using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for select new*/
namespace pradeep.ulinq
{
    class CLSSelectnewab
    {
        public static void Main()
        {
            List<CLSERaa> erLst = new List<CLSERaa>()
        {
            new CLSERaa{rno=1001,sname="siva",m1=56.5,m2=70},
            new CLSERaa{rno=1002,sname="sathish",m1=80,m2=89},
            new CLSERaa{rno=1003,sname="pradeep",m1=67,m2=20}
        };
            var ds = from row in erLst
                     select new { row.rno, row.result };
            foreach (var row in ds)
            {
                Console.Write("\n{0,4}\t{1,4}\n", row.rno, row.result);
            }

        }
    }
}
/*
1001    Pass

1002    Pass

1003    Fail
*/
