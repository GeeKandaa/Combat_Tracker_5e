using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Model
{
    class Player : ICombatable
    {
        public string Name { get; }
        private int _CurrentHp;
        private int _MaxHp;
        public string Hp 
        { 
            get 
            {
                ValidateHp();
                return _CurrentHp.ToString()+"/"+ _MaxHp.ToString(); 
            }
        }
        public string Initiative { get { return _Initiative.ToString(); }}
        private int _Initiative;
        public bool Stunned 
        { 
            get { return _Stunned; }
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
                if (_Status) return "Active";
                return ""; 
            }
        }
        private bool _Status;
        public Player(string name, int currentHp, int maxHp)
        {
            Name = name;
            _CurrentHp = currentHp;
            _MaxHp = maxHp;
            _Stunned = false;
            _Concentrating = false;
            _Status = false;
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
        }
        public void HealDamage(int dmg)
        {
            _CurrentHp += dmg;
        }
        public void FlipStun()
        {
            _Stunned = !_Stunned;
        }
    }
}
