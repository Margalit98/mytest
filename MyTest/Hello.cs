using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyTest
{
    public class Hello : Student
    {
         public Hello() {
            Console.WriteLine(this.ToString());
        }
    }
}
