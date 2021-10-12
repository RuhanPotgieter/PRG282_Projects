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
    public partial class StudentSearch : Form
    {
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            pb_search.BackgroundImage = Properties.Resources.search1;
            searchpanel.BackColor = Color.FromArgb(0, 101, 74);
            txt_Search.ForeColor = Color.FromArgb(0, 101, 74);
        }
    }
}
