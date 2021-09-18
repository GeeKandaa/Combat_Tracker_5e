using System;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class Managed_Button : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Manager.Instance.HandleButtonAction(this.Name[4..]);
        }
    }
}
