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
                case "Add":
                    combatDisplay_DataGridView1.Add_NPC(new Player_Classes.Character(NameInput.Text, 13));
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
        }
    }
}
