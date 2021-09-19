using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Combat_Tracker_5e.Controls;
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
        private CombatDisplay_DataGridView combat_display;
        private Managed_Form active_form;
        private Stack<Managed_Form> previous_forms = new();
        // Register Main Form
        public void register_main(Managed_Form mainForm)
        {
            if (Main_Form == null) Main_Form = mainForm;
            active_form = mainForm;
            foreach (Control control in active_form.Controls)
            {
                if (control.GetType().Name == "CombatDisplay_DataGridView")
                {
                    combat_display = (CombatDisplay_DataGridView)control;
                    break;
                }
            }
        }

        // party
        private Party party = new();
        public void New_Party(List<Character> members)    
        {
            party.New(members);
            combat_display.Populate();
        }
        public List<Character> Get_Party()
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

        // Hitpoint input validation
        public int[] Verify_Hp(string hp_txt)
        {
            if (!Check_Format(hp_txt)) {
                Display_Error();
                return new int[0];
            }
            int[] hp_parts = HP_To_Int(hp_txt);
            if (hp_parts[0] == -1) return new int[0];
            return hp_parts;
        }
        private bool Check_Format(string hp_txt)
        {
            string[] test_array = hp_txt.Split("/");
            if (test_array.Length > 2) return false;
            foreach (string test_str in test_array)
            {
                if (!test_str.All(char.IsDigit)) return false;
            }
            return true;
        }

        private int[] HP_To_Int(string hp_txt)
        {
            string[] hp_strings = hp_txt.Split("/");
            int[] hp_ints = new int[hp_strings.Length];
            for (int i = 0; i < hp_strings.Length; i++)
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
