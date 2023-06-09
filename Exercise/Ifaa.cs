using System;

/*example for find biggest number*/

namespace pradeep
{
    class Ifaa
    { 
        public static void Main()
        {
            int i = 5, j = 9, k = 2;
            if(i>j && i>k)
            {
                Console.WriteLine("bignumber:" + i);
            }
            else if(j>k)
            {
                Console.WriteLine("bignumber:" + j);
            }
            else
            {
                Console.WriteLine("bignumber:" + k);
            }

        }
    }
}
/*
 output
 bignumber:9
 */
