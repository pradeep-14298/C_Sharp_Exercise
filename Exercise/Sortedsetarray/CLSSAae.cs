using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
example for set method like Union 
 */

namespace pradeep.usortedsetarray
{
    class CLSSAae
    {
        public static void Main()
        {
            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("a");
            ss.Add("c");
            ss.Add("b");
            SortedSet<string> ssa = new SortedSet<string>();
            ssa.Add("a");
            ssa.Add("d");
            ss.UnionWith(ssa);
            foreach (string s in ss)
                Console.WriteLine(s);
        }
    }
}
/*
a
b
c
d
 */
