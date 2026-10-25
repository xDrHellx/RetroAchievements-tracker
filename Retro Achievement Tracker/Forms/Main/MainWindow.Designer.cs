using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Retro_Achievement_Tracker.Tabs;
using Retro_Achievement_Tracker.Utils;
// using Runtime.InteropServices;

namespace Retro_Achievement_Tracker
{
    partial class MainWindow
    {
        Font labelFont = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
            windowSettingsFont = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Padding labelMargin = new Padding(4, 0, 4, 0),
            btnPanelMargin = new Padding(4, 5, 4, 5);
        Color foreColor = Color.FromArgb(44, 151, 250),
            btnBackColor = Color.FromArgb(22, 22, 22),
            btnForeColor = Color.FromArgb(204, 153, 0),
            panelBackColor = Color.FromArgb(32, 32, 32),
            lightGrayColor = Color.FromArgb(200, 200, 200);

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
            openFileDialog.FileName = "openFileDialog";

            // Search
            manualSearchLabel = WinFormHelpers.CreateLabel("manualSearchLabel", "Game ID", new Point(4, 15), new Size(98, 25), margin: labelMargin);
            // manualSearchLabel.AutoSize = true;
            manualSearchLabel.BackColor = Color.Transparent;
            manualSearchLabel.Font = labelFont;
            manualSearchLabel.ForeColor = foreColor;
            // manualSearchLabel.TabIndex = 32;

            manualSearchTextBox = WinFormHelpers.CreateTextBox("manualSearchTextBox", "", new Point(105, 9), new Size(138, 31), readOnly: false);
            manualSearchTextBox.BackColor = btnBackColor;
            manualSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            manualSearchTextBox.Font = labelFont;
            manualSearchTextBox.ForeColor = Color.White;
            manualSearchTextBox.Margin = btnPanelMargin;
            // manualSearchTextBox.TabIndex = 30;
            manualSearchTextBox.WordWrap = false;
            manualSearchTextBox.KeyPress += new KeyPressEventHandler(ManualSearchTextBox_KeyPress);

            manualSearchButton = WinFormHelpers.CreateButton("manualSearchButton", "Search", new Point(249, 5), new Size(112, 42));
            manualSearchButton.BackColor = btnBackColor;
            manualSearchButton.FlatAppearance.BorderColor = Color.Black;
            manualSearchButton.FlatStyle = FlatStyle.Flat;
            manualSearchButton.Font = labelFont;
            manualSearchButton.ForeColor = btnForeColor;
            manualSearchButton.Margin = new Padding(0);
            // manualSearchButton.TabIndex = 31;
            manualSearchButton.UseVisualStyleBackColor = false;
            manualSearchButton.Click += new EventHandler(ManualSearchButton_Click);

            // RA account & API interactions
            usernameLabel = WinFormHelpers.CreateLabel("usernameLabel", "Username", new Point(50, 8), new Size(114, 25), margin: labelMargin);
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = labelFont;
            usernameLabel.ForeColor = foreColor;
            // usernameLabel.TabIndex = 26;

            usernameTextBox = WinFormHelpers.CreateTextBox("usernameTextBox", "", new Point(162, 5), new Size(428, 31), readOnly: false);
            usernameTextBox.BackColor = btnBackColor;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = labelFont;
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Margin = btnPanelMargin;
            // usernameTextBox.TabIndex = 0;
            usernameTextBox.WordWrap = false;
            usernameTextBox.TextChanged += new EventHandler(RequiredField_TextChanged);

            apiKeyLabel = WinFormHelpers.CreateLabel("apiKeyLabel", "Web API Key", new Point(20, 6), new Size(140, 25), margin: labelMargin);
            // apiKeyLabel.AutoSize = true;
            apiKeyLabel.BackColor = Color.Transparent;
            apiKeyLabel.Font = labelFont;
            apiKeyLabel.ForeColor = foreColor;
            // apiKeyLabel.TabIndex = 31;

            apiKeyTextBox = WinFormHelpers.CreateTextBox("apiKeyTextBox", "", new Point(162, 3), new Size(428, 31), readOnly: false);
            apiKeyTextBox.BackColor = btnBackColor;
            apiKeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            apiKeyTextBox.Font = labelFont;
            apiKeyTextBox.ForeColor = Color.White;
            apiKeyTextBox.Margin = btnPanelMargin;
            apiKeyTextBox.PasswordChar = '*';
            // apiKeyTextBox.TabIndex = 1;
            apiKeyTextBox.WordWrap = false;
            apiKeyTextBox.TextChanged += new EventHandler(RequiredField_TextChanged);

            checkForUpdatesButton = WinFormHelpers.CreateButton("checkForUpdatesButton", "Check For Updates", new Point(4, 95), new Size(225, 42));
            checkForUpdatesButton.BackColor = btnBackColor;
            checkForUpdatesButton.FlatAppearance.BorderColor = Color.Black;
            checkForUpdatesButton.FlatStyle = FlatStyle.Flat;
            checkForUpdatesButton.Font = labelFont;
            checkForUpdatesButton.ForeColor = btnForeColor;
            checkForUpdatesButton.Margin = new Padding(0);
            // checkForUpdatesButton.TabIndex = 29;
            checkForUpdatesButton.UseVisualStyleBackColor = false;

            autoStartCheckbox = WinFormHelpers.CreateCheckBox("autoStartCheckbox", "Auto-Start", new Point(234, 109), new Size(125, 26));
            // autoStartCheckbox.AutoSize = true;
            autoStartCheckbox.BackColor = Color.Transparent;
            autoStartCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            autoStartCheckbox.FlatAppearance.BorderSize = 0;
            autoStartCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(118, 118, 118);
            autoStartCheckbox.FlatStyle = FlatStyle.Flat;
            autoStartCheckbox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoStartCheckbox.ForeColor = foreColor;
            autoStartCheckbox.Margin = btnPanelMargin;
            // autoStartCheckbox.TabIndex = 2;
            autoStartCheckbox.UseVisualStyleBackColor = false;
            autoStartCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            startButton = WinFormHelpers.CreateButton("startButton", "Start", new Point(370, 97), new Size(112, 42));
            startButton.BackColor = btnBackColor;
            startButton.FlatAppearance.BorderColor = Color.Black;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = labelFont;
            startButton.ForeColor = btnForeColor;
            startButton.Margin = new Padding(0);
            // startButton.TabIndex = 3;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += new EventHandler(StartButton_Click);

            stopButton = WinFormHelpers.CreateButton("stopButton", "Stop", new Point(483, 97), new Size(112, 42));
            stopButton.BackColor = btnBackColor;
            stopButton.FlatAppearance.BorderColor = Color.Black;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = labelFont;
            stopButton.ForeColor = btnForeColor;
            stopButton.Margin = new Padding(0);
            // stopButton.TabIndex = 4;
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += new EventHandler(StopButton_Click);

            autoPollingStatusLabel = WinFormHelpers.CreateLabel("autoPollingStatusLabel", "Offline", new Point(57, 14), new Size(498, 43));
            autoPollingStatusLabel.BackColor = Color.Transparent;
            autoPollingStatusLabel.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoPollingStatusLabel.ForeColor = foreColor;
            autoPollingStatusLabel.Margin = labelMargin;
            // autoPollingStatusLabel.TabIndex = 10024;

            userProfilePictureBox = WinFormHelpers.CreatePictureBox("userProfilePictureBox", null, new Point(576, 62), sizeMode: "StretchImage", width: 96, height: 98);
            userProfilePictureBox.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            userProfilePictureBox.BackColor = Color.Transparent;
            userProfilePictureBox.Cursor = Cursors.Hand;
            userProfilePictureBox.Margin = btnPanelMargin;
            // userProfilePictureBox.TabIndex = 20;
            userProfilePictureBox.TabStop = false;
            userProfilePictureBox.Click += new EventHandler(BrowserSensitiveControl_Click);

            // Main tabs
            InitTabs();

            mainTabControl = new TabControl();
            alertTabControl = new TabControl();
            achievementTabPage = new TabPage();
            masteryTabPage = new TabPage();

            // Elements
            autoPollingStatusPictureBox = WinFormHelpers.CreatePictureBox("autoPollingStatusPictureBox", global::Retro_Achievement_Tracker.Properties.Resources.red_button, new Point(6, 14), sizeMode: "StretchImage", width: 42, height: 43);
            autoPollingStatusPictureBox.BackColor = Color.Transparent;
            autoPollingStatusPictureBox.Margin = btnPanelMargin;
            // autoPollingStatusPictureBox.TabIndex = 10025;
            autoPollingStatusPictureBox.TabStop = false;

            autoFocusRulePanel = WinFormHelpers.CreatePanel("autoFocusRulePanel", new Point(4, 465), new Size(434, 97));
            autoFocusRulePanel.BackColor = panelBackColor;
            autoFocusRulePanel.Margin = btnPanelMargin;
            // autoFocusRulePanel.TabIndex = 10084;

            auoFocusRuleLabel = WinFormHelpers.CreateLabel("auoFocusRuleLabel", "Auto-Focus Rule", new Point(4, 5), new Size(410, 40));
            auoFocusRuleLabel.BackColor = Color.Transparent;
            auoFocusRuleLabel.Font = windowSettingsFont;
            auoFocusRuleLabel.ForeColor = foreColor;
            auoFocusRuleLabel.Margin = labelMargin;
            // auoFocusRuleLabel.TabIndex = 10082;

            pictureBox12 = WinFormHelpers.CreatePictureBox("pictureBox12", null, new Point(3, 49), width: 412, height: 3);
            pictureBox12.BackColor = foreColor;
            pictureBox12.Margin = btnPanelMargin;
            // pictureBox12.TabIndex = 10083;
            pictureBox12.TabStop = false;

            panel63 = WinFormHelpers.CreatePanel("panel63", new Point(4, 5), new Size(434, 451));
            panel63.BackColor = panelBackColor;
            panel63.Margin = btnPanelMargin;
            // panel63.TabIndex = 10081;

            unlockAchievementButton = WinFormHelpers.CreateButton("unlockAchievementButton", "Unlock", new Point(316, 62), new Size(112, 42));
            unlockAchievementButton.BackColor = btnBackColor;
            unlockAchievementButton.FlatAppearance.BorderColor = btnBackColor;
            unlockAchievementButton.FlatStyle = FlatStyle.Flat;
            unlockAchievementButton.Font = labelFont;
            unlockAchievementButton.ForeColor = btnForeColor;
            unlockAchievementButton.Margin = btnPanelMargin;
            // unlockAchievementButton.TabIndex = 10084;
            unlockAchievementButton.UseVisualStyleBackColor = false;
            unlockAchievementButton.Click += new EventHandler(UnlockAchievementButton_Click);

            currentAchievementLabel = WinFormHelpers.CreateLabel("currentAchievementLabel", "Current Achievement", new Point(4, 5), new Size(410, 40));
            currentAchievementLabel.BackColor = Color.Transparent;
            currentAchievementLabel.Font = windowSettingsFont;
            currentAchievementLabel.ForeColor = foreColor;
            currentAchievementLabel.Margin = labelMargin;
            // currentAchievementLabel.TabIndex = 10082;

            pictureBox10 = WinFormHelpers.CreatePictureBox("pictureBox10", null, new Point(3, 49), width: 420, height: 3);
            pictureBox10.BackColor = foreColor;
            pictureBox10.Margin = btnPanelMargin;
            // pictureBox10.TabIndex = 10083;
            pictureBox10.TabStop = false;

            currentAchievementPanel = WinFormHelpers.CreatePanel("currentAchievementPanel", new Point(444, 5), new Size(702, 438));
            currentAchievementPanel.BackColor = panelBackColor;
            currentAchievementPanel.Margin = btnPanelMargin;
            // currentAchievementPanel.TabIndex = 10080;

            focusLineLabel = WinFormHelpers.CreateLabel("focusLineLabel", "Line", new Point(4, 6), new Size(216, 25));
            focusLineLabel.BackColor = Color.Transparent;
            focusLineLabel.Font = labelFont;
            focusLineLabel.ForeColor = foreColor;
            focusLineLabel.Margin = labelMargin;
            // focusLineLabel.TabIndex = 10066;

