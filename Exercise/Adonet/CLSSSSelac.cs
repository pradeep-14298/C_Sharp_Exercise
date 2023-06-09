using System;
using System.Data;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSSelac
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrySel = null;

            try
            {
                qrySel = "select * from eatb";

                Console.WriteLine("\nEmployee salary Allowanes");
                Console.WriteLine(" for show specific rows");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);

                ds = new DataSet();
                sqlda.Fill(ds, "eatb");
                dt = ds.Tables["eatb"];

                
               Console.WriteLine("\n1st row , 7 columns value");
                Console.Write(dt.Rows[0][0] + "\t");
                Console.Write(dt.Rows[0][1] + "\t");
                Console.Write(dt.Rows[0][2] + "\t");
                Console.Write(dt.Rows[0][3] + "\t");
                Console.Write(dt.Rows[0][4] + "\t");
                Console.Write(dt.Rows[0][5] + "\t");
                Console.Write(dt.Rows[0][6] + "\t");
                Console.Write(dt.Rows[0][7]);

                Console.WriteLine("\n5th row , 7 columns value");
                Console.Write(dt.Rows[4][0] + "\t");
                Console.Write(dt.Rows[4][1] + "\t");
                Console.Write(dt.Rows[4][2] + "\t");
                Console.Write(dt.Rows[4][3] + "\t");
                Console.Write(dt.Rows[4][4] + "\t");
                Console.Write(dt.Rows[4][5] + "\t");
                Console.Write(dt.Rows[4][6] + "\t");
                Console.Write(dt.Rows[4][7]);
                Console.WriteLine();

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
 for show specific rows

1st row , 7 columns value
1       siva    400000.00       80000.000000    60000.000000    140000.000000   540000.000000   400000.000000
5th row , 7 columns value
6       milton  600000.00       120000.000000   90000.000000    210000.000000   810000.000000   600000.000000
  
*/
