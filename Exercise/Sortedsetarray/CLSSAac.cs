using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.usortedsetarray
{
    class CLSSAac
    {
        public static void Main()
        {

            string[] sar = { "bb", "BB","bb","aa","AA","cc" };
            SortedSet<string> ss = new SortedSet<string>(sar);
            foreach (string s in ss)
                Console.WriteLine(s);
        }
    }
}
/*
aa
AA
bb
BB
cc
 */
