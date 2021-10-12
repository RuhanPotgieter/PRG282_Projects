using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace PRG282_Project.Data_Access_Layer
{
    class DataBaseConnection 
    {

       public DataBaseConnection() { }

        string conn = "Server=(local); Data Source=DESKTOP-50UCQHT;Initial Catalog=Students;Integrated Security=True";
        SqlConnection con;

        public void Oponconnection()
        {
            con = new SqlConnection(conn);
            con.Open();

        }

        public void Closeconnection()
        {
            con.Close();
        }


    }
}
