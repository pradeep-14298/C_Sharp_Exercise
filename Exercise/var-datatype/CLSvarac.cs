using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 title 
 example for 'var' data-type
 */

namespace pradeep
{
    class CLSvarac
    {
        public static void Main()
        {
            var er = new { rno = 1001, sname = new { Fname = "Ganesh", LName = "Siva" } };
            Console.WriteLine("Roll no:{0}", er.rno);
            Console.WriteLine("Name:{0}", er.sname);
            Console.WriteLine("First name:{0}", er.sname.Fname);
            Console.WriteLine("Last name:{0}", er.sname.LName);

        }


    }
}
/*
 Roll no:1001
Name:{ Fname = Ganesh, LName = Siva }
First name:Ganesh
Last name:Siva
 */
