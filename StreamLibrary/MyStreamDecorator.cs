namespace StreamLibrary
{
    public class MyStreamDecorator : MyStream
    {
        protected MyStream myStream;

        public MyStreamDecorator(string filename, MyStream myStream) : base(filename)
        {
            this.myStream = myStream;
        }

    }
}
