using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 example for Default keyword for Find neutral value of datatype
 */
namespace pradeep
{
    class CLSDefaa
    {
        public static void Main()
        {
            Console.WriteLine(default(int));
            Console.WriteLine(default(float));
            Console.WriteLine(default(double));
            Console.WriteLine(default(char));
            Console.WriteLine(default(bool));

            Console.WriteLine(default(DateTime));
            Console.WriteLine(default(string));
        }
    }
}
/*
0
0
0
<null>
False
1/1/0001 12:00:00 AM
<null>
 */
