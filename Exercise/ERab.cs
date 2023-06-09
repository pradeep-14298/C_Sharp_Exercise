using System;

/*example for exam result*/

namespace pradeep
{
    class ERab
    {
        public static void Main()
        {
            Console.WriteLine("Enter following for Exam result");
            string ip = null;

            Console.Write("\n Roll number:\t");
            ip = Console.ReadLine();
            int rno = 0;
            int.TryParse(ip, out rno);

            Console.Write("\nStudent:\t");
            ip = Console.ReadLine();
            string sname = Console.ReadLine();

            Console.Write("\nMark-1:\t");
            ip = Console.ReadLine();
            double m1 = 0;
            double.TryParse(ip, out m1);


            Console.Write("\nMark-2:\t");
            ip = Console.ReadLine();
            double m2 = 0;
            double.TryParse(ip, out m2);

            double total = (m1 + m2), avg = (m1 + m2) / 2;
            bool result = (m1 > 34.4 && m2 > 34.4);

            Console.WriteLine("Exam Result Info:\n");
            Console.WriteLine("Roll no:\t" + rno);
            Console.WriteLine("Name:\t" + sname);
            Console.WriteLine("Mark-1:\t" + m1);
            Console.WriteLine("Mark-2:\t" + m2);
            Console.WriteLine("Total:\t" + total);
            Console.WriteLine("Average:\t" + avg);
            Console.WriteLine("Result:\t" + (result ? "Pass" : "Fail"));
       
        }

    }
}
/*
output
Enter following for Exam result

 Roll number:
1001

Student:        pradeep


Mark-1:
80

Mark-2:
60
Exam Result Info:

Roll no:        1001
Name:
Mark-1: 80
Mark-2: 60
Total:  140
Average:        70
Result: Pass

 output-2
 Enter following for Exam result

 Roll number:   1002

Student:        siva


Mark-1: 90

Mark-2: 34
Exam Result Info:

Roll no:        1002
Name:
Mark-1: 90
Mark-2: 34
Total:  124
Average:        62
Result: Fail
 */
