using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorLibrary
{
    public class TextFile
    {
        public string Name { get; set; }
        public string Text { get; set; }
        private DateTime _creationDate;

        public TextFile(string name, string text)
        {
            Name = name;
            Text = text;
            _creationDate = DateTime.Now;
        }

        public string GetDateOfCreating() => _creationDate.ToString("d");

        public string GetTimetOfCreating() => _creationDate.ToString("T");
    }
}
