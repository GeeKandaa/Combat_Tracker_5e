//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Combat_Tracker_5e
{
    public abstract class Command
    {
        public string Key { get; protected set; }
        public string DisplayName { get; protected set; }
        public bool Enabled { get; }
        public abstract void Execute();
    }
}
