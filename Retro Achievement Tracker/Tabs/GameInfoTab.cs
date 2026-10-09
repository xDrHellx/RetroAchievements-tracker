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

        public override void InitElements()
        {
            gameInfoPictureBox = new PictureBox();
            gameInfoGenreLabel = new Label();
            gameInfoReleasedLabel = new Label();
            gameInfoPublisherLabel = new Label();
            gameInfoDeveloperLabel = new Label();
            gameInfoTitleLabel = new Label();
            gameInfoReleasedCheckBox = new CheckBox();
            gameInfoReleaseDateTextBox = new TextBox();
            gameInfoGenreCheckBox = new CheckBox();
            gameInfoGenreTextBox = new TextBox();
            gameInfoDefaultButton = new Button();
            gameInfoTitleCheckBox = new CheckBox();
            gameInfoTitleTextBox = new TextBox();
            gameInfoConsoleCheckBox = new CheckBox();
            gameInfoConsoleTextBox = new TextBox();
            gameInfoPublisherTextBox = new TextBox();
            gameInfoPublisherCheckBox = new CheckBox();
            gameInfoDeveloperTextBox = new TextBox();
            gameInfoDeveloperCheckBox = new CheckBox();
            gameInfoAdvancedCheckBox = new CheckBox();
            gameInfoOpenWindowButton = new Button();
            gameInfoValuesPanel = new Panel();
            gameInfoValuesFontColorPictureBox = new PictureBox();
            gameInfoValuesFontComboBox = new ComboBox();
            gameInfoAutoOpenWindowCheckbox = new CheckBox();
            gameInfoBackgroundColorPictureBox = new PictureBox();
            gameInfoNamesLabel = new Label();
            gameInfoNamesFontColorPictureBox = new PictureBox();
            gameInfoNamesFontComboBox = new ComboBox();
            gameInfoNamesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoNamesOutlineCheckBox = new CheckBox();
            gameInfoNamesOutlineLabel = new Label();
            gameInfoNamesFontOutlineColorPictureBox = new PictureBox();
            gameInfoValuesOutlinePanel = new Panel();
            gameInfoValuesFontOutlineColorPictureBox = new PictureBox();
            gameInfoValuesFontOutlineNumericUpDown = new NumericUpDown();
            gameInfoValuesOutlineCheckBox = new CheckBox();
            gameInfoValuesPanel.SuspendLayout();
            gameInfoValuesOutlinePanel.SuspendLayout();
            gameInfoPictureBox.BackColor = Color.Transparent;
            gameInfoPictureBox.Cursor = Cursors.Hand;
            gameInfoPictureBox.InitialImage = null;
            gameInfoPictureBox.Location = new Point(12, 80);
            gameInfoPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoPictureBox.Name = "gameInfoPictureBox";
            gameInfoPictureBox.Size = new Size(144, 148);
            gameInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameInfoPictureBox.TabIndex = 10004;
            gameInfoPictureBox.TabStop = false;
            gameInfoGenreLabel.BackColor = Color.Transparent;
            gameInfoGenreLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoGenreLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoGenreLabel.Location = new Point(154, 8);
            gameInfoGenreLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoGenreLabel.Name = "gameInfoGenreLabel";
            gameInfoGenreLabel.Size = new Size(363, 25);
            gameInfoGenreLabel.TabIndex = 10066;
            gameInfoGenreLabel.UseMnemonic = false;
            gameInfoReleasedLabel.BackColor = Color.Transparent;
            gameInfoReleasedLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoReleasedLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoReleasedLabel.Location = new Point(154, 8);
            gameInfoReleasedLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoReleasedLabel.Name = "gameInfoReleasedLabel";
            gameInfoReleasedLabel.Size = new Size(363, 25);
            gameInfoReleasedLabel.TabIndex = 10067;
            gameInfoReleasedLabel.UseMnemonic = false;
            gameInfoPublisherLabel.BackColor = Color.Transparent;
            gameInfoPublisherLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoPublisherLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoPublisherLabel.Location = new Point(154, 9);
            gameInfoPublisherLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoPublisherLabel.Name = "gameInfoPublisherLabel";
            gameInfoPublisherLabel.Size = new Size(363, 25);
            gameInfoPublisherLabel.TabIndex = 10064;
            gameInfoPublisherLabel.UseMnemonic = false;
            gameInfoDeveloperLabel.BackColor = Color.Transparent;
            gameInfoDeveloperLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoDeveloperLabel.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoDeveloperLabel.Location = new Point(154, 5);
            gameInfoDeveloperLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoDeveloperLabel.Name = "gameInfoDeveloperLabel";
            gameInfoDeveloperLabel.Size = new Size(363, 25);
            gameInfoDeveloperLabel.TabIndex = 10063;
            gameInfoDeveloperLabel.UseMnemonic = false;
            gameInfoTitleLabel.BackColor = Color.Transparent;
            gameInfoTitleLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTitleLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoTitleLabel.Location = new Point(4, 5);
            gameInfoTitleLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoTitleLabel.Name = "gameInfoTitleLabel";
            gameInfoTitleLabel.Size = new Size(688, 58);
            gameInfoTitleLabel.TabIndex = 10058;
            gameInfoTitleLabel.Text = "Game Info Title";
            gameInfoTitleLabel.UseMnemonic = false;
            gameInfoReleasedCheckBox.AutoSize = true;
            gameInfoReleasedCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoReleasedCheckBox.Location = new Point(338, 8);
            gameInfoReleasedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoReleasedCheckBox.Name = "gameInfoReleasedCheckBox";
            gameInfoReleasedCheckBox.Size = new Size(22, 21);
            gameInfoReleasedCheckBox.TabIndex = 55;
            gameInfoReleasedCheckBox.UseVisualStyleBackColor = true;
            gameInfoReleaseDateTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoReleaseDateTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoReleaseDateTextBox.ForeColor = Color.White;
            gameInfoReleaseDateTextBox.Location = new Point(174, 0);
            gameInfoReleaseDateTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoReleaseDateTextBox.Name = "gameInfoReleaseDateTextBox";
            gameInfoReleaseDateTextBox.Size = new Size(146, 31);
            gameInfoReleaseDateTextBox.TabIndex = 5;
            gameInfoReleaseDateTextBox.Text = "Released";
            gameInfoGenreCheckBox.AutoSize = true;
            gameInfoGenreCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoGenreCheckBox.Location = new Point(338, 8);
            gameInfoGenreCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoGenreCheckBox.Name = "gameInfoGenreCheckBox";
            gameInfoGenreCheckBox.Size = new Size(22, 21);
            gameInfoGenreCheckBox.TabIndex = 55;
            gameInfoGenreCheckBox.UseVisualStyleBackColor = true;
            gameInfoGenreTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoGenreTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoGenreTextBox.ForeColor = Color.White;
            gameInfoGenreTextBox.Location = new Point(174, 0);
            gameInfoGenreTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoGenreTextBox.Name = "gameInfoGenreTextBox";
            gameInfoGenreTextBox.Size = new Size(146, 31);
            gameInfoGenreTextBox.TabIndex = 5;
            gameInfoGenreTextBox.Text = "Genre";
            gameInfoDefaultButton.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoDefaultButton.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            gameInfoDefaultButton.FlatStyle = FlatStyle.Flat;
            gameInfoDefaultButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoDefaultButton.ForeColor = Color.FromArgb(239, 68, 68);
            gameInfoDefaultButton.Location = new Point(306, 3);
            gameInfoDefaultButton.Margin = new Padding(0);
            gameInfoDefaultButton.Name = "gameInfoDefaultButton";
            gameInfoDefaultButton.Size = new Size(112, 42);
            gameInfoDefaultButton.TabIndex = 39;
            gameInfoDefaultButton.Text = "Default";
            gameInfoDefaultButton.UseVisualStyleBackColor = false;
            gameInfoTitleCheckBox.AutoSize = true;
            gameInfoTitleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTitleCheckBox.Location = new Point(338, 8);
            gameInfoTitleCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTitleCheckBox.Name = "gameInfoTitleCheckBox";
            gameInfoTitleCheckBox.Size = new Size(22, 21);
            gameInfoTitleCheckBox.TabIndex = 52;
            gameInfoTitleCheckBox.UseVisualStyleBackColor = true;
            gameInfoTitleTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoTitleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoTitleTextBox.ForeColor = Color.White;
            gameInfoTitleTextBox.Location = new Point(174, 0);
            gameInfoTitleTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoTitleTextBox.Name = "gameInfoTitleTextBox";
            gameInfoTitleTextBox.Size = new Size(146, 31);
            gameInfoTitleTextBox.TabIndex = 1;
            gameInfoTitleTextBox.Text = "Title";
            gameInfoConsoleCheckBox.AutoSize = true;
            gameInfoConsoleCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoConsoleCheckBox.Location = new Point(338, 8);
            gameInfoConsoleCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoConsoleCheckBox.Name = "gameInfoConsoleCheckBox";
            gameInfoConsoleCheckBox.Size = new Size(22, 21);
            gameInfoConsoleCheckBox.TabIndex = 55;
            gameInfoConsoleCheckBox.UseVisualStyleBackColor = true;
            gameInfoConsoleTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoConsoleTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoConsoleTextBox.ForeColor = Color.White;
            gameInfoConsoleTextBox.Location = new Point(174, 0);
            gameInfoConsoleTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoConsoleTextBox.Name = "gameInfoConsoleTextBox";
            gameInfoConsoleTextBox.Size = new Size(146, 31);
            gameInfoConsoleTextBox.TabIndex = 5;
            gameInfoConsoleTextBox.Text = "Console";
            gameInfoPublisherTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoPublisherTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoPublisherTextBox.ForeColor = Color.White;
            gameInfoPublisherTextBox.Location = new Point(174, 0);
            gameInfoPublisherTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoPublisherTextBox.Name = "gameInfoPublisherTextBox";
            gameInfoPublisherTextBox.Size = new Size(146, 31);
            gameInfoPublisherTextBox.TabIndex = 7;
            gameInfoPublisherTextBox.Text = "Publisher";
            gameInfoPublisherCheckBox.AutoSize = true;
            gameInfoPublisherCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoPublisherCheckBox.Location = new Point(338, 8);
            gameInfoPublisherCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoPublisherCheckBox.Name = "gameInfoPublisherCheckBox";
            gameInfoPublisherCheckBox.Size = new Size(22, 21);
            gameInfoPublisherCheckBox.TabIndex = 56;
            gameInfoPublisherCheckBox.UseVisualStyleBackColor = true;
            gameInfoDeveloperTextBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoDeveloperTextBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoDeveloperTextBox.ForeColor = Color.White;
            gameInfoDeveloperTextBox.Location = new Point(174, 0);
            gameInfoDeveloperTextBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoDeveloperTextBox.Name = "gameInfoDeveloperTextBox";
            gameInfoDeveloperTextBox.Size = new Size(146, 31);
            gameInfoDeveloperTextBox.TabIndex = 6;
            gameInfoDeveloperTextBox.Text = "Developer";
            gameInfoDeveloperCheckBox.AutoSize = true;
            gameInfoDeveloperCheckBox.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            gameInfoDeveloperCheckBox.Location = new Point(338, 8);
            gameInfoDeveloperCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoDeveloperCheckBox.Name = "gameInfoDeveloperCheckBox";
            gameInfoDeveloperCheckBox.Size = new Size(22, 21);
            gameInfoDeveloperCheckBox.TabIndex = 54;
            gameInfoDeveloperCheckBox.UseVisualStyleBackColor = true;
            gameInfoAdvancedCheckBox.AutoSize = true;
            gameInfoAdvancedCheckBox.BackColor = Color.Transparent;
            gameInfoAdvancedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoAdvancedCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoAdvancedCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoAdvancedCheckBox.Location = new Point(8, 3);
            gameInfoAdvancedCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoAdvancedCheckBox.Name = "gameInfoAdvancedCheckBox";
            gameInfoAdvancedCheckBox.Size = new Size(135, 29);
            gameInfoAdvancedCheckBox.TabIndex = 10053;
            gameInfoAdvancedCheckBox.Text = "Advanced";
            gameInfoAdvancedCheckBox.UseVisualStyleBackColor = false;
            gameInfoOpenWindowButton.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            gameInfoOpenWindowButton.FlatStyle = FlatStyle.Flat;
            gameInfoOpenWindowButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoOpenWindowButton.ForeColor = Color.FromArgb(204, 153, 0);
            gameInfoOpenWindowButton.Location = new Point(573, 3);
            gameInfoOpenWindowButton.Margin = new Padding(0);
            gameInfoOpenWindowButton.Name = "gameInfoOpenWindowButton";
            gameInfoOpenWindowButton.Size = new Size(112, 42);
            gameInfoOpenWindowButton.TabIndex = 10021;
            gameInfoOpenWindowButton.Text = "Open";
            gameInfoOpenWindowButton.UseVisualStyleBackColor = false;
            gameInfoValuesPanel.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoValuesPanel.Location = new Point(3, 163);
            gameInfoValuesPanel.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesPanel.Name = "gameInfoValuesPanel";
            gameInfoValuesPanel.Size = new Size(694, 35);
            gameInfoValuesPanel.TabIndex = 10061;
            gameInfoValuesFontColorPictureBox.BackColor = Color.White;
            gameInfoValuesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoValuesFontColorPictureBox.Location = new Point(230, 5);
            gameInfoValuesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesFontColorPictureBox.Name = "gameInfoValuesFontColorPictureBox";
            gameInfoValuesFontColorPictureBox.Size = new Size(22, 22);
            gameInfoValuesFontColorPictureBox.TabIndex = 45;
            gameInfoValuesFontColorPictureBox.TabStop = false;
            gameInfoValuesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoValuesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoValuesFontComboBox.ForeColor = Color.White;
            gameInfoValuesFontComboBox.FormattingEnabled = true;
            gameInfoValuesFontComboBox.Location = new Point(290, 3);
            gameInfoValuesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesFontComboBox.Name = "gameInfoValuesFontComboBox";
            gameInfoValuesFontComboBox.Size = new Size(301, 28);
            gameInfoValuesFontComboBox.TabIndex = 45;
            gameInfoAutoOpenWindowCheckbox.AutoSize = true;
            gameInfoAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            gameInfoAutoOpenWindowCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoAutoOpenWindowCheckbox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoAutoOpenWindowCheckbox.Location = new Point(378, 14);
            gameInfoAutoOpenWindowCheckbox.Margin = new Padding(4, 5, 4, 5);
            gameInfoAutoOpenWindowCheckbox.Name = "gameInfoAutoOpenWindowCheckbox";
            gameInfoAutoOpenWindowCheckbox.Size = new Size(147, 29);
            gameInfoAutoOpenWindowCheckbox.TabIndex = 10022;
            gameInfoAutoOpenWindowCheckbox.Text = "Auto-Open";
            gameInfoAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            gameInfoBackgroundColorPictureBox.BackColor = Color.White;
            gameInfoBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoBackgroundColorPictureBox.Location = new Point(230, 5);
            gameInfoBackgroundColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoBackgroundColorPictureBox.Name = "gameInfoBackgroundColorPictureBox";
            gameInfoBackgroundColorPictureBox.Size = new Size(22, 22);
            gameInfoBackgroundColorPictureBox.TabIndex = 42;
            gameInfoBackgroundColorPictureBox.TabStop = false;
            gameInfoNamesLabel.BackColor = Color.Transparent;
            gameInfoNamesLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoNamesLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoNamesLabel.Location = new Point(4, 6);
            gameInfoNamesLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoNamesLabel.Name = "gameInfoNamesLabel";
            gameInfoNamesLabel.Size = new Size(216, 25);
            gameInfoNamesLabel.TabIndex = 10065;
            gameInfoNamesLabel.Text = "Names";
            gameInfoNamesFontColorPictureBox.BackColor = Color.White;
            gameInfoNamesFontColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoNamesFontColorPictureBox.Location = new Point(230, 6);
            gameInfoNamesFontColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoNamesFontColorPictureBox.Name = "gameInfoNamesFontColorPictureBox";
            gameInfoNamesFontColorPictureBox.Size = new Size(22, 22);
            gameInfoNamesFontColorPictureBox.TabIndex = 45;
            gameInfoNamesFontColorPictureBox.TabStop = false;
            gameInfoNamesFontComboBox.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoNamesFontComboBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoNamesFontComboBox.ForeColor = Color.White;
            gameInfoNamesFontComboBox.FormattingEnabled = true;
            gameInfoNamesFontComboBox.Location = new Point(290, 3);
            gameInfoNamesFontComboBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoNamesFontComboBox.Name = "gameInfoNamesFontComboBox";
            gameInfoNamesFontComboBox.Size = new Size(301, 28);
            gameInfoNamesFontComboBox.TabIndex = 45;
            gameInfoNamesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameInfoNamesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoNamesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoNamesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoNamesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoNamesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameInfoNamesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gameInfoNamesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gameInfoNamesFontOutlineNumericUpDown.Name = "gameInfoNamesFontOutlineNumericUpDown";
            gameInfoNamesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameInfoNamesFontOutlineNumericUpDown.TabIndex = 45;
            gameInfoNamesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            gameInfoNamesOutlineCheckBox.AutoSize = true;
            gameInfoNamesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoNamesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoNamesOutlineCheckBox.Location = new Point(620, 8);
            gameInfoNamesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoNamesOutlineCheckBox.Name = "gameInfoNamesOutlineCheckBox";
            gameInfoNamesOutlineCheckBox.Size = new Size(22, 21);
            gameInfoNamesOutlineCheckBox.TabIndex = 45;
            gameInfoNamesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoNamesOutlineLabel.BackColor = Color.Transparent;
            gameInfoNamesOutlineLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoNamesOutlineLabel.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoNamesOutlineLabel.Location = new Point(4, 5);
            gameInfoNamesOutlineLabel.Margin = new Padding(4, 0, 4, 0);
            gameInfoNamesOutlineLabel.Name = "gameInfoNamesOutlineLabel";
            gameInfoNamesOutlineLabel.Size = new Size(216, 25);
            gameInfoNamesOutlineLabel.TabIndex = 10066;
            gameInfoNamesOutlineLabel.Text = "Names OutlineColor";
            gameInfoNamesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoNamesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoNamesFontOutlineColorPictureBox.Location = new Point(230, 5);
            gameInfoNamesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoNamesFontOutlineColorPictureBox.Name = "gameInfoNamesFontOutlineColorPictureBox";
            gameInfoNamesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameInfoNamesFontOutlineColorPictureBox.TabIndex = 45;
            gameInfoNamesFontOutlineColorPictureBox.TabStop = false;
            gameInfoValuesOutlinePanel.BackColor = Color.FromArgb(22, 22, 22);
            gameInfoValuesOutlinePanel.Location = new Point(3, 231);
            gameInfoValuesOutlinePanel.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesOutlinePanel.Name = "gameInfoValuesOutlinePanel";
            gameInfoValuesOutlinePanel.Size = new Size(694, 35);
            gameInfoValuesOutlinePanel.TabIndex = 10067;
            gameInfoValuesFontOutlineColorPictureBox.BackColor = Color.White;
            gameInfoValuesFontOutlineColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            gameInfoValuesFontOutlineColorPictureBox.Location = new Point(230, 6);
            gameInfoValuesFontOutlineColorPictureBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesFontOutlineColorPictureBox.Name = "gameInfoValuesFontOutlineColorPictureBox";
            gameInfoValuesFontOutlineColorPictureBox.Size = new Size(22, 22);
            gameInfoValuesFontOutlineColorPictureBox.TabIndex = 45;
            gameInfoValuesFontOutlineColorPictureBox.TabStop = false;
            gameInfoValuesFontOutlineNumericUpDown.BackColor = Color.FromArgb(42, 42, 42);
            gameInfoValuesFontOutlineNumericUpDown.BorderStyle = BorderStyle.None;
            gameInfoValuesFontOutlineNumericUpDown.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoValuesFontOutlineNumericUpDown.ForeColor = Color.White;
            gameInfoValuesFontOutlineNumericUpDown.Location = new Point(528, 6);
            gameInfoValuesFontOutlineNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesFontOutlineNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gameInfoValuesFontOutlineNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gameInfoValuesFontOutlineNumericUpDown.Name = "gameInfoValuesFontOutlineNumericUpDown";
            gameInfoValuesFontOutlineNumericUpDown.Size = new Size(64, 24);
            gameInfoValuesFontOutlineNumericUpDown.TabIndex = 45;
            gameInfoValuesFontOutlineNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            gameInfoValuesOutlineCheckBox.AutoSize = true;
            gameInfoValuesOutlineCheckBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gameInfoValuesOutlineCheckBox.ForeColor = Color.FromArgb(44, 151, 250);
            gameInfoValuesOutlineCheckBox.Location = new Point(620, 9);
            gameInfoValuesOutlineCheckBox.Margin = new Padding(4, 5, 4, 5);
            gameInfoValuesOutlineCheckBox.Name = "gameInfoValuesOutlineCheckBox";
            gameInfoValuesOutlineCheckBox.Size = new Size(22, 21);
            gameInfoValuesOutlineCheckBox.TabIndex = 45;
            gameInfoValuesOutlineCheckBox.UseVisualStyleBackColor = true;
            gameInfoValuesPanel.ResumeLayout(false);
            gameInfoValuesOutlinePanel.ResumeLayout(false);
            gameInfoValuesOutlinePanel.PerformLayout();
        }

        #endregion
    }
}
