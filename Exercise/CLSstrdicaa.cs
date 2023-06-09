using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
/*
example for stringDictionary
*/

namespace pradeep
{
    class CLSstrdicaa
    {
        public static void Main()
        {
            StringDictionary sd=new StringDictionary();
            sd.Add("Box", "11");
            sd.Add("Fox", "22");
            foreach (string strkey in sd.Keys)
                Console.WriteLine(strkey);
            foreach (string strval in sd.Values)
                Console.WriteLine(strval);
        }
    }
}
/*
box
fox
11
22
 */
