﻿namespace WindowsForms
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
            this.nevTB = new System.Windows.Forms.TextBox();
            this.jelszoTB = new System.Windows.Forms.TextBox();
            this.regdatumDTP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nevDel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jelszoDel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.regdatumUpdate = new System.Windows.Forms.DateTimePicker();
            this.nevLogin = new System.Windows.Forms.TextBox();
            this.jelszoLogin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(17, 64);
            this.nevTB.Margin = new System.Windows.Forms.Padding(4);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(344, 22);
            this.nevTB.TabIndex = 0;
            // 
            // jelszoTB
            // 
            this.jelszoTB.Location = new System.Drawing.Point(17, 111);
            this.jelszoTB.Margin = new System.Windows.Forms.Padding(4);
            this.jelszoTB.Name = "jelszoTB";
            this.jelszoTB.PasswordChar = '*';
            this.jelszoTB.Size = new System.Drawing.Size(344, 22);
            this.jelszoTB.TabIndex = 1;
            // 
            // regdatumDTP
            // 
            this.regdatumDTP.Location = new System.Drawing.Point(17, 158);
            this.regdatumDTP.Margin = new System.Windows.Forms.Padding(4);
            this.regdatumDTP.Name = "regdatumDTP";
            this.regdatumDTP.Size = new System.Drawing.Size(344, 22);
            this.regdatumDTP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regisztráció";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DELETE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "INSERT";
            // 
            // nevDel
            // 
            this.nevDel.Location = new System.Drawing.Point(392, 64);
            this.nevDel.Name = "nevDel";
            this.nevDel.Size = new System.Drawing.Size(348, 22);
            this.nevDel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Név:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jelszó:";
            // 
            // jelszoDel
            // 
            this.jelszoDel.Location = new System.Drawing.Point(392, 111);
            this.jelszoDel.Name = "jelszoDel";
            this.jelszoDel.Size = new System.Drawing.Size(347, 22);
            this.jelszoDel.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Törlés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "UPDATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Név:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Jelszó:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Dátum:";
            // 
            // regdatumUpdate
            // 
            this.regdatumUpdate.Location = new System.Drawing.Point(395, 235);
            this.regdatumUpdate.Name = "regdatumUpdate";
            this.regdatumUpdate.Size = new System.Drawing.Size(347, 22);
            this.regdatumUpdate.TabIndex = 18;
            // 
            // nevLogin
            // 
            this.nevLogin.Location = new System.Drawing.Point(13, 283);
            this.nevLogin.Name = "nevLogin";
            this.nevLogin.Size = new System.Drawing.Size(348, 22);
            this.nevLogin.TabIndex = 19;
            // 
            // jelszoLogin
            // 
            this.jelszoLogin.Location = new System.Drawing.Point(13, 333);
            this.jelszoLogin.Name = "jelszoLogin";
            this.jelszoLogin.PasswordChar = '*';
            this.jelszoLogin.Size = new System.Drawing.Size(347, 22);
            this.jelszoLogin.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(622, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "Módosítás";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "LOGIN";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(228, 361);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 39);
            this.login.TabIndex = 23;
            this.login.Text = "Bejelentkezés";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 404);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.jelszoLogin);
            this.Controls.Add(this.nevLogin);
            this.Controls.Add(this.regdatumUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jelszoDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nevDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regdatumDTP);
            this.Controls.Add(this.jelszoTB);
            this.Controls.Add(this.nevTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.TextBox jelszoTB;
        private System.Windows.Forms.DateTimePicker regdatumDTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nevDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox jelszoDel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker regdatumUpdate;
        private System.Windows.Forms.TextBox nevLogin;
        private System.Windows.Forms.TextBox jelszoLogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button login;
    }
}

