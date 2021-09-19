
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewParty = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.MenuLoad = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.MenuSave = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQuit = new Combat_Tracker_5e.Controls.Managed_MenuItem();
            this.combatDisplay_DataGridView1 = new Combat_Tracker_5e.Controls.CombatDisplay_DataGridView();
            this.Colm_Turn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Colm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colm_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colm_Stunned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Colm_Concentration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Colm_HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatDisplay_DataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuNewParty.Size = new System.Drawing.Size(264, 34);
            this.menuNewParty.Text = "New Party";
            // 
            // MenuLoad
            // 
            this.MenuLoad.Name = "MenuLoad";
            this.MenuLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuLoad.Size = new System.Drawing.Size(264, 34);
            this.MenuLoad.Text = "Load Party..";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(264, 34);
            this.MenuSave.Text = "Save Party..";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 6);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Q)));
            this.MenuQuit.Size = new System.Drawing.Size(264, 34);
            this.MenuQuit.Text = "Quit";
            // 
            // combatDisplay_DataGridView1
            // 
            this.combatDisplay_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combatDisplay_DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colm_Turn,
            this.Colm_Name,
            this.Colm_Type,
            this.Colm_Stunned,
            this.Colm_Concentration,
            this.Colm_HP});
            this.combatDisplay_DataGridView1.Location = new System.Drawing.Point(12, 36);
            this.combatDisplay_DataGridView1.Name = "combatDisplay_DataGridView1";
            this.combatDisplay_DataGridView1.RowHeadersWidth = 62;
            this.combatDisplay_DataGridView1.RowTemplate.Height = 33;
            this.combatDisplay_DataGridView1.Size = new System.Drawing.Size(650, 683);
            this.combatDisplay_DataGridView1.TabIndex = 6;
            // 
            // Colm_Turn
            // 
            this.Colm_Turn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_Turn.HeaderText = "Turn";
            this.Colm_Turn.MinimumWidth = 8;
            this.Colm_Turn.Name = "Colm_Turn";
            this.Colm_Turn.ReadOnly = true;
            this.Colm_Turn.Width = 53;
            // 
            // Colm_Name
            // 
            this.Colm_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_Name.HeaderText = "Name";
            this.Colm_Name.MinimumWidth = 8;
            this.Colm_Name.Name = "Colm_Name";
            this.Colm_Name.ReadOnly = true;
            this.Colm_Name.Width = 95;
            // 
            // Colm_Type
            // 
            this.Colm_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_Type.HeaderText = "Type";
            this.Colm_Type.MinimumWidth = 8;
            this.Colm_Type.Name = "Colm_Type";
            this.Colm_Type.ReadOnly = true;
            this.Colm_Type.Width = 85;
            // 
            // Colm_Stunned
            // 
            this.Colm_Stunned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_Stunned.HeaderText = "Stunned?";
            this.Colm_Stunned.MinimumWidth = 8;
            this.Colm_Stunned.Name = "Colm_Stunned";
            this.Colm_Stunned.ReadOnly = true;
            this.Colm_Stunned.Width = 91;
            // 
            // Colm_Concentration
            // 
            this.Colm_Concentration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_Concentration.HeaderText = "Concentrating?";
            this.Colm_Concentration.MinimumWidth = 8;
            this.Colm_Concentration.Name = "Colm_Concentration";
            this.Colm_Concentration.ReadOnly = true;
            this.Colm_Concentration.Width = 137;
            // 
            // Colm_HP
            // 
            this.Colm_HP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colm_HP.HeaderText = "Hit Points";
            this.Colm_HP.MinimumWidth = 8;
            this.Colm_HP.Name = "Colm_HP";
            this.Colm_HP.ReadOnly = true;
            this.Colm_HP.Width = 124;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 731);
            this.Controls.Add(this.combatDisplay_DataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatDisplay_DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private Controls.Managed_MenuItem menuNewParty;
        private Controls.Managed_MenuItem MenuLoad;
        private Controls.Managed_MenuItem MenuSave;
        private Controls.Managed_MenuItem MenuQuit;
        private Controls.CombatDisplay_DataGridView combatDisplay_DataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Colm_Turn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colm_Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Colm_Stunned;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Colm_Concentration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colm_HP;
    }
}

