using CombatTracker5e.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CombatTracker5e.Model
{
    public class Combatents
    {
        private Combatents() { }
        public static Combatents Instance { get; private set; } = new();
        
        public List<ICombatable> AllCombatents = new();

        /// <summary>
        /// Reads information from a saved text file to generate Players and NPCs.
        /// </summary>
        /// <param name="path">Path of saved text file</param>
        public void LoadFromFile(string path)
        {
            AllCombatents.Clear();
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

        /// <summary>
        /// Generates a BindingSource from the current list of combatents.
        /// </summary>
        /// <returns>BindingSource</returns>
        public BindingSource GetBinding() 
        {
            BindingSource BindSource = new();
            foreach (ICombatable combatent in AllCombatents)
            {
                BindSource.Add(combatent);
            }
            return BindSource;
        }

        /// <summary>
        /// Overloading method. Does not display a UserInput dialog.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        /// <param name="combatentAction">Action to be performed on the characters.</param>
        public void PerformActionOnSelected(string playerIds, string combatentAction) 
        {
            PerformActionOnSelected(playerIds, string.Empty, string.Empty, combatentAction);
        }

        /// <summary>
        /// Performs an action on all players denoted by player ID. Displays a dialog by default to set 
        /// argument value for the action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        /// <param name="title">Dialog title text</param>
        /// <param name="prompt">Dialog prompt text.</param>
        /// <param name="combatentAction">Action to be performed on the characters.</param>
        public void PerformActionOnSelected(string playerIds, string title, string prompt, string combatentAction) 
        {
            int[] playerId = Array.ConvertAll(playerIds.Split(','), int.Parse);
            int[] values = new int[] { };
            if (combatentAction == "Damage" || combatentAction == "Heal")
            {
                string[] dialogText = new string[] { title, prompt, combatentAction };
                values = GetValuesFromUser(playerId, dialogText);
            }
            foreach (int ID in playerId.Reverse())
            {
                int i = Convert.ToInt32(ID);
                switch (combatentAction)
                {
                    case "Damage":
                        AllCombatents[i].TakeDamage(values[ID]);
                        break;
                    case "Heal":
                        AllCombatents[i].HealDamage(values[ID]);
                        break;
                    case "Stun":
                        AllCombatents[i].FlipStun();
                        break;
                    case "Concentrating":
                        AllCombatents[i].FlipConcentrating();
                        break;
                    case "Flee":
                        AllCombatents[i].Flee();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Prompts the user to enter specific values for performing character actions.
        /// </summary>
        /// <param name="players">An array of character IDs to perform actions</param>
        /// <param name="dialogText">An string array containing UserInput dialog options</param>
        /// <returns></returns>
         private int[] GetValuesFromUser(int[] players, string[] dialogText)
        {
            int[] values = new int[players.Max() + 1];
            int recalledInput = 0;
            foreach (int ID in players)
            {
                UserInput.Result res = UserInput.Show
                (
                    dialogText[0], 
                    $"{AllCombatents[ID].Name}\n" + dialogText[1], 
                    recalledInput, 
                    dialogText[2]
                );

                values[ID] = res.Value;
                if (res.Recall != 0) recalledInput = res.Recall;
            }
            return values;
        }
        /// <summary>
        /// Passes default values to PerformActionOnSelected for Damage action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        public void DamagePlayers(string playerIds)
        {
            PerformActionOnSelected
            (
                playerIds,
                "Damage Character",
                "How much damage should be taken?",
                "Damage"
            );
        }

        /// <summary>
        /// Passes default values to PerformActionOnSelected for Heal action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        public void HealPlayers(string playerIds)
        {
            PerformActionOnSelected
            (
                playerIds,
                "Heal Character",
                "How much health should be restored?",
                "Heal"
            );
        }

        /// <summary>
        /// Passes default values to PerformActionOnSelected for Stun action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        public void PlayersStunFlip(string playerIds)
        {
            PerformActionOnSelected(playerIds, "Stun");
        }

        /// <summary>
        /// Passes default values to PerformActionOnSelected for Concentrating action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        public void PlayersConcentratingFlip(string playerIds)
        {
            PerformActionOnSelected(playerIds, "Concentrating");
        }

        /// <summary>
        /// Passes default values to PerformActionOnSelected for Flee action.
        /// </summary>
        /// <param name="playerIds">Comma seperated string of characters that will be affected.</param>
        public void PlayersFlee(string playerIds)
        {
            PerformActionOnSelected(playerIds, "Flee");
        }
    }
}
