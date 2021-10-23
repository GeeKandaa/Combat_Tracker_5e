using System;
using System.Drawing;
using System.Windows.Forms;
using CombatTracker5e.Dialog;

namespace CombatTracker5e
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Point? pnt = null;
            string res = UserChooseStartup.Show(pnt);
            return;
        }

    }
}
