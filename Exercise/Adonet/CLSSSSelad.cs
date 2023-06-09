using System;
using System.Data;
using System.Data.SqlClient;

namespace pradeep.uadonet
{
    class CLSSSSelad
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;
            SqlDataAdapter sqlda = null;
            DataSet ds = null;
            DataTable dt = null;

            string qrySel = null,id=null;

            try
            {
                qrySel = "select * from eatb";

                Console.WriteLine("\nEmployee salary Allowanes for show a row");

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qrySel, sqlcnn);

                sqlda = new SqlDataAdapter(sqlcmd);

                ds = new DataSet();
                sqlda.Fill(ds, "eatb");
                dt = ds.Tables["eatb"];

                int cc = dt.Columns.Count;

                for (int c = 0; c < cc; c++)
                {
                    Console.Write(dt.Columns[c].ColumnName);
                    if (c > 1)
                    {
                        Console.Write("\t\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
                int rc = dt.Rows.Count;

                for (int r = 0; r < rc; r++)
                {
                    for (int c = 0; c < cc; c++)
                    {
                        Console.Write(dt.Rows[r][c] + "\t");
                    }
                    Console.WriteLine();
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
Employee salary Allowanes for show a row
id      ename   esal            hra             da              pf              gpay            npay
1       siva    400000.00       80000.000000    60000.000000    140000.000000   540000.000000   400000.000000
2       pradeep 800000.00       160000.000000   120000.000000   280000.000000   1080000.000000  800000.000000
3       sathish 1000000.00      200000.000000   150000.000000   350000.000000   1350000.000000  1000000.000000
5       divya   500000.00       100000.000000   75000.000000    175000.000000   675000.000000   500000.000000
6       milton  600000.00       120000.000000   90000.000000    210000.000000   810000.000000   600000.000000
7       gopi    700000.00       140000.000000   105000.000000   245000.000000   945000.000000   700000.000000  
*/
