using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep.ulinq
{
    class CLSERaa
    {
        
        public int rno
        {
            get;set;
            
        }
        public string sname
        {
            get;set;
        }
        public double m1
        {
            get;set;
        }
        public double m2
        {
            get;set;
        }
        public double total
        {
            get
            {
                return m1 + m2;
            }
        }
        public double avg
        {
            get
            {
                return total / 2;
            }
        }
        public string result
        {
            get
            {
                return m1 > 34.4 && m2 > 34.4 ? "Pass" : "Fail";
            }
        }

    }
}
