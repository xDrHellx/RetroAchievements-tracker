using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using Retro_Achievement_Tracker.Utils;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Retro_Achievement_Tracker.Forms
{
    partial class RecentUnlocksWindow
    {
        /// <summary>Required designer variable.</summary>
        private IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RecentUnlocksWindow));
            this.webView21 = WinFormHelpers.CreateWebView2("webView21", new Point(0, 0), new Size(1920, 1080));
            ((ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.NavigationCompleted);
            // 
            // RecentAchievementsWindow
            // 
            this.ClientSize = new Size(120, 0);
            this.Controls.Add(this.webView21);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecentAchievementsWindow";
            this.Text = "RA Tracker - Recent Unlocks";
            ((ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}