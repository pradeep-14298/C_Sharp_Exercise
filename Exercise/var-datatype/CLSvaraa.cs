﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep
{
    class CLSvaraa
    {
        public static void Main()
        {
            var i = 5.9;
            Console.WriteLine("\n{0}:{1}", i, i.GetType());

            i = 9.2f;
            Console.WriteLine("\n{0}:{1}", i, i.GetType());

            i = 4;
            Console.WriteLine("\n{0}:{1}", i, i.GetType());

            var x = 4;
            Console.WriteLine("\n{0}:{1}", x,x.GetType());
        }
    }

}
/*
 5.9:System.Double

9.19999980926514:System.Double

4:System.Double

4:System.Int32
 */
