using CombatTracker5e.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    public class NewCharacterDialog : Form
    {
        /// <summary>
        /// Confirm button; Processes data and initiates character creation
        /// </summary>
        protected Button ButtonCreate;

        /// <summary>
        /// Cancel button; Cancels character creation
        /// </summary>
        protected Button ButtonCancel;

        /// <summary>
        /// User Input: Character name
        /// </summary>
        protected TextBox InputName;

        /// <summary>
        /// User Input: Character HP
        /// </summary>
        protected TextBox InputCurrentHp;

        /// <summary>
        /// User Input: Character Max HP
        /// </summary>
        protected TextBox InputMaxHp;

        /// <summary>
        /// Components of form. Required.
        /// </summary>
        private readonly System.ComponentModel.Container components = null;

        /// <summary>
        /// Constructor, initialises form.
        /// </summary>
        public NewCharacterDialog()
        {
            ClientSize = new(365, 200);

            Panel container = new();
            container.Dock = DockStyle.Top;
            container.Height = (int)(Height * 0.55);
            Controls.Add(container);

            InputName = new();
            InputName.Name = "CharacterName";
            InputName.Width = 200;
            InputName.Location = new Point(container.Right - InputName.Width - 15, 15);

            Label descriptor = new();
            descriptor.Text = "Character Name:";
            descriptor.AutoSize = true;

            container.Controls.AddRange(new Control[] { descriptor, InputName });
            descriptor.Location = new Point(InputName.Left - descriptor.Width, 15 - (descriptor.Height - InputName.Height)/2);

            InputCurrentHp = new();
            InputCurrentHp.Name = "CurrentHp";
            InputCurrentHp.Width = container.Width / 6;
            InputCurrentHp.Location = new Point(container.Right - InputCurrentHp.Width - 15, InputName.Bottom + 15);
            InputCurrentHp.KeyPress += ValidateInput;

            descriptor = new();
            descriptor.Text = "Initial HP:";
            descriptor.AutoSize = true;

            container.Controls.AddRange(new Control[] { descriptor, InputCurrentHp });
            descriptor.Location = new Point(InputCurrentHp.Left - descriptor.Width, InputName.Bottom + 15 - (descriptor.Height - InputCurrentHp.Height) / 2);

            InputMaxHp = new();
            InputMaxHp.Name = "MaxHp";
            InputMaxHp.Width = container.Width / 6;
            InputMaxHp.Location = new Point(container.Right - InputMaxHp.Width - 15, InputCurrentHp.Bottom + 15);
            InputMaxHp.KeyPress += ValidateInput;

            descriptor = new();
            descriptor.Text = "Maximum HP:";
            descriptor.AutoSize = true;

            container.Controls.AddRange(new Control[] { descriptor, InputMaxHp });
            descriptor.Location = new Point(InputMaxHp.Left - descriptor.Width, InputCurrentHp.Bottom + 15 - (descriptor.Height - InputMaxHp.Height) / 2);

            /////
            container = new();
            container.Dock = DockStyle.Bottom;
            container.Height = (int)(Height * 0.2);
            Controls.Add(container);

            ButtonCreate = new();
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Text = "Submit Character";
            ButtonCreate.AutoSize = true;
            ButtonCreate.Click += ButtonClick;
            ButtonCreate.DialogResult = DialogResult.OK;
            container.Controls.Add(ButtonCreate);

            ButtonCancel = new();
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Text = "Cancel";
            ButtonCancel.AutoSize = false;
            ButtonCancel.Width = ButtonCreate.Width;
            ButtonCancel.Height = ButtonCreate.Height;
            ButtonCancel.Click += ButtonClick;
            ButtonCancel.DialogResult = DialogResult.Cancel;
            container.Controls.Add(ButtonCancel);

            int locationSpecifier = (container.Width / ButtonCreate.Width)-2;
            ButtonCreate.Location = new Point(container.Width * locationSpecifier + 15,container.Height/2-ButtonCreate.Height/2);
            ButtonCancel.Location = new Point(container.Right - ButtonCreate.Width - container.Width * locationSpecifier - 15, container.Height / 2 - ButtonCreate.Height / 2);

        }

        /// <summary>
        /// Disposing method. Required.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Ensures characters can not be typed other than numeric. Controls are accepted to allow backspace but does not restrict copy/paste (BUG)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !("1234567890".Contains(e.KeyChar.ToString())))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Simple button handler. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Shows character creation dialog.
        /// </summary>
        /// <param name="characterType">Type of character to be created</param>
        /// <param name="name">Default name for name user input</param>
        /// <param name="hp">Default HP for HP user input</param>
        /// <param name="maxHp">Default MaxHp for MaxHp user input</param>
        /// <returns>Result containing character data if successful, MissingStat is true otherwise.</returns>
        public static Result Show(string characterType, string name, int hp, int maxHp)
        {
            using NewCharacterDialog form = new();
            form.Text = $"Add {characterType}";
            if (name != null) form.InputName.Text = name;
            if (hp != -1) form.InputCurrentHp.Text = hp.ToString();
            if (maxHp != -1) form.InputMaxHp.Text = maxHp.ToString();
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();
            Result retval = new();
            if (result == DialogResult.OK)
            {

                if (form.InputName.Text != "") retval.Name = form.InputName.Text;
                if (form.InputCurrentHp.Text != "") retval.Hp = Convert.ToInt32(form.InputCurrentHp.Text);
                if (form.InputMaxHp.Text != "") retval.MaxHp = Convert.ToInt32(form.InputMaxHp.Text);
                  
                if(retval.MissingStat) MessageBox.Show("Character stats cannot be empty!");
            }
            else
            {
                retval.Cancel = true;
            }
            return retval;
        }

        /// <summary>
        /// Result class for character creation dialog, contains character data.
        /// </summary>
        public class Result
        {
            public string Name;
            public int Hp = -1;
            public int MaxHp = -1;
            public bool Cancel = false;
            public bool MissingStat
            {
                get
                {
                    if (Name == null || Hp == -1 || MaxHp == -1)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}