using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    class Arithimetic
    {
        public void  usum(int a,int b)
            {
            int i = a + b;
            Console.WriteLine(i);
            }
        public void uminus(int a, int b)
        {
            int j = a -b;
            Console.WriteLine(j);
        }
        static void Main()
        {
            Arithimetic c = new Arithimetic();
            c.usum(2, 3);
            c.uminus(5, 4);
            
        }
    }
}
/*
5
1
*/