            focusWindowSettingsLabel = WinFormHelpers.CreateLabel("focusWindowSettingsLabel", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            focusWindowSettingsLabel.BackColor = Color.Transparent;
            focusWindowSettingsLabel.Font = windowSettingsFont;
            focusWindowSettingsLabel.ForeColor = foreColor;
            focusWindowSettingsLabel.Margin = labelMargin;
            // focusWindowSettingsLabel.TabIndex = 10062;

            panel59 = WinFormHelpers.CreatePanel("panel59", new Point(3, 129), new Size(694, 35));
            panel59.BackColor = panelBackColor;
            panel59.Margin = btnPanelMargin;
            // panel59.TabIndex = 10069;

            label107 = WinFormHelpers.CreateLabel("label107", "Border", new Point(4, 5), new Size(216, 25));
            label107.BackColor = Color.Transparent;
            label107.Font = labelFont;
            label107.ForeColor = foreColor;
            label107.Margin = labelMargin;
            // label107.TabIndex = 10064;

            label108 = WinFormHelpers.CreateLabel("label108", "Points", new Point(4, 6), new Size(216, 25));
            label108.BackColor = Color.Transparent;
            label108.Font = labelFont;
            label108.ForeColor = foreColor;
            label108.Margin = labelMargin;
            // label108.TabIndex = 10065;

            panel52 = WinFormHelpers.CreatePanel("panel52", new Point(3, 62), new Size(694, 35));
            panel52.BackColor = panelBackColor;
            panel52.Margin = btnPanelMargin;
            // panel52.TabIndex = 10076;

            label97 = WinFormHelpers.CreateLabel("label97", "Color", new Point(225, 5), new Size(72, 25));
            label97.BackColor = Color.Transparent;
            label97.Font = labelFont;
            label97.ForeColor = lightGrayColor;
            label97.Margin = labelMargin;
            // label97.TabIndex = 10065;

            label98 = WinFormHelpers.CreateLabel("label98", "Font", new Point(291, 5), new Size(75, 25));
            label98.BackColor = Color.Transparent;
            label98.Font = labelFont;
            label98.ForeColor = lightGrayColor;
            label98.Margin = labelMargin;
            // label98.TabIndex = 10066;

            label99 = WinFormHelpers.CreateLabel("label99", "Size", new Point(524, 5), new Size(62, 25));
            label99.BackColor = Color.Transparent;
            label99.Font = labelFont;
            label99.ForeColor = lightGrayColor;
            label99.Margin = labelMargin;
            // label99.TabIndex = 10068;

            label100 = WinFormHelpers.CreateLabel("label100", "Enabled", new Point(594, 5), new Size(88, 25));
            label100.BackColor = Color.Transparent;
            label100.Font = labelFont;
            label100.ForeColor = lightGrayColor;
            label100.Margin = labelMargin;
            // label100.TabIndex = 10067;

            panel61 = WinFormHelpers.CreatePanel("panel61", new Point(3, 298), new Size(694, 35));
            panel61.BackColor = Color.FromArgb(26, 26, 26);
            panel61.Margin = btnPanelMargin;
            // panel61.TabIndex = 10071;

            label110 = WinFormHelpers.CreateLabel("label110", "Description OutlineColor", new Point(4, 6), new Size(216, 25));
            label110.BackColor = Color.Transparent;
            label110.Font = labelFont;
            label110.ForeColor = foreColor;
            label110.Margin = labelMargin;
            // label110.TabIndex = 10066;

            label101 = WinFormHelpers.CreateLabel("label101", "Description", new Point(4, 6), new Size(216, 25));
            label101.BackColor = Color.Transparent;
            label101.Font = labelFont;
            label101.ForeColor = foreColor;
            label101.Margin = labelMargin;
            // label101.TabIndex = 10066;

            pictureBox11 = WinFormHelpers.CreatePictureBox("pictureBox11", null, new Point(3, 49), width: 690, height: 3);
            pictureBox11.BackColor = foreColor;
            pictureBox11.Margin = btnPanelMargin;
            // pictureBox11.TabIndex = 10063;
            pictureBox11.TabStop = false;

            panel54 = WinFormHelpers.CreatePanel("panel54", new Point(3, 95), new Size(694, 35));
            panel54.BackColor = Color.FromArgb(26, 26, 26);
            panel54.Margin = btnPanelMargin;
            // panel54.TabIndex = 10061;

            label102 = WinFormHelpers.CreateLabel("label102", "Window Background", new Point(4, 5), new Size(216, 25));
            label102.BackColor = Color.Transparent;
            label102.Font = labelFont;
            label102.ForeColor = foreColor;
            label102.Margin = labelMargin;
            // label102.TabIndex = 10064;

            panel55 = WinFormHelpers.CreatePanel("panel55", new Point(3, 163), new Size(694, 35));
            panel55.BackColor = Color.FromArgb(26, 26, 26);
            panel55.Margin = btnPanelMargin;
            // panel55.TabIndex = 10061;

            label104 = WinFormHelpers.CreateLabel("label104", "Points OutlineColor", new Point(4, 5), new Size(216, 25));
            label104.BackColor = Color.Transparent;
            label104.Font = labelFont;
            label104.ForeColor = foreColor;
            label104.Margin = labelMargin;
            // label104.TabIndex = 10066;

            label105 = WinFormHelpers.CreateLabel("label105", "Line OutlineColor", new Point(4, 6), new Size(216, 25));
            label105.BackColor = Color.Transparent;
            label105.Font = labelFont;
            label105.ForeColor = foreColor;
            label105.Margin = labelMargin;
            // label105.TabIndex = 10066;

            panel65 = WinFormHelpers.CreatePanel("panel65", new Point(444, 5), new Size(702, 438));
            panel65.BackColor = panelBackColor;
            panel65.Margin = btnPanelMargin;
            // panel65.TabIndex = 10081;

            label113 = WinFormHelpers.CreateLabel("label113", "Line", new Point(4, 6), new Size(216, 25));
            label113.BackColor = Color.Transparent;
            label113.Font = labelFont;
            label113.ForeColor = foreColor;
            label113.Margin = labelMargin;
            // label113.TabIndex = 10066;

            label114 = WinFormHelpers.CreateLabel("label114", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label114.BackColor = Color.Transparent;
            label114.Font = windowSettingsFont;
            label114.ForeColor = foreColor;
            label114.Margin = labelMargin;
            // label114.TabIndex = 10062;

            panel67 = WinFormHelpers.CreatePanel("panel67", new Point(3, 129), new Size(694, 35));
            panel67.BackColor = panelBackColor;
            panel67.Margin = btnPanelMargin;
            // panel67.TabIndex = 10069;

            label115 = WinFormHelpers.CreateLabel("label115", "Border", new Point(4, 5), new Size(216, 25));
            label115.BackColor = Color.Transparent;
            label115.Font = labelFont;
            label115.ForeColor = foreColor;
            label115.Margin = labelMargin;
            // label115.TabIndex = 10064;

            label116 = WinFormHelpers.CreateLabel("label116", "Points", new Point(4, 6), new Size(216, 25));
            label116.BackColor = Color.Transparent;
            label116.Font = labelFont;
            label116.ForeColor = foreColor;
            label116.Margin = labelMargin;
            // label116.TabIndex = 10065;

            panel69 = WinFormHelpers.CreatePanel("panel69", new Point(3, 62), new Size(694, 35));
            panel69.BackColor = panelBackColor;
            panel69.Margin = btnPanelMargin;
            // panel69.TabIndex = 10076;

            label117 = WinFormHelpers.CreateLabel("label117", "Color", new Point(225, 5), new Size(72, 25));
            label117.BackColor = Color.Transparent;
            label117.Font = labelFont;
            label117.ForeColor = lightGrayColor;
            label117.Margin = labelMargin;
            // label117.TabIndex = 10065;

            label118 = WinFormHelpers.CreateLabel("label118", "Font", new Point(291, 5), new Size(75, 25));
            label118.BackColor = Color.Transparent;
            label118.Font = labelFont;
            label118.ForeColor = lightGrayColor;
            label118.Margin = labelMargin;
            // label118.TabIndex = 10066;

            label119 = WinFormHelpers.CreateLabel("label119", "Size", new Point(524, 5), new Size(62, 25));
            label119.BackColor = Color.Transparent;
            label119.Font = labelFont;
            label119.ForeColor = lightGrayColor;
            label119.Margin = labelMargin;
            // label119.TabIndex = 10068;

            label120 = WinFormHelpers.CreateLabel("label120", "Enabled", new Point(594, 5), new Size(88, 25));
            label120.BackColor = Color.Transparent;
            label120.Font = labelFont;
            label120.ForeColor = lightGrayColor;
            label120.Margin = labelMargin;
            // label120.TabIndex = 10067;

            panel70 = WinFormHelpers.CreatePanel("panel70", new Point(3, 298), new Size(694, 35));
            panel70.BackColor = btnBackColor;
            panel70.Margin = btnPanelMargin;
            // panel70.TabIndex = 10071;

            label122 = WinFormHelpers.CreateLabel("label122", "Description OutlineColor", new Point(4, 6), new Size(216, 25));
            label122.BackColor = Color.Transparent;
            label122.Font = labelFont;
            label122.ForeColor = foreColor;
            label122.Margin = labelMargin;
            // label122.TabIndex = 10066;

            label123 = WinFormHelpers.CreateLabel("label123", "Description", new Point(4, 6), new Size(216, 25));
            label123.BackColor = Color.Transparent;
            label123.Font = labelFont;
            label123.ForeColor = foreColor;
            label123.Margin = labelMargin;
            // label123.TabIndex = 10066;

            pictureBox20 = WinFormHelpers.CreatePictureBox("pictureBox20", null, new Point(3, 49), width: 690, height: 3);
            pictureBox20.BackColor = foreColor;
            pictureBox20.Margin = btnPanelMargin;
            // pictureBox20.TabIndex = 10063;
            pictureBox20.TabStop = false;

            pictureBox13 = WinFormHelpers.CreatePictureBox("pictureBox13", null, new Point(3, 49), width: 398, height: 3);
            pictureBox13.BackColor = foreColor;
            pictureBox13.Margin = btnPanelMargin;
            // pictureBox13.TabIndex = 10070;
            pictureBox13.TabStop = false;

            pictureBox14 = WinFormHelpers.CreatePictureBox("pictureBox14", null, new Point(3, 49), width: 398, height: 3);
            pictureBox14.BackColor = foreColor;
            pictureBox14.Margin = btnPanelMargin;
            // pictureBox14.TabIndex = 10070;
            pictureBox14.TabStop = false;

            panel73 = WinFormHelpers.CreatePanel("panel73", new Point(3, 95), new Size(694, 35));
            panel73.BackColor = btnBackColor;
            panel73.Margin = btnPanelMargin;
            // panel73.TabIndex = 10061;

            label124 = WinFormHelpers.CreateLabel("label124", "Window Background", new Point(4, 5), new Size(216, 25));
            label124.BackColor = Color.Transparent;
            label124.Font = labelFont;
            label124.ForeColor = foreColor;
            label124.Margin = labelMargin;
            // label124.TabIndex = 10064;

            panel74 = WinFormHelpers.CreatePanel("panel74", new Point(3, 163), new Size(694, 35));
            panel74.BackColor = btnBackColor;
            panel74.Margin = btnPanelMargin;
            // panel74.TabIndex = 10061;

            label126 = WinFormHelpers.CreateLabel("label126", "Points OutlineColor", new Point(4, 5), new Size(216, 25));
            label126.BackColor = Color.Transparent;
            label126.Font = labelFont;
            label126.ForeColor = foreColor;
            label126.Margin = labelMargin;
            // label126.TabIndex = 10066;

            label127 = WinFormHelpers.CreateLabel("label127", "Line OutlineColor", new Point(4, 6), new Size(216, 25));
            label127.BackColor = Color.Transparent;
            label127.Font = labelFont;
            label127.ForeColor = foreColor;
            label127.Margin = labelMargin;
            // label127.TabIndex = 10066;

            label129 = WinFormHelpers.CreateLabel("label129", "Animate In Duration", new Point(4, 6), new Size(225, 25));
            label129.BackColor = Color.Transparent;
            label129.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label129.ForeColor = foreColor;
            label129.Margin = labelMargin;
            // label129.TabIndex = 10069;

            label42 = WinFormHelpers.CreateLabel("label42", "Field", new Point(4, 5), new Size(75, 25));
            label42.BackColor = Color.Transparent;
            label42.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label42.ForeColor = Color.FromArgb(200, 200, 200);
            label42.Margin = labelMargin;
            // label42.TabIndex = 10071;

            label128 = WinFormHelpers.CreateLabel("label128", "Value", new Point(279, 5), new Size(87, 25));
            label128.BackColor = Color.Transparent;
            label128.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label128.ForeColor = Color.FromArgb(200, 200, 200);
            label128.Margin = labelMargin;
            // label128.TabIndex = 10073;

            label130 = WinFormHelpers.CreateLabel("label130", "Achievement", new Point(4, 5), new Size(228, 40));
            label130.BackColor = Color.Transparent;
            label130.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label130.ForeColor = foreColor;
            label130.Margin = labelMargin;
            // label130.TabIndex = 10069;

            label131 = WinFormHelpers.CreateLabel("label131", "X position", new Point(4, 5), new Size(141, 25));
            label131.BackColor = Color.Transparent;
            label131.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label131.ForeColor = foreColor;
            label131.Margin = labelMargin;
            // label131.TabIndex = 10066;

            label132 = WinFormHelpers.CreateLabel("label132", "Animate In Time", new Point(4, 6), new Size(225, 25));
            label132.BackColor = Color.Transparent;
            label132.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label132.ForeColor = foreColor;
            label132.Margin = labelMargin;
            // label132.TabIndex = 10069;

            label133 = WinFormHelpers.CreateLabel("label133", "Scale", new Point(4, 6), new Size(141, 25));
            label133.BackColor = Color.Transparent;
            label133.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label133.ForeColor = foreColor;
            label133.Margin = labelMargin;
            // label133.TabIndex = 10068;

            label134 = WinFormHelpers.CreateLabel("label134", "Y position", new Point(4, 6), new Size(141, 25));
            label134.BackColor = Color.Transparent;
            label134.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label134.ForeColor = foreColor;
            label134.Margin = labelMargin;
            // label134.TabIndex = 10067;

            label135 = WinFormHelpers.CreateLabel("label135", "Animate In Direction", new Point(4, 6), new Size(225, 25));
            label135.BackColor = Color.Transparent;
            label135.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label135.ForeColor = foreColor;
            label135.Margin = labelMargin;
            // label135.TabIndex = 10069;

            label136 = WinFormHelpers.CreateLabel("label136", "Animate Out Direction", new Point(4, 6), new Size(238, 25));
            label136.BackColor = Color.Transparent;
            label136.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label136.ForeColor = foreColor;
            label136.Margin = labelMargin;
            // label136.TabIndex = 10069;

            label137 = WinFormHelpers.CreateLabel("label137", "Animate Out Duration", new Point(4, 6), new Size(225, 25));
            label137.BackColor = Color.Transparent;
            label137.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label137.ForeColor = foreColor;
            label137.Margin = labelMargin;
            // label137.TabIndex = 10069;

            label138 = WinFormHelpers.CreateLabel("label138", "Animate Out Time", new Point(4, 6), new Size(225, 25));
            label138.BackColor = Color.Transparent;
            label138.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label138.ForeColor = foreColor;
            label138.Margin = labelMargin;
            // label138.TabIndex = 10069;

            label6 = WinFormHelpers.CreateLabel("label6", "Animate Out Direction", new Point(4, 6), new Size(238, 25));
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = foreColor;
            label6.Margin = labelMargin;
            // label6.TabIndex = 10069;

            label7 = WinFormHelpers.CreateLabel("label7", "Animate In Direction", new Point(4, 6), new Size(225, 25));
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = foreColor;
            label7.Margin = labelMargin;
            // label7.TabIndex = 10069;

            label8 = WinFormHelpers.CreateLabel("label8", "Animate Out Duration", new Point(4, 6), new Size(225, 25));
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = foreColor;
            label8.Margin = labelMargin;
            // label8.TabIndex = 10069;

            label11 = WinFormHelpers.CreateLabel("label11", "Animate In Duration", new Point(4, 6), new Size(225, 25));
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = foreColor;
            label11.Margin = labelMargin;
            // label11.TabIndex = 10069;

            label12 = WinFormHelpers.CreateLabel("label12", "Animate Out Time", new Point(4, 6), new Size(225, 25));
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = foreColor;
            label12.Margin = labelMargin;
            // label12.TabIndex = 10069;

            label13 = WinFormHelpers.CreateLabel("label13", "Field", new Point(4, 5), new Size(75, 25));
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = Color.FromArgb(200, 200, 200);
            label13.Margin = labelMargin;
            // label13.TabIndex = 10071;

            label14 = WinFormHelpers.CreateLabel("label14", "Value", new Point(279, 5), new Size(87, 25));
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = Color.FromArgb(200, 200, 200);
            label14.Margin = labelMargin;
            // label14.TabIndex = 10073;

            label139 = WinFormHelpers.CreateLabel("label139", "Mastery", new Point(4, 5), new Size(228, 40));
            label139.BackColor = Color.Transparent;
            label139.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label139.ForeColor = foreColor;
            label139.Margin = labelMargin;
            // label139.TabIndex = 10069;

            panel95 = WinFormHelpers.CreatePanel("panel95", new Point(3, 95), new Size(408, 35));
            panel95.BackColor = btnBackColor;
            panel95.Margin = btnPanelMargin;
            // panel95.TabIndex = 10061;

            label140 = WinFormHelpers.CreateLabel("label140", "X position", new Point(4, 5), new Size(141, 25));
            label140.BackColor = Color.Transparent;
            label140.Font = labelFont;
            label140.ForeColor = foreColor;
            label140.Margin = labelMargin;
            // label140.TabIndex = 10066;

            panel96 = WinFormHelpers.CreatePanel("panel96", new Point(3, 197), new Size(408, 35));
            panel96.BackColor = panelBackColor;
            panel96.Margin = btnPanelMargin;
            // panel96.TabIndex = 10061;

            label141 = WinFormHelpers.CreateLabel("label141", "Animate In Time", new Point(4, 6), new Size(225, 25));
            label141.BackColor = Color.Transparent;
            label141.Font = labelFont;
            label141.ForeColor = foreColor;
            label141.Margin = labelMargin;
            // label141.TabIndex = 10069;

            panel97 = WinFormHelpers.CreatePanel("panel97", new Point(3, 163), new Size(408, 35));
            panel97.BackColor = btnBackColor;
            panel97.Margin = btnPanelMargin;
            // panel97.TabIndex = 10061;

            label142 = WinFormHelpers.CreateLabel("label142", "Scale", new Point(4, 6), new Size(141, 25));
            label142.BackColor = Color.Transparent;
            label142.Font = labelFont;
            label142.ForeColor = foreColor;
            label142.Margin = labelMargin;
            // label142.TabIndex = 10068;

            panel98 = WinFormHelpers.CreatePanel("panel98", new Point(3, 129), new Size(408, 35));
            panel98.BackColor = panelBackColor;
            panel98.Margin = btnPanelMargin;
            // panel98.TabIndex = 10061;

            label143 = WinFormHelpers.CreateLabel("label143", "Y position", new Point(4, 6), new Size(141, 25));
            label143.BackColor = Color.Transparent;
            label143.Font = labelFont;
            label143.ForeColor = foreColor;
            label143.Margin = labelMargin;
            // label143.TabIndex = 10067;

            panel14 = WinFormHelpers.CreatePanel("panel14", new Point(444, 283), new Size(702, 278));
            panel14.BackColor = panelBackColor;
            panel14.Margin = btnPanelMargin;
            // panel14.TabIndex = 10079;

            label37 = WinFormHelpers.CreateLabel("label37", "Retro Ratio:", new Point(9, 145), new Size(141, 25));
            label37.BackColor = Color.Transparent;
            label37.Font = labelFont;
            label37.ForeColor = foreColor;
            label37.Margin = labelMargin;
            // label37.TabIndex = 10075;

            pictureBox2 = WinFormHelpers.CreatePictureBox("pictureBox2", null, new Point(3, 49), width: 690, height: 3);
            pictureBox2.BackColor = foreColor;
            pictureBox2.Margin = btnPanelMargin;
            // pictureBox2.TabIndex = 10059;
            pictureBox2.TabStop = false;

            panel21 = WinFormHelpers.CreatePanel("panel21", new Point(6, 5), new Size(430, 243));
            panel21.BackColor = panelBackColor;
            panel21.Margin = btnPanelMargin;
            // panel21.TabIndex = 10078;

            panel22 = WinFormHelpers.CreatePanel("panel22", new Point(3, 62), new Size(417, 35));
            panel22.BackColor = panelBackColor;
            panel22.Margin = btnPanelMargin;
            // panel22.TabIndex = 10079;

            label29 = WinFormHelpers.CreateLabel("label29", "Field", new Point(4, 5), new Size(75, 25));
            label29.BackColor = Color.Transparent;
            label29.Font = labelFont;
            label29.ForeColor = lightGrayColor;
            label29.Margin = labelMargin;
            // label29.TabIndex = 10071;

            label32 = WinFormHelpers.CreateLabel("label32", "Display Text", new Point(170, 5), new Size(153, 25));
            label32.BackColor = Color.Transparent;
            label32.Font = labelFont;
            label32.ForeColor = lightGrayColor;
            label32.Margin = labelMargin;
            // label32.TabIndex = 10073;

            label30 = WinFormHelpers.CreateLabel("label30", "Enabled", new Point(332, 5), new Size(92, 25));
            label30.BackColor = Color.Transparent;
            label30.Font = labelFont;
            label30.ForeColor = lightGrayColor;
            label30.Margin = labelMargin;
            // label30.TabIndex = 10072;

            label28 = WinFormHelpers.CreateLabel("label28", "Field Overrides", new Point(4, 5), new Size(285, 40));
            label28.BackColor = Color.Transparent;
            label28.Font = windowSettingsFont;
            label28.ForeColor = foreColor;
            label28.Margin = labelMargin;
            // label28.TabIndex = 10069;

            pictureBox4 = WinFormHelpers.CreatePictureBox("pictureBox4", null, new Point(3, 49), width: 412, height: 3);
            pictureBox4.BackColor = foreColor;
            pictureBox4.Margin = btnPanelMargin;
            // pictureBox4.TabIndex = 10070;
            pictureBox4.TabStop = false;

            panel10 = WinFormHelpers.CreatePanel("panel10", new Point(3, 95), new Size(417, 35));
            panel10.BackColor = btnBackColor;
            panel10.Margin = btnPanelMargin;
            // panel10.TabIndex = 10061;

            label31 = WinFormHelpers.CreateLabel("label31", "Rank", new Point(4, 5), new Size(141, 25));
            label31.BackColor = Color.Transparent;
            label31.Font = labelFont;
            label31.ForeColor = foreColor;
            label31.Margin = labelMargin;
            // label31.TabIndex = 10066;

            panel13 = WinFormHelpers.CreatePanel("panel13", new Point(3, 197), new Size(417, 35));
            panel13.BackColor = panelBackColor;
            panel13.Margin = btnPanelMargin;
            // panel13.TabIndex = 10061;

            label35 = WinFormHelpers.CreateLabel("label35", "Retro Ratio", new Point(4, 6), new Size(141, 25));
            label35.BackColor = Color.Transparent;
            label35.Font = labelFont;
            label35.ForeColor = foreColor;
            label35.Margin = labelMargin;
            // label35.TabIndex = 10069;

            panel12 = WinFormHelpers.CreatePanel("panel12", new Point(3, 163), new Size(417, 35));
            panel12.BackColor = btnBackColor;
            panel12.Margin = btnPanelMargin;
            // panel12.TabIndex = 10061;

            label34 = WinFormHelpers.CreateLabel("label34", "True Points", new Point(4, 6), new Size(141, 25));
            label34.BackColor = Color.Transparent;
            label34.Font = labelFont;
            label34.ForeColor = foreColor;
            label34.Margin = labelMargin;
            // label34.TabIndex = 10068;

            panel11 = WinFormHelpers.CreatePanel("panel11", new Point(3, 129), new Size(417, 35));
            panel11.BackColor = panelBackColor;
            panel11.Margin = btnPanelMargin;
            // panel11.TabIndex = 10061;

            label33 = WinFormHelpers.CreateLabel("label33", "Points", new Point(4, 6), new Size(141, 25));
            label33.BackColor = Color.Transparent;
            label33.Font = labelFont;
            label33.ForeColor = foreColor;
            label33.Margin = labelMargin;
            // label33.TabIndex = 10067;

            panel20 = WinFormHelpers.CreatePanel("panel20", new Point(444, 5), new Size(702, 271));
            panel20.BackColor = panelBackColor;
            panel20.Margin = btnPanelMargin;
            // panel20.TabIndex = 10077;

            label2 = WinFormHelpers.CreateLabel("label2", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label2.BackColor = Color.Transparent;
            label2.Font = windowSettingsFont;
            label2.ForeColor = foreColor;
            label2.Margin = labelMargin;
            // label2.TabIndex = 10062;

            panel4 = WinFormHelpers.CreatePanel("panel4", new Point(3, 62), new Size(694, 35));
            panel4.BackColor = panelBackColor;
            panel4.Margin = btnPanelMargin;
            // panel4.TabIndex = 10076;

            label4 = WinFormHelpers.CreateLabel("label4", "Color", new Point(225, 5), new Size(72, 25));
            label4.BackColor = Color.Transparent;
            label4.Font = labelFont;
            label4.ForeColor = lightGrayColor;
            label4.Margin = labelMargin;
            // label4.TabIndex = 10065;

            label9 = WinFormHelpers.CreateLabel("label9", "Font", new Point(291, 5), new Size(75, 25));
            label9.BackColor = Color.Transparent;
            label9.Font = labelFont;
            label9.ForeColor = lightGrayColor;
            label9.Margin = labelMargin;
            // label9.TabIndex = 10066;

            label25 = WinFormHelpers.CreateLabel("label25", "Size", new Point(524, 5), new Size(62, 25));
            label25.BackColor = Color.Transparent;
            label25.Font = labelFont;
            label25.ForeColor = lightGrayColor;
            label25.Margin = labelMargin;
            // label25.TabIndex = 10068;

            label15 = WinFormHelpers.CreateLabel("label15", "Enabled", new Point(594, 5), new Size(88, 25));
            label15.BackColor = Color.Transparent;
            label15.Font = labelFont;
            label15.ForeColor = lightGrayColor;
            label15.Margin = labelMargin;
            // label15.TabIndex = 10067;

            label26 = WinFormHelpers.CreateLabel("label26", "Values", new Point(4, 6), new Size(216, 25));
            label26.BackColor = Color.Transparent;
            label26.Font = labelFont;
            label26.ForeColor = foreColor;
            label26.Margin = labelMargin;
            // label26.TabIndex = 10066;

            pictureBox3 = WinFormHelpers.CreatePictureBox("pictureBox3", null, new Point(3, 49), width: 690, height: 3);
            pictureBox3.BackColor = foreColor;
            pictureBox3.Margin = btnPanelMargin;
            // pictureBox3.TabIndex = 10063;
            pictureBox3.TabStop = false;

            panel5 = WinFormHelpers.CreatePanel("panel5", new Point(3, 95), new Size(694, 35));
            panel5.BackColor = btnBackColor;
            panel5.Margin = btnPanelMargin;
            // panel5.TabIndex = 10061;

            label3 = WinFormHelpers.CreateLabel("label3", "Window Background", new Point(4, 5), new Size(216, 25));
            label3.BackColor = Color.Transparent;
            label3.Font = labelFont;
            label3.ForeColor = foreColor;
            label3.Margin = labelMargin;
            // label3.TabIndex = 10064;

            panel6 = WinFormHelpers.CreatePanel("panel6", new Point(3, 129), new Size(694, 35));
            panel6.BackColor = panelBackColor;
            panel6.Margin = btnPanelMargin;
            // panel6.TabIndex = 10061;

            panel7 = WinFormHelpers.CreatePanel("panel7", new Point(3, 197), new Size(694, 35));
            panel7.BackColor = panelBackColor;
            panel7.Margin = btnPanelMargin;
            // panel7.TabIndex = 10061;

            label27 = WinFormHelpers.CreateLabel("label27", "Values OutlineColor", new Point(4, 6), new Size(216, 25));
            label27.BackColor = Color.Transparent;
            label27.Font = labelFont;
            label27.ForeColor = foreColor;
            label27.Margin = labelMargin;
            // label27.TabIndex = 10066;

            panel50 = WinFormHelpers.CreatePanel("panel50", new Point(444, 283), new Size(702, 278));
            panel50.BackColor = panelBackColor;
            panel50.Margin = btnPanelMargin;
            // panel50.TabIndex = 10081;

            panel119 = WinFormHelpers.CreatePanel("panel119", new Point(164, 157), new Size(522, 38));
            panel119.BackColor = panelBackColor;
            panel119.Margin = btnPanelMargin;
            // panel119.TabIndex = 10073;

            label62 = WinFormHelpers.CreateLabel("label62", "Genre", new Point(4, 8), new Size(141, 25));
            label62.BackColor = Color.Transparent;
            label62.Font = labelFont;
            label62.ForeColor = foreColor;
            label62.Margin = labelMargin;
            // label62.TabIndex = 10070;

            label36 = WinFormHelpers.CreateLabel("label36", null, new Point(202, 5), new Size(315, 25));
            label36.BackColor = Color.Transparent;
            label36.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = btnForeColor;
            label36.Margin = labelMargin;
            // label36.TabIndex = 10066;
            label36.UseMnemonic = false;

            panel117 = WinFormHelpers.CreatePanel("panel117", new Point(164, 195), new Size(522, 38));
            panel117.BackColor = btnBackColor;
            panel117.Margin = btnPanelMargin;
            // panel117.TabIndex = 10072;

            label89 = WinFormHelpers.CreateLabel("label89", "Released", new Point(4, 8), new Size(141, 25));
            label89.BackColor = Color.Transparent;
            label89.Font = labelFont;
            label89.ForeColor = foreColor;
            label89.Margin = labelMargin;
            // label89.TabIndex = 10070;

            panel118 = WinFormHelpers.CreatePanel("panel118", new Point(164, 118), new Size(522, 38));
            panel118.BackColor = btnBackColor;
            panel118.Margin = btnPanelMargin;
            // panel118.TabIndex = 10073;

            label61 = WinFormHelpers.CreateLabel("label61", "Publisher", new Point(4, 9), new Size(141, 25));
            label61.BackColor = Color.Transparent;
            label61.Font = labelFont;
            label61.ForeColor = foreColor;
            label61.Margin = labelMargin;
            // label61.TabIndex = 10069;

            panel116 = WinFormHelpers.CreatePanel("panel116", new Point(164, 80), new Size(522, 38));
            panel116.BackColor = panelBackColor;
            panel116.Margin = btnPanelMargin;
            // panel116.TabIndex = 10071;

            label57 = WinFormHelpers.CreateLabel("label57", "Developer", new Point(4, 5), new Size(141, 25));
            label57.BackColor = Color.Transparent;
            label57.Font = labelFont;
            label57.ForeColor = foreColor;
            label57.Margin = labelMargin;
            // label57.TabIndex = 10070;

            pictureBox8 = WinFormHelpers.CreatePictureBox("pictureBox8", null, new Point(3, 68), width: 690, height: 3);
            pictureBox8.BackColor = foreColor;
            pictureBox8.Margin = btnPanelMargin;
            // pictureBox8.TabIndex = 10059;
            pictureBox8.TabStop = false;

            panel29 = WinFormHelpers.CreatePanel("panel29", new Point(6, 5), new Size(430, 309));
            panel29.BackColor = panelBackColor;

            panel29.Margin = btnPanelMargin;
            // panel29.TabIndex = 10080;

            panel49 = WinFormHelpers.CreatePanel("panel49", new Point(3, 265), new Size(417, 35));
            panel49.BackColor = panelBackColor;
            panel49.Margin = btnPanelMargin;
            // panel49.TabIndex = 10071;

            label88 = WinFormHelpers.CreateLabel("label88", "Released", new Point(4, 6), new Size(141, 25));
            label88.BackColor = Color.Transparent;
            label88.Font = labelFont;
            label88.ForeColor = foreColor;
            label88.Margin = labelMargin;
            // label88.TabIndex = 10069;

            panel48 = WinFormHelpers.CreatePanel("panel48", new Point(3, 231), new Size(417, 35));
            panel48.BackColor = btnBackColor;
            panel48.Margin = btnPanelMargin;
            // panel48.TabIndex = 10070;

            label87 = WinFormHelpers.CreateLabel("label87", "Genre", new Point(4, 6), new Size(141, 25));
            label87.BackColor = Color.Transparent;
            label87.Font = labelFont;
            label87.ForeColor = foreColor;
            label87.Margin = labelMargin;
            // label87.TabIndex = 10069;

            panel30 = WinFormHelpers.CreatePanel("panel30", new Point(3, 62), new Size(417, 35));
            panel30.BackColor = panelBackColor;
            panel30.Margin = btnPanelMargin;
            // panel30.TabIndex = 10079;

            label63 = WinFormHelpers.CreateLabel("label63", "Field", new Point(4, 5), new Size(75, 25));
            label63.BackColor = Color.Transparent;
            label63.Font = labelFont;
            label63.ForeColor = lightGrayColor;
            label63.Margin = labelMargin;
            // label63.TabIndex = 10071;

            label64 = WinFormHelpers.CreateLabel("label64", "Display Text", new Point(170, 5), new Size(153, 25));
            label64.BackColor = Color.Transparent;
            label64.Font = labelFont;
            label64.ForeColor = lightGrayColor;
            label64.Margin = labelMargin;
            // label64.TabIndex = 10073;

            label65 = WinFormHelpers.CreateLabel("label65", "Enabled", new Point(332, 5), new Size(92, 25));
            label65.BackColor = Color.Transparent;
            label65.Font = labelFont;
            label65.ForeColor = lightGrayColor;
            label65.Margin = labelMargin;
            // label65.TabIndex = 10072;

            label66 = WinFormHelpers.CreateLabel("label66", "Field Overrides", new Point(4, 5), new Size(285, 40));
            label66.BackColor = Color.Transparent;
            label66.Font = windowSettingsFont;
            label66.ForeColor = foreColor;
            label66.Margin = labelMargin;
            // label66.TabIndex = 10069;

            pictureBox7 = WinFormHelpers.CreatePictureBox("pictureBox7", null, new Point(3, 49), width: 412, height: 3);
            pictureBox7.BackColor = foreColor;
            pictureBox7.Margin = btnPanelMargin;
            // pictureBox7.TabIndex = 10070;
            pictureBox7.TabStop = false;

            panel31 = WinFormHelpers.CreatePanel("panel31", new Point(3, 95), new Size(417, 35));
            panel31.BackColor = btnBackColor;
            panel31.Margin = btnPanelMargin;
            // panel31.TabIndex = 10061;

            label67 = WinFormHelpers.CreateLabel("label67", "Title", new Point(4, 5), new Size(141, 25));
            label67.BackColor = Color.Transparent;
            label67.Font = labelFont;
            label67.ForeColor = foreColor;
            label67.Margin = labelMargin;
            // label67.TabIndex = 10066;

            panel32 = WinFormHelpers.CreatePanel("panel32", new Point(3, 197), new Size(417, 35));
            panel32.BackColor = panelBackColor;
            panel32.Margin = btnPanelMargin;
            // panel32.TabIndex = 10061;

            label68 = WinFormHelpers.CreateLabel("label68", "Console", new Point(4, 6), new Size(141, 25));
            label68.BackColor = Color.Transparent;
            label68.Font = labelFont;
            label68.ForeColor = foreColor;
            label68.Margin = labelMargin;
            // label68.TabIndex = 10069;

            panel33 = WinFormHelpers.CreatePanel("panel33", new Point(3, 163), new Size(417, 35));
            panel33.BackColor = btnBackColor;
            panel33.Margin = btnPanelMargin;
            // panel33.TabIndex = 10061;

            label69 = WinFormHelpers.CreateLabel("label69", "Publisher", new Point(4, 6), new Size(141, 25));
            label69.BackColor = Color.Transparent;
            label69.Font = labelFont;
            label69.ForeColor = foreColor;
            label69.Margin = labelMargin;
            // label69.TabIndex = 10068;

            panel34 = WinFormHelpers.CreatePanel("panel34", new Point(3, 129), new Size(417, 35));
            panel34.BackColor = panelBackColor;
            panel34.Margin = btnPanelMargin;
            // panel34.TabIndex = 10061;

            label70 = WinFormHelpers.CreateLabel("label70", "Developer", new Point(4, 6), new Size(141, 25));
            label70.BackColor = Color.Transparent;
            label70.Font = labelFont;
            label70.ForeColor = foreColor;
            label70.Margin = labelMargin;
            // label70.TabIndex = 10067;

            panel35 = WinFormHelpers.CreatePanel("panel35", new Point(444, 5), new Size(702, 271));
            panel35.BackColor = panelBackColor;
            panel35.Margin = btnPanelMargin;
            // panel35.TabIndex = 10079;

            label71 = WinFormHelpers.CreateLabel("label71", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label71.BackColor = Color.Transparent;
            label71.Font = windowSettingsFont;
            label71.ForeColor = foreColor;
            label71.Margin = labelMargin;
            // label71.TabIndex = 10062;

            panel42 = WinFormHelpers.CreatePanel("panel42", new Point(3, 62), new Size(694, 35));
            panel42.BackColor = panelBackColor;
            panel42.Margin = btnPanelMargin;
            // panel42.TabIndex = 10076;

            label78 = WinFormHelpers.CreateLabel("label78", "Color", new Point(225, 5), new Size(72, 25));
            label78.BackColor = Color.Transparent;
            label78.Font = labelFont;
            label78.ForeColor = lightGrayColor;
            label78.Margin = labelMargin;
            // label78.TabIndex = 10065;

            label79 = WinFormHelpers.CreateLabel("label79", "Font", new Point(291, 5), new Size(75, 25));
            label79.BackColor = Color.Transparent;
            label79.Font = labelFont;
            label79.ForeColor = lightGrayColor;
            label79.Margin = labelMargin;
            // label79.TabIndex = 10066;

            label80 = WinFormHelpers.CreateLabel("label80", "Size", new Point(524, 5), new Size(62, 25));
            label80.BackColor = Color.Transparent;
            label80.Font = labelFont;
            label80.ForeColor = lightGrayColor;
            label80.Margin = labelMargin;
            // label80.TabIndex = 10068;

            label81 = WinFormHelpers.CreateLabel("label81", "Enabled", new Point(594, 5), new Size(88, 25));
            label81.BackColor = Color.Transparent;
            label81.Font = labelFont;
            label81.ForeColor = lightGrayColor;
            label81.Margin = labelMargin;
            // label81.TabIndex = 10067;

            label82 = WinFormHelpers.CreateLabel("label82", "Values", new Point(4, 6), new Size(216, 25));
            label82.BackColor = Color.Transparent;
            label82.Font = labelFont;
            label82.ForeColor = foreColor;
            label82.Margin = labelMargin;
            // label82.TabIndex = 10066;

            pictureBox9 = WinFormHelpers.CreatePictureBox("pictureBox9", null, new Point(3, 49), width: 690, height: 3);
            pictureBox9.BackColor = foreColor;
            pictureBox9.Margin = btnPanelMargin;
            // pictureBox9.TabIndex = 10063;
            pictureBox9.TabStop = false;

            panel44 = WinFormHelpers.CreatePanel("panel44", new Point(3, 95), new Size(694, 35));
            panel44.BackColor = btnBackColor;
            panel44.Margin = btnPanelMargin;
            // panel44.TabIndex = 10061;

            label83 = WinFormHelpers.CreateLabel("label83", "Window Background", new Point(4, 5), new Size(216, 25));
            label83.BackColor = Color.Transparent;
            label83.Font = labelFont;
            label83.ForeColor = foreColor;
            label83.Margin = labelMargin;
            // label83.TabIndex = 10064;

            panel45 = WinFormHelpers.CreatePanel("panel45", new Point(3, 129), new Size(694, 35));
            panel45.BackColor = panelBackColor;
            panel45.Margin = btnPanelMargin;
            // panel45.TabIndex = 10061;

            panel46 = WinFormHelpers.CreatePanel("panel46", new Point(3, 197), new Size(694, 35));
            panel46.BackColor = panelBackColor;
            panel46.Margin = btnPanelMargin;
            // panel46.TabIndex = 10061;

            label86 = WinFormHelpers.CreateLabel("label86", "Values OutlineColor", new Point(4, 6), new Size(216, 25));
            label86.BackColor = Color.Transparent;
            label86.Font = labelFont;
            label86.ForeColor = foreColor;
            label86.Margin = labelMargin;
            // label86.TabIndex = 10066;

            panel28 = WinFormHelpers.CreatePanel("panel28", new Point(444, 283), new Size(702, 278));
            panel28.BackColor = panelBackColor;
            panel28.Margin = btnPanelMargin;
            // panel28.TabIndex = 10082;

            pictureBox21 = WinFormHelpers.CreatePictureBox("pictureBox21", null, new Point(375, 200), width: 316, height: 46);
            pictureBox21.BackColor = Color.Transparent;
            pictureBox21.Image = global::Retro_Achievement_Tracker.Properties.Resources.progression_meter;
            pictureBox21.Margin = btnPanelMargin;
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox21.TabIndex = 10067;
            pictureBox21.TabStop = false;

            label60 = WinFormHelpers.CreateLabel("label60", "points.", new Point(550, 63), new Size(81, 25));
            label60.BackColor = Color.Transparent;
            label60.Font = new Font("Verdana", 9.75F);
            label60.ForeColor = foreColor;
            label60.Margin = labelMargin;
            // label60.TabIndex = 10065;

            label59 = WinFormHelpers.CreateLabel("label59", "achievements worth", new Point(160, 63), new Size(216, 25));
            label59.AutoSize = true;
            label59.BackColor = Color.Transparent;
            label59.Font = new Font("Verdana", 9.75F);
            label59.ForeColor = foreColor;
            label59.Margin = labelMargin;
            // label59.TabIndex = 10064;

            label58 = WinFormHelpers.CreateLabel("label58", "There are", new Point(4, 63), new Size(110, 25));
            label58.AutoSize = true;
            label58.BackColor = Color.Transparent;
            label58.Font = new Font("Verdana", 9.75F);
            label58.ForeColor = foreColor;
            label58.Margin = labelMargin;
            // label58.TabIndex = 10063;

            label56 = WinFormHelpers.CreateLabel("label56", "Achievements", new Point(4, 5), new Size(288, 40));
            label56.BackColor = Color.Transparent;
            label56.Font = windowSettingsFont;
            label56.ForeColor = foreColor;
            label56.Margin = labelMargin;
            // label56.TabIndex = 10058;

            pictureBox5 = WinFormHelpers.CreatePictureBox("pictureBox5", null, new Point(3, 49), width: 690, height: 3);
            pictureBox5.BackColor = foreColor;
            pictureBox5.Margin = btnPanelMargin;
            // pictureBox5.TabIndex = 10059;
            pictureBox5.TabStop = false;

            panel15 = WinFormHelpers.CreatePanel("panel15", new Point(444, 5), new Size(702, 271));
            panel15.BackColor = panelBackColor;
            panel15.Margin = btnPanelMargin;
            // panel15.TabIndex = 10081;

            label38 = WinFormHelpers.CreateLabel("label38", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label38.BackColor = Color.Transparent;
            label38.Font = windowSettingsFont;
            label38.ForeColor = foreColor;
            label38.Margin = labelMargin;
            // label38.TabIndex = 10062;

            panel16 = WinFormHelpers.CreatePanel("panel16", new Point(3, 62), new Size(694, 35));
            panel16.BackColor = panelBackColor;
            panel16.Margin = btnPanelMargin;
            // panel16.TabIndex = 10076;

            label41 = WinFormHelpers.CreateLabel("label41", "Color", new Point(225, 5), new Size(72, 25));
            label41.BackColor = Color.Transparent;
            label41.Font = labelFont;
            label41.ForeColor = lightGrayColor;
            label41.Margin = labelMargin;
            // label41.TabIndex = 10065;

            label43 = WinFormHelpers.CreateLabel("label43", "Font", new Point(291, 5), new Size(75, 25));
            label43.BackColor = Color.Transparent;
            label43.Font = labelFont;
            label43.ForeColor = lightGrayColor;
            label43.Margin = labelMargin;
            // label43.TabIndex = 10066;

            label44 = WinFormHelpers.CreateLabel("label44", "Size", new Point(524, 5), new Size(62, 25));
            label44.BackColor = Color.Transparent;
            label44.Font = labelFont;
            label44.ForeColor = lightGrayColor;
            label44.Margin = labelMargin;
            // label44.TabIndex = 10068;

            label45 = WinFormHelpers.CreateLabel("label45", "Enabled", new Point(594, 5), new Size(88, 25));
            label45.BackColor = Color.Transparent;
            label45.Font = labelFont;
            label45.ForeColor = lightGrayColor;
            label45.Margin = labelMargin;
            // label45.TabIndex = 10067;

            label46 = WinFormHelpers.CreateLabel("label46", "Values", new Point(4, 6), new Size(216, 25));
            label46.BackColor = Color.Transparent;
            label46.Font = labelFont;
            label46.ForeColor = foreColor;
            label46.Margin = labelMargin;
            // label46.TabIndex = 10066;

            pictureBox6 = WinFormHelpers.CreatePictureBox("pictureBox6", null, new Point(3, 49), width: 690, height: 3);
            pictureBox6.BackColor = foreColor;
            pictureBox6.Margin = btnPanelMargin;
            // pictureBox6.TabIndex = 10063;
            pictureBox6.TabStop = false;

            panel18 = WinFormHelpers.CreatePanel("panel18", new Point(3, 95), new Size(694, 35));
            panel18.BackColor = btnBackColor;

            panel18.Margin = btnPanelMargin;
            // panel18.TabIndex = 10061;

            label47 = WinFormHelpers.CreateLabel("label47", "Window Background", new Point(4, 5), new Size(216, 25));
            label47.BackColor = Color.Transparent;
            label47.Font = labelFont;
            label47.ForeColor = foreColor;
            label47.Margin = labelMargin;
            // label47.TabIndex = 10064;

            panel19 = WinFormHelpers.CreatePanel("panel19", new Point(3, 129), new Size(694, 35));
            panel19.BackColor = panelBackColor;
            panel19.Margin = btnPanelMargin;
            // panel19.TabIndex = 10061;

            panel23 = WinFormHelpers.CreatePanel("panel23", new Point(3, 197), new Size(694, 35));
            panel23.BackColor = panelBackColor;


            panel23.Margin = btnPanelMargin;
            // panel23.TabIndex = 10061;

            label50 = WinFormHelpers.CreateLabel("label50", "Values OutlineColor", new Point(4, 6), new Size(216, 25));
            label50.BackColor = Color.Transparent;
            label50.Font = labelFont;
            label50.ForeColor = foreColor;
            label50.Margin = labelMargin;
            // label50.TabIndex = 10066;

            panel36 = WinFormHelpers.CreatePanel("panel36", new Point(6, 5), new Size(430, 342));
            panel36.BackColor = Color.FromArgb(36, 36, 36);
            panel36.Margin = btnPanelMargin;
            // panel36.TabIndex = 10080;

            panel27 = WinFormHelpers.CreatePanel("panel27", new Point(3, 298), new Size(417, 35));
            panel27.BackColor = btnBackColor;
            panel27.Margin = btnPanelMargin;
            // panel27.TabIndex = 10073;

            label55 = WinFormHelpers.CreateLabel("label55", ".", new Point(346, 6), new Size(22, 25));
            label55.BackColor = Color.Transparent;
            label55.Font = labelFont;
            label55.ForeColor = foreColor;
            label55.Margin = labelMargin;
            // label55.TabIndex = 10074;

            label54 = WinFormHelpers.CreateLabel("label54", ":", new Point(264, 6), new Size(22, 25));
            label54.BackColor = Color.Transparent;
            label54.Font = labelFont;
            label54.ForeColor = foreColor;
            label54.Margin = labelMargin;
            // label54.TabIndex = 10072;

            label53 = WinFormHelpers.CreateLabel("label53", "/", new Point(177, 6), new Size(22, 25));
            label53.BackColor = Color.Transparent;
            label53.Font = labelFont;
            label53.ForeColor = foreColor;
            label53.Margin = labelMargin;
            // label53.TabIndex = 10070;

            label51 = WinFormHelpers.CreateLabel("label51", "Separator", new Point(4, 6), new Size(141, 25));
            label51.BackColor = Color.Transparent;
            label51.Font = labelFont;
            label51.ForeColor = foreColor;
            label51.Margin = labelMargin;
            // label51.TabIndex = 10069;

            panel25 = WinFormHelpers.CreatePanel("panel25", new Point(3, 265), new Size(417, 35));
            panel25.BackColor = panelBackColor;
            panel25.Margin = btnPanelMargin;
            // panel25.TabIndex = 10072;

            panel37 = WinFormHelpers.CreatePanel("panel37", new Point(3, 62), new Size(417, 35));
            panel37.BackColor = panelBackColor;
            panel37.Margin = btnPanelMargin;
            // panel37.TabIndex = 10079;

            label39 = WinFormHelpers.CreateLabel("label39", "Field", new Point(4, 5), new Size(75, 25));
            label39.BackColor = Color.Transparent;
            label39.Font = labelFont;
            label39.ForeColor = lightGrayColor;
            label39.Margin = labelMargin;
            // label39.TabIndex = 10071;

            label40 = WinFormHelpers.CreateLabel("label40", "Display Text", new Point(170, 5), new Size(153, 25));
            label40.BackColor = Color.Transparent;
            label40.Font = labelFont;
            label40.ForeColor = lightGrayColor;
            label40.Margin = labelMargin;
            // label40.TabIndex = 10073;

            label72 = WinFormHelpers.CreateLabel("label72", "Enabled", new Point(332, 5), new Size(92, 25));
            label72.BackColor = Color.Transparent;
            label72.Font = labelFont;
            label72.ForeColor = lightGrayColor;
            label72.Margin = labelMargin;
            // label72.TabIndex = 10072;

            panel26 = WinFormHelpers.CreatePanel("panel26", new Point(3, 231), new Size(417, 35));
            panel26.BackColor = btnBackColor;
            panel26.Margin = btnPanelMargin;
            // panel26.TabIndex = 10071;

            label52 = WinFormHelpers.CreateLabel("label52", "Completed", new Point(4, 6), new Size(141, 25));
            label52.BackColor = Color.Transparent;
            label52.Font = labelFont;
            label52.ForeColor = foreColor;
            label52.Margin = labelMargin;
            // label52.TabIndex = 10068;

            label73 = WinFormHelpers.CreateLabel("label73", "Field Overrides", new Point(4, 5), new Size(285, 40));
            label73.BackColor = Color.Transparent;
            label73.Font = windowSettingsFont;
            label73.ForeColor = foreColor;
            label73.Margin = labelMargin;
            // label73.TabIndex = 10069;

            pictureBox17 = WinFormHelpers.CreatePictureBox("pictureBox17", null, new Point(3, 49), width: 412, height: 3);
            pictureBox17.BackColor = foreColor;
            pictureBox17.Margin = btnPanelMargin;
            // pictureBox17.TabIndex = 10070;
            pictureBox17.TabStop = false;

            panel38 = WinFormHelpers.CreatePanel("panel38", new Point(3, 95), new Size(417, 35));
            panel38.BackColor = btnBackColor;
            panel38.Margin = btnPanelMargin;
            // panel38.TabIndex = 10061;

            label74 = WinFormHelpers.CreateLabel("label74", "Achievements", new Point(4, 5), new Size(168, 25));
            label74.BackColor = Color.Transparent;
            label74.Font = labelFont;
            label74.ForeColor = foreColor;
            label74.Margin = labelMargin;
            // label74.TabIndex = 10066;

            panel39 = WinFormHelpers.CreatePanel("panel39", new Point(3, 197), new Size(417, 35));
            panel39.BackColor = panelBackColor;
            panel39.Margin = btnPanelMargin;
            // panel39.TabIndex = 10061;

            label75 = WinFormHelpers.CreateLabel("label75", "Retro Ratio", new Point(4, 6), new Size(141, 25));
            label75.BackColor = Color.Transparent;
            label75.Font = labelFont;
            label75.ForeColor = foreColor;
            label75.Margin = labelMargin;
            // label75.TabIndex = 10069;

            panel40 = WinFormHelpers.CreatePanel("panel40", new Point(3, 163), new Size(417, 35));
            panel40.BackColor = btnBackColor;
            panel40.Margin = btnPanelMargin;
            // panel40.TabIndex = 10061;

            label76 = WinFormHelpers.CreateLabel("label76", "True Points", new Point(4, 6), new Size(141, 25));
            label76.BackColor = Color.Transparent;
            label76.Font = labelFont;
            label76.ForeColor = foreColor;
            label76.Margin = labelMargin;
            // label76.TabIndex = 10068;

            panel41 = WinFormHelpers.CreatePanel("panel41", new Point(3, 129), new Size(417, 35));
            panel41.BackColor = panelBackColor;
            panel41.Margin = btnPanelMargin;
            // panel41.TabIndex = 10061;

            label77 = WinFormHelpers.CreateLabel("label77", "Points", new Point(4, 6), new Size(141, 25));
            label77.BackColor = Color.Transparent;
            label77.Font = labelFont;
            label77.ForeColor = foreColor;
            label77.Margin = labelMargin;
            // label77.TabIndex = 10067;

            panel113 = WinFormHelpers.CreatePanel("panel113", new Point(6, 5), new Size(434, 98));
            panel113.BackColor = panelBackColor;
            panel113.Margin = btnPanelMargin;
            // panel113.TabIndex = 10083;

            label155 = WinFormHelpers.CreateLabel("label155", "List Settings", new Point(4, 5), new Size(285, 40));
            label155.BackColor = Color.Transparent;
            label155.Font = windowSettingsFont;
            label155.ForeColor = foreColor;
            label155.Margin = labelMargin;
            // label155.TabIndex = 10069;

            pictureBox15 = WinFormHelpers.CreatePictureBox("pictureBox15", null, new Point(3, 49), width: 412, height: 3);
            pictureBox15.BackColor = foreColor;
            pictureBox15.Margin = btnPanelMargin;
            // pictureBox15.TabIndex = 10070;
            pictureBox15.TabStop = false;

            panel99 = WinFormHelpers.CreatePanel("panel99", new Point(444, 5), new Size(702, 438));
            panel99.BackColor = panelBackColor;
            panel99.Margin = btnPanelMargin;
            // panel99.TabIndex = 10082;

            label16 = WinFormHelpers.CreateLabel("label16", "Line", new Point(4, 6), new Size(216, 25));
            label16.BackColor = Color.Transparent;
            label16.Font = labelFont;
            label16.ForeColor = foreColor;
            label16.Margin = labelMargin;
            // label16.TabIndex = 10066;

            label17 = WinFormHelpers.CreateLabel("label17", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label17.BackColor = Color.Transparent;
            label17.Font = windowSettingsFont;
            label17.ForeColor = foreColor;
            label17.Margin = labelMargin;
            // label17.TabIndex = 10062;

            panel101 = WinFormHelpers.CreatePanel("panel101", new Point(3, 129), new Size(694, 35));
            panel101.BackColor = panelBackColor;
            panel101.Margin = btnPanelMargin;
            // panel101.TabIndex = 10069;

            label18 = WinFormHelpers.CreateLabel("label18", "Border", new Point(4, 5), new Size(216, 25));
            label18.BackColor = Color.Transparent;
            label18.Font = labelFont;
            label18.ForeColor = foreColor;
            label18.Margin = labelMargin;
            // label18.TabIndex = 10064;

            label19 = WinFormHelpers.CreateLabel("label19", "Points", new Point(4, 6), new Size(216, 25));
            label19.BackColor = Color.Transparent;
            label19.Font = labelFont;
            label19.ForeColor = foreColor;
            label19.Margin = labelMargin;
            // label19.TabIndex = 10065;

            panel103 = WinFormHelpers.CreatePanel("panel103", new Point(3, 62), new Size(694, 35));
            panel103.BackColor = panelBackColor;
            panel103.Margin = btnPanelMargin;
            // panel103.TabIndex = 10076;

            label20 = WinFormHelpers.CreateLabel("label20", "Color", new Point(225, 5), new Size(72, 25));
            label20.BackColor = Color.Transparent;
            label20.Font = labelFont;
            label20.ForeColor = lightGrayColor;
            label20.Margin = labelMargin;
            // label20.TabIndex = 10065;

            label21 = WinFormHelpers.CreateLabel("label21", "Font", new Point(291, 5), new Size(75, 25));
            label21.BackColor = Color.Transparent;
            label21.Font = labelFont;
            label21.ForeColor = lightGrayColor;
            label21.Margin = labelMargin;
            // label21.TabIndex = 10066;

            label22 = WinFormHelpers.CreateLabel("label22", "Size", new Point(524, 5), new Size(62, 25));
            label22.BackColor = Color.Transparent;
            label22.Font = labelFont;
            label22.ForeColor = lightGrayColor;
            label22.Margin = labelMargin;
            // label22.TabIndex = 10068;

            label23 = WinFormHelpers.CreateLabel("label23", "Enabled", new Point(594, 5), new Size(88, 25));
            label23.BackColor = Color.Transparent;
            label23.Font = labelFont;
            label23.ForeColor = lightGrayColor;
            label23.Margin = labelMargin;
            // label23.TabIndex = 10067;

            panel104 = WinFormHelpers.CreatePanel("panel104", new Point(3, 298), new Size(694, 35));
            panel104.BackColor = btnBackColor;
            panel104.Margin = btnPanelMargin;
            // panel104.TabIndex = 10071;

            label144 = WinFormHelpers.CreateLabel("label144", "Date OutlineColor", new Point(4, 6), new Size(216, 25));
            label144.BackColor = Color.Transparent;
            label144.Font = labelFont;
            label144.ForeColor = foreColor;
            label144.Margin = labelMargin;
            // label144.TabIndex = 10066;

            label145 = WinFormHelpers.CreateLabel("label145", "Date", new Point(4, 6), new Size(216, 25));
            label145.BackColor = Color.Transparent;
            label145.Font = labelFont;
            label145.ForeColor = foreColor;
            label145.Margin = labelMargin;
            // label145.TabIndex = 10066;

            pictureBox23 = WinFormHelpers.CreatePictureBox("pictureBox23", null, new Point(3, 49), width: 690, height: 3);
            pictureBox23.BackColor = foreColor;
            pictureBox23.Margin = btnPanelMargin;
            // pictureBox23.TabIndex = 10063;
            pictureBox23.TabStop = false;

            panel107 = WinFormHelpers.CreatePanel("panel107", new Point(3, 95), new Size(694, 35));
            panel107.BackColor = btnBackColor;
            panel107.Margin = btnPanelMargin;
            // panel107.TabIndex = 10061;

            label146 = WinFormHelpers.CreateLabel("label146", "Window Background", new Point(4, 5), new Size(216, 25));
            label146.BackColor = Color.Transparent;
            label146.Font = labelFont;
            label146.ForeColor = foreColor;
            label146.Margin = labelMargin;
            // label146.TabIndex = 10064;

            panel108 = WinFormHelpers.CreatePanel("panel108", new Point(3, 163), new Size(694, 35));
            panel108.BackColor = btnBackColor;
            panel108.Margin = btnPanelMargin;
            // panel108.TabIndex = 10061;

            label148 = WinFormHelpers.CreateLabel("label148", "Points OutlineColor", new Point(4, 5), new Size(216, 25));
            label148.BackColor = Color.Transparent;
            label148.Font = labelFont;
            label148.ForeColor = foreColor;
            label148.Margin = labelMargin;
            // label148.TabIndex = 10066;

            label149 = WinFormHelpers.CreateLabel("label149", "Line OutlineColor", new Point(4, 6), new Size(216, 25));
            label149.BackColor = Color.Transparent;
            label149.Font = labelFont;
            label149.ForeColor = foreColor;
            label149.Margin = labelMargin;
            // label149.TabIndex = 10066;

            panel115 = WinFormHelpers.CreatePanel("panel115", new Point(6, 5), new Size(434, 97));
            panel115.BackColor = panelBackColor;
            panel115.Margin = btnPanelMargin;
            // panel115.TabIndex = 10084;

            label152 = WinFormHelpers.CreateLabel("label152", "List Settings", new Point(4, 5), new Size(285, 40));
            label152.BackColor = Color.Transparent;
            label152.Font = windowSettingsFont;
            label152.ForeColor = foreColor;
            label152.Margin = labelMargin;
            // label152.TabIndex = 10069;

            pictureBox18 = WinFormHelpers.CreatePictureBox("pictureBox18", null, new Point(3, 49), width: 412, height: 3);
            pictureBox18.BackColor = foreColor;
            pictureBox18.Margin = btnPanelMargin;
            // pictureBox18.TabIndex = 10070;
            pictureBox18.TabStop = false;

            panel111 = WinFormHelpers.CreatePanel("panel111", new Point(444, 5), new Size(702, 176));
            panel111.BackColor = panelBackColor;
            panel111.Margin = btnPanelMargin;
            // panel111.TabIndex = 10082;

            panel9 = WinFormHelpers.CreatePanel("panel9", new Point(4, 133), new Size(693, 36));
            panel9.BackColor = btnBackColor;
            panel9.Margin = btnPanelMargin;
            // panel9.TabIndex = 10065;

            label150 = WinFormHelpers.CreateLabel("label150", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label150.BackColor = Color.Transparent;
            label150.Font = windowSettingsFont;
            label150.ForeColor = foreColor;
            label150.Margin = labelMargin;
            // label150.TabIndex = 10062;

            panel112 = WinFormHelpers.CreatePanel("panel112", new Point(3, 62), new Size(694, 35));
            panel112.BackColor = Color.FromArgb(36, 36, 36);
            panel112.Margin = btnPanelMargin;
            // panel112.TabIndex = 10076;

            label151 = WinFormHelpers.CreateLabel("label151", "Color", new Point(225, 5), new Size(72, 25));
            label151.BackColor = Color.Transparent;
            label151.Font = labelFont;
            label151.ForeColor = lightGrayColor;
            label151.Margin = labelMargin;
            // label151.TabIndex = 10065;

            pictureBox16 = WinFormHelpers.CreatePictureBox("pictureBox16", null, new Point(3, 49), width: 690, height: 3);
            pictureBox16.BackColor = foreColor;
            // pictureBox16.TabIndex = 10063;
            pictureBox16.TabStop = false;

            panel114 = WinFormHelpers.CreatePanel("panel114", new Point(3, 95), new Size(694, 35));
            panel114.BackColor = btnBackColor;

            panel114.Margin = btnPanelMargin;
            // panel114.TabIndex = 10061;

            label156 = WinFormHelpers.CreateLabel("label156", "Window Background", new Point(4, 5), new Size(216, 25));
            label156.BackColor = Color.Transparent;
            label156.Font = labelFont;
            label156.ForeColor = foreColor;
            label156.Margin = labelMargin;
            // label156.TabIndex = 10064;

            panel1 = WinFormHelpers.CreatePanel("panel1", new Point(564, 9), new Size(606, 147));
            panel1.BackColor = panelBackColor;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Margin = btnPanelMargin;
            // panel1.TabIndex = 10031;

            panel3 = WinFormHelpers.CreatePanel("panel3", new Point(4, 46), new Size(596, 43));
            panel3.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            panel3.BackColor = Color.FromArgb(30, 30, 30);

            panel3.Margin = btnPanelMargin;
            // panel3.TabIndex = 28;

            panel2 = WinFormHelpers.CreatePanel("panel2", new Point(4, 5), new Size(596, 43));
            panel2.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            panel2.BackColor = Color.FromArgb(35, 35, 35);

            panel2.Margin = btnPanelMargin;
            // panel2.TabIndex = 27;

            panel120 = WinFormHelpers.CreatePanel("panel120", new Point(6, 5), new Size(434, 226));
            panel120.BackColor = panelBackColor;
            panel120.Margin = btnPanelMargin;
            // panel120.TabIndex = 0;

            pictureBox19 = WinFormHelpers.CreatePictureBox("pictureBox19", null, new Point(3, 49), width: 412, height: 3);
            pictureBox19.BackColor = foreColor;
            pictureBox19.Margin = btnPanelMargin;
            // pictureBox19.TabIndex = 10071;
            pictureBox19.TabStop = false;

            label1 = WinFormHelpers.CreateLabel("label1", "RetroAchievements.org", new Point(4, 5), new Size(411, 40));
            label1.BackColor = Color.Transparent;
            label1.Font = windowSettingsFont;
            label1.ForeColor = foreColor;
            label1.Margin = labelMargin;
            // label1.TabIndex = 10063;

            panel121 = WinFormHelpers.CreatePanel("panel121", new Point(444, 5), new Size(702, 134));
            panel121.BackColor = panelBackColor;
            panel121.Margin = btnPanelMargin;
            // panel121.TabIndex = 10083;

            label90 = WinFormHelpers.CreateLabel("label90", "Window/Font Settings", new Point(4, 5), new Size(364, 40));
            label90.BackColor = Color.Transparent;
            label90.Font = windowSettingsFont;
            label90.ForeColor = foreColor;
            label90.Margin = labelMargin;
            // label90.TabIndex = 10062;

            panel122 = WinFormHelpers.CreatePanel("panel122", new Point(3, 62), new Size(694, 35));
            panel122.BackColor = Color.FromArgb(36, 36, 36);
            panel122.Margin = btnPanelMargin;
            // panel122.TabIndex = 10076;

            label91 = WinFormHelpers.CreateLabel("label91", "Color", new Point(225, 5), new Size(72, 25));
            label91.BackColor = Color.Transparent;
            label91.Font = labelFont;
            label91.ForeColor = lightGrayColor;
            label91.Margin = labelMargin;
            // label91.TabIndex = 10065;

            pictureBox22 = WinFormHelpers.CreatePictureBox("pictureBox22", null, new Point(3, 49), width: 690, height: 3);
            pictureBox22.BackColor = foreColor;
            pictureBox22.Margin = btnPanelMargin;
            // pictureBox22.TabIndex = 10063;
            pictureBox22.TabStop = false;

            panel123 = WinFormHelpers.CreatePanel("panel123", new Point(3, 95), new Size(694, 35));
            panel123.BackColor = btnBackColor;
            panel123.Margin = btnPanelMargin;
            // panel123.TabIndex = 10061;

            label92 = WinFormHelpers.CreateLabel("label92", "Window Background", new Point(4, 5), new Size(216, 25));
            label92.BackColor = Color.Transparent;
            label92.Font = labelFont;
            label92.ForeColor = foreColor;
            label92.Margin = labelMargin;
            // label92.TabIndex = 10064;

            panel124 = WinFormHelpers.CreatePanel("panel124", new Point(8, 240), new Size(434, 322));
            panel124.BackColor = panelBackColor;
            panel124.Margin = btnPanelMargin;
            // panel124.TabIndex = 10076;

            panel8 = WinFormHelpers.CreatePanel("panel8", new Point(190, 105), new Size(364, 52));
            panel8.BackColor = Color.FromArgb(46, 46, 46);
            panel8.Margin = btnPanelMargin;
            // panel8.TabIndex = 10037;

            panel78 = WinFormHelpers.CreatePanel("panel78", new Point(3, 62), new Size(408, 35));
            panel78.BackColor = panelBackColor;
            panel78.Margin = new Padding(4, 5, 4, 5);
            // panel78.TabIndex = 10079;

            panel79 = WinFormHelpers.CreatePanel("panel79", new Point(3, 95), new Size(408, 35));
            panel79.BackColor = btnBackColor;
            panel79.Margin = new Padding(4, 5, 4, 5);
            // panel79.TabIndex = 10061;

            panel80 = WinFormHelpers.CreatePanel("panel80", new Point(3, 197), new Size(408, 35));
            panel80.BackColor = panelBackColor;
            panel80.Margin = new Padding(4, 5, 4, 5);
            // panel80.TabIndex = 10061;

            panel81 = WinFormHelpers.CreatePanel("panel81", new Point(3, 163), new Size(408, 35));
            panel81.BackColor = btnBackColor;
            panel81.Margin = new Padding(4, 5, 4, 5);
            // panel81.TabIndex = 10061;

            panel82 = WinFormHelpers.CreatePanel("panel82", new Point(3, 129), new Size(408, 35));
            panel82.BackColor = panelBackColor;
            panel82.Margin = new Padding(4, 5, 4, 5);
            // panel82.TabIndex = 10061;

            panel83 = WinFormHelpers.CreatePanel("panel83", new Point(3, 231), new Size(408, 34));
            panel83.BackColor = btnBackColor;
            panel83.Margin = new Padding(4, 5, 4, 5);
            // panel83.TabIndex = 10070;

            panel84 = WinFormHelpers.CreatePanel("panel84", new Point(3, 265), new Size(408, 34));
            panel84.BackColor = panelBackColor;
            panel84.Margin = new Padding(4, 5, 4, 5);
            // panel84.TabIndex = 10071;

            panel85 = WinFormHelpers.CreatePanel("panel85", new Point(3, 366), new Size(408, 34));
            panel85.BackColor = btnBackColor;
            panel85.Margin = new Padding(4, 5, 4, 5);
            // panel85.TabIndex = 10074;

            panel86 = WinFormHelpers.CreatePanel("panel86", new Point(3, 332), new Size(408, 34));
            panel86.BackColor = panelBackColor;
            panel86.Margin = new Padding(4, 5, 4, 5);
            // panel86.TabIndex = 10073;

            panel87 = WinFormHelpers.CreatePanel("panel87", new Point(3, 298), new Size(408, 35));
            panel87.BackColor = btnBackColor;
            panel87.Margin = new Padding(4, 5, 4, 5);
            // panel87.TabIndex = 10072;

            panel89 = WinFormHelpers.CreatePanel("panel89", new Point(3, 366), new Size(408, 35));
            panel89.BackColor = btnBackColor;
            panel89.Margin = new Padding(4, 5, 4, 5);
            // panel89.TabIndex = 10074;

            panel90 = WinFormHelpers.CreatePanel("panel90", new Point(3, 265), new Size(408, 35));
            panel90.BackColor = panelBackColor;
            panel90.Margin = new Padding(4, 5, 4, 5);
            // panel90.TabIndex = 10071;

            panel91 = WinFormHelpers.CreatePanel("panel91", new Point(3, 332), new Size(408, 35));
            panel91.BackColor = panelBackColor;
            panel91.Margin = new Padding(4, 5, 4, 5);
            // panel91.TabIndex = 10073;

            panel92 = WinFormHelpers.CreatePanel("panel92", new Point(3, 231), new Size(408, 35));
            panel92.BackColor = btnBackColor;
            panel92.Margin = new Padding(4, 5, 4, 5);
            // panel92.TabIndex = 10070;

            panel93 = WinFormHelpers.CreatePanel("panel93", new Point(3, 298), new Size(408, 35));
            panel93.BackColor = btnBackColor;
            panel93.Margin = new Padding(4, 5, 4, 5);
            // panel93.TabIndex = 10072;

            panel94 = WinFormHelpers.CreatePanel("panel94", new Point(3, 62), new Size(408, 35));
            panel94.BackColor = panelBackColor;
            panel94.Margin = new Padding(4, 5, 4, 5);
            // panel94.TabIndex = 10079;

            autoFocusRulePanel.Controls.Add(auoFocusRuleLabel);
            autoFocusRulePanel.Controls.Add(focusTabPage.focusBehaviorGoToLastRadioButton);
            autoFocusRulePanel.Controls.Add(pictureBox12);
            autoFocusRulePanel.Controls.Add(focusTabPage.focusBehaviorGoToFirstRadioButton);
            autoFocusRulePanel.Controls.Add(focusTabPage.focusBehaviorGoToNextRadioButton);
            autoFocusRulePanel.Controls.Add(focusTabPage.focusBehaviorGoToPreviousRadioButton);
            panel63.Controls.Add(unlockAchievementButton);
            panel63.Controls.Add(currentAchievementLabel);
            panel63.Controls.Add(pictureBox10);
            panel63.Controls.Add(focusTabPage.focusAchievementPictureBox);
            panel63.Controls.Add(focusTabPage.focusAchievementButtonPrevious);
            panel63.Controls.Add(focusTabPage.focusAchievementButtonNext);
            panel63.Controls.Add(focusTabPage.focusAchievementDescriptionLabel);
            panel63.Controls.Add(focusTabPage.focusAchievementTitleLabel);
            panel63.Controls.Add(focusTabPage.focusSetButton);
            currentAchievementPanel.Controls.Add(focusTabPage.focusLinePanel);
            currentAchievementPanel.Controls.Add(focusWindowSettingsLabel);
            currentAchievementPanel.Controls.Add(panel59);
            currentAchievementPanel.Controls.Add(focusTabPage.focusPointsPanel);
            currentAchievementPanel.Controls.Add(panel52);
            currentAchievementPanel.Controls.Add(panel61);
            currentAchievementPanel.Controls.Add(focusTabPage.focusOpenWindowButton);
            currentAchievementPanel.Controls.Add(focusTabPage.focusDescriptionOutlinePanel);
            currentAchievementPanel.Controls.Add(focusTabPage.focusDescriptionPanel);
            currentAchievementPanel.Controls.Add(focusTabPage.focusAutoOpenWindowCheckBox);
            currentAchievementPanel.Controls.Add(pictureBox11);
            currentAchievementPanel.Controls.Add(panel54);
            currentAchievementPanel.Controls.Add(panel55);
            currentAchievementPanel.Controls.Add(focusTabPage.focusPointsOutlinePanel);
            currentAchievementPanel.Controls.Add(focusTabPage.focusLineOutlinePanel);
            panel59.Controls.Add(focusTabPage.focusBorderCheckBox);
            panel59.Controls.Add(focusTabPage.focusBorderColorPictureBox);
            panel59.Controls.Add(label107);
            panel52.Controls.Add(focusTabPage.focusAdvancedCheckBox);
            panel52.Controls.Add(label97);
            panel52.Controls.Add(label98);
            panel52.Controls.Add(label99);
            panel52.Controls.Add(label100);
            panel61.Controls.Add(focusTabPage.focusTitleFontOutlineNumericUpDown);
            panel61.Controls.Add(focusTabPage.focusTitleOutlineCheckBox);
            panel61.Controls.Add(focusTabPage.focusTitleOutlineLabel);
            panel61.Controls.Add(focusTabPage.focusTitleFontOutlineColorPictureBox);
            panel54.Controls.Add(focusTabPage.focusBackgroundColorPictureBox);
            panel54.Controls.Add(label102);
            panel55.Controls.Add(focusTabPage.focusTitleLabel);
            panel55.Controls.Add(focusTabPage.focusTitleFontColorPictureBox);
            panel55.Controls.Add(focusTabPage.focusTitleFontComboBox);
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
            panel67.Controls.Add(alertsTabPage.alertsBorderCheckBox);
            panel67.Controls.Add(alertsTabPage.alertsBorderColorPictureBox);
            panel67.Controls.Add(label115);
            panel69.Controls.Add(alertsTabPage.alertsAdvancedCheckBox);
            panel69.Controls.Add(label117);
            panel69.Controls.Add(label118);
            panel69.Controls.Add(label119);
            panel69.Controls.Add(label120);
            panel70.Controls.Add(alertsTabPage.alertsTitleFontOutlineNumericUpDown);
            panel70.Controls.Add(alertsTabPage.alertsTitleOutlineCheckBox);
            panel70.Controls.Add(alertsTabPage.alertsTitleOutlineLabel);
            panel70.Controls.Add(alertsTabPage.alertsTitleFontOutlineColorPictureBox);
            panel73.Controls.Add(alertsTabPage.alertsBackgroundColorPictureBox);
            panel73.Controls.Add(label124);
            panel74.Controls.Add(alertsTabPage.alertsTitleLabel);
            panel74.Controls.Add(alertsTabPage.alertsTitleFontColorPictureBox);
            panel74.Controls.Add(alertsTabPage.alertsTitleFontComboBox);
            panel95.Controls.Add(label140);
            panel95.Controls.Add(alertsTabPage.alertsCustomMasteryXNumericUpDown);
            panel96.Controls.Add(label141);
            panel96.Controls.Add(alertsTabPage.alertsCustomMasteryInNumericUpDown);
            panel97.Controls.Add(label142);
            panel97.Controls.Add(alertsTabPage.alertsCustomMasteryScaleNumericUpDown);
            panel98.Controls.Add(label143);
            panel98.Controls.Add(alertsTabPage.alertsCustomMasteryYNumericUpDown);
            panel14.Controls.Add(userInfoTabPage.userInfoUsernameLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoRankLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoPointsLabel);
            panel14.Controls.Add(label37);
            panel14.Controls.Add(userInfoTabPage.userInfoTruePointsLabel);
            panel14.Controls.Add(userProfilePictureBox);
            panel14.Controls.Add(userInfoTabPage.userInfoMottoLabel);
            panel14.Controls.Add(userInfoTabPage.userInfoRatioLabel);
            panel14.Controls.Add(pictureBox2);
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(label28);
            panel21.Controls.Add(userInfoTabPage.userInfoDefaultButton);
            panel21.Controls.Add(pictureBox4);
            panel21.Controls.Add(panel10);
            panel21.Controls.Add(panel13);
            panel21.Controls.Add(panel12);
            panel21.Controls.Add(panel11);
            panel22.Controls.Add(label29);
            panel22.Controls.Add(label32);
            panel22.Controls.Add(label30);
            panel10.Controls.Add(label31);
            panel10.Controls.Add(userInfoTabPage.userInfoRankCheckBox);
            panel10.Controls.Add(userInfoTabPage.userInfoRankTextBox);
            panel13.Controls.Add(label35);
            panel13.Controls.Add(userInfoTabPage.userInfoRatioCheckBox);
            panel13.Controls.Add(userInfoTabPage.userInfoRatioTextBox);
            panel12.Controls.Add(label34);
            panel12.Controls.Add(userInfoTabPage.userInfoTruePointsTextBox);
            panel12.Controls.Add(userInfoTabPage.userInfoTruePointsCheckBox);
            panel11.Controls.Add(label33);
            panel11.Controls.Add(userInfoTabPage.userInfoPointsTextBox);
            panel11.Controls.Add(userInfoTabPage.userInfoPointsCheckBox);
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
            panel4.Controls.Add(userInfoTabPage.userInfoAdvancedCheckBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label15);
            panel5.Controls.Add(userInfoTabPage.userInfoBackgroundColorPictureBox);
            panel5.Controls.Add(label3);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesLabel);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesFontColorPictureBox);
            panel6.Controls.Add(userInfoTabPage.userInfoNamesFontComboBox);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesOutlineCheckBox);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesOutlineLabel);
            panel7.Controls.Add(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox);
            panel50.Controls.Add(panel119);
            panel50.Controls.Add(panel117);
            panel50.Controls.Add(panel118);
            panel50.Controls.Add(panel116);
            panel50.Controls.Add(gameInfoTabPage.gameInfoTitleLabel);
            panel50.Controls.Add(pictureBox8);
            panel50.Controls.Add(gameInfoTabPage.gameInfoPictureBox);
            panel119.Controls.Add(gameInfoTabPage.gameInfoGenreLabel);
            panel119.Controls.Add(label62);
            panel119.Controls.Add(label36);
            panel117.Controls.Add(label89);
            panel117.Controls.Add(gameInfoTabPage.gameInfoReleasedLabel);
            panel118.Controls.Add(label61);
            panel118.Controls.Add(gameInfoTabPage.gameInfoPublisherLabel);
            panel116.Controls.Add(label57);
            panel116.Controls.Add(gameInfoTabPage.gameInfoDeveloperLabel);
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
            panel49.Controls.Add(label88);
            panel49.Controls.Add(gameInfoTabPage.gameInfoReleasedCheckBox);
            panel49.Controls.Add(gameInfoTabPage.gameInfoReleaseDateTextBox);
            panel48.Controls.Add(label87);
            panel48.Controls.Add(gameInfoTabPage.gameInfoGenreCheckBox);
            panel48.Controls.Add(gameInfoTabPage.gameInfoGenreTextBox);
            panel30.Controls.Add(label63);
            panel30.Controls.Add(label64);
            panel30.Controls.Add(label65);
            panel31.Controls.Add(label67);
            panel31.Controls.Add(gameInfoTabPage.gameInfoTitleCheckBox);
            panel31.Controls.Add(gameInfoTabPage.gameInfoTitleTextBox);
            panel32.Controls.Add(label68);
            panel32.Controls.Add(gameInfoTabPage.gameInfoConsoleCheckBox);
            panel32.Controls.Add(gameInfoTabPage.gameInfoConsoleTextBox);
            panel33.Controls.Add(label69);
            panel33.Controls.Add(gameInfoTabPage.gameInfoPublisherTextBox);
            panel33.Controls.Add(gameInfoTabPage.gameInfoPublisherCheckBox);
            panel34.Controls.Add(label70);
            panel34.Controls.Add(gameInfoTabPage.gameInfoDeveloperTextBox);
            panel34.Controls.Add(gameInfoTabPage.gameInfoDeveloperCheckBox);
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
            panel42.Controls.Add(gameInfoTabPage.gameInfoAdvancedCheckBox);
            panel42.Controls.Add(label78);
            panel42.Controls.Add(label79);
            panel42.Controls.Add(label80);
            panel42.Controls.Add(label81);
            panel44.Controls.Add(gameInfoTabPage.gameInfoBackgroundColorPictureBox);
            panel44.Controls.Add(label83);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesLabel);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesFontColorPictureBox);
            panel45.Controls.Add(gameInfoTabPage.gameInfoNamesFontComboBox);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesOutlineCheckBox);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesOutlineLabel);
            panel46.Controls.Add(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox);
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
            panel16.Controls.Add(gameProgressTabPage.gameProgressAdvancedCheckBox);
            panel16.Controls.Add(label41);
            panel16.Controls.Add(label43);
            panel16.Controls.Add(label44);
            panel16.Controls.Add(label45);
            panel18.Controls.Add(gameProgressTabPage.gameProgressBackgroundColorPictureBox);
            panel18.Controls.Add(label47);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesLabel);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesFontColorPictureBox);
            panel19.Controls.Add(gameProgressTabPage.gameProgressNamesFontComboBox);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesOutlineCheckBox);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesOutlineLabel);
            panel23.Controls.Add(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox);
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
            panel27.Controls.Add(label55);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonPeriod);
            panel27.Controls.Add(label54);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonColon);
            panel27.Controls.Add(label53);
            panel27.Controls.Add(gameProgressTabPage.gameProgressRadioButtonBackslash);
            panel27.Controls.Add(label51);
            panel37.Controls.Add(label39);
            panel37.Controls.Add(label40);
            panel37.Controls.Add(label72);
            panel26.Controls.Add(label52);
            panel26.Controls.Add(gameProgressTabPage.gameProgressCompletedTextBox);
            panel26.Controls.Add(gameProgressTabPage.gameProgressCompletedCheckBox);
            panel38.Controls.Add(label74);
            panel38.Controls.Add(gameProgressTabPage.gameProgressAchievementsCheckBox);
            panel38.Controls.Add(gameProgressTabPage.gameProgressAchievementsTextBox);
            panel39.Controls.Add(label75);
            panel39.Controls.Add(gameProgressTabPage.gameProgressRatioCheckBox);
            panel39.Controls.Add(gameProgressTabPage.gameProgressRatioTextBox);
            panel40.Controls.Add(label76);
            panel40.Controls.Add(gameProgressTabPage.gameProgressTruePointsTextBox);
            panel40.Controls.Add(gameProgressTabPage.gameProgressTruePointsCheckBox);
            panel41.Controls.Add(label77);
            panel41.Controls.Add(gameProgressTabPage.gameProgressPointsTextBox);
            panel41.Controls.Add(gameProgressTabPage.gameProgressPointsCheckBox);
            panel113.Controls.Add(label155);
            panel113.Controls.Add(pictureBox15);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsMaxListLabel);
            panel113.Controls.Add(recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox);
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
            panel101.Controls.Add(recentAchievementsTabPage.recentAchievementsBorderCheckBox);
            panel101.Controls.Add(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox);
            panel101.Controls.Add(label18);
            panel103.Controls.Add(recentAchievementsTabPage.recentAchievementsAdvancedCheckBox);
            panel103.Controls.Add(label20);
            panel103.Controls.Add(label21);
            panel103.Controls.Add(label22);
            panel103.Controls.Add(label23);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleOutlineLabel);
            panel104.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox);
            panel107.Controls.Add(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox);
            panel107.Controls.Add(label146);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleLabel);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox);
            panel108.Controls.Add(recentAchievementsTabPage.recentAchievementsTitleFontComboBox);
            panel115.Controls.Add(label152);
            panel115.Controls.Add(pictureBox18);
            panel115.Controls.Add(achievementsListTabPage.achievementListAutoScrollCheckBox);
            panel111.Controls.Add(panel9);
            panel111.Controls.Add(label150);
            panel111.Controls.Add(panel112);
            panel111.Controls.Add(achievementsListTabPage.achievementListOpenWindowButton);
            panel111.Controls.Add(achievementsListTabPage.achievementListAutoOpenWindowCheckbox);
            panel111.Controls.Add(pictureBox16);
            panel111.Controls.Add(panel114);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeLabel);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeXUpDown);
            panel9.Controls.Add(achievementsListTabPage.achievementListWindowSizeYUpDown);
            panel112.Controls.Add(label151);
            panel114.Controls.Add(achievementsListTabPage.achievementListBackgroundColorPictureBox);
            panel114.Controls.Add(label156);
            panel1.Controls.Add(checkForUpdatesButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(stopButton);
            panel1.Controls.Add(autoStartCheckbox);
            panel3.Controls.Add(apiKeyLabel);
            panel3.Controls.Add(apiKeyTextBox);
            panel2.Controls.Add(usernameLabel);
            panel2.Controls.Add(usernameTextBox);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRAScreenshotRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRABadgeIconRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRABoxArtRadioButton);
            panel120.Controls.Add(relatedMediaTabPage.relatedMediaRATitleScreenRadioButton);
            panel120.Controls.Add(pictureBox19);
            panel120.Controls.Add(label1);
            panel121.Controls.Add(label90);
            panel121.Controls.Add(panel122);
            panel121.Controls.Add(relatedMediaTabPage.relatedMediaOpenWindowButton);
            panel121.Controls.Add(relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox);
            panel121.Controls.Add(pictureBox22);
            panel121.Controls.Add(panel123);
            panel122.Controls.Add(label91);
            panel123.Controls.Add(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox);
            panel123.Controls.Add(label92);
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
            panel8.Controls.Add(manualSearchLabel);
            panel8.Controls.Add(manualSearchTextBox);
            panel8.Controls.Add(manualSearchButton);

            panel78.Controls.Add(label42);
            panel78.Controls.Add(label128);
            panel79.Controls.Add(label131);
            panel79.Controls.Add(alertsTabPage.alertsCustomAchievementXNumericUpDown);
            panel80.Controls.Add(label132);
            panel80.Controls.Add(alertsTabPage.alertsCustomAchievementInNumericUpDown);
            panel81.Controls.Add(label133);
            panel81.Controls.Add(alertsTabPage.alertsCustomAchievementScaleNumericUpDown);
            panel82.Controls.Add(label134);
            panel82.Controls.Add(alertsTabPage.alertsCustomAchievementYNumericUpDown);
            panel83.Controls.Add(label129);
            panel83.Controls.Add(alertsTabPage.alertsCustomAchievementInSpeedUpDown);
            panel84.Controls.Add(label135);
            panel84.Controls.Add(alertsTabPage.alertsCustomAchievementAnimationInComboBox);
            panel85.Controls.Add(label136);
            panel85.Controls.Add(alertsTabPage.alertsCustomAchievementAnimationOutComboBox);
            panel86.Controls.Add(label137);
            panel86.Controls.Add(alertsTabPage.alertsCustomAchievementOutSpeedUpDown);
            panel87.Controls.Add(label138);
            panel87.Controls.Add(alertsTabPage.alertsCustomAchievementOutNumericUpDown);
            panel89.Controls.Add(label6);
            panel89.Controls.Add(alertsTabPage.alertsCustomMasteryAnimationOutComboBox);
            panel90.Controls.Add(label7);
            panel90.Controls.Add(alertsTabPage.alertsCustomMasteryAnimationInComboBox);
            panel91.Controls.Add(label8);
            panel91.Controls.Add(alertsTabPage.alertsCustomMasteryOutSpeedUpDown);
            panel92.Controls.Add(label11);
            panel92.Controls.Add(alertsTabPage.alertsCustomMasteryInSpeedUpDown);
            panel93.Controls.Add(label12);
            panel93.Controls.Add(alertsTabPage.alertsCustomMasteryOutNumericUpDown);
            panel94.Controls.Add(label13);
            panel94.Controls.Add(label14);

