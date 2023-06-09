using System;
/*
example for typecasting
*/
namespace pradeep
{
    class Tcaa
    {
        public static void Main()
        {
            String s = "fox";
            int i = 0;
            i = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine(s);
        
        }
    }
}
/*
 Unhandled Exception: System.FormatException: Input string was not in a correct format.
 */