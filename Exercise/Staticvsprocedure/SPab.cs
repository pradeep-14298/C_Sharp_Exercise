using System;

namespace pradeep
{
    class SPab
    {
        public void udSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void udMinus(int x, int y)
        {
            Console.WriteLine(x-y);
        }

        public static void Main()
        {
            SPab spb = new SPab();
            spb.udSum(4, 5);
            spb.udMinus(8, 5);
        }
    }
}
/*
9
3
 */
