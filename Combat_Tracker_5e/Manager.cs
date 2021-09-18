﻿using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Tracker_5e.Forms;
using Combat_Tracker_5e.Player_Classes;

namespace Combat_Tracker_5e
{
    public sealed class Manager
    {
        // singleton setup
        public static Manager Instance { get; } = new Manager();
        private Manager() { }
        private Managed_Form Main_Form;
        private Character_Tree char_tree;
        private Managed_Form active_form;
        private Stack<Managed_Form> previous_forms = new();
        // Register Main Form
        public void register_main(Managed_Form mainForm)
        {
            if (Main_Form == null) Main_Form = mainForm;
            active_form = mainForm;
            foreach (Control control in active_form.Controls)
            {
                if (control.GetType().Name == "Character_Tree")
                {
                    char_tree = (Character_Tree)control;
                    break;
                }
            }
        }

        // party
        private Party party = new();
        public void New_Party(Queue<string> members)    
        {
            party.New(members);
            char_tree.Populate_Players();
        }
        public List<string> Party_List()
        {
            return party.Get_Party();
        }
        
        // UI Commands
        public void New()
        {
            previous_forms.Push(active_form);
            Main_Form.Hide();
            PartyCreation_Form f2 = new();
            active_form = f2;
            f2.Show();
        }
        public void HandleButtonAction(string action)
        {
            if (active_form.Handle_Action(action) == true) return;
            foreach(Managed_Form form in previous_forms)
            {
                if (form.Handle_Action(action) == true) return;
            }
        }
        public void quit_form(Managed_Form exiting_form)
        {
            if (exiting_form == Main_Form)
            {
                Application.Exit();
            }
            else
            {
                exiting_form.Close();
                active_form = previous_forms.Pop();
                active_form.Show();
            }
        }
    }
}
