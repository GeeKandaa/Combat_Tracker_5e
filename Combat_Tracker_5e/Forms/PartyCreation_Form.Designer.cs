
namespace Combat_Tracker_5e
{
    partial class PartyCreation_Form
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
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.nameInput = new Combat_Tracker_5e.Controls.NameInput_TextBox();
            this.Btn_Cancel = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_AddChar = new Combat_Tracker_5e.Controls.Managed_Button();
            this.CharList = new Combat_Tracker_5e.Controls.NewPartyList_ListBox();
            this.Btn_RemoveChar = new Combat_Tracker_5e.Controls.Managed_Button();
            this.Btn_Clear = new Combat_Tracker_5e.Controls.Managed_Button();
            this.SuspendLayout();
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Confirm.Enabled = false;
            this.Btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Confirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Confirm.Location = new System.Drawing.Point(151, 652);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(214, 57);
            this.Btn_Confirm.TabIndex = 8;
            this.Btn_Confirm.Text = "Confirm Party";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.Location = new System.Drawing.Point(37, 57);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(533, 45);
            this.nameInput.TabIndex = 9;
            this.nameInput.TabStop = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cancel.Location = new System.Drawing.Point(490, 652);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(214, 57);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_AddChar
            // 
            this.Btn_AddChar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddChar.Location = new System.Drawing.Point(606, 57);
            this.Btn_AddChar.Name = "Btn_AddChar";
            this.Btn_AddChar.Size = new System.Drawing.Size(214, 45);
            this.Btn_AddChar.TabIndex = 11;
            this.Btn_AddChar.Text = "Add Character";
            this.Btn_AddChar.UseVisualStyleBackColor = true;
            // 
            // CharList
            // 
            this.CharList.FormattingEnabled = true;
            this.CharList.ItemHeight = 25;
            this.CharList.Location = new System.Drawing.Point(37, 138);
            this.CharList.Name = "CharList";
            this.CharList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CharList.Size = new System.Drawing.Size(533, 454);
            this.CharList.TabIndex = 12;
            // 
            // Btn_RemoveChar
            // 
            this.Btn_RemoveChar.Enabled = false;
            this.Btn_RemoveChar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_RemoveChar.Location = new System.Drawing.Point(606, 138);
            this.Btn_RemoveChar.Name = "Btn_RemoveChar";
            this.Btn_RemoveChar.Size = new System.Drawing.Size(214, 67);
            this.Btn_RemoveChar.TabIndex = 13;
            this.Btn_RemoveChar.Text = "Remove Character";
            this.Btn_RemoveChar.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Enabled = false;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Clear.Location = new System.Drawing.Point(606, 237);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(214, 67);
            this.Btn_Clear.TabIndex = 14;
            this.Btn_Clear.Text = "Clear Party";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // PartyCreation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 748);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_RemoveChar);
            this.Controls.Add(this.CharList);
            this.Controls.Add(this.Btn_AddChar);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.Btn_Confirm);
            this.Name = "PartyCreation_Form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Confirm;
        private Controls.NameInput_TextBox nameInput;
        private Controls.Managed_Button Btn_Cancel;
        private Controls.Managed_Button Btn_AddChar;
        private Controls.NewPartyList_ListBox CharList;
        private Controls.Managed_Button Btn_RemoveChar;
        private Controls.Managed_Button Btn_Clear;
    }
}