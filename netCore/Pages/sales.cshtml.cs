using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace netCore.Pages
{
    public class salesModel : PageModel
    {
        
        public List<Sales_info> list_name = new List<Sales_info>();
       
        public void OnGet()
        {
            try
            {

              string ConnectionString = "Data Source=INLPF21DBJ6\\MSSQLSERVER1;Initial Catalog=nisha;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
              SqlConnection sqlCon = new SqlConnection(ConnectionString);
              sqlCon.Open();
              string query = "select * from sales_detail where amount<5000";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
               // cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sales_info info = new Sales_info();
                    info.s_id = reader.GetInt32(0);
                    info.s_name = reader.GetString(1);
                    info.amount = reader.GetInt64(2);
                    info.city = reader.GetString(3);
                    info.email_id = reader.GetString(4);

                    list_name.Add(info);


                }
               // list_name.ForEach(x=> Console.WriteLine(x.s_id+" "+x.s_name+" "+x.amount+" "+x.city+" "+x.email_id));
               
                //Console.Log(list_name);
                sqlCon.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
            }
        }
        //public void Delete_Sales(int delete_id)
        //{
        //    try
        //    {

        //        string ConnectionString = "Data Source=INLPF21DBJ6\\MSSQLSERVER1;Initial Catalog=nisha;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        //        sqlCon.Open();
        //        // string query = "select * from sales_detail where amount<5000";

        //        SqlCommand cmd = new SqlCommand("Delete_Sales", sqlCon);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        //Sales_info info1 = new Sales_info();
        //        //info1.s_id = delete_id;

        //        cmd.Parameters.Add("@p_s_id", System.Data.SqlDbType.Int).Value = delete_id;
        //        Console.WriteLine("Delete Sales");
        //        cmd.ExecuteNonQuery();


        //        // list_name.ForEach(x=> Console.WriteLine(x.s_id+" "+x.s_name+" "+x.amount+" "+x.city+" "+x.email_id));

        //        //Console.Log(list_name);
        //        sqlCon.Close();
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Sql related problem");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("C# related problem");
        //    }
        //}

    }


    public class Sales_info
    {
        public int s_id;
      public string s_name,city;
       public long amount;
        public string email_id;

        
    }


}
