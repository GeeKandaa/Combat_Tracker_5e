using System.Windows.Forms;

namespace Combat_Tracker_5e.Player_Classes
{
    public class Character
    {
        // private vars
        private string char_name;
        private int initiative;
        private bool stunned = false;
        private bool concentrating = false;
        private int hp;
        private int hp_max;

        //public property
        public string Char_Name { get { return char_name; } }
        public string Initiative { get { return initiative.ToString(); } }
        public string Stunned
        {
            get
            {
                if (stunned)
                {
                    return "1";
                }
                else return "0";
            }
        }
        public string Concentrating
        {
            get
            {
                if (concentrating)
                {
                    return "1";
                }
                else return "0";
            }
        }
        public string HP { get { return hp.ToString(); } }
        public string Max_HP { get { return hp_max.ToString(); } }

        //constructor&methods..
        public Character(string Name_str, int Hp_int, int Hp_Max_int = -1)
        {
            char_name = Name_str;
            hp = Hp_int;
            if (Hp_Max_int == -1)
            {
                hp_max = Hp_int;
            }
            else hp_max = Hp_Max_int;
        }

        public void Toggle_Stun()
        {
            if (stunned)
            {
                stunned = false;
            }
            else stunned = true;
        }

        public void Toggle_Concentration() 
        {
            if (concentrating)
            {
                concentrating = false;
            }
            else concentrating = true;
        }

        public void Heal_Damage(int dmg)
        {
            if (hp + dmg >= hp_max)
            {
                hp = hp_max;
            }
            else hp += dmg;
        }

        public bool Survive_Damage(int dmg)
        {
            Check_Concentration();
            hp -= dmg;
            if (hp < 1) return false;
            return true;
        }

        private void Check_Concentration()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Does this character maintain concentration?", "", buttons);
            if (result == DialogResult.Yes)
            {
                return;
            }
            else Toggle_Concentration();
        }
    }
}
