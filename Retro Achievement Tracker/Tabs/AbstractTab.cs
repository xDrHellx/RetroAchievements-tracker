using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker.Tabs
{
    /// <summary>Abstract class for simplifying tabs</summary>
    public abstract class AbstractTab : TabPage
    {
        protected Font labelFont = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
            numUpDownFont = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
            windowSettingsFont = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        protected Padding labelMargin = new Padding(4, 0, 4, 0),
            btnPanelMargin = new Padding(4, 5, 4, 5);
        protected Color foreColor = Color.FromArgb(44, 151, 250),
            btnBackColor = Color.FromArgb(22, 22, 22),
            btnForeColor = Color.FromArgb(204, 153, 0),
            numUpDownBackColor = Color.FromArgb(42, 42, 42),
            panelBackColor = Color.FromArgb(32, 32, 32),
            lightGrayColor = Color.FromArgb(200, 200, 200);

        /// <summary>Toggle the tab elements</summary>
        /// <param name="enable">True / False to enable / disable elements</param>
        public abstract void ToggleTabElements(bool enable);

        /// <summary>Initialize tab elements</summary>
        public virtual void InitElements() { }

        protected void SetFontFamilyBox(ComboBox comboBox, FontFamily fontFamily)
        {
            comboBox.Items.Clear();

            FontFamily[] familyArray = FontFamily.Families.ToArray();
            foreach (FontFamily fontFamilyEntity in familyArray)
            {
                comboBox.Items.Add(fontFamilyEntity.Name);
            }

            comboBox.SelectedIndex = Array.FindIndex(familyArray, row => row.Name == fontFamily.Name);
        }
    }
}