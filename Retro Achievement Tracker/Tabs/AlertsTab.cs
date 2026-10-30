using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Utils;

namespace Retro_Achievement_Tracker.Tabs
{
    public class AlertsTab : AbstractTab
    {
        #region Sub elements

        public Label alertsTitleOutlineLabel,
            alertsTitleLabel;
        public NumericUpDown alertsCustomAchievementScaleNumericUpDown,
            alertsCustomAchievementYNumericUpDown,
            alertsCustomAchievementInSpeedUpDown,
            alertsCustomAchievementOutSpeedUpDown,
            alertsCustomMasteryScaleNumericUpDown,
            alertsCustomMasteryYNumericUpDown,
            alertsCustomMasteryOutSpeedUpDown,
            alertsCustomMasteryInSpeedUpDown,
            alertsCustomAchievementXNumericUpDown,
            alertsCustomAchievementOutNumericUpDown,
            alertsCustomAchievementInNumericUpDown,
            alertsCustomMasteryXNumericUpDown,
            alertsCustomMasteryOutNumericUpDown,
            alertsCustomMasteryInNumericUpDown,
            alertsTitleFontOutlineNumericUpDown,
            alertsDescriptionFontOutlineNumericUpDown,
            alertsPointsFontOutlineNumericUpDown,
            alertsLineOutlineNumericUpDown;
        public PictureBox alertsLineColorPictureBox,
            alertsBorderColorPictureBox,
            alertsPointsFontColorPictureBox,
            alertsTitleFontOutlineColorPictureBox,
            alertsDescriptionFontOutlineColorPictureBox,
            alertsDescriptionFontColorPictureBox,
            alertsBackgroundColorPictureBox,
            alertsTitleFontColorPictureBox,
            alertsPointsFontOutlineColorPictureBox,
            alertsLineOutlineColorPictureBox;
        public Button alertsPlayAchievementButton,
            alertsSelectCustomAchievementFileButton,
            alertsSelectCustomMasteryFileButton,
            alertsPlayMasteryButton,
            alertsOpenWindowButton;
        public CheckBox alertsCustomAchievementEnableCheckbox,
            alertsAchievementEditOutlineCheckbox,
            alertsMasteryEditOutlineCheckbox,
            alertsCustomMasteryEnableCheckbox,
            alertsAchievementEnableCheckbox,
            alertsMasteryEnableCheckbox,
            alertsBorderCheckBox,
            alertsAdvancedCheckBox,
            alertsTitleOutlineCheckBox,
            alertsDescriptionOutlineCheckBox,
            alertsAutoOpenWindowCheckbox,
            alertsPointsOutlineCheckBox,
            alertsLineOutlineCheckBox;
        public ComboBox alertsCustomAchievementAnimationInComboBox,
            alertsCustomAchievementAnimationOutComboBox,
            alertsCustomMasteryAnimationOutComboBox,
            alertsCustomMasteryAnimationInComboBox,
            alertsPointsFontComboBox,
            alertsDescriptionFontComboBox,
            alertsTitleFontComboBox;
        public Panel alertsLinePanel,
            alertsPointsPanel,
            alertsDescriptionOutlinePanel,
            alertsDescriptionPanel,
            alertsPointsOutlinePanel,
            alertsLineOutlinePanel,
            alertsCustomAchievementPanel,
            alertsCustomMasteryPanel;

        #endregion

        #region Constructor

