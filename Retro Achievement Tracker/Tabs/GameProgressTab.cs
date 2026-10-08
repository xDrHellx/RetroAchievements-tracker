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

        #endregion
    }
}
