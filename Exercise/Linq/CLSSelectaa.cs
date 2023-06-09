using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for select*/
namespace pradeep.ulinq
{
    class CLSSelectaa
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
                     select row;
            foreach(var row in ds)
            {
                Console.Write("\n{0,4}\t{1,10}", row.rno, row.sname);
                Console.Write("\t{0,5}\t{1,5}", row.m1, row.m2);
                Console.Write("\t{0,6}\t{1,4}\t{2,5}\n", row.total, row.avg,row.result);
            }


        }       
    }
}
/*
1001    siva     56.5      70    126.5  63.25/t Pass

1002    sathish    80      89      169  84.5/t Pass

1003    pradeep    67      20       87  43.5/t Fail 
 */
