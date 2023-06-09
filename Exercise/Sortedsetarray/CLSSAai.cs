using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for set method like IntersetWith
 */

namespace pradeep.usortedsetarray
{
    class CLSSAai
    {
        static void Main()
        {

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("a");
            ss.Add("c");
            ss.Add("b");
            SortedSet<string> ssa = new SortedSet<string>();
            ssa.Add("a");
            ssa.Add("d");

            ss.IntersectWith(ssa);
            foreach (string str in ss)
                Console.WriteLine(str);

        }
    }
}
/*
a
 */