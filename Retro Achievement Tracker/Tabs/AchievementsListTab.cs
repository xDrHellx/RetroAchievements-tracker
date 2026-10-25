using System.Drawing;
using System.Windows.Forms;
using Retro_Achievement_Tracker.Utils;

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
            BackColor = btnBackColor;
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable) { }

        public override void InitElements()
        {
            achievementListAutoScrollCheckBox = WinFormHelpers.CreateCheckBox("achievementListAutoScrollCheckBox", "Auto-scroll", new Point(4, 60), new Size(147, 29));
            achievementListAutoScrollCheckBox.BackColor = Color.Transparent;
            achievementListAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            achievementListAutoScrollCheckBox.Font = labelFont;
            achievementListAutoScrollCheckBox.ForeColor = foreColor;
            achievementListAutoScrollCheckBox.Margin = btnPanelMargin;
            // achievementListAutoScrollCheckBox.TabIndex = 10055;
            achievementListAutoScrollCheckBox.UseVisualStyleBackColor = false;

            achievementListAutoOpenWindowCheckbox = WinFormHelpers.CreateCheckBox("achievementListAutoOpenWindowCheckbox", "Auto-Open", new Point(378, 14), new Size(147, 29));
            // achievementListAutoOpenWindowCheckbox.AutoSize = true;
            achievementListAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            achievementListAutoOpenWindowCheckbox.Font = labelFont;
            achievementListAutoOpenWindowCheckbox.ForeColor = foreColor;
            achievementListAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            // achievementListAutoOpenWindowCheckbox.TabIndex = 10022;
            achievementListAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;

            achievementListWindowSizeLabel = WinFormHelpers.CreateLabel("achievementListWindowSizeLabel", "Window Size", new Point(3, 4), new Size(141, 25));
            // achievementListWindowSizeLabel.AutoSize = true;
            achievementListWindowSizeLabel.Font = new Font("Verdana", 9.75F);
            achievementListWindowSizeLabel.ForeColor = foreColor;
            // achievementListWindowSizeLabel.TabIndex = 10088;

            achievementListWindowSizeXUpDown = WinFormHelpers.CreateNumericUpDown("achievementListWindowSizeXUpDown", 748, new Point(230, 4), new Size(120, 28), 340, 1700);
            achievementListWindowSizeXUpDown.Increment = 68;
            // achievementListWindowSizeXUpDown.TabIndex = 3;

            achievementListWindowSizeYUpDown = WinFormHelpers.CreateNumericUpDown("achievementListWindowSizeYUpDown", 612, new Point(352, 4), new Size(120, 28), 340, 1700);
            achievementListWindowSizeYUpDown.Increment = 68;
            // achievementListWindowSizeYUpDown.TabIndex = 1;

            achievementListOpenWindowButton = WinFormHelpers.CreateButton("achievementListOpenWindowButton", "Open", new Point(573, 3), new Size(112, 42));
            achievementListOpenWindowButton.BackColor = btnBackColor;
            achievementListOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            achievementListOpenWindowButton.FlatStyle = FlatStyle.Flat;
            achievementListOpenWindowButton.Font = labelFont;
            achievementListOpenWindowButton.ForeColor = btnForeColor;
            achievementListOpenWindowButton.Margin = new Padding(0);
            // achievementListOpenWindowButton.TabIndex = 10021;
            achievementListOpenWindowButton.UseVisualStyleBackColor = false;

            achievementListBackgroundColorPictureBox = WinFormHelpers.CreatePictureBox("achievementListBackgroundColorPictureBox", null, new Point(230, 5), width: 22, height: 22);
            achievementListBackgroundColorPictureBox.BackColor = Color.White;
            achievementListBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            achievementListBackgroundColorPictureBox.Margin = btnPanelMargin;
            // achievementListBackgroundColorPictureBox.TabIndex = 42;
            achievementListBackgroundColorPictureBox.TabStop = false;
        }

        #endregion
    }
}
