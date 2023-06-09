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
    class CLSMMb
    {
        public CLSMMb()
        {
            Console.WriteLine("Constructor:CLSMMb");
        }
        public void usum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        ~CLSMMb()
        {
            Console.WriteLine("Destructor:CLSMMb");
        }
    }
    class CLSMMab
    {
        public static void Main()
        {
            CLSMMb obj = new CLSMMb();
            obj.usum(9, 7);
            obj = null;
            obj.usum(3, 4);
        }

    }
}
/*
Constructor:CLSMMb
16

 Object reference not set to an instance of an object.
 */