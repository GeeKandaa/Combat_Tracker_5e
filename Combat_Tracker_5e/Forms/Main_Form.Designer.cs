
namespace Combat_Tracker_5e
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox Heading_PlayerList;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewParty = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.MenuLoad = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.MenuSave = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQuit = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.character_Tree1 = new Combat_Tracker_5e.Character_Tree();
            Heading_PlayerList = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading_PlayerList
            // 
            Heading_PlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Heading_PlayerList.Cursor = System.Windows.Forms.Cursors.Default;
            Heading_PlayerList.Location = new System.Drawing.Point(13, 61);
            Heading_PlayerList.Name = "Heading_PlayerList";
            Heading_PlayerList.ReadOnly = true;
            Heading_PlayerList.Size = new System.Drawing.Size(279, 24);
            Heading_PlayerList.TabIndex = 1;
            Heading_PlayerList.Text = "Characters In Combat";
            Heading_PlayerList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewParty,
            this.MenuLoad,
            this.MenuSave,
            this.toolStripMenuItem1,
            this.MenuQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNewParty
            // 
            this.menuNewParty.Name = "menuNewParty";
            this.menuNewParty.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewParty.Size = new System.Drawing.Size(270, 34);
            this.menuNewParty.Text = "New Party";
            // 
            // MenuLoad
            // 
            this.MenuLoad.Name = "MenuLoad";
            this.MenuLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuLoad.Size = new System.Drawing.Size(270, 34);
            this.MenuLoad.Text = "Load Party..";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(270, 34);
            this.MenuSave.Text = "Save Party..";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Q)));
            this.MenuQuit.Size = new System.Drawing.Size(270, 34);
            this.MenuQuit.Text = "Quit";
            // 
            // character_Tree1
            // 
            this.character_Tree1.CheckBoxes = true;
            this.character_Tree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.character_Tree1.Location = new System.Drawing.Point(13, 91);
            this.character_Tree1.Name = "character_Tree1";
            this.character_Tree1.ShowPlusMinus = false;
            this.character_Tree1.ShowRootLines = false;
            this.character_Tree1.Size = new System.Drawing.Size(279, 466);
            this.character_Tree1.TabIndex = 4;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 731);
            this.Controls.Add(this.character_Tree1);
            this.Controls.Add(Heading_PlayerList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TextBox Heading_PlayerList;
        private Character_Tree character_Tree1;
        private Controls.Managed_MenuItem menuNewParty;
        private Controls.Managed_MenuItem MenuLoad;
        private Controls.Managed_MenuItem MenuSave;
        private Controls.Managed_MenuItem MenuQuit;
    }
}

