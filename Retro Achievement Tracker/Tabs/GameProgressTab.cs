using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class GameProgressTab : AbstractTab
    {
        #region Sub elements

        public Label gameProgressTruePoints1Label,
            gameProgressPoints1Label,
            gameProgressAchievements1Label,
            gameProgressNamesLabel,
            gameProgressNamesOutlineLabel,
            gameProgressCompletedLabel,
            gameProgressHaveEarnedLabel,
            gameProgressAchievements2Label,
            gameProgressPointsTextLabel,
            gameProgressHardcoreWorthLabel,
            gameProgressPoints2Label,
            gameProgressTruePoints2Label;
        public NumericUpDown gameProgressNamesFontOutlineNumericUpDown,
            gameProgressValuesFontOutlineNumericUpDown;
        public TextBox gameProgressAchievementsTextBox,
            gameProgressRatioTextBox,
            gameProgressTruePointsTextBox,
            gameProgressPointsTextBox,
            gameProgressCompletedTextBox;
        public PictureBox gameProgressValuesFontColorPictureBox,
            gameProgressBackgroundColorPictureBox,
            gameProgressNamesFontColorPictureBox,
            gameProgressNamesFontOutlineColorPictureBox,
            gameProgressValuesFontOutlineColorPictureBox,
            gameProgressPercentCompletePictureBox,
            gameProgressMasteryPictureBox;
        public Button gameProgressDefaultButton,
            gameProgressOpenWindowButton;
        public CheckBox gameProgressAchievementsCheckBox,
            gameProgressRatioCheckBox,
            gameProgressTruePointsCheckBox,
            gameProgressPointsCheckBox,
            gameProgressAdvancedCheckBox,
            gameProgressAutoOpenWindowCheckbox,
            gameProgressNamesOutlineCheckBox,
            gameProgressValuesOutlineCheckBox,
            gameProgressCompletedCheckBox;
        public ComboBox gameProgressValuesFontComboBox,
            gameProgressNamesFontComboBox;
        public RadioButton gameProgressRadioButtonPeriod,
            gameProgressRadioButtonColon,
            gameProgressRadioButtonBackslash;
        public Panel gameProgressValuesPanel,
            gameProgressValuesOutlinePanel;

        #endregion

        #region Constructor

        public GameProgressTab()
        {
            Name = "GameProgressTabPage";
            Text = "Progress";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                gameProgressNamesLabel.Text = "Names";
                gameProgressNamesOutlineLabel.Text = "Names OutlineColor";

                SetFontFamilyBox(gameProgressNamesFontComboBox, GameProgressController.Instance.NameFontFamily);
                gameProgressNamesOutlineCheckBox.Checked = GameProgressController.Instance.NameOutlineEnabled;
                gameProgressNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.NameColor);
                gameProgressNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.NameOutlineColor);
            }
            else
            {
                gameProgressNamesLabel.Text = "Font";
                gameProgressNamesOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(gameProgressNamesFontComboBox, GameProgressController.Instance.SimpleFontFamily);
                gameProgressNamesOutlineCheckBox.Checked = GameProgressController.Instance.SimpleFontOutlineEnabled;
                gameProgressNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.SimpleFontColor);
                gameProgressNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(GameProgressController.Instance.SimpleFontOutlineColor);
            }

            gameProgressValuesPanel.Enabled = enable;
            gameProgressValuesOutlinePanel.Enabled = enable;
        }

        public override void InitElements()
        {
            gameProgressPointsTextLabel = new Label();
            gameProgressHardcoreWorthLabel = new Label();
            gameProgressPoints2Label = new Label();
            gameProgressTruePoints2Label = new Label();
            gameProgressAchievements2Label = new Label();
            gameProgressHaveEarnedLabel = new Label();
            gameProgressPercentCompletePictureBox = new PictureBox();
            gameProgressMasteryPictureBox = new PictureBox();
            gameProgressAchievements1Label = new Label();
            gameProgressPoints1Label = new Label();
            gameProgressCompletedLabel = new Label();
            gameProgressTruePoints1Label = new Label();
            gameProgressAdvancedCheckBox = new CheckBox();
            gameProgressOpenWindowButton = new Button();
            gameProgressValuesPanel = new Panel();
            gameProgressValuesFontColorPictureBox = new PictureBox();
            gameProgressValuesFontComboBox = new ComboBox();
            gameProgressAutoOpenWindowCheckbox = new CheckBox();
            gameProgressBackgroundColorPictureBox = new PictureBox();
            gameProgressNamesLabel = new Label();
            gameProgressNamesFontColorPictureBox = new PictureBox();
            gameProgressNamesFontComboBox = new ComboBox();
            gameProgressNamesFontOutlineNumericUpDown = new NumericUpDown();
            gameProgressNamesOutlineCheckBox = new CheckBox();
            gameProgressNamesOutlineLabel = new Label();
            gameProgressNamesFontOutlineColorPictureBox = new PictureBox();
            gameProgressValuesOutlinePanel = new Panel();
            gameProgressValuesFontOutlineColorPictureBox = new PictureBox();
            gameProgressValuesFontOutlineNumericUpDown = new NumericUpDown();
            gameProgressValuesOutlineCheckBox = new CheckBox();
            gameProgressRadioButtonPeriod = new RadioButton();
            gameProgressRadioButtonColon = new RadioButton();
            gameProgressRadioButtonBackslash = new RadioButton();
            gameProgressCompletedTextBox = new TextBox();
            gameProgressCompletedCheckBox = new CheckBox();
            gameProgressDefaultButton = new Button();
            gameProgressAchievementsCheckBox = new CheckBox();
            gameProgressAchievementsTextBox = new TextBox();
            gameProgressRatioCheckBox = new CheckBox();
            gameProgressRatioTextBox = new TextBox();
            gameProgressTruePointsTextBox = new TextBox();
            gameProgressTruePointsCheckBox = new CheckBox();
            gameProgressPointsTextBox = new TextBox();
            gameProgressPointsCheckBox = new CheckBox();
            gameProgressValuesPanel.SuspendLayout();
            gameProgressValuesOutlinePanel.SuspendLayout();
            gameProgressPointsTextLabel.AutoSize = true;
            gameProgressPointsTextLabel.BackColor = Color.Transparent;
            gameProgressPointsTextLabel.Font = new Font("Verdana", 9.75F);
            gameProgressPointsTextLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressPointsTextLabel.Location = new Point(178, 126);
            gameProgressPointsTextLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressPointsTextLabel.Name = "gameProgressPointsTextLabel";
            gameProgressPointsTextLabel.Size = new Size(80, 25);
            gameProgressPointsTextLabel.TabIndex = 10074;
            gameProgressPointsTextLabel.Text = "points.";
            gameProgressHardcoreWorthLabel.AutoSize = true;
            gameProgressHardcoreWorthLabel.BackColor = Color.Transparent;
            gameProgressHardcoreWorthLabel.Font = new Font("Verdana", 9.75F);
            gameProgressHardcoreWorthLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressHardcoreWorthLabel.Location = new Point(231, 95);
            gameProgressHardcoreWorthLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressHardcoreWorthLabel.Name = "gameProgressHardcoreWorthLabel";
            gameProgressHardcoreWorthLabel.Size = new Size(345, 25);
            gameProgressHardcoreWorthLabel.TabIndex = 10073;
            gameProgressHardcoreWorthLabel.Text = "HARDCORE achievements, worth";
            gameProgressPoints2Label.BackColor = Color.Transparent;
            gameProgressPoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressPoints2Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressPoints2Label.Location = new Point(8, 126);
            gameProgressPoints2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressPoints2Label.Name = "gameProgressPoints2Label";
            gameProgressPoints2Label.Size = new Size(82, 25);
            gameProgressPoints2Label.TabIndex = 10071;
            gameProgressPoints2Label.Text = "99999";
            gameProgressPoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressTruePoints2Label.BackColor = Color.Transparent;
            gameProgressTruePoints2Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTruePoints2Label.ForeColor = Color.White;
            gameProgressTruePoints2Label.Location = new Point(81, 126);
            gameProgressTruePoints2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTruePoints2Label.Name = "gameProgressTruePoints2Label";
            gameProgressTruePoints2Label.Size = new Size(108, 25);
            gameProgressTruePoints2Label.TabIndex = 10072;
            gameProgressTruePoints2Label.Text = "(999999)";
            gameProgressTruePoints2Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressAchievements2Label.BackColor = Color.Transparent;
            gameProgressAchievements2Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAchievements2Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressAchievements2Label.Location = new Point(180, 95);
            gameProgressAchievements2Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressAchievements2Label.Name = "gameProgressAchievements2Label";
            gameProgressAchievements2Label.Size = new Size(52, 25);
            gameProgressAchievements2Label.TabIndex = 10070;
            gameProgressAchievements2Label.Text = "999";
            gameProgressAchievements2Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressHaveEarnedLabel.AutoSize = true;
            gameProgressHaveEarnedLabel.BackColor = Color.Transparent;
            gameProgressHaveEarnedLabel.Font = new Font("Verdana", 9.75F);
            gameProgressHaveEarnedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressHaveEarnedLabel.Location = new Point(8, 95);
            gameProgressHaveEarnedLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressHaveEarnedLabel.Name = "gameProgressHaveEarnedLabel";
            gameProgressHaveEarnedLabel.Size = new Size(181, 25);
            gameProgressHaveEarnedLabel.TabIndex = 10069;
            gameProgressHaveEarnedLabel.Text = "You have earned";
            gameProgressPercentCompletePictureBox.BackColor = Color.FromArgb(204, 153, 0);
            gameProgressPercentCompletePictureBox.Location = new Point(381, 220);
            gameProgressPercentCompletePictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressPercentCompletePictureBox.Name = "gameProgressPercentCompletePictureBox";
            gameProgressPercentCompletePictureBox.Size = new Size(273, 5);
            gameProgressPercentCompletePictureBox.TabIndex = 10066;
            gameProgressPercentCompletePictureBox.TabStop = false;
            gameProgressMasteryPictureBox.Image = Properties.Resources.mastered_icon;
            gameProgressMasteryPictureBox.Location = new Point(656, 208);
            gameProgressMasteryPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressMasteryPictureBox.Name = "gameProgressMasteryPictureBox";
            gameProgressMasteryPictureBox.Size = new Size(30, 31);
            gameProgressMasteryPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameProgressMasteryPictureBox.TabIndex = 10068;
            gameProgressMasteryPictureBox.TabStop = false;
            gameProgressAchievements1Label.BackColor = Color.Transparent;
            gameProgressAchievements1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAchievements1Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressAchievements1Label.Location = new Point(111, 63);
            gameProgressAchievements1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressAchievements1Label.Name = "gameProgressAchievements1Label";
            gameProgressAchievements1Label.Size = new Size(52, 25);
            gameProgressAchievements1Label.TabIndex = 10058;
            gameProgressAchievements1Label.Text = "999";
            gameProgressAchievements1Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressPoints1Label.BackColor = Color.Transparent;
            gameProgressPoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressPoints1Label.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressPoints1Label.Location = new Point(374, 63);
            gameProgressPoints1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressPoints1Label.Name = "gameProgressPoints1Label";
            gameProgressPoints1Label.Size = new Size(82, 25);
            gameProgressPoints1Label.TabIndex = 10059;
            gameProgressPoints1Label.Text = "99999";
            gameProgressPoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressCompletedLabel.BackColor = Color.Transparent;
            gameProgressCompletedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressCompletedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressCompletedLabel.Location = new Point(448, 245);
            gameProgressCompletedLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressCompletedLabel.Name = "gameProgressCompletedLabel";
            gameProgressCompletedLabel.Size = new Size(168, 25);
            gameProgressCompletedLabel.TabIndex = 10061;
            gameProgressCompletedLabel.Text = "0% Complete";
            gameProgressTruePoints1Label.BackColor = Color.Transparent;
            gameProgressTruePoints1Label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTruePoints1Label.ForeColor = Color.White;
            gameProgressTruePoints1Label.Location = new Point(448, 63);
            gameProgressTruePoints1Label.Margin = new Padding(4, 0, 4, 0);
            gameProgressTruePoints1Label.Name = "gameProgressTruePoints1Label";
            gameProgressTruePoints1Label.Size = new Size(114, 25);
            gameProgressTruePoints1Label.TabIndex = 10060;
            gameProgressTruePoints1Label.Text = "(999999)";
            gameProgressTruePoints1Label.TextAlign = ContentAlignment.MiddleCenter;
            gameProgressAdvancedCheckBox.AutoSize = true;
            gameProgressAdvancedCheckBox.BackColor = Color.Transparent;
            gameProgressAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            gameProgressAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressAdvancedCheckBox.Location = new Point(8, 3);
            gameProgressAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressAdvancedCheckBox.Name = "gameProgressAdvancedCheckBox";
            gameProgressAdvancedCheckBox.Size = new Size(135, 29);
            gameProgressAdvancedCheckBox.TabIndex = 10053;
            gameProgressAdvancedCheckBox.Text = "Advanced";
            gameProgressAdvancedCheckBox.UseVisualStyleBackColor = false;
            gameProgressOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            gameProgressOpenWindowButton.FlatStyle = FlatStyle.Flat;
            gameProgressOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            gameProgressOpenWindowButton.Location = new Point(573, 3);
            gameProgressOpenWindowButton.Margin = new Padding(0);
            gameProgressOpenWindowButton.Name = "gameProgressOpenWindowButton";
            gameProgressOpenWindowButton.Size = new Size(112, 42);
            gameProgressOpenWindowButton.TabIndex = 10021;
            gameProgressOpenWindowButton.Text = "Open";
            gameProgressOpenWindowButton.UseVisualStyleBackColor = false;
            gameProgressValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressValuesPanel.Location = new Point(3, 163);
            gameProgressValuesPanel.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesPanel.Name = "gameProgressValuesPanel";
            gameProgressValuesPanel.Size = new Size(694, 35);
            gameProgressValuesPanel.TabIndex = 10061;
            gameProgressValuesFontColorPictureBox.BackColor = Color.White;
            gameProgressValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressValuesFontColorPictureBox.Location = new Point(230, 5);
            gameProgressValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesFontColorPictureBox.Name = "gameProgressValuesFontColorPictureBox";
            gameProgressValuesFontColorPictureBox.Size = new Size(22, 22);
            gameProgressValuesFontColorPictureBox.TabIndex = 45;
            gameProgressValuesFontColorPictureBox.TabStop = false;
            gameProgressValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressValuesFontComboBox.ForeColor = Color.White;
            gameProgressValuesFontComboBox.FormattingEnabled = true;
            gameProgressValuesFontComboBox.Location = new Point(290, 3);
            gameProgressValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesFontComboBox.Name = "gameProgressValuesFontComboBox";
            gameProgressValuesFontComboBox.Size = new Size(301, 28);
            gameProgressValuesFontComboBox.TabIndex = 45;
            gameProgressAutoOpenWindowCheckbox.AutoSize = true;
            gameProgressAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            gameProgressAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressAutoOpenWindowCheckbox.Location = new Point(378, 14);
            gameProgressAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            gameProgressAutoOpenWindowCheckbox.Name = "gameProgressAutoOpenWindowCheckbox";
            gameProgressAutoOpenWindowCheckbox.Size = new Size(147, 29);
            gameProgressAutoOpenWindowCheckbox.TabIndex = 10022;
            gameProgressAutoOpenWindowCheckbox.Text = "Auto-Open";
            gameProgressAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            gameProgressBackgroundColorPictureBox.BackColor = Color.White;
            gameProgressBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressBackgroundColorPictureBox.Location = new Point(230, 5);
            gameProgressBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressBackgroundColorPictureBox.Name = "gameProgressBackgroundColorPictureBox";
            gameProgressBackgroundColorPictureBox.Size = new Size(22, 22);
            gameProgressBackgroundColorPictureBox.TabIndex = 42;
            gameProgressBackgroundColorPictureBox.TabStop = false;
            gameProgressNamesLabel.BackColor = Color.Transparent;
            gameProgressNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressNamesLabel.Location = new Point(4, 6);
            gameProgressNamesLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressNamesLabel.Name = "gameProgressNamesLabel";
            gameProgressNamesLabel.Size = new Size(216, 25);
            gameProgressNamesLabel.TabIndex = 10065;
            gameProgressNamesLabel.Text = "Names";
            gameProgressNamesFontColorPictureBox.BackColor = Color.White;
            gameProgressNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressNamesFontColorPictureBox.Location = new Point(230, 6);
            gameProgressNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressNamesFontColorPictureBox.Name = "gameProgressNamesFontColorPictureBox";
            gameProgressNamesFontColorPictureBox.Size = new Size(22, 22);
            gameProgressNamesFontColorPictureBox.TabIndex = 45;
            gameProgressNamesFontColorPictureBox.TabStop = false;
            gameProgressNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressNamesFontComboBox.ForeColor = Color.White;
            gameProgressNamesFontComboBox.FormattingEnabled = true;
            gameProgressNamesFontComboBox.Location = new Point(290, 3);
            gameProgressNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressNamesFontComboBox.Name = "gameProgressNamesFontComboBox";
            gameProgressNamesFontComboBox.Size = new Size(301, 28);
            gameProgressNamesFontComboBox.TabIndex = 45;
            gameProgressNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameProgressNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameProgressNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameProgressNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameProgressNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameProgressNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gameProgressNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gameProgressNamesFontOutlineNumericUpDown.Name = "gameProgressNamesFontOutlineNumericUpDown";
            gameProgressNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameProgressNamesFontOutlineNumericUpDown.TabIndex = 45;
            gameProgressNamesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            gameProgressNamesOutlineCheckBox.AutoSize = true;
            gameProgressNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressNamesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressNamesOutlineCheckBox.Location = new Point(620, 8);
            gameProgressNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressNamesOutlineCheckBox.Name = "gameProgressNamesOutlineCheckBox";
            gameProgressNamesOutlineCheckBox.Size = new Size(22, 21);
            gameProgressNamesOutlineCheckBox.TabIndex = 45;
            gameProgressNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameProgressNamesOutlineLabel.BackColor = Color.Transparent;
            gameProgressNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressNamesOutlineLabel.Location = new Point(4, 5);
            gameProgressNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            gameProgressNamesOutlineLabel.Name = "gameProgressNamesOutlineLabel";
            gameProgressNamesOutlineLabel.Size = new Size(216, 25);
            gameProgressNamesOutlineLabel.TabIndex = 10066;
            gameProgressNamesOutlineLabel.Text = "Names OutlineColor";
            gameProgressNamesFontOutlineColorPictureBox.BackColor = Color.White;
            gameProgressNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            gameProgressNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressNamesFontOutlineColorPictureBox.Name = "gameProgressNamesFontOutlineColorPictureBox";
            gameProgressNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameProgressNamesFontOutlineColorPictureBox.TabIndex = 45;
            gameProgressNamesFontOutlineColorPictureBox.TabStop = false;
            gameProgressValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressValuesOutlinePanel.Location = new Point(3, 231);
            gameProgressValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesOutlinePanel.Name = "gameProgressValuesOutlinePanel";
            gameProgressValuesOutlinePanel.Size = new Size(694, 35);
            gameProgressValuesOutlinePanel.TabIndex = 10067;
            gameProgressValuesFontOutlineColorPictureBox.BackColor = Color.White;
            gameProgressValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameProgressValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            gameProgressValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesFontOutlineColorPictureBox.Name = "gameProgressValuesFontOutlineColorPictureBox";
            gameProgressValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameProgressValuesFontOutlineColorPictureBox.TabIndex = 45;
            gameProgressValuesFontOutlineColorPictureBox.TabStop = false;
            gameProgressValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameProgressValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameProgressValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameProgressValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameProgressValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gameProgressValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gameProgressValuesFontOutlineNumericUpDown.Name = "gameProgressValuesFontOutlineNumericUpDown";
            gameProgressValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameProgressValuesFontOutlineNumericUpDown.TabIndex = 45;
            gameProgressValuesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            gameProgressValuesOutlineCheckBox.AutoSize = true;
            gameProgressValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressValuesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameProgressValuesOutlineCheckBox.Location = new Point(620, 9);
            gameProgressValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressValuesOutlineCheckBox.Name = "gameProgressValuesOutlineCheckBox";
            gameProgressValuesOutlineCheckBox.Size = new Size(22, 21);
            gameProgressValuesOutlineCheckBox.TabIndex = 45;
            gameProgressValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameProgressRadioButtonPeriod.AutoSize = true;
            gameProgressRadioButtonPeriod.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressRadioButtonPeriod.Location = new Point(320, 8);
            gameProgressRadioButtonPeriod.Margin = new Padding(4, 5, 4, 5);
            gameProgressRadioButtonPeriod.Name = "gameProgressRadioButtonPeriod";
            gameProgressRadioButtonPeriod.Size = new Size(21, 20);
            gameProgressRadioButtonPeriod.TabIndex = 10073;
            gameProgressRadioButtonPeriod.UseVisualStyleBackColor = true;
            gameProgressRadioButtonColon.AutoSize = true;
            gameProgressRadioButtonColon.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressRadioButtonColon.Location = new Point(237, 8);
            gameProgressRadioButtonColon.Margin = new Padding(4, 5, 4, 5);
            gameProgressRadioButtonColon.Name = "gameProgressRadioButtonColon";
            gameProgressRadioButtonColon.Size = new Size(21, 20);
            gameProgressRadioButtonColon.TabIndex = 10071;
            gameProgressRadioButtonColon.UseVisualStyleBackColor = true;
            gameProgressRadioButtonBackslash.AutoSize = true;
            gameProgressRadioButtonBackslash.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressRadioButtonBackslash.Location = new Point(150, 8);
            gameProgressRadioButtonBackslash.Margin = new Padding(4, 5, 4, 5);
            gameProgressRadioButtonBackslash.Name = "gameProgressRadioButtonBackslash";
            gameProgressRadioButtonBackslash.Size = new Size(21, 20);
            gameProgressRadioButtonBackslash.TabIndex = 10067;
            gameProgressRadioButtonBackslash.UseVisualStyleBackColor = true;
            gameProgressCompletedTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressCompletedTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressCompletedTextBox.ForeColor = Color.White;
            gameProgressCompletedTextBox.Location = new Point(174, 0);
            gameProgressCompletedTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressCompletedTextBox.Name = "gameProgressCompletedTextBox";
            gameProgressCompletedTextBox.Size = new Size(146, 31);
            gameProgressCompletedTextBox.TabIndex = 7;
            gameProgressCompletedTextBox.Text = "Completed";
            gameProgressCompletedCheckBox.AutoSize = true;
            gameProgressCompletedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressCompletedCheckBox.Location = new Point(338, 8);
            gameProgressCompletedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressCompletedCheckBox.Name = "gameProgressCompletedCheckBox";
            gameProgressCompletedCheckBox.Size = new Size(22, 21);
            gameProgressCompletedCheckBox.TabIndex = 56;
            gameProgressCompletedCheckBox.UseVisualStyleBackColor = true;
            gameProgressDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            gameProgressDefaultButton.FlatStyle = FlatStyle.Flat;
            gameProgressDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            gameProgressDefaultButton.Location = new Point(306, 3);
            gameProgressDefaultButton.Margin = new Padding(0);
            gameProgressDefaultButton.Name = "gameProgressDefaultButton";
            gameProgressDefaultButton.Size = new Size(112, 42);
            gameProgressDefaultButton.TabIndex = 39;
            gameProgressDefaultButton.Text = "Default";
            gameProgressDefaultButton.UseVisualStyleBackColor = false;
            gameProgressAchievementsCheckBox.AutoSize = true;
            gameProgressAchievementsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAchievementsCheckBox.Location = new Point(338, 8);
            gameProgressAchievementsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressAchievementsCheckBox.Name = "gameProgressAchievementsCheckBox";
            gameProgressAchievementsCheckBox.Size = new Size(22, 21);
            gameProgressAchievementsCheckBox.TabIndex = 52;
            gameProgressAchievementsCheckBox.UseVisualStyleBackColor = true;
            gameProgressAchievementsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressAchievementsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressAchievementsTextBox.ForeColor = Color.White;
            gameProgressAchievementsTextBox.Location = new Point(174, 0);
            gameProgressAchievementsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressAchievementsTextBox.Name = "gameProgressAchievementsTextBox";
            gameProgressAchievementsTextBox.Size = new Size(146, 31);
            gameProgressAchievementsTextBox.TabIndex = 1;
            gameProgressAchievementsTextBox.Text = "Achievements";
            gameProgressRatioCheckBox.AutoSize = true;
            gameProgressRatioCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressRatioCheckBox.Location = new Point(338, 8);
            gameProgressRatioCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressRatioCheckBox.Name = "gameProgressRatioCheckBox";
            gameProgressRatioCheckBox.Size = new Size(22, 21);
            gameProgressRatioCheckBox.TabIndex = 55;
            gameProgressRatioCheckBox.UseVisualStyleBackColor = true;
            gameProgressRatioTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressRatioTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressRatioTextBox.ForeColor = Color.White;
            gameProgressRatioTextBox.Location = new Point(174, 0);
            gameProgressRatioTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressRatioTextBox.Name = "gameProgressRatioTextBox";
            gameProgressRatioTextBox.Size = new Size(146, 31);
            gameProgressRatioTextBox.TabIndex = 5;
            gameProgressRatioTextBox.Text = "Retro Ratio";
            gameProgressTruePointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressTruePointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTruePointsTextBox.ForeColor = Color.White;
            gameProgressTruePointsTextBox.Location = new Point(174, 0);
            gameProgressTruePointsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTruePointsTextBox.Name = "gameProgressTruePointsTextBox";
            gameProgressTruePointsTextBox.Size = new Size(146, 31);
            gameProgressTruePointsTextBox.TabIndex = 7;
            gameProgressTruePointsTextBox.Text = "True Points";
            gameProgressTruePointsCheckBox.AutoSize = true;
            gameProgressTruePointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressTruePointsCheckBox.Location = new Point(338, 8);
            gameProgressTruePointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressTruePointsCheckBox.Name = "gameProgressTruePointsCheckBox";
            gameProgressTruePointsCheckBox.Size = new Size(22, 21);
            gameProgressTruePointsCheckBox.TabIndex = 56;
            gameProgressTruePointsCheckBox.UseVisualStyleBackColor = true;
            gameProgressPointsTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameProgressPointsTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameProgressPointsTextBox.ForeColor = Color.White;
            gameProgressPointsTextBox.Location = new Point(174, 0);
            gameProgressPointsTextBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressPointsTextBox.Name = "gameProgressPointsTextBox";
            gameProgressPointsTextBox.Size = new Size(146, 31);
            gameProgressPointsTextBox.TabIndex = 6;
            gameProgressPointsTextBox.Text = "Points";
            gameProgressPointsCheckBox.AutoSize = true;
            gameProgressPointsCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameProgressPointsCheckBox.Location = new Point(338, 8);
            gameProgressPointsCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameProgressPointsCheckBox.Name = "gameProgressPointsCheckBox";
            gameProgressPointsCheckBox.Size = new Size(22, 21);
            gameProgressPointsCheckBox.TabIndex = 54;
            gameProgressPointsCheckBox.UseVisualStyleBackColor = true;
            gameProgressValuesPanel.ResumeLayout(false);
            gameProgressValuesOutlinePanel.ResumeLayout(false);
            gameProgressValuesOutlinePanel.PerformLayout();
        }

        #endregion
    }
}
