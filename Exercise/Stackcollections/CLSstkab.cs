using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pradeep
{ 
    class CLSstkab
    {
        public static void Main()
        {
            int [] x = { 9, 7, 5 } ;
        Stack<int> stk = new Stack<int>(x);
            foreach (int j in stk)
                Console.WriteLine(j);
        }
    }
}
/*
5
7
9
 */
