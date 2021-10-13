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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void txt_StudentNum_Click(object sender, EventArgs e)
        {
            txt_StudentNum.Clear();

            panelstudentnumber.BackColor = Color.FromArgb(0, 101, 74);
            txt_StudentNum.ForeColor = Color.FromArgb(0, 101, 74);


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Firstname_Click_1(object sender, EventArgs e)
        {
            txt_Firstname.Clear();

            firstnamepanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Firstname.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Surname_Click(object sender, EventArgs e)
        {
            txt_Surname.Clear();

            surnamepanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Surname.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            firstnamepanel.BackColor = Color.White;
            txt_Firstname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Dateofbirth_Click(object sender, EventArgs e)
        {
            txt_Dateofbirth.Clear();

            dateofbirthpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Dateofbirth.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Gender_Click(object sender, EventArgs e)
        {
            txt_Gender.Clear();

            genderpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Gender.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Phonenumber_Click(object sender, EventArgs e)
        {
            txt_Phonenumber.Clear();

            phonenumberpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Phonenumber.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_Address_Click(object sender, EventArgs e)
        {
            txt_Address.Clear();

            addresspanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Address.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            coursecodepanel.BackColor = Color.White;
            txt_coursecode.ForeColor = Color.White;
        }

        private void txt_coursecode_Click(object sender, EventArgs e)
        {
            txt_coursecode.Clear();

            coursecodepanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_coursecode.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


            surnamepanel.BackColor = Color.White;
            txt_Surname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            DataHandler dhq = new DataHandler();
            dhq.addstudentstuff();
        }

        private void btn_Addimage_Click(object sender, EventArgs e)
        {
            AddStudent ads = new AddStudent();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_Studentimage.Image = new Bitmap(open.FileName);
                lbl_Imagefilepath.Text = "Image: " + open.FileName;
            }


        }
    }
}
