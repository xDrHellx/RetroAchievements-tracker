using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Controllers;

namespace Retro_Achievement_Tracker.Tabs
{
    public class RecentAchievementsTab : AbstractTab
    {
        #region Sub elements

        public Label recentAchievementsMaxListLabel,
            recentAchievementsTitleOutlineLabel,
            recentAchievementsTitleLabel;
        public NumericUpDown recentAchievementsMaxListNumericUpDown,
            recentAchievementsTitleFontOutlineNumericUpDown,
            recentAchievementsDescriptionFontOutlineNumericUpDown,
            recentAchievementsPointsFontOutlineNumericUpDown,
            recentAchievementsLineOutlineNumericUpDown;
        public PictureBox recentAchievementsLineColorPictureBox,
            recentAchievementsBorderColorPictureBox,
            recentAchievementsPointsFontColorPictureBox,
            recentAchievementsTitleFontOutlineColorPictureBox,
            recentAchievementsDateFontOutlineColorPictureBox,
            recentAchievementsDateFontColorPictureBox,
            recentAchievementsBackgroundColorPictureBox,
            recentAchievementsTitleFontColorPictureBox,
            recentAchievementsPointsFontOutlineColorPictureBox,
            recentAchievementsLineOutlineColorPictureBox;
        public Button recentAchievementsOpenWindowButton;
        public CheckBox recentAchievementsAutoScrollCheckBox,
            recentAchievementsBorderCheckBox,
            recentAchievementsAdvancedCheckBox,
            recentAchievementsTitleFontOutlineCheckBox,
            recentAchievementsDateFontOutlineCheckBox,
            recentAchievementsAutoOpenWindowCheckbox,
            recentAchievementsPointsFontOutlineCheckBox,
            recentAchievementsLineOutlineCheckBox;
        public ComboBox recentAchievementsPointsFontComboBox,
            recentAchievementsDescriptionFontComboBox,
            recentAchievementsTitleFontComboBox;
        public Panel recentAchievementsLinePanel,
            recentAchievementsPointsPanel,
            recentAchievementsDescriptionOutlinePanel,
            recentAchievementsDescriptionPanel,
            recentAchievementsPointsOutlinePanel,
            recentAchievementsLineOutlinePanel;

        #endregion

        #region Constructor

        public RecentAchievementsTab()
        {
            Name = "RecentAchievementsTabPage";
            Text = "Recent Unlocks";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable)
        {
            if (enable)
            {
                recentAchievementsTitleLabel.Text = "Title";
                recentAchievementsTitleOutlineLabel.Text = "Title OutlineColor";

                SetFontFamilyBox(recentAchievementsTitleFontComboBox, RecentUnlocksController.Instance.TitleFontFamily);
                recentAchievementsTitleFontOutlineCheckBox.Checked = RecentUnlocksController.Instance.TitleOutlineEnabled;
                recentAchievementsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.TitleColor);
                recentAchievementsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(FocusController.Instance.TitleOutlineColor);
            }
            else
            {
                recentAchievementsTitleLabel.Text = "Font";
                recentAchievementsTitleOutlineLabel.Text = "Font OutlineColor";

                SetFontFamilyBox(recentAchievementsTitleFontComboBox, RecentUnlocksController.Instance.SimpleFontFamily);
                recentAchievementsTitleFontOutlineCheckBox.Checked = RecentUnlocksController.Instance.SimpleFontOutlineEnabled;
                recentAchievementsTitleFontColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.SimpleFontColor);
                recentAchievementsTitleFontOutlineColorPictureBox.BackColor = ColorTranslator.FromHtml(RecentUnlocksController.Instance.SimpleFontOutlineColor);
            }

            recentAchievementsDescriptionPanel.Enabled = enable;
            recentAchievementsPointsPanel.Enabled = enable;
            recentAchievementsLinePanel.Enabled = enable;
            recentAchievementsDescriptionOutlinePanel.Enabled = enable;
            recentAchievementsPointsOutlinePanel.Enabled = enable;
            recentAchievementsLineOutlinePanel.Enabled = enable;
        }

        #endregion
    }
}