//             ((ISupportInitialize)(userProfilePictureBox)).BeginInit();
//             ((ISupportInitialize)(focusTabPage.focusAchievementPictureBox)).BeginInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoPictureBox)).BeginInit();
//             ((ISupportInitialize)(autoPollingStatusPictureBox)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementScaleNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementXNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementYNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutSpeedUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInSpeedUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryScaleNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryXNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryYNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutSpeedUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInSpeedUpDown)).BeginInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown)).BeginInit();
//             autoFocusRulePanel.SuspendLayout();
//             ((ISupportInitialize)(pictureBox12)).BeginInit();
//             panel63.SuspendLayout();
//             ((ISupportInitialize)(pictureBox10)).BeginInit();
//             currentAchievementPanel.SuspendLayout();

//             ((ISupportInitialize)(focusTabPage.focusLineColorPictureBox)).BeginInit();
//             panel59.SuspendLayout();
//             ((ISupportInitialize)(focusTabPage.focusBorderColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(focusTabPage.focusPointsFontColorPictureBox)).BeginInit();
//             panel52.SuspendLayout();
//             panel61.SuspendLayout();
//             ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineNumericUpDown)).BeginInit();

//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox11)).BeginInit();
//             panel54.SuspendLayout();
//             ((ISupportInitialize)(focusTabPage.focusBackgroundColorPictureBox)).BeginInit();
//             panel55.SuspendLayout();
//             ((ISupportInitialize)(focusTabPage.focusTitleFontColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(focusTabPage.focusLineOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(focusTabPage.focusLineOutlineNumericUpDown)).BeginInit();
//             panel65.SuspendLayout();

