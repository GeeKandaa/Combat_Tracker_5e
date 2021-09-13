
namespace Combat_Tracker_5e
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Test Player");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Players", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Test NPC");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("NPCs", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Players");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("NPCs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Test Player");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Players", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Test NPC");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("NPCs", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.newPartyToolStripMenuItem,
            this.loadPartyToolStripMenuItem,
            this.savePartyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPartyToolStripMenuItem
            // 
            this.newPartyToolStripMenuItem.Name = "newPartyToolStripMenuItem";
            this.newPartyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPartyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newPartyToolStripMenuItem.Text = "New Party";
            this.newPartyToolStripMenuItem.Click += new System.EventHandler(this.NewPartyToolStripMenuItem_Click);
            // 
            // loadPartyToolStripMenuItem
            // 
            this.loadPartyToolStripMenuItem.Name = "loadPartyToolStripMenuItem";
            this.loadPartyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadPartyToolStripMenuItem.Text = "Load Party..";
            // 
            // savePartyToolStripMenuItem
            // 
            this.savePartyToolStripMenuItem.Name = "savePartyToolStripMenuItem";
            this.savePartyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.savePartyToolStripMenuItem.Text = "Save Party..";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(13, 91);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Test_Player";
            treeNode1.Text = "Test Player";
            treeNode2.Name = "Player_Root";
            treeNode2.Text = "Players";
            treeNode3.Name = "Test_NPC";
            treeNode3.Text = "Test NPC";
            treeNode4.Name = "NPC_Root";
            treeNode4.Text = "NPCs";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(279, 466);
            this.treeView1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(483, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 479);
            this.listBox1.TabIndex = 3;
            // 
            // character_Tree1
            // 
            this.character_Tree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.character_Tree1.Location = new System.Drawing.Point(295, 91);
            this.character_Tree1.Name = "character_Tree1";
            treeNode5.Name = "";
            treeNode5.Text = "Players";
            treeNode6.Name = "";
            treeNode6.Text = "NPCs";
            treeNode7.Name = "Test_Player";
            treeNode7.Text = "Test Player";
            treeNode8.Name = "Player_Root";
            treeNode8.Text = "Players";
            treeNode9.Name = "Test_NPC";
            treeNode9.Text = "Test NPC";
            treeNode10.Name = "NPC_Root";
            treeNode10.Text = "NPCs";
            this.character_Tree1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode8,
            treeNode10});
            this.character_Tree1.Size = new System.Drawing.Size(182, 466);
            this.character_Tree1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 731);
            this.Controls.Add(this.character_Tree1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(Heading_PlayerList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox Heading_PlayerList;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private Character_Tree character_Tree1;
    }
}

