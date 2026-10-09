using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker.Tabs
{
    /// <summary>Abstract class for simplifying tabs</summary>
    public abstract class AbstractTab : TabPage
    {
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