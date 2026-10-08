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
            BackColor = Color.FromArgb(22, 22, 22);
        }

        #endregion

        #region Methods

        public override void ToggleTabElements(bool enable) { }

        #endregion
    }
}
