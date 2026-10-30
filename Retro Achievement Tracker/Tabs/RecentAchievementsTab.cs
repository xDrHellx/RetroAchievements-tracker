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
            BackColor = btnBackColor;
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
            recentAchievementsMaxListLabel.Font = labelFont;
            recentAchievementsMaxListLabel.ForeColor = foreColor;
            recentAchievementsMaxListLabel.Location = new Point(190, 63);
            recentAchievementsMaxListLabel.Margin = labelMargin;
            recentAchievementsMaxListLabel.Name = "recentAchievementsMaxListLabel";
            recentAchievementsMaxListLabel.Size = new Size(145, 25);
            // recentAchievementsMaxListLabel.TabIndex = 10015;

            recentAchievementsMaxListLabel.Text = "Max List Size";
            recentAchievementsMaxListNumericUpDown.BackColor = numUpDownBackColor;
            recentAchievementsMaxListNumericUpDown.Font = new Font("Verdana", 8.25F);
            recentAchievementsMaxListNumericUpDown.ForeColor = Color.White;
            recentAchievementsMaxListNumericUpDown.Location = new Point(339, 62);
            recentAchievementsMaxListNumericUpDown.Margin = btnPanelMargin;
            recentAchievementsMaxListNumericUpDown.Maximum = 20;
            recentAchievementsMaxListNumericUpDown.Minimum = 1;
            recentAchievementsMaxListNumericUpDown.Name = "recentAchievementsMaxListNumericUpDown";
            recentAchievementsMaxListNumericUpDown.Size = new Size(76, 28);
            // recentAchievementsMaxListNumericUpDown.TabIndex = 22;

            recentAchievementsMaxListNumericUpDown.Value = 1;
            recentAchievementsAutoScrollCheckBox.AutoSize = true;
            recentAchievementsAutoScrollCheckBox.BackColor = Color.Transparent;
            recentAchievementsAutoScrollCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAutoScrollCheckBox.Font = labelFont;
            recentAchievementsAutoScrollCheckBox.ForeColor = foreColor;
            recentAchievementsAutoScrollCheckBox.Location = new Point(4, 60);
            recentAchievementsAutoScrollCheckBox.Margin = btnPanelMargin;
            recentAchievementsAutoScrollCheckBox.Name = "recentAchievementsAutoScrollCheckBox";
            recentAchievementsAutoScrollCheckBox.Size = new Size(147, 29);
            // recentAchievementsAutoScrollCheckBox.TabIndex = 10055;

            recentAchievementsAutoScrollCheckBox.Text = "Auto-scroll";
            recentAchievementsAutoScrollCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsLinePanel.BackColor = panelBackColor;
            recentAchievementsLinePanel.Location = new Point(3, 265);
            recentAchievementsLinePanel.Margin = btnPanelMargin;
            recentAchievementsLinePanel.Name = "recentAchievementsLinePanel";
            recentAchievementsLinePanel.Size = new Size(694, 35);
            // recentAchievementsLinePanel.TabIndex = 10068;

            recentAchievementsLineColorPictureBox.BackColor = Color.White;
            recentAchievementsLineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsLineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsLineColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsLineColorPictureBox.Name = "recentAchievementsLineColorPictureBox";
            recentAchievementsLineColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsLineColorPictureBox.TabIndex = 45;

            recentAchievementsLineColorPictureBox.TabStop = false;
            recentAchievementsBorderCheckBox.AutoSize = true;
            recentAchievementsBorderCheckBox.Font = labelFont;
            recentAchievementsBorderCheckBox.ForeColor = foreColor;
            recentAchievementsBorderCheckBox.Location = new Point(620, 8);
            recentAchievementsBorderCheckBox.Margin = btnPanelMargin;
            recentAchievementsBorderCheckBox.Name = "recentAchievementsBorderCheckBox";
            recentAchievementsBorderCheckBox.Size = new Size(22, 21);
            // recentAchievementsBorderCheckBox.TabIndex = 10065;

            recentAchievementsBorderCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsBorderColorPictureBox.BackColor = Color.White;
            recentAchievementsBorderColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsBorderColorPictureBox.Location = new Point(230, 5);
            recentAchievementsBorderColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsBorderColorPictureBox.Name = "recentAchievementsBorderColorPictureBox";
            recentAchievementsBorderColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsBorderColorPictureBox.TabIndex = 42;

            recentAchievementsBorderColorPictureBox.TabStop = false;
            recentAchievementsPointsPanel.BackColor = btnBackColor;
            recentAchievementsPointsPanel.Location = new Point(3, 231);
            recentAchievementsPointsPanel.Margin = btnPanelMargin;
            recentAchievementsPointsPanel.Name = "recentAchievementsPointsPanel";
            recentAchievementsPointsPanel.Size = new Size(694, 35);
            // recentAchievementsPointsPanel.TabIndex = 10070;

            recentAchievementsPointsFontColorPictureBox.BackColor = Color.White;
            recentAchievementsPointsFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsPointsFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsPointsFontColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsPointsFontColorPictureBox.Name = "recentAchievementsPointsFontColorPictureBox";
            recentAchievementsPointsFontColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsPointsFontColorPictureBox.TabIndex = 45;

            recentAchievementsPointsFontColorPictureBox.TabStop = false;
            recentAchievementsPointsFontComboBox.BackColor = btnBackColor;
            recentAchievementsPointsFontComboBox.Font = numUpDownFont;
            recentAchievementsPointsFontComboBox.ForeColor = Color.White;
            recentAchievementsPointsFontComboBox.FormattingEnabled = true;
            recentAchievementsPointsFontComboBox.Location = new Point(290, 3);
            recentAchievementsPointsFontComboBox.Margin = btnPanelMargin;
            recentAchievementsPointsFontComboBox.Name = "recentAchievementsPointsFontComboBox";
            recentAchievementsPointsFontComboBox.Size = new Size(301, 28);
            // recentAchievementsPointsFontComboBox.TabIndex = 45;

            recentAchievementsAdvancedCheckBox.AutoSize = true;
            recentAchievementsAdvancedCheckBox.BackColor = Color.Transparent;
            recentAchievementsAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAdvancedCheckBox.Font = labelFont;
            recentAchievementsAdvancedCheckBox.ForeColor = foreColor;
            recentAchievementsAdvancedCheckBox.Location = new Point(8, 3);
            recentAchievementsAdvancedCheckBox.Margin = btnPanelMargin;
            recentAchievementsAdvancedCheckBox.Name = "recentAchievementsAdvancedCheckBox";
            recentAchievementsAdvancedCheckBox.Size = new Size(135, 29);
            // recentAchievementsAdvancedCheckBox.TabIndex = 10053;

            recentAchievementsAdvancedCheckBox.Text = "Advanced";
            recentAchievementsAdvancedCheckBox.UseVisualStyleBackColor = false;
            recentAchievementsTitleFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            recentAchievementsTitleFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsTitleFontOutlineNumericUpDown.Font = numUpDownFont;
            recentAchievementsTitleFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsTitleFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsTitleFontOutlineNumericUpDown.Margin = btnPanelMargin;
            recentAchievementsTitleFontOutlineNumericUpDown.Maximum = 5;
            recentAchievementsTitleFontOutlineNumericUpDown.Minimum = 1;
            recentAchievementsTitleFontOutlineNumericUpDown.Name = "recentAchievementsTitleFontOutlineNumericUpDown";
            recentAchievementsTitleFontOutlineNumericUpDown.Size = new Size(64, 24);
            // recentAchievementsTitleFontOutlineNumericUpDown.TabIndex = 45;

            recentAchievementsTitleFontOutlineNumericUpDown.Value = 1;
            recentAchievementsTitleFontOutlineCheckBox.AutoSize = true;
            recentAchievementsTitleFontOutlineCheckBox.Font = labelFont;
            recentAchievementsTitleFontOutlineCheckBox.ForeColor = foreColor;
            recentAchievementsTitleFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsTitleFontOutlineCheckBox.Margin = btnPanelMargin;
            recentAchievementsTitleFontOutlineCheckBox.Name = "recentAchievementsTitleFontOutlineCheckBox";
            recentAchievementsTitleFontOutlineCheckBox.Size = new Size(22, 21);
            // recentAchievementsTitleFontOutlineCheckBox.TabIndex = 45;

            recentAchievementsTitleFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsTitleOutlineLabel.BackColor = Color.Transparent;
            recentAchievementsTitleOutlineLabel.Font = labelFont;
            recentAchievementsTitleOutlineLabel.ForeColor = foreColor;
            recentAchievementsTitleOutlineLabel.Location = new Point(4, 5);
            recentAchievementsTitleOutlineLabel.Margin = labelMargin;
            recentAchievementsTitleOutlineLabel.Name = "recentAchievementsTitleOutlineLabel";
            recentAchievementsTitleOutlineLabel.Size = new Size(216, 25);
            // recentAchievementsTitleOutlineLabel.TabIndex = 10066;

            recentAchievementsTitleOutlineLabel.Text = "Title OutlineColor";
            recentAchievementsTitleFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsTitleFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTitleFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsTitleFontOutlineColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsTitleFontOutlineColorPictureBox.Name = "recentAchievementsTitleFontOutlineColorPictureBox";
            recentAchievementsTitleFontOutlineColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsTitleFontOutlineColorPictureBox.TabIndex = 45;

            recentAchievementsTitleFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsOpenWindowButton.BackColor = btnBackColor;
            recentAchievementsOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            recentAchievementsOpenWindowButton.FlatStyle = FlatStyle.Flat;
            recentAchievementsOpenWindowButton.Font = labelFont;
            recentAchievementsOpenWindowButton.ForeColor = btnForeColor;
            recentAchievementsOpenWindowButton.Location = new Point(573, 3);
            recentAchievementsOpenWindowButton.Margin = new Padding(0);
            recentAchievementsOpenWindowButton.Name = "recentAchievementsOpenWindowButton";
            recentAchievementsOpenWindowButton.Size = new Size(112, 42);
            // recentAchievementsOpenWindowButton.TabIndex = 10021;

            recentAchievementsOpenWindowButton.Text = "Open";
            recentAchievementsOpenWindowButton.UseVisualStyleBackColor = false;
            recentAchievementsDescriptionOutlinePanel.BackColor = panelBackColor;
            recentAchievementsDescriptionOutlinePanel.Location = new Point(3, 332);
            recentAchievementsDescriptionOutlinePanel.Margin = btnPanelMargin;
            recentAchievementsDescriptionOutlinePanel.Name = "recentAchievementsDescriptionOutlinePanel";
            recentAchievementsDescriptionOutlinePanel.Size = new Size(694, 35);
            // recentAchievementsDescriptionOutlinePanel.TabIndex = 10072;

            recentAchievementsDateFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsDateFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsDateFontOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsDateFontOutlineColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsDateFontOutlineColorPictureBox.Name = "recentAchievementsDateFontOutlineColorPictureBox";
            recentAchievementsDateFontOutlineColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsDateFontOutlineColorPictureBox.TabIndex = 45;

            recentAchievementsDateFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsDescriptionFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            recentAchievementsDescriptionFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Font = numUpDownFont;
            recentAchievementsDescriptionFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsDescriptionFontOutlineNumericUpDown.Margin = btnPanelMargin;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Maximum = 5;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Minimum = 1;
            recentAchievementsDescriptionFontOutlineNumericUpDown.Name = "recentAchievementsDescriptionFontOutlineNumericUpDown";
            recentAchievementsDescriptionFontOutlineNumericUpDown.Size = new Size(64, 24);
            // recentAchievementsDescriptionFontOutlineNumericUpDown.TabIndex = 45;

            recentAchievementsDescriptionFontOutlineNumericUpDown.Value = 1;
            recentAchievementsDateFontOutlineCheckBox.AutoSize = true;
            recentAchievementsDateFontOutlineCheckBox.Font = labelFont;
            recentAchievementsDateFontOutlineCheckBox.ForeColor = foreColor;
            recentAchievementsDateFontOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsDateFontOutlineCheckBox.Margin = btnPanelMargin;
            recentAchievementsDateFontOutlineCheckBox.Name = "recentAchievementsDateFontOutlineCheckBox";
            recentAchievementsDateFontOutlineCheckBox.Size = new Size(22, 21);
            // recentAchievementsDateFontOutlineCheckBox.TabIndex = 45;

            recentAchievementsDateFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsDescriptionPanel.BackColor = panelBackColor;
            recentAchievementsDescriptionPanel.Location = new Point(3, 197);
            recentAchievementsDescriptionPanel.Margin = btnPanelMargin;
            recentAchievementsDescriptionPanel.Name = "recentAchievementsDescriptionPanel";
            recentAchievementsDescriptionPanel.Size = new Size(694, 35);
            // recentAchievementsDescriptionPanel.TabIndex = 10061;

            recentAchievementsDateFontColorPictureBox.BackColor = Color.White;
            recentAchievementsDateFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsDateFontColorPictureBox.Location = new Point(230, 5);
            recentAchievementsDateFontColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsDateFontColorPictureBox.Name = "recentAchievementsDateFontColorPictureBox";
            recentAchievementsDateFontColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsDateFontColorPictureBox.TabIndex = 45;

            recentAchievementsDateFontColorPictureBox.TabStop = false;
            recentAchievementsDescriptionFontComboBox.BackColor = btnBackColor;
            recentAchievementsDescriptionFontComboBox.Font = numUpDownFont;
            recentAchievementsDescriptionFontComboBox.ForeColor = Color.White;
            recentAchievementsDescriptionFontComboBox.FormattingEnabled = true;
            recentAchievementsDescriptionFontComboBox.Location = new Point(290, 3);
            recentAchievementsDescriptionFontComboBox.Margin = btnPanelMargin;
            recentAchievementsDescriptionFontComboBox.Name = "recentAchievementsDescriptionFontComboBox";
            recentAchievementsDescriptionFontComboBox.Size = new Size(301, 28);
            // recentAchievementsDescriptionFontComboBox.TabIndex = 45;

            recentAchievementsAutoOpenWindowCheckbox.AutoSize = true;
            recentAchievementsAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            recentAchievementsAutoOpenWindowCheckbox.Font = labelFont;
            recentAchievementsAutoOpenWindowCheckbox.ForeColor = foreColor;
            recentAchievementsAutoOpenWindowCheckbox.Location = new Point(378, 14);
            recentAchievementsAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            recentAchievementsAutoOpenWindowCheckbox.Name = "recentAchievementsAutoOpenWindowCheckbox";
            recentAchievementsAutoOpenWindowCheckbox.Size = new Size(147, 29);
            // recentAchievementsAutoOpenWindowCheckbox.TabIndex = 10022;

            recentAchievementsAutoOpenWindowCheckbox.Text = "Auto-Open";
            recentAchievementsAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            recentAchievementsBackgroundColorPictureBox.BackColor = Color.White;
            recentAchievementsBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsBackgroundColorPictureBox.Location = new Point(230, 5);
            recentAchievementsBackgroundColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsBackgroundColorPictureBox.Name = "recentAchievementsBackgroundColorPictureBox";
            recentAchievementsBackgroundColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsBackgroundColorPictureBox.TabIndex = 42;

            recentAchievementsBackgroundColorPictureBox.TabStop = false;
            recentAchievementsTitleLabel.BackColor = Color.Transparent;
            recentAchievementsTitleLabel.Font = labelFont;
            recentAchievementsTitleLabel.ForeColor = foreColor;
            recentAchievementsTitleLabel.Location = new Point(4, 6);
            recentAchievementsTitleLabel.Margin = labelMargin;
            recentAchievementsTitleLabel.Name = "recentAchievementsTitleLabel";
            recentAchievementsTitleLabel.Size = new Size(216, 25);
            // recentAchievementsTitleLabel.TabIndex = 10065;

            recentAchievementsTitleLabel.Text = "Title";
            recentAchievementsTitleFontColorPictureBox.BackColor = Color.White;
            recentAchievementsTitleFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsTitleFontColorPictureBox.Location = new Point(230, 6);
            recentAchievementsTitleFontColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsTitleFontColorPictureBox.Name = "recentAchievementsTitleFontColorPictureBox";
            recentAchievementsTitleFontColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsTitleFontColorPictureBox.TabIndex = 45;

            recentAchievementsTitleFontColorPictureBox.TabStop = false;
            recentAchievementsTitleFontComboBox.BackColor = btnBackColor;
            recentAchievementsTitleFontComboBox.Font = numUpDownFont;
            recentAchievementsTitleFontComboBox.ForeColor = Color.White;
            recentAchievementsTitleFontComboBox.FormattingEnabled = true;
            recentAchievementsTitleFontComboBox.Location = new Point(290, 3);
            recentAchievementsTitleFontComboBox.Margin = btnPanelMargin;
            recentAchievementsTitleFontComboBox.Name = "recentAchievementsTitleFontComboBox";
            recentAchievementsTitleFontComboBox.Size = new Size(301, 28);
            // recentAchievementsTitleFontComboBox.TabIndex = 45;

            recentAchievementsPointsOutlinePanel.BackColor = btnBackColor;
            recentAchievementsPointsOutlinePanel.Location = new Point(3, 366);
            recentAchievementsPointsOutlinePanel.Margin = btnPanelMargin;
            recentAchievementsPointsOutlinePanel.Name = "recentAchievementsPointsOutlinePanel";
            recentAchievementsPointsOutlinePanel.Size = new Size(694, 35);
            // recentAchievementsPointsOutlinePanel.TabIndex = 10061;

            recentAchievementsPointsFontOutlineNumericUpDown.BackColor = numUpDownBackColor;
            recentAchievementsPointsFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsPointsFontOutlineNumericUpDown.Font = numUpDownFont;
            recentAchievementsPointsFontOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsPointsFontOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsPointsFontOutlineNumericUpDown.Margin = btnPanelMargin;
            recentAchievementsPointsFontOutlineNumericUpDown.Maximum = 5;
            recentAchievementsPointsFontOutlineNumericUpDown.Minimum = 1;
            recentAchievementsPointsFontOutlineNumericUpDown.Name = "recentAchievementsPointsFontOutlineNumericUpDown";
            recentAchievementsPointsFontOutlineNumericUpDown.Size = new Size(64, 24);
            // recentAchievementsPointsFontOutlineNumericUpDown.TabIndex = 45;

            recentAchievementsPointsFontOutlineNumericUpDown.Value = 1;
            recentAchievementsPointsFontOutlineCheckBox.AutoSize = true;
            recentAchievementsPointsFontOutlineCheckBox.Font = labelFont;
            recentAchievementsPointsFontOutlineCheckBox.ForeColor = foreColor;
            recentAchievementsPointsFontOutlineCheckBox.Location = new Point(620, 8);
            recentAchievementsPointsFontOutlineCheckBox.Margin = btnPanelMargin;
            recentAchievementsPointsFontOutlineCheckBox.Name = "recentAchievementsPointsFontOutlineCheckBox";
            recentAchievementsPointsFontOutlineCheckBox.Size = new Size(22, 21);
            // recentAchievementsPointsFontOutlineCheckBox.TabIndex = 45;

            recentAchievementsPointsFontOutlineCheckBox.UseVisualStyleBackColor = true;
            recentAchievementsPointsFontOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsPointsFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsPointsFontOutlineColorPictureBox.Location = new Point(230, 5);
            recentAchievementsPointsFontOutlineColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsPointsFontOutlineColorPictureBox.Name = "recentAchievementsPointsFontOutlineColorPictureBox";
            recentAchievementsPointsFontOutlineColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsPointsFontOutlineColorPictureBox.TabIndex = 45;

            recentAchievementsPointsFontOutlineColorPictureBox.TabStop = false;
            recentAchievementsLineOutlinePanel.BackColor = panelBackColor;
            recentAchievementsLineOutlinePanel.Location = new Point(3, 400);
            recentAchievementsLineOutlinePanel.Margin = btnPanelMargin;
            recentAchievementsLineOutlinePanel.Name = "recentAchievementsLineOutlinePanel";
            recentAchievementsLineOutlinePanel.Size = new Size(694, 35);
            // recentAchievementsLineOutlinePanel.TabIndex = 10067;

            recentAchievementsLineOutlineColorPictureBox.BackColor = Color.White;
            recentAchievementsLineOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            recentAchievementsLineOutlineColorPictureBox.Location = new Point(230, 6);
            recentAchievementsLineOutlineColorPictureBox.Margin = btnPanelMargin;
            recentAchievementsLineOutlineColorPictureBox.Name = "recentAchievementsLineOutlineColorPictureBox";
            recentAchievementsLineOutlineColorPictureBox.Size = new Size(22, 22);
            // recentAchievementsLineOutlineColorPictureBox.TabIndex = 45;

            recentAchievementsLineOutlineColorPictureBox.TabStop = false;
            recentAchievementsLineOutlineNumericUpDown.BackColor = numUpDownBackColor;
            recentAchievementsLineOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            recentAchievementsLineOutlineNumericUpDown.Font = numUpDownFont;
            recentAchievementsLineOutlineNumericUpDown.ForeColor = Color.White;
            recentAchievementsLineOutlineNumericUpDown.Location = new Point(528, 6);
            recentAchievementsLineOutlineNumericUpDown.Margin = btnPanelMargin;
            recentAchievementsLineOutlineNumericUpDown.Maximum = 5;
            recentAchievementsLineOutlineNumericUpDown.Minimum = 1;
            recentAchievementsLineOutlineNumericUpDown.Name = "recentAchievementsLineOutlineNumericUpDown";
            recentAchievementsLineOutlineNumericUpDown.Size = new Size(64, 24);
            // recentAchievementsLineOutlineNumericUpDown.TabIndex = 45;

            recentAchievementsLineOutlineNumericUpDown.Value = 1;
            recentAchievementsLineOutlineCheckBox.AutoSize = true;
            recentAchievementsLineOutlineCheckBox.Font = labelFont;
            recentAchievementsLineOutlineCheckBox.ForeColor = foreColor;
            recentAchievementsLineOutlineCheckBox.Location = new Point(620, 9);
            recentAchievementsLineOutlineCheckBox.Margin = btnPanelMargin;
            recentAchievementsLineOutlineCheckBox.Name = "recentAchievementsLineOutlineCheckBox";
            recentAchievementsLineOutlineCheckBox.Size = new Size(22, 21);
            // recentAchievementsLineOutlineCheckBox.TabIndex = 45;

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
