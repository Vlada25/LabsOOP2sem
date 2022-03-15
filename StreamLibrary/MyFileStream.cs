using System.IO;
using System.Text;

namespace StreamLibrary
{
    public class MyFileStream : MyStreamDecorator
    {
        public MyFileStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        /// <summary>
        /// Reading from file
        /// </summary>
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

                //Text = Text.Substring(1);
            }
        }

        /// <summary>
        /// Writing to file
        /// </summary>
        /// <param name="data">Text to write</param>
        public override void Write(string data)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            int dataByteLength = encoding.GetByteCount(data);

            using (FileStream fs = File.OpenWrite(Filename))
            {
                fs.Write(encoding.GetBytes(data), 0, dataByteLength);
                fs.Flush();
            }
        }
    }
}
