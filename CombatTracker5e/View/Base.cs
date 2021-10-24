using System;
using System.Drawing;
using System.Windows.Forms;
using CombatTracker5e.Dialog;
using CombatTracker5e.Controller;
using CombatTracker5e.View;
namespace CombatTracker5e
{
    public partial class Base : Form
    {
        CombatentDisplay combatentDisplay;
        public Base()
        {
            InitializeComponent();
            BaseController.Instance.EnsureAutosaveFileIsValid();
            Panel displayPanel = new Panel();
            displayPanel.Dock = DockStyle.Left;
            displayPanel.Width = (int)Math.Floor(Width*0.6);

            combatentDisplay = new(this);
            displayPanel.Controls.Add(combatentDisplay);
            Controls.Add(displayPanel);

            displayPanel = new Panel();
            displayPanel.Dock = DockStyle.Right;
            displayPanel.Width = (int)Math.Floor(Width * 0.4);
            displayPanel.BackColor = Color.Red;
            Controls.Add(displayPanel);

        }
        private string ActionFromString(string cmd)
        {
            return cmd[6..]; 
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Point? pnt = null;
            UserChooseStartup.Result res = UserChooseStartup.Show(pnt);
            if (res.action == null) Application.Exit();
            else BaseController.Instance.HandleAction(res.action,res.path);
            BaseController.Instance.SyncDisplayData(combatentDisplay);
            return;
        }

    }
}
