using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    class Reversestring_variable
    {
        public static void Main()
        {
            string []str = { "a", "b", "c", "d" };
            Stack<string> stk = new Stack<string>(str);
            foreach(string s in stk)
            Console.WriteLine(s);
        }
    }
}
/*
d
c
b
a
*/