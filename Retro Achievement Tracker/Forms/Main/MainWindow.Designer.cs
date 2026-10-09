using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Retro_Achievement_Tracker.Tabs;

namespace Retro_Achievement_Tracker
{
    partial class MainWindow
    {
        /// <summary>Required designer variable.</summary>
        IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));

            // Search
            manualSearchLabel = new Label();
            manualSearchTextBox = new TextBox();
            manualSearchButton = new Button();
            
            // RA account & API interactions
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            apiKeyLabel = new Label();
            apiKeyTextBox = new TextBox();
            checkForUpdatesButton = new Button();
            autoStartCheckbox = new CheckBox();
            startButton = new Button();
            stopButton = new Button();
            autoPollingStatusLabel = new Label();

            folderBrowserDialog = new FolderBrowserDialog();
            userProfilePictureBox = new PictureBox();

            // Main tabs
            mainTabControl = new TabControl();
            focusTabPage = new FocusTab();
            alertsTabPage = new AlertsTab();
            alertTabControl = new TabControl();
            achievementTabPage = new TabPage();
            masteryTabPage = new TabPage();
            userInfoTabPage = new UserInfoTab();
            gameInfoTabPage = new GameInfoTab();
            gameProgressTabPage = new GameProgressTab();
            recentAchievementsTabPage = new RecentAchievementsTab();
            achievementsListTabPage = new AchievementsListTab();
            relatedMediaTabPage = new RelatedMediaTab();

            // Elements
            focusTabPage.focusAchievementPictureBox = new PictureBox();
            focusTabPage.focusAchievementTitleLabel = new Label();
            focusTabPage.focusAchievementDescriptionLabel = new Label();
            focusTabPage.focusSetButton = new Button();
            focusTabPage.focusAchievementButtonPrevious = new Button();
            focusTabPage.focusAchievementButtonNext = new Button();
            gameInfoTabPage.gameInfoPictureBox = new PictureBox();
            autoPollingStatusPictureBox = new PictureBox();
            alertsTabPage.alertsPlayAchievementButton = new Button();
            alertsTabPage.alertsSelectCustomAchievementFileButton = new Button();
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementXNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementYNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsAchievementEditOutlineCheckbox = new CheckBox();
            alertsTabPage.alertsCustomAchievementOutNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox = new ComboBox();
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementInNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementAnimationInComboBox = new ComboBox();
            alertsTabPage.alertsCustomAchievementInSpeedUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomAchievementEnableCheckbox = new CheckBox();
            alertsTabPage.alertsPlayMasteryButton = new Button();
            alertsTabPage.alertsSelectCustomMasteryFileButton = new Button();
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryXNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryYNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsMasteryEditOutlineCheckbox = new CheckBox();
            alertsTabPage.alertsCustomMasteryOutNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox = new ComboBox();
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryInNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryAnimationInComboBox = new ComboBox();
            alertsTabPage.alertsCustomMasteryInSpeedUpDown = new NumericUpDown();
            alertsTabPage.alertsCustomMasteryEnableCheckbox = new CheckBox();
            userInfoTabPage.userInfoAutoOpenWindowCheckbox = new CheckBox();
            userInfoTabPage.userInfoOpenWindowButton = new Button();
            userInfoTabPage.userInfoTruePointsTextBox = new TextBox();
            userInfoTabPage.userInfoPointsTextBox = new TextBox();
            userInfoTabPage.userInfoRatioTextBox = new TextBox();
            userInfoTabPage.userInfoRankTextBox = new TextBox();
            userInfoTabPage.userInfoTruePointsCheckBox = new CheckBox();
            userInfoTabPage.userInfoRatioCheckBox = new CheckBox();
            userInfoTabPage.userInfoPointsCheckBox = new CheckBox();
            userInfoTabPage.userInfoDefaultButton = new Button();
            userInfoTabPage.userInfoRankCheckBox = new CheckBox();
            openFileDialog = new OpenFileDialog();
            colorDialog = new ColorDialog();
            focusTabPage.focusBehaviorGoToLastRadioButton = new RadioButton();
            focusTabPage.focusBehaviorGoToNextRadioButton = new RadioButton();
            focusTabPage.focusBehaviorGoToPreviousRadioButton = new RadioButton();
            focusTabPage.focusBehaviorGoToFirstRadioButton = new RadioButton();
            recentAchievementsTabPage.recentAchievementsMaxListLabel = new Label();
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown = new NumericUpDown();
            panel64 = new Panel();
            label112 = new Label();
            pictureBox12 = new PictureBox();
            panel63 = new Panel();
            unlockAchievementButton = new Button();
            label111 = new Label();
            pictureBox10 = new PictureBox();
            panel51 = new Panel();
            focusTabPage.focusLinePanel = new Panel();
            label106 = new Label();
            focusTabPage.focusLineColorPictureBox = new PictureBox();
            label96 = new Label();
            panel59 = new Panel();
            focusTabPage.focusBorderCheckBox = new CheckBox();
            focusTabPage.focusBorderColorPictureBox = new PictureBox();
            label107 = new Label();
            focusTabPage.focusPointsPanel = new Panel();
            label108 = new Label();
            focusTabPage.focusPointsFontColorPictureBox = new PictureBox();
            focusTabPage.focusPointsFontComboBox = new ComboBox();
            panel52 = new Panel();
            focusTabPage.focusAdvancedCheckBox = new CheckBox();
            label97 = new Label();
            label98 = new Label();
            label99 = new Label();
            label100 = new Label();
            panel61 = new Panel();
            focusTabPage.focusTitleFontOutlineNumericUpDown = new NumericUpDown();
            focusTabPage.focusTitleOutlineCheckBox = new CheckBox();
            focusTabPage.focusTitleOutlineLabel = new Label();
            focusTabPage.focusTitleFontOutlineColorPictureBox = new PictureBox();
            focusTabPage.focusOpenWindowButton = new Button();
            focusTabPage.focusDescriptionOutlinePanel = new Panel();
            label110 = new Label();
            focusTabPage.focusDescriptionFontOutlineColorPictureBox = new PictureBox();
            focusTabPage.focusDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            focusTabPage.focusDescriptionOutlineCheckBox = new CheckBox();
            focusTabPage.focusDescriptionPanel = new Panel();
            label101 = new Label();
            focusTabPage.focusDescriptionFontColorPictureBox = new PictureBox();
            focusTabPage.focusDescriptionFontComboBox = new ComboBox();
            focusTabPage.focusAutoOpenWindowCheckBox = new CheckBox();
            pictureBox11 = new PictureBox();
            panel54 = new Panel();
            focusTabPage.focusBackgroundColorPictureBox = new PictureBox();
            label102 = new Label();
            panel55 = new Panel();
            focusTabPage.focusTitleLabel = new Label();
            focusTabPage.focusTitleFontColorPictureBox = new PictureBox();
            focusTabPage.focusTitleFontComboBox = new ComboBox();
            focusTabPage.focusPointsOutlinePanel = new Panel();
            focusTabPage.focusPointsFontOutlineNumericUpDown = new NumericUpDown();
            focusTabPage.focusPointsOutlineCheckBox = new CheckBox();
            label104 = new Label();
            focusTabPage.focusPointsFontOutlineColorPictureBox = new PictureBox();
            focusTabPage.focusLineOutlinePanel = new Panel();
            label105 = new Label();
            focusTabPage.focusLineOutlineColorPictureBox = new PictureBox();
            focusTabPage.focusLineOutlineNumericUpDown = new NumericUpDown();
            focusTabPage.focusLineOutlineCheckBox = new CheckBox();
            panel65 = new Panel();
            alertsTabPage.alertsLinePanel = new Panel();
            label113 = new Label();
            alertsTabPage.alertsLineColorPictureBox = new PictureBox();
            label114 = new Label();
            panel67 = new Panel();
            alertsTabPage.alertsBorderCheckBox = new CheckBox();
            alertsTabPage.alertsBorderColorPictureBox = new PictureBox();
            label115 = new Label();
            alertsTabPage.alertsPointsPanel = new Panel();
            label116 = new Label();
            alertsTabPage.alertsPointsFontColorPictureBox = new PictureBox();
            alertsTabPage.alertsPointsFontComboBox = new ComboBox();
            panel69 = new Panel();
            alertsTabPage.alertsAdvancedCheckBox = new CheckBox();
            label117 = new Label();
            label118 = new Label();
            label119 = new Label();
            label120 = new Label();
            panel70 = new Panel();
            alertsTabPage.alertsTitleFontOutlineNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsTitleOutlineCheckBox = new CheckBox();
            alertsTabPage.alertsTitleOutlineLabel = new Label();
            alertsTabPage.alertsTitleFontOutlineColorPictureBox = new PictureBox();
            alertsTabPage.alertsOpenWindowButton = new Button();
            alertsTabPage.alertsDescriptionOutlinePanel = new Panel();
            label122 = new Label();
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox = new PictureBox();
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsDescriptionOutlineCheckBox = new CheckBox();
            alertsTabPage.alertsDescriptionPanel = new Panel();
            label123 = new Label();
            alertsTabPage.alertsDescriptionFontColorPictureBox = new PictureBox();
            alertsTabPage.alertsDescriptionFontComboBox = new ComboBox();
            alertsTabPage.alertsAutoOpenWindowCheckbox = new CheckBox();
            pictureBox20 = new PictureBox();
            panel73 = new Panel();
            alertsTabPage.alertsBackgroundColorPictureBox = new PictureBox();
            label124 = new Label();
            panel74 = new Panel();
            alertsTabPage.alertsTitleLabel = new Label();
            alertsTabPage.alertsTitleFontColorPictureBox = new PictureBox();
            alertsTabPage.alertsTitleFontComboBox = new ComboBox();
            alertsTabPage.alertsPointsOutlinePanel = new Panel();
            alertsTabPage.alertsPointsFontOutlineNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsPointsOutlineCheckBox = new CheckBox();
            label126 = new Label();
            alertsTabPage.alertsPointsFontOutlineColorPictureBox = new PictureBox();
            alertsTabPage.alertsLineOutlinePanel = new Panel();
            label127 = new Label();
            alertsTabPage.alertsLineOutlineColorPictureBox = new PictureBox();
            alertsTabPage.alertsLineOutlineNumericUpDown = new NumericUpDown();
            alertsTabPage.alertsLineOutlineCheckBox = new CheckBox();
            alertsTabPage.alertsCustomAchievementPanel = new Panel();
            panel85 = new Panel();
            label136 = new Label();
            panel84 = new Panel();
            label135 = new Label();
            panel86 = new Panel();
            label137 = new Label();
            panel83 = new Panel();
            label129 = new Label();
            panel87 = new Panel();
            label138 = new Label();
            panel78 = new Panel();
            label42 = new Label();
            label128 = new Label();
            label130 = new Label();
            pictureBox13 = new PictureBox();
            panel79 = new Panel();
            label131 = new Label();
            panel80 = new Panel();
            label132 = new Label();
            panel81 = new Panel();
            label133 = new Label();
            panel82 = new Panel();
            label134 = new Label();
            alertsTabPage.alertsAchievementEnableCheckbox = new CheckBox();
            alertsTabPage.alertsCustomMasteryPanel = new Panel();
            panel89 = new Panel();
            label6 = new Label();
            panel90 = new Panel();
            label7 = new Label();
            panel91 = new Panel();
            label8 = new Label();
            panel92 = new Panel();
            label11 = new Label();
            panel93 = new Panel();
            label12 = new Label();
            panel94 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label139 = new Label();
            pictureBox14 = new PictureBox();
            panel95 = new Panel();
            label140 = new Label();
            panel96 = new Panel();
            label141 = new Label();
            panel97 = new Panel();
            label142 = new Label();
            panel98 = new Panel();
            label143 = new Label();
            alertsTabPage.alertsMasteryEnableCheckbox = new CheckBox();
            panel14 = new Panel();
            userInfoTabPage.userInfoUsernameLabel = new Label();
            userInfoTabPage.userInfoRankLabel = new Label();
            userInfoTabPage.userInfoPointsLabel = new Label();
            label37 = new Label();
            userInfoTabPage.userInfoTruePointsLabel = new Label();
            userInfoTabPage.userInfoMottoLabel = new Label();
            userInfoTabPage.userInfoRatioLabel = new Label();
            pictureBox2 = new PictureBox();
            panel21 = new Panel();
            panel22 = new Panel();
            label29 = new Label();
            label32 = new Label();
            label30 = new Label();
            label28 = new Label();
            pictureBox4 = new PictureBox();
            panel10 = new Panel();
            label31 = new Label();
            panel13 = new Panel();
            label35 = new Label();
            panel12 = new Panel();
            label34 = new Label();
            panel11 = new Panel();
            label33 = new Label();
            panel20 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            userInfoTabPage.userInfoAdvancedCheckBox = new CheckBox();
            label4 = new Label();
            label9 = new Label();
            label25 = new Label();
            label15 = new Label();
            userInfoTabPage.userInfoValuesPanel = new Panel();
            label26 = new Label();
            userInfoTabPage.userInfoValuesFontColorPictureBox = new PictureBox();
            userInfoTabPage.userInfoValuesFontComboBox = new ComboBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            userInfoTabPage.userInfoBackgroundColorPictureBox = new PictureBox();
            label3 = new Label();
            panel6 = new Panel();
            userInfoTabPage.userInfoNamesLabel = new Label();
            userInfoTabPage.userInfoNamesFontColorPictureBox = new PictureBox();
            userInfoTabPage.userInfoNamesFontComboBox = new ComboBox();
            panel7 = new Panel();
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            userInfoTabPage.userInfoNamesOutlineCheckBox = new CheckBox();
            userInfoTabPage.userInfoNamesOutlineLabel = new Label();
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox = new PictureBox();
            userInfoTabPage.userInfoValuesOutlinePanel = new Panel();
            label27 = new Label();
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox = new PictureBox();
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            userInfoTabPage.userInfoValuesOutlineCheckBox = new CheckBox();
            panel50 = new Panel();
            panel119 = new Panel();
            gameInfoTabPage.gameInfoGenreLabel = new Label();
            label62 = new Label();
            label36 = new Label();
            panel117 = new Panel();
            label89 = new Label();
            gameInfoTabPage.gameInfoReleasedLabel = new Label();
            panel118 = new Panel();
            label61 = new Label();
            gameInfoTabPage.gameInfoPublisherLabel = new Label();
            panel116 = new Panel();
            label57 = new Label();
            gameInfoTabPage.gameInfoDeveloperLabel = new Label();
            gameInfoTabPage.gameInfoTitleLabel = new Label();
            pictureBox8 = new PictureBox();
            panel29 = new Panel();
            panel49 = new Panel();
            label88 = new Label();
            gameInfoTabPage.gameInfoReleasedCheckBox = new CheckBox();
            gameInfoTabPage.gameInfoReleaseDateTextBox = new TextBox();
            panel48 = new Panel();
            label87 = new Label();
            gameInfoTabPage.gameInfoGenreCheckBox = new CheckBox();
            gameInfoTabPage.gameInfoGenreTextBox = new TextBox();
            panel30 = new Panel();
            label63 = new Label();
            label64 = new Label();
            label65 = new Label();
            label66 = new Label();
            gameInfoTabPage.gameInfoDefaultButton = new Button();
            pictureBox7 = new PictureBox();
            panel31 = new Panel();
            label67 = new Label();
            gameInfoTabPage.gameInfoTitleCheckBox = new CheckBox();
            gameInfoTabPage.gameInfoTitleTextBox = new TextBox();
            panel32 = new Panel();
            label68 = new Label();
            gameInfoTabPage.gameInfoConsoleCheckBox = new CheckBox();
            gameInfoTabPage.gameInfoConsoleTextBox = new TextBox();
            panel33 = new Panel();
            label69 = new Label();
            gameInfoTabPage.gameInfoPublisherTextBox = new TextBox();
            gameInfoTabPage.gameInfoPublisherCheckBox = new CheckBox();
            panel34 = new Panel();
            label70 = new Label();
            gameInfoTabPage.gameInfoDeveloperTextBox = new TextBox();
            gameInfoTabPage.gameInfoDeveloperCheckBox = new CheckBox();
            panel35 = new Panel();
            label71 = new Label();
            panel42 = new Panel();
            gameInfoTabPage.gameInfoAdvancedCheckBox = new CheckBox();
            label78 = new Label();
            label79 = new Label();
            label80 = new Label();
            label81 = new Label();
            gameInfoTabPage.gameInfoOpenWindowButton = new Button();
            gameInfoTabPage.gameInfoValuesPanel = new Panel();
            label82 = new Label();
            gameInfoTabPage.gameInfoValuesFontColorPictureBox = new PictureBox();
            gameInfoTabPage.gameInfoValuesFontComboBox = new ComboBox();
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox = new CheckBox();
            pictureBox9 = new PictureBox();
            panel44 = new Panel();
            gameInfoTabPage.gameInfoBackgroundColorPictureBox = new PictureBox();
            label83 = new Label();
            panel45 = new Panel();
            gameInfoTabPage.gameInfoNamesLabel = new Label();
            gameInfoTabPage.gameInfoNamesFontColorPictureBox = new PictureBox();
            gameInfoTabPage.gameInfoNamesFontComboBox = new ComboBox();
            panel46 = new Panel();
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoTabPage.gameInfoNamesOutlineCheckBox = new CheckBox();
            gameInfoTabPage.gameInfoNamesOutlineLabel = new Label();
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox = new PictureBox();
            gameInfoTabPage.gameInfoValuesOutlinePanel = new Panel();
            label86 = new Label();
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox = new PictureBox();
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoTabPage.gameInfoValuesOutlineCheckBox = new CheckBox();
            panel28 = new Panel();
            gameProgressTabPage.gameProgressPointsTextLabel = new Label();
            gameProgressTabPage.gameProgressHardcoreWorthLabel = new Label();
            gameProgressTabPage.gameProgressPoints2Label = new Label();
            gameProgressTabPage.gameProgressTruePoints2Label = new Label();
            gameProgressTabPage.gameProgressAchievements2Label = new Label();
            gameProgressTabPage.gameProgressHaveEarnedLabel = new Label();
            gameProgressTabPage.gameProgressPercentCompletePictureBox = new PictureBox();
            gameProgressTabPage.gameProgressMasteryPictureBox = new PictureBox();
            pictureBox21 = new PictureBox();
            label60 = new Label();
            label59 = new Label();
            label58 = new Label();
            label56 = new Label();
            pictureBox5 = new PictureBox();
            gameProgressTabPage.gameProgressAchievements1Label = new Label();
            gameProgressTabPage.gameProgressPoints1Label = new Label();
            gameProgressTabPage.gameProgressCompletedLabel = new Label();
            gameProgressTabPage.gameProgressTruePoints1Label = new Label();
            panel15 = new Panel();
            label38 = new Label();
            panel16 = new Panel();
            gameProgressTabPage.gameProgressAdvancedCheckBox = new CheckBox();
            label41 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            gameProgressTabPage.gameProgressOpenWindowButton = new Button();
            gameProgressTabPage.gameProgressValuesPanel = new Panel();
            label46 = new Label();
            gameProgressTabPage.gameProgressValuesFontColorPictureBox = new PictureBox();
            gameProgressTabPage.gameProgressValuesFontComboBox = new ComboBox();
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox = new CheckBox();
            pictureBox6 = new PictureBox();
            panel18 = new Panel();
            gameProgressTabPage.gameProgressBackgroundColorPictureBox = new PictureBox();
            label47 = new Label();
            panel19 = new Panel();
            gameProgressTabPage.gameProgressNamesLabel = new Label();
            gameProgressTabPage.gameProgressNamesFontColorPictureBox = new PictureBox();
            gameProgressTabPage.gameProgressNamesFontComboBox = new ComboBox();
            panel23 = new Panel();
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown = new NumericUpDown();
            gameProgressTabPage.gameProgressNamesOutlineCheckBox = new CheckBox();
            gameProgressTabPage.gameProgressNamesOutlineLabel = new Label();
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox = new PictureBox();
            gameProgressTabPage.gameProgressValuesOutlinePanel = new Panel();
            label50 = new Label();
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox = new PictureBox();
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown = new NumericUpDown();
            gameProgressTabPage.gameProgressValuesOutlineCheckBox = new CheckBox();
            panel36 = new Panel();
            panel27 = new Panel();
            label55 = new Label();
            gameProgressTabPage.gameProgressRadioButtonPeriod = new RadioButton();
            label54 = new Label();
            gameProgressTabPage.gameProgressRadioButtonColon = new RadioButton();
            label53 = new Label();
            gameProgressTabPage.gameProgressRadioButtonBackslash = new RadioButton();
            label51 = new Label();
            panel25 = new Panel();
            panel37 = new Panel();
            label39 = new Label();
            label40 = new Label();
            label72 = new Label();
            panel26 = new Panel();
            label52 = new Label();
            gameProgressTabPage.gameProgressCompletedTextBox = new TextBox();
            gameProgressTabPage.gameProgressCompletedCheckBox = new CheckBox();
            label73 = new Label();
            gameProgressTabPage.gameProgressDefaultButton = new Button();
            pictureBox17 = new PictureBox();
            panel38 = new Panel();
            label74 = new Label();
            gameProgressTabPage.gameProgressAchievementsCheckBox = new CheckBox();
            gameProgressTabPage.gameProgressAchievementsTextBox = new TextBox();
            panel39 = new Panel();
            label75 = new Label();
            gameProgressTabPage.gameProgressRatioCheckBox = new CheckBox();
            gameProgressTabPage.gameProgressRatioTextBox = new TextBox();
            panel40 = new Panel();
            label76 = new Label();
            gameProgressTabPage.gameProgressTruePointsTextBox = new TextBox();
            gameProgressTabPage.gameProgressTruePointsCheckBox = new CheckBox();
            panel41 = new Panel();
            label77 = new Label();
            gameProgressTabPage.gameProgressPointsTextBox = new TextBox();
            gameProgressTabPage.gameProgressPointsCheckBox = new CheckBox();
            panel113 = new Panel();
            label155 = new Label();
            pictureBox15 = new PictureBox();
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox = new CheckBox();
            panel99 = new Panel();
            recentAchievementsTabPage.recentAchievementsLinePanel = new Panel();
            label16 = new Label();
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox = new PictureBox();
            label17 = new Label();
            panel101 = new Panel();
            recentAchievementsTabPage.recentAchievementsBorderCheckBox = new CheckBox();
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox = new PictureBox();
            label18 = new Label();
            recentAchievementsTabPage.recentAchievementsPointsPanel = new Panel();
            label19 = new Label();
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox = new ComboBox();
            panel103 = new Panel();
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox = new CheckBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            panel104 = new Panel();
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox = new CheckBox();
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel = new Label();
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsOpenWindowButton = new Button();
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel = new Panel();
            label144 = new Label();
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox = new CheckBox();
            recentAchievementsTabPage.recentAchievementsDescriptionPanel = new Panel();
            label145 = new Label();
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox = new ComboBox();
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox = new CheckBox();
            pictureBox23 = new PictureBox();
            panel107 = new Panel();
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox = new PictureBox();
            label146 = new Label();
            panel108 = new Panel();
            recentAchievementsTabPage.recentAchievementsTitleLabel = new Label();
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox = new ComboBox();
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel = new Panel();
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox = new CheckBox();
            label148 = new Label();
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel = new Panel();
            label149 = new Label();
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox = new PictureBox();
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox = new CheckBox();
            panel115 = new Panel();
            label152 = new Label();
            pictureBox18 = new PictureBox();
            achievementsListTabPage.achievementListAutoScrollCheckBox = new CheckBox();
            panel111 = new Panel();
            panel9 = new Panel();
            achievementsListTabPage.achievementListWindowSizeLabel = new Label();
            achievementsListTabPage.achievementListWindowSizeXUpDown = new NumericUpDown();
            achievementsListTabPage.achievementListWindowSizeYUpDown = new NumericUpDown();
            label150 = new Label();
            panel112 = new Panel();
            label151 = new Label();
            achievementsListTabPage.achievementListOpenWindowButton = new Button();
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox = new CheckBox();
            pictureBox16 = new PictureBox();
            panel114 = new Panel();
            achievementsListTabPage.achievementListBackgroundColorPictureBox = new PictureBox();
            label156 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel120 = new Panel();
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton = new RadioButton();
            pictureBox19 = new PictureBox();
            label1 = new Label();
            panel121 = new Panel();
            label90 = new Label();
            panel122 = new Panel();
            label91 = new Label();
            relatedMediaTabPage.relatedMediaOpenWindowButton = new Button();
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox = new CheckBox();
            pictureBox22 = new PictureBox();
            panel123 = new Panel();
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox = new PictureBox();
            label92 = new Label();
            panel124 = new Panel();
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBannerRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton = new Button();
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton = new RadioButton();
            relatedMediaTabPage.relatedMediaLBLinePictureBox = new PictureBox();
            relatedMediaTabPage.relatedMediaLBLabel = new Label();
            panel8 = new Panel();

            ((ISupportInitialize)(userProfilePictureBox)).BeginInit();
            ((ISupportInitialize)(focusTabPage.focusAchievementPictureBox)).BeginInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoPictureBox)).BeginInit();
            ((ISupportInitialize)(autoPollingStatusPictureBox)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementScaleNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementXNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementYNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryScaleNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryXNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryYNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown)).BeginInit();
            panel64.SuspendLayout();
            ((ISupportInitialize)(pictureBox12)).BeginInit();
            panel63.SuspendLayout();
            ((ISupportInitialize)(pictureBox10)).BeginInit();
            panel51.SuspendLayout();
            focusTabPage.focusLinePanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusLineColorPictureBox)).BeginInit();
            panel59.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusBorderColorPictureBox)).BeginInit();
            focusTabPage.focusPointsPanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusPointsFontColorPictureBox)).BeginInit();
            panel52.SuspendLayout();
            panel61.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineColorPictureBox)).BeginInit();
            focusTabPage.focusDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineNumericUpDown)).BeginInit();
            focusTabPage.focusDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox11)).BeginInit();
            panel54.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusBackgroundColorPictureBox)).BeginInit();
            panel55.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusTitleFontColorPictureBox)).BeginInit();
            focusTabPage.focusPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineColorPictureBox)).BeginInit();
            focusTabPage.focusLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(focusTabPage.focusLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(focusTabPage.focusLineOutlineNumericUpDown)).BeginInit();
            panel65.SuspendLayout();
            alertsTabPage.alertsLinePanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsLineColorPictureBox)).BeginInit();
            panel67.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsBorderColorPictureBox)).BeginInit();
            alertsTabPage.alertsPointsPanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontColorPictureBox)).BeginInit();
            panel69.SuspendLayout();
            panel70.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineColorPictureBox)).BeginInit();
            alertsTabPage.alertsDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown)).BeginInit();
            alertsTabPage.alertsDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox20)).BeginInit();
            panel73.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsBackgroundColorPictureBox)).BeginInit();
            panel74.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontColorPictureBox)).BeginInit();
            alertsTabPage.alertsPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineColorPictureBox)).BeginInit();
            alertsTabPage.alertsLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(alertsTabPage.alertsLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(alertsTabPage.alertsLineOutlineNumericUpDown)).BeginInit();
            alertsTabPage.alertsCustomAchievementPanel.SuspendLayout();
            panel85.SuspendLayout();
            panel84.SuspendLayout();
            panel86.SuspendLayout();
            panel83.SuspendLayout();
            panel87.SuspendLayout();
            panel78.SuspendLayout();
            ((ISupportInitialize)(pictureBox13)).BeginInit();
            panel79.SuspendLayout();
            panel80.SuspendLayout();
            panel81.SuspendLayout();
            panel82.SuspendLayout();
            alertsTabPage.alertsCustomMasteryPanel.SuspendLayout();
            panel89.SuspendLayout();
            panel90.SuspendLayout();
            panel91.SuspendLayout();
            panel92.SuspendLayout();
            panel93.SuspendLayout();
            panel94.SuspendLayout();
            ((ISupportInitialize)(pictureBox14)).BeginInit();
            panel95.SuspendLayout();
            panel96.SuspendLayout();
            panel97.SuspendLayout();
            panel98.SuspendLayout();
            panel14.SuspendLayout();
            ((ISupportInitialize)(pictureBox2)).BeginInit();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            ((ISupportInitialize)(pictureBox4)).BeginInit();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel20.SuspendLayout();
            panel4.SuspendLayout();
            userInfoTabPage.userInfoValuesPanel.SuspendLayout();
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox3)).BeginInit();
            panel5.SuspendLayout();
            ((ISupportInitialize)(userInfoTabPage.userInfoBackgroundColorPictureBox)).BeginInit();
            panel6.SuspendLayout();
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontColorPictureBox)).BeginInit();
            panel7.SuspendLayout();
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox)).BeginInit();
            userInfoTabPage.userInfoValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown)).BeginInit();
            panel50.SuspendLayout();
            panel119.SuspendLayout();
            panel117.SuspendLayout();
            panel118.SuspendLayout();
            panel116.SuspendLayout();
            ((ISupportInitialize)(pictureBox8)).BeginInit();
            panel29.SuspendLayout();
            panel49.SuspendLayout();
            panel48.SuspendLayout();
            panel30.SuspendLayout();
            ((ISupportInitialize)(pictureBox7)).BeginInit();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            panel33.SuspendLayout();
            panel34.SuspendLayout();
            panel35.SuspendLayout();
            panel42.SuspendLayout();
            gameInfoTabPage.gameInfoValuesPanel.SuspendLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox9)).BeginInit();
            panel44.SuspendLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoBackgroundColorPictureBox)).BeginInit();
            panel45.SuspendLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontColorPictureBox)).BeginInit();
            panel46.SuspendLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox)).BeginInit();
            gameInfoTabPage.gameInfoValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown)).BeginInit();
            panel28.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressPercentCompletePictureBox)).BeginInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressMasteryPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox21)).BeginInit();
            ((ISupportInitialize)(pictureBox5)).BeginInit();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            gameProgressTabPage.gameProgressValuesPanel.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox6)).BeginInit();
            panel18.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressBackgroundColorPictureBox)).BeginInit();
            panel19.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontColorPictureBox)).BeginInit();
            panel23.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox)).BeginInit();
            gameProgressTabPage.gameProgressValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown)).BeginInit();
            panel36.SuspendLayout();
            panel27.SuspendLayout();
            panel37.SuspendLayout();
            panel26.SuspendLayout();
            ((ISupportInitialize)(pictureBox17)).BeginInit();
            panel38.SuspendLayout();
            panel39.SuspendLayout();
            panel40.SuspendLayout();
            panel41.SuspendLayout();
            panel113.SuspendLayout();
            ((ISupportInitialize)(pictureBox15)).BeginInit();
            panel99.SuspendLayout();
            recentAchievementsTabPage.recentAchievementsLinePanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineColorPictureBox)).BeginInit();
            panel101.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox)).BeginInit();
            recentAchievementsTabPage.recentAchievementsPointsPanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox)).BeginInit();
            panel103.SuspendLayout();
            panel104.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox)).BeginInit();
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown)).BeginInit();
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(pictureBox23)).BeginInit();
            panel107.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox)).BeginInit();
            panel108.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox)).BeginInit();
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox)).BeginInit();
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown)).BeginInit();
            panel115.SuspendLayout();
            ((ISupportInitialize)(pictureBox18)).BeginInit();
            panel111.SuspendLayout();
            panel9.SuspendLayout();
            ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeXUpDown)).BeginInit();
            ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeYUpDown)).BeginInit();
            panel112.SuspendLayout();
            ((ISupportInitialize)(pictureBox16)).BeginInit();
            panel114.SuspendLayout();
            ((ISupportInitialize)(achievementsListTabPage.achievementListBackgroundColorPictureBox)).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel120.SuspendLayout();
            ((ISupportInitialize)(pictureBox19)).BeginInit();
            panel121.SuspendLayout();
            panel122.SuspendLayout();
            ((ISupportInitialize)(pictureBox22)).BeginInit();
            panel123.SuspendLayout();
            ((ISupportInitialize)(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox)).BeginInit();
            panel124.SuspendLayout();
            ((ISupportInitialize)(relatedMediaTabPage.relatedMediaLBLinePictureBox)).BeginInit();
            mainTabControl.SuspendLayout();
            focusTabPage.SuspendLayout();
            alertsTabPage.SuspendLayout();
            alertTabControl.SuspendLayout();
            achievementTabPage.SuspendLayout();
            masteryTabPage.SuspendLayout();
            userInfoTabPage.SuspendLayout();
            gameInfoTabPage.SuspendLayout();
            gameProgressTabPage.SuspendLayout();
            recentAchievementsTabPage.SuspendLayout();
            achievementsListTabPage.SuspendLayout();
            relatedMediaTabPage.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();

            // 
            // apiKeyLabel
            // 
            apiKeyLabel.AutoSize = true;
            apiKeyLabel.BackColor = Color.Transparent;
            apiKeyLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            apiKeyLabel.ForeColor = Color.FromArgb(44, 151, 250);
            apiKeyLabel.Location = new Point(20, 6);
            apiKeyLabel.Margin = new Padding(4, 0, 4, 0);
            apiKeyLabel.Name = "apiKeyLabel";
            apiKeyLabel.Size = new Size(140, 25);
            apiKeyLabel.TabIndex = 31;
            apiKeyLabel.Text = "Web API Key";
            // 
            // apiKeyTextBox
            // 
            apiKeyTextBox.BackColor = Color.FromArgb(22, 22, 22);
            apiKeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            apiKeyTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            apiKeyTextBox.ForeColor = Color.White;
            apiKeyTextBox.Location = new Point(162, 3);
            apiKeyTextBox.Margin = new Padding(4, 5, 4, 5);
            apiKeyTextBox.Name = "apiKeyTextBox";
            apiKeyTextBox.PasswordChar = '*';
            apiKeyTextBox.Size = new Size(428, 31);
            apiKeyTextBox.TabIndex = 1;
            apiKeyTextBox.WordWrap = false;
            apiKeyTextBox.TextChanged += new System.EventHandler(RequiredField_TextChanged);
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = Color.FromArgb(44, 151, 250);
            usernameLabel.Location = new Point(50, 8);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(114, 25);
            usernameLabel.TabIndex = 26;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(22, 22, 22);
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(162, 5);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(428, 31);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.WordWrap = false;
            usernameTextBox.TextChanged += new System.EventHandler(RequiredField_TextChanged);
            // 
            // userProfilePictureBox
            // 
            userProfilePictureBox.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            userProfilePictureBox.BackColor = Color.Transparent;
            userProfilePictureBox.Cursor = Cursors.Hand;
            userProfilePictureBox.Location = new Point(576, 62);
            userProfilePictureBox.Margin = new Padding(4, 5, 4, 5);
            userProfilePictureBox.Name = "userProfilePictureBox";
            userProfilePictureBox.Size = new Size(96, 98);
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePictureBox.TabIndex = 20;
            userProfilePictureBox.TabStop = false;
            userProfilePictureBox.Click += new System.EventHandler(BrowserSensitiveControl_Click);
            // 
            // autoStartCheckbox
            // 
            autoStartCheckbox.AutoSize = true;
            autoStartCheckbox.BackColor = Color.Transparent;
            autoStartCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            autoStartCheckbox.FlatAppearance.BorderSize = 0;
            autoStartCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(118, 118, 118);
            autoStartCheckbox.FlatStyle = FlatStyle.Flat;
            autoStartCheckbox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            autoStartCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            autoStartCheckbox.Location = new Point(234, 109);
            autoStartCheckbox.Margin = new Padding(4, 5, 4, 5);
            autoStartCheckbox.Name = "autoStartCheckbox";
            autoStartCheckbox.Size = new Size(125, 26);
            autoStartCheckbox.TabIndex = 2;
            autoStartCheckbox.Text = "Auto-Start";
            autoStartCheckbox.UseVisualStyleBackColor = false;
            autoStartCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.FromArgb(22, 22, 22);
            stopButton.FlatAppearance.BorderColor = Color.Black;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            stopButton.ForeColor = Color.FromArgb(204, 153, 0);
            stopButton.Location = new Point(483, 97);
            stopButton.Margin = new Padding(0);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(112, 42);
            stopButton.TabIndex = 4;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += new System.EventHandler(StopButton_Click);
            // 
            // autoPollingStatusLabel
            // 
            autoPollingStatusLabel.BackColor = Color.Transparent;
            autoPollingStatusLabel.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            autoPollingStatusLabel.ForeColor = Color.FromArgb(44, 151, 250);
            autoPollingStatusLabel.Location = new Point(57, 14);
            autoPollingStatusLabel.Margin = new Padding(4, 0, 4, 0);
            autoPollingStatusLabel.Name = "autoPollingStatusLabel";
            autoPollingStatusLabel.Size = new Size(498, 43);
            autoPollingStatusLabel.TabIndex = 10024;
            autoPollingStatusLabel.Text = "Offline";
            // 
            // userInfoAutoOpenWindowCheckbox
            // 
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.AutoSize = true;
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Name = "userInfoAutoOpenWindowCheckbox";
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoOpenWindowButton
            // 
            userInfoTabPage.userInfoOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            userInfoTabPage.userInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            userInfoTabPage.userInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            userInfoTabPage.userInfoOpenWindowButton.Location = new Point(573, 3);
            userInfoTabPage.userInfoOpenWindowButton.Margin = new Padding(0);
            userInfoTabPage.userInfoOpenWindowButton.Name = "userInfoOpenWindowButton";
            userInfoTabPage.userInfoOpenWindowButton.Size = new Size(112, 42);
            userInfoTabPage.userInfoOpenWindowButton.TabIndex = 10021;
            userInfoTabPage.userInfoOpenWindowButton.Text = "Open";
            userInfoTabPage.userInfoOpenWindowButton.UseVisualStyleBackColor = false;
            userInfoTabPage.userInfoOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(22, 22, 22);
            startButton.FlatAppearance.BorderColor = Color.Black;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            startButton.ForeColor = Color.FromArgb(204, 153, 0);
            startButton.Location = new Point(370, 97);
            startButton.Margin = new Padding(0);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 42);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += new System.EventHandler(StartButton_Click);
            // 
            // focusAchievementPictureBox
            // 
            focusTabPage.focusAchievementPictureBox.BackColor = Color.Transparent;
            focusTabPage.focusAchievementPictureBox.Cursor = Cursors.Hand;
            focusTabPage.focusAchievementPictureBox.InitialImage = null;
            focusTabPage.focusAchievementPictureBox.Location = new Point(4, 62);
            focusTabPage.focusAchievementPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusAchievementPictureBox.Name = "focusAchievementPictureBox";
            focusTabPage.focusAchievementPictureBox.Size = new Size(168, 172);
            focusTabPage.focusAchievementPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            focusTabPage.focusAchievementPictureBox.TabIndex = 10030;
            focusTabPage.focusAchievementPictureBox.TabStop = false;
            focusTabPage.focusAchievementPictureBox.Click += new System.EventHandler(BrowserSensitiveControl_Click);
            // 
            // focusAchievementTitleLabel
            // 
            focusTabPage.focusAchievementTitleLabel.BackColor = Color.Transparent;
            focusTabPage.focusAchievementTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            focusTabPage.focusAchievementTitleLabel.Cursor = Cursors.Hand;
            focusTabPage.focusAchievementTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAchievementTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusAchievementTitleLabel.Location = new Point(182, 129);
            focusTabPage.focusAchievementTitleLabel.Margin = new Padding(4, 0, 4, 0);
            focusTabPage.focusAchievementTitleLabel.Name = "focusAchievementTitleLabel";
            focusTabPage.focusAchievementTitleLabel.Size = new Size(246, 104);
            focusTabPage.focusAchievementTitleLabel.TabIndex = 10027;
            focusTabPage.focusAchievementTitleLabel.Click += new System.EventHandler(BrowserSensitiveControl_Click);
            // 
            // focusAchievementDescriptionLabel
            // 
            focusTabPage.focusAchievementDescriptionLabel.BackColor = Color.Transparent;
            focusTabPage.focusAchievementDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            focusTabPage.focusAchievementDescriptionLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAchievementDescriptionLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusAchievementDescriptionLabel.Location = new Point(3, 238);
            focusTabPage.focusAchievementDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            focusTabPage.focusAchievementDescriptionLabel.Name = "focusAchievementDescriptionLabel";
            focusTabPage.focusAchievementDescriptionLabel.Size = new Size(425, 156);
            focusTabPage.focusAchievementDescriptionLabel.TabIndex = 10026;
            // 
            // focusSetButton
            // 
            focusTabPage.focusSetButton.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusSetButton.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusSetButton.FlatStyle = FlatStyle.Flat;
            focusTabPage.focusSetButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusSetButton.ForeColor = Color.FromArgb(204, 153, 0);
            focusTabPage.focusSetButton.Location = new Point(316, 405);
            focusTabPage.focusSetButton.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusSetButton.Name = "focusSetButton";
            focusTabPage.focusSetButton.Size = new Size(112, 42);
            focusTabPage.focusSetButton.TabIndex = 10031;
            focusTabPage.focusSetButton.Text = "Set";
            focusTabPage.focusSetButton.UseVisualStyleBackColor = false;
            focusTabPage.focusSetButton.Click += new System.EventHandler(SetFocusButton_Click);
            // 
            // focusAchievementButtonPrevious
            // 
            focusTabPage.focusAchievementButtonPrevious.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusAchievementButtonPrevious.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusAchievementButtonPrevious.FlatStyle = FlatStyle.Flat;
            focusTabPage.focusAchievementButtonPrevious.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAchievementButtonPrevious.ForeColor = Color.FromArgb(204, 153, 0);
            focusTabPage.focusAchievementButtonPrevious.Location = new Point(6, 405);
            focusTabPage.focusAchievementButtonPrevious.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusAchievementButtonPrevious.Name = "focusAchievementButtonPrevious";
            focusTabPage.focusAchievementButtonPrevious.Size = new Size(112, 42);
            focusTabPage.focusAchievementButtonPrevious.TabIndex = 10028;
            focusTabPage.focusAchievementButtonPrevious.Text = "<";
            focusTabPage.focusAchievementButtonPrevious.UseVisualStyleBackColor = false;
            focusTabPage.focusAchievementButtonPrevious.Click += new System.EventHandler(MoveFocusIndexPrev_Click);
            // 
            // focusAchievementButtonNext
            // 
            focusTabPage.focusAchievementButtonNext.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusAchievementButtonNext.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusAchievementButtonNext.FlatStyle = FlatStyle.Flat;
            focusTabPage.focusAchievementButtonNext.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAchievementButtonNext.ForeColor = Color.FromArgb(204, 153, 0);
            focusTabPage.focusAchievementButtonNext.Location = new Point(128, 405);
            focusTabPage.focusAchievementButtonNext.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusAchievementButtonNext.Name = "focusAchievementButtonNext";
            focusTabPage.focusAchievementButtonNext.Size = new Size(112, 42);
            focusTabPage.focusAchievementButtonNext.TabIndex = 10029;
            focusTabPage.focusAchievementButtonNext.Text = ">";
            focusTabPage.focusAchievementButtonNext.UseVisualStyleBackColor = false;
            focusTabPage.focusAchievementButtonNext.Click += new System.EventHandler(MoveFocusIndexNext_Click);
            // 
            // gameInfoPictureBox
            // 
            gameInfoTabPage.gameInfoPictureBox.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoPictureBox.Cursor = Cursors.Hand;
            gameInfoTabPage.gameInfoPictureBox.InitialImage = null;
            gameInfoTabPage.gameInfoPictureBox.Location = new Point(12, 80);
            gameInfoTabPage.gameInfoPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoPictureBox.Name = "gameInfoPictureBox";
            gameInfoTabPage.gameInfoPictureBox.Size = new Size(144, 148);
            gameInfoTabPage.gameInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameInfoTabPage.gameInfoPictureBox.TabIndex = 10004;
            gameInfoTabPage.gameInfoPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoPictureBox.Click += new System.EventHandler(BrowserSensitiveControl_Click);
            // 
            // autoPollingStatusPictureBox
            // 
            autoPollingStatusPictureBox.BackColor = Color.Transparent;
            autoPollingStatusPictureBox.Image = global::Retro_Achievement_Tracker.Properties.Resources.red_button;
            autoPollingStatusPictureBox.Location = new Point(6, 14);
            autoPollingStatusPictureBox.Margin = new Padding(4, 5, 4, 5);
            autoPollingStatusPictureBox.Name = "autoPollingStatusPictureBox";
            autoPollingStatusPictureBox.Size = new Size(42, 43);
            autoPollingStatusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            autoPollingStatusPictureBox.TabIndex = 10025;
            autoPollingStatusPictureBox.TabStop = false;
            // 
            // alertsPlayAchievementButton
            // 
            alertsTabPage.alertsPlayAchievementButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsPlayAchievementButton.FlatAppearance.BorderColor = Color.Black;
            alertsTabPage.alertsPlayAchievementButton.FlatStyle = FlatStyle.Flat;
            alertsTabPage.alertsPlayAchievementButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsPlayAchievementButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsTabPage.alertsPlayAchievementButton.Location = new Point(318, 5);
            alertsTabPage.alertsPlayAchievementButton.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPlayAchievementButton.Name = "alertsPlayAchievementButton";
            alertsTabPage.alertsPlayAchievementButton.Size = new Size(98, 38);
            alertsTabPage.alertsPlayAchievementButton.TabIndex = 2;
            alertsTabPage.alertsPlayAchievementButton.Text = "Play";
            alertsTabPage.alertsPlayAchievementButton.UseVisualStyleBackColor = false;
            alertsTabPage.alertsPlayAchievementButton.Click += new System.EventHandler(ShowAlertButton_Click);
            // 
            // alertsSelectCustomAchievementFileButton
            // 
            alertsTabPage.alertsSelectCustomAchievementFileButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsSelectCustomAchievementFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsTabPage.alertsSelectCustomAchievementFileButton.FlatStyle = FlatStyle.Flat;
            alertsTabPage.alertsSelectCustomAchievementFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsSelectCustomAchievementFileButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsTabPage.alertsSelectCustomAchievementFileButton.Location = new Point(314, 409);
            alertsTabPage.alertsSelectCustomAchievementFileButton.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsSelectCustomAchievementFileButton.Name = "alertsSelectCustomAchievementFileButton";
            alertsTabPage.alertsSelectCustomAchievementFileButton.Size = new Size(98, 38);
            alertsTabPage.alertsSelectCustomAchievementFileButton.TabIndex = 14;
            alertsTabPage.alertsSelectCustomAchievementFileButton.Text = "File";
            alertsTabPage.alertsSelectCustomAchievementFileButton.UseVisualStyleBackColor = false;
            alertsTabPage.alertsSelectCustomAchievementFileButton.Click += new System.EventHandler(SelectCustomAlertButton_Click);
            // 
            // alertsCustomAchievementScaleNumericUpDown
            // 
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.DecimalPlaces = 2;
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 131072});
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Name = "alertsCustomAchievementScaleNumericUpDown";
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.TabIndex = 20;
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementXNumericUpDown
            // 
            alertsTabPage.alertsCustomAchievementXNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementXNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Minimum = new decimal(new int[] {2000, 0, 0, -2147483648});
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Name = "alertsCustomAchievementXNumericUpDown";
            alertsTabPage.alertsCustomAchievementXNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementXNumericUpDown.TabIndex = 15;
            alertsTabPage.alertsCustomAchievementXNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementYNumericUpDown
            // 
            alertsTabPage.alertsCustomAchievementYNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementYNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Minimum = new decimal(new int[] {2000, 0, 0, -2147483648});
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Name = "alertsCustomAchievementYNumericUpDown";
            alertsTabPage.alertsCustomAchievementYNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementYNumericUpDown.TabIndex = 16;
            alertsTabPage.alertsCustomAchievementYNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsAchievementEditOutlineCheckbox
            // 
            alertsTabPage.alertsAchievementEditOutlineCheckbox.AutoSize = true;
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsAchievementEditOutlineCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Location = new Point(12, 414);
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Name = "alertsAchievementEditOutlineCheckbox";
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Size = new Size(137, 29);
            alertsTabPage.alertsAchievementEditOutlineCheckbox.TabIndex = 47;
            alertsTabPage.alertsAchievementEditOutlineCheckbox.Text = "Edit Mode";
            alertsTabPage.alertsAchievementEditOutlineCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsAchievementEditOutlineCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomAchievementOutNumericUpDown
            // 
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Minimum = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Name = "alertsCustomAchievementOutNumericUpDown";
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.TabIndex = 26;
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.Value = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementAnimationOutComboBox
            // 
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.FormattingEnabled = true;
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Location = new Point(252, 2);
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Name = "alertsCustomAchievementAnimationOutComboBox";
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.Size = new Size(144, 28);
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.TabIndex = 39;
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.SelectedIndexChanged += new System.EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomAchievementOutSpeedUpDown
            // 
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Minimum = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Name = "alertsCustomAchievementOutSpeedUpDown";
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.TabIndex = 48;
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.Value = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementInNumericUpDown
            // 
            alertsTabPage.alertsCustomAchievementInNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementInNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Minimum = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Name = "alertsCustomAchievementInNumericUpDown";
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementInNumericUpDown.TabIndex = 26;
            alertsTabPage.alertsCustomAchievementInNumericUpDown.Value = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementAnimationInComboBox
            // 
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.FormattingEnabled = true;
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.Location = new Point(252, 2);
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.Name = "alertsCustomAchievementAnimationInComboBox";
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.Size = new Size(144, 28);
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.TabIndex = 39;
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.SelectedIndexChanged += new System.EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomAchievementInSpeedUpDown
            // 
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Minimum = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Name = "alertsCustomAchievementInSpeedUpDown";
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.TabIndex = 48;
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.Value = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementEnableCheckbox
            // 
            alertsTabPage.alertsCustomAchievementEnableCheckbox.AutoSize = true;
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomAchievementEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Location = new Point(129, 9);
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Name = "alertsCustomAchievementEnableCheckbox";
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Size = new Size(114, 29);
            alertsTabPage.alertsCustomAchievementEnableCheckbox.TabIndex = 13;
            alertsTabPage.alertsCustomAchievementEnableCheckbox.Text = "Custom";
            alertsTabPage.alertsCustomAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsCustomAchievementEnableCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsPlayMasteryButton
            // 
            alertsTabPage.alertsPlayMasteryButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsPlayMasteryButton.FlatAppearance.BorderColor = Color.Black;
            alertsTabPage.alertsPlayMasteryButton.FlatStyle = FlatStyle.Flat;
            alertsTabPage.alertsPlayMasteryButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsPlayMasteryButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsTabPage.alertsPlayMasteryButton.Location = new Point(318, 5);
            alertsTabPage.alertsPlayMasteryButton.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPlayMasteryButton.Name = "alertsPlayMasteryButton";
            alertsTabPage.alertsPlayMasteryButton.Size = new Size(98, 38);
            alertsTabPage.alertsPlayMasteryButton.TabIndex = 2;
            alertsTabPage.alertsPlayMasteryButton.Text = "Play";
            alertsTabPage.alertsPlayMasteryButton.UseVisualStyleBackColor = false;
            alertsTabPage.alertsPlayMasteryButton.Click += new System.EventHandler(ShowAlertButton_Click);
            // 
            // alertsSelectCustomMasteryFileButton
            // 
            alertsTabPage.alertsSelectCustomMasteryFileButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsSelectCustomMasteryFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsTabPage.alertsSelectCustomMasteryFileButton.FlatStyle = FlatStyle.Flat;
            alertsTabPage.alertsSelectCustomMasteryFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsSelectCustomMasteryFileButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsTabPage.alertsSelectCustomMasteryFileButton.Location = new Point(314, 409);
            alertsTabPage.alertsSelectCustomMasteryFileButton.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsSelectCustomMasteryFileButton.Name = "alertsSelectCustomMasteryFileButton";
            alertsTabPage.alertsSelectCustomMasteryFileButton.Size = new Size(98, 38);
            alertsTabPage.alertsSelectCustomMasteryFileButton.TabIndex = 14;
            alertsTabPage.alertsSelectCustomMasteryFileButton.Text = "File";
            alertsTabPage.alertsSelectCustomMasteryFileButton.UseVisualStyleBackColor = false;
            alertsTabPage.alertsSelectCustomMasteryFileButton.Click += new System.EventHandler(SelectCustomAlertButton_Click);
            // 
            // alertsCustomMasteryScaleNumericUpDown
            // 
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.DecimalPlaces = 2;
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 131072});
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Name = "alertsCustomMasteryScaleNumericUpDown";
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.TabIndex = 20;
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryXNumericUpDown
            // 
            alertsTabPage.alertsCustomMasteryXNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Minimum = new decimal(new int[] {2000, 0, 0, -2147483648});
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Name = "alertsCustomMasteryXNumericUpDown";
            alertsTabPage.alertsCustomMasteryXNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.TabIndex = 15;
            alertsTabPage.alertsCustomMasteryXNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryYNumericUpDown
            // 
            alertsTabPage.alertsCustomMasteryYNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Minimum = new decimal(new int[] {2000, 0, 0, -2147483648});
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Name = "alertsCustomMasteryYNumericUpDown";
            alertsTabPage.alertsCustomMasteryYNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.TabIndex = 16;
            alertsTabPage.alertsCustomMasteryYNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsMasteryEditOutlineCheckbox
            // 
            alertsTabPage.alertsMasteryEditOutlineCheckbox.AutoSize = true;
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsMasteryEditOutlineCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Location = new Point(12, 414);
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Name = "alertsMasteryEditOutlineCheckbox";
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Size = new Size(137, 29);
            alertsTabPage.alertsMasteryEditOutlineCheckbox.TabIndex = 47;
            alertsTabPage.alertsMasteryEditOutlineCheckbox.Text = "Edit Mode";
            alertsTabPage.alertsMasteryEditOutlineCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsMasteryEditOutlineCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomMasteryOutNumericUpDown
            // 
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Minimum = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Name = "alertsCustomMasteryOutNumericUpDown";
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.TabIndex = 26;
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.Value = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryAnimationOutComboBox
            // 
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.FormattingEnabled = true;
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Location = new Point(252, 2);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Name = "alertsCustomMasteryAnimationOutComboBox";
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.Size = new Size(144, 28);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.TabIndex = 39;
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.SelectedIndexChanged += new System.EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomMasteryOutSpeedUpDown
            // 
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Minimum = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Name = "alertsCustomMasteryOutSpeedUpDown";
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.TabIndex = 48;
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.Value = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryInNumericUpDown
            // 
            alertsTabPage.alertsCustomMasteryInNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Minimum = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Name = "alertsCustomMasteryInNumericUpDown";
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.TabIndex = 26;
            alertsTabPage.alertsCustomMasteryInNumericUpDown.Value = new decimal(new int[] {300, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryAnimationInComboBox
            // 
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.FormattingEnabled = true;
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.Location = new Point(252, 2);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.Name = "alertsCustomMasteryAnimationInComboBox";
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.Size = new Size(144, 28);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.TabIndex = 39;
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.SelectedIndexChanged += new System.EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomMasteryInSpeedUpDown
            // 
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.ForeColor = Color.White;
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Location = new Point(252, 6);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Minimum = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Name = "alertsCustomMasteryInSpeedUpDown";
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Size = new Size(146, 24);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.TabIndex = 48;
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.Value = new decimal(new int[] {50, 0, 0, 0});
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryEnableCheckbox
            // 
            alertsTabPage.alertsCustomMasteryEnableCheckbox.AutoSize = true;
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsCustomMasteryEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Location = new Point(129, 9);
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Name = "alertsCustomMasteryEnableCheckbox";
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Size = new Size(114, 29);
            alertsTabPage.alertsCustomMasteryEnableCheckbox.TabIndex = 13;
            alertsTabPage.alertsCustomMasteryEnableCheckbox.Text = "Custom";
            alertsTabPage.alertsCustomMasteryEnableCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsCustomMasteryEnableCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // userInfoTruePointsTextBox
            // 
            userInfoTabPage.userInfoTruePointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoTruePointsTextBox.ForeColor = Color.White;
            userInfoTabPage.userInfoTruePointsTextBox.Location = new Point(174, 0);
            userInfoTabPage.userInfoTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoTruePointsTextBox.Name = "userInfoTruePointsTextBox";
            userInfoTabPage.userInfoTruePointsTextBox.Size = new Size(146, 31);
            userInfoTabPage.userInfoTruePointsTextBox.TabIndex = 7;
            userInfoTabPage.userInfoTruePointsTextBox.Text = "True Points";
            userInfoTabPage.userInfoTruePointsTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // userInfoPointsTextBox
            // 
            userInfoTabPage.userInfoPointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoPointsTextBox.ForeColor = Color.White;
            userInfoTabPage.userInfoPointsTextBox.Location = new Point(174, 0);
            userInfoTabPage.userInfoPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoPointsTextBox.Name = "userInfoPointsTextBox";
            userInfoTabPage.userInfoPointsTextBox.Size = new Size(146, 31);
            userInfoTabPage.userInfoPointsTextBox.TabIndex = 6;
            userInfoTabPage.userInfoPointsTextBox.Text = "Points";
            userInfoTabPage.userInfoPointsTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // userInfoRatioTextBox
            // 
            userInfoTabPage.userInfoRatioTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRatioTextBox.ForeColor = Color.White;
            userInfoTabPage.userInfoRatioTextBox.Location = new Point(174, 0);
            userInfoTabPage.userInfoRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoRatioTextBox.Name = "userInfoRatioTextBox";
            userInfoTabPage.userInfoRatioTextBox.Size = new Size(146, 31);
            userInfoTabPage.userInfoRatioTextBox.TabIndex = 5;
            userInfoTabPage.userInfoRatioTextBox.Text = "Retro Ratio";
            userInfoTabPage.userInfoRatioTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // userInfoRankTextBox
            // 
            userInfoTabPage.userInfoRankTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoRankTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRankTextBox.ForeColor = Color.White;
            userInfoTabPage.userInfoRankTextBox.Location = new Point(174, 0);
            userInfoTabPage.userInfoRankTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoRankTextBox.Name = "userInfoRankTextBox";
            userInfoTabPage.userInfoRankTextBox.Size = new Size(146, 31);
            userInfoTabPage.userInfoRankTextBox.TabIndex = 1;
            userInfoTabPage.userInfoRankTextBox.Text = "Rank";
            userInfoTabPage.userInfoRankTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // userInfoTruePointsCheckBox
            // 
            userInfoTabPage.userInfoTruePointsCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoTruePointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoTruePointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoTruePointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoTruePointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoTruePointsCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoTruePointsCheckBox.Location = new Point(338, 8);
            userInfoTabPage.userInfoTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoTruePointsCheckBox.Name = "userInfoTruePointsCheckBox";
            userInfoTabPage.userInfoTruePointsCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoTruePointsCheckBox.TabIndex = 56;
            userInfoTabPage.userInfoTruePointsCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoTruePointsCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoRatioCheckBox
            // 
            userInfoTabPage.userInfoRatioCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoRatioCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoRatioCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoRatioCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoRatioCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRatioCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoRatioCheckBox.Location = new Point(338, 8);
            userInfoTabPage.userInfoRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoRatioCheckBox.Name = "userInfoRatioCheckBox";
            userInfoTabPage.userInfoRatioCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoRatioCheckBox.TabIndex = 55;
            userInfoTabPage.userInfoRatioCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoRatioCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoPointsCheckBox
            // 
            userInfoTabPage.userInfoPointsCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoPointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoPointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoPointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoPointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoPointsCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoPointsCheckBox.Location = new Point(338, 8);
            userInfoTabPage.userInfoPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoPointsCheckBox.Name = "userInfoPointsCheckBox";
            userInfoTabPage.userInfoPointsCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoPointsCheckBox.TabIndex = 54;
            userInfoTabPage.userInfoPointsCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoPointsCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoDefaultButton
            // 
            userInfoTabPage.userInfoDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            userInfoTabPage.userInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            userInfoTabPage.userInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            userInfoTabPage.userInfoDefaultButton.Location = new Point(306, 3);
            userInfoTabPage.userInfoDefaultButton.Margin = new Padding(0);
            userInfoTabPage.userInfoDefaultButton.Name = "userInfoDefaultButton";
            userInfoTabPage.userInfoDefaultButton.Size = new Size(112, 42);
            userInfoTabPage.userInfoDefaultButton.TabIndex = 39;
            userInfoTabPage.userInfoDefaultButton.Text = "Default";
            userInfoTabPage.userInfoDefaultButton.UseVisualStyleBackColor = false;
            userInfoTabPage.userInfoDefaultButton.Click += new System.EventHandler(DefaultButton_Click);
            // 
            // userInfoRankCheckBox
            // 
            userInfoTabPage.userInfoRankCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoRankCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoRankCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoRankCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoRankCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRankCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoRankCheckBox.Location = new Point(338, 8);
            userInfoTabPage.userInfoRankCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoRankCheckBox.Name = "userInfoRankCheckBox";
            userInfoTabPage.userInfoRankCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoRankCheckBox.TabIndex = 52;
            userInfoTabPage.userInfoRankCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoRankCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // focusBehaviorGoToLastRadioButton
            // 
            focusTabPage.focusBehaviorGoToLastRadioButton.AutoSize = true;
            focusTabPage.focusBehaviorGoToLastRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusBehaviorGoToLastRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusBehaviorGoToLastRadioButton.Location = new Point(334, 62);
            focusTabPage.focusBehaviorGoToLastRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBehaviorGoToLastRadioButton.Name = "focusBehaviorGoToLastRadioButton";
            focusTabPage.focusBehaviorGoToLastRadioButton.Size = new Size(78, 29);
            focusTabPage.focusBehaviorGoToLastRadioButton.TabIndex = 3;
            focusTabPage.focusBehaviorGoToLastRadioButton.Text = "Last";
            focusTabPage.focusBehaviorGoToLastRadioButton.UseVisualStyleBackColor = true;
            focusTabPage.focusBehaviorGoToLastRadioButton.CheckedChanged += new System.EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToNextRadioButton
            // 
            focusTabPage.focusBehaviorGoToNextRadioButton.AutoSize = true;
            focusTabPage.focusBehaviorGoToNextRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusBehaviorGoToNextRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusBehaviorGoToNextRadioButton.Location = new Point(102, 62);
            focusTabPage.focusBehaviorGoToNextRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBehaviorGoToNextRadioButton.Name = "focusBehaviorGoToNextRadioButton";
            focusTabPage.focusBehaviorGoToNextRadioButton.Size = new Size(84, 29);
            focusTabPage.focusBehaviorGoToNextRadioButton.TabIndex = 2;
            focusTabPage.focusBehaviorGoToNextRadioButton.Text = "Next";
            focusTabPage.focusBehaviorGoToNextRadioButton.UseVisualStyleBackColor = true;
            focusTabPage.focusBehaviorGoToNextRadioButton.CheckedChanged += new System.EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToPreviousRadioButton
            // 
            focusTabPage.focusBehaviorGoToPreviousRadioButton.AutoSize = true;
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusBehaviorGoToPreviousRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Location = new Point(206, 62);
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Name = "focusBehaviorGoToPreviousRadioButton";
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Size = new Size(123, 29);
            focusTabPage.focusBehaviorGoToPreviousRadioButton.TabIndex = 1;
            focusTabPage.focusBehaviorGoToPreviousRadioButton.Text = "Previous";
            focusTabPage.focusBehaviorGoToPreviousRadioButton.UseVisualStyleBackColor = true;
            focusTabPage.focusBehaviorGoToPreviousRadioButton.CheckedChanged += new System.EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToFirstRadioButton
            // 
            focusTabPage.focusBehaviorGoToFirstRadioButton.AutoSize = true;
            focusTabPage.focusBehaviorGoToFirstRadioButton.Checked = true;
            focusTabPage.focusBehaviorGoToFirstRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusBehaviorGoToFirstRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusBehaviorGoToFirstRadioButton.Location = new Point(12, 62);
            focusTabPage.focusBehaviorGoToFirstRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBehaviorGoToFirstRadioButton.Name = "focusBehaviorGoToFirstRadioButton";
            focusTabPage.focusBehaviorGoToFirstRadioButton.Size = new Size(82, 29);
            focusTabPage.focusBehaviorGoToFirstRadioButton.TabIndex = 0;
            focusTabPage.focusBehaviorGoToFirstRadioButton.TabStop = true;
            focusTabPage.focusBehaviorGoToFirstRadioButton.Text = "First";
            focusTabPage.focusBehaviorGoToFirstRadioButton.UseVisualStyleBackColor = true;
            focusTabPage.focusBehaviorGoToFirstRadioButton.CheckedChanged += new System.EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            // 
            // recentAchievementsMaxListLabel
            // 
            recentAchievementsTabPage.recentAchievementsMaxListLabel.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsMaxListLabel.BackColor = Color.Transparent;
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsMaxListLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Location = new Point(190, 63);
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Name = "recentAchievementsMaxListLabel";
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Size = new Size(145, 25);
            recentAchievementsTabPage.recentAchievementsMaxListLabel.TabIndex = 10015;
            recentAchievementsTabPage.recentAchievementsMaxListLabel.Text = "Max List Size";
            // 
            // recentAchievementsMaxListNumericUpDown
            // 
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Font = new Font("Verdana", 8.25F);
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Location = new Point(339, 62);
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Maximum = new decimal(new int[] {20, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Name = "recentAchievementsMaxListNumericUpDown";
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Size = new Size(76, 28);
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.TabIndex = 22;
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // panel64
            // 
            panel64.BackColor = Color.FromArgb(32, 32, 32);
            panel64.Controls.Add(label112);
            panel64.Controls.Add(focusTabPage.focusBehaviorGoToLastRadioButton);
            panel64.Controls.Add(pictureBox12);
            panel64.Controls.Add(focusTabPage.focusBehaviorGoToFirstRadioButton);
            panel64.Controls.Add(focusTabPage.focusBehaviorGoToNextRadioButton);
            panel64.Controls.Add(focusTabPage.focusBehaviorGoToPreviousRadioButton);
            panel64.Location = new Point(4, 465);
            panel64.Margin = new Padding(4, 5, 4, 5);
            panel64.Name = "panel64";
            panel64.Size = new Size(434, 97);
            panel64.TabIndex = 10084;
            // 
            // label112
            // 
            label112.BackColor = Color.Transparent;
            label112.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label112.ForeColor = Color.FromArgb(44, 151, 250);
            label112.Location = new Point(4, 5);
            label112.Margin = new Padding(4, 0, 4, 0);
            label112.Name = "label112";
            label112.Size = new Size(410, 40);
            label112.TabIndex = 10082;
            label112.Text = "Auto-Focus Rule";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox12.Location = new Point(3, 49);
            pictureBox12.Margin = new Padding(4, 5, 4, 5);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(412, 3);
            pictureBox12.TabIndex = 10083;
            pictureBox12.TabStop = false;
            // 
            // panel63
            // 
            panel63.BackColor = Color.FromArgb(32, 32, 32);
            panel63.Controls.Add(unlockAchievementButton);
            panel63.Controls.Add(label111);
            panel63.Controls.Add(pictureBox10);
            panel63.Controls.Add(focusTabPage.focusAchievementPictureBox);
            panel63.Controls.Add(focusTabPage.focusAchievementButtonPrevious);
            panel63.Controls.Add(focusTabPage.focusAchievementButtonNext);
            panel63.Controls.Add(focusTabPage.focusAchievementDescriptionLabel);
            panel63.Controls.Add(focusTabPage.focusAchievementTitleLabel);
            panel63.Controls.Add(focusTabPage.focusSetButton);
            panel63.Location = new Point(4, 5);
            panel63.Margin = new Padding(4, 5, 4, 5);
            panel63.Name = "panel63";
            panel63.Size = new Size(434, 451);
            panel63.TabIndex = 10081;
            // 
            // unlockAchievementButton
            // 
            unlockAchievementButton.BackColor = Color.FromArgb(22, 22, 22);
            unlockAchievementButton.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            unlockAchievementButton.FlatStyle = FlatStyle.Flat;
            unlockAchievementButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            unlockAchievementButton.ForeColor = Color.FromArgb(204, 153, 0);
            unlockAchievementButton.Location = new Point(316, 62);
            unlockAchievementButton.Margin = new Padding(4, 5, 4, 5);
            unlockAchievementButton.Name = "unlockAchievementButton";
            unlockAchievementButton.Size = new Size(112, 42);
            unlockAchievementButton.TabIndex = 10084;
            unlockAchievementButton.Text = "Unlock";
            unlockAchievementButton.UseVisualStyleBackColor = false;
            unlockAchievementButton.Click += new System.EventHandler(UnlockAchievementButton_Click);
            // 
            // label111
            // 
            label111.BackColor = Color.Transparent;
            label111.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label111.ForeColor = Color.FromArgb(44, 151, 250);
            label111.Location = new Point(4, 5);
            label111.Margin = new Padding(4, 0, 4, 0);
            label111.Name = "label111";
            label111.Size = new Size(410, 40);
            label111.TabIndex = 10082;
            label111.Text = "Current Achievement";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox10.Location = new Point(3, 49);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(420, 3);
            pictureBox10.TabIndex = 10083;
            pictureBox10.TabStop = false;
            // 
            // panel51
            // 
            panel51.BackColor = Color.FromArgb(32, 32, 32);
            panel51.Controls.Add(focusTabPage.focusLinePanel);
            panel51.Controls.Add(label96);
            panel51.Controls.Add(panel59);
            panel51.Controls.Add(focusTabPage.focusPointsPanel);
            panel51.Controls.Add(panel52);
            panel51.Controls.Add(panel61);
            panel51.Controls.Add(focusTabPage.focusOpenWindowButton);
            panel51.Controls.Add(focusTabPage.focusDescriptionOutlinePanel);
            panel51.Controls.Add(focusTabPage.focusDescriptionPanel);
            panel51.Controls.Add(focusTabPage.focusAutoOpenWindowCheckBox);
            panel51.Controls.Add(pictureBox11);
            panel51.Controls.Add(panel54);
            panel51.Controls.Add(panel55);
            panel51.Controls.Add(focusTabPage.focusPointsOutlinePanel);
            panel51.Controls.Add(focusTabPage.focusLineOutlinePanel);
            panel51.Location = new Point(444, 5);
            panel51.Margin = new Padding(4, 5, 4, 5);
            panel51.Name = "panel51";
            panel51.Size = new Size(702, 438);
            panel51.TabIndex = 10080;
            // 
            // focusLinePanel
            // 
            focusTabPage.focusLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusTabPage.focusLinePanel.Controls.Add(label106);
            focusTabPage.focusLinePanel.Controls.Add(focusTabPage.focusLineColorPictureBox);
            focusTabPage.focusLinePanel.Location = new Point(3, 265);
            focusTabPage.focusLinePanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLinePanel.Name = "focusLinePanel";
            focusTabPage.focusLinePanel.Size = new Size(694, 35);
            focusTabPage.focusLinePanel.TabIndex = 10068;
            // 
            // label106
            // 
            label106.BackColor = Color.Transparent;
            label106.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label106.ForeColor = Color.FromArgb(44, 151, 250);
            label106.Location = new Point(4, 6);
            label106.Margin = new Padding(4, 0, 4, 0);
            label106.Name = "label106";
            label106.Size = new Size(216, 25);
            label106.TabIndex = 10066;
            label106.Text = "Line";
            // 
            // focusLineColorPictureBox
            // 
            focusTabPage.focusLineColorPictureBox.BackColor = Color.White;
            focusTabPage.focusLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusLineColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLineColorPictureBox.Name = "focusLineColorPictureBox";
            focusTabPage.focusLineColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusLineColorPictureBox.TabIndex = 45;
            focusTabPage.focusLineColorPictureBox.TabStop = false;
            focusTabPage.focusLineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label96
            // 
            label96.BackColor = Color.Transparent;
            label96.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label96.ForeColor = Color.FromArgb(44, 151, 250);
            label96.Location = new Point(4, 5);
            label96.Margin = new Padding(4, 0, 4, 0);
            label96.Name = "label96";
            label96.Size = new Size(364, 40);
            label96.TabIndex = 10062;
            label96.Text = "Window/Font Settings";
            // 
            // panel59
            // 
            panel59.BackColor = Color.FromArgb(32, 32, 32);
            panel59.Controls.Add(focusTabPage.focusBorderCheckBox);
            panel59.Controls.Add(focusTabPage.focusBorderColorPictureBox);
            panel59.Controls.Add(label107);
            panel59.Location = new Point(3, 129);
            panel59.Margin = new Padding(4, 5, 4, 5);
            panel59.Name = "panel59";
            panel59.Size = new Size(694, 35);
            panel59.TabIndex = 10069;
            // 
            // focusBorderCheckBox
            // 
            focusTabPage.focusBorderCheckBox.AutoSize = true;
            focusTabPage.focusBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusBorderCheckBox.Location = new Point(620, 8);
            focusTabPage.focusBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBorderCheckBox.Name = "focusBorderCheckBox";
            focusTabPage.focusBorderCheckBox.Size = new Size(22, 21);
            focusTabPage.focusBorderCheckBox.TabIndex = 10065;
            focusTabPage.focusBorderCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusBorderCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusBorderColorPictureBox
            // 
            focusTabPage.focusBorderColorPictureBox.BackColor = Color.White;
            focusTabPage.focusBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusBorderColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBorderColorPictureBox.Name = "focusBorderColorPictureBox";
            focusTabPage.focusBorderColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusBorderColorPictureBox.TabIndex = 42;
            focusTabPage.focusBorderColorPictureBox.TabStop = false;
            focusTabPage.focusBorderColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label107
            // 
            label107.BackColor = Color.Transparent;
            label107.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label107.ForeColor = Color.FromArgb(44, 151, 250);
            label107.Location = new Point(4, 5);
            label107.Margin = new Padding(4, 0, 4, 0);
            label107.Name = "label107";
            label107.Size = new Size(216, 25);
            label107.TabIndex = 10064;
            label107.Text = "Border";
            // 
            // focusPointsPanel
            // 
            focusTabPage.focusPointsPanel.BackColor = Color.FromArgb(26, 26, 26);
            focusTabPage.focusPointsPanel.Controls.Add(label108);
            focusTabPage.focusPointsPanel.Controls.Add(focusTabPage.focusPointsFontColorPictureBox);
            focusTabPage.focusPointsPanel.Controls.Add(focusTabPage.focusPointsFontComboBox);
            focusTabPage.focusPointsPanel.Location = new Point(3, 231);
            focusTabPage.focusPointsPanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsPanel.Name = "focusPointsPanel";
            focusTabPage.focusPointsPanel.Size = new Size(694, 35);
            focusTabPage.focusPointsPanel.TabIndex = 10070;
            // 
            // label108
            // 
            label108.BackColor = Color.Transparent;
            label108.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label108.ForeColor = Color.FromArgb(44, 151, 250);
            label108.Location = new Point(4, 6);
            label108.Margin = new Padding(4, 0, 4, 0);
            label108.Name = "label108";
            label108.Size = new Size(216, 25);
            label108.TabIndex = 10065;
            label108.Text = "Points";
            // 
            // focusPointsFontColorPictureBox
            // 
            focusTabPage.focusPointsFontColorPictureBox.BackColor = Color.White;
            focusTabPage.focusPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusPointsFontColorPictureBox.Location = new Point(230, 6);
            focusTabPage.focusPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsFontColorPictureBox.Name = "focusPointsFontColorPictureBox";
            focusTabPage.focusPointsFontColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusPointsFontColorPictureBox.TabIndex = 45;
            focusTabPage.focusPointsFontColorPictureBox.TabStop = false;
            focusTabPage.focusPointsFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusPointsFontComboBox
            // 
            focusTabPage.focusPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusPointsFontComboBox.ForeColor = Color.White;
            focusTabPage.focusPointsFontComboBox.FormattingEnabled = true;
            focusTabPage.focusPointsFontComboBox.Location = new Point(290, 3);
            focusTabPage.focusPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsFontComboBox.Name = "focusPointsFontComboBox";
            focusTabPage.focusPointsFontComboBox.Size = new Size(301, 28);
            focusTabPage.focusPointsFontComboBox.TabIndex = 45;
            focusTabPage.focusPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel52
            // 
            panel52.BackColor = Color.FromArgb(32, 32, 32);
            panel52.Controls.Add(focusTabPage.focusAdvancedCheckBox);
            panel52.Controls.Add(label97);
            panel52.Controls.Add(label98);
            panel52.Controls.Add(label99);
            panel52.Controls.Add(label100);
            panel52.Location = new Point(3, 62);
            panel52.Margin = new Padding(4, 5, 4, 5);
            panel52.Name = "panel52";
            panel52.Size = new Size(694, 35);
            panel52.TabIndex = 10076;
            // 
            // focusAdvancedCheckBox
            // 
            focusTabPage.focusAdvancedCheckBox.AutoSize = true;
            focusTabPage.focusAdvancedCheckBox.BackColor = Color.Transparent;
            focusTabPage.focusAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusTabPage.focusAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusAdvancedCheckBox.Location = new Point(8, 3);
            focusTabPage.focusAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusAdvancedCheckBox.Name = "focusAdvancedCheckBox";
            focusTabPage.focusAdvancedCheckBox.Size = new Size(135, 29);
            focusTabPage.focusAdvancedCheckBox.TabIndex = 10053;
            focusTabPage.focusAdvancedCheckBox.Text = "Advanced";
            focusTabPage.focusAdvancedCheckBox.UseVisualStyleBackColor = false;
            focusTabPage.focusAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label97
            // 
            label97.BackColor = Color.Transparent;
            label97.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label97.ForeColor = Color.FromArgb(200, 200, 200);
            label97.Location = new Point(225, 5);
            label97.Margin = new Padding(4, 0, 4, 0);
            label97.Name = "label97";
            label97.Size = new Size(72, 25);
            label97.TabIndex = 10065;
            label97.Text = "Color";
            // 
            // label98
            // 
            label98.BackColor = Color.Transparent;
            label98.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label98.ForeColor = Color.FromArgb(200, 200, 200);
            label98.Location = new Point(291, 5);
            label98.Margin = new Padding(4, 0, 4, 0);
            label98.Name = "label98";
            label98.Size = new Size(75, 25);
            label98.TabIndex = 10066;
            label98.Text = "Font";
            // 
            // label99
            // 
            label99.BackColor = Color.Transparent;
            label99.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label99.ForeColor = Color.FromArgb(200, 200, 200);
            label99.Location = new Point(524, 5);
            label99.Margin = new Padding(4, 0, 4, 0);
            label99.Name = "label99";
            label99.Size = new Size(62, 25);
            label99.TabIndex = 10068;
            label99.Text = "Size";
            // 
            // label100
            // 
            label100.BackColor = Color.Transparent;
            label100.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label100.ForeColor = Color.FromArgb(200, 200, 200);
            label100.Location = new Point(594, 5);
            label100.Margin = new Padding(4, 0, 4, 0);
            label100.Name = "label100";
            label100.Size = new Size(88, 25);
            label100.TabIndex = 10067;
            label100.Text = "Enabled";
            // 
            // panel61
            // 
            panel61.BackColor = Color.FromArgb(26, 26, 26);
            panel61.Controls.Add(focusTabPage.focusTitleFontOutlineNumericUpDown);
            panel61.Controls.Add(focusTabPage.focusTitleOutlineCheckBox);
            panel61.Controls.Add(focusTabPage.focusTitleOutlineLabel);
            panel61.Controls.Add(focusTabPage.focusTitleFontOutlineColorPictureBox);
            panel61.Location = new Point(3, 298);
            panel61.Margin = new Padding(4, 5, 4, 5);
            panel61.Name = "panel61";
            panel61.Size = new Size(694, 35);
            panel61.TabIndex = 10071;
            // 
            // focusTitleFontOutlineNumericUpDown
            // 
            focusTabPage.focusTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusTabPage.focusTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTabPage.focusTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            focusTabPage.focusTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusTabPage.focusTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            focusTabPage.focusTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusTitleFontOutlineNumericUpDown.Name = "focusTitleFontOutlineNumericUpDown";
            focusTabPage.focusTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusTabPage.focusTitleFontOutlineNumericUpDown.TabIndex = 45;
            focusTabPage.focusTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // focusTitleOutlineCheckBox
            // 
            focusTabPage.focusTitleOutlineCheckBox.AutoSize = true;
            focusTabPage.focusTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusTitleOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusTitleOutlineCheckBox.Location = new Point(620, 8);
            focusTabPage.focusTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusTitleOutlineCheckBox.Name = "focusTitleOutlineCheckBox";
            focusTabPage.focusTitleOutlineCheckBox.Size = new Size(22, 21);
            focusTabPage.focusTitleOutlineCheckBox.TabIndex = 45;
            focusTabPage.focusTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusTitleOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusTitleOutlineLabel
            // 
            focusTabPage.focusTitleOutlineLabel.BackColor = Color.Transparent;
            focusTabPage.focusTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusTitleOutlineLabel.Location = new Point(4, 5);
            focusTabPage.focusTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            focusTabPage.focusTitleOutlineLabel.Name = "focusTitleOutlineLabel";
            focusTabPage.focusTitleOutlineLabel.Size = new Size(216, 25);
            focusTabPage.focusTitleOutlineLabel.TabIndex = 10066;
            focusTabPage.focusTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // focusTitleFontOutlineColorPictureBox
            // 
            focusTabPage.focusTitleFontOutlineColorPictureBox.BackColor = Color.White;
            focusTabPage.focusTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusTitleFontOutlineColorPictureBox.Name = "focusTitleFontOutlineColorPictureBox";
            focusTabPage.focusTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusTitleFontOutlineColorPictureBox.TabIndex = 45;
            focusTabPage.focusTitleFontOutlineColorPictureBox.TabStop = false;
            focusTabPage.focusTitleFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusOpenWindowButton
            // 
            focusTabPage.focusOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            focusTabPage.focusOpenWindowButton.FlatStyle = FlatStyle.Flat;
            focusTabPage.focusOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            focusTabPage.focusOpenWindowButton.Location = new Point(573, 3);
            focusTabPage.focusOpenWindowButton.Margin = new Padding(0);
            focusTabPage.focusOpenWindowButton.Name = "focusOpenWindowButton";
            focusTabPage.focusOpenWindowButton.Size = new Size(112, 42);
            focusTabPage.focusOpenWindowButton.TabIndex = 10021;
            focusTabPage.focusOpenWindowButton.Text = "Open";
            focusTabPage.focusOpenWindowButton.UseVisualStyleBackColor = false;
            focusTabPage.focusOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // focusDescriptionOutlinePanel
            // 
            focusTabPage.focusDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(label110);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionFontOutlineColorPictureBox);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionFontOutlineNumericUpDown);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionOutlineCheckBox);
            focusTabPage.focusDescriptionOutlinePanel.Location = new Point(3, 332);
            focusTabPage.focusDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionOutlinePanel.Name = "focusDescriptionOutlinePanel";
            focusTabPage.focusDescriptionOutlinePanel.Size = new Size(694, 35);
            focusTabPage.focusDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label110
            // 
            label110.BackColor = Color.Transparent;
            label110.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label110.ForeColor = Color.FromArgb(44, 151, 250);
            label110.Location = new Point(4, 6);
            label110.Margin = new Padding(4, 0, 4, 0);
            label110.Name = "label110";
            label110.Size = new Size(216, 25);
            label110.TabIndex = 10066;
            label110.Text = "Description OutlineColor";
            // 
            // focusDescriptionFontOutlineColorPictureBox
            // 
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Name = "focusDescriptionFontOutlineColorPictureBox";
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.TabStop = false;
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusDescriptionFontOutlineNumericUpDown
            // 
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Name = "focusDescriptionFontOutlineNumericUpDown";
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // focusDescriptionOutlineCheckBox
            // 
            focusTabPage.focusDescriptionOutlineCheckBox.AutoSize = true;
            focusTabPage.focusDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusDescriptionOutlineCheckBox.Location = new Point(620, 9);
            focusTabPage.focusDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionOutlineCheckBox.Name = "focusDescriptionOutlineCheckBox";
            focusTabPage.focusDescriptionOutlineCheckBox.Size = new Size(22, 21);
            focusTabPage.focusDescriptionOutlineCheckBox.TabIndex = 45;
            focusTabPage.focusDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusDescriptionOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusDescriptionPanel
            // 
            focusTabPage.focusDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            focusTabPage.focusDescriptionPanel.Controls.Add(label101);
            focusTabPage.focusDescriptionPanel.Controls.Add(focusTabPage.focusDescriptionFontColorPictureBox);
            focusTabPage.focusDescriptionPanel.Controls.Add(focusTabPage.focusDescriptionFontComboBox);
            focusTabPage.focusDescriptionPanel.Location = new Point(3, 197);
            focusTabPage.focusDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionPanel.Name = "focusDescriptionPanel";
            focusTabPage.focusDescriptionPanel.Size = new Size(694, 35);
            focusTabPage.focusDescriptionPanel.TabIndex = 10061;
            // 
            // label101
            // 
            label101.BackColor = Color.Transparent;
            label101.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label101.ForeColor = Color.FromArgb(44, 151, 250);
            label101.Location = new Point(4, 6);
            label101.Margin = new Padding(4, 0, 4, 0);
            label101.Name = "label101";
            label101.Size = new Size(216, 25);
            label101.TabIndex = 10066;
            label101.Text = "Description";
            // 
            // focusDescriptionFontColorPictureBox
            // 
            focusTabPage.focusDescriptionFontColorPictureBox.BackColor = Color.White;
            focusTabPage.focusDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusDescriptionFontColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionFontColorPictureBox.Name = "focusDescriptionFontColorPictureBox";
            focusTabPage.focusDescriptionFontColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusDescriptionFontColorPictureBox.TabIndex = 45;
            focusTabPage.focusDescriptionFontColorPictureBox.TabStop = false;
            focusTabPage.focusDescriptionFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusDescriptionFontComboBox
            // 
            focusTabPage.focusDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusDescriptionFontComboBox.ForeColor = Color.White;
            focusTabPage.focusDescriptionFontComboBox.FormattingEnabled = true;
            focusTabPage.focusDescriptionFontComboBox.Location = new Point(290, 3);
            focusTabPage.focusDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusDescriptionFontComboBox.Name = "focusDescriptionFontComboBox";
            focusTabPage.focusDescriptionFontComboBox.Size = new Size(301, 28);
            focusTabPage.focusDescriptionFontComboBox.TabIndex = 45;
            focusTabPage.focusDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // focusAutoOpenWindowCheckBox
            // 
            focusTabPage.focusAutoOpenWindowCheckBox.AutoSize = true;
            focusTabPage.focusAutoOpenWindowCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusTabPage.focusAutoOpenWindowCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusAutoOpenWindowCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusAutoOpenWindowCheckBox.Location = new Point(378, 14);
            focusTabPage.focusAutoOpenWindowCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusAutoOpenWindowCheckBox.Name = "focusAutoOpenWindowCheckBox";
            focusTabPage.focusAutoOpenWindowCheckBox.Size = new Size(147, 29);
            focusTabPage.focusAutoOpenWindowCheckBox.TabIndex = 10022;
            focusTabPage.focusAutoOpenWindowCheckBox.Text = "Auto-Open";
            focusTabPage.focusAutoOpenWindowCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusAutoOpenWindowCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox11.Location = new Point(3, 49);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(690, 3);
            pictureBox11.TabIndex = 10063;
            pictureBox11.TabStop = false;
            // 
            // panel54
            // 
            panel54.BackColor = Color.FromArgb(26, 26, 26);
            panel54.Controls.Add(focusTabPage.focusBackgroundColorPictureBox);
            panel54.Controls.Add(label102);
            panel54.Location = new Point(3, 95);
            panel54.Margin = new Padding(4, 5, 4, 5);
            panel54.Name = "panel54";
            panel54.Size = new Size(694, 35);
            panel54.TabIndex = 10061;
            // 
            // focusBackgroundColorPictureBox
            // 
            focusTabPage.focusBackgroundColorPictureBox.BackColor = Color.White;
            focusTabPage.focusBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusBackgroundColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusBackgroundColorPictureBox.Name = "focusBackgroundColorPictureBox";
            focusTabPage.focusBackgroundColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusBackgroundColorPictureBox.TabIndex = 42;
            focusTabPage.focusBackgroundColorPictureBox.TabStop = false;
            focusTabPage.focusBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label102
            // 
            label102.BackColor = Color.Transparent;
            label102.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label102.ForeColor = Color.FromArgb(44, 151, 250);
            label102.Location = new Point(4, 5);
            label102.Margin = new Padding(4, 0, 4, 0);
            label102.Name = "label102";
            label102.Size = new Size(216, 25);
            label102.TabIndex = 10064;
            label102.Text = "Window Background";
            // 
            // panel55
            // 
            panel55.BackColor = Color.FromArgb(26, 26, 26);
            panel55.Controls.Add(focusTabPage.focusTitleLabel);
            panel55.Controls.Add(focusTabPage.focusTitleFontColorPictureBox);
            panel55.Controls.Add(focusTabPage.focusTitleFontComboBox);
            panel55.Location = new Point(3, 163);
            panel55.Margin = new Padding(4, 5, 4, 5);
            panel55.Name = "panel55";
            panel55.Size = new Size(694, 35);
            panel55.TabIndex = 10061;
            // 
            // focusTitleLabel
            // 
            focusTabPage.focusTitleLabel.BackColor = Color.Transparent;
            focusTabPage.focusTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusTitleLabel.Location = new Point(4, 6);
            focusTabPage.focusTitleLabel.Margin = new Padding(4, 0, 4, 0);
            focusTabPage.focusTitleLabel.Name = "focusTitleLabel";
            focusTabPage.focusTitleLabel.Size = new Size(216, 25);
            focusTabPage.focusTitleLabel.TabIndex = 10065;
            focusTabPage.focusTitleLabel.Text = "Title";
            // 
            // focusTitleFontColorPictureBox
            // 
            focusTabPage.focusTitleFontColorPictureBox.BackColor = Color.White;
            focusTabPage.focusTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusTitleFontColorPictureBox.Location = new Point(230, 6);
            focusTabPage.focusTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusTitleFontColorPictureBox.Name = "focusTitleFontColorPictureBox";
            focusTabPage.focusTitleFontColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusTitleFontColorPictureBox.TabIndex = 45;
            focusTabPage.focusTitleFontColorPictureBox.TabStop = false;
            focusTabPage.focusTitleFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusTitleFontComboBox
            // 
            focusTabPage.focusTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusTabPage.focusTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusTitleFontComboBox.ForeColor = Color.White;
            focusTabPage.focusTitleFontComboBox.FormattingEnabled = true;
            focusTabPage.focusTitleFontComboBox.Location = new Point(290, 3);
            focusTabPage.focusTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusTitleFontComboBox.Name = "focusTitleFontComboBox";
            focusTabPage.focusTitleFontComboBox.Size = new Size(301, 28);
            focusTabPage.focusTitleFontComboBox.TabIndex = 45;
            focusTabPage.focusTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // focusPointsOutlinePanel
            // 
            focusTabPage.focusPointsOutlinePanel.BackColor = Color.FromArgb(26, 26, 26);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsFontOutlineNumericUpDown);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsOutlineCheckBox);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(label104);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsFontOutlineColorPictureBox);
            focusTabPage.focusPointsOutlinePanel.Location = new Point(3, 366);
            focusTabPage.focusPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsOutlinePanel.Name = "focusPointsOutlinePanel";
            focusTabPage.focusPointsOutlinePanel.Size = new Size(694, 35);
            focusTabPage.focusPointsOutlinePanel.TabIndex = 10061;
            // 
            // focusPointsFontOutlineNumericUpDown
            // 
            focusTabPage.focusPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusTabPage.focusPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTabPage.focusPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            focusTabPage.focusPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusTabPage.focusPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            focusTabPage.focusPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusPointsFontOutlineNumericUpDown.Name = "focusPointsFontOutlineNumericUpDown";
            focusTabPage.focusPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusTabPage.focusPointsFontOutlineNumericUpDown.TabIndex = 45;
            focusTabPage.focusPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // focusPointsOutlineCheckBox
            // 
            focusTabPage.focusPointsOutlineCheckBox.AutoSize = true;
            focusTabPage.focusPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusPointsOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusPointsOutlineCheckBox.Location = new Point(620, 8);
            focusTabPage.focusPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsOutlineCheckBox.Name = "focusPointsOutlineCheckBox";
            focusTabPage.focusPointsOutlineCheckBox.Size = new Size(22, 21);
            focusTabPage.focusPointsOutlineCheckBox.TabIndex = 45;
            focusTabPage.focusPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusPointsOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label104
            // 
            label104.BackColor = Color.Transparent;
            label104.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label104.ForeColor = Color.FromArgb(44, 151, 250);
            label104.Location = new Point(4, 5);
            label104.Margin = new Padding(4, 0, 4, 0);
            label104.Name = "label104";
            label104.Size = new Size(216, 25);
            label104.TabIndex = 10066;
            label104.Text = "Points OutlineColor";
            // 
            // focusPointsFontOutlineColorPictureBox
            // 
            focusTabPage.focusPointsFontOutlineColorPictureBox.BackColor = Color.White;
            focusTabPage.focusPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusTabPage.focusPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusPointsFontOutlineColorPictureBox.Name = "focusPointsFontOutlineColorPictureBox";
            focusTabPage.focusPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusPointsFontOutlineColorPictureBox.TabIndex = 45;
            focusTabPage.focusPointsFontOutlineColorPictureBox.TabStop = false;
            focusTabPage.focusPointsFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusLineOutlinePanel
            // 
            focusTabPage.focusLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusTabPage.focusLineOutlinePanel.Controls.Add(label105);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineColorPictureBox);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineNumericUpDown);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineCheckBox);
            focusTabPage.focusLineOutlinePanel.Location = new Point(3, 400);
            focusTabPage.focusLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLineOutlinePanel.Name = "focusLineOutlinePanel";
            focusTabPage.focusLineOutlinePanel.Size = new Size(694, 35);
            focusTabPage.focusLineOutlinePanel.TabIndex = 10067;
            // 
            // label105
            // 
            label105.BackColor = Color.Transparent;
            label105.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label105.ForeColor = Color.FromArgb(44, 151, 250);
            label105.Location = new Point(4, 6);
            label105.Margin = new Padding(4, 0, 4, 0);
            label105.Name = "label105";
            label105.Size = new Size(216, 25);
            label105.TabIndex = 10066;
            label105.Text = "Line OutlineColor";
            // 
            // focusLineOutlineColorPictureBox
            // 
            focusTabPage.focusLineOutlineColorPictureBox.BackColor = Color.White;
            focusTabPage.focusLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTabPage.focusLineOutlineColorPictureBox.Location = new Point(230, 6);
            focusTabPage.focusLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLineOutlineColorPictureBox.Name = "focusLineOutlineColorPictureBox";
            focusTabPage.focusLineOutlineColorPictureBox.Size = new Size(22, 22);
            focusTabPage.focusLineOutlineColorPictureBox.TabIndex = 45;
            focusTabPage.focusLineOutlineColorPictureBox.TabStop = false;
            focusTabPage.focusLineOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // focusLineOutlineNumericUpDown
            // 
            focusTabPage.focusLineOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusTabPage.focusLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTabPage.focusLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusLineOutlineNumericUpDown.ForeColor = Color.White;
            focusTabPage.focusLineOutlineNumericUpDown.Location = new Point(528, 6);
            focusTabPage.focusLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLineOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            focusTabPage.focusLineOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusLineOutlineNumericUpDown.Name = "focusLineOutlineNumericUpDown";
            focusTabPage.focusLineOutlineNumericUpDown.Size = new Size(64, 24);
            focusTabPage.focusLineOutlineNumericUpDown.TabIndex = 45;
            focusTabPage.focusLineOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            focusTabPage.focusLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // focusLineOutlineCheckBox
            // 
            focusTabPage.focusLineOutlineCheckBox.AutoSize = true;
            focusTabPage.focusLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTabPage.focusLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTabPage.focusLineOutlineCheckBox.Location = new Point(620, 9);
            focusTabPage.focusLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTabPage.focusLineOutlineCheckBox.Name = "focusLineOutlineCheckBox";
            focusTabPage.focusLineOutlineCheckBox.Size = new Size(22, 21);
            focusTabPage.focusLineOutlineCheckBox.TabIndex = 45;
            focusTabPage.focusLineOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTabPage.focusLineOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel65
            // 
            panel65.BackColor = Color.FromArgb(32, 32, 32);
            panel65.Controls.Add(alertsTabPage.alertsLinePanel);
            panel65.Controls.Add(label114);
            panel65.Controls.Add(panel67);
            panel65.Controls.Add(alertsTabPage.alertsPointsPanel);
            panel65.Controls.Add(panel69);
            panel65.Controls.Add(panel70);
            panel65.Controls.Add(alertsTabPage.alertsOpenWindowButton);
            panel65.Controls.Add(alertsTabPage.alertsDescriptionOutlinePanel);
            panel65.Controls.Add(alertsTabPage.alertsDescriptionPanel);
            panel65.Controls.Add(alertsTabPage.alertsAutoOpenWindowCheckbox);
            panel65.Controls.Add(pictureBox20);
            panel65.Controls.Add(panel73);
            panel65.Controls.Add(panel74);
            panel65.Controls.Add(alertsTabPage.alertsPointsOutlinePanel);
            panel65.Controls.Add(alertsTabPage.alertsLineOutlinePanel);
            panel65.Location = new Point(444, 5);
            panel65.Margin = new Padding(4, 5, 4, 5);
            panel65.Name = "panel65";
            panel65.Size = new Size(702, 438);
            panel65.TabIndex = 10081;
            // 
            // alertsLinePanel
            // 
            alertsTabPage.alertsLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsLinePanel.Controls.Add(label113);
            alertsTabPage.alertsLinePanel.Controls.Add(alertsTabPage.alertsLineColorPictureBox);
            alertsTabPage.alertsLinePanel.Location = new Point(3, 265);
            alertsTabPage.alertsLinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLinePanel.Name = "alertsLinePanel";
            alertsTabPage.alertsLinePanel.Size = new Size(694, 35);
            alertsTabPage.alertsLinePanel.TabIndex = 10068;
            // 
            // label113
            // 
            label113.BackColor = Color.Transparent;
            label113.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label113.ForeColor = Color.FromArgb(44, 151, 250);
            label113.Location = new Point(4, 6);
            label113.Margin = new Padding(4, 0, 4, 0);
            label113.Name = "label113";
            label113.Size = new Size(216, 25);
            label113.TabIndex = 10066;
            label113.Text = "Line";
            // 
            // alertsLineColorPictureBox
            // 
            alertsTabPage.alertsLineColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsLineColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLineColorPictureBox.Name = "alertsLineColorPictureBox";
            alertsTabPage.alertsLineColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsLineColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsLineColorPictureBox.TabStop = false;
            alertsTabPage.alertsLineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label114
            // 
            label114.BackColor = Color.Transparent;
            label114.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label114.ForeColor = Color.FromArgb(44, 151, 250);
            label114.Location = new Point(4, 5);
            label114.Margin = new Padding(4, 0, 4, 0);
            label114.Name = "label114";
            label114.Size = new Size(364, 40);
            label114.TabIndex = 10062;
            label114.Text = "Window/Font Settings";
            // 
            // panel67
            // 
            panel67.BackColor = Color.FromArgb(32, 32, 32);
            panel67.Controls.Add(alertsTabPage.alertsBorderCheckBox);
            panel67.Controls.Add(alertsTabPage.alertsBorderColorPictureBox);
            panel67.Controls.Add(label115);
            panel67.Location = new Point(3, 129);
            panel67.Margin = new Padding(4, 5, 4, 5);
            panel67.Name = "panel67";
            panel67.Size = new Size(694, 35);
            panel67.TabIndex = 10069;
            // 
            // alertsBorderCheckBox
            // 
            alertsTabPage.alertsBorderCheckBox.AutoSize = true;
            alertsTabPage.alertsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsBorderCheckBox.Location = new Point(620, 8);
            alertsTabPage.alertsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsBorderCheckBox.Name = "alertsBorderCheckBox";
            alertsTabPage.alertsBorderCheckBox.Size = new Size(22, 21);
            alertsTabPage.alertsBorderCheckBox.TabIndex = 10065;
            alertsTabPage.alertsBorderCheckBox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsBorderCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsBorderColorPictureBox
            // 
            alertsTabPage.alertsBorderColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsBorderColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsBorderColorPictureBox.Name = "alertsBorderColorPictureBox";
            alertsTabPage.alertsBorderColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsBorderColorPictureBox.TabIndex = 42;
            alertsTabPage.alertsBorderColorPictureBox.TabStop = false;
            alertsTabPage.alertsBorderColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label115
            // 
            label115.BackColor = Color.Transparent;
            label115.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label115.ForeColor = Color.FromArgb(44, 151, 250);
            label115.Location = new Point(4, 5);
            label115.Margin = new Padding(4, 0, 4, 0);
            label115.Name = "label115";
            label115.Size = new Size(216, 25);
            label115.TabIndex = 10064;
            label115.Text = "Border";
            // 
            // alertsPointsPanel
            // 
            alertsTabPage.alertsPointsPanel.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsPointsPanel.Controls.Add(label116);
            alertsTabPage.alertsPointsPanel.Controls.Add(alertsTabPage.alertsPointsFontColorPictureBox);
            alertsTabPage.alertsPointsPanel.Controls.Add(alertsTabPage.alertsPointsFontComboBox);
            alertsTabPage.alertsPointsPanel.Location = new Point(3, 231);
            alertsTabPage.alertsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsPanel.Name = "alertsPointsPanel";
            alertsTabPage.alertsPointsPanel.Size = new Size(694, 35);
            alertsTabPage.alertsPointsPanel.TabIndex = 10070;
            // 
            // label116
            // 
            label116.BackColor = Color.Transparent;
            label116.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label116.ForeColor = Color.FromArgb(44, 151, 250);
            label116.Location = new Point(4, 6);
            label116.Margin = new Padding(4, 0, 4, 0);
            label116.Name = "label116";
            label116.Size = new Size(216, 25);
            label116.TabIndex = 10065;
            label116.Text = "Points";
            // 
            // alertsPointsFontColorPictureBox
            // 
            alertsTabPage.alertsPointsFontColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsPointsFontColorPictureBox.Location = new Point(230, 6);
            alertsTabPage.alertsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsFontColorPictureBox.Name = "alertsPointsFontColorPictureBox";
            alertsTabPage.alertsPointsFontColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsPointsFontColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsPointsFontColorPictureBox.TabStop = false;
            alertsTabPage.alertsPointsFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsPointsFontComboBox
            // 
            alertsTabPage.alertsPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsPointsFontComboBox.FlatStyle = FlatStyle.System;
            alertsTabPage.alertsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsPointsFontComboBox.ForeColor = Color.White;
            alertsTabPage.alertsPointsFontComboBox.FormattingEnabled = true;
            alertsTabPage.alertsPointsFontComboBox.Location = new Point(290, 3);
            alertsTabPage.alertsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsFontComboBox.Name = "alertsPointsFontComboBox";
            alertsTabPage.alertsPointsFontComboBox.Size = new Size(301, 28);
            alertsTabPage.alertsPointsFontComboBox.TabIndex = 45;
            alertsTabPage.alertsPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel69
            // 
            panel69.BackColor = Color.FromArgb(32, 32, 32);
            panel69.Controls.Add(alertsTabPage.alertsAdvancedCheckBox);
            panel69.Controls.Add(label117);
            panel69.Controls.Add(label118);
            panel69.Controls.Add(label119);
            panel69.Controls.Add(label120);
            panel69.Location = new Point(3, 62);
            panel69.Margin = new Padding(4, 5, 4, 5);
            panel69.Name = "panel69";
            panel69.Size = new Size(694, 35);
            panel69.TabIndex = 10076;
            // 
            // alertsAdvancedCheckBox
            // 
            alertsTabPage.alertsAdvancedCheckBox.AutoSize = true;
            alertsTabPage.alertsAdvancedCheckBox.BackColor = Color.Transparent;
            alertsTabPage.alertsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            alertsTabPage.alertsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsAdvancedCheckBox.Location = new Point(8, 3);
            alertsTabPage.alertsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsAdvancedCheckBox.Name = "alertsAdvancedCheckBox";
            alertsTabPage.alertsAdvancedCheckBox.Size = new Size(135, 29);
            alertsTabPage.alertsAdvancedCheckBox.TabIndex = 10053;
            alertsTabPage.alertsAdvancedCheckBox.Text = "Advanced";
            alertsTabPage.alertsAdvancedCheckBox.UseVisualStyleBackColor = false;
            alertsTabPage.alertsAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label117
            // 
            label117.BackColor = Color.Transparent;
            label117.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label117.ForeColor = Color.FromArgb(200, 200, 200);
            label117.Location = new Point(225, 5);
            label117.Margin = new Padding(4, 0, 4, 0);
            label117.Name = "label117";
            label117.Size = new Size(72, 25);
            label117.TabIndex = 10065;
            label117.Text = "Color";
            // 
            // label118
            // 
            label118.BackColor = Color.Transparent;
            label118.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label118.ForeColor = Color.FromArgb(200, 200, 200);
            label118.Location = new Point(291, 5);
            label118.Margin = new Padding(4, 0, 4, 0);
            label118.Name = "label118";
            label118.Size = new Size(75, 25);
            label118.TabIndex = 10066;
            label118.Text = "Font";
            // 
            // label119
            // 
            label119.BackColor = Color.Transparent;
            label119.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label119.ForeColor = Color.FromArgb(200, 200, 200);
            label119.Location = new Point(524, 5);
            label119.Margin = new Padding(4, 0, 4, 0);
            label119.Name = "label119";
            label119.Size = new Size(62, 25);
            label119.TabIndex = 10068;
            label119.Text = "Size";
            // 
            // label120
            // 
            label120.BackColor = Color.Transparent;
            label120.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label120.ForeColor = Color.FromArgb(200, 200, 200);
            label120.Location = new Point(594, 5);
            label120.Margin = new Padding(4, 0, 4, 0);
            label120.Name = "label120";
            label120.Size = new Size(88, 25);
            label120.TabIndex = 10067;
            label120.Text = "Enabled";
            // 
            // panel70
            // 
            panel70.BackColor = Color.FromArgb(22, 22, 22);
            panel70.Controls.Add(alertsTabPage.alertsTitleFontOutlineNumericUpDown);
            panel70.Controls.Add(alertsTabPage.alertsTitleOutlineCheckBox);
            panel70.Controls.Add(alertsTabPage.alertsTitleOutlineLabel);
            panel70.Controls.Add(alertsTabPage.alertsTitleFontOutlineColorPictureBox);
            panel70.Location = new Point(3, 298);
            panel70.Margin = new Padding(4, 5, 4, 5);
            panel70.Name = "panel70";
            panel70.Size = new Size(694, 35);
            panel70.TabIndex = 10071;
            // 
            // alertsTitleFontOutlineNumericUpDown
            // 
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Name = "alertsTitleFontOutlineNumericUpDown";
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.TabIndex = 45;
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsTitleOutlineCheckBox
            // 
            alertsTabPage.alertsTitleOutlineCheckBox.AutoSize = true;
            alertsTabPage.alertsTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsTitleOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsTitleOutlineCheckBox.Location = new Point(620, 8);
            alertsTabPage.alertsTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsTitleOutlineCheckBox.Name = "alertsTitleOutlineCheckBox";
            alertsTabPage.alertsTitleOutlineCheckBox.Size = new Size(22, 21);
            alertsTabPage.alertsTitleOutlineCheckBox.TabIndex = 45;
            alertsTabPage.alertsTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsTitleOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsTitleOutlineLabel
            // 
            alertsTabPage.alertsTitleOutlineLabel.BackColor = Color.Transparent;
            alertsTabPage.alertsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsTitleOutlineLabel.Location = new Point(4, 5);
            alertsTabPage.alertsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            alertsTabPage.alertsTitleOutlineLabel.Name = "alertsTitleOutlineLabel";
            alertsTabPage.alertsTitleOutlineLabel.Size = new Size(216, 25);
            alertsTabPage.alertsTitleOutlineLabel.TabIndex = 10066;
            alertsTabPage.alertsTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // alertsTitleFontOutlineColorPictureBox
            // 
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Name = "alertsTitleFontOutlineColorPictureBox";
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.TabStop = false;
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsOpenWindowButton
            // 
            alertsTabPage.alertsOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            alertsTabPage.alertsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            alertsTabPage.alertsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsTabPage.alertsOpenWindowButton.Location = new Point(573, 3);
            alertsTabPage.alertsOpenWindowButton.Margin = new Padding(0);
            alertsTabPage.alertsOpenWindowButton.Name = "alertsOpenWindowButton";
            alertsTabPage.alertsOpenWindowButton.Size = new Size(112, 42);
            alertsTabPage.alertsOpenWindowButton.TabIndex = 10021;
            alertsTabPage.alertsOpenWindowButton.Text = "Open";
            alertsTabPage.alertsOpenWindowButton.UseVisualStyleBackColor = false;
            alertsTabPage.alertsOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // alertsDescriptionOutlinePanel
            // 
            alertsTabPage.alertsDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(label122);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionOutlineCheckBox);
            alertsTabPage.alertsDescriptionOutlinePanel.Location = new Point(3, 332);
            alertsTabPage.alertsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionOutlinePanel.Name = "alertsDescriptionOutlinePanel";
            alertsTabPage.alertsDescriptionOutlinePanel.Size = new Size(694, 35);
            alertsTabPage.alertsDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label122
            // 
            label122.BackColor = Color.Transparent;
            label122.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label122.ForeColor = Color.FromArgb(44, 151, 250);
            label122.Location = new Point(4, 6);
            label122.Margin = new Padding(4, 0, 4, 0);
            label122.Name = "label122";
            label122.Size = new Size(216, 25);
            label122.TabIndex = 10066;
            label122.Text = "Description OutlineColor";
            // 
            // alertsDescriptionFontOutlineColorPictureBox
            // 
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Name = "alertsDescriptionFontOutlineColorPictureBox";
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.TabStop = false;
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsDescriptionFontOutlineNumericUpDown
            // 
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Name = "alertsDescriptionFontOutlineNumericUpDown";
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsDescriptionOutlineCheckBox
            // 
            alertsTabPage.alertsDescriptionOutlineCheckBox.AutoSize = true;
            alertsTabPage.alertsDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsDescriptionOutlineCheckBox.Location = new Point(620, 9);
            alertsTabPage.alertsDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionOutlineCheckBox.Name = "alertsDescriptionOutlineCheckBox";
            alertsTabPage.alertsDescriptionOutlineCheckBox.Size = new Size(22, 21);
            alertsTabPage.alertsDescriptionOutlineCheckBox.TabIndex = 45;
            alertsTabPage.alertsDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsDescriptionOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsDescriptionPanel
            // 
            alertsTabPage.alertsDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(label123);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(alertsTabPage.alertsDescriptionFontColorPictureBox);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(alertsTabPage.alertsDescriptionFontComboBox);
            alertsTabPage.alertsDescriptionPanel.Location = new Point(3, 197);
            alertsTabPage.alertsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionPanel.Name = "alertsDescriptionPanel";
            alertsTabPage.alertsDescriptionPanel.Size = new Size(694, 35);
            alertsTabPage.alertsDescriptionPanel.TabIndex = 10061;
            // 
            // label123
            // 
            label123.BackColor = Color.Transparent;
            label123.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label123.ForeColor = Color.FromArgb(44, 151, 250);
            label123.Location = new Point(4, 6);
            label123.Margin = new Padding(4, 0, 4, 0);
            label123.Name = "label123";
            label123.Size = new Size(216, 25);
            label123.TabIndex = 10066;
            label123.Text = "Description";
            // 
            // alertsDescriptionFontColorPictureBox
            // 
            alertsTabPage.alertsDescriptionFontColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsDescriptionFontColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionFontColorPictureBox.Name = "alertsDescriptionFontColorPictureBox";
            alertsTabPage.alertsDescriptionFontColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsDescriptionFontColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsDescriptionFontColorPictureBox.TabStop = false;
            alertsTabPage.alertsDescriptionFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsDescriptionFontComboBox
            // 
            alertsTabPage.alertsDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsDescriptionFontComboBox.FlatStyle = FlatStyle.System;
            alertsTabPage.alertsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsDescriptionFontComboBox.ForeColor = Color.White;
            alertsTabPage.alertsDescriptionFontComboBox.FormattingEnabled = true;
            alertsTabPage.alertsDescriptionFontComboBox.Location = new Point(290, 3);
            alertsTabPage.alertsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsDescriptionFontComboBox.Name = "alertsDescriptionFontComboBox";
            alertsTabPage.alertsDescriptionFontComboBox.Size = new Size(301, 28);
            alertsTabPage.alertsDescriptionFontComboBox.TabIndex = 45;
            alertsTabPage.alertsDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // alertsAutoOpenWindowCheckbox
            // 
            alertsTabPage.alertsAutoOpenWindowCheckbox.AutoSize = true;
            alertsTabPage.alertsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            alertsTabPage.alertsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            alertsTabPage.alertsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsAutoOpenWindowCheckbox.Name = "alertsAutoOpenWindowCheckbox";
            alertsTabPage.alertsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            alertsTabPage.alertsAutoOpenWindowCheckbox.TabIndex = 10022;
            alertsTabPage.alertsAutoOpenWindowCheckbox.Text = "Auto-Open";
            alertsTabPage.alertsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox20.Location = new Point(3, 49);
            pictureBox20.Margin = new Padding(4, 5, 4, 5);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(690, 3);
            pictureBox20.TabIndex = 10063;
            pictureBox20.TabStop = false;
            // 
            // panel73
            // 
            panel73.BackColor = Color.FromArgb(22, 22, 22);
            panel73.Controls.Add(alertsTabPage.alertsBackgroundColorPictureBox);
            panel73.Controls.Add(label124);
            panel73.Location = new Point(3, 95);
            panel73.Margin = new Padding(4, 5, 4, 5);
            panel73.Name = "panel73";
            panel73.Size = new Size(694, 35);
            panel73.TabIndex = 10061;
            // 
            // alertsBackgroundColorPictureBox
            // 
            alertsTabPage.alertsBackgroundColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsBackgroundColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsBackgroundColorPictureBox.Name = "alertsBackgroundColorPictureBox";
            alertsTabPage.alertsBackgroundColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsBackgroundColorPictureBox.TabIndex = 42;
            alertsTabPage.alertsBackgroundColorPictureBox.TabStop = false;
            alertsTabPage.alertsBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label124
            // 
            label124.BackColor = Color.Transparent;
            label124.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label124.ForeColor = Color.FromArgb(44, 151, 250);
            label124.Location = new Point(4, 5);
            label124.Margin = new Padding(4, 0, 4, 0);
            label124.Name = "label124";
            label124.Size = new Size(216, 25);
            label124.TabIndex = 10064;
            label124.Text = "Window Background";
            // 
            // panel74
            // 
            panel74.BackColor = Color.FromArgb(22, 22, 22);
            panel74.Controls.Add(alertsTabPage.alertsTitleLabel);
            panel74.Controls.Add(alertsTabPage.alertsTitleFontColorPictureBox);
            panel74.Controls.Add(alertsTabPage.alertsTitleFontComboBox);
            panel74.Location = new Point(3, 163);
            panel74.Margin = new Padding(4, 5, 4, 5);
            panel74.Name = "panel74";
            panel74.Size = new Size(694, 35);
            panel74.TabIndex = 10061;
            // 
            // alertsTitleLabel
            // 
            alertsTabPage.alertsTitleLabel.BackColor = Color.Transparent;
            alertsTabPage.alertsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsTitleLabel.Location = new Point(4, 6);
            alertsTabPage.alertsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            alertsTabPage.alertsTitleLabel.Name = "alertsTitleLabel";
            alertsTabPage.alertsTitleLabel.Size = new Size(216, 25);
            alertsTabPage.alertsTitleLabel.TabIndex = 10065;
            alertsTabPage.alertsTitleLabel.Text = "Title";
            // 
            // alertsTitleFontColorPictureBox
            // 
            alertsTabPage.alertsTitleFontColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsTitleFontColorPictureBox.Location = new Point(230, 6);
            alertsTabPage.alertsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsTitleFontColorPictureBox.Name = "alertsTitleFontColorPictureBox";
            alertsTabPage.alertsTitleFontColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsTitleFontColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsTitleFontColorPictureBox.TabStop = false;
            alertsTabPage.alertsTitleFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsTitleFontComboBox
            // 
            alertsTabPage.alertsTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsTitleFontComboBox.FlatStyle = FlatStyle.System;
            alertsTabPage.alertsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsTitleFontComboBox.ForeColor = Color.White;
            alertsTabPage.alertsTitleFontComboBox.FormattingEnabled = true;
            alertsTabPage.alertsTitleFontComboBox.Location = new Point(290, 3);
            alertsTabPage.alertsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsTitleFontComboBox.Name = "alertsTitleFontComboBox";
            alertsTabPage.alertsTitleFontComboBox.Size = new Size(301, 28);
            alertsTabPage.alertsTitleFontComboBox.TabIndex = 45;
            alertsTabPage.alertsTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // alertsPointsOutlinePanel
            // 
            alertsTabPage.alertsPointsOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsFontOutlineNumericUpDown);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsOutlineCheckBox);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(label126);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsFontOutlineColorPictureBox);
            alertsTabPage.alertsPointsOutlinePanel.Location = new Point(3, 366);
            alertsTabPage.alertsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsOutlinePanel.Name = "alertsPointsOutlinePanel";
            alertsTabPage.alertsPointsOutlinePanel.Size = new Size(694, 35);
            alertsTabPage.alertsPointsOutlinePanel.TabIndex = 10061;
            // 
            // alertsPointsFontOutlineNumericUpDown
            // 
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Name = "alertsPointsFontOutlineNumericUpDown";
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.TabIndex = 45;
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsPointsOutlineCheckBox
            // 
            alertsTabPage.alertsPointsOutlineCheckBox.AutoSize = true;
            alertsTabPage.alertsPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsPointsOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsPointsOutlineCheckBox.Location = new Point(620, 8);
            alertsTabPage.alertsPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsOutlineCheckBox.Name = "alertsPointsOutlineCheckBox";
            alertsTabPage.alertsPointsOutlineCheckBox.Size = new Size(22, 21);
            alertsTabPage.alertsPointsOutlineCheckBox.TabIndex = 45;
            alertsTabPage.alertsPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsPointsOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label126
            // 
            label126.BackColor = Color.Transparent;
            label126.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label126.ForeColor = Color.FromArgb(44, 151, 250);
            label126.Location = new Point(4, 5);
            label126.Margin = new Padding(4, 0, 4, 0);
            label126.Name = "label126";
            label126.Size = new Size(216, 25);
            label126.TabIndex = 10066;
            label126.Text = "Points OutlineColor";
            // 
            // alertsPointsFontOutlineColorPictureBox
            // 
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Name = "alertsPointsFontOutlineColorPictureBox";
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.TabStop = false;
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsLineOutlinePanel
            // 
            alertsTabPage.alertsLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(label127);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineColorPictureBox);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineNumericUpDown);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineCheckBox);
            alertsTabPage.alertsLineOutlinePanel.Location = new Point(3, 400);
            alertsTabPage.alertsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLineOutlinePanel.Name = "alertsLineOutlinePanel";
            alertsTabPage.alertsLineOutlinePanel.Size = new Size(694, 35);
            alertsTabPage.alertsLineOutlinePanel.TabIndex = 10067;
            // 
            // label127
            // 
            label127.BackColor = Color.Transparent;
            label127.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label127.ForeColor = Color.FromArgb(44, 151, 250);
            label127.Location = new Point(4, 6);
            label127.Margin = new Padding(4, 0, 4, 0);
            label127.Name = "label127";
            label127.Size = new Size(216, 25);
            label127.TabIndex = 10066;
            label127.Text = "Line OutlineColor";
            // 
            // alertsLineOutlineColorPictureBox
            // 
            alertsTabPage.alertsLineOutlineColorPictureBox.BackColor = Color.White;
            alertsTabPage.alertsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTabPage.alertsLineOutlineColorPictureBox.Location = new Point(230, 6);
            alertsTabPage.alertsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLineOutlineColorPictureBox.Name = "alertsLineOutlineColorPictureBox";
            alertsTabPage.alertsLineOutlineColorPictureBox.Size = new Size(22, 22);
            alertsTabPage.alertsLineOutlineColorPictureBox.TabIndex = 45;
            alertsTabPage.alertsLineOutlineColorPictureBox.TabStop = false;
            alertsTabPage.alertsLineOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // alertsLineOutlineNumericUpDown
            // 
            alertsTabPage.alertsLineOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTabPage.alertsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTabPage.alertsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsLineOutlineNumericUpDown.ForeColor = Color.White;
            alertsTabPage.alertsLineOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTabPage.alertsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLineOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            alertsTabPage.alertsLineOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsLineOutlineNumericUpDown.Name = "alertsLineOutlineNumericUpDown";
            alertsTabPage.alertsLineOutlineNumericUpDown.Size = new Size(64, 24);
            alertsTabPage.alertsLineOutlineNumericUpDown.TabIndex = 45;
            alertsTabPage.alertsLineOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            alertsTabPage.alertsLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // alertsLineOutlineCheckBox
            // 
            alertsTabPage.alertsLineOutlineCheckBox.AutoSize = true;
            alertsTabPage.alertsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsLineOutlineCheckBox.Location = new Point(620, 9);
            alertsTabPage.alertsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsLineOutlineCheckBox.Name = "alertsLineOutlineCheckBox";
            alertsTabPage.alertsLineOutlineCheckBox.Size = new Size(22, 21);
            alertsTabPage.alertsLineOutlineCheckBox.TabIndex = 45;
            alertsTabPage.alertsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsLineOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsCustomAchievementPanel
            // 
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel85);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel84);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel86);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(alertsTabPage.alertsSelectCustomAchievementFileButton);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel83);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(alertsTabPage.alertsAchievementEditOutlineCheckbox);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel87);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel78);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(label130);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(pictureBox13);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel79);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel80);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel81);
            alertsTabPage.alertsCustomAchievementPanel.Controls.Add(panel82);
            alertsTabPage.alertsCustomAchievementPanel.Location = new Point(4, 49);
            alertsTabPage.alertsCustomAchievementPanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomAchievementPanel.Name = "alertsCustomAchievementPanel";
            alertsTabPage.alertsCustomAchievementPanel.Size = new Size(417, 452);
            alertsTabPage.alertsCustomAchievementPanel.TabIndex = 10082;
            // 
            // panel85
            // 
            panel85.BackColor = Color.FromArgb(22, 22, 22);
            panel85.Controls.Add(label136);
            panel85.Controls.Add(alertsTabPage.alertsCustomAchievementAnimationOutComboBox);
            panel85.Location = new Point(3, 366);
            panel85.Margin = new Padding(4, 5, 4, 5);
            panel85.Name = "panel85";
            panel85.Size = new Size(408, 34);
            panel85.TabIndex = 10074;
            // 
            // label136
            // 
            label136.BackColor = Color.Transparent;
            label136.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label136.ForeColor = Color.FromArgb(44, 151, 250);
            label136.Location = new Point(4, 6);
            label136.Margin = new Padding(4, 0, 4, 0);
            label136.Name = "label136";
            label136.Size = new Size(238, 25);
            label136.TabIndex = 10069;
            label136.Text = "Animate Out Direction";
            // 
            // panel84
            // 
            panel84.BackColor = Color.FromArgb(32, 32, 32);
            panel84.Controls.Add(label135);
            panel84.Controls.Add(alertsTabPage.alertsCustomAchievementAnimationInComboBox);
            panel84.Location = new Point(3, 265);
            panel84.Margin = new Padding(4, 5, 4, 5);
            panel84.Name = "panel84";
            panel84.Size = new Size(408, 34);
            panel84.TabIndex = 10071;
            // 
            // label135
            // 
            label135.BackColor = Color.Transparent;
            label135.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label135.ForeColor = Color.FromArgb(44, 151, 250);
            label135.Location = new Point(4, 6);
            label135.Margin = new Padding(4, 0, 4, 0);
            label135.Name = "label135";
            label135.Size = new Size(225, 25);
            label135.TabIndex = 10069;
            label135.Text = "Animate In Direction";
            // 
            // panel86
            // 
            panel86.BackColor = Color.FromArgb(32, 32, 32);
            panel86.Controls.Add(label137);
            panel86.Controls.Add(alertsTabPage.alertsCustomAchievementOutSpeedUpDown);
            panel86.Location = new Point(3, 332);
            panel86.Margin = new Padding(4, 5, 4, 5);
            panel86.Name = "panel86";
            panel86.Size = new Size(408, 34);
            panel86.TabIndex = 10073;
            // 
            // label137
            // 
            label137.BackColor = Color.Transparent;
            label137.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label137.ForeColor = Color.FromArgb(44, 151, 250);
            label137.Location = new Point(4, 6);
            label137.Margin = new Padding(4, 0, 4, 0);
            label137.Name = "label137";
            label137.Size = new Size(225, 25);
            label137.TabIndex = 10069;
            label137.Text = "Animate Out Duration";
            // 
            // panel83
            // 
            panel83.BackColor = Color.FromArgb(22, 22, 22);
            panel83.Controls.Add(label129);
            panel83.Controls.Add(alertsTabPage.alertsCustomAchievementInSpeedUpDown);
            panel83.Location = new Point(3, 231);
            panel83.Margin = new Padding(4, 5, 4, 5);
            panel83.Name = "panel83";
            panel83.Size = new Size(408, 34);
            panel83.TabIndex = 10070;
            // 
            // label129
            // 
            label129.BackColor = Color.Transparent;
            label129.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label129.ForeColor = Color.FromArgb(44, 151, 250);
            label129.Location = new Point(4, 6);
            label129.Margin = new Padding(4, 0, 4, 0);
            label129.Name = "label129";
            label129.Size = new Size(225, 25);
            label129.TabIndex = 10069;
            label129.Text = "Animate In Duration";
            // 
            // panel87
            // 
            panel87.BackColor = Color.FromArgb(22, 22, 22);
            panel87.Controls.Add(label138);
            panel87.Controls.Add(alertsTabPage.alertsCustomAchievementOutNumericUpDown);
            panel87.Location = new Point(3, 298);
            panel87.Margin = new Padding(4, 5, 4, 5);
            panel87.Name = "panel87";
            panel87.Size = new Size(408, 35);
            panel87.TabIndex = 10072;
            // 
            // label138
            // 
            label138.BackColor = Color.Transparent;
            label138.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label138.ForeColor = Color.FromArgb(44, 151, 250);
            label138.Location = new Point(4, 6);
            label138.Margin = new Padding(4, 0, 4, 0);
            label138.Name = "label138";
            label138.Size = new Size(225, 25);
            label138.TabIndex = 10069;
            label138.Text = "Animate Out Time";
            // 
            // panel78
            // 
            panel78.BackColor = Color.FromArgb(32, 32, 32);
            panel78.Controls.Add(label42);
            panel78.Controls.Add(label128);
            panel78.Location = new Point(3, 62);
            panel78.Margin = new Padding(4, 5, 4, 5);
            panel78.Name = "panel78";
            panel78.Size = new Size(408, 35);
            panel78.TabIndex = 10079;
            // 
            // label42
            // 
            label42.BackColor = Color.Transparent;
            label42.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label42.ForeColor = Color.FromArgb(200, 200, 200);
            label42.Location = new Point(4, 5);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new Size(75, 25);
            label42.TabIndex = 10071;
            label42.Text = "Field";
            // 
            // label128
            // 
            label128.BackColor = Color.Transparent;
            label128.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label128.ForeColor = Color.FromArgb(200, 200, 200);
            label128.Location = new Point(279, 5);
            label128.Margin = new Padding(4, 0, 4, 0);
            label128.Name = "label128";
            label128.Size = new Size(87, 25);
            label128.TabIndex = 10073;
            label128.Text = "Value";
            // 
            // label130
            // 
            label130.BackColor = Color.Transparent;
            label130.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label130.ForeColor = Color.FromArgb(44, 151, 250);
            label130.Location = new Point(4, 5);
            label130.Margin = new Padding(4, 0, 4, 0);
            label130.Name = "label130";
            label130.Size = new Size(228, 40);
            label130.TabIndex = 10069;
            label130.Text = "Achievement";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox13.Location = new Point(3, 49);
            pictureBox13.Margin = new Padding(4, 5, 4, 5);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(398, 3);
            pictureBox13.TabIndex = 10070;
            pictureBox13.TabStop = false;
            // 
            // panel79
            // 
            panel79.BackColor = Color.FromArgb(22, 22, 22);
            panel79.Controls.Add(label131);
            panel79.Controls.Add(alertsTabPage.alertsCustomAchievementXNumericUpDown);
            panel79.Location = new Point(3, 95);
            panel79.Margin = new Padding(4, 5, 4, 5);
            panel79.Name = "panel79";
            panel79.Size = new Size(408, 35);
            panel79.TabIndex = 10061;
            // 
            // label131
            // 
            label131.BackColor = Color.Transparent;
            label131.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label131.ForeColor = Color.FromArgb(44, 151, 250);
            label131.Location = new Point(4, 5);
            label131.Margin = new Padding(4, 0, 4, 0);
            label131.Name = "label131";
            label131.Size = new Size(141, 25);
            label131.TabIndex = 10066;
            label131.Text = "X position";
            // 
            // panel80
            // 
            panel80.BackColor = Color.FromArgb(32, 32, 32);
            panel80.Controls.Add(label132);
            panel80.Controls.Add(alertsTabPage.alertsCustomAchievementInNumericUpDown);
            panel80.Location = new Point(3, 197);
            panel80.Margin = new Padding(4, 5, 4, 5);
            panel80.Name = "panel80";
            panel80.Size = new Size(408, 35);
            panel80.TabIndex = 10061;
            // 
            // label132
            // 
            label132.BackColor = Color.Transparent;
            label132.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label132.ForeColor = Color.FromArgb(44, 151, 250);
            label132.Location = new Point(4, 6);
            label132.Margin = new Padding(4, 0, 4, 0);
            label132.Name = "label132";
            label132.Size = new Size(225, 25);
            label132.TabIndex = 10069;
            label132.Text = "Animate In Time";
            // 
            // panel81
            // 
            panel81.BackColor = Color.FromArgb(22, 22, 22);
            panel81.Controls.Add(label133);
            panel81.Controls.Add(alertsTabPage.alertsCustomAchievementScaleNumericUpDown);
            panel81.Location = new Point(3, 163);
            panel81.Margin = new Padding(4, 5, 4, 5);
            panel81.Name = "panel81";
            panel81.Size = new Size(408, 35);
            panel81.TabIndex = 10061;
            // 
            // label133
            // 
            label133.BackColor = Color.Transparent;
            label133.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label133.ForeColor = Color.FromArgb(44, 151, 250);
            label133.Location = new Point(4, 6);
            label133.Margin = new Padding(4, 0, 4, 0);
            label133.Name = "label133";
            label133.Size = new Size(141, 25);
            label133.TabIndex = 10068;
            label133.Text = "Scale";
            // 
            // panel82
            // 
            panel82.BackColor = Color.FromArgb(32, 32, 32);
            panel82.Controls.Add(label134);
            panel82.Controls.Add(alertsTabPage.alertsCustomAchievementYNumericUpDown);
            panel82.Location = new Point(3, 129);
            panel82.Margin = new Padding(4, 5, 4, 5);
            panel82.Name = "panel82";
            panel82.Size = new Size(408, 35);
            panel82.TabIndex = 10061;
            // 
            // label134
            // 
            label134.BackColor = Color.Transparent;
            label134.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label134.ForeColor = Color.FromArgb(44, 151, 250);
            label134.Location = new Point(4, 6);
            label134.Margin = new Padding(4, 0, 4, 0);
            label134.Name = "label134";
            label134.Size = new Size(141, 25);
            label134.TabIndex = 10067;
            label134.Text = "Y position";
            // 
            // alertsAchievementEnableCheckbox
            // 
            alertsTabPage.alertsAchievementEnableCheckbox.AutoSize = true;
            alertsTabPage.alertsAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsAchievementEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsAchievementEnableCheckbox.Location = new Point(16, 9);
            alertsTabPage.alertsAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsAchievementEnableCheckbox.Name = "alertsAchievementEnableCheckbox";
            alertsTabPage.alertsAchievementEnableCheckbox.Size = new Size(106, 29);
            alertsTabPage.alertsAchievementEnableCheckbox.TabIndex = 54;
            alertsTabPage.alertsAchievementEnableCheckbox.Text = "Enable";
            alertsTabPage.alertsAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsAchievementEnableCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomMasteryPanel
            // 
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel89);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel90);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel91);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(alertsTabPage.alertsMasteryEditOutlineCheckbox);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(alertsTabPage.alertsSelectCustomMasteryFileButton);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel92);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel93);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel94);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(label139);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(pictureBox14);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel95);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel96);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel97);
            alertsTabPage.alertsCustomMasteryPanel.Controls.Add(panel98);
            alertsTabPage.alertsCustomMasteryPanel.Location = new Point(4, 49);
            alertsTabPage.alertsCustomMasteryPanel.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsCustomMasteryPanel.Name = "alertsCustomMasteryPanel";
            alertsTabPage.alertsCustomMasteryPanel.Size = new Size(418, 452);
            alertsTabPage.alertsCustomMasteryPanel.TabIndex = 10083;
            // 
            // panel89
            // 
            panel89.BackColor = Color.FromArgb(22, 22, 22);
            panel89.Controls.Add(label6);
            panel89.Controls.Add(alertsTabPage.alertsCustomMasteryAnimationOutComboBox);
            panel89.Location = new Point(3, 366);
            panel89.Margin = new Padding(4, 5, 4, 5);
            panel89.Name = "panel89";
            panel89.Size = new Size(408, 35);
            panel89.TabIndex = 10074;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = Color.FromArgb(44, 151, 250);
            label6.Location = new Point(4, 6);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(238, 25);
            label6.TabIndex = 10069;
            label6.Text = "Animate Out Direction";
            // 
            // panel90
            // 
            panel90.BackColor = Color.FromArgb(32, 32, 32);
            panel90.Controls.Add(label7);
            panel90.Controls.Add(alertsTabPage.alertsCustomMasteryAnimationInComboBox);
            panel90.Location = new Point(3, 265);
            panel90.Margin = new Padding(4, 5, 4, 5);
            panel90.Name = "panel90";
            panel90.Size = new Size(408, 35);
            panel90.TabIndex = 10071;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = Color.FromArgb(44, 151, 250);
            label7.Location = new Point(4, 6);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(225, 25);
            label7.TabIndex = 10069;
            label7.Text = "Animate In Direction";
            // 
            // panel91
            // 
            panel91.BackColor = Color.FromArgb(32, 32, 32);
            panel91.Controls.Add(label8);
            panel91.Controls.Add(alertsTabPage.alertsCustomMasteryOutSpeedUpDown);
            panel91.Location = new Point(3, 332);
            panel91.Margin = new Padding(4, 5, 4, 5);
            panel91.Name = "panel91";
            panel91.Size = new Size(408, 35);
            panel91.TabIndex = 10073;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = Color.FromArgb(44, 151, 250);
            label8.Location = new Point(4, 6);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(225, 25);
            label8.TabIndex = 10069;
            label8.Text = "Animate Out Duration";
            // 
            // panel92
            // 
            panel92.BackColor = Color.FromArgb(22, 22, 22);
            panel92.Controls.Add(label11);
            panel92.Controls.Add(alertsTabPage.alertsCustomMasteryInSpeedUpDown);
            panel92.Location = new Point(3, 231);
            panel92.Margin = new Padding(4, 5, 4, 5);
            panel92.Name = "panel92";
            panel92.Size = new Size(408, 35);
            panel92.TabIndex = 10070;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = Color.FromArgb(44, 151, 250);
            label11.Location = new Point(4, 6);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(225, 25);
            label11.TabIndex = 10069;
            label11.Text = "Animate In Duration";
            // 
            // panel93
            // 
            panel93.BackColor = Color.FromArgb(22, 22, 22);
            panel93.Controls.Add(label12);
            panel93.Controls.Add(alertsTabPage.alertsCustomMasteryOutNumericUpDown);
            panel93.Location = new Point(3, 298);
            panel93.Margin = new Padding(4, 5, 4, 5);
            panel93.Name = "panel93";
            panel93.Size = new Size(408, 35);
            panel93.TabIndex = 10072;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = Color.FromArgb(44, 151, 250);
            label12.Location = new Point(4, 6);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(225, 25);
            label12.TabIndex = 10069;
            label12.Text = "Animate Out Time";
            // 
            // panel94
            // 
            panel94.BackColor = Color.FromArgb(32, 32, 32);
            panel94.Controls.Add(label13);
            panel94.Controls.Add(label14);
            panel94.Location = new Point(3, 62);
            panel94.Margin = new Padding(4, 5, 4, 5);
            panel94.Name = "panel94";
            panel94.Size = new Size(408, 35);
            panel94.TabIndex = 10079;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = Color.FromArgb(200, 200, 200);
            label13.Location = new Point(4, 5);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 25);
            label13.TabIndex = 10071;
            label13.Text = "Field";
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = Color.FromArgb(200, 200, 200);
            label14.Location = new Point(279, 5);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(87, 25);
            label14.TabIndex = 10073;
            label14.Text = "Value";
            // 
            // label139
            // 
            label139.BackColor = Color.Transparent;
            label139.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label139.ForeColor = Color.FromArgb(44, 151, 250);
            label139.Location = new Point(4, 5);
            label139.Margin = new Padding(4, 0, 4, 0);
            label139.Name = "label139";
            label139.Size = new Size(228, 40);
            label139.TabIndex = 10069;
            label139.Text = "Mastery";
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox14.Location = new Point(3, 49);
            pictureBox14.Margin = new Padding(4, 5, 4, 5);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(398, 3);
            pictureBox14.TabIndex = 10070;
            pictureBox14.TabStop = false;
            // 
            // panel95
            // 
            panel95.BackColor = Color.FromArgb(22, 22, 22);
            panel95.Controls.Add(label140);
            panel95.Controls.Add(alertsTabPage.alertsCustomMasteryXNumericUpDown);
            panel95.Location = new Point(3, 95);
            panel95.Margin = new Padding(4, 5, 4, 5);
            panel95.Name = "panel95";
            panel95.Size = new Size(408, 35);
            panel95.TabIndex = 10061;
            // 
            // label140
            // 
            label140.BackColor = Color.Transparent;
            label140.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label140.ForeColor = Color.FromArgb(44, 151, 250);
            label140.Location = new Point(4, 5);
            label140.Margin = new Padding(4, 0, 4, 0);
            label140.Name = "label140";
            label140.Size = new Size(141, 25);
            label140.TabIndex = 10066;
            label140.Text = "X position";
            // 
            // panel96
            // 
            panel96.BackColor = Color.FromArgb(32, 32, 32);
            panel96.Controls.Add(label141);
            panel96.Controls.Add(alertsTabPage.alertsCustomMasteryInNumericUpDown);
            panel96.Location = new Point(3, 197);
            panel96.Margin = new Padding(4, 5, 4, 5);
            panel96.Name = "panel96";
            panel96.Size = new Size(408, 35);
            panel96.TabIndex = 10061;
            // 
            // label141
            // 
            label141.BackColor = Color.Transparent;
            label141.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label141.ForeColor = Color.FromArgb(44, 151, 250);
            label141.Location = new Point(4, 6);
            label141.Margin = new Padding(4, 0, 4, 0);
            label141.Name = "label141";
            label141.Size = new Size(225, 25);
            label141.TabIndex = 10069;
            label141.Text = "Animate In Time";
            // 
            // panel97
            // 
            panel97.BackColor = Color.FromArgb(22, 22, 22);
            panel97.Controls.Add(label142);
            panel97.Controls.Add(alertsTabPage.alertsCustomMasteryScaleNumericUpDown);
            panel97.Location = new Point(3, 163);
            panel97.Margin = new Padding(4, 5, 4, 5);
            panel97.Name = "panel97";
            panel97.Size = new Size(408, 35);
            panel97.TabIndex = 10061;
            // 
            // label142
            // 
            label142.BackColor = Color.Transparent;
            label142.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label142.ForeColor = Color.FromArgb(44, 151, 250);
            label142.Location = new Point(4, 6);
            label142.Margin = new Padding(4, 0, 4, 0);
            label142.Name = "label142";
            label142.Size = new Size(141, 25);
            label142.TabIndex = 10068;
            label142.Text = "Scale";
            // 
            // panel98
            // 
            panel98.BackColor = Color.FromArgb(32, 32, 32);
            panel98.Controls.Add(label143);
            panel98.Controls.Add(alertsTabPage.alertsCustomMasteryYNumericUpDown);
            panel98.Location = new Point(3, 129);
            panel98.Margin = new Padding(4, 5, 4, 5);
            panel98.Name = "panel98";
            panel98.Size = new Size(408, 35);
            panel98.TabIndex = 10061;
            // 
            // label143
            // 
            label143.BackColor = Color.Transparent;
            label143.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label143.ForeColor = Color.FromArgb(44, 151, 250);
            label143.Location = new Point(4, 6);
            label143.Margin = new Padding(4, 0, 4, 0);
            label143.Name = "label143";
            label143.Size = new Size(141, 25);
            label143.TabIndex = 10067;
            label143.Text = "Y position";
            // 
            // alertsMasteryEnableCheckbox
            // 
            alertsTabPage.alertsMasteryEnableCheckbox.AutoSize = true;
            alertsTabPage.alertsMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTabPage.alertsMasteryEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTabPage.alertsMasteryEnableCheckbox.Location = new Point(16, 9);
            alertsTabPage.alertsMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsTabPage.alertsMasteryEnableCheckbox.Name = "alertsMasteryEnableCheckbox";
            alertsTabPage.alertsMasteryEnableCheckbox.Size = new Size(106, 29);
            alertsTabPage.alertsMasteryEnableCheckbox.TabIndex = 54;
            alertsTabPage.alertsMasteryEnableCheckbox.Text = "Enable";
            alertsTabPage.alertsMasteryEnableCheckbox.UseVisualStyleBackColor = true;
            alertsTabPage.alertsMasteryEnableCheckbox.CheckedChanged += new System.EventHandler(CustomAlertsCheckBox_CheckedChanged);
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(32, 32, 32);
            panel14.Controls.Add(userInfoTabPage.userInfoUsernameLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoRankLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoPointsLabel);
            panel14.Controls.Add(label37);
            panel14.Controls.Add(userInfoTabPage.userInfoTruePointsLabel);
            panel14.Controls.Add(userProfilePictureBox);
            panel14.Controls.Add(userInfoTabPage.userInfoMottoLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoRatioLabel);
            panel14.Controls.Add(pictureBox2);
            panel14.Location = new Point(444, 283);
            panel14.Margin = new Padding(4, 5, 4, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(702, 278);
            panel14.TabIndex = 10079;
            // 
            // userInfoUsernameLabel
            // 
            userInfoTabPage.userInfoUsernameLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoUsernameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoUsernameLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoUsernameLabel.Location = new Point(4, 5);
            userInfoTabPage.userInfoUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoUsernameLabel.Name = "userInfoUsernameLabel";
            userInfoTabPage.userInfoUsernameLabel.Size = new Size(688, 40);
            userInfoTabPage.userInfoUsernameLabel.TabIndex = 10058;
            userInfoTabPage.userInfoUsernameLabel.Text = "Username";
            // 
            // userInfoRankLabel
            // 
            userInfoTabPage.userInfoRankLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoRankLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRankLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoRankLabel.Location = new Point(9, 120);
            userInfoTabPage.userInfoRankLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoRankLabel.Name = "userInfoRankLabel";
            userInfoTabPage.userInfoRankLabel.Size = new Size(303, 25);
            userInfoTabPage.userInfoRankLabel.TabIndex = 10054;
            userInfoTabPage.userInfoRankLabel.Text = "Site Rank: 15000";
            // 
            // userInfoPointsLabel
            // 
            userInfoTabPage.userInfoPointsLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoPointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoPointsLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoPointsLabel.Location = new Point(9, 95);
            userInfoTabPage.userInfoPointsLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoPointsLabel.Name = "userInfoPointsLabel";
            userInfoTabPage.userInfoPointsLabel.Size = new Size(280, 25);
            userInfoTabPage.userInfoPointsLabel.TabIndex = 10055;
            userInfoTabPage.userInfoPointsLabel.Text = "Hardcore Points: 348897";
            // 
            // label37
            // 
            label37.BackColor = Color.Transparent;
            label37.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label37.ForeColor = Color.FromArgb(44, 151, 250);
            label37.Location = new Point(9, 145);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(141, 25);
            label37.TabIndex = 10075;
            label37.Text = "Retro Ratio:";
            // 
            // userInfoTruePointsLabel
            // 
            userInfoTabPage.userInfoTruePointsLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoTruePointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoTruePointsLabel.ForeColor = Color.White;
            userInfoTabPage.userInfoTruePointsLabel.Location = new Point(291, 95);
            userInfoTabPage.userInfoTruePointsLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoTruePointsLabel.Name = "userInfoTruePointsLabel";
            userInfoTabPage.userInfoTruePointsLabel.Size = new Size(128, 25);
            userInfoTabPage.userInfoTruePointsLabel.TabIndex = 10056;
            userInfoTabPage.userInfoTruePointsLabel.Text = "(10019920)";
            // 
            // userInfoMottoLabel
            // 
            userInfoTabPage.userInfoMottoLabel.AutoSize = true;
            userInfoTabPage.userInfoMottoLabel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoMottoLabel.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoMottoLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoMottoLabel.Location = new Point(9, 57);
            userInfoTabPage.userInfoMottoLabel.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoMottoLabel.Name = "userInfoMottoLabel";
            userInfoTabPage.userInfoMottoLabel.Padding = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoMottoLabel.Size = new Size(240, 35);
            userInfoTabPage.userInfoMottoLabel.TabIndex = 10074;
            userInfoTabPage.userInfoMottoLabel.Text = "twitch.tv/RetroS3xual";
            // 
            // userInfoRatioLabel
            // 
            userInfoTabPage.userInfoRatioLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoRatioLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoRatioLabel.ForeColor = Color.White;
            userInfoTabPage.userInfoRatioLabel.Location = new Point(146, 145);
            userInfoTabPage.userInfoRatioLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoRatioLabel.Name = "userInfoRatioLabel";
            userInfoTabPage.userInfoRatioLabel.Size = new Size(110, 25);
            userInfoTabPage.userInfoRatioLabel.TabIndex = 10057;
            userInfoTabPage.userInfoRatioLabel.Text = "3.62";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox2.Location = new Point(3, 49);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(690, 3);
            pictureBox2.TabIndex = 10059;
            pictureBox2.TabStop = false;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(32, 32, 32);
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(label28);
            panel21.Controls.Add(userInfoTabPage.userInfoDefaultButton);
            panel21.Controls.Add(pictureBox4);
            panel21.Controls.Add(panel10);
            panel21.Controls.Add(panel13);
            panel21.Controls.Add(panel12);
            panel21.Controls.Add(panel11);
            panel21.Location = new Point(6, 5);
            panel21.Margin = new Padding(4, 5, 4, 5);
            panel21.Name = "panel21";
            panel21.Size = new Size(430, 243);
            panel21.TabIndex = 10078;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(32, 32, 32);
            panel22.Controls.Add(label29);
            panel22.Controls.Add(label32);
            panel22.Controls.Add(label30);
            panel22.Location = new Point(3, 62);
            panel22.Margin = new Padding(4, 5, 4, 5);
            panel22.Name = "panel22";
            panel22.Size = new Size(417, 35);
            panel22.TabIndex = 10079;
            // 
            // label29
            // 
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label29.ForeColor = Color.FromArgb(200, 200, 200);
            label29.Location = new Point(4, 5);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(75, 25);
            label29.TabIndex = 10071;
            label29.Text = "Field";
            // 
            // label32
            // 
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label32.ForeColor = Color.FromArgb(200, 200, 200);
            label32.Location = new Point(170, 5);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(153, 25);
            label32.TabIndex = 10073;
            label32.Text = "Display Text";
            // 
            // label30
            // 
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label30.ForeColor = Color.FromArgb(200, 200, 200);
            label30.Location = new Point(332, 5);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(92, 25);
            label30.TabIndex = 10072;
            label30.Text = "Enabled";
            // 
            // label28
            // 
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label28.ForeColor = Color.FromArgb(44, 151, 250);
            label28.Location = new Point(4, 5);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(285, 40);
            label28.TabIndex = 10069;
            label28.Text = "Field Overrides";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox4.Location = new Point(3, 49);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(412, 3);
            pictureBox4.TabIndex = 10070;
            pictureBox4.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(22, 22, 22);
            panel10.Controls.Add(label31);
            panel10.Controls.Add(userInfoTabPage.userInfoRankCheckBox);
            panel10.Controls.Add(userInfoTabPage.userInfoRankTextBox);
            panel10.Location = new Point(3, 95);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(417, 35);
            panel10.TabIndex = 10061;
            // 
            // label31
            // 
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label31.ForeColor = Color.FromArgb(44, 151, 250);
            label31.Location = new Point(4, 5);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(141, 25);
            label31.TabIndex = 10066;
            label31.Text = "Rank";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(32, 32, 32);
            panel13.Controls.Add(label35);
            panel13.Controls.Add(userInfoTabPage.userInfoRatioCheckBox);
            panel13.Controls.Add(userInfoTabPage.userInfoRatioTextBox);
            panel13.Location = new Point(3, 197);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(417, 35);
            panel13.TabIndex = 10061;
            // 
            // label35
            // 
            label35.BackColor = Color.Transparent;
            label35.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label35.ForeColor = Color.FromArgb(44, 151, 250);
            label35.Location = new Point(4, 6);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(141, 25);
            label35.TabIndex = 10069;
            label35.Text = "Retro Ratio";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(22, 22, 22);
            panel12.Controls.Add(label34);
            panel12.Controls.Add(userInfoTabPage.userInfoTruePointsTextBox);
            panel12.Controls.Add(userInfoTabPage.userInfoTruePointsCheckBox);
            panel12.Location = new Point(3, 163);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(417, 35);
            panel12.TabIndex = 10061;
            // 
            // label34
            // 
            label34.BackColor = Color.Transparent;
            label34.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label34.ForeColor = Color.FromArgb(44, 151, 250);
            label34.Location = new Point(4, 6);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(141, 25);
            label34.TabIndex = 10068;
            label34.Text = "True Points";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(32, 32, 32);
            panel11.Controls.Add(label33);
            panel11.Controls.Add(userInfoTabPage.userInfoPointsTextBox);
            panel11.Controls.Add(userInfoTabPage.userInfoPointsCheckBox);
            panel11.Location = new Point(3, 129);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(417, 35);
            panel11.TabIndex = 10061;
            // 
            // label33
            // 
            label33.BackColor = Color.Transparent;
            label33.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label33.ForeColor = Color.FromArgb(44, 151, 250);
            label33.Location = new Point(4, 6);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(141, 25);
            label33.TabIndex = 10067;
            label33.Text = "Points";
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(32, 32, 32);
            panel20.Controls.Add(label2);
            panel20.Controls.Add(panel4);
            panel20.Controls.Add(userInfoTabPage.userInfoOpenWindowButton);
            panel20.Controls.Add(userInfoTabPage.userInfoValuesPanel);
            panel20.Controls.Add(userInfoTabPage.userInfoAutoOpenWindowCheckbox);
            panel20.Controls.Add(pictureBox3);
            panel20.Controls.Add(panel5);
            panel20.Controls.Add(panel6);
            panel20.Controls.Add(panel7);
            panel20.Controls.Add(userInfoTabPage.userInfoValuesOutlinePanel);
            panel20.Location = new Point(444, 5);
            panel20.Margin = new Padding(4, 5, 4, 5);
            panel20.Name = "panel20";
            panel20.Size = new Size(702, 271);
            panel20.TabIndex = 10077;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = Color.FromArgb(44, 151, 250);
            label2.Location = new Point(4, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 40);
            label2.TabIndex = 10062;
            label2.Text = "Window/Font Settings";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(32, 32, 32);
            panel4.Controls.Add(userInfoTabPage.userInfoAdvancedCheckBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(3, 62);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(694, 35);
            panel4.TabIndex = 10076;
            // 
            // userInfoAdvancedCheckBox
            // 
            userInfoTabPage.userInfoAdvancedCheckBox.AutoSize = true;
            userInfoTabPage.userInfoAdvancedCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            userInfoTabPage.userInfoAdvancedCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoAdvancedCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(118, 118, 118);
            userInfoTabPage.userInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoAdvancedCheckBox.Location = new Point(8, 3);
            userInfoTabPage.userInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoAdvancedCheckBox.Name = "userInfoAdvancedCheckBox";
            userInfoTabPage.userInfoAdvancedCheckBox.Size = new Size(135, 29);
            userInfoTabPage.userInfoAdvancedCheckBox.TabIndex = 10053;
            userInfoTabPage.userInfoAdvancedCheckBox.Text = "Advanced";
            userInfoTabPage.userInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            userInfoTabPage.userInfoAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = Color.FromArgb(200, 200, 200);
            label4.Location = new Point(225, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 10065;
            label4.Text = "Color";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = Color.FromArgb(200, 200, 200);
            label9.Location = new Point(291, 5);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 10066;
            label9.Text = "Font";
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label25.ForeColor = Color.FromArgb(200, 200, 200);
            label25.Location = new Point(524, 5);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(62, 25);
            label25.TabIndex = 10068;
            label25.Text = "Size";
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label15.ForeColor = Color.FromArgb(200, 200, 200);
            label15.Location = new Point(594, 5);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(88, 25);
            label15.TabIndex = 10067;
            label15.Text = "Enabled";
            // 
            // userInfoValuesPanel
            // 
            userInfoTabPage.userInfoValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoValuesPanel.Controls.Add(label26);
            userInfoTabPage.userInfoValuesPanel.Controls.Add(userInfoTabPage.userInfoValuesFontColorPictureBox);
            userInfoTabPage.userInfoValuesPanel.Controls.Add(userInfoTabPage.userInfoValuesFontComboBox);
            userInfoTabPage.userInfoValuesPanel.Location = new Point(3, 163);
            userInfoTabPage.userInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesPanel.Name = "userInfoValuesPanel";
            userInfoTabPage.userInfoValuesPanel.Size = new Size(694, 35);
            userInfoTabPage.userInfoValuesPanel.TabIndex = 10061;
            // 
            // label26
            // 
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label26.ForeColor = Color.FromArgb(44, 151, 250);
            label26.Location = new Point(4, 6);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(216, 25);
            label26.TabIndex = 10066;
            label26.Text = "Values";
            // 
            // userInfoValuesFontColorPictureBox
            // 
            userInfoTabPage.userInfoValuesFontColorPictureBox.BackColor = Color.White;
            userInfoTabPage.userInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoTabPage.userInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            userInfoTabPage.userInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesFontColorPictureBox.Name = "userInfoValuesFontColorPictureBox";
            userInfoTabPage.userInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoValuesFontColorPictureBox.TabIndex = 45;
            userInfoTabPage.userInfoValuesFontColorPictureBox.TabStop = false;
            userInfoTabPage.userInfoValuesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // userInfoValuesFontComboBox
            // 
            userInfoTabPage.userInfoValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoValuesFontComboBox.ForeColor = Color.White;
            userInfoTabPage.userInfoValuesFontComboBox.FormattingEnabled = true;
            userInfoTabPage.userInfoValuesFontComboBox.Location = new Point(290, 3);
            userInfoTabPage.userInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesFontComboBox.Name = "userInfoValuesFontComboBox";
            userInfoTabPage.userInfoValuesFontComboBox.Size = new Size(301, 28);
            userInfoTabPage.userInfoValuesFontComboBox.TabIndex = 45;
            userInfoTabPage.userInfoValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox3.Location = new Point(3, 49);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(690, 3);
            pictureBox3.TabIndex = 10063;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(22, 22, 22);
            panel5.Controls.Add(userInfoTabPage.userInfoBackgroundColorPictureBox);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 95);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(694, 35);
            panel5.TabIndex = 10061;
            // 
            // userInfoBackgroundColorPictureBox
            // 
            userInfoTabPage.userInfoBackgroundColorPictureBox.BackColor = Color.White;
            userInfoTabPage.userInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoTabPage.userInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            userInfoTabPage.userInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoBackgroundColorPictureBox.Name = "userInfoBackgroundColorPictureBox";
            userInfoTabPage.userInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoBackgroundColorPictureBox.TabIndex = 42;
            userInfoTabPage.userInfoBackgroundColorPictureBox.TabStop = false;
            userInfoTabPage.userInfoBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = Color.FromArgb(44, 151, 250);
            label3.Location = new Point(4, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 10064;
            label3.Text = "Window Background";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(32, 32, 32);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesLabel);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesFontColorPictureBox);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesFontComboBox);
            panel6.Location = new Point(3, 129);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(694, 35);
            panel6.TabIndex = 10061;
            // 
            // userInfoNamesLabel
            // 
            userInfoTabPage.userInfoNamesLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoNamesLabel.Location = new Point(4, 6);
            userInfoTabPage.userInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoNamesLabel.Name = "userInfoNamesLabel";
            userInfoTabPage.userInfoNamesLabel.Size = new Size(216, 25);
            userInfoTabPage.userInfoNamesLabel.TabIndex = 10065;
            userInfoTabPage.userInfoNamesLabel.Text = "Names";
            // 
            // userInfoNamesFontColorPictureBox
            // 
            userInfoTabPage.userInfoNamesFontColorPictureBox.BackColor = Color.White;
            userInfoTabPage.userInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoTabPage.userInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            userInfoTabPage.userInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoNamesFontColorPictureBox.Name = "userInfoNamesFontColorPictureBox";
            userInfoTabPage.userInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoNamesFontColorPictureBox.TabIndex = 45;
            userInfoTabPage.userInfoNamesFontColorPictureBox.TabStop = false;
            userInfoTabPage.userInfoNamesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // userInfoNamesFontComboBox
            // 
            userInfoTabPage.userInfoNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoNamesFontComboBox.ForeColor = Color.White;
            userInfoTabPage.userInfoNamesFontComboBox.FormattingEnabled = true;
            userInfoTabPage.userInfoNamesFontComboBox.Location = new Point(290, 3);
            userInfoTabPage.userInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoNamesFontComboBox.Name = "userInfoNamesFontComboBox";
            userInfoTabPage.userInfoNamesFontComboBox.Size = new Size(301, 28);
            userInfoTabPage.userInfoNamesFontComboBox.TabIndex = 45;
            userInfoTabPage.userInfoNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(32, 32, 32);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesOutlineCheckBox);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesOutlineLabel);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox);
            panel7.Location = new Point(3, 197);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(694, 35);
            panel7.TabIndex = 10061;
            // 
            // userInfoNamesFontOutlineNumericUpDown
            // 
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Name = "userInfoNamesFontOutlineNumericUpDown";
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // userInfoNamesOutlineCheckBox
            // 
            userInfoTabPage.userInfoNamesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoNamesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoNamesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoNamesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoNamesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoNamesOutlineCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            userInfoTabPage.userInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoNamesOutlineCheckBox.Name = "userInfoNamesOutlineCheckBox";
            userInfoTabPage.userInfoNamesOutlineCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoNamesOutlineCheckBox.TabIndex = 45;
            userInfoTabPage.userInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoNamesOutlineLabel
            // 
            userInfoTabPage.userInfoNamesOutlineLabel.BackColor = Color.Transparent;
            userInfoTabPage.userInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoTabPage.userInfoNamesOutlineLabel.Location = new Point(4, 5);
            userInfoTabPage.userInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTabPage.userInfoNamesOutlineLabel.Name = "userInfoNamesOutlineLabel";
            userInfoTabPage.userInfoNamesOutlineLabel.Size = new Size(216, 25);
            userInfoTabPage.userInfoNamesOutlineLabel.TabIndex = 10066;
            userInfoTabPage.userInfoNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // userInfoNamesFontOutlineColorPictureBox
            // 
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Name = "userInfoNamesFontOutlineColorPictureBox";
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.TabStop = false;
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // userInfoValuesOutlinePanel
            // 
            userInfoTabPage.userInfoValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(label27);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesOutlineCheckBox);
            userInfoTabPage.userInfoValuesOutlinePanel.Location = new Point(3, 231);
            userInfoTabPage.userInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesOutlinePanel.Name = "userInfoValuesOutlinePanel";
            userInfoTabPage.userInfoValuesOutlinePanel.Size = new Size(694, 35);
            userInfoTabPage.userInfoValuesOutlinePanel.TabIndex = 10067;
            // 
            // label27
            // 
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label27.ForeColor = Color.FromArgb(44, 151, 250);
            label27.Location = new Point(4, 6);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(216, 25);
            label27.TabIndex = 10066;
            label27.Text = "Values OutlineColor";
            // 
            // userInfoValuesFontOutlineColorPictureBox
            // 
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Name = "userInfoValuesFontOutlineColorPictureBox";
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.TabStop = false;
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // userInfoValuesFontOutlineNumericUpDown
            // 
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Name = "userInfoValuesFontOutlineNumericUpDown";
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // userInfoValuesOutlineCheckBox
            // 
            userInfoTabPage.userInfoValuesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoTabPage.userInfoValuesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTabPage.userInfoValuesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTabPage.userInfoValuesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoTabPage.userInfoValuesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTabPage.userInfoValuesOutlineCheckBox.ForeColor = Color.White;
            userInfoTabPage.userInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            userInfoTabPage.userInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTabPage.userInfoValuesOutlineCheckBox.Name = "userInfoValuesOutlineCheckBox";
            userInfoTabPage.userInfoValuesOutlineCheckBox.Size = new Size(22, 22);
            userInfoTabPage.userInfoValuesOutlineCheckBox.TabIndex = 45;
            userInfoTabPage.userInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoTabPage.userInfoValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel50
            // 
            panel50.BackColor = Color.FromArgb(32, 32, 32);
            panel50.Controls.Add(panel119);
            panel50.Controls.Add(panel117);
            panel50.Controls.Add(panel118);
            panel50.Controls.Add(panel116);
            panel50.Controls.Add(gameInfoTabPage.gameInfoTitleLabel);
            panel50.Controls.Add(pictureBox8);
            panel50.Controls.Add(gameInfoTabPage.gameInfoPictureBox);
            panel50.Location = new Point(444, 283);
            panel50.Margin = new Padding(4, 5, 4, 5);
            panel50.Name = "panel50";
            panel50.Size = new Size(702, 278);
            panel50.TabIndex = 10081;
            // 
            // panel119
            // 
            panel119.BackColor = Color.FromArgb(32, 32, 32);
            panel119.Controls.Add(gameInfoTabPage.gameInfoGenreLabel);
            panel119.Controls.Add(label62);
            panel119.Controls.Add(label36);
            panel119.Location = new Point(164, 157);
            panel119.Margin = new Padding(4, 5, 4, 5);
            panel119.Name = "panel119";
            panel119.Size = new Size(522, 38);
            panel119.TabIndex = 10073;
            // 
            // gameInfoGenreLabel
            // 
            gameInfoTabPage.gameInfoGenreLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoGenreLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoGenreLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoTabPage.gameInfoGenreLabel.Location = new Point(154, 8);
            gameInfoTabPage.gameInfoGenreLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoGenreLabel.Name = "gameInfoGenreLabel";
            gameInfoTabPage.gameInfoGenreLabel.Size = new Size(363, 25);
            gameInfoTabPage.gameInfoGenreLabel.TabIndex = 10066;
            gameInfoTabPage.gameInfoGenreLabel.UseMnemonic = false;
            // 
            // label62
            // 
            label62.BackColor = Color.Transparent;
            label62.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label62.ForeColor = Color.FromArgb(44, 151, 250);
            label62.Location = new Point(4, 8);
            label62.Margin = new Padding(4, 0, 4, 0);
            label62.Name = "label62";
            label62.Size = new Size(141, 25);
            label62.TabIndex = 10070;
            label62.Text = "Genre";
            // 
            // label36
            // 
            label36.BackColor = Color.Transparent;
            label36.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label36.ForeColor = Color.FromArgb(204, 153, 0);
            label36.Location = new Point(202, 5);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(315, 25);
            label36.TabIndex = 10066;
            label36.UseMnemonic = false;
            // 
            // panel117
            // 
            panel117.BackColor = Color.FromArgb(22, 22, 22);
            panel117.Controls.Add(label89);
            panel117.Controls.Add(gameInfoTabPage.gameInfoReleasedLabel);
            panel117.Location = new Point(164, 195);
            panel117.Margin = new Padding(4, 5, 4, 5);
            panel117.Name = "panel117";
            panel117.Size = new Size(522, 38);
            panel117.TabIndex = 10072;
            // 
            // label89
            // 
            label89.BackColor = Color.Transparent;
            label89.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label89.ForeColor = Color.FromArgb(44, 151, 250);
            label89.Location = new Point(4, 8);
            label89.Margin = new Padding(4, 0, 4, 0);
            label89.Name = "label89";
            label89.Size = new Size(141, 25);
            label89.TabIndex = 10070;
            label89.Text = "Released";
            // 
            // gameInfoReleasedLabel
            // 
            gameInfoTabPage.gameInfoReleasedLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoReleasedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoReleasedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoReleasedLabel.Location = new Point(154, 8);
            gameInfoTabPage.gameInfoReleasedLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoReleasedLabel.Name = "gameInfoReleasedLabel";
            gameInfoTabPage.gameInfoReleasedLabel.Size = new Size(363, 25);
            gameInfoTabPage.gameInfoReleasedLabel.TabIndex = 10067;
            gameInfoTabPage.gameInfoReleasedLabel.UseMnemonic = false;
            // 
            // panel118
            // 
            panel118.BackColor = Color.FromArgb(22, 22, 22);
            panel118.Controls.Add(label61);
            panel118.Controls.Add(gameInfoTabPage.gameInfoPublisherLabel);
            panel118.Location = new Point(164, 118);
            panel118.Margin = new Padding(4, 5, 4, 5);
            panel118.Name = "panel118";
            panel118.Size = new Size(522, 38);
            panel118.TabIndex = 10073;
            // 
            // label61
            // 
            label61.BackColor = Color.Transparent;
            label61.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label61.ForeColor = Color.FromArgb(44, 151, 250);
            label61.Location = new Point(4, 9);
            label61.Margin = new Padding(4, 0, 4, 0);
            label61.Name = "label61";
            label61.Size = new Size(141, 25);
            label61.TabIndex = 10069;
            label61.Text = "Publisher";
            // 
            // gameInfoPublisherLabel
            // 
            gameInfoTabPage.gameInfoPublisherLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoPublisherLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoPublisherLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoTabPage.gameInfoPublisherLabel.Location = new Point(154, 9);
            gameInfoTabPage.gameInfoPublisherLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoPublisherLabel.Name = "gameInfoPublisherLabel";
            gameInfoTabPage.gameInfoPublisherLabel.Size = new Size(363, 25);
            gameInfoTabPage.gameInfoPublisherLabel.TabIndex = 10064;
            gameInfoTabPage.gameInfoPublisherLabel.UseMnemonic = false;
            // 
            // panel116
            // 
            panel116.BackColor = Color.FromArgb(32, 32, 32);
            panel116.Controls.Add(label57);
            panel116.Controls.Add(gameInfoTabPage.gameInfoDeveloperLabel);
            panel116.Location = new Point(164, 80);
            panel116.Margin = new Padding(4, 5, 4, 5);
            panel116.Name = "panel116";
            panel116.Size = new Size(522, 38);
            panel116.TabIndex = 10071;
            // 
            // label57
            // 
            label57.BackColor = Color.Transparent;
            label57.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label57.ForeColor = Color.FromArgb(44, 151, 250);
            label57.Location = new Point(4, 5);
            label57.Margin = new Padding(4, 0, 4, 0);
            label57.Name = "label57";
            label57.Size = new Size(141, 25);
            label57.TabIndex = 10070;
            label57.Text = "Developer";
            // 
            // gameInfoDeveloperLabel
            // 
            gameInfoTabPage.gameInfoDeveloperLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoDeveloperLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoDeveloperLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoTabPage.gameInfoDeveloperLabel.Location = new Point(154, 5);
            gameInfoTabPage.gameInfoDeveloperLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoDeveloperLabel.Name = "gameInfoDeveloperLabel";
            gameInfoTabPage.gameInfoDeveloperLabel.Size = new Size(363, 25);
            gameInfoTabPage.gameInfoDeveloperLabel.TabIndex = 10063;
            gameInfoTabPage.gameInfoDeveloperLabel.UseMnemonic = false;
            // 
            // gameInfoTitleLabel
            // 
            gameInfoTabPage.gameInfoTitleLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoTitleLabel.Location = new Point(4, 5);
            gameInfoTabPage.gameInfoTitleLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoTitleLabel.Name = "gameInfoTitleLabel";
            gameInfoTabPage.gameInfoTitleLabel.Size = new Size(688, 58);
            gameInfoTabPage.gameInfoTitleLabel.TabIndex = 10058;
            gameInfoTabPage.gameInfoTitleLabel.Text = "Game Info Title";
            gameInfoTabPage.gameInfoTitleLabel.UseMnemonic = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox8.Location = new Point(3, 68);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(690, 3);
            pictureBox8.TabIndex = 10059;
            pictureBox8.TabStop = false;
            // 
            // panel29
            // 
            panel29.BackColor = Color.FromArgb(32, 32, 32);
            panel29.Controls.Add(panel49);
            panel29.Controls.Add(panel48);
            panel29.Controls.Add(panel30);
            panel29.Controls.Add(label66);
            panel29.Controls.Add(gameInfoTabPage.gameInfoDefaultButton);
            panel29.Controls.Add(pictureBox7);
            panel29.Controls.Add(panel31);
            panel29.Controls.Add(panel32);
            panel29.Controls.Add(panel33);
            panel29.Controls.Add(panel34);
            panel29.Location = new Point(6, 5);
            panel29.Margin = new Padding(4, 5, 4, 5);
            panel29.Name = "panel29";
            panel29.Size = new Size(430, 309);
            panel29.TabIndex = 10080;
            // 
            // panel49
            // 
            panel49.BackColor = Color.FromArgb(32, 32, 32);
            panel49.Controls.Add(label88);
            panel49.Controls.Add(gameInfoTabPage.gameInfoReleasedCheckBox);
            panel49.Controls.Add(gameInfoTabPage.gameInfoReleaseDateTextBox);
            panel49.Location = new Point(3, 265);
            panel49.Margin = new Padding(4, 5, 4, 5);
            panel49.Name = "panel49";
            panel49.Size = new Size(417, 35);
            panel49.TabIndex = 10071;
            // 
            // label88
            // 
            label88.BackColor = Color.Transparent;
            label88.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label88.ForeColor = Color.FromArgb(44, 151, 250);
            label88.Location = new Point(4, 6);
            label88.Margin = new Padding(4, 0, 4, 0);
            label88.Name = "label88";
            label88.Size = new Size(141, 25);
            label88.TabIndex = 10069;
            label88.Text = "Released";
            // 
            // gameInfoReleasedCheckBox
            // 
            gameInfoTabPage.gameInfoReleasedCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoReleasedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoReleasedCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoReleasedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoReleasedCheckBox.Name = "gameInfoReleasedCheckBox";
            gameInfoTabPage.gameInfoReleasedCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoReleasedCheckBox.TabIndex = 55;
            gameInfoTabPage.gameInfoReleasedCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoReleasedCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoReleaseDateTextBox
            // 
            gameInfoTabPage.gameInfoReleaseDateTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoReleaseDateTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoReleaseDateTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoReleaseDateTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoReleaseDateTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoReleaseDateTextBox.Name = "gameInfoReleaseDateTextBox";
            gameInfoTabPage.gameInfoReleaseDateTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoReleaseDateTextBox.TabIndex = 5;
            gameInfoTabPage.gameInfoReleaseDateTextBox.Text = "Released";
            gameInfoTabPage.gameInfoReleaseDateTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel48
            // 
            panel48.BackColor = Color.FromArgb(22, 22, 22);
            panel48.Controls.Add(label87);
            panel48.Controls.Add(gameInfoTabPage.gameInfoGenreCheckBox);
            panel48.Controls.Add(gameInfoTabPage.gameInfoGenreTextBox);
            panel48.Location = new Point(3, 231);
            panel48.Margin = new Padding(4, 5, 4, 5);
            panel48.Name = "panel48";
            panel48.Size = new Size(417, 35);
            panel48.TabIndex = 10070;
            // 
            // label87
            // 
            label87.BackColor = Color.Transparent;
            label87.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label87.ForeColor = Color.FromArgb(44, 151, 250);
            label87.Location = new Point(4, 6);
            label87.Margin = new Padding(4, 0, 4, 0);
            label87.Name = "label87";
            label87.Size = new Size(141, 25);
            label87.TabIndex = 10069;
            label87.Text = "Genre";
            // 
            // gameInfoGenreCheckBox
            // 
            gameInfoTabPage.gameInfoGenreCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoGenreCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoGenreCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoGenreCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoGenreCheckBox.Name = "gameInfoGenreCheckBox";
            gameInfoTabPage.gameInfoGenreCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoGenreCheckBox.TabIndex = 55;
            gameInfoTabPage.gameInfoGenreCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoGenreCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoGenreTextBox
            // 
            gameInfoTabPage.gameInfoGenreTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoGenreTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoGenreTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoGenreTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoGenreTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoGenreTextBox.Name = "gameInfoGenreTextBox";
            gameInfoTabPage.gameInfoGenreTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoGenreTextBox.TabIndex = 5;
            gameInfoTabPage.gameInfoGenreTextBox.Text = "Genre";
            gameInfoTabPage.gameInfoGenreTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel30
            // 
            panel30.BackColor = Color.FromArgb(32, 32, 32);
            panel30.Controls.Add(label63);
            panel30.Controls.Add(label64);
            panel30.Controls.Add(label65);
            panel30.Location = new Point(3, 62);
            panel30.Margin = new Padding(4, 5, 4, 5);
            panel30.Name = "panel30";
            panel30.Size = new Size(417, 35);
            panel30.TabIndex = 10079;
            // 
            // label63
            // 
            label63.BackColor = Color.Transparent;
            label63.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label63.ForeColor = Color.FromArgb(200, 200, 200);
            label63.Location = new Point(4, 5);
            label63.Margin = new Padding(4, 0, 4, 0);
            label63.Name = "label63";
            label63.Size = new Size(75, 25);
            label63.TabIndex = 10071;
            label63.Text = "Field";
            // 
            // label64
            // 
            label64.BackColor = Color.Transparent;
            label64.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label64.ForeColor = Color.FromArgb(200, 200, 200);
            label64.Location = new Point(170, 5);
            label64.Margin = new Padding(4, 0, 4, 0);
            label64.Name = "label64";
            label64.Size = new Size(153, 25);
            label64.TabIndex = 10073;
            label64.Text = "Display Text";
            // 
            // label65
            // 
            label65.BackColor = Color.Transparent;
            label65.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label65.ForeColor = Color.FromArgb(200, 200, 200);
            label65.Location = new Point(332, 5);
            label65.Margin = new Padding(4, 0, 4, 0);
            label65.Name = "label65";
            label65.Size = new Size(92, 25);
            label65.TabIndex = 10072;
            label65.Text = "Enabled";
            // 
            // label66
            // 
            label66.BackColor = Color.Transparent;
            label66.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label66.ForeColor = Color.FromArgb(44, 151, 250);
            label66.Location = new Point(4, 5);
            label66.Margin = new Padding(4, 0, 4, 0);
            label66.Name = "label66";
            label66.Size = new Size(285, 40);
            label66.TabIndex = 10069;
            label66.Text = "Field Overrides";
            // 
            // gameInfoDefaultButton
            // 
            gameInfoTabPage.gameInfoDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            gameInfoTabPage.gameInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            gameInfoTabPage.gameInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            gameInfoTabPage.gameInfoDefaultButton.Location = new Point(306, 3);
            gameInfoTabPage.gameInfoDefaultButton.Margin = new Padding(0);
            gameInfoTabPage.gameInfoDefaultButton.Name = "gameInfoDefaultButton";
            gameInfoTabPage.gameInfoDefaultButton.Size = new Size(112, 42);
            gameInfoTabPage.gameInfoDefaultButton.TabIndex = 39;
            gameInfoTabPage.gameInfoDefaultButton.Text = "Default";
            gameInfoTabPage.gameInfoDefaultButton.UseVisualStyleBackColor = false;
            gameInfoTabPage.gameInfoDefaultButton.Click += new System.EventHandler(DefaultButton_Click);
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox7.Location = new Point(3, 49);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(412, 3);
            pictureBox7.TabIndex = 10070;
            pictureBox7.TabStop = false;
            // 
            // panel31
            // 
            panel31.BackColor = Color.FromArgb(22, 22, 22);
            panel31.Controls.Add(label67);
            panel31.Controls.Add(gameInfoTabPage.gameInfoTitleCheckBox);
            panel31.Controls.Add(gameInfoTabPage.gameInfoTitleTextBox);
            panel31.Location = new Point(3, 95);
            panel31.Margin = new Padding(4, 5, 4, 5);
            panel31.Name = "panel31";
            panel31.Size = new Size(417, 35);
            panel31.TabIndex = 10061;
            // 
            // label67
            // 
            label67.BackColor = Color.Transparent;
            label67.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label67.ForeColor = Color.FromArgb(44, 151, 250);
            label67.Location = new Point(4, 5);
            label67.Margin = new Padding(4, 0, 4, 0);
            label67.Name = "label67";
            label67.Size = new Size(141, 25);
            label67.TabIndex = 10066;
            label67.Text = "Title";
            // 
            // gameInfoTitleCheckBox
            // 
            gameInfoTabPage.gameInfoTitleCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoTitleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoTitleCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoTitleCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoTitleCheckBox.Name = "gameInfoTitleCheckBox";
            gameInfoTabPage.gameInfoTitleCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoTitleCheckBox.TabIndex = 52;
            gameInfoTabPage.gameInfoTitleCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoTitleCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoTitleTextBox
            // 
            gameInfoTabPage.gameInfoTitleTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoTitleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoTitleTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoTitleTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoTitleTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoTitleTextBox.Name = "gameInfoTitleTextBox";
            gameInfoTabPage.gameInfoTitleTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoTitleTextBox.TabIndex = 1;
            gameInfoTabPage.gameInfoTitleTextBox.Text = "Title";
            gameInfoTabPage.gameInfoTitleTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel32
            // 
            panel32.BackColor = Color.FromArgb(32, 32, 32);
            panel32.Controls.Add(label68);
            panel32.Controls.Add(gameInfoTabPage.gameInfoConsoleCheckBox);
            panel32.Controls.Add(gameInfoTabPage.gameInfoConsoleTextBox);
            panel32.Location = new Point(3, 197);
            panel32.Margin = new Padding(4, 5, 4, 5);
            panel32.Name = "panel32";
            panel32.Size = new Size(417, 35);
            panel32.TabIndex = 10061;
            // 
            // label68
            // 
            label68.BackColor = Color.Transparent;
            label68.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label68.ForeColor = Color.FromArgb(44, 151, 250);
            label68.Location = new Point(4, 6);
            label68.Margin = new Padding(4, 0, 4, 0);
            label68.Name = "label68";
            label68.Size = new Size(141, 25);
            label68.TabIndex = 10069;
            label68.Text = "Console";
            // 
            // gameInfoConsoleCheckBox
            // 
            gameInfoTabPage.gameInfoConsoleCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoConsoleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoConsoleCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoConsoleCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoConsoleCheckBox.Name = "gameInfoConsoleCheckBox";
            gameInfoTabPage.gameInfoConsoleCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoConsoleCheckBox.TabIndex = 55;
            gameInfoTabPage.gameInfoConsoleCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoConsoleCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoConsoleTextBox
            // 
            gameInfoTabPage.gameInfoConsoleTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoConsoleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoConsoleTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoConsoleTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoConsoleTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoConsoleTextBox.Name = "gameInfoConsoleTextBox";
            gameInfoTabPage.gameInfoConsoleTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoConsoleTextBox.TabIndex = 5;
            gameInfoTabPage.gameInfoConsoleTextBox.Text = "Console";
            gameInfoTabPage.gameInfoConsoleTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel33
            // 
            panel33.BackColor = Color.FromArgb(22, 22, 22);
            panel33.Controls.Add(label69);
            panel33.Controls.Add(gameInfoTabPage.gameInfoPublisherTextBox);
            panel33.Controls.Add(gameInfoTabPage.gameInfoPublisherCheckBox);
            panel33.Location = new Point(3, 163);
            panel33.Margin = new Padding(4, 5, 4, 5);
            panel33.Name = "panel33";
            panel33.Size = new Size(417, 35);
            panel33.TabIndex = 10061;
            // 
            // label69
            // 
            label69.BackColor = Color.Transparent;
            label69.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label69.ForeColor = Color.FromArgb(44, 151, 250);
            label69.Location = new Point(4, 6);
            label69.Margin = new Padding(4, 0, 4, 0);
            label69.Name = "label69";
            label69.Size = new Size(141, 25);
            label69.TabIndex = 10068;
            label69.Text = "Publisher";
            // 
            // gameInfoPublisherTextBox
            // 
            gameInfoTabPage.gameInfoPublisherTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoPublisherTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoPublisherTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoPublisherTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoPublisherTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoPublisherTextBox.Name = "gameInfoPublisherTextBox";
            gameInfoTabPage.gameInfoPublisherTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoPublisherTextBox.TabIndex = 7;
            gameInfoTabPage.gameInfoPublisherTextBox.Text = "Publisher";
            gameInfoTabPage.gameInfoPublisherTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // gameInfoPublisherCheckBox
            // 
            gameInfoTabPage.gameInfoPublisherCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoPublisherCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoPublisherCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoPublisherCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoPublisherCheckBox.Name = "gameInfoPublisherCheckBox";
            gameInfoTabPage.gameInfoPublisherCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoPublisherCheckBox.TabIndex = 56;
            gameInfoTabPage.gameInfoPublisherCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoPublisherCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel34
            // 
            panel34.BackColor = Color.FromArgb(32, 32, 32);
            panel34.Controls.Add(label70);
            panel34.Controls.Add(gameInfoTabPage.gameInfoDeveloperTextBox);
            panel34.Controls.Add(gameInfoTabPage.gameInfoDeveloperCheckBox);
            panel34.Location = new Point(3, 129);
            panel34.Margin = new Padding(4, 5, 4, 5);
            panel34.Name = "panel34";
            panel34.Size = new Size(417, 35);
            panel34.TabIndex = 10061;
            // 
            // label70
            // 
            label70.BackColor = Color.Transparent;
            label70.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label70.ForeColor = Color.FromArgb(44, 151, 250);
            label70.Location = new Point(4, 6);
            label70.Margin = new Padding(4, 0, 4, 0);
            label70.Name = "label70";
            label70.Size = new Size(141, 25);
            label70.TabIndex = 10067;
            label70.Text = "Developer";
            // 
            // gameInfoDeveloperTextBox
            // 
            gameInfoTabPage.gameInfoDeveloperTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoDeveloperTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoDeveloperTextBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoDeveloperTextBox.Location = new Point(174, 0);
            gameInfoTabPage.gameInfoDeveloperTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoDeveloperTextBox.Name = "gameInfoDeveloperTextBox";
            gameInfoTabPage.gameInfoDeveloperTextBox.Size = new Size(146, 31);
            gameInfoTabPage.gameInfoDeveloperTextBox.TabIndex = 6;
            gameInfoTabPage.gameInfoDeveloperTextBox.Text = "Developer";
            gameInfoTabPage.gameInfoDeveloperTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // gameInfoDeveloperCheckBox
            // 
            gameInfoTabPage.gameInfoDeveloperCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoDeveloperCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoDeveloperCheckBox.Location = new Point(338, 8);
            gameInfoTabPage.gameInfoDeveloperCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoDeveloperCheckBox.Name = "gameInfoDeveloperCheckBox";
            gameInfoTabPage.gameInfoDeveloperCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoDeveloperCheckBox.TabIndex = 54;
            gameInfoTabPage.gameInfoDeveloperCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoDeveloperCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel35
            // 
            panel35.BackColor = Color.FromArgb(32, 32, 32);
            panel35.Controls.Add(label71);
            panel35.Controls.Add(panel42);
            panel35.Controls.Add(gameInfoTabPage.gameInfoOpenWindowButton);
            panel35.Controls.Add(gameInfoTabPage.gameInfoValuesPanel);
            panel35.Controls.Add(gameInfoTabPage.gameInfoAutoOpenWindowCheckbox);
            panel35.Controls.Add(pictureBox9);
            panel35.Controls.Add(panel44);
            panel35.Controls.Add(panel45);
            panel35.Controls.Add(panel46);
            panel35.Controls.Add(gameInfoTabPage.gameInfoValuesOutlinePanel);
            panel35.Location = new Point(444, 5);
            panel35.Margin = new Padding(4, 5, 4, 5);
            panel35.Name = "panel35";
            panel35.Size = new Size(702, 271);
            panel35.TabIndex = 10079;
            // 
            // label71
            // 
            label71.BackColor = Color.Transparent;
            label71.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label71.ForeColor = Color.FromArgb(44, 151, 250);
            label71.Location = new Point(4, 5);
            label71.Margin = new Padding(4, 0, 4, 0);
            label71.Name = "label71";
            label71.Size = new Size(364, 40);
            label71.TabIndex = 10062;
            label71.Text = "Window/Font Settings";
            // 
            // panel42
            // 
            panel42.BackColor = Color.FromArgb(32, 32, 32);
            panel42.Controls.Add(gameInfoTabPage.gameInfoAdvancedCheckBox);
            panel42.Controls.Add(label78);
            panel42.Controls.Add(label79);
            panel42.Controls.Add(label80);
            panel42.Controls.Add(label81);
            panel42.Location = new Point(3, 62);
            panel42.Margin = new Padding(4, 5, 4, 5);
            panel42.Name = "panel42";
            panel42.Size = new Size(694, 35);
            panel42.TabIndex = 10076;
            // 
            // gameInfoAdvancedCheckBox
            // 
            gameInfoTabPage.gameInfoAdvancedCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoAdvancedCheckBox.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoTabPage.gameInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoAdvancedCheckBox.Location = new Point(8, 3);
            gameInfoTabPage.gameInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoAdvancedCheckBox.Name = "gameInfoAdvancedCheckBox";
            gameInfoTabPage.gameInfoAdvancedCheckBox.Size = new Size(135, 29);
            gameInfoTabPage.gameInfoAdvancedCheckBox.TabIndex = 10053;
            gameInfoTabPage.gameInfoAdvancedCheckBox.Text = "Advanced";
            gameInfoTabPage.gameInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            gameInfoTabPage.gameInfoAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label78
            // 
            label78.BackColor = Color.Transparent;
            label78.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label78.ForeColor = Color.FromArgb(200, 200, 200);
            label78.Location = new Point(225, 5);
            label78.Margin = new Padding(4, 0, 4, 0);
            label78.Name = "label78";
            label78.Size = new Size(72, 25);
            label78.TabIndex = 10065;
            label78.Text = "Color";
            // 
            // label79
            // 
            label79.BackColor = Color.Transparent;
            label79.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label79.ForeColor = Color.FromArgb(200, 200, 200);
            label79.Location = new Point(291, 5);
            label79.Margin = new Padding(4, 0, 4, 0);
            label79.Name = "label79";
            label79.Size = new Size(75, 25);
            label79.TabIndex = 10066;
            label79.Text = "Font";
            // 
            // label80
            // 
            label80.BackColor = Color.Transparent;
            label80.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label80.ForeColor = Color.FromArgb(200, 200, 200);
            label80.Location = new Point(524, 5);
            label80.Margin = new Padding(4, 0, 4, 0);
            label80.Name = "label80";
            label80.Size = new Size(62, 25);
            label80.TabIndex = 10068;
            label80.Text = "Size";
            // 
            // label81
            // 
            label81.BackColor = Color.Transparent;
            label81.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label81.ForeColor = Color.FromArgb(200, 200, 200);
            label81.Location = new Point(594, 5);
            label81.Margin = new Padding(4, 0, 4, 0);
            label81.Name = "label81";
            label81.Size = new Size(88, 25);
            label81.TabIndex = 10067;
            label81.Text = "Enabled";
            // 
            // gameInfoOpenWindowButton
            // 
            gameInfoTabPage.gameInfoOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            gameInfoTabPage.gameInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            gameInfoTabPage.gameInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoTabPage.gameInfoOpenWindowButton.Location = new Point(573, 3);
            gameInfoTabPage.gameInfoOpenWindowButton.Margin = new Padding(0);
            gameInfoTabPage.gameInfoOpenWindowButton.Name = "gameInfoOpenWindowButton";
            gameInfoTabPage.gameInfoOpenWindowButton.Size = new Size(112, 42);
            gameInfoTabPage.gameInfoOpenWindowButton.TabIndex = 10021;
            gameInfoTabPage.gameInfoOpenWindowButton.Text = "Open";
            gameInfoTabPage.gameInfoOpenWindowButton.UseVisualStyleBackColor = false;
            gameInfoTabPage.gameInfoOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // gameInfoValuesPanel
            // 
            gameInfoTabPage.gameInfoValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(label82);
            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontColorPictureBox);
            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontComboBox);
            gameInfoTabPage.gameInfoValuesPanel.Location = new Point(3, 163);
            gameInfoTabPage.gameInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesPanel.Name = "gameInfoValuesPanel";
            gameInfoTabPage.gameInfoValuesPanel.Size = new Size(694, 35);
            gameInfoTabPage.gameInfoValuesPanel.TabIndex = 10061;
            // 
            // label82
            // 
            label82.BackColor = Color.Transparent;
            label82.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label82.ForeColor = Color.FromArgb(44, 151, 250);
            label82.Location = new Point(4, 6);
            label82.Margin = new Padding(4, 0, 4, 0);
            label82.Name = "label82";
            label82.Size = new Size(216, 25);
            label82.TabIndex = 10066;
            label82.Text = "Values";
            // 
            // gameInfoValuesFontColorPictureBox
            // 
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.BackColor = Color.White;
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Name = "gameInfoValuesFontColorPictureBox";
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.TabIndex = 45;
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameInfoValuesFontComboBox
            // 
            gameInfoTabPage.gameInfoValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoValuesFontComboBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoValuesFontComboBox.FormattingEnabled = true;
            gameInfoTabPage.gameInfoValuesFontComboBox.Location = new Point(290, 3);
            gameInfoTabPage.gameInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesFontComboBox.Name = "gameInfoValuesFontComboBox";
            gameInfoTabPage.gameInfoValuesFontComboBox.Size = new Size(301, 28);
            gameInfoTabPage.gameInfoValuesFontComboBox.TabIndex = 45;
            gameInfoTabPage.gameInfoValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // gameInfoAutoOpenWindowCheckbox
            // 
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.AutoSize = true;
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Name = "gameInfoAutoOpenWindowCheckbox";
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox9.Location = new Point(3, 49);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(690, 3);
            pictureBox9.TabIndex = 10063;
            pictureBox9.TabStop = false;
            // 
            // panel44
            // 
            panel44.BackColor = Color.FromArgb(22, 22, 22);
            panel44.Controls.Add(gameInfoTabPage.gameInfoBackgroundColorPictureBox);
            panel44.Controls.Add(label83);
            panel44.Location = new Point(3, 95);
            panel44.Margin = new Padding(4, 5, 4, 5);
            panel44.Name = "panel44";
            panel44.Size = new Size(694, 35);
            panel44.TabIndex = 10061;
            // 
            // gameInfoBackgroundColorPictureBox
            // 
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.BackColor = Color.White;
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Name = "gameInfoBackgroundColorPictureBox";
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.TabIndex = 42;
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label83
            // 
            label83.BackColor = Color.Transparent;
            label83.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label83.ForeColor = Color.FromArgb(44, 151, 250);
            label83.Location = new Point(4, 5);
            label83.Margin = new Padding(4, 0, 4, 0);
            label83.Name = "label83";
            label83.Size = new Size(216, 25);
            label83.TabIndex = 10064;
            label83.Text = "Window Background";
            // 
            // panel45
            // 
            panel45.BackColor = Color.FromArgb(32, 32, 32);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesLabel);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesFontColorPictureBox);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesFontComboBox);
            panel45.Location = new Point(3, 129);
            panel45.Margin = new Padding(4, 5, 4, 5);
            panel45.Name = "panel45";
            panel45.Size = new Size(694, 35);
            panel45.TabIndex = 10061;
            // 
            // gameInfoNamesLabel
            // 
            gameInfoTabPage.gameInfoNamesLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoNamesLabel.Location = new Point(4, 6);
            gameInfoTabPage.gameInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoNamesLabel.Name = "gameInfoNamesLabel";
            gameInfoTabPage.gameInfoNamesLabel.Size = new Size(216, 25);
            gameInfoTabPage.gameInfoNamesLabel.TabIndex = 10065;
            gameInfoTabPage.gameInfoNamesLabel.Text = "Names";
            // 
            // gameInfoNamesFontColorPictureBox
            // 
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.BackColor = Color.White;
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Name = "gameInfoNamesFontColorPictureBox";
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.TabIndex = 45;
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameInfoNamesFontComboBox
            // 
            gameInfoTabPage.gameInfoNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoNamesFontComboBox.ForeColor = Color.White;
            gameInfoTabPage.gameInfoNamesFontComboBox.FormattingEnabled = true;
            gameInfoTabPage.gameInfoNamesFontComboBox.Location = new Point(290, 3);
            gameInfoTabPage.gameInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoNamesFontComboBox.Name = "gameInfoNamesFontComboBox";
            gameInfoTabPage.gameInfoNamesFontComboBox.Size = new Size(301, 28);
            gameInfoTabPage.gameInfoNamesFontComboBox.TabIndex = 45;
            gameInfoTabPage.gameInfoNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel46
            // 
            panel46.BackColor = Color.FromArgb(32, 32, 32);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesOutlineCheckBox);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesOutlineLabel);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox);
            panel46.Location = new Point(3, 197);
            panel46.Margin = new Padding(4, 5, 4, 5);
            panel46.Name = "panel46";
            panel46.Size = new Size(694, 35);
            panel46.TabIndex = 10061;
            // 
            // gameInfoNamesFontOutlineNumericUpDown
            // 
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Name = "gameInfoNamesFontOutlineNumericUpDown";
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // gameInfoNamesOutlineCheckBox
            // 
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Name = "gameInfoNamesOutlineCheckBox";
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.TabIndex = 45;
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoNamesOutlineLabel
            // 
            gameInfoTabPage.gameInfoNamesOutlineLabel.BackColor = Color.Transparent;
            gameInfoTabPage.gameInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoNamesOutlineLabel.Location = new Point(4, 5);
            gameInfoTabPage.gameInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTabPage.gameInfoNamesOutlineLabel.Name = "gameInfoNamesOutlineLabel";
            gameInfoTabPage.gameInfoNamesOutlineLabel.Size = new Size(216, 25);
            gameInfoTabPage.gameInfoNamesOutlineLabel.TabIndex = 10066;
            gameInfoTabPage.gameInfoNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // gameInfoNamesFontOutlineColorPictureBox
            // 
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Name = "gameInfoNamesFontOutlineColorPictureBox";
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameInfoValuesOutlinePanel
            // 
            gameInfoTabPage.gameInfoValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(label86);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesOutlineCheckBox);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Location = new Point(3, 231);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Name = "gameInfoValuesOutlinePanel";
            gameInfoTabPage.gameInfoValuesOutlinePanel.Size = new Size(694, 35);
            gameInfoTabPage.gameInfoValuesOutlinePanel.TabIndex = 10067;
            // 
            // label86
            // 
            label86.BackColor = Color.Transparent;
            label86.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label86.ForeColor = Color.FromArgb(44, 151, 250);
            label86.Location = new Point(4, 6);
            label86.Margin = new Padding(4, 0, 4, 0);
            label86.Name = "label86";
            label86.Size = new Size(216, 25);
            label86.TabIndex = 10066;
            label86.Text = "Values OutlineColor";
            // 
            // gameInfoValuesFontOutlineColorPictureBox
            // 
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Name = "gameInfoValuesFontOutlineColorPictureBox";
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.TabStop = false;
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameInfoValuesFontOutlineNumericUpDown
            // 
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Name = "gameInfoValuesFontOutlineNumericUpDown";
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // gameInfoValuesOutlineCheckBox
            // 
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.AutoSize = true;
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Name = "gameInfoValuesOutlineCheckBox";
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.Size = new Size(22, 21);
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.TabIndex = 45;
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel28
            // 
            panel28.BackColor = Color.FromArgb(32, 32, 32);
            panel28.Controls.Add(gameProgressTabPage.gameProgressPointsTextLabel);
            panel28.Controls.Add(gameProgressTabPage.gameProgressHardcoreWorthLabel);
            panel28.Controls.Add(gameProgressTabPage.gameProgressPoints2Label);
            panel28.Controls.Add(gameProgressTabPage.gameProgressTruePoints2Label);
            panel28.Controls.Add(gameProgressTabPage.gameProgressAchievements2Label);
            panel28.Controls.Add(gameProgressTabPage.gameProgressHaveEarnedLabel);
            panel28.Controls.Add(gameProgressTabPage.gameProgressPercentCompletePictureBox);
            panel28.Controls.Add(gameProgressTabPage.gameProgressMasteryPictureBox);
            panel28.Controls.Add(pictureBox21);
            panel28.Controls.Add(label60);
            panel28.Controls.Add(label59);
            panel28.Controls.Add(label58);
            panel28.Controls.Add(label56);
            panel28.Controls.Add(pictureBox5);
            panel28.Controls.Add(gameProgressTabPage.gameProgressAchievements1Label);
            panel28.Controls.Add(gameProgressTabPage.gameProgressPoints1Label);
            panel28.Controls.Add(gameProgressTabPage.gameProgressCompletedLabel);
            panel28.Controls.Add(gameProgressTabPage.gameProgressTruePoints1Label);
            panel28.Location = new Point(444, 283);
            panel28.Margin = new Padding(4, 5, 4, 5);
            panel28.Name = "panel28";
            panel28.Size = new Size(702, 278);
            panel28.TabIndex = 10082;
            // 
            // gameProgressPointsTextLabel
            // 
            gameProgressTabPage.gameProgressPointsTextLabel.AutoSize = true;
            gameProgressTabPage.gameProgressPointsTextLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressPointsTextLabel.Font = new Font("Verdana", 9.75F);
            gameProgressTabPage.gameProgressPointsTextLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressPointsTextLabel.Location = new Point(178, 126);
            gameProgressTabPage.gameProgressPointsTextLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressPointsTextLabel.Name = "gameProgressPointsTextLabel";
            gameProgressTabPage.gameProgressPointsTextLabel.Size = new Size(80, 25);
            gameProgressTabPage.gameProgressPointsTextLabel.TabIndex = 10074;
            gameProgressTabPage.gameProgressPointsTextLabel.Text = "points.";
            // 
            // gameProgressHardcoreWorthLabel
            // 
            gameProgressTabPage.gameProgressHardcoreWorthLabel.AutoSize = true;
            gameProgressTabPage.gameProgressHardcoreWorthLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Font = new Font("Verdana", 9.75F);
            gameProgressTabPage.gameProgressHardcoreWorthLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Location = new Point(231, 95);
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Name = "gameProgressHardcoreWorthLabel";
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Size = new Size(345, 25);
            gameProgressTabPage.gameProgressHardcoreWorthLabel.TabIndex = 10073;
            gameProgressTabPage.gameProgressHardcoreWorthLabel.Text = "HARDCORE achievements, worth";
            // 
            // gameProgressPoints2Label
            // 
            gameProgressTabPage.gameProgressPoints2Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressPoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressPoints2Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressPoints2Label.Location = new Point(8, 126);
            gameProgressTabPage.gameProgressPoints2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressPoints2Label.Name = "gameProgressPoints2Label";
            gameProgressTabPage.gameProgressPoints2Label.Size = new Size(82, 25);
            gameProgressTabPage.gameProgressPoints2Label.TabIndex = 10071;
            gameProgressTabPage.gameProgressPoints2Label.Text = "99999";
            gameProgressTabPage.gameProgressPoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressTruePoints2Label
            // 
            gameProgressTabPage.gameProgressTruePoints2Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressTruePoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressTruePoints2Label.ForeColor = Color.White;
            gameProgressTabPage.gameProgressTruePoints2Label.Location = new Point(81, 126);
            gameProgressTabPage.gameProgressTruePoints2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressTruePoints2Label.Name = "gameProgressTruePoints2Label";
            gameProgressTabPage.gameProgressTruePoints2Label.Size = new Size(108, 25);
            gameProgressTabPage.gameProgressTruePoints2Label.TabIndex = 10072;
            gameProgressTabPage.gameProgressTruePoints2Label.Text = "(999999)";
            gameProgressTabPage.gameProgressTruePoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressAchievements2Label
            // 
            gameProgressTabPage.gameProgressAchievements2Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressAchievements2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAchievements2Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressAchievements2Label.Location = new Point(180, 95);
            gameProgressTabPage.gameProgressAchievements2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressAchievements2Label.Name = "gameProgressAchievements2Label";
            gameProgressTabPage.gameProgressAchievements2Label.Size = new Size(52, 25);
            gameProgressTabPage.gameProgressAchievements2Label.TabIndex = 10070;
            gameProgressTabPage.gameProgressAchievements2Label.Text = "999";
            gameProgressTabPage.gameProgressAchievements2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressHaveEarnedLabel
            // 
            gameProgressTabPage.gameProgressHaveEarnedLabel.AutoSize = true;
            gameProgressTabPage.gameProgressHaveEarnedLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressHaveEarnedLabel.Font = new Font("Verdana", 9.75F);
            gameProgressTabPage.gameProgressHaveEarnedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressHaveEarnedLabel.Location = new Point(8, 95);
            gameProgressTabPage.gameProgressHaveEarnedLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressHaveEarnedLabel.Name = "gameProgressHaveEarnedLabel";
            gameProgressTabPage.gameProgressHaveEarnedLabel.Size = new Size(181, 25);
            gameProgressTabPage.gameProgressHaveEarnedLabel.TabIndex = 10069;
            gameProgressTabPage.gameProgressHaveEarnedLabel.Text = "You have earned";
            // 
            // gameProgressPercentCompletePictureBox
            // 
            gameProgressTabPage.gameProgressPercentCompletePictureBox.BackColor = Color.FromArgb(204, 153, 0);
            gameProgressTabPage.gameProgressPercentCompletePictureBox.Location = new Point(381, 220);
            gameProgressTabPage.gameProgressPercentCompletePictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressPercentCompletePictureBox.Name = "gameProgressPercentCompletePictureBox";
            gameProgressTabPage.gameProgressPercentCompletePictureBox.Size = new Size(273, 5);
            gameProgressTabPage.gameProgressPercentCompletePictureBox.TabIndex = 10066;
            gameProgressTabPage.gameProgressPercentCompletePictureBox.TabStop = false;
            // 
            // gameProgressMasteryPictureBox
            // 
            gameProgressTabPage.gameProgressMasteryPictureBox.Image = global::Retro_Achievement_Tracker.Properties.Resources.mastered_icon;
            gameProgressTabPage.gameProgressMasteryPictureBox.Location = new Point(656, 208);
            gameProgressTabPage.gameProgressMasteryPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressMasteryPictureBox.Name = "gameProgressMasteryPictureBox";
            gameProgressTabPage.gameProgressMasteryPictureBox.Size = new Size(30, 31);
            gameProgressTabPage.gameProgressMasteryPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameProgressTabPage.gameProgressMasteryPictureBox.TabIndex = 10068;
            gameProgressTabPage.gameProgressMasteryPictureBox.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.Transparent;
            pictureBox21.Image = global::Retro_Achievement_Tracker.Properties.Resources.progression_meter;
            pictureBox21.Location = new Point(375, 200);
            pictureBox21.Margin = new Padding(4, 5, 4, 5);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(316, 46);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 10067;
            pictureBox21.TabStop = false;
            // 
            // label60
            // 
            label60.BackColor = Color.Transparent;
            label60.Font = new Font("Verdana", 9.75F);
            label60.ForeColor = Color.FromArgb(44, 151, 250);
            label60.Location = new Point(550, 63);
            label60.Margin = new Padding(4, 0, 4, 0);
            label60.Name = "label60";
            label60.Size = new Size(81, 25);
            label60.TabIndex = 10065;
            label60.Text = "points.";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BackColor = Color.Transparent;
            label59.Font = new Font("Verdana", 9.75F);
            label59.ForeColor = Color.FromArgb(44, 151, 250);
            label59.Location = new Point(160, 63);
            label59.Margin = new Padding(4, 0, 4, 0);
            label59.Name = "label59";
            label59.Size = new Size(216, 25);
            label59.TabIndex = 10064;
            label59.Text = "achievements worth";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.BackColor = Color.Transparent;
            label58.Font = new Font("Verdana", 9.75F);
            label58.ForeColor = Color.FromArgb(44, 151, 250);
            label58.Location = new Point(4, 63);
            label58.Margin = new Padding(4, 0, 4, 0);
            label58.Name = "label58";
            label58.Size = new Size(110, 25);
            label58.TabIndex = 10063;
            label58.Text = "There are";
            // 
            // label56
            // 
            label56.BackColor = Color.Transparent;
            label56.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label56.ForeColor = Color.FromArgb(44, 151, 250);
            label56.Location = new Point(4, 5);
            label56.Margin = new Padding(4, 0, 4, 0);
            label56.Name = "label56";
            label56.Size = new Size(288, 40);
            label56.TabIndex = 10058;
            label56.Text = "Achievements";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox5.Location = new Point(3, 49);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(690, 3);
            pictureBox5.TabIndex = 10059;
            pictureBox5.TabStop = false;
            // 
            // gameProgressAchievements1Label
            // 
            gameProgressTabPage.gameProgressAchievements1Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressAchievements1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAchievements1Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressAchievements1Label.Location = new Point(111, 63);
            gameProgressTabPage.gameProgressAchievements1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressAchievements1Label.Name = "gameProgressAchievements1Label";
            gameProgressTabPage.gameProgressAchievements1Label.Size = new Size(52, 25);
            gameProgressTabPage.gameProgressAchievements1Label.TabIndex = 10058;
            gameProgressTabPage.gameProgressAchievements1Label.Text = "999";
            gameProgressTabPage.gameProgressAchievements1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressPoints1Label
            // 
            gameProgressTabPage.gameProgressPoints1Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressPoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressPoints1Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressPoints1Label.Location = new Point(374, 63);
            gameProgressTabPage.gameProgressPoints1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressPoints1Label.Name = "gameProgressPoints1Label";
            gameProgressTabPage.gameProgressPoints1Label.Size = new Size(82, 25);
            gameProgressTabPage.gameProgressPoints1Label.TabIndex = 10059;
            gameProgressTabPage.gameProgressPoints1Label.Text = "99999";
            gameProgressTabPage.gameProgressPoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressCompletedLabel
            // 
            gameProgressTabPage.gameProgressCompletedLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressCompletedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressCompletedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressCompletedLabel.Location = new Point(448, 245);
            gameProgressTabPage.gameProgressCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressCompletedLabel.Name = "gameProgressCompletedLabel";
            gameProgressTabPage.gameProgressCompletedLabel.Size = new Size(168, 25);
            gameProgressTabPage.gameProgressCompletedLabel.TabIndex = 10061;
            gameProgressTabPage.gameProgressCompletedLabel.Text = "0% Complete";
            // 
            // gameProgressTruePoints1Label
            // 
            gameProgressTabPage.gameProgressTruePoints1Label.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressTruePoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressTruePoints1Label.ForeColor = Color.White;
            gameProgressTabPage.gameProgressTruePoints1Label.Location = new Point(448, 63);
            gameProgressTabPage.gameProgressTruePoints1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressTruePoints1Label.Name = "gameProgressTruePoints1Label";
            gameProgressTabPage.gameProgressTruePoints1Label.Size = new Size(114, 25);
            gameProgressTabPage.gameProgressTruePoints1Label.TabIndex = 10060;
            gameProgressTabPage.gameProgressTruePoints1Label.Text = "(999999)";
            gameProgressTabPage.gameProgressTruePoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(32, 32, 32);
            panel15.Controls.Add(label38);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(gameProgressTabPage.gameProgressOpenWindowButton);
            panel15.Controls.Add(gameProgressTabPage.gameProgressValuesPanel);
            panel15.Controls.Add(gameProgressTabPage.gameProgressAutoOpenWindowCheckbox);
            panel15.Controls.Add(pictureBox6);
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(panel19);
            panel15.Controls.Add(panel23);
            panel15.Controls.Add(gameProgressTabPage.gameProgressValuesOutlinePanel);
            panel15.Location = new Point(444, 5);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(702, 271);
            panel15.TabIndex = 10081;
            // 
            // label38
            // 
            label38.BackColor = Color.Transparent;
            label38.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label38.ForeColor = Color.FromArgb(44, 151, 250);
            label38.Location = new Point(4, 5);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(364, 40);
            label38.TabIndex = 10062;
            label38.Text = "Window/Font Settings";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(32, 32, 32);
            panel16.Controls.Add(gameProgressTabPage.gameProgressAdvancedCheckBox);
            panel16.Controls.Add(label41);
            panel16.Controls.Add(label43);
            panel16.Controls.Add(label44);
            panel16.Controls.Add(label45);
            panel16.Location = new Point(3, 62);
            panel16.Margin = new Padding(4, 5, 4, 5);
            panel16.Name = "panel16";
            panel16.Size = new Size(694, 35);
            panel16.TabIndex = 10076;
            // 
            // gameProgressAdvancedCheckBox
            // 
            gameProgressTabPage.gameProgressAdvancedCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressAdvancedCheckBox.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            gameProgressTabPage.gameProgressAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressAdvancedCheckBox.Location = new Point(8, 3);
            gameProgressTabPage.gameProgressAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressAdvancedCheckBox.Name = "gameProgressAdvancedCheckBox";
            gameProgressTabPage.gameProgressAdvancedCheckBox.Size = new Size(135, 29);
            gameProgressTabPage.gameProgressAdvancedCheckBox.TabIndex = 10053;
            gameProgressTabPage.gameProgressAdvancedCheckBox.Text = "Advanced";
            gameProgressTabPage.gameProgressAdvancedCheckBox.UseVisualStyleBackColor = false;
            gameProgressTabPage.gameProgressAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label41
            // 
            label41.BackColor = Color.Transparent;
            label41.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label41.ForeColor = Color.FromArgb(200, 200, 200);
            label41.Location = new Point(225, 5);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new Size(72, 25);
            label41.TabIndex = 10065;
            label41.Text = "Color";
            // 
            // label43
            // 
            label43.BackColor = Color.Transparent;
            label43.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label43.ForeColor = Color.FromArgb(200, 200, 200);
            label43.Location = new Point(291, 5);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new Size(75, 25);
            label43.TabIndex = 10066;
            label43.Text = "Font";
            // 
            // label44
            // 
            label44.BackColor = Color.Transparent;
            label44.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label44.ForeColor = Color.FromArgb(200, 200, 200);
            label44.Location = new Point(524, 5);
            label44.Margin = new Padding(4, 0, 4, 0);
            label44.Name = "label44";
            label44.Size = new Size(62, 25);
            label44.TabIndex = 10068;
            label44.Text = "Size";
            // 
            // label45
            // 
            label45.BackColor = Color.Transparent;
            label45.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label45.ForeColor = Color.FromArgb(200, 200, 200);
            label45.Location = new Point(594, 5);
            label45.Margin = new Padding(4, 0, 4, 0);
            label45.Name = "label45";
            label45.Size = new Size(88, 25);
            label45.TabIndex = 10067;
            label45.Text = "Enabled";
            // 
            // gameProgressOpenWindowButton
            // 
            gameProgressTabPage.gameProgressOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            gameProgressTabPage.gameProgressOpenWindowButton.FlatStyle = FlatStyle.Flat;
            gameProgressTabPage.gameProgressOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            gameProgressTabPage.gameProgressOpenWindowButton.Location = new Point(573, 3);
            gameProgressTabPage.gameProgressOpenWindowButton.Margin = new Padding(0);
            gameProgressTabPage.gameProgressOpenWindowButton.Name = "gameProgressOpenWindowButton";
            gameProgressTabPage.gameProgressOpenWindowButton.Size = new Size(112, 42);
            gameProgressTabPage.gameProgressOpenWindowButton.TabIndex = 10021;
            gameProgressTabPage.gameProgressOpenWindowButton.Text = "Open";
            gameProgressTabPage.gameProgressOpenWindowButton.UseVisualStyleBackColor = false;
            gameProgressTabPage.gameProgressOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // gameProgressValuesPanel
            // 
            gameProgressTabPage.gameProgressValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(label46);
            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontColorPictureBox);
            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontComboBox);
            gameProgressTabPage.gameProgressValuesPanel.Location = new Point(3, 163);
            gameProgressTabPage.gameProgressValuesPanel.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesPanel.Name = "gameProgressValuesPanel";
            gameProgressTabPage.gameProgressValuesPanel.Size = new Size(694, 35);
            gameProgressTabPage.gameProgressValuesPanel.TabIndex = 10061;
            // 
            // label46
            // 
            label46.BackColor = Color.Transparent;
            label46.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label46.ForeColor = Color.FromArgb(44, 151, 250);
            label46.Location = new Point(4, 6);
            label46.Margin = new Padding(4, 0, 4, 0);
            label46.Name = "label46";
            label46.Size = new Size(216, 25);
            label46.TabIndex = 10066;
            label46.Text = "Values";
            // 
            // gameProgressValuesFontColorPictureBox
            // 
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.BackColor = Color.White;
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Location = new Point(230, 5);
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Name = "gameProgressValuesFontColorPictureBox";
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Size = new Size(22, 22);
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.TabIndex = 45;
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.TabStop = false;
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameProgressValuesFontComboBox
            // 
            gameProgressTabPage.gameProgressValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressValuesFontComboBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressValuesFontComboBox.FormattingEnabled = true;
            gameProgressTabPage.gameProgressValuesFontComboBox.Location = new Point(290, 3);
            gameProgressTabPage.gameProgressValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesFontComboBox.Name = "gameProgressValuesFontComboBox";
            gameProgressTabPage.gameProgressValuesFontComboBox.Size = new Size(301, 28);
            gameProgressTabPage.gameProgressValuesFontComboBox.TabIndex = 45;
            gameProgressTabPage.gameProgressValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // gameProgressAutoOpenWindowCheckbox
            // 
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.AutoSize = true;
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Location = new Point(378, 14);
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Name = "gameProgressAutoOpenWindowCheckbox";
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Size = new Size(147, 29);
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.TabIndex = 10022;
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.Text = "Auto-Open";
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox6.Location = new Point(3, 49);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(690, 3);
            pictureBox6.TabIndex = 10063;
            pictureBox6.TabStop = false;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(22, 22, 22);
            panel18.Controls.Add(gameProgressTabPage.gameProgressBackgroundColorPictureBox);
            panel18.Controls.Add(label47);
            panel18.Location = new Point(3, 95);
            panel18.Margin = new Padding(4, 5, 4, 5);
            panel18.Name = "panel18";
            panel18.Size = new Size(694, 35);
            panel18.TabIndex = 10061;
            // 
            // gameProgressBackgroundColorPictureBox
            // 
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.BackColor = Color.White;
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Location = new Point(230, 5);
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Name = "gameProgressBackgroundColorPictureBox";
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Size = new Size(22, 22);
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.TabIndex = 42;
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.TabStop = false;
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label47
            // 
            label47.BackColor = Color.Transparent;
            label47.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label47.ForeColor = Color.FromArgb(44, 151, 250);
            label47.Location = new Point(4, 5);
            label47.Margin = new Padding(4, 0, 4, 0);
            label47.Name = "label47";
            label47.Size = new Size(216, 25);
            label47.TabIndex = 10064;
            label47.Text = "Window Background";
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(32, 32, 32);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesLabel);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesFontColorPictureBox);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesFontComboBox);
            panel19.Location = new Point(3, 129);
            panel19.Margin = new Padding(4, 5, 4, 5);
            panel19.Name = "panel19";
            panel19.Size = new Size(694, 35);
            panel19.TabIndex = 10061;
            // 
            // gameProgressNamesLabel
            // 
            gameProgressTabPage.gameProgressNamesLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressNamesLabel.Location = new Point(4, 6);
            gameProgressTabPage.gameProgressNamesLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressNamesLabel.Name = "gameProgressNamesLabel";
            gameProgressTabPage.gameProgressNamesLabel.Size = new Size(216, 25);
            gameProgressTabPage.gameProgressNamesLabel.TabIndex = 10065;
            gameProgressTabPage.gameProgressNamesLabel.Text = "Names";
            // 
            // gameProgressNamesFontColorPictureBox
            // 
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.BackColor = Color.White;
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Location = new Point(230, 6);
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Name = "gameProgressNamesFontColorPictureBox";
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Size = new Size(22, 22);
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.TabIndex = 45;
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.TabStop = false;
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameProgressNamesFontComboBox
            // 
            gameProgressTabPage.gameProgressNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressNamesFontComboBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressNamesFontComboBox.FormattingEnabled = true;
            gameProgressTabPage.gameProgressNamesFontComboBox.Location = new Point(290, 3);
            gameProgressTabPage.gameProgressNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressNamesFontComboBox.Name = "gameProgressNamesFontComboBox";
            gameProgressTabPage.gameProgressNamesFontComboBox.Size = new Size(301, 28);
            gameProgressTabPage.gameProgressNamesFontComboBox.TabIndex = 45;
            gameProgressTabPage.gameProgressNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(32, 32, 32);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesOutlineCheckBox);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesOutlineLabel);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox);
            panel23.Location = new Point(3, 197);
            panel23.Margin = new Padding(4, 5, 4, 5);
            panel23.Name = "panel23";
            panel23.Size = new Size(694, 35);
            panel23.TabIndex = 10061;
            // 
            // gameProgressNamesFontOutlineNumericUpDown
            // 
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Name = "gameProgressNamesFontOutlineNumericUpDown";
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.TabIndex = 45;
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // gameProgressNamesOutlineCheckBox
            // 
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Location = new Point(620, 8);
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Name = "gameProgressNamesOutlineCheckBox";
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.TabIndex = 45;
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressNamesOutlineLabel
            // 
            gameProgressTabPage.gameProgressNamesOutlineLabel.BackColor = Color.Transparent;
            gameProgressTabPage.gameProgressNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressNamesOutlineLabel.Location = new Point(4, 5);
            gameProgressTabPage.gameProgressNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressTabPage.gameProgressNamesOutlineLabel.Name = "gameProgressNamesOutlineLabel";
            gameProgressTabPage.gameProgressNamesOutlineLabel.Size = new Size(216, 25);
            gameProgressTabPage.gameProgressNamesOutlineLabel.TabIndex = 10066;
            gameProgressTabPage.gameProgressNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // gameProgressNamesFontOutlineColorPictureBox
            // 
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.BackColor = Color.White;
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Name = "gameProgressNamesFontOutlineColorPictureBox";
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.TabIndex = 45;
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.TabStop = false;
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameProgressValuesOutlinePanel
            // 
            gameProgressTabPage.gameProgressValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(label50);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesOutlineCheckBox);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Location = new Point(3, 231);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Name = "gameProgressValuesOutlinePanel";
            gameProgressTabPage.gameProgressValuesOutlinePanel.Size = new Size(694, 35);
            gameProgressTabPage.gameProgressValuesOutlinePanel.TabIndex = 10067;
            // 
            // label50
            // 
            label50.BackColor = Color.Transparent;
            label50.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label50.ForeColor = Color.FromArgb(44, 151, 250);
            label50.Location = new Point(4, 6);
            label50.Margin = new Padding(4, 0, 4, 0);
            label50.Name = "label50";
            label50.Size = new Size(216, 25);
            label50.TabIndex = 10066;
            label50.Text = "Values OutlineColor";
            // 
            // gameProgressValuesFontOutlineColorPictureBox
            // 
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.BackColor = Color.White;
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Name = "gameProgressValuesFontOutlineColorPictureBox";
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.TabIndex = 45;
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.TabStop = false;
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // gameProgressValuesFontOutlineNumericUpDown
            // 
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Name = "gameProgressValuesFontOutlineNumericUpDown";
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.TabIndex = 45;
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // gameProgressValuesOutlineCheckBox
            // 
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Location = new Point(620, 9);
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Name = "gameProgressValuesOutlineCheckBox";
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.TabIndex = 45;
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel36
            // 
            panel36.BackColor = Color.FromArgb(36, 36, 36);
            panel36.Controls.Add(panel27);
            panel36.Controls.Add(panel25);
            panel36.Controls.Add(panel37);
            panel36.Controls.Add(panel26);
            panel36.Controls.Add(label73);
            panel36.Controls.Add(gameProgressTabPage.gameProgressDefaultButton);
            panel36.Controls.Add(pictureBox17);
            panel36.Controls.Add(panel38);
            panel36.Controls.Add(panel39);
            panel36.Controls.Add(panel40);
            panel36.Controls.Add(panel41);
            panel36.Location = new Point(6, 5);
            panel36.Margin = new Padding(4, 5, 4, 5);
            panel36.Name = "panel36";
            panel36.Size = new Size(430, 342);
            panel36.TabIndex = 10080;
            // 
            // panel27
            // 
            panel27.BackColor = Color.FromArgb(22, 22, 22);
            panel27.Controls.Add(label55);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonPeriod);
            panel27.Controls.Add(label54);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonColon);
            panel27.Controls.Add(label53);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonBackslash);
            panel27.Controls.Add(label51);
            panel27.Location = new Point(3, 298);
            panel27.Margin = new Padding(4, 5, 4, 5);
            panel27.Name = "panel27";
            panel27.Size = new Size(417, 35);
            panel27.TabIndex = 10073;
            // 
            // label55
            // 
            label55.BackColor = Color.Transparent;
            label55.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label55.ForeColor = Color.FromArgb(44, 151, 250);
            label55.Location = new Point(346, 6);
            label55.Margin = new Padding(4, 0, 4, 0);
            label55.Name = "label55";
            label55.Size = new Size(22, 25);
            label55.TabIndex = 10074;
            label55.Text = ".";
            // 
            // gameProgressRadioButtonPeriod
            // 
            gameProgressTabPage.gameProgressRadioButtonPeriod.AutoSize = true;
            gameProgressTabPage.gameProgressRadioButtonPeriod.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressRadioButtonPeriod.Location = new Point(320, 8);
            gameProgressTabPage.gameProgressRadioButtonPeriod.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressRadioButtonPeriod.Name = "gameProgressRadioButtonPeriod";
            gameProgressTabPage.gameProgressRadioButtonPeriod.Size = new Size(21, 20);
            gameProgressTabPage.gameProgressRadioButtonPeriod.TabIndex = 10073;
            gameProgressTabPage.gameProgressRadioButtonPeriod.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressRadioButtonPeriod.CheckedChanged += new System.EventHandler(DividerCharacter_RadioButtonClicked);
            // 
            // label54
            // 
            label54.BackColor = Color.Transparent;
            label54.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label54.ForeColor = Color.FromArgb(44, 151, 250);
            label54.Location = new Point(264, 6);
            label54.Margin = new Padding(4, 0, 4, 0);
            label54.Name = "label54";
            label54.Size = new Size(22, 25);
            label54.TabIndex = 10072;
            label54.Text = ":";
            // 
            // gameProgressRadioButtonColon
            // 
            gameProgressTabPage.gameProgressRadioButtonColon.AutoSize = true;
            gameProgressTabPage.gameProgressRadioButtonColon.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressRadioButtonColon.Location = new Point(237, 8);
            gameProgressTabPage.gameProgressRadioButtonColon.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressRadioButtonColon.Name = "gameProgressRadioButtonColon";
            gameProgressTabPage.gameProgressRadioButtonColon.Size = new Size(21, 20);
            gameProgressTabPage.gameProgressRadioButtonColon.TabIndex = 10071;
            gameProgressTabPage.gameProgressRadioButtonColon.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressRadioButtonColon.CheckedChanged += new System.EventHandler(DividerCharacter_RadioButtonClicked);
            // 
            // label53
            // 
            label53.BackColor = Color.Transparent;
            label53.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label53.ForeColor = Color.FromArgb(44, 151, 250);
            label53.Location = new Point(177, 6);
            label53.Margin = new Padding(4, 0, 4, 0);
            label53.Name = "label53";
            label53.Size = new Size(22, 25);
            label53.TabIndex = 10070;
            label53.Text = "/";
            // 
            // gameProgressRadioButtonBackslash
            // 
            gameProgressTabPage.gameProgressRadioButtonBackslash.AutoSize = true;
            gameProgressTabPage.gameProgressRadioButtonBackslash.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressRadioButtonBackslash.Location = new Point(150, 8);
            gameProgressTabPage.gameProgressRadioButtonBackslash.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressRadioButtonBackslash.Name = "gameProgressRadioButtonBackslash";
            gameProgressTabPage.gameProgressRadioButtonBackslash.Size = new Size(21, 20);
            gameProgressTabPage.gameProgressRadioButtonBackslash.TabIndex = 10067;
            gameProgressTabPage.gameProgressRadioButtonBackslash.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressRadioButtonBackslash.CheckedChanged += new System.EventHandler(DividerCharacter_RadioButtonClicked);
            // 
            // label51
            // 
            label51.BackColor = Color.Transparent;
            label51.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label51.ForeColor = Color.FromArgb(44, 151, 250);
            label51.Location = new Point(4, 6);
            label51.Margin = new Padding(4, 0, 4, 0);
            label51.Name = "label51";
            label51.Size = new Size(141, 25);
            label51.TabIndex = 10069;
            label51.Text = "Separator";
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(32, 32, 32);
            panel25.Location = new Point(3, 265);
            panel25.Margin = new Padding(4, 5, 4, 5);
            panel25.Name = "panel25";
            panel25.Size = new Size(417, 35);
            panel25.TabIndex = 10072;
            // 
            // panel37
            // 
            panel37.BackColor = Color.FromArgb(32, 32, 32);
            panel37.Controls.Add(label39);
            panel37.Controls.Add(label40);
            panel37.Controls.Add(label72);
            panel37.Location = new Point(3, 62);
            panel37.Margin = new Padding(4, 5, 4, 5);
            panel37.Name = "panel37";
            panel37.Size = new Size(417, 35);
            panel37.TabIndex = 10079;
            // 
            // label39
            // 
            label39.BackColor = Color.Transparent;
            label39.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label39.ForeColor = Color.FromArgb(200, 200, 200);
            label39.Location = new Point(4, 5);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(75, 25);
            label39.TabIndex = 10071;
            label39.Text = "Field";
            // 
            // label40
            // 
            label40.BackColor = Color.Transparent;
            label40.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label40.ForeColor = Color.FromArgb(200, 200, 200);
            label40.Location = new Point(170, 5);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(153, 25);
            label40.TabIndex = 10073;
            label40.Text = "Display Text";
            // 
            // label72
            // 
            label72.BackColor = Color.Transparent;
            label72.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label72.ForeColor = Color.FromArgb(200, 200, 200);
            label72.Location = new Point(332, 5);
            label72.Margin = new Padding(4, 0, 4, 0);
            label72.Name = "label72";
            label72.Size = new Size(92, 25);
            label72.TabIndex = 10072;
            label72.Text = "Enabled";
            // 
            // panel26
            // 
            panel26.BackColor = Color.FromArgb(22, 22, 22);
            panel26.Controls.Add(label52);
            panel26.Controls.Add(gameProgressTabPage.gameProgressCompletedTextBox);
            panel26.Controls.Add(gameProgressTabPage.gameProgressCompletedCheckBox);
            panel26.Location = new Point(3, 231);
            panel26.Margin = new Padding(4, 5, 4, 5);
            panel26.Name = "panel26";
            panel26.Size = new Size(417, 35);
            panel26.TabIndex = 10071;
            // 
            // label52
            // 
            label52.BackColor = Color.Transparent;
            label52.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label52.ForeColor = Color.FromArgb(44, 151, 250);
            label52.Location = new Point(4, 6);
            label52.Margin = new Padding(4, 0, 4, 0);
            label52.Name = "label52";
            label52.Size = new Size(141, 25);
            label52.TabIndex = 10068;
            label52.Text = "Completed";
            // 
            // gameProgressCompletedTextBox
            // 
            gameProgressTabPage.gameProgressCompletedTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressCompletedTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressCompletedTextBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressCompletedTextBox.Location = new Point(174, 0);
            gameProgressTabPage.gameProgressCompletedTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressCompletedTextBox.Name = "gameProgressCompletedTextBox";
            gameProgressTabPage.gameProgressCompletedTextBox.Size = new Size(146, 31);
            gameProgressTabPage.gameProgressCompletedTextBox.TabIndex = 7;
            gameProgressTabPage.gameProgressCompletedTextBox.Text = "Completed";
            gameProgressTabPage.gameProgressCompletedTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // gameProgressCompletedCheckBox
            // 
            gameProgressTabPage.gameProgressCompletedCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressCompletedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressCompletedCheckBox.Location = new Point(338, 8);
            gameProgressTabPage.gameProgressCompletedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressCompletedCheckBox.Name = "gameProgressCompletedCheckBox";
            gameProgressTabPage.gameProgressCompletedCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressCompletedCheckBox.TabIndex = 56;
            gameProgressTabPage.gameProgressCompletedCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressCompletedCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label73
            // 
            label73.BackColor = Color.Transparent;
            label73.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label73.ForeColor = Color.FromArgb(44, 151, 250);
            label73.Location = new Point(4, 5);
            label73.Margin = new Padding(4, 0, 4, 0);
            label73.Name = "label73";
            label73.Size = new Size(285, 40);
            label73.TabIndex = 10069;
            label73.Text = "Field Overrides";
            // 
            // gameProgressDefaultButton
            // 
            gameProgressTabPage.gameProgressDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            gameProgressTabPage.gameProgressDefaultButton.FlatStyle = FlatStyle.Flat;
            gameProgressTabPage.gameProgressDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            gameProgressTabPage.gameProgressDefaultButton.Location = new Point(306, 3);
            gameProgressTabPage.gameProgressDefaultButton.Margin = new Padding(0);
            gameProgressTabPage.gameProgressDefaultButton.Name = "gameProgressDefaultButton";
            gameProgressTabPage.gameProgressDefaultButton.Size = new Size(112, 42);
            gameProgressTabPage.gameProgressDefaultButton.TabIndex = 39;
            gameProgressTabPage.gameProgressDefaultButton.Text = "Default";
            gameProgressTabPage.gameProgressDefaultButton.UseVisualStyleBackColor = false;
            gameProgressTabPage.gameProgressDefaultButton.Click += new System.EventHandler(DefaultButton_Click);
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox17.Location = new Point(3, 49);
            pictureBox17.Margin = new Padding(4, 5, 4, 5);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(412, 3);
            pictureBox17.TabIndex = 10070;
            pictureBox17.TabStop = false;
            // 
            // panel38
            // 
            panel38.BackColor = Color.FromArgb(22, 22, 22);
            panel38.Controls.Add(label74);
            panel38.Controls.Add(gameProgressTabPage.gameProgressAchievementsCheckBox);
            panel38.Controls.Add(gameProgressTabPage.gameProgressAchievementsTextBox);
            panel38.Location = new Point(3, 95);
            panel38.Margin = new Padding(4, 5, 4, 5);
            panel38.Name = "panel38";
            panel38.Size = new Size(417, 35);
            panel38.TabIndex = 10061;
            // 
            // label74
            // 
            label74.BackColor = Color.Transparent;
            label74.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label74.ForeColor = Color.FromArgb(44, 151, 250);
            label74.Location = new Point(4, 5);
            label74.Margin = new Padding(4, 0, 4, 0);
            label74.Name = "label74";
            label74.Size = new Size(168, 25);
            label74.TabIndex = 10066;
            label74.Text = "Achievements";
            // 
            // gameProgressAchievementsCheckBox
            // 
            gameProgressTabPage.gameProgressAchievementsCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressAchievementsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAchievementsCheckBox.Location = new Point(338, 8);
            gameProgressTabPage.gameProgressAchievementsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressAchievementsCheckBox.Name = "gameProgressAchievementsCheckBox";
            gameProgressTabPage.gameProgressAchievementsCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressAchievementsCheckBox.TabIndex = 52;
            gameProgressTabPage.gameProgressAchievementsCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressAchievementsCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressAchievementsTextBox
            // 
            gameProgressTabPage.gameProgressAchievementsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressAchievementsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressAchievementsTextBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressAchievementsTextBox.Location = new Point(174, 0);
            gameProgressTabPage.gameProgressAchievementsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressAchievementsTextBox.Name = "gameProgressAchievementsTextBox";
            gameProgressTabPage.gameProgressAchievementsTextBox.Size = new Size(146, 31);
            gameProgressTabPage.gameProgressAchievementsTextBox.TabIndex = 1;
            gameProgressTabPage.gameProgressAchievementsTextBox.Text = "Achievements";
            gameProgressTabPage.gameProgressAchievementsTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel39
            // 
            panel39.BackColor = Color.FromArgb(32, 32, 32);
            panel39.Controls.Add(label75);
            panel39.Controls.Add(gameProgressTabPage.gameProgressRatioCheckBox);
            panel39.Controls.Add(gameProgressTabPage.gameProgressRatioTextBox);
            panel39.Location = new Point(3, 197);
            panel39.Margin = new Padding(4, 5, 4, 5);
            panel39.Name = "panel39";
            panel39.Size = new Size(417, 35);
            panel39.TabIndex = 10061;
            // 
            // label75
            // 
            label75.BackColor = Color.Transparent;
            label75.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label75.ForeColor = Color.FromArgb(44, 151, 250);
            label75.Location = new Point(4, 6);
            label75.Margin = new Padding(4, 0, 4, 0);
            label75.Name = "label75";
            label75.Size = new Size(141, 25);
            label75.TabIndex = 10069;
            label75.Text = "Retro Ratio";
            // 
            // gameProgressRatioCheckBox
            // 
            gameProgressTabPage.gameProgressRatioCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressRatioCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressRatioCheckBox.Location = new Point(338, 8);
            gameProgressTabPage.gameProgressRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressRatioCheckBox.Name = "gameProgressRatioCheckBox";
            gameProgressTabPage.gameProgressRatioCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressRatioCheckBox.TabIndex = 55;
            gameProgressTabPage.gameProgressRatioCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressRatioCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressRatioTextBox
            // 
            gameProgressTabPage.gameProgressRatioTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressRatioTextBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressRatioTextBox.Location = new Point(174, 0);
            gameProgressTabPage.gameProgressRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressRatioTextBox.Name = "gameProgressRatioTextBox";
            gameProgressTabPage.gameProgressRatioTextBox.Size = new Size(146, 31);
            gameProgressTabPage.gameProgressRatioTextBox.TabIndex = 5;
            gameProgressTabPage.gameProgressRatioTextBox.Text = "Retro Ratio";
            gameProgressTabPage.gameProgressRatioTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // panel40
            // 
            panel40.BackColor = Color.FromArgb(22, 22, 22);
            panel40.Controls.Add(label76);
            panel40.Controls.Add(gameProgressTabPage.gameProgressTruePointsTextBox);
            panel40.Controls.Add(gameProgressTabPage.gameProgressTruePointsCheckBox);
            panel40.Location = new Point(3, 163);
            panel40.Margin = new Padding(4, 5, 4, 5);
            panel40.Name = "panel40";
            panel40.Size = new Size(417, 35);
            panel40.TabIndex = 10061;
            // 
            // label76
            // 
            label76.BackColor = Color.Transparent;
            label76.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label76.ForeColor = Color.FromArgb(44, 151, 250);
            label76.Location = new Point(4, 6);
            label76.Margin = new Padding(4, 0, 4, 0);
            label76.Name = "label76";
            label76.Size = new Size(141, 25);
            label76.TabIndex = 10068;
            label76.Text = "True Points";
            // 
            // gameProgressTruePointsTextBox
            // 
            gameProgressTabPage.gameProgressTruePointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressTruePointsTextBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressTruePointsTextBox.Location = new Point(174, 0);
            gameProgressTabPage.gameProgressTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressTruePointsTextBox.Name = "gameProgressTruePointsTextBox";
            gameProgressTabPage.gameProgressTruePointsTextBox.Size = new Size(146, 31);
            gameProgressTabPage.gameProgressTruePointsTextBox.TabIndex = 7;
            gameProgressTabPage.gameProgressTruePointsTextBox.Text = "True Points";
            gameProgressTabPage.gameProgressTruePointsTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // gameProgressTruePointsCheckBox
            // 
            gameProgressTabPage.gameProgressTruePointsCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressTruePointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressTruePointsCheckBox.Location = new Point(338, 8);
            gameProgressTabPage.gameProgressTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressTruePointsCheckBox.Name = "gameProgressTruePointsCheckBox";
            gameProgressTabPage.gameProgressTruePointsCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressTruePointsCheckBox.TabIndex = 56;
            gameProgressTabPage.gameProgressTruePointsCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressTruePointsCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel41
            // 
            panel41.BackColor = Color.FromArgb(32, 32, 32);
            panel41.Controls.Add(label77);
            panel41.Controls.Add(gameProgressTabPage.gameProgressPointsTextBox);
            panel41.Controls.Add(gameProgressTabPage.gameProgressPointsCheckBox);
            panel41.Location = new Point(3, 129);
            panel41.Margin = new Padding(4, 5, 4, 5);
            panel41.Name = "panel41";
            panel41.Size = new Size(417, 35);
            panel41.TabIndex = 10061;
            // 
            // label77
            // 
            label77.BackColor = Color.Transparent;
            label77.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label77.ForeColor = Color.FromArgb(44, 151, 250);
            label77.Location = new Point(4, 6);
            label77.Margin = new Padding(4, 0, 4, 0);
            label77.Name = "label77";
            label77.Size = new Size(141, 25);
            label77.TabIndex = 10067;
            label77.Text = "Points";
            // 
            // gameProgressPointsTextBox
            // 
            gameProgressTabPage.gameProgressPointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTabPage.gameProgressPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressPointsTextBox.ForeColor = Color.White;
            gameProgressTabPage.gameProgressPointsTextBox.Location = new Point(174, 0);
            gameProgressTabPage.gameProgressPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressPointsTextBox.Name = "gameProgressPointsTextBox";
            gameProgressTabPage.gameProgressPointsTextBox.Size = new Size(146, 31);
            gameProgressTabPage.gameProgressPointsTextBox.TabIndex = 6;
            gameProgressTabPage.gameProgressPointsTextBox.Text = "Points";
            gameProgressTabPage.gameProgressPointsTextBox.TextChanged += new System.EventHandler(OverrideTextBox_TextChanged);
            // 
            // gameProgressPointsCheckBox
            // 
            gameProgressTabPage.gameProgressPointsCheckBox.AutoSize = true;
            gameProgressTabPage.gameProgressPointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTabPage.gameProgressPointsCheckBox.Location = new Point(338, 8);
            gameProgressTabPage.gameProgressPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTabPage.gameProgressPointsCheckBox.Name = "gameProgressPointsCheckBox";
            gameProgressTabPage.gameProgressPointsCheckBox.Size = new Size(22, 21);
            gameProgressTabPage.gameProgressPointsCheckBox.TabIndex = 54;
            gameProgressTabPage.gameProgressPointsCheckBox.UseVisualStyleBackColor = true;
            gameProgressTabPage.gameProgressPointsCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel113
            // 
            panel113.BackColor = Color.FromArgb(32, 32, 32);
            panel113.Controls.Add(label155);
            panel113.Controls.Add(pictureBox15);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsMaxListLabel);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox);
            panel113.Location = new Point(6, 5);
            panel113.Margin = new Padding(4, 5, 4, 5);
            panel113.Name = "panel113";
            panel113.Size = new Size(434, 98);
            panel113.TabIndex = 10083;
            // 
            // label155
            // 
            label155.BackColor = Color.Transparent;
            label155.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label155.ForeColor = Color.FromArgb(44, 151, 250);
            label155.Location = new Point(4, 5);
            label155.Margin = new Padding(4, 0, 4, 0);
            label155.Name = "label155";
            label155.Size = new Size(285, 40);
            label155.TabIndex = 10069;
            label155.Text = "List Settings";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox15.Location = new Point(3, 49);
            pictureBox15.Margin = new Padding(4, 5, 4, 5);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(412, 3);
            pictureBox15.TabIndex = 10070;
            pictureBox15.TabStop = false;
            // 
            // recentAchievementsAutoScrollCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.BackColor = Color.Transparent;
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Location = new Point(4, 60);
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Name = "recentAchievementsAutoScrollCheckBox";
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Size = new Size(147, 29);
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.TabIndex = 10055;
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.Text = "Auto-scroll";
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel99
            // 
            panel99.BackColor = Color.FromArgb(32, 32, 32);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsLinePanel);
            panel99.Controls.Add(label17);
            panel99.Controls.Add(panel101);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsPanel);
            panel99.Controls.Add(panel103);
            panel99.Controls.Add(panel104);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsOpenWindowButton);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionPanel);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox);
            panel99.Controls.Add(pictureBox23);
            panel99.Controls.Add(panel107);
            panel99.Controls.Add(panel108);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsOutlinePanel);
            panel99.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlinePanel);
            panel99.Location = new Point(444, 5);
            panel99.Margin = new Padding(4, 5, 4, 5);
            panel99.Name = "panel99";
            panel99.Size = new Size(702, 438);
            panel99.TabIndex = 10082;
            // 
            // recentAchievementsLinePanel
            // 
            recentAchievementsTabPage.recentAchievementsLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsTabPage.recentAchievementsLinePanel.Controls.Add(label16);
            recentAchievementsTabPage.recentAchievementsLinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsLinePanel.Location = new Point(3, 265);
            recentAchievementsTabPage.recentAchievementsLinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLinePanel.Name = "recentAchievementsLinePanel";
            recentAchievementsTabPage.recentAchievementsLinePanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsLinePanel.TabIndex = 10068;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = Color.FromArgb(44, 151, 250);
            label16.Location = new Point(4, 6);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(216, 25);
            label16.TabIndex = 10066;
            label16.Text = "Line";
            // 
            // recentAchievementsLineColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Name = "recentAchievementsLineColorPictureBox";
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = Color.FromArgb(44, 151, 250);
            label17.Location = new Point(4, 5);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(364, 40);
            label17.TabIndex = 10062;
            label17.Text = "Window/Font Settings";
            // 
            // panel101
            // 
            panel101.BackColor = Color.FromArgb(32, 32, 32);
            panel101.Controls.Add(recentAchievementsTabPage.recentAchievementsBorderCheckBox);
            panel101.Controls.Add(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox);
            panel101.Controls.Add(label18);
            panel101.Location = new Point(3, 129);
            panel101.Margin = new Padding(4, 5, 4, 5);
            panel101.Name = "panel101";
            panel101.Size = new Size(694, 35);
            panel101.TabIndex = 10069;
            // 
            // recentAchievementsBorderCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Location = new Point(620, 8);
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Name = "recentAchievementsBorderCheckBox";
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.Size = new Size(22, 21);
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.TabIndex = 10065;
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsBorderColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Name = "recentAchievementsBorderColorPictureBox";
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.TabIndex = 42;
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = Color.FromArgb(44, 151, 250);
            label18.Location = new Point(4, 5);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(216, 25);
            label18.TabIndex = 10064;
            label18.Text = "Border";
            // 
            // recentAchievementsPointsPanel
            // 
            recentAchievementsTabPage.recentAchievementsPointsPanel.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(label19);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontComboBox);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Location = new Point(3, 231);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Name = "recentAchievementsPointsPanel";
            recentAchievementsTabPage.recentAchievementsPointsPanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsPointsPanel.TabIndex = 10070;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label19.ForeColor = Color.FromArgb(44, 151, 250);
            label19.Location = new Point(4, 6);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(216, 25);
            label19.TabIndex = 10065;
            label19.Text = "Points";
            // 
            // recentAchievementsPointsFontColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Name = "recentAchievementsPointsFontColorPictureBox";
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsPointsFontComboBox
            // 
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.FormattingEnabled = true;
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.Location = new Point(290, 3);
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.Name = "recentAchievementsPointsFontComboBox";
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.Size = new Size(301, 28);
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel103
            // 
            panel103.BackColor = Color.FromArgb(32, 32, 32);
            panel103.Controls.Add(recentAchievementsTabPage.recentAchievementsAdvancedCheckBox);
            panel103.Controls.Add(label20);
            panel103.Controls.Add(label21);
            panel103.Controls.Add(label22);
            panel103.Controls.Add(label23);
            panel103.Location = new Point(3, 62);
            panel103.Margin = new Padding(4, 5, 4, 5);
            panel103.Name = "panel103";
            panel103.Size = new Size(694, 35);
            panel103.TabIndex = 10076;
            // 
            // recentAchievementsAdvancedCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.BackColor = Color.Transparent;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Location = new Point(8, 3);
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Name = "recentAchievementsAdvancedCheckBox";
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Size = new Size(135, 29);
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.TabIndex = 10053;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.Text = "Advanced";
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.CheckedChanged += new System.EventHandler(AdvancedCheckBox_Click);
            // 
            // label20
            // 
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label20.ForeColor = Color.FromArgb(200, 200, 200);
            label20.Location = new Point(225, 5);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(72, 25);
            label20.TabIndex = 10065;
            label20.Text = "Color";
            // 
            // label21
            // 
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label21.ForeColor = Color.FromArgb(200, 200, 200);
            label21.Location = new Point(291, 5);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(75, 25);
            label21.TabIndex = 10066;
            label21.Text = "Font";
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = Color.FromArgb(200, 200, 200);
            label22.Location = new Point(524, 5);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(62, 25);
            label22.TabIndex = 10068;
            label22.Text = "Size";
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label23.ForeColor = Color.FromArgb(200, 200, 200);
            label23.Location = new Point(594, 5);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(88, 25);
            label23.TabIndex = 10067;
            label23.Text = "Enabled";
            // 
            // panel104
            // 
            panel104.BackColor = Color.FromArgb(22, 22, 22);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleOutlineLabel);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox);
            panel104.Location = new Point(3, 298);
            panel104.Margin = new Padding(4, 5, 4, 5);
            panel104.Name = "panel104";
            panel104.Size = new Size(694, 35);
            panel104.TabIndex = 10071;
            // 
            // recentAchievementsTitleFontOutlineNumericUpDown
            // 
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Name = "recentAchievementsTitleFontOutlineNumericUpDown";
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsTitleFontOutlineCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Name = "recentAchievementsTitleFontOutlineCheckBox";
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsTitleOutlineLabel
            // 
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.BackColor = Color.Transparent;
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Location = new Point(4, 5);
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Name = "recentAchievementsTitleOutlineLabel";
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Size = new Size(216, 25);
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.TabIndex = 10066;
            recentAchievementsTabPage.recentAchievementsTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // recentAchievementsTitleFontOutlineColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Name = "recentAchievementsTitleFontOutlineColorPictureBox";
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsOpenWindowButton
            // 
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Location = new Point(573, 3);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Margin = new Padding(0);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Name = "recentAchievementsOpenWindowButton";
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Size = new Size(112, 42);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.TabIndex = 10021;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Text = "Open";
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.UseVisualStyleBackColor = false;
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // recentAchievementsDescriptionOutlinePanel
            // 
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(label144);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Location = new Point(3, 332);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Name = "recentAchievementsDescriptionOutlinePanel";
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label144
            // 
            label144.BackColor = Color.Transparent;
            label144.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label144.ForeColor = Color.FromArgb(44, 151, 250);
            label144.Location = new Point(4, 6);
            label144.Margin = new Padding(4, 0, 4, 0);
            label144.Name = "label144";
            label144.Size = new Size(216, 25);
            label144.TabIndex = 10066;
            label144.Text = "Date OutlineColor";
            // 
            // recentAchievementsDateFontOutlineColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Name = "recentAchievementsDateFontOutlineColorPictureBox";
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsDescriptionFontOutlineNumericUpDown
            // 
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Name = "recentAchievementsDescriptionFontOutlineNumericUpDown";
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsDateFontOutlineCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Name = "recentAchievementsDateFontOutlineCheckBox";
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsDescriptionPanel
            // 
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(label145);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Location = new Point(3, 197);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Name = "recentAchievementsDescriptionPanel";
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.TabIndex = 10061;
            // 
            // label145
            // 
            label145.BackColor = Color.Transparent;
            label145.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label145.ForeColor = Color.FromArgb(44, 151, 250);
            label145.Location = new Point(4, 6);
            label145.Margin = new Padding(4, 0, 4, 0);
            label145.Name = "label145";
            label145.Size = new Size(216, 25);
            label145.TabIndex = 10066;
            label145.Text = "Date";
            // 
            // recentAchievementsDateFontColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Name = "recentAchievementsDateFontColorPictureBox";
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsDescriptionFontComboBox
            // 
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.FormattingEnabled = true;
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.Location = new Point(290, 3);
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.Name = "recentAchievementsDescriptionFontComboBox";
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.Size = new Size(301, 28);
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // recentAchievementsAutoOpenWindowCheckbox
            // 
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Name = "recentAchievementsAutoOpenWindowCheckbox";
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.TabIndex = 10022;
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.Text = "Auto-Open";
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox23.Location = new Point(3, 49);
            pictureBox23.Margin = new Padding(4, 5, 4, 5);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(690, 3);
            pictureBox23.TabIndex = 10063;
            pictureBox23.TabStop = false;
            // 
            // panel107
            // 
            panel107.BackColor = Color.FromArgb(22, 22, 22);
            panel107.Controls.Add(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox);
            panel107.Controls.Add(label146);
            panel107.Location = new Point(3, 95);
            panel107.Margin = new Padding(4, 5, 4, 5);
            panel107.Name = "panel107";
            panel107.Size = new Size(694, 35);
            panel107.TabIndex = 10061;
            // 
            // recentAchievementsBackgroundColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Name = "recentAchievementsBackgroundColorPictureBox";
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.TabIndex = 42;
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label146
            // 
            label146.BackColor = Color.Transparent;
            label146.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label146.ForeColor = Color.FromArgb(44, 151, 250);
            label146.Location = new Point(4, 5);
            label146.Margin = new Padding(4, 0, 4, 0);
            label146.Name = "label146";
            label146.Size = new Size(216, 25);
            label146.TabIndex = 10064;
            label146.Text = "Window Background";
            // 
            // panel108
            // 
            panel108.BackColor = Color.FromArgb(22, 22, 22);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleLabel);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontComboBox);
            panel108.Location = new Point(3, 163);
            panel108.Margin = new Padding(4, 5, 4, 5);
            panel108.Name = "panel108";
            panel108.Size = new Size(694, 35);
            panel108.TabIndex = 10061;
            // 
            // recentAchievementsTitleLabel
            // 
            recentAchievementsTabPage.recentAchievementsTitleLabel.BackColor = Color.Transparent;
            recentAchievementsTabPage.recentAchievementsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsTitleLabel.Location = new Point(4, 6);
            recentAchievementsTabPage.recentAchievementsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsTabPage.recentAchievementsTitleLabel.Name = "recentAchievementsTitleLabel";
            recentAchievementsTabPage.recentAchievementsTitleLabel.Size = new Size(216, 25);
            recentAchievementsTabPage.recentAchievementsTitleLabel.TabIndex = 10065;
            recentAchievementsTabPage.recentAchievementsTitleLabel.Text = "Title";
            // 
            // recentAchievementsTitleFontColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Name = "recentAchievementsTitleFontColorPictureBox";
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsTitleFontComboBox
            // 
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.FormattingEnabled = true;
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.Location = new Point(290, 3);
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.Name = "recentAchievementsTitleFontComboBox";
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.Size = new Size(301, 28);
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            // 
            // recentAchievementsPointsOutlinePanel
            // 
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(label148);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Location = new Point(3, 366);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Name = "recentAchievementsPointsOutlinePanel";
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.TabIndex = 10061;
            // 
            // recentAchievementsPointsFontOutlineNumericUpDown
            // 
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Name = "recentAchievementsPointsFontOutlineNumericUpDown";
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsPointsFontOutlineCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Name = "recentAchievementsPointsFontOutlineCheckBox";
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label148
            // 
            label148.BackColor = Color.Transparent;
            label148.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label148.ForeColor = Color.FromArgb(44, 151, 250);
            label148.Location = new Point(4, 5);
            label148.Margin = new Padding(4, 0, 4, 0);
            label148.Name = "label148";
            label148.Size = new Size(216, 25);
            label148.TabIndex = 10066;
            label148.Text = "Points OutlineColor";
            // 
            // recentAchievementsPointsFontOutlineColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Name = "recentAchievementsPointsFontOutlineColorPictureBox";
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsLineOutlinePanel
            // 
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(label149);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Location = new Point(3, 400);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Name = "recentAchievementsLineOutlinePanel";
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Size = new Size(694, 35);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.TabIndex = 10067;
            // 
            // label149
            // 
            label149.BackColor = Color.Transparent;
            label149.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label149.ForeColor = Color.FromArgb(44, 151, 250);
            label149.Location = new Point(4, 6);
            label149.Margin = new Padding(4, 0, 4, 0);
            label149.Name = "label149";
            label149.Size = new Size(216, 25);
            label149.TabIndex = 10066;
            label149.Text = "Line OutlineColor";
            // 
            // recentAchievementsLineOutlineColorPictureBox
            // 
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Name = "recentAchievementsLineOutlineColorPictureBox";
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.TabStop = false;
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // recentAchievementsLineOutlineNumericUpDown
            // 
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Maximum = new decimal(new int[] {5, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Name = "recentAchievementsLineOutlineNumericUpDown";
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsLineOutlineCheckBox
            // 
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.AutoSize = true;
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Name = "recentAchievementsLineOutlineCheckBox";
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.TabIndex = 45;
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel115
            // 
            panel115.BackColor = Color.FromArgb(32, 32, 32);
            panel115.Controls.Add(label152);
            panel115.Controls.Add(pictureBox18);
            panel115.Controls.Add(achievementsListTabPage.achievementListAutoScrollCheckBox);
            panel115.Location = new Point(6, 5);
            panel115.Margin = new Padding(4, 5, 4, 5);
            panel115.Name = "panel115";
            panel115.Size = new Size(434, 97);
            panel115.TabIndex = 10084;
            // 
            // label152
            // 
            label152.BackColor = Color.Transparent;
            label152.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label152.ForeColor = Color.FromArgb(44, 151, 250);
            label152.Location = new Point(4, 5);
            label152.Margin = new Padding(4, 0, 4, 0);
            label152.Name = "label152";
            label152.Size = new Size(285, 40);
            label152.TabIndex = 10069;
            label152.Text = "List Settings";
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox18.Location = new Point(3, 49);
            pictureBox18.Margin = new Padding(4, 5, 4, 5);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(412, 3);
            pictureBox18.TabIndex = 10070;
            pictureBox18.TabStop = false;
            // 
            // achievementListAutoScrollCheckBox
            // 
            achievementsListTabPage.achievementListAutoScrollCheckBox.AutoSize = true;
            achievementsListTabPage.achievementListAutoScrollCheckBox.BackColor = Color.Transparent;
            achievementsListTabPage.achievementListAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            achievementsListTabPage.achievementListAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementsListTabPage.achievementListAutoScrollCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            achievementsListTabPage.achievementListAutoScrollCheckBox.Location = new Point(4, 60);
            achievementsListTabPage.achievementListAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            achievementsListTabPage.achievementListAutoScrollCheckBox.Name = "achievementListAutoScrollCheckBox";
            achievementsListTabPage.achievementListAutoScrollCheckBox.Size = new Size(147, 29);
            achievementsListTabPage.achievementListAutoScrollCheckBox.TabIndex = 10055;
            achievementsListTabPage.achievementListAutoScrollCheckBox.Text = "Auto-scroll";
            achievementsListTabPage.achievementListAutoScrollCheckBox.UseVisualStyleBackColor = false;
            achievementsListTabPage.achievementListAutoScrollCheckBox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel111
            // 
            panel111.BackColor = Color.FromArgb(32, 32, 32);
            panel111.Controls.Add(panel9);
            panel111.Controls.Add(label150);
            panel111.Controls.Add(panel112);
            panel111.Controls.Add(achievementsListTabPage.achievementListOpenWindowButton);
            panel111.Controls.Add(achievementsListTabPage.achievementListAutoOpenWindowCheckbox);
            panel111.Controls.Add(pictureBox16);
            panel111.Controls.Add(panel114);
            panel111.Location = new Point(444, 5);
            panel111.Margin = new Padding(4, 5, 4, 5);
            panel111.Name = "panel111";
            panel111.Size = new Size(702, 176);
            panel111.TabIndex = 10082;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(22, 22, 22);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeLabel);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeXUpDown);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeYUpDown);
            panel9.Location = new Point(4, 133);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(693, 36);
            panel9.TabIndex = 10065;
            // 
            // achievementListWindowSizeLabel
            // 
            achievementsListTabPage.achievementListWindowSizeLabel.AutoSize = true;
            achievementsListTabPage.achievementListWindowSizeLabel.Font = new Font("Verdana", 9.75F);
            achievementsListTabPage.achievementListWindowSizeLabel.ForeColor = Color.FromArgb(44, 151, 250);
            achievementsListTabPage.achievementListWindowSizeLabel.Location = new Point(3, 4);
            achievementsListTabPage.achievementListWindowSizeLabel.Name = "achievementListWindowSizeLabel";
            achievementsListTabPage.achievementListWindowSizeLabel.Size = new Size(141, 25);
            achievementsListTabPage.achievementListWindowSizeLabel.TabIndex = 10088;
            achievementsListTabPage.achievementListWindowSizeLabel.Text = "Window Size";
            // 
            // achievementListWindowSizeXUpDown
            // 
            achievementsListTabPage.achievementListWindowSizeXUpDown.Increment = new decimal(new int[] {68, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeXUpDown.Location = new Point(230, 4);
            achievementsListTabPage.achievementListWindowSizeXUpDown.Maximum = new decimal(new int[] {1700, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeXUpDown.Minimum = new decimal(new int[] {340, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeXUpDown.Name = "achievementListWindowSizeXUpDown";
            achievementsListTabPage.achievementListWindowSizeXUpDown.Size = new Size(120, 28);
            achievementsListTabPage.achievementListWindowSizeXUpDown.TabIndex = 3;
            achievementsListTabPage.achievementListWindowSizeXUpDown.Value = new decimal(new int[] {748, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeXUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // achievementListWindowSizeYUpDown
            // 
            achievementsListTabPage.achievementListWindowSizeYUpDown.Increment = new decimal(new int[] {68, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeYUpDown.Location = new Point(352, 4);
            achievementsListTabPage.achievementListWindowSizeYUpDown.Maximum = new decimal(new int[] {1700, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeYUpDown.Minimum = new decimal(new int[] {340, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeYUpDown.Name = "achievementListWindowSizeYUpDown";
            achievementsListTabPage.achievementListWindowSizeYUpDown.Size = new Size(120, 28);
            achievementsListTabPage.achievementListWindowSizeYUpDown.TabIndex = 1;
            achievementsListTabPage.achievementListWindowSizeYUpDown.Value = new decimal(new int[] {612, 0, 0, 0});
            achievementsListTabPage.achievementListWindowSizeYUpDown.ValueChanged += new System.EventHandler(CustomNumericUpDown_ValueChanged);
            // 
            // label150
            // 
            label150.BackColor = Color.Transparent;
            label150.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label150.ForeColor = Color.FromArgb(44, 151, 250);
            label150.Location = new Point(4, 5);
            label150.Margin = new Padding(4, 0, 4, 0);
            label150.Name = "label150";
            label150.Size = new Size(364, 40);
            label150.TabIndex = 10062;
            label150.Text = "Window/Font Settings";
            // 
            // panel112
            // 
            panel112.BackColor = Color.FromArgb(36, 36, 36);
            panel112.Controls.Add(label151);
            panel112.Location = new Point(3, 62);
            panel112.Margin = new Padding(4, 5, 4, 5);
            panel112.Name = "panel112";
            panel112.Size = new Size(694, 35);
            panel112.TabIndex = 10076;
            // 
            // label151
            // 
            label151.BackColor = Color.Transparent;
            label151.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label151.ForeColor = Color.FromArgb(200, 200, 200);
            label151.Location = new Point(225, 5);
            label151.Margin = new Padding(4, 0, 4, 0);
            label151.Name = "label151";
            label151.Size = new Size(72, 25);
            label151.TabIndex = 10065;
            label151.Text = "Color";
            // 
            // achievementListOpenWindowButton
            // 
            achievementsListTabPage.achievementListOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            achievementsListTabPage.achievementListOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            achievementsListTabPage.achievementListOpenWindowButton.FlatStyle = FlatStyle.Flat;
            achievementsListTabPage.achievementListOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementsListTabPage.achievementListOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            achievementsListTabPage.achievementListOpenWindowButton.Location = new Point(573, 3);
            achievementsListTabPage.achievementListOpenWindowButton.Margin = new Padding(0);
            achievementsListTabPage.achievementListOpenWindowButton.Name = "achievementListOpenWindowButton";
            achievementsListTabPage.achievementListOpenWindowButton.Size = new Size(112, 42);
            achievementsListTabPage.achievementListOpenWindowButton.TabIndex = 10021;
            achievementsListTabPage.achievementListOpenWindowButton.Text = "Open";
            achievementsListTabPage.achievementListOpenWindowButton.UseVisualStyleBackColor = false;
            achievementsListTabPage.achievementListOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // achievementListAutoOpenWindowCheckbox
            // 
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.AutoSize = true;
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Location = new Point(378, 14);
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Name = "achievementListAutoOpenWindowCheckbox";
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Size = new Size(147, 29);
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.TabIndex = 10022;
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.Text = "Auto-Open";
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox16.Location = new Point(3, 49);
            pictureBox16.Margin = new Padding(4, 5, 4, 5);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(690, 3);
            pictureBox16.TabIndex = 10063;
            pictureBox16.TabStop = false;
            // 
            // panel114
            // 
            panel114.BackColor = Color.FromArgb(22, 22, 22);
            panel114.Controls.Add(achievementsListTabPage.achievementListBackgroundColorPictureBox);
            panel114.Controls.Add(label156);
            panel114.Location = new Point(3, 95);
            panel114.Margin = new Padding(4, 5, 4, 5);
            panel114.Name = "panel114";
            panel114.Size = new Size(694, 35);
            panel114.TabIndex = 10061;
            // 
            // achievementListBackgroundColorPictureBox
            // 
            achievementsListTabPage.achievementListBackgroundColorPictureBox.BackColor = Color.White;
            achievementsListTabPage.achievementListBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Location = new Point(230, 5);
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Name = "achievementListBackgroundColorPictureBox";
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Size = new Size(22, 22);
            achievementsListTabPage.achievementListBackgroundColorPictureBox.TabIndex = 42;
            achievementsListTabPage.achievementListBackgroundColorPictureBox.TabStop = false;
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label156
            // 
            label156.BackColor = Color.Transparent;
            label156.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label156.ForeColor = Color.FromArgb(44, 151, 250);
            label156.Location = new Point(4, 5);
            label156.Margin = new Padding(4, 0, 4, 0);
            label156.Name = "label156";
            label156.Size = new Size(216, 25);
            label156.TabIndex = 10064;
            label156.Text = "Window Background";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkForUpdatesButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(stopButton);
            panel1.Controls.Add(autoStartCheckbox);
            panel1.Location = new Point(564, 9);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 147);
            panel1.TabIndex = 10031;
            // 
            // checkForUpdatesButton
            // 
            checkForUpdatesButton.BackColor = Color.FromArgb(22, 22, 22);
            checkForUpdatesButton.FlatAppearance.BorderColor = Color.Black;
            checkForUpdatesButton.FlatStyle = FlatStyle.Flat;
            checkForUpdatesButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            checkForUpdatesButton.ForeColor = Color.FromArgb(204, 153, 0);
            checkForUpdatesButton.Location = new Point(4, 95);
            checkForUpdatesButton.Margin = new Padding(0);
            checkForUpdatesButton.Name = "checkForUpdatesButton";
            checkForUpdatesButton.Size = new Size(225, 42);
            checkForUpdatesButton.TabIndex = 29;
            checkForUpdatesButton.Text = "Check For Updates";
            checkForUpdatesButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(apiKeyLabel);
            panel3.Controls.Add(apiKeyTextBox);
            panel3.Location = new Point(4, 46);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(596, 43);
            panel3.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.Controls.Add(usernameLabel);
            panel2.Controls.Add(usernameTextBox);
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 43);
            panel2.TabIndex = 27;
            // 
            // panel120
            // 
            panel120.BackColor = Color.FromArgb(32, 32, 32);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRAScreenshotRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRABadgeIconRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRABoxArtRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRATitleScreenRadioButton);
            panel120.Controls.Add(pictureBox19);
            panel120.Controls.Add(label1);
            panel120.Location = new Point(6, 5);
            panel120.Margin = new Padding(4, 5, 4, 5);
            panel120.Name = "panel120";
            panel120.Size = new Size(434, 226);
            panel120.TabIndex = 0;
            // 
            // relatedMediaRAScreenshotRadioButton
            // 
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Location = new Point(12, 182);
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Name = "relatedMediaRAScreenshotRadioButton";
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Size = new Size(150, 29);
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.TabIndex = 10075;
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.Text = "Screenshot";
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.CheckedChanged += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRABadgeIconRadioButton
            // 
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Checked = true;
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Location = new Point(12, 62);
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Name = "relatedMediaRABadgeIconRadioButton";
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Size = new Size(149, 29);
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.TabIndex = 10072;
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.TabStop = true;
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.Text = "Badge Icon";
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.CheckedChanged += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRABoxArtRadioButton
            // 
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Location = new Point(12, 102);
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Name = "relatedMediaRABoxArtRadioButton";
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Size = new Size(113, 29);
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.TabIndex = 10074;
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.Text = "Box Art";
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.CheckedChanged += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRATitleScreenRadioButton
            // 
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Location = new Point(12, 142);
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Name = "relatedMediaRATitleScreenRadioButton";
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Size = new Size(158, 29);
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.TabIndex = 10073;
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.Text = "Title Screen";
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.CheckedChanged += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox19.Location = new Point(3, 49);
            pictureBox19.Margin = new Padding(4, 5, 4, 5);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(412, 3);
            pictureBox19.TabIndex = 10071;
            pictureBox19.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = Color.FromArgb(44, 151, 250);
            label1.Location = new Point(4, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 40);
            label1.TabIndex = 10063;
            label1.Text = "RetroAchievements.org";
            // 
            // panel121
            // 
            panel121.BackColor = Color.FromArgb(32, 32, 32);
            panel121.Controls.Add(label90);
            panel121.Controls.Add(panel122);
            panel121.Controls.Add(relatedMediaTabPage.relatedMediaOpenWindowButton);
            panel121.Controls.Add(relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox);
            panel121.Controls.Add(pictureBox22);
            panel121.Controls.Add(panel123);
            panel121.Location = new Point(444, 5);
            panel121.Margin = new Padding(4, 5, 4, 5);
            panel121.Name = "panel121";
            panel121.Size = new Size(702, 134);
            panel121.TabIndex = 10083;
            // 
            // label90
            // 
            label90.BackColor = Color.Transparent;
            label90.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label90.ForeColor = Color.FromArgb(44, 151, 250);
            label90.Location = new Point(4, 5);
            label90.Margin = new Padding(4, 0, 4, 0);
            label90.Name = "label90";
            label90.Size = new Size(364, 40);
            label90.TabIndex = 10062;
            label90.Text = "Window/Font Settings";
            // 
            // panel122
            // 
            panel122.BackColor = Color.FromArgb(36, 36, 36);
            panel122.Controls.Add(label91);
            panel122.Location = new Point(3, 62);
            panel122.Margin = new Padding(4, 5, 4, 5);
            panel122.Name = "panel122";
            panel122.Size = new Size(694, 35);
            panel122.TabIndex = 10076;
            // 
            // label91
            // 
            label91.BackColor = Color.Transparent;
            label91.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label91.ForeColor = Color.FromArgb(200, 200, 200);
            label91.Location = new Point(225, 5);
            label91.Margin = new Padding(4, 0, 4, 0);
            label91.Name = "label91";
            label91.Size = new Size(72, 25);
            label91.TabIndex = 10065;
            label91.Text = "Color";
            // 
            // relatedMediaOpenWindowButton
            // 
            relatedMediaTabPage.relatedMediaOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            relatedMediaTabPage.relatedMediaOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            relatedMediaTabPage.relatedMediaOpenWindowButton.FlatStyle = FlatStyle.Flat;
            relatedMediaTabPage.relatedMediaOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            relatedMediaTabPage.relatedMediaOpenWindowButton.Location = new Point(573, 3);
            relatedMediaTabPage.relatedMediaOpenWindowButton.Margin = new Padding(0);
            relatedMediaTabPage.relatedMediaOpenWindowButton.Name = "relatedMediaOpenWindowButton";
            relatedMediaTabPage.relatedMediaOpenWindowButton.Size = new Size(112, 42);
            relatedMediaTabPage.relatedMediaOpenWindowButton.TabIndex = 10021;
            relatedMediaTabPage.relatedMediaOpenWindowButton.Text = "Open";
            relatedMediaTabPage.relatedMediaOpenWindowButton.UseVisualStyleBackColor = false;
            relatedMediaTabPage.relatedMediaOpenWindowButton.Click += new System.EventHandler(ShowWindowButton_Click);
            // 
            // relatedMediaAutoOpenWindowCheckbox
            // 
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.AutoSize = true;
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Location = new Point(378, 14);
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Name = "relatedMediaAutoOpenWindowCheckbox";
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Size = new Size(147, 29);
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.TabIndex = 10022;
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.Text = "Auto-Open";
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = Color.FromArgb(44, 151, 250);
            pictureBox22.Location = new Point(3, 49);
            pictureBox22.Margin = new Padding(4, 5, 4, 5);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(690, 3);
            pictureBox22.TabIndex = 10063;
            pictureBox22.TabStop = false;
            // 
            // panel123
            // 
            panel123.BackColor = Color.FromArgb(22, 22, 22);
            panel123.Controls.Add(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox);
            panel123.Controls.Add(label92);
            panel123.Location = new Point(3, 95);
            panel123.Margin = new Padding(4, 5, 4, 5);
            panel123.Name = "panel123";
            panel123.Size = new Size(694, 35);
            panel123.TabIndex = 10061;
            // 
            // relatedMediaBackgroundColorPictureBox
            // 
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.BackColor = Color.White;
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Location = new Point(230, 5);
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Name = "relatedMediaBackgroundColorPictureBox";
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Size = new Size(22, 22);
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.TabIndex = 42;
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.TabStop = false;
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Click += new System.EventHandler(FontColorPictureBox_Click);
            // 
            // label92
            // 
            label92.BackColor = Color.Transparent;
            label92.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label92.ForeColor = Color.FromArgb(44, 151, 250);
            label92.Location = new Point(4, 5);
            label92.Margin = new Padding(4, 0, 4, 0);
            label92.Name = "label92";
            label92.Size = new Size(216, 25);
            label92.TabIndex = 10064;
            label92.Text = "Window Background";
            // 
            // panel124
            // 
            panel124.BackColor = Color.FromArgb(32, 32, 32);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBCartFrontRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBCartBackRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxFullRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBClearLogoRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBannerRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBoxBackRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBBox3DRadioButton);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBLinePictureBox);
            panel124.Controls.Add(relatedMediaTabPage.relatedMediaLBLabel);
            panel124.Location = new Point(8, 240);
            panel124.Margin = new Padding(4, 5, 4, 5);
            panel124.Name = "panel124";
            panel124.Size = new Size(434, 322);
            panel124.TabIndex = 10076;
            // 
            // relatedMediaLBCartFrontRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Location = new Point(260, 222);
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Name = "relatedMediaLBCartFrontRadioButton";
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Size = new Size(157, 29);
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.TabIndex = 10084;
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Text = "Cart - Front";
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBCartBackRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Location = new Point(260, 262);
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Name = "relatedMediaLBCartBackRadioButton";
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Size = new Size(151, 29);
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.TabIndex = 10085;
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Text = "Cart - Back";
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxBackReconRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Location = new Point(10, 222);
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Name = "relatedMediaLBBoxBackReconRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Size = new Size(232, 29);
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.TabIndex = 10082;
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Text = "Box - Back (Recon)";
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxFullRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Location = new Point(10, 262);
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Name = "relatedMediaLBBoxFullRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Size = new Size(135, 29);
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.TabIndex = 10083;
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Text = "Box - Full";
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxSpineRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Location = new Point(260, 62);
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Name = "relatedMediaLBBoxSpineRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Size = new Size(155, 29);
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.TabIndex = 10081;
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Text = "Box - Spine";
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBClearLogoRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Location = new Point(260, 182);
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Name = "relatedMediaLBClearLogoRadioButton";
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Size = new Size(144, 29);
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.TabIndex = 10078;
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Text = "Clear Logo";
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBannerRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Location = new Point(260, 102);
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Name = "relatedMediaLBBannerRadioButton";
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Size = new Size(110, 29);
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.TabIndex = 10080;
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Text = "Banner";
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBTitleScreenRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Location = new Point(260, 142);
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Name = "relatedMediaLBTitleScreenRadioButton";
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Size = new Size(158, 29);
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.TabIndex = 10079;
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Text = "Title Screen";
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaSetLaunchBoxPathButton
            // 
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.BackColor = Color.FromArgb(22, 22, 22);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.FlatAppearance.BorderColor = Color.Black;
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.FlatStyle = FlatStyle.Flat;
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.ForeColor = Color.FromArgb(204, 153, 0);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Location = new Point(303, 5);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Margin = new Padding(0);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Name = "relatedMediaSetLaunchBoxPathButton";
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Size = new Size(112, 42);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.TabIndex = 10077;
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Text = "Set...";
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.UseVisualStyleBackColor = false;
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Click += new System.EventHandler(SetRelatedMediaPathButton_Click);
            // 
            // relatedMediaLBBoxFrontReconRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Location = new Point(10, 182);
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Name = "relatedMediaLBBoxFrontReconRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Size = new Size(238, 29);
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.TabIndex = 10075;
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Text = "Box - Front (Recon)";
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxFrontRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Location = new Point(10, 62);
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Name = "relatedMediaLBBoxFrontRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Size = new Size(152, 29);
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.TabIndex = 10072;
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Text = "Box - Front";
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxBackRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Location = new Point(10, 102);
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Name = "relatedMediaLBBoxBackRadioButton";
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Size = new Size(146, 29);
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.TabIndex = 10074;
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Text = "Box - Back";
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBox3DRadioButton
            // 
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.AutoSize = true;
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Location = new Point(10, 142);
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Name = "relatedMediaLBBox3DRadioButton";
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Size = new Size(126, 29);
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.TabIndex = 10073;
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Text = "Box - 3D";
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.UseVisualStyleBackColor = true;
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Click += new System.EventHandler(RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBLinePictureBox
            // 
            relatedMediaTabPage.relatedMediaLBLinePictureBox.BackColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBLinePictureBox.Location = new Point(3, 49);
            relatedMediaTabPage.relatedMediaLBLinePictureBox.Margin = new Padding(4, 5, 4, 5);
            relatedMediaTabPage.relatedMediaLBLinePictureBox.Name = "relatedMediaLBLinePictureBox";
            relatedMediaTabPage.relatedMediaLBLinePictureBox.Size = new Size(412, 3);
            relatedMediaTabPage.relatedMediaLBLinePictureBox.TabIndex = 10071;
            relatedMediaTabPage.relatedMediaLBLinePictureBox.TabStop = false;
            // 
            // relatedMediaLBLabel
            // 
            relatedMediaTabPage.relatedMediaLBLabel.BackColor = Color.Transparent;
            relatedMediaTabPage.relatedMediaLBLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            relatedMediaTabPage.relatedMediaLBLabel.ForeColor = Color.FromArgb(44, 151, 250);
            relatedMediaTabPage.relatedMediaLBLabel.Location = new Point(4, 5);
            relatedMediaTabPage.relatedMediaLBLabel.Margin = new Padding(4, 0, 4, 0);
            relatedMediaTabPage.relatedMediaLBLabel.Name = "relatedMediaLBLabel";
            relatedMediaTabPage.relatedMediaLBLabel.Size = new Size(294, 40);
            relatedMediaTabPage.relatedMediaLBLabel.TabIndex = 10063;
            relatedMediaTabPage.relatedMediaLBLabel.Text = "LaunchBox";
            // 
            // mainTabControl
            // 
            mainTabControl.Appearance = TabAppearance.FlatButtons;
            mainTabControl.Controls.Add(focusTabPage);
            mainTabControl.Controls.Add(alertsTabPage);
            mainTabControl.Controls.Add(userInfoTabPage);
            mainTabControl.Controls.Add(gameInfoTabPage);
            mainTabControl.Controls.Add(gameProgressTabPage);
            mainTabControl.Controls.Add(recentAchievementsTabPage);
            mainTabControl.Controls.Add(achievementsListTabPage);
            mainTabControl.Controls.Add(relatedMediaTabPage);
            mainTabControl.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            mainTabControl.HotTrack = true;
            mainTabControl.Location = new Point(6, 166);
            mainTabControl.Margin = new Padding(4, 5, 4, 5);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1166, 612);
            mainTabControl.TabIndex = 10033;
            // 
            // focusTabPage
            // 
            focusTabPage.Controls.Add(panel64);
            focusTabPage.Controls.Add(panel63);
            focusTabPage.Controls.Add(panel51);
            // 
            // alertsTabPage
            // 
            alertsTabPage.Controls.Add(alertTabControl);
            alertsTabPage.Controls.Add(panel65);
            // 
            // alertTabControl
            // 
            alertTabControl.Alignment = TabAlignment.Bottom;
            alertTabControl.Controls.Add(achievementTabPage);
            alertTabControl.Controls.Add(masteryTabPage);
            alertTabControl.Cursor = Cursors.Arrow;
            alertTabControl.HotTrack = true;
            alertTabControl.Location = new Point(4, 5);
            alertTabControl.Margin = new Padding(4, 5, 4, 5);
            alertTabControl.Name = "alertTabControl";
            alertTabControl.SelectedIndex = 0;
            alertTabControl.Size = new Size(438, 557);
            alertTabControl.TabIndex = 10082;
            // 
            // achievementTabPage
            // 
            achievementTabPage.BackColor = Color.FromArgb(22, 22, 22);
            achievementTabPage.Controls.Add(alertsTabPage.alertsCustomAchievementPanel);
            achievementTabPage.Controls.Add(alertsTabPage.alertsAchievementEnableCheckbox);
            achievementTabPage.Controls.Add(alertsTabPage.alertsPlayAchievementButton);
            achievementTabPage.Controls.Add(alertsTabPage.alertsCustomAchievementEnableCheckbox);
            achievementTabPage.Cursor = Cursors.Arrow;
            achievementTabPage.Location = new Point(4, 4);
            achievementTabPage.Margin = new Padding(4, 5, 4, 5);
            achievementTabPage.Name = "achievementTabPage";
            achievementTabPage.Padding = new Padding(4, 5, 4, 5);
            achievementTabPage.Size = new Size(430, 524);
            achievementTabPage.TabIndex = 0;
            achievementTabPage.Text = "Achievement";
            // 
            // masteryTabPage
            // 
            masteryTabPage.BackColor = Color.FromArgb(22, 22, 22);
            masteryTabPage.Controls.Add(alertsTabPage.alertsCustomMasteryPanel);
            masteryTabPage.Controls.Add(alertsTabPage.alertsMasteryEnableCheckbox);
            masteryTabPage.Controls.Add(alertsTabPage.alertsPlayMasteryButton);
            masteryTabPage.Controls.Add(alertsTabPage.alertsCustomMasteryEnableCheckbox);
            masteryTabPage.Location = new Point(4, 4);
            masteryTabPage.Margin = new Padding(4, 5, 4, 5);
            masteryTabPage.Name = "masteryTabPage";
            masteryTabPage.Padding = new Padding(4, 5, 4, 5);
            masteryTabPage.Size = new Size(430, 524);
            masteryTabPage.TabIndex = 1;
            masteryTabPage.Text = "Mastery";
            // 
            // userInfoTabPage
            // 
            userInfoTabPage.Controls.Add(panel14);
            userInfoTabPage.Controls.Add(panel21);
            userInfoTabPage.Controls.Add(panel20);
            // 
            // gameInfoTabPage
            // 
            gameInfoTabPage.Controls.Add(panel50);
            gameInfoTabPage.Controls.Add(panel29);
            gameInfoTabPage.Controls.Add(panel35);
            // 
            // gameProgressTabPage
            // 
            gameProgressTabPage.Controls.Add(panel28);
            gameProgressTabPage.Controls.Add(panel36);
            gameProgressTabPage.Controls.Add(panel15);
            // 
            // recentAchievementsTabPage
            // 
            recentAchievementsTabPage.Controls.Add(panel113);
            recentAchievementsTabPage.Controls.Add(panel99);
            // 
            // achievementsListTabPage
            // 
            achievementsListTabPage.Controls.Add(panel111);
            achievementsListTabPage.Controls.Add(panel115);
            // 
            // relatedMediaTabPage
            // 
            relatedMediaTabPage.Controls.Add(panel124);
            relatedMediaTabPage.Controls.Add(panel120);
            relatedMediaTabPage.Controls.Add(panel121);
            // 
            // manualSearchLabel
            // 
            manualSearchLabel.AutoSize = true;
            manualSearchLabel.BackColor = Color.Transparent;
            manualSearchLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            manualSearchLabel.ForeColor = Color.FromArgb(44, 151, 250);
            manualSearchLabel.Location = new Point(4, 15);
            manualSearchLabel.Margin = new Padding(4, 0, 4, 0);
            manualSearchLabel.Name = "manualSearchLabel";
            manualSearchLabel.Size = new Size(98, 25);
            manualSearchLabel.TabIndex = 32;
            manualSearchLabel.Text = "Game ID";
            // 
            // manualSearchTextBox
            // 
            manualSearchTextBox.BackColor = Color.FromArgb(22, 22, 22);
            manualSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            manualSearchTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            manualSearchTextBox.ForeColor = Color.White;
            manualSearchTextBox.Location = new Point(105, 9);
            manualSearchTextBox.Margin = new Padding(4, 5, 4, 5);
            manualSearchTextBox.Name = "manualSearchTextBox";
            manualSearchTextBox.Size = new Size(138, 31);
            manualSearchTextBox.TabIndex = 30;
            manualSearchTextBox.WordWrap = false;
            manualSearchTextBox.KeyPress += new KeyPressEventHandler(ManualSearchTextBox_KeyPress);
            // 
            // manualSearchButton
            // 
            manualSearchButton.BackColor = Color.FromArgb(22, 22, 22);
            manualSearchButton.FlatAppearance.BorderColor = Color.Black;
            manualSearchButton.FlatStyle = FlatStyle.Flat;
            manualSearchButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            manualSearchButton.ForeColor = Color.FromArgb(204, 153, 0);
            manualSearchButton.Location = new Point(249, 5);
            manualSearchButton.Margin = new Padding(0);
            manualSearchButton.Name = "manualSearchButton";
            manualSearchButton.Size = new Size(112, 42);
            manualSearchButton.TabIndex = 31;
            manualSearchButton.Text = "Search";
            manualSearchButton.UseVisualStyleBackColor = false;
            manualSearchButton.Click += new System.EventHandler(ManualSearchButton_Click);
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(46, 46, 46);
            panel8.Controls.Add(manualSearchLabel);
            panel8.Controls.Add(manualSearchTextBox);
            panel8.Controls.Add(manualSearchButton);
            panel8.Location = new Point(190, 105);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(364, 52);
            panel8.TabIndex = 10037;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1179, 785);
            Controls.Add(panel8);
            Controls.Add(mainTabControl);
            Controls.Add(autoPollingStatusPictureBox);
            Controls.Add(autoPollingStatusLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = ((Icon)(resources.GetObject("$Icon")));
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWindow";
            Text = "Retro Achievements Tracker";

            ((ISupportInitialize)(userProfilePictureBox)).EndInit();
            ((ISupportInitialize)(focusTabPage.focusAchievementPictureBox)).EndInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoPictureBox)).EndInit();
            ((ISupportInitialize)(autoPollingStatusPictureBox)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementScaleNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementXNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementYNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutSpeedUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInSpeedUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryScaleNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryXNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryYNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutSpeedUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInSpeedUpDown)).EndInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown)).EndInit();
            panel64.ResumeLayout(false);
            panel64.PerformLayout();
            ((ISupportInitialize)(pictureBox12)).EndInit();
            panel63.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox10)).EndInit();
            panel51.ResumeLayout(false);
            panel51.PerformLayout();
            focusTabPage.focusLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(focusTabPage.focusLineColorPictureBox)).EndInit();
            panel59.ResumeLayout(false);
            panel59.PerformLayout();
            ((ISupportInitialize)(focusTabPage.focusBorderColorPictureBox)).EndInit();
            focusTabPage.focusPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(focusTabPage.focusPointsFontColorPictureBox)).EndInit();
            panel52.ResumeLayout(false);
            panel52.PerformLayout();
            panel61.ResumeLayout(false);
            panel61.PerformLayout();
            ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineColorPictureBox)).EndInit();
            focusTabPage.focusDescriptionOutlinePanel.ResumeLayout(false);
            focusTabPage.focusDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineNumericUpDown)).EndInit();
            focusTabPage.focusDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(focusTabPage.focusDescriptionFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox11)).EndInit();
            panel54.ResumeLayout(false);
            ((ISupportInitialize)(focusTabPage.focusBackgroundColorPictureBox)).EndInit();
            panel55.ResumeLayout(false);
            ((ISupportInitialize)(focusTabPage.focusTitleFontColorPictureBox)).EndInit();
            focusTabPage.focusPointsOutlinePanel.ResumeLayout(false);
            focusTabPage.focusPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineColorPictureBox)).EndInit();
            focusTabPage.focusLineOutlinePanel.ResumeLayout(false);
            focusTabPage.focusLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(focusTabPage.focusLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(focusTabPage.focusLineOutlineNumericUpDown)).EndInit();
            panel65.ResumeLayout(false);
            panel65.PerformLayout();
            alertsTabPage.alertsLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(alertsTabPage.alertsLineColorPictureBox)).EndInit();
            panel67.ResumeLayout(false);
            panel67.PerformLayout();
            ((ISupportInitialize)(alertsTabPage.alertsBorderColorPictureBox)).EndInit();
            alertsTabPage.alertsPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontColorPictureBox)).EndInit();
            panel69.ResumeLayout(false);
            panel69.PerformLayout();
            panel70.ResumeLayout(false);
            panel70.PerformLayout();
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineColorPictureBox)).EndInit();
            alertsTabPage.alertsDescriptionOutlinePanel.ResumeLayout(false);
            alertsTabPage.alertsDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown)).EndInit();
            alertsTabPage.alertsDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox20)).EndInit();
            panel73.ResumeLayout(false);
            ((ISupportInitialize)(alertsTabPage.alertsBackgroundColorPictureBox)).EndInit();
            panel74.ResumeLayout(false);
            ((ISupportInitialize)(alertsTabPage.alertsTitleFontColorPictureBox)).EndInit();
            alertsTabPage.alertsPointsOutlinePanel.ResumeLayout(false);
            alertsTabPage.alertsPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineColorPictureBox)).EndInit();
            alertsTabPage.alertsLineOutlinePanel.ResumeLayout(false);
            alertsTabPage.alertsLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(alertsTabPage.alertsLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(alertsTabPage.alertsLineOutlineNumericUpDown)).EndInit();
            alertsTabPage.alertsCustomAchievementPanel.ResumeLayout(false);
            alertsTabPage.alertsCustomAchievementPanel.PerformLayout();
            panel85.ResumeLayout(false);
            panel84.ResumeLayout(false);
            panel86.ResumeLayout(false);
            panel83.ResumeLayout(false);
            panel87.ResumeLayout(false);
            panel78.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox13)).EndInit();
            panel79.ResumeLayout(false);
            panel80.ResumeLayout(false);
            panel81.ResumeLayout(false);
            panel82.ResumeLayout(false);
            alertsTabPage.alertsCustomMasteryPanel.ResumeLayout(false);
            alertsTabPage.alertsCustomMasteryPanel.PerformLayout();
            panel89.ResumeLayout(false);
            panel90.ResumeLayout(false);
            panel91.ResumeLayout(false);
            panel92.ResumeLayout(false);
            panel93.ResumeLayout(false);
            panel94.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox14)).EndInit();
            panel95.ResumeLayout(false);
            panel96.ResumeLayout(false);
            panel97.ResumeLayout(false);
            panel98.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((ISupportInitialize)(pictureBox2)).EndInit();
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox4)).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            userInfoTabPage.userInfoValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox3)).EndInit();
            panel5.ResumeLayout(false);
            ((ISupportInitialize)(userInfoTabPage.userInfoBackgroundColorPictureBox)).EndInit();
            panel6.ResumeLayout(false);
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontColorPictureBox)).EndInit();
            panel7.ResumeLayout(false);
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox)).EndInit();
            userInfoTabPage.userInfoValuesOutlinePanel.ResumeLayout(false);
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown)).EndInit();
            panel50.ResumeLayout(false);
            panel119.ResumeLayout(false);
            panel117.ResumeLayout(false);
            panel118.ResumeLayout(false);
            panel116.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox8)).EndInit();
            panel29.ResumeLayout(false);
            panel49.ResumeLayout(false);
            panel49.PerformLayout();
            panel48.ResumeLayout(false);
            panel48.PerformLayout();
            panel30.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox7)).EndInit();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            panel34.ResumeLayout(false);
            panel34.PerformLayout();
            panel35.ResumeLayout(false);
            panel35.PerformLayout();
            panel42.ResumeLayout(false);
            panel42.PerformLayout();
            gameInfoTabPage.gameInfoValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox9)).EndInit();
            panel44.ResumeLayout(false);
            ((ISupportInitialize)(gameInfoTabPage.gameInfoBackgroundColorPictureBox)).EndInit();
            panel45.ResumeLayout(false);
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontColorPictureBox)).EndInit();
            panel46.ResumeLayout(false);
            panel46.PerformLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox)).EndInit();
            gameInfoTabPage.gameInfoValuesOutlinePanel.ResumeLayout(false);
            gameInfoTabPage.gameInfoValuesOutlinePanel.PerformLayout();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown)).EndInit();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressPercentCompletePictureBox)).EndInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressMasteryPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox21)).EndInit();
            ((ISupportInitialize)(pictureBox5)).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            gameProgressTabPage.gameProgressValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox6)).EndInit();
            panel18.ResumeLayout(false);
            ((ISupportInitialize)(gameProgressTabPage.gameProgressBackgroundColorPictureBox)).EndInit();
            panel19.ResumeLayout(false);
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontColorPictureBox)).EndInit();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox)).EndInit();
            gameProgressTabPage.gameProgressValuesOutlinePanel.ResumeLayout(false);
            gameProgressTabPage.gameProgressValuesOutlinePanel.PerformLayout();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown)).EndInit();
            panel36.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel37.ResumeLayout(false);
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            ((ISupportInitialize)(pictureBox17)).EndInit();
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel39.ResumeLayout(false);
            panel39.PerformLayout();
            panel40.ResumeLayout(false);
            panel40.PerformLayout();
            panel41.ResumeLayout(false);
            panel41.PerformLayout();
            panel113.ResumeLayout(false);
            panel113.PerformLayout();
            ((ISupportInitialize)(pictureBox15)).EndInit();
            panel99.ResumeLayout(false);
            panel99.PerformLayout();
            recentAchievementsTabPage.recentAchievementsLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineColorPictureBox)).EndInit();
            panel101.ResumeLayout(false);
            panel101.PerformLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox)).EndInit();
            recentAchievementsTabPage.recentAchievementsPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox)).EndInit();
            panel103.ResumeLayout(false);
            panel103.PerformLayout();
            panel104.ResumeLayout(false);
            panel104.PerformLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox)).EndInit();
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.ResumeLayout(false);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown)).EndInit();
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(pictureBox23)).EndInit();
            panel107.ResumeLayout(false);
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox)).EndInit();
            panel108.ResumeLayout(false);
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox)).EndInit();
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.ResumeLayout(false);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox)).EndInit();
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.ResumeLayout(false);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown)).EndInit();
            panel115.ResumeLayout(false);
            panel115.PerformLayout();
            ((ISupportInitialize)(pictureBox18)).EndInit();
            panel111.ResumeLayout(false);
            panel111.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeXUpDown)).EndInit();
            ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeYUpDown)).EndInit();
            panel112.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox16)).EndInit();
            panel114.ResumeLayout(false);
            ((ISupportInitialize)(achievementsListTabPage.achievementListBackgroundColorPictureBox)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel120.ResumeLayout(false);
            panel120.PerformLayout();
            ((ISupportInitialize)(pictureBox19)).EndInit();
            panel121.ResumeLayout(false);
            panel121.PerformLayout();
            panel122.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox22)).EndInit();
            panel123.ResumeLayout(false);
            ((ISupportInitialize)(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox)).EndInit();
            panel124.ResumeLayout(false);
            panel124.PerformLayout();
            ((ISupportInitialize)(relatedMediaTabPage.relatedMediaLBLinePictureBox)).EndInit();
            mainTabControl.ResumeLayout(false);
            focusTabPage.ResumeLayout(false);
            alertsTabPage.ResumeLayout(false);
            alertTabControl.ResumeLayout(false);
            achievementTabPage.ResumeLayout(false);
            achievementTabPage.PerformLayout();
            masteryTabPage.ResumeLayout(false);
            masteryTabPage.PerformLayout();
            userInfoTabPage.ResumeLayout(false);
            gameInfoTabPage.ResumeLayout(false);
            gameProgressTabPage.ResumeLayout(false);
            recentAchievementsTabPage.ResumeLayout(false);
            achievementsListTabPage.ResumeLayout(false);
            relatedMediaTabPage.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}

