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
            BackColor = Color.FromArgb(22, 22, 22);
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

        #endregion
    }
}