//             ((ISupportInitialize)(alertsTabPage.alertsLineColorPictureBox)).BeginInit();
//             panel67.SuspendLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsBorderColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontColorPictureBox)).BeginInit();
//             panel69.SuspendLayout();
//             panel70.SuspendLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown)).BeginInit();

//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox20)).BeginInit();
//             panel73.SuspendLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsBackgroundColorPictureBox)).BeginInit();
//             panel74.SuspendLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(alertsTabPage.alertsLineOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(alertsTabPage.alertsLineOutlineNumericUpDown)).BeginInit();

//             panel85.SuspendLayout();
//             panel84.SuspendLayout();
//             panel86.SuspendLayout();
//             panel83.SuspendLayout();
//             panel87.SuspendLayout();
//             panel78.SuspendLayout();
//             ((ISupportInitialize)(pictureBox13)).BeginInit();
//             panel79.SuspendLayout();
//             panel80.SuspendLayout();
//             panel81.SuspendLayout();
//             panel82.SuspendLayout();

//             panel89.SuspendLayout();
//             panel90.SuspendLayout();
//             panel91.SuspendLayout();
//             panel92.SuspendLayout();
//             panel93.SuspendLayout();
//             panel94.SuspendLayout();
//             ((ISupportInitialize)(pictureBox14)).BeginInit();
//             panel95.SuspendLayout();
//             panel96.SuspendLayout();
//             panel97.SuspendLayout();
//             panel98.SuspendLayout();
//             panel14.SuspendLayout();
//             ((ISupportInitialize)(pictureBox2)).BeginInit();
//             panel21.SuspendLayout();
//             panel22.SuspendLayout();
//             ((ISupportInitialize)(pictureBox4)).BeginInit();
//             panel10.SuspendLayout();
//             panel13.SuspendLayout();
//             panel12.SuspendLayout();
//             panel11.SuspendLayout();
//             panel20.SuspendLayout();
//             panel4.SuspendLayout();