        public AlertsTab()
        {
            Name = "AlertsTabPage";
            Text = "Alerts";
            BackColor = btnBackColor;
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                alertsTitleLabel.Text = "Title";
                alertsTitleOutlineLabel.Text = "Title OutlineColor";

                SetFontFamilyBox(alertsTitleFontComboBox, AlertsController.Instance.TitleFontFamily);
                alertsTitleOutlineCheckBox.Checked = AlertsController.Instance.TitleOutlineEnabled;
                alertsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.TitleColor);
                alertsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.TitleOutlineColor);
            }
            else
            {
                alertsTitleLabel.Text = "Font";
                alertsTitleOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(alertsTitleFontComboBox, AlertsController.Instance.SimpleFontFamily);
                alertsTitleOutlineCheckBox.Checked = AlertsController.Instance.SimpleFontOutlineEnabled;
                alertsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.SimpleFontColor);
                alertsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(AlertsController.Instance.SimpleFontOutlineColor);
            }

            alertsDescriptionPanel.Enabled = enable;
            alertsPointsPanel.Enabled = enable;
            alertsLinePanel.Enabled = enable;
            alertsDescriptionOutlinePanel.Enabled = enable;
            alertsPointsOutlinePanel.Enabled = enable;
            alertsLineOutlinePanel.Enabled = enable;
        }

        public override void InitElements()
        {
            alertsPlayAchievementButton = WinFormHelpers.CreateButton("alertsPlayAchievementButton", "Play", new Point(318, 5), new Size(98, 38));
            alertsPlayAchievementButton.BackColor = btnBackColor;
            alertsPlayAchievementButton.FlatAppearance.BorderColor = Color.Black;
            alertsPlayAchievementButton.FlatStyle = FlatStyle.Flat;
            alertsPlayAchievementButton.Font = labelFont;
            alertsPlayAchievementButton.ForeColor = btnForeColor;
            alertsPlayAchievementButton.Margin = btnPanelMargin;
            // alertsPlayAchievementButton.TabIndex = 2;
            alertsPlayAchievementButton.UseVisualStyleBackColor = false;

            alertsSelectCustomAchievementFileButton = WinFormHelpers.CreateButton("alertsSelectCustomAchievementFileButton", "File", new Point(314, 409), new Size(98, 38));
            alertsSelectCustomAchievementFileButton.BackColor = btnBackColor;
            alertsSelectCustomAchievementFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsSelectCustomAchievementFileButton.FlatStyle = FlatStyle.Flat;
            alertsSelectCustomAchievementFileButton.Font = labelFont;
            alertsSelectCustomAchievementFileButton.ForeColor = btnForeColor;
            alertsSelectCustomAchievementFileButton.Margin = btnPanelMargin;
            // alertsSelectCustomAchievementFileButton.TabIndex = 14;
            alertsSelectCustomAchievementFileButton.UseVisualStyleBackColor = false;

            alertsPlayMasteryButton = WinFormHelpers.CreateButton("alertsPlayMasteryButton", "Play", new Point(318, 5), new Size(98, 38));
            alertsPlayMasteryButton.BackColor = btnBackColor;
            alertsPlayMasteryButton.FlatAppearance.BorderColor = Color.Black;
            alertsPlayMasteryButton.FlatStyle = FlatStyle.Flat;
            alertsPlayMasteryButton.Font = labelFont;
            alertsPlayMasteryButton.ForeColor = btnForeColor;
            alertsPlayMasteryButton.Margin = btnPanelMargin;
            // alertsPlayMasteryButton.TabIndex = 2;
            alertsPlayMasteryButton.UseVisualStyleBackColor = false;

            alertsSelectCustomMasteryFileButton = WinFormHelpers.CreateButton("alertsSelectCustomMasteryFileButton", "File", new Point(314, 409), new Size(98, 38));
            alertsSelectCustomMasteryFileButton.BackColor = btnBackColor;
            alertsSelectCustomMasteryFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsSelectCustomMasteryFileButton.FlatStyle = FlatStyle.Flat;
            alertsSelectCustomMasteryFileButton.Font = labelFont;
            alertsSelectCustomMasteryFileButton.ForeColor = btnForeColor;
            alertsSelectCustomMasteryFileButton.Margin = btnPanelMargin;
            // alertsSelectCustomMasteryFileButton.TabIndex = 14;
            alertsSelectCustomMasteryFileButton.UseVisualStyleBackColor = false;

            alertsOpenWindowButton = WinFormHelpers.CreateButton("alertsOpenWindowButton", "Open", new Point(573, 3), new Size(112, 42));
            alertsOpenWindowButton.BackColor = btnBackColor;
            alertsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            alertsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            alertsOpenWindowButton.Font = labelFont;
            alertsOpenWindowButton.ForeColor = btnForeColor;
            alertsOpenWindowButton.Margin = new Padding(0);
            // alertsOpenWindowButton.TabIndex = 10021;
            alertsOpenWindowButton.UseVisualStyleBackColor = false;

            alertsCustomAchievementScaleNumericUpDown = WinFormHelpers.CreateNumericUpDown("alertsCustomAchievementScaleNumericUpDown", 1, new Point(252, 6), new Size(146, 24), 1, 5, 2);
            alertsCustomAchievementScaleNumericUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementScaleNumericUpDown.Font = numUpDownFont;
            alertsCustomAchievementScaleNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementScaleNumericUpDown.Increment = 1;
            alertsCustomAchievementScaleNumericUpDown.Margin = btnPanelMargin;
            // alertsCustomAchievementScaleNumericUpDown.TabIndex = 20;
            alertsCustomAchievementScaleNumericUpDown.Value = 1;

            alertsCustomAchievementXNumericUpDown = WinFormHelpers.CreateNumericUpDown("alertsCustomAchievementXNumericUpDown", 2000, new Point(252, 6), new Size(146, 24), minValue: 2000, maxValue: 2000);
            alertsCustomAchievementXNumericUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementXNumericUpDown.Font = numUpDownFont;
            alertsCustomAchievementXNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementXNumericUpDown.Margin = btnPanelMargin;
            // alertsCustomAchievementXNumericUpDown.TabIndex = 15;

            alertsCustomAchievementYNumericUpDown = WinFormHelpers.CreateNumericUpDown("alertsCustomAchievementYNumericUpDown", 2000, new Point(252, 6), new Size(146, 24), minValue: 2000, maxValue: 2000);
            alertsCustomAchievementYNumericUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementYNumericUpDown.Font = numUpDownFont;
            alertsCustomAchievementYNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementYNumericUpDown.Margin = btnPanelMargin;
            // alertsCustomAchievementYNumericUpDown.TabIndex = 16;

            alertsAchievementEditOutlineCheckbox = WinFormHelpers.CreateCheckBox("alertsAchievementEditOutlineCheckbox", "Edit Mode", new Point(12, 414), new Size(137, 29));
            // alertsAchievementEditOutlineCheckbox.AutoSize = true;
            alertsAchievementEditOutlineCheckbox.Font = labelFont;
            alertsAchievementEditOutlineCheckbox.ForeColor = foreColor;
            alertsAchievementEditOutlineCheckbox.Margin = btnPanelMargin;
            // alertsAchievementEditOutlineCheckbox.TabIndex = 47;
            alertsAchievementEditOutlineCheckbox.UseVisualStyleBackColor = true;

            alertsCustomAchievementOutNumericUpDown = WinFormHelpers.CreateNumericUpDown("alertsCustomAchievementOutNumericUpDown", 300, new Point(252, 6), new Size(146, 24), 300, 100000);
            alertsCustomAchievementOutNumericUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementOutNumericUpDown.Font = numUpDownFont;
            alertsCustomAchievementOutNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementOutNumericUpDown.Margin = btnPanelMargin;
            // alertsCustomAchievementOutNumericUpDown.TabIndex = 26;

            alertsCustomAchievementAnimationOutComboBox = new ComboBox();
            alertsCustomAchievementOutSpeedUpDown = new NumericUpDown();
            alertsCustomAchievementInNumericUpDown = new NumericUpDown();
            alertsCustomAchievementAnimationInComboBox = new ComboBox();
            alertsCustomAchievementInSpeedUpDown = new NumericUpDown();
            alertsCustomAchievementInSpeedUpDown.Value = 50;

            alertsCustomAchievementEnableCheckbox = WinFormHelpers.CreateCheckBox("alertsCustomAchievementEnableCheckbox", "Custom", new Point(129, 9), new Size(114, 29));
            // alertsCustomAchievementEnableCheckbox.AutoSize = true;
            alertsCustomAchievementEnableCheckbox.Font = labelFont;
            alertsCustomAchievementEnableCheckbox.ForeColor = foreColor;
            alertsCustomAchievementEnableCheckbox.Margin = btnPanelMargin;
            // alertsCustomAchievementEnableCheckbox.TabIndex = 13;
            alertsCustomAchievementEnableCheckbox.UseVisualStyleBackColor = true;

            alertsCustomMasteryScaleNumericUpDown = new NumericUpDown();
            alertsCustomMasteryXNumericUpDown = new NumericUpDown();
            alertsCustomMasteryYNumericUpDown = new NumericUpDown();

            alertsMasteryEditOutlineCheckbox = WinFormHelpers.CreateCheckBox("alertsMasteryEditOutlineCheckbox", "Edit Mode", new Point(12, 414), new Size(137, 29));
            // alertsMasteryEditOutlineCheckbox.AutoSize = true;
            alertsMasteryEditOutlineCheckbox.Font = labelFont;
            alertsMasteryEditOutlineCheckbox.ForeColor = foreColor;
            alertsMasteryEditOutlineCheckbox.Margin = btnPanelMargin;
            // alertsMasteryEditOutlineCheckbox.TabIndex = 47;
            alertsMasteryEditOutlineCheckbox.UseVisualStyleBackColor = true;

            alertsCustomMasteryOutNumericUpDown = new NumericUpDown();
            alertsCustomMasteryAnimationOutComboBox = new ComboBox();
            alertsCustomMasteryOutSpeedUpDown = new NumericUpDown();
            alertsCustomMasteryInNumericUpDown = new NumericUpDown();
            alertsCustomMasteryAnimationInComboBox = new ComboBox();
            alertsCustomMasteryInSpeedUpDown = new NumericUpDown();

            alertsCustomMasteryEnableCheckbox = WinFormHelpers.CreateCheckBox("alertsCustomMasteryEnableCheckbox", "Custom", new Point(129, 9), new Size(114, 29));
            // alertsCustomMasteryEnableCheckbox.AutoSize = true;
            alertsCustomMasteryEnableCheckbox.Font = labelFont;
            alertsCustomMasteryEnableCheckbox.ForeColor = foreColor;
            alertsCustomMasteryEnableCheckbox.Margin = btnPanelMargin;
            // alertsCustomMasteryEnableCheckbox.TabIndex = 13;
            alertsCustomMasteryEnableCheckbox.UseVisualStyleBackColor = true;

            alertsLinePanel = new Panel();
            alertsLineColorPictureBox = new PictureBox();

            alertsBorderCheckBox = WinFormHelpers.CreateCheckBox("alertsBorderCheckBox", "", new Point(620, 8), new Size(22, 21));
            // alertsBorderCheckBox.AutoSize = true;
            alertsBorderCheckBox.Font = labelFont;
            alertsBorderCheckBox.ForeColor = foreColor;
            alertsBorderCheckBox.Margin = btnPanelMargin;
            // alertsBorderCheckBox.TabIndex = 10065;
            alertsBorderCheckBox.UseVisualStyleBackColor = true;

            alertsBorderColorPictureBox = new PictureBox();
            alertsPointsPanel = new Panel();
            alertsPointsFontColorPictureBox = new PictureBox();
            alertsPointsFontComboBox = new ComboBox();

            alertsAdvancedCheckBox = WinFormHelpers.CreateCheckBox("alertsAdvancedCheckBox", "Advanced", new Point(8, 3), new Size(135, 29));
            // alertsAdvancedCheckBox.AutoSize = true;
            alertsAdvancedCheckBox.BackColor = Color.Transparent;
            alertsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            alertsAdvancedCheckBox.Font = labelFont;
            alertsAdvancedCheckBox.ForeColor = foreColor;
            alertsAdvancedCheckBox.Margin = btnPanelMargin;
            // alertsAdvancedCheckBox.TabIndex = 10053;
            alertsAdvancedCheckBox.UseVisualStyleBackColor = false;

            alertsTitleFontOutlineNumericUpDown = new NumericUpDown();

            alertsTitleOutlineCheckBox = WinFormHelpers.CreateCheckBox("alertsTitleOutlineCheckBox", "", new Point(620, 8), new Size(22, 21));
            // alertsTitleOutlineCheckBox.AutoSize = true;
            alertsTitleOutlineCheckBox.Font = labelFont;
            alertsTitleOutlineCheckBox.ForeColor = foreColor;
            alertsTitleOutlineCheckBox.Margin = btnPanelMargin;
            // alertsTitleOutlineCheckBox.TabIndex = 45;
            alertsTitleOutlineCheckBox.UseVisualStyleBackColor = true;

            alertsTitleOutlineLabel = new Label();
            alertsTitleFontOutlineColorPictureBox = new PictureBox();
            alertsDescriptionOutlinePanel = new Panel();
            alertsDescriptionFontOutlineColorPictureBox = new PictureBox();
            alertsDescriptionFontOutlineNumericUpDown = new NumericUpDown();

            alertsDescriptionOutlineCheckBox = WinFormHelpers.CreateCheckBox("alertsDescriptionOutlineCheckBox", "", new Point(620, 9), new Size(22, 21));
            // alertsDescriptionOutlineCheckBox.AutoSize = true;
            alertsDescriptionOutlineCheckBox.Font = labelFont;
            alertsDescriptionOutlineCheckBox.ForeColor = foreColor;
            alertsDescriptionOutlineCheckBox.Margin = btnPanelMargin;
            // alertsDescriptionOutlineCheckBox.TabIndex = 45;
            alertsDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;

            alertsDescriptionPanel = new Panel();
            alertsDescriptionFontColorPictureBox = new PictureBox();
            alertsDescriptionFontComboBox = new ComboBox();

            alertsAutoOpenWindowCheckbox = WinFormHelpers.CreateCheckBox("alertsAutoOpenWindowCheckbox", "Auto-Open", new Point(378, 14), new Size(147, 29));
            // alertsAutoOpenWindowCheckbox.AutoSize = true;
            alertsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            alertsAutoOpenWindowCheckbox.Font = labelFont;
            alertsAutoOpenWindowCheckbox.ForeColor = foreColor;
            alertsAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            // alertsAutoOpenWindowCheckbox.TabIndex = 10022;
            alertsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;

            alertsBackgroundColorPictureBox = new PictureBox();
            alertsTitleLabel = new Label();
            alertsTitleFontColorPictureBox = new PictureBox();
            alertsTitleFontComboBox = new ComboBox();
            alertsPointsOutlinePanel = new Panel();
            alertsPointsFontOutlineNumericUpDown = new NumericUpDown();

            alertsPointsOutlineCheckBox = WinFormHelpers.CreateCheckBox("alertsPointsOutlineCheckBox", "", new Point(620, 8), new Size(22, 21));
            // alertsPointsOutlineCheckBox.AutoSize = true;
            alertsPointsOutlineCheckBox.Font = labelFont;
            alertsPointsOutlineCheckBox.ForeColor = foreColor;
            alertsPointsOutlineCheckBox.Margin = btnPanelMargin;
            // alertsPointsOutlineCheckBox.TabIndex = 45;
            alertsPointsOutlineCheckBox.UseVisualStyleBackColor = true;

            alertsPointsFontOutlineColorPictureBox = new PictureBox();
            alertsLineOutlinePanel = new Panel();
            alertsLineOutlineColorPictureBox = new PictureBox();
            alertsLineOutlineNumericUpDown = new NumericUpDown();

            alertsLineOutlineCheckBox = WinFormHelpers.CreateCheckBox("alertsLineOutlineCheckBox", "", new Point(620, 9), new Size(22, 21));
            // alertsLineOutlineCheckBox.AutoSize = true;
            alertsLineOutlineCheckBox.Font = labelFont;
            alertsLineOutlineCheckBox.ForeColor = foreColor;
            alertsLineOutlineCheckBox.Margin = btnPanelMargin;
            // alertsLineOutlineCheckBox.TabIndex = 45;
            alertsLineOutlineCheckBox.UseVisualStyleBackColor = true;

            alertsCustomAchievementPanel = new Panel();

            alertsAchievementEnableCheckbox = WinFormHelpers.CreateCheckBox("alertsAchievementEnableCheckbox", "Enable", new Point(16, 9), new Size(106, 29));
            // alertsAchievementEnableCheckbox.AutoSize = true;
            alertsAchievementEnableCheckbox.Font = labelFont;
            alertsAchievementEnableCheckbox.ForeColor = foreColor;
            alertsAchievementEnableCheckbox.Margin = btnPanelMargin;
            alertsAchievementEnableCheckbox.Size = new Size(106, 29);
            // alertsAchievementEnableCheckbox.TabIndex = 54;
            alertsAchievementEnableCheckbox.UseVisualStyleBackColor = true;

            alertsCustomMasteryPanel = new Panel();

            alertsMasteryEnableCheckbox = WinFormHelpers.CreateCheckBox("alertsMasteryEnableCheckbox", "Enable", new Point(16, 9), new Size(106, 29));
            // alertsMasteryEnableCheckbox.AutoSize = true;
            alertsMasteryEnableCheckbox.Font = labelFont;
            alertsMasteryEnableCheckbox.ForeColor = foreColor;
            alertsMasteryEnableCheckbox.Margin = btnPanelMargin;
            // alertsMasteryEnableCheckbox.TabIndex = 54;
            alertsMasteryEnableCheckbox.UseVisualStyleBackColor = true;

            alertsLinePanel.SuspendLayout();
            alertsPointsPanel.SuspendLayout();
            alertsDescriptionOutlinePanel.SuspendLayout();
            alertsDescriptionPanel.SuspendLayout();
            alertsPointsOutlinePanel.SuspendLayout();
            alertsLineOutlinePanel.SuspendLayout();
            alertsCustomAchievementPanel.SuspendLayout();
            alertsCustomMasteryPanel.SuspendLayout();

            alertsCustomAchievementAnimationOutComboBox.BackColor = btnBackColor;
            alertsCustomAchievementAnimationOutComboBox.Font = numUpDownFont;
            alertsCustomAchievementAnimationOutComboBox.ForeColor = Color.White;
            alertsCustomAchievementAnimationOutComboBox.FormattingEnabled = true;
            alertsCustomAchievementAnimationOutComboBox.Location = new Point(252, 2);
            alertsCustomAchievementAnimationOutComboBox.Margin = btnPanelMargin;
            alertsCustomAchievementAnimationOutComboBox.Name = "alertsCustomAchievementAnimationOutComboBox";
            alertsCustomAchievementAnimationOutComboBox.Size = new Size(144, 28);
            // alertsCustomAchievementAnimationOutComboBox.TabIndex = 39;
            alertsCustomAchievementOutSpeedUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementOutSpeedUpDown.Font = numUpDownFont;
            alertsCustomAchievementOutSpeedUpDown.ForeColor = Color.White;
            alertsCustomAchievementOutSpeedUpDown.Location = new Point(252, 6);
            alertsCustomAchievementOutSpeedUpDown.Margin = btnPanelMargin;
            alertsCustomAchievementOutSpeedUpDown.Maximum = 10000;
            alertsCustomAchievementOutSpeedUpDown.Minimum = 50;
            alertsCustomAchievementOutSpeedUpDown.Name = "alertsCustomAchievementOutSpeedUpDown";
            alertsCustomAchievementOutSpeedUpDown.Size = new Size(146, 24);
            // alertsCustomAchievementOutSpeedUpDown.TabIndex = 48;
            alertsCustomAchievementOutSpeedUpDown.Value = 50;
            alertsCustomAchievementInNumericUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementInNumericUpDown.Font = numUpDownFont;
            alertsCustomAchievementInNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementInNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementInNumericUpDown.Margin = btnPanelMargin;
            alertsCustomAchievementInNumericUpDown.Maximum = 100000;
            alertsCustomAchievementInNumericUpDown.Minimum = 300;
            alertsCustomAchievementInNumericUpDown.Name = "alertsCustomAchievementInNumericUpDown";
            alertsCustomAchievementInNumericUpDown.Size = new Size(146, 24);
            // alertsCustomAchievementInNumericUpDown.TabIndex = 26;
            alertsCustomAchievementInNumericUpDown.Value = 300;
            alertsCustomAchievementAnimationInComboBox.BackColor = btnBackColor;
            alertsCustomAchievementAnimationInComboBox.Font = numUpDownFont;
            alertsCustomAchievementAnimationInComboBox.ForeColor = Color.White;
            alertsCustomAchievementAnimationInComboBox.FormattingEnabled = true;
            alertsCustomAchievementAnimationInComboBox.Location = new Point(252, 2);
            alertsCustomAchievementAnimationInComboBox.Margin = btnPanelMargin;
            alertsCustomAchievementAnimationInComboBox.Name = "alertsCustomAchievementAnimationInComboBox";
            alertsCustomAchievementAnimationInComboBox.Size = new Size(144, 28);
            // alertsCustomAchievementAnimationInComboBox.TabIndex = 39;
            alertsCustomAchievementInSpeedUpDown.BackColor = numUpDownBackColor;
            alertsCustomAchievementInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementInSpeedUpDown.Font = numUpDownFont;
            alertsCustomAchievementInSpeedUpDown.ForeColor = Color.White;
            alertsCustomAchievementInSpeedUpDown.Location = new Point(252, 6);
            alertsCustomAchievementInSpeedUpDown.Margin = btnPanelMargin;
            alertsCustomAchievementInSpeedUpDown.Maximum = 10000;
            alertsCustomAchievementInSpeedUpDown.Minimum = 50;
            alertsCustomAchievementInSpeedUpDown.Name = "alertsCustomAchievementInSpeedUpDown";
            alertsCustomAchievementInSpeedUpDown.Size = new Size(146, 24);
            // alertsCustomAchievementInSpeedUpDown.TabIndex = 48;

            alertsCustomMasteryScaleNumericUpDown.BackColor = panelBackColor;
            alertsCustomMasteryScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryScaleNumericUpDown.DecimalPlaces = 2;
            alertsCustomMasteryScaleNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryScaleNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryScaleNumericUpDown.Increment = 1;
            alertsCustomMasteryScaleNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryScaleNumericUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryScaleNumericUpDown.Maximum = 5;
            alertsCustomMasteryScaleNumericUpDown.Minimum = 1;
            alertsCustomMasteryScaleNumericUpDown.Name = "alertsCustomMasteryScaleNumericUpDown";
            alertsCustomMasteryScaleNumericUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryScaleNumericUpDown.TabIndex = 20;
            alertsCustomMasteryScaleNumericUpDown.Value = 1;
            alertsCustomMasteryXNumericUpDown.BackColor = panelBackColor;
            alertsCustomMasteryXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryXNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryXNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryXNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryXNumericUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryXNumericUpDown.Maximum = 2000;
            alertsCustomMasteryXNumericUpDown.Minimum = 2000;
            alertsCustomMasteryXNumericUpDown.Name = "alertsCustomMasteryXNumericUpDown";
            alertsCustomMasteryXNumericUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryXNumericUpDown.TabIndex = 15;
            alertsCustomMasteryYNumericUpDown.BackColor = panelBackColor;
            alertsCustomMasteryYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryYNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryYNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryYNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryYNumericUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryYNumericUpDown.Maximum = 2000;
            alertsCustomMasteryYNumericUpDown.Minimum = 2000;
            alertsCustomMasteryYNumericUpDown.Name = "alertsCustomMasteryYNumericUpDown";
            alertsCustomMasteryYNumericUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryYNumericUpDown.TabIndex = 16;

            alertsCustomMasteryOutNumericUpDown.BackColor = panelBackColor;
            alertsCustomMasteryOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryOutNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryOutNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryOutNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryOutNumericUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryOutNumericUpDown.Maximum = 100000;
            alertsCustomMasteryOutNumericUpDown.Minimum = 300;
            alertsCustomMasteryOutNumericUpDown.Name = "alertsCustomMasteryOutNumericUpDown";
            alertsCustomMasteryOutNumericUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryOutNumericUpDown.TabIndex = 26;
            alertsCustomMasteryOutNumericUpDown.Value = 300;
            alertsCustomMasteryAnimationOutComboBox.BackColor = btnBackColor;
            alertsCustomMasteryAnimationOutComboBox.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryAnimationOutComboBox.ForeColor = Color.White;
            alertsCustomMasteryAnimationOutComboBox.FormattingEnabled = true;
            alertsCustomMasteryAnimationOutComboBox.Location = new Point(252, 2);
            alertsCustomMasteryAnimationOutComboBox.Margin = btnPanelMargin;
            alertsCustomMasteryAnimationOutComboBox.Name = "alertsCustomMasteryAnimationOutComboBox";
            alertsCustomMasteryAnimationOutComboBox.Size = new Size(144, 28);
            // alertsCustomMasteryAnimationOutComboBox.TabIndex = 39;
            alertsCustomMasteryOutSpeedUpDown.BackColor = panelBackColor;
            alertsCustomMasteryOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryOutSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryOutSpeedUpDown.ForeColor = Color.White;
            alertsCustomMasteryOutSpeedUpDown.Location = new Point(252, 6);
            alertsCustomMasteryOutSpeedUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryOutSpeedUpDown.Maximum = 10000;
            alertsCustomMasteryOutSpeedUpDown.Minimum = 50;
            alertsCustomMasteryOutSpeedUpDown.Name = "alertsCustomMasteryOutSpeedUpDown";
            alertsCustomMasteryOutSpeedUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryOutSpeedUpDown.TabIndex = 48;
            alertsCustomMasteryOutSpeedUpDown.Value = 50;
            alertsCustomMasteryInNumericUpDown.BackColor = panelBackColor;
            alertsCustomMasteryInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryInNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryInNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryInNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryInNumericUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryInNumericUpDown.Maximum = 100000;
            alertsCustomMasteryInNumericUpDown.Minimum = 300;
            alertsCustomMasteryInNumericUpDown.Name = "alertsCustomMasteryInNumericUpDown";
            alertsCustomMasteryInNumericUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryInNumericUpDown.TabIndex = 26;
            alertsCustomMasteryInNumericUpDown.Value = 300;
            alertsCustomMasteryAnimationInComboBox.BackColor = btnBackColor;
            alertsCustomMasteryAnimationInComboBox.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryAnimationInComboBox.ForeColor = Color.White;
            alertsCustomMasteryAnimationInComboBox.FormattingEnabled = true;
            alertsCustomMasteryAnimationInComboBox.Location = new Point(252, 2);
            alertsCustomMasteryAnimationInComboBox.Margin = btnPanelMargin;
            alertsCustomMasteryAnimationInComboBox.Name = "alertsCustomMasteryAnimationInComboBox";
            alertsCustomMasteryAnimationInComboBox.Size = new Size(144, 28);
            // alertsCustomMasteryAnimationInComboBox.TabIndex = 39;
            alertsCustomMasteryInSpeedUpDown.BackColor = panelBackColor;
            alertsCustomMasteryInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryInSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryInSpeedUpDown.ForeColor = Color.White;
            alertsCustomMasteryInSpeedUpDown.Location = new Point(252, 6);
            alertsCustomMasteryInSpeedUpDown.Margin = btnPanelMargin;
            alertsCustomMasteryInSpeedUpDown.Maximum = 10000;
            alertsCustomMasteryInSpeedUpDown.Minimum = 50;
            alertsCustomMasteryInSpeedUpDown.Name = "alertsCustomMasteryInSpeedUpDown";
            alertsCustomMasteryInSpeedUpDown.Size = new Size(146, 24);
            // alertsCustomMasteryInSpeedUpDown.TabIndex = 48;
            alertsCustomMasteryInSpeedUpDown.Value = 50;

            alertsLinePanel.BackColor = panelBackColor;
            alertsLinePanel.Location = new Point(3, 265);
            alertsLinePanel.Margin = btnPanelMargin;
            alertsLinePanel.Name = "alertsLinePanel";
            alertsLinePanel.Size = new Size(694, 35);
            // alertsLinePanel.TabIndex = 10068;
            alertsLineColorPictureBox.BackColor = Color.White;
            alertsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsLineColorPictureBox.Location = new Point(230, 5);
            alertsLineColorPictureBox.Margin = btnPanelMargin;
            alertsLineColorPictureBox.Name = "alertsLineColorPictureBox";
            alertsLineColorPictureBox.Size = new Size(22, 22);
            // alertsLineColorPictureBox.TabIndex = 45;
            alertsLineColorPictureBox.TabStop = false;

            alertsBorderColorPictureBox.BackColor = Color.White;
            alertsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsBorderColorPictureBox.Location = new Point(230, 5);
            alertsBorderColorPictureBox.Margin = btnPanelMargin;
            alertsBorderColorPictureBox.Name = "alertsBorderColorPictureBox";
            alertsBorderColorPictureBox.Size = new Size(22, 22);
            // alertsBorderColorPictureBox.TabIndex = 42;
            alertsBorderColorPictureBox.TabStop = false;
            alertsPointsPanel.BackColor = btnBackColor;
            alertsPointsPanel.Location = new Point(3, 231);
            alertsPointsPanel.Margin = btnPanelMargin;
            alertsPointsPanel.Name = "alertsPointsPanel";
            alertsPointsPanel.Size = new Size(694, 35);
            // alertsPointsPanel.TabIndex = 10070;
            alertsPointsFontColorPictureBox.BackColor = Color.White;
            alertsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsPointsFontColorPictureBox.Location = new Point(230, 6);
            alertsPointsFontColorPictureBox.Margin = btnPanelMargin;
            alertsPointsFontColorPictureBox.Name = "alertsPointsFontColorPictureBox";
            alertsPointsFontColorPictureBox.Size = new Size(22, 22);
            // alertsPointsFontColorPictureBox.TabIndex = 45;
            alertsPointsFontColorPictureBox.TabStop = false;
            alertsPointsFontComboBox.BackColor = btnBackColor;
            alertsPointsFontComboBox.FlatStyle = FlatStyle.System;
            alertsPointsFontComboBox.Font = numUpDownFont;
            alertsPointsFontComboBox.ForeColor = Color.White;
            alertsPointsFontComboBox.FormattingEnabled = true;
            alertsPointsFontComboBox.Location = new Point(290, 3);
            alertsPointsFontComboBox.Margin = btnPanelMargin;
            alertsPointsFontComboBox.Name = "alertsPointsFontComboBox";
            alertsPointsFontComboBox.Size = new Size(301, 28);
            // alertsPointsFontComboBox.TabIndex = 45;

            alertsTitleFontOutlineNumericUpDown.BackColor = panelBackColor;
            alertsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTitleFontOutlineNumericUpDown.Font = numUpDownFont;
            alertsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTitleFontOutlineNumericUpDown.Margin = btnPanelMargin;
            alertsTitleFontOutlineNumericUpDown.Maximum = 5;
            alertsTitleFontOutlineNumericUpDown.Minimum = 1;
            alertsTitleFontOutlineNumericUpDown.Name = "alertsTitleFontOutlineNumericUpDown";
            alertsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            // alertsTitleFontOutlineNumericUpDown.TabIndex = 45;
            alertsTitleFontOutlineNumericUpDown.Value = 1;

            alertsTitleOutlineLabel.BackColor = Color.Transparent;
            alertsTitleOutlineLabel.Font = labelFont;
            alertsTitleOutlineLabel.ForeColor = foreColor;
            alertsTitleOutlineLabel.Location = new Point(4, 5);
            alertsTitleOutlineLabel.Margin = labelMargin;
            alertsTitleOutlineLabel.Name = "alertsTitleOutlineLabel";
            alertsTitleOutlineLabel.Size = new Size(216, 25);
            // alertsTitleOutlineLabel.TabIndex = 10066;
            alertsTitleOutlineLabel.Text = "Title OutlineColor";
            alertsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            alertsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsTitleFontOutlineColorPictureBox.Margin = btnPanelMargin;
            alertsTitleFontOutlineColorPictureBox.Name = "alertsTitleFontOutlineColorPictureBox";
            alertsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            // alertsTitleFontOutlineColorPictureBox.TabIndex = 45;
            alertsTitleFontOutlineColorPictureBox.TabStop = false;
            alertsDescriptionOutlinePanel.BackColor = panelBackColor;
            alertsDescriptionOutlinePanel.Location = new Point(3, 332);
            alertsDescriptionOutlinePanel.Margin = btnPanelMargin;
            alertsDescriptionOutlinePanel.Name = "alertsDescriptionOutlinePanel";
            alertsDescriptionOutlinePanel.Size = new Size(694, 35);
            // alertsDescriptionOutlinePanel.TabIndex = 10072;
            alertsDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            alertsDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            alertsDescriptionFontOutlineColorPictureBox.Margin = btnPanelMargin;
            alertsDescriptionFontOutlineColorPictureBox.Name = "alertsDescriptionFontOutlineColorPictureBox";
            alertsDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            // alertsDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            alertsDescriptionFontOutlineColorPictureBox.TabStop = false;
            alertsDescriptionFontOutlineNumericUpDown.BackColor = panelBackColor;
            alertsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsDescriptionFontOutlineNumericUpDown.Font = numUpDownFont;
            alertsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsDescriptionFontOutlineNumericUpDown.Margin = btnPanelMargin;
            alertsDescriptionFontOutlineNumericUpDown.Maximum = 5;
            alertsDescriptionFontOutlineNumericUpDown.Minimum = 1;
            alertsDescriptionFontOutlineNumericUpDown.Name = "alertsDescriptionFontOutlineNumericUpDown";
            alertsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            // alertsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            alertsDescriptionFontOutlineNumericUpDown.Value = 1;

            alertsDescriptionPanel.BackColor = panelBackColor;
            alertsDescriptionPanel.Location = new Point(3, 197);
            alertsDescriptionPanel.Margin = btnPanelMargin;
            alertsDescriptionPanel.Name = "alertsDescriptionPanel";
            alertsDescriptionPanel.Size = new Size(694, 35);
            // alertsDescriptionPanel.TabIndex = 10061;
            alertsDescriptionFontColorPictureBox.BackColor = Color.White;
            alertsDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsDescriptionFontColorPictureBox.Location = new Point(230, 5);
            alertsDescriptionFontColorPictureBox.Margin = btnPanelMargin;
            alertsDescriptionFontColorPictureBox.Name = "alertsDescriptionFontColorPictureBox";
            alertsDescriptionFontColorPictureBox.Size = new Size(22, 22);
            // alertsDescriptionFontColorPictureBox.TabIndex = 45;
            alertsDescriptionFontColorPictureBox.TabStop = false;
            alertsDescriptionFontComboBox.BackColor = btnBackColor;
            alertsDescriptionFontComboBox.FlatStyle = FlatStyle.System;
            alertsDescriptionFontComboBox.Font = numUpDownFont;
            alertsDescriptionFontComboBox.ForeColor = Color.White;
            alertsDescriptionFontComboBox.FormattingEnabled = true;
            alertsDescriptionFontComboBox.Location = new Point(290, 3);
            alertsDescriptionFontComboBox.Margin = btnPanelMargin;
            alertsDescriptionFontComboBox.Name = "alertsDescriptionFontComboBox";
            alertsDescriptionFontComboBox.Size = new Size(301, 28);
            // alertsDescriptionFontComboBox.TabIndex = 45;

            alertsBackgroundColorPictureBox.BackColor = Color.White;
            alertsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsBackgroundColorPictureBox.Location = new Point(230, 5);
            alertsBackgroundColorPictureBox.Margin = btnPanelMargin;
            alertsBackgroundColorPictureBox.Name = "alertsBackgroundColorPictureBox";
            alertsBackgroundColorPictureBox.Size = new Size(22, 22);
            // alertsBackgroundColorPictureBox.TabIndex = 42;
            alertsBackgroundColorPictureBox.TabStop = false;
            alertsTitleLabel.BackColor = Color.Transparent;
            alertsTitleLabel.Font = labelFont;
            alertsTitleLabel.ForeColor = foreColor;
            alertsTitleLabel.Location = new Point(4, 6);
            alertsTitleLabel.Margin = labelMargin;
            alertsTitleLabel.Name = "alertsTitleLabel";
            alertsTitleLabel.Size = new Size(216, 25);
            // alertsTitleLabel.TabIndex = 10065;
            alertsTitleLabel.Text = "Title";
            alertsTitleFontColorPictureBox.BackColor = Color.White;
            alertsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTitleFontColorPictureBox.Location = new Point(230, 6);
            alertsTitleFontColorPictureBox.Margin = btnPanelMargin;
            alertsTitleFontColorPictureBox.Name = "alertsTitleFontColorPictureBox";
            alertsTitleFontColorPictureBox.Size = new Size(22, 22);
            // alertsTitleFontColorPictureBox.TabIndex = 45;
            alertsTitleFontColorPictureBox.TabStop = false;
            alertsTitleFontComboBox.BackColor = btnBackColor;
            alertsTitleFontComboBox.FlatStyle = FlatStyle.System;
            alertsTitleFontComboBox.Font = numUpDownFont;
            alertsTitleFontComboBox.ForeColor = Color.White;
            alertsTitleFontComboBox.FormattingEnabled = true;
            alertsTitleFontComboBox.Location = new Point(290, 3);
            alertsTitleFontComboBox.Margin = btnPanelMargin;
            alertsTitleFontComboBox.Name = "alertsTitleFontComboBox";
            alertsTitleFontComboBox.Size = new Size(301, 28);
            // alertsTitleFontComboBox.TabIndex = 45;
            alertsPointsOutlinePanel.BackColor = btnBackColor;
            alertsPointsOutlinePanel.Location = new Point(3, 366);
            alertsPointsOutlinePanel.Margin = btnPanelMargin;
            alertsPointsOutlinePanel.Name = "alertsPointsOutlinePanel";
            alertsPointsOutlinePanel.Size = new Size(694, 35);
            // alertsPointsOutlinePanel.TabIndex = 10061;
            alertsPointsFontOutlineNumericUpDown.BackColor = panelBackColor;
            alertsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsPointsFontOutlineNumericUpDown.Font = numUpDownFont;
            alertsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsPointsFontOutlineNumericUpDown.Margin = btnPanelMargin;
            alertsPointsFontOutlineNumericUpDown.Maximum = 5;
            alertsPointsFontOutlineNumericUpDown.Minimum = 1;
            alertsPointsFontOutlineNumericUpDown.Name = "alertsPointsFontOutlineNumericUpDown";
            alertsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            // alertsPointsFontOutlineNumericUpDown.TabIndex = 45;
            alertsPointsFontOutlineNumericUpDown.Value = 1;

            alertsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            alertsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsPointsFontOutlineColorPictureBox.Margin = btnPanelMargin;
            alertsPointsFontOutlineColorPictureBox.Name = "alertsPointsFontOutlineColorPictureBox";
            alertsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            // alertsPointsFontOutlineColorPictureBox.TabIndex = 45;
            alertsPointsFontOutlineColorPictureBox.TabStop = false;
            alertsLineOutlinePanel.BackColor = panelBackColor;
            alertsLineOutlinePanel.Location = new Point(3, 400);
            alertsLineOutlinePanel.Margin = btnPanelMargin;
            alertsLineOutlinePanel.Name = "alertsLineOutlinePanel";
            alertsLineOutlinePanel.Size = new Size(694, 35);
            // alertsLineOutlinePanel.TabIndex = 10067;
            alertsLineOutlineColorPictureBox.BackColor = Color.White;
            alertsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsLineOutlineColorPictureBox.Location = new Point(230, 6);
            alertsLineOutlineColorPictureBox.Margin = btnPanelMargin;
            alertsLineOutlineColorPictureBox.Name = "alertsLineOutlineColorPictureBox";
            alertsLineOutlineColorPictureBox.Size = new Size(22, 22);
            // alertsLineOutlineColorPictureBox.TabIndex = 45;
            alertsLineOutlineColorPictureBox.TabStop = false;
            alertsLineOutlineNumericUpDown.BackColor = panelBackColor;
            alertsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsLineOutlineNumericUpDown.Font = numUpDownFont;
            alertsLineOutlineNumericUpDown.ForeColor = Color.White;
            alertsLineOutlineNumericUpDown.Location = new Point(528, 6);
            alertsLineOutlineNumericUpDown.Margin = btnPanelMargin;
            alertsLineOutlineNumericUpDown.Maximum = 5;
            alertsLineOutlineNumericUpDown.Minimum = 1;
            alertsLineOutlineNumericUpDown.Name = "alertsLineOutlineNumericUpDown";
            alertsLineOutlineNumericUpDown.Size = new Size(64, 24);
            // alertsLineOutlineNumericUpDown.TabIndex = 45;
            alertsLineOutlineNumericUpDown.Value = 1;

            alertsCustomAchievementPanel.Location = new Point(4, 49);
            alertsCustomAchievementPanel.Margin = btnPanelMargin;
            alertsCustomAchievementPanel.Name = "alertsCustomAchievementPanel";
            alertsCustomAchievementPanel.Size = new Size(417, 452);
            // alertsCustomAchievementPanel.TabIndex = 10082;

            alertsCustomMasteryPanel.Location = new Point(4, 49);
            alertsCustomMasteryPanel.Margin = btnPanelMargin;
            alertsCustomMasteryPanel.Name = "alertsCustomMasteryPanel";
            alertsCustomMasteryPanel.Size = new Size(418, 452);
            // alertsCustomMasteryPanel.TabIndex = 10083;

            alertsLinePanel.ResumeLayout(false);
            alertsPointsPanel.ResumeLayout(false);
            alertsDescriptionOutlinePanel.ResumeLayout(false);
            alertsDescriptionOutlinePanel.PerformLayout();
            alertsDescriptionPanel.ResumeLayout(false);
            alertsPointsOutlinePanel.ResumeLayout(false);
            alertsPointsOutlinePanel.PerformLayout();
            alertsLineOutlinePanel.ResumeLayout(false);
            alertsLineOutlinePanel.PerformLayout();
            alertsCustomAchievementPanel.ResumeLayout(false);
            alertsCustomAchievementPanel.PerformLayout();
            alertsCustomMasteryPanel.ResumeLayout(false);
            alertsCustomMasteryPanel.PerformLayout();
        }

        #endregion
    }
}
