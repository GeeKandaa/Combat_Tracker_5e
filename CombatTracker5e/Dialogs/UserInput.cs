using System;
using System.Drawing;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    public partial class UserInput : Form
    {
        protected Button ButtonOK;
        protected Button ButtonCancel;
        protected Label LabelPrompt;
        protected TextBox InputBox;
        protected CheckBox InputCheck;
        private readonly System.ComponentModel.Container components = null;
        public UserInput()
        {
            Size FormSize = new(400, 200);

            LabelPrompt = new();
            LabelPrompt.AutoSize = true;
            LabelPrompt.Location = new Point(15, 15);
            LabelPrompt.Text = "prompt";

            InputBox = new();
            InputBox.Name = "InputBox";
            InputBox.Text = "";
            InputBox.Width = FormSize.Width-30;
            InputBox.Location = new Point(LabelPrompt.Left, LabelPrompt.Top + LabelPrompt.Height*2 + InputBox.Height/2);
            InputBox.TabIndex = 0;
            InputBox.KeyPress += ValidateInput;

            InputCheck = new();
            InputCheck.Checked = false;
            InputCheck.Appearance = Appearance.Normal;
            InputCheck.AutoSize = true;
            InputCheck.Text = "Half Damage";
            InputCheck.Location = new Point(InputBox.Left, InputBox.Top + InputBox.Height + InputCheck.Height/2);

            ButtonCancel = new();
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Text = "Cancel";
            ButtonCancel.AutoSize = true;
            ButtonCancel.Click += ButtonClick;
            ButtonCancel.Location = new Point((Width / 4) * 3, InputCheck.Top + InputCheck.Height + ButtonCancel.Height / 2);

            ButtonOK = new();
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Text = "OK";
            ButtonOK.Click += ButtonClick;
            ButtonOK.DialogResult = DialogResult.OK;
            ButtonOK.Location = new Point((Width / 4) * 1, ButtonCancel.Top);

            Name = "UserInputDialog";
            Text = "title";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = FormSize;

            AcceptButton = ButtonOK;
            CancelButton = ButtonCancel;

            Controls.AddRange
            (
                new Control[]
                {
                    LabelPrompt,
                    InputBox,
                    InputCheck,
                    ButtonOK,
                    ButtonCancel,
                }
            );

            ButtonOK.Size = ButtonCancel.Size;
        }
        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Close();
        }
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
        public static Result Show(string title, string prompt, int defaultVal, string action)
        {
            if (action!="Damage") return Show(title, prompt, true, defaultVal);
            return Show(title, prompt, false, defaultVal);
        }
        private static Result Show(string title, string prompt, bool hideCheckbox, int defaultVal)
        {
            using UserInput form = new();
            if (hideCheckbox) form.InputCheck.Visible = false;
            form.Text = title;
            form.LabelPrompt.Text = prompt;
            if (defaultVal > 0)
            {
                form.InputBox.Text = defaultVal.ToString();
            }
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();
            Result retval = new();
            if (result == DialogResult.OK)
            {
                try
                {
                    retval.Value = Convert.ToInt32(form.InputBox.Text);
                    retval.Recall = retval.Value;
                    if (form.InputCheck.CheckState == CheckState.Checked) retval.Value = (int)Math.Floor(retval.Value / 2.0);
                    retval.OK = true;
                }
                catch (Exception)
                {
                    retval.OK = false;
                    retval.Value = 0;
                    retval.Recall = 0;
                }
            }
            else
            {
                retval.OK = false;
                retval.Value = 0;
                retval.Recall = 0;
            }
            return retval;
        }
        public class Result
        {
            public int Value;
            public int Recall;
            public bool OK = false;
        }
    }
}
