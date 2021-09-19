using Combat_Tracker_5e.Player_Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class CombatDisplay_DataGridView : DataGridView
    {
        private List<Character> characters = new();
        private List<Managed_Button> buttons = new();
        private Managed_Button combatOn_button;
        private Managed_Button combatOff_button;
        private Managed_Button combatSwitch_button;
        //private List<Managed_Button> 

        public void Attach_Buttons(List<Managed_Button> btns)
        {
            foreach (Managed_Button btn in btns)
            {
                buttons.Add(btn);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="btns"></param>
        /// <param name="Combat_Status">"On"|"Off"|"Switch" - Defines if button is enabled in combat. Switch is specialised for Start Combat button</param>
        public void Attach_Buttons(Managed_Button btn, string Combat_Status)
        {
            switch (Combat_Status)
            {
                case "On":
                    combatOn_button = btn;
                    return;
                case "Off":
                    combatOff_button = btn;
                    return;
                case "Switch":
                    combatSwitch_button = btn;
                    return;
                default:
                    return;
            }
        }
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
                this.CurrentCell = null;
            }
        }

        public void Add_NPC(Character npc)
        {
            characters.Add(npc);
            Update_Display();
        }

        public void Remove_NPC()
        {
            List<int> removal_i = Get_Selected();
            removal_i.Sort();
            removal_i.Reverse();
            foreach(int i in removal_i)
            {
                if (Manager.Instance.Get_Party().Contains(characters[i])) continue;
                characters.RemoveAt(i);
                this.Rows.RemoveAt(i);
            }
            this.CurrentCell = null;
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
            if (this.SelectedRows.Count > 0)
            {
                foreach (Managed_Button btn in buttons)
                {
                    btn.Enabled = true;
                }
            }
            else
            {
                foreach (Managed_Button btn in buttons)
                {
                    btn.Enabled = false;
                }
            }
        }

        public List<int> Get_Selected() 
        {
            List<int> selected = new();
            foreach (DataGridViewRow row in this.SelectedRows)
            {
                selected.Add(row.Index);
            }
            return selected;
        }

        //public void Damage_Char()
        //{
        //    List<int> selected_i = Get_Selected();
        //    foreach(int i in selected_i)
        //    {
        //        characters[i].Survive_Damage()
        //    }
        //}
    }
}
