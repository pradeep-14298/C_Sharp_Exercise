using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
/*
 example for AddRange method in ArrayList
 */


namespace pradeep
{
    class CLSALAddRge
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Box");
            al.Add(11);

            ArrayList al2= new ArrayList();
            al2.Add(4.2);
            al2.Add(true);
            al.AddRange(al2);
            foreach (var v1 in al)
                Console.WriteLine(v1);
        }
    }
}
/*
Box
11
True
 */
