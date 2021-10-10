
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
            this.emailpanel = new System.Windows.Forms.Panel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pb_Email = new System.Windows.Forms.PictureBox();
            this.pb_Pass = new System.Windows.Forms.PictureBox();
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmpanel = new System.Windows.Forms.Panel();
            this.txt_passwordconform = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Email)).BeginInit();
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
            // emailpanel
            // 
            this.emailpanel.BackColor = System.Drawing.Color.White;
            this.emailpanel.Location = new System.Drawing.Point(87, 384);
            this.emailpanel.Name = "emailpanel";
            this.emailpanel.Size = new System.Drawing.Size(200, 1);
            this.emailpanel.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.White;
            this.txt_Email.Location = new System.Drawing.Point(87, 363);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 15);
            this.txt_Email.TabIndex = 17;
            this.txt_Email.Text = "Email";
            this.txt_Email.Click += new System.EventHandler(this.txt_Email_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2.Location = new System.Drawing.Point(44, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pb_Email
            // 
            this.pb_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Email.Image = global::PRG282_Project.Properties.Resources.email1;
            this.pb_Email.Location = new System.Drawing.Point(30, 362);
            this.pb_Email.Name = "pb_Email";
            this.pb_Email.Size = new System.Drawing.Size(30, 25);
            this.pb_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Email.TabIndex = 19;
            this.pb_Email.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(319, 478);
            this.Controls.Add(this.confirmpanel);
            this.Controls.Add(this.txt_passwordconform);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_Email);
            this.Controls.Add(this.emailpanel);
            this.Controls.Add(this.txt_Email);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Email)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.PictureBox pb_Email;
        private System.Windows.Forms.Panel emailpanel;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel confirmpanel;
        private System.Windows.Forms.TextBox txt_passwordconform;
    }
}