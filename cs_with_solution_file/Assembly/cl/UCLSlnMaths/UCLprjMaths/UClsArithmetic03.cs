using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLprjMaths
{
    public partial class UClsArithmetic
    {
        private double sq=0.0;
            public double Usquare
        {
            set
            {
                sq = value * value;
            }
            get
            {
                return sq;
            }
        }
        private  static double cu= 0.0;
        public static double UCube
        {
            set
            {
                cu = value * value*value;
            }
            get
            {
                return cu;
            }
        }
    }
}
