using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class NameInput_TextBox : TextBox
    {
        private Button attached_btn;

        public void Attach_Button(Button button)
        {
            attached_btn = button;
            Reset_Textfield();
        }
        private void Reset_Textfield()
        {
            this.Text = "Enter character name..";
            this.ForeColor = Color.LightGray;
            if (attached_btn!=null) attached_btn.Enabled = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.TextLength != 0)
            {
                attached_btn.Enabled = true;
                this.ForeColor = Color.Black;
            }
            else
            {
                attached_btn.Enabled = false;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            this.Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.TextLength == 0) Reset_Textfield();
        }
    }
}
