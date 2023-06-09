using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for soertedset array 
 */
namespace pradeep.usortedsetarray
{
    class CLSSAab
    {
        public static void Main()
        {
            string[] sar = { "bb", "aa" };
            List<string> Lst = new List<string>(sar);
            SortedSet<string> ss = new SortedSet<string>(Lst);
            foreach (string s in ss)
                Console.WriteLine(s);
        }
    }
}
/*
aa
bb
 */
