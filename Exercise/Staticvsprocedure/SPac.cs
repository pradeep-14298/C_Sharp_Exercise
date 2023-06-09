using System;

namespace pradeep
{
    class SPac
    {
        public static void Main()
        {
            UDCLMath umath = new UDCLMath();
            Console.WriteLine(umath.udmsum(1, 9));
            umath.udmMultiply(2, 2);
            Console.WriteLine(UDCLMath.udmMinus(4,3));
            UDCLMath.udmDivide(20,3);

        }

    }
}

/*
10
4
1
6
*/
