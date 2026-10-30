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
            BackColor = btnBackColor;
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
            userInfoAutoOpenWindowCheckbox.Font = labelFont;
            userInfoAutoOpenWindowCheckbox.ForeColor = foreColor;
            userInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            userInfoAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            userInfoAutoOpenWindowCheckbox.Name = "userInfoAutoOpenWindowCheckbox";
            userInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            // userInfoAutoOpenWindowCheckbox.TabIndex = 10022;

            userInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            userInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            userInfoOpenWindowButton.BackColor = btnBackColor;
            userInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            userInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            userInfoOpenWindowButton.Font = labelFont;
            userInfoOpenWindowButton.ForeColor = btnForeColor;
            userInfoOpenWindowButton.Location = new Point(573, 3);
            userInfoOpenWindowButton.Margin = new Padding(0);
            userInfoOpenWindowButton.Name = "userInfoOpenWindowButton";
            userInfoOpenWindowButton.Size = new Size(112, 42);
            // userInfoOpenWindowButton.TabIndex = 10021;

            userInfoOpenWindowButton.Text = "Open";
            userInfoOpenWindowButton.UseVisualStyleBackColor = false;
            userInfoTruePointsTextBox.BackColor = btnBackColor;
            userInfoTruePointsTextBox.Font = labelFont;
            userInfoTruePointsTextBox.ForeColor = Color.White;
            userInfoTruePointsTextBox.Location = new Point(174, 0);
            userInfoTruePointsTextBox.Margin = btnPanelMargin;
            userInfoTruePointsTextBox.Name = "userInfoTruePointsTextBox";
            userInfoTruePointsTextBox.Size = new Size(146, 31);
            // userInfoTruePointsTextBox.TabIndex = 7;

            userInfoTruePointsTextBox.Text = "True Points";
            userInfoPointsTextBox.BackColor = btnBackColor;
            userInfoPointsTextBox.Font = labelFont;
            userInfoPointsTextBox.ForeColor = Color.White;
            userInfoPointsTextBox.Location = new Point(174, 0);
            userInfoPointsTextBox.Margin = btnPanelMargin;
            userInfoPointsTextBox.Name = "userInfoPointsTextBox";
            userInfoPointsTextBox.Size = new Size(146, 31);
            // userInfoPointsTextBox.TabIndex = 6;

            userInfoPointsTextBox.Text = "Points";
            userInfoRatioTextBox.BackColor = btnBackColor;
            userInfoRatioTextBox.Font = labelFont;
            userInfoRatioTextBox.ForeColor = Color.White;
            userInfoRatioTextBox.Location = new Point(174, 0);
            userInfoRatioTextBox.Margin = btnPanelMargin;
            userInfoRatioTextBox.Name = "userInfoRatioTextBox";
            userInfoRatioTextBox.Size = new Size(146, 31);
            // userInfoRatioTextBox.TabIndex = 5;

            userInfoRatioTextBox.Text = "Retro Ratio";
            userInfoRankTextBox.BackColor = btnBackColor;
            userInfoRankTextBox.Font = labelFont;
            userInfoRankTextBox.ForeColor = Color.White;
            userInfoRankTextBox.Location = new Point(174, 0);
            userInfoRankTextBox.Margin = btnPanelMargin;
            userInfoRankTextBox.Name = "userInfoRankTextBox";
            userInfoRankTextBox.Size = new Size(146, 31);
            // userInfoRankTextBox.TabIndex = 1;

            userInfoRankTextBox.Text = "Rank";
            userInfoTruePointsCheckBox.BackColor = Color.Transparent;
            userInfoTruePointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoTruePointsCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoTruePointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoTruePointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoTruePointsCheckBox.ForeColor = Color.White;
            userInfoTruePointsCheckBox.Location = new Point(338, 8);
            userInfoTruePointsCheckBox.Margin = btnPanelMargin;
            userInfoTruePointsCheckBox.Name = "userInfoTruePointsCheckBox";
            userInfoTruePointsCheckBox.Size = new Size(22, 22);
            // userInfoTruePointsCheckBox.TabIndex = 56;

            userInfoTruePointsCheckBox.UseVisualStyleBackColor = true;
            userInfoRatioCheckBox.BackColor = Color.Transparent;
            userInfoRatioCheckBox.FlatAppearance.BorderSize = 0;
            userInfoRatioCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoRatioCheckBox.FlatStyle = FlatStyle.System;
            userInfoRatioCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoRatioCheckBox.ForeColor = Color.White;
            userInfoRatioCheckBox.Location = new Point(338, 8);
            userInfoRatioCheckBox.Margin = btnPanelMargin;
            userInfoRatioCheckBox.Name = "userInfoRatioCheckBox";
            userInfoRatioCheckBox.Size = new Size(22, 22);
            // userInfoRatioCheckBox.TabIndex = 55;

            userInfoRatioCheckBox.UseVisualStyleBackColor = true;
            userInfoPointsCheckBox.BackColor = Color.Transparent;
            userInfoPointsCheckBox.FlatAppearance.BorderSize = 0;
            userInfoPointsCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoPointsCheckBox.FlatStyle = FlatStyle.System;
            userInfoPointsCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoPointsCheckBox.ForeColor = Color.White;
            userInfoPointsCheckBox.Location = new Point(338, 8);
            userInfoPointsCheckBox.Margin = btnPanelMargin;
            userInfoPointsCheckBox.Name = "userInfoPointsCheckBox";
            userInfoPointsCheckBox.Size = new Size(22, 22);
            // userInfoPointsCheckBox.TabIndex = 54;

            userInfoPointsCheckBox.UseVisualStyleBackColor = true;
            userInfoDefaultButton.BackColor = btnBackColor;
            userInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            userInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            userInfoDefaultButton.Font = labelFont;
            userInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            userInfoDefaultButton.Location = new Point(306, 3);
            userInfoDefaultButton.Margin = new Padding(0);
            userInfoDefaultButton.Name = "userInfoDefaultButton";
            userInfoDefaultButton.Size = new Size(112, 42);
            // userInfoDefaultButton.TabIndex = 39;

            userInfoDefaultButton.Text = "Default";
            userInfoDefaultButton.UseVisualStyleBackColor = false;
            userInfoRankCheckBox.BackColor = Color.Transparent;
            userInfoRankCheckBox.FlatAppearance.BorderSize = 0;
            userInfoRankCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoRankCheckBox.FlatStyle = FlatStyle.System;
            userInfoRankCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoRankCheckBox.ForeColor = Color.White;
            userInfoRankCheckBox.Location = new Point(338, 8);
            userInfoRankCheckBox.Margin = btnPanelMargin;
            userInfoRankCheckBox.Name = "userInfoRankCheckBox";
            userInfoRankCheckBox.Size = new Size(22, 22);
            // userInfoRankCheckBox.TabIndex = 52;

            userInfoRankCheckBox.UseVisualStyleBackColor = true;
            userInfoUsernameLabel.BackColor = Color.Transparent;
            userInfoUsernameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userInfoUsernameLabel.ForeColor = foreColor;
            userInfoUsernameLabel.Location = new Point(4, 5);
            userInfoUsernameLabel.Margin = labelMargin;
            userInfoUsernameLabel.Name = "userInfoUsernameLabel";
            userInfoUsernameLabel.Size = new Size(688, 40);
            // userInfoUsernameLabel.TabIndex = 10058;

            userInfoUsernameLabel.Text = "Username";
            userInfoRankLabel.BackColor = Color.Transparent;
            userInfoRankLabel.Font = labelFont;
            userInfoRankLabel.ForeColor = foreColor;
            userInfoRankLabel.Location = new Point(9, 120);
            userInfoRankLabel.Margin = labelMargin;
            userInfoRankLabel.Name = "userInfoRankLabel";
            userInfoRankLabel.Size = new Size(303, 25);
            // userInfoRankLabel.TabIndex = 10054;

            userInfoRankLabel.Text = "Site Rank: 15000";
            userInfoPointsLabel.BackColor = Color.Transparent;
            userInfoPointsLabel.Font = labelFont;
            userInfoPointsLabel.ForeColor = foreColor;
            userInfoPointsLabel.Location = new Point(9, 95);
            userInfoPointsLabel.Margin = labelMargin;
            userInfoPointsLabel.Name = "userInfoPointsLabel";
            userInfoPointsLabel.Size = new Size(280, 25);
            // userInfoPointsLabel.TabIndex = 10055;

            userInfoPointsLabel.Text = "Hardcore Points: 348897";
            userInfoTruePointsLabel.BackColor = Color.Transparent;
            userInfoTruePointsLabel.Font = labelFont;
            userInfoTruePointsLabel.ForeColor = Color.White;
            userInfoTruePointsLabel.Location = new Point(291, 95);
            userInfoTruePointsLabel.Margin = labelMargin;
            userInfoTruePointsLabel.Name = "userInfoTruePointsLabel";
            userInfoTruePointsLabel.Size = new Size(128, 25);
            // userInfoTruePointsLabel.TabIndex = 10056;

            userInfoTruePointsLabel.Text = "(10019920)";
            userInfoMottoLabel.AutoSize = true;
            userInfoMottoLabel.BackColor = btnBackColor;
            userInfoMottoLabel.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            userInfoMottoLabel.ForeColor = foreColor;
            userInfoMottoLabel.Location = new Point(9, 57);
            userInfoMottoLabel.Margin = btnPanelMargin;
            userInfoMottoLabel.Name = "userInfoMottoLabel";
            userInfoMottoLabel.Padding = btnPanelMargin;
            userInfoMottoLabel.Size = new Size(240, 35);
            // userInfoMottoLabel.TabIndex = 10074;

            userInfoMottoLabel.Text = "twitch.tv/RetroS3xual";
            userInfoRatioLabel.BackColor = Color.Transparent;
            userInfoRatioLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoRatioLabel.ForeColor = Color.White;
            userInfoRatioLabel.Location = new Point(146, 145);
            userInfoRatioLabel.Margin = labelMargin;
            userInfoRatioLabel.Name = "userInfoRatioLabel";
            userInfoRatioLabel.Size = new Size(110, 25);
            // userInfoRatioLabel.TabIndex = 10057;

            userInfoRatioLabel.Text = "3.62";
            userInfoAdvancedCheckBox.AutoSize = true;
            userInfoAdvancedCheckBox.BackColor = Color.Transparent;
            userInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            userInfoAdvancedCheckBox.FlatAppearance.BorderSize = 0;
            userInfoAdvancedCheckBox.FlatAppearance.CheckedBackColor = Color.FromArgb(118, 118, 118);
            userInfoAdvancedCheckBox.Font = labelFont;
            userInfoAdvancedCheckBox.ForeColor = foreColor;
            userInfoAdvancedCheckBox.Location = new Point(8, 3);
            userInfoAdvancedCheckBox.Margin = btnPanelMargin;
            userInfoAdvancedCheckBox.Name = "userInfoAdvancedCheckBox";
            userInfoAdvancedCheckBox.Size = new Size(135, 29);
            // userInfoAdvancedCheckBox.TabIndex = 10053;

            userInfoAdvancedCheckBox.Text = "Advanced";
            userInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            userInfoValuesPanel.BackColor = btnBackColor;
            userInfoValuesPanel.Location = new Point(3, 163);
            userInfoValuesPanel.Margin = btnPanelMargin;
            userInfoValuesPanel.Name = "userInfoValuesPanel";
            userInfoValuesPanel.Size = new Size(694, 35);
            // userInfoValuesPanel.TabIndex = 10061;

            userInfoValuesFontColorPictureBox.BackColor = Color.White;
            userInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            userInfoValuesFontColorPictureBox.Margin = btnPanelMargin;
            userInfoValuesFontColorPictureBox.Name = "userInfoValuesFontColorPictureBox";
            userInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            // userInfoValuesFontColorPictureBox.TabIndex = 45;

            userInfoValuesFontColorPictureBox.TabStop = false;
            userInfoValuesFontComboBox.BackColor = btnBackColor;
            userInfoValuesFontComboBox.Font = numUpDownFont;
            userInfoValuesFontComboBox.ForeColor = Color.White;
            userInfoValuesFontComboBox.FormattingEnabled = true;
            userInfoValuesFontComboBox.Location = new Point(290, 3);
            userInfoValuesFontComboBox.Margin = btnPanelMargin;
            userInfoValuesFontComboBox.Name = "userInfoValuesFontComboBox";
            userInfoValuesFontComboBox.Size = new Size(301, 28);
            // userInfoValuesFontComboBox.TabIndex = 45;

            userInfoBackgroundColorPictureBox.BackColor = Color.White;
            userInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            userInfoBackgroundColorPictureBox.Margin = btnPanelMargin;
            userInfoBackgroundColorPictureBox.Name = "userInfoBackgroundColorPictureBox";
            userInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            // userInfoBackgroundColorPictureBox.TabIndex = 42;

            userInfoBackgroundColorPictureBox.TabStop = false;
            userInfoNamesLabel.BackColor = Color.Transparent;
            userInfoNamesLabel.Font = labelFont;
            userInfoNamesLabel.ForeColor = foreColor;
            userInfoNamesLabel.Location = new Point(4, 6);
            userInfoNamesLabel.Margin = labelMargin;
            userInfoNamesLabel.Name = "userInfoNamesLabel";
            userInfoNamesLabel.Size = new Size(216, 25);
            // userInfoNamesLabel.TabIndex = 10065;

            userInfoNamesLabel.Text = "Names";
            userInfoNamesFontColorPictureBox.BackColor = Color.White;
            userInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            userInfoNamesFontColorPictureBox.Margin = btnPanelMargin;
            userInfoNamesFontColorPictureBox.Name = "userInfoNamesFontColorPictureBox";
            userInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            // userInfoNamesFontColorPictureBox.TabIndex = 45;

            userInfoNamesFontColorPictureBox.TabStop = false;
            userInfoNamesFontComboBox.BackColor = btnBackColor;
            userInfoNamesFontComboBox.Font = numUpDownFont;
            userInfoNamesFontComboBox.ForeColor = Color.White;
            userInfoNamesFontComboBox.FormattingEnabled = true;
            userInfoNamesFontComboBox.Location = new Point(290, 3);
            userInfoNamesFontComboBox.Margin = btnPanelMargin;
            userInfoNamesFontComboBox.Name = "userInfoNamesFontComboBox";
            userInfoNamesFontComboBox.Size = new Size(301, 28);
            // userInfoNamesFontComboBox.TabIndex = 45;

            userInfoNamesFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            userInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoNamesFontOutlineNumericUpDown.Font = numUpDownFont;
            userInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoNamesFontOutlineNumericUpDown.Margin = btnPanelMargin;
            userInfoNamesFontOutlineNumericUpDown.Maximum = 5;
            userInfoNamesFontOutlineNumericUpDown.Minimum = 1;
            userInfoNamesFontOutlineNumericUpDown.Name = "userInfoNamesFontOutlineNumericUpDown";
            userInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            // userInfoNamesFontOutlineNumericUpDown.TabIndex = 45;

            userInfoNamesFontOutlineNumericUpDown.Value = 1;
            userInfoNamesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoNamesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoNamesOutlineCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoNamesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoNamesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoNamesOutlineCheckBox.ForeColor = Color.White;
            userInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            userInfoNamesOutlineCheckBox.Margin = btnPanelMargin;
            userInfoNamesOutlineCheckBox.Name = "userInfoNamesOutlineCheckBox";
            userInfoNamesOutlineCheckBox.Size = new Size(22, 22);
            // userInfoNamesOutlineCheckBox.TabIndex = 45;

            userInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoNamesOutlineLabel.BackColor = Color.Transparent;
            userInfoNamesOutlineLabel.Font = labelFont;
            userInfoNamesOutlineLabel.ForeColor = foreColor;
            userInfoNamesOutlineLabel.Location = new Point(4, 5);
            userInfoNamesOutlineLabel.Margin = labelMargin;
            userInfoNamesOutlineLabel.Name = "userInfoNamesOutlineLabel";
            userInfoNamesOutlineLabel.Size = new Size(216, 25);
            // userInfoNamesOutlineLabel.TabIndex = 10066;

            userInfoNamesOutlineLabel.Text = "Names OutlineColor";
            userInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            userInfoNamesFontOutlineColorPictureBox.Margin = btnPanelMargin;
            userInfoNamesFontOutlineColorPictureBox.Name = "userInfoNamesFontOutlineColorPictureBox";
            userInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            // userInfoNamesFontOutlineColorPictureBox.TabIndex = 45;

            userInfoNamesFontOutlineColorPictureBox.TabStop = false;
            userInfoValuesOutlinePanel.BackColor = btnBackColor;
            userInfoValuesOutlinePanel.Location = new Point(3, 231);
            userInfoValuesOutlinePanel.Margin = btnPanelMargin;
            userInfoValuesOutlinePanel.Name = "userInfoValuesOutlinePanel";
            userInfoValuesOutlinePanel.Size = new Size(694, 35);
            // userInfoValuesOutlinePanel.TabIndex = 10067;

            userInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            userInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            userInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            userInfoValuesFontOutlineColorPictureBox.Margin = btnPanelMargin;
            userInfoValuesFontOutlineColorPictureBox.Name = "userInfoValuesFontOutlineColorPictureBox";
            userInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            // userInfoValuesFontOutlineColorPictureBox.TabIndex = 45;

            userInfoValuesFontOutlineColorPictureBox.TabStop = false;
            userInfoValuesFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            userInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            userInfoValuesFontOutlineNumericUpDown.Font = numUpDownFont;
            userInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            userInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            userInfoValuesFontOutlineNumericUpDown.Margin = btnPanelMargin;
            userInfoValuesFontOutlineNumericUpDown.Maximum = 5;
            userInfoValuesFontOutlineNumericUpDown.Minimum = 1;
            userInfoValuesFontOutlineNumericUpDown.Name = "userInfoValuesFontOutlineNumericUpDown";
            userInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            // userInfoValuesFontOutlineNumericUpDown.TabIndex = 45;

            userInfoValuesFontOutlineNumericUpDown.Value = 1;
            userInfoValuesOutlineCheckBox.BackColor = Color.Transparent;
            userInfoValuesOutlineCheckBox.FlatAppearance.BorderSize = 0;
            userInfoValuesOutlineCheckBox.FlatAppearance.CheckedBackColor = btnBackColor;
            userInfoValuesOutlineCheckBox.FlatStyle = FlatStyle.System;
            userInfoValuesOutlineCheckBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfoValuesOutlineCheckBox.ForeColor = Color.White;
            userInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            userInfoValuesOutlineCheckBox.Margin = btnPanelMargin;
            userInfoValuesOutlineCheckBox.Name = "userInfoValuesOutlineCheckBox";
            userInfoValuesOutlineCheckBox.Size = new Size(22, 22);
            // userInfoValuesOutlineCheckBox.TabIndex = 45;

            userInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            userInfoValuesPanel.ResumeLayout(false);
            userInfoValuesOutlinePanel.ResumeLayout(false);
        }

        #endregion
    }
}
