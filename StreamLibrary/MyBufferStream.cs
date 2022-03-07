using System;
using System.IO;
using System.Text;

namespace StreamLibrary
{
    public class MyBufferStream : MyStreamDecorator
    {
        public MyBufferStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        /// <summary>
        /// Reading from file
        /// </summary>
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

        /// <summary>
        /// Writing to file
        /// </summary>
        /// <param name="data">Text to write</param>
        public override void Write(string data)
        {
            using (FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Write))
            {
                fs.Seek(0, SeekOrigin.Begin);
                BufferedStream bufferedstream = new BufferedStream(fs, 512 * 8);
                Byte[] byteArray = Encoding.Default.GetBytes(data);
                bufferedstream.Seek(0, SeekOrigin.Begin);

                while (byteArray.Length > bufferedstream.Position)
                {
                    bufferedstream.WriteByte(byteArray[bufferedstream.Position]);
                }

                bufferedstream.Close();
            }
        }
    }
}
