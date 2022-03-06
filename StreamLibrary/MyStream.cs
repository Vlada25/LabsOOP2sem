using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamLibrary
{
    public class MyStream : IMyStream
    {
        public string Text { get; protected set; } 
        public string Filename { get; }
        public MyStream(string filename)
        {
            Filename = filename;
            Text = "";
        }
        public virtual void Read()
        {
            throw new NotImplementedException();
        }

        public virtual void Write()
        {
            throw new NotImplementedException();
        }
    }
}
