using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Combat_Tracker_5e.Player_Classes
{
    public class Party
    {
        private List<string> Members = new();
    
        public void New(Queue<string> members)
        {
            Members.Clear();
            foreach (string member in members)
            {
                Members.Add(member);
            }
        }

        public void Load()
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
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

        public void Save()
        {
            using (SaveFileDialog saveFileDialog = new())
            {
                Queue<string> fileContent = new();
                for (int i=0; i!= Members.Count;i++)
                {
                    fileContent.Enqueue(Members[i]);
                }

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

        public List<string> Get_Party()
        {
            return Members;
        }
    }
}
