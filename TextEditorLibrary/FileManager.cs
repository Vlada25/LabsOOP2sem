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
        public static List<string> Filepaths { get; } = new List<string>();
        private static string _path = @"..\";

        static FileManager()
        {
            Filepaths.AddRange(Directory.GetFiles(_path));
        }

        /// <summary>
        /// Opening file to reading
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static string OpenFile(string filepath) 
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Saving new text to file
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="text"></param>
        public static void SaveToFile(string filepath, string text)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.Write(text);
            }
        }

        /// <summary>
        /// Creating new file
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="text"></param>
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
