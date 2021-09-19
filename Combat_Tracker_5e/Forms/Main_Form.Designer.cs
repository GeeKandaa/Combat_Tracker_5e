
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
            this.Btn_Concentrate = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Stun = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Damage = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Heal = new Combat_Tracker_5e.Controls.Managed_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Add = new Combat_Tracker_5e.Controls.Managed_Button();
            this.HpInput = new Combat_Tracker_5e.Controls.CustomInput_TextBox();
            this.NameInput = new Combat_Tracker_5e.Controls.CustomInput_TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Combat = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Initiative = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Flee = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_EndTurn = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_NewParty = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Load = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Quit = new Combat_Tracker_5e.Controls.Managed_Button();
            this.managed_Button2 = new Combat_Tracker_5e.Controls.Managed_Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatDisplay_DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 33);
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
            this.combatDisplay_DataGridView1.AllowUserToAddRows = false;
            this.combatDisplay_DataGridView1.AllowUserToDeleteRows = false;
            this.combatDisplay_DataGridView1.AllowUserToResizeColumns = false;
            this.combatDisplay_DataGridView1.AllowUserToResizeRows = false;
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
            this.combatDisplay_DataGridView1.ReadOnly = true;
            this.combatDisplay_DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.combatDisplay_DataGridView1.RowTemplate.Height = 33;
            this.combatDisplay_DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.combatDisplay_DataGridView1.ShowCellToolTips = false;
            this.combatDisplay_DataGridView1.Size = new System.Drawing.Size(610, 683);
            this.combatDisplay_DataGridView1.TabIndex = 6;
            this.combatDisplay_DataGridView1.TabStop = false;
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
            // Btn_Concentrate
            // 
            this.Btn_Concentrate.Enabled = false;
            this.Btn_Concentrate.Location = new System.Drawing.Point(0, 169);
            this.Btn_Concentrate.Name = "Btn_Concentrate";
            this.Btn_Concentrate.Size = new System.Drawing.Size(190, 49);
            this.Btn_Concentrate.TabIndex = 7;
            this.Btn_Concentrate.Text = "Toggle Concentrating";
            this.Btn_Concentrate.UseVisualStyleBackColor = true;
            // 
            // Btn_Stun
            // 
            this.Btn_Stun.Enabled = false;
            this.Btn_Stun.Location = new System.Drawing.Point(196, 169);
            this.Btn_Stun.Name = "Btn_Stun";
            this.Btn_Stun.Size = new System.Drawing.Size(190, 49);
            this.Btn_Stun.TabIndex = 8;
            this.Btn_Stun.Text = "Toggle Stunned";
            this.Btn_Stun.UseVisualStyleBackColor = true;
            // 
            // Btn_Damage
            // 
            this.Btn_Damage.Enabled = false;
            this.Btn_Damage.Location = new System.Drawing.Point(0, 92);
            this.Btn_Damage.Name = "Btn_Damage";
            this.Btn_Damage.Size = new System.Drawing.Size(190, 49);
            this.Btn_Damage.TabIndex = 10;
            this.Btn_Damage.Text = "Damage";
            this.Btn_Damage.UseVisualStyleBackColor = true;
            // 
            // Btn_Heal
            // 
            this.Btn_Heal.Enabled = false;
            this.Btn_Heal.Location = new System.Drawing.Point(196, 92);
            this.Btn_Heal.Name = "Btn_Heal";
            this.Btn_Heal.Size = new System.Drawing.Size(190, 49);
            this.Btn_Heal.TabIndex = 9;
            this.Btn_Heal.Text = "Heal";
            this.Btn_Heal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add NPC";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.HpInput);
            this.panel1.Controls.Add(this.NameInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(625, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 197);
            this.panel1.TabIndex = 12;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(228, 108);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(149, 39);
            this.Btn_Add.TabIndex = 16;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // HpInput
            // 
            this.HpInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HpInput.ForeColor = System.Drawing.Color.Black;
            this.HpInput.Location = new System.Drawing.Point(14, 108);
            this.HpInput.Name = "HpInput";
            this.HpInput.Size = new System.Drawing.Size(208, 39);
            this.HpInput.TabIndex = 15;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.ForeColor = System.Drawing.Color.Black;
            this.NameInput.Location = new System.Drawing.Point(14, 59);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(363, 39);
            this.NameInput.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Combat);
            this.panel2.Controls.Add(this.Btn_Initiative);
            this.panel2.Controls.Add(this.Btn_Stun);
            this.panel2.Controls.Add(this.Btn_Concentrate);
            this.panel2.Controls.Add(this.Btn_Flee);
            this.panel2.Controls.Add(this.Btn_Damage);
            this.panel2.Controls.Add(this.Btn_Heal);
            this.panel2.Controls.Add(this.Btn_EndTurn);
            this.panel2.Location = new System.Drawing.Point(628, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 307);
            this.panel2.TabIndex = 13;
            // 
            // Btn_Combat
            // 
            this.Btn_Combat.Location = new System.Drawing.Point(196, 14);
            this.Btn_Combat.Name = "Btn_Combat";
            this.Btn_Combat.Size = new System.Drawing.Size(190, 49);
            this.Btn_Combat.TabIndex = 15;
            this.Btn_Combat.Text = "Start Combat";
            this.Btn_Combat.UseVisualStyleBackColor = true;
            // 
            // Btn_Initiative
            // 
            this.Btn_Initiative.Location = new System.Drawing.Point(0, 14);
            this.Btn_Initiative.Name = "Btn_Initiative";
            this.Btn_Initiative.Size = new System.Drawing.Size(190, 49);
            this.Btn_Initiative.TabIndex = 14;
            this.Btn_Initiative.Text = "Set Initiative";
            this.Btn_Initiative.UseVisualStyleBackColor = true;
            // 
            // Btn_Flee
            // 
            this.Btn_Flee.Enabled = false;
            this.Btn_Flee.Location = new System.Drawing.Point(0, 241);
            this.Btn_Flee.Name = "Btn_Flee";
            this.Btn_Flee.Size = new System.Drawing.Size(190, 49);
            this.Btn_Flee.TabIndex = 12;
            this.Btn_Flee.Text = "Flee";
            this.Btn_Flee.UseVisualStyleBackColor = true;
            // 
            // Btn_EndTurn
            // 
            this.Btn_EndTurn.Enabled = false;
            this.Btn_EndTurn.Location = new System.Drawing.Point(196, 241);
            this.Btn_EndTurn.Name = "Btn_EndTurn";
            this.Btn_EndTurn.Size = new System.Drawing.Size(190, 49);
            this.Btn_EndTurn.TabIndex = 13;
            this.Btn_EndTurn.Text = "End Turn";
            this.Btn_EndTurn.UseVisualStyleBackColor = true;
            // 
            // Btn_NewParty
            // 
            this.Btn_NewParty.Location = new System.Drawing.Point(625, 36);
            this.Btn_NewParty.Name = "Btn_NewParty";
            this.Btn_NewParty.Size = new System.Drawing.Size(120, 48);
            this.Btn_NewParty.TabIndex = 17;
            this.Btn_NewParty.Text = "New Party";
            this.Btn_NewParty.UseVisualStyleBackColor = true;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(894, 36);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(120, 48);
            this.Btn_Load.TabIndex = 19;
            this.Btn_Load.Text = "Load Party";
            this.Btn_Load.UseVisualStyleBackColor = true;
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(894, 95);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(120, 48);
            this.Btn_Quit.TabIndex = 20;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            // 
            // managed_Button2
            // 
            this.managed_Button2.Location = new System.Drawing.Point(759, 36);
            this.managed_Button2.Name = "managed_Button2";
            this.managed_Button2.Size = new System.Drawing.Size(120, 48);
            this.managed_Button2.TabIndex = 18;
            this.managed_Button2.Text = "Save Party";
            this.managed_Button2.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 731);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.managed_Button2);
            this.Controls.Add(this.Btn_NewParty);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combatDisplay_DataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatDisplay_DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private Controls.Managed_Button Btn_Concentrate;
        private Controls.Managed_Button Btn_Stun;
        private Controls.Managed_Button Btn_Damage;
        private Controls.Managed_Button Btn_Heal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controls.Managed_Button Btn_Flee;
        private Controls.Managed_Button Btn_EndTurn;
        private Controls.Managed_Button Btn_Add;
        private Controls.CustomInput_TextBox HpInput;
        private Controls.CustomInput_TextBox NameInput;
        private Controls.Managed_Button Btn_NewParty;
        private Controls.Managed_Button Btn_Load;
        private Controls.Managed_Button Btn_Quit;
        private Controls.Managed_Button Btn_Combat;
        private Controls.Managed_Button Btn_Initiative;
        private Controls.Managed_Button managed_Button2;
    }
}

