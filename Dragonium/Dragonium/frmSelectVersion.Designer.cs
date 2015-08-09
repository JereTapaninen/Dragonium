namespace Dragonium
{
    partial class frmSelectVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectVersion));
            this.tileMetro = new MetroFramework.Controls.MetroTile();
            this.tileClassic = new MetroFramework.Controls.MetroTile();
            this.tileOldFashioned = new MetroFramework.Controls.MetroTile();
            this.lblRecommended = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tileMetro
            // 
            this.tileMetro.ActiveControl = null;
            this.tileMetro.Location = new System.Drawing.Point(7, 63);
            this.tileMetro.Name = "tileMetro";
            this.tileMetro.Size = new System.Drawing.Size(275, 86);
            this.tileMetro.TabIndex = 0;
            this.tileMetro.Text = "DRAGONIUM Metro (Windows 8 to 10)";
            this.tileMetro.UseSelectable = true;
            this.tileMetro.Click += new System.EventHandler(this.tileMetro_Click);
            // 
            // tileClassic
            // 
            this.tileClassic.ActiveControl = null;
            this.tileClassic.Location = new System.Drawing.Point(7, 155);
            this.tileClassic.Name = "tileClassic";
            this.tileClassic.Size = new System.Drawing.Size(275, 86);
            this.tileClassic.Style = MetroFramework.MetroColorStyle.Green;
            this.tileClassic.TabIndex = 1;
            this.tileClassic.Text = "DRAGONIUM Classic (< Windows 8)";
            this.tileClassic.UseSelectable = true;
            this.tileClassic.Click += new System.EventHandler(this.tileClassic_Click);
            // 
            // tileOldFashioned
            // 
            this.tileOldFashioned.ActiveControl = null;
            this.tileOldFashioned.Location = new System.Drawing.Point(7, 247);
            this.tileOldFashioned.Name = "tileOldFashioned";
            this.tileOldFashioned.Size = new System.Drawing.Size(275, 86);
            this.tileOldFashioned.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileOldFashioned.TabIndex = 2;
            this.tileOldFashioned.Text = "DRAGONIUM Old Fashioned (< Windows 7)";
            this.tileOldFashioned.UseSelectable = true;
            this.tileOldFashioned.Click += new System.EventHandler(this.tileOldFashioned_Click);
            // 
            // lblRecommended
            // 
            this.lblRecommended.AutoSize = true;
            this.lblRecommended.Location = new System.Drawing.Point(54, 339);
            this.lblRecommended.Name = "lblRecommended";
            this.lblRecommended.Size = new System.Drawing.Size(173, 38);
            this.lblRecommended.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblRecommended.TabIndex = 3;
            this.lblRecommended.Text = "Recommended is {0}\r\nSelecting automatically in {1}";
            this.lblRecommended.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecommended.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblRecommended.TextChanged += new System.EventHandler(this.lblRecommended_TextChanged);
            // 
            // frmSelectVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 383);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecommended);
            this.Controls.Add(this.tileOldFashioned);
            this.Controls.Add(this.tileClassic);
            this.Controls.Add(this.tileMetro);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(289, 383);
            this.MinimumSize = new System.Drawing.Size(289, 383);
            this.Movable = false;
            this.Name = "frmSelectVersion";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Select Program Version";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileMetro;
        private MetroFramework.Controls.MetroTile tileClassic;
        private MetroFramework.Controls.MetroTile tileOldFashioned;
        private MetroFramework.Controls.MetroLabel lblRecommended;

    }
}