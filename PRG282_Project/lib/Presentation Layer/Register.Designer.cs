
namespace PRG282_Project.Presentation_Layer
{
    partial class Register
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
            this.paswordpanel = new System.Windows.Forms.Panel();
            this.userpanel = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.pb_Pass = new System.Windows.Forms.PictureBox();
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmpanel = new System.Windows.Forms.Panel();
            this.txt_passwordconform = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paswordpanel
            // 
            this.paswordpanel.BackColor = System.Drawing.Color.White;
            this.paswordpanel.Location = new System.Drawing.Point(87, 266);
            this.paswordpanel.Name = "paswordpanel";
            this.paswordpanel.Size = new System.Drawing.Size(200, 1);
            this.paswordpanel.TabIndex = 14;
            // 
            // userpanel
            // 
            this.userpanel.BackColor = System.Drawing.Color.White;
            this.userpanel.Location = new System.Drawing.Point(87, 210);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(200, 1);
            this.userpanel.TabIndex = 13;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.Location = new System.Drawing.Point(87, 245);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(200, 15);
            this.txt_Password.TabIndex = 12;
            this.txt_Password.Text = "Password";
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_UserName.ForeColor = System.Drawing.Color.White;
            this.txt_UserName.Location = new System.Drawing.Point(87, 188);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(200, 16);
            this.txt_UserName.TabIndex = 11;
            this.txt_UserName.Text = "Username";
            this.txt_UserName.Click += new System.EventHandler(this.txt_UserName_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Register.Location = new System.Drawing.Point(44, 347);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(243, 31);
            this.btn_Register.TabIndex = 20;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // pb_Pass
            // 
            this.pb_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Pass.Image = global::PRG282_Project.Properties.Resources.password1;
            this.pb_Pass.Location = new System.Drawing.Point(30, 244);
            this.pb_Pass.Name = "pb_Pass";
            this.pb_Pass.Size = new System.Drawing.Size(30, 23);
            this.pb_Pass.TabIndex = 16;
            this.pb_Pass.TabStop = false;
            // 
            // pb_User
            // 
            this.pb_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_User.Image = global::PRG282_Project.Properties.Resources.user11;
            this.pb_User.Location = new System.Drawing.Point(30, 188);
            this.pb_User.Name = "pb_User";
            this.pb_User.Size = new System.Drawing.Size(30, 23);
            this.pb_User.TabIndex = 15;
            this.pb_User.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.icons8_student_center_100;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // confirmpanel
            // 
            this.confirmpanel.BackColor = System.Drawing.Color.White;
            this.confirmpanel.Location = new System.Drawing.Point(87, 324);
            this.confirmpanel.Name = "confirmpanel";
            this.confirmpanel.Size = new System.Drawing.Size(200, 1);
            this.confirmpanel.TabIndex = 16;
            // 
            // txt_passwordconform
            // 
            this.txt_passwordconform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_passwordconform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwordconform.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordconform.ForeColor = System.Drawing.Color.White;
            this.txt_passwordconform.Location = new System.Drawing.Point(87, 303);
            this.txt_passwordconform.Name = "txt_passwordconform";
            this.txt_passwordconform.Size = new System.Drawing.Size(200, 15);
            this.txt_passwordconform.TabIndex = 15;
            this.txt_passwordconform.Text = "Confirm Password";
            this.txt_passwordconform.Click += new System.EventHandler(this.txt_passwordconform_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(319, 394);
            this.Controls.Add(this.confirmpanel);
            this.Controls.Add(this.txt_passwordconform);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.pb_Pass);
            this.Controls.Add(this.pb_User);
            this.Controls.Add(this.paswordpanel);
            this.Controls.Add(this.userpanel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_Pass;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.Panel paswordpanel;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Panel confirmpanel;
        public System.Windows.Forms.TextBox txt_Password;
        public System.Windows.Forms.TextBox txt_UserName;
        public System.Windows.Forms.TextBox txt_passwordconform;
    }
}