namespace ASTAPEN.olahdata
{
    partial class Kepala_keluarga
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInNoKK = new System.Windows.Forms.TextBox();
            this.txtInNamaKK = new System.Windows.Forms.TextBox();
            this.txtInAlamat = new System.Windows.Forms.TextBox();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.bkjkj = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUpNoKK = new System.Windows.Forms.ComboBox();
            this.txtUpAlmtKK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpNamaKK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDelNoKK = new System.Windows.Forms.ComboBox();
            this.txtDelAlmtKK = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDelNamaKK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bkjkj.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kartu keluarga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No KK :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama KK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat KK :";
            // 
            // txtInNoKK
            // 
            this.txtInNoKK.Location = new System.Drawing.Point(142, 57);
            this.txtInNoKK.Name = "txtInNoKK";
            this.txtInNoKK.Size = new System.Drawing.Size(284, 20);
            this.txtInNoKK.TabIndex = 4;
            // 
            // txtInNamaKK
            // 
            this.txtInNamaKK.Location = new System.Drawing.Point(142, 94);
            this.txtInNamaKK.Name = "txtInNamaKK";
            this.txtInNamaKK.Size = new System.Drawing.Size(284, 20);
            this.txtInNamaKK.TabIndex = 5;
            // 
            // txtInAlamat
            // 
            this.txtInAlamat.Location = new System.Drawing.Point(142, 129);
            this.txtInAlamat.Name = "txtInAlamat";
            this.txtInAlamat.Size = new System.Drawing.Size(284, 20);
            this.txtInAlamat.TabIndex = 6;
            // 
            // txtSubmit
            // 
            this.txtSubmit.Location = new System.Drawing.Point(351, 193);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(75, 23);
            this.txtSubmit.TabIndex = 7;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.UseVisualStyleBackColor = true;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // bkjkj
            // 
            this.bkjkj.Controls.Add(this.tabPage1);
            this.bkjkj.Controls.Add(this.tabPage2);
            this.bkjkj.Controls.Add(this.tabPage3);
            this.bkjkj.Location = new System.Drawing.Point(12, 48);
            this.bkjkj.Name = "bkjkj";
            this.bkjkj.SelectedIndex = 0;
            this.bkjkj.Size = new System.Drawing.Size(506, 280);
            this.bkjkj.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtInAlamat);
            this.tabPage1.Controls.Add(this.txtSubmit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtInNamaKK);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtInNoKK);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUpNoKK);
            this.tabPage2.Controls.Add(this.txtUpAlmtKK);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtUpNamaKK);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUpNoKK
            // 
            this.txtUpNoKK.FormattingEnabled = true;
            this.txtUpNoKK.Location = new System.Drawing.Point(112, 51);
            this.txtUpNoKK.Name = "txtUpNoKK";
            this.txtUpNoKK.Size = new System.Drawing.Size(284, 21);
            this.txtUpNoKK.TabIndex = 15;
            this.txtUpNoKK.SelectedIndexChanged += new System.EventHandler(this.txtUpNoKK_SelectedIndexChanged);
            // 
            // txtUpAlmtKK
            // 
            this.txtUpAlmtKK.Location = new System.Drawing.Point(112, 124);
            this.txtUpAlmtKK.Name = "txtUpAlmtKK";
            this.txtUpAlmtKK.Size = new System.Drawing.Size(284, 20);
            this.txtUpAlmtKK.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "No KK :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nama KK :";
            // 
            // txtUpNamaKK
            // 
            this.txtUpNamaKK.Location = new System.Drawing.Point(112, 89);
            this.txtUpNamaKK.Name = "txtUpNamaKK";
            this.txtUpNamaKK.Size = new System.Drawing.Size(284, 20);
            this.txtUpNamaKK.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Alamat KK :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDelNoKK);
            this.tabPage3.Controls.Add(this.txtDelAlmtKK);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtDelNamaKK);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(498, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDelNoKK
            // 
            this.txtDelNoKK.FormattingEnabled = true;
            this.txtDelNoKK.Location = new System.Drawing.Point(143, 49);
            this.txtDelNoKK.Name = "txtDelNoKK";
            this.txtDelNoKK.Size = new System.Drawing.Size(284, 21);
            this.txtDelNoKK.TabIndex = 15;
            this.txtDelNoKK.SelectedIndexChanged += new System.EventHandler(this.txtDelNoKK_SelectedIndexChanged);
            // 
            // txtDelAlmtKK
            // 
            this.txtDelAlmtKK.Enabled = false;
            this.txtDelAlmtKK.Location = new System.Drawing.Point(143, 122);
            this.txtDelAlmtKK.Name = "txtDelAlmtKK";
            this.txtDelAlmtKK.Size = new System.Drawing.Size(284, 20);
            this.txtDelAlmtKK.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "No KK :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nama KK :";
            // 
            // txtDelNamaKK
            // 
            this.txtDelNamaKK.Enabled = false;
            this.txtDelNamaKK.Location = new System.Drawing.Point(143, 87);
            this.txtDelNamaKK.Name = "txtDelNamaKK";
            this.txtDelNamaKK.Size = new System.Drawing.Size(284, 20);
            this.txtDelNamaKK.TabIndex = 12;
            this.txtDelNamaKK.TextChanged += new System.EventHandler(this.txtDelNamaKK_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Alamat KK :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kepala_keluarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkjkj);
            this.Controls.Add(this.label1);
            this.Name = "Kepala_keluarga";
            this.Text = "Kepala_keluarga";
            this.Load += new System.EventHandler(this.Kepala_keluarga_Load);
            this.bkjkj.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInNoKK;
        private System.Windows.Forms.TextBox txtInNamaKK;
        private System.Windows.Forms.TextBox txtInAlamat;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.TabControl bkjkj;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUpAlmtKK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpNamaKK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDelAlmtKK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDelNamaKK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtUpNoKK;
        private System.Windows.Forms.ComboBox txtDelNoKK;
    }
}