using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Retro_Achievement_Tracker.Forms
{
    public partial class RecentUnlocksWindow : AbstractForm
    {
        public RecentUnlocksWindow()
        {
            InitializeComponent();
        }
        protected override async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.SetVirtualHostNameToFolderMapping("appassets.tracker", @"images", CoreWebView2HostResourceAccessKind.DenyCors);
            webView21.NavigateToString(Resources.recent_achievements_window);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            RecentUnlocksController.Instance.IsOpen = false;
        }
        public void SetDateFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            webView21.ExecuteScriptAsync(string.Format("setDateFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetDateColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDateColor(\"{0}\");", value));
        }
        public void SetDateOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDateOutlineColor(\"{0}\");", value));
        }
        public void StartScrolling()
        {
            webView21.ExecuteScriptAsync("startScrolling();");
        }
        public void StopScrolling()
        {
            webView21.ExecuteScriptAsync("stopScrolling();");
        }
        public void ShowRecentAchievements()
        {
            webView21.ExecuteScriptAsync("showRecentAchievements();");
        }
        public void HideRecentAchievements()
        {
            webView21.ExecuteScriptAsync("hideRecentAchievements();");
        }
        public void ClearRecentAchievements()
        {
            webView21.ExecuteScriptAsync("clearRecentAchievements();");
        }
        public void AddAchievements(List<Achievement> achievements)
        {
            for (int i = achievements.Count - 1; i >= 0; i--)
            {
                webView21.ExecuteScriptAsync($"addAchievement({JsonConvert.SerializeObject(achievements[i])});");
            }
        }
        public void SetClientSize()
        {
            Invoke(new Action(() =>
            {
                ClientSize = new Size(511, 600);
            }));
        }
        private void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            RecentUnlocksController.Instance.IsOpen = true;
            RecentUnlocksController.Instance.SetAchievements();
        }
    }
}