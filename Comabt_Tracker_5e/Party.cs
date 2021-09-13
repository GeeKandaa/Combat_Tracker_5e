using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Tracker_5e
{
    public class Party
    {
        private List<string> Members;
    
        public void New()
        {
            Console.WriteLine("Create new party.");
        }

        public void Load()
        {
            Console.WriteLine("Load saved party.");
        }

        public void Save()
        {
            Console.WriteLine("Save party.");
        }
    }
}
