using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatTracker5e.FileFunctions;
using CombatTracker5e.Model;

namespace CombatTracker5e.Controller
{
    public class BaseController
    {
        private BaseController() { }
        public static BaseController Instance { get; private set; } = new();

        public readonly string AutoSaveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CombatTracker5e\\";
        public string AutoSaveFile { get; private set; }

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
        public void HandleAction(string action, string arg)
        {
            switch (action)
            {
                case ("Load" or "Auto"):
                    Combatents.Instance.LoadFromFile(arg);
                    return;
                case "New":
                    return;
                default:
                    return;
            }
        }
        public void SyncDisplayData(DataGridView display)
        {
            Combatents.Instance.Sync(display);
        }
    }
}
