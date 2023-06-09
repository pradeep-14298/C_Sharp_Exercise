using System;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSSInsaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryIns = null, ename = null, esal = null;

            try
            {
                qryIns = "insert into eatb";
                qryIns += "(ename,esal)values";
                qryIns += "(@ename,@esal);";

                Console.WriteLine("\nEmployee salary Allowanes for make a row");
                Console.WriteLine("\nName: ");
                ename = Console.ReadLine();

                Console.Write("\nSalary: ");
                esal = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryIns, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@ename", ename);
                sqlcmd.Parameters.AddWithValue("@esal", esal);

                int afrs = sqlcmd.ExecuteNonQuery();

                if(afrs >0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }else
                {
                    Console.WriteLine("\nAffected 0 row");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Err.: " + e.Message);
            }
            finally
            {
                sqlcnn.Close();
            }
        }
    }
}
/*
Employee salary Allowanes for make a row

Name:
divya

Salary: 500000

Affected 1 row

Employee salary Allowanes for make a row

Name:
sathish

Salary: 800000

Affected 1 row

    Employee salary Allowanes for make a row

Name:
pradeep

Salary: 700000

Affected 1 row
*/
