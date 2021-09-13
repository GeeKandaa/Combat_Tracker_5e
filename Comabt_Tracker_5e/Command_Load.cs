using System;
using System.IO;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    class Command_Load : ICommand
    {
        string filePath = string.Empty;

        public void Execute()
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader sr = new(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Read lines and set party member per line.
                        }
                    }
                }
            }
        }
    }
}