//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox3)).BeginInit();
//             panel5.SuspendLayout();
//             ((ISupportInitialize)(userInfoTabPage.userInfoBackgroundColorPictureBox)).BeginInit();
//             panel6.SuspendLayout();
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontColorPictureBox)).BeginInit();
//             panel7.SuspendLayout();
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown)).BeginInit();
//             panel50.SuspendLayout();
//             panel119.SuspendLayout();
//             panel117.SuspendLayout();
//             panel118.SuspendLayout();
//             panel116.SuspendLayout();
//             ((ISupportInitialize)(pictureBox8)).BeginInit();
//             panel29.SuspendLayout();
//             panel49.SuspendLayout();
//             panel48.SuspendLayout();
//             panel30.SuspendLayout();
//             ((ISupportInitialize)(pictureBox7)).BeginInit();
//             panel31.SuspendLayout();
//             panel32.SuspendLayout();
//             panel33.SuspendLayout();
//             panel34.SuspendLayout();
//             panel35.SuspendLayout();
//             panel42.SuspendLayout();

//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox9)).BeginInit();
//             panel44.SuspendLayout();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoBackgroundColorPictureBox)).BeginInit();
//             panel45.SuspendLayout();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontColorPictureBox)).BeginInit();
//             panel46.SuspendLayout();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown)).BeginInit();
//             panel28.SuspendLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressPercentCompletePictureBox)).BeginInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressMasteryPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox21)).BeginInit();
//             ((ISupportInitialize)(pictureBox5)).BeginInit();
//             panel15.SuspendLayout();
//             panel16.SuspendLayout();

