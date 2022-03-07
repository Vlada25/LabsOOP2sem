using System;

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

        /// <summary>
        /// Reading from file
        /// </summary>
        public virtual void Read()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writing to file
        /// </summary>
        /// <param name="data">Text to write</param>
        public virtual void Write(string data)
        {
            throw new NotImplementedException();
        }
    }
}
