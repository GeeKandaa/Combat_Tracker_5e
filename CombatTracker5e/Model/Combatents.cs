using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.Model
{
    public class Combatents
    {
        private Combatents() { }
        public static Combatents Instance { get; private set; } = new();
        
        public List<ICombatable> AllCombatents;

        public void LoadFromFile(string path)
        {
            AllCombatents = new();
            using (StreamReader sr = new(path))
            {
                string type="";
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == '#')
                    {
                        type = line.Substring(1, line.Length - 1);
                        continue;
                    }
                    string[] CharacterData = line.Split(",");
                    if (type == "PLAYER")
                    {
                        AllCombatents.Add
                        (
                            new Player
                            (
                                CharacterData[0],
                                Convert.ToInt32(CharacterData[1]),
                                Convert.ToInt32(CharacterData[2])
                            )
                        );
                    }
                }
            }
        }

        public void Sync(DataGridView display)
        {
            BindingSource BindSource = new();
            foreach (ICombatable combatent in AllCombatents)
            {
                BindSource.Add(combatent);
            }
            display.DataSource = BindSource;
        }

    }
}
