using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BestFarmPath.Main.FilesOperation
{
    public static class FilesOperation
    {
        public static void SaveFile() {
            Directory.CreateDirectory("Map");
            FileStream fs = File.Create("Map\\test.txt");
            byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

        public static void LoadFile() {
        }



    }
}
