using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*example for thread
 */

namespace pradeep
{
    class CLSThrdaa
    {
        public static void ushow()
        {
            for(int i=10;i<60;i+=10)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
        public static void uDisplay()
        {
            for(int i=1;i<6;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
        public static void Main()
        {
            ThreadStart tsa = new ThreadStart(ushow);
            ThreadStart tsb = new ThreadStart(uDisplay);

            Thread thrda = new Thread(tsa);
            Thread thrdb = new Thread(tsb);

            thrda.Start();
            thrdb.Start();



        }
    }
}
/*
10
1
20
2
3
30
40
4
5
50
*/