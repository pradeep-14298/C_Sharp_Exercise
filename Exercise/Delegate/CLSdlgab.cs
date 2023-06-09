using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.udelegate
{
    class CLSdlgab
    {
        delegate void ushow();
        
        public void uExhibit()
        {
            Console.WriteLine("Method:uExhibit");
        }
        public static void uDisplay()
        {
            Console.WriteLine("Method:uDisplay");
        }
        public static void Main()
        {
            ushow us = new CLSdlgab().uExhibit;
            us();
            us = uDisplay;
            us();
        }
    }
}
/*
Method:uExhibit
Method:uDisplay
*/