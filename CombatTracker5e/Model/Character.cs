using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.Model
{
    public class Character
    {
        public string Name { get; }
        public string Type { get { return _type; } }
        private readonly string _type;
        private int _CurrentHp;
        private int _MaxHp;
        public string HpCsv
        {
            get
            {
                ValidateHp();
                return _CurrentHp.ToString() + "," + _MaxHp.ToString();
            }
        }
        public string Hp
        {
            get
            {
                ValidateHp();
                return _CurrentHp.ToString() + "/" + _MaxHp.ToString();
            }
        }
        public string Initiative{ get { return _Initiative.ToString(); } }
        private int _Initiative;
        public bool Stunned
        {
            get { return _Stunned; }
            set { _Stunned = value; }
        }
        private bool _Stunned;
        public bool Concentrating
        {
            get { return _Concentrating; }
            set { _Concentrating = value; }
        }
        private bool _Concentrating;
        public string Status
        {
            get
            {
                if (IsActive) return "Active";
                return "";
            }
        }
        public bool IsActive;
        public Character(string name, int currentHp, int maxHp, string type) : this(name, currentHp, maxHp, type, false, false) { }

        public Character(string name, int currentHp, int maxHp, string type, bool stunned, bool concentrating)
        {
            Name = name;
            _type = type;
            _CurrentHp = currentHp;
            _MaxHp = maxHp;
            _Stunned = stunned;
            _Concentrating = concentrating;
            IsActive = false;
        }


        private void ValidateHp()
        {
            if (_MaxHp < 0) _MaxHp = 0;
            if (_CurrentHp < -_MaxHp) _CurrentHp = -_MaxHp;
            if (_CurrentHp > _MaxHp) _CurrentHp = _MaxHp;
        }
        public void TakeDamage(int dmg)
        {
            _CurrentHp -= dmg;
            if (Type == "NPC" && _CurrentHp <= 0) Flee();
            if (Concentrating)
            {
                DialogResult res = MessageBox.Show($"{Name} is still concentrating on a spell! Did they lose thier concentration?", "Concentration Check", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;
                FlipConcentrating();
            }
            
        }
        public void HealDamage(int dmg)
        {
            _CurrentHp += dmg;
        }
        public void FlipConcentrating()
        {
            Concentrating = !Concentrating;
        }
        public void FlipStun()
        {
            Stunned = !Stunned;
        }
        public void SetInitiative(int value)
        {
            _Initiative = value;
        }

        public bool SetActive()
        {
            IsActive = true;
            if (Stunned)
            {
                DialogResult res = MessageBox.Show($"{Name} is stunned! Should they be free to move next turn?", "Unable to move!", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return true;
                FlipStun();
                return true;
            }
            return false;
            

        }
        public void Flee()
        {
            if (Type == "Player")
            {
                DialogResult res = MessageBox.Show("You are about to remove a Player Character from the party. Are you sure?", "WARNING", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;
            }
            Combatents.Instance.RemoveCharacter(this);
        }
    }
}
