using CombatTracker5e.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    class Load
    {
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
}
