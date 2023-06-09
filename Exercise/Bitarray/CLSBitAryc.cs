using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 example for collection method in bitarray
 */

namespace pradeep
{
    class CLSBitAryc
    {
        public static void Main()
        {
            bool[] b = new bool[4];
            b[0] = true;
            b[1] = true;
            BitArray ba = new BitArray(b);
            foreach (bool b2 in ba)
                Console.WriteLine(b2);
        }
    }
}
/*
True
True
False
False
 */
