using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for finally block from exception handling feature
 */
namespace pradeep
{
    class CLSEHaa
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Block:Try");
            }catch(Exception e)
            {
                Console.WriteLine("Block:Catch");
            }
            finally
            {
                Console.WriteLine("Block:Finally");
            }

            try
            {
                Console.WriteLine("Block:Try");
                throw new Exception("User defined error message");
            }catch(Exception e)
            {
                Console.WriteLine("Block:Catch,err:"+e.Message);
            }
            finally
            {
                Console.WriteLine("Block:Finally");
            }
            int age = 18;
            try
            {
                if(age>18)
                {
                    Console.WriteLine("Age category:Teenage");
                }else
                {
                    throw new Exception("Adult");
                }
            }
            finally
            {
                Console.WriteLine("Block:Finally");
            }
        }
    }
}
/*
Block:Try
Block:Finally
Block:Try
Block:Catch,err:User defined error message
Block:Finally

Unhandled Exception: System.Exception: Adult
 */
