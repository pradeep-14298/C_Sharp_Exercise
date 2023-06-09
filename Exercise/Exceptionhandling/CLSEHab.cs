using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep
{
    class CLSEHb
    {
        public CLSEHb()
        {
            Console.WriteLine("Constructor:CLSEHb");
        }
        ~CLSEHb()
        {
            Console.WriteLine("Destructor:CLSEHb");
        }
    }
    class CLSEHab
    {
        public static void Main()
        {
            try
            {
                CLSEHb ehb = new CLSEHb();
                Console.WriteLine("Allocate memory to object:ehb");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Block:Catch");
            }
            Console.WriteLine("Deallocate memory to object:ehb");
        }
    }
}
/*
Constructor:CLSEHb
Allocate memory to object:ehb
Destructor:CLSEHb
 */
