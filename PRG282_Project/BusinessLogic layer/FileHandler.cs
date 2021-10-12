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

        public void registercapturer()
        {
            StreamWriter sw = new StreamWriter();

            sw.WriteLine("Username:" + Presentation_Layer.Register.txt_Username.Text + "| Password:" + Presentation_Layer.Register.txt_Password.Text);
        }

        public void logincapturer()
        {

        }

    }
}