//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox6)).BeginInit();
//             panel18.SuspendLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressBackgroundColorPictureBox)).BeginInit();
//             panel19.SuspendLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontColorPictureBox)).BeginInit();
//             panel23.SuspendLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown)).BeginInit();
//             panel36.SuspendLayout();
//             panel27.SuspendLayout();
//             panel37.SuspendLayout();
//             panel26.SuspendLayout();
//             ((ISupportInitialize)(pictureBox17)).BeginInit();
//             panel38.SuspendLayout();
//             panel39.SuspendLayout();
//             panel40.SuspendLayout();
//             panel41.SuspendLayout();
//             panel113.SuspendLayout();
//             ((ISupportInitialize)(pictureBox15)).BeginInit();
//             panel99.SuspendLayout();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineColorPictureBox)).BeginInit();
//             panel101.SuspendLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox)).BeginInit();
//             panel103.SuspendLayout();
//             panel104.SuspendLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown)).BeginInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(pictureBox23)).BeginInit();
//             panel107.SuspendLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox)).BeginInit();
//             panel108.SuspendLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown)).BeginInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox)).BeginInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox)).BeginInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown)).BeginInit();
//             panel115.SuspendLayout();
//             ((ISupportInitialize)(pictureBox18)).BeginInit();
//             panel111.SuspendLayout();
//             panel9.SuspendLayout();
//             ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeXUpDown)).BeginInit();
//             ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeYUpDown)).BeginInit();
//             panel112.SuspendLayout();
//             ((ISupportInitialize)(pictureBox16)).BeginInit();
//             panel114.SuspendLayout();
//             ((ISupportInitialize)(achievementsListTabPage.achievementListBackgroundColorPictureBox)).BeginInit();
//             panel1.SuspendLayout();
//             panel3.SuspendLayout();
//             panel2.SuspendLayout();
//             panel120.SuspendLayout();
//             ((ISupportInitialize)(pictureBox19)).BeginInit();
//             panel121.SuspendLayout();
//             panel122.SuspendLayout();
//             ((ISupportInitialize)(pictureBox22)).BeginInit();
//             panel123.SuspendLayout();
//             ((ISupportInitialize)(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox)).BeginInit();
//             panel124.SuspendLayout();
//             ((ISupportInitialize)(relatedMediaTabPage.relatedMediaLBLinePictureBox)).BeginInit();

