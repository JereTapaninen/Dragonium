using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Dragonium.IO.Theme.Controls
{
    /// <summary>
    /// Handles all the useful WM_Messages
    /// </summary>
    public enum WM_Messages : int
    {
        WM_PAINT = 0xF,
        WM_NCPAINT = 0x85
    }

    public class DragoniumMetroListBox : ListBox
    {
        public BorderStyle BorderStyle
        {
            get
            {
                return System.Windows.Forms.BorderStyle.None;
            }
        }

        /// <summary>
        /// The custom pen used on the borders
        /// </summary>
        private Pen BorderPen { get; set; }

        /// <summary>
        /// Initializes the Dragonium Metro ListBox
        /// </summary>
        public DragoniumMetroListBox()
            : base()
        {
            this.BorderPen = new Pen(this.GetPushedColor(base.BackColor), 1F);
        }
        
        /// <summary>
        /// Custom WndProc WM Message Processor
        /// </summary>
        /// <param name="m">The message</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == (int)WM_Messages.WM_PAINT)
            {
                OnWmPaint();
            }
        }

        /// <summary>
        /// Custom WmPaint wrapper
        /// </summary>
        private void OnWmPaint()
        {
            using (var pG = this.Parent.CreateGraphics())
            {
                var location = this.Location;
                var size = this.Size;

                pG.DrawLine(this.BorderPen, new Point(location.X, location.Y - 2), new Point(location.X + size.Width, location.Y - 2));

                using (var cG = this.CreateGraphics())
                {
                    cG.DrawLine(new Pen(this.BorderPen.Color, 2F), new Point(0, this.Size.Height - 1), new Point(this.Size.Width, this.Size.Height - 1));
                }
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

            var newRed = (red < 128) ? red + 50 : red - 50;
            var newGreen = (green < 128) ? green + 50 : green - 50;
            var newBlue = (blue < 128) ? blue + 50 : blue - 50;

            return Color.FromArgb(newRed, newGreen, newBlue);
        }
    }
}
