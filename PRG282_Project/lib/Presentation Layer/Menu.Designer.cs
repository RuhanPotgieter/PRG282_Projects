
namespace PRG282_Project.Presentation_Layer
{
    partial class Menu
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
            this.btn_studentaddmenu = new System.Windows.Forms.Button();
            this.btn_studentsearchmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_studentaddmenu
            // 
            this.btn_studentaddmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_studentaddmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentaddmenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentaddmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_studentaddmenu.Location = new System.Drawing.Point(150, 153);
            this.btn_studentaddmenu.Name = "btn_studentaddmenu";
            this.btn_studentaddmenu.Size = new System.Drawing.Size(128, 63);
            this.btn_studentaddmenu.TabIndex = 0;
            this.btn_studentaddmenu.Text = "Add student";
            this.btn_studentaddmenu.UseVisualStyleBackColor = false;
            // 
            // btn_studentsearchmenu
            // 
            this.btn_studentsearchmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_studentsearchmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentsearchmenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentsearchmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_studentsearchmenu.Location = new System.Drawing.Point(12, 153);
            this.btn_studentsearchmenu.Name = "btn_studentsearchmenu";
            this.btn_studentsearchmenu.Size = new System.Drawing.Size(128, 63);
            this.btn_studentsearchmenu.TabIndex = 1;
            this.btn_studentsearchmenu.Text = "Search for student";
            this.btn_studentsearchmenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.icons8_student_center_100;
            this.pictureBox1.Location = new System.Drawing.Point(69, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(290, 228);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_studentsearchmenu);
            this.Controls.Add(this.btn_studentaddmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_studentaddmenu;
        private System.Windows.Forms.Button btn_studentsearchmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}