using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorLibrary
{
    public static class FileManager
    {
        public static List<string> Filepaths { get; } = new List<string> { @"..\File1.txt", @"..\File2.txt" };
        public static void CreateFile(string filepath) 
        { 

        }
        public static string OpenFile(string filepath) 
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                return reader.ReadToEnd();
            }
        }

        public static void SaveToFile(string filepath, string text)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.Write(text);
            }
        }

        public static void CreateFile(string fname, string text)
        {
            string filepath = $@"..\{fname}.txt";

            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.Write(text);
            }

            Filepaths.Add(filepath);
        }
    }
}
