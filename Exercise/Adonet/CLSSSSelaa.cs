using System;
using System.Data;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSSelaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrySel= null;

            try
            {
                qrySel = "select * from eatb";

                Console.WriteLine("\nEmployee salary Allowanes");
                Console.WriteLine("for show no. of columns and rows\n");
               
                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                sqlda.Fill(ds, "eatb");
                dt = ds.Tables["eatb"];

                Console.WriteLine("No of columns: " + dt.Columns.Count);
                Console.WriteLine("No of rows: " + dt.Rows.Count);

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
  Employee salary Allowanes
for show no. of columns and rows

No of columns: 8
No of rows: 6
*/