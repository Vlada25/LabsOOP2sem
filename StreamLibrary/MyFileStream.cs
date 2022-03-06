using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamLibrary
{
    public class MyFileStream : MyStreamDecorator
    {
        public MyFileStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        public override void Read()
        {
            using (FileStream fs = File.OpenRead(Filename))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Text += temp.GetString(b);
                }
            }
        }
    }
}
