using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 title:
 example for 'var' data-type

 var data-type can develop read only property or indexer only.

 */

namespace pradeep
{
    class CLSvarab
    {
        public static void Main()
        {
            var er = new { rno = 1001, sname = "x5", m1 = 56.5, m2 = 72 };

            Console.WriteLine("Roll no:{0}", er.rno);
            Console.WriteLine("Name:{0}", er.sname);
            Console.WriteLine("Mark-1:{0}", er.m1);
            Console.WriteLine("Mark-2:{0}", er.m2);

            Console.WriteLine("Total :{0}", er.m1+er.m2);
            Console.WriteLine("Average:{0}",(er.m1+er.m2)/2);
            Console.WriteLine("Result:{0}", (er.m1>34.4 && er.m2>34.4 ?"Pass":"Fail"));
        }
    }
}
/*
Roll no:1001
Name:x5
Mark-1:56.5
Mark-2:72
Total :128.5
Average:64.25
Result:Pass
 */
