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

        #endregion
    }
}
