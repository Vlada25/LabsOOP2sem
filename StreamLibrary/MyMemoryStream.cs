using System;
using System.IO;
using System.Text;

namespace StreamLibrary
{
    public class MyMemoryStream : MyStreamDecorator
    {
        public MyMemoryStream(MyStream myStream) : base(myStream.Filename, myStream) { }

        /// <summary>
        /// Reading from file
        /// </summary>
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

        /// <summary>
        /// Writing to file
        /// </summary>
        /// <param name="data">Text to write</param>
        public override void Write(string data)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] dataBytes = encoding.GetBytes(data);

            using (MemoryStream memStream = new MemoryStream(1000))
            {
                memStream.Write(dataBytes, 0, dataBytes.Length);
            }
        }
    }
}
