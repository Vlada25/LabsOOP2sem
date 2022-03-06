using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamLibrary
{
    public class MyMemoryStream : MyStreamDecorator
    {
        public MyMemoryStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        public override void Read()
        {
            byte[] fileContents = File.ReadAllBytes(Filename);

            using (MemoryStream memoryStream = new MemoryStream(fileContents))
            {
                int b;
                int i = 0;

                while ((b = memoryStream.ReadByte()) >= 0)
                {
                    if (i > 2)
                    {
                        Text += Convert.ToChar(b).ToString();
                    }
                    i++;
                }
            }
        }
    }
}
