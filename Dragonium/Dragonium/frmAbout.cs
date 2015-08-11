using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dragonium
{
    /// <summary>
    /// Displays all the needed information about DRAGONIUM
    /// </summary>
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Initializes the DRAGONIUM about form
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that fires when the control is about to close
        /// </summary>
        /// <param name="sender">The about form</param>
        /// <param name="e">The closing event arguments</param>
        private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void lnkIcons8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/");
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JereTapaninen/Dragonium");
        }
    }
}
