using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace pradeep
{
    class CLSEASelectaa
    {
        public static void Main()
        {
            DataContext dc = new DataContext(CLSCnStr.forpradeep);
            var ds = from row in dc.GetTable<CLSEAaa>()
                     select new
                     {
                         eid = row.eid,
                         ename = row.ename,
                         esal = row.esal,
                         hra = row.hra,
                         da = row.da,
                         pf = row.pf,
                         gpay = row.gpay,
                         npay = row.npay
                     };
            Console.WriteLine("\nEmployee Allowances table has records\n");
            foreach(var obj in ds)
            {
                Console.Write("{0,4}", obj.eid);
                Console.Write("{0,10}", obj.ename);
                Console.Write("{0,10}", obj.esal);
                Console.Write("{0,10}", obj.hra);
                Console.Write("{0,10}", obj.da);
                Console.Write("{0,10}", obj.pf);
                Console.Write("{0,10}", obj.gpay);
                Console.Write("{0,10}", obj.npay);
                Console.WriteLine("\n");

            }
        }
    }
}
/*
Employee Allowances table has records

1001      siva  50000.00  10000.00   7500.00  17500.00  67500.00  50000.00

1002   sathish  60000.00  12000.00   9000.00  21000.00  81000.00  60000.00

1004      bala  30000.00   6000.00   4500.00  10500.00  40500.00  30000.00

1005      gopi  45000.00   9000.00   6750.00  15750.00  60750.00  45000.00

1008    karthi  30000.00   6000.00   4500.00  10500.00  40500.00  30000.00

1009   pradeep  50000.00  10000.00   7500.00  17500.00  67500.00  50000.00
 */
