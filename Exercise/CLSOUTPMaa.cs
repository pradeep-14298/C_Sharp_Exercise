using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for out parameter*/
namespace pradeep
{
    class CLSOUTPMaa
    {
        public static void uSum(int i,int j,out int k)
        {
            k = i + j;
        }
        public static void uFLNames(string fullname,out string fname,out string Lname)
        {
            int bis = fullname.IndexOf("");
            if (bis==-1)
            {
                fname = fullname;
                Lname = null;
                return;
            }
            fname = fullname.Substring(0,bis).Trim();
            Lname = fullname.Substring(bis).Trim();
        }
        
        public static void Main()
        {
            int x = 0;
            uSum(2, 5, out x);
            Console.WriteLine(x);
            string fullname = "raja raghu raman", sonname = null, fathername = null;
            uFLNames(fullname, out sonname, out fathername);
            Console.WriteLine(sonname);
            Console.WriteLine(fathername);

        }
    }
}

/*
 7

raja raghu raman
*/