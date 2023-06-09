using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

/*
example for file hanlding how to append new content to exists file?
*/
namespace pradeep.ufilehandling
{
    class CLSFHab
    {
        public static void Main()
        {
            byte[] ba = Encoding.UTF8.GetBytes("\ncool drinks\n7up\npepsi\ncoke");
            FileStream fs = new FileStream("drinks.txt", FileMode.Append);
            fs.Write(ba, 0, ba.Length);
            fs.Close();
            Console.WriteLine("successfully created new file");
        }
    }
}
/*
 successfully created new file
*/