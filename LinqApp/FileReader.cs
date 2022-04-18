using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    internal static class FileReader
    {
        public static List<string> DataList { get; private set; }

        public static void Read(string path)
        {
            DataList = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    DataList.Add(line);
                }
            }
        }
    }
}
