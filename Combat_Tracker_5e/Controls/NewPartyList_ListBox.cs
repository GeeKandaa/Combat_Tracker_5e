using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class NewPartyList_ListBox : ListBox
    {
        Managed_Button clear_button;
        Managed_Button remove_button;
        Queue<string> party_list = new();

        public NewPartyList_ListBox()
        {
            this.SelectionMode = SelectionMode.MultiExtended;
        }
        public void Attach_Button(Managed_Button clr_btn, Managed_Button rm_btn)
        {
            clear_button = clr_btn;
            remove_button = rm_btn;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (this.SelectedIndex != -1)
            {
                remove_button.Enabled = true;
            }
            else
            {
                remove_button.Enabled = false;
            }
        }
        public void AddMember(string char_name)
        {
            this.Items.Add(char_name);
            clear_button.Enabled = true;
        }
        public void RemoveMember()
        {
            this.BeginUpdate();
            List<int> removal_i = new(this.SelectedIndices.Cast<int>());
            removal_i.Reverse();

            foreach (int i in removal_i)
            {
                this.Items.RemoveAt(i);
            }
            this.EndUpdate();
            if (this.Items.Count == 0) clear_button.Enabled = false;
        }

    }
}
