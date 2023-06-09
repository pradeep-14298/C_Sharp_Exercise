using System;

/*example for salary tax*/

namespace pradeep
{
    class STaa
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee Info:");
            string ip = null;

            Console.Write("ID:\t");
            ip = Console.ReadLine();
            int eid = 0;
            int.TryParse(ip, out eid);

            Console.Write("Name:\t");
            string ename = Console.ReadLine();

            Console.Write("Salary:\t");
            ip = Console.ReadLine();
            double sal = 0;
            double.TryParse(ip, out sal);

            double tax10=0,tax20=0,tax30=0,taxtot=0,npay=0;

            if(sal>1000000)
            {
                tax10 = 25000;
                tax20 = 100000;
                tax30 = (sal-1000000) * 30.0 / 100;
            }
           else if (sal > 500000)
            {
                tax10 = 25000;
                tax20 = (sal -500000)* 20.0 / 100;
            }
            else if (sal > 250000)
            {
                tax10 = (sal-250000) * 10.0 / 100; ;
                
            }
            else if(sal<0)
                {
                sal = 0;
            }


            taxtot = tax10 + tax20 + tax30;
            npay = sal - taxtot;
            Console.WriteLine("Employee Salary Tax Info\n");
            Console.WriteLine("ID:\t" + eid);
            Console.WriteLine("Name:\t" + ename);
            Console.WriteLine("Salary:\t" + sal);
            Console.WriteLine("Tax10:\t" + tax10);
            Console.WriteLine("Tax20:\t" + tax20);
            Console.WriteLine("Tax30:\t" + tax30);
            Console.WriteLine("Total tax:\t" + taxtot);
            Console.WriteLine("Net pay:\t" + npay);
        }


    }

}
/*
 Enter Employee Info:
ID:     1
Name:   a
Salary: 200000
Employee Salary Tax Info

ID:     1
Name:   a
Salary: 200000
Tax10:  0
Tax20:  0
Tax30:  0
Total tax:      0
Net pay:        200000

    Enter Employee Info:
ID:     2
Name:   b
Salary: 400000
Employee Salary Tax Info

ID:     2
Name:   b
Salary: 400000
Tax10:  15000
Tax20:  0
Tax30:  0
Total tax:      15000
Net pay:        385000

Enter Employee Info:
ID:     3
Name:   c
Salary: 800000
Employee Salary Tax Info

ID:     3
Name:   c
Salary: 800000
Tax10:  25000
Tax20:  60000
Tax30:  0
Total tax:      85000
Net pay:        715000

    Enter Employee Info:
ID:     4
Name:   d
Salary: 1600000
Employee Salary Tax Info

ID:     4
Name:   d
Salary: 1600000
Tax10:  25000
Tax20:  100000
Tax30:  180000
Total tax:      305000
Net pay:        1295000

*/
