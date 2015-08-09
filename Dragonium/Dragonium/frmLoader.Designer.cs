namespace Dragonium
{
    partial class frmLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoader));
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblDesigned = new MetroFramework.Controls.MetroLabel();
            this.pbSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(123, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DRAGONIUM™";
            this.lblTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTitle.UseCustomForeColor = true;
            // 
            // lblDesigned
            // 
            this.lblDesigned.AutoSize = true;
            this.lblDesigned.Location = new System.Drawing.Point(52, 62);
            this.lblDesigned.Name = "lblDesigned";
            this.lblDesigned.Size = new System.Drawing.Size(282, 19);
            this.lblDesigned.TabIndex = 1;
            this.lblDesigned.Text = "Designed especially for Windows 10 and Metro";
            this.lblDesigned.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pbSpinner
            // 
            this.pbSpinner.Location = new System.Drawing.Point(157, 97);
            this.pbSpinner.Maximum = 100;
            this.pbSpinner.Name = "pbSpinner";
            this.pbSpinner.Size = new System.Drawing.Size(64, 64);
            this.pbSpinner.Speed = 2F;
            this.pbSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.pbSpinner.TabIndex = 2;
            this.pbSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pbSpinner.UseSelectable = true;
            // 
            // frmLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 175);
            this.ControlBox = false;
            this.Controls.Add(this.pbSpinner);
            this.Controls.Add(this.lblDesigned);
            this.Controls.Add(this.lblTitle);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 175);
            this.Movable = false;
            this.Name = "frmLoader";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Dragonium™";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoader_FormClosing);
            this.Load += new System.EventHandler(this.frmLoader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel lblDesigned;
        private MetroFramework.Controls.MetroProgressSpinner pbSpinner;
    }
}