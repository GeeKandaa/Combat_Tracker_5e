using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