//             mainTabControl.SuspendLayout();
//             focusTabPage.SuspendLayout();
//             alertsTabPage.SuspendLayout();
//             alertTabControl.SuspendLayout();
//             achievementTabPage.SuspendLayout();
//             masteryTabPage.SuspendLayout();
//             userInfoTabPage.SuspendLayout();
//             gameInfoTabPage.SuspendLayout();
//             gameProgressTabPage.SuspendLayout();
//             recentAchievementsTabPage.SuspendLayout();
//             achievementsListTabPage.SuspendLayout();
//             relatedMediaTabPage.SuspendLayout();
//             panel8.SuspendLayout();
//             SuspendLayout();

            mainTabControl = WinFormHelpers.CreateTabControl("mainTabControl", new Point(6, 166), new Size(1166, 612));
            mainTabControl.Appearance = TabAppearance.FlatButtons;
            mainTabControl.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTabControl.HotTrack = true;
            mainTabControl.Margin = btnPanelMargin;
            mainTabControl.SelectedIndex = 0;
            // mainTabControl.TabIndex = 10033;
            mainTabControl.Controls.Add(focusTabPage);
            mainTabControl.Controls.Add(alertsTabPage);
            mainTabControl.Controls.Add(userInfoTabPage);
            mainTabControl.Controls.Add(gameInfoTabPage);
            mainTabControl.Controls.Add(gameProgressTabPage);
            mainTabControl.Controls.Add(recentAchievementsTabPage);
            mainTabControl.Controls.Add(achievementsListTabPage);
            mainTabControl.Controls.Add(relatedMediaTabPage);

            focusTabPage.Controls.Add(autoFocusRulePanel);
            focusTabPage.Controls.Add(panel63);
            focusTabPage.Controls.Add(currentAchievementPanel);
            alertsTabPage.Controls.Add(alertTabControl);
            alertsTabPage.Controls.Add(panel65);

            alertTabControl = WinFormHelpers.CreateTabControl("alertTabControl", new Point(4, 5), new Size(438, 557));
            alertTabControl.Alignment = TabAlignment.Bottom;
            alertTabControl.Cursor = Cursors.Arrow;
            alertTabControl.HotTrack = true;
            alertTabControl.Margin = btnPanelMargin;
            alertTabControl.SelectedIndex = 0;
            // alertTabControl.TabIndex = 10082;
            alertTabControl.Controls.Add(achievementTabPage);
            alertTabControl.Controls.Add(masteryTabPage);

            achievementTabPage = WinFormHelpers.CreateTabPage("achievementTabPage", "Achievement", /*new Point(4, 4),*/ new Size(430, 524));
            achievementTabPage.BackColor = btnBackColor;
            achievementTabPage.Cursor = Cursors.Arrow;
            achievementTabPage.Margin = btnPanelMargin;
            achievementTabPage.Padding = btnPanelMargin;
            // achievementTabPage.TabIndex = 0;
            achievementTabPage.Controls.Add(alertsTabPage.alertsCustomAchievementPanel);
            achievementTabPage.Controls.Add(alertsTabPage.alertsAchievementEnableCheckbox);
            achievementTabPage.Controls.Add(alertsTabPage.alertsPlayAchievementButton);
            achievementTabPage.Controls.Add(alertsTabPage.alertsCustomAchievementEnableCheckbox);

            masteryTabPage = WinFormHelpers.CreateTabPage("masteryTabPage", "Mastery", /*new Point(4, 4),*/ new Size(430, 524));
            masteryTabPage.BackColor = btnBackColor;
            masteryTabPage.Margin = btnPanelMargin;
            masteryTabPage.Padding = btnPanelMargin;
            // masteryTabPage.TabIndex = 1;
            masteryTabPage.Controls.Add(alertsTabPage.alertsCustomMasteryPanel);
            masteryTabPage.Controls.Add(alertsTabPage.alertsMasteryEnableCheckbox);
            masteryTabPage.Controls.Add(alertsTabPage.alertsPlayMasteryButton);
            masteryTabPage.Controls.Add(alertsTabPage.alertsCustomMasteryEnableCheckbox);

            userInfoTabPage.Controls.Add(panel14);
            userInfoTabPage.Controls.Add(panel21);
            userInfoTabPage.Controls.Add(panel20);
            gameInfoTabPage.Controls.Add(panel50);
            gameInfoTabPage.Controls.Add(panel29);
            gameInfoTabPage.Controls.Add(panel35);
            gameProgressTabPage.Controls.Add(panel28);
            gameProgressTabPage.Controls.Add(panel36);
            gameProgressTabPage.Controls.Add(panel15);
            recentAchievementsTabPage.Controls.Add(panel113);
            recentAchievementsTabPage.Controls.Add(panel99);
            achievementsListTabPage.Controls.Add(panel111);
            achievementsListTabPage.Controls.Add(panel115);
            relatedMediaTabPage.Controls.Add(panel124);
            relatedMediaTabPage.Controls.Add(panel120);
            relatedMediaTabPage.Controls.Add(panel121);

            InitWindow(true);

            focusTabPage.focusLinePanel.Controls.Add(focusLineLabel);
            focusTabPage.focusLinePanel.Controls.Add(focusTabPage.focusLineColorPictureBox);
            focusTabPage.focusPointsPanel.Controls.Add(label108);
            focusTabPage.focusPointsPanel.Controls.Add(focusTabPage.focusPointsFontColorPictureBox);
            focusTabPage.focusPointsPanel.Controls.Add(focusTabPage.focusPointsFontComboBox);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(label110);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionFontOutlineColorPictureBox);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionFontOutlineNumericUpDown);
            focusTabPage.focusDescriptionOutlinePanel.Controls.Add(focusTabPage.focusDescriptionOutlineCheckBox);
            focusTabPage.focusDescriptionPanel.Controls.Add(label101);
            focusTabPage.focusDescriptionPanel.Controls.Add(focusTabPage.focusDescriptionFontColorPictureBox);
            focusTabPage.focusDescriptionPanel.Controls.Add(focusTabPage.focusDescriptionFontComboBox);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsFontOutlineNumericUpDown);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsOutlineCheckBox);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(label104);
            focusTabPage.focusPointsOutlinePanel.Controls.Add(focusTabPage.focusPointsFontOutlineColorPictureBox);
            focusTabPage.focusLineOutlinePanel.Controls.Add(label105);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineColorPictureBox);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineNumericUpDown);
            focusTabPage.focusLineOutlinePanel.Controls.Add(focusTabPage.focusLineOutlineCheckBox);

            focusTabPage.focusAchievementPictureBox.Click += new EventHandler(BrowserSensitiveControl_Click);
            focusTabPage.focusAchievementTitleLabel.Click += new EventHandler(BrowserSensitiveControl_Click);
            focusTabPage.focusSetButton.Click += new EventHandler(SetFocusButton_Click);
            focusTabPage.focusAchievementButtonPrevious.Click += new EventHandler(MoveFocusIndexPrev_Click);
            focusTabPage.focusAchievementButtonNext.Click += new EventHandler(MoveFocusIndexNext_Click);
            focusTabPage.focusBehaviorGoToLastRadioButton.CheckedChanged += new EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            focusTabPage.focusBehaviorGoToNextRadioButton.CheckedChanged += new EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            focusTabPage.focusBehaviorGoToPreviousRadioButton.CheckedChanged += new EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            focusTabPage.focusBehaviorGoToFirstRadioButton.CheckedChanged += new EventHandler(RefocusBehavior_RadioButtonCheckChanged);
            focusTabPage.focusLineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusBorderCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            focusTabPage.focusBorderColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusPointsFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusPointsFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            focusTabPage.focusAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            focusTabPage.focusTitleFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            focusTabPage.focusTitleOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            focusTabPage.focusTitleFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            focusTabPage.focusDescriptionFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusDescriptionFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            focusTabPage.focusDescriptionOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            focusTabPage.focusDescriptionFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusDescriptionFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            focusTabPage.focusAutoOpenWindowCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            focusTabPage.focusBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusTitleFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusTitleFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            focusTabPage.focusPointsFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            focusTabPage.focusPointsOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            focusTabPage.focusPointsFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusLineOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            focusTabPage.focusLineOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            focusTabPage.focusLineOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            alertsTabPage.alertsLinePanel.Controls.Add(label113);
            alertsTabPage.alertsLinePanel.Controls.Add(alertsTabPage.alertsLineColorPictureBox);
            alertsTabPage.alertsPointsPanel.Controls.Add(label116);
            alertsTabPage.alertsPointsPanel.Controls.Add(alertsTabPage.alertsPointsFontColorPictureBox);
            alertsTabPage.alertsPointsPanel.Controls.Add(alertsTabPage.alertsPointsFontComboBox);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(label122);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown);
            alertsTabPage.alertsDescriptionOutlinePanel.Controls.Add(alertsTabPage.alertsDescriptionOutlineCheckBox);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(label123);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(alertsTabPage.alertsDescriptionFontColorPictureBox);
            alertsTabPage.alertsDescriptionPanel.Controls.Add(alertsTabPage.alertsDescriptionFontComboBox);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsFontOutlineNumericUpDown);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsOutlineCheckBox);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(label126);
            alertsTabPage.alertsPointsOutlinePanel.Controls.Add(alertsTabPage.alertsPointsFontOutlineColorPictureBox);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(label127);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineColorPictureBox);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineNumericUpDown);
            alertsTabPage.alertsLineOutlinePanel.Controls.Add(alertsTabPage.alertsLineOutlineCheckBox);
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

            alertsTabPage.alertsPlayAchievementButton.Click += new EventHandler(ShowAlertButton_Click);
            alertsTabPage.alertsSelectCustomAchievementFileButton.Click += new EventHandler(SelectCustomAlertButton_Click);
            alertsTabPage.alertsCustomAchievementScaleNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementXNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementYNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsAchievementEditOutlineCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);
            alertsTabPage.alertsCustomAchievementOutNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementAnimationOutComboBox.SelectedIndexChanged += new EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            alertsTabPage.alertsCustomAchievementOutSpeedUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementInNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementAnimationInComboBox.SelectedIndexChanged += new EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            alertsTabPage.alertsCustomAchievementInSpeedUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomAchievementEnableCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);
            alertsTabPage.alertsPlayMasteryButton.Click += new EventHandler(ShowAlertButton_Click);
            alertsTabPage.alertsSelectCustomMasteryFileButton.Click += new EventHandler(SelectCustomAlertButton_Click);
            alertsTabPage.alertsCustomMasteryScaleNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryXNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryYNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsMasteryEditOutlineCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);
            alertsTabPage.alertsCustomMasteryOutNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryAnimationOutComboBox.SelectedIndexChanged += new EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            alertsTabPage.alertsCustomMasteryOutSpeedUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryInNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryAnimationInComboBox.SelectedIndexChanged += new EventHandler(NotificationAnimationComboBox_SelectedIndexChanged);
            alertsTabPage.alertsCustomMasteryInSpeedUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsCustomMasteryEnableCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);
            alertsTabPage.alertsLineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsBorderCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsBorderColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsPointsFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsPointsFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            alertsTabPage.alertsAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            alertsTabPage.alertsTitleFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsTitleOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsTitleFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            alertsTabPage.alertsDescriptionFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsDescriptionFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsDescriptionOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsDescriptionFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsDescriptionFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            alertsTabPage.alertsAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsTitleFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsTitleFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            alertsTabPage.alertsPointsFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsPointsOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsPointsFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsLineOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            alertsTabPage.alertsLineOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            alertsTabPage.alertsLineOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            alertsTabPage.alertsAchievementEnableCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);
            alertsTabPage.alertsMasteryEnableCheckbox.CheckedChanged += new EventHandler(CustomAlertsCheckBox_CheckedChanged);

            userInfoTabPage.userInfoValuesPanel.Controls.Add(label26);
            userInfoTabPage.userInfoValuesPanel.Controls.Add(userInfoTabPage.userInfoValuesFontColorPictureBox);
            userInfoTabPage.userInfoValuesPanel.Controls.Add(userInfoTabPage.userInfoValuesFontComboBox);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(label27);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown);
            userInfoTabPage.userInfoValuesOutlinePanel.Controls.Add(userInfoTabPage.userInfoValuesOutlineCheckBox);

            userInfoTabPage.userInfoAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            userInfoTabPage.userInfoTruePointsTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            userInfoTabPage.userInfoPointsTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            userInfoTabPage.userInfoRatioTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            userInfoTabPage.userInfoRankTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            userInfoTabPage.userInfoTruePointsCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoRatioCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoPointsCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoDefaultButton.Click += new EventHandler(DefaultButton_Click);
            userInfoTabPage.userInfoRankCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            userInfoTabPage.userInfoValuesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            userInfoTabPage.userInfoValuesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            userInfoTabPage.userInfoBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            userInfoTabPage.userInfoNamesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            userInfoTabPage.userInfoNamesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            userInfoTabPage.userInfoNamesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            userInfoTabPage.userInfoNamesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            userInfoTabPage.userInfoNamesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            userInfoTabPage.userInfoValuesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            userInfoTabPage.userInfoValuesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            userInfoTabPage.userInfoValuesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(label82);
            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontColorPictureBox);
            gameInfoTabPage.gameInfoValuesPanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontComboBox);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(label86);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown);
            gameInfoTabPage.gameInfoValuesOutlinePanel.Controls.Add(gameInfoTabPage.gameInfoValuesOutlineCheckBox);

            gameInfoTabPage.gameInfoPictureBox.Click += new EventHandler(BrowserSensitiveControl_Click);
            gameInfoTabPage.gameInfoReleasedCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoReleaseDateTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoGenreCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoGenreTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoDefaultButton.Click += new EventHandler(DefaultButton_Click);
            gameInfoTabPage.gameInfoTitleCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoTitleTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoConsoleCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoConsoleTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoPublisherTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoPublisherCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoDeveloperTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameInfoTabPage.gameInfoDeveloperCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            gameInfoTabPage.gameInfoOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            gameInfoTabPage.gameInfoValuesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameInfoTabPage.gameInfoValuesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            gameInfoTabPage.gameInfoAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameInfoTabPage.gameInfoNamesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameInfoTabPage.gameInfoNamesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            gameInfoTabPage.gameInfoNamesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            gameInfoTabPage.gameInfoValuesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(label46);
            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontColorPictureBox);
            gameProgressTabPage.gameProgressValuesPanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontComboBox);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(label50);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown);
            gameProgressTabPage.gameProgressValuesOutlinePanel.Controls.Add(gameProgressTabPage.gameProgressValuesOutlineCheckBox);

            gameProgressTabPage.gameProgressAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            gameProgressTabPage.gameProgressOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            gameProgressTabPage.gameProgressValuesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameProgressTabPage.gameProgressValuesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            gameProgressTabPage.gameProgressAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameProgressTabPage.gameProgressNamesFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameProgressTabPage.gameProgressNamesFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            gameProgressTabPage.gameProgressNamesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            gameProgressTabPage.gameProgressValuesOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressRadioButtonPeriod.CheckedChanged += new EventHandler(DividerCharacter_RadioButtonClicked);
            gameProgressTabPage.gameProgressRadioButtonColon.CheckedChanged += new EventHandler(DividerCharacter_RadioButtonClicked);
            gameProgressTabPage.gameProgressRadioButtonBackslash.CheckedChanged += new EventHandler(DividerCharacter_RadioButtonClicked);
            gameProgressTabPage.gameProgressCompletedTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameProgressTabPage.gameProgressCompletedCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressDefaultButton.Click += new EventHandler(DefaultButton_Click);
            gameProgressTabPage.gameProgressAchievementsCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressAchievementsTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameProgressTabPage.gameProgressRatioCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressRatioTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameProgressTabPage.gameProgressTruePointsTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameProgressTabPage.gameProgressTruePointsCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            gameProgressTabPage.gameProgressPointsTextBox.TextChanged += new EventHandler(OverrideTextBox_TextChanged);
            gameProgressTabPage.gameProgressPointsCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            recentAchievementsTabPage.recentAchievementsLinePanel.Controls.Add(label16);
            recentAchievementsTabPage.recentAchievementsLinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(label19);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox);
            recentAchievementsTabPage.recentAchievementsPointsPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontComboBox);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(label144);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsDescriptionOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(label145);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox);
            recentAchievementsTabPage.recentAchievementsDescriptionPanel.Controls.Add(recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(label148);
            recentAchievementsTabPage.recentAchievementsPointsOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(label149);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown);
            recentAchievementsTabPage.recentAchievementsLineOutlinePanel.Controls.Add(recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox);

            recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            recentAchievementsTabPage.recentAchievementsAutoScrollCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsLineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsBorderCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsBorderColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsPointsFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            recentAchievementsTabPage.recentAchievementsAdvancedCheckBox.CheckedChanged += new EventHandler(AdvancedCheckBox_Click);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            recentAchievementsTabPage.recentAchievementsDateFontOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsDescriptionFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            recentAchievementsTabPage.recentAchievementsAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsTitleFontComboBox.SelectedIndexChanged += new EventHandler(FontFamilyComboBox_SelectedIndexChanged);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            recentAchievementsTabPage.recentAchievementsLineOutlineCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);

            achievementsListTabPage.achievementListAutoScrollCheckBox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            achievementsListTabPage.achievementListWindowSizeXUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            achievementsListTabPage.achievementListWindowSizeYUpDown.ValueChanged += new EventHandler(CustomNumericUpDown_ValueChanged);
            achievementsListTabPage.achievementListOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            achievementsListTabPage.achievementListAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            achievementsListTabPage.achievementListBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);

            relatedMediaTabPage.relatedMediaRAScreenshotRadioButton.CheckedChanged += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaRABadgeIconRadioButton.CheckedChanged += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaRABoxArtRadioButton.CheckedChanged += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaRATitleScreenRadioButton.CheckedChanged += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaOpenWindowButton.Click += new EventHandler(ShowWindowButton_Click);
            relatedMediaTabPage.relatedMediaAutoOpenWindowCheckbox.CheckedChanged += new EventHandler(FeatureEnablementCheckBox_CheckedChanged);
            relatedMediaTabPage.relatedMediaBackgroundColorPictureBox.Click += new EventHandler(FontColorPictureBox_Click);
            relatedMediaTabPage.relatedMediaLBCartFrontRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBCartBackRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBoxBackReconRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBoxFullRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBoxSpineRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBClearLogoRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBannerRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBTitleScreenRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaSetLaunchBoxPathButton.Click += new EventHandler(SetRelatedMediaPathButton_Click);
            relatedMediaTabPage.relatedMediaLBBoxFrontReconRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBoxFrontRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBoxBackRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);
            relatedMediaTabPage.relatedMediaLBBox3DRadioButton.Click += new EventHandler(RelatedMedia_RadioButtonCheckChanged);

            // Main window
            InitWindow();

