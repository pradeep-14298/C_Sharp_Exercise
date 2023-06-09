using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for covariance-array
*/

namespace pradeep.ucovariancearray
{
    class CLScovaryaa
    {
        public static void Main()
        {
            string[] sa = { "aa", "zz", "cc" };
            object[] obj = sa;
            obj[1] = "bb";
            foreach (string s in sa)
                Console.WriteLine(s);
        }

    }
}
/*
aa
bb
cc
 */
