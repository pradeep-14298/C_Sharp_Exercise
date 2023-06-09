using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pradeep
{
    class CLShashtblaa
    {
        public static void Main()
        {
            Hashtable hb = new Hashtable();
            hb["Box"] = 11;
            hb[22] = "Fox";

            Console.WriteLine(hb["Box"]);
            Console.WriteLine(hb[22]);
        }
    }
}
/*
11
Fox
 */
