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
                    //Check HP input
                    if (!Verify_Hp(HpInput.Text)) {
                        Display_Error();
                        return true;
                    }
                    int[] hp_parts = HP_To_Int(HpInput.Text);
                    if (hp_parts[0] == -1) return true;

                    //Hp input passed check
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

        private bool Verify_Hp(string input)
        {
            string[] test_array = input.Split("/");
            if (test_array.Length > 2) return false;
            foreach(string test_str in test_array)
            {
                if (!test_str.All(char.IsDigit)) return false;
            }
            return true;
        }

        private int[] HP_To_Int(string num_txt)
        {
            string[] hp_strings = HpInput.Text.Split("/");
            int[] hp_ints= new int[2];
            for(int i = 0;i < hp_strings.Length; i++)
            {
                try
                {
                    hp_ints[i] = Int32.Parse(hp_strings[i]);
                }
                catch (FormatException)
                {
                    Display_Error();
                    hp_ints[0] = -1;
                }
            }
            if (hp_ints[1] == 0) hp_ints[1] = hp_ints[0];
            return hp_ints;
        }

        private void Display_Error()
        {
            string caption = "HP Parse Error!";
            string msg = "HP should be integers. If character is not at maximum health, please specify in the following format:\n hp/max";
            MessageBox.Show(msg, caption);
        }
    }
}
