using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PRG282_Project.BusinessLogic_layer;
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
            con.ConnectionString = @"Data Source=DESKTOP-50UCQHT;Initial Catalog=Students;Integrated Security=True";
            con.Open();
            cmd.Connection = con;
        }

        


    }
}
