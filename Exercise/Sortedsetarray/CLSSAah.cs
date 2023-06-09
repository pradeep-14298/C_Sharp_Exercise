using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 example for ExceptWith 
 */

namespace pradeep.usortedsetarray
{
    class CLSSAah
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

            ssa.ExceptWith(ss);
            foreach (string str in ssa)
            Console.WriteLine(str);
        }
    }
}
/*
d
*/
