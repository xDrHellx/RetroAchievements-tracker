using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class UserInfoTab : AbstractTab
    {
        #region Sub elements

        public Label userInfoRatioLabel,
            userInfoTruePointsLabel,
            userInfoPointsLabel,
            userInfoRankLabel,
            userInfoUsernameLabel,
            userInfoNamesLabel,
            userInfoNamesOutlineLabel,
            userInfoMottoLabel;
        public NumericUpDown userInfoNamesFontOutlineNumericUpDown,
            userInfoValuesFontOutlineNumericUpDown;
        public TextBox userInfoTruePointsTextBox,
            userInfoPointsTextBox,
            userInfoRatioTextBox,
            userInfoRankTextBox;
        public PictureBox userInfoBackgroundColorPictureBox,
            userInfoNamesFontOutlineColorPictureBox,
            userInfoNamesFontColorPictureBox,
            userInfoValuesFontOutlineColorPictureBox,
            userInfoValuesFontColorPictureBox;
        public Button userInfoOpenWindowButton,
            userInfoDefaultButton;
        public CheckBox userInfoAutoOpenWindowCheckbox,
            userInfoTruePointsCheckBox,
            userInfoRatioCheckBox,
            userInfoPointsCheckBox,
            userInfoRankCheckBox,
            userInfoNamesOutlineCheckBox,
            userInfoValuesOutlineCheckBox,
            userInfoAdvancedCheckBox;
        public ComboBox userInfoNamesFontComboBox,
            userInfoValuesFontComboBox;
        public Panel userInfoValuesOutlinePanel,
            userInfoValuesPanel;

        #endregion

        #region Constructor

        public UserInfoTab()
        {
            Name = "UserInfoTabPage";
            Text = "User Info";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                userInfoNamesLabel.Text = "Names";
                userInfoNamesOutlineLabel.Text = "Names OutlineColor";

                SetFontFamilyBox(userInfoNamesFontComboBox, UserInfoController.Instance.NameFontFamily);
                userInfoNamesOutlineCheckBox.Checked = UserInfoController.Instance.NameOutlineEnabled;
                userInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.NameColor);
                userInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.NameOutlineColor);
            }
            else
            {
                userInfoNamesLabel.Text = "Font";
                userInfoNamesOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(userInfoNamesFontComboBox, UserInfoController.Instance.SimpleFontFamily);
                userInfoNamesOutlineCheckBox.Checked = UserInfoController.Instance.SimpleFontOutlineEnabled;
                userInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.SimpleFontColor);
                userInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.SimpleFontOutlineColor);
            }

            userInfoValuesPanel.Enabled = enable;
            userInfoValuesOutlinePanel.Enabled = enable;
        }

        public override void InitElements()
        {
            userInfoAutoOpenWindowCheckbox = new CheckBox();
            userInfoOpenWindowButton = new Button();
            userInfoTruePointsTextBox = new TextBox();
            userInfoPointsTextBox = new TextBox();
            userInfoRatioTextBox = new TextBox();
            userInfoRankTextBox = new TextBox();
            userInfoTruePointsCheckBox = new CheckBox();
            userInfoRatioCheckBox = new CheckBox();
            userInfoPointsCheckBox = new CheckBox();
            userInfoDefaultButton = new Button();
            userInfoRankCheckBox = new CheckBox();
            userInfoUsernameLabel = new Label();
            userInfoRankLabel = new Label();
            userInfoPointsLabel = new Label();
            userInfoTruePointsLabel = new Label();
            userInfoMottoLabel = new Label();
            userInfoRatioLabel = new Label();
            userInfoAdvancedCheckBox = new CheckBox();
            userInfoValuesPanel = new Panel();
            userInfoValuesFontColorPictureBox = new PictureBox();
            userInfoValuesFontComboBox = new ComboBox();
            userInfoBackgroundColorPictureBox = new PictureBox();
            userInfoNamesLabel = new Label();
            userInfoNamesFontColorPictureBox = new PictureBox();
            userInfoNamesFontComboBox = new ComboBox();
            userInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            userInfoNamesOutlineCheckBox = new CheckBox();
            userInfoNamesOutlineLabel = new Label();
            userInfoNamesFontOutlineColorPictureBox = new PictureBox();
            userInfoValuesOutlinePanel = new Panel();
            userInfoValuesFontOutlineColorPictureBox = new PictureBox();
            userInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            userInfoValuesOutlineCheckBox = new CheckBox();
            userInfoValuesPanel.SuspendLayout();
            userInfoValuesOutlinePanel.SuspendLayout();
            userInfoAutoOpenWindowCheckbox.AutoSize = true;
            userInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            userInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            userInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            userInfoAutoOpenWindowCheckbox.Name = "userInfoAutoOpenWindowCheckbox";
            userInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            userInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            userInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            userInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            userInfoOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            userInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            userInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            userInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            userInfoOpenWindowButton.Location = new Point(573, 3);
            userInfoOpenWindowButton.Margin = new Padding(0);
            userInfoOpenWindowButton.Name = "userInfoOpenWindowButton";
            userInfoOpenWindowButton.Size = new Size(112, 42);
            userInfoOpenWindowButton.TabIndex = 10021;
            userInfoOpenWindowButton.Text = "Open";
            userInfoOpenWindowButton.UseVisualStyleBackColor = false;
            userInfoTruePointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTruePointsTextBox.ForeColor = Color.White;
            userInfoTruePointsTextBox.Location = new Point(174, 0);
            userInfoTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTruePointsTextBox.Name = "userInfoTruePointsTextBox";
            userInfoTruePointsTextBox.Size = new Size(146, 31);
            userInfoTruePointsTextBox.TabIndex = 7;
            userInfoTruePointsTextBox.Text = "True Points";
            userInfoPointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoPointsTextBox.ForeColor = Color.White;
            userInfoPointsTextBox.Location = new Point(174, 0);
            userInfoPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoPointsTextBox.Name = "userInfoPointsTextBox";
            userInfoPointsTextBox.Size = new Size(146, 31);
            userInfoPointsTextBox.TabIndex = 6;
            userInfoPointsTextBox.Text = "Points";
            userInfoRatioTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoRatioTextBox.ForeColor = Color.White;
            userInfoRatioTextBox.Location = new Point(174, 0);
            userInfoRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoRatioTextBox.Name = "userInfoRatioTextBox";
            userInfoRatioTextBox.Size = new Size(146, 31);
            userInfoRatioTextBox.TabIndex = 5;
            userInfoRatioTextBox.Text = "Retro Ratio";
            userInfoRankTextBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoRankTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoRankTextBox.ForeColor = Color.White;
            userInfoRankTextBox.Location = new Point(174, 0);
            userInfoRankTextBox.Margin = new Padding(4, 5, 4, 5);
            userInfoRankTextBox.Name = "userInfoRankTextBox";
            userInfoRankTextBox.Size = new Size(146, 31);
            userInfoRankTextBox.TabIndex = 1;
            userInfoRankTextBox.Text = "Rank";
            userInfoTruePointsCheckBox.BackColor = Color.Transparent;
            userInfoTruePointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTruePointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoTruePointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoTruePointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoTruePointsCheckBox.ForeColor = Color.White;
            userInfoTruePointsCheckBox.Location = new Point(338, 8);
            userInfoTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoTruePointsCheckBox.Name = "userInfoTruePointsCheckBox";
            userInfoTruePointsCheckBox.Size = new Size(22, 22);
            userInfoTruePointsCheckBox.TabIndex = 56;
            userInfoTruePointsCheckBox.UseVisualStyleBackColor = true;
            userInfoRatioCheckBox.BackColor = Color.Transparent;
            userInfoRatioCheckBox.FlatAppearance.BorderSize = 0;
            userInfoRatioCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoRatioCheckBox.FlatStyle = FlatStyle.System;
            userInfoRatioCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoRatioCheckBox.ForeColor = Color.White;
            userInfoRatioCheckBox.Location = new Point(338, 8);
            userInfoRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoRatioCheckBox.Name = "userInfoRatioCheckBox";
            userInfoRatioCheckBox.Size = new Size(22, 22);
            userInfoRatioCheckBox.TabIndex = 55;
            userInfoRatioCheckBox.UseVisualStyleBackColor = true;
            userInfoPointsCheckBox.BackColor = Color.Transparent;
            userInfoPointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoPointsCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoPointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoPointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoPointsCheckBox.ForeColor = Color.White;
            userInfoPointsCheckBox.Location = new Point(338, 8);
            userInfoPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoPointsCheckBox.Name = "userInfoPointsCheckBox";
            userInfoPointsCheckBox.Size = new Size(22, 22);
            userInfoPointsCheckBox.TabIndex = 54;
            userInfoPointsCheckBox.UseVisualStyleBackColor = true;
            userInfoDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            userInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            userInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            userInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            userInfoDefaultButton.Location = new Point(306, 3);
            userInfoDefaultButton.Margin = new Padding(0);
            userInfoDefaultButton.Name = "userInfoDefaultButton";
            userInfoDefaultButton.Size = new Size(112, 42);
            userInfoDefaultButton.TabIndex = 39;
            userInfoDefaultButton.Text = "Default";
            userInfoDefaultButton.UseVisualStyleBackColor = false;
            userInfoRankCheckBox.BackColor = Color.Transparent;
            userInfoRankCheckBox.FlatAppearance.BorderSize = 0;
            userInfoRankCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoRankCheckBox.FlatStyle = FlatStyle.System;
            userInfoRankCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoRankCheckBox.ForeColor = Color.White;
            userInfoRankCheckBox.Location = new Point(338, 8);
            userInfoRankCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoRankCheckBox.Name = "userInfoRankCheckBox";
            userInfoRankCheckBox.Size = new Size(22, 22);
            userInfoRankCheckBox.TabIndex = 52;
            userInfoRankCheckBox.UseVisualStyleBackColor = true;
            userInfoUsernameLabel.BackColor = Color.Transparent;
            userInfoUsernameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoUsernameLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoUsernameLabel.Location = new Point(4, 5);
            userInfoUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoUsernameLabel.Name = "userInfoUsernameLabel";
            userInfoUsernameLabel.Size = new Size(688, 40);
            userInfoUsernameLabel.TabIndex = 10058;
            userInfoUsernameLabel.Text = "Username";
            userInfoRankLabel.BackColor = Color.Transparent;
            userInfoRankLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoRankLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoRankLabel.Location = new Point(9, 120);
            userInfoRankLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoRankLabel.Name = "userInfoRankLabel";
            userInfoRankLabel.Size = new Size(303, 25);
            userInfoRankLabel.TabIndex = 10054;
            userInfoRankLabel.Text = "Site Rank: 15000";
            userInfoPointsLabel.BackColor = Color.Transparent;
            userInfoPointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoPointsLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoPointsLabel.Location = new Point(9, 95);
            userInfoPointsLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoPointsLabel.Name = "userInfoPointsLabel";
            userInfoPointsLabel.Size = new Size(280, 25);
            userInfoPointsLabel.TabIndex = 10055;
            userInfoPointsLabel.Text = "Hardcore Points: 348897";
            userInfoTruePointsLabel.BackColor = Color.Transparent;
            userInfoTruePointsLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoTruePointsLabel.ForeColor = Color.White;
            userInfoTruePointsLabel.Location = new Point(291, 95);
            userInfoTruePointsLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoTruePointsLabel.Name = "userInfoTruePointsLabel";
            userInfoTruePointsLabel.Size = new Size(128, 25);
            userInfoTruePointsLabel.TabIndex = 10056;
            userInfoTruePointsLabel.Text = "(10019920)";
            userInfoMottoLabel.AutoSize = true;
            userInfoMottoLabel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoMottoLabel.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            userInfoMottoLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoMottoLabel.Location = new Point(9, 57);
            userInfoMottoLabel.Margin = new Padding(4, 5, 4, 5);
            userInfoMottoLabel.Name = "userInfoMottoLabel";
            userInfoMottoLabel.Padding = new Padding(4, 5, 4, 5);
            userInfoMottoLabel.Size = new Size(240, 35);
            userInfoMottoLabel.TabIndex = 10074;
            userInfoMottoLabel.Text = "twitch.tv/RetroS3xual";
            userInfoRatioLabel.BackColor = Color.Transparent;
            userInfoRatioLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoRatioLabel.ForeColor = Color.White;
            userInfoRatioLabel.Location = new Point(146, 145);
            userInfoRatioLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoRatioLabel.Name = "userInfoRatioLabel";
            userInfoRatioLabel.Size = new Size(110, 25);
            userInfoRatioLabel.TabIndex = 10057;
            userInfoRatioLabel.Text = "3.62";
            userInfoAdvancedCheckBox.AutoSize = true;
            userInfoAdvancedCheckBox.BackColor = Color.Transparent;
            userInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            userInfoAdvancedCheckBox.FlatAppearance.BorderSize = 0;
            userInfoAdvancedCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(118, 118, 118);
            userInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoAdvancedCheckBox.Location = new Point(8, 3);
            userInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoAdvancedCheckBox.Name = "userInfoAdvancedCheckBox";
            userInfoAdvancedCheckBox.Size = new Size(135, 29);
            userInfoAdvancedCheckBox.TabIndex = 10053;
            userInfoAdvancedCheckBox.Text = "Advanced";
            userInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            userInfoValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoValuesPanel.Location = new Point(3, 163);
            userInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesPanel.Name = "userInfoValuesPanel";
            userInfoValuesPanel.Size = new Size(694, 35);
            userInfoValuesPanel.TabIndex = 10061;
            userInfoValuesFontColorPictureBox.BackColor = Color.White;
            userInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            userInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesFontColorPictureBox.Name = "userInfoValuesFontColorPictureBox";
            userInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            userInfoValuesFontColorPictureBox.TabIndex = 45;
            userInfoValuesFontColorPictureBox.TabStop = false;
            userInfoValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoValuesFontComboBox.ForeColor = Color.White;
            userInfoValuesFontComboBox.FormattingEnabled = true;
            userInfoValuesFontComboBox.Location = new Point(290, 3);
            userInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesFontComboBox.Name = "userInfoValuesFontComboBox";
            userInfoValuesFontComboBox.Size = new Size(301, 28);
            userInfoValuesFontComboBox.TabIndex = 45;
            userInfoBackgroundColorPictureBox.BackColor = Color.White;
            userInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            userInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoBackgroundColorPictureBox.Name = "userInfoBackgroundColorPictureBox";
            userInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            userInfoBackgroundColorPictureBox.TabIndex = 42;
            userInfoBackgroundColorPictureBox.TabStop = false;
            userInfoNamesLabel.BackColor = Color.Transparent;
            userInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoNamesLabel.Location = new Point(4, 6);
            userInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoNamesLabel.Name = "userInfoNamesLabel";
            userInfoNamesLabel.Size = new Size(216, 25);
            userInfoNamesLabel.TabIndex = 10065;
            userInfoNamesLabel.Text = "Names";
            userInfoNamesFontColorPictureBox.BackColor = Color.White;
            userInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            userInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoNamesFontColorPictureBox.Name = "userInfoNamesFontColorPictureBox";
            userInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            userInfoNamesFontColorPictureBox.TabIndex = 45;
            userInfoNamesFontColorPictureBox.TabStop = false;
            userInfoNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            userInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoNamesFontComboBox.ForeColor = Color.White;
            userInfoNamesFontComboBox.FormattingEnabled = true;
            userInfoNamesFontComboBox.Location = new Point(290, 3);
            userInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            userInfoNamesFontComboBox.Name = "userInfoNamesFontComboBox";
            userInfoNamesFontComboBox.Size = new Size(301, 28);
            userInfoNamesFontComboBox.TabIndex = 45;
            userInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            userInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            userInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            userInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            userInfoNamesFontOutlineNumericUpDown.Name = "userInfoNamesFontOutlineNumericUpDown";
            userInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            userInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            userInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            userInfoNamesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoNamesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoNamesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoNamesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoNamesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoNamesOutlineCheckBox.ForeColor = Color.White;
            userInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            userInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoNamesOutlineCheckBox.Name = "userInfoNamesOutlineCheckBox";
            userInfoNamesOutlineCheckBox.Size = new Size(22, 22);
            userInfoNamesOutlineCheckBox.TabIndex = 45;
            userInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoNamesOutlineLabel.BackColor = Color.Transparent;
            userInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            userInfoNamesOutlineLabel.Location = new Point(4, 5);
            userInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            userInfoNamesOutlineLabel.Name = "userInfoNamesOutlineLabel";
            userInfoNamesOutlineLabel.Size = new Size(216, 25);
            userInfoNamesOutlineLabel.TabIndex = 10066;
            userInfoNamesOutlineLabel.Text = "Names OutlineColor";
            userInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            userInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoNamesFontOutlineColorPictureBox.Name = "userInfoNamesFontOutlineColorPictureBox";
            userInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            userInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            userInfoNamesFontOutlineColorPictureBox.TabStop = false;
            userInfoValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            userInfoValuesOutlinePanel.Location = new Point(3, 231);
            userInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesOutlinePanel.Name = "userInfoValuesOutlinePanel";
            userInfoValuesOutlinePanel.Size = new Size(694, 35);
            userInfoValuesOutlinePanel.TabIndex = 10067;
            userInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            userInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesFontOutlineColorPictureBox.Name = "userInfoValuesFontOutlineColorPictureBox";
            userInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            userInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            userInfoValuesFontOutlineColorPictureBox.TabStop = false;
            userInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            userInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            userInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            userInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            userInfoValuesFontOutlineNumericUpDown.Name = "userInfoValuesFontOutlineNumericUpDown";
            userInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            userInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            userInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            userInfoValuesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoValuesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoValuesOutlineCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(22, 22, 22);
            userInfoValuesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoValuesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            userInfoValuesOutlineCheckBox.ForeColor = Color.White;
            userInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            userInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            userInfoValuesOutlineCheckBox.Name = "userInfoValuesOutlineCheckBox";
            userInfoValuesOutlineCheckBox.Size = new Size(22, 22);
            userInfoValuesOutlineCheckBox.TabIndex = 45;
            userInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoValuesPanel.ResumeLayout(false);
            userInfoValuesOutlinePanel.ResumeLayout(false);
        }

        #endregion
    }
}
