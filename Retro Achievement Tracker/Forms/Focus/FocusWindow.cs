using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Retro_Achievement_Tracker.Forms
{
    public partial class FocusWindow : AbstractForm
    {
        public FocusWindow()
        {
            InitializeComponent();
        }
        protected override async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);

            webView21.CoreWebView2.SetVirtualHostNameToFolderMapping("appassets.tracker", @"images", CoreWebView2HostResourceAccessKind.DenyCors);
            webView21.NavigateToString(Resources.focus_window);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            FocusController.Instance.IsOpen = false;
        }

        public async void SetFocus(Achievement achievement)
        {
            if (achievement != null)
            {
                await webView21.ExecuteScriptAsync("fadeOutFocus();");

                await Task.Delay(200);

                await webView21.ExecuteScriptAsync($"addAchievement({JsonConvert.SerializeObject(achievement)});");

                await Task.Delay(200);

                await webView21.ExecuteScriptAsync("fadeInFocus();");
                await webView21.ExecuteScriptAsync("fadeInAchievementDescription();");
            }
            else
            {
                HideFocus();
            }
        }
        public async void SetFocus(GameInfo gameInfo)
        {
            await webView21.ExecuteScriptAsync("fadeOutFocus();");

            await Task.Delay(200);

            await webView21.ExecuteScriptAsync($"addGameInfo({JsonConvert.SerializeObject(gameInfo)});");

            await Task.Delay(200);

            await webView21.ExecuteScriptAsync("fadeInFocus();");
            await webView21.ExecuteScriptAsync("fadeInMasteryDescription();");
        }
        public void SetClientSize()
        {
            Invoke(new Action(() =>
            {
                ClientSize = new Size(700, 165);
            }));
        }
        void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            FocusController.Instance.IsOpen = true;
            FocusController.Instance.UpdateFocus();
        }
    }
}
