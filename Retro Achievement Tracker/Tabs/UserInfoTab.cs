using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class UserInfoTab : AbstractTab
    {
        #region Sub elements

        public Label userInfoRatioLabel,
            userInfoTruePointsLabel,
            userInfoPointsLabel,
            userInfoRankLabel,
            userInfoUsernameLabel,
            userInfoNamesLabel,
            userInfoNamesOutlineLabel,
            userInfoMottoLabel;
        public NumericUpDown userInfoNamesFontOutlineNumericUpDown,
            userInfoValuesFontOutlineNumericUpDown;
        public TextBox userInfoTruePointsTextBox,
            userInfoPointsTextBox,
            userInfoRatioTextBox,
            userInfoRankTextBox;
        public PictureBox userInfoBackgroundColorPictureBox,
            userInfoNamesFontOutlineColorPictureBox,
            userInfoNamesFontColorPictureBox,
            userInfoValuesFontOutlineColorPictureBox,
            userInfoValuesFontColorPictureBox;
        public Button userInfoOpenWindowButton,
            userInfoDefaultButton;
        public CheckBox userInfoAutoOpenWindowCheckbox,
            userInfoTruePointsCheckBox,
            userInfoRatioCheckBox,
            userInfoPointsCheckBox,
            userInfoRankCheckBox,
            userInfoNamesOutlineCheckBox,
            userInfoValuesOutlineCheckBox,
            userInfoAdvancedCheckBox;
        public ComboBox userInfoNamesFontComboBox,
            userInfoValuesFontComboBox;
        public Panel userInfoValuesOutlinePanel,
            userInfoValuesPanel;

        #endregion

        #region Constructor

        public UserInfoTab()
        {
            Name = "UserInfoTabPage";
            Text = "User Info";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                userInfoNamesLabel.Text = "Names";
                userInfoNamesOutlineLabel.Text = "Names OutlineColor";

                SetFontFamilyBox(userInfoNamesFontComboBox, UserInfoController.Instance.NameFontFamily);
                userInfoNamesOutlineCheckBox.Checked = UserInfoController.Instance.NameOutlineEnabled;
                userInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.NameColor);
                userInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.NameOutlineColor);
            }
            else
            {
                userInfoNamesLabel.Text = "Font";
                userInfoNamesOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(userInfoNamesFontComboBox, UserInfoController.Instance.SimpleFontFamily);
                userInfoNamesOutlineCheckBox.Checked = UserInfoController.Instance.SimpleFontOutlineEnabled;
                userInfoNamesFontColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.SimpleFontColor);
                userInfoNamesFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(UserInfoController.Instance.SimpleFontOutlineColor);
            }

            userInfoValuesPanel.Enabled = enable;
            userInfoValuesOutlinePanel.Enabled = enable;
        }

        #endregion
    }
}
