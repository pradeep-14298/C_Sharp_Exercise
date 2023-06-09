using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 example for List Collection
 */
namespace pradeep
{
    class CLSLstaa
    {
        static void Display(List<string> Lst)
        {
            Console.WriteLine("\n" + (Lst.Capacity));
            foreach (string str in Lst)
                Console.WriteLine(str);
        }
        public static void Main()
        {
            List<string> Lsta = new List<string>(new string[] { "Box", "Fox" });
            Display(Lsta);
            Lsta.AddRange(Lsta);
            Display(Lsta);
            Lsta.RemoveRange(2, 2);
            Display(Lsta);
            Lsta.InsertRange(1, new string[] { "xx", "x" });
            Display(Lsta);
            string[] s = Lsta.GetRange(0, 2).ToArray();
            Lsta = new List<string>(s);
            Display(Lsta);
        }
    }
}
/*
2
Box
Fox

4
Box
Fox
Box
Fox

4
Box
Fox

4
Box
xx
x
Fox

2
Box
xx
 */
