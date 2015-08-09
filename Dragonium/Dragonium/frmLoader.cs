using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Dragonium
{
    /// <summary>
    /// The form that appears foremost when the program is launched
    /// Handles loading all the forms etc.
    /// </summary>
    public partial class frmLoader : MetroFramework.Forms.MetroForm
    {
        public frmSelectVersion SelectVersionForm { get; private set; }

        public bool IsAllowedToClose { get; private set; }

        /// <summary>
        /// Initializes the loading form
        /// </summary>
        public frmLoader()
        {
            InitializeComponent();

            // Initialize the loading form
        }

        /// <summary>
        /// Initializes the loading form
        /// </summary>
        private void Initialize()
        {
            this.IsAllowedToClose = false;
        }

        /// <summary>
        /// Event that fires when the loading form is being closed
        /// </summary>
        /// <param name="sender">The loading form</param>
        /// <param name="e">The closing event arguments</param>
        private void frmLoader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsAllowedToClose)
                e.Cancel = true;
        }

        /// <summary>
        /// Event that fires when the loading form has loaded
        /// </summary>
        /// <param name="sender">The loading form</param>
        /// <param name="e">The event arguments</param>
        private void frmLoader_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();

            Application.DoEvents();

            var mainForm = new Form();

            var selectVersionThread = new Thread(() =>
            {
                this.SelectVersionForm = new frmSelectVersion();
                this.SelectVersionForm.Show();
                this.SelectVersionForm.Activate();

                while (this.SelectVersionForm.SelectedVersion == ProgramVersion.NotSelected && this.SelectVersionForm.Visible)
                {
                    Application.DoEvents();
                    Thread.Sleep(1);
                }
            });

            selectVersionThread.Start();
            selectVersionThread.Join();

            var loadThread = new Thread(() =>
            {
                var version = this.SelectVersionForm.SelectedVersion;

                switch (version)
                {
                    case ProgramVersion.Classic:
                        mainForm = new frmMain(version);
                        break;
                    case ProgramVersion.Metro:
                        mainForm = new frmMain(version);
                        break;
                    case ProgramVersion.OldFashioned:
                        mainForm = new frmMain(version);

                        Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;

                        mainForm.Invalidate(true);
                        break;
                    case ProgramVersion.NotSelected:
                    default:
                        mainForm = new frmMain(ProgramVersion.Classic);
                        break;
                }
            }); 
            
            loadThread.Start();
            loadThread.Join();

            // Finally, close the current form and launch the desired form
            new Thread(() =>
            {
                Thread.Sleep(1000);

                this.IsAllowedToClose = true;

                Invoke(new MethodInvoker(() => {
                    mainForm.Show();
                    this.Close();
                }));
            }).Start();
        }
    }
}
