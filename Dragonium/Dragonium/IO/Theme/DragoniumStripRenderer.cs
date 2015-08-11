using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dragonium.IO.Theme
{
    /// <summary>
    /// The custom renderer used for the Dragonium menu strip
    /// </summary>
    public class DragoniumStripRenderer : ToolStripProfessionalRenderer
    {
        /// <summary>
        /// Initialize the renderer with the custom colors
        /// </summary>
        public DragoniumStripRenderer()
            : base(new DragoniumStripColors())
        {
            this.RoundedEdges = false;
        }
    }
}
