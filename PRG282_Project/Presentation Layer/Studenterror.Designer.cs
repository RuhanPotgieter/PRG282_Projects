
namespace PRG282_Project.Presentation_Layer
{
    partial class Studenterror
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
            this.btn_Error = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Error
            // 
            this.btn_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.btn_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Error.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Error.Location = new System.Drawing.Point(96, 93);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(103, 26);
            this.btn_Error.TabIndex = 0;
            this.btn_Error.Text = "OK";
            this.btn_Error.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please check if you entered the \r\n            details correctly or \r\n            " +
    "  filled all the fields";
            // 
            // Studenterror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(323, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studenterror";
            this.Text = "Studenterror";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Label label1;
    }
}