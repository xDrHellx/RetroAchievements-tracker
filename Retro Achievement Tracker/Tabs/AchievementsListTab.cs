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

        public override void InitElements()
        {
            achievementListAutoScrollCheckBox = new CheckBox();
            achievementListWindowSizeLabel = new Label();
            achievementListWindowSizeXUpDown = new NumericUpDown();
            achievementListWindowSizeYUpDown = new NumericUpDown();
            achievementListOpenWindowButton = new Button();
            achievementListAutoOpenWindowCheckbox = new CheckBox();
            achievementListBackgroundColorPictureBox = new PictureBox();
            achievementListAutoScrollCheckBox.AutoSize = true;
            achievementListAutoScrollCheckBox.BackColor = Color.Transparent;
            achievementListAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            achievementListAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementListAutoScrollCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            achievementListAutoScrollCheckBox.Location = new Point(4, 60);
            achievementListAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            achievementListAutoScrollCheckBox.Name = "achievementListAutoScrollCheckBox";
            achievementListAutoScrollCheckBox.Size = new Size(147, 29);
            achievementListAutoScrollCheckBox.TabIndex = 10055;
            achievementListAutoScrollCheckBox.Text = "Auto-scroll";
            achievementListAutoScrollCheckBox.UseVisualStyleBackColor = false;
            achievementListWindowSizeLabel.AutoSize = true;
            achievementListWindowSizeLabel.Font = new Font("Verdana", 9.75F);
            achievementListWindowSizeLabel.ForeColor = Color.FromArgb(44, 151, 250);
            achievementListWindowSizeLabel.Location = new Point(3, 4);
            achievementListWindowSizeLabel.Name = "achievementListWindowSizeLabel";
            achievementListWindowSizeLabel.Size = new Size(141, 25);
            achievementListWindowSizeLabel.TabIndex = 10088;
            achievementListWindowSizeLabel.Text = "Window Size";
            achievementListWindowSizeXUpDown.Increment = new decimal(new int[] { 68, 0, 0, 0 });
            achievementListWindowSizeXUpDown.Location = new Point(230, 4);
            achievementListWindowSizeXUpDown.Maximum = new decimal(new int[] { 1700, 0, 0, 0 });
            achievementListWindowSizeXUpDown.Minimum = new decimal(new int[] { 340, 0, 0, 0 });
            achievementListWindowSizeXUpDown.Name = "achievementListWindowSizeXUpDown";
            achievementListWindowSizeXUpDown.Size = new Size(120, 28);
            achievementListWindowSizeXUpDown.TabIndex = 3;
            achievementListWindowSizeXUpDown.Value = new decimal(new int[] { 748, 0, 0, 0 });
            achievementListWindowSizeYUpDown.Increment = new decimal(new int[] { 68, 0, 0, 0 });
            achievementListWindowSizeYUpDown.Location = new Point(352, 4);
            achievementListWindowSizeYUpDown.Maximum = new decimal(new int[] { 1700, 0, 0, 0 });
            achievementListWindowSizeYUpDown.Minimum = new decimal(new int[] { 340, 0, 0, 0 });
            achievementListWindowSizeYUpDown.Name = "achievementListWindowSizeYUpDown";
            achievementListWindowSizeYUpDown.Size = new Size(120, 28);
            achievementListWindowSizeYUpDown.TabIndex = 1;
            achievementListWindowSizeYUpDown.Value = new decimal(new int[] { 612, 0, 0, 0 });
            achievementListOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            achievementListOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            achievementListOpenWindowButton.FlatStyle = FlatStyle.Flat;
            achievementListOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementListOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            achievementListOpenWindowButton.Location = new Point(573, 3);
            achievementListOpenWindowButton.Margin = new Padding(0);
            achievementListOpenWindowButton.Name = "achievementListOpenWindowButton";
            achievementListOpenWindowButton.Size = new Size(112, 42);
            achievementListOpenWindowButton.TabIndex = 10021;
            achievementListOpenWindowButton.Text = "Open";
            achievementListOpenWindowButton.UseVisualStyleBackColor = false;
            achievementListAutoOpenWindowCheckbox.AutoSize = true;
            achievementListAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            achievementListAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            achievementListAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            achievementListAutoOpenWindowCheckbox.Location = new Point(378, 14);
            achievementListAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            achievementListAutoOpenWindowCheckbox.Name = "achievementListAutoOpenWindowCheckbox";
            achievementListAutoOpenWindowCheckbox.Size = new Size(147, 29);
            achievementListAutoOpenWindowCheckbox.TabIndex = 10022;
            achievementListAutoOpenWindowCheckbox.Text = "Auto-Open";
            achievementListAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            achievementListBackgroundColorPictureBox.BackColor = Color.White;
            achievementListBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            achievementListBackgroundColorPictureBox.Location = new Point(230, 5);
            achievementListBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            achievementListBackgroundColorPictureBox.Name = "achievementListBackgroundColorPictureBox";
            achievementListBackgroundColorPictureBox.Size = new Size(22, 22);
            achievementListBackgroundColorPictureBox.TabIndex = 42;
            achievementListBackgroundColorPictureBox.TabStop = false;
        }

        #endregion
    }
}
