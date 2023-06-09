using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for static storage clause*/
namespace pradeep
{
    class CLSStatica
    {
        int i = 5;
        static int j = 5;
        public CLSStatica()
        {
            Console.WriteLine($"{i}\t{j}");
            i += 2;
            j += 2;
        }
    }
    class CLSStaticaa
    {
        public static void Main()
        {
            CLSStatica obja = new CLSStatica();
            CLSStatica objb = new CLSStatica();
            CLSStatica objc = new CLSStatica();
        }

    }

}
/*
5       5
5       7
5       9
*/