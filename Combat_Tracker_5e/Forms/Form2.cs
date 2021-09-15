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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            nameInput.Attach_Button(Btn_AddChar);
        }

        private void Btn_CancelNew_Click(object sender, EventArgs e)
        {
            Manager.Instance.quit_form(this);   
        }
    }
}
