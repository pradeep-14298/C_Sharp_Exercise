using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Example for stack using push,pop and peek
 */

namespace pradeep
{
    class CLSstkaa
    {
        public static void Main()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(2);
            stk.Push(4);
            stk.Push(6);
            stk.Push(8);
            stk.Push(0);
            foreach (int i in stk)
                Console.WriteLine(i);
            Console.WriteLine("\n" + stk.Pop());
            Console.WriteLine(stk.Peek()+"\n");
        }
    }
}
/*
0
8
6
4
2

0
8
 */
