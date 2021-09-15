
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
            this.Btn_AddChar = new System.Windows.Forms.Button();
            this.Btn_RemoveChar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_ClearParty = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.nameInput = new Combat_Tracker_5e.Controls.NameInput_TextBox();
            this.SuspendLayout();
            // 
            // Btn_AddChar
            // 
            this.Btn_AddChar.Enabled = false;
            this.Btn_AddChar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddChar.Location = new System.Drawing.Point(424, 34);
            this.Btn_AddChar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddChar.Name = "Btn_AddChar";
            this.Btn_AddChar.Size = new System.Drawing.Size(150, 34);
            this.Btn_AddChar.TabIndex = 0;
            this.Btn_AddChar.Text = "Add Character";
            this.Btn_AddChar.UseVisualStyleBackColor = true;
            // 
            // Btn_RemoveChar
            // 
            this.Btn_RemoveChar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_RemoveChar.Enabled = false;
            this.Btn_RemoveChar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_RemoveChar.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_RemoveChar.Location = new System.Drawing.Point(424, 180);
            this.Btn_RemoveChar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RemoveChar.Name = "Btn_RemoveChar";
            this.Btn_RemoveChar.Size = new System.Drawing.Size(150, 34);
            this.Btn_RemoveChar.TabIndex = 2;
            this.Btn_RemoveChar.Text = "Remove Character";
            this.Btn_RemoveChar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 110);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 259);
            this.listBox1.TabIndex = 3;
            // 
            // Btn_ClearParty
            // 
            this.Btn_ClearParty.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ClearParty.Enabled = false;
            this.Btn_ClearParty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_ClearParty.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_ClearParty.Location = new System.Drawing.Point(424, 255);
            this.Btn_ClearParty.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ClearParty.Name = "Btn_ClearParty";
            this.Btn_ClearParty.Size = new System.Drawing.Size(150, 34);
            this.Btn_ClearParty.TabIndex = 5;
            this.Btn_ClearParty.Text = "Clear Party";
            this.Btn_ClearParty.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Cancel.Location = new System.Drawing.Point(343, 391);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(150, 34);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_CancelNew_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Confirm.Enabled = false;
            this.Btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Confirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Confirm.Location = new System.Drawing.Point(106, 391);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(150, 34);
            this.Btn_Confirm.TabIndex = 8;
            this.Btn_Confirm.Text = "Confirm Party";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.Location = new System.Drawing.Point(26, 34);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(374, 33);
            this.nameInput.TabIndex = 9;
            this.nameInput.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 449);
            this.ControlBox = false;
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_ClearParty);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_RemoveChar);
            this.Controls.Add(this.Btn_AddChar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddChar;
        private System.Windows.Forms.Button Btn_RemoveChar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_ClearParty;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Confirm;
        private Controls.NameInput_TextBox nameInput;
    }
}