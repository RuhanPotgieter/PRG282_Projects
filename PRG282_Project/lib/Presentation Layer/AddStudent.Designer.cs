
namespace PRG282_Project.Presentation_Layer
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.surnamepanel = new System.Windows.Forms.Panel();
            this.panelstudentnumber = new System.Windows.Forms.Panel();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_StudentNum = new System.Windows.Forms.TextBox();
            this.genderpanel = new System.Windows.Forms.Panel();
            this.dateofbirthpanel = new System.Windows.Forms.Panel();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.txt_Dateofbirth = new System.Windows.Forms.TextBox();
            this.addresspanel = new System.Windows.Forms.Panel();
            this.phonenumberpanel = new System.Windows.Forms.Panel();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Phonenumber = new System.Windows.Forms.TextBox();
            this.coursecodepanel = new System.Windows.Forms.Panel();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.btn_Addimage = new System.Windows.Forms.Button();
            this.pb_Studentimage = new System.Windows.Forms.PictureBox();
            this.firstnamepanel = new System.Windows.Forms.Panel();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.lbl_Imagefilepath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Studentimage)).BeginInit();
            this.SuspendLayout();
            // 
            // surnamepanel
            // 
            this.surnamepanel.BackColor = System.Drawing.Color.White;
            this.surnamepanel.Location = new System.Drawing.Point(37, 133);
            this.surnamepanel.Name = "surnamepanel";
            this.surnamepanel.Size = new System.Drawing.Size(200, 1);
            this.surnamepanel.TabIndex = 10;
            // 
            // panelstudentnumber
            // 
            this.panelstudentnumber.BackColor = System.Drawing.Color.White;
            this.panelstudentnumber.Location = new System.Drawing.Point(37, 40);
            this.panelstudentnumber.Name = "panelstudentnumber";
            this.panelstudentnumber.Size = new System.Drawing.Size(200, 1);
            this.panelstudentnumber.TabIndex = 9;
            // 
            // txt_Surname
            // 
            this.txt_Surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Surname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Surname.ForeColor = System.Drawing.Color.White;
            this.txt_Surname.Location = new System.Drawing.Point(37, 112);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(200, 15);
            this.txt_Surname.TabIndex = 8;
            this.txt_Surname.Text = "Surname";
            this.txt_Surname.Click += new System.EventHandler(this.txt_Surname_Click);
            // 
            // txt_StudentNum
            // 
            this.txt_StudentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_StudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_StudentNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StudentNum.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_StudentNum.ForeColor = System.Drawing.Color.White;
            this.txt_StudentNum.Location = new System.Drawing.Point(37, 18);
            this.txt_StudentNum.Name = "txt_StudentNum";
            this.txt_StudentNum.Size = new System.Drawing.Size(200, 16);
            this.txt_StudentNum.TabIndex = 7;
            this.txt_StudentNum.Text = "Student Number";
            this.txt_StudentNum.Click += new System.EventHandler(this.txt_StudentNum_Click);
            // 
            // genderpanel
            // 
            this.genderpanel.BackColor = System.Drawing.Color.White;
            this.genderpanel.Location = new System.Drawing.Point(37, 234);
            this.genderpanel.Name = "genderpanel";
            this.genderpanel.Size = new System.Drawing.Size(200, 1);
            this.genderpanel.TabIndex = 14;
            // 
            // dateofbirthpanel
            // 
            this.dateofbirthpanel.BackColor = System.Drawing.Color.White;
            this.dateofbirthpanel.Location = new System.Drawing.Point(37, 186);
            this.dateofbirthpanel.Name = "dateofbirthpanel";
            this.dateofbirthpanel.Size = new System.Drawing.Size(200, 1);
            this.dateofbirthpanel.TabIndex = 13;
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Gender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gender.ForeColor = System.Drawing.Color.White;
            this.txt_Gender.Location = new System.Drawing.Point(37, 213);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(200, 15);
            this.txt_Gender.TabIndex = 12;
            this.txt_Gender.Text = "Gender";
            this.txt_Gender.Click += new System.EventHandler(this.txt_Gender_Click);
            // 
            // txt_Dateofbirth
            // 
            this.txt_Dateofbirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Dateofbirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dateofbirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dateofbirth.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_Dateofbirth.ForeColor = System.Drawing.Color.White;
            this.txt_Dateofbirth.Location = new System.Drawing.Point(37, 164);
            this.txt_Dateofbirth.Name = "txt_Dateofbirth";
            this.txt_Dateofbirth.Size = new System.Drawing.Size(200, 16);
            this.txt_Dateofbirth.TabIndex = 11;
            this.txt_Dateofbirth.Text = "Date of birth";
            this.txt_Dateofbirth.Click += new System.EventHandler(this.txt_Dateofbirth_Click);
            // 
            // addresspanel
            // 
            this.addresspanel.BackColor = System.Drawing.Color.White;
            this.addresspanel.Location = new System.Drawing.Point(37, 340);
            this.addresspanel.Name = "addresspanel";
            this.addresspanel.Size = new System.Drawing.Size(200, 1);
            this.addresspanel.TabIndex = 18;
            // 
            // phonenumberpanel
            // 
            this.phonenumberpanel.BackColor = System.Drawing.Color.White;
            this.phonenumberpanel.Location = new System.Drawing.Point(37, 284);
            this.phonenumberpanel.Name = "phonenumberpanel";
            this.phonenumberpanel.Size = new System.Drawing.Size(200, 1);
            this.phonenumberpanel.TabIndex = 17;
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Address.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.White;
            this.txt_Address.Location = new System.Drawing.Point(37, 319);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(200, 15);
            this.txt_Address.TabIndex = 16;
            this.txt_Address.Text = "Address";
            this.txt_Address.Click += new System.EventHandler(this.txt_Address_Click);
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Phonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phonenumber.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_Phonenumber.ForeColor = System.Drawing.Color.White;
            this.txt_Phonenumber.Location = new System.Drawing.Point(37, 262);
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(200, 16);
            this.txt_Phonenumber.TabIndex = 15;
            this.txt_Phonenumber.Text = "Phone Number";
            this.txt_Phonenumber.Click += new System.EventHandler(this.txt_Phonenumber_Click);
            // 
            // coursecodepanel
            // 
            this.coursecodepanel.BackColor = System.Drawing.Color.White;
            this.coursecodepanel.Location = new System.Drawing.Point(37, 393);
            this.coursecodepanel.Name = "coursecodepanel";
            this.coursecodepanel.Size = new System.Drawing.Size(200, 1);
            this.coursecodepanel.TabIndex = 20;
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_coursecode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_coursecode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursecode.ForeColor = System.Drawing.Color.White;
            this.txt_coursecode.Location = new System.Drawing.Point(37, 372);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(200, 15);
            this.txt_coursecode.TabIndex = 19;
            this.txt_coursecode.Text = "Module code";
            this.txt_coursecode.Click += new System.EventHandler(this.txt_coursecode_Click);
            // 
            // btn_Addimage
            // 
            this.btn_Addimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_Addimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addimage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addimage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Addimage.Location = new System.Drawing.Point(147, 406);
            this.btn_Addimage.Name = "btn_Addimage";
            this.btn_Addimage.Size = new System.Drawing.Size(90, 27);
            this.btn_Addimage.TabIndex = 21;
            this.btn_Addimage.Text = "Add image";
            this.btn_Addimage.UseVisualStyleBackColor = false;
            this.btn_Addimage.Click += new System.EventHandler(this.btn_Addimage_Click);
            // 
            // pb_Studentimage
            // 
            this.pb_Studentimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Studentimage.Location = new System.Drawing.Point(275, 50);
            this.pb_Studentimage.Name = "pb_Studentimage";
            this.pb_Studentimage.Size = new System.Drawing.Size(380, 344);
            this.pb_Studentimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Studentimage.TabIndex = 22;
            this.pb_Studentimage.TabStop = false;
            // 
            // firstnamepanel
            // 
            this.firstnamepanel.BackColor = System.Drawing.Color.White;
            this.firstnamepanel.Location = new System.Drawing.Point(37, 86);
            this.firstnamepanel.Name = "firstnamepanel";
            this.firstnamepanel.Size = new System.Drawing.Size(200, 1);
            this.firstnamepanel.TabIndex = 24;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Firstname.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_Firstname.ForeColor = System.Drawing.Color.White;
            this.txt_Firstname.Location = new System.Drawing.Point(37, 64);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(200, 16);
            this.txt_Firstname.TabIndex = 23;
            this.txt_Firstname.Text = "Firstname";
            this.txt_Firstname.Click += new System.EventHandler(this.txt_Firstname_Click_1);
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_AddStudent.Location = new System.Drawing.Point(37, 406);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(90, 27);
            this.btn_AddStudent.TabIndex = 25;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = false;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // lbl_Imagefilepath
            // 
            this.lbl_Imagefilepath.AutoSize = true;
            this.lbl_Imagefilepath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Imagefilepath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.lbl_Imagefilepath.Location = new System.Drawing.Point(272, 397);
            this.lbl_Imagefilepath.Name = "lbl_Imagefilepath";
            this.lbl_Imagefilepath.Size = new System.Drawing.Size(0, 17);
            this.lbl_Imagefilepath.TabIndex = 26;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(692, 463);
            this.Controls.Add(this.lbl_Imagefilepath);
            this.Controls.Add(this.btn_AddStudent);
            this.Controls.Add(this.firstnamepanel);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.pb_Studentimage);
            this.Controls.Add(this.btn_Addimage);
            this.Controls.Add(this.coursecodepanel);
            this.Controls.Add(this.txt_coursecode);
            this.Controls.Add(this.addresspanel);
            this.Controls.Add(this.phonenumberpanel);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Phonenumber);
            this.Controls.Add(this.genderpanel);
            this.Controls.Add(this.dateofbirthpanel);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_Dateofbirth);
            this.Controls.Add(this.surnamepanel);
            this.Controls.Add(this.panelstudentnumber);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_StudentNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Studentimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel surnamepanel;
        private System.Windows.Forms.Panel panelstudentnumber;
        private System.Windows.Forms.Panel genderpanel;
        private System.Windows.Forms.Panel dateofbirthpanel;
        private System.Windows.Forms.Panel addresspanel;
        private System.Windows.Forms.Panel phonenumberpanel;
        private System.Windows.Forms.Panel coursecodepanel;
        private System.Windows.Forms.Button btn_Addimage;
        private System.Windows.Forms.Panel firstnamepanel;
        public System.Windows.Forms.TextBox txt_StudentNum;
        public System.Windows.Forms.TextBox txt_Firstname;
        public System.Windows.Forms.TextBox txt_Surname;
        public System.Windows.Forms.TextBox txt_Gender;
        public System.Windows.Forms.TextBox txt_Dateofbirth;
        public System.Windows.Forms.TextBox txt_Address;
        public System.Windows.Forms.TextBox txt_Phonenumber;
        public System.Windows.Forms.TextBox txt_coursecode;
        public System.Windows.Forms.PictureBox pb_Studentimage;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Label lbl_Imagefilepath;
    }
}