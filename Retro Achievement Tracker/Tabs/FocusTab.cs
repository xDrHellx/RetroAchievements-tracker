using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class FocusTab : AbstractTab
    {
        #region Sub elements

        public Label focusAchievementTitleLabel,
            focusAchievementDescriptionLabel,
            focusTitleOutlineLabel,
            focusTitleLabel;
        public NumericUpDown focusTitleFontOutlineNumericUpDown,
            focusDescriptionFontOutlineNumericUpDown,
            focusPointsFontOutlineNumericUpDown,
            focusLineOutlineNumericUpDown;
        public PictureBox focusAchievementPictureBox,
            focusLineColorPictureBox,
            focusBorderColorPictureBox,
            focusPointsFontColorPictureBox,
            focusTitleFontOutlineColorPictureBox,
            focusDescriptionFontOutlineColorPictureBox,
            focusDescriptionFontColorPictureBox,
            focusBackgroundColorPictureBox,
            focusTitleFontColorPictureBox,
            focusPointsFontOutlineColorPictureBox,
            focusLineOutlineColorPictureBox;
        public Button focusSetButton,
            focusAchievementButtonPrevious,
            focusAchievementButtonNext,
            focusOpenWindowButton;
        public CheckBox focusAdvancedCheckBox,
            focusTitleOutlineCheckBox,
            focusDescriptionOutlineCheckBox,
            focusAutoOpenWindowCheckBox,
            focusPointsOutlineCheckBox,
            focusLineOutlineCheckBox,
            focusBorderCheckBox;
        public ComboBox focusPointsFontComboBox,
            focusDescriptionFontComboBox,
            focusTitleFontComboBox;
        public RadioButton focusBehaviorGoToLastRadioButton,
            focusBehaviorGoToNextRadioButton,
            focusBehaviorGoToPreviousRadioButton,
            focusBehaviorGoToFirstRadioButton;
        public Panel focusLinePanel,
            focusPointsPanel,
            focusDescriptionOutlinePanel,
            focusDescriptionPanel,
            focusPointsOutlinePanel,
            focusLineOutlinePanel;

        #endregion

        #region Constructor

        public FocusTab()
        {
            Name = "FocusTabPage";
            Text = "Focus";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                focusTitleLabel.Text = "Title";
                focusTitleOutlineLabel.Text = "Title OutlineColor";

                SetFontFamilyBox(focusTitleFontComboBox, FocusController.Instance.TitleFontFamily);
                focusTitleOutlineCheckBox.Checked = FocusController.Instance.TitleOutlineEnabled;
                focusTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.TitleColor);
                focusTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.TitleOutlineColor);
            }
            else
            {
                focusTitleLabel.Text = "Font";
                focusTitleOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(focusTitleFontComboBox, FocusController.Instance.SimpleFontFamily);
                focusTitleOutlineCheckBox.Checked = FocusController.Instance.SimpleFontOutlineEnabled;
                focusTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.SimpleFontColor);
                focusTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.SimpleFontOutlineColor);
            }

            focusDescriptionPanel.Enabled = enable;
            focusPointsPanel.Enabled = enable;
            focusLinePanel.Enabled = enable;
            focusDescriptionOutlinePanel.Enabled = enable;
            focusPointsOutlinePanel.Enabled = enable;
            focusLineOutlinePanel.Enabled = enable;
        }

        public override void InitElements()
        {
            focusAchievementPictureBox = new PictureBox();
            focusAchievementTitleLabel = new Label();
            focusAchievementDescriptionLabel = new Label();
            focusSetButton = new Button();
            focusAchievementButtonPrevious = new Button();
            focusAchievementButtonNext = new Button();
            focusBehaviorGoToLastRadioButton = new RadioButton();
            focusBehaviorGoToNextRadioButton = new RadioButton();
            focusBehaviorGoToPreviousRadioButton = new RadioButton();
            focusBehaviorGoToFirstRadioButton = new RadioButton();
            focusLinePanel = new Panel();
            focusLineColorPictureBox = new PictureBox();
            focusBorderCheckBox = new CheckBox();
            focusBorderColorPictureBox = new PictureBox();
            focusPointsPanel = new Panel();
            focusPointsFontColorPictureBox = new PictureBox();
            focusPointsFontComboBox = new ComboBox();
            focusAdvancedCheckBox = new CheckBox();
            focusTitleFontOutlineNumericUpDown = new NumericUpDown();
            focusTitleOutlineCheckBox = new CheckBox();
            focusTitleOutlineLabel = new Label();
            focusTitleFontOutlineColorPictureBox = new PictureBox();
            focusOpenWindowButton = new Button();
            focusDescriptionOutlinePanel = new Panel();
            focusDescriptionFontOutlineColorPictureBox = new PictureBox();
            focusDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            focusDescriptionOutlineCheckBox = new CheckBox();
            focusDescriptionPanel = new Panel();
            focusDescriptionFontColorPictureBox = new PictureBox();
            focusDescriptionFontComboBox = new ComboBox();
            focusAutoOpenWindowCheckBox = new CheckBox();
            focusBackgroundColorPictureBox = new PictureBox();
            focusTitleLabel = new Label();
            focusTitleFontColorPictureBox = new PictureBox();
            focusTitleFontComboBox = new ComboBox();
            focusPointsOutlinePanel = new Panel();
            focusPointsFontOutlineNumericUpDown = new NumericUpDown();
            focusPointsOutlineCheckBox = new CheckBox();
            focusPointsFontOutlineColorPictureBox = new PictureBox();
            focusLineOutlinePanel = new Panel();
            focusLineOutlineColorPictureBox = new PictureBox();
            focusLineOutlineNumericUpDown = new NumericUpDown();
            focusLineOutlineCheckBox = new CheckBox();
            focusLinePanel.SuspendLayout();
            focusPointsPanel.SuspendLayout();
            focusDescriptionOutlinePanel.SuspendLayout();
            focusDescriptionPanel.SuspendLayout();
            focusPointsOutlinePanel.SuspendLayout();
            focusLineOutlinePanel.SuspendLayout();
            focusAchievementPictureBox.BackColor = Color.Transparent;
            focusAchievementPictureBox.Cursor = Cursors.Hand;
            focusAchievementPictureBox.InitialImage = null;
            focusAchievementPictureBox.Location = new Point(4, 62);
            focusAchievementPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusAchievementPictureBox.Name = "focusAchievementPictureBox";
            focusAchievementPictureBox.Size = new Size(168, 172);
            focusAchievementPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            focusAchievementPictureBox.TabIndex = 10030;
            focusAchievementPictureBox.TabStop = false;
            focusAchievementTitleLabel.BackColor = Color.Transparent;
            focusAchievementTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            focusAchievementTitleLabel.Cursor = Cursors.Hand;
            focusAchievementTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAchievementTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusAchievementTitleLabel.Location = new Point(182, 129);
            focusAchievementTitleLabel.Margin = new Padding(4, 0, 4, 0);
            focusAchievementTitleLabel.Name = "focusAchievementTitleLabel";
            focusAchievementTitleLabel.Size = new Size(246, 104);
            focusAchievementTitleLabel.TabIndex = 10027;
            focusAchievementDescriptionLabel.BackColor = Color.Transparent;
            focusAchievementDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            focusAchievementDescriptionLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAchievementDescriptionLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusAchievementDescriptionLabel.Location = new Point(3, 238);
            focusAchievementDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            focusAchievementDescriptionLabel.Name = "focusAchievementDescriptionLabel";
            focusAchievementDescriptionLabel.Size = new Size(425, 156);
            focusAchievementDescriptionLabel.TabIndex = 10026;
            focusSetButton.BackColor = Color.FromArgb(22, 22, 22);
            focusSetButton.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusSetButton.FlatStyle = FlatStyle.Flat;
            focusSetButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusSetButton.ForeColor = Color.FromArgb(204, 153, 0);
            focusSetButton.Location = new Point(316, 405);
            focusSetButton.Margin = new Padding(4, 5, 4, 5);
            focusSetButton.Name = "focusSetButton";
            focusSetButton.Size = new Size(112, 42);
            focusSetButton.TabIndex = 10031;
            focusSetButton.Text = "Set";
            focusSetButton.UseVisualStyleBackColor = false;
            focusAchievementButtonPrevious.BackColor = Color.FromArgb(22, 22, 22);
            focusAchievementButtonPrevious.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusAchievementButtonPrevious.FlatStyle = FlatStyle.Flat;
            focusAchievementButtonPrevious.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAchievementButtonPrevious.ForeColor = Color.FromArgb(204, 153, 0);
            focusAchievementButtonPrevious.Location = new Point(6, 405);
            focusAchievementButtonPrevious.Margin = new Padding(4, 5, 4, 5);
            focusAchievementButtonPrevious.Name = "focusAchievementButtonPrevious";
            focusAchievementButtonPrevious.Size = new Size(112, 42);
            focusAchievementButtonPrevious.TabIndex = 10028;
            focusAchievementButtonPrevious.Text = "<";
            focusAchievementButtonPrevious.UseVisualStyleBackColor = false;
            focusAchievementButtonNext.BackColor = Color.FromArgb(22, 22, 22);
            focusAchievementButtonNext.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
            focusAchievementButtonNext.FlatStyle = FlatStyle.Flat;
            focusAchievementButtonNext.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAchievementButtonNext.ForeColor = Color.FromArgb(204, 153, 0);
            focusAchievementButtonNext.Location = new Point(128, 405);
            focusAchievementButtonNext.Margin = new Padding(4, 5, 4, 5);
            focusAchievementButtonNext.Name = "focusAchievementButtonNext";
            focusAchievementButtonNext.Size = new Size(112, 42);
            focusAchievementButtonNext.TabIndex = 10029;
            focusAchievementButtonNext.Text = ">";
            focusAchievementButtonNext.UseVisualStyleBackColor = false;
            focusBehaviorGoToLastRadioButton.AutoSize = true;
            focusBehaviorGoToLastRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusBehaviorGoToLastRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusBehaviorGoToLastRadioButton.Location = new Point(334, 62);
            focusBehaviorGoToLastRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusBehaviorGoToLastRadioButton.Name = "focusBehaviorGoToLastRadioButton";
            focusBehaviorGoToLastRadioButton.Size = new Size(78, 29);
            focusBehaviorGoToLastRadioButton.TabIndex = 3;
            focusBehaviorGoToLastRadioButton.Text = "Last";
            focusBehaviorGoToLastRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToNextRadioButton.AutoSize = true;
            focusBehaviorGoToNextRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusBehaviorGoToNextRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusBehaviorGoToNextRadioButton.Location = new Point(102, 62);
            focusBehaviorGoToNextRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusBehaviorGoToNextRadioButton.Name = "focusBehaviorGoToNextRadioButton";
            focusBehaviorGoToNextRadioButton.Size = new Size(84, 29);
            focusBehaviorGoToNextRadioButton.TabIndex = 2;
            focusBehaviorGoToNextRadioButton.Text = "Next";
            focusBehaviorGoToNextRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToPreviousRadioButton.AutoSize = true;
            focusBehaviorGoToPreviousRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusBehaviorGoToPreviousRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusBehaviorGoToPreviousRadioButton.Location = new Point(206, 62);
            focusBehaviorGoToPreviousRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusBehaviorGoToPreviousRadioButton.Name = "focusBehaviorGoToPreviousRadioButton";
            focusBehaviorGoToPreviousRadioButton.Size = new Size(123, 29);
            focusBehaviorGoToPreviousRadioButton.TabIndex = 1;
            focusBehaviorGoToPreviousRadioButton.Text = "Previous";
            focusBehaviorGoToPreviousRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToFirstRadioButton.AutoSize = true;
            focusBehaviorGoToFirstRadioButton.Checked = true;
            focusBehaviorGoToFirstRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusBehaviorGoToFirstRadioButton.ForeColor = Color.FromArgb(44, 151, 250);
            focusBehaviorGoToFirstRadioButton.Location = new Point(12, 62);
            focusBehaviorGoToFirstRadioButton.Margin = new Padding(4, 5, 4, 5);
            focusBehaviorGoToFirstRadioButton.Name = "focusBehaviorGoToFirstRadioButton";
            focusBehaviorGoToFirstRadioButton.Size = new Size(82, 29);
            focusBehaviorGoToFirstRadioButton.TabIndex = 0;
            focusBehaviorGoToFirstRadioButton.TabStop = true;
            focusBehaviorGoToFirstRadioButton.Text = "First";
            focusBehaviorGoToFirstRadioButton.UseVisualStyleBackColor = true;
            focusLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusLinePanel.Location = new Point(3, 265);
            focusLinePanel.Margin = new Padding(4, 5, 4, 5);
            focusLinePanel.Name = "focusLinePanel";
            focusLinePanel.Size = new Size(694, 35);
            focusLinePanel.TabIndex = 10068;
            focusLineColorPictureBox.BackColor = Color.White;
            focusLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusLineColorPictureBox.Location = new Point(230, 5);
            focusLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusLineColorPictureBox.Name = "focusLineColorPictureBox";
            focusLineColorPictureBox.Size = new Size(22, 22);
            focusLineColorPictureBox.TabIndex = 45;
            focusLineColorPictureBox.TabStop = false;
            focusBorderCheckBox.AutoSize = true;
            focusBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusBorderCheckBox.Location = new Point(620, 8);
            focusBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusBorderCheckBox.Name = "focusBorderCheckBox";
            focusBorderCheckBox.Size = new Size(22, 21);
            focusBorderCheckBox.TabIndex = 10065;
            focusBorderCheckBox.UseVisualStyleBackColor = true;
            focusBorderColorPictureBox.BackColor = Color.White;
            focusBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusBorderColorPictureBox.Location = new Point(230, 5);
            focusBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusBorderColorPictureBox.Name = "focusBorderColorPictureBox";
            focusBorderColorPictureBox.Size = new Size(22, 22);
            focusBorderColorPictureBox.TabIndex = 42;
            focusBorderColorPictureBox.TabStop = false;
            focusPointsPanel.BackColor = Color.FromArgb(26, 26, 26);
            focusPointsPanel.Location = new Point(3, 231);
            focusPointsPanel.Margin = new Padding(4, 5, 4, 5);
            focusPointsPanel.Name = "focusPointsPanel";
            focusPointsPanel.Size = new Size(694, 35);
            focusPointsPanel.TabIndex = 10070;
            focusPointsFontColorPictureBox.BackColor = Color.White;
            focusPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusPointsFontColorPictureBox.Location = new Point(230, 6);
            focusPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusPointsFontColorPictureBox.Name = "focusPointsFontColorPictureBox";
            focusPointsFontColorPictureBox.Size = new Size(22, 22);
            focusPointsFontColorPictureBox.TabIndex = 45;
            focusPointsFontColorPictureBox.TabStop = false;
            focusPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusPointsFontComboBox.ForeColor = Color.White;
            focusPointsFontComboBox.FormattingEnabled = true;
            focusPointsFontComboBox.Location = new Point(290, 3);
            focusPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusPointsFontComboBox.Name = "focusPointsFontComboBox";
            focusPointsFontComboBox.Size = new Size(301, 28);
            focusPointsFontComboBox.TabIndex = 45;
            focusAdvancedCheckBox.AutoSize = true;
            focusAdvancedCheckBox.BackColor = Color.Transparent;
            focusAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusAdvancedCheckBox.Location = new Point(8, 3);
            focusAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusAdvancedCheckBox.Name = "focusAdvancedCheckBox";
            focusAdvancedCheckBox.Size = new Size(135, 29);
            focusAdvancedCheckBox.TabIndex = 10053;
            focusAdvancedCheckBox.Text = "Advanced";
            focusAdvancedCheckBox.UseVisualStyleBackColor = false;
            focusTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            focusTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            focusTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            focusTitleFontOutlineNumericUpDown.Name = "focusTitleFontOutlineNumericUpDown";
            focusTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusTitleFontOutlineNumericUpDown.TabIndex = 45;
            focusTitleFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            focusTitleOutlineCheckBox.AutoSize = true;
            focusTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTitleOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusTitleOutlineCheckBox.Location = new Point(620, 8);
            focusTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusTitleOutlineCheckBox.Name = "focusTitleOutlineCheckBox";
            focusTitleOutlineCheckBox.Size = new Size(22, 21);
            focusTitleOutlineCheckBox.TabIndex = 45;
            focusTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTitleOutlineLabel.BackColor = Color.Transparent;
            focusTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTitleOutlineLabel.Location = new Point(4, 5);
            focusTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            focusTitleOutlineLabel.Name = "focusTitleOutlineLabel";
            focusTitleOutlineLabel.Size = new Size(216, 25);
            focusTitleOutlineLabel.TabIndex = 10066;
            focusTitleOutlineLabel.Text = "Title OutlineColor";
            focusTitleFontOutlineColorPictureBox.BackColor = Color.White;
            focusTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTitleFontOutlineColorPictureBox.Name = "focusTitleFontOutlineColorPictureBox";
            focusTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusTitleFontOutlineColorPictureBox.TabIndex = 45;
            focusTitleFontOutlineColorPictureBox.TabStop = false;
            focusOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            focusOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            focusOpenWindowButton.FlatStyle = FlatStyle.Flat;
            focusOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            focusOpenWindowButton.Location = new Point(573, 3);
            focusOpenWindowButton.Margin = new Padding(0);
            focusOpenWindowButton.Name = "focusOpenWindowButton";
            focusOpenWindowButton.Size = new Size(112, 42);
            focusOpenWindowButton.TabIndex = 10021;
            focusOpenWindowButton.Text = "Open";
            focusOpenWindowButton.UseVisualStyleBackColor = false;
            focusDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusDescriptionOutlinePanel.Location = new Point(3, 332);
            focusDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionOutlinePanel.Name = "focusDescriptionOutlinePanel";
            focusDescriptionOutlinePanel.Size = new Size(694, 35);
            focusDescriptionOutlinePanel.TabIndex = 10072;
            focusDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            focusDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            focusDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionFontOutlineColorPictureBox.Name = "focusDescriptionFontOutlineColorPictureBox";
            focusDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            focusDescriptionFontOutlineColorPictureBox.TabStop = false;
            focusDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            focusDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            focusDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            focusDescriptionFontOutlineNumericUpDown.Name = "focusDescriptionFontOutlineNumericUpDown";
            focusDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            focusDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            focusDescriptionOutlineCheckBox.AutoSize = true;
            focusDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusDescriptionOutlineCheckBox.Location = new Point(620, 9);
            focusDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionOutlineCheckBox.Name = "focusDescriptionOutlineCheckBox";
            focusDescriptionOutlineCheckBox.Size = new Size(22, 21);
            focusDescriptionOutlineCheckBox.TabIndex = 45;
            focusDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            focusDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            focusDescriptionPanel.Location = new Point(3, 197);
            focusDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionPanel.Name = "focusDescriptionPanel";
            focusDescriptionPanel.Size = new Size(694, 35);
            focusDescriptionPanel.TabIndex = 10061;
            focusDescriptionFontColorPictureBox.BackColor = Color.White;
            focusDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusDescriptionFontColorPictureBox.Location = new Point(230, 5);
            focusDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionFontColorPictureBox.Name = "focusDescriptionFontColorPictureBox";
            focusDescriptionFontColorPictureBox.Size = new Size(22, 22);
            focusDescriptionFontColorPictureBox.TabIndex = 45;
            focusDescriptionFontColorPictureBox.TabStop = false;
            focusDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusDescriptionFontComboBox.ForeColor = Color.White;
            focusDescriptionFontComboBox.FormattingEnabled = true;
            focusDescriptionFontComboBox.Location = new Point(290, 3);
            focusDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusDescriptionFontComboBox.Name = "focusDescriptionFontComboBox";
            focusDescriptionFontComboBox.Size = new Size(301, 28);
            focusDescriptionFontComboBox.TabIndex = 45;
            focusAutoOpenWindowCheckBox.AutoSize = true;
            focusAutoOpenWindowCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusAutoOpenWindowCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusAutoOpenWindowCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusAutoOpenWindowCheckBox.Location = new Point(378, 14);
            focusAutoOpenWindowCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusAutoOpenWindowCheckBox.Name = "focusAutoOpenWindowCheckBox";
            focusAutoOpenWindowCheckBox.Size = new Size(147, 29);
            focusAutoOpenWindowCheckBox.TabIndex = 10022;
            focusAutoOpenWindowCheckBox.Text = "Auto-Open";
            focusAutoOpenWindowCheckBox.UseVisualStyleBackColor = true;
            focusBackgroundColorPictureBox.BackColor = Color.White;
            focusBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusBackgroundColorPictureBox.Location = new Point(230, 5);
            focusBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusBackgroundColorPictureBox.Name = "focusBackgroundColorPictureBox";
            focusBackgroundColorPictureBox.Size = new Size(22, 22);
            focusBackgroundColorPictureBox.TabIndex = 42;
            focusBackgroundColorPictureBox.TabStop = false;
            focusTitleLabel.BackColor = Color.Transparent;
            focusTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            focusTitleLabel.Location = new Point(4, 6);
            focusTitleLabel.Margin = new Padding(4, 0, 4, 0);
            focusTitleLabel.Name = "focusTitleLabel";
            focusTitleLabel.Size = new Size(216, 25);
            focusTitleLabel.TabIndex = 10065;
            focusTitleLabel.Text = "Title";
            focusTitleFontColorPictureBox.BackColor = Color.White;
            focusTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTitleFontColorPictureBox.Location = new Point(230, 6);
            focusTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusTitleFontColorPictureBox.Name = "focusTitleFontColorPictureBox";
            focusTitleFontColorPictureBox.Size = new Size(22, 22);
            focusTitleFontColorPictureBox.TabIndex = 45;
            focusTitleFontColorPictureBox.TabStop = false;
            focusTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            focusTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusTitleFontComboBox.ForeColor = Color.White;
            focusTitleFontComboBox.FormattingEnabled = true;
            focusTitleFontComboBox.Location = new Point(290, 3);
            focusTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            focusTitleFontComboBox.Name = "focusTitleFontComboBox";
            focusTitleFontComboBox.Size = new Size(301, 28);
            focusTitleFontComboBox.TabIndex = 45;
            focusPointsOutlinePanel.BackColor = Color.FromArgb(26, 26, 26);
            focusPointsOutlinePanel.Location = new Point(3, 366);
            focusPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusPointsOutlinePanel.Name = "focusPointsOutlinePanel";
            focusPointsOutlinePanel.Size = new Size(694, 35);
            focusPointsOutlinePanel.TabIndex = 10061;
            focusPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            focusPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            focusPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            focusPointsFontOutlineNumericUpDown.Name = "focusPointsFontOutlineNumericUpDown";
            focusPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            focusPointsFontOutlineNumericUpDown.TabIndex = 45;
            focusPointsFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            focusPointsOutlineCheckBox.AutoSize = true;
            focusPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusPointsOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusPointsOutlineCheckBox.Location = new Point(620, 8);
            focusPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusPointsOutlineCheckBox.Name = "focusPointsOutlineCheckBox";
            focusPointsOutlineCheckBox.Size = new Size(22, 21);
            focusPointsOutlineCheckBox.TabIndex = 45;
            focusPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            focusPointsFontOutlineColorPictureBox.BackColor = Color.White;
            focusPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusPointsFontOutlineColorPictureBox.Name = "focusPointsFontOutlineColorPictureBox";
            focusPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            focusPointsFontOutlineColorPictureBox.TabIndex = 45;
            focusPointsFontOutlineColorPictureBox.TabStop = false;
            focusLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            focusLineOutlinePanel.Location = new Point(3, 400);
            focusLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            focusLineOutlinePanel.Name = "focusLineOutlinePanel";
            focusLineOutlinePanel.Size = new Size(694, 35);
            focusLineOutlinePanel.TabIndex = 10067;
            focusLineOutlineColorPictureBox.BackColor = Color.White;
            focusLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusLineOutlineColorPictureBox.Location = new Point(230, 6);
            focusLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            focusLineOutlineColorPictureBox.Name = "focusLineOutlineColorPictureBox";
            focusLineOutlineColorPictureBox.Size = new Size(22, 22);
            focusLineOutlineColorPictureBox.TabIndex = 45;
            focusLineOutlineColorPictureBox.TabStop = false;
            focusLineOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            focusLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusLineOutlineNumericUpDown.ForeColor = Color.White;
            focusLineOutlineNumericUpDown.Location = new Point(528, 6);
            focusLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            focusLineOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            focusLineOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            focusLineOutlineNumericUpDown.Name = "focusLineOutlineNumericUpDown";
            focusLineOutlineNumericUpDown.Size = new Size(64, 24);
            focusLineOutlineNumericUpDown.TabIndex = 45;
            focusLineOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            focusLineOutlineCheckBox.AutoSize = true;
            focusLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            focusLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            focusLineOutlineCheckBox.Location = new Point(620, 9);
            focusLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            focusLineOutlineCheckBox.Name = "focusLineOutlineCheckBox";
            focusLineOutlineCheckBox.Size = new Size(22, 21);
            focusLineOutlineCheckBox.TabIndex = 45;
            focusLineOutlineCheckBox.UseVisualStyleBackColor = true;
            focusLinePanel.ResumeLayout(false);
            focusPointsPanel.ResumeLayout(false);
            focusDescriptionOutlinePanel.ResumeLayout(false);
            focusDescriptionOutlinePanel.PerformLayout();
            focusDescriptionPanel.ResumeLayout(false);
            focusPointsOutlinePanel.ResumeLayout(false);
            focusPointsOutlinePanel.PerformLayout();
            focusLineOutlinePanel.ResumeLayout(false);
            focusLineOutlinePanel.PerformLayout();
        }

        #endregion
    }
}
