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
                case "Btn_Cancel":
                    Manager.Instance.quit_form(this);
                    return true;
                case "Btn_AddChar":
                    CharList.AddMember(nameInput.Text);
                    return true;
                case "Btn_RemoveChar":
                    CharList.RemoveMember();
                    return true;
                case "Btn_Clear":
                    CharList.RemoveAll();
                    return true;
                case "Btn_Confirm":
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
