using Microsoft.Web.WebView2.Core;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Properties;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Retro_Achievement_Tracker.Forms
{
    public partial class RelatedMediaWindow : AbstractForm
    {
        public RelatedMediaWindow()
        {
            InitializeComponent();
        }
        protected override async Task InitializeAsync()
        {
            string path = RelatedMediaController.Instance.LaunchBoxFilePath.Replace("\\", "/");
            if (!File.Exists(path))
            {
                MessageBox.Show("The selected folder doesn't exist. Please choose another.");
                Close();
            }
            else
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.SetVirtualHostNameToFolderMapping("appassets.tracker", path, CoreWebView2HostResourceAccessKind.DenyCors);
                webView21.NavigateToString(Resources.related_media_window);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            RelatedMediaController.Instance.IsOpen = false;
        }
        public void SetImage(string imageUri)
        {
            webView21.ExecuteScriptAsync($"setImage(\"{imageUri}\");");
        }
        public void HideImage()
        {
            webView21.ExecuteScriptAsync("hideImage();");
        }
        public void ShowImage()
        {
            webView21.ExecuteScriptAsync("showImage();");
        }
        public void SetClientSize()
        {
            Invoke(new Action(() =>
            {
                ClientSize = new System.Drawing.Size(640, 480);
            }));
        }
        void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                RelatedMediaController.Instance.IsOpen = true;
                RelatedMediaController.Instance.SetAllSettings(true);
            }
        }
    }
}
