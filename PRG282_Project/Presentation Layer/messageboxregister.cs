using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer
{
    public partial class messageboxregister : Form
    {
        public messageboxregister()
        {
            InitializeComponent();
        }

        private void messageboxregister_Load(object sender, EventArgs e)
        {
            Presentation_Layer.Login l = new Login();
            lb_Welcome.Text = "Welcome {0}"+l.txt_UserName.Text;
        }
    }
}
