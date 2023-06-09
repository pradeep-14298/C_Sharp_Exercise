using System;
using System.Data.SqlClient;
/*example for detele records in table*/
namespace pradeep.uadonet
{
    class CLSSSDelaa
    {
        public static void Main()
        {
            SqlConnection sqlcnn = null;
            SqlCommand sqlcmd = null;

            string qryDel = null, id = null;

            try
            {
                qryDel = "delete from eatb";
                qryDel += " where id=@id";

                Console.WriteLine("\nEmployee salary Allowanes for erase a row");

                Console.WriteLine("\nId: ");
                id = Console.ReadLine();

                sqlcnn = new SqlConnection(CLSSSCnStr.cnStr);
                sqlcnn.Open();

                sqlcmd = new SqlCommand(qryDel, sqlcnn);
                sqlcmd.Parameters.AddWithValue("@id", id);

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
Employee salary Allowanes for erase a row

Id:
4
*/