using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
