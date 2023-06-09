using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for multicast delegate*/
namespace pradeep.udelegate
{
    class CLSdlgac
    {
        delegate void ucalc(int i, int j);

         public static void usum(int x,int y)
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }
        public static void uMinus(int x, int y)
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x - y);
        }
        public static void Main()
        {
            ucalc uc = usum;
            uc += uMinus;
            uc(5, 2);
            Console.WriteLine("\n");
            uc -= usum;
            uc(8, 9);
            Console.WriteLine("\n");
            uc(5, 4);
        }
    }
}
/*

5+2=7
5+2=3

8+9=-1

5+4=1
*/