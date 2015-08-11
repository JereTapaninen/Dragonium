using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dragonium.IO.Theme;

namespace Dragonium
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// The about form that opens once the user clicks the about tool strip menu item
        /// </summary>
        public Form AboutForm { get; private set; }

        /// <summary>
        /// Initializes the main form
        /// </summary>
        /// <param name="version">The user-selected program version</param>
        public frmMain(ProgramVersion version)
        {
            InitializeComponent();

            // Finally, initialize the program
            Initialize(version);
        }

        /// <summary>
        /// Event that fires after the Dragonium form has loaded
        /// </summary>
        /// <param name="sender">The form</param>
        /// <param name="e">The event arguments</param>
        private void frmMain_Load(object sender, EventArgs e)
        { }

        /// <summary>
        /// Initializes stuff.
        /// </summary>
        /// <param name="version"></param>
        private void Initialize(ProgramVersion version)
        {
            this.AboutForm = new frmAbout();

            // Finally, initialize the UI
            InitializeUI(version);
        }

        /// <summary>
        /// Initializes the Dragonium UI
        /// </summary>
        private void InitializeUI(ProgramVersion version)
        {
            if (version == ProgramVersion.Metro)
            {
                var stripRenderer = new DragoniumStripRenderer();

                this.menuMain.Renderer = stripRenderer;
                this.statusMain.Renderer = stripRenderer;
            }
            else if (version == ProgramVersion.OldFashioned)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is MenuStrip || control is ToolStrip || control is StatusStrip)
                        (control as ToolStrip).RenderMode = ToolStripRenderMode.System;
                }
            }
        }

        /// <summary>
        /// Event that fires when the 'About' tool strip menu item has been clicked
        /// </summary>
        /// <param name="sender">The about tool strip menu item</param>
        /// <param name="e">The event arguments</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AboutForm.Visible)
                AboutForm.Show();
        }
    }
}
