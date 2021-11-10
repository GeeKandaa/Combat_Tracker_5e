using CombatTracker5e.Dialogs;
using CombatTracker5e.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CombatTracker5e.Model
{
    public class Combatents
    {

        int currentlyActive_i;
        /// <summary>
        /// Private constructor to follow singleton pattern.
        /// </summary>
        private Combatents() { }

        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static Combatents Instance { get; private set; } = new();
        
        /// <summary>
        /// Contains all characters regardless of type
        /// </summary>
        public List<Character> AllCombatents = new();

        /// <summary>
        /// Contains player type characters
        /// </summary>
        private readonly List<Character> PlayerCombatents = new();
        
        /// <summary>
        /// Contains NPC type characters
        /// </summary>
        private readonly List<Character> NpcCombatents = new();

        /// <summary>
        /// Writes current characters to file.
        /// </summary>
        /// <param name="path">string indicating file path to write to</param>
        public void SaveToFile(string path)
        {
            using StreamWriter sw = new(path);
            sw.WriteLine("!FILEFORMAT: Name,hp,max_hp,stunned,concentrating");
            sw.WriteLine("!FILEFORMAT: text,numeric,numeric,true/false,true/false");
            sw.WriteLine("#PLAYER");
            foreach (Character player in PlayerCombatents)
            {
                sw.WriteLine(player.Name + "," + player.HpCsv.ToString() + "," + player.Stunned.ToString() + "," + player.Concentrating.ToString());
            }
            sw.WriteLine("#NPC");
            foreach (Character npc in NpcCombatents)
            {
                sw.WriteLine(npc.Name + "," + npc.HpCsv.ToString() + "," + npc.Stunned.ToString() + "," + npc.Concentrating.ToString());
            }
        }

        /// <summary>
        /// Reads information from a saved text file to generate Players and NPCs.
        /// </summary>
        /// <param name="path">Path of saved text file</param>
        public void LoadFromFile(string path)
        {
            AllCombatents.Clear();
            PlayerCombatents.Clear();
            NpcCombatents.Clear();

            try
            {
                using StreamReader sr = new(path);
                string type = "";
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == '!')
                    {
                        continue;
                    }
                    if (line[0] == '#')
                    {
                        type = line[1..];
                        continue;
                    }
                    string[] CharacterData = line.Split(",");
                    if (type == "PLAYER")
                    {
                        PlayerCombatents.Add
                        (
                            new Character
                            (
                                CharacterData[0],
                                Convert.ToInt32(CharacterData[1]),
                                Convert.ToInt32(CharacterData[2]),
                                "Player",
                                Convert.ToBoolean(CharacterData[3]),
                                Convert.ToBoolean(CharacterData[4])
                            )
                        );
                    }
                    if (type == "NPC")
                    {
                        NpcCombatents.Add
                        (
                            new Character
                            (
                                CharacterData[0],
                                Convert.ToInt32(CharacterData[1]),
                                Convert.ToInt32(CharacterData[2]),
                                "NPC",
                                Convert.ToBoolean(CharacterData[3]),
                                Convert.ToBoolean(CharacterData[4])
                            )
                        );
                    }
                }
                ComposeAllCombatents();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The file you are trying to load contains invalid or outdated data! The application will now close to prevent loss of data."+
                    "\nYou may try to fix this by creating a new party and manually saving the party. You can then confirm the old file matches the format specified in the new file."+
                    "\nWarning: If the file you are trying to load is an autosave make sure to create a backup before creating a new party or else it will be overwritten."+
                    $"\n\n The current file you are trying to load can be found at:\n {path}", "Could not load file..");
                BaseController.Instance.CanSave = false;
                Application.Exit();
            }
        }

        /// <summary>
        /// Repopulates combatent list.
        /// </summary>
        private void ComposeAllCombatents()
        {
            AllCombatents.Clear();
            foreach(Character player in PlayerCombatents)
            {
                AllCombatents.Add(player);
            }
            foreach(Character npc in NpcCombatents)
            {
                AllCombatents.Add(npc);
            }
        }

        /// <summary>
        /// Generates a BindingSource from the current list of combatents.
        /// </summary>
        /// <returns>BindingSource</returns>
        public BindingSource GetBinding() 
        {
            BindingSource BindSource = new();
            foreach (Character combatent in AllCombatents)
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
            int[] values = Array.Empty<int>();
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

        /// <summary>
        /// Removes character from appropriate type list and from databinding list
        /// </summary>
        /// <param name="fleeingCharacter">Character to be removed</param>
        public void RemoveCharacter(Character fleeingCharacter)
        {
            if (fleeingCharacter.Type == "Player") PlayerCombatents.Remove(fleeingCharacter);
            else if (fleeingCharacter.Type == "NPC") NpcCombatents.Remove(fleeingCharacter);
            ComposeAllCombatents();
        }

        /// <summary>
        /// Generate player of specified type and populates appropriate list and databinding list
        /// </summary>
        /// <param name="type">Character type</param>
        /// <param name="res">NewCharacterDialog Result containing character data</param>
        public void AddCombatent(string type, Dialogs.NewCharacterDialog.Result res)
        {
            Character newChar = new(res.Name, res.Hp, res.MaxHp, type);
            if (type == "Player") PlayerCombatents.Add(newChar);
            else if (type == "NPC") NpcCombatents.Add(newChar);
            ComposeAllCombatents();
        }

        /// <summary>
        /// Displays a dialog for each character for user to set intitiative values.
        /// </summary>
        public void SetInitiatives()
        {
            foreach (Character character in AllCombatents)
            {
                string[] dialogText = new string[] { "Set Initiative", "What is thier initiative?", "Initiative" };
                int ID = AllCombatents.IndexOf(character);
                int[] value = GetValuesFromUser(new int[] { ID }, dialogText);
                character.SetInitiative(value[ID]);
            }
            VerifyAndCorrectInitiatives();
        }

        private int GetDistinctCount(KeyValuePair<int,int>[] arr)
        {
            int previous = -1;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int next = arr[i].Value;
                if (next != 0 && (next != previous || previous == -1))
                {
                    count++;
                    previous = next;
                }
                else if(next==0)
                {
                    count++;
                }
            }
            return count;
        }

        public void VerifyAndCorrectInitiatives()
        {
            KeyValuePair<int, int>[] inits = new KeyValuePair<int, int>[AllCombatents.Count];
            for (int i = 0; i < AllCombatents.Count; i++)
            {
                inits[i] = new KeyValuePair<int, int>(i, Convert.ToInt32(AllCombatents[i].Initiative));
            }

            inits = inits.OrderBy(x => x.Value).ToArray();
            int count = GetDistinctCount(inits);
            List<KeyValuePair<int, int>> changedInits = new();
            while (inits.Length != count)
            {
                List<KeyValuePair<int, int>> changingInits = new();
                int currentMatchingInit = 0;
                for (int i = 0; i < inits.Length; i++)
                {
                    if (i == inits.Length - 1) break;
                    if (inits[i].Value == 0) continue;
                    if (changedInits.Contains(inits[i]))
                    {
                        if (inits[i].Value == inits[i + 1].Value)
                        {
                            for(int j = i+1; j < inits.Length; j++)
                            {
                                inits[j] = new KeyValuePair<int, int>(inits[j].Key, inits[j].Value + 1);
                            }
                        }
                        continue;
                    }
                    if (inits[i].Value != currentMatchingInit && currentMatchingInit != 0) break;
                    if (inits[i].Value == inits[i + 1].Value)
                    {
                        if (currentMatchingInit == 0) currentMatchingInit = inits[i].Value;
                        if (!changingInits.Contains(inits[i])) changingInits.Add(inits[i]);
                        changingInits.Add(inits[i+1]);
                    }
                }
                
                ////////////////////////////////
                List<int> toChange = new();
                
                foreach (KeyValuePair<int,int> pair in changingInits)
                {
                    toChange.Add(pair.Key);
                }
                if(toChange.Count!=0) toChange = UserChooseOrder.Show(toChange);
                int sequentialModifier = 0;
                foreach (int i in toChange)
                {
                    foreach(KeyValuePair<int,int> pair in changingInits)
                    {
                        if (pair.Key == i)
                        {
                            KeyValuePair<int, int> new_pair = new (pair.Key, pair.Value + sequentialModifier);

                            int changingIndex = changingInits.IndexOf(pair);
                            changingInits[changingIndex] = new_pair;

                            int realIndex = Array.IndexOf(inits,pair);
                            inits[realIndex] = new_pair;

                            changedInits.Add(new_pair);

                            sequentialModifier++;
                            break;
                        }
                    }
                }
                ////////////////////////////////

                count = GetDistinctCount(inits);
            }

            for (int i = 0; i < AllCombatents.Count; i++)
            {
                AllCombatents[inits[i].Key].SetInitiative(inits[i].Value);
            }
        }

        /// <summary>
        /// Finds the initial character in a combat round (highest initiative that isn't == 0) and 
        /// sets thier status to active. In the case that the character is stunned, the next turn 
        /// is automatically called. 
        /// </summary>
        public void StartCombat()
        {
            int max_initiative = int.MinValue;
            for(int i = 0; i < AllCombatents.Count; i++)
            {
                if (Convert.ToInt32(AllCombatents[i].Initiative) > max_initiative)
                {
                    currentlyActive_i = i;
                    max_initiative = Convert.ToInt32(AllCombatents[i].Initiative);
                }
            }
            if (max_initiative <= 0) return;
            bool stunned = AllCombatents[currentlyActive_i].SetActive();
            if (stunned) NextTurn();
        }

        /// <summary>
        /// Finds the next character to perform a turn (highest initiative less than the current
        /// active character's). In the case that the character is stunned, the next turn 
        /// is automatically called.
        /// </summary>
        public void NextTurn()
        {
            AllCombatents[currentlyActive_i].IsActive = false;
            int max_initiative = int.MinValue;
            int previous_initiative = Convert.ToInt32(AllCombatents[currentlyActive_i].Initiative);
            for (int i = 0; i < AllCombatents.Count; i++)
            {
                int test_initiative = Convert.ToInt32(AllCombatents[i].Initiative);
                if (test_initiative > max_initiative && test_initiative < previous_initiative && test_initiative != 0)
                {
                    currentlyActive_i = i;
                    max_initiative = Convert.ToInt32(AllCombatents[i].Initiative);
                }
            }
            if (max_initiative == int.MinValue)
            {
                StartCombat();
                return;
            }
            bool stunned = AllCombatents[currentlyActive_i].SetActive();
            if (stunned) NextTurn();
        }

        /// <summary>
        /// Removes the active characters active status and resets initiative of all 
        /// characters to 0.
        /// </summary>
        public void EndCombat()
        {
            AllCombatents[currentlyActive_i].IsActive = false;
            foreach(Character character in AllCombatents)
            {
                character.SetInitiative(0);
            }
        }
    }
}
