using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradeep
{
    public class UDCLMath
    {
        public int udmsum(int x,int y)
        {
            return x + y;
        }
        public static int udmMinus(int x,int y)
        {
            return x - y;
        }
        public void udmMultiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void udmDivide(int x,int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
