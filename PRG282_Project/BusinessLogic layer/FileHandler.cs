using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.BusinessLogic_layer
{
    class FileHandler: Presentation_Layer.Login
    {
        public static void Read()
        {
            Presentation_Layer.Login l = new Presentation_Layer.Login();
            StreamReader sr = new StreamReader(@"logininfo.txt");
            string olddata = sr.ReadLine();
            sr.Close();
            string[] data = new string[2];
            data[0] = l.txt
        }

    }
}
