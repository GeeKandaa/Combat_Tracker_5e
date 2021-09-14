
namespace Combat_Tracker_5e
{
    partial class Form2
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
            this.btn_addchar = new System.Windows.Forms.Button();
            this.textfield_characterName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_AcceptParty = new System.Windows.Forms.Button();
            this.Btn_ClearParty = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addchar
            // 
            this.btn_addchar.Enabled = false;
            this.btn_addchar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addchar.Location = new System.Drawing.Point(606, 86);
            this.btn_addchar.Name = "btn_addchar";
            this.btn_addchar.Size = new System.Drawing.Size(214, 57);
            this.btn_addchar.TabIndex = 0;
            this.btn_addchar.Text = "Add Character";
            this.btn_addchar.UseVisualStyleBackColor = true;
            this.btn_addchar.Click += new System.EventHandler(this.btn_addchar_Click);
            // 
            // textfield_characterName
            // 
            this.textfield_characterName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textfield_characterName.Location = new System.Drawing.Point(37, 95);
            this.textfield_characterName.Name = "textfield_characterName";
            this.textfield_characterName.Size = new System.Drawing.Size(532, 39);
            this.textfield_characterName.TabIndex = 1;
            this.textfield_characterName.TabStop = false;
            this.textfield_characterName.TextChanged += new System.EventHandler(this.Textfield_CharacterName_TextChanged);
            this.textfield_characterName.Enter += new System.EventHandler(this.Textfield_CharacterName_Enter);
            this.textfield_characterName.Leave += new System.EventHandler(this.Textfield_CharacterName_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(606, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove Character";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(37, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 429);
            this.listBox1.TabIndex = 3;
            // 
            // Btn_AcceptParty
            // 
            this.Btn_AcceptParty.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AcceptParty.Enabled = false;
            this.Btn_AcceptParty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AcceptParty.ForeColor = System.Drawing.Color.Black;
            this.Btn_AcceptParty.Location = new System.Drawing.Point(152, 739);
            this.Btn_AcceptParty.Name = "Btn_AcceptParty";
            this.Btn_AcceptParty.Size = new System.Drawing.Size(214, 57);
            this.Btn_AcceptParty.TabIndex = 4;
            this.Btn_AcceptParty.Text = "Confirm Party";
            this.Btn_AcceptParty.UseVisualStyleBackColor = false;
            // 
            // Btn_ClearParty
            // 
            this.Btn_ClearParty.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ClearParty.Enabled = false;
            this.Btn_ClearParty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_ClearParty.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_ClearParty.Location = new System.Drawing.Point(606, 468);
            this.Btn_ClearParty.Name = "Btn_ClearParty";
            this.Btn_ClearParty.Size = new System.Drawing.Size(214, 57);
            this.Btn_ClearParty.TabIndex = 5;
            this.Btn_ClearParty.Text = "Clear Party";
            this.Btn_ClearParty.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancel.Enabled = false;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancel.Location = new System.Drawing.Point(490, 739);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(214, 57);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 862);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_ClearParty);
            this.Controls.Add(this.Btn_AcceptParty);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textfield_characterName);
            this.Controls.Add(this.btn_addchar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addchar;
        private System.Windows.Forms.TextBox textfield_characterName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_AcceptParty;
        private System.Windows.Forms.Button Btn_ClearParty;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}