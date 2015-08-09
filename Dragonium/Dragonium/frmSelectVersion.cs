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
    /// Contains all the program versions available
    /// </summary>
    public enum ProgramVersion : byte 
    {
        NotSelected = 0,
        Metro = 1,
        Classic = 2,
        OldFashioned = 3
    }

    /// <summary>
    /// The form that the user selects the program's version from
    /// </summary>
    public partial class frmSelectVersion : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// The currently selected program version.
        /// Initial value is ProgramVersion.NotSelected
        /// </summary>
        public ProgramVersion SelectedVersion { get; private set; }

        /// <summary>
        /// The thread that automatically selects the program version if user doesn't
        /// </summary>
        public Thread SelectionThread { get; private set; }

        /// <summary>
        /// Initializes the selection form
        /// </summary>
        public frmSelectVersion()
        {
            InitializeComponent();

            Initialize();
        }

        /// <summary>
        /// Initializes the Select Version Form
        /// </summary>
        private void Initialize()
        {
            // Do some generic UI work here

            this.PostInitialize();
        }

        /// <summary>
        /// Initializes all the rest of the shit
        /// </summary>
        private void PostInitialize()
        {
            var recommended = ProgramVersion.NotSelected;

            try
            {
                var windowsVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\", "ProductName", "Windows x").ToString();

                if (windowsVersion.Contains("Windows 8") || windowsVersion.Contains("Windows 10"))
                    recommended = ProgramVersion.Metro;
                else if (windowsVersion.Contains("Windows 7") || windowsVersion.Contains("Windows Vista"))
                    recommended = ProgramVersion.Classic;
                else
                    recommended = ProgramVersion.OldFashioned;
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("DRAGONIUM got a Security Exception while trying to read the Windows-version from the Registry.\n\n" +
                                "Please make sure that you are running DRAGONIUM with full admin privileges\n\n" + 
                                "Defaulting recommended program version to Old Fashioned.",
                                "Security Exception",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                recommended = ProgramVersion.OldFashioned;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("DRAGONIUM got an IO Exception while trying to read the Windows-version from the Registry.\n\n" +
                                "Defaulting recommended program version to Old Fashioned.",
                                "IO Exception",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                recommended = ProgramVersion.OldFashioned;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("DRAGONIUM got an Argument Exception while trying to read the Windows-version from the Registry.\n\n" +
                                "PLEASE REPORT THIS TO THE DEVELOPER.\n\n" + 
                                "Defaulting recommended program version to Old Fashioned.",
                                "Argument Exception",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                recommended = ProgramVersion.OldFashioned;
            }

            switch (recommended)
            {
                case ProgramVersion.Metro:
                    this.Style = this.tileMetro.Style;
                    this.tileMetro.Focus();
                    break;
                case ProgramVersion.Classic:
                    this.Style = this.tileClassic.Style;
                    this.tileClassic.Focus();
                    break;
                case ProgramVersion.OldFashioned:
                    this.Style = this.tileOldFashioned.Style;
                    this.tileOldFashioned.Focus();
                    break;
                case ProgramVersion.NotSelected:
                default:
                    this.Style = this.tileOldFashioned.Style;
                    this.tileOldFashioned.Focus();
                    break;
            }

            var recommendedString = (recommended == ProgramVersion.OldFashioned) ? "Old Fashioned" : recommended.ToString();

            var defText = this.lblRecommended.Text;
            this.lblRecommended.Text = string.Format(this.lblRecommended.Text, recommendedString, "10");

            try
            {
                this.SelectionThread = new Thread(() =>
                {
                    var val = 10;

                    while (val > 1)
                    {
                        val--;

                        this.lblRecommended.Invoke(new MethodInvoker(() => this.lblRecommended.Text = string.Format(defText, recommendedString, val.ToString())));

                        Thread.Sleep(1000);
                    }

                    this.SelectedVersion = recommended;
                });

                this.SelectionThread.Start();
            }
            catch (ThreadAbortException)
            { /* Do absolutely nothing */ }
        
        }

        private void FinalizeAndClose()
        {
            this.SelectionThread.Abort();
            this.Close();
        }

        /// <summary>
        /// Event that fires when the DRAGONIUM Metro tile has been clicked
        /// </summary>
        /// <param name="sender">The tileMetro control</param>
        /// <param name="e">The event arguments</param>
        private void tileMetro_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = ProgramVersion.Metro;

            this.FinalizeAndClose();
        }

        /// <summary>
        /// Event that fires when the DRAGONIUM Classic tile has been clicked
        /// </summary>
        /// <param name="sender">The tileClassic control</param>
        /// <param name="e">The event arguments</param>
        private void tileClassic_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = ProgramVersion.Classic;

            this.FinalizeAndClose();
        }

        /// <summary>
        /// Event that fires when the DRAGONIUM Old Fashioned tile has been clicked
        /// </summary>
        /// <param name="sender">The tileOldFashioned control</param>
        /// <param name="e">The event arguments</param>
        private void tileOldFashioned_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = ProgramVersion.OldFashioned;

            this.FinalizeAndClose();
        }

        /// <summary>
        /// Handles the label realigning after its text has been changed
        /// </summary>
        /// <param name="sender">The lblRecommended control</param>
        /// <param name="e">The event arguments</param>
        private void lblRecommended_TextChanged(object sender, EventArgs e)
        {
            var lbl = (MetroFramework.Controls.MetroLabel)sender;

            var lblPoint = new Point((this.Size.Width / 2) - (lbl.Size.Width / 2), lbl.Location.Y);
            lbl.Location = lblPoint;
        }
    }
}
