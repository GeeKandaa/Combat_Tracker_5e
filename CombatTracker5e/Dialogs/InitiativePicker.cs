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
    public partial class InitiativePicker : Form
    {
        protected Button buttonSelect;
        protected Button buttonClassic;
        protected Button buttonCancel;
        protected Label LabelPrompt;
        protected string choice = "";
        private readonly System.ComponentModel.Container components = null;
        public InitiativePicker()
        {
            Size FormSize = new(530, 200);
            ClientSize = FormSize;
            LabelPrompt = new();
            LabelPrompt.Text = "Select initiative style:\n" +
                                "Select: Click on the characters to select turn order, first to last.\n" +
                                "Classic: Set each characters intitiative manually.\n\nNote: An intitiative of 0 will not partake in battle.";
            LabelPrompt.AutoSize = true;
            LabelPrompt.Location = new Point(15, 15);
            Controls.Add(LabelPrompt);

            buttonSelect = new();
            buttonClassic = new();
            buttonCancel = new();
            buttonSelect.Text = "Select";
            buttonSelect.Enabled = false;
            buttonClassic.Text = "Classic";
            buttonCancel.Text = "Cancel";
            buttonSelect.Click += Select_Click;
            buttonClassic.Click += Classic_Click;
            buttonCancel.Click += Cancel_Click;
            Controls.AddRange(new Control[] { buttonSelect, buttonClassic, buttonCancel });

            buttonClassic.AutoSize = true;
            buttonSelect.Size = buttonClassic.Size;
            buttonCancel.Size = buttonClassic.Size;

            int buttonLoc = FormSize.Width / 5;
            buttonSelect.Location = new Point(buttonLoc +15, FormSize.Height - buttonSelect.Height - 15);
            buttonClassic.Location = new Point(buttonLoc * 2+15, FormSize.Height - buttonClassic.Height - 15);
            buttonCancel.Location = new Point(buttonLoc * 3+15, FormSize.Height - buttonCancel.Height - 15);
            buttonSelect.DialogResult = DialogResult.OK;
            buttonClassic.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

        }
        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void Classic_Click(object sender, EventArgs e)
        {
            choice = "Classic";
            Close();
        }
        private void Select_Click(object sender, EventArgs e)
        {
            choice = "Select";
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
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

        public static Result Show(string title)
        {
            using InitiativePicker form = new();
            form.Text = title;
            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog();
            Result retval = new();
            if (result == DialogResult.OK)
            {
                retval.Choice = form.choice;
                retval.OK = true;
            }
            else
            {
                retval.OK = false;
                retval.Choice = "Cancel";
            }
            return retval;
        }
        public class Result
        {
            public string Choice;
            public bool OK = false;
        }
    }
}
