using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    
    class Addition
    {

        // adding two integer values.
        public int usum(int a, int b)
        {
            int s = a + b;
            return s;
        }

        // adding three integer values.
        public int usum(int a, int b, int c)
        {
            int s = a + b + c;
            return s;
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating Object
            Addition  ob = new Addition();

            int s1 = ob.usum(1, 2);
            Console.WriteLine("sum of the two "
                            + "integer value : " + s1);

            int s2 = ob.usum(1, 2, 3);
            Console.WriteLine("sum of the three "
                            + "integer value : " + s2);
        }
    }

}


/*
sum of the two integer value : 3
sum of the three integer value : 6
*/

