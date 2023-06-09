using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.uproperty
{
    class CLSPropea
    {

        private int eid;
        private string ename;
        private double esal = 0;

        public int id
        {
            get
            {
                return eid;
            }
            set
            {
                eid = value;
            }
        }
        public string name
        {
            get
            {
                return ename;
            }
            set
            {
                ename = value;
            }
        }
        public double salary
        {
            get
            {
                return esal;
            }
            set
            {
                esal = value;
            }
        }
        
        public double Hra
        {
            get
            {
                return esal*20.0/100;
            }
        }
        public double Da
        {
            get
            {
                return esal*15.0 /100;
            }
        }
        public double Pf
        {
            get
            {
                return esal * 35.0 / 100;
            }
        }
        public double Gpay
        {
            get
            {
                return Hra + Da + salary;
            }
        }
        public double Npay
        {
            get
            {
                return Gpay - Pf;
            }
        }
    }
    class CLSPropeaaa
    {
        public static void Main()
        {
            CLSPropea ea = new CLSPropea();
            ea.id = 1001;
            ea.name = "pradeep";
            ea.salary = 30000;
           

            Console.WriteLine(ea.id);
            Console.WriteLine(ea.name);
            Console.WriteLine(ea.salary);
            Console.WriteLine(ea.Hra);
            Console.WriteLine(ea.Da);
            Console.WriteLine(ea.Pf);
            Console.WriteLine(ea.Gpay);
            Console.WriteLine(ea.Npay);
        }
    }
}
/*
1001
pradeep
30000
6000
4500
10500
40500
30000
 */
