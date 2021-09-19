using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class Managed_Button : Button
    {
        Dictionary<CustomInput_TextBox, bool> connected_input = new();
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Manager.Instance.HandleButtonAction(this.Name[4..]);
        }
        public void Connect_To(CustomInput_TextBox txtbox)
        {
            connected_input.Add(txtbox, false);
        }
        public void Try_Enable(CustomInput_TextBox txtBox, bool val)
        {
            connected_input[txtBox] = val;
            if (connected_input.Values.Distinct().Count() == 1 && connected_input.ContainsValue(true))
            {
                this.Enabled = true;
            }
            else this.Enabled = false;
        }
    }
}
