using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
/*
example for file handling how to make a file using write or create
 */
namespace pradeep.ufilehandling
{
    class CLSFHaa
    {
        public static void Main()
        {
            byte[] ba = Encoding.UTF8.GetBytes("Hot drinks\nCoffee\nTea\nMilk");
            FileStream fs = new FileStream("drinks.txt",FileMode.Create);
            fs.Write(ba, 0, ba.Length);
            fs.Close();
            Console.WriteLine("successfully created new file");
        }
    }
}
/*
successfully created new file
*/