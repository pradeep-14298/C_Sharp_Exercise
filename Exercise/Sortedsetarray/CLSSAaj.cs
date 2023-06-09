using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for Max and Min
 */
namespace pradeep.usortedsetarray
{
    class CLSSAaj
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

            Console.WriteLine(ss.Min);
            Console.WriteLine(ss.Max);
        }
    }
}
/*
a
c
*/