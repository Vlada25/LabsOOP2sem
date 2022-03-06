using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamLibrary
{
    public class MyBufferStream : MyStreamDecorator
    {
        public MyBufferStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        public override void Read()
        {
            using (FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                fs.Seek(0, SeekOrigin.Begin);

                using (BufferedStream bs = new BufferedStream(fs, 528 * 4))
                {
                    byte[] byteArray = new byte[bs.Length];

                    while (bs.Length > bs.Position)
                    {
                        byteArray[bs.Position] = (byte)bs.ReadByte();
                    }

                    Text = Encoding.Default.GetString(byteArray).Substring(3);
                }
            }
        }
    }
}
