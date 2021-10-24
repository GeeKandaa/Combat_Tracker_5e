using System;
using System.Drawing;
using System.Windows.Forms;
using CombatTracker5e.Dialog;
using CombatTracker5e.Controller;

namespace CombatTracker5e
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        private string ActionFromString(string cmd)
        {
            return cmd.Substring(6); 
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Point? pnt = null;
            string res = UserChooseStartup.Show(pnt);
            BaseController.HandleAction(ActionFromString(res));
            return;
        }

    }
}
