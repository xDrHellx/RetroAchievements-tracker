using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class GameInfoTab : AbstractTab
    {
        #region Sub elements

        public Label gameInfoReleasedLabel,
            gameInfoGenreLabel,
            gameInfoPublisherLabel,
            gameInfoDeveloperLabel,
            gameInfoNamesLabel,
            gameInfoNamesOutlineLabel,
            gameInfoTitleLabel;
        public NumericUpDown gameInfoNamesFontOutlineNumericUpDown,
            gameInfoValuesFontOutlineNumericUpDown;
        public TextBox gameInfoGenreTextBox,
            gameInfoTitleTextBox,
            gameInfoConsoleTextBox,
            gameInfoPublisherTextBox,
            gameInfoDeveloperTextBox,
            gameInfoReleaseDateTextBox;
        public PictureBox gameInfoPictureBox,
            gameInfoValuesFontColorPictureBox,
            gameInfoBackgroundColorPictureBox,
            gameInfoNamesFontColorPictureBox,
            gameInfoNamesFontOutlineColorPictureBox,
            gameInfoValuesFontOutlineColorPictureBox;
        public Button gameInfoDefaultButton,
            gameInfoOpenWindowButton;
        public CheckBox gameInfoGenreCheckBox,
            gameInfoTitleCheckBox,
            gameInfoConsoleCheckBox,
            gameInfoPublisherCheckBox,
            gameInfoDeveloperCheckBox,
            gameInfoAdvancedCheckBox,
            gameInfoAutoOpenWindowCheckbox,
            gameInfoNamesOutlineCheckBox,
            gameInfoValuesOutlineCheckBox,
            gameInfoReleasedCheckBox;
        public ComboBox gameInfoValuesFontComboBox,
            gameInfoNamesFontComboBox;
        public Panel gameInfoValuesPanel,
            gameInfoValuesOutlinePanel;

        #endregion

        #region Constructor

        public GameInfoTab()
        {
            Name = "GameInfoTabPage";
            Text = "Game Info";
            BackColor = btnBackColor;
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                gameInfoNamesLabel.Text = "Names";
                gameInfoNamesOutlineLabel.Text = "Names OutlineColor";

                SetFontFamilyBox(gameInfoNamesFontComboBox, GameInfoController.Instance.NameFontFamily);
                gameInfoNamesOutlineCheckBox.Checked = GameInfoController.Instance.NameOutlineEnabled;
                gameInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.NameColor);
                gameInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.NameOutlineColor);
            }
            else
            {
                gameInfoNamesLabel.Text = "Font";
                gameInfoNamesOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(gameInfoNamesFontComboBox, GameInfoController.Instance.SimpleFontFamily);
                gameInfoNamesOutlineCheckBox.Checked = GameInfoController.Instance.SimpleFontOutlineEnabled;
                gameInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.SimpleFontColor);
                gameInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameInfoController.Instance.SimpleFontOutlineColor);
            }

            gameInfoValuesPanel.Enabled = enable;
            gameInfoValuesOutlinePanel.Enabled = enable;
        }

        public override void InitElements()
        {
            gameInfoPictureBox = new PictureBox();
            gameInfoGenreLabel = new Label();
            gameInfoReleasedLabel = new Label();
            gameInfoPublisherLabel = new Label();
            gameInfoDeveloperLabel = new Label();
            gameInfoTitleLabel = new Label();
            gameInfoReleasedCheckBox = new CheckBox();
            gameInfoReleaseDateTextBox = new TextBox();
            gameInfoGenreCheckBox = new CheckBox();
            gameInfoGenreTextBox = new TextBox();
            gameInfoDefaultButton = new Button();
            gameInfoTitleCheckBox = new CheckBox();
            gameInfoTitleTextBox = new TextBox();
            gameInfoConsoleCheckBox = new CheckBox();
            gameInfoConsoleTextBox = new TextBox();
            gameInfoPublisherTextBox = new TextBox();
            gameInfoPublisherCheckBox = new CheckBox();
            gameInfoDeveloperTextBox = new TextBox();
            gameInfoDeveloperCheckBox = new CheckBox();
            gameInfoAdvancedCheckBox = new CheckBox();
            gameInfoOpenWindowButton = new Button();
            gameInfoValuesPanel = new Panel();
            gameInfoValuesFontColorPictureBox = new PictureBox();
            gameInfoValuesFontComboBox = new ComboBox();
            gameInfoAutoOpenWindowCheckbox = new CheckBox();
            gameInfoBackgroundColorPictureBox = new PictureBox();
            gameInfoNamesLabel = new Label();
            gameInfoNamesFontColorPictureBox = new PictureBox();
            gameInfoNamesFontComboBox = new ComboBox();
            gameInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoNamesOutlineCheckBox = new CheckBox();
            gameInfoNamesOutlineLabel = new Label();
            gameInfoNamesFontOutlineColorPictureBox = new PictureBox();
            gameInfoValuesOutlinePanel = new Panel();
            gameInfoValuesFontOutlineColorPictureBox = new PictureBox();
            gameInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoValuesOutlineCheckBox = new CheckBox();
            gameInfoValuesPanel.SuspendLayout();
            gameInfoValuesOutlinePanel.SuspendLayout();
            gameInfoPictureBox.BackColor = Color.Transparent;
            gameInfoPictureBox.Cursor = Cursors.Hand;
            gameInfoPictureBox.InitialImage = null;
            gameInfoPictureBox.Location = new Point(12, 80);
            gameInfoPictureBox.Margin = btnPanelMargin;
            gameInfoPictureBox.Name = "gameInfoPictureBox";
            gameInfoPictureBox.Size = new Size(144, 148);
            gameInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // gameInfoPictureBox.TabIndex = 10004;

            gameInfoPictureBox.TabStop = false;
            gameInfoGenreLabel.BackColor = Color.Transparent;
            gameInfoGenreLabel.Font = labelFont;
            gameInfoGenreLabel.ForeColor = btnForeColor;
            gameInfoGenreLabel.Location = new Point(154, 8);
            gameInfoGenreLabel.Margin = labelMargin;
            gameInfoGenreLabel.Name = "gameInfoGenreLabel";
            gameInfoGenreLabel.Size = new Size(363, 25);
            // gameInfoGenreLabel.TabIndex = 10066;

            gameInfoGenreLabel.UseMnemonic = false;
            gameInfoReleasedLabel.BackColor = Color.Transparent;
            gameInfoReleasedLabel.Font = labelFont;
            gameInfoReleasedLabel.ForeColor = foreColor;
            gameInfoReleasedLabel.Location = new Point(154, 8);
            gameInfoReleasedLabel.Margin = labelMargin;
            gameInfoReleasedLabel.Name = "gameInfoReleasedLabel";
            gameInfoReleasedLabel.Size = new Size(363, 25);
            // gameInfoReleasedLabel.TabIndex = 10067;

            gameInfoReleasedLabel.UseMnemonic = false;
            gameInfoPublisherLabel.BackColor = Color.Transparent;
            gameInfoPublisherLabel.Font = labelFont;
            gameInfoPublisherLabel.ForeColor = btnForeColor;
            gameInfoPublisherLabel.Location = new Point(154, 9);
            gameInfoPublisherLabel.Margin = labelMargin;
            gameInfoPublisherLabel.Name = "gameInfoPublisherLabel";
            gameInfoPublisherLabel.Size = new Size(363, 25);
            // gameInfoPublisherLabel.TabIndex = 10064;

            gameInfoPublisherLabel.UseMnemonic = false;
            gameInfoDeveloperLabel.BackColor = Color.Transparent;
            gameInfoDeveloperLabel.Font = labelFont;
            gameInfoDeveloperLabel.ForeColor = btnForeColor;
            gameInfoDeveloperLabel.Location = new Point(154, 5);
            gameInfoDeveloperLabel.Margin = labelMargin;
            gameInfoDeveloperLabel.Name = "gameInfoDeveloperLabel";
            gameInfoDeveloperLabel.Size = new Size(363, 25);
            // gameInfoDeveloperLabel.TabIndex = 10063;

            gameInfoDeveloperLabel.UseMnemonic = false;
            gameInfoTitleLabel.BackColor = Color.Transparent;
            gameInfoTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameInfoTitleLabel.ForeColor = foreColor;
            gameInfoTitleLabel.Location = new Point(4, 5);
            gameInfoTitleLabel.Margin = labelMargin;
            gameInfoTitleLabel.Name = "gameInfoTitleLabel";
            gameInfoTitleLabel.Size = new Size(688, 58);
            // gameInfoTitleLabel.TabIndex = 10058;

            gameInfoTitleLabel.Text = "Game Info Title";
            gameInfoTitleLabel.UseMnemonic = false;
            gameInfoReleasedCheckBox.AutoSize = true;
            gameInfoReleasedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoReleasedCheckBox.Location = new Point(338, 8);
            gameInfoReleasedCheckBox.Margin = btnPanelMargin;
            gameInfoReleasedCheckBox.Name = "gameInfoReleasedCheckBox";
            gameInfoReleasedCheckBox.Size = new Size(22, 21);
            // gameInfoReleasedCheckBox.TabIndex = 55;

            gameInfoReleasedCheckBox.UseVisualStyleBackColor = true;
            gameInfoReleaseDateTextBox.BackColor = btnBackColor;
            gameInfoReleaseDateTextBox.Font = labelFont;
            gameInfoReleaseDateTextBox.ForeColor = Color.White;
            gameInfoReleaseDateTextBox.Location = new Point(174, 0);
            gameInfoReleaseDateTextBox.Margin = btnPanelMargin;
            gameInfoReleaseDateTextBox.Name = "gameInfoReleaseDateTextBox";
            gameInfoReleaseDateTextBox.Size = new Size(146, 31);
            // gameInfoReleaseDateTextBox.TabIndex = 5;

            gameInfoReleaseDateTextBox.Text = "Released";
            gameInfoGenreCheckBox.AutoSize = true;
            gameInfoGenreCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoGenreCheckBox.Location = new Point(338, 8);
            gameInfoGenreCheckBox.Margin = btnPanelMargin;
            gameInfoGenreCheckBox.Name = "gameInfoGenreCheckBox";
            gameInfoGenreCheckBox.Size = new Size(22, 21);
            // gameInfoGenreCheckBox.TabIndex = 55;

            gameInfoGenreCheckBox.UseVisualStyleBackColor = true;
            gameInfoGenreTextBox.BackColor = btnBackColor;
            gameInfoGenreTextBox.Font = labelFont;
            gameInfoGenreTextBox.ForeColor = Color.White;
            gameInfoGenreTextBox.Location = new Point(174, 0);
            gameInfoGenreTextBox.Margin = btnPanelMargin;
            gameInfoGenreTextBox.Name = "gameInfoGenreTextBox";
            gameInfoGenreTextBox.Size = new Size(146, 31);
            // gameInfoGenreTextBox.TabIndex = 5;

            gameInfoGenreTextBox.Text = "Genre";
            gameInfoDefaultButton.BackColor = btnBackColor;
            gameInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            gameInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            gameInfoDefaultButton.Font = labelFont;
            gameInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            gameInfoDefaultButton.Location = new Point(306, 3);
            gameInfoDefaultButton.Margin = new Padding(0);
            gameInfoDefaultButton.Name = "gameInfoDefaultButton";
            gameInfoDefaultButton.Size = new Size(112, 42);
            // gameInfoDefaultButton.TabIndex = 39;

            gameInfoDefaultButton.Text = "Default";
            gameInfoDefaultButton.UseVisualStyleBackColor = false;
            gameInfoTitleCheckBox.AutoSize = true;
            gameInfoTitleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoTitleCheckBox.Location = new Point(338, 8);
            gameInfoTitleCheckBox.Margin = btnPanelMargin;
            gameInfoTitleCheckBox.Name = "gameInfoTitleCheckBox";
            gameInfoTitleCheckBox.Size = new Size(22, 21);
            // gameInfoTitleCheckBox.TabIndex = 52;

            gameInfoTitleCheckBox.UseVisualStyleBackColor = true;
            gameInfoTitleTextBox.BackColor = btnBackColor;
            gameInfoTitleTextBox.Font = labelFont;
            gameInfoTitleTextBox.ForeColor = Color.White;
            gameInfoTitleTextBox.Location = new Point(174, 0);
            gameInfoTitleTextBox.Margin = btnPanelMargin;
            gameInfoTitleTextBox.Name = "gameInfoTitleTextBox";
            gameInfoTitleTextBox.Size = new Size(146, 31);
            // gameInfoTitleTextBox.TabIndex = 1;

            gameInfoTitleTextBox.Text = "Title";
            gameInfoConsoleCheckBox.AutoSize = true;
            gameInfoConsoleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoConsoleCheckBox.Location = new Point(338, 8);
            gameInfoConsoleCheckBox.Margin = btnPanelMargin;
            gameInfoConsoleCheckBox.Name = "gameInfoConsoleCheckBox";
            gameInfoConsoleCheckBox.Size = new Size(22, 21);
            // gameInfoConsoleCheckBox.TabIndex = 55;

            gameInfoConsoleCheckBox.UseVisualStyleBackColor = true;
            gameInfoConsoleTextBox.BackColor = btnBackColor;
            gameInfoConsoleTextBox.Font = labelFont;
            gameInfoConsoleTextBox.ForeColor = Color.White;
            gameInfoConsoleTextBox.Location = new Point(174, 0);
            gameInfoConsoleTextBox.Margin = btnPanelMargin;
            gameInfoConsoleTextBox.Name = "gameInfoConsoleTextBox";
            gameInfoConsoleTextBox.Size = new Size(146, 31);
            // gameInfoConsoleTextBox.TabIndex = 5;

            gameInfoConsoleTextBox.Text = "Console";
            gameInfoPublisherTextBox.BackColor = btnBackColor;
            gameInfoPublisherTextBox.Font = labelFont;
            gameInfoPublisherTextBox.ForeColor = Color.White;
            gameInfoPublisherTextBox.Location = new Point(174, 0);
            gameInfoPublisherTextBox.Margin = btnPanelMargin;
            gameInfoPublisherTextBox.Name = "gameInfoPublisherTextBox";
            gameInfoPublisherTextBox.Size = new Size(146, 31);
            // gameInfoPublisherTextBox.TabIndex = 7;

            gameInfoPublisherTextBox.Text = "Publisher";
            gameInfoPublisherCheckBox.AutoSize = true;
            gameInfoPublisherCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoPublisherCheckBox.Location = new Point(338, 8);
            gameInfoPublisherCheckBox.Margin = btnPanelMargin;
            gameInfoPublisherCheckBox.Name = "gameInfoPublisherCheckBox";
            gameInfoPublisherCheckBox.Size = new Size(22, 21);
            // gameInfoPublisherCheckBox.TabIndex = 56;

            gameInfoPublisherCheckBox.UseVisualStyleBackColor = true;
            gameInfoDeveloperTextBox.BackColor = btnBackColor;
            gameInfoDeveloperTextBox.Font = labelFont;
            gameInfoDeveloperTextBox.ForeColor = Color.White;
            gameInfoDeveloperTextBox.Location = new Point(174, 0);
            gameInfoDeveloperTextBox.Margin = btnPanelMargin;
            gameInfoDeveloperTextBox.Name = "gameInfoDeveloperTextBox";
            gameInfoDeveloperTextBox.Size = new Size(146, 31);
            // gameInfoDeveloperTextBox.TabIndex = 6;

            gameInfoDeveloperTextBox.Text = "Developer";
            gameInfoDeveloperCheckBox.AutoSize = true;
            gameInfoDeveloperCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameInfoDeveloperCheckBox.Location = new Point(338, 8);
            gameInfoDeveloperCheckBox.Margin = btnPanelMargin;
            gameInfoDeveloperCheckBox.Name = "gameInfoDeveloperCheckBox";
            gameInfoDeveloperCheckBox.Size = new Size(22, 21);
            // gameInfoDeveloperCheckBox.TabIndex = 54;

            gameInfoDeveloperCheckBox.UseVisualStyleBackColor = true;
            gameInfoAdvancedCheckBox.AutoSize = true;
            gameInfoAdvancedCheckBox.BackColor = Color.Transparent;
            gameInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoAdvancedCheckBox.Font = labelFont;
            gameInfoAdvancedCheckBox.ForeColor = foreColor;
            gameInfoAdvancedCheckBox.Location = new Point(8, 3);
            gameInfoAdvancedCheckBox.Margin = btnPanelMargin;
            gameInfoAdvancedCheckBox.Name = "gameInfoAdvancedCheckBox";
            gameInfoAdvancedCheckBox.Size = new Size(135, 29);
            // gameInfoAdvancedCheckBox.TabIndex = 10053;

            gameInfoAdvancedCheckBox.Text = "Advanced";
            gameInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            gameInfoOpenWindowButton.BackColor = btnBackColor;
            gameInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            gameInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            gameInfoOpenWindowButton.Font = labelFont;
            gameInfoOpenWindowButton.ForeColor = btnForeColor;
            gameInfoOpenWindowButton.Location = new Point(573, 3);
            gameInfoOpenWindowButton.Margin = new Padding(0);
            gameInfoOpenWindowButton.Name = "gameInfoOpenWindowButton";
            gameInfoOpenWindowButton.Size = new Size(112, 42);
            // gameInfoOpenWindowButton.TabIndex = 10021;

            gameInfoOpenWindowButton.Text = "Open";
            gameInfoOpenWindowButton.UseVisualStyleBackColor = false;
            gameInfoValuesPanel.BackColor = btnBackColor;
            gameInfoValuesPanel.Location = new Point(3, 163);
            gameInfoValuesPanel.Margin = btnPanelMargin;
            gameInfoValuesPanel.Name = "gameInfoValuesPanel";
            gameInfoValuesPanel.Size = new Size(694, 35);
            // gameInfoValuesPanel.TabIndex = 10061;

            gameInfoValuesFontColorPictureBox.BackColor = Color.White;
            gameInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            gameInfoValuesFontColorPictureBox.Margin = btnPanelMargin;
            gameInfoValuesFontColorPictureBox.Name = "gameInfoValuesFontColorPictureBox";
            gameInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            // gameInfoValuesFontColorPictureBox.TabIndex = 45;

            gameInfoValuesFontColorPictureBox.TabStop = false;
            gameInfoValuesFontComboBox.BackColor = btnBackColor;
            gameInfoValuesFontComboBox.Font = numUpDownFont;
            gameInfoValuesFontComboBox.ForeColor = Color.White;
            gameInfoValuesFontComboBox.FormattingEnabled = true;
            gameInfoValuesFontComboBox.Location = new Point(290, 3);
            gameInfoValuesFontComboBox.Margin = btnPanelMargin;
            gameInfoValuesFontComboBox.Name = "gameInfoValuesFontComboBox";
            gameInfoValuesFontComboBox.Size = new Size(301, 28);
            // gameInfoValuesFontComboBox.TabIndex = 45;

            gameInfoAutoOpenWindowCheckbox.AutoSize = true;
            gameInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoAutoOpenWindowCheckbox.Font = labelFont;
            gameInfoAutoOpenWindowCheckbox.ForeColor = foreColor;
            gameInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            gameInfoAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            gameInfoAutoOpenWindowCheckbox.Name = "gameInfoAutoOpenWindowCheckbox";
            gameInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            // gameInfoAutoOpenWindowCheckbox.TabIndex = 10022;

            gameInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            gameInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            gameInfoBackgroundColorPictureBox.BackColor = Color.White;
            gameInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            gameInfoBackgroundColorPictureBox.Margin = btnPanelMargin;
            gameInfoBackgroundColorPictureBox.Name = "gameInfoBackgroundColorPictureBox";
            gameInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            // gameInfoBackgroundColorPictureBox.TabIndex = 42;

            gameInfoBackgroundColorPictureBox.TabStop = false;
            gameInfoNamesLabel.BackColor = Color.Transparent;
            gameInfoNamesLabel.Font = labelFont;
            gameInfoNamesLabel.ForeColor = foreColor;
            gameInfoNamesLabel.Location = new Point(4, 6);
            gameInfoNamesLabel.Margin = labelMargin;
            gameInfoNamesLabel.Name = "gameInfoNamesLabel";
            gameInfoNamesLabel.Size = new Size(216, 25);
            // gameInfoNamesLabel.TabIndex = 10065;

            gameInfoNamesLabel.Text = "Names";
            gameInfoNamesFontColorPictureBox.BackColor = Color.White;
            gameInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            gameInfoNamesFontColorPictureBox.Margin = btnPanelMargin;
            gameInfoNamesFontColorPictureBox.Name = "gameInfoNamesFontColorPictureBox";
            gameInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            // gameInfoNamesFontColorPictureBox.TabIndex = 45;

            gameInfoNamesFontColorPictureBox.TabStop = false;
            gameInfoNamesFontComboBox.BackColor = btnBackColor;
            gameInfoNamesFontComboBox.Font = numUpDownFont;
            gameInfoNamesFontComboBox.ForeColor = Color.White;
            gameInfoNamesFontComboBox.FormattingEnabled = true;
            gameInfoNamesFontComboBox.Location = new Point(290, 3);
            gameInfoNamesFontComboBox.Margin = btnPanelMargin;
            gameInfoNamesFontComboBox.Name = "gameInfoNamesFontComboBox";
            gameInfoNamesFontComboBox.Size = new Size(301, 28);
            // gameInfoNamesFontComboBox.TabIndex = 45;

            gameInfoNamesFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            gameInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoNamesFontOutlineNumericUpDown.Font = numUpDownFont;
            gameInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoNamesFontOutlineNumericUpDown.Margin = btnPanelMargin;
            gameInfoNamesFontOutlineNumericUpDown.Maximum = 5;
            gameInfoNamesFontOutlineNumericUpDown.Minimum = 1;
            gameInfoNamesFontOutlineNumericUpDown.Name = "gameInfoNamesFontOutlineNumericUpDown";
            gameInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            // gameInfoNamesFontOutlineNumericUpDown.TabIndex = 45;

            gameInfoNamesFontOutlineNumericUpDown.Value = 1;
            gameInfoNamesOutlineCheckBox.AutoSize = true;
            gameInfoNamesOutlineCheckBox.Font = labelFont;
            gameInfoNamesOutlineCheckBox.ForeColor = foreColor;
            gameInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            gameInfoNamesOutlineCheckBox.Margin = btnPanelMargin;
            gameInfoNamesOutlineCheckBox.Name = "gameInfoNamesOutlineCheckBox";
            gameInfoNamesOutlineCheckBox.Size = new Size(22, 21);
            // gameInfoNamesOutlineCheckBox.TabIndex = 45;

            gameInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoNamesOutlineLabel.BackColor = Color.Transparent;
            gameInfoNamesOutlineLabel.Font = labelFont;
            gameInfoNamesOutlineLabel.ForeColor = foreColor;
            gameInfoNamesOutlineLabel.Location = new Point(4, 5);
            gameInfoNamesOutlineLabel.Margin = labelMargin;
            gameInfoNamesOutlineLabel.Name = "gameInfoNamesOutlineLabel";
            gameInfoNamesOutlineLabel.Size = new Size(216, 25);
            // gameInfoNamesOutlineLabel.TabIndex = 10066;

            gameInfoNamesOutlineLabel.Text = "Names OutlineColor";
            gameInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            gameInfoNamesFontOutlineColorPictureBox.Margin = btnPanelMargin;
            gameInfoNamesFontOutlineColorPictureBox.Name = "gameInfoNamesFontOutlineColorPictureBox";
            gameInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            // gameInfoNamesFontOutlineColorPictureBox.TabIndex = 45;

            gameInfoNamesFontOutlineColorPictureBox.TabStop = false;
            gameInfoValuesOutlinePanel.BackColor = btnBackColor;
            gameInfoValuesOutlinePanel.Location = new Point(3, 231);
            gameInfoValuesOutlinePanel.Margin = btnPanelMargin;
            gameInfoValuesOutlinePanel.Name = "gameInfoValuesOutlinePanel";
            gameInfoValuesOutlinePanel.Size = new Size(694, 35);
            // gameInfoValuesOutlinePanel.TabIndex = 10067;

            gameInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            gameInfoValuesFontOutlineColorPictureBox.Margin = btnPanelMargin;
            gameInfoValuesFontOutlineColorPictureBox.Name = "gameInfoValuesFontOutlineColorPictureBox";
            gameInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            // gameInfoValuesFontOutlineColorPictureBox.TabIndex = 45;

            gameInfoValuesFontOutlineColorPictureBox.TabStop = false;
            gameInfoValuesFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            gameInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoValuesFontOutlineNumericUpDown.Font = numUpDownFont;
            gameInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoValuesFontOutlineNumericUpDown.Margin = btnPanelMargin;
            gameInfoValuesFontOutlineNumericUpDown.Maximum = 5;
            gameInfoValuesFontOutlineNumericUpDown.Minimum = 1;
            gameInfoValuesFontOutlineNumericUpDown.Name = "gameInfoValuesFontOutlineNumericUpDown";
            gameInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            // gameInfoValuesFontOutlineNumericUpDown.TabIndex = 45;

            gameInfoValuesFontOutlineNumericUpDown.Value = 1;
            gameInfoValuesOutlineCheckBox.AutoSize = true;
            gameInfoValuesOutlineCheckBox.Font = labelFont;
            gameInfoValuesOutlineCheckBox.ForeColor = foreColor;
            gameInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            gameInfoValuesOutlineCheckBox.Margin = btnPanelMargin;
            gameInfoValuesOutlineCheckBox.Name = "gameInfoValuesOutlineCheckBox";
            gameInfoValuesOutlineCheckBox.Size = new Size(22, 21);
            // gameInfoValuesOutlineCheckBox.TabIndex = 45;

            gameInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoValuesPanel.ResumeLayout(false);
            gameInfoValuesOutlinePanel.ResumeLayout(false);
            gameInfoValuesOutlinePanel.PerformLayout();
        }

        #endregion
    }
}
