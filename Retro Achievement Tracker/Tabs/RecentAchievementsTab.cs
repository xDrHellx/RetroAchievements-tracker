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

        public override void InitElements()
        {
            recentAchievementsMaxListLabel = new Label();
            recentAchievementsMaxListNumericUpDown = new NumericUpDown();
            recentAchievementsAutoScrollCheckBox = new CheckBox();
            recentAchievementsLinePanel = new Panel();
            recentAchievementsLineColorPictureBox = new PictureBox();
            recentAchievementsBorderCheckBox = new CheckBox();
            recentAchievementsBorderColorPictureBox = new PictureBox();
            recentAchievementsPointsPanel = new Panel();
            recentAchievementsPointsFontColorPictureBox = new PictureBox();
            recentAchievementsPointsFontComboBox = new ComboBox();
            recentAchievementsAdvancedCheckBox = new CheckBox();
            recentAchievementsTitleFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsTitleFontOutlineCheckBox = new CheckBox();
            recentAchievementsTitleOutlineLabel = new Label();
            recentAchievementsTitleFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsOpenWindowButton = new Button();
            recentAchievementsDescriptionOutlinePanel = new Panel();
            recentAchievementsDateFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsDescriptionFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsDateFontOutlineCheckBox = new CheckBox();
            recentAchievementsDescriptionPanel = new Panel();
            recentAchievementsDateFontColorPictureBox = new PictureBox();
            recentAchievementsDescriptionFontComboBox = new ComboBox();
            recentAchievementsAutoOpenWindowCheckbox = new CheckBox();
            recentAchievementsBackgroundColorPictureBox = new PictureBox();
            recentAchievementsTitleLabel = new Label();
            recentAchievementsTitleFontColorPictureBox = new PictureBox();
            recentAchievementsTitleFontComboBox = new ComboBox();
            recentAchievementsPointsOutlinePanel = new Panel();
            recentAchievementsPointsFontOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsPointsFontOutlineCheckBox = new CheckBox();
            recentAchievementsPointsFontOutlineColorPictureBox = new PictureBox();
            recentAchievementsLineOutlinePanel = new Panel();
            recentAchievementsLineOutlineColorPictureBox = new PictureBox();
            recentAchievementsLineOutlineNumericUpDown = new NumericUpDown();
            recentAchievementsLineOutlineCheckBox = new CheckBox();
            recentAchievementsLinePanel.SuspendLayout();
            recentAchievementsPointsPanel.SuspendLayout();
            recentAchievementsDescriptionOutlinePanel.SuspendLayout();
            recentAchievementsDescriptionPanel.SuspendLayout();
            recentAchievementsPointsOutlinePanel.SuspendLayout();
            recentAchievementsLineOutlinePanel.SuspendLayout();
            recentAchievementsMaxListLabel.AutoSize = true;
            recentAchievementsMaxListLabel.BackColor = Color.Transparent;
            recentAchievementsMaxListLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsMaxListLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsMaxListLabel.Location = new Point(190, 63);
            recentAchievementsMaxListLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsMaxListLabel.Name = "recentAchievementsMaxListLabel";
            recentAchievementsMaxListLabel.Size = new Size(145, 25);
            recentAchievementsMaxListLabel.TabIndex = 10015;
            recentAchievementsMaxListLabel.Text = "Max List Size";
            recentAchievementsMaxListNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsMaxListNumericUpDown.Font = new Font("Verdana", 8.25F);
            recentAchievementsMaxListNumericUpDown.ForeColor = Color.White;
            recentAchievementsMaxListNumericUpDown.Location = new Point(339, 62);
            recentAchievementsMaxListNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsMaxListNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            recentAchievementsMaxListNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsMaxListNumericUpDown.Name = "recentAchievementsMaxListNumericUpDown";
            recentAchievementsMaxListNumericUpDown.Size = new Size(76, 28);
            recentAchievementsMaxListNumericUpDown.TabIndex = 22;
            recentAchievementsMaxListNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsAutoScrollCheckBox.AutoSize = true;
            recentAchievementsAutoScrollCheckBox.BackColor = Color.Transparent;
            recentAchievementsAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAutoScrollCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsAutoScrollCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsAutoScrollCheckBox.Location = new Point(4, 60);
            recentAchievementsAutoScrollCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsAutoScrollCheckBox.Name = "recentAchievementsAutoScrollCheckBox";
            recentAchievementsAutoScrollCheckBox.Size = new Size(147, 29);
            recentAchievementsAutoScrollCheckBox.TabIndex = 10055;
            recentAchievementsAutoScrollCheckBox.Text = "Auto-scroll";
            recentAchievementsAutoScrollCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsLinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsLinePanel.Location = new Point(3, 265);
            recentAchievementsLinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLinePanel.Name = "recentAchievementsLinePanel";
            recentAchievementsLinePanel.Size = new Size(694, 35);
            recentAchievementsLinePanel.TabIndex = 10068;
            recentAchievementsLineColorPictureBox.BackColor = Color.White;
            recentAchievementsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsLineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsLineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLineColorPictureBox.Name = "recentAchievementsLineColorPictureBox";
            recentAchievementsLineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsLineColorPictureBox.TabIndex = 45;
            recentAchievementsLineColorPictureBox.TabStop = false;
            recentAchievementsBorderCheckBox.AutoSize = true;
            recentAchievementsBorderCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsBorderCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsBorderCheckBox.Location = new Point(620, 8);
            recentAchievementsBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsBorderCheckBox.Name = "recentAchievementsBorderCheckBox";
            recentAchievementsBorderCheckBox.Size = new Size(22, 21);
            recentAchievementsBorderCheckBox.TabIndex = 10065;
            recentAchievementsBorderCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsBorderColorPictureBox.BackColor = Color.White;
            recentAchievementsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsBorderColorPictureBox.Location = new Point(230, 5);
            recentAchievementsBorderColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsBorderColorPictureBox.Name = "recentAchievementsBorderColorPictureBox";
            recentAchievementsBorderColorPictureBox.Size = new Size(22, 22);
            recentAchievementsBorderColorPictureBox.TabIndex = 42;
            recentAchievementsBorderColorPictureBox.TabStop = false;
            recentAchievementsPointsPanel.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsPointsPanel.Location = new Point(3, 231);
            recentAchievementsPointsPanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsPanel.Name = "recentAchievementsPointsPanel";
            recentAchievementsPointsPanel.Size = new Size(694, 35);
            recentAchievementsPointsPanel.TabIndex = 10070;
            recentAchievementsPointsFontColorPictureBox.BackColor = Color.White;
            recentAchievementsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsPointsFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsPointsFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsFontColorPictureBox.Name = "recentAchievementsPointsFontColorPictureBox";
            recentAchievementsPointsFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsPointsFontColorPictureBox.TabIndex = 45;
            recentAchievementsPointsFontColorPictureBox.TabStop = false;
            recentAchievementsPointsFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsPointsFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsPointsFontComboBox.ForeColor = Color.White;
            recentAchievementsPointsFontComboBox.FormattingEnabled = true;
            recentAchievementsPointsFontComboBox.Location = new Point(290, 3);
            recentAchievementsPointsFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsFontComboBox.Name = "recentAchievementsPointsFontComboBox";
            recentAchievementsPointsFontComboBox.Size = new Size(301, 28);
            recentAchievementsPointsFontComboBox.TabIndex = 45;
            recentAchievementsAdvancedCheckBox.AutoSize = true;
            recentAchievementsAdvancedCheckBox.BackColor = Color.Transparent;
            recentAchievementsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsAdvancedCheckBox.Location = new Point(8, 3);
            recentAchievementsAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsAdvancedCheckBox.Name = "recentAchievementsAdvancedCheckBox";
            recentAchievementsAdvancedCheckBox.Size = new Size(135, 29);
            recentAchievementsAdvancedCheckBox.TabIndex = 10053;
            recentAchievementsAdvancedCheckBox.Text = "Advanced";
            recentAchievementsAdvancedCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsTitleFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTitleFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTitleFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTitleFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            recentAchievementsTitleFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsTitleFontOutlineNumericUpDown.Name = "recentAchievementsTitleFontOutlineNumericUpDown";
            recentAchievementsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsTitleFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsTitleFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsTitleFontOutlineCheckBox.AutoSize = true;
            recentAchievementsTitleFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTitleFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTitleFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsTitleFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTitleFontOutlineCheckBox.Name = "recentAchievementsTitleFontOutlineCheckBox";
            recentAchievementsTitleFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsTitleFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsTitleFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTitleOutlineLabel.BackColor = Color.Transparent;
            recentAchievementsTitleOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTitleOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTitleOutlineLabel.Location = new Point(4, 5);
            recentAchievementsTitleOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsTitleOutlineLabel.Name = "recentAchievementsTitleOutlineLabel";
            recentAchievementsTitleOutlineLabel.Size = new Size(216, 25);
            recentAchievementsTitleOutlineLabel.TabIndex = 10066;
            recentAchievementsTitleOutlineLabel.Text = "Title OutlineColor";
            recentAchievementsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTitleFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTitleFontOutlineColorPictureBox.Name = "recentAchievementsTitleFontOutlineColorPictureBox";
            recentAchievementsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTitleFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsTitleFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            recentAchievementsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            recentAchievementsOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            recentAchievementsOpenWindowButton.Location = new Point(573, 3);
            recentAchievementsOpenWindowButton.Margin = new Padding(0);
            recentAchievementsOpenWindowButton.Name = "recentAchievementsOpenWindowButton";
            recentAchievementsOpenWindowButton.Size = new Size(112, 42);
            recentAchievementsOpenWindowButton.TabIndex = 10021;
            recentAchievementsOpenWindowButton.Text = "Open";
            recentAchievementsOpenWindowButton.UseVisualStyleBackColor = false;
            recentAchievementsDescriptionOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsDescriptionOutlinePanel.Location = new Point(3, 332);
            recentAchievementsDescriptionOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDescriptionOutlinePanel.Name = "recentAchievementsDescriptionOutlinePanel";
            recentAchievementsDescriptionOutlinePanel.Size = new Size(694, 35);
            recentAchievementsDescriptionOutlinePanel.TabIndex = 10072;
            recentAchievementsDateFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsDateFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsDateFontOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsDateFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDateFontOutlineColorPictureBox.Name = "recentAchievementsDateFontOutlineColorPictureBox";
            recentAchievementsDateFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsDateFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsDateFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsDescriptionFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsDescriptionFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDescriptionFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            recentAchievementsDescriptionFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsDescriptionFontOutlineNumericUpDown.Name = "recentAchievementsDescriptionFontOutlineNumericUpDown";
            recentAchievementsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsDescriptionFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsDateFontOutlineCheckBox.AutoSize = true;
            recentAchievementsDateFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsDateFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsDateFontOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsDateFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDateFontOutlineCheckBox.Name = "recentAchievementsDateFontOutlineCheckBox";
            recentAchievementsDateFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsDateFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsDateFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsDescriptionPanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsDescriptionPanel.Location = new Point(3, 197);
            recentAchievementsDescriptionPanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDescriptionPanel.Name = "recentAchievementsDescriptionPanel";
            recentAchievementsDescriptionPanel.Size = new Size(694, 35);
            recentAchievementsDescriptionPanel.TabIndex = 10061;
            recentAchievementsDateFontColorPictureBox.BackColor = Color.White;
            recentAchievementsDateFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsDateFontColorPictureBox.Location = new Point(230, 5);
            recentAchievementsDateFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDateFontColorPictureBox.Name = "recentAchievementsDateFontColorPictureBox";
            recentAchievementsDateFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsDateFontColorPictureBox.TabIndex = 45;
            recentAchievementsDateFontColorPictureBox.TabStop = false;
            recentAchievementsDescriptionFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsDescriptionFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsDescriptionFontComboBox.ForeColor = Color.White;
            recentAchievementsDescriptionFontComboBox.FormattingEnabled = true;
            recentAchievementsDescriptionFontComboBox.Location = new Point(290, 3);
            recentAchievementsDescriptionFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsDescriptionFontComboBox.Name = "recentAchievementsDescriptionFontComboBox";
            recentAchievementsDescriptionFontComboBox.Size = new Size(301, 28);
            recentAchievementsDescriptionFontComboBox.TabIndex = 45;
            recentAchievementsAutoOpenWindowCheckbox.AutoSize = true;
            recentAchievementsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            recentAchievementsAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsAutoOpenWindowCheckbox.Name = "recentAchievementsAutoOpenWindowCheckbox";
            recentAchievementsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            recentAchievementsAutoOpenWindowCheckbox.TabIndex = 10022;
            recentAchievementsAutoOpenWindowCheckbox.Text = "Auto-Open";
            recentAchievementsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            recentAchievementsBackgroundColorPictureBox.BackColor = Color.White;
            recentAchievementsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsBackgroundColorPictureBox.Location = new Point(230, 5);
            recentAchievementsBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsBackgroundColorPictureBox.Name = "recentAchievementsBackgroundColorPictureBox";
            recentAchievementsBackgroundColorPictureBox.Size = new Size(22, 22);
            recentAchievementsBackgroundColorPictureBox.TabIndex = 42;
            recentAchievementsBackgroundColorPictureBox.TabStop = false;
            recentAchievementsTitleLabel.BackColor = Color.Transparent;
            recentAchievementsTitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsTitleLabel.Location = new Point(4, 6);
            recentAchievementsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            recentAchievementsTitleLabel.Name = "recentAchievementsTitleLabel";
            recentAchievementsTitleLabel.Size = new Size(216, 25);
            recentAchievementsTitleLabel.TabIndex = 10065;
            recentAchievementsTitleLabel.Text = "Title";
            recentAchievementsTitleFontColorPictureBox.BackColor = Color.White;
            recentAchievementsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTitleFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTitleFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTitleFontColorPictureBox.Name = "recentAchievementsTitleFontColorPictureBox";
            recentAchievementsTitleFontColorPictureBox.Size = new Size(22, 22);
            recentAchievementsTitleFontColorPictureBox.TabIndex = 45;
            recentAchievementsTitleFontColorPictureBox.TabStop = false;
            recentAchievementsTitleFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsTitleFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsTitleFontComboBox.ForeColor = Color.White;
            recentAchievementsTitleFontComboBox.FormattingEnabled = true;
            recentAchievementsTitleFontComboBox.Location = new Point(290, 3);
            recentAchievementsTitleFontComboBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsTitleFontComboBox.Name = "recentAchievementsTitleFontComboBox";
            recentAchievementsTitleFontComboBox.Size = new Size(301, 28);
            recentAchievementsTitleFontComboBox.TabIndex = 45;
            recentAchievementsPointsOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            recentAchievementsPointsOutlinePanel.Location = new Point(3, 366);
            recentAchievementsPointsOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsOutlinePanel.Name = "recentAchievementsPointsOutlinePanel";
            recentAchievementsPointsOutlinePanel.Size = new Size(694, 35);
            recentAchievementsPointsOutlinePanel.TabIndex = 10061;
            recentAchievementsPointsFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsPointsFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsPointsFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            recentAchievementsPointsFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsPointsFontOutlineNumericUpDown.Name = "recentAchievementsPointsFontOutlineNumericUpDown";
            recentAchievementsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsPointsFontOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsPointsFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsPointsFontOutlineCheckBox.AutoSize = true;
            recentAchievementsPointsFontOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsPointsFontOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsPointsFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsPointsFontOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsFontOutlineCheckBox.Name = "recentAchievementsPointsFontOutlineCheckBox";
            recentAchievementsPointsFontOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsPointsFontOutlineCheckBox.TabIndex = 45;
            recentAchievementsPointsFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsPointsFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsPointsFontOutlineColorPictureBox.Name = "recentAchievementsPointsFontOutlineColorPictureBox";
            recentAchievementsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsPointsFontOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsPointsFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsLineOutlinePanel.BackColor = Color.FromArgb(32, 32, 32);
            recentAchievementsLineOutlinePanel.Location = new Point(3, 400);
            recentAchievementsLineOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLineOutlinePanel.Name = "recentAchievementsLineOutlinePanel";
            recentAchievementsLineOutlinePanel.Size = new Size(694, 35);
            recentAchievementsLineOutlinePanel.TabIndex = 10067;
            recentAchievementsLineOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsLineOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsLineOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLineOutlineColorPictureBox.Name = "recentAchievementsLineOutlineColorPictureBox";
            recentAchievementsLineOutlineColorPictureBox.Size = new Size(22, 22);
            recentAchievementsLineOutlineColorPictureBox.TabIndex = 45;
            recentAchievementsLineOutlineColorPictureBox.TabStop = false;
            recentAchievementsLineOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            recentAchievementsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsLineOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsLineOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsLineOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsLineOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLineOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            recentAchievementsLineOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsLineOutlineNumericUpDown.Name = "recentAchievementsLineOutlineNumericUpDown";
            recentAchievementsLineOutlineNumericUpDown.Size = new Size(64, 24);
            recentAchievementsLineOutlineNumericUpDown.TabIndex = 45;
            recentAchievementsLineOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            recentAchievementsLineOutlineCheckBox.AutoSize = true;
            recentAchievementsLineOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            recentAchievementsLineOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            recentAchievementsLineOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsLineOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            recentAchievementsLineOutlineCheckBox.Name = "recentAchievementsLineOutlineCheckBox";
            recentAchievementsLineOutlineCheckBox.Size = new Size(22, 21);
            recentAchievementsLineOutlineCheckBox.TabIndex = 45;
            recentAchievementsLineOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsLinePanel.ResumeLayout(false);
            recentAchievementsPointsPanel.ResumeLayout(false);
            recentAchievementsDescriptionOutlinePanel.ResumeLayout(false);
            recentAchievementsDescriptionOutlinePanel.PerformLayout();
            recentAchievementsDescriptionPanel.ResumeLayout(false);
            recentAchievementsPointsOutlinePanel.ResumeLayout(false);
            recentAchievementsPointsOutlinePanel.PerformLayout();
            recentAchievementsLineOutlinePanel.ResumeLayout(false);
            recentAchievementsLineOutlinePanel.PerformLayout();
        }

        #endregion
    }
}
