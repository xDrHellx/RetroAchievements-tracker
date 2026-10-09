using System.Collections.Generic;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using Retro_Achievement_Tracker.Tabs;

namespace Retro_Achievement_Tracker
{
    public partial class MainWindow : Form
    {
        #region Main

        string Username
        {
            get => Settings.Default.ra_username;
            set => Settings.Default.ra_username = value;
        }
        string WebAPIKey
        {
            get => Settings.Default.ra_key;
            set => Settings.Default.ra_key = value;
        }
        long PreviouslyPlayedGameId
        {
            get => Settings.Default.previously_played_game;
            set => Settings.Default.previously_played_game = (int)value;
        }

        List<Achievement> LockedAchievements
        {
            get
            {
                if (GameInfoAndProgress != null && GameInfoAndProgress.Achievements != null)
                {
                    return GameInfoAndProgress.Achievements.FindAll(x => !x.DateEarned.HasValue);
                }
                return new List<Achievement>();
            }
        }

        List<Achievement> UnlockedAchievements
        {
            get
            {
                if (GameInfoAndProgress != null && GameInfoAndProgress.Achievements != null)
                {
                    return GameInfoAndProgress.Achievements.FindAll(x => x.DateEarned.HasValue);
                }
                return new List<Achievement>();
            }
        }

        bool ShouldRun,
            IsChanging,
            IsBooting,
            IsStarting;

        int CurrentlyViewingIndex,
            UserAndGameTimerCounter,
            MaxCheevoCount = 0;

        UserSummary UserSummary;
        GameInfo GameInfoAndProgress;
        Achievement CurrentlyViewingAchievement;
        List<Achievement> OldUnlockedAchievements;
        Timer UserAndGameUpdateTimer;
        RetroAchievementAPIClient RetroAchievementsAPIClient;

        #endregion

        #region WinForm

        OpenFileDialog openFileDialog;
        ColorDialog colorDialog;
        FolderBrowserDialog folderBrowserDialog;
        FocusTab focusTabPage;
        AlertsTab alertsTabPage;
        UserInfoTab userInfoTabPage;
        GameInfoTab gameInfoTabPage;
        GameProgressTab gameProgressTabPage;
        RecentAchievementsTab recentAchievementsTabPage;
        AchievementsListTab achievementsListTabPage;
        RelatedMediaTab relatedMediaTabPage;
        TabPage achievementTabPage,
            masteryTabPage;
        TabControl mainTabControl,
            alertTabControl;
        Label usernameLabel,
            apiKeyLabel,
            autoPollingStatusLabel,
            label2,
            label4,
            label3,
            label27,
            label26,
            label25,
            label15,
            label9,
            label32,
            label30,
            label29,
            label31,
            label28,
            label33,
            label34,
            label35,
            label37,
            label39,
            label40,
            label72,
            label73,
            label74,
            label75,
            label76,
            label77,
            label38,
            label41,
            label43,
            label44,
            label45,
            label46,
            label47,
            label50,
            label52,
            label56,
            label55,
            label54,
            label53,
            label51,
            label87,
            label63,
            label64,
            label65,
            label66,
            label67,
            label68,
            label69,
            label70,
            label71,
            label78,
            label79,
            label80,
            label81,
            label82,
            label83,
            label86,
            label88,
            label106,
            label96,
            label107,
            label108,
            label97,
            label98,
            label99,
            label100,
            label110,
            label101,
            label102,
            label104,
            label105,
            label111,
            label112,
            label113,
            label114,
            label115,
            label116,
            label117,
            label118,
            label119,
            label120,
            label122,
            label123,
            label124,
            label126,
            label127,
            label135,
            label129,
            label42,
            label128,
            label130,
            label131,
            label132,
            label133,
            label134,
            label136,
            label137,
            label138,
            label6,
            label7,
            label8,
            label11,
            label12,
            label13,
            label14,
            label139,
            label140,
            label141,
            label142,
            label143,
            label16,
            label17,
            label18,
            label19,
            label20,
            label21,
            label22,
            label23,
            label144,
            label145,
            label146,
            label148,
            label149,
            label150,
            label151,
            label156,
            label155,
            label152,
            label89,
            label62,
            label61,
            label57,
            label60,
            label59,
            label58,
            label36,
            label1,
            label90,
            label91,
            label92,
            manualSearchLabel;
        TextBox apiKeyTextBox,
            usernameTextBox,
            manualSearchTextBox;
        PictureBox userProfilePictureBox,
            autoPollingStatusPictureBox,
            pictureBox2,
            pictureBox3,
            pictureBox4,
            pictureBox17,
            pictureBox6,
            pictureBox5,
            pictureBox7,
            pictureBox9,
            pictureBox11,
            pictureBox8,
            pictureBox10,
            pictureBox12,
            pictureBox20,
            pictureBox13,
            pictureBox14,
            pictureBox23,
            pictureBox16,
            pictureBox15,
            pictureBox18,
            pictureBox21,
            pictureBox22,
            pictureBox19;
        Button startButton,
            stopButton,
            checkForUpdatesButton,
            manualSearchButton,
            unlockAchievementButton;
        CheckBox autoStartCheckbox;
        Panel panel1,
            panel2,
            panel3,
            panel6,
            panel5,
            panel7,
            panel10,
            panel12,
            panel11,
            panel13,
            panel4,
            panel20,
            panel21,
            panel22,
            panel36,
            panel37,
            panel38,
            panel39,
            panel40,
            panel41,
            panel14,
            panel15,
            panel16,
            panel18,
            panel19,
            panel23,
            panel26,
            panel28,
            panel27,
            panel25,
            panel29,
            panel48,
            panel30,
            panel31,
            panel32,
            panel33,
            panel34,
            panel35,
            panel42,
            panel44,
            panel45,
            panel46,
            panel49,
            panel51,
            panel59,
            panel52,
            panel61,
            panel54,
            panel55,
            panel50,
            panel63,
            panel64,
            panel65,
            panel67,
            panel69,
            panel70,
            panel73,
            panel74,
            panel84,
            panel83,
            panel78,
            panel79,
            panel80,
            panel81,
            panel82,
            panel85,
            panel86,
            panel87,
            panel89,
            panel90,
            panel91,
            panel92,
            panel93,
            panel94,
            panel95,
            panel96,
            panel97,
            panel98,
            panel99,
            panel101,
            panel103,
            panel104,
            panel107,
            panel108,
            panel111,
            panel112,
            panel114,
            panel113,
            panel115,
            panel119,
            panel117,
            panel118,
            panel116,
            panel120,
            panel121,
            panel122,
            panel123,
            panel124,
            panel8,
            panel9;

        #endregion
    }
}
