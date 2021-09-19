using System;
using System.Drawing;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class CustomInput_TextBox : TextBox
    {
        private string ghost_text = "";
        private Managed_Button attached_btn;

        public void Set_GhostText(string msg)
        {
            ghost_text = msg;
        }
        public void Attach_Button(Managed_Button button)
        {
            attached_btn = button;
            attached_btn.Connect_To(this);
            Reset_Textfield();
        }
        private void Reset_Textfield()
        {
            this.Text = ghost_text;
            this.ForeColor = Color.LightGray;
            if (attached_btn!=null) attached_btn.Try_Enable(this,false);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.TextLength != 0)
            {
                if (attached_btn != null) attached_btn.Try_Enable(this,true);
                this.ForeColor = Color.Black;
            }
            else
            {
                if (attached_btn != null) attached_btn.Try_Enable(this,false);
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
