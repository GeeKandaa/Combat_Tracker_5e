using System.Collections.Generic;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public sealed class Manager
    {
        // singleton setup
        public static Manager Instance { get; } = new Manager();
        private Manager() { }
        private Form Main_Form;
        private Form active_form;
        private Stack<Form> previous_forms = new();
        // Register Main Form
        public void register_main(Form mainForm)
        {
            if (Main_Form == null) Main_Form = mainForm;
            active_form = mainForm;
        }

        // party
        private Party party;
        public List<string> Party_List()
        {
            return party.get_party();
        }
        
        public void quit_form(Form exiting_form)
        {
            exiting_form.Close();
            active_form = previous_forms.Pop();
            active_form.Show();
        }

        // UI Commands
        public void New()
        {
            previous_forms.Push(active_form);
            Main_Form.Hide();
            Form2 f2 = new();
            active_form = f2;
            f2.Show();
        }
    }
}
