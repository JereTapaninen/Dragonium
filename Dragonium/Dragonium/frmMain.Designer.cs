namespace Dragonium
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolsMain = new System.Windows.Forms.ToolStrip();
            this.lbConsole = new Dragonium.IO.Theme.Controls.DragoniumMetroListBox();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadAScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disableAScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.AllowMerge = false;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.scriptsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuMain.Size = new System.Drawing.Size(1158, 24);
            this.menuMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAScriptToolStripMenuItem,
            this.disableAScriptToolStripMenuItem,
            this.toolStripSeparator2,
            this.scriptOptionsToolStripMenuItem});
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 693);
            this.statusMain.Name = "statusMain";
            this.statusMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMain.Size = new System.Drawing.Size(1158, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 17);
            this.lblStatus.Text = "Dragonium is ready";
            // 
            // toolsMain
            // 
            this.toolsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMain.Location = new System.Drawing.Point(0, 24);
            this.toolsMain.Name = "toolsMain";
            this.toolsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolsMain.Size = new System.Drawing.Size(1158, 25);
            this.toolsMain.TabIndex = 3;
            // 
            // lbConsole
            // 
            this.lbConsole.BackColor = System.Drawing.SystemColors.Window;
            this.lbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(0, 615);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbConsole.Size = new System.Drawing.Size(1158, 78);
            this.lbConsole.TabIndex = 2;
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // loadAScriptToolStripMenuItem
            // 
            this.loadAScriptToolStripMenuItem.Name = "loadAScriptToolStripMenuItem";
            this.loadAScriptToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadAScriptToolStripMenuItem.Text = "Load a script";
            // 
            // scriptOptionsToolStripMenuItem
            // 
            this.scriptOptionsToolStripMenuItem.Name = "scriptOptionsToolStripMenuItem";
            this.scriptOptionsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.scriptOptionsToolStripMenuItem.Text = "Script Options";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // disableAScriptToolStripMenuItem
            // 
            this.disableAScriptToolStripMenuItem.Name = "disableAScriptToolStripMenuItem";
            this.disableAScriptToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.disableAScriptToolStripMenuItem.Text = "Disable a script";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 715);
            this.Controls.Add(this.toolsMain);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRAGONIUM™";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private IO.Theme.Controls.DragoniumMetroListBox lbConsole;
        private System.Windows.Forms.ToolStrip toolsMain;
        private System.Windows.Forms.ToolStripMenuItem loadAScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem scriptOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

