using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep
{
    class CLSSeaaa
    {
        public CLSSeaaa()
        {
            Console.WriteLine("constructor:CLSSeaaa");
        }
        ~CLSSeaaa()
        {
            Console.WriteLine("destructor:CLSSeaaa");
        }
    }
    sealed class CLSSeaab:CLSSeaaa
    {
        public CLSSeaab()
        {
            Console.WriteLine("constructor:CLSSeaab");
        }
        ~CLSSeaab()
        {
            Console.WriteLine("destructor:CLSSeaab");
        }

    }
    class CLSSealedaa
    {
        public static void Main()
        {
            new CLSSeaab();
        }

    }
}
/*
constructor:CLSSeaaa
constructor:CLSSeaab
destructor:CLSSeaab
destructor:CLSSeaaa
*/