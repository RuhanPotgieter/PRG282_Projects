
namespace PRG282_Project.Presentation_Layer
{
    partial class messageboxregister
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
            this.btn_messageboxstudentadded = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_messageboxstudentadded
            // 
            this.btn_messageboxstudentadded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_messageboxstudentadded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messageboxstudentadded.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_messageboxstudentadded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_messageboxstudentadded.Location = new System.Drawing.Point(83, 69);
            this.btn_messageboxstudentadded.Name = "btn_messageboxstudentadded";
            this.btn_messageboxstudentadded.Size = new System.Drawing.Size(139, 26);
            this.btn_messageboxstudentadded.TabIndex = 3;
            this.btn_messageboxstudentadded.Text = "OK";
            this.btn_messageboxstudentadded.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration Succesfull";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.lb_Welcome.Location = new System.Drawing.Point(145, 31);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(0, 22);
            this.lb_Welcome.TabIndex = 4;
            // 
            // messageboxregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(323, 131);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.btn_messageboxstudentadded);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageboxregister";
            this.Text = "messageboxregister";
            this.Load += new System.EventHandler(this.messageboxregister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messageboxstudentadded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Welcome;
    }
}