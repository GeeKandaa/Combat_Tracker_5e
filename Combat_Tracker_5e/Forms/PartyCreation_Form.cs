using Combat_Tracker_5e.Player_Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public partial class PartyCreation_Form : Forms.Managed_Form
    {

        public PartyCreation_Form()
        {
            InitializeComponent();
            NameInput.Set_GhostText("Character Name: eg. Joe Bloggs");
            HpInput.Set_GhostText("Hp/Max: eg. 17/34");
            NameInput.Attach_Button(Btn_AddChar);
            HpInput.Attach_Button(Btn_AddChar);
            CharList.Attach_Button(Btn_Clear, Btn_Confirm, Btn_RemoveChar);
        }

        public override bool Handle_Action(string action)
        {
            switch (action)
            {
                case "Cancel":
                    Manager.Instance.quit_form(this);
                    return true;

                case "AddChar":
                    int[] hp_parts = Manager.Instance.Verify_Hp(HpInput.Text);
                    if (!(hp_parts.Length > 0)) return true;

                    Character new_player;
                    if (hp_parts.Length == 1) 
                    {
                        new_player = new(NameInput.Text, hp_parts[0]);
                    } else new_player = new(NameInput.Text,hp_parts[0],hp_parts[1]);

                    CharList.AddMember(new_player);
                    return true;

                case "RemoveChar":
                    CharList.RemoveMember();
                    return true;

                case "Clear":
                    CharList.RemoveAll();
                    return true;

                case "Confirm":
                    Manager.Instance.New_Party(CharList.Get_Members());
                    Manager.Instance.quit_form(this);
                    return true;

                default:
                    return false;
            }
        }
    }
}
