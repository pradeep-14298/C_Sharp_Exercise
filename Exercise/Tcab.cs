using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for typecasting
 */
namespace pradeep
{
    class Tcab
    {
        public static void Main()
        {
            string s = "fox";
                int i = 0;
            int.TryParse(s,out i);
            Console.WriteLine(i + "-" + i.GetType());
            Console.WriteLine(s + "-" + s.GetType());

        }

    }
}
/*
 0-System.Int32
fox-System.String
*/