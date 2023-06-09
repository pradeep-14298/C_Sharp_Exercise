using System;
/*
 title:
 example for access specifier : 'private'
 */


namespace pradeep.Accessspecifier
{
    class CLSASaa
    {
        private int x;
    }
    class CLSASab
    {
        public static void Main()
        {
            CLSASaa aa = new CLSASaa();
            //Console.WriteLine(aa.x);
        }
    }

}
