using System;

namespace pradeep.MDLaa
{
    class CLSHomeaa
    {
        public static void Main()
        {
            Console.WriteLine("Choose execute App:\n");
            Console.WriteLine("Exam Result");
            Console.WriteLine("Employee Allowances");
            Console.WriteLine("Employee Salary Tax");
            Console.WriteLine("Electricity Bill");

            Console.WriteLine("Enter App no between 1 to 4:");
            int i = 0;
            int.TryParse(Console.ReadLine(), out i);
            if (!(i >= 1 && i <= 4))
            {
                Console.WriteLine("Invaild App no.");
                return;
            }
             if (i==1)
             {
                    ERaa.Main();
             }
            if (i == 2)
            {
                EAaa.Main();
            }
            if (i == 3)
            {
                STaa.Main();
            }
            if (i == 4)
            {
                EBaa.Main();
            }
        }
    }
}
