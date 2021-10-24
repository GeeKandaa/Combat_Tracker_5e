using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker5e.FileFunctions
{
    public static class FileManager
    {
        public static string ReadBinaryFileToString(FileStream fs)
        {
            BinaryReader br = new(fs);
            List<Byte> binary_list = new();
            string data = br.ReadString();
            for (int i = 0; i < data.Length; i += 8)
            {
                binary_list.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(binary_list.ToArray());
        }
        public static void WriteBinaryFileFromString(FileStream fs, string content)
        {
            BinaryWriter bw = new(fs);
            StringBuilder sb = new();
            foreach (char c in content)
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            bw.Write(sb.ToString());
            fs.Close();
        }
    }
}
