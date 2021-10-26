using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Model
{
    public interface ICombatable
    {
        public string Status { get; }
        public string Name { get; }
        public string Hp { get; }
        public string Initiative { get; }
        public bool Stunned { get; }
        public bool Concentrating { get; set; }

        public void TakeDamage(int dmg) { }
        public void HealDamage(int dmg) { }
        public void SetInitiative() { }
        public void FlipConcentrating()
        {
            Concentrating = !Concentrating;
        }
        public void FlipStun() { }
        public void Flee() { }
    }
}
