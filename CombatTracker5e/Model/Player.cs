using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Model
{
    class Player
    {
        public string Name { get; }
        public string MaxHp { get; private set; }
        private int _MaxHp;
        public string CurrentHp { get; private set; }
        private int _CurrentHp;
        public string Initiative { get; private set; }
        private int _Initiative;
        public string Stunned { get; private set; }
        private bool _Stunned;
        public string Concentrating { get; private set; }
        private bool _Concentrating;

        public Player(string name, int currentHp, int maxHp)
        {
            Name = name;
            _CurrentHp = currentHp;
            _MaxHp = maxHp;
            _Stunned = false;
            _Concentrating = false;
        }


    }
}
