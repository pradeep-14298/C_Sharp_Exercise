using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
example for List collection with "Add" method
 */

namespace pradeep
{
    class CLSLstab
    {
        static void Main()
        {
            List<string> Lst = new List<string>();
            Lst.Add("Box");
            Lst.Add("Fox");
            foreach (string s in Lst)
                Console.WriteLine(s);
        }
    }
}
/*
Box
Fox
 */
