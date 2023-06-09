using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.uproperty
{ 
    class CLSProper
    {
        private int rno;
        private string sname;
        private double m1 = 0, m2 = 0;

        public int Rno
        {
            get
            {
                return rno;
            }
            set
            {
                rno = value;
            }
        }
        public string Sname
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }
        public double M1
        {
            get
            {
                return m1;
            }
            set
            {
                m1 = value;
            }
        }
        public double M2
        {
            get
            {
                return m2;
            }
            set
            {
                m2 = value;
            }
        }
        public double Total
        {
            get
            {
                return m1+m2;
            }
        }
        public double Avg
        {
            get
            {
                return Total/2;
            }
        }
        public string Result
        {
            get
            {
                return m1>34.4 && m2>34.4?"Pass":"Fail";
            }
        }
    }
    class CLSProperaa
    {
         public static void Main()
        {
            CLSProper er = new CLSProper();
            er.Rno = 1001;
            er.Sname = "pradeep";
            er.M1 = 56.4;
            er.M2 = 64;

            Console.WriteLine(er.Rno);
            Console.WriteLine(er.Sname);
            Console.WriteLine(er.M1);
            Console.WriteLine(er.M2);
            Console.WriteLine(er.Total);
            Console.WriteLine(er.Avg);
            Console.WriteLine(er.Result);
        }
    }
}


