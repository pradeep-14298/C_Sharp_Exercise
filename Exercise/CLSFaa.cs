using System;

namespace pradeep
{
    class CLSFaa
    {
        public static void Main()
        {
            int a = 5, b = 3;
            Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
            string s = string.Format("{0}x{1}={2}", a, b, (a * b));
            Console.WriteLine(s);
        }
    }
}
/*
5+3=8
5x3=15
 */
