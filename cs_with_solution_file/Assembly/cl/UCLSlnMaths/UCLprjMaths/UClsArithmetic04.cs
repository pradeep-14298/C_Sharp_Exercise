using System;
using System.Collections.Generic;


namespace UCLprjMaths
{
    public class UClsSUM
    {
        private Dictionary<int, double> dc = new Dictionary<int, double>();

        public double this[int keyname]
        {
            set
            {
                dc.Add(keyname, value);
            }
            get
            {
                try
                {
                    return dc[keyname];
                }
                catch(Exception e)
                {
                    Console.WriteLine(keyname + ":" +e.Message+ "\n");
                    return -1;
                }
            }
        }
        public double[] UElements
        {
            get
            {
                double[] d = new double[dc.Count];
                dc.Values.CopyTo(d, 0);
                return d;
            }
        }
    }
}
