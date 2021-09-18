using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Combat_Tracker_5e.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class Managed_MenuItem : ToolStripMenuItem
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Manager.Instance.HandleButtonAction(this.Name[4..]);
        }
    }
}