//             ((ISupportInitialize)(userProfilePictureBox)).EndInit();
//             ((ISupportInitialize)(focusTabPage.focusAchievementPictureBox)).EndInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoPictureBox)).EndInit();
//             ((ISupportInitialize)(autoPollingStatusPictureBox)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementScaleNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementXNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementYNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementOutSpeedUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomAchievementInSpeedUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryScaleNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryXNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryYNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryOutSpeedUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsCustomMasteryInSpeedUpDown)).EndInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsMaxListNumericUpDown)).EndInit();
//             autoFocusRulePanel.ResumeLayout(false);
//             autoFocusRulePanel.PerformLayout();
//             ((ISupportInitialize)(pictureBox12)).EndInit();
//             panel63.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox10)).EndInit();
//             currentAchievementPanel.ResumeLayout(false);
//             currentAchievementPanel.PerformLayout();

//             ((ISupportInitialize)(focusTabPage.focusLineColorPictureBox)).EndInit();
//             panel59.ResumeLayout(false);
//             panel59.PerformLayout();
//             ((ISupportInitialize)(focusTabPage.focusBorderColorPictureBox)).EndInit();

//             ((ISupportInitialize)(focusTabPage.focusPointsFontColorPictureBox)).EndInit();
//             panel52.ResumeLayout(false);
//             panel52.PerformLayout();
//             panel61.ResumeLayout(false);
//             panel61.PerformLayout();
//             ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(focusTabPage.focusTitleFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontOutlineNumericUpDown)).EndInit();

//             ((ISupportInitialize)(focusTabPage.focusDescriptionFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox11)).EndInit();
//             panel54.ResumeLayout(false);
//             ((ISupportInitialize)(focusTabPage.focusBackgroundColorPictureBox)).EndInit();
//             panel55.ResumeLayout(false);
//             ((ISupportInitialize)(focusTabPage.focusTitleFontColorPictureBox)).EndInit();

//             ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(focusTabPage.focusPointsFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(focusTabPage.focusLineOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(focusTabPage.focusLineOutlineNumericUpDown)).EndInit();
//             panel65.ResumeLayout(false);
//             panel65.PerformLayout();

//             ((ISupportInitialize)(alertsTabPage.alertsLineColorPictureBox)).EndInit();
//             panel67.ResumeLayout(false);
//             panel67.PerformLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsBorderColorPictureBox)).EndInit();

//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontColorPictureBox)).EndInit();
//             panel69.ResumeLayout(false);
//             panel69.PerformLayout();
//             panel70.ResumeLayout(false);
//             panel70.PerformLayout();
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontOutlineNumericUpDown)).EndInit();

//             ((ISupportInitialize)(alertsTabPage.alertsDescriptionFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox20)).EndInit();
//             panel73.ResumeLayout(false);
//             ((ISupportInitialize)(alertsTabPage.alertsBackgroundColorPictureBox)).EndInit();
//             panel74.ResumeLayout(false);
//             ((ISupportInitialize)(alertsTabPage.alertsTitleFontColorPictureBox)).EndInit();

//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsPointsFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(alertsTabPage.alertsLineOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(alertsTabPage.alertsLineOutlineNumericUpDown)).EndInit();

//             panel85.ResumeLayout(false);
//             panel84.ResumeLayout(false);
//             panel86.ResumeLayout(false);
//             panel83.ResumeLayout(false);
//             panel87.ResumeLayout(false);
//             panel78.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox13)).EndInit();
//             panel79.ResumeLayout(false);
//             panel80.ResumeLayout(false);
//             panel81.ResumeLayout(false);
//             panel82.ResumeLayout(false);

//             panel89.ResumeLayout(false);
//             panel90.ResumeLayout(false);
//             panel91.ResumeLayout(false);
//             panel92.ResumeLayout(false);
//             panel93.ResumeLayout(false);
//             panel94.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox14)).EndInit();
//             panel95.ResumeLayout(false);
//             panel96.ResumeLayout(false);
//             panel97.ResumeLayout(false);
//             panel98.ResumeLayout(false);
//             panel14.ResumeLayout(false);
//             panel14.PerformLayout();
//             ((ISupportInitialize)(pictureBox2)).EndInit();
//             panel21.ResumeLayout(false);
//             panel22.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox4)).EndInit();
//             panel10.ResumeLayout(false);
//             panel10.PerformLayout();
//             panel13.ResumeLayout(false);
//             panel13.PerformLayout();
//             panel12.ResumeLayout(false);
//             panel12.PerformLayout();
//             panel11.ResumeLayout(false);
//             panel11.PerformLayout();
//             panel20.ResumeLayout(false);
//             panel20.PerformLayout();
//             panel4.ResumeLayout(false);
//             panel4.PerformLayout();

//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox3)).EndInit();
//             panel5.ResumeLayout(false);
//             ((ISupportInitialize)(userInfoTabPage.userInfoBackgroundColorPictureBox)).EndInit();
//             panel6.ResumeLayout(false);
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontColorPictureBox)).EndInit();
//             panel7.ResumeLayout(false);
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(userInfoTabPage.userInfoNamesFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(userInfoTabPage.userInfoValuesFontOutlineNumericUpDown)).EndInit();
//             panel50.ResumeLayout(false);
//             panel119.ResumeLayout(false);
//             panel117.ResumeLayout(false);
//             panel118.ResumeLayout(false);
//             panel116.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox8)).EndInit();
//             panel29.ResumeLayout(false);
//             panel49.ResumeLayout(false);
//             panel49.PerformLayout();
//             panel48.ResumeLayout(false);
//             panel48.PerformLayout();
//             panel30.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox7)).EndInit();
//             panel31.ResumeLayout(false);
//             panel31.PerformLayout();
//             panel32.ResumeLayout(false);
//             panel32.PerformLayout();
//             panel33.ResumeLayout(false);
//             panel33.PerformLayout();
//             panel34.ResumeLayout(false);
//             panel34.PerformLayout();
//             panel35.ResumeLayout(false);
//             panel35.PerformLayout();
//             panel42.ResumeLayout(false);
//             panel42.PerformLayout();

//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox9)).EndInit();
//             panel44.ResumeLayout(false);
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoBackgroundColorPictureBox)).EndInit();
//             panel45.ResumeLayout(false);
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontColorPictureBox)).EndInit();
//             panel46.ResumeLayout(false);
//             panel46.PerformLayout();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoNamesFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(gameInfoTabPage.gameInfoValuesFontOutlineNumericUpDown)).EndInit();
//             panel28.ResumeLayout(false);
//             panel28.PerformLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressPercentCompletePictureBox)).EndInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressMasteryPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox21)).EndInit();
//             ((ISupportInitialize)(pictureBox5)).EndInit();
//             panel15.ResumeLayout(false);
//             panel15.PerformLayout();
//             panel16.ResumeLayout(false);
//             panel16.PerformLayout();

//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox6)).EndInit();
//             panel18.ResumeLayout(false);
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressBackgroundColorPictureBox)).EndInit();
//             panel19.ResumeLayout(false);
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontColorPictureBox)).EndInit();
//             panel23.ResumeLayout(false);
//             panel23.PerformLayout();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressNamesFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(gameProgressTabPage.gameProgressValuesFontOutlineNumericUpDown)).EndInit();
//             panel36.ResumeLayout(false);
//             panel27.ResumeLayout(false);
//             panel27.PerformLayout();
//             panel37.ResumeLayout(false);
//             panel26.ResumeLayout(false);
//             panel26.PerformLayout();
//             ((ISupportInitialize)(pictureBox17)).EndInit();
//             panel38.ResumeLayout(false);
//             panel38.PerformLayout();
//             panel39.ResumeLayout(false);
//             panel39.PerformLayout();
//             panel40.ResumeLayout(false);
//             panel40.PerformLayout();
//             panel41.ResumeLayout(false);
//             panel41.PerformLayout();
//             panel113.ResumeLayout(false);
//             panel113.PerformLayout();
//             ((ISupportInitialize)(pictureBox15)).EndInit();
//             panel99.ResumeLayout(false);
//             panel99.PerformLayout();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineColorPictureBox)).EndInit();
//             panel101.ResumeLayout(false);
//             panel101.PerformLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBorderColorPictureBox)).EndInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontColorPictureBox)).EndInit();
//             panel103.ResumeLayout(false);
//             panel103.PerformLayout();
//             panel104.ResumeLayout(false);
//             panel104.PerformLayout();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDescriptionFontOutlineNumericUpDown)).EndInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsDateFontColorPictureBox)).EndInit();
//             ((ISupportInitialize)(pictureBox23)).EndInit();
//             panel107.ResumeLayout(false);
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsBackgroundColorPictureBox)).EndInit();
//             panel108.ResumeLayout(false);
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsTitleFontColorPictureBox)).EndInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineNumericUpDown)).EndInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsPointsFontOutlineColorPictureBox)).EndInit();

//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineColorPictureBox)).EndInit();
//             ((ISupportInitialize)(recentAchievementsTabPage.recentAchievementsLineOutlineNumericUpDown)).EndInit();
//             panel115.ResumeLayout(false);
//             panel115.PerformLayout();
//             ((ISupportInitialize)(pictureBox18)).EndInit();
//             panel111.ResumeLayout(false);
//             panel111.PerformLayout();
//             panel9.ResumeLayout(false);
//             panel9.PerformLayout();
//             ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeXUpDown)).EndInit();
//             ((ISupportInitialize)(achievementsListTabPage.achievementListWindowSizeYUpDown)).EndInit();
//             panel112.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox16)).EndInit();
//             panel114.ResumeLayout(false);
//             ((ISupportInitialize)(achievementsListTabPage.achievementListBackgroundColorPictureBox)).EndInit();
//             panel1.ResumeLayout(false);
//             panel1.PerformLayout();
//             panel3.ResumeLayout(false);
//             panel3.PerformLayout();
//             panel2.ResumeLayout(false);
//             panel2.PerformLayout();
//             panel120.ResumeLayout(false);
//             panel120.PerformLayout();
//             ((ISupportInitialize)(pictureBox19)).EndInit();
//             panel121.ResumeLayout(false);
//             panel121.PerformLayout();
//             panel122.ResumeLayout(false);
//             ((ISupportInitialize)(pictureBox22)).EndInit();
//             panel123.ResumeLayout(false);
//             ((ISupportInitialize)(relatedMediaTabPage.relatedMediaBackgroundColorPictureBox)).EndInit();
//             panel124.ResumeLayout(false);
//             panel124.PerformLayout();
//             ((ISupportInitialize)(relatedMediaTabPage.relatedMediaLBLinePictureBox)).EndInit();
//             mainTabControl.ResumeLayout(false);
//             focusTabPage.ResumeLayout(false);
//             alertsTabPage.ResumeLayout(false);
//             alertTabControl.ResumeLayout(false);
//             achievementTabPage.ResumeLayout(false);
//             achievementTabPage.PerformLayout();
//             masteryTabPage.ResumeLayout(false);
//             masteryTabPage.PerformLayout();
//             userInfoTabPage.ResumeLayout(false);
//             gameInfoTabPage.ResumeLayout(false);
//             gameProgressTabPage.ResumeLayout(false);
//             recentAchievementsTabPage.ResumeLayout(false);
//             achievementsListTabPage.ResumeLayout(false);
//             relatedMediaTabPage.ResumeLayout(false);
//             panel8.ResumeLayout(false);
//             panel8.PerformLayout();

            // Prevent flickering
            // SetStyle(
            //     ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
            //     true
            // );

            ResumeLayout(false);
        }

        void InitWindow(bool firstInit = false)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
            Icon = ((Icon)(resources.GetObject("$this.Icon")));
            Name = "MainWindow";
            Text = "Retro Achievements Tracker";
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = btnBackColor;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = btnPanelMargin;

            if (firstInit)
            {
                ClientSize = new Size(1179, 785);
                
                Controls.Add(panel8);
                Controls.Add(mainTabControl);
                Controls.Add(autoPollingStatusPictureBox);
                Controls.Add(autoPollingStatusLabel);
                Controls.Add(panel1);
            }
        }

        void InitTabs()
        {
            focusTabPage.InitElements();
            alertsTabPage.InitElements();
            userInfoTabPage.InitElements();
            gameInfoTabPage.InitElements();
            gameProgressTabPage.InitElements();
            recentAchievementsTabPage.InitElements();
            achievementsListTabPage.InitElements();
            relatedMediaTabPage.InitElements();
        }

        #endregion
    }
}

