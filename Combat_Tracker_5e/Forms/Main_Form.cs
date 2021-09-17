using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public partial class Main_Form : Forms.Managed_Form
    {   
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Manager.Instance.register_main(this);
        }

        private void NewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Instance.New();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Possibly redundant
            character_Tree1.Cleanup();
            /////////////////
            Manager.Instance.quit_form(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Possibly redundant
            character_Tree1.Cleanup();
            /////////////////
            Manager.Instance.quit_form(this);
        }
    }
}
