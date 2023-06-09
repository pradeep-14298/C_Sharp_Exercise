using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
example for "throw" statement in Exception Handling feature
 */
namespace pradeep.uexceptionhandling
{
    class CLSEHba
    {
        public static int WithDraw(int deposit,int WithDrawAmount)
        {
            if (deposit>WithDrawAmount)
            {
                return deposit - WithDrawAmount;
            }else
            {
                throw new Exception("Invalid transaction");
            }
        }
        public static void Main()
        {
            try
            {
                int ba = WithDraw(100, 20);
                Console.WriteLine("Balance amount:" + ba);
                ba = WithDraw(30, 100);
                Console.WriteLine("Balance amount:" + ba);
            }catch(Exception e)
            {
                Console.WriteLine("err:" + e.Message);
            }
        }
    }
}
/*
Balance amount:80
err:Invalid transaction
 */
