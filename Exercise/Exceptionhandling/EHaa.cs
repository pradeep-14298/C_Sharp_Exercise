using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep
{
    class EHaa
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Welcome");
                int i = 10, j = 0;
                Console.WriteLine(i / j);
                Console.WriteLine("Thanks");
            }
            catch(Exception e)
            {
                Console.WriteLine("err:" + e.Message);
            }
            Console.WriteLine("visit agian");
        }
    }
}

/*
Welcome
err:Attempted to divide by zero.
visit agian
 */
