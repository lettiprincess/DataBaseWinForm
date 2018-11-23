namespace WindowsForms
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
            this.SuspendLayout();
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(13, 13);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(259, 20);
            this.nevTB.TabIndex = 0;
            // 
            // jelszoTB
            // 
            this.jelszoTB.Location = new System.Drawing.Point(13, 40);
            this.jelszoTB.Name = "jelszoTB";
            this.jelszoTB.PasswordChar = '*';
            this.jelszoTB.Size = new System.Drawing.Size(259, 20);
            this.jelszoTB.TabIndex = 1;
            // 
            // regdatumDTP
            // 
            this.regdatumDTP.Location = new System.Drawing.Point(13, 67);
            this.regdatumDTP.Name = "regdatumDTP";
            this.regdatumDTP.Size = new System.Drawing.Size(259, 20);
            this.regdatumDTP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regdatumDTP);
            this.Controls.Add(this.jelszoTB);
            this.Controls.Add(this.nevTB);
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
    }
}

