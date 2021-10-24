using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Model
{
    interface ICombatable
    {
        public void TakeDamage(int dmg) { }
        public void HealDamage(int dmg) { }
        public void SetInitiative() { }
        public void RemoveCharacter() { }
    }
}
