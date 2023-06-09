using System;
using System.Data;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSelab
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

                Console.WriteLine("\nEmployee salary Allowanes table column name");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);

                ds = new DataSet();
                sqlda.Fill(ds, "eatb");
                dt = ds.Tables["eatb"];

                int cc = dt.Columns.Count;
                for (int c=0; c<cc;c++)
                {
                    Console.Write(dt.Columns[c].ColumnName + "\t");
                }
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
  Employee salary Allowanes table column name
id      ename   esal    hra     da      pf      gpay    npay
*/
