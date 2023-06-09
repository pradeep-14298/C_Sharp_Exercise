using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
example for thread
 */
namespace pradeep
{
    class CLSThrdab
    {
        public static void ushow()
        {
            for (int i = 10; i < 60; i += 10)
            {

                Console.WriteLine(Thread.CurrentThread.Name+"\t"+i);
                Thread.Sleep(200);
            }
        }
        
        public static void Main()
        {
            ThreadStart ts = new ThreadStart(ushow);

            Thread thrd = new Thread(ts);
            

            thrd.Name="Task1";
            thrd.Start();

             for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "\t" + i);
                Thread.Sleep(200);
            }


        }
    }
}
/*
        1
Task1   10
Task1   20
        2
        3
Task1   30
Task1   40
        4
Task1   50
        5
*/