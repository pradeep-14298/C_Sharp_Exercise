using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    class person
    {
        public void Name()
        {
            Console.WriteLine("Pradeep");

        }
        public void Age()
        {
            Console.WriteLine("25");
        }


        class Methodcalling
        {
            static void Main(string[] args)
            {
                person obj = new person();
                obj.Name();
                obj.Age();
            }
        }

    }
}
/*
Pradeep
25
*/