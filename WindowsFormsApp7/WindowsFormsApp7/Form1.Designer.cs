﻿namespace WindowsFormsApp7
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(551, 363);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(12, 44);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 13);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "User name";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(89, 41);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(200, 20);
            this.textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(89, 67);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '.';
            this.textPassword.Size = new System.Drawing.Size(200, 20);
            this.textPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(89, 93);
            this.textPhoneNumber.Multiline = true;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textPhoneNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone number";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(15, 145);
            this.textMessage.MaxLength = 200;
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(611, 212);
            this.textMessage.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(638, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          5SMS                                                                   " +
    "Send  sms message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label3;
    }
}

