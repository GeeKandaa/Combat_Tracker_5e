using Combat_Tracker_5e.Player_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class CombatDisplay_DataGridView : DataGridView
    {
        public void Populate_Players()
        {
            this.Rows.Clear();
            foreach (Character player in Manager.Instance.Get_Party())
            {
                //                   { Turn(Bool), Name, Type, Stun(Bool), Concentration(Bool), HP}
                string[] char_info = { "false", player.Char_Name, "PC" , "false", "false", player.HP + "/" + player.Max_HP };
                this.Rows.Add(char_info);
            }
        }
    }
}
