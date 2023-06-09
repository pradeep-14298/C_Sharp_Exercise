using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace pradeep
{
    [Table(Name ="eatba")]
    class CLSEAaa
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int eid;

        [Column]
        public string ename;

        [Column]
        public decimal esal;

        [Column(IsDbGenerated = true)]
        public decimal hra;

        [Column(IsDbGenerated = true)]
        public decimal da;

        [Column(IsDbGenerated = true)]
        public decimal pf;

        [Column(IsDbGenerated = true)]
        public decimal gpay;

        [Column(IsDbGenerated = true)]
        public decimal npay;

    }
}
