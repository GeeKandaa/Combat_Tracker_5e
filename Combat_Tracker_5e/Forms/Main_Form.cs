using Combat_Tracker_5e.Controls;
using Combat_Tracker_5e.Player_Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public partial class Main_Form : Forms.Managed_Form
    {
        List<Managed_Button> buttons;
        public Main_Form()
        {
            InitializeComponent();
        }

        public override bool Handle_Action(string action)
        {
            InputBoxResult result;
            switch (action)
            {
                case "NewParty":
                    Manager.Instance.New();
                    return true;
                case "Quit":
                    Manager.Instance.quit_form(this);
                    return true;
                case "Add":
                    int[] hp_parts = Manager.Instance.Verify_Hp(HpInput.Text);
                    if (!(hp_parts.Length > 0)) return true;

                    Character new_npc;
                    if (hp_parts.Length == 1)
                    {
                        new_npc = new(NameInput.Text, hp_parts[0]);
                    }
                    else new_npc = new(NameInput.Text, hp_parts[0], hp_parts[1]);

                    combatDisplay_DataGridView1.Add_NPC(new_npc);
                    return true;
                case "Damage":
                    result = InputBox.Show("", "Damage", "Default text", null);
                        if (result.OK)
                        {
                            combatDisplay_DataGridView1.Damage_Selected(Convert.ToInt32(result.Text));
                        }
                    return true;
                case "Heal":
                    result = InputBox.Show("", "Damage", "Default text", null);
                    if (result.OK)
                    {
                        combatDisplay_DataGridView1.Heal_Selected(Convert.ToInt32(result.Text));
                    }
                    return true;
                case "Flee":
                    combatDisplay_DataGridView1.Remove_NPC();
                    return true;
                default:
                    return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manager.Instance.register_main(this);
            NameInput.Set_GhostText("NPC Name");
            HpInput.Set_GhostText("NPC Hit Points");
            NameInput.Attach_Button(Btn_Add);
            HpInput.Attach_Button(Btn_Add);

            buttons = new List<Managed_Button>()
            {
                Btn_Damage,
                Btn_Heal,
                Btn_Concentrate,
                Btn_Stun,
                Btn_Flee
            };
            combatDisplay_DataGridView1.Attach_Buttons(buttons);
            combatDisplay_DataGridView1.Attach_Buttons(Btn_EndTurn, "On");
            combatDisplay_DataGridView1.Attach_Buttons(Btn_Initiative, "Off");
            combatDisplay_DataGridView1.Attach_Buttons(Btn_Combat, "Switch");
        }
    }
}
