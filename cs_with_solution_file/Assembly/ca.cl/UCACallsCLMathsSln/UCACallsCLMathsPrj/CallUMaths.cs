using System;
using UCLprjMaths;

namespace UCACallsCLMathsPrj
{
    class CallUMaths
    {
        static void Main(string[] args)
        {
            UClsArithmetic uca = new UClsArithmetic();
            double d1 = uca.USum(0.5, 9);
            double d2 = UClsArithmetic.UMinus(8, 3);

            double d3 = 0;
            uca.UMultiply(0.7, 10, out d3);
            double d4 = 0;
            UClsArithmetic.UDivide(10, 3, out d4);

            uca.Usquare = 8;
            UClsArithmetic.UCube = 5;

            UClsSUM ucs = new UClsSUM();
            ucs[0] = 11;
            ucs[2] = 33;
            ucs[4] = 55;

            double[] darr = ucs.UElements;

            Console.WriteLine(d1 + "," + d2);
            Console.WriteLine(d3 + "," + d4);

            Console.WriteLine(uca.Usquare);
            Console.WriteLine(UClsArithmetic.UCube);

            Console.WriteLine(ucs[0] + "," + ucs[2]);
            Console.WriteLine(ucs[4] + "," + ucs[1]);
            foreach(double d in darr)
            {
                Console.WriteLine(d);
            }
        }
    }
}
/*
 9.5,5
7,3.33333333333333
64
125
11,33
1:The given key was not present in the dictionary.

55,-1
11
33
55
*/