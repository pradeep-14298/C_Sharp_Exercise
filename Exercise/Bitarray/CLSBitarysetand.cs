using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace pradeep
{
    class CLSBitarysetand
    {
        
            static void Display(BitArray BAobj)
            {
            foreach(bool b in BAobj)
            {
                Console.Write(b ? 1 : 0);
            }
            Console.WriteLine("\n");
            }
        static void Main()
        {
            BitArray BAobja = new BitArray(6);
            BAobja[0] = true;
            BAobja[1] = true;
            BAobja.Set(5, true);
            Display(BAobja);
            BitArray BAobjb = new BitArray(6);
            BAobjb[5] = true;
            Display(BAobjb);
            BAobja.And(BAobjb);
            Display(BAobja);
        }
    }
}
/*
 110001

000001

000001

 */
