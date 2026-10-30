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
            BackColor = btnBackColor;
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
            focusAchievementPictureBox.Margin = btnPanelMargin;
            focusAchievementPictureBox.Name = "focusAchievementPictureBox";
            focusAchievementPictureBox.Size = new Size(168, 172);
            focusAchievementPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // focusAchievementPictureBox.TabIndex = 10030;

            focusAchievementPictureBox.TabStop = false;
            focusAchievementTitleLabel.BackColor = Color.Transparent;
            focusAchievementTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            focusAchievementTitleLabel.Cursor = Cursors.Hand;
            focusAchievementTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            focusAchievementTitleLabel.ForeColor = foreColor;
            focusAchievementTitleLabel.Location = new Point(182, 129);
            focusAchievementTitleLabel.Margin = labelMargin;
            focusAchievementTitleLabel.Name = "focusAchievementTitleLabel";
            focusAchievementTitleLabel.Size = new Size(246, 104);
            // focusAchievementTitleLabel.TabIndex = 10027;

            focusAchievementDescriptionLabel.BackColor = Color.Transparent;
            focusAchievementDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            focusAchievementDescriptionLabel.Font = labelFont;
            focusAchievementDescriptionLabel.ForeColor = foreColor;
            focusAchievementDescriptionLabel.Location = new Point(3, 238);
            focusAchievementDescriptionLabel.Margin = labelMargin;
            focusAchievementDescriptionLabel.Name = "focusAchievementDescriptionLabel";
            focusAchievementDescriptionLabel.Size = new Size(425, 156);
            // focusAchievementDescriptionLabel.TabIndex = 10026;

            focusSetButton.BackColor = btnBackColor;
            focusSetButton.FlatAppearance.BorderColor = btnBackColor;
            focusSetButton.FlatStyle = FlatStyle.Flat;
            focusSetButton.Font = labelFont;
            focusSetButton.ForeColor = btnForeColor;
            focusSetButton.Location = new Point(316, 405);
            focusSetButton.Margin = btnPanelMargin;
            focusSetButton.Name = "focusSetButton";
            focusSetButton.Size = new Size(112, 42);
            // focusSetButton.TabIndex = 10031;

            focusSetButton.Text = "Set";
            focusSetButton.UseVisualStyleBackColor = false;
            focusAchievementButtonPrevious.BackColor = btnBackColor;
            focusAchievementButtonPrevious.FlatAppearance.BorderColor = btnBackColor;
            focusAchievementButtonPrevious.FlatStyle = FlatStyle.Flat;
            focusAchievementButtonPrevious.Font = labelFont;
            focusAchievementButtonPrevious.ForeColor = btnForeColor;
            focusAchievementButtonPrevious.Location = new Point(6, 405);
            focusAchievementButtonPrevious.Margin = btnPanelMargin;
            focusAchievementButtonPrevious.Name = "focusAchievementButtonPrevious";
            focusAchievementButtonPrevious.Size = new Size(112, 42);
            // focusAchievementButtonPrevious.TabIndex = 10028;

            focusAchievementButtonPrevious.Text = "<";
            focusAchievementButtonPrevious.UseVisualStyleBackColor = false;
            focusAchievementButtonNext.BackColor = btnBackColor;
            focusAchievementButtonNext.FlatAppearance.BorderColor = btnBackColor;
            focusAchievementButtonNext.FlatStyle = FlatStyle.Flat;
            focusAchievementButtonNext.Font = labelFont;
            focusAchievementButtonNext.ForeColor = btnForeColor;
            focusAchievementButtonNext.Location = new Point(128, 405);
            focusAchievementButtonNext.Margin = btnPanelMargin;
            focusAchievementButtonNext.Name = "focusAchievementButtonNext";
            focusAchievementButtonNext.Size = new Size(112, 42);
            // focusAchievementButtonNext.TabIndex = 10029;

            focusAchievementButtonNext.Text = ">";
            focusAchievementButtonNext.UseVisualStyleBackColor = false;
            focusBehaviorGoToLastRadioButton.AutoSize = true;
            focusBehaviorGoToLastRadioButton.Font = labelFont;
            focusBehaviorGoToLastRadioButton.ForeColor = foreColor;
            focusBehaviorGoToLastRadioButton.Location = new Point(334, 62);
            focusBehaviorGoToLastRadioButton.Margin = btnPanelMargin;
            focusBehaviorGoToLastRadioButton.Name = "focusBehaviorGoToLastRadioButton";
            focusBehaviorGoToLastRadioButton.Size = new Size(78, 29);
            // focusBehaviorGoToLastRadioButton.TabIndex = 3;

            focusBehaviorGoToLastRadioButton.Text = "Last";
            focusBehaviorGoToLastRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToNextRadioButton.AutoSize = true;
            focusBehaviorGoToNextRadioButton.Font = labelFont;
            focusBehaviorGoToNextRadioButton.ForeColor = foreColor;
            focusBehaviorGoToNextRadioButton.Location = new Point(102, 62);
            focusBehaviorGoToNextRadioButton.Margin = btnPanelMargin;
            focusBehaviorGoToNextRadioButton.Name = "focusBehaviorGoToNextRadioButton";
            focusBehaviorGoToNextRadioButton.Size = new Size(84, 29);
            // focusBehaviorGoToNextRadioButton.TabIndex = 2;

            focusBehaviorGoToNextRadioButton.Text = "Next";
            focusBehaviorGoToNextRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToPreviousRadioButton.AutoSize = true;
            focusBehaviorGoToPreviousRadioButton.Font = labelFont;
            focusBehaviorGoToPreviousRadioButton.ForeColor = foreColor;
            focusBehaviorGoToPreviousRadioButton.Location = new Point(206, 62);
            focusBehaviorGoToPreviousRadioButton.Margin = btnPanelMargin;
            focusBehaviorGoToPreviousRadioButton.Name = "focusBehaviorGoToPreviousRadioButton";
            focusBehaviorGoToPreviousRadioButton.Size = new Size(123, 29);
            // focusBehaviorGoToPreviousRadioButton.TabIndex = 1;

            focusBehaviorGoToPreviousRadioButton.Text = "Previous";
            focusBehaviorGoToPreviousRadioButton.UseVisualStyleBackColor = true;
            focusBehaviorGoToFirstRadioButton.AutoSize = true;
            focusBehaviorGoToFirstRadioButton.Checked = true;
            focusBehaviorGoToFirstRadioButton.Font = labelFont;
            focusBehaviorGoToFirstRadioButton.ForeColor = foreColor;
            focusBehaviorGoToFirstRadioButton.Location = new Point(12, 62);
            focusBehaviorGoToFirstRadioButton.Margin = btnPanelMargin;
            focusBehaviorGoToFirstRadioButton.Name = "focusBehaviorGoToFirstRadioButton";
            focusBehaviorGoToFirstRadioButton.Size = new Size(82, 29);
            // focusBehaviorGoToFirstRadioButton.TabIndex = 0;

            focusBehaviorGoToFirstRadioButton.TabStop = true;
            focusBehaviorGoToFirstRadioButton.Text = "First";
            focusBehaviorGoToFirstRadioButton.UseVisualStyleBackColor = true;
            focusLinePanel.BackColor = panelBackColor;
            focusLinePanel.Location = new Point(3, 265);
            focusLinePanel.Margin = btnPanelMargin;
            focusLinePanel.Name = "focusLinePanel";
            focusLinePanel.Size = new Size(694, 35);
            // focusLinePanel.TabIndex = 10068;

            focusLineColorPictureBox.BackColor = Color.White;
            focusLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusLineColorPictureBox.Location = new Point(230, 5);
            focusLineColorPictureBox.Margin = btnPanelMargin;
            focusLineColorPictureBox.Name = "focusLineColorPictureBox";
            focusLineColorPictureBox.Size = new Size(22, 22);
            // focusLineColorPictureBox.TabIndex = 45;

            focusLineColorPictureBox.TabStop = false;
            focusBorderCheckBox.AutoSize = true;
            focusBorderCheckBox.Font = labelFont;
            focusBorderCheckBox.ForeColor = foreColor;
            focusBorderCheckBox.Location = new Point(620, 8);
            focusBorderCheckBox.Margin = btnPanelMargin;
            focusBorderCheckBox.Name = "focusBorderCheckBox";
            focusBorderCheckBox.Size = new Size(22, 21);
            // focusBorderCheckBox.TabIndex = 10065;

            focusBorderCheckBox.UseVisualStyleBackColor = true;
            focusBorderColorPictureBox.BackColor = Color.White;
            focusBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusBorderColorPictureBox.Location = new Point(230, 5);
            focusBorderColorPictureBox.Margin = btnPanelMargin;
            focusBorderColorPictureBox.Name = "focusBorderColorPictureBox";
            focusBorderColorPictureBox.Size = new Size(22, 22);
            // focusBorderColorPictureBox.TabIndex = 42;

            focusBorderColorPictureBox.TabStop = false;
            focusPointsPanel.BackColor = Color.FromArgb(26, 26, 26);
            focusPointsPanel.Location = new Point(3, 231);
            focusPointsPanel.Margin = btnPanelMargin;
            focusPointsPanel.Name = "focusPointsPanel";
            focusPointsPanel.Size = new Size(694, 35);
            // focusPointsPanel.TabIndex = 10070;

            focusPointsFontColorPictureBox.BackColor = Color.White;
            focusPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusPointsFontColorPictureBox.Location = new Point(230, 6);
            focusPointsFontColorPictureBox.Margin = btnPanelMargin;
            focusPointsFontColorPictureBox.Name = "focusPointsFontColorPictureBox";
            focusPointsFontColorPictureBox.Size = new Size(22, 22);
            // focusPointsFontColorPictureBox.TabIndex = 45;

            focusPointsFontColorPictureBox.TabStop = false;
            focusPointsFontComboBox.BackColor = btnBackColor;
            focusPointsFontComboBox.Font = numUpDownFont;
            focusPointsFontComboBox.ForeColor = Color.White;
            focusPointsFontComboBox.FormattingEnabled = true;
            focusPointsFontComboBox.Location = new Point(290, 3);
            focusPointsFontComboBox.Margin = btnPanelMargin;
            focusPointsFontComboBox.Name = "focusPointsFontComboBox";
            focusPointsFontComboBox.Size = new Size(301, 28);
            // focusPointsFontComboBox.TabIndex = 45;

            focusAdvancedCheckBox.AutoSize = true;
            focusAdvancedCheckBox.BackColor = Color.Transparent;
            focusAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusAdvancedCheckBox.Font = labelFont;
            focusAdvancedCheckBox.ForeColor = foreColor;
            focusAdvancedCheckBox.Location = new Point(8, 3);
            focusAdvancedCheckBox.Margin = btnPanelMargin;
            focusAdvancedCheckBox.Name = "focusAdvancedCheckBox";
            focusAdvancedCheckBox.Size = new Size(135, 29);
            // focusAdvancedCheckBox.TabIndex = 10053;

            focusAdvancedCheckBox.Text = "Advanced";
            focusAdvancedCheckBox.UseVisualStyleBackColor = false;
            focusTitleFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            focusTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusTitleFontOutlineNumericUpDown.Font = numUpDownFont;
            focusTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            focusTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusTitleFontOutlineNumericUpDown.Margin = btnPanelMargin;
            focusTitleFontOutlineNumericUpDown.Maximum = 5;
            focusTitleFontOutlineNumericUpDown.Minimum = 1;
            focusTitleFontOutlineNumericUpDown.Name = "focusTitleFontOutlineNumericUpDown";
            focusTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            // focusTitleFontOutlineNumericUpDown.TabIndex = 45;

            focusTitleFontOutlineNumericUpDown.Value = 1;
            focusTitleOutlineCheckBox.AutoSize = true;
            focusTitleOutlineCheckBox.Font = labelFont;
            focusTitleOutlineCheckBox.ForeColor = foreColor;
            focusTitleOutlineCheckBox.Location = new Point(620, 8);
            focusTitleOutlineCheckBox.Margin = btnPanelMargin;
            focusTitleOutlineCheckBox.Name = "focusTitleOutlineCheckBox";
            focusTitleOutlineCheckBox.Size = new Size(22, 21);
            // focusTitleOutlineCheckBox.TabIndex = 45;

            focusTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            focusTitleOutlineLabel.BackColor = Color.Transparent;
            focusTitleOutlineLabel.Font = labelFont;
            focusTitleOutlineLabel.ForeColor = foreColor;
            focusTitleOutlineLabel.Location = new Point(4, 5);
            focusTitleOutlineLabel.Margin = labelMargin;
            focusTitleOutlineLabel.Name = "focusTitleOutlineLabel";
            focusTitleOutlineLabel.Size = new Size(216, 25);
            // focusTitleOutlineLabel.TabIndex = 10066;

            focusTitleOutlineLabel.Text = "Title OutlineColor";
            focusTitleFontOutlineColorPictureBox.BackColor = Color.White;
            focusTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusTitleFontOutlineColorPictureBox.Margin = btnPanelMargin;
            focusTitleFontOutlineColorPictureBox.Name = "focusTitleFontOutlineColorPictureBox";
            focusTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            // focusTitleFontOutlineColorPictureBox.TabIndex = 45;

            focusTitleFontOutlineColorPictureBox.TabStop = false;
            focusOpenWindowButton.BackColor = btnBackColor;
            focusOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            focusOpenWindowButton.FlatStyle = FlatStyle.Flat;
            focusOpenWindowButton.Font = labelFont;
            focusOpenWindowButton.ForeColor = btnForeColor;
            focusOpenWindowButton.Location = new Point(573, 3);
            focusOpenWindowButton.Margin = new Padding(0);
            focusOpenWindowButton.Name = "focusOpenWindowButton";
            focusOpenWindowButton.Size = new Size(112, 42);
            // focusOpenWindowButton.TabIndex = 10021;

            focusOpenWindowButton.Text = "Open";
            focusOpenWindowButton.UseVisualStyleBackColor = false;
            focusDescriptionOutlinePanel.BackColor = panelBackColor;
            focusDescriptionOutlinePanel.Location = new Point(3, 332);
            focusDescriptionOutlinePanel.Margin = btnPanelMargin;
            focusDescriptionOutlinePanel.Name = "focusDescriptionOutlinePanel";
            focusDescriptionOutlinePanel.Size = new Size(694, 35);
            // focusDescriptionOutlinePanel.TabIndex = 10072;

            focusDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            focusDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            focusDescriptionFontOutlineColorPictureBox.Margin = btnPanelMargin;
            focusDescriptionFontOutlineColorPictureBox.Name = "focusDescriptionFontOutlineColorPictureBox";
            focusDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            // focusDescriptionFontOutlineColorPictureBox.TabIndex = 45;

            focusDescriptionFontOutlineColorPictureBox.TabStop = false;
            focusDescriptionFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            focusDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusDescriptionFontOutlineNumericUpDown.Font = numUpDownFont;
            focusDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            focusDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusDescriptionFontOutlineNumericUpDown.Margin = btnPanelMargin;
            focusDescriptionFontOutlineNumericUpDown.Maximum = 5;
            focusDescriptionFontOutlineNumericUpDown.Minimum = 1;
            focusDescriptionFontOutlineNumericUpDown.Name = "focusDescriptionFontOutlineNumericUpDown";
            focusDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            // focusDescriptionFontOutlineNumericUpDown.TabIndex = 45;

            focusDescriptionFontOutlineNumericUpDown.Value = 1;
            focusDescriptionOutlineCheckBox.AutoSize = true;
            focusDescriptionOutlineCheckBox.Font = labelFont;
            focusDescriptionOutlineCheckBox.ForeColor = foreColor;
            focusDescriptionOutlineCheckBox.Location = new Point(620, 9);
            focusDescriptionOutlineCheckBox.Margin = btnPanelMargin;
            focusDescriptionOutlineCheckBox.Name = "focusDescriptionOutlineCheckBox";
            focusDescriptionOutlineCheckBox.Size = new Size(22, 21);
            // focusDescriptionOutlineCheckBox.TabIndex = 45;

            focusDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            focusDescriptionPanel.BackColor = panelBackColor;
            focusDescriptionPanel.Location = new Point(3, 197);
            focusDescriptionPanel.Margin = btnPanelMargin;
            focusDescriptionPanel.Name = "focusDescriptionPanel";
            focusDescriptionPanel.Size = new Size(694, 35);
            // focusDescriptionPanel.TabIndex = 10061;

            focusDescriptionFontColorPictureBox.BackColor = Color.White;
            focusDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusDescriptionFontColorPictureBox.Location = new Point(230, 5);
            focusDescriptionFontColorPictureBox.Margin = btnPanelMargin;
            focusDescriptionFontColorPictureBox.Name = "focusDescriptionFontColorPictureBox";
            focusDescriptionFontColorPictureBox.Size = new Size(22, 22);
            // focusDescriptionFontColorPictureBox.TabIndex = 45;

            focusDescriptionFontColorPictureBox.TabStop = false;
            focusDescriptionFontComboBox.BackColor = btnBackColor;
            focusDescriptionFontComboBox.Font = numUpDownFont;
            focusDescriptionFontComboBox.ForeColor = Color.White;
            focusDescriptionFontComboBox.FormattingEnabled = true;
            focusDescriptionFontComboBox.Location = new Point(290, 3);
            focusDescriptionFontComboBox.Margin = btnPanelMargin;
            focusDescriptionFontComboBox.Name = "focusDescriptionFontComboBox";
            focusDescriptionFontComboBox.Size = new Size(301, 28);
            // focusDescriptionFontComboBox.TabIndex = 45;

            focusAutoOpenWindowCheckBox.AutoSize = true;
            focusAutoOpenWindowCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            focusAutoOpenWindowCheckBox.Font = labelFont;
            focusAutoOpenWindowCheckBox.ForeColor = foreColor;
            focusAutoOpenWindowCheckBox.Location = new Point(378, 14);
            focusAutoOpenWindowCheckBox.Margin = btnPanelMargin;
            focusAutoOpenWindowCheckBox.Name = "focusAutoOpenWindowCheckBox";
            focusAutoOpenWindowCheckBox.Size = new Size(147, 29);
            // focusAutoOpenWindowCheckBox.TabIndex = 10022;

            focusAutoOpenWindowCheckBox.Text = "Auto-Open";
            focusAutoOpenWindowCheckBox.UseVisualStyleBackColor = true;
            focusBackgroundColorPictureBox.BackColor = Color.White;
            focusBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusBackgroundColorPictureBox.Location = new Point(230, 5);
            focusBackgroundColorPictureBox.Margin = btnPanelMargin;
            focusBackgroundColorPictureBox.Name = "focusBackgroundColorPictureBox";
            focusBackgroundColorPictureBox.Size = new Size(22, 22);
            // focusBackgroundColorPictureBox.TabIndex = 42;

            focusBackgroundColorPictureBox.TabStop = false;
            focusTitleLabel.BackColor = Color.Transparent;
            focusTitleLabel.Font = labelFont;
            focusTitleLabel.ForeColor = foreColor;
            focusTitleLabel.Location = new Point(4, 6);
            focusTitleLabel.Margin = labelMargin;
            focusTitleLabel.Name = "focusTitleLabel";
            focusTitleLabel.Size = new Size(216, 25);
            // focusTitleLabel.TabIndex = 10065;

            focusTitleLabel.Text = "Title";
            focusTitleFontColorPictureBox.BackColor = Color.White;
            focusTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusTitleFontColorPictureBox.Location = new Point(230, 6);
            focusTitleFontColorPictureBox.Margin = btnPanelMargin;
            focusTitleFontColorPictureBox.Name = "focusTitleFontColorPictureBox";
            focusTitleFontColorPictureBox.Size = new Size(22, 22);
            // focusTitleFontColorPictureBox.TabIndex = 45;

            focusTitleFontColorPictureBox.TabStop = false;
            focusTitleFontComboBox.BackColor = btnBackColor;
            focusTitleFontComboBox.Font = numUpDownFont;
            focusTitleFontComboBox.ForeColor = Color.White;
            focusTitleFontComboBox.FormattingEnabled = true;
            focusTitleFontComboBox.Location = new Point(290, 3);
            focusTitleFontComboBox.Margin = btnPanelMargin;
            focusTitleFontComboBox.Name = "focusTitleFontComboBox";
            focusTitleFontComboBox.Size = new Size(301, 28);
            // focusTitleFontComboBox.TabIndex = 45;

            focusPointsOutlinePanel.BackColor = Color.FromArgb(26, 26, 26);
            focusPointsOutlinePanel.Location = new Point(3, 366);
            focusPointsOutlinePanel.Margin = btnPanelMargin;
            focusPointsOutlinePanel.Name = "focusPointsOutlinePanel";
            focusPointsOutlinePanel.Size = new Size(694, 35);
            // focusPointsOutlinePanel.TabIndex = 10061;

            focusPointsFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            focusPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusPointsFontOutlineNumericUpDown.Font = numUpDownFont;
            focusPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            focusPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            focusPointsFontOutlineNumericUpDown.Margin = btnPanelMargin;
            focusPointsFontOutlineNumericUpDown.Maximum = 5;
            focusPointsFontOutlineNumericUpDown.Minimum = 1;
            focusPointsFontOutlineNumericUpDown.Name = "focusPointsFontOutlineNumericUpDown";
            focusPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            // focusPointsFontOutlineNumericUpDown.TabIndex = 45;

            focusPointsFontOutlineNumericUpDown.Value = 1;
            focusPointsOutlineCheckBox.AutoSize = true;
            focusPointsOutlineCheckBox.Font = labelFont;
            focusPointsOutlineCheckBox.ForeColor = foreColor;
            focusPointsOutlineCheckBox.Location = new Point(620, 8);
            focusPointsOutlineCheckBox.Margin = btnPanelMargin;
            focusPointsOutlineCheckBox.Name = "focusPointsOutlineCheckBox";
            focusPointsOutlineCheckBox.Size = new Size(22, 21);
            // focusPointsOutlineCheckBox.TabIndex = 45;

            focusPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            focusPointsFontOutlineColorPictureBox.BackColor = Color.White;
            focusPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            focusPointsFontOutlineColorPictureBox.Margin = btnPanelMargin;
            focusPointsFontOutlineColorPictureBox.Name = "focusPointsFontOutlineColorPictureBox";
            focusPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            // focusPointsFontOutlineColorPictureBox.TabIndex = 45;

            focusPointsFontOutlineColorPictureBox.TabStop = false;
            focusLineOutlinePanel.BackColor = panelBackColor;
            focusLineOutlinePanel.Location = new Point(3, 400);
            focusLineOutlinePanel.Margin = btnPanelMargin;
            focusLineOutlinePanel.Name = "focusLineOutlinePanel";
            focusLineOutlinePanel.Size = new Size(694, 35);
            // focusLineOutlinePanel.TabIndex = 10067;

            focusLineOutlineColorPictureBox.BackColor = Color.White;
            focusLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            focusLineOutlineColorPictureBox.Location = new Point(230, 6);
            focusLineOutlineColorPictureBox.Margin = btnPanelMargin;
            focusLineOutlineColorPictureBox.Name = "focusLineOutlineColorPictureBox";
            focusLineOutlineColorPictureBox.Size = new Size(22, 22);
            // focusLineOutlineColorPictureBox.TabIndex = 45;

            focusLineOutlineColorPictureBox.TabStop = false;
            focusLineOutlineNumericUpDown.BackColor = numUpDownBackColor;
            focusLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            focusLineOutlineNumericUpDown.Font = numUpDownFont;
            focusLineOutlineNumericUpDown.ForeColor = Color.White;
            focusLineOutlineNumericUpDown.Location = new Point(528, 6);
            focusLineOutlineNumericUpDown.Margin = btnPanelMargin;
            focusLineOutlineNumericUpDown.Maximum = 5;
            focusLineOutlineNumericUpDown.Minimum = 1;
            focusLineOutlineNumericUpDown.Name = "focusLineOutlineNumericUpDown";
            focusLineOutlineNumericUpDown.Size = new Size(64, 24);
            // focusLineOutlineNumericUpDown.TabIndex = 45;

            focusLineOutlineNumericUpDown.Value = 1;
            focusLineOutlineCheckBox.AutoSize = true;
            focusLineOutlineCheckBox.Font = labelFont;
            focusLineOutlineCheckBox.ForeColor = foreColor;
            focusLineOutlineCheckBox.Location = new Point(620, 9);
            focusLineOutlineCheckBox.Margin = btnPanelMargin;
            focusLineOutlineCheckBox.Name = "focusLineOutlineCheckBox";
            focusLineOutlineCheckBox.Size = new Size(22, 21);
            // focusLineOutlineCheckBox.TabIndex = 45;

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
