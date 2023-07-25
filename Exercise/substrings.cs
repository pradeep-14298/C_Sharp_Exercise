using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    class substring
    {

        // Main Method
        public static void Main()
        {

            // define string
            String str = "PradeepSekar";

            Console.WriteLine("String    : " + str);

            // retrieve the substring from index 5
            Console.WriteLine("Sub String1: " + str.Substring(7));

        }
    }
}
/*
String    : PradeepSekar
Sub String1: Sekar
*/
