using System.Windows.Forms;

namespace Combat_Tracker_5e.Player_Classes
{
    class Character
    {
        private string name;
        private int initiative;
        private bool stunned = false;
        private bool concentrating = false;
        private int hp;
        private int hp_max;

        public Character(string Name_str, int Hp_int, int Hp_Max_int = -1)
        {
            name = Name_str;
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

        public void Set_Initiative(int init)
        {
            initiative = init;
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
