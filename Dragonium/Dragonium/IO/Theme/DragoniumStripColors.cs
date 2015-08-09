using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;

namespace Dragonium.IO.Theme
{
    /// <summary>
    /// Handles the colors of the Dragonium Menu Strip
    /// </summary>
    public class DragoniumStripColors : ProfessionalColorTable
    {
        /// <summary>
        /// A fully transparent color
        /// </summary>
        public Color Transparent 
        {
            get 
            {
                return Color.FromArgb(0, 0, 0, 0);
            }
        }

        /// <summary>
        /// The default metro window color. 
        /// If the value isn't found from the registry, defaults to WHITE
        /// </summary>
        public Color MetroWindowDefaultColor
        {
            get
            {
                var value = Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\Colors\", "Window", "255 255 255").ToString();
                var values = value.Split(' ');
                var parsedColor = Color.FromArgb(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));

                return parsedColor;
            }
        }

        /* Menu Strip Begin */

        public override Color MenuItemSelected
        {
            get
            {
                return base.MenuItemSelected;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return this.GetPushedColor(this.MetroWindowDefaultColor);
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return this.GetPushedColor(this.MetroWindowDefaultColor);
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Transparent;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return this.MetroWindowDefaultColor;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return this.MetroWindowDefaultColor;;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Transparent;
            }
        }

        /* Status Strip Begin */

        public override Color StatusStripGradientBegin
        {
            get
            {
                return this.MetroWindowDefaultColor;
            }
        }

        public override Color StatusStripGradientEnd
        {
            get
            {
                return this.MetroWindowDefaultColor;
            }
        }

        /// <summary>
        /// Returns a "pushed" color with the help of the defaultColor parameter
        /// </summary>
        /// <param name="defaultColor">The default color (f.ex. the menustrip background color)</param>
        /// <returns>The pushed color for controls on top of a surface that has the background color of defaultColor</returns>
        private Color GetPushedColor(Color defaultColor)
        {
            var red = defaultColor.R;
            var green = defaultColor.G;
            var blue = defaultColor.B;

            var newRed = (red < 128) ? red + 25 : red - 25;
            var newGreen = (green < 128) ? green + 25 : green - 25;
            var newBlue = (blue < 128) ? blue + 25 : blue - 25;

            return Color.FromArgb(newRed, newGreen, newBlue);
        }
    }
}
