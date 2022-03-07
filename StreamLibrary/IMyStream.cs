namespace StreamLibrary
{
    public interface IMyStream
    {
        /// <summary>
        /// Reading from file
        /// </summary>
        void Read();

        /// <summary>
        /// Writing to file
        /// </summary>
        /// <param name="data">Text to write</param>
        void Write(string data);
    }
}
