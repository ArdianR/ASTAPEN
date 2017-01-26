namespace ASTAPEN.olahdata
{
    partial class User
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInPass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInUser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtInNamaAdm = new System.Windows.Forms.TextBox();
            this.txtDelId = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUpUsername = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpPassBaru = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUpPassLama = new System.Windows.Forms.TextBox();
            this.txtUpNamaAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpPass = new System.Windows.Forms.Label();
            this.txtUpNamaAd = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDeluser = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtDelPass = new System.Windows.Forms.TextBox();
            this.txtDelNamaAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDelId.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // txtInPass
            // 
            this.txtInPass.AutoSize = true;
            this.txtInPass.Location = new System.Drawing.Point(19, 68);
            this.txtInPass.Name = "txtInPass";
            this.txtInPass.Size = new System.Drawing.Size(59, 13);
            this.txtInPass.TabIndex = 3;
            this.txtInPass.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama Admin :";
            // 
            // txtInUser
            // 
            this.txtInUser.Location = new System.Drawing.Point(100, 35);
            this.txtInUser.Name = "txtInUser";
            this.txtInUser.Size = new System.Drawing.Size(212, 20);
            this.txtInUser.TabIndex = 6;
            this.txtInUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(100, 61);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(212, 20);
            this.txtpass.TabIndex = 7;
            // 
            // txtInNamaAdm
            // 
            this.txtInNamaAdm.Location = new System.Drawing.Point(100, 87);
            this.txtInNamaAdm.Name = "txtInNamaAdm";
            this.txtInNamaAdm.Size = new System.Drawing.Size(212, 20);
            this.txtInNamaAdm.TabIndex = 8;
            // 
            // txtDelId
            // 
            this.txtDelId.Controls.Add(this.tabPage1);
            this.txtDelId.Controls.Add(this.tabPage2);
            this.txtDelId.Controls.Add(this.tabPage3);
            this.txtDelId.Location = new System.Drawing.Point(39, 61);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.SelectedIndex = 0;
            this.txtDelId.Size = new System.Drawing.Size(365, 230);
            this.txtDelId.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtpass);
            this.tabPage1.Controls.Add(this.txtInNamaAdm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtInUser);
            this.tabPage1.Controls.Add(this.txtInPass);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Oke";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUpUsername);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtUpPassBaru);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtUpPassLama);
            this.tabPage2.Controls.Add(this.txtUpNamaAdmin);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtUpPass);
            this.tabPage2.Controls.Add(this.txtUpNamaAd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUpUsername
            // 
            this.txtUpUsername.FormattingEnabled = true;
            this.txtUpUsername.Location = new System.Drawing.Point(116, 25);
            this.txtUpUsername.Name = "txtUpUsername";
            this.txtUpUsername.Size = new System.Drawing.Size(222, 21);
            this.txtUpUsername.TabIndex = 20;
            this.txtUpUsername.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password Lama :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtUpPassBaru
            // 
            this.txtUpPassBaru.Location = new System.Drawing.Point(116, 89);
            this.txtUpPassBaru.Name = "txtUpPassBaru";
            this.txtUpPassBaru.PasswordChar = '*';
            this.txtUpPassBaru.Size = new System.Drawing.Size(222, 20);
            this.txtUpPassBaru.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Oke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUpPassLama
            // 
            this.txtUpPassLama.Location = new System.Drawing.Point(116, 56);
            this.txtUpPassLama.Name = "txtUpPassLama";
            this.txtUpPassLama.PasswordChar = '*';
            this.txtUpPassLama.Size = new System.Drawing.Size(222, 20);
            this.txtUpPassLama.TabIndex = 15;
            // 
            // txtUpNamaAdmin
            // 
            this.txtUpNamaAdmin.Location = new System.Drawing.Point(116, 118);
            this.txtUpNamaAdmin.Name = "txtUpNamaAdmin";
            this.txtUpNamaAdmin.Size = new System.Drawing.Size(222, 20);
            this.txtUpNamaAdmin.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username :";
            // 
            // txtUpPass
            // 
            this.txtUpPass.AutoSize = true;
            this.txtUpPass.Location = new System.Drawing.Point(20, 92);
            this.txtUpPass.Name = "txtUpPass";
            this.txtUpPass.Size = new System.Drawing.Size(84, 13);
            this.txtUpPass.TabIndex = 11;
            this.txtUpPass.Text = "Password Baru :";
            // 
            // txtUpNamaAd
            // 
            this.txtUpNamaAd.AutoSize = true;
            this.txtUpNamaAd.Location = new System.Drawing.Point(20, 121);
            this.txtUpNamaAd.Name = "txtUpNamaAd";
            this.txtUpNamaAd.Size = new System.Drawing.Size(73, 13);
            this.txtUpNamaAd.TabIndex = 12;
            this.txtUpNamaAd.Text = "Nama Admin :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDeluser);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.txtDelPass);
            this.tabPage3.Controls.Add(this.txtDelNamaAd);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(357, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDeluser
            // 
            this.txtDeluser.FormattingEnabled = true;
            this.txtDeluser.Location = new System.Drawing.Point(126, 41);
            this.txtDeluser.Name = "txtDeluser";
            this.txtDeluser.Size = new System.Drawing.Size(212, 21);
            this.txtDeluser.TabIndex = 21;
            this.txtDeluser.SelectedIndexChanged += new System.EventHandler(this.txtDeluser_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Oke";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtDelPass
            // 
            this.txtDelPass.Location = new System.Drawing.Point(126, 72);
            this.txtDelPass.Name = "txtDelPass";
            this.txtDelPass.PasswordChar = '*';
            this.txtDelPass.Size = new System.Drawing.Size(212, 20);
            this.txtDelPass.TabIndex = 15;
            // 
            // txtDelNamaAd
            // 
            this.txtDelNamaAd.Enabled = false;
            this.txtDelNamaAd.Location = new System.Drawing.Point(126, 102);
            this.txtDelNamaAd.Name = "txtDelNamaAd";
            this.txtDelNamaAd.Size = new System.Drawing.Size(212, 20);
            this.txtDelNamaAd.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Username :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Password :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nama Admin :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDelId);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.Text = " ";
            this.Load += new System.EventHandler(this.User_Load);
            this.txtDelId.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtInPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInUser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtInNamaAdm;
        private System.Windows.Forms.TabControl txtDelId;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtUpPassLama;
        private System.Windows.Forms.TextBox txtUpNamaAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtUpPass;
        private System.Windows.Forms.Label txtUpNamaAd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDelPass;
        private System.Windows.Forms.TextBox txtDelNamaAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpPassBaru;
        private System.Windows.Forms.ComboBox txtUpUsername;
        private System.Windows.Forms.ComboBox txtDeluser;
    }
}