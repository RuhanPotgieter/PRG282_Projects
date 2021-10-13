using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.BusinessLogic_layer;


namespace PRG282_Project.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_UserName_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            pb_User.BackgroundImage = Properties.Resources.user21;
            userpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_UserName.ForeColor = Color.FromArgb(0, 101, 74);

            pb_Pass.BackgroundImage = Properties.Resources.password1;
            paswordpanel.BackColor = Color.White;
            txt_Password.ForeColor = Color.White;

        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
            txt_Password.PasswordChar = '*';
            pb_Pass.BackgroundImage = Properties.Resources.pass2;
            paswordpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Password.ForeColor = Color.FromArgb(0, 101, 74);

            pb_User.BackgroundImage = Properties.Resources.user1;
            userpanel.BackColor = Color.White;
            txt_UserName.ForeColor = Color.White;
        }

        private void btn_RegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg2 = new Register();
            
            reg2.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
        }
    }
}
