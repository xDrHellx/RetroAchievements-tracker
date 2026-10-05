using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Retro_Achievement_Tracker
{
    partial class MainWindow
    {
        /// <summary>Required designer variable.</summary>
        private IContainer components = null;

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
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
            this.apiKeyLabel = new Label();
            this.apiKeyTextBox = new TextBox();
            this.usernameLabel = new Label();
            this.usernameTextBox = new TextBox();
            this.userProfilePictureBox = new PictureBox();
            this.autoStartCheckbox = new CheckBox();
            this.stopButton = new Button();
            this.autoPollingStatusLabel = new Label();
            this.userInfoAutoOpenWindowCheckbox = new CheckBox();
            this.userInfoOpenWindowButton = new Button();
            this.startButton = new Button();
            this.focusAchievementPictureBox = new PictureBox();
            this.focusAchievementTitleLabel = new Label();
            this.focusAchievementDescriptionLabel = new Label();
            this.focusSetButton = new Button();
            this.focusAchievementButtonPrevious = new Button();
            this.focusAchievementButtonNext = new Button();
            this.gameInfoPictureBox = new PictureBox();
            this.autoPollingStatusPictureBox = new PictureBox();
            this.alertsPlayAchievementButton = new Button();
            this.alertsSelectCustomAchievementFileButton = new Button();
            this.alertsCustomAchievementScaleNumericUpDown = new NumericUpDown();
            this.alertsCustomAchievementXNumericUpDown = new NumericUpDown();
            this.alertsCustomAchievementYNumericUpDown = new NumericUpDown();
            this.alertsAchievementEditOutlineCheckbox = new CheckBox();
            this.alertsCustomAchievementOutNumericUpDown = new NumericUpDown();
            this.alertsCustomAchievementAnimationOutComboBox = new ComboBox();
            this.alertsCustomAchievementOutSpeedUpDown = new NumericUpDown();
            this.alertsCustomAchievementInNumericUpDown = new NumericUpDown();
            this.alertsCustomAchievementAnimationInComboBox = new ComboBox();
            this.alertsCustomAchievementInSpeedUpDown = new NumericUpDown();
            this.alertsCustomAchievementEnableCheckbox = new CheckBox();
            this.alertsPlayMasteryButton = new Button();
            this.alertsSelectCustomMasteryFileButton = new Button();
            this.alertsCustomMasteryScaleNumericUpDown = new NumericUpDown();
            this.alertsCustomMasteryXNumericUpDown = new NumericUpDown();
            this.alertsCustomMasteryYNumericUpDown = new NumericUpDown();
            this.alertsMasteryEditOutlineCheckbox = new CheckBox();
            this.alertsCustomMasteryOutNumericUpDown = new NumericUpDown();
            this.alertsCustomMasteryAnimationOutComboBox = new ComboBox();
            this.alertsCustomMasteryOutSpeedUpDown = new NumericUpDown();
            this.alertsCustomMasteryInNumericUpDown = new NumericUpDown();
            this.alertsCustomMasteryAnimationInComboBox = new ComboBox();
            this.alertsCustomMasteryInSpeedUpDown = new NumericUpDown();
            this.alertsCustomMasteryEnableCheckbox = new CheckBox();
            this.userInfoTruePointsTextBox = new TextBox();
            this.userInfoPointsTextBox = new TextBox();
            this.userInfoRatioTextBox = new TextBox();
            this.userInfoRankTextBox = new TextBox();
            this.userInfoTruePointsCheckBox = new CheckBox();
            this.userInfoRatioCheckBox = new CheckBox();
            this.userInfoPointsCheckBox = new CheckBox();
            this.userInfoDefaultButton = new Button();
            this.userInfoRankCheckBox = new CheckBox();
            this.openFileDialog1 = new OpenFileDialog();
            this.colorDialog1 = new ColorDialog();
            this.focusBehaviorGoToLastRadioButton = new RadioButton();
            this.focusBehaviorGoToNextRadioButton = new RadioButton();
            this.focusBehaviorGoToPreviousRadioButton = new RadioButton();
            this.focusBehaviorGoToFirstRadioButton = new RadioButton();
            this.recentAchievementsMaxListLabel = new Label();
            this.recentAchievementsMaxListNumericUpDown = new NumericUpDown();
            this.panel64 = new Panel();
            this.label112 = new Label();
            this.pictureBox12 = new PictureBox();
            this.panel63 = new Panel();
            this.unlockAchievementButton = new Button();
            this.label111 = new Label();
            this.pictureBox10 = new PictureBox();
            this.panel51 = new Panel();
            this.focusLinePanel = new Panel();
            this.label106 = new Label();
            this.focusLineColorPictureBox = new PictureBox();
            this.label96 = new Label();
            this.panel59 = new Panel();
            this.focusBorderCheckBox = new CheckBox();
            this.focusBorderColorPictureBox = new PictureBox();
            this.label107 = new Label();
            this.focusPointsPanel = new Panel();
            this.label108 = new Label();
            this.focusPointsFontColorPictureBox = new PictureBox();
            this.focusPointsFontComboBox = new ComboBox();
            this.panel52 = new Panel();
            this.focusAdvancedCheckBox = new CheckBox();
            this.label97 = new Label();
            this.label98 = new Label();
            this.label99 = new Label();
            this.label100 = new Label();
            this.panel61 = new Panel();
            this.focusTitleFontOutlineNumericUpDown = new NumericUpDown();
            this.focusTitleOutlineCheckBox = new CheckBox();
            this.focusTitleOutlineLabel = new Label();
            this.focusTitleFontOutlineColorPictureBox = new PictureBox();
            this.focusOpenWindowButton = new Button();
            this.focusDescriptionOutlinePanel = new Panel();
            this.label110 = new Label();
            this.focusDescriptionFontOutlineColorPictureBox = new PictureBox();
            this.focusDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            this.focusDescriptionOutlineCheckBox = new CheckBox();
            this.focusDescriptionPanel = new Panel();
            this.label101 = new Label();
            this.focusDescriptionFontColorPictureBox = new PictureBox();
            this.focusDescriptionFontComboBox = new ComboBox();
            this.focusAutoOpenWindowCheckBox = new CheckBox();
            this.pictureBox11 = new PictureBox();
            this.panel54 = new Panel();
            this.focusBackgroundColorPictureBox = new PictureBox();
            this.label102 = new Label();
            this.panel55 = new Panel();
            this.focusTitleLabel = new Label();
            this.focusTitleFontColorPictureBox = new PictureBox();
            this.focusTitleFontComboBox = new ComboBox();
            this.focusPointsOutlinePanel = new Panel();
            this.focusPointsFontOutlineNumericUpDown = new NumericUpDown();
            this.focusPointsOutlineCheckBox = new CheckBox();
            this.label104 = new Label();
            this.focusPointsFontOutlineColorPictureBox = new PictureBox();
            this.focusLineOutlinePanel = new Panel();
            this.label105 = new Label();
            this.focusLineOutlineColorPictureBox = new PictureBox();
            this.focusLineOutlineNumericUpDown = new NumericUpDown();
            this.focusLineOutlineCheckBox = new CheckBox();
            this.panel65 = new Panel();
            this.alertsLinePanel = new Panel();
            this.label113 = new Label();
            this.alertsLineColorPictureBox = new PictureBox();
            this.label114 = new Label();
            this.panel67 = new Panel();
            this.alertsBorderCheckBox = new CheckBox();
            this.alertsBorderColorPictureBox = new PictureBox();
            this.label115 = new Label();
            this.alertsPointsPanel = new Panel();
            this.label116 = new Label();
            this.alertsPointsFontColorPictureBox = new PictureBox();
            this.alertsPointsFontComboBox = new ComboBox();
            this.panel69 = new Panel();
            this.alertsAdvancedCheckBox = new CheckBox();
            this.label117 = new Label();
            this.label118 = new Label();
            this.label119 = new Label();
            this.label120 = new Label();
            this.panel70 = new Panel();
            this.alertsTitleFontOutlineNumericUpDown = new NumericUpDown();
            this.alertsTitleOutlineCheckBox = new CheckBox();
            this.alertsTitleOutlineLabel = new Label();
            this.alertsTitleFontOutlineColorPictureBox = new PictureBox();
            this.alertsOpenWindowButton = new Button();
            this.alertsDescriptionOutlinePanel = new Panel();
            this.label122 = new Label();
            this.alertsDescriptionFontOutlineColorPictureBox = new PictureBox();
            this.alertsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            this.alertsDescriptionOutlineCheckBox = new CheckBox();
            this.alertsDescriptionPanel = new Panel();
            this.label123 = new Label();
            this.alertsDescriptionFontColorPictureBox = new PictureBox();
            this.alertsDescriptionFontComboBox = new ComboBox();
            this.alertsAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox20 = new PictureBox();
            this.panel73 = new Panel();
            this.alertsBackgroundColorPictureBox = new PictureBox();
            this.label124 = new Label();
            this.panel74 = new Panel();
            this.alertsTitleLabel = new Label();
            this.alertsTitleFontColorPictureBox = new PictureBox();
            this.alertsTitleFontComboBox = new ComboBox();
            this.alertsPointsOutlinePanel = new Panel();
            this.alertsPointsFontOutlineNumericUpDown = new NumericUpDown();
            this.alertsPointsOutlineCheckBox = new CheckBox();
            this.label126 = new Label();
            this.alertsPointsFontOutlineColorPictureBox = new PictureBox();
            this.alertsLineOutlinePanel = new Panel();
            this.label127 = new Label();
            this.alertsLineOutlineColorPictureBox = new PictureBox();
            this.alertsLineOutlineNumericUpDown = new NumericUpDown();
            this.alertsLineOutlineCheckBox = new CheckBox();
            this.alertsCustomAchievementPanel = new Panel();
            this.panel85 = new Panel();
            this.label136 = new Label();
            this.panel84 = new Panel();
            this.label135 = new Label();
            this.panel86 = new Panel();
            this.label137 = new Label();
            this.panel83 = new Panel();
            this.label129 = new Label();
            this.panel87 = new Panel();
            this.label138 = new Label();
            this.panel78 = new Panel();
            this.label42 = new Label();
            this.label128 = new Label();
            this.label130 = new Label();
            this.pictureBox13 = new PictureBox();
            this.panel79 = new Panel();
            this.label131 = new Label();
            this.panel80 = new Panel();
            this.label132 = new Label();
            this.panel81 = new Panel();
            this.label133 = new Label();
            this.panel82 = new Panel();
            this.label134 = new Label();
            this.alertsAchievementEnableCheckbox = new CheckBox();
            this.alertsCustomMasteryPanel = new Panel();
            this.panel89 = new Panel();
            this.label6 = new Label();
            this.panel90 = new Panel();
            this.label7 = new Label();
            this.panel91 = new Panel();
            this.label8 = new Label();
            this.panel92 = new Panel();
            this.label11 = new Label();
            this.panel93 = new Panel();
            this.label12 = new Label();
            this.panel94 = new Panel();
            this.label13 = new Label();
            this.label14 = new Label();
            this.label139 = new Label();
            this.pictureBox14 = new PictureBox();
            this.panel95 = new Panel();
            this.label140 = new Label();
            this.panel96 = new Panel();
            this.label141 = new Label();
            this.panel97 = new Panel();
            this.label142 = new Label();
            this.panel98 = new Panel();
            this.label143 = new Label();
            this.alertsMasteryEnableCheckbox = new CheckBox();
            this.panel14 = new Panel();
            this.userInfoUsernameLabel = new Label();
            this.userInfoRankLabel = new Label();
            this.userInfoPointsLabel = new Label();
            this.label37 = new Label();
            this.userInfoTruePointsLabel = new Label();
            this.userInfoMottoLabel = new Label();
            this.userInfoRatioLabel = new Label();
            this.pictureBox2 = new PictureBox();
            this.panel21 = new Panel();
            this.panel22 = new Panel();
            this.label29 = new Label();
            this.label32 = new Label();
            this.label30 = new Label();
            this.label28 = new Label();
            this.pictureBox4 = new PictureBox();
            this.panel10 = new Panel();
            this.label31 = new Label();
            this.panel13 = new Panel();
            this.label35 = new Label();
            this.panel12 = new Panel();
            this.label34 = new Label();
            this.panel11 = new Panel();
            this.label33 = new Label();
            this.panel20 = new Panel();
            this.label2 = new Label();
            this.panel4 = new Panel();
            this.userInfoAdvancedCheckBox = new CheckBox();
            this.label4 = new Label();
            this.label9 = new Label();
            this.label25 = new Label();
            this.label15 = new Label();
            this.userInfoValuesPanel = new Panel();
            this.label26 = new Label();
            this.userInfoValuesFontColorPictureBox = new PictureBox();
            this.userInfoValuesFontComboBox = new ComboBox();
            this.pictureBox3 = new PictureBox();
            this.panel5 = new Panel();
            this.userInfoBackgroundColorPictureBox = new PictureBox();
            this.label3 = new Label();
            this.panel6 = new Panel();
            this.userInfoNamesLabel = new Label();
            this.userInfoNamesFontColorPictureBox = new PictureBox();
            this.userInfoNamesFontComboBox = new ComboBox();
            this.panel7 = new Panel();
            this.userInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            this.userInfoNamesOutlineCheckBox = new CheckBox();
            this.userInfoNamesOutlineLabel = new Label();
            this.userInfoNamesFontOutlineColorPictureBox = new PictureBox();
            this.userInfoValuesOutlinePanel = new Panel();
            this.label27 = new Label();
            this.userInfoValuesFontOutlineColorPictureBox = new PictureBox();
            this.userInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            this.userInfoValuesOutlineCheckBox = new CheckBox();
            this.panel50 = new Panel();
            this.panel119 = new Panel();
            this.gameInfoGenreLabel = new Label();
            this.label62 = new Label();
            this.label36 = new Label();
            this.panel117 = new Panel();
            this.label89 = new Label();
            this.gameInfoReleasedLabel = new Label();
            this.panel118 = new Panel();
            this.label61 = new Label();
            this.gameInfoPublisherLabel = new Label();
            this.panel116 = new Panel();
            this.label57 = new Label();
            this.gameInfoDeveloperLabel = new Label();
            this.gameInfoTitleLabel = new Label();
            this.pictureBox8 = new PictureBox();
            this.panel29 = new Panel();
            this.panel49 = new Panel();
            this.label88 = new Label();
            this.gameInfoReleasedCheckBox = new CheckBox();
            this.gameInfoReleaseDateTextBox = new TextBox();
            this.panel48 = new Panel();
            this.label87 = new Label();
            this.gameInfoGenreCheckBox = new CheckBox();
            this.gameInfoGenreTextBox = new TextBox();
            this.panel30 = new Panel();
            this.label63 = new Label();
            this.label64 = new Label();
            this.label65 = new Label();
            this.label66 = new Label();
            this.gameInfoDefaultButton = new Button();
            this.pictureBox7 = new PictureBox();
            this.panel31 = new Panel();
            this.label67 = new Label();
            this.gameInfoTitleCheckBox = new CheckBox();
            this.gameInfoTitleTextBox = new TextBox();
            this.panel32 = new Panel();
            this.label68 = new Label();
            this.gameInfoConsoleCheckBox = new CheckBox();
            this.gameInfoConsoleTextBox = new TextBox();
            this.panel33 = new Panel();
            this.label69 = new Label();
            this.gameInfoPublisherTextBox = new TextBox();
            this.gameInfoPublisherCheckBox = new CheckBox();
            this.panel34 = new Panel();
            this.label70 = new Label();
            this.gameInfoDeveloperTextBox = new TextBox();
            this.gameInfoDeveloperCheckBox = new CheckBox();
            this.panel35 = new Panel();
            this.label71 = new Label();
            this.panel42 = new Panel();
            this.gameInfoAdvancedCheckBox = new CheckBox();
            this.label78 = new Label();
            this.label79 = new Label();
            this.label80 = new Label();
            this.label81 = new Label();
            this.gameInfoOpenWindowButton = new Button();
            this.gameInfoValuesPanel = new Panel();
            this.label82 = new Label();
            this.gameInfoValuesFontColorPictureBox = new PictureBox();
            this.gameInfoValuesFontComboBox = new ComboBox();
            this.gameInfoAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox9 = new PictureBox();
            this.panel44 = new Panel();
            this.gameInfoBackgroundColorPictureBox = new PictureBox();
            this.label83 = new Label();
            this.panel45 = new Panel();
            this.gameInfoNamesLabel = new Label();
            this.gameInfoNamesFontColorPictureBox = new PictureBox();
            this.gameInfoNamesFontComboBox = new ComboBox();
            this.panel46 = new Panel();
            this.gameInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            this.gameInfoNamesOutlineCheckBox = new CheckBox();
            this.gameInfoNamesOutlineLabel = new Label();
            this.gameInfoNamesFontOutlineColorPictureBox = new PictureBox();
            this.gameInfoValuesOutlinePanel = new Panel();
            this.label86 = new Label();
            this.gameInfoValuesFontOutlineColorPictureBox = new PictureBox();
            this.gameInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            this.gameInfoValuesOutlineCheckBox = new CheckBox();
            this.panel28 = new Panel();
            this.gameProgressPointsTextLabel = new Label();
            this.gameProgressHardcoreWorthLabel = new Label();
            this.gameProgressPoints2Label = new Label();
            this.gameProgressTruePoints2Label = new Label();
            this.gameProgressAchievements2Label = new Label();
            this.gameProgressHaveEarnedLabel = new Label();
            this.gameProgressPercentCompletePictureBox = new PictureBox();
            this.gameProgressMasteryPictureBox = new PictureBox();
            this.pictureBox21 = new PictureBox();
            this.label60 = new Label();
            this.label59 = new Label();
            this.label58 = new Label();
            this.label56 = new Label();
            this.pictureBox5 = new PictureBox();
            this.gameProgressAchievements1Label = new Label();
            this.gameProgressPoints1Label = new Label();
            this.gameProgressCompletedLabel = new Label();
            this.gameProgressTruePoints1Label = new Label();
            this.panel15 = new Panel();
            this.label38 = new Label();
            this.panel16 = new Panel();
            this.gameProgressAdvancedCheckBox = new CheckBox();
            this.label41 = new Label();
            this.label43 = new Label();
            this.label44 = new Label();
            this.label45 = new Label();
            this.gameProgressOpenWindowButton = new Button();
            this.gameProgressValuesPanel = new Panel();
            this.label46 = new Label();
            this.gameProgressValuesFontColorPictureBox = new PictureBox();
            this.gameProgressValuesFontComboBox = new ComboBox();
            this.gameProgressAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox6 = new PictureBox();
            this.panel18 = new Panel();
            this.gameProgressBackgroundColorPictureBox = new PictureBox();
            this.label47 = new Label();
            this.panel19 = new Panel();
            this.gameProgressNamesLabel = new Label();
            this.gameProgressNamesFontColorPictureBox = new PictureBox();
            this.gameProgressNamesFontComboBox = new ComboBox();
            this.panel23 = new Panel();
            this.gameProgressNamesFontOutlineNumericUpDown = new NumericUpDown();
            this.gameProgressNamesOutlineCheckBox = new CheckBox();
            this.gameProgressNamesOutlineLabel = new Label();
            this.gameProgressNamesFontOutlineColorPictureBox = new PictureBox();
            this.gameProgressValuesOutlinePanel = new Panel();
            this.label50 = new Label();
            this.gameProgressValuesFontOutlineColorPictureBox = new PictureBox();
            this.gameProgressValuesFontOutlineNumericUpDown = new NumericUpDown();
            this.gameProgressValuesOutlineCheckBox = new CheckBox();
            this.panel36 = new Panel();
            this.panel27 = new Panel();
            this.label55 = new Label();
            this.gameProgressRadioButtonPeriod = new RadioButton();
            this.label54 = new Label();
            this.gameProgressRadioButtonColon = new RadioButton();
            this.label53 = new Label();
            this.gameProgressRadioButtonBackslash = new RadioButton();
            this.label51 = new Label();
            this.panel25 = new Panel();
            this.panel37 = new Panel();
            this.label39 = new Label();
            this.label40 = new Label();
            this.label72 = new Label();
            this.panel26 = new Panel();
            this.label52 = new Label();
            this.gameProgressCompletedTextBox = new TextBox();
            this.gameProgressCompletedCheckBox = new CheckBox();
            this.label73 = new Label();
            this.gameProgressDefaultButton = new Button();
            this.pictureBox17 = new PictureBox();
            this.panel38 = new Panel();
            this.label74 = new Label();
            this.gameProgressAchievementsCheckBox = new CheckBox();
            this.gameProgressAchievementsTextBox = new TextBox();
            this.panel39 = new Panel();
            this.label75 = new Label();
            this.gameProgressRatioCheckBox = new CheckBox();
            this.gameProgressRatioTextBox = new TextBox();
            this.panel40 = new Panel();
            this.label76 = new Label();
            this.gameProgressTruePointsTextBox = new TextBox();
            this.gameProgressTruePointsCheckBox = new CheckBox();
            this.panel41 = new Panel();
            this.label77 = new Label();
            this.gameProgressPointsTextBox = new TextBox();
            this.gameProgressPointsCheckBox = new CheckBox();
            this.panel113 = new Panel();
            this.label155 = new Label();
            this.pictureBox15 = new PictureBox();
            this.recentAchievementsAutoScrollCheckBox = new CheckBox();
            this.panel99 = new Panel();
            this.recentAchievementsLinePanel = new Panel();
            this.label16 = new Label();
            this.recentAchievementsLineColorPictureBox = new PictureBox();
            this.label17 = new Label();
            this.panel101 = new Panel();
            this.recentAchievementsBorderCheckBox = new CheckBox();
            this.recentAchievementsBorderColorPictureBox = new PictureBox();
            this.label18 = new Label();
            this.recentAchievementsPointsPanel = new Panel();
            this.label19 = new Label();
            this.recentAchievementsPointsFontColorPictureBox = new PictureBox();
            this.recentAchievementsPointsFontComboBox = new ComboBox();
            this.panel103 = new Panel();
            this.recentAchievementsAdvancedCheckBox = new CheckBox();
            this.label20 = new Label();
            this.label21 = new Label();
            this.label22 = new Label();
            this.label23 = new Label();
            this.panel104 = new Panel();
            this.recentAchievementsTitleFontOutlineNumericUpDown = new NumericUpDown();
            this.recentAchievementsTitleFontOutlineCheckBox = new CheckBox();
            this.recentAchievementsTitleOutlineLabel = new Label();
            this.recentAchievementsTitleFontOutlineColorPictureBox = new PictureBox();
            this.recentAchievementsOpenWindowButton = new Button();
            this.recentAchievementsDescriptionOutlinePanel = new Panel();
            this.label144 = new Label();
            this.recentAchievementsDateFontOutlineColorPictureBox = new PictureBox();
            this.recentAchievementsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            this.recentAchievementsDateFontOutlineCheckBox = new CheckBox();
            this.recentAchievementsDescriptionPanel = new Panel();
            this.label145 = new Label();
            this.recentAchievementsDateFontColorPictureBox = new PictureBox();
            this.recentAchievementsDescriptionFontComboBox = new ComboBox();
            this.recentAchievementsAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox23 = new PictureBox();
            this.panel107 = new Panel();
            this.recentAchievementsBackgroundColorPictureBox = new PictureBox();
            this.label146 = new Label();
            this.panel108 = new Panel();
            this.recentAchievementsTitleLabel = new Label();
            this.recentAchievementsTitleFontColorPictureBox = new PictureBox();
            this.recentAchievementsTitleFontComboBox = new ComboBox();
            this.recentAchievementsPointsOutlinePanel = new Panel();
            this.recentAchievementsPointsFontOutlineNumericUpDown = new NumericUpDown();
            this.recentAchievementsPointsFontOutlineCheckBox = new CheckBox();
            this.label148 = new Label();
            this.recentAchievementsPointsFontOutlineColorPictureBox = new PictureBox();
            this.recentAchievementsLineOutlinePanel = new Panel();
            this.label149 = new Label();
            this.recentAchievementsLineOutlineColorPictureBox = new PictureBox();
            this.recentAchievementsLineOutlineNumericUpDown = new NumericUpDown();
            this.recentAchievementsLineOutlineCheckBox = new CheckBox();
            this.panel115 = new Panel();
            this.label152 = new Label();
            this.pictureBox18 = new PictureBox();
            this.achievementListAutoScrollCheckBox = new CheckBox();
            this.panel111 = new Panel();
            this.panel9 = new Panel();
            this.achievementListWindowSizeLabel = new Label();
            this.achievementListWindowSizeXUpDown = new NumericUpDown();
            this.achievementListWindowSizeYUpDown = new NumericUpDown();
            this.label150 = new Label();
            this.panel112 = new Panel();
            this.label151 = new Label();
            this.achievementListOpenWindowButton = new Button();
            this.achievementListAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox16 = new PictureBox();
            this.panel114 = new Panel();
            this.achievementListBackgroundColorPictureBox = new PictureBox();
            this.label156 = new Label();
            this.panel1 = new Panel();
            this.checkForUpdatesButton = new Button();
            this.panel3 = new Panel();
            this.panel2 = new Panel();
            this.panel120 = new Panel();
            this.relatedMediaRAScreenshotRadioButton = new RadioButton();
            this.relatedMediaRABadgeIconRadioButton = new RadioButton();
            this.relatedMediaRABoxArtRadioButton = new RadioButton();
            this.relatedMediaRATitleScreenRadioButton = new RadioButton();
            this.pictureBox19 = new PictureBox();
            this.label1 = new Label();
            this.panel121 = new Panel();
            this.label90 = new Label();
            this.panel122 = new Panel();
            this.label91 = new Label();
            this.relatedMediaOpenWindowButton = new Button();
            this.relatedMediaAutoOpenWindowCheckbox = new CheckBox();
            this.pictureBox22 = new PictureBox();
            this.panel123 = new Panel();
            this.relatedMediaBackgroundColorPictureBox = new PictureBox();
            this.label92 = new Label();
            this.panel124 = new Panel();
            this.relatedMediaLBCartFrontRadioButton = new RadioButton();
            this.relatedMediaLBCartBackRadioButton = new RadioButton();
            this.relatedMediaLBBoxBackReconRadioButton = new RadioButton();
            this.relatedMediaLBBoxFullRadioButton = new RadioButton();
            this.relatedMediaLBBoxSpineRadioButton = new RadioButton();
            this.relatedMediaLBClearLogoRadioButton = new RadioButton();
            this.relatedMediaLBBannerRadioButton = new RadioButton();
            this.relatedMediaLBTitleScreenRadioButton = new RadioButton();
            this.relatedMediaSetLaunchBoxPathButton = new Button();
            this.relatedMediaLBBoxFrontReconRadioButton = new RadioButton();
            this.relatedMediaLBBoxFrontRadioButton = new RadioButton();
            this.relatedMediaLBBoxBackRadioButton = new RadioButton();
            this.relatedMediaLBBox3DRadioButton = new RadioButton();
            this.relatedMediaLBLinePictureBox = new PictureBox();
            this.relatedMediaLBLabel = new Label();
            this.mainTabControl = new TabControl();
            this.focusTabPage = new TabPage();
            this.alertsTabPage2 = new TabPage();
            this.alertTabControl = new TabControl();
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.userInfoTabPage = new TabPage();
            this.gameInfoTabPage = new TabPage();
            this.gameProgressTabPage = new TabPage();
            this.recentCheevosTabPage = new TabPage();
            this.cheevosListTabPage = new TabPage();
            this.relatedMediaTabPage = new TabPage();
            this.manualSearchLabel = new Label();
            this.manualSearchTextBox = new TextBox();
            this.manualSearchButton = new Button();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.panel8 = new Panel();
            ((ISupportInitialize)(this.userProfilePictureBox)).BeginInit();
            ((ISupportInitialize)(this.focusAchievementPictureBox)).BeginInit();
            ((ISupportInitialize)(this.gameInfoPictureBox)).BeginInit();
            ((ISupportInitialize)(this.autoPollingStatusPictureBox)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementScaleNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementXNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementYNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementOutNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementOutSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementInNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomAchievementInSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryScaleNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryXNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryYNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryOutNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryOutSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryInNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsCustomMasteryInSpeedUpDown)).BeginInit();
            ((ISupportInitialize)(this.recentAchievementsMaxListNumericUpDown)).BeginInit();
            this.panel64.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel63.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel51.SuspendLayout();
            this.focusLinePanel.SuspendLayout();
            ((ISupportInitialize)(this.focusLineColorPictureBox)).BeginInit();
            this.panel59.SuspendLayout();
            ((ISupportInitialize)(this.focusBorderColorPictureBox)).BeginInit();
            this.focusPointsPanel.SuspendLayout();
            ((ISupportInitialize)(this.focusPointsFontColorPictureBox)).BeginInit();
            this.panel52.SuspendLayout();
            this.panel61.SuspendLayout();
            ((ISupportInitialize)(this.focusTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.focusTitleFontOutlineColorPictureBox)).BeginInit();
            this.focusDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.focusDescriptionFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.focusDescriptionFontOutlineNumericUpDown)).BeginInit();
            this.focusDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(this.focusDescriptionFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel54.SuspendLayout();
            ((ISupportInitialize)(this.focusBackgroundColorPictureBox)).BeginInit();
            this.panel55.SuspendLayout();
            ((ISupportInitialize)(this.focusTitleFontColorPictureBox)).BeginInit();
            this.focusPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.focusPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.focusPointsFontOutlineColorPictureBox)).BeginInit();
            this.focusLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.focusLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.focusLineOutlineNumericUpDown)).BeginInit();
            this.panel65.SuspendLayout();
            this.alertsLinePanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsLineColorPictureBox)).BeginInit();
            this.panel67.SuspendLayout();
            ((ISupportInitialize)(this.alertsBorderColorPictureBox)).BeginInit();
            this.alertsPointsPanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsPointsFontColorPictureBox)).BeginInit();
            this.panel69.SuspendLayout();
            this.panel70.SuspendLayout();
            ((ISupportInitialize)(this.alertsTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsTitleFontOutlineColorPictureBox)).BeginInit();
            this.alertsDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsDescriptionFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.alertsDescriptionFontOutlineNumericUpDown)).BeginInit();
            this.alertsDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsDescriptionFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.panel73.SuspendLayout();
            ((ISupportInitialize)(this.alertsBackgroundColorPictureBox)).BeginInit();
            this.panel74.SuspendLayout();
            ((ISupportInitialize)(this.alertsTitleFontColorPictureBox)).BeginInit();
            this.alertsPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.alertsPointsFontOutlineColorPictureBox)).BeginInit();
            this.alertsLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.alertsLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.alertsLineOutlineNumericUpDown)).BeginInit();
            this.alertsCustomAchievementPanel.SuspendLayout();
            this.panel85.SuspendLayout();
            this.panel84.SuspendLayout();
            this.panel86.SuspendLayout();
            this.panel83.SuspendLayout();
            this.panel87.SuspendLayout();
            this.panel78.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel79.SuspendLayout();
            this.panel80.SuspendLayout();
            this.panel81.SuspendLayout();
            this.panel82.SuspendLayout();
            this.alertsCustomMasteryPanel.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel90.SuspendLayout();
            this.panel91.SuspendLayout();
            this.panel92.SuspendLayout();
            this.panel93.SuspendLayout();
            this.panel94.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.panel95.SuspendLayout();
            this.panel96.SuspendLayout();
            this.panel97.SuspendLayout();
            this.panel98.SuspendLayout();
            this.panel14.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel4.SuspendLayout();
            this.userInfoValuesPanel.SuspendLayout();
            ((ISupportInitialize)(this.userInfoValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((ISupportInitialize)(this.userInfoBackgroundColorPictureBox)).BeginInit();
            this.panel6.SuspendLayout();
            ((ISupportInitialize)(this.userInfoNamesFontColorPictureBox)).BeginInit();
            this.panel7.SuspendLayout();
            ((ISupportInitialize)(this.userInfoNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.userInfoNamesFontOutlineColorPictureBox)).BeginInit();
            this.userInfoValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.userInfoValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.userInfoValuesFontOutlineNumericUpDown)).BeginInit();
            this.panel50.SuspendLayout();
            this.panel119.SuspendLayout();
            this.panel117.SuspendLayout();
            this.panel118.SuspendLayout();
            this.panel116.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel29.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel30.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel42.SuspendLayout();
            this.gameInfoValuesPanel.SuspendLayout();
            ((ISupportInitialize)(this.gameInfoValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel44.SuspendLayout();
            ((ISupportInitialize)(this.gameInfoBackgroundColorPictureBox)).BeginInit();
            this.panel45.SuspendLayout();
            ((ISupportInitialize)(this.gameInfoNamesFontColorPictureBox)).BeginInit();
            this.panel46.SuspendLayout();
            ((ISupportInitialize)(this.gameInfoNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.gameInfoNamesFontOutlineColorPictureBox)).BeginInit();
            this.gameInfoValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.gameInfoValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.gameInfoValuesFontOutlineNumericUpDown)).BeginInit();
            this.panel28.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressPercentCompletePictureBox)).BeginInit();
            ((ISupportInitialize)(this.gameProgressMasteryPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.gameProgressValuesPanel.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressValuesFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel18.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressBackgroundColorPictureBox)).BeginInit();
            this.panel19.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressNamesFontColorPictureBox)).BeginInit();
            this.panel23.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressNamesFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.gameProgressNamesFontOutlineColorPictureBox)).BeginInit();
            this.gameProgressValuesOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.gameProgressValuesFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.gameProgressValuesFontOutlineNumericUpDown)).BeginInit();
            this.panel36.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel26.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel113.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.panel99.SuspendLayout();
            this.recentAchievementsLinePanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsLineColorPictureBox)).BeginInit();
            this.panel101.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsBorderColorPictureBox)).BeginInit();
            this.recentAchievementsPointsPanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsPointsFontColorPictureBox)).BeginInit();
            this.panel103.SuspendLayout();
            this.panel104.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsTitleFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.recentAchievementsTitleFontOutlineColorPictureBox)).BeginInit();
            this.recentAchievementsDescriptionOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsDateFontOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.recentAchievementsDescriptionFontOutlineNumericUpDown)).BeginInit();
            this.recentAchievementsDescriptionPanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsDateFontColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.panel107.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsBackgroundColorPictureBox)).BeginInit();
            this.panel108.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsTitleFontColorPictureBox)).BeginInit();
            this.recentAchievementsPointsOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsPointsFontOutlineNumericUpDown)).BeginInit();
            ((ISupportInitialize)(this.recentAchievementsPointsFontOutlineColorPictureBox)).BeginInit();
            this.recentAchievementsLineOutlinePanel.SuspendLayout();
            ((ISupportInitialize)(this.recentAchievementsLineOutlineColorPictureBox)).BeginInit();
            ((ISupportInitialize)(this.recentAchievementsLineOutlineNumericUpDown)).BeginInit();
            this.panel115.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.panel111.SuspendLayout();
            this.panel9.SuspendLayout();
            ((ISupportInitialize)(this.achievementListWindowSizeXUpDown)).BeginInit();
            ((ISupportInitialize)(this.achievementListWindowSizeYUpDown)).BeginInit();
            this.panel112.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panel114.SuspendLayout();
            ((ISupportInitialize)(this.achievementListBackgroundColorPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel120.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.panel121.SuspendLayout();
            this.panel122.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.panel123.SuspendLayout();
            ((ISupportInitialize)(this.relatedMediaBackgroundColorPictureBox)).BeginInit();
            this.panel124.SuspendLayout();
            ((ISupportInitialize)(this.relatedMediaLBLinePictureBox)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.focusTabPage.SuspendLayout();
            this.alertsTabPage2.SuspendLayout();
            this.alertTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.userInfoTabPage.SuspendLayout();
            this.gameInfoTabPage.SuspendLayout();
            this.gameProgressTabPage.SuspendLayout();
            this.recentCheevosTabPage.SuspendLayout();
            this.cheevosListTabPage.SuspendLayout();
            this.relatedMediaTabPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.BackColor = Color.Transparent;
            this.apiKeyLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.apiKeyLabel.Location = new Point(20, 6);
            this.apiKeyLabel.Margin = new Padding(4, 0, 4, 0);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new Size(140, 25);
            this.apiKeyLabel.TabIndex = 31;
            this.apiKeyLabel.Text = "Web API Key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.apiKeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.apiKeyTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyTextBox.ForeColor = Color.White;
            this.apiKeyTextBox.Location = new Point(162, 3);
            this.apiKeyTextBox.Margin = new Padding(4, 5, 4, 5);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '*';
            this.apiKeyTextBox.Size = new Size(428, 31);
            this.apiKeyTextBox.TabIndex = 1;
            this.apiKeyTextBox.WordWrap = false;
            this.apiKeyTextBox.TextChanged += new System.EventHandler(this.RequiredField_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = Color.Transparent;
            this.usernameLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.usernameLabel.Location = new Point(50, 8);
            this.usernameLabel.Margin = new Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new Size(114, 25);
            this.usernameLabel.TabIndex = 26;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = Color.White;
            this.usernameTextBox.Location = new Point(162, 5);
            this.usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new Size(428, 31);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.WordWrap = false;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.RequiredField_TextChanged);
            // 
            // userProfilePictureBox
            // 
            this.userProfilePictureBox.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.userProfilePictureBox.BackColor = Color.Transparent;
            this.userProfilePictureBox.Cursor = Cursors.Hand;
            this.userProfilePictureBox.Location = new Point(576, 62);
            this.userProfilePictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userProfilePictureBox.Name = "userProfilePictureBox";
            this.userProfilePictureBox.Size = new Size(96, 98);
            this.userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.userProfilePictureBox.TabIndex = 20;
            this.userProfilePictureBox.TabStop = false;
            this.userProfilePictureBox.Click += new System.EventHandler(this.BrowserSensitiveControl_Click);
            // 
            // autoStartCheckbox
            // 
            this.autoStartCheckbox.AutoSize = true;
            this.autoStartCheckbox.BackColor = Color.Transparent;
            this.autoStartCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.autoStartCheckbox.FlatAppearance.BorderSize = 0;
            this.autoStartCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.autoStartCheckbox.FlatStyle = FlatStyle.Flat;
            this.autoStartCheckbox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.autoStartCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.autoStartCheckbox.Location = new Point(234, 109);
            this.autoStartCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.autoStartCheckbox.Name = "autoStartCheckbox";
            this.autoStartCheckbox.Size = new Size(125, 26);
            this.autoStartCheckbox.TabIndex = 2;
            this.autoStartCheckbox.Text = "Auto-Start";
            this.autoStartCheckbox.UseVisualStyleBackColor = false;
            this.autoStartCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.stopButton.FlatAppearance.BorderColor = Color.Black;
            this.stopButton.FlatStyle = FlatStyle.Flat;
            this.stopButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.stopButton.Location = new Point(483, 97);
            this.stopButton.Margin = new Padding(0);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new Size(112, 42);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // autoPollingStatusLabel
            // 
            this.autoPollingStatusLabel.BackColor = Color.Transparent;
            this.autoPollingStatusLabel.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.autoPollingStatusLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.autoPollingStatusLabel.Location = new Point(57, 14);
            this.autoPollingStatusLabel.Margin = new Padding(4, 0, 4, 0);
            this.autoPollingStatusLabel.Name = "autoPollingStatusLabel";
            this.autoPollingStatusLabel.Size = new Size(498, 43);
            this.autoPollingStatusLabel.TabIndex = 10024;
            this.autoPollingStatusLabel.Text = "Offline";
            // 
            // userInfoAutoOpenWindowCheckbox
            // 
            this.userInfoAutoOpenWindowCheckbox.AutoSize = true;
            this.userInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.userInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.userInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoAutoOpenWindowCheckbox.Name = "userInfoAutoOpenWindowCheckbox";
            this.userInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.userInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            this.userInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.userInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.userInfoAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoOpenWindowButton
            // 
            this.userInfoOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.userInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.userInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.userInfoOpenWindowButton.Location = new Point(573, 3);
            this.userInfoOpenWindowButton.Margin = new Padding(0);
            this.userInfoOpenWindowButton.Name = "userInfoOpenWindowButton";
            this.userInfoOpenWindowButton.Size = new Size(112, 42);
            this.userInfoOpenWindowButton.TabIndex = 10021;
            this.userInfoOpenWindowButton.Text = "Open";
            this.userInfoOpenWindowButton.UseVisualStyleBackColor = false;
            this.userInfoOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.startButton.FlatAppearance.BorderColor = Color.Black;
            this.startButton.FlatStyle = FlatStyle.Flat;
            this.startButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.startButton.Location = new Point(370, 97);
            this.startButton.Margin = new Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new Size(112, 42);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // focusAchievementPictureBox
            // 
            this.focusAchievementPictureBox.BackColor = Color.Transparent;
            this.focusAchievementPictureBox.Cursor = Cursors.Hand;
            this.focusAchievementPictureBox.InitialImage = null;
            this.focusAchievementPictureBox.Location = new Point(4, 62);
            this.focusAchievementPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusAchievementPictureBox.Name = "focusAchievementPictureBox";
            this.focusAchievementPictureBox.Size = new Size(168, 172);
            this.focusAchievementPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.focusAchievementPictureBox.TabIndex = 10030;
            this.focusAchievementPictureBox.TabStop = false;
            this.focusAchievementPictureBox.Click += new System.EventHandler(this.BrowserSensitiveControl_Click);
            // 
            // focusAchievementTitleLabel
            // 
            this.focusAchievementTitleLabel.BackColor = Color.Transparent;
            this.focusAchievementTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            this.focusAchievementTitleLabel.Cursor = Cursors.Hand;
            this.focusAchievementTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementTitleLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusAchievementTitleLabel.Location = new Point(182, 129);
            this.focusAchievementTitleLabel.Margin = new Padding(4, 0, 4, 0);
            this.focusAchievementTitleLabel.Name = "focusAchievementTitleLabel";
            this.focusAchievementTitleLabel.Size = new Size(246, 104);
            this.focusAchievementTitleLabel.TabIndex = 10027;
            this.focusAchievementTitleLabel.Click += new System.EventHandler(this.BrowserSensitiveControl_Click);
            // 
            // focusAchievementDescriptionLabel
            // 
            this.focusAchievementDescriptionLabel.BackColor = Color.Transparent;
            this.focusAchievementDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            this.focusAchievementDescriptionLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementDescriptionLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusAchievementDescriptionLabel.Location = new Point(3, 238);
            this.focusAchievementDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            this.focusAchievementDescriptionLabel.Name = "focusAchievementDescriptionLabel";
            this.focusAchievementDescriptionLabel.Size = new Size(425, 156);
            this.focusAchievementDescriptionLabel.TabIndex = 10026;
            // 
            // focusSetButton
            // 
            this.focusSetButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusSetButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusSetButton.FlatStyle = FlatStyle.Flat;
            this.focusSetButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusSetButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.focusSetButton.Location = new Point(316, 405);
            this.focusSetButton.Margin = new Padding(4, 5, 4, 5);
            this.focusSetButton.Name = "focusSetButton";
            this.focusSetButton.Size = new Size(112, 42);
            this.focusSetButton.TabIndex = 10031;
            this.focusSetButton.Text = "Set";
            this.focusSetButton.UseVisualStyleBackColor = false;
            this.focusSetButton.Click += new System.EventHandler(this.SetFocusButton_Click);
            // 
            // focusAchievementButtonPrevious
            // 
            this.focusAchievementButtonPrevious.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusAchievementButtonPrevious.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusAchievementButtonPrevious.FlatStyle = FlatStyle.Flat;
            this.focusAchievementButtonPrevious.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementButtonPrevious.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.focusAchievementButtonPrevious.Location = new Point(6, 405);
            this.focusAchievementButtonPrevious.Margin = new Padding(4, 5, 4, 5);
            this.focusAchievementButtonPrevious.Name = "focusAchievementButtonPrevious";
            this.focusAchievementButtonPrevious.Size = new Size(112, 42);
            this.focusAchievementButtonPrevious.TabIndex = 10028;
            this.focusAchievementButtonPrevious.Text = "<";
            this.focusAchievementButtonPrevious.UseVisualStyleBackColor = false;
            this.focusAchievementButtonPrevious.Click += new System.EventHandler(this.MoveFocusIndexPrev_Click);
            // 
            // focusAchievementButtonNext
            // 
            this.focusAchievementButtonNext.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusAchievementButtonNext.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusAchievementButtonNext.FlatStyle = FlatStyle.Flat;
            this.focusAchievementButtonNext.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementButtonNext.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.focusAchievementButtonNext.Location = new Point(128, 405);
            this.focusAchievementButtonNext.Margin = new Padding(4, 5, 4, 5);
            this.focusAchievementButtonNext.Name = "focusAchievementButtonNext";
            this.focusAchievementButtonNext.Size = new Size(112, 42);
            this.focusAchievementButtonNext.TabIndex = 10029;
            this.focusAchievementButtonNext.Text = ">";
            this.focusAchievementButtonNext.UseVisualStyleBackColor = false;
            this.focusAchievementButtonNext.Click += new System.EventHandler(this.MoveFocusIndexNext_Click);
            // 
            // gameInfoPictureBox
            // 
            this.gameInfoPictureBox.BackColor = Color.Transparent;
            this.gameInfoPictureBox.Cursor = Cursors.Hand;
            this.gameInfoPictureBox.InitialImage = null;
            this.gameInfoPictureBox.Location = new Point(12, 80);
            this.gameInfoPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoPictureBox.Name = "gameInfoPictureBox";
            this.gameInfoPictureBox.Size = new Size(144, 148);
            this.gameInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.gameInfoPictureBox.TabIndex = 10004;
            this.gameInfoPictureBox.TabStop = false;
            this.gameInfoPictureBox.Click += new System.EventHandler(this.BrowserSensitiveControl_Click);
            // 
            // autoPollingStatusPictureBox
            // 
            this.autoPollingStatusPictureBox.BackColor = Color.Transparent;
            this.autoPollingStatusPictureBox.Image = global::Retro_Achievement_Tracker.Properties.Resources.red_button;
            this.autoPollingStatusPictureBox.Location = new Point(6, 14);
            this.autoPollingStatusPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.autoPollingStatusPictureBox.Name = "autoPollingStatusPictureBox";
            this.autoPollingStatusPictureBox.Size = new Size(42, 43);
            this.autoPollingStatusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.autoPollingStatusPictureBox.TabIndex = 10025;
            this.autoPollingStatusPictureBox.TabStop = false;
            // 
            // alertsPlayAchievementButton
            // 
            this.alertsPlayAchievementButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsPlayAchievementButton.FlatAppearance.BorderColor = Color.Black;
            this.alertsPlayAchievementButton.FlatStyle = FlatStyle.Flat;
            this.alertsPlayAchievementButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsPlayAchievementButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.alertsPlayAchievementButton.Location = new Point(318, 5);
            this.alertsPlayAchievementButton.Margin = new Padding(4, 5, 4, 5);
            this.alertsPlayAchievementButton.Name = "alertsPlayAchievementButton";
            this.alertsPlayAchievementButton.Size = new Size(98, 38);
            this.alertsPlayAchievementButton.TabIndex = 2;
            this.alertsPlayAchievementButton.Text = "Play";
            this.alertsPlayAchievementButton.UseVisualStyleBackColor = false;
            this.alertsPlayAchievementButton.Click += new System.EventHandler(this.ShowAlertButton_Click);
            // 
            // alertsSelectCustomAchievementFileButton
            // 
            this.alertsSelectCustomAchievementFileButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsSelectCustomAchievementFileButton.FlatAppearance.BorderColor = Color.Black;
            this.alertsSelectCustomAchievementFileButton.FlatStyle = FlatStyle.Flat;
            this.alertsSelectCustomAchievementFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsSelectCustomAchievementFileButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.alertsSelectCustomAchievementFileButton.Location = new Point(314, 409);
            this.alertsSelectCustomAchievementFileButton.Margin = new Padding(4, 5, 4, 5);
            this.alertsSelectCustomAchievementFileButton.Name = "alertsSelectCustomAchievementFileButton";
            this.alertsSelectCustomAchievementFileButton.Size = new Size(98, 38);
            this.alertsSelectCustomAchievementFileButton.TabIndex = 14;
            this.alertsSelectCustomAchievementFileButton.Text = "File";
            this.alertsSelectCustomAchievementFileButton.UseVisualStyleBackColor = false;
            this.alertsSelectCustomAchievementFileButton.Click += new System.EventHandler(this.SelectCustomAlertButton_Click);
            // 
            // alertsCustomAchievementScaleNumericUpDown
            // 
            this.alertsCustomAchievementScaleNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementScaleNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementScaleNumericUpDown.DecimalPlaces = 2;
            this.alertsCustomAchievementScaleNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementScaleNumericUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementScaleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alertsCustomAchievementScaleNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementScaleNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsCustomAchievementScaleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alertsCustomAchievementScaleNumericUpDown.Name = "alertsCustomAchievementScaleNumericUpDown";
            this.alertsCustomAchievementScaleNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementScaleNumericUpDown.TabIndex = 20;
            this.alertsCustomAchievementScaleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsCustomAchievementScaleNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementXNumericUpDown
            // 
            this.alertsCustomAchievementXNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementXNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementXNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementXNumericUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementXNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementXNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.alertsCustomAchievementXNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.alertsCustomAchievementXNumericUpDown.Name = "alertsCustomAchievementXNumericUpDown";
            this.alertsCustomAchievementXNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementXNumericUpDown.TabIndex = 15;
            this.alertsCustomAchievementXNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementYNumericUpDown
            // 
            this.alertsCustomAchievementYNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementYNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementYNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementYNumericUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementYNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementYNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.alertsCustomAchievementYNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.alertsCustomAchievementYNumericUpDown.Name = "alertsCustomAchievementYNumericUpDown";
            this.alertsCustomAchievementYNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementYNumericUpDown.TabIndex = 16;
            this.alertsCustomAchievementYNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsAchievementEditOutlineCheckbox
            // 
            this.alertsAchievementEditOutlineCheckbox.AutoSize = true;
            this.alertsAchievementEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsAchievementEditOutlineCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsAchievementEditOutlineCheckbox.Location = new Point(12, 414);
            this.alertsAchievementEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsAchievementEditOutlineCheckbox.Name = "alertsAchievementEditOutlineCheckbox";
            this.alertsAchievementEditOutlineCheckbox.Size = new Size(137, 29);
            this.alertsAchievementEditOutlineCheckbox.TabIndex = 47;
            this.alertsAchievementEditOutlineCheckbox.Text = "Edit Mode";
            this.alertsAchievementEditOutlineCheckbox.UseVisualStyleBackColor = true;
            this.alertsAchievementEditOutlineCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomAchievementOutNumericUpDown
            // 
            this.alertsCustomAchievementOutNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementOutNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementOutNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementOutNumericUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementOutNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementOutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.alertsCustomAchievementOutNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomAchievementOutNumericUpDown.Name = "alertsCustomAchievementOutNumericUpDown";
            this.alertsCustomAchievementOutNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementOutNumericUpDown.TabIndex = 26;
            this.alertsCustomAchievementOutNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomAchievementOutNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementAnimationOutComboBox
            // 
            this.alertsCustomAchievementAnimationOutComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsCustomAchievementAnimationOutComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementAnimationOutComboBox.ForeColor = Color.White;
            this.alertsCustomAchievementAnimationOutComboBox.FormattingEnabled = true;
            this.alertsCustomAchievementAnimationOutComboBox.Location = new Point(252, 2);
            this.alertsCustomAchievementAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementAnimationOutComboBox.Name = "alertsCustomAchievementAnimationOutComboBox";
            this.alertsCustomAchievementAnimationOutComboBox.Size = new Size(144, 28);
            this.alertsCustomAchievementAnimationOutComboBox.TabIndex = 39;
            this.alertsCustomAchievementAnimationOutComboBox.SelectedIndexChanged += new System.EventHandler(this.NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomAchievementOutSpeedUpDown
            // 
            this.alertsCustomAchievementOutSpeedUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementOutSpeedUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementOutSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementOutSpeedUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementOutSpeedUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementOutSpeedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alertsCustomAchievementOutSpeedUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomAchievementOutSpeedUpDown.Name = "alertsCustomAchievementOutSpeedUpDown";
            this.alertsCustomAchievementOutSpeedUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementOutSpeedUpDown.TabIndex = 48;
            this.alertsCustomAchievementOutSpeedUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomAchievementOutSpeedUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementInNumericUpDown
            // 
            this.alertsCustomAchievementInNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementInNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementInNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementInNumericUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementInNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementInNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.alertsCustomAchievementInNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomAchievementInNumericUpDown.Name = "alertsCustomAchievementInNumericUpDown";
            this.alertsCustomAchievementInNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementInNumericUpDown.TabIndex = 26;
            this.alertsCustomAchievementInNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomAchievementInNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementAnimationInComboBox
            // 
            this.alertsCustomAchievementAnimationInComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsCustomAchievementAnimationInComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementAnimationInComboBox.ForeColor = Color.White;
            this.alertsCustomAchievementAnimationInComboBox.FormattingEnabled = true;
            this.alertsCustomAchievementAnimationInComboBox.Location = new Point(252, 2);
            this.alertsCustomAchievementAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementAnimationInComboBox.Name = "alertsCustomAchievementAnimationInComboBox";
            this.alertsCustomAchievementAnimationInComboBox.Size = new Size(144, 28);
            this.alertsCustomAchievementAnimationInComboBox.TabIndex = 39;
            this.alertsCustomAchievementAnimationInComboBox.SelectedIndexChanged += new System.EventHandler(this.NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomAchievementInSpeedUpDown
            // 
            this.alertsCustomAchievementInSpeedUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.alertsCustomAchievementInSpeedUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomAchievementInSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementInSpeedUpDown.ForeColor = Color.White;
            this.alertsCustomAchievementInSpeedUpDown.Location = new Point(252, 6);
            this.alertsCustomAchievementInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementInSpeedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alertsCustomAchievementInSpeedUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomAchievementInSpeedUpDown.Name = "alertsCustomAchievementInSpeedUpDown";
            this.alertsCustomAchievementInSpeedUpDown.Size = new Size(146, 24);
            this.alertsCustomAchievementInSpeedUpDown.TabIndex = 48;
            this.alertsCustomAchievementInSpeedUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomAchievementInSpeedUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomAchievementEnableCheckbox
            // 
            this.alertsCustomAchievementEnableCheckbox.AutoSize = true;
            this.alertsCustomAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomAchievementEnableCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsCustomAchievementEnableCheckbox.Location = new Point(129, 9);
            this.alertsCustomAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementEnableCheckbox.Name = "alertsCustomAchievementEnableCheckbox";
            this.alertsCustomAchievementEnableCheckbox.Size = new Size(114, 29);
            this.alertsCustomAchievementEnableCheckbox.TabIndex = 13;
            this.alertsCustomAchievementEnableCheckbox.Text = "Custom";
            this.alertsCustomAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            this.alertsCustomAchievementEnableCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsPlayMasteryButton
            // 
            this.alertsPlayMasteryButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsPlayMasteryButton.FlatAppearance.BorderColor = Color.Black;
            this.alertsPlayMasteryButton.FlatStyle = FlatStyle.Flat;
            this.alertsPlayMasteryButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsPlayMasteryButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.alertsPlayMasteryButton.Location = new Point(318, 5);
            this.alertsPlayMasteryButton.Margin = new Padding(4, 5, 4, 5);
            this.alertsPlayMasteryButton.Name = "alertsPlayMasteryButton";
            this.alertsPlayMasteryButton.Size = new Size(98, 38);
            this.alertsPlayMasteryButton.TabIndex = 2;
            this.alertsPlayMasteryButton.Text = "Play";
            this.alertsPlayMasteryButton.UseVisualStyleBackColor = false;
            this.alertsPlayMasteryButton.Click += new System.EventHandler(this.ShowAlertButton_Click);
            // 
            // alertsSelectCustomMasteryFileButton
            // 
            this.alertsSelectCustomMasteryFileButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsSelectCustomMasteryFileButton.FlatAppearance.BorderColor = Color.Black;
            this.alertsSelectCustomMasteryFileButton.FlatStyle = FlatStyle.Flat;
            this.alertsSelectCustomMasteryFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsSelectCustomMasteryFileButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.alertsSelectCustomMasteryFileButton.Location = new Point(314, 409);
            this.alertsSelectCustomMasteryFileButton.Margin = new Padding(4, 5, 4, 5);
            this.alertsSelectCustomMasteryFileButton.Name = "alertsSelectCustomMasteryFileButton";
            this.alertsSelectCustomMasteryFileButton.Size = new Size(98, 38);
            this.alertsSelectCustomMasteryFileButton.TabIndex = 14;
            this.alertsSelectCustomMasteryFileButton.Text = "File";
            this.alertsSelectCustomMasteryFileButton.UseVisualStyleBackColor = false;
            this.alertsSelectCustomMasteryFileButton.Click += new System.EventHandler(this.SelectCustomAlertButton_Click);
            // 
            // alertsCustomMasteryScaleNumericUpDown
            // 
            this.alertsCustomMasteryScaleNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryScaleNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryScaleNumericUpDown.DecimalPlaces = 2;
            this.alertsCustomMasteryScaleNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryScaleNumericUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryScaleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alertsCustomMasteryScaleNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryScaleNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsCustomMasteryScaleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alertsCustomMasteryScaleNumericUpDown.Name = "alertsCustomMasteryScaleNumericUpDown";
            this.alertsCustomMasteryScaleNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryScaleNumericUpDown.TabIndex = 20;
            this.alertsCustomMasteryScaleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsCustomMasteryScaleNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryXNumericUpDown
            // 
            this.alertsCustomMasteryXNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryXNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryXNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryXNumericUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryXNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryXNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.alertsCustomMasteryXNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.alertsCustomMasteryXNumericUpDown.Name = "alertsCustomMasteryXNumericUpDown";
            this.alertsCustomMasteryXNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryXNumericUpDown.TabIndex = 15;
            this.alertsCustomMasteryXNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryYNumericUpDown
            // 
            this.alertsCustomMasteryYNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryYNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryYNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryYNumericUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryYNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryYNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.alertsCustomMasteryYNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.alertsCustomMasteryYNumericUpDown.Name = "alertsCustomMasteryYNumericUpDown";
            this.alertsCustomMasteryYNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryYNumericUpDown.TabIndex = 16;
            this.alertsCustomMasteryYNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsMasteryEditOutlineCheckbox
            // 
            this.alertsMasteryEditOutlineCheckbox.AutoSize = true;
            this.alertsMasteryEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsMasteryEditOutlineCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsMasteryEditOutlineCheckbox.Location = new Point(12, 414);
            this.alertsMasteryEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsMasteryEditOutlineCheckbox.Name = "alertsMasteryEditOutlineCheckbox";
            this.alertsMasteryEditOutlineCheckbox.Size = new Size(137, 29);
            this.alertsMasteryEditOutlineCheckbox.TabIndex = 47;
            this.alertsMasteryEditOutlineCheckbox.Text = "Edit Mode";
            this.alertsMasteryEditOutlineCheckbox.UseVisualStyleBackColor = true;
            this.alertsMasteryEditOutlineCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomMasteryOutNumericUpDown
            // 
            this.alertsCustomMasteryOutNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryOutNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryOutNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryOutNumericUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryOutNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryOutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.alertsCustomMasteryOutNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomMasteryOutNumericUpDown.Name = "alertsCustomMasteryOutNumericUpDown";
            this.alertsCustomMasteryOutNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryOutNumericUpDown.TabIndex = 26;
            this.alertsCustomMasteryOutNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomMasteryOutNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryAnimationOutComboBox
            // 
            this.alertsCustomMasteryAnimationOutComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsCustomMasteryAnimationOutComboBox.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryAnimationOutComboBox.ForeColor = Color.White;
            this.alertsCustomMasteryAnimationOutComboBox.FormattingEnabled = true;
            this.alertsCustomMasteryAnimationOutComboBox.Location = new Point(252, 2);
            this.alertsCustomMasteryAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryAnimationOutComboBox.Name = "alertsCustomMasteryAnimationOutComboBox";
            this.alertsCustomMasteryAnimationOutComboBox.Size = new Size(144, 28);
            this.alertsCustomMasteryAnimationOutComboBox.TabIndex = 39;
            this.alertsCustomMasteryAnimationOutComboBox.SelectedIndexChanged += new System.EventHandler(this.NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomMasteryOutSpeedUpDown
            // 
            this.alertsCustomMasteryOutSpeedUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryOutSpeedUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryOutSpeedUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryOutSpeedUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryOutSpeedUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryOutSpeedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alertsCustomMasteryOutSpeedUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomMasteryOutSpeedUpDown.Name = "alertsCustomMasteryOutSpeedUpDown";
            this.alertsCustomMasteryOutSpeedUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryOutSpeedUpDown.TabIndex = 48;
            this.alertsCustomMasteryOutSpeedUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomMasteryOutSpeedUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryInNumericUpDown
            // 
            this.alertsCustomMasteryInNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryInNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryInNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryInNumericUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryInNumericUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryInNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.alertsCustomMasteryInNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomMasteryInNumericUpDown.Name = "alertsCustomMasteryInNumericUpDown";
            this.alertsCustomMasteryInNumericUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryInNumericUpDown.TabIndex = 26;
            this.alertsCustomMasteryInNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.alertsCustomMasteryInNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryAnimationInComboBox
            // 
            this.alertsCustomMasteryAnimationInComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsCustomMasteryAnimationInComboBox.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryAnimationInComboBox.ForeColor = Color.White;
            this.alertsCustomMasteryAnimationInComboBox.FormattingEnabled = true;
            this.alertsCustomMasteryAnimationInComboBox.Location = new Point(252, 2);
            this.alertsCustomMasteryAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryAnimationInComboBox.Name = "alertsCustomMasteryAnimationInComboBox";
            this.alertsCustomMasteryAnimationInComboBox.Size = new Size(144, 28);
            this.alertsCustomMasteryAnimationInComboBox.TabIndex = 39;
            this.alertsCustomMasteryAnimationInComboBox.SelectedIndexChanged += new System.EventHandler(this.NotificationAnimationComboBox_SelectedIndexChanged);
            // 
            // alertsCustomMasteryInSpeedUpDown
            // 
            this.alertsCustomMasteryInSpeedUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsCustomMasteryInSpeedUpDown.BorderStyle = BorderStyle.None;
            this.alertsCustomMasteryInSpeedUpDown.Font = new Font("Verdana", 8.25F);
            this.alertsCustomMasteryInSpeedUpDown.ForeColor = Color.White;
            this.alertsCustomMasteryInSpeedUpDown.Location = new Point(252, 6);
            this.alertsCustomMasteryInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryInSpeedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alertsCustomMasteryInSpeedUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomMasteryInSpeedUpDown.Name = "alertsCustomMasteryInSpeedUpDown";
            this.alertsCustomMasteryInSpeedUpDown.Size = new Size(146, 24);
            this.alertsCustomMasteryInSpeedUpDown.TabIndex = 48;
            this.alertsCustomMasteryInSpeedUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alertsCustomMasteryInSpeedUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsCustomMasteryEnableCheckbox
            // 
            this.alertsCustomMasteryEnableCheckbox.AutoSize = true;
            this.alertsCustomMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsCustomMasteryEnableCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsCustomMasteryEnableCheckbox.Location = new Point(129, 9);
            this.alertsCustomMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryEnableCheckbox.Name = "alertsCustomMasteryEnableCheckbox";
            this.alertsCustomMasteryEnableCheckbox.Size = new Size(114, 29);
            this.alertsCustomMasteryEnableCheckbox.TabIndex = 13;
            this.alertsCustomMasteryEnableCheckbox.Text = "Custom";
            this.alertsCustomMasteryEnableCheckbox.UseVisualStyleBackColor = true;
            this.alertsCustomMasteryEnableCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // userInfoTruePointsTextBox
            // 
            this.userInfoTruePointsTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoTruePointsTextBox.ForeColor = Color.White;
            this.userInfoTruePointsTextBox.Location = new Point(174, 0);
            this.userInfoTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoTruePointsTextBox.Name = "userInfoTruePointsTextBox";
            this.userInfoTruePointsTextBox.Size = new Size(146, 31);
            this.userInfoTruePointsTextBox.TabIndex = 7;
            this.userInfoTruePointsTextBox.Text = "True Points";
            this.userInfoTruePointsTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // userInfoPointsTextBox
            // 
            this.userInfoPointsTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoPointsTextBox.ForeColor = Color.White;
            this.userInfoPointsTextBox.Location = new Point(174, 0);
            this.userInfoPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoPointsTextBox.Name = "userInfoPointsTextBox";
            this.userInfoPointsTextBox.Size = new Size(146, 31);
            this.userInfoPointsTextBox.TabIndex = 6;
            this.userInfoPointsTextBox.Text = "Points";
            this.userInfoPointsTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // userInfoRatioTextBox
            // 
            this.userInfoRatioTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRatioTextBox.ForeColor = Color.White;
            this.userInfoRatioTextBox.Location = new Point(174, 0);
            this.userInfoRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoRatioTextBox.Name = "userInfoRatioTextBox";
            this.userInfoRatioTextBox.Size = new Size(146, 31);
            this.userInfoRatioTextBox.TabIndex = 5;
            this.userInfoRatioTextBox.Text = "Retro Ratio";
            this.userInfoRatioTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // userInfoRankTextBox
            // 
            this.userInfoRankTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoRankTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRankTextBox.ForeColor = Color.White;
            this.userInfoRankTextBox.Location = new Point(174, 0);
            this.userInfoRankTextBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoRankTextBox.Name = "userInfoRankTextBox";
            this.userInfoRankTextBox.Size = new Size(146, 31);
            this.userInfoRankTextBox.TabIndex = 1;
            this.userInfoRankTextBox.Text = "Rank";
            this.userInfoRankTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // userInfoTruePointsCheckBox
            // 
            this.userInfoTruePointsCheckBox.BackColor = Color.Transparent;
            this.userInfoTruePointsCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoTruePointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoTruePointsCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoTruePointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoTruePointsCheckBox.ForeColor = Color.White;
            this.userInfoTruePointsCheckBox.Location = new Point(338, 8);
            this.userInfoTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoTruePointsCheckBox.Name = "userInfoTruePointsCheckBox";
            this.userInfoTruePointsCheckBox.Size = new Size(22, 22);
            this.userInfoTruePointsCheckBox.TabIndex = 56;
            this.userInfoTruePointsCheckBox.UseVisualStyleBackColor = true;
            this.userInfoTruePointsCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoRatioCheckBox
            // 
            this.userInfoRatioCheckBox.BackColor = Color.Transparent;
            this.userInfoRatioCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoRatioCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoRatioCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoRatioCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRatioCheckBox.ForeColor = Color.White;
            this.userInfoRatioCheckBox.Location = new Point(338, 8);
            this.userInfoRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoRatioCheckBox.Name = "userInfoRatioCheckBox";
            this.userInfoRatioCheckBox.Size = new Size(22, 22);
            this.userInfoRatioCheckBox.TabIndex = 55;
            this.userInfoRatioCheckBox.UseVisualStyleBackColor = true;
            this.userInfoRatioCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoPointsCheckBox
            // 
            this.userInfoPointsCheckBox.BackColor = Color.Transparent;
            this.userInfoPointsCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoPointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoPointsCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoPointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoPointsCheckBox.ForeColor = Color.White;
            this.userInfoPointsCheckBox.Location = new Point(338, 8);
            this.userInfoPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoPointsCheckBox.Name = "userInfoPointsCheckBox";
            this.userInfoPointsCheckBox.Size = new Size(22, 22);
            this.userInfoPointsCheckBox.TabIndex = 54;
            this.userInfoPointsCheckBox.UseVisualStyleBackColor = true;
            this.userInfoPointsCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoDefaultButton
            // 
            this.userInfoDefaultButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            this.userInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoDefaultButton.ForeColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userInfoDefaultButton.Location = new Point(306, 3);
            this.userInfoDefaultButton.Margin = new Padding(0);
            this.userInfoDefaultButton.Name = "userInfoDefaultButton";
            this.userInfoDefaultButton.Size = new Size(112, 42);
            this.userInfoDefaultButton.TabIndex = 39;
            this.userInfoDefaultButton.Text = "Default";
            this.userInfoDefaultButton.UseVisualStyleBackColor = false;
            this.userInfoDefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // userInfoRankCheckBox
            // 
            this.userInfoRankCheckBox.BackColor = Color.Transparent;
            this.userInfoRankCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoRankCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoRankCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoRankCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRankCheckBox.ForeColor = Color.White;
            this.userInfoRankCheckBox.Location = new Point(338, 8);
            this.userInfoRankCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoRankCheckBox.Name = "userInfoRankCheckBox";
            this.userInfoRankCheckBox.Size = new Size(22, 22);
            this.userInfoRankCheckBox.TabIndex = 52;
            this.userInfoRankCheckBox.UseVisualStyleBackColor = true;
            this.userInfoRankCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // focusBehaviorGoToLastRadioButton
            // 
            this.focusBehaviorGoToLastRadioButton.AutoSize = true;
            this.focusBehaviorGoToLastRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusBehaviorGoToLastRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusBehaviorGoToLastRadioButton.Location = new Point(334, 62);
            this.focusBehaviorGoToLastRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.focusBehaviorGoToLastRadioButton.Name = "focusBehaviorGoToLastRadioButton";
            this.focusBehaviorGoToLastRadioButton.Size = new Size(78, 29);
            this.focusBehaviorGoToLastRadioButton.TabIndex = 3;
            this.focusBehaviorGoToLastRadioButton.Text = "Last";
            this.focusBehaviorGoToLastRadioButton.UseVisualStyleBackColor = true;
            this.focusBehaviorGoToLastRadioButton.CheckedChanged += new System.EventHandler(this.RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToNextRadioButton
            // 
            this.focusBehaviorGoToNextRadioButton.AutoSize = true;
            this.focusBehaviorGoToNextRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusBehaviorGoToNextRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusBehaviorGoToNextRadioButton.Location = new Point(102, 62);
            this.focusBehaviorGoToNextRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.focusBehaviorGoToNextRadioButton.Name = "focusBehaviorGoToNextRadioButton";
            this.focusBehaviorGoToNextRadioButton.Size = new Size(84, 29);
            this.focusBehaviorGoToNextRadioButton.TabIndex = 2;
            this.focusBehaviorGoToNextRadioButton.Text = "Next";
            this.focusBehaviorGoToNextRadioButton.UseVisualStyleBackColor = true;
            this.focusBehaviorGoToNextRadioButton.CheckedChanged += new System.EventHandler(this.RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToPreviousRadioButton
            // 
            this.focusBehaviorGoToPreviousRadioButton.AutoSize = true;
            this.focusBehaviorGoToPreviousRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusBehaviorGoToPreviousRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusBehaviorGoToPreviousRadioButton.Location = new Point(206, 62);
            this.focusBehaviorGoToPreviousRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.focusBehaviorGoToPreviousRadioButton.Name = "focusBehaviorGoToPreviousRadioButton";
            this.focusBehaviorGoToPreviousRadioButton.Size = new Size(123, 29);
            this.focusBehaviorGoToPreviousRadioButton.TabIndex = 1;
            this.focusBehaviorGoToPreviousRadioButton.Text = "Previous";
            this.focusBehaviorGoToPreviousRadioButton.UseVisualStyleBackColor = true;
            this.focusBehaviorGoToPreviousRadioButton.CheckedChanged += new System.EventHandler(this.RefocusBehavior_RadioButtonCheckChanged);
            // 
            // focusBehaviorGoToFirstRadioButton
            // 
            this.focusBehaviorGoToFirstRadioButton.AutoSize = true;
            this.focusBehaviorGoToFirstRadioButton.Checked = true;
            this.focusBehaviorGoToFirstRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusBehaviorGoToFirstRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusBehaviorGoToFirstRadioButton.Location = new Point(12, 62);
            this.focusBehaviorGoToFirstRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.focusBehaviorGoToFirstRadioButton.Name = "focusBehaviorGoToFirstRadioButton";
            this.focusBehaviorGoToFirstRadioButton.Size = new Size(82, 29);
            this.focusBehaviorGoToFirstRadioButton.TabIndex = 0;
            this.focusBehaviorGoToFirstRadioButton.TabStop = true;
            this.focusBehaviorGoToFirstRadioButton.Text = "First";
            this.focusBehaviorGoToFirstRadioButton.UseVisualStyleBackColor = true;
            this.focusBehaviorGoToFirstRadioButton.CheckedChanged += new System.EventHandler(this.RefocusBehavior_RadioButtonCheckChanged);
            // 
            // recentAchievementsMaxListLabel
            // 
            this.recentAchievementsMaxListLabel.AutoSize = true;
            this.recentAchievementsMaxListLabel.BackColor = Color.Transparent;
            this.recentAchievementsMaxListLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsMaxListLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsMaxListLabel.Location = new Point(190, 63);
            this.recentAchievementsMaxListLabel.Margin = new Padding(4, 0, 4, 0);
            this.recentAchievementsMaxListLabel.Name = "recentAchievementsMaxListLabel";
            this.recentAchievementsMaxListLabel.Size = new Size(145, 25);
            this.recentAchievementsMaxListLabel.TabIndex = 10015;
            this.recentAchievementsMaxListLabel.Text = "Max List Size";
            // 
            // recentAchievementsMaxListNumericUpDown
            // 
            this.recentAchievementsMaxListNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.recentAchievementsMaxListNumericUpDown.Font = new Font("Verdana", 8.25F);
            this.recentAchievementsMaxListNumericUpDown.ForeColor = Color.White;
            this.recentAchievementsMaxListNumericUpDown.Location = new Point(339, 62);
            this.recentAchievementsMaxListNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsMaxListNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.recentAchievementsMaxListNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsMaxListNumericUpDown.Name = "recentAchievementsMaxListNumericUpDown";
            this.recentAchievementsMaxListNumericUpDown.Size = new Size(76, 28);
            this.recentAchievementsMaxListNumericUpDown.TabIndex = 22;
            this.recentAchievementsMaxListNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsMaxListNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // panel64
            // 
            this.panel64.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel64.Controls.Add(this.label112);
            this.panel64.Controls.Add(this.focusBehaviorGoToLastRadioButton);
            this.panel64.Controls.Add(this.pictureBox12);
            this.panel64.Controls.Add(this.focusBehaviorGoToFirstRadioButton);
            this.panel64.Controls.Add(this.focusBehaviorGoToNextRadioButton);
            this.panel64.Controls.Add(this.focusBehaviorGoToPreviousRadioButton);
            this.panel64.Location = new Point(4, 465);
            this.panel64.Margin = new Padding(4, 5, 4, 5);
            this.panel64.Name = "panel64";
            this.panel64.Size = new Size(434, 97);
            this.panel64.TabIndex = 10084;
            // 
            // label112
            // 
            this.label112.BackColor = Color.Transparent;
            this.label112.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label112.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label112.Location = new Point(4, 5);
            this.label112.Margin = new Padding(4, 0, 4, 0);
            this.label112.Name = "label112";
            this.label112.Size = new Size(410, 40);
            this.label112.TabIndex = 10082;
            this.label112.Text = "Auto-Focus Rule";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox12.Location = new Point(3, 49);
            this.pictureBox12.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new Size(412, 3);
            this.pictureBox12.TabIndex = 10083;
            this.pictureBox12.TabStop = false;
            // 
            // panel63
            // 
            this.panel63.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel63.Controls.Add(this.unlockAchievementButton);
            this.panel63.Controls.Add(this.label111);
            this.panel63.Controls.Add(this.pictureBox10);
            this.panel63.Controls.Add(this.focusAchievementPictureBox);
            this.panel63.Controls.Add(this.focusAchievementButtonPrevious);
            this.panel63.Controls.Add(this.focusAchievementButtonNext);
            this.panel63.Controls.Add(this.focusAchievementDescriptionLabel);
            this.panel63.Controls.Add(this.focusAchievementTitleLabel);
            this.panel63.Controls.Add(this.focusSetButton);
            this.panel63.Location = new Point(4, 5);
            this.panel63.Margin = new Padding(4, 5, 4, 5);
            this.panel63.Name = "panel63";
            this.panel63.Size = new Size(434, 451);
            this.panel63.TabIndex = 10081;
            // 
            // unlockAchievementButton
            // 
            this.unlockAchievementButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.unlockAchievementButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.unlockAchievementButton.FlatStyle = FlatStyle.Flat;
            this.unlockAchievementButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.unlockAchievementButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.unlockAchievementButton.Location = new Point(316, 62);
            this.unlockAchievementButton.Margin = new Padding(4, 5, 4, 5);
            this.unlockAchievementButton.Name = "unlockAchievementButton";
            this.unlockAchievementButton.Size = new Size(112, 42);
            this.unlockAchievementButton.TabIndex = 10084;
            this.unlockAchievementButton.Text = "Unlock";
            this.unlockAchievementButton.UseVisualStyleBackColor = false;
            this.unlockAchievementButton.Click += new System.EventHandler(this.UnlockAchievementButton_Click);
            // 
            // label111
            // 
            this.label111.BackColor = Color.Transparent;
            this.label111.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label111.Location = new Point(4, 5);
            this.label111.Margin = new Padding(4, 0, 4, 0);
            this.label111.Name = "label111";
            this.label111.Size = new Size(410, 40);
            this.label111.TabIndex = 10082;
            this.label111.Text = "Current Achievement";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox10.Location = new Point(3, 49);
            this.pictureBox10.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new Size(420, 3);
            this.pictureBox10.TabIndex = 10083;
            this.pictureBox10.TabStop = false;
            // 
            // panel51
            // 
            this.panel51.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel51.Controls.Add(this.focusLinePanel);
            this.panel51.Controls.Add(this.label96);
            this.panel51.Controls.Add(this.panel59);
            this.panel51.Controls.Add(this.focusPointsPanel);
            this.panel51.Controls.Add(this.panel52);
            this.panel51.Controls.Add(this.panel61);
            this.panel51.Controls.Add(this.focusOpenWindowButton);
            this.panel51.Controls.Add(this.focusDescriptionOutlinePanel);
            this.panel51.Controls.Add(this.focusDescriptionPanel);
            this.panel51.Controls.Add(this.focusAutoOpenWindowCheckBox);
            this.panel51.Controls.Add(this.pictureBox11);
            this.panel51.Controls.Add(this.panel54);
            this.panel51.Controls.Add(this.panel55);
            this.panel51.Controls.Add(this.focusPointsOutlinePanel);
            this.panel51.Controls.Add(this.focusLineOutlinePanel);
            this.panel51.Location = new Point(444, 5);
            this.panel51.Margin = new Padding(4, 5, 4, 5);
            this.panel51.Name = "panel51";
            this.panel51.Size = new Size(702, 438);
            this.panel51.TabIndex = 10080;
            // 
            // focusLinePanel
            // 
            this.focusLinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.focusLinePanel.Controls.Add(this.label106);
            this.focusLinePanel.Controls.Add(this.focusLineColorPictureBox);
            this.focusLinePanel.Location = new Point(3, 265);
            this.focusLinePanel.Margin = new Padding(4, 5, 4, 5);
            this.focusLinePanel.Name = "focusLinePanel";
            this.focusLinePanel.Size = new Size(694, 35);
            this.focusLinePanel.TabIndex = 10068;
            // 
            // label106
            // 
            this.label106.BackColor = Color.Transparent;
            this.label106.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label106.Location = new Point(4, 6);
            this.label106.Margin = new Padding(4, 0, 4, 0);
            this.label106.Name = "label106";
            this.label106.Size = new Size(216, 25);
            this.label106.TabIndex = 10066;
            this.label106.Text = "Line";
            // 
            // focusLineColorPictureBox
            // 
            this.focusLineColorPictureBox.BackColor = Color.White;
            this.focusLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusLineColorPictureBox.Location = new Point(230, 5);
            this.focusLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusLineColorPictureBox.Name = "focusLineColorPictureBox";
            this.focusLineColorPictureBox.Size = new Size(22, 22);
            this.focusLineColorPictureBox.TabIndex = 45;
            this.focusLineColorPictureBox.TabStop = false;
            this.focusLineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label96
            // 
            this.label96.BackColor = Color.Transparent;
            this.label96.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label96.Location = new Point(4, 5);
            this.label96.Margin = new Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new Size(364, 40);
            this.label96.TabIndex = 10062;
            this.label96.Text = "Window/Font Settings";
            // 
            // panel59
            // 
            this.panel59.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel59.Controls.Add(this.focusBorderCheckBox);
            this.panel59.Controls.Add(this.focusBorderColorPictureBox);
            this.panel59.Controls.Add(this.label107);
            this.panel59.Location = new Point(3, 129);
            this.panel59.Margin = new Padding(4, 5, 4, 5);
            this.panel59.Name = "panel59";
            this.panel59.Size = new Size(694, 35);
            this.panel59.TabIndex = 10069;
            // 
            // focusBorderCheckBox
            // 
            this.focusBorderCheckBox.AutoSize = true;
            this.focusBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusBorderCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusBorderCheckBox.Location = new Point(620, 8);
            this.focusBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusBorderCheckBox.Name = "focusBorderCheckBox";
            this.focusBorderCheckBox.Size = new Size(22, 21);
            this.focusBorderCheckBox.TabIndex = 10065;
            this.focusBorderCheckBox.UseVisualStyleBackColor = true;
            this.focusBorderCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusBorderColorPictureBox
            // 
            this.focusBorderColorPictureBox.BackColor = Color.White;
            this.focusBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusBorderColorPictureBox.Location = new Point(230, 5);
            this.focusBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusBorderColorPictureBox.Name = "focusBorderColorPictureBox";
            this.focusBorderColorPictureBox.Size = new Size(22, 22);
            this.focusBorderColorPictureBox.TabIndex = 42;
            this.focusBorderColorPictureBox.TabStop = false;
            this.focusBorderColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label107
            // 
            this.label107.BackColor = Color.Transparent;
            this.label107.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label107.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label107.Location = new Point(4, 5);
            this.label107.Margin = new Padding(4, 0, 4, 0);
            this.label107.Name = "label107";
            this.label107.Size = new Size(216, 25);
            this.label107.TabIndex = 10064;
            this.label107.Text = "Border";
            // 
            // focusPointsPanel
            // 
            this.focusPointsPanel.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.focusPointsPanel.Controls.Add(this.label108);
            this.focusPointsPanel.Controls.Add(this.focusPointsFontColorPictureBox);
            this.focusPointsPanel.Controls.Add(this.focusPointsFontComboBox);
            this.focusPointsPanel.Location = new Point(3, 231);
            this.focusPointsPanel.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsPanel.Name = "focusPointsPanel";
            this.focusPointsPanel.Size = new Size(694, 35);
            this.focusPointsPanel.TabIndex = 10070;
            // 
            // label108
            // 
            this.label108.BackColor = Color.Transparent;
            this.label108.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label108.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label108.Location = new Point(4, 6);
            this.label108.Margin = new Padding(4, 0, 4, 0);
            this.label108.Name = "label108";
            this.label108.Size = new Size(216, 25);
            this.label108.TabIndex = 10065;
            this.label108.Text = "Points";
            // 
            // focusPointsFontColorPictureBox
            // 
            this.focusPointsFontColorPictureBox.BackColor = Color.White;
            this.focusPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusPointsFontColorPictureBox.Location = new Point(230, 6);
            this.focusPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsFontColorPictureBox.Name = "focusPointsFontColorPictureBox";
            this.focusPointsFontColorPictureBox.Size = new Size(22, 22);
            this.focusPointsFontColorPictureBox.TabIndex = 45;
            this.focusPointsFontColorPictureBox.TabStop = false;
            this.focusPointsFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusPointsFontComboBox
            // 
            this.focusPointsFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusPointsFontComboBox.ForeColor = Color.White;
            this.focusPointsFontComboBox.FormattingEnabled = true;
            this.focusPointsFontComboBox.Location = new Point(290, 3);
            this.focusPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsFontComboBox.Name = "focusPointsFontComboBox";
            this.focusPointsFontComboBox.Size = new Size(301, 28);
            this.focusPointsFontComboBox.TabIndex = 45;
            this.focusPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel52
            // 
            this.panel52.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel52.Controls.Add(this.focusAdvancedCheckBox);
            this.panel52.Controls.Add(this.label97);
            this.panel52.Controls.Add(this.label98);
            this.panel52.Controls.Add(this.label99);
            this.panel52.Controls.Add(this.label100);
            this.panel52.Location = new Point(3, 62);
            this.panel52.Margin = new Padding(4, 5, 4, 5);
            this.panel52.Name = "panel52";
            this.panel52.Size = new Size(694, 35);
            this.panel52.TabIndex = 10076;
            // 
            // focusAdvancedCheckBox
            // 
            this.focusAdvancedCheckBox.AutoSize = true;
            this.focusAdvancedCheckBox.BackColor = Color.Transparent;
            this.focusAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.focusAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusAdvancedCheckBox.Location = new Point(8, 3);
            this.focusAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusAdvancedCheckBox.Name = "focusAdvancedCheckBox";
            this.focusAdvancedCheckBox.Size = new Size(135, 29);
            this.focusAdvancedCheckBox.TabIndex = 10053;
            this.focusAdvancedCheckBox.Text = "Advanced";
            this.focusAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.focusAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label97
            // 
            this.label97.BackColor = Color.Transparent;
            this.label97.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label97.Location = new Point(225, 5);
            this.label97.Margin = new Padding(4, 0, 4, 0);
            this.label97.Name = "label97";
            this.label97.Size = new Size(72, 25);
            this.label97.TabIndex = 10065;
            this.label97.Text = "Color";
            // 
            // label98
            // 
            this.label98.BackColor = Color.Transparent;
            this.label98.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label98.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label98.Location = new Point(291, 5);
            this.label98.Margin = new Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new Size(75, 25);
            this.label98.TabIndex = 10066;
            this.label98.Text = "Font";
            // 
            // label99
            // 
            this.label99.BackColor = Color.Transparent;
            this.label99.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label99.Location = new Point(524, 5);
            this.label99.Margin = new Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new Size(62, 25);
            this.label99.TabIndex = 10068;
            this.label99.Text = "Size";
            // 
            // label100
            // 
            this.label100.BackColor = Color.Transparent;
            this.label100.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label100.Location = new Point(594, 5);
            this.label100.Margin = new Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new Size(88, 25);
            this.label100.TabIndex = 10067;
            this.label100.Text = "Enabled";
            // 
            // panel61
            // 
            this.panel61.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel61.Controls.Add(this.focusTitleFontOutlineNumericUpDown);
            this.panel61.Controls.Add(this.focusTitleOutlineCheckBox);
            this.panel61.Controls.Add(this.focusTitleOutlineLabel);
            this.panel61.Controls.Add(this.focusTitleFontOutlineColorPictureBox);
            this.panel61.Location = new Point(3, 298);
            this.panel61.Margin = new Padding(4, 5, 4, 5);
            this.panel61.Name = "panel61";
            this.panel61.Size = new Size(694, 35);
            this.panel61.TabIndex = 10071;
            // 
            // focusTitleFontOutlineNumericUpDown
            // 
            this.focusTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.focusTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.focusTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            this.focusTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.focusTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.focusTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.focusTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusTitleFontOutlineNumericUpDown.Name = "focusTitleFontOutlineNumericUpDown";
            this.focusTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.focusTitleFontOutlineNumericUpDown.TabIndex = 45;
            this.focusTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // focusTitleOutlineCheckBox
            // 
            this.focusTitleOutlineCheckBox.AutoSize = true;
            this.focusTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusTitleOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusTitleOutlineCheckBox.Location = new Point(620, 8);
            this.focusTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusTitleOutlineCheckBox.Name = "focusTitleOutlineCheckBox";
            this.focusTitleOutlineCheckBox.Size = new Size(22, 21);
            this.focusTitleOutlineCheckBox.TabIndex = 45;
            this.focusTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            this.focusTitleOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusTitleOutlineLabel
            // 
            this.focusTitleOutlineLabel.BackColor = Color.Transparent;
            this.focusTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusTitleOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusTitleOutlineLabel.Location = new Point(4, 5);
            this.focusTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.focusTitleOutlineLabel.Name = "focusTitleOutlineLabel";
            this.focusTitleOutlineLabel.Size = new Size(216, 25);
            this.focusTitleOutlineLabel.TabIndex = 10066;
            this.focusTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // focusTitleFontOutlineColorPictureBox
            // 
            this.focusTitleFontOutlineColorPictureBox.BackColor = Color.White;
            this.focusTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.focusTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusTitleFontOutlineColorPictureBox.Name = "focusTitleFontOutlineColorPictureBox";
            this.focusTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.focusTitleFontOutlineColorPictureBox.TabIndex = 45;
            this.focusTitleFontOutlineColorPictureBox.TabStop = false;
            this.focusTitleFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusOpenWindowButton
            // 
            this.focusOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.focusOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.focusOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.focusOpenWindowButton.Location = new Point(573, 3);
            this.focusOpenWindowButton.Margin = new Padding(0);
            this.focusOpenWindowButton.Name = "focusOpenWindowButton";
            this.focusOpenWindowButton.Size = new Size(112, 42);
            this.focusOpenWindowButton.TabIndex = 10021;
            this.focusOpenWindowButton.Text = "Open";
            this.focusOpenWindowButton.UseVisualStyleBackColor = false;
            this.focusOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // focusDescriptionOutlinePanel
            // 
            this.focusDescriptionOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.focusDescriptionOutlinePanel.Controls.Add(this.label110);
            this.focusDescriptionOutlinePanel.Controls.Add(this.focusDescriptionFontOutlineColorPictureBox);
            this.focusDescriptionOutlinePanel.Controls.Add(this.focusDescriptionFontOutlineNumericUpDown);
            this.focusDescriptionOutlinePanel.Controls.Add(this.focusDescriptionOutlineCheckBox);
            this.focusDescriptionOutlinePanel.Location = new Point(3, 332);
            this.focusDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionOutlinePanel.Name = "focusDescriptionOutlinePanel";
            this.focusDescriptionOutlinePanel.Size = new Size(694, 35);
            this.focusDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label110
            // 
            this.label110.BackColor = Color.Transparent;
            this.label110.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label110.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label110.Location = new Point(4, 6);
            this.label110.Margin = new Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new Size(216, 25);
            this.label110.TabIndex = 10066;
            this.label110.Text = "Description OutlineColor";
            // 
            // focusDescriptionFontOutlineColorPictureBox
            // 
            this.focusDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            this.focusDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.focusDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionFontOutlineColorPictureBox.Name = "focusDescriptionFontOutlineColorPictureBox";
            this.focusDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.focusDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            this.focusDescriptionFontOutlineColorPictureBox.TabStop = false;
            this.focusDescriptionFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusDescriptionFontOutlineNumericUpDown
            // 
            this.focusDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.focusDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.focusDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            this.focusDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.focusDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.focusDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusDescriptionFontOutlineNumericUpDown.Name = "focusDescriptionFontOutlineNumericUpDown";
            this.focusDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.focusDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            this.focusDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // focusDescriptionOutlineCheckBox
            // 
            this.focusDescriptionOutlineCheckBox.AutoSize = true;
            this.focusDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusDescriptionOutlineCheckBox.Location = new Point(620, 9);
            this.focusDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionOutlineCheckBox.Name = "focusDescriptionOutlineCheckBox";
            this.focusDescriptionOutlineCheckBox.Size = new Size(22, 21);
            this.focusDescriptionOutlineCheckBox.TabIndex = 45;
            this.focusDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            this.focusDescriptionOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // focusDescriptionPanel
            // 
            this.focusDescriptionPanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.focusDescriptionPanel.Controls.Add(this.label101);
            this.focusDescriptionPanel.Controls.Add(this.focusDescriptionFontColorPictureBox);
            this.focusDescriptionPanel.Controls.Add(this.focusDescriptionFontComboBox);
            this.focusDescriptionPanel.Location = new Point(3, 197);
            this.focusDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionPanel.Name = "focusDescriptionPanel";
            this.focusDescriptionPanel.Size = new Size(694, 35);
            this.focusDescriptionPanel.TabIndex = 10061;
            // 
            // label101
            // 
            this.label101.BackColor = Color.Transparent;
            this.label101.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label101.Location = new Point(4, 6);
            this.label101.Margin = new Padding(4, 0, 4, 0);
            this.label101.Name = "label101";
            this.label101.Size = new Size(216, 25);
            this.label101.TabIndex = 10066;
            this.label101.Text = "Description";
            // 
            // focusDescriptionFontColorPictureBox
            // 
            this.focusDescriptionFontColorPictureBox.BackColor = Color.White;
            this.focusDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusDescriptionFontColorPictureBox.Location = new Point(230, 5);
            this.focusDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionFontColorPictureBox.Name = "focusDescriptionFontColorPictureBox";
            this.focusDescriptionFontColorPictureBox.Size = new Size(22, 22);
            this.focusDescriptionFontColorPictureBox.TabIndex = 45;
            this.focusDescriptionFontColorPictureBox.TabStop = false;
            this.focusDescriptionFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusDescriptionFontComboBox
            // 
            this.focusDescriptionFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusDescriptionFontComboBox.ForeColor = Color.White;
            this.focusDescriptionFontComboBox.FormattingEnabled = true;
            this.focusDescriptionFontComboBox.Location = new Point(290, 3);
            this.focusDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.focusDescriptionFontComboBox.Name = "focusDescriptionFontComboBox";
            this.focusDescriptionFontComboBox.Size = new Size(301, 28);
            this.focusDescriptionFontComboBox.TabIndex = 45;
            this.focusDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // focusAutoOpenWindowCheckBox
            // 
            this.focusAutoOpenWindowCheckBox.AutoSize = true;
            this.focusAutoOpenWindowCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.focusAutoOpenWindowCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusAutoOpenWindowCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusAutoOpenWindowCheckBox.Location = new Point(378, 14);
            this.focusAutoOpenWindowCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusAutoOpenWindowCheckBox.Name = "focusAutoOpenWindowCheckBox";
            this.focusAutoOpenWindowCheckBox.Size = new Size(147, 29);
            this.focusAutoOpenWindowCheckBox.TabIndex = 10022;
            this.focusAutoOpenWindowCheckBox.Text = "Auto-Open";
            this.focusAutoOpenWindowCheckBox.UseVisualStyleBackColor = true;
            this.focusAutoOpenWindowCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox11.Location = new Point(3, 49);
            this.pictureBox11.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new Size(690, 3);
            this.pictureBox11.TabIndex = 10063;
            this.pictureBox11.TabStop = false;
            // 
            // panel54
            // 
            this.panel54.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel54.Controls.Add(this.focusBackgroundColorPictureBox);
            this.panel54.Controls.Add(this.label102);
            this.panel54.Location = new Point(3, 95);
            this.panel54.Margin = new Padding(4, 5, 4, 5);
            this.panel54.Name = "panel54";
            this.panel54.Size = new Size(694, 35);
            this.panel54.TabIndex = 10061;
            // 
            // focusBackgroundColorPictureBox
            // 
            this.focusBackgroundColorPictureBox.BackColor = Color.White;
            this.focusBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusBackgroundColorPictureBox.Location = new Point(230, 5);
            this.focusBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusBackgroundColorPictureBox.Name = "focusBackgroundColorPictureBox";
            this.focusBackgroundColorPictureBox.Size = new Size(22, 22);
            this.focusBackgroundColorPictureBox.TabIndex = 42;
            this.focusBackgroundColorPictureBox.TabStop = false;
            this.focusBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label102
            // 
            this.label102.BackColor = Color.Transparent;
            this.label102.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label102.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label102.Location = new Point(4, 5);
            this.label102.Margin = new Padding(4, 0, 4, 0);
            this.label102.Name = "label102";
            this.label102.Size = new Size(216, 25);
            this.label102.TabIndex = 10064;
            this.label102.Text = "Window Background";
            // 
            // panel55
            // 
            this.panel55.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel55.Controls.Add(this.focusTitleLabel);
            this.panel55.Controls.Add(this.focusTitleFontColorPictureBox);
            this.panel55.Controls.Add(this.focusTitleFontComboBox);
            this.panel55.Location = new Point(3, 163);
            this.panel55.Margin = new Padding(4, 5, 4, 5);
            this.panel55.Name = "panel55";
            this.panel55.Size = new Size(694, 35);
            this.panel55.TabIndex = 10061;
            // 
            // focusTitleLabel
            // 
            this.focusTitleLabel.BackColor = Color.Transparent;
            this.focusTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusTitleLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusTitleLabel.Location = new Point(4, 6);
            this.focusTitleLabel.Margin = new Padding(4, 0, 4, 0);
            this.focusTitleLabel.Name = "focusTitleLabel";
            this.focusTitleLabel.Size = new Size(216, 25);
            this.focusTitleLabel.TabIndex = 10065;
            this.focusTitleLabel.Text = "Title";
            // 
            // focusTitleFontColorPictureBox
            // 
            this.focusTitleFontColorPictureBox.BackColor = Color.White;
            this.focusTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusTitleFontColorPictureBox.Location = new Point(230, 6);
            this.focusTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusTitleFontColorPictureBox.Name = "focusTitleFontColorPictureBox";
            this.focusTitleFontColorPictureBox.Size = new Size(22, 22);
            this.focusTitleFontColorPictureBox.TabIndex = 45;
            this.focusTitleFontColorPictureBox.TabStop = false;
            this.focusTitleFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusTitleFontComboBox
            // 
            this.focusTitleFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusTitleFontComboBox.ForeColor = Color.White;
            this.focusTitleFontComboBox.FormattingEnabled = true;
            this.focusTitleFontComboBox.Location = new Point(290, 3);
            this.focusTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.focusTitleFontComboBox.Name = "focusTitleFontComboBox";
            this.focusTitleFontComboBox.Size = new Size(301, 28);
            this.focusTitleFontComboBox.TabIndex = 45;
            this.focusTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // focusPointsOutlinePanel
            // 
            this.focusPointsOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.focusPointsOutlinePanel.Controls.Add(this.focusPointsFontOutlineNumericUpDown);
            this.focusPointsOutlinePanel.Controls.Add(this.focusPointsOutlineCheckBox);
            this.focusPointsOutlinePanel.Controls.Add(this.label104);
            this.focusPointsOutlinePanel.Controls.Add(this.focusPointsFontOutlineColorPictureBox);
            this.focusPointsOutlinePanel.Location = new Point(3, 366);
            this.focusPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsOutlinePanel.Name = "focusPointsOutlinePanel";
            this.focusPointsOutlinePanel.Size = new Size(694, 35);
            this.focusPointsOutlinePanel.TabIndex = 10061;
            // 
            // focusPointsFontOutlineNumericUpDown
            // 
            this.focusPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.focusPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.focusPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            this.focusPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.focusPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.focusPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusPointsFontOutlineNumericUpDown.Name = "focusPointsFontOutlineNumericUpDown";
            this.focusPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.focusPointsFontOutlineNumericUpDown.TabIndex = 45;
            this.focusPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // focusPointsOutlineCheckBox
            // 
            this.focusPointsOutlineCheckBox.AutoSize = true;
            this.focusPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusPointsOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusPointsOutlineCheckBox.Location = new Point(620, 8);
            this.focusPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsOutlineCheckBox.Name = "focusPointsOutlineCheckBox";
            this.focusPointsOutlineCheckBox.Size = new Size(22, 21);
            this.focusPointsOutlineCheckBox.TabIndex = 45;
            this.focusPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            this.focusPointsOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label104
            // 
            this.label104.BackColor = Color.Transparent;
            this.label104.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label104.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label104.Location = new Point(4, 5);
            this.label104.Margin = new Padding(4, 0, 4, 0);
            this.label104.Name = "label104";
            this.label104.Size = new Size(216, 25);
            this.label104.TabIndex = 10066;
            this.label104.Text = "Points OutlineColor";
            // 
            // focusPointsFontOutlineColorPictureBox
            // 
            this.focusPointsFontOutlineColorPictureBox.BackColor = Color.White;
            this.focusPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.focusPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusPointsFontOutlineColorPictureBox.Name = "focusPointsFontOutlineColorPictureBox";
            this.focusPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.focusPointsFontOutlineColorPictureBox.TabIndex = 45;
            this.focusPointsFontOutlineColorPictureBox.TabStop = false;
            this.focusPointsFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusLineOutlinePanel
            // 
            this.focusLineOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.focusLineOutlinePanel.Controls.Add(this.label105);
            this.focusLineOutlinePanel.Controls.Add(this.focusLineOutlineColorPictureBox);
            this.focusLineOutlinePanel.Controls.Add(this.focusLineOutlineNumericUpDown);
            this.focusLineOutlinePanel.Controls.Add(this.focusLineOutlineCheckBox);
            this.focusLineOutlinePanel.Location = new Point(3, 400);
            this.focusLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.focusLineOutlinePanel.Name = "focusLineOutlinePanel";
            this.focusLineOutlinePanel.Size = new Size(694, 35);
            this.focusLineOutlinePanel.TabIndex = 10067;
            // 
            // label105
            // 
            this.label105.BackColor = Color.Transparent;
            this.label105.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label105.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label105.Location = new Point(4, 6);
            this.label105.Margin = new Padding(4, 0, 4, 0);
            this.label105.Name = "label105";
            this.label105.Size = new Size(216, 25);
            this.label105.TabIndex = 10066;
            this.label105.Text = "Line OutlineColor";
            // 
            // focusLineOutlineColorPictureBox
            // 
            this.focusLineOutlineColorPictureBox.BackColor = Color.White;
            this.focusLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.focusLineOutlineColorPictureBox.Location = new Point(230, 6);
            this.focusLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.focusLineOutlineColorPictureBox.Name = "focusLineOutlineColorPictureBox";
            this.focusLineOutlineColorPictureBox.Size = new Size(22, 22);
            this.focusLineOutlineColorPictureBox.TabIndex = 45;
            this.focusLineOutlineColorPictureBox.TabStop = false;
            this.focusLineOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // focusLineOutlineNumericUpDown
            // 
            this.focusLineOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.focusLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.focusLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusLineOutlineNumericUpDown.ForeColor = Color.White;
            this.focusLineOutlineNumericUpDown.Location = new Point(528, 6);
            this.focusLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.focusLineOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.focusLineOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusLineOutlineNumericUpDown.Name = "focusLineOutlineNumericUpDown";
            this.focusLineOutlineNumericUpDown.Size = new Size(64, 24);
            this.focusLineOutlineNumericUpDown.TabIndex = 45;
            this.focusLineOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // focusLineOutlineCheckBox
            // 
            this.focusLineOutlineCheckBox.AutoSize = true;
            this.focusLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.focusLineOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.focusLineOutlineCheckBox.Location = new Point(620, 9);
            this.focusLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.focusLineOutlineCheckBox.Name = "focusLineOutlineCheckBox";
            this.focusLineOutlineCheckBox.Size = new Size(22, 21);
            this.focusLineOutlineCheckBox.TabIndex = 45;
            this.focusLineOutlineCheckBox.UseVisualStyleBackColor = true;
            this.focusLineOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel65
            // 
            this.panel65.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel65.Controls.Add(this.alertsLinePanel);
            this.panel65.Controls.Add(this.label114);
            this.panel65.Controls.Add(this.panel67);
            this.panel65.Controls.Add(this.alertsPointsPanel);
            this.panel65.Controls.Add(this.panel69);
            this.panel65.Controls.Add(this.panel70);
            this.panel65.Controls.Add(this.alertsOpenWindowButton);
            this.panel65.Controls.Add(this.alertsDescriptionOutlinePanel);
            this.panel65.Controls.Add(this.alertsDescriptionPanel);
            this.panel65.Controls.Add(this.alertsAutoOpenWindowCheckbox);
            this.panel65.Controls.Add(this.pictureBox20);
            this.panel65.Controls.Add(this.panel73);
            this.panel65.Controls.Add(this.panel74);
            this.panel65.Controls.Add(this.alertsPointsOutlinePanel);
            this.panel65.Controls.Add(this.alertsLineOutlinePanel);
            this.panel65.Location = new Point(444, 5);
            this.panel65.Margin = new Padding(4, 5, 4, 5);
            this.panel65.Name = "panel65";
            this.panel65.Size = new Size(702, 438);
            this.panel65.TabIndex = 10081;
            // 
            // alertsLinePanel
            // 
            this.alertsLinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsLinePanel.Controls.Add(this.label113);
            this.alertsLinePanel.Controls.Add(this.alertsLineColorPictureBox);
            this.alertsLinePanel.Location = new Point(3, 265);
            this.alertsLinePanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsLinePanel.Name = "alertsLinePanel";
            this.alertsLinePanel.Size = new Size(694, 35);
            this.alertsLinePanel.TabIndex = 10068;
            // 
            // label113
            // 
            this.label113.BackColor = Color.Transparent;
            this.label113.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label113.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label113.Location = new Point(4, 6);
            this.label113.Margin = new Padding(4, 0, 4, 0);
            this.label113.Name = "label113";
            this.label113.Size = new Size(216, 25);
            this.label113.TabIndex = 10066;
            this.label113.Text = "Line";
            // 
            // alertsLineColorPictureBox
            // 
            this.alertsLineColorPictureBox.BackColor = Color.White;
            this.alertsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsLineColorPictureBox.Location = new Point(230, 5);
            this.alertsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsLineColorPictureBox.Name = "alertsLineColorPictureBox";
            this.alertsLineColorPictureBox.Size = new Size(22, 22);
            this.alertsLineColorPictureBox.TabIndex = 45;
            this.alertsLineColorPictureBox.TabStop = false;
            this.alertsLineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label114
            // 
            this.label114.BackColor = Color.Transparent;
            this.label114.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label114.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label114.Location = new Point(4, 5);
            this.label114.Margin = new Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new Size(364, 40);
            this.label114.TabIndex = 10062;
            this.label114.Text = "Window/Font Settings";
            // 
            // panel67
            // 
            this.panel67.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel67.Controls.Add(this.alertsBorderCheckBox);
            this.panel67.Controls.Add(this.alertsBorderColorPictureBox);
            this.panel67.Controls.Add(this.label115);
            this.panel67.Location = new Point(3, 129);
            this.panel67.Margin = new Padding(4, 5, 4, 5);
            this.panel67.Name = "panel67";
            this.panel67.Size = new Size(694, 35);
            this.panel67.TabIndex = 10069;
            // 
            // alertsBorderCheckBox
            // 
            this.alertsBorderCheckBox.AutoSize = true;
            this.alertsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsBorderCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsBorderCheckBox.Location = new Point(620, 8);
            this.alertsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsBorderCheckBox.Name = "alertsBorderCheckBox";
            this.alertsBorderCheckBox.Size = new Size(22, 21);
            this.alertsBorderCheckBox.TabIndex = 10065;
            this.alertsBorderCheckBox.UseVisualStyleBackColor = true;
            this.alertsBorderCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsBorderColorPictureBox
            // 
            this.alertsBorderColorPictureBox.BackColor = Color.White;
            this.alertsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsBorderColorPictureBox.Location = new Point(230, 5);
            this.alertsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsBorderColorPictureBox.Name = "alertsBorderColorPictureBox";
            this.alertsBorderColorPictureBox.Size = new Size(22, 22);
            this.alertsBorderColorPictureBox.TabIndex = 42;
            this.alertsBorderColorPictureBox.TabStop = false;
            this.alertsBorderColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label115
            // 
            this.label115.BackColor = Color.Transparent;
            this.label115.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label115.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label115.Location = new Point(4, 5);
            this.label115.Margin = new Padding(4, 0, 4, 0);
            this.label115.Name = "label115";
            this.label115.Size = new Size(216, 25);
            this.label115.TabIndex = 10064;
            this.label115.Text = "Border";
            // 
            // alertsPointsPanel
            // 
            this.alertsPointsPanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsPointsPanel.Controls.Add(this.label116);
            this.alertsPointsPanel.Controls.Add(this.alertsPointsFontColorPictureBox);
            this.alertsPointsPanel.Controls.Add(this.alertsPointsFontComboBox);
            this.alertsPointsPanel.Location = new Point(3, 231);
            this.alertsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsPanel.Name = "alertsPointsPanel";
            this.alertsPointsPanel.Size = new Size(694, 35);
            this.alertsPointsPanel.TabIndex = 10070;
            // 
            // label116
            // 
            this.label116.BackColor = Color.Transparent;
            this.label116.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label116.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label116.Location = new Point(4, 6);
            this.label116.Margin = new Padding(4, 0, 4, 0);
            this.label116.Name = "label116";
            this.label116.Size = new Size(216, 25);
            this.label116.TabIndex = 10065;
            this.label116.Text = "Points";
            // 
            // alertsPointsFontColorPictureBox
            // 
            this.alertsPointsFontColorPictureBox.BackColor = Color.White;
            this.alertsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsPointsFontColorPictureBox.Location = new Point(230, 6);
            this.alertsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsFontColorPictureBox.Name = "alertsPointsFontColorPictureBox";
            this.alertsPointsFontColorPictureBox.Size = new Size(22, 22);
            this.alertsPointsFontColorPictureBox.TabIndex = 45;
            this.alertsPointsFontColorPictureBox.TabStop = false;
            this.alertsPointsFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsPointsFontComboBox
            // 
            this.alertsPointsFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsPointsFontComboBox.FlatStyle = FlatStyle.System;
            this.alertsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsPointsFontComboBox.ForeColor = Color.White;
            this.alertsPointsFontComboBox.FormattingEnabled = true;
            this.alertsPointsFontComboBox.Location = new Point(290, 3);
            this.alertsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsFontComboBox.Name = "alertsPointsFontComboBox";
            this.alertsPointsFontComboBox.Size = new Size(301, 28);
            this.alertsPointsFontComboBox.TabIndex = 45;
            this.alertsPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel69
            // 
            this.panel69.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel69.Controls.Add(this.alertsAdvancedCheckBox);
            this.panel69.Controls.Add(this.label117);
            this.panel69.Controls.Add(this.label118);
            this.panel69.Controls.Add(this.label119);
            this.panel69.Controls.Add(this.label120);
            this.panel69.Location = new Point(3, 62);
            this.panel69.Margin = new Padding(4, 5, 4, 5);
            this.panel69.Name = "panel69";
            this.panel69.Size = new Size(694, 35);
            this.panel69.TabIndex = 10076;
            // 
            // alertsAdvancedCheckBox
            // 
            this.alertsAdvancedCheckBox.AutoSize = true;
            this.alertsAdvancedCheckBox.BackColor = Color.Transparent;
            this.alertsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.alertsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsAdvancedCheckBox.Location = new Point(8, 3);
            this.alertsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsAdvancedCheckBox.Name = "alertsAdvancedCheckBox";
            this.alertsAdvancedCheckBox.Size = new Size(135, 29);
            this.alertsAdvancedCheckBox.TabIndex = 10053;
            this.alertsAdvancedCheckBox.Text = "Advanced";
            this.alertsAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.alertsAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label117
            // 
            this.label117.BackColor = Color.Transparent;
            this.label117.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label117.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label117.Location = new Point(225, 5);
            this.label117.Margin = new Padding(4, 0, 4, 0);
            this.label117.Name = "label117";
            this.label117.Size = new Size(72, 25);
            this.label117.TabIndex = 10065;
            this.label117.Text = "Color";
            // 
            // label118
            // 
            this.label118.BackColor = Color.Transparent;
            this.label118.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label118.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label118.Location = new Point(291, 5);
            this.label118.Margin = new Padding(4, 0, 4, 0);
            this.label118.Name = "label118";
            this.label118.Size = new Size(75, 25);
            this.label118.TabIndex = 10066;
            this.label118.Text = "Font";
            // 
            // label119
            // 
            this.label119.BackColor = Color.Transparent;
            this.label119.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label119.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label119.Location = new Point(524, 5);
            this.label119.Margin = new Padding(4, 0, 4, 0);
            this.label119.Name = "label119";
            this.label119.Size = new Size(62, 25);
            this.label119.TabIndex = 10068;
            this.label119.Text = "Size";
            // 
            // label120
            // 
            this.label120.BackColor = Color.Transparent;
            this.label120.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label120.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label120.Location = new Point(594, 5);
            this.label120.Margin = new Padding(4, 0, 4, 0);
            this.label120.Name = "label120";
            this.label120.Size = new Size(88, 25);
            this.label120.TabIndex = 10067;
            this.label120.Text = "Enabled";
            // 
            // panel70
            // 
            this.panel70.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel70.Controls.Add(this.alertsTitleFontOutlineNumericUpDown);
            this.panel70.Controls.Add(this.alertsTitleOutlineCheckBox);
            this.panel70.Controls.Add(this.alertsTitleOutlineLabel);
            this.panel70.Controls.Add(this.alertsTitleFontOutlineColorPictureBox);
            this.panel70.Location = new Point(3, 298);
            this.panel70.Margin = new Padding(4, 5, 4, 5);
            this.panel70.Name = "panel70";
            this.panel70.Size = new Size(694, 35);
            this.panel70.TabIndex = 10071;
            // 
            // alertsTitleFontOutlineNumericUpDown
            // 
            this.alertsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            this.alertsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.alertsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsTitleFontOutlineNumericUpDown.Name = "alertsTitleFontOutlineNumericUpDown";
            this.alertsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.alertsTitleFontOutlineNumericUpDown.TabIndex = 45;
            this.alertsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsTitleOutlineCheckBox
            // 
            this.alertsTitleOutlineCheckBox.AutoSize = true;
            this.alertsTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsTitleOutlineCheckBox.Location = new Point(620, 8);
            this.alertsTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsTitleOutlineCheckBox.Name = "alertsTitleOutlineCheckBox";
            this.alertsTitleOutlineCheckBox.Size = new Size(22, 21);
            this.alertsTitleOutlineCheckBox.TabIndex = 45;
            this.alertsTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            this.alertsTitleOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsTitleOutlineLabel
            // 
            this.alertsTitleOutlineLabel.BackColor = Color.Transparent;
            this.alertsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsTitleOutlineLabel.Location = new Point(4, 5);
            this.alertsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.alertsTitleOutlineLabel.Name = "alertsTitleOutlineLabel";
            this.alertsTitleOutlineLabel.Size = new Size(216, 25);
            this.alertsTitleOutlineLabel.TabIndex = 10066;
            this.alertsTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // alertsTitleFontOutlineColorPictureBox
            // 
            this.alertsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            this.alertsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.alertsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsTitleFontOutlineColorPictureBox.Name = "alertsTitleFontOutlineColorPictureBox";
            this.alertsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.alertsTitleFontOutlineColorPictureBox.TabIndex = 45;
            this.alertsTitleFontOutlineColorPictureBox.TabStop = false;
            this.alertsTitleFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsOpenWindowButton
            // 
            this.alertsOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.alertsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.alertsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.alertsOpenWindowButton.Location = new Point(573, 3);
            this.alertsOpenWindowButton.Margin = new Padding(0);
            this.alertsOpenWindowButton.Name = "alertsOpenWindowButton";
            this.alertsOpenWindowButton.Size = new Size(112, 42);
            this.alertsOpenWindowButton.TabIndex = 10021;
            this.alertsOpenWindowButton.Text = "Open";
            this.alertsOpenWindowButton.UseVisualStyleBackColor = false;
            this.alertsOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // alertsDescriptionOutlinePanel
            // 
            this.alertsDescriptionOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsDescriptionOutlinePanel.Controls.Add(this.label122);
            this.alertsDescriptionOutlinePanel.Controls.Add(this.alertsDescriptionFontOutlineColorPictureBox);
            this.alertsDescriptionOutlinePanel.Controls.Add(this.alertsDescriptionFontOutlineNumericUpDown);
            this.alertsDescriptionOutlinePanel.Controls.Add(this.alertsDescriptionOutlineCheckBox);
            this.alertsDescriptionOutlinePanel.Location = new Point(3, 332);
            this.alertsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionOutlinePanel.Name = "alertsDescriptionOutlinePanel";
            this.alertsDescriptionOutlinePanel.Size = new Size(694, 35);
            this.alertsDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label122
            // 
            this.label122.BackColor = Color.Transparent;
            this.label122.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label122.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label122.Location = new Point(4, 6);
            this.label122.Margin = new Padding(4, 0, 4, 0);
            this.label122.Name = "label122";
            this.label122.Size = new Size(216, 25);
            this.label122.TabIndex = 10066;
            this.label122.Text = "Description OutlineColor";
            // 
            // alertsDescriptionFontOutlineColorPictureBox
            // 
            this.alertsDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            this.alertsDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.alertsDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionFontOutlineColorPictureBox.Name = "alertsDescriptionFontOutlineColorPictureBox";
            this.alertsDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.alertsDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            this.alertsDescriptionFontOutlineColorPictureBox.TabStop = false;
            this.alertsDescriptionFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsDescriptionFontOutlineNumericUpDown
            // 
            this.alertsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            this.alertsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.alertsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsDescriptionFontOutlineNumericUpDown.Name = "alertsDescriptionFontOutlineNumericUpDown";
            this.alertsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.alertsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            this.alertsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsDescriptionOutlineCheckBox
            // 
            this.alertsDescriptionOutlineCheckBox.AutoSize = true;
            this.alertsDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsDescriptionOutlineCheckBox.Location = new Point(620, 9);
            this.alertsDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionOutlineCheckBox.Name = "alertsDescriptionOutlineCheckBox";
            this.alertsDescriptionOutlineCheckBox.Size = new Size(22, 21);
            this.alertsDescriptionOutlineCheckBox.TabIndex = 45;
            this.alertsDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            this.alertsDescriptionOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsDescriptionPanel
            // 
            this.alertsDescriptionPanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsDescriptionPanel.Controls.Add(this.label123);
            this.alertsDescriptionPanel.Controls.Add(this.alertsDescriptionFontColorPictureBox);
            this.alertsDescriptionPanel.Controls.Add(this.alertsDescriptionFontComboBox);
            this.alertsDescriptionPanel.Location = new Point(3, 197);
            this.alertsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionPanel.Name = "alertsDescriptionPanel";
            this.alertsDescriptionPanel.Size = new Size(694, 35);
            this.alertsDescriptionPanel.TabIndex = 10061;
            // 
            // label123
            // 
            this.label123.BackColor = Color.Transparent;
            this.label123.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label123.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label123.Location = new Point(4, 6);
            this.label123.Margin = new Padding(4, 0, 4, 0);
            this.label123.Name = "label123";
            this.label123.Size = new Size(216, 25);
            this.label123.TabIndex = 10066;
            this.label123.Text = "Description";
            // 
            // alertsDescriptionFontColorPictureBox
            // 
            this.alertsDescriptionFontColorPictureBox.BackColor = Color.White;
            this.alertsDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsDescriptionFontColorPictureBox.Location = new Point(230, 5);
            this.alertsDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionFontColorPictureBox.Name = "alertsDescriptionFontColorPictureBox";
            this.alertsDescriptionFontColorPictureBox.Size = new Size(22, 22);
            this.alertsDescriptionFontColorPictureBox.TabIndex = 45;
            this.alertsDescriptionFontColorPictureBox.TabStop = false;
            this.alertsDescriptionFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsDescriptionFontComboBox
            // 
            this.alertsDescriptionFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsDescriptionFontComboBox.FlatStyle = FlatStyle.System;
            this.alertsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsDescriptionFontComboBox.ForeColor = Color.White;
            this.alertsDescriptionFontComboBox.FormattingEnabled = true;
            this.alertsDescriptionFontComboBox.Location = new Point(290, 3);
            this.alertsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsDescriptionFontComboBox.Name = "alertsDescriptionFontComboBox";
            this.alertsDescriptionFontComboBox.Size = new Size(301, 28);
            this.alertsDescriptionFontComboBox.TabIndex = 45;
            this.alertsDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // alertsAutoOpenWindowCheckbox
            // 
            this.alertsAutoOpenWindowCheckbox.AutoSize = true;
            this.alertsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.alertsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.alertsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsAutoOpenWindowCheckbox.Name = "alertsAutoOpenWindowCheckbox";
            this.alertsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.alertsAutoOpenWindowCheckbox.TabIndex = 10022;
            this.alertsAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.alertsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.alertsAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox20.Location = new Point(3, 49);
            this.pictureBox20.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new Size(690, 3);
            this.pictureBox20.TabIndex = 10063;
            this.pictureBox20.TabStop = false;
            // 
            // panel73
            // 
            this.panel73.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel73.Controls.Add(this.alertsBackgroundColorPictureBox);
            this.panel73.Controls.Add(this.label124);
            this.panel73.Location = new Point(3, 95);
            this.panel73.Margin = new Padding(4, 5, 4, 5);
            this.panel73.Name = "panel73";
            this.panel73.Size = new Size(694, 35);
            this.panel73.TabIndex = 10061;
            // 
            // alertsBackgroundColorPictureBox
            // 
            this.alertsBackgroundColorPictureBox.BackColor = Color.White;
            this.alertsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsBackgroundColorPictureBox.Location = new Point(230, 5);
            this.alertsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsBackgroundColorPictureBox.Name = "alertsBackgroundColorPictureBox";
            this.alertsBackgroundColorPictureBox.Size = new Size(22, 22);
            this.alertsBackgroundColorPictureBox.TabIndex = 42;
            this.alertsBackgroundColorPictureBox.TabStop = false;
            this.alertsBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label124
            // 
            this.label124.BackColor = Color.Transparent;
            this.label124.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label124.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label124.Location = new Point(4, 5);
            this.label124.Margin = new Padding(4, 0, 4, 0);
            this.label124.Name = "label124";
            this.label124.Size = new Size(216, 25);
            this.label124.TabIndex = 10064;
            this.label124.Text = "Window Background";
            // 
            // panel74
            // 
            this.panel74.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel74.Controls.Add(this.alertsTitleLabel);
            this.panel74.Controls.Add(this.alertsTitleFontColorPictureBox);
            this.panel74.Controls.Add(this.alertsTitleFontComboBox);
            this.panel74.Location = new Point(3, 163);
            this.panel74.Margin = new Padding(4, 5, 4, 5);
            this.panel74.Name = "panel74";
            this.panel74.Size = new Size(694, 35);
            this.panel74.TabIndex = 10061;
            // 
            // alertsTitleLabel
            // 
            this.alertsTitleLabel.BackColor = Color.Transparent;
            this.alertsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsTitleLabel.Location = new Point(4, 6);
            this.alertsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            this.alertsTitleLabel.Name = "alertsTitleLabel";
            this.alertsTitleLabel.Size = new Size(216, 25);
            this.alertsTitleLabel.TabIndex = 10065;
            this.alertsTitleLabel.Text = "Title";
            // 
            // alertsTitleFontColorPictureBox
            // 
            this.alertsTitleFontColorPictureBox.BackColor = Color.White;
            this.alertsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsTitleFontColorPictureBox.Location = new Point(230, 6);
            this.alertsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsTitleFontColorPictureBox.Name = "alertsTitleFontColorPictureBox";
            this.alertsTitleFontColorPictureBox.Size = new Size(22, 22);
            this.alertsTitleFontColorPictureBox.TabIndex = 45;
            this.alertsTitleFontColorPictureBox.TabStop = false;
            this.alertsTitleFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsTitleFontComboBox
            // 
            this.alertsTitleFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsTitleFontComboBox.FlatStyle = FlatStyle.System;
            this.alertsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleFontComboBox.ForeColor = Color.White;
            this.alertsTitleFontComboBox.FormattingEnabled = true;
            this.alertsTitleFontComboBox.Location = new Point(290, 3);
            this.alertsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsTitleFontComboBox.Name = "alertsTitleFontComboBox";
            this.alertsTitleFontComboBox.Size = new Size(301, 28);
            this.alertsTitleFontComboBox.TabIndex = 45;
            this.alertsTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // alertsPointsOutlinePanel
            // 
            this.alertsPointsOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsPointsOutlinePanel.Controls.Add(this.alertsPointsFontOutlineNumericUpDown);
            this.alertsPointsOutlinePanel.Controls.Add(this.alertsPointsOutlineCheckBox);
            this.alertsPointsOutlinePanel.Controls.Add(this.label126);
            this.alertsPointsOutlinePanel.Controls.Add(this.alertsPointsFontOutlineColorPictureBox);
            this.alertsPointsOutlinePanel.Location = new Point(3, 366);
            this.alertsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsOutlinePanel.Name = "alertsPointsOutlinePanel";
            this.alertsPointsOutlinePanel.Size = new Size(694, 35);
            this.alertsPointsOutlinePanel.TabIndex = 10061;
            // 
            // alertsPointsFontOutlineNumericUpDown
            // 
            this.alertsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            this.alertsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.alertsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsPointsFontOutlineNumericUpDown.Name = "alertsPointsFontOutlineNumericUpDown";
            this.alertsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.alertsPointsFontOutlineNumericUpDown.TabIndex = 45;
            this.alertsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsPointsOutlineCheckBox
            // 
            this.alertsPointsOutlineCheckBox.AutoSize = true;
            this.alertsPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsPointsOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsPointsOutlineCheckBox.Location = new Point(620, 8);
            this.alertsPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsOutlineCheckBox.Name = "alertsPointsOutlineCheckBox";
            this.alertsPointsOutlineCheckBox.Size = new Size(22, 21);
            this.alertsPointsOutlineCheckBox.TabIndex = 45;
            this.alertsPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            this.alertsPointsOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label126
            // 
            this.label126.BackColor = Color.Transparent;
            this.label126.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label126.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label126.Location = new Point(4, 5);
            this.label126.Margin = new Padding(4, 0, 4, 0);
            this.label126.Name = "label126";
            this.label126.Size = new Size(216, 25);
            this.label126.TabIndex = 10066;
            this.label126.Text = "Points OutlineColor";
            // 
            // alertsPointsFontOutlineColorPictureBox
            // 
            this.alertsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            this.alertsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.alertsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsPointsFontOutlineColorPictureBox.Name = "alertsPointsFontOutlineColorPictureBox";
            this.alertsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.alertsPointsFontOutlineColorPictureBox.TabIndex = 45;
            this.alertsPointsFontOutlineColorPictureBox.TabStop = false;
            this.alertsPointsFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsLineOutlinePanel
            // 
            this.alertsLineOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsLineOutlinePanel.Controls.Add(this.label127);
            this.alertsLineOutlinePanel.Controls.Add(this.alertsLineOutlineColorPictureBox);
            this.alertsLineOutlinePanel.Controls.Add(this.alertsLineOutlineNumericUpDown);
            this.alertsLineOutlinePanel.Controls.Add(this.alertsLineOutlineCheckBox);
            this.alertsLineOutlinePanel.Location = new Point(3, 400);
            this.alertsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsLineOutlinePanel.Name = "alertsLineOutlinePanel";
            this.alertsLineOutlinePanel.Size = new Size(694, 35);
            this.alertsLineOutlinePanel.TabIndex = 10067;
            // 
            // label127
            // 
            this.label127.BackColor = Color.Transparent;
            this.label127.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label127.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label127.Location = new Point(4, 6);
            this.label127.Margin = new Padding(4, 0, 4, 0);
            this.label127.Name = "label127";
            this.label127.Size = new Size(216, 25);
            this.label127.TabIndex = 10066;
            this.label127.Text = "Line OutlineColor";
            // 
            // alertsLineOutlineColorPictureBox
            // 
            this.alertsLineOutlineColorPictureBox.BackColor = Color.White;
            this.alertsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.alertsLineOutlineColorPictureBox.Location = new Point(230, 6);
            this.alertsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsLineOutlineColorPictureBox.Name = "alertsLineOutlineColorPictureBox";
            this.alertsLineOutlineColorPictureBox.Size = new Size(22, 22);
            this.alertsLineOutlineColorPictureBox.TabIndex = 45;
            this.alertsLineOutlineColorPictureBox.TabStop = false;
            this.alertsLineOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // alertsLineOutlineNumericUpDown
            // 
            this.alertsLineOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.alertsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.alertsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsLineOutlineNumericUpDown.ForeColor = Color.White;
            this.alertsLineOutlineNumericUpDown.Location = new Point(528, 6);
            this.alertsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.alertsLineOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alertsLineOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsLineOutlineNumericUpDown.Name = "alertsLineOutlineNumericUpDown";
            this.alertsLineOutlineNumericUpDown.Size = new Size(64, 24);
            this.alertsLineOutlineNumericUpDown.TabIndex = 45;
            this.alertsLineOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alertsLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // alertsLineOutlineCheckBox
            // 
            this.alertsLineOutlineCheckBox.AutoSize = true;
            this.alertsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsLineOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsLineOutlineCheckBox.Location = new Point(620, 9);
            this.alertsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.alertsLineOutlineCheckBox.Name = "alertsLineOutlineCheckBox";
            this.alertsLineOutlineCheckBox.Size = new Size(22, 21);
            this.alertsLineOutlineCheckBox.TabIndex = 45;
            this.alertsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            this.alertsLineOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // alertsCustomAchievementPanel
            // 
            this.alertsCustomAchievementPanel.Controls.Add(this.panel85);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel84);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel86);
            this.alertsCustomAchievementPanel.Controls.Add(this.alertsSelectCustomAchievementFileButton);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel83);
            this.alertsCustomAchievementPanel.Controls.Add(this.alertsAchievementEditOutlineCheckbox);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel87);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel78);
            this.alertsCustomAchievementPanel.Controls.Add(this.label130);
            this.alertsCustomAchievementPanel.Controls.Add(this.pictureBox13);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel79);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel80);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel81);
            this.alertsCustomAchievementPanel.Controls.Add(this.panel82);
            this.alertsCustomAchievementPanel.Location = new Point(4, 49);
            this.alertsCustomAchievementPanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomAchievementPanel.Name = "alertsCustomAchievementPanel";
            this.alertsCustomAchievementPanel.Size = new Size(417, 452);
            this.alertsCustomAchievementPanel.TabIndex = 10082;
            // 
            // panel85
            // 
            this.panel85.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel85.Controls.Add(this.label136);
            this.panel85.Controls.Add(this.alertsCustomAchievementAnimationOutComboBox);
            this.panel85.Location = new Point(3, 366);
            this.panel85.Margin = new Padding(4, 5, 4, 5);
            this.panel85.Name = "panel85";
            this.panel85.Size = new Size(408, 34);
            this.panel85.TabIndex = 10074;
            // 
            // label136
            // 
            this.label136.BackColor = Color.Transparent;
            this.label136.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label136.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label136.Location = new Point(4, 6);
            this.label136.Margin = new Padding(4, 0, 4, 0);
            this.label136.Name = "label136";
            this.label136.Size = new Size(238, 25);
            this.label136.TabIndex = 10069;
            this.label136.Text = "Animate Out Direction";
            // 
            // panel84
            // 
            this.panel84.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel84.Controls.Add(this.label135);
            this.panel84.Controls.Add(this.alertsCustomAchievementAnimationInComboBox);
            this.panel84.Location = new Point(3, 265);
            this.panel84.Margin = new Padding(4, 5, 4, 5);
            this.panel84.Name = "panel84";
            this.panel84.Size = new Size(408, 34);
            this.panel84.TabIndex = 10071;
            // 
            // label135
            // 
            this.label135.BackColor = Color.Transparent;
            this.label135.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label135.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label135.Location = new Point(4, 6);
            this.label135.Margin = new Padding(4, 0, 4, 0);
            this.label135.Name = "label135";
            this.label135.Size = new Size(225, 25);
            this.label135.TabIndex = 10069;
            this.label135.Text = "Animate In Direction";
            // 
            // panel86
            // 
            this.panel86.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel86.Controls.Add(this.label137);
            this.panel86.Controls.Add(this.alertsCustomAchievementOutSpeedUpDown);
            this.panel86.Location = new Point(3, 332);
            this.panel86.Margin = new Padding(4, 5, 4, 5);
            this.panel86.Name = "panel86";
            this.panel86.Size = new Size(408, 34);
            this.panel86.TabIndex = 10073;
            // 
            // label137
            // 
            this.label137.BackColor = Color.Transparent;
            this.label137.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label137.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label137.Location = new Point(4, 6);
            this.label137.Margin = new Padding(4, 0, 4, 0);
            this.label137.Name = "label137";
            this.label137.Size = new Size(225, 25);
            this.label137.TabIndex = 10069;
            this.label137.Text = "Animate Out Duration";
            // 
            // panel83
            // 
            this.panel83.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel83.Controls.Add(this.label129);
            this.panel83.Controls.Add(this.alertsCustomAchievementInSpeedUpDown);
            this.panel83.Location = new Point(3, 231);
            this.panel83.Margin = new Padding(4, 5, 4, 5);
            this.panel83.Name = "panel83";
            this.panel83.Size = new Size(408, 34);
            this.panel83.TabIndex = 10070;
            // 
            // label129
            // 
            this.label129.BackColor = Color.Transparent;
            this.label129.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label129.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label129.Location = new Point(4, 6);
            this.label129.Margin = new Padding(4, 0, 4, 0);
            this.label129.Name = "label129";
            this.label129.Size = new Size(225, 25);
            this.label129.TabIndex = 10069;
            this.label129.Text = "Animate In Duration";
            // 
            // panel87
            // 
            this.panel87.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel87.Controls.Add(this.label138);
            this.panel87.Controls.Add(this.alertsCustomAchievementOutNumericUpDown);
            this.panel87.Location = new Point(3, 298);
            this.panel87.Margin = new Padding(4, 5, 4, 5);
            this.panel87.Name = "panel87";
            this.panel87.Size = new Size(408, 35);
            this.panel87.TabIndex = 10072;
            // 
            // label138
            // 
            this.label138.BackColor = Color.Transparent;
            this.label138.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label138.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label138.Location = new Point(4, 6);
            this.label138.Margin = new Padding(4, 0, 4, 0);
            this.label138.Name = "label138";
            this.label138.Size = new Size(225, 25);
            this.label138.TabIndex = 10069;
            this.label138.Text = "Animate Out Time";
            // 
            // panel78
            // 
            this.panel78.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel78.Controls.Add(this.label42);
            this.panel78.Controls.Add(this.label128);
            this.panel78.Location = new Point(3, 62);
            this.panel78.Margin = new Padding(4, 5, 4, 5);
            this.panel78.Name = "panel78";
            this.panel78.Size = new Size(408, 35);
            this.panel78.TabIndex = 10079;
            // 
            // label42
            // 
            this.label42.BackColor = Color.Transparent;
            this.label42.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label42.Location = new Point(4, 5);
            this.label42.Margin = new Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new Size(75, 25);
            this.label42.TabIndex = 10071;
            this.label42.Text = "Field";
            // 
            // label128
            // 
            this.label128.BackColor = Color.Transparent;
            this.label128.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label128.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label128.Location = new Point(279, 5);
            this.label128.Margin = new Padding(4, 0, 4, 0);
            this.label128.Name = "label128";
            this.label128.Size = new Size(87, 25);
            this.label128.TabIndex = 10073;
            this.label128.Text = "Value";
            // 
            // label130
            // 
            this.label130.BackColor = Color.Transparent;
            this.label130.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label130.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label130.Location = new Point(4, 5);
            this.label130.Margin = new Padding(4, 0, 4, 0);
            this.label130.Name = "label130";
            this.label130.Size = new Size(228, 40);
            this.label130.TabIndex = 10069;
            this.label130.Text = "Achievement";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox13.Location = new Point(3, 49);
            this.pictureBox13.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new Size(398, 3);
            this.pictureBox13.TabIndex = 10070;
            this.pictureBox13.TabStop = false;
            // 
            // panel79
            // 
            this.panel79.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel79.Controls.Add(this.label131);
            this.panel79.Controls.Add(this.alertsCustomAchievementXNumericUpDown);
            this.panel79.Location = new Point(3, 95);
            this.panel79.Margin = new Padding(4, 5, 4, 5);
            this.panel79.Name = "panel79";
            this.panel79.Size = new Size(408, 35);
            this.panel79.TabIndex = 10061;
            // 
            // label131
            // 
            this.label131.BackColor = Color.Transparent;
            this.label131.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label131.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label131.Location = new Point(4, 5);
            this.label131.Margin = new Padding(4, 0, 4, 0);
            this.label131.Name = "label131";
            this.label131.Size = new Size(141, 25);
            this.label131.TabIndex = 10066;
            this.label131.Text = "X position";
            // 
            // panel80
            // 
            this.panel80.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel80.Controls.Add(this.label132);
            this.panel80.Controls.Add(this.alertsCustomAchievementInNumericUpDown);
            this.panel80.Location = new Point(3, 197);
            this.panel80.Margin = new Padding(4, 5, 4, 5);
            this.panel80.Name = "panel80";
            this.panel80.Size = new Size(408, 35);
            this.panel80.TabIndex = 10061;
            // 
            // label132
            // 
            this.label132.BackColor = Color.Transparent;
            this.label132.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label132.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label132.Location = new Point(4, 6);
            this.label132.Margin = new Padding(4, 0, 4, 0);
            this.label132.Name = "label132";
            this.label132.Size = new Size(225, 25);
            this.label132.TabIndex = 10069;
            this.label132.Text = "Animate In Time";
            // 
            // panel81
            // 
            this.panel81.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel81.Controls.Add(this.label133);
            this.panel81.Controls.Add(this.alertsCustomAchievementScaleNumericUpDown);
            this.panel81.Location = new Point(3, 163);
            this.panel81.Margin = new Padding(4, 5, 4, 5);
            this.panel81.Name = "panel81";
            this.panel81.Size = new Size(408, 35);
            this.panel81.TabIndex = 10061;
            // 
            // label133
            // 
            this.label133.BackColor = Color.Transparent;
            this.label133.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label133.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label133.Location = new Point(4, 6);
            this.label133.Margin = new Padding(4, 0, 4, 0);
            this.label133.Name = "label133";
            this.label133.Size = new Size(141, 25);
            this.label133.TabIndex = 10068;
            this.label133.Text = "Scale";
            // 
            // panel82
            // 
            this.panel82.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel82.Controls.Add(this.label134);
            this.panel82.Controls.Add(this.alertsCustomAchievementYNumericUpDown);
            this.panel82.Location = new Point(3, 129);
            this.panel82.Margin = new Padding(4, 5, 4, 5);
            this.panel82.Name = "panel82";
            this.panel82.Size = new Size(408, 35);
            this.panel82.TabIndex = 10061;
            // 
            // label134
            // 
            this.label134.BackColor = Color.Transparent;
            this.label134.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label134.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label134.Location = new Point(4, 6);
            this.label134.Margin = new Padding(4, 0, 4, 0);
            this.label134.Name = "label134";
            this.label134.Size = new Size(141, 25);
            this.label134.TabIndex = 10067;
            this.label134.Text = "Y position";
            // 
            // alertsAchievementEnableCheckbox
            // 
            this.alertsAchievementEnableCheckbox.AutoSize = true;
            this.alertsAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsAchievementEnableCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsAchievementEnableCheckbox.Location = new Point(16, 9);
            this.alertsAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsAchievementEnableCheckbox.Name = "alertsAchievementEnableCheckbox";
            this.alertsAchievementEnableCheckbox.Size = new Size(106, 29);
            this.alertsAchievementEnableCheckbox.TabIndex = 54;
            this.alertsAchievementEnableCheckbox.Text = "Enable";
            this.alertsAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            this.alertsAchievementEnableCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // alertsCustomMasteryPanel
            // 
            this.alertsCustomMasteryPanel.Controls.Add(this.panel89);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel90);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel91);
            this.alertsCustomMasteryPanel.Controls.Add(this.alertsMasteryEditOutlineCheckbox);
            this.alertsCustomMasteryPanel.Controls.Add(this.alertsSelectCustomMasteryFileButton);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel92);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel93);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel94);
            this.alertsCustomMasteryPanel.Controls.Add(this.label139);
            this.alertsCustomMasteryPanel.Controls.Add(this.pictureBox14);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel95);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel96);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel97);
            this.alertsCustomMasteryPanel.Controls.Add(this.panel98);
            this.alertsCustomMasteryPanel.Location = new Point(4, 49);
            this.alertsCustomMasteryPanel.Margin = new Padding(4, 5, 4, 5);
            this.alertsCustomMasteryPanel.Name = "alertsCustomMasteryPanel";
            this.alertsCustomMasteryPanel.Size = new Size(418, 452);
            this.alertsCustomMasteryPanel.TabIndex = 10083;
            // 
            // panel89
            // 
            this.panel89.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel89.Controls.Add(this.label6);
            this.panel89.Controls.Add(this.alertsCustomMasteryAnimationOutComboBox);
            this.panel89.Location = new Point(3, 366);
            this.panel89.Margin = new Padding(4, 5, 4, 5);
            this.panel89.Name = "panel89";
            this.panel89.Size = new Size(408, 35);
            this.panel89.TabIndex = 10074;
            // 
            // label6
            // 
            this.label6.BackColor = Color.Transparent;
            this.label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label6.Location = new Point(4, 6);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(238, 25);
            this.label6.TabIndex = 10069;
            this.label6.Text = "Animate Out Direction";
            // 
            // panel90
            // 
            this.panel90.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel90.Controls.Add(this.label7);
            this.panel90.Controls.Add(this.alertsCustomMasteryAnimationInComboBox);
            this.panel90.Location = new Point(3, 265);
            this.panel90.Margin = new Padding(4, 5, 4, 5);
            this.panel90.Name = "panel90";
            this.panel90.Size = new Size(408, 35);
            this.panel90.TabIndex = 10071;
            // 
            // label7
            // 
            this.label7.BackColor = Color.Transparent;
            this.label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label7.Location = new Point(4, 6);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(225, 25);
            this.label7.TabIndex = 10069;
            this.label7.Text = "Animate In Direction";
            // 
            // panel91
            // 
            this.panel91.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel91.Controls.Add(this.label8);
            this.panel91.Controls.Add(this.alertsCustomMasteryOutSpeedUpDown);
            this.panel91.Location = new Point(3, 332);
            this.panel91.Margin = new Padding(4, 5, 4, 5);
            this.panel91.Name = "panel91";
            this.panel91.Size = new Size(408, 35);
            this.panel91.TabIndex = 10073;
            // 
            // label8
            // 
            this.label8.BackColor = Color.Transparent;
            this.label8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label8.Location = new Point(4, 6);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(225, 25);
            this.label8.TabIndex = 10069;
            this.label8.Text = "Animate Out Duration";
            // 
            // panel92
            // 
            this.panel92.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel92.Controls.Add(this.label11);
            this.panel92.Controls.Add(this.alertsCustomMasteryInSpeedUpDown);
            this.panel92.Location = new Point(3, 231);
            this.panel92.Margin = new Padding(4, 5, 4, 5);
            this.panel92.Name = "panel92";
            this.panel92.Size = new Size(408, 35);
            this.panel92.TabIndex = 10070;
            // 
            // label11
            // 
            this.label11.BackColor = Color.Transparent;
            this.label11.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label11.Location = new Point(4, 6);
            this.label11.Margin = new Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(225, 25);
            this.label11.TabIndex = 10069;
            this.label11.Text = "Animate In Duration";
            // 
            // panel93
            // 
            this.panel93.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel93.Controls.Add(this.label12);
            this.panel93.Controls.Add(this.alertsCustomMasteryOutNumericUpDown);
            this.panel93.Location = new Point(3, 298);
            this.panel93.Margin = new Padding(4, 5, 4, 5);
            this.panel93.Name = "panel93";
            this.panel93.Size = new Size(408, 35);
            this.panel93.TabIndex = 10072;
            // 
            // label12
            // 
            this.label12.BackColor = Color.Transparent;
            this.label12.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label12.Location = new Point(4, 6);
            this.label12.Margin = new Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new Size(225, 25);
            this.label12.TabIndex = 10069;
            this.label12.Text = "Animate Out Time";
            // 
            // panel94
            // 
            this.panel94.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel94.Controls.Add(this.label13);
            this.panel94.Controls.Add(this.label14);
            this.panel94.Location = new Point(3, 62);
            this.panel94.Margin = new Padding(4, 5, 4, 5);
            this.panel94.Name = "panel94";
            this.panel94.Size = new Size(408, 35);
            this.panel94.TabIndex = 10079;
            // 
            // label13
            // 
            this.label13.BackColor = Color.Transparent;
            this.label13.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label13.Location = new Point(4, 5);
            this.label13.Margin = new Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(75, 25);
            this.label13.TabIndex = 10071;
            this.label13.Text = "Field";
            // 
            // label14
            // 
            this.label14.BackColor = Color.Transparent;
            this.label14.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label14.Location = new Point(279, 5);
            this.label14.Margin = new Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new Size(87, 25);
            this.label14.TabIndex = 10073;
            this.label14.Text = "Value";
            // 
            // label139
            // 
            this.label139.BackColor = Color.Transparent;
            this.label139.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label139.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label139.Location = new Point(4, 5);
            this.label139.Margin = new Padding(4, 0, 4, 0);
            this.label139.Name = "label139";
            this.label139.Size = new Size(228, 40);
            this.label139.TabIndex = 10069;
            this.label139.Text = "Mastery";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox14.Location = new Point(3, 49);
            this.pictureBox14.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new Size(398, 3);
            this.pictureBox14.TabIndex = 10070;
            this.pictureBox14.TabStop = false;
            // 
            // panel95
            // 
            this.panel95.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel95.Controls.Add(this.label140);
            this.panel95.Controls.Add(this.alertsCustomMasteryXNumericUpDown);
            this.panel95.Location = new Point(3, 95);
            this.panel95.Margin = new Padding(4, 5, 4, 5);
            this.panel95.Name = "panel95";
            this.panel95.Size = new Size(408, 35);
            this.panel95.TabIndex = 10061;
            // 
            // label140
            // 
            this.label140.BackColor = Color.Transparent;
            this.label140.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label140.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label140.Location = new Point(4, 5);
            this.label140.Margin = new Padding(4, 0, 4, 0);
            this.label140.Name = "label140";
            this.label140.Size = new Size(141, 25);
            this.label140.TabIndex = 10066;
            this.label140.Text = "X position";
            // 
            // panel96
            // 
            this.panel96.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel96.Controls.Add(this.label141);
            this.panel96.Controls.Add(this.alertsCustomMasteryInNumericUpDown);
            this.panel96.Location = new Point(3, 197);
            this.panel96.Margin = new Padding(4, 5, 4, 5);
            this.panel96.Name = "panel96";
            this.panel96.Size = new Size(408, 35);
            this.panel96.TabIndex = 10061;
            // 
            // label141
            // 
            this.label141.BackColor = Color.Transparent;
            this.label141.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label141.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label141.Location = new Point(4, 6);
            this.label141.Margin = new Padding(4, 0, 4, 0);
            this.label141.Name = "label141";
            this.label141.Size = new Size(225, 25);
            this.label141.TabIndex = 10069;
            this.label141.Text = "Animate In Time";
            // 
            // panel97
            // 
            this.panel97.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel97.Controls.Add(this.label142);
            this.panel97.Controls.Add(this.alertsCustomMasteryScaleNumericUpDown);
            this.panel97.Location = new Point(3, 163);
            this.panel97.Margin = new Padding(4, 5, 4, 5);
            this.panel97.Name = "panel97";
            this.panel97.Size = new Size(408, 35);
            this.panel97.TabIndex = 10061;
            // 
            // label142
            // 
            this.label142.BackColor = Color.Transparent;
            this.label142.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label142.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label142.Location = new Point(4, 6);
            this.label142.Margin = new Padding(4, 0, 4, 0);
            this.label142.Name = "label142";
            this.label142.Size = new Size(141, 25);
            this.label142.TabIndex = 10068;
            this.label142.Text = "Scale";
            // 
            // panel98
            // 
            this.panel98.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel98.Controls.Add(this.label143);
            this.panel98.Controls.Add(this.alertsCustomMasteryYNumericUpDown);
            this.panel98.Location = new Point(3, 129);
            this.panel98.Margin = new Padding(4, 5, 4, 5);
            this.panel98.Name = "panel98";
            this.panel98.Size = new Size(408, 35);
            this.panel98.TabIndex = 10061;
            // 
            // label143
            // 
            this.label143.BackColor = Color.Transparent;
            this.label143.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label143.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label143.Location = new Point(4, 6);
            this.label143.Margin = new Padding(4, 0, 4, 0);
            this.label143.Name = "label143";
            this.label143.Size = new Size(141, 25);
            this.label143.TabIndex = 10067;
            this.label143.Text = "Y position";
            // 
            // alertsMasteryEnableCheckbox
            // 
            this.alertsMasteryEnableCheckbox.AutoSize = true;
            this.alertsMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.alertsMasteryEnableCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.alertsMasteryEnableCheckbox.Location = new Point(16, 9);
            this.alertsMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.alertsMasteryEnableCheckbox.Name = "alertsMasteryEnableCheckbox";
            this.alertsMasteryEnableCheckbox.Size = new Size(106, 29);
            this.alertsMasteryEnableCheckbox.TabIndex = 54;
            this.alertsMasteryEnableCheckbox.Text = "Enable";
            this.alertsMasteryEnableCheckbox.UseVisualStyleBackColor = true;
            this.alertsMasteryEnableCheckbox.CheckedChanged += new System.EventHandler(this.CustomAlertsCheckBox_CheckedChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel14.Controls.Add(this.userInfoUsernameLabel);
            this.panel14.Controls.Add(this.userInfoRankLabel);
            this.panel14.Controls.Add(this.userInfoPointsLabel);
            this.panel14.Controls.Add(this.label37);
            this.panel14.Controls.Add(this.userInfoTruePointsLabel);
            this.panel14.Controls.Add(this.userProfilePictureBox);
            this.panel14.Controls.Add(this.userInfoMottoLabel);
            this.panel14.Controls.Add(this.userInfoRatioLabel);
            this.panel14.Controls.Add(this.pictureBox2);
            this.panel14.Location = new Point(444, 283);
            this.panel14.Margin = new Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new Size(702, 278);
            this.panel14.TabIndex = 10079;
            // 
            // userInfoUsernameLabel
            // 
            this.userInfoUsernameLabel.BackColor = Color.Transparent;
            this.userInfoUsernameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoUsernameLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoUsernameLabel.Location = new Point(4, 5);
            this.userInfoUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoUsernameLabel.Name = "userInfoUsernameLabel";
            this.userInfoUsernameLabel.Size = new Size(688, 40);
            this.userInfoUsernameLabel.TabIndex = 10058;
            this.userInfoUsernameLabel.Text = "Username";
            // 
            // userInfoRankLabel
            // 
            this.userInfoRankLabel.BackColor = Color.Transparent;
            this.userInfoRankLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRankLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoRankLabel.Location = new Point(9, 120);
            this.userInfoRankLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoRankLabel.Name = "userInfoRankLabel";
            this.userInfoRankLabel.Size = new Size(303, 25);
            this.userInfoRankLabel.TabIndex = 10054;
            this.userInfoRankLabel.Text = "Site Rank: 15000";
            // 
            // userInfoPointsLabel
            // 
            this.userInfoPointsLabel.BackColor = Color.Transparent;
            this.userInfoPointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoPointsLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoPointsLabel.Location = new Point(9, 95);
            this.userInfoPointsLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoPointsLabel.Name = "userInfoPointsLabel";
            this.userInfoPointsLabel.Size = new Size(280, 25);
            this.userInfoPointsLabel.TabIndex = 10055;
            this.userInfoPointsLabel.Text = "Hardcore Points: 348897";
            // 
            // label37
            // 
            this.label37.BackColor = Color.Transparent;
            this.label37.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label37.Location = new Point(9, 145);
            this.label37.Margin = new Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new Size(141, 25);
            this.label37.TabIndex = 10075;
            this.label37.Text = "Retro Ratio:";
            // 
            // userInfoTruePointsLabel
            // 
            this.userInfoTruePointsLabel.BackColor = Color.Transparent;
            this.userInfoTruePointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoTruePointsLabel.ForeColor = Color.White;
            this.userInfoTruePointsLabel.Location = new Point(291, 95);
            this.userInfoTruePointsLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoTruePointsLabel.Name = "userInfoTruePointsLabel";
            this.userInfoTruePointsLabel.Size = new Size(128, 25);
            this.userInfoTruePointsLabel.TabIndex = 10056;
            this.userInfoTruePointsLabel.Text = "(10019920)";
            // 
            // userInfoMottoLabel
            // 
            this.userInfoMottoLabel.AutoSize = true;
            this.userInfoMottoLabel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoMottoLabel.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoMottoLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoMottoLabel.Location = new Point(9, 57);
            this.userInfoMottoLabel.Margin = new Padding(4, 5, 4, 5);
            this.userInfoMottoLabel.Name = "userInfoMottoLabel";
            this.userInfoMottoLabel.Padding = new Padding(4, 5, 4, 5);
            this.userInfoMottoLabel.Size = new Size(240, 35);
            this.userInfoMottoLabel.TabIndex = 10074;
            this.userInfoMottoLabel.Text = "twitch.tv/RetroS3xual";
            // 
            // userInfoRatioLabel
            // 
            this.userInfoRatioLabel.BackColor = Color.Transparent;
            this.userInfoRatioLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoRatioLabel.ForeColor = Color.White;
            this.userInfoRatioLabel.Location = new Point(146, 145);
            this.userInfoRatioLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoRatioLabel.Name = "userInfoRatioLabel";
            this.userInfoRatioLabel.Size = new Size(110, 25);
            this.userInfoRatioLabel.TabIndex = 10057;
            this.userInfoRatioLabel.Text = "3.62";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox2.Location = new Point(3, 49);
            this.pictureBox2.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(690, 3);
            this.pictureBox2.TabIndex = 10059;
            this.pictureBox2.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.label28);
            this.panel21.Controls.Add(this.userInfoDefaultButton);
            this.panel21.Controls.Add(this.pictureBox4);
            this.panel21.Controls.Add(this.panel10);
            this.panel21.Controls.Add(this.panel13);
            this.panel21.Controls.Add(this.panel12);
            this.panel21.Controls.Add(this.panel11);
            this.panel21.Location = new Point(6, 5);
            this.panel21.Margin = new Padding(4, 5, 4, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new Size(430, 243);
            this.panel21.TabIndex = 10078;
            // 
            // panel22
            // 
            this.panel22.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel22.Controls.Add(this.label29);
            this.panel22.Controls.Add(this.label32);
            this.panel22.Controls.Add(this.label30);
            this.panel22.Location = new Point(3, 62);
            this.panel22.Margin = new Padding(4, 5, 4, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new Size(417, 35);
            this.panel22.TabIndex = 10079;
            // 
            // label29
            // 
            this.label29.BackColor = Color.Transparent;
            this.label29.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label29.Location = new Point(4, 5);
            this.label29.Margin = new Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new Size(75, 25);
            this.label29.TabIndex = 10071;
            this.label29.Text = "Field";
            // 
            // label32
            // 
            this.label32.BackColor = Color.Transparent;
            this.label32.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label32.Location = new Point(170, 5);
            this.label32.Margin = new Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new Size(153, 25);
            this.label32.TabIndex = 10073;
            this.label32.Text = "Display Text";
            // 
            // label30
            // 
            this.label30.BackColor = Color.Transparent;
            this.label30.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label30.Location = new Point(332, 5);
            this.label30.Margin = new Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new Size(92, 25);
            this.label30.TabIndex = 10072;
            this.label30.Text = "Enabled";
            // 
            // label28
            // 
            this.label28.BackColor = Color.Transparent;
            this.label28.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label28.Location = new Point(4, 5);
            this.label28.Margin = new Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new Size(285, 40);
            this.label28.TabIndex = 10069;
            this.label28.Text = "Field Overrides";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox4.Location = new Point(3, 49);
            this.pictureBox4.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(412, 3);
            this.pictureBox4.TabIndex = 10070;
            this.pictureBox4.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel10.Controls.Add(this.label31);
            this.panel10.Controls.Add(this.userInfoRankCheckBox);
            this.panel10.Controls.Add(this.userInfoRankTextBox);
            this.panel10.Location = new Point(3, 95);
            this.panel10.Margin = new Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new Size(417, 35);
            this.panel10.TabIndex = 10061;
            // 
            // label31
            // 
            this.label31.BackColor = Color.Transparent;
            this.label31.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label31.Location = new Point(4, 5);
            this.label31.Margin = new Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new Size(141, 25);
            this.label31.TabIndex = 10066;
            this.label31.Text = "Rank";
            // 
            // panel13
            // 
            this.panel13.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel13.Controls.Add(this.label35);
            this.panel13.Controls.Add(this.userInfoRatioCheckBox);
            this.panel13.Controls.Add(this.userInfoRatioTextBox);
            this.panel13.Location = new Point(3, 197);
            this.panel13.Margin = new Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new Size(417, 35);
            this.panel13.TabIndex = 10061;
            // 
            // label35
            // 
            this.label35.BackColor = Color.Transparent;
            this.label35.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label35.Location = new Point(4, 6);
            this.label35.Margin = new Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new Size(141, 25);
            this.label35.TabIndex = 10069;
            this.label35.Text = "Retro Ratio";
            // 
            // panel12
            // 
            this.panel12.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel12.Controls.Add(this.label34);
            this.panel12.Controls.Add(this.userInfoTruePointsTextBox);
            this.panel12.Controls.Add(this.userInfoTruePointsCheckBox);
            this.panel12.Location = new Point(3, 163);
            this.panel12.Margin = new Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new Size(417, 35);
            this.panel12.TabIndex = 10061;
            // 
            // label34
            // 
            this.label34.BackColor = Color.Transparent;
            this.label34.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label34.Location = new Point(4, 6);
            this.label34.Margin = new Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new Size(141, 25);
            this.label34.TabIndex = 10068;
            this.label34.Text = "True Points";
            // 
            // panel11
            // 
            this.panel11.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel11.Controls.Add(this.label33);
            this.panel11.Controls.Add(this.userInfoPointsTextBox);
            this.panel11.Controls.Add(this.userInfoPointsCheckBox);
            this.panel11.Location = new Point(3, 129);
            this.panel11.Margin = new Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new Size(417, 35);
            this.panel11.TabIndex = 10061;
            // 
            // label33
            // 
            this.label33.BackColor = Color.Transparent;
            this.label33.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label33.Location = new Point(4, 6);
            this.label33.Margin = new Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new Size(141, 25);
            this.label33.TabIndex = 10067;
            this.label33.Text = "Points";
            // 
            // panel20
            // 
            this.panel20.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel20.Controls.Add(this.label2);
            this.panel20.Controls.Add(this.panel4);
            this.panel20.Controls.Add(this.userInfoOpenWindowButton);
            this.panel20.Controls.Add(this.userInfoValuesPanel);
            this.panel20.Controls.Add(this.userInfoAutoOpenWindowCheckbox);
            this.panel20.Controls.Add(this.pictureBox3);
            this.panel20.Controls.Add(this.panel5);
            this.panel20.Controls.Add(this.panel6);
            this.panel20.Controls.Add(this.panel7);
            this.panel20.Controls.Add(this.userInfoValuesOutlinePanel);
            this.panel20.Location = new Point(444, 5);
            this.panel20.Margin = new Padding(4, 5, 4, 5);
            this.panel20.Name = "panel20";
            this.panel20.Size = new Size(702, 271);
            this.panel20.TabIndex = 10077;
            // 
            // label2
            // 
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label2.Location = new Point(4, 5);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(364, 40);
            this.label2.TabIndex = 10062;
            this.label2.Text = "Window/Font Settings";
            // 
            // panel4
            // 
            this.panel4.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.userInfoAdvancedCheckBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new Point(3, 62);
            this.panel4.Margin = new Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(694, 35);
            this.panel4.TabIndex = 10076;
            // 
            // userInfoAdvancedCheckBox
            // 
            this.userInfoAdvancedCheckBox.AutoSize = true;
            this.userInfoAdvancedCheckBox.BackColor = Color.Transparent;
            this.userInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.userInfoAdvancedCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoAdvancedCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.userInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoAdvancedCheckBox.Location = new Point(8, 3);
            this.userInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoAdvancedCheckBox.Name = "userInfoAdvancedCheckBox";
            this.userInfoAdvancedCheckBox.Size = new Size(135, 29);
            this.userInfoAdvancedCheckBox.TabIndex = 10053;
            this.userInfoAdvancedCheckBox.Text = "Advanced";
            this.userInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.userInfoAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label4
            // 
            this.label4.BackColor = Color.Transparent;
            this.label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label4.Location = new Point(225, 5);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(72, 25);
            this.label4.TabIndex = 10065;
            this.label4.Text = "Color";
            // 
            // label9
            // 
            this.label9.BackColor = Color.Transparent;
            this.label9.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label9.Location = new Point(291, 5);
            this.label9.Margin = new Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(75, 25);
            this.label9.TabIndex = 10066;
            this.label9.Text = "Font";
            // 
            // label25
            // 
            this.label25.BackColor = Color.Transparent;
            this.label25.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label25.Location = new Point(524, 5);
            this.label25.Margin = new Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new Size(62, 25);
            this.label25.TabIndex = 10068;
            this.label25.Text = "Size";
            // 
            // label15
            // 
            this.label15.BackColor = Color.Transparent;
            this.label15.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label15.Location = new Point(594, 5);
            this.label15.Margin = new Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new Size(88, 25);
            this.label15.TabIndex = 10067;
            this.label15.Text = "Enabled";
            // 
            // userInfoValuesPanel
            // 
            this.userInfoValuesPanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoValuesPanel.Controls.Add(this.label26);
            this.userInfoValuesPanel.Controls.Add(this.userInfoValuesFontColorPictureBox);
            this.userInfoValuesPanel.Controls.Add(this.userInfoValuesFontComboBox);
            this.userInfoValuesPanel.Location = new Point(3, 163);
            this.userInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesPanel.Name = "userInfoValuesPanel";
            this.userInfoValuesPanel.Size = new Size(694, 35);
            this.userInfoValuesPanel.TabIndex = 10061;
            // 
            // label26
            // 
            this.label26.BackColor = Color.Transparent;
            this.label26.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label26.Location = new Point(4, 6);
            this.label26.Margin = new Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new Size(216, 25);
            this.label26.TabIndex = 10066;
            this.label26.Text = "Values";
            // 
            // userInfoValuesFontColorPictureBox
            // 
            this.userInfoValuesFontColorPictureBox.BackColor = Color.White;
            this.userInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.userInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            this.userInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesFontColorPictureBox.Name = "userInfoValuesFontColorPictureBox";
            this.userInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            this.userInfoValuesFontColorPictureBox.TabIndex = 45;
            this.userInfoValuesFontColorPictureBox.TabStop = false;
            this.userInfoValuesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // userInfoValuesFontComboBox
            // 
            this.userInfoValuesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoValuesFontComboBox.ForeColor = Color.White;
            this.userInfoValuesFontComboBox.FormattingEnabled = true;
            this.userInfoValuesFontComboBox.Location = new Point(290, 3);
            this.userInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesFontComboBox.Name = "userInfoValuesFontComboBox";
            this.userInfoValuesFontComboBox.Size = new Size(301, 28);
            this.userInfoValuesFontComboBox.TabIndex = 45;
            this.userInfoValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox3.Location = new Point(3, 49);
            this.pictureBox3.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(690, 3);
            this.pictureBox3.TabIndex = 10063;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel5.Controls.Add(this.userInfoBackgroundColorPictureBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new Point(3, 95);
            this.panel5.Margin = new Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(694, 35);
            this.panel5.TabIndex = 10061;
            // 
            // userInfoBackgroundColorPictureBox
            // 
            this.userInfoBackgroundColorPictureBox.BackColor = Color.White;
            this.userInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.userInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            this.userInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoBackgroundColorPictureBox.Name = "userInfoBackgroundColorPictureBox";
            this.userInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            this.userInfoBackgroundColorPictureBox.TabIndex = 42;
            this.userInfoBackgroundColorPictureBox.TabStop = false;
            this.userInfoBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label3
            // 
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label3.Location = new Point(4, 5);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(216, 25);
            this.label3.TabIndex = 10064;
            this.label3.Text = "Window Background";
            // 
            // panel6
            // 
            this.panel6.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.userInfoNamesLabel);
            this.panel6.Controls.Add(this.userInfoNamesFontColorPictureBox);
            this.panel6.Controls.Add(this.userInfoNamesFontComboBox);
            this.panel6.Location = new Point(3, 129);
            this.panel6.Margin = new Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(694, 35);
            this.panel6.TabIndex = 10061;
            // 
            // userInfoNamesLabel
            // 
            this.userInfoNamesLabel.BackColor = Color.Transparent;
            this.userInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoNamesLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoNamesLabel.Location = new Point(4, 6);
            this.userInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoNamesLabel.Name = "userInfoNamesLabel";
            this.userInfoNamesLabel.Size = new Size(216, 25);
            this.userInfoNamesLabel.TabIndex = 10065;
            this.userInfoNamesLabel.Text = "Names";
            // 
            // userInfoNamesFontColorPictureBox
            // 
            this.userInfoNamesFontColorPictureBox.BackColor = Color.White;
            this.userInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.userInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            this.userInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoNamesFontColorPictureBox.Name = "userInfoNamesFontColorPictureBox";
            this.userInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            this.userInfoNamesFontColorPictureBox.TabIndex = 45;
            this.userInfoNamesFontColorPictureBox.TabStop = false;
            this.userInfoNamesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // userInfoNamesFontComboBox
            // 
            this.userInfoNamesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoNamesFontComboBox.ForeColor = Color.White;
            this.userInfoNamesFontComboBox.FormattingEnabled = true;
            this.userInfoNamesFontComboBox.Location = new Point(290, 3);
            this.userInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoNamesFontComboBox.Name = "userInfoNamesFontComboBox";
            this.userInfoNamesFontComboBox.Size = new Size(301, 28);
            this.userInfoNamesFontComboBox.TabIndex = 45;
            this.userInfoNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel7.Controls.Add(this.userInfoNamesFontOutlineNumericUpDown);
            this.panel7.Controls.Add(this.userInfoNamesOutlineCheckBox);
            this.panel7.Controls.Add(this.userInfoNamesOutlineLabel);
            this.panel7.Controls.Add(this.userInfoNamesFontOutlineColorPictureBox);
            this.panel7.Location = new Point(3, 197);
            this.panel7.Margin = new Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new Size(694, 35);
            this.panel7.TabIndex = 10061;
            // 
            // userInfoNamesFontOutlineNumericUpDown
            // 
            this.userInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.userInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.userInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.userInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.userInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.userInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.userInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userInfoNamesFontOutlineNumericUpDown.Name = "userInfoNamesFontOutlineNumericUpDown";
            this.userInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.userInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            this.userInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userInfoNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // userInfoNamesOutlineCheckBox
            // 
            this.userInfoNamesOutlineCheckBox.BackColor = Color.Transparent;
            this.userInfoNamesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoNamesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoNamesOutlineCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoNamesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoNamesOutlineCheckBox.ForeColor = Color.White;
            this.userInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            this.userInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoNamesOutlineCheckBox.Name = "userInfoNamesOutlineCheckBox";
            this.userInfoNamesOutlineCheckBox.Size = new Size(22, 22);
            this.userInfoNamesOutlineCheckBox.TabIndex = 45;
            this.userInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.userInfoNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // userInfoNamesOutlineLabel
            // 
            this.userInfoNamesOutlineLabel.BackColor = Color.Transparent;
            this.userInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoNamesOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.userInfoNamesOutlineLabel.Location = new Point(4, 5);
            this.userInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.userInfoNamesOutlineLabel.Name = "userInfoNamesOutlineLabel";
            this.userInfoNamesOutlineLabel.Size = new Size(216, 25);
            this.userInfoNamesOutlineLabel.TabIndex = 10066;
            this.userInfoNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // userInfoNamesFontOutlineColorPictureBox
            // 
            this.userInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            this.userInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.userInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.userInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoNamesFontOutlineColorPictureBox.Name = "userInfoNamesFontOutlineColorPictureBox";
            this.userInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.userInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            this.userInfoNamesFontOutlineColorPictureBox.TabStop = false;
            this.userInfoNamesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // userInfoValuesOutlinePanel
            // 
            this.userInfoValuesOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoValuesOutlinePanel.Controls.Add(this.label27);
            this.userInfoValuesOutlinePanel.Controls.Add(this.userInfoValuesFontOutlineColorPictureBox);
            this.userInfoValuesOutlinePanel.Controls.Add(this.userInfoValuesFontOutlineNumericUpDown);
            this.userInfoValuesOutlinePanel.Controls.Add(this.userInfoValuesOutlineCheckBox);
            this.userInfoValuesOutlinePanel.Location = new Point(3, 231);
            this.userInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesOutlinePanel.Name = "userInfoValuesOutlinePanel";
            this.userInfoValuesOutlinePanel.Size = new Size(694, 35);
            this.userInfoValuesOutlinePanel.TabIndex = 10067;
            // 
            // label27
            // 
            this.label27.BackColor = Color.Transparent;
            this.label27.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label27.Location = new Point(4, 6);
            this.label27.Margin = new Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new Size(216, 25);
            this.label27.TabIndex = 10066;
            this.label27.Text = "Values OutlineColor";
            // 
            // userInfoValuesFontOutlineColorPictureBox
            // 
            this.userInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            this.userInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.userInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.userInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesFontOutlineColorPictureBox.Name = "userInfoValuesFontOutlineColorPictureBox";
            this.userInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.userInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            this.userInfoValuesFontOutlineColorPictureBox.TabStop = false;
            this.userInfoValuesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // userInfoValuesFontOutlineNumericUpDown
            // 
            this.userInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.userInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.userInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.userInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.userInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.userInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userInfoValuesFontOutlineNumericUpDown.Name = "userInfoValuesFontOutlineNumericUpDown";
            this.userInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.userInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            this.userInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userInfoValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // userInfoValuesOutlineCheckBox
            // 
            this.userInfoValuesOutlineCheckBox.BackColor = Color.Transparent;
            this.userInfoValuesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            this.userInfoValuesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoValuesOutlineCheckBox.FlatStyle = FlatStyle.System;
            this.userInfoValuesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.userInfoValuesOutlineCheckBox.ForeColor = Color.White;
            this.userInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            this.userInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.userInfoValuesOutlineCheckBox.Name = "userInfoValuesOutlineCheckBox";
            this.userInfoValuesOutlineCheckBox.Size = new Size(22, 22);
            this.userInfoValuesOutlineCheckBox.TabIndex = 45;
            this.userInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.userInfoValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel50
            // 
            this.panel50.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel50.Controls.Add(this.panel119);
            this.panel50.Controls.Add(this.panel117);
            this.panel50.Controls.Add(this.panel118);
            this.panel50.Controls.Add(this.panel116);
            this.panel50.Controls.Add(this.gameInfoTitleLabel);
            this.panel50.Controls.Add(this.pictureBox8);
            this.panel50.Controls.Add(this.gameInfoPictureBox);
            this.panel50.Location = new Point(444, 283);
            this.panel50.Margin = new Padding(4, 5, 4, 5);
            this.panel50.Name = "panel50";
            this.panel50.Size = new Size(702, 278);
            this.panel50.TabIndex = 10081;
            // 
            // panel119
            // 
            this.panel119.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel119.Controls.Add(this.gameInfoGenreLabel);
            this.panel119.Controls.Add(this.label62);
            this.panel119.Controls.Add(this.label36);
            this.panel119.Location = new Point(164, 157);
            this.panel119.Margin = new Padding(4, 5, 4, 5);
            this.panel119.Name = "panel119";
            this.panel119.Size = new Size(522, 38);
            this.panel119.TabIndex = 10073;
            // 
            // gameInfoGenreLabel
            // 
            this.gameInfoGenreLabel.BackColor = Color.Transparent;
            this.gameInfoGenreLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoGenreLabel.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameInfoGenreLabel.Location = new Point(154, 8);
            this.gameInfoGenreLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoGenreLabel.Name = "gameInfoGenreLabel";
            this.gameInfoGenreLabel.Size = new Size(363, 25);
            this.gameInfoGenreLabel.TabIndex = 10066;
            this.gameInfoGenreLabel.UseMnemonic = false;
            // 
            // label62
            // 
            this.label62.BackColor = Color.Transparent;
            this.label62.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label62.Location = new Point(4, 8);
            this.label62.Margin = new Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new Size(141, 25);
            this.label62.TabIndex = 10070;
            this.label62.Text = "Genre";
            // 
            // label36
            // 
            this.label36.BackColor = Color.Transparent;
            this.label36.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label36.Location = new Point(202, 5);
            this.label36.Margin = new Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new Size(315, 25);
            this.label36.TabIndex = 10066;
            this.label36.UseMnemonic = false;
            // 
            // panel117
            // 
            this.panel117.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel117.Controls.Add(this.label89);
            this.panel117.Controls.Add(this.gameInfoReleasedLabel);
            this.panel117.Location = new Point(164, 195);
            this.panel117.Margin = new Padding(4, 5, 4, 5);
            this.panel117.Name = "panel117";
            this.panel117.Size = new Size(522, 38);
            this.panel117.TabIndex = 10072;
            // 
            // label89
            // 
            this.label89.BackColor = Color.Transparent;
            this.label89.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label89.Location = new Point(4, 8);
            this.label89.Margin = new Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new Size(141, 25);
            this.label89.TabIndex = 10070;
            this.label89.Text = "Released";
            // 
            // gameInfoReleasedLabel
            // 
            this.gameInfoReleasedLabel.BackColor = Color.Transparent;
            this.gameInfoReleasedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoReleasedLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoReleasedLabel.Location = new Point(154, 8);
            this.gameInfoReleasedLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoReleasedLabel.Name = "gameInfoReleasedLabel";
            this.gameInfoReleasedLabel.Size = new Size(363, 25);
            this.gameInfoReleasedLabel.TabIndex = 10067;
            this.gameInfoReleasedLabel.UseMnemonic = false;
            // 
            // panel118
            // 
            this.panel118.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel118.Controls.Add(this.label61);
            this.panel118.Controls.Add(this.gameInfoPublisherLabel);
            this.panel118.Location = new Point(164, 118);
            this.panel118.Margin = new Padding(4, 5, 4, 5);
            this.panel118.Name = "panel118";
            this.panel118.Size = new Size(522, 38);
            this.panel118.TabIndex = 10073;
            // 
            // label61
            // 
            this.label61.BackColor = Color.Transparent;
            this.label61.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label61.Location = new Point(4, 9);
            this.label61.Margin = new Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new Size(141, 25);
            this.label61.TabIndex = 10069;
            this.label61.Text = "Publisher";
            // 
            // gameInfoPublisherLabel
            // 
            this.gameInfoPublisherLabel.BackColor = Color.Transparent;
            this.gameInfoPublisherLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoPublisherLabel.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameInfoPublisherLabel.Location = new Point(154, 9);
            this.gameInfoPublisherLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoPublisherLabel.Name = "gameInfoPublisherLabel";
            this.gameInfoPublisherLabel.Size = new Size(363, 25);
            this.gameInfoPublisherLabel.TabIndex = 10064;
            this.gameInfoPublisherLabel.UseMnemonic = false;
            // 
            // panel116
            // 
            this.panel116.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel116.Controls.Add(this.label57);
            this.panel116.Controls.Add(this.gameInfoDeveloperLabel);
            this.panel116.Location = new Point(164, 80);
            this.panel116.Margin = new Padding(4, 5, 4, 5);
            this.panel116.Name = "panel116";
            this.panel116.Size = new Size(522, 38);
            this.panel116.TabIndex = 10071;
            // 
            // label57
            // 
            this.label57.BackColor = Color.Transparent;
            this.label57.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label57.Location = new Point(4, 5);
            this.label57.Margin = new Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new Size(141, 25);
            this.label57.TabIndex = 10070;
            this.label57.Text = "Developer";
            // 
            // gameInfoDeveloperLabel
            // 
            this.gameInfoDeveloperLabel.BackColor = Color.Transparent;
            this.gameInfoDeveloperLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDeveloperLabel.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameInfoDeveloperLabel.Location = new Point(154, 5);
            this.gameInfoDeveloperLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoDeveloperLabel.Name = "gameInfoDeveloperLabel";
            this.gameInfoDeveloperLabel.Size = new Size(363, 25);
            this.gameInfoDeveloperLabel.TabIndex = 10063;
            this.gameInfoDeveloperLabel.UseMnemonic = false;
            // 
            // gameInfoTitleLabel
            // 
            this.gameInfoTitleLabel.BackColor = Color.Transparent;
            this.gameInfoTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoTitleLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoTitleLabel.Location = new Point(4, 5);
            this.gameInfoTitleLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoTitleLabel.Name = "gameInfoTitleLabel";
            this.gameInfoTitleLabel.Size = new Size(688, 58);
            this.gameInfoTitleLabel.TabIndex = 10058;
            this.gameInfoTitleLabel.Text = "Game Info Title";
            this.gameInfoTitleLabel.UseMnemonic = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox8.Location = new Point(3, 68);
            this.pictureBox8.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(690, 3);
            this.pictureBox8.TabIndex = 10059;
            this.pictureBox8.TabStop = false;
            // 
            // panel29
            // 
            this.panel29.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel29.Controls.Add(this.panel49);
            this.panel29.Controls.Add(this.panel48);
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Controls.Add(this.label66);
            this.panel29.Controls.Add(this.gameInfoDefaultButton);
            this.panel29.Controls.Add(this.pictureBox7);
            this.panel29.Controls.Add(this.panel31);
            this.panel29.Controls.Add(this.panel32);
            this.panel29.Controls.Add(this.panel33);
            this.panel29.Controls.Add(this.panel34);
            this.panel29.Location = new Point(6, 5);
            this.panel29.Margin = new Padding(4, 5, 4, 5);
            this.panel29.Name = "panel29";
            this.panel29.Size = new Size(430, 309);
            this.panel29.TabIndex = 10080;
            // 
            // panel49
            // 
            this.panel49.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel49.Controls.Add(this.label88);
            this.panel49.Controls.Add(this.gameInfoReleasedCheckBox);
            this.panel49.Controls.Add(this.gameInfoReleaseDateTextBox);
            this.panel49.Location = new Point(3, 265);
            this.panel49.Margin = new Padding(4, 5, 4, 5);
            this.panel49.Name = "panel49";
            this.panel49.Size = new Size(417, 35);
            this.panel49.TabIndex = 10071;
            // 
            // label88
            // 
            this.label88.BackColor = Color.Transparent;
            this.label88.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label88.Location = new Point(4, 6);
            this.label88.Margin = new Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new Size(141, 25);
            this.label88.TabIndex = 10069;
            this.label88.Text = "Released";
            // 
            // gameInfoReleasedCheckBox
            // 
            this.gameInfoReleasedCheckBox.AutoSize = true;
            this.gameInfoReleasedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoReleasedCheckBox.Location = new Point(338, 8);
            this.gameInfoReleasedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoReleasedCheckBox.Name = "gameInfoReleasedCheckBox";
            this.gameInfoReleasedCheckBox.Size = new Size(22, 21);
            this.gameInfoReleasedCheckBox.TabIndex = 55;
            this.gameInfoReleasedCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoReleasedCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoReleaseDateTextBox
            // 
            this.gameInfoReleaseDateTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoReleaseDateTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoReleaseDateTextBox.ForeColor = Color.White;
            this.gameInfoReleaseDateTextBox.Location = new Point(174, 0);
            this.gameInfoReleaseDateTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoReleaseDateTextBox.Name = "gameInfoReleaseDateTextBox";
            this.gameInfoReleaseDateTextBox.Size = new Size(146, 31);
            this.gameInfoReleaseDateTextBox.TabIndex = 5;
            this.gameInfoReleaseDateTextBox.Text = "Released";
            this.gameInfoReleaseDateTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel48
            // 
            this.panel48.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel48.Controls.Add(this.label87);
            this.panel48.Controls.Add(this.gameInfoGenreCheckBox);
            this.panel48.Controls.Add(this.gameInfoGenreTextBox);
            this.panel48.Location = new Point(3, 231);
            this.panel48.Margin = new Padding(4, 5, 4, 5);
            this.panel48.Name = "panel48";
            this.panel48.Size = new Size(417, 35);
            this.panel48.TabIndex = 10070;
            // 
            // label87
            // 
            this.label87.BackColor = Color.Transparent;
            this.label87.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label87.Location = new Point(4, 6);
            this.label87.Margin = new Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new Size(141, 25);
            this.label87.TabIndex = 10069;
            this.label87.Text = "Genre";
            // 
            // gameInfoGenreCheckBox
            // 
            this.gameInfoGenreCheckBox.AutoSize = true;
            this.gameInfoGenreCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoGenreCheckBox.Location = new Point(338, 8);
            this.gameInfoGenreCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoGenreCheckBox.Name = "gameInfoGenreCheckBox";
            this.gameInfoGenreCheckBox.Size = new Size(22, 21);
            this.gameInfoGenreCheckBox.TabIndex = 55;
            this.gameInfoGenreCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoGenreCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoGenreTextBox
            // 
            this.gameInfoGenreTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoGenreTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoGenreTextBox.ForeColor = Color.White;
            this.gameInfoGenreTextBox.Location = new Point(174, 0);
            this.gameInfoGenreTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoGenreTextBox.Name = "gameInfoGenreTextBox";
            this.gameInfoGenreTextBox.Size = new Size(146, 31);
            this.gameInfoGenreTextBox.TabIndex = 5;
            this.gameInfoGenreTextBox.Text = "Genre";
            this.gameInfoGenreTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel30
            // 
            this.panel30.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel30.Controls.Add(this.label63);
            this.panel30.Controls.Add(this.label64);
            this.panel30.Controls.Add(this.label65);
            this.panel30.Location = new Point(3, 62);
            this.panel30.Margin = new Padding(4, 5, 4, 5);
            this.panel30.Name = "panel30";
            this.panel30.Size = new Size(417, 35);
            this.panel30.TabIndex = 10079;
            // 
            // label63
            // 
            this.label63.BackColor = Color.Transparent;
            this.label63.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label63.Location = new Point(4, 5);
            this.label63.Margin = new Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new Size(75, 25);
            this.label63.TabIndex = 10071;
            this.label63.Text = "Field";
            // 
            // label64
            // 
            this.label64.BackColor = Color.Transparent;
            this.label64.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label64.Location = new Point(170, 5);
            this.label64.Margin = new Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new Size(153, 25);
            this.label64.TabIndex = 10073;
            this.label64.Text = "Display Text";
            // 
            // label65
            // 
            this.label65.BackColor = Color.Transparent;
            this.label65.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label65.Location = new Point(332, 5);
            this.label65.Margin = new Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new Size(92, 25);
            this.label65.TabIndex = 10072;
            this.label65.Text = "Enabled";
            // 
            // label66
            // 
            this.label66.BackColor = Color.Transparent;
            this.label66.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label66.Location = new Point(4, 5);
            this.label66.Margin = new Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new Size(285, 40);
            this.label66.TabIndex = 10069;
            this.label66.Text = "Field Overrides";
            // 
            // gameInfoDefaultButton
            // 
            this.gameInfoDefaultButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gameInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            this.gameInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDefaultButton.ForeColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gameInfoDefaultButton.Location = new Point(306, 3);
            this.gameInfoDefaultButton.Margin = new Padding(0);
            this.gameInfoDefaultButton.Name = "gameInfoDefaultButton";
            this.gameInfoDefaultButton.Size = new Size(112, 42);
            this.gameInfoDefaultButton.TabIndex = 39;
            this.gameInfoDefaultButton.Text = "Default";
            this.gameInfoDefaultButton.UseVisualStyleBackColor = false;
            this.gameInfoDefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox7.Location = new Point(3, 49);
            this.pictureBox7.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(412, 3);
            this.pictureBox7.TabIndex = 10070;
            this.pictureBox7.TabStop = false;
            // 
            // panel31
            // 
            this.panel31.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel31.Controls.Add(this.label67);
            this.panel31.Controls.Add(this.gameInfoTitleCheckBox);
            this.panel31.Controls.Add(this.gameInfoTitleTextBox);
            this.panel31.Location = new Point(3, 95);
            this.panel31.Margin = new Padding(4, 5, 4, 5);
            this.panel31.Name = "panel31";
            this.panel31.Size = new Size(417, 35);
            this.panel31.TabIndex = 10061;
            // 
            // label67
            // 
            this.label67.BackColor = Color.Transparent;
            this.label67.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label67.Location = new Point(4, 5);
            this.label67.Margin = new Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new Size(141, 25);
            this.label67.TabIndex = 10066;
            this.label67.Text = "Title";
            // 
            // gameInfoTitleCheckBox
            // 
            this.gameInfoTitleCheckBox.AutoSize = true;
            this.gameInfoTitleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoTitleCheckBox.Location = new Point(338, 8);
            this.gameInfoTitleCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoTitleCheckBox.Name = "gameInfoTitleCheckBox";
            this.gameInfoTitleCheckBox.Size = new Size(22, 21);
            this.gameInfoTitleCheckBox.TabIndex = 52;
            this.gameInfoTitleCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoTitleCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoTitleTextBox
            // 
            this.gameInfoTitleTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoTitleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoTitleTextBox.ForeColor = Color.White;
            this.gameInfoTitleTextBox.Location = new Point(174, 0);
            this.gameInfoTitleTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoTitleTextBox.Name = "gameInfoTitleTextBox";
            this.gameInfoTitleTextBox.Size = new Size(146, 31);
            this.gameInfoTitleTextBox.TabIndex = 1;
            this.gameInfoTitleTextBox.Text = "Title";
            this.gameInfoTitleTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel32
            // 
            this.panel32.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel32.Controls.Add(this.label68);
            this.panel32.Controls.Add(this.gameInfoConsoleCheckBox);
            this.panel32.Controls.Add(this.gameInfoConsoleTextBox);
            this.panel32.Location = new Point(3, 197);
            this.panel32.Margin = new Padding(4, 5, 4, 5);
            this.panel32.Name = "panel32";
            this.panel32.Size = new Size(417, 35);
            this.panel32.TabIndex = 10061;
            // 
            // label68
            // 
            this.label68.BackColor = Color.Transparent;
            this.label68.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label68.Location = new Point(4, 6);
            this.label68.Margin = new Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new Size(141, 25);
            this.label68.TabIndex = 10069;
            this.label68.Text = "Console";
            // 
            // gameInfoConsoleCheckBox
            // 
            this.gameInfoConsoleCheckBox.AutoSize = true;
            this.gameInfoConsoleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoConsoleCheckBox.Location = new Point(338, 8);
            this.gameInfoConsoleCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoConsoleCheckBox.Name = "gameInfoConsoleCheckBox";
            this.gameInfoConsoleCheckBox.Size = new Size(22, 21);
            this.gameInfoConsoleCheckBox.TabIndex = 55;
            this.gameInfoConsoleCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoConsoleCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoConsoleTextBox
            // 
            this.gameInfoConsoleTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoConsoleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoConsoleTextBox.ForeColor = Color.White;
            this.gameInfoConsoleTextBox.Location = new Point(174, 0);
            this.gameInfoConsoleTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoConsoleTextBox.Name = "gameInfoConsoleTextBox";
            this.gameInfoConsoleTextBox.Size = new Size(146, 31);
            this.gameInfoConsoleTextBox.TabIndex = 5;
            this.gameInfoConsoleTextBox.Text = "Console";
            this.gameInfoConsoleTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel33
            // 
            this.panel33.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel33.Controls.Add(this.label69);
            this.panel33.Controls.Add(this.gameInfoPublisherTextBox);
            this.panel33.Controls.Add(this.gameInfoPublisherCheckBox);
            this.panel33.Location = new Point(3, 163);
            this.panel33.Margin = new Padding(4, 5, 4, 5);
            this.panel33.Name = "panel33";
            this.panel33.Size = new Size(417, 35);
            this.panel33.TabIndex = 10061;
            // 
            // label69
            // 
            this.label69.BackColor = Color.Transparent;
            this.label69.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label69.Location = new Point(4, 6);
            this.label69.Margin = new Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new Size(141, 25);
            this.label69.TabIndex = 10068;
            this.label69.Text = "Publisher";
            // 
            // gameInfoPublisherTextBox
            // 
            this.gameInfoPublisherTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoPublisherTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoPublisherTextBox.ForeColor = Color.White;
            this.gameInfoPublisherTextBox.Location = new Point(174, 0);
            this.gameInfoPublisherTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoPublisherTextBox.Name = "gameInfoPublisherTextBox";
            this.gameInfoPublisherTextBox.Size = new Size(146, 31);
            this.gameInfoPublisherTextBox.TabIndex = 7;
            this.gameInfoPublisherTextBox.Text = "Publisher";
            this.gameInfoPublisherTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // gameInfoPublisherCheckBox
            // 
            this.gameInfoPublisherCheckBox.AutoSize = true;
            this.gameInfoPublisherCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoPublisherCheckBox.Location = new Point(338, 8);
            this.gameInfoPublisherCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoPublisherCheckBox.Name = "gameInfoPublisherCheckBox";
            this.gameInfoPublisherCheckBox.Size = new Size(22, 21);
            this.gameInfoPublisherCheckBox.TabIndex = 56;
            this.gameInfoPublisherCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoPublisherCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel34
            // 
            this.panel34.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel34.Controls.Add(this.label70);
            this.panel34.Controls.Add(this.gameInfoDeveloperTextBox);
            this.panel34.Controls.Add(this.gameInfoDeveloperCheckBox);
            this.panel34.Location = new Point(3, 129);
            this.panel34.Margin = new Padding(4, 5, 4, 5);
            this.panel34.Name = "panel34";
            this.panel34.Size = new Size(417, 35);
            this.panel34.TabIndex = 10061;
            // 
            // label70
            // 
            this.label70.BackColor = Color.Transparent;
            this.label70.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label70.Location = new Point(4, 6);
            this.label70.Margin = new Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new Size(141, 25);
            this.label70.TabIndex = 10067;
            this.label70.Text = "Developer";
            // 
            // gameInfoDeveloperTextBox
            // 
            this.gameInfoDeveloperTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoDeveloperTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDeveloperTextBox.ForeColor = Color.White;
            this.gameInfoDeveloperTextBox.Location = new Point(174, 0);
            this.gameInfoDeveloperTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoDeveloperTextBox.Name = "gameInfoDeveloperTextBox";
            this.gameInfoDeveloperTextBox.Size = new Size(146, 31);
            this.gameInfoDeveloperTextBox.TabIndex = 6;
            this.gameInfoDeveloperTextBox.Text = "Developer";
            this.gameInfoDeveloperTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // gameInfoDeveloperCheckBox
            // 
            this.gameInfoDeveloperCheckBox.AutoSize = true;
            this.gameInfoDeveloperCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDeveloperCheckBox.Location = new Point(338, 8);
            this.gameInfoDeveloperCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoDeveloperCheckBox.Name = "gameInfoDeveloperCheckBox";
            this.gameInfoDeveloperCheckBox.Size = new Size(22, 21);
            this.gameInfoDeveloperCheckBox.TabIndex = 54;
            this.gameInfoDeveloperCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoDeveloperCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel35
            // 
            this.panel35.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel35.Controls.Add(this.label71);
            this.panel35.Controls.Add(this.panel42);
            this.panel35.Controls.Add(this.gameInfoOpenWindowButton);
            this.panel35.Controls.Add(this.gameInfoValuesPanel);
            this.panel35.Controls.Add(this.gameInfoAutoOpenWindowCheckbox);
            this.panel35.Controls.Add(this.pictureBox9);
            this.panel35.Controls.Add(this.panel44);
            this.panel35.Controls.Add(this.panel45);
            this.panel35.Controls.Add(this.panel46);
            this.panel35.Controls.Add(this.gameInfoValuesOutlinePanel);
            this.panel35.Location = new Point(444, 5);
            this.panel35.Margin = new Padding(4, 5, 4, 5);
            this.panel35.Name = "panel35";
            this.panel35.Size = new Size(702, 271);
            this.panel35.TabIndex = 10079;
            // 
            // label71
            // 
            this.label71.BackColor = Color.Transparent;
            this.label71.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label71.Location = new Point(4, 5);
            this.label71.Margin = new Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new Size(364, 40);
            this.label71.TabIndex = 10062;
            this.label71.Text = "Window/Font Settings";
            // 
            // panel42
            // 
            this.panel42.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel42.Controls.Add(this.gameInfoAdvancedCheckBox);
            this.panel42.Controls.Add(this.label78);
            this.panel42.Controls.Add(this.label79);
            this.panel42.Controls.Add(this.label80);
            this.panel42.Controls.Add(this.label81);
            this.panel42.Location = new Point(3, 62);
            this.panel42.Margin = new Padding(4, 5, 4, 5);
            this.panel42.Name = "panel42";
            this.panel42.Size = new Size(694, 35);
            this.panel42.TabIndex = 10076;
            // 
            // gameInfoAdvancedCheckBox
            // 
            this.gameInfoAdvancedCheckBox.AutoSize = true;
            this.gameInfoAdvancedCheckBox.BackColor = Color.Transparent;
            this.gameInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.gameInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoAdvancedCheckBox.Location = new Point(8, 3);
            this.gameInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoAdvancedCheckBox.Name = "gameInfoAdvancedCheckBox";
            this.gameInfoAdvancedCheckBox.Size = new Size(135, 29);
            this.gameInfoAdvancedCheckBox.TabIndex = 10053;
            this.gameInfoAdvancedCheckBox.Text = "Advanced";
            this.gameInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.gameInfoAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label78
            // 
            this.label78.BackColor = Color.Transparent;
            this.label78.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label78.Location = new Point(225, 5);
            this.label78.Margin = new Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new Size(72, 25);
            this.label78.TabIndex = 10065;
            this.label78.Text = "Color";
            // 
            // label79
            // 
            this.label79.BackColor = Color.Transparent;
            this.label79.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label79.Location = new Point(291, 5);
            this.label79.Margin = new Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new Size(75, 25);
            this.label79.TabIndex = 10066;
            this.label79.Text = "Font";
            // 
            // label80
            // 
            this.label80.BackColor = Color.Transparent;
            this.label80.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label80.Location = new Point(524, 5);
            this.label80.Margin = new Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new Size(62, 25);
            this.label80.TabIndex = 10068;
            this.label80.Text = "Size";
            // 
            // label81
            // 
            this.label81.BackColor = Color.Transparent;
            this.label81.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label81.Location = new Point(594, 5);
            this.label81.Margin = new Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new Size(88, 25);
            this.label81.TabIndex = 10067;
            this.label81.Text = "Enabled";
            // 
            // gameInfoOpenWindowButton
            // 
            this.gameInfoOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.gameInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.gameInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameInfoOpenWindowButton.Location = new Point(573, 3);
            this.gameInfoOpenWindowButton.Margin = new Padding(0);
            this.gameInfoOpenWindowButton.Name = "gameInfoOpenWindowButton";
            this.gameInfoOpenWindowButton.Size = new Size(112, 42);
            this.gameInfoOpenWindowButton.TabIndex = 10021;
            this.gameInfoOpenWindowButton.Text = "Open";
            this.gameInfoOpenWindowButton.UseVisualStyleBackColor = false;
            this.gameInfoOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // gameInfoValuesPanel
            // 
            this.gameInfoValuesPanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoValuesPanel.Controls.Add(this.label82);
            this.gameInfoValuesPanel.Controls.Add(this.gameInfoValuesFontColorPictureBox);
            this.gameInfoValuesPanel.Controls.Add(this.gameInfoValuesFontComboBox);
            this.gameInfoValuesPanel.Location = new Point(3, 163);
            this.gameInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesPanel.Name = "gameInfoValuesPanel";
            this.gameInfoValuesPanel.Size = new Size(694, 35);
            this.gameInfoValuesPanel.TabIndex = 10061;
            // 
            // label82
            // 
            this.label82.BackColor = Color.Transparent;
            this.label82.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label82.Location = new Point(4, 6);
            this.label82.Margin = new Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new Size(216, 25);
            this.label82.TabIndex = 10066;
            this.label82.Text = "Values";
            // 
            // gameInfoValuesFontColorPictureBox
            // 
            this.gameInfoValuesFontColorPictureBox.BackColor = Color.White;
            this.gameInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            this.gameInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesFontColorPictureBox.Name = "gameInfoValuesFontColorPictureBox";
            this.gameInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            this.gameInfoValuesFontColorPictureBox.TabIndex = 45;
            this.gameInfoValuesFontColorPictureBox.TabStop = false;
            this.gameInfoValuesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameInfoValuesFontComboBox
            // 
            this.gameInfoValuesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoValuesFontComboBox.ForeColor = Color.White;
            this.gameInfoValuesFontComboBox.FormattingEnabled = true;
            this.gameInfoValuesFontComboBox.Location = new Point(290, 3);
            this.gameInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesFontComboBox.Name = "gameInfoValuesFontComboBox";
            this.gameInfoValuesFontComboBox.Size = new Size(301, 28);
            this.gameInfoValuesFontComboBox.TabIndex = 45;
            this.gameInfoValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // gameInfoAutoOpenWindowCheckbox
            // 
            this.gameInfoAutoOpenWindowCheckbox.AutoSize = true;
            this.gameInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.gameInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.gameInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoAutoOpenWindowCheckbox.Name = "gameInfoAutoOpenWindowCheckbox";
            this.gameInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.gameInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            this.gameInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.gameInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.gameInfoAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox9.Location = new Point(3, 49);
            this.pictureBox9.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new Size(690, 3);
            this.pictureBox9.TabIndex = 10063;
            this.pictureBox9.TabStop = false;
            // 
            // panel44
            // 
            this.panel44.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel44.Controls.Add(this.gameInfoBackgroundColorPictureBox);
            this.panel44.Controls.Add(this.label83);
            this.panel44.Location = new Point(3, 95);
            this.panel44.Margin = new Padding(4, 5, 4, 5);
            this.panel44.Name = "panel44";
            this.panel44.Size = new Size(694, 35);
            this.panel44.TabIndex = 10061;
            // 
            // gameInfoBackgroundColorPictureBox
            // 
            this.gameInfoBackgroundColorPictureBox.BackColor = Color.White;
            this.gameInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            this.gameInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoBackgroundColorPictureBox.Name = "gameInfoBackgroundColorPictureBox";
            this.gameInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            this.gameInfoBackgroundColorPictureBox.TabIndex = 42;
            this.gameInfoBackgroundColorPictureBox.TabStop = false;
            this.gameInfoBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label83
            // 
            this.label83.BackColor = Color.Transparent;
            this.label83.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label83.Location = new Point(4, 5);
            this.label83.Margin = new Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new Size(216, 25);
            this.label83.TabIndex = 10064;
            this.label83.Text = "Window Background";
            // 
            // panel45
            // 
            this.panel45.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel45.Controls.Add(this.gameInfoNamesLabel);
            this.panel45.Controls.Add(this.gameInfoNamesFontColorPictureBox);
            this.panel45.Controls.Add(this.gameInfoNamesFontComboBox);
            this.panel45.Location = new Point(3, 129);
            this.panel45.Margin = new Padding(4, 5, 4, 5);
            this.panel45.Name = "panel45";
            this.panel45.Size = new Size(694, 35);
            this.panel45.TabIndex = 10061;
            // 
            // gameInfoNamesLabel
            // 
            this.gameInfoNamesLabel.BackColor = Color.Transparent;
            this.gameInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoNamesLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoNamesLabel.Location = new Point(4, 6);
            this.gameInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoNamesLabel.Name = "gameInfoNamesLabel";
            this.gameInfoNamesLabel.Size = new Size(216, 25);
            this.gameInfoNamesLabel.TabIndex = 10065;
            this.gameInfoNamesLabel.Text = "Names";
            // 
            // gameInfoNamesFontColorPictureBox
            // 
            this.gameInfoNamesFontColorPictureBox.BackColor = Color.White;
            this.gameInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            this.gameInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoNamesFontColorPictureBox.Name = "gameInfoNamesFontColorPictureBox";
            this.gameInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            this.gameInfoNamesFontColorPictureBox.TabIndex = 45;
            this.gameInfoNamesFontColorPictureBox.TabStop = false;
            this.gameInfoNamesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameInfoNamesFontComboBox
            // 
            this.gameInfoNamesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoNamesFontComboBox.ForeColor = Color.White;
            this.gameInfoNamesFontComboBox.FormattingEnabled = true;
            this.gameInfoNamesFontComboBox.Location = new Point(290, 3);
            this.gameInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoNamesFontComboBox.Name = "gameInfoNamesFontComboBox";
            this.gameInfoNamesFontComboBox.Size = new Size(301, 28);
            this.gameInfoNamesFontComboBox.TabIndex = 45;
            this.gameInfoNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel46
            // 
            this.panel46.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel46.Controls.Add(this.gameInfoNamesFontOutlineNumericUpDown);
            this.panel46.Controls.Add(this.gameInfoNamesOutlineCheckBox);
            this.panel46.Controls.Add(this.gameInfoNamesOutlineLabel);
            this.panel46.Controls.Add(this.gameInfoNamesFontOutlineColorPictureBox);
            this.panel46.Location = new Point(3, 197);
            this.panel46.Margin = new Padding(4, 5, 4, 5);
            this.panel46.Name = "panel46";
            this.panel46.Size = new Size(694, 35);
            this.panel46.TabIndex = 10061;
            // 
            // gameInfoNamesFontOutlineNumericUpDown
            // 
            this.gameInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gameInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.gameInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.gameInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.gameInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gameInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameInfoNamesFontOutlineNumericUpDown.Name = "gameInfoNamesFontOutlineNumericUpDown";
            this.gameInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.gameInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            this.gameInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameInfoNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // gameInfoNamesOutlineCheckBox
            // 
            this.gameInfoNamesOutlineCheckBox.AutoSize = true;
            this.gameInfoNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoNamesOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            this.gameInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoNamesOutlineCheckBox.Name = "gameInfoNamesOutlineCheckBox";
            this.gameInfoNamesOutlineCheckBox.Size = new Size(22, 21);
            this.gameInfoNamesOutlineCheckBox.TabIndex = 45;
            this.gameInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameInfoNamesOutlineLabel
            // 
            this.gameInfoNamesOutlineLabel.BackColor = Color.Transparent;
            this.gameInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoNamesOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoNamesOutlineLabel.Location = new Point(4, 5);
            this.gameInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameInfoNamesOutlineLabel.Name = "gameInfoNamesOutlineLabel";
            this.gameInfoNamesOutlineLabel.Size = new Size(216, 25);
            this.gameInfoNamesOutlineLabel.TabIndex = 10066;
            this.gameInfoNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // gameInfoNamesFontOutlineColorPictureBox
            // 
            this.gameInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            this.gameInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.gameInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoNamesFontOutlineColorPictureBox.Name = "gameInfoNamesFontOutlineColorPictureBox";
            this.gameInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.gameInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            this.gameInfoNamesFontOutlineColorPictureBox.TabStop = false;
            this.gameInfoNamesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameInfoValuesOutlinePanel
            // 
            this.gameInfoValuesOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoValuesOutlinePanel.Controls.Add(this.label86);
            this.gameInfoValuesOutlinePanel.Controls.Add(this.gameInfoValuesFontOutlineColorPictureBox);
            this.gameInfoValuesOutlinePanel.Controls.Add(this.gameInfoValuesFontOutlineNumericUpDown);
            this.gameInfoValuesOutlinePanel.Controls.Add(this.gameInfoValuesOutlineCheckBox);
            this.gameInfoValuesOutlinePanel.Location = new Point(3, 231);
            this.gameInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesOutlinePanel.Name = "gameInfoValuesOutlinePanel";
            this.gameInfoValuesOutlinePanel.Size = new Size(694, 35);
            this.gameInfoValuesOutlinePanel.TabIndex = 10067;
            // 
            // label86
            // 
            this.label86.BackColor = Color.Transparent;
            this.label86.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label86.Location = new Point(4, 6);
            this.label86.Margin = new Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new Size(216, 25);
            this.label86.TabIndex = 10066;
            this.label86.Text = "Values OutlineColor";
            // 
            // gameInfoValuesFontOutlineColorPictureBox
            // 
            this.gameInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            this.gameInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.gameInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesFontOutlineColorPictureBox.Name = "gameInfoValuesFontOutlineColorPictureBox";
            this.gameInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.gameInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            this.gameInfoValuesFontOutlineColorPictureBox.TabStop = false;
            this.gameInfoValuesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameInfoValuesFontOutlineNumericUpDown
            // 
            this.gameInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gameInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.gameInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.gameInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.gameInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gameInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameInfoValuesFontOutlineNumericUpDown.Name = "gameInfoValuesFontOutlineNumericUpDown";
            this.gameInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.gameInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            this.gameInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameInfoValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // gameInfoValuesOutlineCheckBox
            // 
            this.gameInfoValuesOutlineCheckBox.AutoSize = true;
            this.gameInfoValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoValuesOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            this.gameInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoValuesOutlineCheckBox.Name = "gameInfoValuesOutlineCheckBox";
            this.gameInfoValuesOutlineCheckBox.Size = new Size(22, 21);
            this.gameInfoValuesOutlineCheckBox.TabIndex = 45;
            this.gameInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel28
            // 
            this.panel28.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel28.Controls.Add(this.gameProgressPointsTextLabel);
            this.panel28.Controls.Add(this.gameProgressHardcoreWorthLabel);
            this.panel28.Controls.Add(this.gameProgressPoints2Label);
            this.panel28.Controls.Add(this.gameProgressTruePoints2Label);
            this.panel28.Controls.Add(this.gameProgressAchievements2Label);
            this.panel28.Controls.Add(this.gameProgressHaveEarnedLabel);
            this.panel28.Controls.Add(this.gameProgressPercentCompletePictureBox);
            this.panel28.Controls.Add(this.gameProgressMasteryPictureBox);
            this.panel28.Controls.Add(this.pictureBox21);
            this.panel28.Controls.Add(this.label60);
            this.panel28.Controls.Add(this.label59);
            this.panel28.Controls.Add(this.label58);
            this.panel28.Controls.Add(this.label56);
            this.panel28.Controls.Add(this.pictureBox5);
            this.panel28.Controls.Add(this.gameProgressAchievements1Label);
            this.panel28.Controls.Add(this.gameProgressPoints1Label);
            this.panel28.Controls.Add(this.gameProgressCompletedLabel);
            this.panel28.Controls.Add(this.gameProgressTruePoints1Label);
            this.panel28.Location = new Point(444, 283);
            this.panel28.Margin = new Padding(4, 5, 4, 5);
            this.panel28.Name = "panel28";
            this.panel28.Size = new Size(702, 278);
            this.panel28.TabIndex = 10082;
            // 
            // gameProgressPointsTextLabel
            // 
            this.gameProgressPointsTextLabel.AutoSize = true;
            this.gameProgressPointsTextLabel.BackColor = Color.Transparent;
            this.gameProgressPointsTextLabel.Font = new Font("Verdana", 9.75F);
            this.gameProgressPointsTextLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressPointsTextLabel.Location = new Point(178, 126);
            this.gameProgressPointsTextLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressPointsTextLabel.Name = "gameProgressPointsTextLabel";
            this.gameProgressPointsTextLabel.Size = new Size(80, 25);
            this.gameProgressPointsTextLabel.TabIndex = 10074;
            this.gameProgressPointsTextLabel.Text = "points.";
            // 
            // gameProgressHardcoreWorthLabel
            // 
            this.gameProgressHardcoreWorthLabel.AutoSize = true;
            this.gameProgressHardcoreWorthLabel.BackColor = Color.Transparent;
            this.gameProgressHardcoreWorthLabel.Font = new Font("Verdana", 9.75F);
            this.gameProgressHardcoreWorthLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressHardcoreWorthLabel.Location = new Point(231, 95);
            this.gameProgressHardcoreWorthLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressHardcoreWorthLabel.Name = "gameProgressHardcoreWorthLabel";
            this.gameProgressHardcoreWorthLabel.Size = new Size(345, 25);
            this.gameProgressHardcoreWorthLabel.TabIndex = 10073;
            this.gameProgressHardcoreWorthLabel.Text = "HARDCORE achievements, worth";
            // 
            // gameProgressPoints2Label
            // 
            this.gameProgressPoints2Label.BackColor = Color.Transparent;
            this.gameProgressPoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressPoints2Label.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressPoints2Label.Location = new Point(8, 126);
            this.gameProgressPoints2Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressPoints2Label.Name = "gameProgressPoints2Label";
            this.gameProgressPoints2Label.Size = new Size(82, 25);
            this.gameProgressPoints2Label.TabIndex = 10071;
            this.gameProgressPoints2Label.Text = "99999";
            this.gameProgressPoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressTruePoints2Label
            // 
            this.gameProgressTruePoints2Label.BackColor = Color.Transparent;
            this.gameProgressTruePoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressTruePoints2Label.ForeColor = Color.White;
            this.gameProgressTruePoints2Label.Location = new Point(81, 126);
            this.gameProgressTruePoints2Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressTruePoints2Label.Name = "gameProgressTruePoints2Label";
            this.gameProgressTruePoints2Label.Size = new Size(108, 25);
            this.gameProgressTruePoints2Label.TabIndex = 10072;
            this.gameProgressTruePoints2Label.Text = "(999999)";
            this.gameProgressTruePoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressAchievements2Label
            // 
            this.gameProgressAchievements2Label.BackColor = Color.Transparent;
            this.gameProgressAchievements2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAchievements2Label.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressAchievements2Label.Location = new Point(180, 95);
            this.gameProgressAchievements2Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressAchievements2Label.Name = "gameProgressAchievements2Label";
            this.gameProgressAchievements2Label.Size = new Size(52, 25);
            this.gameProgressAchievements2Label.TabIndex = 10070;
            this.gameProgressAchievements2Label.Text = "999";
            this.gameProgressAchievements2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressHaveEarnedLabel
            // 
            this.gameProgressHaveEarnedLabel.AutoSize = true;
            this.gameProgressHaveEarnedLabel.BackColor = Color.Transparent;
            this.gameProgressHaveEarnedLabel.Font = new Font("Verdana", 9.75F);
            this.gameProgressHaveEarnedLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressHaveEarnedLabel.Location = new Point(8, 95);
            this.gameProgressHaveEarnedLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressHaveEarnedLabel.Name = "gameProgressHaveEarnedLabel";
            this.gameProgressHaveEarnedLabel.Size = new Size(181, 25);
            this.gameProgressHaveEarnedLabel.TabIndex = 10069;
            this.gameProgressHaveEarnedLabel.Text = "You have earned";
            // 
            // gameProgressPercentCompletePictureBox
            // 
            this.gameProgressPercentCompletePictureBox.BackColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameProgressPercentCompletePictureBox.Location = new Point(381, 220);
            this.gameProgressPercentCompletePictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressPercentCompletePictureBox.Name = "gameProgressPercentCompletePictureBox";
            this.gameProgressPercentCompletePictureBox.Size = new Size(273, 5);
            this.gameProgressPercentCompletePictureBox.TabIndex = 10066;
            this.gameProgressPercentCompletePictureBox.TabStop = false;
            // 
            // gameProgressMasteryPictureBox
            // 
            this.gameProgressMasteryPictureBox.Image = global::Retro_Achievement_Tracker.Properties.Resources.mastered_icon;
            this.gameProgressMasteryPictureBox.Location = new Point(656, 208);
            this.gameProgressMasteryPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressMasteryPictureBox.Name = "gameProgressMasteryPictureBox";
            this.gameProgressMasteryPictureBox.Size = new Size(30, 31);
            this.gameProgressMasteryPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.gameProgressMasteryPictureBox.TabIndex = 10068;
            this.gameProgressMasteryPictureBox.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = Color.Transparent;
            this.pictureBox21.Image = global::Retro_Achievement_Tracker.Properties.Resources.progression_meter;
            this.pictureBox21.Location = new Point(375, 200);
            this.pictureBox21.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new Size(316, 46);
            this.pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 10067;
            this.pictureBox21.TabStop = false;
            // 
            // label60
            // 
            this.label60.BackColor = Color.Transparent;
            this.label60.Font = new Font("Verdana", 9.75F);
            this.label60.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label60.Location = new Point(550, 63);
            this.label60.Margin = new Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new Size(81, 25);
            this.label60.TabIndex = 10065;
            this.label60.Text = "points.";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = Color.Transparent;
            this.label59.Font = new Font("Verdana", 9.75F);
            this.label59.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label59.Location = new Point(160, 63);
            this.label59.Margin = new Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new Size(216, 25);
            this.label59.TabIndex = 10064;
            this.label59.Text = "achievements worth";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = Color.Transparent;
            this.label58.Font = new Font("Verdana", 9.75F);
            this.label58.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label58.Location = new Point(4, 63);
            this.label58.Margin = new Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new Size(110, 25);
            this.label58.TabIndex = 10063;
            this.label58.Text = "There are";
            // 
            // label56
            // 
            this.label56.BackColor = Color.Transparent;
            this.label56.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label56.Location = new Point(4, 5);
            this.label56.Margin = new Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new Size(288, 40);
            this.label56.TabIndex = 10058;
            this.label56.Text = "Achievements";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox5.Location = new Point(3, 49);
            this.pictureBox5.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(690, 3);
            this.pictureBox5.TabIndex = 10059;
            this.pictureBox5.TabStop = false;
            // 
            // gameProgressAchievements1Label
            // 
            this.gameProgressAchievements1Label.BackColor = Color.Transparent;
            this.gameProgressAchievements1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAchievements1Label.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressAchievements1Label.Location = new Point(111, 63);
            this.gameProgressAchievements1Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressAchievements1Label.Name = "gameProgressAchievements1Label";
            this.gameProgressAchievements1Label.Size = new Size(52, 25);
            this.gameProgressAchievements1Label.TabIndex = 10058;
            this.gameProgressAchievements1Label.Text = "999";
            this.gameProgressAchievements1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressPoints1Label
            // 
            this.gameProgressPoints1Label.BackColor = Color.Transparent;
            this.gameProgressPoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressPoints1Label.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressPoints1Label.Location = new Point(374, 63);
            this.gameProgressPoints1Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressPoints1Label.Name = "gameProgressPoints1Label";
            this.gameProgressPoints1Label.Size = new Size(82, 25);
            this.gameProgressPoints1Label.TabIndex = 10059;
            this.gameProgressPoints1Label.Text = "99999";
            this.gameProgressPoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameProgressCompletedLabel
            // 
            this.gameProgressCompletedLabel.BackColor = Color.Transparent;
            this.gameProgressCompletedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressCompletedLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressCompletedLabel.Location = new Point(448, 245);
            this.gameProgressCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressCompletedLabel.Name = "gameProgressCompletedLabel";
            this.gameProgressCompletedLabel.Size = new Size(168, 25);
            this.gameProgressCompletedLabel.TabIndex = 10061;
            this.gameProgressCompletedLabel.Text = "0% Complete";
            // 
            // gameProgressTruePoints1Label
            // 
            this.gameProgressTruePoints1Label.BackColor = Color.Transparent;
            this.gameProgressTruePoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressTruePoints1Label.ForeColor = Color.White;
            this.gameProgressTruePoints1Label.Location = new Point(448, 63);
            this.gameProgressTruePoints1Label.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressTruePoints1Label.Name = "gameProgressTruePoints1Label";
            this.gameProgressTruePoints1Label.Size = new Size(114, 25);
            this.gameProgressTruePoints1Label.TabIndex = 10060;
            this.gameProgressTruePoints1Label.Text = "(999999)";
            this.gameProgressTruePoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel15.Controls.Add(this.label38);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.gameProgressOpenWindowButton);
            this.panel15.Controls.Add(this.gameProgressValuesPanel);
            this.panel15.Controls.Add(this.gameProgressAutoOpenWindowCheckbox);
            this.panel15.Controls.Add(this.pictureBox6);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Controls.Add(this.panel23);
            this.panel15.Controls.Add(this.gameProgressValuesOutlinePanel);
            this.panel15.Location = new Point(444, 5);
            this.panel15.Margin = new Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new Size(702, 271);
            this.panel15.TabIndex = 10081;
            // 
            // label38
            // 
            this.label38.BackColor = Color.Transparent;
            this.label38.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label38.Location = new Point(4, 5);
            this.label38.Margin = new Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new Size(364, 40);
            this.label38.TabIndex = 10062;
            this.label38.Text = "Window/Font Settings";
            // 
            // panel16
            // 
            this.panel16.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel16.Controls.Add(this.gameProgressAdvancedCheckBox);
            this.panel16.Controls.Add(this.label41);
            this.panel16.Controls.Add(this.label43);
            this.panel16.Controls.Add(this.label44);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Location = new Point(3, 62);
            this.panel16.Margin = new Padding(4, 5, 4, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new Size(694, 35);
            this.panel16.TabIndex = 10076;
            // 
            // gameProgressAdvancedCheckBox
            // 
            this.gameProgressAdvancedCheckBox.AutoSize = true;
            this.gameProgressAdvancedCheckBox.BackColor = Color.Transparent;
            this.gameProgressAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.gameProgressAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressAdvancedCheckBox.Location = new Point(8, 3);
            this.gameProgressAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressAdvancedCheckBox.Name = "gameProgressAdvancedCheckBox";
            this.gameProgressAdvancedCheckBox.Size = new Size(135, 29);
            this.gameProgressAdvancedCheckBox.TabIndex = 10053;
            this.gameProgressAdvancedCheckBox.Text = "Advanced";
            this.gameProgressAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.gameProgressAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label41
            // 
            this.label41.BackColor = Color.Transparent;
            this.label41.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label41.Location = new Point(225, 5);
            this.label41.Margin = new Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new Size(72, 25);
            this.label41.TabIndex = 10065;
            this.label41.Text = "Color";
            // 
            // label43
            // 
            this.label43.BackColor = Color.Transparent;
            this.label43.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label43.Location = new Point(291, 5);
            this.label43.Margin = new Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new Size(75, 25);
            this.label43.TabIndex = 10066;
            this.label43.Text = "Font";
            // 
            // label44
            // 
            this.label44.BackColor = Color.Transparent;
            this.label44.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label44.Location = new Point(524, 5);
            this.label44.Margin = new Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new Size(62, 25);
            this.label44.TabIndex = 10068;
            this.label44.Text = "Size";
            // 
            // label45
            // 
            this.label45.BackColor = Color.Transparent;
            this.label45.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label45.Location = new Point(594, 5);
            this.label45.Margin = new Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new Size(88, 25);
            this.label45.TabIndex = 10067;
            this.label45.Text = "Enabled";
            // 
            // gameProgressOpenWindowButton
            // 
            this.gameProgressOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.gameProgressOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.gameProgressOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.gameProgressOpenWindowButton.Location = new Point(573, 3);
            this.gameProgressOpenWindowButton.Margin = new Padding(0);
            this.gameProgressOpenWindowButton.Name = "gameProgressOpenWindowButton";
            this.gameProgressOpenWindowButton.Size = new Size(112, 42);
            this.gameProgressOpenWindowButton.TabIndex = 10021;
            this.gameProgressOpenWindowButton.Text = "Open";
            this.gameProgressOpenWindowButton.UseVisualStyleBackColor = false;
            this.gameProgressOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // gameProgressValuesPanel
            // 
            this.gameProgressValuesPanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressValuesPanel.Controls.Add(this.label46);
            this.gameProgressValuesPanel.Controls.Add(this.gameProgressValuesFontColorPictureBox);
            this.gameProgressValuesPanel.Controls.Add(this.gameProgressValuesFontComboBox);
            this.gameProgressValuesPanel.Location = new Point(3, 163);
            this.gameProgressValuesPanel.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesPanel.Name = "gameProgressValuesPanel";
            this.gameProgressValuesPanel.Size = new Size(694, 35);
            this.gameProgressValuesPanel.TabIndex = 10061;
            // 
            // label46
            // 
            this.label46.BackColor = Color.Transparent;
            this.label46.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label46.Location = new Point(4, 6);
            this.label46.Margin = new Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new Size(216, 25);
            this.label46.TabIndex = 10066;
            this.label46.Text = "Values";
            // 
            // gameProgressValuesFontColorPictureBox
            // 
            this.gameProgressValuesFontColorPictureBox.BackColor = Color.White;
            this.gameProgressValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameProgressValuesFontColorPictureBox.Location = new Point(230, 5);
            this.gameProgressValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesFontColorPictureBox.Name = "gameProgressValuesFontColorPictureBox";
            this.gameProgressValuesFontColorPictureBox.Size = new Size(22, 22);
            this.gameProgressValuesFontColorPictureBox.TabIndex = 45;
            this.gameProgressValuesFontColorPictureBox.TabStop = false;
            this.gameProgressValuesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameProgressValuesFontComboBox
            // 
            this.gameProgressValuesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressValuesFontComboBox.ForeColor = Color.White;
            this.gameProgressValuesFontComboBox.FormattingEnabled = true;
            this.gameProgressValuesFontComboBox.Location = new Point(290, 3);
            this.gameProgressValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesFontComboBox.Name = "gameProgressValuesFontComboBox";
            this.gameProgressValuesFontComboBox.Size = new Size(301, 28);
            this.gameProgressValuesFontComboBox.TabIndex = 45;
            this.gameProgressValuesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // gameProgressAutoOpenWindowCheckbox
            // 
            this.gameProgressAutoOpenWindowCheckbox.AutoSize = true;
            this.gameProgressAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.gameProgressAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.gameProgressAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressAutoOpenWindowCheckbox.Name = "gameProgressAutoOpenWindowCheckbox";
            this.gameProgressAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.gameProgressAutoOpenWindowCheckbox.TabIndex = 10022;
            this.gameProgressAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.gameProgressAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.gameProgressAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox6.Location = new Point(3, 49);
            this.pictureBox6.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(690, 3);
            this.pictureBox6.TabIndex = 10063;
            this.pictureBox6.TabStop = false;
            // 
            // panel18
            // 
            this.panel18.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel18.Controls.Add(this.gameProgressBackgroundColorPictureBox);
            this.panel18.Controls.Add(this.label47);
            this.panel18.Location = new Point(3, 95);
            this.panel18.Margin = new Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new Size(694, 35);
            this.panel18.TabIndex = 10061;
            // 
            // gameProgressBackgroundColorPictureBox
            // 
            this.gameProgressBackgroundColorPictureBox.BackColor = Color.White;
            this.gameProgressBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameProgressBackgroundColorPictureBox.Location = new Point(230, 5);
            this.gameProgressBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressBackgroundColorPictureBox.Name = "gameProgressBackgroundColorPictureBox";
            this.gameProgressBackgroundColorPictureBox.Size = new Size(22, 22);
            this.gameProgressBackgroundColorPictureBox.TabIndex = 42;
            this.gameProgressBackgroundColorPictureBox.TabStop = false;
            this.gameProgressBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label47
            // 
            this.label47.BackColor = Color.Transparent;
            this.label47.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label47.Location = new Point(4, 5);
            this.label47.Margin = new Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new Size(216, 25);
            this.label47.TabIndex = 10064;
            this.label47.Text = "Window Background";
            // 
            // panel19
            // 
            this.panel19.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel19.Controls.Add(this.gameProgressNamesLabel);
            this.panel19.Controls.Add(this.gameProgressNamesFontColorPictureBox);
            this.panel19.Controls.Add(this.gameProgressNamesFontComboBox);
            this.panel19.Location = new Point(3, 129);
            this.panel19.Margin = new Padding(4, 5, 4, 5);
            this.panel19.Name = "panel19";
            this.panel19.Size = new Size(694, 35);
            this.panel19.TabIndex = 10061;
            // 
            // gameProgressNamesLabel
            // 
            this.gameProgressNamesLabel.BackColor = Color.Transparent;
            this.gameProgressNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressNamesLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressNamesLabel.Location = new Point(4, 6);
            this.gameProgressNamesLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressNamesLabel.Name = "gameProgressNamesLabel";
            this.gameProgressNamesLabel.Size = new Size(216, 25);
            this.gameProgressNamesLabel.TabIndex = 10065;
            this.gameProgressNamesLabel.Text = "Names";
            // 
            // gameProgressNamesFontColorPictureBox
            // 
            this.gameProgressNamesFontColorPictureBox.BackColor = Color.White;
            this.gameProgressNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameProgressNamesFontColorPictureBox.Location = new Point(230, 6);
            this.gameProgressNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressNamesFontColorPictureBox.Name = "gameProgressNamesFontColorPictureBox";
            this.gameProgressNamesFontColorPictureBox.Size = new Size(22, 22);
            this.gameProgressNamesFontColorPictureBox.TabIndex = 45;
            this.gameProgressNamesFontColorPictureBox.TabStop = false;
            this.gameProgressNamesFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameProgressNamesFontComboBox
            // 
            this.gameProgressNamesFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressNamesFontComboBox.ForeColor = Color.White;
            this.gameProgressNamesFontComboBox.FormattingEnabled = true;
            this.gameProgressNamesFontComboBox.Location = new Point(290, 3);
            this.gameProgressNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressNamesFontComboBox.Name = "gameProgressNamesFontComboBox";
            this.gameProgressNamesFontComboBox.Size = new Size(301, 28);
            this.gameProgressNamesFontComboBox.TabIndex = 45;
            this.gameProgressNamesFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel23
            // 
            this.panel23.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel23.Controls.Add(this.gameProgressNamesFontOutlineNumericUpDown);
            this.panel23.Controls.Add(this.gameProgressNamesOutlineCheckBox);
            this.panel23.Controls.Add(this.gameProgressNamesOutlineLabel);
            this.panel23.Controls.Add(this.gameProgressNamesFontOutlineColorPictureBox);
            this.panel23.Location = new Point(3, 197);
            this.panel23.Margin = new Padding(4, 5, 4, 5);
            this.panel23.Name = "panel23";
            this.panel23.Size = new Size(694, 35);
            this.panel23.TabIndex = 10061;
            // 
            // gameProgressNamesFontOutlineNumericUpDown
            // 
            this.gameProgressNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gameProgressNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.gameProgressNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.gameProgressNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.gameProgressNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gameProgressNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameProgressNamesFontOutlineNumericUpDown.Name = "gameProgressNamesFontOutlineNumericUpDown";
            this.gameProgressNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.gameProgressNamesFontOutlineNumericUpDown.TabIndex = 45;
            this.gameProgressNamesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameProgressNamesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // gameProgressNamesOutlineCheckBox
            // 
            this.gameProgressNamesOutlineCheckBox.AutoSize = true;
            this.gameProgressNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressNamesOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressNamesOutlineCheckBox.Location = new Point(620, 8);
            this.gameProgressNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressNamesOutlineCheckBox.Name = "gameProgressNamesOutlineCheckBox";
            this.gameProgressNamesOutlineCheckBox.Size = new Size(22, 21);
            this.gameProgressNamesOutlineCheckBox.TabIndex = 45;
            this.gameProgressNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressNamesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressNamesOutlineLabel
            // 
            this.gameProgressNamesOutlineLabel.BackColor = Color.Transparent;
            this.gameProgressNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressNamesOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressNamesOutlineLabel.Location = new Point(4, 5);
            this.gameProgressNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.gameProgressNamesOutlineLabel.Name = "gameProgressNamesOutlineLabel";
            this.gameProgressNamesOutlineLabel.Size = new Size(216, 25);
            this.gameProgressNamesOutlineLabel.TabIndex = 10066;
            this.gameProgressNamesOutlineLabel.Text = "Names OutlineColor";
            // 
            // gameProgressNamesFontOutlineColorPictureBox
            // 
            this.gameProgressNamesFontOutlineColorPictureBox.BackColor = Color.White;
            this.gameProgressNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameProgressNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.gameProgressNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressNamesFontOutlineColorPictureBox.Name = "gameProgressNamesFontOutlineColorPictureBox";
            this.gameProgressNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.gameProgressNamesFontOutlineColorPictureBox.TabIndex = 45;
            this.gameProgressNamesFontOutlineColorPictureBox.TabStop = false;
            this.gameProgressNamesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameProgressValuesOutlinePanel
            // 
            this.gameProgressValuesOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressValuesOutlinePanel.Controls.Add(this.label50);
            this.gameProgressValuesOutlinePanel.Controls.Add(this.gameProgressValuesFontOutlineColorPictureBox);
            this.gameProgressValuesOutlinePanel.Controls.Add(this.gameProgressValuesFontOutlineNumericUpDown);
            this.gameProgressValuesOutlinePanel.Controls.Add(this.gameProgressValuesOutlineCheckBox);
            this.gameProgressValuesOutlinePanel.Location = new Point(3, 231);
            this.gameProgressValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesOutlinePanel.Name = "gameProgressValuesOutlinePanel";
            this.gameProgressValuesOutlinePanel.Size = new Size(694, 35);
            this.gameProgressValuesOutlinePanel.TabIndex = 10067;
            // 
            // label50
            // 
            this.label50.BackColor = Color.Transparent;
            this.label50.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label50.Location = new Point(4, 6);
            this.label50.Margin = new Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new Size(216, 25);
            this.label50.TabIndex = 10066;
            this.label50.Text = "Values OutlineColor";
            // 
            // gameProgressValuesFontOutlineColorPictureBox
            // 
            this.gameProgressValuesFontOutlineColorPictureBox.BackColor = Color.White;
            this.gameProgressValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.gameProgressValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.gameProgressValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesFontOutlineColorPictureBox.Name = "gameProgressValuesFontOutlineColorPictureBox";
            this.gameProgressValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.gameProgressValuesFontOutlineColorPictureBox.TabIndex = 45;
            this.gameProgressValuesFontOutlineColorPictureBox.TabStop = false;
            this.gameProgressValuesFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // gameProgressValuesFontOutlineNumericUpDown
            // 
            this.gameProgressValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gameProgressValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.gameProgressValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            this.gameProgressValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.gameProgressValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gameProgressValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameProgressValuesFontOutlineNumericUpDown.Name = "gameProgressValuesFontOutlineNumericUpDown";
            this.gameProgressValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.gameProgressValuesFontOutlineNumericUpDown.TabIndex = 45;
            this.gameProgressValuesFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameProgressValuesFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // gameProgressValuesOutlineCheckBox
            // 
            this.gameProgressValuesOutlineCheckBox.AutoSize = true;
            this.gameProgressValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressValuesOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.gameProgressValuesOutlineCheckBox.Location = new Point(620, 9);
            this.gameProgressValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressValuesOutlineCheckBox.Name = "gameProgressValuesOutlineCheckBox";
            this.gameProgressValuesOutlineCheckBox.Size = new Size(22, 21);
            this.gameProgressValuesOutlineCheckBox.TabIndex = 45;
            this.gameProgressValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressValuesOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel36
            // 
            this.panel36.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel36.Controls.Add(this.panel27);
            this.panel36.Controls.Add(this.panel25);
            this.panel36.Controls.Add(this.panel37);
            this.panel36.Controls.Add(this.panel26);
            this.panel36.Controls.Add(this.label73);
            this.panel36.Controls.Add(this.gameProgressDefaultButton);
            this.panel36.Controls.Add(this.pictureBox17);
            this.panel36.Controls.Add(this.panel38);
            this.panel36.Controls.Add(this.panel39);
            this.panel36.Controls.Add(this.panel40);
            this.panel36.Controls.Add(this.panel41);
            this.panel36.Location = new Point(6, 5);
            this.panel36.Margin = new Padding(4, 5, 4, 5);
            this.panel36.Name = "panel36";
            this.panel36.Size = new Size(430, 342);
            this.panel36.TabIndex = 10080;
            // 
            // panel27
            // 
            this.panel27.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel27.Controls.Add(this.label55);
            this.panel27.Controls.Add(this.gameProgressRadioButtonPeriod);
            this.panel27.Controls.Add(this.label54);
            this.panel27.Controls.Add(this.gameProgressRadioButtonColon);
            this.panel27.Controls.Add(this.label53);
            this.panel27.Controls.Add(this.gameProgressRadioButtonBackslash);
            this.panel27.Controls.Add(this.label51);
            this.panel27.Location = new Point(3, 298);
            this.panel27.Margin = new Padding(4, 5, 4, 5);
            this.panel27.Name = "panel27";
            this.panel27.Size = new Size(417, 35);
            this.panel27.TabIndex = 10073;
            // 
            // label55
            // 
            this.label55.BackColor = Color.Transparent;
            this.label55.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label55.Location = new Point(346, 6);
            this.label55.Margin = new Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new Size(22, 25);
            this.label55.TabIndex = 10074;
            this.label55.Text = ".";
            // 
            // gameProgressRadioButtonPeriod
            // 
            this.gameProgressRadioButtonPeriod.AutoSize = true;
            this.gameProgressRadioButtonPeriod.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressRadioButtonPeriod.Location = new Point(320, 8);
            this.gameProgressRadioButtonPeriod.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressRadioButtonPeriod.Name = "gameProgressRadioButtonPeriod";
            this.gameProgressRadioButtonPeriod.Size = new Size(21, 20);
            this.gameProgressRadioButtonPeriod.TabIndex = 10073;
            this.gameProgressRadioButtonPeriod.UseVisualStyleBackColor = true;
            this.gameProgressRadioButtonPeriod.CheckedChanged += new System.EventHandler(this.DividerCharacter_RadioButtonClicked);
            // 
            // label54
            // 
            this.label54.BackColor = Color.Transparent;
            this.label54.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label54.Location = new Point(264, 6);
            this.label54.Margin = new Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new Size(22, 25);
            this.label54.TabIndex = 10072;
            this.label54.Text = ":";
            // 
            // gameProgressRadioButtonColon
            // 
            this.gameProgressRadioButtonColon.AutoSize = true;
            this.gameProgressRadioButtonColon.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressRadioButtonColon.Location = new Point(237, 8);
            this.gameProgressRadioButtonColon.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressRadioButtonColon.Name = "gameProgressRadioButtonColon";
            this.gameProgressRadioButtonColon.Size = new Size(21, 20);
            this.gameProgressRadioButtonColon.TabIndex = 10071;
            this.gameProgressRadioButtonColon.UseVisualStyleBackColor = true;
            this.gameProgressRadioButtonColon.CheckedChanged += new System.EventHandler(this.DividerCharacter_RadioButtonClicked);
            // 
            // label53
            // 
            this.label53.BackColor = Color.Transparent;
            this.label53.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label53.Location = new Point(177, 6);
            this.label53.Margin = new Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new Size(22, 25);
            this.label53.TabIndex = 10070;
            this.label53.Text = "/";
            // 
            // gameProgressRadioButtonBackslash
            // 
            this.gameProgressRadioButtonBackslash.AutoSize = true;
            this.gameProgressRadioButtonBackslash.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressRadioButtonBackslash.Location = new Point(150, 8);
            this.gameProgressRadioButtonBackslash.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressRadioButtonBackslash.Name = "gameProgressRadioButtonBackslash";
            this.gameProgressRadioButtonBackslash.Size = new Size(21, 20);
            this.gameProgressRadioButtonBackslash.TabIndex = 10067;
            this.gameProgressRadioButtonBackslash.UseVisualStyleBackColor = true;
            this.gameProgressRadioButtonBackslash.CheckedChanged += new System.EventHandler(this.DividerCharacter_RadioButtonClicked);
            // 
            // label51
            // 
            this.label51.BackColor = Color.Transparent;
            this.label51.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label51.Location = new Point(4, 6);
            this.label51.Margin = new Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new Size(141, 25);
            this.label51.TabIndex = 10069;
            this.label51.Text = "Separator";
            // 
            // panel25
            // 
            this.panel25.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel25.Location = new Point(3, 265);
            this.panel25.Margin = new Padding(4, 5, 4, 5);
            this.panel25.Name = "panel25";
            this.panel25.Size = new Size(417, 35);
            this.panel25.TabIndex = 10072;
            // 
            // panel37
            // 
            this.panel37.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel37.Controls.Add(this.label39);
            this.panel37.Controls.Add(this.label40);
            this.panel37.Controls.Add(this.label72);
            this.panel37.Location = new Point(3, 62);
            this.panel37.Margin = new Padding(4, 5, 4, 5);
            this.panel37.Name = "panel37";
            this.panel37.Size = new Size(417, 35);
            this.panel37.TabIndex = 10079;
            // 
            // label39
            // 
            this.label39.BackColor = Color.Transparent;
            this.label39.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label39.Location = new Point(4, 5);
            this.label39.Margin = new Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new Size(75, 25);
            this.label39.TabIndex = 10071;
            this.label39.Text = "Field";
            // 
            // label40
            // 
            this.label40.BackColor = Color.Transparent;
            this.label40.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label40.Location = new Point(170, 5);
            this.label40.Margin = new Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new Size(153, 25);
            this.label40.TabIndex = 10073;
            this.label40.Text = "Display Text";
            // 
            // label72
            // 
            this.label72.BackColor = Color.Transparent;
            this.label72.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label72.Location = new Point(332, 5);
            this.label72.Margin = new Padding(4, 0, 4, 0);
            this.label72.Name = "label72";
            this.label72.Size = new Size(92, 25);
            this.label72.TabIndex = 10072;
            this.label72.Text = "Enabled";
            // 
            // panel26
            // 
            this.panel26.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel26.Controls.Add(this.label52);
            this.panel26.Controls.Add(this.gameProgressCompletedTextBox);
            this.panel26.Controls.Add(this.gameProgressCompletedCheckBox);
            this.panel26.Location = new Point(3, 231);
            this.panel26.Margin = new Padding(4, 5, 4, 5);
            this.panel26.Name = "panel26";
            this.panel26.Size = new Size(417, 35);
            this.panel26.TabIndex = 10071;
            // 
            // label52
            // 
            this.label52.BackColor = Color.Transparent;
            this.label52.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label52.Location = new Point(4, 6);
            this.label52.Margin = new Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new Size(141, 25);
            this.label52.TabIndex = 10068;
            this.label52.Text = "Completed";
            // 
            // gameProgressCompletedTextBox
            // 
            this.gameProgressCompletedTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressCompletedTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressCompletedTextBox.ForeColor = Color.White;
            this.gameProgressCompletedTextBox.Location = new Point(174, 0);
            this.gameProgressCompletedTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressCompletedTextBox.Name = "gameProgressCompletedTextBox";
            this.gameProgressCompletedTextBox.Size = new Size(146, 31);
            this.gameProgressCompletedTextBox.TabIndex = 7;
            this.gameProgressCompletedTextBox.Text = "Completed";
            this.gameProgressCompletedTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // gameProgressCompletedCheckBox
            // 
            this.gameProgressCompletedCheckBox.AutoSize = true;
            this.gameProgressCompletedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressCompletedCheckBox.Location = new Point(338, 8);
            this.gameProgressCompletedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressCompletedCheckBox.Name = "gameProgressCompletedCheckBox";
            this.gameProgressCompletedCheckBox.Size = new Size(22, 21);
            this.gameProgressCompletedCheckBox.TabIndex = 56;
            this.gameProgressCompletedCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressCompletedCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label73
            // 
            this.label73.BackColor = Color.Transparent;
            this.label73.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label73.Location = new Point(4, 5);
            this.label73.Margin = new Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new Size(285, 40);
            this.label73.TabIndex = 10069;
            this.label73.Text = "Field Overrides";
            // 
            // gameProgressDefaultButton
            // 
            this.gameProgressDefaultButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gameProgressDefaultButton.FlatStyle = FlatStyle.Flat;
            this.gameProgressDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressDefaultButton.ForeColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gameProgressDefaultButton.Location = new Point(306, 3);
            this.gameProgressDefaultButton.Margin = new Padding(0);
            this.gameProgressDefaultButton.Name = "gameProgressDefaultButton";
            this.gameProgressDefaultButton.Size = new Size(112, 42);
            this.gameProgressDefaultButton.TabIndex = 39;
            this.gameProgressDefaultButton.Text = "Default";
            this.gameProgressDefaultButton.UseVisualStyleBackColor = false;
            this.gameProgressDefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox17.Location = new Point(3, 49);
            this.pictureBox17.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new Size(412, 3);
            this.pictureBox17.TabIndex = 10070;
            this.pictureBox17.TabStop = false;
            // 
            // panel38
            // 
            this.panel38.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel38.Controls.Add(this.label74);
            this.panel38.Controls.Add(this.gameProgressAchievementsCheckBox);
            this.panel38.Controls.Add(this.gameProgressAchievementsTextBox);
            this.panel38.Location = new Point(3, 95);
            this.panel38.Margin = new Padding(4, 5, 4, 5);
            this.panel38.Name = "panel38";
            this.panel38.Size = new Size(417, 35);
            this.panel38.TabIndex = 10061;
            // 
            // label74
            // 
            this.label74.BackColor = Color.Transparent;
            this.label74.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label74.Location = new Point(4, 5);
            this.label74.Margin = new Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new Size(168, 25);
            this.label74.TabIndex = 10066;
            this.label74.Text = "Achievements";
            // 
            // gameProgressAchievementsCheckBox
            // 
            this.gameProgressAchievementsCheckBox.AutoSize = true;
            this.gameProgressAchievementsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAchievementsCheckBox.Location = new Point(338, 8);
            this.gameProgressAchievementsCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressAchievementsCheckBox.Name = "gameProgressAchievementsCheckBox";
            this.gameProgressAchievementsCheckBox.Size = new Size(22, 21);
            this.gameProgressAchievementsCheckBox.TabIndex = 52;
            this.gameProgressAchievementsCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressAchievementsCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressAchievementsTextBox
            // 
            this.gameProgressAchievementsTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressAchievementsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressAchievementsTextBox.ForeColor = Color.White;
            this.gameProgressAchievementsTextBox.Location = new Point(174, 0);
            this.gameProgressAchievementsTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressAchievementsTextBox.Name = "gameProgressAchievementsTextBox";
            this.gameProgressAchievementsTextBox.Size = new Size(146, 31);
            this.gameProgressAchievementsTextBox.TabIndex = 1;
            this.gameProgressAchievementsTextBox.Text = "Achievements";
            this.gameProgressAchievementsTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel39
            // 
            this.panel39.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel39.Controls.Add(this.label75);
            this.panel39.Controls.Add(this.gameProgressRatioCheckBox);
            this.panel39.Controls.Add(this.gameProgressRatioTextBox);
            this.panel39.Location = new Point(3, 197);
            this.panel39.Margin = new Padding(4, 5, 4, 5);
            this.panel39.Name = "panel39";
            this.panel39.Size = new Size(417, 35);
            this.panel39.TabIndex = 10061;
            // 
            // label75
            // 
            this.label75.BackColor = Color.Transparent;
            this.label75.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label75.Location = new Point(4, 6);
            this.label75.Margin = new Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new Size(141, 25);
            this.label75.TabIndex = 10069;
            this.label75.Text = "Retro Ratio";
            // 
            // gameProgressRatioCheckBox
            // 
            this.gameProgressRatioCheckBox.AutoSize = true;
            this.gameProgressRatioCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressRatioCheckBox.Location = new Point(338, 8);
            this.gameProgressRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressRatioCheckBox.Name = "gameProgressRatioCheckBox";
            this.gameProgressRatioCheckBox.Size = new Size(22, 21);
            this.gameProgressRatioCheckBox.TabIndex = 55;
            this.gameProgressRatioCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressRatioCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // gameProgressRatioTextBox
            // 
            this.gameProgressRatioTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressRatioTextBox.ForeColor = Color.White;
            this.gameProgressRatioTextBox.Location = new Point(174, 0);
            this.gameProgressRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressRatioTextBox.Name = "gameProgressRatioTextBox";
            this.gameProgressRatioTextBox.Size = new Size(146, 31);
            this.gameProgressRatioTextBox.TabIndex = 5;
            this.gameProgressRatioTextBox.Text = "Retro Ratio";
            this.gameProgressRatioTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // panel40
            // 
            this.panel40.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel40.Controls.Add(this.label76);
            this.panel40.Controls.Add(this.gameProgressTruePointsTextBox);
            this.panel40.Controls.Add(this.gameProgressTruePointsCheckBox);
            this.panel40.Location = new Point(3, 163);
            this.panel40.Margin = new Padding(4, 5, 4, 5);
            this.panel40.Name = "panel40";
            this.panel40.Size = new Size(417, 35);
            this.panel40.TabIndex = 10061;
            // 
            // label76
            // 
            this.label76.BackColor = Color.Transparent;
            this.label76.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label76.Location = new Point(4, 6);
            this.label76.Margin = new Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new Size(141, 25);
            this.label76.TabIndex = 10068;
            this.label76.Text = "True Points";
            // 
            // gameProgressTruePointsTextBox
            // 
            this.gameProgressTruePointsTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressTruePointsTextBox.ForeColor = Color.White;
            this.gameProgressTruePointsTextBox.Location = new Point(174, 0);
            this.gameProgressTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressTruePointsTextBox.Name = "gameProgressTruePointsTextBox";
            this.gameProgressTruePointsTextBox.Size = new Size(146, 31);
            this.gameProgressTruePointsTextBox.TabIndex = 7;
            this.gameProgressTruePointsTextBox.Text = "True Points";
            this.gameProgressTruePointsTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // gameProgressTruePointsCheckBox
            // 
            this.gameProgressTruePointsCheckBox.AutoSize = true;
            this.gameProgressTruePointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressTruePointsCheckBox.Location = new Point(338, 8);
            this.gameProgressTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressTruePointsCheckBox.Name = "gameProgressTruePointsCheckBox";
            this.gameProgressTruePointsCheckBox.Size = new Size(22, 21);
            this.gameProgressTruePointsCheckBox.TabIndex = 56;
            this.gameProgressTruePointsCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressTruePointsCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel41
            // 
            this.panel41.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel41.Controls.Add(this.label77);
            this.panel41.Controls.Add(this.gameProgressPointsTextBox);
            this.panel41.Controls.Add(this.gameProgressPointsCheckBox);
            this.panel41.Location = new Point(3, 129);
            this.panel41.Margin = new Padding(4, 5, 4, 5);
            this.panel41.Name = "panel41";
            this.panel41.Size = new Size(417, 35);
            this.panel41.TabIndex = 10061;
            // 
            // label77
            // 
            this.label77.BackColor = Color.Transparent;
            this.label77.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label77.Location = new Point(4, 6);
            this.label77.Margin = new Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new Size(141, 25);
            this.label77.TabIndex = 10067;
            this.label77.Text = "Points";
            // 
            // gameProgressPointsTextBox
            // 
            this.gameProgressPointsTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressPointsTextBox.ForeColor = Color.White;
            this.gameProgressPointsTextBox.Location = new Point(174, 0);
            this.gameProgressPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressPointsTextBox.Name = "gameProgressPointsTextBox";
            this.gameProgressPointsTextBox.Size = new Size(146, 31);
            this.gameProgressPointsTextBox.TabIndex = 6;
            this.gameProgressPointsTextBox.Text = "Points";
            this.gameProgressPointsTextBox.TextChanged += new System.EventHandler(this.OverrideTextBox_TextChanged);
            // 
            // gameProgressPointsCheckBox
            // 
            this.gameProgressPointsCheckBox.AutoSize = true;
            this.gameProgressPointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.gameProgressPointsCheckBox.Location = new Point(338, 8);
            this.gameProgressPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressPointsCheckBox.Name = "gameProgressPointsCheckBox";
            this.gameProgressPointsCheckBox.Size = new Size(22, 21);
            this.gameProgressPointsCheckBox.TabIndex = 54;
            this.gameProgressPointsCheckBox.UseVisualStyleBackColor = true;
            this.gameProgressPointsCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel113
            // 
            this.panel113.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel113.Controls.Add(this.label155);
            this.panel113.Controls.Add(this.pictureBox15);
            this.panel113.Controls.Add(this.recentAchievementsMaxListNumericUpDown);
            this.panel113.Controls.Add(this.recentAchievementsMaxListLabel);
            this.panel113.Controls.Add(this.recentAchievementsAutoScrollCheckBox);
            this.panel113.Location = new Point(6, 5);
            this.panel113.Margin = new Padding(4, 5, 4, 5);
            this.panel113.Name = "panel113";
            this.panel113.Size = new Size(434, 98);
            this.panel113.TabIndex = 10083;
            // 
            // label155
            // 
            this.label155.BackColor = Color.Transparent;
            this.label155.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label155.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label155.Location = new Point(4, 5);
            this.label155.Margin = new Padding(4, 0, 4, 0);
            this.label155.Name = "label155";
            this.label155.Size = new Size(285, 40);
            this.label155.TabIndex = 10069;
            this.label155.Text = "List Settings";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox15.Location = new Point(3, 49);
            this.pictureBox15.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new Size(412, 3);
            this.pictureBox15.TabIndex = 10070;
            this.pictureBox15.TabStop = false;
            // 
            // recentAchievementsAutoScrollCheckBox
            // 
            this.recentAchievementsAutoScrollCheckBox.AutoSize = true;
            this.recentAchievementsAutoScrollCheckBox.BackColor = Color.Transparent;
            this.recentAchievementsAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.recentAchievementsAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsAutoScrollCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsAutoScrollCheckBox.Location = new Point(4, 60);
            this.recentAchievementsAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsAutoScrollCheckBox.Name = "recentAchievementsAutoScrollCheckBox";
            this.recentAchievementsAutoScrollCheckBox.Size = new Size(147, 29);
            this.recentAchievementsAutoScrollCheckBox.TabIndex = 10055;
            this.recentAchievementsAutoScrollCheckBox.Text = "Auto-scroll";
            this.recentAchievementsAutoScrollCheckBox.UseVisualStyleBackColor = false;
            this.recentAchievementsAutoScrollCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel99
            // 
            this.panel99.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel99.Controls.Add(this.recentAchievementsLinePanel);
            this.panel99.Controls.Add(this.label17);
            this.panel99.Controls.Add(this.panel101);
            this.panel99.Controls.Add(this.recentAchievementsPointsPanel);
            this.panel99.Controls.Add(this.panel103);
            this.panel99.Controls.Add(this.panel104);
            this.panel99.Controls.Add(this.recentAchievementsOpenWindowButton);
            this.panel99.Controls.Add(this.recentAchievementsDescriptionOutlinePanel);
            this.panel99.Controls.Add(this.recentAchievementsDescriptionPanel);
            this.panel99.Controls.Add(this.recentAchievementsAutoOpenWindowCheckbox);
            this.panel99.Controls.Add(this.pictureBox23);
            this.panel99.Controls.Add(this.panel107);
            this.panel99.Controls.Add(this.panel108);
            this.panel99.Controls.Add(this.recentAchievementsPointsOutlinePanel);
            this.panel99.Controls.Add(this.recentAchievementsLineOutlinePanel);
            this.panel99.Location = new Point(444, 5);
            this.panel99.Margin = new Padding(4, 5, 4, 5);
            this.panel99.Name = "panel99";
            this.panel99.Size = new Size(702, 438);
            this.panel99.TabIndex = 10082;
            // 
            // recentAchievementsLinePanel
            // 
            this.recentAchievementsLinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.recentAchievementsLinePanel.Controls.Add(this.label16);
            this.recentAchievementsLinePanel.Controls.Add(this.recentAchievementsLineColorPictureBox);
            this.recentAchievementsLinePanel.Location = new Point(3, 265);
            this.recentAchievementsLinePanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLinePanel.Name = "recentAchievementsLinePanel";
            this.recentAchievementsLinePanel.Size = new Size(694, 35);
            this.recentAchievementsLinePanel.TabIndex = 10068;
            // 
            // label16
            // 
            this.label16.BackColor = Color.Transparent;
            this.label16.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label16.Location = new Point(4, 6);
            this.label16.Margin = new Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new Size(216, 25);
            this.label16.TabIndex = 10066;
            this.label16.Text = "Line";
            // 
            // recentAchievementsLineColorPictureBox
            // 
            this.recentAchievementsLineColorPictureBox.BackColor = Color.White;
            this.recentAchievementsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsLineColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLineColorPictureBox.Name = "recentAchievementsLineColorPictureBox";
            this.recentAchievementsLineColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsLineColorPictureBox.TabIndex = 45;
            this.recentAchievementsLineColorPictureBox.TabStop = false;
            this.recentAchievementsLineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label17
            // 
            this.label17.BackColor = Color.Transparent;
            this.label17.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label17.Location = new Point(4, 5);
            this.label17.Margin = new Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new Size(364, 40);
            this.label17.TabIndex = 10062;
            this.label17.Text = "Window/Font Settings";
            // 
            // panel101
            // 
            this.panel101.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel101.Controls.Add(this.recentAchievementsBorderCheckBox);
            this.panel101.Controls.Add(this.recentAchievementsBorderColorPictureBox);
            this.panel101.Controls.Add(this.label18);
            this.panel101.Location = new Point(3, 129);
            this.panel101.Margin = new Padding(4, 5, 4, 5);
            this.panel101.Name = "panel101";
            this.panel101.Size = new Size(694, 35);
            this.panel101.TabIndex = 10069;
            // 
            // recentAchievementsBorderCheckBox
            // 
            this.recentAchievementsBorderCheckBox.AutoSize = true;
            this.recentAchievementsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsBorderCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsBorderCheckBox.Location = new Point(620, 8);
            this.recentAchievementsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsBorderCheckBox.Name = "recentAchievementsBorderCheckBox";
            this.recentAchievementsBorderCheckBox.Size = new Size(22, 21);
            this.recentAchievementsBorderCheckBox.TabIndex = 10065;
            this.recentAchievementsBorderCheckBox.UseVisualStyleBackColor = true;
            this.recentAchievementsBorderCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsBorderColorPictureBox
            // 
            this.recentAchievementsBorderColorPictureBox.BackColor = Color.White;
            this.recentAchievementsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsBorderColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsBorderColorPictureBox.Name = "recentAchievementsBorderColorPictureBox";
            this.recentAchievementsBorderColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsBorderColorPictureBox.TabIndex = 42;
            this.recentAchievementsBorderColorPictureBox.TabStop = false;
            this.recentAchievementsBorderColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label18
            // 
            this.label18.BackColor = Color.Transparent;
            this.label18.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label18.Location = new Point(4, 5);
            this.label18.Margin = new Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new Size(216, 25);
            this.label18.TabIndex = 10064;
            this.label18.Text = "Border";
            // 
            // recentAchievementsPointsPanel
            // 
            this.recentAchievementsPointsPanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsPointsPanel.Controls.Add(this.label19);
            this.recentAchievementsPointsPanel.Controls.Add(this.recentAchievementsPointsFontColorPictureBox);
            this.recentAchievementsPointsPanel.Controls.Add(this.recentAchievementsPointsFontComboBox);
            this.recentAchievementsPointsPanel.Location = new Point(3, 231);
            this.recentAchievementsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsPanel.Name = "recentAchievementsPointsPanel";
            this.recentAchievementsPointsPanel.Size = new Size(694, 35);
            this.recentAchievementsPointsPanel.TabIndex = 10070;
            // 
            // label19
            // 
            this.label19.BackColor = Color.Transparent;
            this.label19.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label19.Location = new Point(4, 6);
            this.label19.Margin = new Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new Size(216, 25);
            this.label19.TabIndex = 10065;
            this.label19.Text = "Points";
            // 
            // recentAchievementsPointsFontColorPictureBox
            // 
            this.recentAchievementsPointsFontColorPictureBox.BackColor = Color.White;
            this.recentAchievementsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsPointsFontColorPictureBox.Location = new Point(230, 6);
            this.recentAchievementsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsFontColorPictureBox.Name = "recentAchievementsPointsFontColorPictureBox";
            this.recentAchievementsPointsFontColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsPointsFontColorPictureBox.TabIndex = 45;
            this.recentAchievementsPointsFontColorPictureBox.TabStop = false;
            this.recentAchievementsPointsFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsPointsFontComboBox
            // 
            this.recentAchievementsPointsFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsPointsFontComboBox.ForeColor = Color.White;
            this.recentAchievementsPointsFontComboBox.FormattingEnabled = true;
            this.recentAchievementsPointsFontComboBox.Location = new Point(290, 3);
            this.recentAchievementsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsFontComboBox.Name = "recentAchievementsPointsFontComboBox";
            this.recentAchievementsPointsFontComboBox.Size = new Size(301, 28);
            this.recentAchievementsPointsFontComboBox.TabIndex = 45;
            this.recentAchievementsPointsFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // panel103
            // 
            this.panel103.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel103.Controls.Add(this.recentAchievementsAdvancedCheckBox);
            this.panel103.Controls.Add(this.label20);
            this.panel103.Controls.Add(this.label21);
            this.panel103.Controls.Add(this.label22);
            this.panel103.Controls.Add(this.label23);
            this.panel103.Location = new Point(3, 62);
            this.panel103.Margin = new Padding(4, 5, 4, 5);
            this.panel103.Name = "panel103";
            this.panel103.Size = new Size(694, 35);
            this.panel103.TabIndex = 10076;
            // 
            // recentAchievementsAdvancedCheckBox
            // 
            this.recentAchievementsAdvancedCheckBox.AutoSize = true;
            this.recentAchievementsAdvancedCheckBox.BackColor = Color.Transparent;
            this.recentAchievementsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.recentAchievementsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsAdvancedCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsAdvancedCheckBox.Location = new Point(8, 3);
            this.recentAchievementsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsAdvancedCheckBox.Name = "recentAchievementsAdvancedCheckBox";
            this.recentAchievementsAdvancedCheckBox.Size = new Size(135, 29);
            this.recentAchievementsAdvancedCheckBox.TabIndex = 10053;
            this.recentAchievementsAdvancedCheckBox.Text = "Advanced";
            this.recentAchievementsAdvancedCheckBox.UseVisualStyleBackColor = false;
            this.recentAchievementsAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_Click);
            // 
            // label20
            // 
            this.label20.BackColor = Color.Transparent;
            this.label20.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label20.Location = new Point(225, 5);
            this.label20.Margin = new Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new Size(72, 25);
            this.label20.TabIndex = 10065;
            this.label20.Text = "Color";
            // 
            // label21
            // 
            this.label21.BackColor = Color.Transparent;
            this.label21.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label21.Location = new Point(291, 5);
            this.label21.Margin = new Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new Size(75, 25);
            this.label21.TabIndex = 10066;
            this.label21.Text = "Font";
            // 
            // label22
            // 
            this.label22.BackColor = Color.Transparent;
            this.label22.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label22.Location = new Point(524, 5);
            this.label22.Margin = new Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new Size(62, 25);
            this.label22.TabIndex = 10068;
            this.label22.Text = "Size";
            // 
            // label23
            // 
            this.label23.BackColor = Color.Transparent;
            this.label23.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label23.Location = new Point(594, 5);
            this.label23.Margin = new Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new Size(88, 25);
            this.label23.TabIndex = 10067;
            this.label23.Text = "Enabled";
            // 
            // panel104
            // 
            this.panel104.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel104.Controls.Add(this.recentAchievementsTitleFontOutlineNumericUpDown);
            this.panel104.Controls.Add(this.recentAchievementsTitleFontOutlineCheckBox);
            this.panel104.Controls.Add(this.recentAchievementsTitleOutlineLabel);
            this.panel104.Controls.Add(this.recentAchievementsTitleFontOutlineColorPictureBox);
            this.panel104.Location = new Point(3, 298);
            this.panel104.Margin = new Padding(4, 5, 4, 5);
            this.panel104.Name = "panel104";
            this.panel104.Size = new Size(694, 35);
            this.panel104.TabIndex = 10071;
            // 
            // recentAchievementsTitleFontOutlineNumericUpDown
            // 
            this.recentAchievementsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.recentAchievementsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.recentAchievementsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            this.recentAchievementsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.recentAchievementsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.recentAchievementsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsTitleFontOutlineNumericUpDown.Name = "recentAchievementsTitleFontOutlineNumericUpDown";
            this.recentAchievementsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.recentAchievementsTitleFontOutlineNumericUpDown.TabIndex = 45;
            this.recentAchievementsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsTitleFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsTitleFontOutlineCheckBox
            // 
            this.recentAchievementsTitleFontOutlineCheckBox.AutoSize = true;
            this.recentAchievementsTitleFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsTitleFontOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsTitleFontOutlineCheckBox.Location = new Point(620, 8);
            this.recentAchievementsTitleFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsTitleFontOutlineCheckBox.Name = "recentAchievementsTitleFontOutlineCheckBox";
            this.recentAchievementsTitleFontOutlineCheckBox.Size = new Size(22, 21);
            this.recentAchievementsTitleFontOutlineCheckBox.TabIndex = 45;
            this.recentAchievementsTitleFontOutlineCheckBox.UseVisualStyleBackColor = true;
            this.recentAchievementsTitleFontOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsTitleOutlineLabel
            // 
            this.recentAchievementsTitleOutlineLabel.BackColor = Color.Transparent;
            this.recentAchievementsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsTitleOutlineLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsTitleOutlineLabel.Location = new Point(4, 5);
            this.recentAchievementsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            this.recentAchievementsTitleOutlineLabel.Name = "recentAchievementsTitleOutlineLabel";
            this.recentAchievementsTitleOutlineLabel.Size = new Size(216, 25);
            this.recentAchievementsTitleOutlineLabel.TabIndex = 10066;
            this.recentAchievementsTitleOutlineLabel.Text = "Title OutlineColor";
            // 
            // recentAchievementsTitleFontOutlineColorPictureBox
            // 
            this.recentAchievementsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            this.recentAchievementsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsTitleFontOutlineColorPictureBox.Name = "recentAchievementsTitleFontOutlineColorPictureBox";
            this.recentAchievementsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsTitleFontOutlineColorPictureBox.TabIndex = 45;
            this.recentAchievementsTitleFontOutlineColorPictureBox.TabStop = false;
            this.recentAchievementsTitleFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsOpenWindowButton
            // 
            this.recentAchievementsOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.recentAchievementsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.recentAchievementsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.recentAchievementsOpenWindowButton.Location = new Point(573, 3);
            this.recentAchievementsOpenWindowButton.Margin = new Padding(0);
            this.recentAchievementsOpenWindowButton.Name = "recentAchievementsOpenWindowButton";
            this.recentAchievementsOpenWindowButton.Size = new Size(112, 42);
            this.recentAchievementsOpenWindowButton.TabIndex = 10021;
            this.recentAchievementsOpenWindowButton.Text = "Open";
            this.recentAchievementsOpenWindowButton.UseVisualStyleBackColor = false;
            this.recentAchievementsOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // recentAchievementsDescriptionOutlinePanel
            // 
            this.recentAchievementsDescriptionOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.recentAchievementsDescriptionOutlinePanel.Controls.Add(this.label144);
            this.recentAchievementsDescriptionOutlinePanel.Controls.Add(this.recentAchievementsDateFontOutlineColorPictureBox);
            this.recentAchievementsDescriptionOutlinePanel.Controls.Add(this.recentAchievementsDescriptionFontOutlineNumericUpDown);
            this.recentAchievementsDescriptionOutlinePanel.Controls.Add(this.recentAchievementsDateFontOutlineCheckBox);
            this.recentAchievementsDescriptionOutlinePanel.Location = new Point(3, 332);
            this.recentAchievementsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDescriptionOutlinePanel.Name = "recentAchievementsDescriptionOutlinePanel";
            this.recentAchievementsDescriptionOutlinePanel.Size = new Size(694, 35);
            this.recentAchievementsDescriptionOutlinePanel.TabIndex = 10072;
            // 
            // label144
            // 
            this.label144.BackColor = Color.Transparent;
            this.label144.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label144.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label144.Location = new Point(4, 6);
            this.label144.Margin = new Padding(4, 0, 4, 0);
            this.label144.Name = "label144";
            this.label144.Size = new Size(216, 25);
            this.label144.TabIndex = 10066;
            this.label144.Text = "Date OutlineColor";
            // 
            // recentAchievementsDateFontOutlineColorPictureBox
            // 
            this.recentAchievementsDateFontOutlineColorPictureBox.BackColor = Color.White;
            this.recentAchievementsDateFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsDateFontOutlineColorPictureBox.Location = new Point(230, 6);
            this.recentAchievementsDateFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDateFontOutlineColorPictureBox.Name = "recentAchievementsDateFontOutlineColorPictureBox";
            this.recentAchievementsDateFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsDateFontOutlineColorPictureBox.TabIndex = 45;
            this.recentAchievementsDateFontOutlineColorPictureBox.TabStop = false;
            this.recentAchievementsDateFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsDescriptionFontOutlineNumericUpDown
            // 
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Name = "recentAchievementsDescriptionFontOutlineNumericUpDown";
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsDescriptionFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsDateFontOutlineCheckBox
            // 
            this.recentAchievementsDateFontOutlineCheckBox.AutoSize = true;
            this.recentAchievementsDateFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsDateFontOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsDateFontOutlineCheckBox.Location = new Point(620, 9);
            this.recentAchievementsDateFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDateFontOutlineCheckBox.Name = "recentAchievementsDateFontOutlineCheckBox";
            this.recentAchievementsDateFontOutlineCheckBox.Size = new Size(22, 21);
            this.recentAchievementsDateFontOutlineCheckBox.TabIndex = 45;
            this.recentAchievementsDateFontOutlineCheckBox.UseVisualStyleBackColor = true;
            this.recentAchievementsDateFontOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // recentAchievementsDescriptionPanel
            // 
            this.recentAchievementsDescriptionPanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.recentAchievementsDescriptionPanel.Controls.Add(this.label145);
            this.recentAchievementsDescriptionPanel.Controls.Add(this.recentAchievementsDateFontColorPictureBox);
            this.recentAchievementsDescriptionPanel.Controls.Add(this.recentAchievementsDescriptionFontComboBox);
            this.recentAchievementsDescriptionPanel.Location = new Point(3, 197);
            this.recentAchievementsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDescriptionPanel.Name = "recentAchievementsDescriptionPanel";
            this.recentAchievementsDescriptionPanel.Size = new Size(694, 35);
            this.recentAchievementsDescriptionPanel.TabIndex = 10061;
            // 
            // label145
            // 
            this.label145.BackColor = Color.Transparent;
            this.label145.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label145.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label145.Location = new Point(4, 6);
            this.label145.Margin = new Padding(4, 0, 4, 0);
            this.label145.Name = "label145";
            this.label145.Size = new Size(216, 25);
            this.label145.TabIndex = 10066;
            this.label145.Text = "Date";
            // 
            // recentAchievementsDateFontColorPictureBox
            // 
            this.recentAchievementsDateFontColorPictureBox.BackColor = Color.White;
            this.recentAchievementsDateFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsDateFontColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsDateFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDateFontColorPictureBox.Name = "recentAchievementsDateFontColorPictureBox";
            this.recentAchievementsDateFontColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsDateFontColorPictureBox.TabIndex = 45;
            this.recentAchievementsDateFontColorPictureBox.TabStop = false;
            this.recentAchievementsDateFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsDescriptionFontComboBox
            // 
            this.recentAchievementsDescriptionFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsDescriptionFontComboBox.ForeColor = Color.White;
            this.recentAchievementsDescriptionFontComboBox.FormattingEnabled = true;
            this.recentAchievementsDescriptionFontComboBox.Location = new Point(290, 3);
            this.recentAchievementsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsDescriptionFontComboBox.Name = "recentAchievementsDescriptionFontComboBox";
            this.recentAchievementsDescriptionFontComboBox.Size = new Size(301, 28);
            this.recentAchievementsDescriptionFontComboBox.TabIndex = 45;
            this.recentAchievementsDescriptionFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // recentAchievementsAutoOpenWindowCheckbox
            // 
            this.recentAchievementsAutoOpenWindowCheckbox.AutoSize = true;
            this.recentAchievementsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.recentAchievementsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.recentAchievementsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsAutoOpenWindowCheckbox.Name = "recentAchievementsAutoOpenWindowCheckbox";
            this.recentAchievementsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.recentAchievementsAutoOpenWindowCheckbox.TabIndex = 10022;
            this.recentAchievementsAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.recentAchievementsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.recentAchievementsAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox23.Location = new Point(3, 49);
            this.pictureBox23.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new Size(690, 3);
            this.pictureBox23.TabIndex = 10063;
            this.pictureBox23.TabStop = false;
            // 
            // panel107
            // 
            this.panel107.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel107.Controls.Add(this.recentAchievementsBackgroundColorPictureBox);
            this.panel107.Controls.Add(this.label146);
            this.panel107.Location = new Point(3, 95);
            this.panel107.Margin = new Padding(4, 5, 4, 5);
            this.panel107.Name = "panel107";
            this.panel107.Size = new Size(694, 35);
            this.panel107.TabIndex = 10061;
            // 
            // recentAchievementsBackgroundColorPictureBox
            // 
            this.recentAchievementsBackgroundColorPictureBox.BackColor = Color.White;
            this.recentAchievementsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsBackgroundColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsBackgroundColorPictureBox.Name = "recentAchievementsBackgroundColorPictureBox";
            this.recentAchievementsBackgroundColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsBackgroundColorPictureBox.TabIndex = 42;
            this.recentAchievementsBackgroundColorPictureBox.TabStop = false;
            this.recentAchievementsBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label146
            // 
            this.label146.BackColor = Color.Transparent;
            this.label146.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label146.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label146.Location = new Point(4, 5);
            this.label146.Margin = new Padding(4, 0, 4, 0);
            this.label146.Name = "label146";
            this.label146.Size = new Size(216, 25);
            this.label146.TabIndex = 10064;
            this.label146.Text = "Window Background";
            // 
            // panel108
            // 
            this.panel108.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel108.Controls.Add(this.recentAchievementsTitleLabel);
            this.panel108.Controls.Add(this.recentAchievementsTitleFontColorPictureBox);
            this.panel108.Controls.Add(this.recentAchievementsTitleFontComboBox);
            this.panel108.Location = new Point(3, 163);
            this.panel108.Margin = new Padding(4, 5, 4, 5);
            this.panel108.Name = "panel108";
            this.panel108.Size = new Size(694, 35);
            this.panel108.TabIndex = 10061;
            // 
            // recentAchievementsTitleLabel
            // 
            this.recentAchievementsTitleLabel.BackColor = Color.Transparent;
            this.recentAchievementsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsTitleLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsTitleLabel.Location = new Point(4, 6);
            this.recentAchievementsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            this.recentAchievementsTitleLabel.Name = "recentAchievementsTitleLabel";
            this.recentAchievementsTitleLabel.Size = new Size(216, 25);
            this.recentAchievementsTitleLabel.TabIndex = 10065;
            this.recentAchievementsTitleLabel.Text = "Title";
            // 
            // recentAchievementsTitleFontColorPictureBox
            // 
            this.recentAchievementsTitleFontColorPictureBox.BackColor = Color.White;
            this.recentAchievementsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsTitleFontColorPictureBox.Location = new Point(230, 6);
            this.recentAchievementsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsTitleFontColorPictureBox.Name = "recentAchievementsTitleFontColorPictureBox";
            this.recentAchievementsTitleFontColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsTitleFontColorPictureBox.TabIndex = 45;
            this.recentAchievementsTitleFontColorPictureBox.TabStop = false;
            this.recentAchievementsTitleFontColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsTitleFontComboBox
            // 
            this.recentAchievementsTitleFontComboBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsTitleFontComboBox.ForeColor = Color.White;
            this.recentAchievementsTitleFontComboBox.FormattingEnabled = true;
            this.recentAchievementsTitleFontComboBox.Location = new Point(290, 3);
            this.recentAchievementsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsTitleFontComboBox.Name = "recentAchievementsTitleFontComboBox";
            this.recentAchievementsTitleFontComboBox.Size = new Size(301, 28);
            this.recentAchievementsTitleFontComboBox.TabIndex = 45;
            this.recentAchievementsTitleFontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedIndexChanged);
            // 
            // recentAchievementsPointsOutlinePanel
            // 
            this.recentAchievementsPointsOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentAchievementsPointsOutlinePanel.Controls.Add(this.recentAchievementsPointsFontOutlineNumericUpDown);
            this.recentAchievementsPointsOutlinePanel.Controls.Add(this.recentAchievementsPointsFontOutlineCheckBox);
            this.recentAchievementsPointsOutlinePanel.Controls.Add(this.label148);
            this.recentAchievementsPointsOutlinePanel.Controls.Add(this.recentAchievementsPointsFontOutlineColorPictureBox);
            this.recentAchievementsPointsOutlinePanel.Location = new Point(3, 366);
            this.recentAchievementsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsOutlinePanel.Name = "recentAchievementsPointsOutlinePanel";
            this.recentAchievementsPointsOutlinePanel.Size = new Size(694, 35);
            this.recentAchievementsPointsOutlinePanel.TabIndex = 10061;
            // 
            // recentAchievementsPointsFontOutlineNumericUpDown
            // 
            this.recentAchievementsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.recentAchievementsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.recentAchievementsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            this.recentAchievementsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            this.recentAchievementsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.recentAchievementsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsPointsFontOutlineNumericUpDown.Name = "recentAchievementsPointsFontOutlineNumericUpDown";
            this.recentAchievementsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            this.recentAchievementsPointsFontOutlineNumericUpDown.TabIndex = 45;
            this.recentAchievementsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsPointsFontOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsPointsFontOutlineCheckBox
            // 
            this.recentAchievementsPointsFontOutlineCheckBox.AutoSize = true;
            this.recentAchievementsPointsFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsPointsFontOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsPointsFontOutlineCheckBox.Location = new Point(620, 8);
            this.recentAchievementsPointsFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsFontOutlineCheckBox.Name = "recentAchievementsPointsFontOutlineCheckBox";
            this.recentAchievementsPointsFontOutlineCheckBox.Size = new Size(22, 21);
            this.recentAchievementsPointsFontOutlineCheckBox.TabIndex = 45;
            this.recentAchievementsPointsFontOutlineCheckBox.UseVisualStyleBackColor = true;
            this.recentAchievementsPointsFontOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // label148
            // 
            this.label148.BackColor = Color.Transparent;
            this.label148.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label148.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label148.Location = new Point(4, 5);
            this.label148.Margin = new Padding(4, 0, 4, 0);
            this.label148.Name = "label148";
            this.label148.Size = new Size(216, 25);
            this.label148.TabIndex = 10066;
            this.label148.Text = "Points OutlineColor";
            // 
            // recentAchievementsPointsFontOutlineColorPictureBox
            // 
            this.recentAchievementsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            this.recentAchievementsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            this.recentAchievementsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsPointsFontOutlineColorPictureBox.Name = "recentAchievementsPointsFontOutlineColorPictureBox";
            this.recentAchievementsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsPointsFontOutlineColorPictureBox.TabIndex = 45;
            this.recentAchievementsPointsFontOutlineColorPictureBox.TabStop = false;
            this.recentAchievementsPointsFontOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsLineOutlinePanel
            // 
            this.recentAchievementsLineOutlinePanel.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.recentAchievementsLineOutlinePanel.Controls.Add(this.label149);
            this.recentAchievementsLineOutlinePanel.Controls.Add(this.recentAchievementsLineOutlineColorPictureBox);
            this.recentAchievementsLineOutlinePanel.Controls.Add(this.recentAchievementsLineOutlineNumericUpDown);
            this.recentAchievementsLineOutlinePanel.Controls.Add(this.recentAchievementsLineOutlineCheckBox);
            this.recentAchievementsLineOutlinePanel.Location = new Point(3, 400);
            this.recentAchievementsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLineOutlinePanel.Name = "recentAchievementsLineOutlinePanel";
            this.recentAchievementsLineOutlinePanel.Size = new Size(694, 35);
            this.recentAchievementsLineOutlinePanel.TabIndex = 10067;
            // 
            // label149
            // 
            this.label149.BackColor = Color.Transparent;
            this.label149.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label149.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label149.Location = new Point(4, 6);
            this.label149.Margin = new Padding(4, 0, 4, 0);
            this.label149.Name = "label149";
            this.label149.Size = new Size(216, 25);
            this.label149.TabIndex = 10066;
            this.label149.Text = "Line OutlineColor";
            // 
            // recentAchievementsLineOutlineColorPictureBox
            // 
            this.recentAchievementsLineOutlineColorPictureBox.BackColor = Color.White;
            this.recentAchievementsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.recentAchievementsLineOutlineColorPictureBox.Location = new Point(230, 6);
            this.recentAchievementsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLineOutlineColorPictureBox.Name = "recentAchievementsLineOutlineColorPictureBox";
            this.recentAchievementsLineOutlineColorPictureBox.Size = new Size(22, 22);
            this.recentAchievementsLineOutlineColorPictureBox.TabIndex = 45;
            this.recentAchievementsLineOutlineColorPictureBox.TabStop = false;
            this.recentAchievementsLineOutlineColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // recentAchievementsLineOutlineNumericUpDown
            // 
            this.recentAchievementsLineOutlineNumericUpDown.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.recentAchievementsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            this.recentAchievementsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsLineOutlineNumericUpDown.ForeColor = Color.White;
            this.recentAchievementsLineOutlineNumericUpDown.Location = new Point(528, 6);
            this.recentAchievementsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLineOutlineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.recentAchievementsLineOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsLineOutlineNumericUpDown.Name = "recentAchievementsLineOutlineNumericUpDown";
            this.recentAchievementsLineOutlineNumericUpDown.Size = new Size(64, 24);
            this.recentAchievementsLineOutlineNumericUpDown.TabIndex = 45;
            this.recentAchievementsLineOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recentAchievementsLineOutlineNumericUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // recentAchievementsLineOutlineCheckBox
            // 
            this.recentAchievementsLineOutlineCheckBox.AutoSize = true;
            this.recentAchievementsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.recentAchievementsLineOutlineCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.recentAchievementsLineOutlineCheckBox.Location = new Point(620, 9);
            this.recentAchievementsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.recentAchievementsLineOutlineCheckBox.Name = "recentAchievementsLineOutlineCheckBox";
            this.recentAchievementsLineOutlineCheckBox.Size = new Size(22, 21);
            this.recentAchievementsLineOutlineCheckBox.TabIndex = 45;
            this.recentAchievementsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            this.recentAchievementsLineOutlineCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel115
            // 
            this.panel115.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel115.Controls.Add(this.label152);
            this.panel115.Controls.Add(this.pictureBox18);
            this.panel115.Controls.Add(this.achievementListAutoScrollCheckBox);
            this.panel115.Location = new Point(6, 5);
            this.panel115.Margin = new Padding(4, 5, 4, 5);
            this.panel115.Name = "panel115";
            this.panel115.Size = new Size(434, 97);
            this.panel115.TabIndex = 10084;
            // 
            // label152
            // 
            this.label152.BackColor = Color.Transparent;
            this.label152.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label152.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label152.Location = new Point(4, 5);
            this.label152.Margin = new Padding(4, 0, 4, 0);
            this.label152.Name = "label152";
            this.label152.Size = new Size(285, 40);
            this.label152.TabIndex = 10069;
            this.label152.Text = "List Settings";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox18.Location = new Point(3, 49);
            this.pictureBox18.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new Size(412, 3);
            this.pictureBox18.TabIndex = 10070;
            this.pictureBox18.TabStop = false;
            // 
            // achievementListAutoScrollCheckBox
            // 
            this.achievementListAutoScrollCheckBox.AutoSize = true;
            this.achievementListAutoScrollCheckBox.BackColor = Color.Transparent;
            this.achievementListAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            this.achievementListAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.achievementListAutoScrollCheckBox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.achievementListAutoScrollCheckBox.Location = new Point(4, 60);
            this.achievementListAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            this.achievementListAutoScrollCheckBox.Name = "achievementListAutoScrollCheckBox";
            this.achievementListAutoScrollCheckBox.Size = new Size(147, 29);
            this.achievementListAutoScrollCheckBox.TabIndex = 10055;
            this.achievementListAutoScrollCheckBox.Text = "Auto-scroll";
            this.achievementListAutoScrollCheckBox.UseVisualStyleBackColor = false;
            this.achievementListAutoScrollCheckBox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // panel111
            // 
            this.panel111.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel111.Controls.Add(this.panel9);
            this.panel111.Controls.Add(this.label150);
            this.panel111.Controls.Add(this.panel112);
            this.panel111.Controls.Add(this.achievementListOpenWindowButton);
            this.panel111.Controls.Add(this.achievementListAutoOpenWindowCheckbox);
            this.panel111.Controls.Add(this.pictureBox16);
            this.panel111.Controls.Add(this.panel114);
            this.panel111.Location = new Point(444, 5);
            this.panel111.Margin = new Padding(4, 5, 4, 5);
            this.panel111.Name = "panel111";
            this.panel111.Size = new Size(702, 176);
            this.panel111.TabIndex = 10082;
            // 
            // panel9
            // 
            this.panel9.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel9.Controls.Add(this.achievementListWindowSizeLabel);
            this.panel9.Controls.Add(this.achievementListWindowSizeXUpDown);
            this.panel9.Controls.Add(this.achievementListWindowSizeYUpDown);
            this.panel9.Location = new Point(4, 133);
            this.panel9.Margin = new Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new Size(693, 36);
            this.panel9.TabIndex = 10065;
            // 
            // achievementListWindowSizeLabel
            // 
            this.achievementListWindowSizeLabel.AutoSize = true;
            this.achievementListWindowSizeLabel.Font = new Font("Verdana", 9.75F);
            this.achievementListWindowSizeLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.achievementListWindowSizeLabel.Location = new Point(3, 4);
            this.achievementListWindowSizeLabel.Name = "achievementListWindowSizeLabel";
            this.achievementListWindowSizeLabel.Size = new Size(141, 25);
            this.achievementListWindowSizeLabel.TabIndex = 10088;
            this.achievementListWindowSizeLabel.Text = "Window Size";
            // 
            // achievementListWindowSizeXUpDown
            // 
            this.achievementListWindowSizeXUpDown.Increment = new decimal(new int[] {
            68,
            0,
            0,
            0});
            this.achievementListWindowSizeXUpDown.Location = new Point(230, 4);
            this.achievementListWindowSizeXUpDown.Maximum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.achievementListWindowSizeXUpDown.Minimum = new decimal(new int[] {
            340,
            0,
            0,
            0});
            this.achievementListWindowSizeXUpDown.Name = "achievementListWindowSizeXUpDown";
            this.achievementListWindowSizeXUpDown.Size = new Size(120, 28);
            this.achievementListWindowSizeXUpDown.TabIndex = 3;
            this.achievementListWindowSizeXUpDown.Value = new decimal(new int[] {
            748,
            0,
            0,
            0});
            this.achievementListWindowSizeXUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // achievementListWindowSizeYUpDown
            // 
            this.achievementListWindowSizeYUpDown.Increment = new decimal(new int[] {
            68,
            0,
            0,
            0});
            this.achievementListWindowSizeYUpDown.Location = new Point(352, 4);
            this.achievementListWindowSizeYUpDown.Maximum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.achievementListWindowSizeYUpDown.Minimum = new decimal(new int[] {
            340,
            0,
            0,
            0});
            this.achievementListWindowSizeYUpDown.Name = "achievementListWindowSizeYUpDown";
            this.achievementListWindowSizeYUpDown.Size = new Size(120, 28);
            this.achievementListWindowSizeYUpDown.TabIndex = 1;
            this.achievementListWindowSizeYUpDown.Value = new decimal(new int[] {
            612,
            0,
            0,
            0});
            this.achievementListWindowSizeYUpDown.ValueChanged += new System.EventHandler(this.CustomNumericUpDown_ValueChanged);
            // 
            // label150
            // 
            this.label150.BackColor = Color.Transparent;
            this.label150.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label150.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label150.Location = new Point(4, 5);
            this.label150.Margin = new Padding(4, 0, 4, 0);
            this.label150.Name = "label150";
            this.label150.Size = new Size(364, 40);
            this.label150.TabIndex = 10062;
            this.label150.Text = "Window/Font Settings";
            // 
            // panel112
            // 
            this.panel112.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel112.Controls.Add(this.label151);
            this.panel112.Location = new Point(3, 62);
            this.panel112.Margin = new Padding(4, 5, 4, 5);
            this.panel112.Name = "panel112";
            this.panel112.Size = new Size(694, 35);
            this.panel112.TabIndex = 10076;
            // 
            // label151
            // 
            this.label151.BackColor = Color.Transparent;
            this.label151.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label151.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label151.Location = new Point(225, 5);
            this.label151.Margin = new Padding(4, 0, 4, 0);
            this.label151.Name = "label151";
            this.label151.Size = new Size(72, 25);
            this.label151.TabIndex = 10065;
            this.label151.Text = "Color";
            // 
            // achievementListOpenWindowButton
            // 
            this.achievementListOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.achievementListOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.achievementListOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.achievementListOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.achievementListOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.achievementListOpenWindowButton.Location = new Point(573, 3);
            this.achievementListOpenWindowButton.Margin = new Padding(0);
            this.achievementListOpenWindowButton.Name = "achievementListOpenWindowButton";
            this.achievementListOpenWindowButton.Size = new Size(112, 42);
            this.achievementListOpenWindowButton.TabIndex = 10021;
            this.achievementListOpenWindowButton.Text = "Open";
            this.achievementListOpenWindowButton.UseVisualStyleBackColor = false;
            this.achievementListOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // achievementListAutoOpenWindowCheckbox
            // 
            this.achievementListAutoOpenWindowCheckbox.AutoSize = true;
            this.achievementListAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.achievementListAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.achievementListAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.achievementListAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.achievementListAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.achievementListAutoOpenWindowCheckbox.Name = "achievementListAutoOpenWindowCheckbox";
            this.achievementListAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.achievementListAutoOpenWindowCheckbox.TabIndex = 10022;
            this.achievementListAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.achievementListAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.achievementListAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox16.Location = new Point(3, 49);
            this.pictureBox16.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new Size(690, 3);
            this.pictureBox16.TabIndex = 10063;
            this.pictureBox16.TabStop = false;
            // 
            // panel114
            // 
            this.panel114.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel114.Controls.Add(this.achievementListBackgroundColorPictureBox);
            this.panel114.Controls.Add(this.label156);
            this.panel114.Location = new Point(3, 95);
            this.panel114.Margin = new Padding(4, 5, 4, 5);
            this.panel114.Name = "panel114";
            this.panel114.Size = new Size(694, 35);
            this.panel114.TabIndex = 10061;
            // 
            // achievementListBackgroundColorPictureBox
            // 
            this.achievementListBackgroundColorPictureBox.BackColor = Color.White;
            this.achievementListBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.achievementListBackgroundColorPictureBox.Location = new Point(230, 5);
            this.achievementListBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.achievementListBackgroundColorPictureBox.Name = "achievementListBackgroundColorPictureBox";
            this.achievementListBackgroundColorPictureBox.Size = new Size(22, 22);
            this.achievementListBackgroundColorPictureBox.TabIndex = 42;
            this.achievementListBackgroundColorPictureBox.TabStop = false;
            this.achievementListBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label156
            // 
            this.label156.BackColor = Color.Transparent;
            this.label156.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label156.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label156.Location = new Point(4, 5);
            this.label156.Margin = new Padding(4, 0, 4, 0);
            this.label156.Name = "label156";
            this.label156.Size = new Size(216, 25);
            this.label156.TabIndex = 10064;
            this.label156.Text = "Window Background";
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkForUpdatesButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.autoStartCheckbox);
            this.panel1.Location = new Point(564, 9);
            this.panel1.Margin = new Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(606, 147);
            this.panel1.TabIndex = 10031;
            // 
            // checkForUpdatesButton
            // 
            this.checkForUpdatesButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.checkForUpdatesButton.FlatAppearance.BorderColor = Color.Black;
            this.checkForUpdatesButton.FlatStyle = FlatStyle.Flat;
            this.checkForUpdatesButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkForUpdatesButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.checkForUpdatesButton.Location = new Point(4, 95);
            this.checkForUpdatesButton.Margin = new Padding(0);
            this.checkForUpdatesButton.Name = "checkForUpdatesButton";
            this.checkForUpdatesButton.Size = new Size(225, 42);
            this.checkForUpdatesButton.TabIndex = 29;
            this.checkForUpdatesButton.Text = "Check For Updates";
            this.checkForUpdatesButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.panel3.BackColor = Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.apiKeyLabel);
            this.panel3.Controls.Add(this.apiKeyTextBox);
            this.panel3.Location = new Point(4, 46);
            this.panel3.Margin = new Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(596, 43);
            this.panel3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.panel2.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Location = new Point(4, 5);
            this.panel2.Margin = new Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(596, 43);
            this.panel2.TabIndex = 27;
            // 
            // panel120
            // 
            this.panel120.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel120.Controls.Add(this.relatedMediaRAScreenshotRadioButton);
            this.panel120.Controls.Add(this.relatedMediaRABadgeIconRadioButton);
            this.panel120.Controls.Add(this.relatedMediaRABoxArtRadioButton);
            this.panel120.Controls.Add(this.relatedMediaRATitleScreenRadioButton);
            this.panel120.Controls.Add(this.pictureBox19);
            this.panel120.Controls.Add(this.label1);
            this.panel120.Location = new Point(6, 5);
            this.panel120.Margin = new Padding(4, 5, 4, 5);
            this.panel120.Name = "panel120";
            this.panel120.Size = new Size(434, 226);
            this.panel120.TabIndex = 0;
            // 
            // relatedMediaRAScreenshotRadioButton
            // 
            this.relatedMediaRAScreenshotRadioButton.AutoSize = true;
            this.relatedMediaRAScreenshotRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaRAScreenshotRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaRAScreenshotRadioButton.Location = new Point(12, 182);
            this.relatedMediaRAScreenshotRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaRAScreenshotRadioButton.Name = "relatedMediaRAScreenshotRadioButton";
            this.relatedMediaRAScreenshotRadioButton.Size = new Size(150, 29);
            this.relatedMediaRAScreenshotRadioButton.TabIndex = 10075;
            this.relatedMediaRAScreenshotRadioButton.Text = "Screenshot";
            this.relatedMediaRAScreenshotRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaRAScreenshotRadioButton.CheckedChanged += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRABadgeIconRadioButton
            // 
            this.relatedMediaRABadgeIconRadioButton.AutoSize = true;
            this.relatedMediaRABadgeIconRadioButton.Checked = true;
            this.relatedMediaRABadgeIconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaRABadgeIconRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaRABadgeIconRadioButton.Location = new Point(12, 62);
            this.relatedMediaRABadgeIconRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaRABadgeIconRadioButton.Name = "relatedMediaRABadgeIconRadioButton";
            this.relatedMediaRABadgeIconRadioButton.Size = new Size(149, 29);
            this.relatedMediaRABadgeIconRadioButton.TabIndex = 10072;
            this.relatedMediaRABadgeIconRadioButton.TabStop = true;
            this.relatedMediaRABadgeIconRadioButton.Text = "Badge Icon";
            this.relatedMediaRABadgeIconRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaRABadgeIconRadioButton.CheckedChanged += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRABoxArtRadioButton
            // 
            this.relatedMediaRABoxArtRadioButton.AutoSize = true;
            this.relatedMediaRABoxArtRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaRABoxArtRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaRABoxArtRadioButton.Location = new Point(12, 102);
            this.relatedMediaRABoxArtRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaRABoxArtRadioButton.Name = "relatedMediaRABoxArtRadioButton";
            this.relatedMediaRABoxArtRadioButton.Size = new Size(113, 29);
            this.relatedMediaRABoxArtRadioButton.TabIndex = 10074;
            this.relatedMediaRABoxArtRadioButton.Text = "Box Art";
            this.relatedMediaRABoxArtRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaRABoxArtRadioButton.CheckedChanged += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaRATitleScreenRadioButton
            // 
            this.relatedMediaRATitleScreenRadioButton.AutoSize = true;
            this.relatedMediaRATitleScreenRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaRATitleScreenRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaRATitleScreenRadioButton.Location = new Point(12, 142);
            this.relatedMediaRATitleScreenRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaRATitleScreenRadioButton.Name = "relatedMediaRATitleScreenRadioButton";
            this.relatedMediaRATitleScreenRadioButton.Size = new Size(158, 29);
            this.relatedMediaRATitleScreenRadioButton.TabIndex = 10073;
            this.relatedMediaRATitleScreenRadioButton.Text = "Title Screen";
            this.relatedMediaRATitleScreenRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaRATitleScreenRadioButton.CheckedChanged += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox19.Location = new Point(3, 49);
            this.pictureBox19.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new Size(412, 3);
            this.pictureBox19.TabIndex = 10071;
            this.pictureBox19.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label1.Location = new Point(4, 5);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(411, 40);
            this.label1.TabIndex = 10063;
            this.label1.Text = "RetroAchievements.org";
            // 
            // panel121
            // 
            this.panel121.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel121.Controls.Add(this.label90);
            this.panel121.Controls.Add(this.panel122);
            this.panel121.Controls.Add(this.relatedMediaOpenWindowButton);
            this.panel121.Controls.Add(this.relatedMediaAutoOpenWindowCheckbox);
            this.panel121.Controls.Add(this.pictureBox22);
            this.panel121.Controls.Add(this.panel123);
            this.panel121.Location = new Point(444, 5);
            this.panel121.Margin = new Padding(4, 5, 4, 5);
            this.panel121.Name = "panel121";
            this.panel121.Size = new Size(702, 134);
            this.panel121.TabIndex = 10083;
            // 
            // label90
            // 
            this.label90.BackColor = Color.Transparent;
            this.label90.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label90.Location = new Point(4, 5);
            this.label90.Margin = new Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new Size(364, 40);
            this.label90.TabIndex = 10062;
            this.label90.Text = "Window/Font Settings";
            // 
            // panel122
            // 
            this.panel122.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel122.Controls.Add(this.label91);
            this.panel122.Location = new Point(3, 62);
            this.panel122.Margin = new Padding(4, 5, 4, 5);
            this.panel122.Name = "panel122";
            this.panel122.Size = new Size(694, 35);
            this.panel122.TabIndex = 10076;
            // 
            // label91
            // 
            this.label91.BackColor = Color.Transparent;
            this.label91.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label91.Location = new Point(225, 5);
            this.label91.Margin = new Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new Size(72, 25);
            this.label91.TabIndex = 10065;
            this.label91.Text = "Color";
            // 
            // relatedMediaOpenWindowButton
            // 
            this.relatedMediaOpenWindowButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.relatedMediaOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            this.relatedMediaOpenWindowButton.FlatStyle = FlatStyle.Flat;
            this.relatedMediaOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaOpenWindowButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.relatedMediaOpenWindowButton.Location = new Point(573, 3);
            this.relatedMediaOpenWindowButton.Margin = new Padding(0);
            this.relatedMediaOpenWindowButton.Name = "relatedMediaOpenWindowButton";
            this.relatedMediaOpenWindowButton.Size = new Size(112, 42);
            this.relatedMediaOpenWindowButton.TabIndex = 10021;
            this.relatedMediaOpenWindowButton.Text = "Open";
            this.relatedMediaOpenWindowButton.UseVisualStyleBackColor = false;
            this.relatedMediaOpenWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // relatedMediaAutoOpenWindowCheckbox
            // 
            this.relatedMediaAutoOpenWindowCheckbox.AutoSize = true;
            this.relatedMediaAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            this.relatedMediaAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaAutoOpenWindowCheckbox.Location = new Point(378, 14);
            this.relatedMediaAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaAutoOpenWindowCheckbox.Name = "relatedMediaAutoOpenWindowCheckbox";
            this.relatedMediaAutoOpenWindowCheckbox.Size = new Size(147, 29);
            this.relatedMediaAutoOpenWindowCheckbox.TabIndex = 10022;
            this.relatedMediaAutoOpenWindowCheckbox.Text = "Auto-Open";
            this.relatedMediaAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            this.relatedMediaAutoOpenWindowCheckbox.CheckedChanged += new System.EventHandler(this.FeatureEnablementCheckBox_CheckedChanged);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pictureBox22.Location = new Point(3, 49);
            this.pictureBox22.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new Size(690, 3);
            this.pictureBox22.TabIndex = 10063;
            this.pictureBox22.TabStop = false;
            // 
            // panel123
            // 
            this.panel123.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel123.Controls.Add(this.relatedMediaBackgroundColorPictureBox);
            this.panel123.Controls.Add(this.label92);
            this.panel123.Location = new Point(3, 95);
            this.panel123.Margin = new Padding(4, 5, 4, 5);
            this.panel123.Name = "panel123";
            this.panel123.Size = new Size(694, 35);
            this.panel123.TabIndex = 10061;
            // 
            // relatedMediaBackgroundColorPictureBox
            // 
            this.relatedMediaBackgroundColorPictureBox.BackColor = Color.White;
            this.relatedMediaBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.relatedMediaBackgroundColorPictureBox.Location = new Point(230, 5);
            this.relatedMediaBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaBackgroundColorPictureBox.Name = "relatedMediaBackgroundColorPictureBox";
            this.relatedMediaBackgroundColorPictureBox.Size = new Size(22, 22);
            this.relatedMediaBackgroundColorPictureBox.TabIndex = 42;
            this.relatedMediaBackgroundColorPictureBox.TabStop = false;
            this.relatedMediaBackgroundColorPictureBox.Click += new System.EventHandler(this.FontColorPictureBox_Click);
            // 
            // label92
            // 
            this.label92.BackColor = Color.Transparent;
            this.label92.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label92.Location = new Point(4, 5);
            this.label92.Margin = new Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new Size(216, 25);
            this.label92.TabIndex = 10064;
            this.label92.Text = "Window Background";
            // 
            // panel124
            // 
            this.panel124.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel124.Controls.Add(this.relatedMediaLBCartFrontRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBCartBackRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxBackReconRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxFullRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxSpineRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBClearLogoRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBannerRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBTitleScreenRadioButton);
            this.panel124.Controls.Add(this.relatedMediaSetLaunchBoxPathButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxFrontReconRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxFrontRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBoxBackRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBBox3DRadioButton);
            this.panel124.Controls.Add(this.relatedMediaLBLinePictureBox);
            this.panel124.Controls.Add(this.relatedMediaLBLabel);
            this.panel124.Location = new Point(8, 240);
            this.panel124.Margin = new Padding(4, 5, 4, 5);
            this.panel124.Name = "panel124";
            this.panel124.Size = new Size(434, 322);
            this.panel124.TabIndex = 10076;
            // 
            // relatedMediaLBCartFrontRadioButton
            // 
            this.relatedMediaLBCartFrontRadioButton.AutoSize = true;
            this.relatedMediaLBCartFrontRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBCartFrontRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBCartFrontRadioButton.Location = new Point(260, 222);
            this.relatedMediaLBCartFrontRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBCartFrontRadioButton.Name = "relatedMediaLBCartFrontRadioButton";
            this.relatedMediaLBCartFrontRadioButton.Size = new Size(157, 29);
            this.relatedMediaLBCartFrontRadioButton.TabIndex = 10084;
            this.relatedMediaLBCartFrontRadioButton.Text = "Cart - Front";
            this.relatedMediaLBCartFrontRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBCartFrontRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBCartBackRadioButton
            // 
            this.relatedMediaLBCartBackRadioButton.AutoSize = true;
            this.relatedMediaLBCartBackRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBCartBackRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBCartBackRadioButton.Location = new Point(260, 262);
            this.relatedMediaLBCartBackRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBCartBackRadioButton.Name = "relatedMediaLBCartBackRadioButton";
            this.relatedMediaLBCartBackRadioButton.Size = new Size(151, 29);
            this.relatedMediaLBCartBackRadioButton.TabIndex = 10085;
            this.relatedMediaLBCartBackRadioButton.Text = "Cart - Back";
            this.relatedMediaLBCartBackRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBCartBackRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxBackReconRadioButton
            // 
            this.relatedMediaLBBoxBackReconRadioButton.AutoSize = true;
            this.relatedMediaLBBoxBackReconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxBackReconRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxBackReconRadioButton.Location = new Point(10, 222);
            this.relatedMediaLBBoxBackReconRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxBackReconRadioButton.Name = "relatedMediaLBBoxBackReconRadioButton";
            this.relatedMediaLBBoxBackReconRadioButton.Size = new Size(232, 29);
            this.relatedMediaLBBoxBackReconRadioButton.TabIndex = 10082;
            this.relatedMediaLBBoxBackReconRadioButton.Text = "Box - Back (Recon)";
            this.relatedMediaLBBoxBackReconRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxBackReconRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxFullRadioButton
            // 
            this.relatedMediaLBBoxFullRadioButton.AutoSize = true;
            this.relatedMediaLBBoxFullRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxFullRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxFullRadioButton.Location = new Point(10, 262);
            this.relatedMediaLBBoxFullRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxFullRadioButton.Name = "relatedMediaLBBoxFullRadioButton";
            this.relatedMediaLBBoxFullRadioButton.Size = new Size(135, 29);
            this.relatedMediaLBBoxFullRadioButton.TabIndex = 10083;
            this.relatedMediaLBBoxFullRadioButton.Text = "Box - Full";
            this.relatedMediaLBBoxFullRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxFullRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxSpineRadioButton
            // 
            this.relatedMediaLBBoxSpineRadioButton.AutoSize = true;
            this.relatedMediaLBBoxSpineRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxSpineRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxSpineRadioButton.Location = new Point(260, 62);
            this.relatedMediaLBBoxSpineRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxSpineRadioButton.Name = "relatedMediaLBBoxSpineRadioButton";
            this.relatedMediaLBBoxSpineRadioButton.Size = new Size(155, 29);
            this.relatedMediaLBBoxSpineRadioButton.TabIndex = 10081;
            this.relatedMediaLBBoxSpineRadioButton.Text = "Box - Spine";
            this.relatedMediaLBBoxSpineRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxSpineRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBClearLogoRadioButton
            // 
            this.relatedMediaLBClearLogoRadioButton.AutoSize = true;
            this.relatedMediaLBClearLogoRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBClearLogoRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBClearLogoRadioButton.Location = new Point(260, 182);
            this.relatedMediaLBClearLogoRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBClearLogoRadioButton.Name = "relatedMediaLBClearLogoRadioButton";
            this.relatedMediaLBClearLogoRadioButton.Size = new Size(144, 29);
            this.relatedMediaLBClearLogoRadioButton.TabIndex = 10078;
            this.relatedMediaLBClearLogoRadioButton.Text = "Clear Logo";
            this.relatedMediaLBClearLogoRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBClearLogoRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBannerRadioButton
            // 
            this.relatedMediaLBBannerRadioButton.AutoSize = true;
            this.relatedMediaLBBannerRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBannerRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBannerRadioButton.Location = new Point(260, 102);
            this.relatedMediaLBBannerRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBannerRadioButton.Name = "relatedMediaLBBannerRadioButton";
            this.relatedMediaLBBannerRadioButton.Size = new Size(110, 29);
            this.relatedMediaLBBannerRadioButton.TabIndex = 10080;
            this.relatedMediaLBBannerRadioButton.Text = "Banner";
            this.relatedMediaLBBannerRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBannerRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBTitleScreenRadioButton
            // 
            this.relatedMediaLBTitleScreenRadioButton.AutoSize = true;
            this.relatedMediaLBTitleScreenRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBTitleScreenRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBTitleScreenRadioButton.Location = new Point(260, 142);
            this.relatedMediaLBTitleScreenRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBTitleScreenRadioButton.Name = "relatedMediaLBTitleScreenRadioButton";
            this.relatedMediaLBTitleScreenRadioButton.Size = new Size(158, 29);
            this.relatedMediaLBTitleScreenRadioButton.TabIndex = 10079;
            this.relatedMediaLBTitleScreenRadioButton.Text = "Title Screen";
            this.relatedMediaLBTitleScreenRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBTitleScreenRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaSetLaunchBoxPathButton
            // 
            this.relatedMediaSetLaunchBoxPathButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.relatedMediaSetLaunchBoxPathButton.FlatAppearance.BorderColor = Color.Black;
            this.relatedMediaSetLaunchBoxPathButton.FlatStyle = FlatStyle.Flat;
            this.relatedMediaSetLaunchBoxPathButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaSetLaunchBoxPathButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.relatedMediaSetLaunchBoxPathButton.Location = new Point(303, 5);
            this.relatedMediaSetLaunchBoxPathButton.Margin = new Padding(0);
            this.relatedMediaSetLaunchBoxPathButton.Name = "relatedMediaSetLaunchBoxPathButton";
            this.relatedMediaSetLaunchBoxPathButton.Size = new Size(112, 42);
            this.relatedMediaSetLaunchBoxPathButton.TabIndex = 10077;
            this.relatedMediaSetLaunchBoxPathButton.Text = "Set...";
            this.relatedMediaSetLaunchBoxPathButton.UseVisualStyleBackColor = false;
            this.relatedMediaSetLaunchBoxPathButton.Click += new System.EventHandler(this.SetRelatedMediaPathButton_Click);
            // 
            // relatedMediaLBBoxFrontReconRadioButton
            // 
            this.relatedMediaLBBoxFrontReconRadioButton.AutoSize = true;
            this.relatedMediaLBBoxFrontReconRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxFrontReconRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxFrontReconRadioButton.Location = new Point(10, 182);
            this.relatedMediaLBBoxFrontReconRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxFrontReconRadioButton.Name = "relatedMediaLBBoxFrontReconRadioButton";
            this.relatedMediaLBBoxFrontReconRadioButton.Size = new Size(238, 29);
            this.relatedMediaLBBoxFrontReconRadioButton.TabIndex = 10075;
            this.relatedMediaLBBoxFrontReconRadioButton.Text = "Box - Front (Recon)";
            this.relatedMediaLBBoxFrontReconRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxFrontReconRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxFrontRadioButton
            // 
            this.relatedMediaLBBoxFrontRadioButton.AutoSize = true;
            this.relatedMediaLBBoxFrontRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxFrontRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxFrontRadioButton.Location = new Point(10, 62);
            this.relatedMediaLBBoxFrontRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxFrontRadioButton.Name = "relatedMediaLBBoxFrontRadioButton";
            this.relatedMediaLBBoxFrontRadioButton.Size = new Size(152, 29);
            this.relatedMediaLBBoxFrontRadioButton.TabIndex = 10072;
            this.relatedMediaLBBoxFrontRadioButton.Text = "Box - Front";
            this.relatedMediaLBBoxFrontRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxFrontRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBoxBackRadioButton
            // 
            this.relatedMediaLBBoxBackRadioButton.AutoSize = true;
            this.relatedMediaLBBoxBackRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBoxBackRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBoxBackRadioButton.Location = new Point(10, 102);
            this.relatedMediaLBBoxBackRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBoxBackRadioButton.Name = "relatedMediaLBBoxBackRadioButton";
            this.relatedMediaLBBoxBackRadioButton.Size = new Size(146, 29);
            this.relatedMediaLBBoxBackRadioButton.TabIndex = 10074;
            this.relatedMediaLBBoxBackRadioButton.Text = "Box - Back";
            this.relatedMediaLBBoxBackRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBoxBackRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBBox3DRadioButton
            // 
            this.relatedMediaLBBox3DRadioButton.AutoSize = true;
            this.relatedMediaLBBox3DRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBBox3DRadioButton.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBBox3DRadioButton.Location = new Point(10, 142);
            this.relatedMediaLBBox3DRadioButton.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBBox3DRadioButton.Name = "relatedMediaLBBox3DRadioButton";
            this.relatedMediaLBBox3DRadioButton.Size = new Size(126, 29);
            this.relatedMediaLBBox3DRadioButton.TabIndex = 10073;
            this.relatedMediaLBBox3DRadioButton.Text = "Box - 3D";
            this.relatedMediaLBBox3DRadioButton.UseVisualStyleBackColor = true;
            this.relatedMediaLBBox3DRadioButton.Click += new System.EventHandler(this.RelatedMedia_RadioButtonCheckChanged);
            // 
            // relatedMediaLBLinePictureBox
            // 
            this.relatedMediaLBLinePictureBox.BackColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBLinePictureBox.Location = new Point(3, 49);
            this.relatedMediaLBLinePictureBox.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaLBLinePictureBox.Name = "relatedMediaLBLinePictureBox";
            this.relatedMediaLBLinePictureBox.Size = new Size(412, 3);
            this.relatedMediaLBLinePictureBox.TabIndex = 10071;
            this.relatedMediaLBLinePictureBox.TabStop = false;
            // 
            // relatedMediaLBLabel
            // 
            this.relatedMediaLBLabel.BackColor = Color.Transparent;
            this.relatedMediaLBLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.relatedMediaLBLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.relatedMediaLBLabel.Location = new Point(4, 5);
            this.relatedMediaLBLabel.Margin = new Padding(4, 0, 4, 0);
            this.relatedMediaLBLabel.Name = "relatedMediaLBLabel";
            this.relatedMediaLBLabel.Size = new Size(294, 40);
            this.relatedMediaLBLabel.TabIndex = 10063;
            this.relatedMediaLBLabel.Text = "LaunchBox";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.focusTabPage);
            this.mainTabControl.Controls.Add(this.alertsTabPage2);
            this.mainTabControl.Controls.Add(this.userInfoTabPage);
            this.mainTabControl.Controls.Add(this.gameInfoTabPage);
            this.mainTabControl.Controls.Add(this.gameProgressTabPage);
            this.mainTabControl.Controls.Add(this.recentCheevosTabPage);
            this.mainTabControl.Controls.Add(this.cheevosListTabPage);
            this.mainTabControl.Controls.Add(this.relatedMediaTabPage);
            this.mainTabControl.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Location = new Point(6, 166);
            this.mainTabControl.Margin = new Padding(4, 5, 4, 5);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new Size(1166, 612);
            this.mainTabControl.TabIndex = 10033;
            // 
            // focusTabPage
            // 
            this.focusTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.focusTabPage.Controls.Add(this.panel64);
            this.focusTabPage.Controls.Add(this.panel63);
            this.focusTabPage.Controls.Add(this.panel51);
            this.focusTabPage.Location = new Point(4, 32);
            this.focusTabPage.Margin = new Padding(4, 5, 4, 5);
            this.focusTabPage.Name = "focusTabPage";
            this.focusTabPage.Size = new Size(1158, 576);
            this.focusTabPage.TabIndex = 0;
            this.focusTabPage.Text = "Focus";
            // 
            // alertsTabPage2
            // 
            this.alertsTabPage2.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.alertsTabPage2.Controls.Add(this.alertTabControl);
            this.alertsTabPage2.Controls.Add(this.panel65);
            this.alertsTabPage2.Location = new Point(4, 32);
            this.alertsTabPage2.Margin = new Padding(4, 5, 4, 5);
            this.alertsTabPage2.Name = "alertsTabPage2";
            this.alertsTabPage2.Size = new Size(1158, 576);
            this.alertsTabPage2.TabIndex = 1;
            this.alertsTabPage2.Text = "Alerts";
            // 
            // alertTabControl
            // 
            this.alertTabControl.Alignment = TabAlignment.Bottom;
            this.alertTabControl.Controls.Add(this.tabPage1);
            this.alertTabControl.Controls.Add(this.tabPage2);
            this.alertTabControl.Cursor = Cursors.Arrow;
            this.alertTabControl.HotTrack = true;
            this.alertTabControl.Location = new Point(4, 5);
            this.alertTabControl.Margin = new Padding(4, 5, 4, 5);
            this.alertTabControl.Name = "alertTabControl";
            this.alertTabControl.SelectedIndex = 0;
            this.alertTabControl.Size = new Size(438, 557);
            this.alertTabControl.TabIndex = 10082;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabPage1.Controls.Add(this.alertsCustomAchievementPanel);
            this.tabPage1.Controls.Add(this.alertsAchievementEnableCheckbox);
            this.tabPage1.Controls.Add(this.alertsPlayAchievementButton);
            this.tabPage1.Controls.Add(this.alertsCustomAchievementEnableCheckbox);
            this.tabPage1.Cursor = Cursors.Arrow;
            this.tabPage1.Location = new Point(4, 4);
            this.tabPage1.Margin = new Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(4, 5, 4, 5);
            this.tabPage1.Size = new Size(430, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Achievement";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabPage2.Controls.Add(this.alertsCustomMasteryPanel);
            this.tabPage2.Controls.Add(this.alertsMasteryEnableCheckbox);
            this.tabPage2.Controls.Add(this.alertsPlayMasteryButton);
            this.tabPage2.Controls.Add(this.alertsCustomMasteryEnableCheckbox);
            this.tabPage2.Location = new Point(4, 4);
            this.tabPage2.Margin = new Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(4, 5, 4, 5);
            this.tabPage2.Size = new Size(430, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mastery";
            // 
            // userInfoTabPage
            // 
            this.userInfoTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.userInfoTabPage.Controls.Add(this.panel14);
            this.userInfoTabPage.Controls.Add(this.panel21);
            this.userInfoTabPage.Controls.Add(this.panel20);
            this.userInfoTabPage.Location = new Point(4, 32);
            this.userInfoTabPage.Margin = new Padding(4, 5, 4, 5);
            this.userInfoTabPage.Name = "userInfoTabPage";
            this.userInfoTabPage.Size = new Size(1158, 576);
            this.userInfoTabPage.TabIndex = 2;
            this.userInfoTabPage.Text = "User Info";
            // 
            // gameInfoTabPage
            // 
            this.gameInfoTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameInfoTabPage.Controls.Add(this.panel50);
            this.gameInfoTabPage.Controls.Add(this.panel29);
            this.gameInfoTabPage.Controls.Add(this.panel35);
            this.gameInfoTabPage.Location = new Point(4, 32);
            this.gameInfoTabPage.Margin = new Padding(4, 5, 4, 5);
            this.gameInfoTabPage.Name = "gameInfoTabPage";
            this.gameInfoTabPage.Size = new Size(1158, 576);
            this.gameInfoTabPage.TabIndex = 3;
            this.gameInfoTabPage.Text = "Game Info";
            // 
            // gameProgressTabPage
            // 
            this.gameProgressTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameProgressTabPage.Controls.Add(this.panel28);
            this.gameProgressTabPage.Controls.Add(this.panel36);
            this.gameProgressTabPage.Controls.Add(this.panel15);
            this.gameProgressTabPage.Location = new Point(4, 32);
            this.gameProgressTabPage.Margin = new Padding(4, 5, 4, 5);
            this.gameProgressTabPage.Name = "gameProgressTabPage";
            this.gameProgressTabPage.Size = new Size(1158, 576);
            this.gameProgressTabPage.TabIndex = 4;
            this.gameProgressTabPage.Text = "Progress";
            // 
            // recentCheevosTabPage
            // 
            this.recentCheevosTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.recentCheevosTabPage.Controls.Add(this.panel113);
            this.recentCheevosTabPage.Controls.Add(this.panel99);
            this.recentCheevosTabPage.Location = new Point(4, 32);
            this.recentCheevosTabPage.Margin = new Padding(4, 5, 4, 5);
            this.recentCheevosTabPage.Name = "recentCheevosTabPage";
            this.recentCheevosTabPage.Size = new Size(1158, 576);
            this.recentCheevosTabPage.TabIndex = 5;
            this.recentCheevosTabPage.Text = "Recent Unlocks";
            // 
            // cheevosListTabPage
            // 
            this.cheevosListTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.cheevosListTabPage.Controls.Add(this.panel111);
            this.cheevosListTabPage.Controls.Add(this.panel115);
            this.cheevosListTabPage.Location = new Point(4, 32);
            this.cheevosListTabPage.Margin = new Padding(4, 5, 4, 5);
            this.cheevosListTabPage.Name = "cheevosListTabPage";
            this.cheevosListTabPage.Size = new Size(1158, 576);
            this.cheevosListTabPage.TabIndex = 6;
            this.cheevosListTabPage.Text = "Achievement List";
            // 
            // relatedMediaTabPage
            // 
            this.relatedMediaTabPage.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.relatedMediaTabPage.Controls.Add(this.panel124);
            this.relatedMediaTabPage.Controls.Add(this.panel120);
            this.relatedMediaTabPage.Controls.Add(this.panel121);
            this.relatedMediaTabPage.Location = new Point(4, 32);
            this.relatedMediaTabPage.Margin = new Padding(4, 5, 4, 5);
            this.relatedMediaTabPage.Name = "relatedMediaTabPage";
            this.relatedMediaTabPage.Size = new Size(1158, 576);
            this.relatedMediaTabPage.TabIndex = 7;
            this.relatedMediaTabPage.Text = "Related Media";
            // 
            // manualSearchLabel
            // 
            this.manualSearchLabel.AutoSize = true;
            this.manualSearchLabel.BackColor = Color.Transparent;
            this.manualSearchLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.manualSearchLabel.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.manualSearchLabel.Location = new Point(4, 15);
            this.manualSearchLabel.Margin = new Padding(4, 0, 4, 0);
            this.manualSearchLabel.Name = "manualSearchLabel";
            this.manualSearchLabel.Size = new Size(98, 25);
            this.manualSearchLabel.TabIndex = 32;
            this.manualSearchLabel.Text = "Game Id";
            // 
            // manualSearchTextBox
            // 
            this.manualSearchTextBox.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.manualSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.manualSearchTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.manualSearchTextBox.ForeColor = Color.White;
            this.manualSearchTextBox.Location = new Point(105, 9);
            this.manualSearchTextBox.Margin = new Padding(4, 5, 4, 5);
            this.manualSearchTextBox.Name = "manualSearchTextBox";
            this.manualSearchTextBox.Size = new Size(138, 31);
            this.manualSearchTextBox.TabIndex = 30;
            this.manualSearchTextBox.WordWrap = false;
            this.manualSearchTextBox.KeyPress += new KeyPressEventHandler(this.ManualSearchTextBox_KeyPress);
            // 
            // manualSearchButton
            // 
            this.manualSearchButton.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.manualSearchButton.FlatAppearance.BorderColor = Color.Black;
            this.manualSearchButton.FlatStyle = FlatStyle.Flat;
            this.manualSearchButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.manualSearchButton.ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.manualSearchButton.Location = new Point(249, 5);
            this.manualSearchButton.Margin = new Padding(0);
            this.manualSearchButton.Name = "manualSearchButton";
            this.manualSearchButton.Size = new Size(112, 42);
            this.manualSearchButton.TabIndex = 31;
            this.manualSearchButton.Text = "Search";
            this.manualSearchButton.UseVisualStyleBackColor = false;
            this.manualSearchButton.Click += new System.EventHandler(this.ManualSearchButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel8.Controls.Add(this.manualSearchLabel);
            this.panel8.Controls.Add(this.manualSearchTextBox);
            this.panel8.Controls.Add(this.manualSearchButton);
            this.panel8.Location = new Point(190, 105);
            this.panel8.Margin = new Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new Size(364, 52);
            this.panel8.TabIndex = 10037;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new Size(1179, 785);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.autoPollingStatusPictureBox);
            this.Controls.Add(this.autoPollingStatusLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Retro Achievements Tracker";
            ((ISupportInitialize)(this.userProfilePictureBox)).EndInit();
            ((ISupportInitialize)(this.focusAchievementPictureBox)).EndInit();
            ((ISupportInitialize)(this.gameInfoPictureBox)).EndInit();
            ((ISupportInitialize)(this.autoPollingStatusPictureBox)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementScaleNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementXNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementYNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementOutNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementOutSpeedUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementInNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomAchievementInSpeedUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryScaleNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryXNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryYNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryOutNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryOutSpeedUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryInNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsCustomMasteryInSpeedUpDown)).EndInit();
            ((ISupportInitialize)(this.recentAchievementsMaxListNumericUpDown)).EndInit();
            this.panel64.ResumeLayout(false);
            this.panel64.PerformLayout();
            ((ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel63.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel51.ResumeLayout(false);
            this.panel51.PerformLayout();
            this.focusLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(this.focusLineColorPictureBox)).EndInit();
            this.panel59.ResumeLayout(false);
            this.panel59.PerformLayout();
            ((ISupportInitialize)(this.focusBorderColorPictureBox)).EndInit();
            this.focusPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.focusPointsFontColorPictureBox)).EndInit();
            this.panel52.ResumeLayout(false);
            this.panel52.PerformLayout();
            this.panel61.ResumeLayout(false);
            this.panel61.PerformLayout();
            ((ISupportInitialize)(this.focusTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.focusTitleFontOutlineColorPictureBox)).EndInit();
            this.focusDescriptionOutlinePanel.ResumeLayout(false);
            this.focusDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.focusDescriptionFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.focusDescriptionFontOutlineNumericUpDown)).EndInit();
            this.focusDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.focusDescriptionFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel54.ResumeLayout(false);
            ((ISupportInitialize)(this.focusBackgroundColorPictureBox)).EndInit();
            this.panel55.ResumeLayout(false);
            ((ISupportInitialize)(this.focusTitleFontColorPictureBox)).EndInit();
            this.focusPointsOutlinePanel.ResumeLayout(false);
            this.focusPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.focusPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.focusPointsFontOutlineColorPictureBox)).EndInit();
            this.focusLineOutlinePanel.ResumeLayout(false);
            this.focusLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.focusLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.focusLineOutlineNumericUpDown)).EndInit();
            this.panel65.ResumeLayout(false);
            this.panel65.PerformLayout();
            this.alertsLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(this.alertsLineColorPictureBox)).EndInit();
            this.panel67.ResumeLayout(false);
            this.panel67.PerformLayout();
            ((ISupportInitialize)(this.alertsBorderColorPictureBox)).EndInit();
            this.alertsPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.alertsPointsFontColorPictureBox)).EndInit();
            this.panel69.ResumeLayout(false);
            this.panel69.PerformLayout();
            this.panel70.ResumeLayout(false);
            this.panel70.PerformLayout();
            ((ISupportInitialize)(this.alertsTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsTitleFontOutlineColorPictureBox)).EndInit();
            this.alertsDescriptionOutlinePanel.ResumeLayout(false);
            this.alertsDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.alertsDescriptionFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.alertsDescriptionFontOutlineNumericUpDown)).EndInit();
            this.alertsDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.alertsDescriptionFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox20)).EndInit();
            this.panel73.ResumeLayout(false);
            ((ISupportInitialize)(this.alertsBackgroundColorPictureBox)).EndInit();
            this.panel74.ResumeLayout(false);
            ((ISupportInitialize)(this.alertsTitleFontColorPictureBox)).EndInit();
            this.alertsPointsOutlinePanel.ResumeLayout(false);
            this.alertsPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.alertsPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.alertsPointsFontOutlineColorPictureBox)).EndInit();
            this.alertsLineOutlinePanel.ResumeLayout(false);
            this.alertsLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.alertsLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.alertsLineOutlineNumericUpDown)).EndInit();
            this.alertsCustomAchievementPanel.ResumeLayout(false);
            this.alertsCustomAchievementPanel.PerformLayout();
            this.panel85.ResumeLayout(false);
            this.panel84.ResumeLayout(false);
            this.panel86.ResumeLayout(false);
            this.panel83.ResumeLayout(false);
            this.panel87.ResumeLayout(false);
            this.panel78.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel79.ResumeLayout(false);
            this.panel80.ResumeLayout(false);
            this.panel81.ResumeLayout(false);
            this.panel82.ResumeLayout(false);
            this.alertsCustomMasteryPanel.ResumeLayout(false);
            this.alertsCustomMasteryPanel.PerformLayout();
            this.panel89.ResumeLayout(false);
            this.panel90.ResumeLayout(false);
            this.panel91.ResumeLayout(false);
            this.panel92.ResumeLayout(false);
            this.panel93.ResumeLayout(false);
            this.panel94.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox14)).EndInit();
            this.panel95.ResumeLayout(false);
            this.panel96.ResumeLayout(false);
            this.panel97.ResumeLayout(false);
            this.panel98.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.userInfoValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.userInfoValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((ISupportInitialize)(this.userInfoBackgroundColorPictureBox)).EndInit();
            this.panel6.ResumeLayout(false);
            ((ISupportInitialize)(this.userInfoNamesFontColorPictureBox)).EndInit();
            this.panel7.ResumeLayout(false);
            ((ISupportInitialize)(this.userInfoNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.userInfoNamesFontOutlineColorPictureBox)).EndInit();
            this.userInfoValuesOutlinePanel.ResumeLayout(false);
            ((ISupportInitialize)(this.userInfoValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.userInfoValuesFontOutlineNumericUpDown)).EndInit();
            this.panel50.ResumeLayout(false);
            this.panel119.ResumeLayout(false);
            this.panel117.ResumeLayout(false);
            this.panel118.ResumeLayout(false);
            this.panel116.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel29.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel48.ResumeLayout(false);
            this.panel48.PerformLayout();
            this.panel30.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel34.ResumeLayout(false);
            this.panel34.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.gameInfoValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.gameInfoValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel44.ResumeLayout(false);
            ((ISupportInitialize)(this.gameInfoBackgroundColorPictureBox)).EndInit();
            this.panel45.ResumeLayout(false);
            ((ISupportInitialize)(this.gameInfoNamesFontColorPictureBox)).EndInit();
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            ((ISupportInitialize)(this.gameInfoNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.gameInfoNamesFontOutlineColorPictureBox)).EndInit();
            this.gameInfoValuesOutlinePanel.ResumeLayout(false);
            this.gameInfoValuesOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.gameInfoValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.gameInfoValuesFontOutlineNumericUpDown)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((ISupportInitialize)(this.gameProgressPercentCompletePictureBox)).EndInit();
            ((ISupportInitialize)(this.gameProgressMasteryPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox21)).EndInit();
            ((ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.gameProgressValuesPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.gameProgressValuesFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel18.ResumeLayout(false);
            ((ISupportInitialize)(this.gameProgressBackgroundColorPictureBox)).EndInit();
            this.panel19.ResumeLayout(false);
            ((ISupportInitialize)(this.gameProgressNamesFontColorPictureBox)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((ISupportInitialize)(this.gameProgressNamesFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.gameProgressNamesFontOutlineColorPictureBox)).EndInit();
            this.gameProgressValuesOutlinePanel.ResumeLayout(false);
            this.gameProgressValuesOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.gameProgressValuesFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.gameProgressValuesFontOutlineNumericUpDown)).EndInit();
            this.panel36.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            ((ISupportInitialize)(this.pictureBox17)).EndInit();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.panel113.ResumeLayout(false);
            this.panel113.PerformLayout();
            ((ISupportInitialize)(this.pictureBox15)).EndInit();
            this.panel99.ResumeLayout(false);
            this.panel99.PerformLayout();
            this.recentAchievementsLinePanel.ResumeLayout(false);
            ((ISupportInitialize)(this.recentAchievementsLineColorPictureBox)).EndInit();
            this.panel101.ResumeLayout(false);
            this.panel101.PerformLayout();
            ((ISupportInitialize)(this.recentAchievementsBorderColorPictureBox)).EndInit();
            this.recentAchievementsPointsPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.recentAchievementsPointsFontColorPictureBox)).EndInit();
            this.panel103.ResumeLayout(false);
            this.panel103.PerformLayout();
            this.panel104.ResumeLayout(false);
            this.panel104.PerformLayout();
            ((ISupportInitialize)(this.recentAchievementsTitleFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.recentAchievementsTitleFontOutlineColorPictureBox)).EndInit();
            this.recentAchievementsDescriptionOutlinePanel.ResumeLayout(false);
            this.recentAchievementsDescriptionOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.recentAchievementsDateFontOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.recentAchievementsDescriptionFontOutlineNumericUpDown)).EndInit();
            this.recentAchievementsDescriptionPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.recentAchievementsDateFontColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.pictureBox23)).EndInit();
            this.panel107.ResumeLayout(false);
            ((ISupportInitialize)(this.recentAchievementsBackgroundColorPictureBox)).EndInit();
            this.panel108.ResumeLayout(false);
            ((ISupportInitialize)(this.recentAchievementsTitleFontColorPictureBox)).EndInit();
            this.recentAchievementsPointsOutlinePanel.ResumeLayout(false);
            this.recentAchievementsPointsOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.recentAchievementsPointsFontOutlineNumericUpDown)).EndInit();
            ((ISupportInitialize)(this.recentAchievementsPointsFontOutlineColorPictureBox)).EndInit();
            this.recentAchievementsLineOutlinePanel.ResumeLayout(false);
            this.recentAchievementsLineOutlinePanel.PerformLayout();
            ((ISupportInitialize)(this.recentAchievementsLineOutlineColorPictureBox)).EndInit();
            ((ISupportInitialize)(this.recentAchievementsLineOutlineNumericUpDown)).EndInit();
            this.panel115.ResumeLayout(false);
            this.panel115.PerformLayout();
            ((ISupportInitialize)(this.pictureBox18)).EndInit();
            this.panel111.ResumeLayout(false);
            this.panel111.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((ISupportInitialize)(this.achievementListWindowSizeXUpDown)).EndInit();
            ((ISupportInitialize)(this.achievementListWindowSizeYUpDown)).EndInit();
            this.panel112.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panel114.ResumeLayout(false);
            ((ISupportInitialize)(this.achievementListBackgroundColorPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel120.ResumeLayout(false);
            this.panel120.PerformLayout();
            ((ISupportInitialize)(this.pictureBox19)).EndInit();
            this.panel121.ResumeLayout(false);
            this.panel121.PerformLayout();
            this.panel122.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox22)).EndInit();
            this.panel123.ResumeLayout(false);
            ((ISupportInitialize)(this.relatedMediaBackgroundColorPictureBox)).EndInit();
            this.panel124.ResumeLayout(false);
            this.panel124.PerformLayout();
            ((ISupportInitialize)(this.relatedMediaLBLinePictureBox)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.focusTabPage.ResumeLayout(false);
            this.alertsTabPage2.ResumeLayout(false);
            this.alertTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.userInfoTabPage.ResumeLayout(false);
            this.gameInfoTabPage.ResumeLayout(false);
            this.gameProgressTabPage.ResumeLayout(false);
            this.recentCheevosTabPage.ResumeLayout(false);
            this.cheevosListTabPage.ResumeLayout(false);
            this.relatedMediaTabPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

