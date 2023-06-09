using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for memory management system using Auto forey clause
 */
namespace pradeep.umemorymangement
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
    class CLSMMba
    {
          public static void Main()
          {
                Console.WriteLine("Main Block:Top");
                { 
                    CLSMMb obj = new CLSMMb();
                    obj.usum(9, 7);
                }

                Console.WriteLine("Main Block:Middle");
                {
                    CLSMMb obj = new CLSMMb();
                    obj.usum(5, 5);
                }
                Console.WriteLine("Main Block:Bottom");
          }
    }
}
/*
Main Block:Top
Constructor:CLSMMb
16
Main Block:Middle
Constructor:CLSMMb
10
Main Block:Bottom
Destructor:CLSMMb
Destructor:CLSMMb
 */
