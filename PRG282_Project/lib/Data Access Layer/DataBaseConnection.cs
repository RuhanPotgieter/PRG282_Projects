using System.Data;
using System.Data.SqlClient;
//using System.Web;


namespace PRG282_Project.Data_Access_Layer
{
    class DataBaseConnection : QueryHandler
    {


        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public DataSet ds = new DataSet();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public SqlDataReader dr;



        public DataBaseConnection()
        {
            
            con.ConnectionString = @"Data Source=DESKTOP-50UCQHT;Initial Catalog=Students;Integrated Security=True";
            con.Open();
            cmd.Connection = con;
        }




    }
}
