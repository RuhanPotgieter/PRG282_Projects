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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        lib.BusinessLogic_layer.FileHandler fh = new lib.BusinessLogic_layer.FileHandler();

        private void txt_UserName_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            pb_User.BackgroundImage = Properties.Resources.user21;
            userpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_UserName.ForeColor = Color.FromArgb(0, 101, 74);

            pb_Pass.BackgroundImage = Properties.Resources.password1;
            paswordpanel.BackColor = Color.White;
            txt_Password.ForeColor = Color.White;

            confirmpanel.BackColor = Color.White;
            txt_passwordconform.ForeColor = Color.White;


        }

        private void txt_Password_Click(object sender, EventArgs e)
        {

            txt_Password.Clear();
            txt_Password.PasswordChar = '*';
            pb_Pass.BackgroundImage = Properties.Resources.pass2;
            paswordpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Password.ForeColor = Color.FromArgb(0, 101, 74);

            pb_User.BackgroundImage = Properties.Resources.user11;
            userpanel.BackColor = Color.White;
            txt_UserName.ForeColor = Color.White;

            confirmpanel.BackColor = Color.White;
            txt_passwordconform.ForeColor = Color.White;


        }

        private void txt_passwordconform_Click(object sender, EventArgs e)
        {
            txt_passwordconform.Clear();
            txt_passwordconform.PasswordChar = '*';
            pb_Pass.BackgroundImage = Properties.Resources.pass2;
            confirmpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_passwordconform.ForeColor = Color.FromArgb(0, 101, 74);

            pb_User.BackgroundImage = Properties.Resources.user11;
            userpanel.BackColor = Color.White;
            txt_UserName.ForeColor = Color.White;

            userpanel.BackColor = Color.White;
            txt_UserName.ForeColor = Color.White;

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            fh.registercapturer();

            
        }
    }
}
