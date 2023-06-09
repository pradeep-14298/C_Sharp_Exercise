using System;

/* example for employee allowances*/

namespace pradeep
{
    class EAaa
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

            double hra = 0, da = 0, pf = 0, gpay = 0, npay = 0;
            hra = sal * (20.0 / 100);
            da = sal * (15.0 / 100);
            pf = sal * (35.0 / 100);
            gpay = sal + hra + da;
            npay = gpay - pf;
            Console.WriteLine("Employee Salary Allowances Info\n");
            Console.WriteLine("ID:\t" + eid);
            Console.WriteLine("Name:\t" + ename);
            Console.WriteLine("Salary:\t" + sal);
            Console.WriteLine("House rent allowances:\t" + hra);
            Console.WriteLine("Dearness:\t" + da);
            Console.WriteLine("Provident fund:\t" + pf);
            Console.WriteLine("Gross pay:\t" + gpay);
            Console.WriteLine("Net pay:\t" + npay);
        }
      

    }

}

/*
 output
 Enter Employee Info:
ID:     11
Name:   p
Salary: 50000
Employee Salary Allowances Info

ID:     11
Name:   p
Salary: 50000
House rent allowances:  10000
Dearness:       7500
Provident fund: 17500
Gross pay:      67500
Net pay:        32500

 
*/
