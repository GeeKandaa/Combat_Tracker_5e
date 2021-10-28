using CombatTracker5e.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    /// <summary>
    /// Load Dialog Class
    /// </summary>
    class Load
    {
        /// <summary>
        /// Displays Load dialog.
        /// </summary>
        /// <returns>String indicating file path to load from</returns>
        public static string Show()
        {
            string path;
            using (OpenFileDialog dialog = new())
            {
                dialog.InitialDirectory = BaseController.Instance.AutoSaveDirectory;
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    return path;
                }
            }
            return string.Empty;
        }
    }

    /// <summary>
    /// Save Dialog Class
    /// </summary>
    class Save
    {
        /// <summary>
        /// Display Save dialog.
        /// </summary>
        /// <returns>String indicating file path to save to</returns>
        public static string Show()
        {
            string path;
            using (SaveFileDialog dialog = new())
            {
                dialog.InitialDirectory = BaseController.Instance.AutoSaveDirectory;
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    return path;
                }
            }
            return string.Empty;
        }
    }
}
