using System;

namespace Combat_Tracker_5e
{
    public partial class PartyCreation_Form : Forms.Managed_Form
    {

        public PartyCreation_Form()
        {
            InitializeComponent();
            nameInput.Attach_Button(Btn_AddChar);
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
                    CharList.AddMember(nameInput.Text);
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


        private void Btn_AddChar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
