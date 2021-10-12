﻿using System;
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

            
            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;

            
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

        private void txt_studentname_Click(object sender, EventArgs e)
        {
            txt_studentname.Clear();

            firstnamepanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_studentname.ForeColor = Color.FromArgb(0, 101, 74);


            panelstudentnumber.BackColor = Color.White;
            txt_StudentNum.ForeColor = Color.White;


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


            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;


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


            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;


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


            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;


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


            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;


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


            firstnamepanel.BackColor = Color.White;
            txt_studentname.ForeColor = Color.White;


            dateofbirthpanel.BackColor = Color.White;
            txt_Dateofbirth.ForeColor = Color.White;


            genderpanel.BackColor = Color.White;
            txt_Gender.ForeColor = Color.White;


            phonenumberpanel.BackColor = Color.White;
            txt_Phonenumber.ForeColor = Color.White;


            addresspanel.BackColor = Color.White;
            txt_Address.ForeColor = Color.White;
        }
    }
}
