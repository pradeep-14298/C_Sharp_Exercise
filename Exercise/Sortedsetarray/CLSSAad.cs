using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 example for sortedset array 
 How to develop collections.Generic with Lamda Opertor

 */
namespace pradeep.usortedsetarray
{
    class CLSSAad
    {
        public static void Main()
        {
            string[] sar = { "Fox", "Box", "Box", "Fox", "FOX", "Zoo" };
            SortedSet<string> ss = new SortedSet<string>(sar);
            ss.RemoveWhere(Element => Element.StartsWith("F"));
            foreach (string s in ss)
                Console.WriteLine(s);
        }
    }
}
/*
Box
Zoo
 */
