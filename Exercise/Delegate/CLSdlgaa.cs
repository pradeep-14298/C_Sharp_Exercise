using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.udelegate
{
    class CLSdlgaa
    {
        delegate void ucalc(int i, int j);
        public static void Main()
        {
            ucalc usum = delegate (int i, int j)
              {
                  Console.WriteLine(i + j);
              };
           ucalc udiv = delegate (int i, int j)
            {
                Console.WriteLine(i / j);
            };
            ucalc umul = delegate (int i, int j)
            {
                Console.WriteLine(i * j);
            };
            usum (1, 5);
            udiv(20, 5);
            umul(7, 2);
        }
    }
}
/*
6
4
14
*/