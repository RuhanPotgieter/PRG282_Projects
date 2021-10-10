using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.BusinessLogic_layer
{
    class FileHandler: Presentation_Layer.Register
    {
        public static void Read()
        {
            Presentation_Layer.Register re = new Presentation_Layer.Register();
            StreamReader sr = new StreamReader(@"logininfo.txt");
            string olddata = sr.ReadLine();
            sr.Close();
            string[] data = new string[2];
            data[0] = re.txt_UserName.Text;
            data[1] = re.txt_Password.Text;
            StreamWriter sw = new StreamWriter(@"logininfo.txt");
            sw.WriteLine(olddata + (Environment.NewLine) + "Username=" + data[0] + " ,Password=" + data[1]);

            sw.Close();


        }

    }
}
