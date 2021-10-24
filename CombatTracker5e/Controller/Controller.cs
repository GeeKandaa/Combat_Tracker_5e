using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.Controller
{
    public static class BaseController
    {
        public static void HandleAction(string action) 
        {
            switch (action)
            {
                case "Load":
                    return;
                case "Autosaved":
                    return;
                case "New":
                    return;
                default:
                    return;
            }
        }
    }
}
