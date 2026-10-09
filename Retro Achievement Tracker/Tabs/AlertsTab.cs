using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

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
            BackColor = Color.FromArgb(22, 22, 22);
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
            alertsPlayAchievementButton = new Button();
            alertsSelectCustomAchievementFileButton = new Button();
            alertsCustomAchievementScaleNumericUpDown = new NumericUpDown();
            alertsCustomAchievementXNumericUpDown = new NumericUpDown();
            alertsCustomAchievementYNumericUpDown = new NumericUpDown();
            alertsAchievementEditOutlineCheckbox = new CheckBox();
            alertsCustomAchievementOutNumericUpDown = new NumericUpDown();
            alertsCustomAchievementAnimationOutComboBox = new ComboBox();
            alertsCustomAchievementOutSpeedUpDown = new NumericUpDown();
            alertsCustomAchievementInNumericUpDown = new NumericUpDown();
            alertsCustomAchievementAnimationInComboBox = new ComboBox();
            alertsCustomAchievementInSpeedUpDown = new NumericUpDown();
            alertsCustomAchievementEnableCheckbox = new CheckBox();
            alertsPlayMasteryButton = new Button();
            alertsSelectCustomMasteryFileButton = new Button();
            alertsCustomMasteryScaleNumericUpDown = new NumericUpDown();
            alertsCustomMasteryXNumericUpDown = new NumericUpDown();
            alertsCustomMasteryYNumericUpDown = new NumericUpDown();
            alertsMasteryEditOutlineCheckbox = new CheckBox();
            alertsCustomMasteryOutNumericUpDown = new NumericUpDown();
            alertsCustomMasteryAnimationOutComboBox = new ComboBox();
            alertsCustomMasteryOutSpeedUpDown = new NumericUpDown();
            alertsCustomMasteryInNumericUpDown = new NumericUpDown();
            alertsCustomMasteryAnimationInComboBox = new ComboBox();
            alertsCustomMasteryInSpeedUpDown = new NumericUpDown();
            alertsCustomMasteryEnableCheckbox = new CheckBox();
            alertsLinePanel = new Panel();
            alertsLineColorPictureBox = new PictureBox();
            alertsBorderCheckBox = new CheckBox();
            alertsBorderColorPictureBox = new PictureBox();
            alertsPointsPanel = new Panel();
            alertsPointsFontColorPictureBox = new PictureBox();
            alertsPointsFontComboBox = new ComboBox();
            alertsAdvancedCheckBox = new CheckBox();
            alertsTitleFontOutlineNumericUpDown = new NumericUpDown();
            alertsTitleOutlineCheckBox = new CheckBox();
            alertsTitleOutlineLabel = new Label();
            alertsTitleFontOutlineColorPictureBox = new PictureBox();
            alertsOpenWindowButton = new Button();
            alertsDescriptionOutlinePanel = new Panel();
            alertsDescriptionFontOutlineColorPictureBox = new PictureBox();
            alertsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            alertsDescriptionOutlineCheckBox = new CheckBox();
            alertsDescriptionPanel = new Panel();
            alertsDescriptionFontColorPictureBox = new PictureBox();
            alertsDescriptionFontComboBox = new ComboBox();
            alertsAutoOpenWindowCheckbox = new CheckBox();
            alertsBackgroundColorPictureBox = new PictureBox();
            alertsTitleLabel = new Label();
            alertsTitleFontColorPictureBox = new PictureBox();
            alertsTitleFontComboBox = new ComboBox();
            alertsPointsOutlinePanel = new Panel();
            alertsPointsFontOutlineNumericUpDown = new NumericUpDown();
            alertsPointsOutlineCheckBox = new CheckBox();
            alertsPointsFontOutlineColorPictureBox = new PictureBox();
            alertsLineOutlinePanel = new Panel();
            alertsLineOutlineColorPictureBox = new PictureBox();
            alertsLineOutlineNumericUpDown = new NumericUpDown();
            alertsLineOutlineCheckBox = new CheckBox();
            alertsCustomAchievementPanel = new Panel();
            alertsAchievementEnableCheckbox = new CheckBox();
            alertsCustomMasteryPanel = new Panel();
            alertsMasteryEnableCheckbox = new CheckBox();
            alertsLinePanel.SuspendLayout();
            alertsPointsPanel.SuspendLayout();
            alertsDescriptionOutlinePanel.SuspendLayout();
            alertsDescriptionPanel.SuspendLayout();
            alertsPointsOutlinePanel.SuspendLayout();
            alertsLineOutlinePanel.SuspendLayout();
            alertsCustomAchievementPanel.SuspendLayout();
            alertsCustomMasteryPanel.SuspendLayout();
            alertsPlayAchievementButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsPlayAchievementButton.FlatAppearance.BorderColor = Color.Black;
            alertsPlayAchievementButton.FlatStyle = FlatStyle.Flat;
            alertsPlayAchievementButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsPlayAchievementButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsPlayAchievementButton.Location = new Point(318, 5);
            alertsPlayAchievementButton.Margin = new Padding(4, 5, 4, 5);
            alertsPlayAchievementButton.Name = "alertsPlayAchievementButton";
            alertsPlayAchievementButton.Size = new Size(98, 38);
            alertsPlayAchievementButton.TabIndex = 2;
            alertsPlayAchievementButton.Text = "Play";
            alertsPlayAchievementButton.UseVisualStyleBackColor = false;
            alertsSelectCustomAchievementFileButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsSelectCustomAchievementFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsSelectCustomAchievementFileButton.FlatStyle = FlatStyle.Flat;
            alertsSelectCustomAchievementFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsSelectCustomAchievementFileButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsSelectCustomAchievementFileButton.Location = new Point(314, 409);
            alertsSelectCustomAchievementFileButton.Margin = new Padding(4, 5, 4, 5);
            alertsSelectCustomAchievementFileButton.Name = "alertsSelectCustomAchievementFileButton";
            alertsSelectCustomAchievementFileButton.Size = new Size(98, 38);
            alertsSelectCustomAchievementFileButton.TabIndex = 14;
            alertsSelectCustomAchievementFileButton.Text = "File";
            alertsSelectCustomAchievementFileButton.UseVisualStyleBackColor = false;
            alertsCustomAchievementScaleNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementScaleNumericUpDown.DecimalPlaces = 2;
            alertsCustomAchievementScaleNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementScaleNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementScaleNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            alertsCustomAchievementScaleNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementScaleNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsCustomAchievementScaleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            alertsCustomAchievementScaleNumericUpDown.Name = "alertsCustomAchievementScaleNumericUpDown";
            alertsCustomAchievementScaleNumericUpDown.Size = new Size(146, 24);
            alertsCustomAchievementScaleNumericUpDown.TabIndex = 20;
            alertsCustomAchievementScaleNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsCustomAchievementXNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementXNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementXNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementXNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementXNumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            alertsCustomAchievementXNumericUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, -2147483648 });
            alertsCustomAchievementXNumericUpDown.Name = "alertsCustomAchievementXNumericUpDown";
            alertsCustomAchievementXNumericUpDown.Size = new Size(146, 24);
            alertsCustomAchievementXNumericUpDown.TabIndex = 15;
            alertsCustomAchievementYNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementYNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementYNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementYNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementYNumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            alertsCustomAchievementYNumericUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, -2147483648 });
            alertsCustomAchievementYNumericUpDown.Name = "alertsCustomAchievementYNumericUpDown";
            alertsCustomAchievementYNumericUpDown.Size = new Size(146, 24);
            alertsCustomAchievementYNumericUpDown.TabIndex = 16;
            alertsAchievementEditOutlineCheckbox.AutoSize = true;
            alertsAchievementEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsAchievementEditOutlineCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsAchievementEditOutlineCheckbox.Location = new Point(12, 414);
            alertsAchievementEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsAchievementEditOutlineCheckbox.Name = "alertsAchievementEditOutlineCheckbox";
            alertsAchievementEditOutlineCheckbox.Size = new Size(137, 29);
            alertsAchievementEditOutlineCheckbox.TabIndex = 47;
            alertsAchievementEditOutlineCheckbox.Text = "Edit Mode";
            alertsAchievementEditOutlineCheckbox.UseVisualStyleBackColor = true;
            alertsCustomAchievementOutNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementOutNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementOutNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementOutNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementOutNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            alertsCustomAchievementOutNumericUpDown.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomAchievementOutNumericUpDown.Name = "alertsCustomAchievementOutNumericUpDown";
            alertsCustomAchievementOutNumericUpDown.Size = new Size(146, 24);
            alertsCustomAchievementOutNumericUpDown.TabIndex = 26;
            alertsCustomAchievementOutNumericUpDown.Value = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomAchievementAnimationOutComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsCustomAchievementAnimationOutComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementAnimationOutComboBox.ForeColor = Color.White;
            alertsCustomAchievementAnimationOutComboBox.FormattingEnabled = true;
            alertsCustomAchievementAnimationOutComboBox.Location = new Point(252, 2);
            alertsCustomAchievementAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementAnimationOutComboBox.Name = "alertsCustomAchievementAnimationOutComboBox";
            alertsCustomAchievementAnimationOutComboBox.Size = new Size(144, 28);
            alertsCustomAchievementAnimationOutComboBox.TabIndex = 39;
            alertsCustomAchievementOutSpeedUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementOutSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementOutSpeedUpDown.ForeColor = Color.White;
            alertsCustomAchievementOutSpeedUpDown.Location = new Point(252, 6);
            alertsCustomAchievementOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementOutSpeedUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            alertsCustomAchievementOutSpeedUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomAchievementOutSpeedUpDown.Name = "alertsCustomAchievementOutSpeedUpDown";
            alertsCustomAchievementOutSpeedUpDown.Size = new Size(146, 24);
            alertsCustomAchievementOutSpeedUpDown.TabIndex = 48;
            alertsCustomAchievementOutSpeedUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomAchievementInNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementInNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementInNumericUpDown.ForeColor = Color.White;
            alertsCustomAchievementInNumericUpDown.Location = new Point(252, 6);
            alertsCustomAchievementInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementInNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            alertsCustomAchievementInNumericUpDown.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomAchievementInNumericUpDown.Name = "alertsCustomAchievementInNumericUpDown";
            alertsCustomAchievementInNumericUpDown.Size = new Size(146, 24);
            alertsCustomAchievementInNumericUpDown.TabIndex = 26;
            alertsCustomAchievementInNumericUpDown.Value = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomAchievementAnimationInComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsCustomAchievementAnimationInComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementAnimationInComboBox.ForeColor = Color.White;
            alertsCustomAchievementAnimationInComboBox.FormattingEnabled = true;
            alertsCustomAchievementAnimationInComboBox.Location = new Point(252, 2);
            alertsCustomAchievementAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementAnimationInComboBox.Name = "alertsCustomAchievementAnimationInComboBox";
            alertsCustomAchievementAnimationInComboBox.Size = new Size(144, 28);
            alertsCustomAchievementAnimationInComboBox.TabIndex = 39;
            alertsCustomAchievementInSpeedUpDown.BackColor = Color.FromArgb(42, 42, 42);
            alertsCustomAchievementInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomAchievementInSpeedUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementInSpeedUpDown.ForeColor = Color.White;
            alertsCustomAchievementInSpeedUpDown.Location = new Point(252, 6);
            alertsCustomAchievementInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementInSpeedUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            alertsCustomAchievementInSpeedUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomAchievementInSpeedUpDown.Name = "alertsCustomAchievementInSpeedUpDown";
            alertsCustomAchievementInSpeedUpDown.Size = new Size(146, 24);
            alertsCustomAchievementInSpeedUpDown.TabIndex = 48;
            alertsCustomAchievementInSpeedUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomAchievementEnableCheckbox.AutoSize = true;
            alertsCustomAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomAchievementEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsCustomAchievementEnableCheckbox.Location = new Point(129, 9);
            alertsCustomAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementEnableCheckbox.Name = "alertsCustomAchievementEnableCheckbox";
            alertsCustomAchievementEnableCheckbox.Size = new Size(114, 29);
            alertsCustomAchievementEnableCheckbox.TabIndex = 13;
            alertsCustomAchievementEnableCheckbox.Text = "Custom";
            alertsCustomAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            alertsPlayMasteryButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsPlayMasteryButton.FlatAppearance.BorderColor = Color.Black;
            alertsPlayMasteryButton.FlatStyle = FlatStyle.Flat;
            alertsPlayMasteryButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsPlayMasteryButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsPlayMasteryButton.Location = new Point(318, 5);
            alertsPlayMasteryButton.Margin = new Padding(4, 5, 4, 5);
            alertsPlayMasteryButton.Name = "alertsPlayMasteryButton";
            alertsPlayMasteryButton.Size = new Size(98, 38);
            alertsPlayMasteryButton.TabIndex = 2;
            alertsPlayMasteryButton.Text = "Play";
            alertsPlayMasteryButton.UseVisualStyleBackColor = false;
            alertsSelectCustomMasteryFileButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsSelectCustomMasteryFileButton.FlatAppearance.BorderColor = Color.Black;
            alertsSelectCustomMasteryFileButton.FlatStyle = FlatStyle.Flat;
            alertsSelectCustomMasteryFileButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsSelectCustomMasteryFileButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsSelectCustomMasteryFileButton.Location = new Point(314, 409);
            alertsSelectCustomMasteryFileButton.Margin = new Padding(4, 5, 4, 5);
            alertsSelectCustomMasteryFileButton.Name = "alertsSelectCustomMasteryFileButton";
            alertsSelectCustomMasteryFileButton.Size = new Size(98, 38);
            alertsSelectCustomMasteryFileButton.TabIndex = 14;
            alertsSelectCustomMasteryFileButton.Text = "File";
            alertsSelectCustomMasteryFileButton.UseVisualStyleBackColor = false;
            alertsCustomMasteryScaleNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryScaleNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryScaleNumericUpDown.DecimalPlaces = 2;
            alertsCustomMasteryScaleNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryScaleNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryScaleNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            alertsCustomMasteryScaleNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryScaleNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryScaleNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsCustomMasteryScaleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            alertsCustomMasteryScaleNumericUpDown.Name = "alertsCustomMasteryScaleNumericUpDown";
            alertsCustomMasteryScaleNumericUpDown.Size = new Size(146, 24);
            alertsCustomMasteryScaleNumericUpDown.TabIndex = 20;
            alertsCustomMasteryScaleNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsCustomMasteryXNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryXNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryXNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryXNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryXNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryXNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryXNumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            alertsCustomMasteryXNumericUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, -2147483648 });
            alertsCustomMasteryXNumericUpDown.Name = "alertsCustomMasteryXNumericUpDown";
            alertsCustomMasteryXNumericUpDown.Size = new Size(146, 24);
            alertsCustomMasteryXNumericUpDown.TabIndex = 15;
            alertsCustomMasteryYNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryYNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryYNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryYNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryYNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryYNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryYNumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            alertsCustomMasteryYNumericUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, -2147483648 });
            alertsCustomMasteryYNumericUpDown.Name = "alertsCustomMasteryYNumericUpDown";
            alertsCustomMasteryYNumericUpDown.Size = new Size(146, 24);
            alertsCustomMasteryYNumericUpDown.TabIndex = 16;
            alertsMasteryEditOutlineCheckbox.AutoSize = true;
            alertsMasteryEditOutlineCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsMasteryEditOutlineCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsMasteryEditOutlineCheckbox.Location = new Point(12, 414);
            alertsMasteryEditOutlineCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsMasteryEditOutlineCheckbox.Name = "alertsMasteryEditOutlineCheckbox";
            alertsMasteryEditOutlineCheckbox.Size = new Size(137, 29);
            alertsMasteryEditOutlineCheckbox.TabIndex = 47;
            alertsMasteryEditOutlineCheckbox.Text = "Edit Mode";
            alertsMasteryEditOutlineCheckbox.UseVisualStyleBackColor = true;
            alertsCustomMasteryOutNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryOutNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryOutNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryOutNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryOutNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryOutNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryOutNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            alertsCustomMasteryOutNumericUpDown.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomMasteryOutNumericUpDown.Name = "alertsCustomMasteryOutNumericUpDown";
            alertsCustomMasteryOutNumericUpDown.Size = new Size(146, 24);
            alertsCustomMasteryOutNumericUpDown.TabIndex = 26;
            alertsCustomMasteryOutNumericUpDown.Value = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomMasteryAnimationOutComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsCustomMasteryAnimationOutComboBox.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryAnimationOutComboBox.ForeColor = Color.White;
            alertsCustomMasteryAnimationOutComboBox.FormattingEnabled = true;
            alertsCustomMasteryAnimationOutComboBox.Location = new Point(252, 2);
            alertsCustomMasteryAnimationOutComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryAnimationOutComboBox.Name = "alertsCustomMasteryAnimationOutComboBox";
            alertsCustomMasteryAnimationOutComboBox.Size = new Size(144, 28);
            alertsCustomMasteryAnimationOutComboBox.TabIndex = 39;
            alertsCustomMasteryOutSpeedUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryOutSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryOutSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryOutSpeedUpDown.ForeColor = Color.White;
            alertsCustomMasteryOutSpeedUpDown.Location = new Point(252, 6);
            alertsCustomMasteryOutSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryOutSpeedUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            alertsCustomMasteryOutSpeedUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomMasteryOutSpeedUpDown.Name = "alertsCustomMasteryOutSpeedUpDown";
            alertsCustomMasteryOutSpeedUpDown.Size = new Size(146, 24);
            alertsCustomMasteryOutSpeedUpDown.TabIndex = 48;
            alertsCustomMasteryOutSpeedUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomMasteryInNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryInNumericUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryInNumericUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryInNumericUpDown.ForeColor = Color.White;
            alertsCustomMasteryInNumericUpDown.Location = new Point(252, 6);
            alertsCustomMasteryInNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryInNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            alertsCustomMasteryInNumericUpDown.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomMasteryInNumericUpDown.Name = "alertsCustomMasteryInNumericUpDown";
            alertsCustomMasteryInNumericUpDown.Size = new Size(146, 24);
            alertsCustomMasteryInNumericUpDown.TabIndex = 26;
            alertsCustomMasteryInNumericUpDown.Value = new decimal(new int[] { 300, 0, 0, 0 });
            alertsCustomMasteryAnimationInComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsCustomMasteryAnimationInComboBox.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryAnimationInComboBox.ForeColor = Color.White;
            alertsCustomMasteryAnimationInComboBox.FormattingEnabled = true;
            alertsCustomMasteryAnimationInComboBox.Location = new Point(252, 2);
            alertsCustomMasteryAnimationInComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryAnimationInComboBox.Name = "alertsCustomMasteryAnimationInComboBox";
            alertsCustomMasteryAnimationInComboBox.Size = new Size(144, 28);
            alertsCustomMasteryAnimationInComboBox.TabIndex = 39;
            alertsCustomMasteryInSpeedUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsCustomMasteryInSpeedUpDown.BorderStyle = BorderStyle.None;
            alertsCustomMasteryInSpeedUpDown.Font = new Font("Verdana", 8.25F);
            alertsCustomMasteryInSpeedUpDown.ForeColor = Color.White;
            alertsCustomMasteryInSpeedUpDown.Location = new Point(252, 6);
            alertsCustomMasteryInSpeedUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryInSpeedUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            alertsCustomMasteryInSpeedUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomMasteryInSpeedUpDown.Name = "alertsCustomMasteryInSpeedUpDown";
            alertsCustomMasteryInSpeedUpDown.Size = new Size(146, 24);
            alertsCustomMasteryInSpeedUpDown.TabIndex = 48;
            alertsCustomMasteryInSpeedUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            alertsCustomMasteryEnableCheckbox.AutoSize = true;
            alertsCustomMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsCustomMasteryEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsCustomMasteryEnableCheckbox.Location = new Point(129, 9);
            alertsCustomMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryEnableCheckbox.Name = "alertsCustomMasteryEnableCheckbox";
            alertsCustomMasteryEnableCheckbox.Size = new Size(114, 29);
            alertsCustomMasteryEnableCheckbox.TabIndex = 13;
            alertsCustomMasteryEnableCheckbox.Text = "Custom";
            alertsCustomMasteryEnableCheckbox.UseVisualStyleBackColor = true;
            alertsLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsLinePanel.Location = new Point(3, 265);
            alertsLinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsLinePanel.Name = "alertsLinePanel";
            alertsLinePanel.Size = new Size(694, 35);
            alertsLinePanel.TabIndex = 10068;
            alertsLineColorPictureBox.BackColor = Color.White;
            alertsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsLineColorPictureBox.Location = new Point(230, 5);
            alertsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsLineColorPictureBox.Name = "alertsLineColorPictureBox";
            alertsLineColorPictureBox.Size = new Size(22, 22);
            alertsLineColorPictureBox.TabIndex = 45;
            alertsLineColorPictureBox.TabStop = false;
            alertsBorderCheckBox.AutoSize = true;
            alertsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsBorderCheckBox.Location = new Point(620, 8);
            alertsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsBorderCheckBox.Name = "alertsBorderCheckBox";
            alertsBorderCheckBox.Size = new Size(22, 21);
            alertsBorderCheckBox.TabIndex = 10065;
            alertsBorderCheckBox.UseVisualStyleBackColor = true;
            alertsBorderColorPictureBox.BackColor = Color.White;
            alertsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsBorderColorPictureBox.Location = new Point(230, 5);
            alertsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsBorderColorPictureBox.Name = "alertsBorderColorPictureBox";
            alertsBorderColorPictureBox.Size = new Size(22, 22);
            alertsBorderColorPictureBox.TabIndex = 42;
            alertsBorderColorPictureBox.TabStop = false;
            alertsPointsPanel.BackColor = Color.FromArgb(22, 22, 22);
            alertsPointsPanel.Location = new Point(3, 231);
            alertsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            alertsPointsPanel.Name = "alertsPointsPanel";
            alertsPointsPanel.Size = new Size(694, 35);
            alertsPointsPanel.TabIndex = 10070;
            alertsPointsFontColorPictureBox.BackColor = Color.White;
            alertsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsPointsFontColorPictureBox.Location = new Point(230, 6);
            alertsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsPointsFontColorPictureBox.Name = "alertsPointsFontColorPictureBox";
            alertsPointsFontColorPictureBox.Size = new Size(22, 22);
            alertsPointsFontColorPictureBox.TabIndex = 45;
            alertsPointsFontColorPictureBox.TabStop = false;
            alertsPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsPointsFontComboBox.FlatStyle = FlatStyle.System;
            alertsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsPointsFontComboBox.ForeColor = Color.White;
            alertsPointsFontComboBox.FormattingEnabled = true;
            alertsPointsFontComboBox.Location = new Point(290, 3);
            alertsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsPointsFontComboBox.Name = "alertsPointsFontComboBox";
            alertsPointsFontComboBox.Size = new Size(301, 28);
            alertsPointsFontComboBox.TabIndex = 45;
            alertsAdvancedCheckBox.AutoSize = true;
            alertsAdvancedCheckBox.BackColor = Color.Transparent;
            alertsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            alertsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsAdvancedCheckBox.Location = new Point(8, 3);
            alertsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsAdvancedCheckBox.Name = "alertsAdvancedCheckBox";
            alertsAdvancedCheckBox.Size = new Size(135, 29);
            alertsAdvancedCheckBox.TabIndex = 10053;
            alertsAdvancedCheckBox.Text = "Advanced";
            alertsAdvancedCheckBox.UseVisualStyleBackColor = false;
            alertsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            alertsTitleFontOutlineNumericUpDown.Name = "alertsTitleFontOutlineNumericUpDown";
            alertsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsTitleFontOutlineNumericUpDown.TabIndex = 45;
            alertsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsTitleOutlineCheckBox.AutoSize = true;
            alertsTitleOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTitleOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTitleOutlineCheckBox.Location = new Point(620, 8);
            alertsTitleOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsTitleOutlineCheckBox.Name = "alertsTitleOutlineCheckBox";
            alertsTitleOutlineCheckBox.Size = new Size(22, 21);
            alertsTitleOutlineCheckBox.TabIndex = 45;
            alertsTitleOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsTitleOutlineLabel.BackColor = Color.Transparent;
            alertsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTitleOutlineLabel.Location = new Point(4, 5);
            alertsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            alertsTitleOutlineLabel.Name = "alertsTitleOutlineLabel";
            alertsTitleOutlineLabel.Size = new Size(216, 25);
            alertsTitleOutlineLabel.TabIndex = 10066;
            alertsTitleOutlineLabel.Text = "Title OutlineColor";
            alertsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            alertsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTitleFontOutlineColorPictureBox.Name = "alertsTitleFontOutlineColorPictureBox";
            alertsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsTitleFontOutlineColorPictureBox.TabIndex = 45;
            alertsTitleFontOutlineColorPictureBox.TabStop = false;
            alertsOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            alertsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            alertsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            alertsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            alertsOpenWindowButton.Location = new Point(573, 3);
            alertsOpenWindowButton.Margin = new Padding(0);
            alertsOpenWindowButton.Name = "alertsOpenWindowButton";
            alertsOpenWindowButton.Size = new Size(112, 42);
            alertsOpenWindowButton.TabIndex = 10021;
            alertsOpenWindowButton.Text = "Open";
            alertsOpenWindowButton.UseVisualStyleBackColor = false;
            alertsDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsDescriptionOutlinePanel.Location = new Point(3, 332);
            alertsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionOutlinePanel.Name = "alertsDescriptionOutlinePanel";
            alertsDescriptionOutlinePanel.Size = new Size(694, 35);
            alertsDescriptionOutlinePanel.TabIndex = 10072;
            alertsDescriptionFontOutlineColorPictureBox.BackColor = Color.White;
            alertsDescriptionFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsDescriptionFontOutlineColorPictureBox.Location = new Point(230, 6);
            alertsDescriptionFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionFontOutlineColorPictureBox.Name = "alertsDescriptionFontOutlineColorPictureBox";
            alertsDescriptionFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsDescriptionFontOutlineColorPictureBox.TabIndex = 45;
            alertsDescriptionFontOutlineColorPictureBox.TabStop = false;
            alertsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            alertsDescriptionFontOutlineNumericUpDown.Name = "alertsDescriptionFontOutlineNumericUpDown";
            alertsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            alertsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsDescriptionOutlineCheckBox.AutoSize = true;
            alertsDescriptionOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsDescriptionOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsDescriptionOutlineCheckBox.Location = new Point(620, 9);
            alertsDescriptionOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionOutlineCheckBox.Name = "alertsDescriptionOutlineCheckBox";
            alertsDescriptionOutlineCheckBox.Size = new Size(22, 21);
            alertsDescriptionOutlineCheckBox.TabIndex = 45;
            alertsDescriptionOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsDescriptionPanel.Location = new Point(3, 197);
            alertsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionPanel.Name = "alertsDescriptionPanel";
            alertsDescriptionPanel.Size = new Size(694, 35);
            alertsDescriptionPanel.TabIndex = 10061;
            alertsDescriptionFontColorPictureBox.BackColor = Color.White;
            alertsDescriptionFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsDescriptionFontColorPictureBox.Location = new Point(230, 5);
            alertsDescriptionFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionFontColorPictureBox.Name = "alertsDescriptionFontColorPictureBox";
            alertsDescriptionFontColorPictureBox.Size = new Size(22, 22);
            alertsDescriptionFontColorPictureBox.TabIndex = 45;
            alertsDescriptionFontColorPictureBox.TabStop = false;
            alertsDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsDescriptionFontComboBox.FlatStyle = FlatStyle.System;
            alertsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsDescriptionFontComboBox.ForeColor = Color.White;
            alertsDescriptionFontComboBox.FormattingEnabled = true;
            alertsDescriptionFontComboBox.Location = new Point(290, 3);
            alertsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsDescriptionFontComboBox.Name = "alertsDescriptionFontComboBox";
            alertsDescriptionFontComboBox.Size = new Size(301, 28);
            alertsDescriptionFontComboBox.TabIndex = 45;
            alertsAutoOpenWindowCheckbox.AutoSize = true;
            alertsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            alertsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            alertsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsAutoOpenWindowCheckbox.Name = "alertsAutoOpenWindowCheckbox";
            alertsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            alertsAutoOpenWindowCheckbox.TabIndex = 10022;
            alertsAutoOpenWindowCheckbox.Text = "Auto-Open";
            alertsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            alertsBackgroundColorPictureBox.BackColor = Color.White;
            alertsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsBackgroundColorPictureBox.Location = new Point(230, 5);
            alertsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsBackgroundColorPictureBox.Name = "alertsBackgroundColorPictureBox";
            alertsBackgroundColorPictureBox.Size = new Size(22, 22);
            alertsBackgroundColorPictureBox.TabIndex = 42;
            alertsBackgroundColorPictureBox.TabStop = false;
            alertsTitleLabel.BackColor = Color.Transparent;
            alertsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            alertsTitleLabel.Location = new Point(4, 6);
            alertsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            alertsTitleLabel.Name = "alertsTitleLabel";
            alertsTitleLabel.Size = new Size(216, 25);
            alertsTitleLabel.TabIndex = 10065;
            alertsTitleLabel.Text = "Title";
            alertsTitleFontColorPictureBox.BackColor = Color.White;
            alertsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsTitleFontColorPictureBox.Location = new Point(230, 6);
            alertsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsTitleFontColorPictureBox.Name = "alertsTitleFontColorPictureBox";
            alertsTitleFontColorPictureBox.Size = new Size(22, 22);
            alertsTitleFontColorPictureBox.TabIndex = 45;
            alertsTitleFontColorPictureBox.TabStop = false;
            alertsTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            alertsTitleFontComboBox.FlatStyle = FlatStyle.System;
            alertsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsTitleFontComboBox.ForeColor = Color.White;
            alertsTitleFontComboBox.FormattingEnabled = true;
            alertsTitleFontComboBox.Location = new Point(290, 3);
            alertsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            alertsTitleFontComboBox.Name = "alertsTitleFontComboBox";
            alertsTitleFontComboBox.Size = new Size(301, 28);
            alertsTitleFontComboBox.TabIndex = 45;
            alertsPointsOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            alertsPointsOutlinePanel.Location = new Point(3, 366);
            alertsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsPointsOutlinePanel.Name = "alertsPointsOutlinePanel";
            alertsPointsOutlinePanel.Size = new Size(694, 35);
            alertsPointsOutlinePanel.TabIndex = 10061;
            alertsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            alertsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            alertsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            alertsPointsFontOutlineNumericUpDown.Name = "alertsPointsFontOutlineNumericUpDown";
            alertsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            alertsPointsFontOutlineNumericUpDown.TabIndex = 45;
            alertsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsPointsOutlineCheckBox.AutoSize = true;
            alertsPointsOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsPointsOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsPointsOutlineCheckBox.Location = new Point(620, 8);
            alertsPointsOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsPointsOutlineCheckBox.Name = "alertsPointsOutlineCheckBox";
            alertsPointsOutlineCheckBox.Size = new Size(22, 21);
            alertsPointsOutlineCheckBox.TabIndex = 45;
            alertsPointsOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            alertsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            alertsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsPointsFontOutlineColorPictureBox.Name = "alertsPointsFontOutlineColorPictureBox";
            alertsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            alertsPointsFontOutlineColorPictureBox.TabIndex = 45;
            alertsPointsFontOutlineColorPictureBox.TabStop = false;
            alertsLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            alertsLineOutlinePanel.Location = new Point(3, 400);
            alertsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            alertsLineOutlinePanel.Name = "alertsLineOutlinePanel";
            alertsLineOutlinePanel.Size = new Size(694, 35);
            alertsLineOutlinePanel.TabIndex = 10067;
            alertsLineOutlineColorPictureBox.BackColor = Color.White;
            alertsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            alertsLineOutlineColorPictureBox.Location = new Point(230, 6);
            alertsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            alertsLineOutlineColorPictureBox.Name = "alertsLineOutlineColorPictureBox";
            alertsLineOutlineColorPictureBox.Size = new Size(22, 22);
            alertsLineOutlineColorPictureBox.TabIndex = 45;
            alertsLineOutlineColorPictureBox.TabStop = false;
            alertsLineOutlineNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            alertsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            alertsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsLineOutlineNumericUpDown.ForeColor = Color.White;
            alertsLineOutlineNumericUpDown.Location = new Point(528, 6);
            alertsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            alertsLineOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            alertsLineOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            alertsLineOutlineNumericUpDown.Name = "alertsLineOutlineNumericUpDown";
            alertsLineOutlineNumericUpDown.Size = new Size(64, 24);
            alertsLineOutlineNumericUpDown.TabIndex = 45;
            alertsLineOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            alertsLineOutlineCheckBox.AutoSize = true;
            alertsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsLineOutlineCheckBox.Location = new Point(620, 9);
            alertsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            alertsLineOutlineCheckBox.Name = "alertsLineOutlineCheckBox";
            alertsLineOutlineCheckBox.Size = new Size(22, 21);
            alertsLineOutlineCheckBox.TabIndex = 45;
            alertsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            alertsCustomAchievementPanel.Location = new Point(4, 49);
            alertsCustomAchievementPanel.Margin = new Padding(4, 5, 4, 5);
            alertsCustomAchievementPanel.Name = "alertsCustomAchievementPanel";
            alertsCustomAchievementPanel.Size = new Size(417, 452);
            alertsCustomAchievementPanel.TabIndex = 10082;
            alertsAchievementEnableCheckbox.AutoSize = true;
            alertsAchievementEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsAchievementEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsAchievementEnableCheckbox.Location = new Point(16, 9);
            alertsAchievementEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsAchievementEnableCheckbox.Name = "alertsAchievementEnableCheckbox";
            alertsAchievementEnableCheckbox.Size = new Size(106, 29);
            alertsAchievementEnableCheckbox.TabIndex = 54;
            alertsAchievementEnableCheckbox.Text = "Enable";
            alertsAchievementEnableCheckbox.UseVisualStyleBackColor = true;
            alertsCustomMasteryPanel.Location = new Point(4, 49);
            alertsCustomMasteryPanel.Margin = new Padding(4, 5, 4, 5);
            alertsCustomMasteryPanel.Name = "alertsCustomMasteryPanel";
            alertsCustomMasteryPanel.Size = new Size(418, 452);
            alertsCustomMasteryPanel.TabIndex = 10083;
            alertsMasteryEnableCheckbox.AutoSize = true;
            alertsMasteryEnableCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alertsMasteryEnableCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            alertsMasteryEnableCheckbox.Location = new Point(16, 9);
            alertsMasteryEnableCheckbox.Margin = new Padding(4, 5, 4, 5);
            alertsMasteryEnableCheckbox.Name = "alertsMasteryEnableCheckbox";
            alertsMasteryEnableCheckbox.Size = new Size(106, 29);
            alertsMasteryEnableCheckbox.TabIndex = 54;
            alertsMasteryEnableCheckbox.Text = "Enable";
            alertsMasteryEnableCheckbox.UseVisualStyleBackColor = true;
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
