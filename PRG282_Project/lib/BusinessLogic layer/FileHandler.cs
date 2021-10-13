using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PRG282_Project.Presentation_Layer;



namespace PRG282_Project.lib.BusinessLogic_layer
{
    class FileHandler : Presentation_Layer.Login
    {
        
        Login l = new Login();
        Register r = new Register();
        public void registercapturer()
        {

            if (r.txt_UserName.Text == "" || r.txt_Password.Text == "")
            {
                MessageBox.Show("Please enter a Username and Password");
            }
            else if (r.txt_Password.Text != r.txt_passwordconform.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                StreamWriter sw = new StreamWriter("logininfo.txt");
                sw.WriteLine("Username: " + l.txt_UserName + ", Password: " + l.txt_Password + ";");
                Clear();
            }
            



        }

        public void logincapturer()
        {

        }

        public void Clear()
        {
            r.txt_UserName.Text = r.txt_Password.Text = r.txt_passwordconform.Text = "";
        }
    }
}
