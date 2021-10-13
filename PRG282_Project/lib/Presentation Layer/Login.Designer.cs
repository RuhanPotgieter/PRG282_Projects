
namespace PRG282_Project.Presentation_Layer
{
    partial class Login
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.userpanel = new System.Windows.Forms.Panel();
            this.paswordpanel = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_RegisterForm = new System.Windows.Forms.Button();
            this.pb_Pass = new System.Windows.Forms.PictureBox();
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_UserName.ForeColor = System.Drawing.Color.White;
            this.txt_UserName.Location = new System.Drawing.Point(86, 230);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(200, 16);
            this.txt_UserName.TabIndex = 3;
            this.txt_UserName.Text = "Username";
            this.txt_UserName.Click += new System.EventHandler(this.txt_UserName_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.Location = new System.Drawing.Point(86, 287);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(200, 15);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.Text = "Password";
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // userpanel
            // 
            this.userpanel.BackColor = System.Drawing.Color.White;
            this.userpanel.Location = new System.Drawing.Point(86, 252);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(200, 1);
            this.userpanel.TabIndex = 5;
            // 
            // paswordpanel
            // 
            this.paswordpanel.BackColor = System.Drawing.Color.White;
            this.paswordpanel.Location = new System.Drawing.Point(86, 308);
            this.paswordpanel.Name = "paswordpanel";
            this.paswordpanel.Size = new System.Drawing.Size(200, 1);
            this.paswordpanel.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Login.Location = new System.Drawing.Point(43, 348);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(243, 31);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_RegisterForm
            // 
            this.btn_RegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterForm.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterForm.Location = new System.Drawing.Point(43, 385);
            this.btn_RegisterForm.Name = "btn_RegisterForm";
            this.btn_RegisterForm.Size = new System.Drawing.Size(243, 31);
            this.btn_RegisterForm.TabIndex = 8;
            this.btn_RegisterForm.Text = "Register";
            this.btn_RegisterForm.UseVisualStyleBackColor = true;
            this.btn_RegisterForm.Click += new System.EventHandler(this.btn_RegisterForm_Click);
            // 
            // pb_Pass
            // 
            this.pb_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Pass.Image = global::PRG282_Project.Properties.Resources.password1;
            this.pb_Pass.Location = new System.Drawing.Point(29, 286);
            this.pb_Pass.Name = "pb_Pass";
            this.pb_Pass.Size = new System.Drawing.Size(30, 23);
            this.pb_Pass.TabIndex = 10;
            this.pb_Pass.TabStop = false;
            // 
            // pb_User
            // 
            this.pb_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_User.Image = global::PRG282_Project.Properties.Resources.user1;
            this.pb_User.Location = new System.Drawing.Point(29, 230);
            this.pb_User.Name = "pb_User";
            this.pb_User.Size = new System.Drawing.Size(30, 23);
            this.pb_User.TabIndex = 9;
            this.pb_User.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.icons8_student_center_100;
            this.pictureBox1.Location = new System.Drawing.Point(102, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(345, 467);
            this.Controls.Add(this.pb_Pass);
            this.Controls.Add(this.pb_User);
            this.Controls.Add(this.btn_RegisterForm);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.paswordpanel);
            this.Controls.Add(this.userpanel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Panel paswordpanel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_RegisterForm;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.PictureBox pb_Pass;
        public System.Windows.Forms.TextBox txt_UserName;
        public System.Windows.Forms.TextBox txt_Password;
    }
}