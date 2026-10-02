using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker
{
    /// <summary>Abstract class to simplify and shorten subwindow classes</summary>
    public abstract class AbstractForm : Form
    {
        #region Properties

        protected Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        #endregion

        #region Required methods

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await InitializeAsync();
        }

        protected abstract Task InitializeAsync();

        #endregion

        #region JS init

        public void AssignJavaScriptVariables()
        {
            webView21.ExecuteScriptAsync("assignJavaScriptVariables();");
        }

        #endregion

        #region Background

        public void SetWindowBackgroundColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setWindowBackgroundColor(\"{0}\");", value));
        }

        #endregion

        #region Simple Font

        public void SetSimpleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }

        public void SetSimpleFontColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontColor(\"{0}\");", value));
            SetLineColor(value);
        }

        public void SetSimpleFontOutline(string fontOutline, string borderOutline)
        {
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontOutline(\"{0}\");", fontOutline));
            SetLineOutline(borderOutline);
        }

        public void SetSimpleFontOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontOutline(\"{0}\");", value));
        }

        public void SetTitleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            webView21.ExecuteScriptAsync(string.Format("setTitleFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }

        #endregion

        #region Title

        public void SetTitleName(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setTitleName(\"{0}\");", string.IsNullOrEmpty(value.Trim()) ? string.Empty : value.Trim() + ":"));
        }

        public void SetTitleColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setTitleColor(\"{0}\");", value));
        }

        public void SetTitleOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setTitleOutlineColor(\"{0}\");", value));
        }

        #endregion

        #region Description

        public void SetDescriptionFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            webView21.ExecuteScriptAsync(string.Format("setDescriptionFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }

        public void SetDescriptionColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDescriptionColor(\"{0}\");", value));
        }

        public void SetDescriptionOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDescriptionOutlineColor(\"{0}\");", value));
        }

        #endregion

        #region Points

        public void SetPointsFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            webView21.ExecuteScriptAsync(string.Format("setPointsFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }

        public void SetPointsColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setPointsColor(\"{0}\");", value));
        }

        public void SetPointsOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setPointsOutlineColor(\"{0}\");", value));
        }

        #endregion

        #region Line / Outline

        public void SetLineColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setLineColor(\"{0}\");", value));
        }

        public void SetLineOutline(string borderOutline)
        {
            webView21.ExecuteScriptAsync(string.Format("setLineOutlineColor(\"{0}\");", borderOutline));
        }

        #endregion

        #region Border

        public void EnableBorder()
        {
            webView21.ExecuteScriptAsync("enableBorder();");
        }

        public void DisableBorder()
        {
            webView21.ExecuteScriptAsync("disableBorder();");
        }

        public void SetBorderBackgroundColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setBorderBackgroundColor(\"{0}\");", value));
        }

        #endregion

        #region Focus

        public void HideFocus()
        {
            webView21.ExecuteScriptAsync("hideFocus();");
        }

        #endregion
    }
}
