using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*example for foreach with collections*/
namespace pradeep.ulinq
{
    class CLSAFEaa
    {
        public static void Main()
        {
            List<CLSERaa> erLst = new List<CLSERaa>()
        {
            new CLSERaa{rno=1001,sname="siva",m1=56.5,m2=70},
            new CLSERaa{rno=1002,sname="sathish",m1=80,m2=89},
            new CLSERaa{rno=1003,sname="pradeep",m1=67,m2=20}
        };

            foreach (CLSERaa er in erLst)
            {
                String sr = "\n{0,4}\t{1,10}\t{2,5}\t{3,5}\t{4,6}\t{5,4}\t{6,5}\n";
                Console.WriteLine(sr, er.rno, er.sname, er.m1, er.m2, er.total, er.avg, er.result);
            }

        }
    }
}
/*
 
1001          siva       56.5      70    126.5  63.25    Pass


1002       sathish         80      89      169  84.5     Pass


1003       pradeep         67      20       87  43.5     Fail

 */