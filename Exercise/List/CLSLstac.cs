using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
example for dictionary with List
*/

namespace pradeep
{
    class CLSLstac
    {
        static void Main()
        {
            Dictionary<string, int> d = new Dictionary<string, int>()
            {
                { "Box",11},
                { "Fox",22}
            };
            List<string> Lst = new List<string>(d.Keys);
            foreach (string s in Lst)
                Console.WriteLine(s + "-" + d[s]);
        }

    }
}
/*
Box-11
Fox-22
 */
