using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pradeep
{
    class CLS_hashtblac
    {
        public static void Main()
        {
            Hashtable hb = new Hashtable();
            hb["Box"] = 11;
            hb[22] = "Fox";

            foreach (var v1 in hb.Keys)
                Console.WriteLine(hb[v1]);
        }
    }
}
