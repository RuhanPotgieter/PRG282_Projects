using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.BusinessLogic_layer
{
    class FileHandler
    {
        public static void Read()
        {
            try
            {
                Presentation_Layer.Login l = new Presentation_Layer.Login();
                StreamReader sr = new StreamReader(@"logininfo.txt");
                string olddate = sr.ReadLine();
                sr.Close();
                string[] data = new string[2];
                data[0] = l.txt_Username.Text;
                data[1] = l.txt_Password.Text;

            }
            catch (customException)
            {

                throw;
            }

        }

    }
}
