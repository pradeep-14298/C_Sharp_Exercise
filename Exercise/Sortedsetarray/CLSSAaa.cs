using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
example for SortedSet Array
 */

namespace pradeep.usortedsetarray
{
    class CLSSAaa
    {
        public static void Main()
        {
            int[] i = { 9, 5, 7 };
            SortedSet<int> ss = new SortedSet<int>(i);
            foreach (int j in ss)
                Console.WriteLine(j);
        }
    }
}
/*
5
7
9
 */
