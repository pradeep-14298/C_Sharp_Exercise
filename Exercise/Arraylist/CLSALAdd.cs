using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 example for Add method in ArrayList
 */
namespace pradeep
{
    class CLSALAdd
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Box");
            al.Add(11);
            al.Add(true);
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
