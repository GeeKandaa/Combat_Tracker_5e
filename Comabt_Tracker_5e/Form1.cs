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
    public partial class Form1 : Form
    {
        Party party;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            party = new();

        }

        private void NewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.Show();
        }
    }
}
