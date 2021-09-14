using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    public sealed class Manager
    {
        // singleton setup
        public static Manager Instance { get; } = new Manager();
        private Manager() { }
        private Form Main_Form;

        // Register Main Form
        public void register_main(Form mainForm)
        {
            if (Main_Form == null) Main_Form = mainForm;
        }

        // party
        private Party party;
        public List<string> Party_List()
        {
            return party.get_party();
        }
        
        // UI Commands
        public void New()
        {
            Main_Form.Hide();
            Form2 f2 = new();
            f2.Show();
        }
    }
}
