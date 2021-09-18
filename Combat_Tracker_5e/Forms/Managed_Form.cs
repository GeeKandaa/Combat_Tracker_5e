using System.Windows.Forms;

namespace Combat_Tracker_5e.Forms
{
    public partial class Managed_Form : Form
    {
        public Managed_Form()
        {
            InitializeComponent();
        }

        public virtual bool Handle_Action(string action)
        {
            return false;
        }
    }
}
