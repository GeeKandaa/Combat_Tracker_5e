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
            Reset_Textfield();
        }

        private void Reset_Textfield()
        {
            textfield_characterName.Text = "Enter character name..";
            textfield_characterName.ForeColor = Color.LightGray;
            btn_addchar.Enabled = false;
        }

        private void Textfield_CharacterName_TextChanged(object sender, EventArgs e)
        {
            if (textfield_characterName.TextLength != 0)
            {
                btn_addchar.Enabled = true;
                textfield_characterName.ForeColor = Color.Black;
            }
            else
            {
                btn_addchar.Enabled = false;
            }
        }

        private void Textfield_CharacterName_Enter(object sender, EventArgs e)
        {
            textfield_characterName.Text = "";
        }

        private void Textfield_CharacterName_Leave(object sender, EventArgs e)
        {
            if (textfield_characterName.TextLength == 0) Reset_Textfield();
        }

        private void btn_addchar_Click(object sender, EventArgs e)
        {

        }
    }
}
