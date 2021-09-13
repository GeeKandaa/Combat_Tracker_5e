
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
            this.SuspendLayout();
            // 
            // btn_addchar
            // 
            this.btn_addchar.Enabled = false;
            this.btn_addchar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addchar.Location = new System.Drawing.Point(623, 80);
            this.btn_addchar.Name = "btn_addchar";
            this.btn_addchar.Size = new System.Drawing.Size(212, 69);
            this.btn_addchar.TabIndex = 0;
            this.btn_addchar.Text = "Add Character";
            this.btn_addchar.UseVisualStyleBackColor = true;
            this.btn_addchar.Click += new System.EventHandler(this.btn_addchar_Click);
            // 
            // textfield_characterName
            // 
            this.textfield_characterName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textfield_characterName.Location = new System.Drawing.Point(24, 95);
            this.textfield_characterName.Name = "textfield_characterName";
            this.textfield_characterName.Size = new System.Drawing.Size(572, 39);
            this.textfield_characterName.TabIndex = 1;
            this.textfield_characterName.TabStop = false;
            this.textfield_characterName.TextChanged += new System.EventHandler(this.Textfield_CharacterName_TextChanged);
            this.textfield_characterName.Enter += new System.EventHandler(this.Textfield_CharacterName_Enter);
            this.textfield_characterName.Leave += new System.EventHandler(this.Textfield_CharacterName_Leave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 240);
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
    }
}