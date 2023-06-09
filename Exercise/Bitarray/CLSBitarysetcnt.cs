using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pradeep
{
    class CLSBitarysetcnt
    {
        public static void Main()
        {
            BitArray b = new BitArray(6);
            b[0] = true;
            b[1] = true;
            b.Set(5, true);
            Console.WriteLine(b.Count);
            int i = 0;

            foreach (bool b2 in b)
            {
                if (b2)

                    i++;
            }
                Console.WriteLine(i);
        }
    }
}
/*
6
3
 */
