using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 title 
 example for without 'checked' block
 'checked' block enable validation strict mode
 */

namespace pradeep
{
    class CLSchkUchkab
    {
        public static void Main()
        {

            int x = int.MinValue;
            int y = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(y);

            checked
            {
                Console.WriteLine(--x);
            }
            checked
            {
                Console.WriteLine(++y);
            }
        }
    }
}
/*
 -2147483648
2147483647

OverflowException.
*/
