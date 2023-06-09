using System;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSUpdaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryUpd = null, id = null, ename = null, esal = null;

            try
            {
                qryUpd = "update eatb set";
                qryUpd += " ename=@ename,";
                qryUpd += " esal=@esal";
                qryUpd +=" where id=@id";

                Console.WriteLine("\nEmployee salary Allowanes for modify a row");

                Console.WriteLine("\nId: ");
                id = Console.ReadLine();


                Console.WriteLine("\nName: ");
                ename = Console.ReadLine();

                Console.Write("\nSalary: ");
                esal = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryUpd, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@id", id);
                sqlcmd.Parameters.AddWithValue("@ename", ename);
                sqlcmd.Parameters.AddWithValue("@esal", esal);

                int afrs = sqlcmd.ExecuteNonQuery();

                if (afrs > 0)
                {
                    Console.WriteLine("\nAffected 1 row");
                }
                else
                {
                    Console.WriteLine("\nAffected 0 row");
                }
            }
            catch (Exception e)
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
 Employee salary Allowanes for modify a row

Id:
6

Name:
milton

Salary: 600000

Affected 1 row

    Employee salary Allowanes for modify a row

Id:
7

Name:
gopi

Salary: 700000

Affected 1 row
*/
