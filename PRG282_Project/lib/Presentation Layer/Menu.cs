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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_studentsearchmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch reg2 = new StudentSearch();
            reg2.FormClosed += (s, args) => this.Close();
            reg2.Show();
        }

        private void btn_studentaddmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent reg2 = new AddStudent();
            reg2.FormClosed += (s, args) => this.Close();
            reg2.Show();
        }
    }
}
