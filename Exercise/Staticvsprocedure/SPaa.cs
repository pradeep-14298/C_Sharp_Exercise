using System;

namespace pradeep
{
    class SPaa
    {
        public int udSum(int x, int y)
        {
            return x+y;
        }
        public int udMinus(int x,int y)
        {
            return x-y;
        }
        public static void Main()
        {
            SPaa spa = new SPaa();
            Console.WriteLine(spa.udSum(4, 5));
            Console.WriteLine(spa.udMinus(8, 5));
        }

    }
}
/*
9
3
*/
