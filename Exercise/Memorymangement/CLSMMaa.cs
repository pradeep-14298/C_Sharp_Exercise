using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for memory management system
 */
namespace pradeep
{
    class CLSMMa
    {
        public CLSMMa()
        {
            Console.WriteLine("Constructor:CLSMMa");
        }
        public void usum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        ~CLSMMa()
        {
            Console.WriteLine("Destructor:CLSMMa");
        }
    }
    class CLSMMaa
    {
        public static void Main()
        {
            CLSMMa obj = new CLSMMa();
            obj.usum(9, 7);
            obj.usum(3, 4);
        }

    }
}
/*
Constructor:CLSMMa
16
7
Destructor:CLSMMa
 */
