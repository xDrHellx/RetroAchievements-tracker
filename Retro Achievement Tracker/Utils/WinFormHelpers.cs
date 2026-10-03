using System.Drawing;
using Microsoft.Web.WebView2.WinForms;

namespace Retro_Achievement_Tracker.Utils
{
    public class WinFormHelpers
    {
        #region Standard elements

        /// <summary>Simplified method for creating a WebView2 instance</summary>
        /// <param name="name">Name</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <returns><c>WebView2</c>Instance</returns>
        public static WebView2 CreateWebView2(string name, Point position, Size size)
        {
            WebView2 wv2 = new WebView2
            {
                Name = name,
                Location = position,
                Size = size,
                AllowExternalDrop = true,
                DefaultBackgroundColor = Color.White,
                ZoomFactor = 1D
            };

            return wv2;
        }

        #endregion
    }
}
