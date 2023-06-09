using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
/*
Example for Concurrent collection using TryPeek and TryTake
 */
namespace pradeep
{
    class CLSConcrtaa
    {
        static void Main()
        {
            string[] sar = { "Box","Fox" };
            ConcurrentBag<string> cb = new ConcurrentBag<string>(sar);
            string s;
            if (cb.TryPeek(out s))
                Console.WriteLine(s);
            Console.WriteLine(cb.Count);
            if (cb.TryTake(out s)) 
            Console.WriteLine(s);
            Console.WriteLine(cb.Count);
        }
    }
}
/*
Fox
2
Fox
1
 */
