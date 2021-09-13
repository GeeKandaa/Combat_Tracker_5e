using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Tracker_5e
{
    public sealed class Manager
    {
        public static Manager Instance { get; } = new Manager();
        private Manager() { }

        private Party party;
    }
}
