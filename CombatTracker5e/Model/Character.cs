using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Model
{
    class Character
    {
        public string Name { get; }
        public string MaxHp { get; }
        public string CurrentHp { get; private set; }
        public string Initiative { get; private set; }
        public string Stunned { get; private set; }
        public string Concentrating { get; private set; }


    }
}
