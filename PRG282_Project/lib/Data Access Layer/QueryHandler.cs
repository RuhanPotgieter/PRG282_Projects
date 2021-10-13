using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PRG282_Project.BusinessLogic_layer;

namespace PRG282_Project.Data_Access_Layer
{
    public class QueryHandler 
    {
        DataHandler dh = new DataHandler();
        DataBaseConnection dbc = new DataBaseConnection();
        public void AddStudents()
        {
            
           
            string conn = Convert.ToString(dbc.con);
            using (SqlConnection con1 = new SqlConnection(conn))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("InsertStudent", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Studentnum", dh.txt_StudentNum.Text.Trim());
                cmd.Parameters.AddWithValue("@Firstname", ads.txt_Firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@Surname", ads.txt_Surname.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", ads.txt_Dateofbirth.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", ads.txt_Gender.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", ads.txt_Phonenumber.Text.Trim());
                cmd.Parameters.AddWithValue("@homeaddress", ads.txt_Address.Text.Trim());
                cmd.Parameters.AddWithValue("@modulecode", ads.txt_coursecode.Text.Trim());
                cmd.Parameters.AddWithValue("@studentphoto", ads.pb_Studentimage.Image);
                cmd.ExecuteNonQuery();
               
                reset();

            }

        }
        public void reset()
        {

        }

        public void DeleteStudent()
        {
            Presentation_Layer.AddStudent ads = new Presentation_Layer.AddStudent();
            DataBaseConnection dbc = new DataBaseConnection();
            string conn = Convert.ToString(dbc.con);
            using (SqlConnection con1 = new SqlConnection(conn))
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("DeleteStudent", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Studentnum", ads.txt_StudentNum.Text.Trim());
                cmd.Parameters.AddWithValue("@Firstname", ads.txt_Firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@Surname", ads.txt_Surname.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", ads.txt_Dateofbirth.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", ads.txt_Gender.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", ads.txt_Phonenumber.Text.Trim());
                cmd.Parameters.AddWithValue("@homeaddress", ads.txt_Address.Text.Trim());
                cmd.Parameters.AddWithValue("@modulecode", ads.txt_coursecode.Text.Trim());
                cmd.Parameters.AddWithValue("@studentphoto", ads.pb_Studentimage.Image);
                cmd.ExecuteNonQuery();

                reset();

            }
        }
        public void UpdateStudent()
        {

        }

        

        public void Displaydata()
        {
            
            DataBaseConnection dbc = new DataBaseConnection();
            string conn = Convert.ToString(dbc.con);
            using (SqlConnection con1 = new SqlConnection(conn))
            {
                con1.Open();
                
                SqlDataAdapter sda = new SqlDataAdapter("allStudent", con1);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                sts.dgv_Studentsdetails.DataSource = dtbl;
                
            }
        }

        public void SearchStudent()
        {
            SearchStudent sst = new SearchStudent();
            DataBaseConnection dbc = new DataBaseConnection();
            string conn = Convert.ToString(dbc.con);
            using (SqlConnection con1 = new SqlConnection(conn)) 
            {
                int studnum = int.Parse(sst.txt_Search.Text);
                SqlCommand cmd = new SqlCommand("SearchStudent", con1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sst.dgv_Studentsdetails.DataSource = dt;
            }
                
        }


    }
}
