using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace pradeep
{
    class CLSEAInsertaa
    {
        public static void Main()
        {
            CLSEAaa ea = new CLSEAaa();
            ea.ename = "vinoth";
            ea.esal = 70000;

            DataContext dc = new DataContext(CLSCnStr.forpradeep);
            dc.GetTable<CLSEAaa>().InsertOnSubmit(ea);
            dc.SubmitChanges();

            Console.WriteLine("1 row affected");

        }
    }
}
