using System;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public partial class Main_Form : Forms.Managed_Form
    {   
        public Main_Form()
        {
            InitializeComponent();
        }

        public override bool Handle_Action(string action)
        {
            switch (action)
            {
                case "NewParty":
                    Manager.Instance.New();
                    return true;
                case "Quit":
                    Manager.Instance.quit_form(this);
                    return true;
                default:
                    return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Manager.Instance.register_main(this);
        }

        private void NewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Instance.New();
        }
    }
}
