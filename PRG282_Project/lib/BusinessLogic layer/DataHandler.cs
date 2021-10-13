using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Data_Access_Layer;
using PRG282_Project.Presentation_Layer;

namespace PRG282_Project.BusinessLogic_layer
{
    class DataHandler 
    {
        public void loginstuff()
        {
            Login loginform = new Login();
            loginform.
        }
        public void searchstudentstuff()
        {
            StudentSearch sts = new StudentSearch();
            sts.
        }
        public void addstudentstuff()
        {
            QueryHandler qh = new QueryHandler();
            qh.AddStudents();
        }

        public void PullData (int studentnum, string name, string surname, object studentimage, string dob, string gender, int phonenumber, string address, string modulecode)
        {
            Student Pull = new Student(studentnum,name,surname,studentimage,dob,gender,phonenumber,address,modulecode) ; 
            
        }
        
        

    }
}
