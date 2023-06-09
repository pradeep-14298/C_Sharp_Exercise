﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 example for ExceptWith 
 */
namespace pradeep.usortedsetarray
{
    class CLSSAag
    {
        static void Main()
        {

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("a");
            ss.Add("c");
            ss.Add("b");
            SortedSet<string> ssa = new SortedSet<string>();
            ssa.Add("a");
            ssa.Add("d");

            ss.ExceptWith(ssa);
            foreach (string str in ss)
            Console.WriteLine(str);

        }
    }
}
/*
b
c
 */
