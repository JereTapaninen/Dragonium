namespace Dragonium
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTextThatWasAGreatNameRight = new System.Windows.Forms.Label();
            this.lnkIcons8 = new System.Windows.Forms.LinkLabel();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DRAGONIUM™";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(10, 37);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(150, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "by Jere Tapaninen, 2015";
            // 
            // lblTextThatWasAGreatNameRight
            // 
            this.lblTextThatWasAGreatNameRight.AutoSize = true;
            this.lblTextThatWasAGreatNameRight.Location = new System.Drawing.Point(12, 69);
            this.lblTextThatWasAGreatNameRight.Name = "lblTextThatWasAGreatNameRight";
            this.lblTextThatWasAGreatNameRight.Size = new System.Drawing.Size(239, 104);
            this.lblTextThatWasAGreatNameRight.TabIndex = 2;
            this.lblTextThatWasAGreatNameRight.Text = "Dragonium made by Jere Tapaninen.\r\n\r\nThis program uses icons by icons8,\r\ncheck th" +
    "em out by visiting the following link:\r\n\r\n\r\n\r\nCheck out my Github page! :";
            // 
            // lnkIcons8
            // 
            this.lnkIcons8.AutoSize = true;
            this.lnkIcons8.Location = new System.Drawing.Point(12, 133);
            this.lnkIcons8.Name = "lnkIcons8";
            this.lnkIcons8.Size = new System.Drawing.Size(132, 13);
            this.lnkIcons8.TabIndex = 3;
            this.lnkIcons8.TabStop = true;
            this.lnkIcons8.Text = "https://www.icons8.com";
            this.lnkIcons8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIcons8_LinkClicked);
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(12, 187);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(243, 13);
            this.lnkGithub.TabIndex = 4;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/JereTapaninen/Dragonium";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.lnkIcons8);
            this.Controls.Add(this.lblTextThatWasAGreatNameRight);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragonium™ About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAbout_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTextThatWasAGreatNameRight;
        private System.Windows.Forms.LinkLabel lnkIcons8;
        private System.Windows.Forms.LinkLabel lnkGithub;
    }
}