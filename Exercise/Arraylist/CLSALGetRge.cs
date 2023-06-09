using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 example for GetRange method in ArrayList
 */

namespace pradeep
{
    class CLSALGetRge
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Box");
            al.Add(11);
            al.Add(4.2);
            al.Add(true);

            ArrayList al2 = al.GetRange(2,2);
            
            foreach (var v1 in al)
                Console.WriteLine(v1);
        }
    }
}
/*
 Box
11
4.2
True
 */
