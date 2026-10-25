using System.Data;
using System.Drawing;
using System.Windows.Forms;
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

        /// <summary>Simplified method for creating a group box</summary>
        /// <param name="name">Group name</param>
        /// <param name="text">Group text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <returns><c>GroupBox</c>Instance</returns>
        public static GroupBox CreateGroupBox(string name, string text, Point position, Size size, Control control = null)
        {
            GroupBox groupBox = new GroupBox()
            {
                Name = name,
                Text = text,
                Location = position,
                Size = size,
                TabIndex = 1
            };

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(groupBox);
            return groupBox;
        }

        /// <summary>Simplified method for creating a label</summary>
        /// <param name="name">Label name</param>
        /// <param name="text">Label text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="colorHex">Set the background color for the label</param>
        /// <param name="margin">Margin (by default Padding(0, 3, 0, 3), the default value in Visual Studio)</param>
        /// <param name="textAlignment">Text alignment, by default "MiddleCenter" (see System.Drawing.ContentAlignment for possible values)</param>
        /// <returns><c>Label</c>Instance</returns>
        public static Label CreateLabel(string name, string text, Point position, Size size, Control control = null, string colorHex = "", Padding margin = new Padding(), string textAlignment = "MiddleCenter")
        {
            Label label = new Label()
            {
                Name = name,
                Text = text,
                Location = position,
                Size = size,
                TabIndex = 2,
                TextAlign = GetTextAlignment(textAlignment)
            };

            if (colorHex != "")
            {
                label.BackColor = ColorTranslator.FromHtml(colorHex);
            }

            // If no specific margin is passed, set defaults from Visual Studio
            if (margin.All == 0)
            {
                margin.Top = 3;
                margin.Left = 3;
            }

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(label);
            return label;
        }

        /// <summary>Simplified method for creating a separator via a label</summary>
        /// <param name="name">Label name</param>
        /// <param name="position">Position</param>
        /// <param name="length">Length (in pixels)</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="vertical">True if the separator should be vertical (False by default)</param>
        /// <returns><c>Label</c>Instance</returns>
        public static Label CreateSeparator(string name, Point position, int length, Control control = null, bool vertical = false)
        {
            Label separator = new Label()
            {
                Name = name,
                Location = position,
                Size = vertical == false ? new Size(length, 1) : new Size(1, length),
                TabIndex = 2,
                BorderStyle = BorderStyle.Fixed3D
            };

            control?.Controls.Add(separator);
            return separator;
        }

        /// <summary>Simplified method for creating a button</summary>
        /// <param name="name">Label name</param>
        /// <param name="text">Label text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="colorHex">Set the background color for the label</param>
        /// <param name="margin">Margin (by default Padding(0, 3, 0, 3), the default value in Visual Studio)</param>
        /// <param name="textAlignment">Text alignment, by default "MiddleCenter" (see System.Drawing.ContentAlignment for possible values)</param>
        /// <param name="enabled">True if it should be enabled (True by default)</param>
        /// <returns><c>Button</c>Instance</returns>
        public static Button CreateButton(string name, string text, Point position, Size size, Control control = null, string colorHex = "", Padding margin = new Padding(), string textAlignment = "MiddleCenter", bool enabled = true)
        {
            Button btn = new Button()
            {
                Name = name,
                Text = text,
                Location = position,
                Size = size,
                TabIndex = 2,
                Enabled = enabled,
                TextAlign = GetTextAlignment(textAlignment)
            };

            if (colorHex != "")
            {
                btn.BackColor = ColorTranslator.FromHtml(colorHex);
            }

            // If no specific margin is passed, set defaults from Visual Studio
            if (margin.All == 0)
            {
                margin.Top = 3;
                margin.Left = 3;
            }

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(btn);
            return btn;
        }

        /// <summary>Simplified method for creating a numeric input field</summary>
        /// <param name="name">Field name</param>
        /// <param name="defaultValue">Default value</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="minValue">Minimum settable value</param>
        /// <param name="maxValue">Maximum settable value</param>
        /// <param name="nbDecimals">Number of decimals (0 by default)</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="colorHex">Set the background color for the label</param>
        /// <param name="margin">Margin (by default Padding(0, 3, 0, 3), the default value in Visual Studio)</param>
        /// <param name="valueAlignment">Value alignment, by default "Left" (see HorizontalAlignment for possible values)</param>
        /// <param name="enabled">True if it should be enabled (True by default)</param>
        /// <returns><c>NumericUpDown</c>Instance</returns>
        public static NumericUpDown CreateNumericUpDown(string name, decimal defaultValue, Point position, Size size, decimal minValue = 0, decimal maxValue = 99, int nbDecimals = 0, Control control = null, string colorHex = "", Padding margin = new Padding(), string valueAlignment = "Left", bool enabled = true)
        {
            NumericUpDown numUpDown = new NumericUpDown()
            {
                Name = name,
                Minimum = minValue,
                Maximum = maxValue,
                Value = defaultValue,
                Location = position,
                Size = size,
                TabIndex = 2,
                Increment = (decimal)(maxValue > 500 ? 10 : (nbDecimals == 2 ? 0.05 : (nbDecimals == 1 ? 0.5 : 1))),
                DecimalPlaces = nbDecimals,
                Enabled = enabled
            };

            switch (valueAlignment)
            {
                case "Right": numUpDown.TextAlign = HorizontalAlignment.Right; break;
                case "Center": numUpDown.TextAlign = HorizontalAlignment.Center; break;
                default: numUpDown.TextAlign = HorizontalAlignment.Left; break;
            }

            if (colorHex != "")
            {
                numUpDown.BackColor = ColorTranslator.FromHtml(colorHex);
            }

            // If no specific margin is passed, set defaults from Visual Studio
            if (margin.All == 0)
            {
                margin.Top = 3;
                margin.Left = 3;
            }

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(numUpDown);
            return numUpDown;
        }

        /// <summary>Simplified method for creating a CheckBox</summary>
        /// <param name="name">Field name</param>
        /// <param name="text">Field text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="isCheckedByDefault">Set to true if the CheckBox has to be checked when initiated</param>
        /// <param name="checkboxOnRight">Set to true if the Checkbox has to be on the right of the text</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <returns><c>CheckBox</c>Instance</returns>
        public static CheckBox CreateCheckBox(string name, string text, Point position, Size size, bool isCheckedByDefault = false, bool checkboxOnRight = false, Control control = null)
        {
            CheckBox checkBox = new CheckBox()
            {
                Name = name,
                Text = text,
                Checked = isCheckedByDefault,
                RightToLeft = checkboxOnRight == true ? RightToLeft.Yes : RightToLeft.No,
                Location = position,
                Size = size,
                TabIndex = 1,
                AutoSize = false
            };

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(checkBox);
            return checkBox;
        }

        /// <summary>Simplified method for creating a tooltip</summary>
        /// <returns><c>ToolTip<c/>Instance</returns>
        public static ToolTip CreateToolTip()
        {
            return new ToolTip()
            {
                ShowAlways = true,      // Always shows tooltip even if window isn't focused
                AutoPopDelay = 5000,    // Set tooltip delays
                InitialDelay = 1000,
                ReshowDelay = 500
            };
        }

        /// <summary>Simplified method for creating a data grid view</summary>
        /// <param name="name">Group name</param>
        /// <param name="data">Data to show</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="dockStyle">DockStyle (by default None)</param>
        /// <returns><c>DataGridView</c>Instance</returns>
        public static DataGridView CreateDataGridView(string name, DataTable data, Point position, Size size, Control control = null, DockStyle dockStyle = DockStyle.None)
        {
            DataGridView gridView = new DataGridView()
            {
                Name = name,
                DataSource = data,
                Location = position,
                Size = size,
                TabIndex = 1,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = dockStyle,
                EnableHeadersVisualStyles = false,
                ReadOnly = true
            };

            // Set a specific color for the header
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(gridView);
            return gridView;
        }

        /// <summary>Simplified method for creating a dropdown list</summary>
        /// <param name="name">Dropdown name</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="dropDownWidth">Dropdown Width (in pixels, if not specified will take use the element's width as reference)</param>
        /// <param name="dropDownHeight">Dropdown Height (in pixels, if not specified will take use the element's height as reference)</param>
        /// <param name="visibleOptions">Amount of options visible without needing to scroll (will take priority over dropDownHeight parameters if specified)</param>
        /// <param name="enabled">True if it should be enabled (True by default)</param>
        /// <returns><c>ComboBox</c>Instance</returns>
        public static ComboBox CreateDropDownList(string name, Point position, Size size, Control control = null, int dropDownWidth = 0, int dropDownHeight = 0, int visibleOptions = 0, bool enabled = true)
        {
            ComboBox dropDownList = new ComboBox()
            {
                Name = name,
                Location = position,
                Size = size,
                DropDownStyle = ComboBoxStyle.DropDownList,
                TabIndex = 1,
                // If DropDownWidth was specified, use it, otherwise use the element's width
                DropDownWidth = dropDownWidth > 0 ? dropDownWidth : size.Width,
                Enabled = enabled
            };

            /**
             * If the number of options to show without needed to scroll is specified, use it
             * Otherwise handle the DropDownHeight the same way as the DropDownWidth
             */
            if (visibleOptions > 0)
            {
                dropDownList.DropDownHeight = (size.Height - 4) * visibleOptions;
            }
            else
            {
                dropDownList.DropDownHeight = dropDownHeight > 0 ? dropDownHeight : size.Height;
            }

            // If a Control instance is passed, add the generated element to it
            control?.Controls.Add(dropDownList);
            return dropDownList;
        }

        /// <summary>Simplified method for creating a Panel</summary>
        /// <param name="name">Panel name</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="autoScroll">True if AutoScroll should be active (True by default)</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="enabled">True if it should be enabled (True by default)</param>
        /// <returns><c>Panel</c>Instance</returns>
        public static Panel CreatePanel(string name, Point position, Size size, Control control = null, bool autoScroll = true, bool enabled = true)
        {
            Panel panel = new Panel()
            {
                Name = name,
                Location = position,
                Size = size,
                TabIndex = 1,
                AutoScroll = autoScroll,
                Enabled = enabled
            };

            control?.Controls.Add(panel);
            return panel;
        }

        /// <summary>Simplified method for creating a TextBox</summary>
        /// <param name="name">TextBox name</param>
        /// <param name="text">TextBox text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="multiLine">True if text added should take multiple lines (True by default)</param>
        /// <param name="readOnly">True if text should be readonly (True by default)</param>
        /// <returns><c>TextBox</c>Instance</returns>
        public static TextBox CreateTextBox(string name, string text, Point position, Size size, Control control = null, bool multiLine = true, bool readOnly = true)
        {
            TextBox textBox = new TextBox()
            {
                Name = name,
                Location = position,
                Size = size,
                TabIndex = 1,
                Text = text,
                Multiline = multiLine,
                ReadOnly = readOnly
            };

            control?.Controls.Add(textBox);
            return textBox;
        }

        /// <summary>Simplified method for creating a RadioButton</summary>
        /// <param name="name">RadioButton name</param>
        /// <param name="text">RadioButton text</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="tag">Tag (used to store a value if necessary)</param>
        /// <param name="isCheckedByDefault">Set to true if the CheckBox has to be checked when initiated</param>
        /// <returns><c>RadioButton</c>Instance</returns>
        public static RadioButton CreateRadioButton(string name, string text, Point position, Size size, Control control = null, object tag = null, bool isCheckedByDefault = false)
        {
            RadioButton radioBtn = new RadioButton()
            {
                Name = name,
                Text = text,
                Checked = isCheckedByDefault,
                Tag = tag,
                Location = position,
                Size = size,
                TabIndex = 1,
                AutoSize = false
            };

            control?.Controls.Add(radioBtn);
            return radioBtn;
        }

        /// <summary>Simplified method for creating a TabControl</summary>
        /// <param name="name">TabControl name</param>
        /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <param name="selectedIndex">Selected index at start (by default none)</param>
        /// <returns><c>TabControl</c>Instance</returns>
        public static TabControl CreateTabControl(string name, Point position, Size size, Control control = null, int selectedIndex = -1)
        {
            TabControl tabCtrl = new TabControl()
            {
                Name = name,
                Location = position,
                Size = size,
                TabIndex = 1,
                SelectedIndex = selectedIndex
            };

            control?.Controls.Add(tabCtrl);
            return tabCtrl;
        }

        /// <summary>Simplified method for creating a TabPage</summary>
        /// <param name="name">TabPage name</param>
        /// <param name="text">TabPage text</param>
        // /// <param name="position">Position</param>
        /// <param name="size">Size</param>
        /// <param name="tabControl">TabControl instance if the element is to be attached to it directly</param>
        /// <returns><c>TabPage</c>Instance</returns>
        public static TabPage CreateTabPage(string name, string text, /*Point position,*/ Size size, TabControl tabControl = null)
        {
            TabPage tabPage = new TabPage()
            {
                Name = name,
                Text = text,
                // Location = position,
                Size = size
                // TabIndex = 2
            };

            tabControl?.Controls.Add(tabPage);
            return tabPage;
        }

        /// <summary>Simplified method for creating a MenuStrip</summary>
        /// <param name="name">Name</param>
        /// <param name="text">Text</param>
        /// <param name="bgColorHex">Background color (hex code) (if none, defaults to white for visibility)</param>
        /// <param name="control">Control instance if the element is to be attached to it directly</param>
        /// <returns><c>MenuStrip</c>Instance</returns>
        public static MenuStrip CreateMenuStrip(string name, string text, string bgColorHex = "", Control control = null)
        {
            MenuStrip menu = new MenuStrip()
            {
                Name = name,
                Text = text,
                TabIndex = 1,
                BackColor = bgColorHex != "" ? ColorTranslator.FromHtml(bgColorHex) : Color.White,
                ShowItemToolTips = true
            };

            control?.Controls.Add(menu);
            return menu;
        }

        /// <summary>Simplified method for creating a ToolStripMenuItem</summary>
        /// <param name="name">Name</param>
        /// <param name="text">Text</param>
        /// <param name="bgColorHex">Background color (hex code) (if none, defaults to white for visibility)</param>
        /// <param name="toolTipText">Text on hover / tooltip</param>
        /// <param name="menuStrip">MenuStrip instance if the element is to be attached to it directly</param>
        /// <param name="ToolStripMenuItem">ToolStripMenuItem instance if the element is to be attached to it directly</param>
        /// <returns><c>ToolStripMenuItem</c>Instance</returns>
        public static ToolStripMenuItem CreateToolStripMenuItem(string name, string text, string bgColorHex = "", string toolTipText = "", MenuStrip menuStrip = null, ToolStripMenuItem menuItem = null)
        {
            ToolStripMenuItem item = new ToolStripMenuItem()
            {
                Name = name,
                Text = text,
                AutoSize = true,
                BackColor = bgColorHex != "" ? ColorTranslator.FromHtml(bgColorHex) : Color.White,
                ToolTipText = toolTipText
            };

            menuStrip?.Items.Add(item);
            menuItem?.DropDownItems.Add(item);
            return item;
        }

        /// <summary>Simplified method for creating a PictureBox</summary>
        /// <param name="name">PictureBox name</param>
        /// <param name="image">PictureBox image</param>
        /// <param name="position">Position</param>
        /// <param name="control"></param>
        /// <param name="sizeMode">SizeMode, by default "AutoSize" (see System.Windows.Forms.PictureBoxSizeMode for possible values)</param>
        /// <param name="width">Width if SizeMode is not set to "AutoSize"</param>
        /// <param name="height">Height if SizeMode is not set to "AutoSize"</param>
        /// <param name="bgColorHex">Background color (hex code)</param>
        /// <returns><c>PictureBox</c>Instance</returns>
        public static PictureBox CreatePictureBox(string name, Image image, Point position, Control control = null, string sizeMode = "AutoSize", int width = 0, int height = 0, string bgColorHex = "")
        {
            PictureBox pictureBox = new PictureBox()
            {
                Name = name,
                Image = image,
                SizeMode = GetSizeMode(sizeMode),
                Location = position,
                AutoSize = false
            };

            if (sizeMode != "AutoSize")
            {
                pictureBox.Size = new Size(width, height);
            }

            if (bgColorHex != "")
            {
                pictureBox.BackColor = ColorTranslator.FromHtml(bgColorHex);
            }

            control?.Controls.Add(pictureBox);
            return pictureBox;
        }

        #endregion

        #region Misc

        /// <summary>Get the direction for an animation</summary>
        /// <param name="animationName">Name of the animation</param>
        /// <returns><c>AnimationDirection</c></returns>
        public static AnimationDirection GetAnimationDirection(string animationName)
        {
            switch (animationName)
            {
                case "DOWN":
                    return AnimationDirection.DOWN;
                case "LEFT":
                    return AnimationDirection.LEFT;
                case "RIGHT":
                    return AnimationDirection.RIGHT;
                case "UP":
                    return AnimationDirection.UP;
                default:
                    return AnimationDirection.STATIC;
            }
        }

        /// <summary>Get the corresponding text alignment based on a string</summary>
        /// <param name="value">Text alignment string</param>
        /// <returns><c>System.Drawing.ContentAlignment</c>Text alignment object</returns>
        static ContentAlignment GetTextAlignment(string value)
        {
            switch (value)
            {
                case "BottomCenter": return ContentAlignment.BottomCenter;
                case "BottomLeft": return ContentAlignment.BottomLeft;
                case "BottomRight": return ContentAlignment.BottomRight;
                case "MiddleLeft": return ContentAlignment.MiddleLeft;
                case "MiddleRight": return ContentAlignment.MiddleRight;
                case "TopCenter": return ContentAlignment.TopCenter;
                case "TopLeft": return ContentAlignment.TopLeft;
                case "TopRight": return ContentAlignment.TopRight;
                default: return ContentAlignment.MiddleCenter;
            }
        }

        /// <summary>Get the corresponding PictureBoxSizeMode based on a string</summary>
        /// <param name="value">SizeMode string</param>
        /// <returns><c>System.Windows.Forms.PictureBoxSizeMode</c>SizeMode object</returns>
        static PictureBoxSizeMode GetSizeMode(string value)
        {
            switch (value)
            {
                case "CenterImage": return PictureBoxSizeMode.CenterImage;
                case "Normal": return PictureBoxSizeMode.Normal;
                case "StretchImage": return PictureBoxSizeMode.StretchImage;
                case "Zoom": return PictureBoxSizeMode.Zoom;
                default: return PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>Escape ampersand characters within text</summary>
        /// <param name="text">Text</param>
        /// <returns><c>string</c>Escaped text</returns>
        public static string EscapeAmpersand(string text)
        {
            return text.Replace("&", "&&");
        }

        #endregion
    }
}
