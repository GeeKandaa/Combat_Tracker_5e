﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Controls
{
    class NewPartyList_ListBox : ListBox
    {
        Managed_Button clear_button;
        Managed_Button confirmed_button;
        Managed_Button remove_button;

        public NewPartyList_ListBox()
        {
            this.SelectionMode = SelectionMode.MultiExtended;
        }
        public void Attach_Button(Managed_Button clr_btn, Managed_Button cfm_btn, Managed_Button rm_btn)
        {
            clear_button = clr_btn;
            confirmed_button = cfm_btn;
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
            confirmed_button.Enabled = true;
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
            if (this.Items.Count == 0)
            {
                clear_button.Enabled = false;
                confirmed_button.Enabled = false;
            }
        }
        public void RemoveAll()
        {
            this.Items.Clear();
            clear_button.Enabled = false;
            confirmed_button.Enabled = false;
        }

        public Queue<string> Get_Members()
        {
            Queue<string> party_list = new();
            foreach (string member in this.Items)
            {
                party_list.Enqueue(member);
            }
            return party_list;
        }
    }
}
