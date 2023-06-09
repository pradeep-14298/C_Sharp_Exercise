using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pradeep.ufilehandling
{
    class CLSFHac
    {
        public static void Main()
        {
            FileStream fs = new FileStream("drinks.txt", FileMode.Open);
            Console.WriteLine("File Size(bytes):\n");
            Console.WriteLine(fs.Length);
            byte[] ba = new byte[fs.Length];
            fs.Read(ba, 0, ba.Length);
            fs.Close();
            Console.WriteLine("File Content:\n");
            Console.WriteLine(Encoding.UTF8.GetString(ba));
        }
    }
}
/*
File Size(bytes):

52
File Content:

Hot drinks
Coffee
Tea
Milk
cool drinks
7up
pepsi
coke
*/