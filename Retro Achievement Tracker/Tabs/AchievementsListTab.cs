using System.Drawing;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker.Tabs
{
    public class AchievementsListTab : AbstractTab
    {
        #region Sub elements

        public Label achievementListWindowSizeLabel;
        public NumericUpDown achievementListWindowSizeXUpDown,
            achievementListWindowSizeYUpDown;
        public PictureBox achievementListBackgroundColorPictureBox;
        public Button achievementListOpenWindowButton;
        public CheckBox achievementListAutoOpenWindowCheckbox,
            achievementListAutoScrollCheckBox;

        #endregion

        #region Constructor

        public AchievementsListTab()
        {
            Name = "AchievementsListTabPage";
            Text = "Achievements List";
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable) { }

        #endregion
    }
}
