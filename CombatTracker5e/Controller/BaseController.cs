using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatTracker5e.FileFunctions;
using CombatTracker5e.Model;
using CombatTracker5e.View;

namespace CombatTracker5e.Controller
{
    public class BaseController
    {
        CombatentDisplay Display;
        private BaseController() { }
        public static BaseController Instance { get; private set; } = new();

        public readonly string AutoSaveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CombatTracker5e\\";
        public string AutoSaveFile { get; private set; }

        /// <summary>
        /// Creates default directory for autosave reference file.
        /// </summary>
        public void EnsureAutosaveFileIsValid()
        {
            string path = AutoSaveDirectory + "log.auto";
            AutoSaveFile = AutoSaveDirectory + "autosave.txt";
            Directory.CreateDirectory(AutoSaveDirectory);
            VerifyAutoSaveFile(path);
        }

        private void VerifyAutoSaveFile(string path)
        {
            FileStream fs = new(path, FileMode.OpenOrCreate);

            string contents = "";
            if (fs.Length != 0)
            {
                contents = FileManager.ReadBinaryFileToString(fs);
            }
            fs.Close();

            if (System.IO.File.Exists(contents)) AutoSaveFile = contents;
            else
            {
                fs = new(path, FileMode.Create);
                FileManager.WriteBinaryFileFromString(fs, AutoSaveFile);
            }
        }

        /// <summary>
        /// Handles user input.
        /// </summary>
        /// <param name="action">Command to be performed.</param>
        /// <param name="arg">Optional arguments to be supplied with commands.</param>
        public void HandleAction(string action, string arg="")
        {
            switch (action)
            {
                case ("Load" or "Auto"):
                    Combatents.Instance.LoadFromFile(arg);
                    SyncDisplayData();
                    break;
                case "New":
                    break;
                case "Damage":
                    Combatents.Instance.DamagePlayers(arg);
                    break;
                case "Heal":
                    Combatents.Instance.HealPlayers(arg);
                    break;
                case "Stun":
                    Combatents.Instance.PlayersStunFlip(arg);
                    break;
                case "Concentrating":
                    Combatents.Instance.PlayersConcentratingFlip(arg);
                    break;
                case "Flee":
                    Combatents.Instance.PlayersFlee(arg);
                    break;
                default:
                    break;
            }
            Display.Invalidate();
        }

        /// <summary>
        /// Registers the CombatentDisplay to a class variable in Controller for referencing.
        /// </summary>
        /// <param name="display">Display for syncing combatent list data</param>
        public void RegisterDisplay(CombatentDisplay display)
        {
            Display = display;
        }

        /// <summary>
        /// Generates new binding to sync to registered CombatentDisplay.
        /// </summary>
        public void SyncDisplayData()
        {
            BindingSource binding = Combatents.Instance.GetBinding();
            Display.DataSource = binding;
        }
    }
}
