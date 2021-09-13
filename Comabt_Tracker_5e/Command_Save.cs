using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    class Command_Save : ICommand
    {
        readonly Queue<string> fileContent = new();

        public Command_Save(Queue<string> members)
        {
            while (members.Count != 0)
            {
                fileContent = members;
            }
        }
        public void Execute()
        {
            using (SaveFileDialog saveFileDialog = new())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.FileName = "Party.txt";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new(saveFileDialog.OpenFile()))
                    {
                        string line;
                        while ((line = fileContent.Dequeue()) != null)
                        {
                            sw.WriteLine(line);
                        }
                        sw.Dispose();
                        sw.Close();
                    }
                }
            }
        }
    }
}