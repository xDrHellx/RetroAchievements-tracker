using AutoUpdaterDotNET;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using FontFamily = System.Drawing.FontFamily;
using File = System.IO.File;
using System.Globalization;
using Newtonsoft.Json;
using Retro_Achievement_Tracker.Utils;

namespace Retro_Achievement_Tracker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            MaximizeBox = false;
            IsBooting = IsChanging = true;
            CurrentlyViewingIndex = -1;

            AutoUpdate();
            InitializeComponent();
        }

        void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            Settings.Default.check_for_update_on_version = true;
            AutoUpdate();
        }

        void TabControlExtra1_TabIndexChanged(object sender, EventArgs e)
        {
            foreach (TabPage tab in mainTabControl.TabPages)
            {
                if (mainTabControl.SelectedTab.Equals(tab))
                {
                    tab.Show();
                }
                else
                {
                    tab.Hide();
                }
            }
        }

        void AutoUpdate()
        {
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.ReportErrors = false;
            AutoUpdater.Synchronous = true;
            AutoUpdater.Start(Constants.GITHUB_AUTO_UPDATE_URL);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UserAndGameUpdateTimer = new Timer
            {
                Enabled = false
            };

            UserAndGameUpdateTimer.Tick += new EventHandler(UpdateFromSite);
            UserAndGameUpdateTimer.Interval = 500;

            mainTabControl.TabIndexChanged += TabControlExtra1_TabIndexChanged;
            checkForUpdatesButton.Click += CheckForUpdatesButton_Click;

            LoadProperties();
            CreateFolders();

            if (CanStart() && autoStartCheckbox.Checked)
            {
                StartButton_Click(null, null);
            }
            else if (!CanStart())
            {
                StopButton_Click(null, null);
            }

            IsChanging = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            Username = usernameTextBox.Text;
            WebAPIKey = apiKeyTextBox.Text;

            Settings.Default.Save();

            StreamLabelController.Instance.ClearAllStreamLabels();
            FocusController.Instance.Close();
            UserInfoController.Instance.Close();
            AlertsController.Instance.Close();
            GameInfoController.Instance.Close();
            RecentUnlocksController.Instance.Close();
            AchievementListController.Instance.Close();
            RelatedMediaController.Instance.Close();
        }

        void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args == null)
            {
                MessageBox.Show(@"There is a problem reaching update server please check your internet connection and try again later.", @"Update check failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (args.IsUpdateAvailable && (Settings.Default.check_for_update_on_version || (!Settings.Default.check_for_update_version.Equals(args.CurrentVersion) && Settings.Default.check_for_update_on_version)))
            {
                Settings.Default.check_for_update_version = args.CurrentVersion;

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Old version: " + args.InstalledVersion + "\nNew version: " + args.CurrentVersion, "New Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                            Close();
                    }
                    else
                    {
                        Settings.Default.check_for_update_on_version = false;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Settings.Default.Save();
            }
        }

        async void UpdateFromSite(object sender, EventArgs e)
        {
            if (!ShouldRun)
            {
                UserAndGameUpdateTimer.Stop();
                return;
            }

            if (UserSummary != null && GameInfoAndProgress != null && IsBooting)
            {
                if (FocusController.Instance.AutoLaunch && !FocusController.Instance.IsOpen)
                    FocusController.Instance.Show();
                else if (AlertsController.Instance.AutoLaunch && !AlertsController.Instance.IsOpen)
                    AlertsController.Instance.Show();
                else if (UserInfoController.Instance.AutoLaunch && !UserInfoController.Instance.IsOpen)
                    UserInfoController.Instance.Show();
                else if (GameInfoController.Instance.AutoLaunch && !GameInfoController.Instance.IsOpen)
                    GameInfoController.Instance.Show();
                else if (GameProgressController.Instance.AutoLaunch && !GameProgressController.Instance.IsOpen)
                    GameProgressController.Instance.Show();
                else if (RecentUnlocksController.Instance.AutoLaunch && !RecentUnlocksController.Instance.IsOpen)
                    RecentUnlocksController.Instance.Show();
                else if (AchievementListController.Instance.AutoLaunch && !AchievementListController.Instance.IsOpen)
                    AchievementListController.Instance.Show();
                else if (RelatedMediaController.Instance.AutoLaunch && !RelatedMediaController.Instance.IsOpen)
                    RelatedMediaController.Instance.Show();
                else if (AlertsController.Instance.AutoLaunch && !AlertsController.Instance.IsOpen)
                    AlertsController.Instance.Show();
                else
                    IsBooting = false;
            }

            UserAndGameTimerCounter--;

            UpdateActivePollingLabel(string.Format(Constants.RETRO_ACHIEVEMENTS_LABEL_MSG_COUNTDOWN, UserAndGameTimerCounter / 2));

            try
            {
                if (UserAndGameTimerCounter > 0)
                {
                    return;
                }

                UserAndGameUpdateTimer.Stop();

                if (UserSummary == null)
                {
                    UpdateActivePollingLabel(Constants.RETRO_ACHIEVEMENTS_LABEL_MSG_UPDATING_USER_INFO);
                    UserSummary = await RetroAchievementsAPIClient.GetUserSummary();
                    UpdateUserInfo();
                }

                if (UserSummary == null || UserSummary.LastGameID < 1)
                {
                    return;
                }

                List<GameInfo> previouslyPlayed = await RetroAchievementsAPIClient.GetRecentlyPlayedGames();
                if (previouslyPlayed.Count > 0)
                {
                    List<Achievement> recentlyUnlockedAchievements = await RetroAchievementsAPIClient.GetRecentAchievements();

                    if (GameInfoAndProgress == null || !previouslyPlayed[0].Id.Equals(GameInfoAndProgress.Id) || recentlyUnlockedAchievements.Count(x => LockedAchievements.Contains(x)) > 0)
                    {
                        bool sameGame = GameInfoAndProgress != null && previouslyPlayed[0].Id.Equals(GameInfoAndProgress.Id);

                        UpdateActivePollingLabel(Constants.RETRO_ACHIEVEMENTS_LABEL_MSG_UPDATING_GAME_INFO);
                        GameInfoAndProgress = await RetroAchievementsAPIClient.GetGameInfoAndProgress(previouslyPlayed[0].Id);

                        if (UpdateGameProgress(sameGame))
                        {
                            UserRankAndScore userRankAndScore = await RetroAchievementsAPIClient.GetRankAndScore();

                            UserSummary.Rank = userRankAndScore.Rank;
                            UserSummary.TotalPoints = userRankAndScore.Score;

                            UpdateUserInfo();
                        }
                    }

                    if (GameInfoAndProgress == null)
                    {
                        ShouldRun = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("RA backend"))
                {
                    ShouldRun = IsBooting = false;

                    UpdateActivePollingLabel("API_GetGameInfoAndUserProgress is down.");

                    if (PreviouslyPlayedGameId != 0)
                        ManualSearchButton_Click(null, null);
                }
            }

            if (ShouldRun)
            {
                StartTimer();
            }
            else
            {
                StopButton_Click(null, null);
            }
        }

        bool UpdateGameProgress(bool sameGame)
        {
            bool needsUpdate = !sameGame,
                triggeredUpdate = false;

            try
            {
                PreviouslyPlayedGameId = GameInfoAndProgress.Id;

                GameInfoAndProgress.Achievements?.ForEach(achievement =>
                    {
                        achievement.GameId = (int)GameInfoAndProgress.Id;
                        achievement.GameTitle = GameInfoAndProgress.Title;
                    });

                if (sameGame)
                {
                    List<Achievement> achievementNotificationList = UnlockedAchievements
                        .FindAll(unlockedAchievement => !OldUnlockedAchievements.Contains(unlockedAchievement))
                        .ToList();

                    achievementNotificationList.ForEach((achievement) => StreamLabelController.Instance.EnqueueAlert(achievement));

                    if (achievementNotificationList.Count > 0 && UnlockedAchievements.Count > MaxCheevoCount)
                    {
                        MaxCheevoCount = UnlockedAchievements.Count;

                        UpdateActivePollingLabel(Constants.RETRO_ACHIEVEMENTS_LABEL_MSG_CHEEVO_POP);

                        achievementNotificationList.Sort();

                        if (AlertsController.Instance.AchievementAlertEnable)
                        {
                            triggeredUpdate = true;
                            AlertsController.Instance.EnqueueAchievementNotifications(achievementNotificationList);
                        }

                        if (achievementNotificationList.Contains(FocusController.Instance.CurrentlyFocusedAchievement) || achievementNotificationList.Contains(CurrentlyViewingAchievement))
                            if (LockedAchievements.Count > 0)
                                FindNewFocus();

                        if (AlertsController.Instance.MasteryAlertEnable && UnlockedAchievements.Count == GameInfoAndProgress.Achievements.Count && OldUnlockedAchievements.Count < GameInfoAndProgress.Achievements.Count)
                        {
                            AlertsController.Instance.EnqueueMasteryNotification(GameInfoAndProgress);
                            StreamLabelController.Instance.EnqueueAlert(GameInfoAndProgress);
                        }

                        needsUpdate = true;
                    }
                }
                else
                {
                    UpdateActivePollingLabel(string.Format(Constants.RETRO_ACHIEVEMENTS_LABEL_MSG_CHANGING_TITLE, GameInfoAndProgress.Title));

                    MaxCheevoCount = UnlockedAchievements.Count;

                    CurrentlyViewingAchievement = null;
                    CurrentlyViewingIndex = -1;

                    UpdateLaunchBoxReferences();

                    StreamLabelController.Instance.ClearAllStreamLabels();
                    RelatedMediaController.Instance.SetAllSettings(false);

                    triggeredUpdate = true;
                }

                if (GameInfoAndProgress.Achievements != null && GameInfoAndProgress.Achievements.Count > 0 && needsUpdate)
                {
                    UpdateGameInfo();
                    UpdateCurrentlyViewingAchievement();

                    SetFocus();

                    AchievementListController.Instance.UpdateAchievementList(UnlockedAchievements.ToList(), LockedAchievements.ToList(), !sameGame);
                    RecentUnlocksController.Instance.SetAchievements(UnlockedAchievements.ToList());
                    StreamLabelController.Instance.EnqueueRecentUnlocks(UnlockedAchievements.ToList());
                    StreamLabelController.Instance.RunNotifications();
                }

                OldUnlockedAchievements = UnlockedAchievements.ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return triggeredUpdate;
        }

        void FindNewFocus()
        {
            int currentIndex = GameInfoAndProgress.Achievements.IndexOf(FocusController.Instance.CurrentlyFocusedAchievement);

            switch (FocusController.Instance.RefocusBehavior)
            {
                case RefocusBehaviorEnum.GO_TO_FIRST:
                    currentIndex = -1;
                    break;
                case RefocusBehaviorEnum.GO_TO_PREVIOUS:
                    while (currentIndex > 0 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[currentIndex]))
                        currentIndex--;

                    if (currentIndex == 0)
                        while (currentIndex < GameInfoAndProgress.Achievements.Count - 1 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[currentIndex]))
                            currentIndex++;

                    break;
                case RefocusBehaviorEnum.GO_TO_NEXT:
                    while (currentIndex < GameInfoAndProgress.Achievements.Count - 1 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[currentIndex]))
                    {
                        currentIndex++;
                    }
                    if (currentIndex == GameInfoAndProgress.Achievements.Count - 1)
                    {
                        while (currentIndex > 0 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[currentIndex]))
                        {
                            currentIndex--;
                        }
                    }
                    break;
                case RefocusBehaviorEnum.GO_TO_LAST:
                    currentIndex = GameInfoAndProgress.Achievements.Count;
                    break;
            }

            CurrentlyViewingIndex = currentIndex;
        }
        public void UpdateCurrentlyViewingAchievement()
        {
            if (!Visible)
            {
                return;
            }

            if (LockedAchievements.Count > 0)
            {
                if (CurrentlyViewingIndex >= GameInfoAndProgress.Achievements.Count)
                {
                    CurrentlyViewingIndex = GameInfoAndProgress.Achievements.Count - 1;
                    while (CurrentlyViewingIndex > 0 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[CurrentlyViewingIndex]))
                    {
                        CurrentlyViewingIndex--;
                    }

                }
                else if (CurrentlyViewingIndex < 0)
                {
                    CurrentlyViewingIndex = 0;
                    while (CurrentlyViewingIndex < GameInfoAndProgress.Achievements.Count - 1 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[CurrentlyViewingIndex]))
                    {
                        CurrentlyViewingIndex++;
                    }
                }

                CurrentlyViewingAchievement = GameInfoAndProgress.Achievements[CurrentlyViewingIndex];

                focusTabPage.focusAchievementPictureBox.ImageLocation = CurrentlyViewingAchievement.BadgeUri;
                focusTabPage.focusAchievementTitleLabel.Text = "[" + CurrentlyViewingAchievement.Points + "] - " + CurrentlyViewingAchievement.Title;
                focusTabPage.focusAchievementDescriptionLabel.Text = CurrentlyViewingAchievement.Description;
            }
            else
            {
                CurrentlyViewingIndex = -1;
                CurrentlyViewingAchievement = null;
                focusTabPage.focusAchievementPictureBox.ImageLocation = focusTabPage.focusAchievementTitleLabel.Text = focusTabPage.focusAchievementDescriptionLabel.Text = "";
            }

            UpdateFocusButtons();
        }
        void SetFocus()
        {
            if (CurrentlyViewingAchievement != null)
            {
                if (FocusController.Instance.GetCurrentlyFocusedAchievement() == null || FocusController.Instance.GetCurrentlyFocusedAchievement().Id != CurrentlyViewingAchievement.Id)
                {
                    FocusController.Instance.SetFocus(CurrentlyViewingAchievement);
                    StreamLabelController.Instance.EnqueueFocus(CurrentlyViewingAchievement);
                }
            }
            else if (LockedAchievements.Count == 0 && UnlockedAchievements.Count > 0)
            {
                FocusController.Instance.SetFocus((Achievement)null);
                FocusController.Instance.SetFocus(GameInfoAndProgress);
                StreamLabelController.Instance.ClearFocus();
            }
            else
            {
                StreamLabelController.Instance.ClearFocus();
            }
        }
        void CreateFolders()
        {
            Directory.CreateDirectory(@"stream-labels");
            Directory.CreateDirectory(@"stream-labels\user-info");
            Directory.CreateDirectory(@"stream-labels\game-info");
            Directory.CreateDirectory(@"stream-labels\last-five");
            Directory.CreateDirectory(@"stream-labels\focus");
            Directory.CreateDirectory(@"stream-labels\alerts");
            Directory.CreateDirectory(@"game-progress");
        }

        /// <summary>Indicate if the Tracker can start</summary>
        /// <returns><c>bool</c></returns>
        bool CanStart()
        {
            return !(string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(apiKeyTextBox.Text));
        }

        void UpdateActivePollingLabel(string s)
        {
            autoPollingStatusLabel.Text = s;
        }

        void StartTimer()
        {
            UserAndGameTimerCounter = (IsStarting || IsBooting) ? 0 : 60;
            UserAndGameUpdateTimer = new Timer
            {
                Interval = 500,
                Enabled = false
            };

            UserAndGameUpdateTimer.Tick += new EventHandler(UpdateFromSite);
            UserAndGameUpdateTimer.Start();
        }
        void UpdateUserInfo()
        {
            autoPollingStatusPictureBox.Image = Resources.green_button;
            userProfilePictureBox.ImageLocation = string.Format(Constants.RETRO_ACHIEVEMENTS_PROFILE_PIC_URL, UserSummary.UserName);

            userInfoTabPage.userInfoUsernameLabel.Text = UserSummary.UserName;
            userInfoTabPage.userInfoMottoLabel.Text = UserSummary.Motto;
            userInfoTabPage.userInfoRankLabel.Text = "Site Rank: " + (UserSummary.Rank == 0 ? "No Rank" : UserSummary.Rank.ToString());
            userInfoTabPage.userInfoPointsLabel.Text = "Hardcore Points: " + UserSummary.TotalPoints.ToString() + " points";
            userInfoTabPage.userInfoTruePointsLabel.Text = "(" + UserSummary.TotalTruePoints.ToString() + ")";
            userInfoTabPage.userInfoRatioLabel.Text = UserSummary.RetroRatio;

            UserInfoController.Instance.SetRank(UserSummary.Rank == 0 ? "No Rank" : UserSummary.Rank.ToString());
            UserInfoController.Instance.SetPoints(UserSummary.TotalPoints.ToString());
            UserInfoController.Instance.SetTruePoints(UserSummary.TotalTruePoints.ToString());
            UserInfoController.Instance.SetRatio(UserSummary.RetroRatio);
            StreamLabelController.Instance.EnqueueUserInfo(UserSummary);
        }
        void UpdateGameInfo()
        {
            gameInfoTabPage.gameInfoPictureBox.ImageLocation = GameInfoAndProgress.BadgeUri;
            gameInfoTabPage.gameInfoTitleLabel.Text = GameInfoAndProgress.Title + " (" + GameInfoAndProgress.ConsoleName + ")";
            gameInfoTabPage.gameInfoDeveloperLabel.Text = GameInfoAndProgress.Developer;
            gameInfoTabPage.gameInfoPublisherLabel.Text = GameInfoAndProgress.Publisher;
            gameInfoTabPage.gameInfoGenreLabel.Text = GameInfoAndProgress.Genre;
            gameInfoTabPage.gameInfoReleasedLabel.Text = GameInfoAndProgress.Released;

            GameInfoController.Instance.SetTitleValue(GameInfoAndProgress.Title);
            GameInfoController.Instance.SetDeveloperValue(GameInfoAndProgress.Developer);
            GameInfoController.Instance.SetPublisherValue(GameInfoAndProgress.Publisher);
            GameInfoController.Instance.SetGenreValue(GameInfoAndProgress.Genre);
            GameInfoController.Instance.SetConsoleValue(GameInfoAndProgress.ConsoleName);
            GameInfoController.Instance.SetReleaseDateValue(GameInfoAndProgress.Released);

            GameProgressController.Instance.SetGameAchievements(GameInfoAndProgress.AchievementsEarned.ToString(), GameInfoAndProgress.Achievements == null ? "0" : GameInfoAndProgress.Achievements.Count.ToString());
            GameProgressController.Instance.SetGamePoints(GameInfoAndProgress.GamePointsEarned.ToString(), GameInfoAndProgress.GamePointsPossible.ToString());
            GameProgressController.Instance.SetGameTruePoints(GameInfoAndProgress.GameTruePointsEarned.ToString(), GameInfoAndProgress.GameTruePointsPossible.ToString());
            GameProgressController.Instance.SetCompleted(GameInfoAndProgress.Achievements == null ? 0.00f : GameInfoAndProgress.AchievementsEarned / (float)GameInfoAndProgress.Achievements.Count * 100f);
            GameProgressController.Instance.SetGameRatio();

            StreamLabelController.Instance.EnqueueGameProgress(GameInfoAndProgress);
            StreamLabelController.Instance.EnqueueGameInfo(GameInfoAndProgress);

            int percentageCompleted = (int)float.Parse(GameInfoAndProgress.PercentComplete);

            gameProgressTabPage.gameProgressAchievements1Label.Text = GameInfoAndProgress.AchievementsPossible.ToString();
            gameProgressTabPage.gameProgressPoints1Label.Text = GameInfoAndProgress.GamePointsPossible.ToString();
            gameProgressTabPage.gameProgressTruePoints1Label.Text = "(" + GameInfoAndProgress.GameTruePointsPossible.ToString() + ")";
            gameProgressTabPage.gameProgressPercentCompletePictureBox.Size = new Size((int)(1.82 * percentageCompleted), 2);
            gameProgressTabPage.gameProgressCompletedLabel.Text = percentageCompleted + "% complete";

            if (0 == percentageCompleted)
            {
                gameProgressTabPage.gameProgressMasteryPictureBox.Hide();
                gameProgressTabPage.gameProgressHaveEarnedLabel.Text = "You have not earned any achievements for this game.";

                gameProgressTabPage.gameProgressAchievements2Label.Hide();
                gameProgressTabPage.gameProgressHardcoreWorthLabel.Hide();
                gameProgressTabPage.gameProgressPoints2Label.Hide();
                gameProgressTabPage.gameProgressTruePoints2Label.Hide();
                gameProgressTabPage.gameProgressPointsTextLabel.Hide();
            }
            else
            {
                if (percentageCompleted == 100)
                {
                    gameProgressTabPage.gameProgressMasteryPictureBox.Show();
                    gameProgressTabPage.gameProgressCompletedLabel.Text = "Mastered";
                }

                gameProgressTabPage.gameProgressHaveEarnedLabel.Text = "You have earned";

                gameProgressTabPage.gameProgressAchievements2Label.Show();
                gameProgressTabPage.gameProgressHardcoreWorthLabel.Show();
                gameProgressTabPage.gameProgressPoints2Label.Show();
                gameProgressTabPage.gameProgressTruePoints2Label.Show();
                gameProgressTabPage.gameProgressPointsTextLabel.Show();

                gameProgressTabPage.gameProgressAchievements2Label.Text = GameInfoAndProgress.AchievementsEarned.ToString();
                gameProgressTabPage.gameProgressPoints2Label.Text = GameInfoAndProgress.GamePointsEarned.ToString();
                gameProgressTabPage.gameProgressTruePoints2Label.Text = "(" + GameInfoAndProgress.GameTruePointsEarned.ToString() + ")";
            }

            Dictionary<int, DateTime> achievementUnlocks = new Dictionary<int, DateTime>();

            GameInfoAndProgress.Achievements
                .FindAll(x => x.DateEarned.HasValue)
                .ForEach(x => achievementUnlocks.Add(x.Id, x.DateEarned.Value));

            File.WriteAllText(@Directory.GetCurrentDirectory() + "/game-progress/" + GameInfoAndProgress.Id + ".json", JsonConvert.SerializeObject(achievementUnlocks));

            RelatedMediaController.Instance.RABadgeIconURI = GameInfoAndProgress.BadgeUri;
            RelatedMediaController.Instance.RATitleScreenURI = GameInfoAndProgress.ImageTitle;
            RelatedMediaController.Instance.RAScreenshotURI = GameInfoAndProgress.ImageIngame;
            RelatedMediaController.Instance.RABoxArtURI = GameInfoAndProgress.ImageBoxArt;
            RelatedMediaController.Instance.UpdateImage(false);
        }
        void UpdateFocusButtons()
        {
            if (LockedAchievements.Count == 0)
            {
                focusTabPage.focusAchievementButtonPrevious.Enabled = false;
                focusTabPage.focusAchievementButtonNext.Enabled = false;
                focusTabPage.focusSetButton.Enabled = false;
            }
            else
            {
                focusTabPage.focusSetButton.Enabled = true;

                if (LockedAchievements.IndexOf(CurrentlyViewingAchievement) == 0)
                {
                    focusTabPage.focusAchievementButtonPrevious.Enabled = false;
                    focusTabPage.focusAchievementButtonNext.Enabled = LockedAchievements.Count > 1;
                }
                else if (LockedAchievements.IndexOf(CurrentlyViewingAchievement) == LockedAchievements.Count - 1)
                {
                    focusTabPage.focusAchievementButtonPrevious.Enabled = true;
                    focusTabPage.focusAchievementButtonNext.Enabled = false;
                }
                else
                {
                    focusTabPage.focusAchievementButtonPrevious.Enabled = true;
                    focusTabPage.focusAchievementButtonNext.Enabled = true;
                }
            }
        }
        void StartButton_Click(object sender, EventArgs e)
        {
            IsStarting = true;

            RetroAchievementsAPIClient = new RetroAchievementAPIClient(usernameTextBox.Text, apiKeyTextBox.Text);

            startButton.Enabled = false;
            usernameTextBox.Enabled = false;
            apiKeyTextBox.Enabled = false;

            ShouldRun = true;
            stopButton.Enabled = true;
            focusTabPage.focusOpenWindowButton.Enabled = true;
            alertsTabPage.alertsOpenWindowButton.Enabled = true;
            userInfoTabPage.userInfoOpenWindowButton.Enabled = true;
            gameInfoTabPage.gameInfoOpenWindowButton.Enabled = true;
            relatedMediaTabPage.relatedMediaOpenWindowButton.Enabled = true;
            achievementsListTabPage.achievementListOpenWindowButton.Enabled = true;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Enabled = true;

            StartTimer();

            IsStarting = false;
        }
        void StopButton_Click(object sender, EventArgs e)
        {
            ShouldRun = false;

            UserAndGameUpdateTimer.Stop();

            autoPollingStatusPictureBox.Image = Resources.red_button;

            stopButton.Enabled = false;

            bool canStart = CanStart();

            focusTabPage.focusOpenWindowButton.Enabled = canStart;
            alertsTabPage.alertsOpenWindowButton.Enabled = canStart;
            userInfoTabPage.userInfoOpenWindowButton.Enabled = canStart;
            gameInfoTabPage.gameInfoOpenWindowButton.Enabled = canStart;
            relatedMediaTabPage.relatedMediaOpenWindowButton.Enabled = canStart;
            achievementsListTabPage.achievementListOpenWindowButton.Enabled = canStart;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Enabled = canStart;

            apiKeyTextBox.Enabled = true;
            usernameTextBox.Enabled = true;

            startButton.Enabled = canStart;

            IsBooting = IsChanging = false;
        }
        void RequiredField_TextChanged(object sender, EventArgs e)
        {
            startButton.Enabled = CanStart();
        }
        void ManualSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        async void ManualSearchButton_Click(object sender, EventArgs e)
        {
            if (!ShouldRun && !UserAndGameUpdateTimer.Enabled && manualSearchTextBox.Text.Length > 0)
            {
                RetroAchievementsAPIClient = new RetroAchievementAPIClient(usernameTextBox.Text, apiKeyTextBox.Text);

                GameInfoAndProgress = await RetroAchievementsAPIClient.GetGameInfoExtended(long.Parse(manualSearchTextBox.Text));

                autoPollingStatusPictureBox.Image = Resources.green_button;
                userProfilePictureBox.ImageLocation = string.Format(Constants.RETRO_ACHIEVEMENTS_PROFILE_PIC_URL, usernameTextBox.Text);

                if (File.Exists(@Directory.GetCurrentDirectory() + "/game-progress/" + GameInfoAndProgress.Id + ".json"))
                {
                    Dictionary<int, DateTime> completedIds = JsonConvert.DeserializeObject<Dictionary<int, DateTime>>(File.ReadAllText(@Directory.GetCurrentDirectory() + "/game-progress/" + GameInfoAndProgress.Id + ".json"));

                    GameInfoAndProgress.Achievements
                        .FindAll(x => completedIds.Keys.Contains(x.Id))
                        .ForEach(x => x.DateEarned = completedIds[x.Id]);
                }

                if (FocusController.Instance.AutoLaunch && !FocusController.Instance.IsOpen)
                    FocusController.Instance.Show();

                if (AlertsController.Instance.AutoLaunch && !AlertsController.Instance.IsOpen)
                    AlertsController.Instance.Show();

                if (UserInfoController.Instance.AutoLaunch && !UserInfoController.Instance.IsOpen)
                    UserInfoController.Instance.Show();

                if (GameInfoController.Instance.AutoLaunch && !GameInfoController.Instance.IsOpen)
                    GameInfoController.Instance.Show();

                if (GameProgressController.Instance.AutoLaunch && !GameProgressController.Instance.IsOpen)
                    GameProgressController.Instance.Show();

                if (RecentUnlocksController.Instance.AutoLaunch && !RecentUnlocksController.Instance.IsOpen)
                    RecentUnlocksController.Instance.Show();

                if (AchievementListController.Instance.AutoLaunch && !AchievementListController.Instance.IsOpen)
                    AchievementListController.Instance.Show();

                if (RelatedMediaController.Instance.AutoLaunch && !RelatedMediaController.Instance.IsOpen)
                    RelatedMediaController.Instance.Show();

                if (AlertsController.Instance.AutoLaunch && !AlertsController.Instance.IsOpen)
                    AlertsController.Instance.Show();

                UpdateGameProgress(false);
            }
        }
        void UnlockAchievementButton_Click(object sender, EventArgs e)
        {
            CurrentlyViewingAchievement.DateEarned = DateTime.Now;
            UpdateGameProgress(true);
        }
        void CustomAlertsCheckBox_CheckedChanged(object sender, EventArgs eventArgs)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            CheckBox checkBox = sender as CheckBox;
            bool isChecked = checkBox.Checked;

            switch (checkBox.Name)
            {
                case "alertsAchievementEnableCheckbox":
                    AlertsController.Instance.AchievementAlertEnable = isChecked;
                    break;
                case "alertsMasteryEnableCheckbox":
                    AlertsController.Instance.MasteryAlertEnable = isChecked;
                    break;
                case "alertsCustomAchievementEnableCheckbox":
                    if (isChecked)
                        if (!File.Exists(AlertsController.Instance.CustomAchievementFile))
                            SelectCustomAchievementFile();

                    AlertsController.Instance.CustomAchievementEnabled = isChecked;
                    break;
                case "alertsCustomMasteryEnableCheckbox":
                    if (isChecked)
                        if (!File.Exists(AlertsController.Instance.CustomMasteryFile))
                            SelectCustomMasteryFile();

                    AlertsController.Instance.CustomMasteryEnabled = isChecked;
                    break;
                case "alertsAchievementEditOutlineCheckbox":
                    if (checkBox.Checked)
                    {
                        AlertsController.Instance.EnableAchievementEdit();
                        AlertsController.Instance.SendAchievementNotification(new Achievement()
                        {
                            Title = "Thrilling!!!!",
                            Description = "Color every bit of Dinosaur 2. [Must color white if leaving white]",
                            BadgeUri = "https://retroachievements.org/Badge/49987.png",
                            Points = 1
                        });
                    }
                    else
                        AlertsController.Instance.DisableAchievementEdit();
                    break;
                case "alertsMasteryEditOutlineCheckbox":
                    if (checkBox.Checked)
                    {
                        AlertsController.Instance.EnableMasteryEdit();
                        AlertsController.Instance.SendMasteryNotification(GameInfoAndProgress);
                    }
                    else
                    {
                        AlertsController.Instance.DisableMasteryEdit();
                    }
                    break;
            }

            UpdateAlertsEnabledControls();
            IsChanging = false;
        }
        void UpdateAlertsEnabledControls()
        {
            alertsTabPage.alertsAchievementEnableCheckbox.Checked = AlertsController.Instance.AchievementAlertEnable;
            alertsTabPage.alertsMasteryEnableCheckbox.Checked = AlertsController.Instance.MasteryAlertEnable;

            alertsTabPage.alertsCustomAchievementEnableCheckbox.Checked = AlertsController.Instance.CustomAchievementEnabled;
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Checked = AlertsController.Instance.CustomMasteryEnabled;

            if (AlertsController.Instance.AchievementAlertEnable)
            {
                alertsTabPage.alertsPlayAchievementButton.Enabled = true;
                alertsTabPage.alertsCustomAchievementEnableCheckbox.Enabled = true;

                if (AlertsController.Instance.CustomAchievementEnabled)
                {
                    alertsTabPage.alertsCustomAchievementPanel.Enabled = true;
                    alertsTabPage.alertsSelectCustomAchievementFileButton.Enabled = true;
                    alertsTabPage.alertsAchievementEditOutlineCheckbox.Enabled = true;
                }
                else
                {
                    alertsTabPage.alertsCustomAchievementPanel.Enabled = false;
                    alertsTabPage.alertsSelectCustomAchievementFileButton.Enabled = false;
                    alertsTabPage.alertsAchievementEditOutlineCheckbox.Enabled = false;
                }
            }
            else
            {
                alertsTabPage.alertsCustomAchievementPanel.Enabled = false;
                alertsTabPage.alertsSelectCustomAchievementFileButton.Enabled = false;
                alertsTabPage.alertsPlayAchievementButton.Enabled = false;
                alertsTabPage.alertsCustomAchievementEnableCheckbox.Enabled = false;
                alertsTabPage.alertsAchievementEditOutlineCheckbox.Enabled = false;
            }

            if (AlertsController.Instance.MasteryAlertEnable)
            {
                alertsTabPage.alertsPlayMasteryButton.Enabled = true;
                alertsTabPage.alertsCustomMasteryEnableCheckbox.Enabled = true;

                if (AlertsController.Instance.CustomMasteryEnabled)
                {
                    alertsTabPage.alertsCustomMasteryPanel.Enabled = true;
                    alertsTabPage.alertsSelectCustomMasteryFileButton.Enabled = true;
                    alertsTabPage.alertsMasteryEditOutlineCheckbox.Enabled = true;
                }
                else
                {
                    alertsTabPage.alertsCustomMasteryPanel.Enabled = false;
                    alertsTabPage.alertsSelectCustomMasteryFileButton.Enabled = false;
                    alertsTabPage.alertsMasteryEditOutlineCheckbox.Enabled = false;
                }
            }
            else
            {
                alertsTabPage.alertsCustomMasteryPanel.Enabled = false;
                alertsTabPage.alertsSelectCustomMasteryFileButton.Enabled = false;
                alertsTabPage.alertsPlayMasteryButton.Enabled = false;
                alertsTabPage.alertsCustomMasteryEnableCheckbox.Enabled = false;
                alertsTabPage.alertsMasteryEditOutlineCheckbox.Enabled = false;
            }
        }
        void CustomNumericUpDown_ValueChanged(object sender, EventArgs eventArgs)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;
            NumericUpDown numericUpDown = sender as NumericUpDown;
            switch (numericUpDown.Name)
            {
                case "focusTitleFontOutlineNumericUpDown":
                    if (FocusController.Instance.AdvancedSettingsEnabled)
                    {
                        FocusController.Instance.TitleOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        FocusController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "focusDescriptionFontOutlineNumericUpDown":
                    FocusController.Instance.DescriptionOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "focusPointsFontOutlineNumericUpDown":
                    FocusController.Instance.PointsOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "focusLineOutlineNumericUpDown":
                    FocusController.Instance.LineOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsTitleFontOutlineNumericUpDown":
                    if (AlertsController.Instance.AdvancedSettingsEnabled)
                    {
                        AlertsController.Instance.TitleOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        AlertsController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "alertsDescriptionFontOutlineNumericUpDown":
                    AlertsController.Instance.DescriptionOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsPointsFontOutlineNumericUpDown":
                    AlertsController.Instance.PointsOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsLineOutlineNumericUpDown":
                    AlertsController.Instance.LineOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementXNumericUpDown":
                    AlertsController.Instance.CustomAchievementX = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementYNumericUpDown":
                    AlertsController.Instance.CustomAchievementY = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementScaleNumericUpDown":
                    AlertsController.Instance.CustomAchievementScale = Convert.ToInt32(numericUpDown.Value, CultureInfo.CurrentCulture);
                    break;
                case "alertsCustomAchievementInNumericUpDown":
                    AlertsController.Instance.CustomAchievementInTime = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementInSpeedUpDown":
                    AlertsController.Instance.CustomAchievementInSpeed = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementOutNumericUpDown":
                    AlertsController.Instance.CustomAchievementOutTime = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomAchievementOutSpeedUpDown":
                    AlertsController.Instance.CustomAchievementOutSpeed = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryXNumericUpDown":
                    AlertsController.Instance.CustomMasteryX = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryYNumericUpDown":
                    AlertsController.Instance.CustomMasteryY = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryScaleNumericUpDown":
                    AlertsController.Instance.CustomMasteryScale = Convert.ToInt32(numericUpDown.Value, CultureInfo.CurrentCulture);
                    break;
                case "alertsCustomMasteryInNumericUpDown":
                    AlertsController.Instance.CustomMasteryInTime = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryInSpeedUpDown":
                    AlertsController.Instance.CustomMasteryInSpeed = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryOutNumericUpDown":
                    AlertsController.Instance.CustomMasteryOutTime = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "alertsCustomMasteryOutSpeedUpDown":
                    AlertsController.Instance.CustomMasteryOutSpeed = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "userInfoNamesFontOutlineNumericUpDown":
                    if (UserInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        UserInfoController.Instance.NameOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        UserInfoController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "userInfoValuesFontOutlineNumericUpDown":
                    UserInfoController.Instance.ValueOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "gameInfoNamesFontOutlineNumericUpDown":
                    if (GameInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        GameInfoController.Instance.NameOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        GameInfoController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "gameInfoValuesFontOutlineNumericUpDown":
                    GameInfoController.Instance.ValueOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "gameProgressNamesFontOutlineNumericUpDown":
                    if (GameProgressController.Instance.AdvancedSettingsEnabled)
                    {
                        GameProgressController.Instance.NameOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        GameProgressController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "gameProgressValuesFontOutlineNumericUpDown":
                    GameProgressController.Instance.ValueOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "recentAchievementsTitleFontOutlineNumericUpDown":
                    if (RecentUnlocksController.Instance.AdvancedSettingsEnabled)
                    {
                        RecentUnlocksController.Instance.TitleOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    else
                    {
                        RecentUnlocksController.Instance.SimpleFontOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    }
                    break;
                case "recentAchievementsDescriptionFontOutlineNumericUpDown":
                    RecentUnlocksController.Instance.DescriptionOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "recentAchievementsPointsFontOutlineNumericUpDown":
                    RecentUnlocksController.Instance.PointsOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "recentAchievementsLineOutlineNumericUpDown":
                    RecentUnlocksController.Instance.LineOutlineSize = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "recentAchievementsMaxListNumericUpDown":
                    RecentUnlocksController.Instance.MaxListSize = Convert.ToInt32(numericUpDown.Value);
                    RecentUnlocksController.Instance.SetAchievements(UnlockedAchievements.ToList());
                    break;
                case "achievementListWindowSizeXUpDown":
                    AchievementListController.Instance.WindowSizeX = Convert.ToInt32(numericUpDown.Value);
                    break;
                case "achievementListWindowSizeYUpDown":
                    AchievementListController.Instance.WindowSizeY = Convert.ToInt32(numericUpDown.Value);
                    break;
            }

            IsChanging = false;
        }
        void SelectCustomAlertButton_Click(object sender, EventArgs eventArgs)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "alertsSelectCustomAchievementFileButton":
                    SelectCustomAchievementFile();
                    break;
                case "alertsSelectCustomMasteryFileButton":
                    SelectCustomMasteryFile();
                    break;
            }
        }
        void SelectCustomAchievementFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AlertsController.Instance.CustomAchievementFile = openFileDialog.FileName;
            }
            else if (AlertsController.Instance.CustomAchievementEnabled && (string.IsNullOrEmpty(AlertsController.Instance.CustomAchievementFile) || !File.Exists(AlertsController.Instance.CustomAchievementFile)))
            {
                AlertsController.Instance.CustomAchievementEnabled = false;
                alertsTabPage.alertsCustomAchievementEnableCheckbox.Checked = false;
            }
        }
        void SelectCustomMasteryFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AlertsController.Instance.CustomMasteryFile = openFileDialog.FileName;
            }
            else if (AlertsController.Instance.CustomMasteryEnabled && (string.IsNullOrEmpty(AlertsController.Instance.CustomMasteryFile) || !File.Exists(AlertsController.Instance.CustomMasteryFile)))
            {
                AlertsController.Instance.CustomMasteryEnabled = false;
                alertsTabPage.alertsCustomMasteryEnableCheckbox.Checked = false;
            }
        }
        void ShowAlertButton_Click(object sender, EventArgs eventArgs)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "alertsPlayAchievementButton":
                    List<Achievement> unlockedAchievements = UnlockedAchievements.ToList();
                    if (unlockedAchievements.Count > 0)
                    {
                        unlockedAchievements.Sort();
                        Achievement achievement = (Achievement)unlockedAchievements[unlockedAchievements.Count - 1].Clone();

                        AlertsController.Instance.EnqueueAchievementNotifications(new List<Achievement>() { achievement });
                        StreamLabelController.Instance.EnqueueAlert(achievement);
                    }
                    else
                    {
                        Achievement achievement = new Achievement()
                        {
                            Title = "Thrilling!!!!",
                            Description = "Color every bit of Dinosaur 2. [Must color white if leaving white]",
                            BadgeUri = "https://retroachievements.org/Badge/49987.png",
                            Points = 1
                        };

                        AlertsController.Instance.EnqueueAchievementNotifications(new List<Achievement>() { achievement });
                        StreamLabelController.Instance.EnqueueAlert(achievement);
                    }
                    break;
                case "alertsPlayMasteryButton":
                    AlertsController.Instance.EnqueueMasteryNotification(GameInfoAndProgress);
                    StreamLabelController.Instance.EnqueueAlert(GameInfoAndProgress);
                    break;
            }

            StreamLabelController.Instance.RunNotifications();
        }
        void SetFocusButton_Click(object sender, EventArgs e)
        {
            SetFocus();
            StreamLabelController.Instance.RunNotifications();
        }
        void MoveFocusIndexPrev_Click(object sender, EventArgs e)
        {
            CurrentlyViewingIndex--;
            while (CurrentlyViewingIndex > -1 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[CurrentlyViewingIndex]))
            {
                CurrentlyViewingIndex--;
            }

            UpdateCurrentlyViewingAchievement();
        }
        void MoveFocusIndexNext_Click(object sender, EventArgs e)
        {
            CurrentlyViewingIndex++;
            while (CurrentlyViewingIndex < GameInfoAndProgress.Achievements.Count - 1 && !LockedAchievements.Contains(GameInfoAndProgress.Achievements[CurrentlyViewingIndex]))
            {
                CurrentlyViewingIndex++;
            }

            UpdateCurrentlyViewingAchievement();
        }
        void ShowWindowButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "focusOpenWindowButton":
                    FocusController.Instance.Show();
                    SetFocus();
                    break;
                case "userInfoOpenWindowButton":
                    UserInfoController.Instance.Show();
                    break;
                case "gameProgressOpenWindowButton":
                    GameProgressController.Instance.Show();
                    break;
                case "alertsOpenWindowButton":
                    AlertsController.Instance.Show();
                    break;
                case "gameInfoOpenWindowButton":
                    GameInfoController.Instance.Show();
                    break;
                case "recentAchievementsOpenWindowButton":
                    RecentUnlocksController.Instance.Show();
                    break;
                case "achievementListOpenWindowButton":
                    AchievementListController.Instance.Show();
                    AchievementListController.Instance.UpdateAchievementList(UnlockedAchievements.ToList(), LockedAchievements.ToList(), true);
                    break;
                case "relatedMediaOpenWindowButton":
                    RelatedMediaController.Instance.Show();
                    RelatedMediaController.Instance.SetAllSettings(true);
                    break;
            }
        }
        void SetRelatedMediaPathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                RelatedMediaController.Instance.LaunchBoxFilePath = folderBrowserDialog.SelectedPath;
                UpdateRelatedMediaRadioButtons();
                UpdateLaunchBoxReferences();
            }
        }
        void SetFontFamilyBox(ComboBox comboBox, FontFamily fontFamily)
        {
            comboBox.Items.Clear();

            FontFamily[] familyArray = FontFamily.Families.ToArray();
            foreach (FontFamily fontFamilyEntity in familyArray)
            {
                comboBox.Items.Add(fontFamilyEntity.Name);
            }

            comboBox.SelectedIndex = Array.FindIndex(familyArray, row => row.Name == fontFamily.Name);
        }
        void FontColorPictureBox_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            PictureBox pictureBox = sender as PictureBox;
            switch (pictureBox.Name)
            {
                case "focusBackgroundColorPictureBox":
                    FocusController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusBorderColorPictureBox":
                    FocusController.Instance.BorderBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusBorderColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusTitleFontColorPictureBox":
                    if (FocusController.Instance.AdvancedSettingsEnabled)
                    {
                        FocusController.Instance.TitleColor = MediaHelper.HexConverter(colorDialog.Color); ;
                    }
                    else
                    {
                        FocusController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color); ;
                    }
                    focusTabPage.focusTitleFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusDescriptionFontColorPictureBox":
                    FocusController.Instance.DescriptionColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusDescriptionFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusPointsFontColorPictureBox":
                    FocusController.Instance.PointsColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusPointsFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusLineColorPictureBox":
                    FocusController.Instance.LineColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusLineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusTitleFontOutlineColorPictureBox":
                    if (FocusController.Instance.AdvancedSettingsEnabled)
                    {
                        FocusController.Instance.TitleOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        FocusController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    focusTabPage.focusTitleFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusDescriptionFontOutlineColorPictureBox":
                    FocusController.Instance.DescriptionOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusDescriptionFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusPointsFontOutlineColorPictureBox":
                    FocusController.Instance.PointsOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusPointsFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "focusLineOutlineColorPictureBox":
                    FocusController.Instance.LineOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    focusTabPage.focusLineOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsBackgroundColorPictureBox":
                    AlertsController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsBorderColorPictureBox":
                    AlertsController.Instance.BorderBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsBorderColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsTitleFontColorPictureBox":
                    if (AlertsController.Instance.AdvancedSettingsEnabled)
                    {
                        AlertsController.Instance.TitleColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        AlertsController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    alertsTabPage.alertsTitleFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsDescriptionFontColorPictureBox":
                    AlertsController.Instance.DescriptionColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsDescriptionFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsPointsFontColorPictureBox":
                    AlertsController.Instance.PointsColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsPointsFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsLineColorPictureBox":
                    AlertsController.Instance.LineColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsLineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsTitleFontOutlineColorPictureBox":
                    if (AlertsController.Instance.AdvancedSettingsEnabled)
                    {
                        AlertsController.Instance.TitleOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        AlertsController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    alertsTabPage.alertsTitleFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsDescriptionFontOutlineColorPictureBox":
                    AlertsController.Instance.DescriptionOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsPointsFontOutlineColorPictureBox":
                    AlertsController.Instance.PointsOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsPointsFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "alertsLineOutlineColorPictureBox":
                    AlertsController.Instance.LineOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    alertsTabPage.alertsLineOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "userInfoBackgroundColorPictureBox":
                    UserInfoController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    userInfoTabPage.userInfoBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "userInfoNamesFontColorPictureBox":
                    if (UserInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        UserInfoController.Instance.NameColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        UserInfoController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    userInfoTabPage.userInfoNamesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "userInfoValuesFontColorPictureBox":
                    UserInfoController.Instance.ValueColor = MediaHelper.HexConverter(colorDialog.Color);
                    userInfoTabPage.userInfoValuesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "userInfoNamesFontOutlineColorPictureBox":
                    if (UserInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        UserInfoController.Instance.NameOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        UserInfoController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "userInfoValuesFontOutlineColorPictureBox":
                    UserInfoController.Instance.ValueOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameInfoBackgroundColorPictureBox":
                    GameInfoController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameInfoTabPage.gameInfoBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameInfoNamesFontColorPictureBox":
                    if (GameInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        GameInfoController.Instance.NameColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        GameInfoController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    gameInfoTabPage.gameInfoNamesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameInfoValuesFontColorPictureBox":
                    GameInfoController.Instance.ValueColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameInfoTabPage.gameInfoValuesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameInfoNamesFontOutlineColorPictureBox":
                    if (GameInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        GameInfoController.Instance.NameOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        GameInfoController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameInfoValuesFontOutlineColorPictureBox":
                    GameInfoController.Instance.ValueOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameProgressBackgroundColorPictureBox":
                    GameProgressController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameProgressTabPage.gameProgressBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameProgressNamesFontColorPictureBox":
                    if (GameProgressController.Instance.AdvancedSettingsEnabled)
                    {
                        GameProgressController.Instance.NameColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        GameProgressController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    gameProgressTabPage.gameProgressNamesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameProgressValuesFontColorPictureBox":
                    GameProgressController.Instance.ValueColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameProgressTabPage.gameProgressValuesFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameProgressNamesFontOutlineColorPictureBox":
                    if (GameProgressController.Instance.AdvancedSettingsEnabled)
                    {
                        GameProgressController.Instance.NameOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        GameProgressController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "gameProgressValuesFontOutlineColorPictureBox":
                    GameProgressController.Instance.ValueOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsBackgroundColorPictureBox":
                    RecentUnlocksController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsBorderColorPictureBox":
                    RecentUnlocksController.Instance.BorderBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsTitleFontColorPictureBox":
                    if (RecentUnlocksController.Instance.AdvancedSettingsEnabled)
                    {
                        RecentUnlocksController.Instance.TitleColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        RecentUnlocksController.Instance.SimpleFontColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsDateFontColorPictureBox":
                    RecentUnlocksController.Instance.DateColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsPointsFontColorPictureBox":
                    RecentUnlocksController.Instance.PointsColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsLineColorPictureBox":
                    RecentUnlocksController.Instance.LineColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsLineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsTitleFontOutlineColorPictureBox":
                    if (RecentUnlocksController.Instance.AdvancedSettingsEnabled)
                    {
                        RecentUnlocksController.Instance.TitleOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    else
                    {
                        RecentUnlocksController.Instance.SimpleFontOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    }
                    recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsDateFontOutlineColorPictureBox":
                    RecentUnlocksController.Instance.DateOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsPointsFontOutlineColorPictureBox":
                    RecentUnlocksController.Instance.PointsOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "recentAchievementsLineOutlineColorPictureBox":
                    RecentUnlocksController.Instance.LineOutlineColor = MediaHelper.HexConverter(colorDialog.Color);
                    recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "achievementListBackgroundColorPictureBox":
                    AchievementListController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    achievementsListTabPage.achievementListBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
                case "relatedMediaBackgroundColorPictureBox":
                    RelatedMediaController.Instance.WindowBackgroundColor = MediaHelper.HexConverter(colorDialog.Color);
                    relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.BackColor = colorDialog.Color;
                    break;
            }
        }
        void FontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            FontFamily[] familyArray = FontFamily.Families.ToArray();
            FontFamily fontFamily = null;
            ComboBox comboBox = sender as ComboBox;

            foreach (FontFamily fontFamilyEntity in familyArray)
            {
                if (fontFamilyEntity.Name.Equals((string)comboBox.SelectedItem))
                {
                    fontFamily = fontFamilyEntity;
                    break;
                }
            }

            if (fontFamily != null)
            {
                switch (comboBox.Name)
                {
                    case "focusTitleFontComboBox":
                        if (FocusController.Instance.AdvancedSettingsEnabled)
                        {
                            FocusController.Instance.TitleFontFamily = fontFamily;
                        }
                        else
                        {
                            FocusController.Instance.SimpleFontFamily = fontFamily;
                        }
                        break;
                    case "focusDescriptionFontComboBox":
                        FocusController.Instance.DescriptionFontFamily = fontFamily;
                        break;
                    case "focusPointsFontComboBox":
                        FocusController.Instance.PointsFontFamily = fontFamily;
                        break;
                    case "alertsTitleFontComboBox":
                        if (AlertsController.Instance.AdvancedSettingsEnabled)
                        {
                            AlertsController.Instance.TitleFontFamily = fontFamily;
                        }
                        else
                        {
                            AlertsController.Instance.SimpleFontFamily = fontFamily;
                        }
                        break;
                    case "alertsDescriptionFontComboBox":
                        AlertsController.Instance.DescriptionFontFamily = fontFamily;
                        break;
                    case "alertsPointsFontComboBox":
                        AlertsController.Instance.PointsFontFamily = fontFamily;
                        break;
                    case "userInfoNamesFontComboBox":
                        if (UserInfoController.Instance.AdvancedSettingsEnabled)
                        {
                            UserInfoController.Instance.NameFontFamily = fontFamily;
                        }
                        else
                        {
                            UserInfoController.Instance.SimpleFontFamily = fontFamily;
                        }
                        break;
                    case "userInfoValuesFontComboBox":
                        UserInfoController.Instance.ValueFontFamily = fontFamily;
                        break;
                    case "gameInfoNamesFontComboBox":
                        if (GameInfoController.Instance.AdvancedSettingsEnabled)
                        {
                            GameInfoController.Instance.NameFontFamily = fontFamily;
                        }
                        else
                        {
                            GameInfoController.Instance.SimpleFontFamily = fontFamily;
                        }
                        break;
                    case "gameInfoValuesFontComboBox":
                        GameInfoController.Instance.ValueFontFamily = fontFamily;
                        break;
                    case "gameProgressNamesFontComboBox":
                        if (GameProgressController.Instance.AdvancedSettingsEnabled)
                        {
                            GameProgressController.Instance.NameFontFamily = fontFamily;
                        }
                        else
                        {
                            GameProgressController.Instance.SimpleFontFamily = fontFamily;
                        }
                        break;
                    case "gameProgressValuesFontComboBox":
                        GameProgressController.Instance.ValueFontFamily = fontFamily;
                        break;
                    case "recentAchievementsTitleFontComboBox":
                        if (RecentUnlocksController.Instance.AdvancedSettingsEnabled)
                        {
                            RecentUnlocksController.Instance.TitleFontFamily = fontFamily;
                        }
                        else
                        {
                            RecentUnlocksController.Instance.SimpleFontFamily = fontFamily;
                        }

                        RecentUnlocksController.Instance.PopulateRecentAchievementsWindow();
                        break;
                    case "recentAchievementsDescriptionFontComboBox":
                        RecentUnlocksController.Instance.DateFontFamily = fontFamily;
                        RecentUnlocksController.Instance.PopulateRecentAchievementsWindow();
                        break;
                    case "recentAchievementsPointsFontComboBox":
                        RecentUnlocksController.Instance.PointsFontFamily = fontFamily;
                        RecentUnlocksController.Instance.PopulateRecentAchievementsWindow();
                        break;
                }
            }

            IsChanging = false;
        }
        void NotificationAnimationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            ComboBox comboBox = sender as ComboBox;
            switch (comboBox.Name)
            {
                case "alertsCustomAchievementAnimationInComboBox":
                    AlertsController.Instance.AchievementAnimationIn = WinFormHelpers.GetAnimationDirection((string)(sender as ComboBox).SelectedItem);
                    break;
                case "alertsCustomAchievementAnimationOutComboBox":
                    AlertsController.Instance.AchievementAnimationOut = WinFormHelpers.GetAnimationDirection((string)alertsTabPage.alertsCustomAchievementAnimationOutComboBox.SelectedItem);
                    break;
                case "alertsCustomMasteryAnimationInComboBox":
                    AlertsController.Instance.MasteryAnimationIn = WinFormHelpers.GetAnimationDirection((string)alertsTabPage.alertsCustomMasteryAnimationInComboBox.SelectedItem);
                    break;
                case "alertsCustomMasteryAnimationOutComboBox":
                    AlertsController.Instance.MasteryAnimationOut = WinFormHelpers.GetAnimationDirection((string)alertsTabPage.alertsCustomMasteryAnimationOutComboBox.SelectedItem);
                    break;
            }

            IsChanging = false;
        }
        void FeatureEnablementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            CheckBox checkBox = sender as CheckBox;
            switch (checkBox.Name)
            {
                case "recentAchievementsAutoOpenWindowCheckbox":
                    RecentUnlocksController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "gameInfoAutoOpenWindowCheckbox":
                    GameInfoController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "alertsAutoOpenWindowCheckbox":
                    AlertsController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "focusAutoOpenWindowCheckBox":
                    FocusController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "userInfoAutoOpenWindowCheckbox":
                    UserInfoController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "gameProgressAutoOpenWindowCheckbox":
                    GameProgressController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "achievementListAutoOpenWindowCheckbox":
                    AchievementListController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "relatedMediaAutoOpenWindowCheckbox":
                    RelatedMediaController.Instance.AutoLaunch = checkBox.Checked;
                    break;
                case "autoStartCheckbox":
                    Settings.Default.auto_start_checked = checkBox.Checked;
                    Settings.Default.Save();
                    break;
                case "achievementListAutoScrollCheckBox":
                    AchievementListController.Instance.AutoScroll = checkBox.Checked;
                    break;
                case "recentAchievementsAutoScrollCheckBox":
                    RecentUnlocksController.Instance.AutoScroll = checkBox.Checked;
                    break;
                case "focusBorderCheckBox":
                    FocusController.Instance.BorderEnabled = checkBox.Checked;
                    break;
                case "alertsBorderCheckBox":
                    AlertsController.Instance.BorderEnabled = checkBox.Checked;
                    break;
                case "recentAchievementsBorderCheckBox":
                    RecentUnlocksController.Instance.BorderEnabled = checkBox.Checked;
                    break;
                case "focusTitleOutlineCheckBox":
                    if (FocusController.Instance.AdvancedSettingsEnabled)
                    {
                        FocusController.Instance.TitleOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        FocusController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "focusDescriptionOutlineCheckBox":
                    FocusController.Instance.DescriptionOutlineEnabled = checkBox.Checked;
                    break;
                case "focusPointsOutlineCheckBox":
                    FocusController.Instance.PointsOutlineEnabled = checkBox.Checked;
                    break;
                case "focusLineOutlineCheckBox":
                    FocusController.Instance.LineOutlineEnabled = checkBox.Checked;
                    break;
                case "alertsTitleOutlineCheckBox":
                    if (AlertsController.Instance.AdvancedSettingsEnabled)
                    {
                        AlertsController.Instance.TitleOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        AlertsController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "alertsDescriptionOutlineCheckBox":
                    AlertsController.Instance.DescriptionOutlineEnabled = checkBox.Checked;
                    break;
                case "alertsPointsOutlineCheckBox":
                    AlertsController.Instance.PointsOutlineEnabled = checkBox.Checked;
                    break;
                case "alertsLineOutlineCheckBox":
                    AlertsController.Instance.LineOutlineEnabled = checkBox.Checked;
                    break;
                case "userInfoNamesOutlineCheckBox":
                    if (UserInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        UserInfoController.Instance.NameOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        UserInfoController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "userInfoValuesOutlineCheckBox":
                    UserInfoController.Instance.ValueOutlineEnabled = checkBox.Checked;
                    break;
                case "gameInfoNamesOutlineCheckBox":
                    if (GameInfoController.Instance.AdvancedSettingsEnabled)
                    {
                        GameInfoController.Instance.NameOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        GameInfoController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "gameInfoValuesOutlineCheckBox":
                    GameInfoController.Instance.ValueOutlineEnabled = checkBox.Checked;
                    break;
                case "gameProgressNamesOutlineCheckBox":
                    if (GameProgressController.Instance.AdvancedSettingsEnabled)
                    {
                        GameProgressController.Instance.NameOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        GameProgressController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "gameProgressValuesOutlineCheckBox":
                    GameProgressController.Instance.ValueOutlineEnabled = checkBox.Checked;
                    break;
                case "recentAchievementsTitleFontOutlineCheckBox":
                    if (RecentUnlocksController.Instance.AdvancedSettingsEnabled)
                    {
                        RecentUnlocksController.Instance.TitleOutlineEnabled = checkBox.Checked;
                    }
                    else
                    {
                        RecentUnlocksController.Instance.SimpleFontOutlineEnabled = checkBox.Checked;
                    }
                    break;
                case "recentAchievementsDateFontOutlineCheckBox":
                    RecentUnlocksController.Instance.DescriptionOutlineEnabled = checkBox.Checked;
                    break;
                case "recentAchievementsPointsFontOutlineCheckBox":
                    RecentUnlocksController.Instance.PointsOutlineEnabled = checkBox.Checked;
                    break;
                case "recentAchievementsLineOutlineCheckBox":
                    RecentUnlocksController.Instance.LineOutlineEnabled = checkBox.Checked;
                    break;
                case "userInfoRankCheckBox":
                    UserInfoController.Instance.RankEnabled = checkBox.Checked;
                    break;
                case "userInfoPointsCheckBox":
                    UserInfoController.Instance.PointsEnabled = checkBox.Checked;
                    break;
                case "userInfoTruePointsCheckBox":
                    UserInfoController.Instance.TruePointsEnabled = checkBox.Checked;
                    break;
                case "userInfoRatioCheckBox":
                    UserInfoController.Instance.RatioEnabled = checkBox.Checked;
                    break;
                case "gameInfoTitleCheckBox":
                    GameInfoController.Instance.TitleEnabled = checkBox.Checked;
                    break;
                case "gameInfoDeveloperCheckBox":
                    GameInfoController.Instance.DeveloperEnabled = checkBox.Checked;
                    break;
                case "gameInfoPublisherCheckBox":
                    GameInfoController.Instance.PublisherEnabled = checkBox.Checked;
                    break;
                case "gameInfoConsoleCheckBox":
                    GameInfoController.Instance.ConsoleEnabled = checkBox.Checked;
                    break;
                case "gameInfoGenreCheckBox":
                    GameInfoController.Instance.GenreEnabled = checkBox.Checked;
                    break;
                case "gameInfoReleasedCheckBox":
                    GameInfoController.Instance.ReleasedDateEnabled = checkBox.Checked;
                    break;
                case "gameProgressAchievementsCheckBox":
                    GameProgressController.Instance.AchievementsEnabled = checkBox.Checked;
                    break;
                case "gameProgressPointsCheckBox":
                    GameProgressController.Instance.PointsEnabled = checkBox.Checked;
                    break;
                case "gameProgressTruePointsCheckBox":
                    GameProgressController.Instance.TruePointsEnabled = checkBox.Checked;
                    break;
                case "gameProgressCompletedCheckBox":
                    GameProgressController.Instance.CompletedEnabled = checkBox.Checked;
                    break;
                case "gameProgressRatioCheckBox":
                    GameProgressController.Instance.RatioEnabled = checkBox.Checked;
                    break;
            }

            IsChanging = false;
        }
        void DividerCharacter_RadioButtonClicked(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "gameProgressRadioButtonBackslash":
                        GameProgressController.Instance.DividerCharacter = "/";
                        break;
                    case "gameProgressRadioButtonColon":
                        GameProgressController.Instance.DividerCharacter = ":";
                        break;
                    case "gameProgressRadioButtonPeriod":
                        GameProgressController.Instance.DividerCharacter = ".";
                        break;
                }

                UpdateDividerCharacterRadioButtons();
            }

            IsChanging = false;
        }
        void UpdateDividerCharacterRadioButtons()
        {
            switch (GameProgressController.Instance.DividerCharacter)
            {
                case "/":
                    gameProgressTabPage.gameProgressRadioButtonBackslash.Checked = true;
                    gameProgressTabPage.gameProgressRadioButtonColon.Checked = false;
                    gameProgressTabPage.gameProgressRadioButtonPeriod.Checked = false;
                    break;
                case ":":
                    gameProgressTabPage.gameProgressRadioButtonBackslash.Checked = false;
                    gameProgressTabPage.gameProgressRadioButtonColon.Checked = true;
                    gameProgressTabPage.gameProgressRadioButtonPeriod.Checked = false;
                    break;
                case ".":
                    gameProgressTabPage.gameProgressRadioButtonBackslash.Checked = false;
                    gameProgressTabPage.gameProgressRadioButtonColon.Checked = false;
                    gameProgressTabPage.gameProgressRadioButtonPeriod.Checked = true;
                    break;
            }
        }
        void RefocusBehavior_RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "focusBehaviorGoToFirstRadioButton":
                        FocusController.Instance.RefocusBehavior = RefocusBehaviorEnum.GO_TO_FIRST;
                        break;
                    case "focusBehaviorGoToPreviousRadioButton":
                        FocusController.Instance.RefocusBehavior = RefocusBehaviorEnum.GO_TO_PREVIOUS;
                        break;
                    case "focusBehaviorGoToNextRadioButton":
                        FocusController.Instance.RefocusBehavior = RefocusBehaviorEnum.GO_TO_NEXT;
                        break;
                    case "focusBehaviorGoToLastRadioButton":
                        FocusController.Instance.RefocusBehavior = RefocusBehaviorEnum.GO_TO_LAST;
                        break;
                }

                UpdateRefocusBehaviorRadioButtons();
            }

            IsChanging = false;
        }
        void UpdateRefocusBehaviorRadioButtons()
        {
            switch (FocusController.Instance.RefocusBehavior)
            {
                case RefocusBehaviorEnum.GO_TO_FIRST:
                    focusTabPage.focusBehaviorGoToFirstRadioButton.Checked = true;
                    focusTabPage.focusBehaviorGoToPreviousRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToNextRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToLastRadioButton.Checked = false;
                    break;
                case RefocusBehaviorEnum.GO_TO_PREVIOUS:
                    focusTabPage.focusBehaviorGoToFirstRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToPreviousRadioButton.Checked = true;
                    focusTabPage.focusBehaviorGoToNextRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToLastRadioButton.Checked = false;
                    break;
                case RefocusBehaviorEnum.GO_TO_NEXT:
                    focusTabPage.focusBehaviorGoToFirstRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToPreviousRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToNextRadioButton.Checked = true;
                    focusTabPage.focusBehaviorGoToLastRadioButton.Checked = false;
                    break;
                case RefocusBehaviorEnum.GO_TO_LAST:
                    focusTabPage.focusBehaviorGoToFirstRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToPreviousRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToNextRadioButton.Checked = false;
                    focusTabPage.focusBehaviorGoToLastRadioButton.Checked = true;
                    break;
            }
        }
        void RelatedMedia_RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;

            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Name)
            {
                case "relatedMediaRABadgeIconRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.RABadgeIcon)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.RABadgeIcon;
                    break;
                case "relatedMediaRABoxArtRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.RABoxArt)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.RABoxArt;
                    break;
                case "relatedMediaRATitleScreenRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.RATitleScreen)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.RATitleScreen;
                    break;
                case "relatedMediaRAScreenshotRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.RAIngameScreen)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.RAIngameScreen;
                    break;
                case "relatedMediaLBBoxFrontRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtFront)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtFront;
                    break;
                case "relatedMediaLBBoxBackRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtBack)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtBack;
                    break;
                case "relatedMediaLBBox3DRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArt3D)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArt3D;
                    break;
                case "relatedMediaLBBoxFrontReconRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtFrontRecon)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtFrontRecon;
                    break;
                case "relatedMediaLBBoxBackReconRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtBackRecon)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtBackRecon;
                    break;
                case "relatedMediaLBBoxFullRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtFull)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtFull;
                    break;
                case "relatedMediaLBBoxSpineRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBoxArtSpine)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBoxArtSpine;
                    break;
                case "relatedMediaLBBannerRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBBanner)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBBanner;
                    break;
                case "relatedMediaLBTitleScreenRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBTitleScreen)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBTitleScreen;
                    break;
                case "relatedMediaLBClearLogoRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBClearLogo)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBClearLogo;
                    break;
                case "relatedMediaLBCartFrontRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBCartFront)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBCartFront;
                    break;
                case "relatedMediaLBCartBackRadioButton":
                    if (RelatedMediaController.Instance.RelatedMediaSelection == RelatedMediaSelection.LBCartBack)
                    {
                        IsChanging = false;
                        return;
                    }
                    RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.LBCartBack;
                    break;
            }

            UpdateRelatedMediaRadioButtons();
            IsChanging = false;
        }

        void UpdateRelatedMediaRadioButtons()
        {
            UpdateLaunchBoxIntegrationState();

            switch (RelatedMediaController.Instance.RelatedMediaSelection)
            {
                case RelatedMediaSelection.RABadgeIcon:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaRABadgeIconRadioButton);
                    break;
                case RelatedMediaSelection.RABoxArt:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaRABoxArtRadioButton);
                    break;
                case RelatedMediaSelection.RATitleScreen:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaRATitleScreenRadioButton);
                    break;
                case RelatedMediaSelection.RAIngameScreen:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaRAScreenshotRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtFront:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtBack:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxBackRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArt3D:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBox3DRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtFrontRecon:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtBackRecon:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtFull:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxFullRadioButton);
                    break;
                case RelatedMediaSelection.LBBoxArtSpine:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton);
                    break;
                case RelatedMediaSelection.LBBanner:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBBannerRadioButton);
                    break;
                case RelatedMediaSelection.LBTitleScreen:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton);
                    break;
                case RelatedMediaSelection.LBClearLogo:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBClearLogoRadioButton);
                    break;
                case RelatedMediaSelection.LBCartFront:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBCartFrontRadioButton);
                    break;
                case RelatedMediaSelection.LBCartBack:
                    SetMediaButtonChecks(relatedMediaTabPage.relatedMediaLBCartBackRadioButton);
                    break;
            }

            RelatedMediaController.Instance.SetAllSettings(false);
        }

        /// <summary>Uncheck all media buttons, then check the ones parassed as parameters</summary>
        /// <param name="toCheck">Button to check</param>
        void SetMediaButtonChecks(params RadioButton[] toCheck)
        {
            List<RadioButton> btns = new List<RadioButton>{
                relatedMediaTabPage.relatedMediaRABoxArtRadioButton,
                relatedMediaTabPage.relatedMediaRATitleScreenRadioButton,
                relatedMediaTabPage.relatedMediaRAScreenshotRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxBackRadioButton,
                relatedMediaTabPage.relatedMediaLBBox3DRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxFullRadioButton,
                relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton,
                relatedMediaTabPage.relatedMediaLBBannerRadioButton,
                relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton,
                relatedMediaTabPage.relatedMediaLBClearLogoRadioButton,
                relatedMediaTabPage.relatedMediaLBCartFrontRadioButton,
                relatedMediaTabPage.relatedMediaLBCartBackRadioButton,
                relatedMediaTabPage.relatedMediaRABadgeIconRadioButton
            };

            foreach (RadioButton btn in btns)
            {
                btn.Checked = false;
            }

            foreach (RadioButton btn in toCheck)
            {
                btn.Checked = true;
            }
        }
        void UpdateLaunchBoxIntegrationState()
        {
            if (!Directory.Exists(RelatedMediaController.Instance.LaunchBoxFilePath) || (Directory.Exists(RelatedMediaController.Instance.LaunchBoxFilePath) && !File.Exists(RelatedMediaController.Instance.LaunchBoxFilePath + "\\LaunchBox.exe")))
            {
                relatedMediaTabPage.relatedMediaLBLabel.Enabled = false;
                relatedMediaTabPage.relatedMediaLBLinePictureBox.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBBannerRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Enabled = false;
                relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Enabled = false;

                switch (RelatedMediaController.Instance.RelatedMediaSelection)
                {
                    case RelatedMediaSelection.LBBoxArtFront:
                    case RelatedMediaSelection.LBBoxArtBack:
                    case RelatedMediaSelection.LBBoxArt3D:
                    case RelatedMediaSelection.LBBoxArtFrontRecon:
                    case RelatedMediaSelection.LBBoxArtBackRecon:
                    case RelatedMediaSelection.LBBoxArtFull:
                    case RelatedMediaSelection.LBBoxArtSpine:
                    case RelatedMediaSelection.LBBanner:
                    case RelatedMediaSelection.LBTitleScreen:
                    case RelatedMediaSelection.LBClearLogo:
                    case RelatedMediaSelection.LBCartFront:
                    case RelatedMediaSelection.LBCartBack:
                        relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Checked = true;

                        RelatedMediaController.Instance.RelatedMediaSelection = RelatedMediaSelection.RABadgeIcon;
                        break;
                }
            }
            else
            {
                relatedMediaTabPage.relatedMediaLBLabel.Enabled = true;
                relatedMediaTabPage.relatedMediaLBLinePictureBox.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBBannerRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Enabled = true;
                relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Enabled = true;
            }
        }
        void UpdateLaunchBoxReferences()
        {
            if (GameInfoAndProgress != null || !Directory.Exists(Settings.Default.related_media_launchbox_filepath))
            {
                return;
            }

            try
            {
                Dictionary<string, DateTime> gameNames = new Dictionary<string, DateTime>();

                using (XmlReader reader = XmlReader.Create(Settings.Default.related_media_launchbox_filepath + "\\Data\\Platforms\\" + GameInfoAndProgress.ConsoleName + ".xml"))
                {
                    string currentGameName = "";
                    bool inGame = false,
                        inName = false,
                        inLastPlayed = false;

                    DateTime lastPlayed = DateTime.MinValue;

                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                switch (reader.Name)
                                {
                                    case "Game": inGame = true; break;
                                    case "Title": inName = true; break;
                                    case "LastPlayedDate": inLastPlayed = true; break;
                                }
                                break;
                            case XmlNodeType.Text:
                                if (inGame)
                                {
                                    if (inName)
                                    {
                                        inName = false;
                                        currentGameName = reader.Value;
                                    }
                                    else if (inLastPlayed)
                                    {
                                        inLastPlayed = false;
                                        lastPlayed = DateTime.Parse(reader.Value);
                                    }
                                }
                                break;
                            case XmlNodeType.EndElement:
                                if ("Game".Equals(reader.Name))
                                {
                                    if (!lastPlayed.Equals(DateTime.MinValue))
                                    {
                                        gameNames.Add(currentGameName, lastPlayed);
                                    }

                                    inGame = inName = inLastPlayed = false;
                                    lastPlayed = DateTime.MinValue;
                                }
                                break;
                        }
                    }
                }

                /**
                 * Get the highest confidence game, we'll use it to get images of the game
                 * However if it's not available, updates URI values & stop
                 */
                string highestConfidenceGame = GetHighestConfidenceGame(gameNames);
                if (string.IsNullOrEmpty(highestConfidenceGame))
                {
                    RelatedMediaController.Instance.LBBoxFrontURI = "";
                    RelatedMediaController.Instance.LBBoxBackURI = "";
                    RelatedMediaController.Instance.LBBox3DURI = "";
                    RelatedMediaController.Instance.LBBoxFrontReconURI = "";
                    RelatedMediaController.Instance.LBBoxBackReconURI = "";
                    RelatedMediaController.Instance.LBBoxFullURI = "";
                    RelatedMediaController.Instance.LBBoxSpineURI = "";
                    RelatedMediaController.Instance.LBBannerURI = "";
                    RelatedMediaController.Instance.LBTitleSceenURI = "";
                    RelatedMediaController.Instance.LBClearLogoURI = "";
                    RelatedMediaController.Instance.LBCartFrontURI = "";
                    RelatedMediaController.Instance.LBCartBackURI = "";
                    return;
                }

                // Get game box art, cartridge pics, screenshots
                RelatedMediaController.Instance.LBBoxFrontURI = GetGameImagePath(highestConfidenceGame, "Box-Front");
                RelatedMediaController.Instance.LBBoxBackURI = GetGameImagePath(highestConfidenceGame, "Box-Back");
                RelatedMediaController.Instance.LBBox3DURI = GetGameImagePath(highestConfidenceGame, "Box-3D");
                RelatedMediaController.Instance.LBBoxFrontReconURI = GetGameImagePath(highestConfidenceGame, "Box-Front-Reconstructed");
                RelatedMediaController.Instance.LBBoxBackReconURI = GetGameImagePath(highestConfidenceGame, "Box-Back-Reconstructed");
                RelatedMediaController.Instance.LBBoxFullURI = GetGameImagePath(highestConfidenceGame, "Box-Full");
                RelatedMediaController.Instance.LBBoxSpineURI = GetGameImagePath(highestConfidenceGame, "Box-Spine");
                RelatedMediaController.Instance.LBClearLogoURI = GetGameImagePath(highestConfidenceGame, "Clear-Logo");
                RelatedMediaController.Instance.LBTitleSceenURI = GetGameImagePath(highestConfidenceGame, "Screenshot-Game-Title");
                RelatedMediaController.Instance.LBBannerURI = GetGameImagePath(highestConfidenceGame, "Banner");
                RelatedMediaController.Instance.LBCartFrontURI = GetGameImagePath(highestConfidenceGame, "Cart-Front");
                RelatedMediaController.Instance.LBCartBackURI = GetGameImagePath(highestConfidenceGame, "Cart-Back");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>Get the highest confidence game</summary>
        /// <param name="gameNames">Dictionary of possible game names</param>
        /// <returns><c>string</c>Game name (or empty if not available)</returns>
        string GetHighestConfidenceGame(Dictionary<string, DateTime> gameNames)
        {
            if (gameNames.Count < 1)
            {
                return "";
            }

            string game = "";
            DateTime dateTime = DateTime.MinValue;
            foreach (string name in gameNames.Keys)
            {
                gameNames.TryGetValue(name, out DateTime value);
                if (value.CompareTo(dateTime) > 0)
                {
                    game = name;
                    dateTime = value;
                }
            }

            return game.Replace('\'', '_').Replace(':', '_');
        }

        /// <summary>Get the path of a specific image related to a game</summary>
        /// <param name="game">Game name</param>
        /// <param name="img">Image to get the path of</param>
        /// <returns><c>string</c></returns>
        string GetGameImagePath(string game, string img)
        {
            // Get the path & absolute path first
            string path,
                filePath = $"{RelatedMediaController.Instance.LaunchBoxFilePath.Replace("\\", "/")}/";
            switch (img.ToLower())
            {
                case "box-front":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Front/{game}";
                    break;
                case "box-front-reconstructed":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Front - Reconstructed/{game}";
                    break;
                case "box-back":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Back/{game}";
                    break;
                case "box-back-reconstructed":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Back - Reconstructed/{game}";
                    break;
                case "box-3d":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - 3D/{game}";
                    break;
                case "box-full":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Full/{game}";
                    break;
                case "box-spine":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Box - Spine/{game}";
                    break;
                case "clear-logo":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Clear Logo/{game}";
                    break;
                case "screenshot-game-title":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Screenshot - Game Title/{game}";
                    break;
                case "banner":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Banner/{game}";
                    break;
                case "cart-front":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Cart - Front/{game}";
                    break;
                case "cart-back":
                    path = $"Images/{GameInfoAndProgress.ConsoleName}/Cart - Back/{game}";
                    break;
                default:
                    return "";
            }

            // Check if an img if available
            string imgPath = "",
                absolutePath = filePath + path,
                subFoldersPath = $"{RelatedMediaController.Instance.LaunchBoxFilePath}{path.Replace("/", "\\")}";
            string[] subFolders = Directory.Exists(subFoldersPath) ? Directory.GetDirectories(subFoldersPath) : Array.Empty<string>();
            for (int i = 1; i < 3; i++)
            {
                // Look in the main folder
                if (File.Exists($"{absolutePath}-0{i}.jpg"))
                {
                    imgPath = $"{path}-0{i}.jpg";
                    break;
                }
                else if (File.Exists($"{absolutePath}-0{i}.png"))
                {
                    imgPath = $"{path}-0{i}.jpg";
                    break;
                }

                if (subFolders.Length < 1)
                {
                    continue;
                }

                // Look in subfolders
                foreach (string folder in subFolders)
                {
                    if (File.Exists($"{folder.Replace("\\", "/")}/{game}-0{i}.jpg"))
                    {
                        imgPath = $"{folder.Substring(RelatedMediaController.Instance.LaunchBoxFilePath.Length).Replace("\\", "/")}/{game}-0{i}.jpg";
                        break;
                    }
                    else if (File.Exists($"{folder.Replace("\\", "/")}/{game}-0{i}.png"))
                    {
                        imgPath = $"{folder.Substring(RelatedMediaController.Instance.LaunchBoxFilePath.Length).Replace("\\", "/")}/{game}-0{i}.png";
                        break;
                    }
                }
            }

            return imgPath;
        }

        void AdvancedCheckBox_Click(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "focusAdvancedCheckBox":
                    FocusController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
                case "alertsAdvancedCheckBox":
                    AlertsController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
                case "userInfoAdvancedCheckBox":
                    UserInfoController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
                case "gameInfoAdvancedCheckBox":
                    GameInfoController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
                case "gameProgressAdvancedCheckBox":
                    GameProgressController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
                case "recentAchievementsAdvancedCheckBox":
                    RecentUnlocksController.Instance.AdvancedSettingsEnabled = checkBox.Checked;
                    break;
            }

            UpdateAdvancedSettings();
            IsChanging = false;
        }

        void UpdateAdvancedSettings()
        {
            focusTabPage.ToggleTabElements(FocusController.Instance.AdvancedSettingsEnabled);
            alertsTabPage.ToggleTabElements(AlertsController.Instance.AdvancedSettingsEnabled);
            userInfoTabPage.ToggleTabElements(UserInfoController.Instance.AdvancedSettingsEnabled);
            gameInfoTabPage.ToggleTabElements(GameInfoController.Instance.AdvancedSettingsEnabled);
            gameProgressTabPage.ToggleTabElements(GameProgressController.Instance.AdvancedSettingsEnabled);
            recentAchievementsTabPage.ToggleTabElements(RecentUnlocksController.Instance.AdvancedSettingsEnabled);
        }
        void DefaultButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "gameInfoDefaultButton":
                    gameInfoTabPage.gameInfoTitleTextBox.Text = "Title";
                    gameInfoTabPage.gameInfoConsoleTextBox.Text = "Console";
                    gameInfoTabPage.gameInfoDeveloperTextBox.Text = "Developer";
                    gameInfoTabPage.gameInfoPublisherTextBox.Text = "Publisher";
                    gameInfoTabPage.gameInfoGenreTextBox.Text = "Genre";
                    gameInfoTabPage.gameInfoReleaseDateTextBox.Text = "Released";
                    break;
                case "userInfoDefaultButton":
                    userInfoTabPage.userInfoRankTextBox.Text = "Rank";
                    userInfoTabPage.userInfoPointsTextBox.Text = "Points";
                    userInfoTabPage.userInfoTruePointsTextBox.Text = "True Points";
                    userInfoTabPage.userInfoRatioTextBox.Text = "Retro Ratio";
                    break;
                case "gameProgressDefaultButton":
                    gameProgressTabPage.gameProgressRatioTextBox.Text = "Retro Ratio";
                    gameProgressTabPage.gameProgressPointsTextBox.Text = "Points";
                    gameProgressTabPage.gameProgressTruePointsTextBox.Text = "True Points";
                    gameProgressTabPage.gameProgressAchievementsTextBox.Text = "Achievements";
                    gameProgressTabPage.gameProgressCompletedTextBox.Text = "Completed";
                    break;
            }
        }
        void OverrideTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                return;
            }

            IsChanging = true;
            TextBox textBox = sender as TextBox;
            switch (textBox.Name)
            {
                case "userInfoRankTextBox":
                    UserInfoController.Instance.RankName = textBox.Text;
                    break;
                case "userInfoPointsTextBox":
                    UserInfoController.Instance.PointsName = textBox.Text;
                    break;
                case "userInfoTruePointsTextBox":
                    UserInfoController.Instance.TruePointsName = textBox.Text;
                    break;
                case "userInfoRatioTextBox":
                    UserInfoController.Instance.RatioName = textBox.Text;
                    break;
                case "gameProgressAchievementsTextBox":
                    GameProgressController.Instance.AchievementsName = textBox.Text;
                    break;
                case "gameProgressPointsTextBox":
                    GameProgressController.Instance.PointsName = textBox.Text;
                    break;
                case "gameProgressTruePointsTextBox":
                    GameProgressController.Instance.TruePointsName = textBox.Text;
                    break;
                case "gameProgressCompletedTextBox":
                    GameProgressController.Instance.CompletedName = textBox.Text;
                    break;
                case "gameProgressRatioTextBox":
                    GameProgressController.Instance.RatioName = textBox.Text;
                    break;
                case "gameInfoConsoleTextBox":
                    GameInfoController.Instance.ConsoleName = textBox.Text;
                    break;
                case "gameInfoDeveloperTextBox":
                    GameInfoController.Instance.DeveloperName = textBox.Text;
                    break;
                case "gameInfoPublisherTextBox":
                    GameInfoController.Instance.PublisherName = textBox.Text;
                    break;
                case "gameInfoGenreTextBox":
                    GameInfoController.Instance.GenreName = textBox.Text;
                    break;
                case "gameInfoReleaseDateTextBox":
                    GameInfoController.Instance.ReleasedDateName = textBox.Text;
                    break;
                case "gameInfoTitleTextBox":
                    GameInfoController.Instance.TitleName = textBox.Text;
                    break;
            }

            IsChanging = false;
        }
        void BrowserSensitiveControl_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (control.Name)
            {
                case "userProfilePictureBox":
                    System.Diagnostics.Process.Start("https://retroachievements.org/User/" + UserSummary.UserName);
                    break;
                case "gameInfoPictureBox":
                    System.Diagnostics.Process.Start("https://retroachievements.org/game/" + GameInfoAndProgress.Id);
                    break;
                case "focusAchievementPictureBox":
                case "focusAchievementTitleLabel":
                    if (CurrentlyViewingAchievement != null)
                    {
                        System.Diagnostics.Process.Start("https://retroachievements.org/achievement/" + CurrentlyViewingAchievement.Id);
                    }
                    break;
                case "rssFeedListView":
                    ListView listView = (ListView)sender;
                    if (listView.SelectedItems.Count > 0)
                    {
                        if (listView.SelectedItems[0].SubItems[0].Text.Contains("[FORUM] ") || listView.SelectedItems[0].SubItems[0].Text.Contains("[CHEEVO] "))
                        {
                            System.Diagnostics.Process.Start(listView.SelectedItems[0].SubItems[3].Text);
                        }
                    }
                    break;
            }
        }
        void LoadProperties()
        {
            if (Settings.Default.UpdateSettings)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpdateSettings = false;
                Settings.Default.Save();
            }

            usernameTextBox.Text = Username;
            apiKeyTextBox.Text = WebAPIKey;

            manualSearchTextBox.Text = PreviouslyPlayedGameId.ToString();

            userInfoTabPage.userInfoRankTextBox.Text = UserInfoController.Instance.RankName;
            userInfoTabPage.userInfoPointsTextBox.Text = UserInfoController.Instance.PointsName;
            userInfoTabPage.userInfoTruePointsTextBox.Text = UserInfoController.Instance.TruePointsName;
            userInfoTabPage.userInfoRatioTextBox.Text = UserInfoController.Instance.RatioName;

            gameInfoTabPage.gameInfoTitleTextBox.Text = GameInfoController.Instance.TitleName;
            gameInfoTabPage.gameInfoDeveloperTextBox.Text = GameInfoController.Instance.DeveloperName;
            gameInfoTabPage.gameInfoPublisherTextBox.Text = GameInfoController.Instance.PublisherName;
            gameInfoTabPage.gameInfoConsoleTextBox.Text = GameInfoController.Instance.ConsoleName;
            gameInfoTabPage.gameInfoGenreTextBox.Text = GameInfoController.Instance.GenreName;
            gameInfoTabPage.gameInfoReleaseDateTextBox.Text = GameInfoController.Instance.ReleasedDateName;

            gameProgressTabPage.gameProgressAchievementsTextBox.Text = GameProgressController.Instance.AchievementsName;
            gameProgressTabPage.gameProgressPointsTextBox.Text = GameProgressController.Instance.PointsName;
            gameProgressTabPage.gameProgressTruePointsTextBox.Text = GameProgressController.Instance.TruePointsName;
            gameProgressTabPage.gameProgressRatioTextBox.Text = GameProgressController.Instance.RatioName;
            gameProgressTabPage.gameProgressCompletedTextBox.Text = GameProgressController.Instance.CompletedName;

            // Auto-Launch/Starting
            autoStartCheckbox.Checked = Settings.Default.auto_start_checked;
            focusTabPage.focusAutoOpenWindowCheckBox.Checked = FocusController.Instance.AutoLaunch;
            alertsTabPage.alertsAutoOpenWindowCheckbox.Checked = AlertsController.Instance.AutoLaunch;
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Checked = UserInfoController.Instance.AutoLaunch;
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Checked = GameInfoController.Instance.AutoLaunch;
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Checked = GameProgressController.Instance.AutoLaunch;
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Checked = RecentUnlocksController.Instance.AutoLaunch;
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Checked = AchievementListController.Instance.AutoLaunch;
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Checked = RelatedMediaController.Instance.AutoLaunch;

            // Window Background Color
            focusTabPage.focusBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.WindowBackgroundColor);
            alertsTabPage.alertsBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.WindowBackgroundColor);
            userInfoTabPage.userInfoBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.WindowBackgroundColor);
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.WindowBackgroundColor);
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.WindowBackgroundColor);
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.WindowBackgroundColor);
            achievementsListTabPage.achievementListBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(AchievementListController.Instance.WindowBackgroundColor);
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.BackColor = ColorTranslator.FromHtml(RelatedMediaController.Instance.WindowBackgroundColor);

            // Window Static Sizes
            achievementsListTabPage.achievementListWindowSizeXUpDown.Value = AchievementListController.Instance.WindowSizeX;
            achievementsListTabPage.achievementListWindowSizeYUpDown.Value = AchievementListController.Instance.WindowSizeY;

            // Border Background Color
            focusTabPage.focusBorderColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.BorderBackgroundColor);
            alertsTabPage.alertsBorderColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.BorderBackgroundColor);
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.BorderBackgroundColor);

            // Border Enabled
            focusTabPage.focusBorderCheckBox.Checked = FocusController.Instance.BorderEnabled;
            alertsTabPage.alertsBorderCheckBox.Checked = AlertsController.Instance.BorderEnabled;
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Checked = RecentUnlocksController.Instance.BorderEnabled;

            // Advanced Settings
            focusTabPage.focusAdvancedCheckBox.Checked = FocusController.Instance.AdvancedSettingsEnabled;
            alertsTabPage.alertsAdvancedCheckBox.Checked = AlertsController.Instance.AdvancedSettingsEnabled;
            userInfoTabPage.userInfoAdvancedCheckBox.Checked = UserInfoController.Instance.AdvancedSettingsEnabled;
            gameInfoTabPage.gameInfoAdvancedCheckBox.Checked = GameInfoController.Instance.AdvancedSettingsEnabled;
            gameProgressTabPage.gameProgressAdvancedCheckBox.Checked = GameProgressController.Instance.AdvancedSettingsEnabled;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Checked = RecentUnlocksController.Instance.AdvancedSettingsEnabled;

            userInfoTabPage.userInfoRankCheckBox.Checked = UserInfoController.Instance.RankEnabled;
            userInfoTabPage.userInfoPointsCheckBox.Checked = UserInfoController.Instance.PointsEnabled;
            userInfoTabPage.userInfoTruePointsCheckBox.Checked = UserInfoController.Instance.TruePointsEnabled;
            userInfoTabPage.userInfoRatioCheckBox.Checked = UserInfoController.Instance.RatioEnabled;

            gameInfoTabPage.gameInfoTitleCheckBox.Checked = GameInfoController.Instance.TitleEnabled;
            gameInfoTabPage.gameInfoDeveloperCheckBox.Checked = GameInfoController.Instance.DeveloperEnabled;
            gameInfoTabPage.gameInfoPublisherCheckBox.Checked = GameInfoController.Instance.PublisherEnabled;
            gameInfoTabPage.gameInfoConsoleCheckBox.Checked = GameInfoController.Instance.ConsoleEnabled;
            gameInfoTabPage.gameInfoGenreCheckBox.Checked = GameInfoController.Instance.GenreEnabled;
            gameInfoTabPage.gameInfoReleasedCheckBox.Checked = GameInfoController.Instance.ReleasedDateEnabled;

            gameProgressTabPage.gameProgressAchievementsCheckBox.Checked = GameProgressController.Instance.AchievementsEnabled;
            gameProgressTabPage.gameProgressPointsCheckBox.Checked = GameProgressController.Instance.PointsEnabled;
            gameProgressTabPage.gameProgressTruePointsCheckBox.Checked = GameProgressController.Instance.TruePointsEnabled;
            gameProgressTabPage.gameProgressCompletedCheckBox.Checked = GameProgressController.Instance.CompletedEnabled;
            gameProgressTabPage.gameProgressRatioCheckBox.Checked = GameProgressController.Instance.RatioEnabled;

            // Set Font Family ComboBoxes
            SetFontFamilyBox(focusTabPage.focusTitleFontComboBox, FocusController.Instance.AdvancedSettingsEnabled ? FocusController.Instance.TitleFontFamily : FocusController.Instance.SimpleFontFamily);
            SetFontFamilyBox(focusTabPage.focusDescriptionFontComboBox, FocusController.Instance.DescriptionFontFamily);
            SetFontFamilyBox(focusTabPage.focusPointsFontComboBox, FocusController.Instance.PointsFontFamily);

            SetFontFamilyBox(alertsTabPage.alertsTitleFontComboBox, AlertsController.Instance.AdvancedSettingsEnabled ? AlertsController.Instance.TitleFontFamily : AlertsController.Instance.SimpleFontFamily);
            SetFontFamilyBox(alertsTabPage.alertsDescriptionFontComboBox, AlertsController.Instance.DescriptionFontFamily);
            SetFontFamilyBox(alertsTabPage.alertsPointsFontComboBox, AlertsController.Instance.PointsFontFamily);

            SetFontFamilyBox(userInfoTabPage.userInfoNamesFontComboBox, UserInfoController.Instance.AdvancedSettingsEnabled ? UserInfoController.Instance.NameFontFamily : UserInfoController.Instance.SimpleFontFamily);
            SetFontFamilyBox(userInfoTabPage.userInfoValuesFontComboBox, UserInfoController.Instance.ValueFontFamily);

            SetFontFamilyBox(gameInfoTabPage.gameInfoNamesFontComboBox, GameInfoController.Instance.AdvancedSettingsEnabled ? GameInfoController.Instance.NameFontFamily : GameInfoController.Instance.SimpleFontFamily);
            SetFontFamilyBox(gameInfoTabPage.gameInfoValuesFontComboBox, GameInfoController.Instance.ValueFontFamily);

            SetFontFamilyBox(gameProgressTabPage.gameProgressNamesFontComboBox, GameProgressController.Instance.AdvancedSettingsEnabled ? GameProgressController.Instance.NameFontFamily : GameProgressController.Instance.SimpleFontFamily);
            SetFontFamilyBox(gameProgressTabPage.gameProgressValuesFontComboBox, GameProgressController.Instance.ValueFontFamily);

            SetFontFamilyBox(recentAchievementsTabPage.recentAchievementsTitleFontComboBox, RecentUnlocksController.Instance.AdvancedSettingsEnabled ? RecentUnlocksController.Instance.TitleFontFamily : RecentUnlocksController.Instance.SimpleFontFamily);
            SetFontFamilyBox(recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox, RecentUnlocksController.Instance.DateFontFamily);
            SetFontFamilyBox(recentAchievementsTabPage.recentAchievementsPointsFontComboBox, RecentUnlocksController.Instance.PointsFontFamily);

            // Font & Outline Enablement
            focusTabPage.focusTitleOutlineCheckBox.Checked = FocusController.Instance.AdvancedSettingsEnabled ? FocusController.Instance.TitleOutlineEnabled : FocusController.Instance.SimpleFontOutlineEnabled;
            focusTabPage.focusDescriptionOutlineCheckBox.Checked = FocusController.Instance.DescriptionOutlineEnabled;
            focusTabPage.focusPointsOutlineCheckBox.Checked = FocusController.Instance.PointsOutlineEnabled;
            focusTabPage.focusLineOutlineCheckBox.Checked = FocusController.Instance.LineOutlineEnabled;

            alertsTabPage.alertsTitleOutlineCheckBox.Checked = AlertsController.Instance.AdvancedSettingsEnabled ? AlertsController.Instance.TitleOutlineEnabled : AlertsController.Instance.SimpleFontOutlineEnabled;
            alertsTabPage.alertsDescriptionOutlineCheckBox.Checked = AlertsController.Instance.DescriptionOutlineEnabled;
            alertsTabPage.alertsPointsOutlineCheckBox.Checked = AlertsController.Instance.PointsOutlineEnabled;
            alertsTabPage.alertsLineOutlineCheckBox.Checked = AlertsController.Instance.LineOutlineEnabled;

            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Checked = GameInfoController.Instance.AdvancedSettingsEnabled ? GameInfoController.Instance.NameOutlineEnabled : GameInfoController.Instance.SimpleFontOutlineEnabled;
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Checked = GameInfoController.Instance.ValueOutlineEnabled;

            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Checked = GameProgressController.Instance.AdvancedSettingsEnabled ? GameProgressController.Instance.NameOutlineEnabled : GameProgressController.Instance.SimpleFontOutlineEnabled;
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Checked = GameProgressController.Instance.ValueOutlineEnabled;

            userInfoTabPage.userInfoNamesOutlineCheckBox.Checked = UserInfoController.Instance.AdvancedSettingsEnabled ? UserInfoController.Instance.NameOutlineEnabled : UserInfoController.Instance.SimpleFontOutlineEnabled;
            userInfoTabPage.userInfoValuesOutlineCheckBox.Checked = UserInfoController.Instance.ValueOutlineEnabled;

            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Checked = RecentUnlocksController.Instance.AdvancedSettingsEnabled ? RecentUnlocksController.Instance.TitleOutlineEnabled : RecentUnlocksController.Instance.SimpleFontOutlineEnabled;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Checked = RecentUnlocksController.Instance.DescriptionOutlineEnabled;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Checked = RecentUnlocksController.Instance.PointsOutlineEnabled;
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Checked = RecentUnlocksController.Instance.LineOutlineEnabled;

            // Font Color PictureBox Assignment
            focusTabPage.focusTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.AdvancedSettingsEnabled ? FocusController.Instance.TitleColor : FocusController.Instance.SimpleFontColor);
            focusTabPage.focusDescriptionFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.DescriptionColor);
            focusTabPage.focusPointsFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.PointsColor);
            focusTabPage.focusLineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.LineColor);

            focusTabPage.focusTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.AdvancedSettingsEnabled ? FocusController.Instance.TitleOutlineColor : FocusController.Instance.SimpleFontOutlineColor);
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.DescriptionOutlineColor);
            focusTabPage.focusPointsFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.PointsOutlineColor);
            focusTabPage.focusLineOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.LineOutlineColor);

            alertsTabPage.alertsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.AdvancedSettingsEnabled ? AlertsController.Instance.TitleColor : AlertsController.Instance.SimpleFontColor);
            alertsTabPage.alertsDescriptionFontColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.DescriptionColor);
            alertsTabPage.alertsPointsFontColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.PointsColor);
            alertsTabPage.alertsLineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.LineColor);

            alertsTabPage.alertsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.AdvancedSettingsEnabled ? AlertsController.Instance.TitleOutlineColor : AlertsController.Instance.SimpleFontOutlineColor);
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.DescriptionOutlineColor);
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.PointsOutlineColor);
            alertsTabPage.alertsLineOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.LineColor);

            userInfoTabPage.userInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.AdvancedSettingsEnabled ? UserInfoController.Instance.NameColor : UserInfoController.Instance.SimpleFontColor);
            userInfoTabPage.userInfoValuesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.ValueColor);

            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.AdvancedSettingsEnabled ? UserInfoController.Instance.NameOutlineColor : UserInfoController.Instance.SimpleFontOutlineColor);
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.ValueOutlineColor);

            gameInfoTabPage.gameInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.AdvancedSettingsEnabled ? GameInfoController.Instance.NameColor : GameInfoController.Instance.SimpleFontColor);
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.ValueColor);

            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.AdvancedSettingsEnabled ? GameInfoController.Instance.NameOutlineColor : GameInfoController.Instance.SimpleFontOutlineColor);
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.ValueOutlineColor);

            gameProgressTabPage.gameProgressNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.AdvancedSettingsEnabled ? GameProgressController.Instance.NameColor : GameProgressController.Instance.SimpleFontColor);
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.ValueColor);

            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.AdvancedSettingsEnabled ? GameProgressController.Instance.NameOutlineColor : GameProgressController.Instance.SimpleFontOutlineColor);
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.ValueOutlineColor);

            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.AdvancedSettingsEnabled ? RecentUnlocksController.Instance.TitleColor : RecentUnlocksController.Instance.SimpleFontColor);
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.DateColor);
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.PointsColor);
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.LineColor);

            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.AdvancedSettingsEnabled ? RecentUnlocksController.Instance.TitleOutlineColor : RecentUnlocksController.Instance.SimpleFontOutlineColor);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.DateOutlineColor);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.PointsOutlineColor);
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.LineOutlineColor);

            // Font Outline Size NumericUpDown Assignment
            focusTabPage.focusTitleFontOutlineNumericUpDown.Value = FocusController.Instance.AdvancedSettingsEnabled ? FocusController.Instance.TitleOutlineSize : FocusController.Instance.SimpleFontOutlineSize;
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Value = FocusController.Instance.DescriptionOutlineSize;
            focusTabPage.focusPointsFontOutlineNumericUpDown.Value = FocusController.Instance.PointsOutlineSize;
            focusTabPage.focusLineOutlineNumericUpDown.Value = FocusController.Instance.LineOutlineSize;

            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Value = AlertsController.Instance.AdvancedSettingsEnabled ? AlertsController.Instance.TitleOutlineSize : AlertsController.Instance.SimpleFontOutlineSize;
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Value = AlertsController.Instance.DescriptionOutlineSize;
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Value = AlertsController.Instance.PointsOutlineSize;
            alertsTabPage.alertsLineOutlineNumericUpDown.Value = AlertsController.Instance.LineOutlineSize;

            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Value = UserInfoController.Instance.AdvancedSettingsEnabled ? UserInfoController.Instance.NameOutlineSize : UserInfoController.Instance.SimpleFontOutlineSize;
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Value = UserInfoController.Instance.ValueOutlineSize;

            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Value = GameInfoController.Instance.AdvancedSettingsEnabled ? GameInfoController.Instance.NameOutlineSize : GameInfoController.Instance.SimpleFontOutlineSize;
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Value = GameInfoController.Instance.ValueOutlineSize;

            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Value = GameProgressController.Instance.AdvancedSettingsEnabled ? GameProgressController.Instance.NameOutlineSize : GameProgressController.Instance.SimpleFontOutlineSize;
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Value = GameProgressController.Instance.ValueOutlineSize;

            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Value = RecentUnlocksController.Instance.AdvancedSettingsEnabled ? RecentUnlocksController.Instance.TitleOutlineSize : RecentUnlocksController.Instance.SimpleFontOutlineSize;
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Value = RecentUnlocksController.Instance.DescriptionOutlineSize;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Value = RecentUnlocksController.Instance.PointsOutlineSize;
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Value = RecentUnlocksController.Instance.LineOutlineSize;

            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Value = RecentUnlocksController.Instance.MaxListSize;

            if (AlertsController.Instance.CustomAchievementScale > alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementScale = alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementScale < alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementScale = alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementX > alertsTabPage.alertsCustomAchievementXNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementX = (int)alertsTabPage.alertsCustomAchievementXNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementX < alertsTabPage.alertsCustomAchievementXNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementX = (int)alertsTabPage.alertsCustomAchievementXNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementY > alertsTabPage.alertsCustomAchievementYNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementY = (int)alertsTabPage.alertsCustomAchievementYNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementY < alertsTabPage.alertsCustomAchievementYNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementY = (int)alertsTabPage.alertsCustomAchievementYNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementInTime > alertsTabPage.alertsCustomAchievementInNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementInTime = (int)alertsTabPage.alertsCustomAchievementInNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementInTime < alertsTabPage.alertsCustomAchievementInNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementInTime = (int)alertsTabPage.alertsCustomAchievementInNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementOutTime > alertsTabPage.alertsCustomAchievementOutNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementOutTime = (int)alertsTabPage.alertsCustomAchievementOutNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementOutTime < alertsTabPage.alertsCustomAchievementOutNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementOutTime = (int)alertsTabPage.alertsCustomAchievementOutNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementInSpeed > alertsTabPage.alertsCustomAchievementInSpeedUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementInSpeed = (int)alertsTabPage.alertsCustomAchievementInSpeedUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementInSpeed < alertsTabPage.alertsCustomAchievementInSpeedUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementInSpeed = (int)alertsTabPage.alertsCustomAchievementInSpeedUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomAchievementOutSpeed > alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Maximum)
            {
                AlertsController.Instance.CustomAchievementOutSpeed = (int)alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomAchievementOutSpeed < alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Minimum)
            {
                AlertsController.Instance.CustomAchievementOutSpeed = (int)alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryScale > alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryScale = alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryScale < alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryScale = alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryX > alertsTabPage.alertsCustomMasteryXNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryX = (int)alertsTabPage.alertsCustomMasteryXNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryX < alertsTabPage.alertsCustomMasteryXNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryX = (int)alertsTabPage.alertsCustomMasteryXNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryY > alertsTabPage.alertsCustomMasteryYNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryY = (int)alertsTabPage.alertsCustomMasteryYNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryY < alertsTabPage.alertsCustomMasteryYNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryY = (int)alertsTabPage.alertsCustomMasteryYNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryInTime > alertsTabPage.alertsCustomMasteryInNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryInTime = (int)alertsTabPage.alertsCustomMasteryInNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryInTime < alertsTabPage.alertsCustomMasteryInNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryInTime = (int)alertsTabPage.alertsCustomMasteryInNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryOutTime > alertsTabPage.alertsCustomMasteryOutNumericUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryOutTime = (int)alertsTabPage.alertsCustomMasteryOutNumericUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryOutTime < alertsTabPage.alertsCustomMasteryOutNumericUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryOutTime = (int)alertsTabPage.alertsCustomMasteryOutNumericUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryInSpeed > alertsTabPage.alertsCustomMasteryInSpeedUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryInSpeed = (int)alertsTabPage.alertsCustomMasteryInSpeedUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryInSpeed < alertsTabPage.alertsCustomMasteryInSpeedUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryInSpeed = (int)alertsTabPage.alertsCustomMasteryInSpeedUpDown.Minimum;
            }

            if (AlertsController.Instance.CustomMasteryOutSpeed > alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Maximum)
            {
                AlertsController.Instance.CustomMasteryOutSpeed = (int)alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Maximum;
            }
            else if (AlertsController.Instance.CustomMasteryOutSpeed < alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Minimum)
            {
                AlertsController.Instance.CustomMasteryOutSpeed = (int)alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Minimum;
            }

            foreach (AnimationDirection direction in Enum.GetValues(typeof(AnimationDirection)))
            {
                string value = direction.ToString();
                alertsTabPage.alertsCustomAchievementAnimationInComboBox.Items.Add(value);
                alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Items.Add(value);
                alertsTabPage.alertsCustomMasteryAnimationInComboBox.Items.Add(value);
                alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Items.Add(value);
            }

            alertsTabPage.alertsCustomAchievementAnimationInComboBox.SelectedIndex = alertsTabPage.alertsCustomAchievementAnimationInComboBox.Items.IndexOf(AlertsController.Instance.AchievementAnimationIn.ToString());
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.SelectedIndex = alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Items.IndexOf(AlertsController.Instance.AchievementAnimationOut.ToString());
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.SelectedIndex = alertsTabPage.alertsCustomMasteryAnimationInComboBox.Items.IndexOf(AlertsController.Instance.MasteryAnimationIn.ToString());
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.SelectedIndex = alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Items.IndexOf(AlertsController.Instance.MasteryAnimationOut.ToString());

            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Value = AlertsController.Instance.CustomAchievementScale;
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Value = AlertsController.Instance.CustomMasteryScale;

            alertsTabPage.alertsCustomAchievementInNumericUpDown.Value = AlertsController.Instance.CustomAchievementInTime;
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Value = AlertsController.Instance.CustomAchievementOutTime;

            alertsTabPage.alertsCustomMasteryInNumericUpDown.Value = AlertsController.Instance.CustomMasteryInTime;
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Value = AlertsController.Instance.CustomMasteryOutTime;

            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Value = AlertsController.Instance.CustomAchievementInSpeed;
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Value = AlertsController.Instance.CustomAchievementOutSpeed;

            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Value = AlertsController.Instance.CustomMasteryInSpeed;
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Value = AlertsController.Instance.CustomMasteryOutSpeed;

            alertsTabPage.alertsCustomAchievementXNumericUpDown.Value = AlertsController.Instance.CustomAchievementX;
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Value = AlertsController.Instance.CustomAchievementY;

            alertsTabPage.alertsCustomMasteryXNumericUpDown.Value = AlertsController.Instance.CustomMasteryX;
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Value = AlertsController.Instance.CustomMasteryY;

            // Auto-Scrolling
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Checked = RecentUnlocksController.Instance.AutoScroll;
            achievementsListTabPage.achievementListAutoScrollCheckBox.Checked = AchievementListController.Instance.AutoScroll;

            UpdateAdvancedSettings();
            UpdateAlertsEnabledControls();

            UpdateRelatedMediaRadioButtons();
            UpdateRefocusBehaviorRadioButtons();
            UpdateDividerCharacterRadioButtons();
        }
    }

    public enum AnimationDirection
    {
        STATIC,
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
}
