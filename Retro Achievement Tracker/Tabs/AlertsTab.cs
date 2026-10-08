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

        #endregion
    }
}
