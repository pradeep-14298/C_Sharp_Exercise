using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for call by value & call by reference
 */
namespace pradeep
{
    class CLSCBVCBRaa
    {
        public static void uSwap(int i,int j)
        {
            i = i + j;
            j = j - i;
            i = j - i;

            Console.WriteLine("Swap[i]:+i");
            Console.WriteLine("Swap[j]:+j");
        }
        public static void uExchange(ref int i,ref int j)
        {
            i = i + j;
            j = j - i;
            i = j - i;

            Console.WriteLine("Exchang[i]:+i");
            Console.WriteLine("Exchange[j]:+j");
        }
        public static void Main()
        {
            int a = 5, b = 2;
            int x = 4, y = 9;

            Console.WriteLine("before Swap[a]:" + a);
            Console.WriteLine("before Swap[b]:" + b);

            Console.WriteLine("after Swap[a]:" + a);
            Console.WriteLine("after Swap[b]:" + b);

            Console.WriteLine("before Exchange[x]:" + x);
            Console.WriteLine("before Exchange[y]:" + y);

            Console.WriteLine("after Exchange[x]:" + x);
            Console.WriteLine("after Exchange[y]:" + y);

        }
    }
}

/*
before Swap[a]:5
before Swap[b]:2
after Swap[a]:5
after Swap[b]:2
before Exchange[x]:4
before Exchange[y]:9
after Exchange[x]:4
after Exchange[y]:9
*/