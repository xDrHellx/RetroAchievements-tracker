using System.Drawing;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker.Tabs
{
    public class RelatedMediaTab : AbstractTab
    {
        #region Sub elements

        public Label relatedMediaLBLabel;
        public PictureBox relatedMediaBackgroundColorPictureBox,
            relatedMediaLBLinePictureBox;
        public Button relatedMediaOpenWindowButton,
            relatedMediaSetLaunchBoxPathButton;
        public CheckBox relatedMediaAutoOpenWindowCheckbox;
        public RadioButton relatedMediaRAScreenshotRadioButton,
            relatedMediaRABadgeIconRadioButton,
            relatedMediaRABoxArtRadioButton,
            relatedMediaRATitleScreenRadioButton,
            relatedMediaLBBoxFrontReconRadioButton,
            relatedMediaLBBoxFrontRadioButton,
            relatedMediaLBBoxBackRadioButton,
            relatedMediaLBBox3DRadioButton,
            relatedMediaLBCartFrontRadioButton,
            relatedMediaLBCartBackRadioButton,
            relatedMediaLBBoxBackReconRadioButton,
            relatedMediaLBBoxFullRadioButton,
            relatedMediaLBBoxSpineRadioButton,
            relatedMediaLBClearLogoRadioButton,
            relatedMediaLBBannerRadioButton,
            relatedMediaLBTitleScreenRadioButton;

        #endregion

        #region Constructor

        public RelatedMediaTab()
        {
            Name = "RelatedMediaTabPage";
            Text = "Related Media";
            BackColor = btnBackColor;
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable) { }

        public override void InitElements()
        {
            relatedMediaRAScreenshotRadioButton = new RadioButton();
            relatedMediaRABadgeIconRadioButton = new RadioButton();
            relatedMediaRABoxArtRadioButton = new RadioButton();
            relatedMediaRATitleScreenRadioButton = new RadioButton();
            relatedMediaOpenWindowButton = new Button();
            relatedMediaAutoOpenWindowCheckbox = new CheckBox();
            relatedMediaBackgroundColorPictureBox = new PictureBox();
            relatedMediaLBCartFrontRadioButton = new RadioButton();
            relatedMediaLBCartBackRadioButton = new RadioButton();
            relatedMediaLBBoxBackReconRadioButton = new RadioButton();
            relatedMediaLBBoxFullRadioButton = new RadioButton();
            relatedMediaLBBoxSpineRadioButton = new RadioButton();
            relatedMediaLBClearLogoRadioButton = new RadioButton();
            relatedMediaLBBannerRadioButton = new RadioButton();
            relatedMediaLBTitleScreenRadioButton = new RadioButton();
            relatedMediaSetLaunchBoxPathButton = new Button();
            relatedMediaLBBoxFrontReconRadioButton = new RadioButton();
            relatedMediaLBBoxFrontRadioButton = new RadioButton();
            relatedMediaLBBoxBackRadioButton = new RadioButton();
            relatedMediaLBBox3DRadioButton = new RadioButton();
            relatedMediaLBLinePictureBox = new PictureBox();
            relatedMediaLBLabel = new Label();
            relatedMediaRAScreenshotRadioButton.AutoSize = true;
            relatedMediaRAScreenshotRadioButton.Font = labelFont;
            relatedMediaRAScreenshotRadioButton.ForeColor = foreColor;
            relatedMediaRAScreenshotRadioButton.Location = new Point(12, 182);
            relatedMediaRAScreenshotRadioButton.Margin = btnPanelMargin;
            relatedMediaRAScreenshotRadioButton.Name = "relatedMediaRAScreenshotRadioButton";
            relatedMediaRAScreenshotRadioButton.Size = new Size(150, 29);
            // relatedMediaRAScreenshotRadioButton.TabIndex = 10075;

            relatedMediaRAScreenshotRadioButton.Text = "Screenshot";
            relatedMediaRAScreenshotRadioButton.UseVisualStyleBackColor = true;
            relatedMediaRABadgeIconRadioButton.AutoSize = true;
            relatedMediaRABadgeIconRadioButton.Checked = true;
            relatedMediaRABadgeIconRadioButton.Font = labelFont;
            relatedMediaRABadgeIconRadioButton.ForeColor = foreColor;
            relatedMediaRABadgeIconRadioButton.Location = new Point(12, 62);
            relatedMediaRABadgeIconRadioButton.Margin = btnPanelMargin;
            relatedMediaRABadgeIconRadioButton.Name = "relatedMediaRABadgeIconRadioButton";
            relatedMediaRABadgeIconRadioButton.Size = new Size(149, 29);
            // relatedMediaRABadgeIconRadioButton.TabIndex = 10072;

            relatedMediaRABadgeIconRadioButton.TabStop = true;
            relatedMediaRABadgeIconRadioButton.Text = "Badge Icon";
            relatedMediaRABadgeIconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaRABoxArtRadioButton.AutoSize = true;
            relatedMediaRABoxArtRadioButton.Font = labelFont;
            relatedMediaRABoxArtRadioButton.ForeColor = foreColor;
            relatedMediaRABoxArtRadioButton.Location = new Point(12, 102);
            relatedMediaRABoxArtRadioButton.Margin = btnPanelMargin;
            relatedMediaRABoxArtRadioButton.Name = "relatedMediaRABoxArtRadioButton";
            relatedMediaRABoxArtRadioButton.Size = new Size(113, 29);
            // relatedMediaRABoxArtRadioButton.TabIndex = 10074;

            relatedMediaRABoxArtRadioButton.Text = "Box Art";
            relatedMediaRABoxArtRadioButton.UseVisualStyleBackColor = true;
            relatedMediaRATitleScreenRadioButton.AutoSize = true;
            relatedMediaRATitleScreenRadioButton.Font = labelFont;
            relatedMediaRATitleScreenRadioButton.ForeColor = foreColor;
            relatedMediaRATitleScreenRadioButton.Location = new Point(12, 142);
            relatedMediaRATitleScreenRadioButton.Margin = btnPanelMargin;
            relatedMediaRATitleScreenRadioButton.Name = "relatedMediaRATitleScreenRadioButton";
            relatedMediaRATitleScreenRadioButton.Size = new Size(158, 29);
            // relatedMediaRATitleScreenRadioButton.TabIndex = 10073;

            relatedMediaRATitleScreenRadioButton.Text = "Title Screen";
            relatedMediaRATitleScreenRadioButton.UseVisualStyleBackColor = true;
            relatedMediaOpenWindowButton.BackColor = btnBackColor;
            relatedMediaOpenWindowButton.FlatAppearance.BorderColor = Color.Black;
            relatedMediaOpenWindowButton.FlatStyle = FlatStyle.Flat;
            relatedMediaOpenWindowButton.Font = labelFont;
            relatedMediaOpenWindowButton.ForeColor = btnForeColor;
            relatedMediaOpenWindowButton.Location = new Point(573, 3);
            relatedMediaOpenWindowButton.Margin = new Padding(0);
            relatedMediaOpenWindowButton.Name = "relatedMediaOpenWindowButton";
            relatedMediaOpenWindowButton.Size = new Size(112, 42);
            // relatedMediaOpenWindowButton.TabIndex = 10021;

            relatedMediaOpenWindowButton.Text = "Open";
            relatedMediaOpenWindowButton.UseVisualStyleBackColor = false;
            relatedMediaAutoOpenWindowCheckbox.AutoSize = true;
            relatedMediaAutoOpenWindowCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            relatedMediaAutoOpenWindowCheckbox.Font = labelFont;
            relatedMediaAutoOpenWindowCheckbox.ForeColor = foreColor;
            relatedMediaAutoOpenWindowCheckbox.Location = new Point(378, 14);
            relatedMediaAutoOpenWindowCheckbox.Margin = btnPanelMargin;
            relatedMediaAutoOpenWindowCheckbox.Name = "relatedMediaAutoOpenWindowCheckbox";
            relatedMediaAutoOpenWindowCheckbox.Size = new Size(147, 29);
            // relatedMediaAutoOpenWindowCheckbox.TabIndex = 10022;

            relatedMediaAutoOpenWindowCheckbox.Text = "Auto-Open";
            relatedMediaAutoOpenWindowCheckbox.UseVisualStyleBackColor = true;
            relatedMediaBackgroundColorPictureBox.BackColor = Color.White;
            relatedMediaBackgroundColorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            relatedMediaBackgroundColorPictureBox.Location = new Point(230, 5);
            relatedMediaBackgroundColorPictureBox.Margin = btnPanelMargin;
            relatedMediaBackgroundColorPictureBox.Name = "relatedMediaBackgroundColorPictureBox";
            relatedMediaBackgroundColorPictureBox.Size = new Size(22, 22);
            // relatedMediaBackgroundColorPictureBox.TabIndex = 42;

            relatedMediaBackgroundColorPictureBox.TabStop = false;
            relatedMediaLBCartFrontRadioButton.AutoSize = true;
            relatedMediaLBCartFrontRadioButton.Font = labelFont;
            relatedMediaLBCartFrontRadioButton.ForeColor = foreColor;
            relatedMediaLBCartFrontRadioButton.Location = new Point(260, 222);
            relatedMediaLBCartFrontRadioButton.Margin = btnPanelMargin;
            relatedMediaLBCartFrontRadioButton.Name = "relatedMediaLBCartFrontRadioButton";
            relatedMediaLBCartFrontRadioButton.Size = new Size(157, 29);
            // relatedMediaLBCartFrontRadioButton.TabIndex = 10084;

            relatedMediaLBCartFrontRadioButton.Text = "Cart - Front";
            relatedMediaLBCartFrontRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBCartBackRadioButton.AutoSize = true;
            relatedMediaLBCartBackRadioButton.Font = labelFont;
            relatedMediaLBCartBackRadioButton.ForeColor = foreColor;
            relatedMediaLBCartBackRadioButton.Location = new Point(260, 262);
            relatedMediaLBCartBackRadioButton.Margin = btnPanelMargin;
            relatedMediaLBCartBackRadioButton.Name = "relatedMediaLBCartBackRadioButton";
            relatedMediaLBCartBackRadioButton.Size = new Size(151, 29);
            // relatedMediaLBCartBackRadioButton.TabIndex = 10085;

            relatedMediaLBCartBackRadioButton.Text = "Cart - Back";
            relatedMediaLBCartBackRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBoxBackReconRadioButton.AutoSize = true;
            relatedMediaLBBoxBackReconRadioButton.Font = labelFont;
            relatedMediaLBBoxBackReconRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxBackReconRadioButton.Location = new Point(10, 222);
            relatedMediaLBBoxBackReconRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxBackReconRadioButton.Name = "relatedMediaLBBoxBackReconRadioButton";
            relatedMediaLBBoxBackReconRadioButton.Size = new Size(232, 29);
            // relatedMediaLBBoxBackReconRadioButton.TabIndex = 10082;

            relatedMediaLBBoxBackReconRadioButton.Text = "Box - Back (Recon)";
            relatedMediaLBBoxBackReconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBoxFullRadioButton.AutoSize = true;
            relatedMediaLBBoxFullRadioButton.Font = labelFont;
            relatedMediaLBBoxFullRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxFullRadioButton.Location = new Point(10, 262);
            relatedMediaLBBoxFullRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxFullRadioButton.Name = "relatedMediaLBBoxFullRadioButton";
            relatedMediaLBBoxFullRadioButton.Size = new Size(135, 29);
            // relatedMediaLBBoxFullRadioButton.TabIndex = 10083;

            relatedMediaLBBoxFullRadioButton.Text = "Box - Full";
            relatedMediaLBBoxFullRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBoxSpineRadioButton.AutoSize = true;
            relatedMediaLBBoxSpineRadioButton.Font = labelFont;
            relatedMediaLBBoxSpineRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxSpineRadioButton.Location = new Point(260, 62);
            relatedMediaLBBoxSpineRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxSpineRadioButton.Name = "relatedMediaLBBoxSpineRadioButton";
            relatedMediaLBBoxSpineRadioButton.Size = new Size(155, 29);
            // relatedMediaLBBoxSpineRadioButton.TabIndex = 10081;

            relatedMediaLBBoxSpineRadioButton.Text = "Box - Spine";
            relatedMediaLBBoxSpineRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBClearLogoRadioButton.AutoSize = true;
            relatedMediaLBClearLogoRadioButton.Font = labelFont;
            relatedMediaLBClearLogoRadioButton.ForeColor = foreColor;
            relatedMediaLBClearLogoRadioButton.Location = new Point(260, 182);
            relatedMediaLBClearLogoRadioButton.Margin = btnPanelMargin;
            relatedMediaLBClearLogoRadioButton.Name = "relatedMediaLBClearLogoRadioButton";
            relatedMediaLBClearLogoRadioButton.Size = new Size(144, 29);
            // relatedMediaLBClearLogoRadioButton.TabIndex = 10078;

            relatedMediaLBClearLogoRadioButton.Text = "Clear Logo";
            relatedMediaLBClearLogoRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBannerRadioButton.AutoSize = true;
            relatedMediaLBBannerRadioButton.Font = labelFont;
            relatedMediaLBBannerRadioButton.ForeColor = foreColor;
            relatedMediaLBBannerRadioButton.Location = new Point(260, 102);
            relatedMediaLBBannerRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBannerRadioButton.Name = "relatedMediaLBBannerRadioButton";
            relatedMediaLBBannerRadioButton.Size = new Size(110, 29);
            // relatedMediaLBBannerRadioButton.TabIndex = 10080;

            relatedMediaLBBannerRadioButton.Text = "Banner";
            relatedMediaLBBannerRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBTitleScreenRadioButton.AutoSize = true;
            relatedMediaLBTitleScreenRadioButton.Font = labelFont;
            relatedMediaLBTitleScreenRadioButton.ForeColor = foreColor;
            relatedMediaLBTitleScreenRadioButton.Location = new Point(260, 142);
            relatedMediaLBTitleScreenRadioButton.Margin = btnPanelMargin;
            relatedMediaLBTitleScreenRadioButton.Name = "relatedMediaLBTitleScreenRadioButton";
            relatedMediaLBTitleScreenRadioButton.Size = new Size(158, 29);
            // relatedMediaLBTitleScreenRadioButton.TabIndex = 10079;

            relatedMediaLBTitleScreenRadioButton.Text = "Title Screen";
            relatedMediaLBTitleScreenRadioButton.UseVisualStyleBackColor = true;
            relatedMediaSetLaunchBoxPathButton.BackColor = btnBackColor;
            relatedMediaSetLaunchBoxPathButton.FlatAppearance.BorderColor = Color.Black;
            relatedMediaSetLaunchBoxPathButton.FlatStyle = FlatStyle.Flat;
            relatedMediaSetLaunchBoxPathButton.Font = labelFont;
            relatedMediaSetLaunchBoxPathButton.ForeColor = btnForeColor;
            relatedMediaSetLaunchBoxPathButton.Location = new Point(303, 5);
            relatedMediaSetLaunchBoxPathButton.Margin = new Padding(0);
            relatedMediaSetLaunchBoxPathButton.Name = "relatedMediaSetLaunchBoxPathButton";
            relatedMediaSetLaunchBoxPathButton.Size = new Size(112, 42);
            // relatedMediaSetLaunchBoxPathButton.TabIndex = 10077;

            relatedMediaSetLaunchBoxPathButton.Text = "Set...";
            relatedMediaSetLaunchBoxPathButton.UseVisualStyleBackColor = false;
            relatedMediaLBBoxFrontReconRadioButton.AutoSize = true;
            relatedMediaLBBoxFrontReconRadioButton.Font = labelFont;
            relatedMediaLBBoxFrontReconRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxFrontReconRadioButton.Location = new Point(10, 182);
            relatedMediaLBBoxFrontReconRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxFrontReconRadioButton.Name = "relatedMediaLBBoxFrontReconRadioButton";
            relatedMediaLBBoxFrontReconRadioButton.Size = new Size(238, 29);
            // relatedMediaLBBoxFrontReconRadioButton.TabIndex = 10075;

            relatedMediaLBBoxFrontReconRadioButton.Text = "Box - Front (Recon)";
            relatedMediaLBBoxFrontReconRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBoxFrontRadioButton.AutoSize = true;
            relatedMediaLBBoxFrontRadioButton.Font = labelFont;
            relatedMediaLBBoxFrontRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxFrontRadioButton.Location = new Point(10, 62);
            relatedMediaLBBoxFrontRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxFrontRadioButton.Name = "relatedMediaLBBoxFrontRadioButton";
            relatedMediaLBBoxFrontRadioButton.Size = new Size(152, 29);
            // relatedMediaLBBoxFrontRadioButton.TabIndex = 10072;

            relatedMediaLBBoxFrontRadioButton.Text = "Box - Front";
            relatedMediaLBBoxFrontRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBoxBackRadioButton.AutoSize = true;
            relatedMediaLBBoxBackRadioButton.Font = labelFont;
            relatedMediaLBBoxBackRadioButton.ForeColor = foreColor;
            relatedMediaLBBoxBackRadioButton.Location = new Point(10, 102);
            relatedMediaLBBoxBackRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBoxBackRadioButton.Name = "relatedMediaLBBoxBackRadioButton";
            relatedMediaLBBoxBackRadioButton.Size = new Size(146, 29);
            // relatedMediaLBBoxBackRadioButton.TabIndex = 10074;

            relatedMediaLBBoxBackRadioButton.Text = "Box - Back";
            relatedMediaLBBoxBackRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBBox3DRadioButton.AutoSize = true;
            relatedMediaLBBox3DRadioButton.Font = labelFont;
            relatedMediaLBBox3DRadioButton.ForeColor = foreColor;
            relatedMediaLBBox3DRadioButton.Location = new Point(10, 142);
            relatedMediaLBBox3DRadioButton.Margin = btnPanelMargin;
            relatedMediaLBBox3DRadioButton.Name = "relatedMediaLBBox3DRadioButton";
            relatedMediaLBBox3DRadioButton.Size = new Size(126, 29);
            // relatedMediaLBBox3DRadioButton.TabIndex = 10073;

            relatedMediaLBBox3DRadioButton.Text = "Box - 3D";
            relatedMediaLBBox3DRadioButton.UseVisualStyleBackColor = true;
            relatedMediaLBLinePictureBox.BackColor = foreColor;
            relatedMediaLBLinePictureBox.Location = new Point(3, 49);
            relatedMediaLBLinePictureBox.Margin = btnPanelMargin;
            relatedMediaLBLinePictureBox.Name = "relatedMediaLBLinePictureBox";
            relatedMediaLBLinePictureBox.Size = new Size(412, 3);
            // relatedMediaLBLinePictureBox.TabIndex = 10071;

            relatedMediaLBLinePictureBox.TabStop = false;
            relatedMediaLBLabel.BackColor = Color.Transparent;
            relatedMediaLBLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            relatedMediaLBLabel.ForeColor = foreColor;
            relatedMediaLBLabel.Location = new Point(4, 5);
            relatedMediaLBLabel.Margin = labelMargin;
            relatedMediaLBLabel.Name = "relatedMediaLBLabel";
            relatedMediaLBLabel.Size = new Size(294, 40);
            // relatedMediaLBLabel.TabIndex = 10063;

            relatedMediaLBLabel.Text = "LaunchBox";
        }

        #endregion
    }
}
