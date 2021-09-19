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
        private List<Character> characters = new();
        public void Populate()
        {
            characters.Clear();
            this.Rows.Clear();
            foreach (Character player in Manager.Instance.Get_Party())
            {
                characters.Add(player);
                Update_Display();
            }

        }
        public void Update_Display()
        {
            this.Rows.Clear();
            foreach (Character player in characters)
            {
                string type;
                if (Manager.Instance.Get_Party().Contains(player))
                {
                    type = "PC";
                }
                else type = "NPC";
                //                   { Turn(Bool), Name, Type, Stun(Bool), Concentration(Bool), HP}
                string[] char_info = { "false", player.Char_Name, type, "false", "false", player.HP + "/" + player.Max_HP };
                this.Rows.Add(char_info);
            }
        }

        public void Add_NPC(Character npc)
        {
            characters.Add(npc);
            Update_Display();
        }

        public void Remove_NPC()
        {
            List<int> removal_i = new();
            foreach(DataGridViewRow row in this.SelectedRows)
            {
                removal_i.Add(row.Index);
            }
            foreach(int i in removal_i)
            {
                characters.RemoveAt(i);
                this.Rows.RemoveAt(i);
            }
        }
    }
}
