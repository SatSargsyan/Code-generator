using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_vs_Readonly2
{
    class Program
    {
        const int y = 42;
        static readonly int z = 45;
      
        static void Main(string[] args)
        {
                     
            short x = 42;
            Console.WriteLine(x.Equals(y));
            //true

            short t = 45;
            Console.WriteLine(t.Equals(z));
            //false

            Console.ReadKey();
        }
    }
}
