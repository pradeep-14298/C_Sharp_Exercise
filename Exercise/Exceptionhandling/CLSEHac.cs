using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for finally block
 */
namespace pradeep.uexceptionhandling
{
    class CLSEHc
    {
        public CLSEHc()
        {
            Console.WriteLine("Constructor:CLSEHc");
        }
        ~CLSEHc()
        {
            Console.WriteLine("Destructor:CLSEHc");
        }
    }
    class CLSEHac
    {
        public static void Main()
        {
            try
            {
                CLSEHc ehc = new CLSEHc();
                Console.WriteLine("Allocate memory to object:ehc");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Block:Catch");
            }
            finally
            {
                Console.WriteLine("Deallocate memory to object:ehc");
            }
            
        }
    }
}
/*
Constructor:CLSEHc
Allocate memory to object:ehc
Deallocate memory to object:ehc
Destructor:CLSEHc
 */
