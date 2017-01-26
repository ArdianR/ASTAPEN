using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace ASTAPEN
{
    public partial class menuutama : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public menuutama()
        {
            InitializeComponent();
        }

        private void olahPendudukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.olah_penduduk q = new olahdata.olah_penduduk();
            q.Show();
            this.Hide();
        }

        private void formPelaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.Pelapor q = new olahdata.Pelapor();
            q.Show();
            this.Hide();

        }

        private void formPengikutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formKematianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.Kematian q = new olahdata.Kematian();
            q.Show();
            this.Hide();
        }

        private void formKelahiranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.Kelahiran q = new olahdata.Kelahiran();
            q.Show();
            this.Hide();
        }

        private void formKKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.Kepala_keluarga q = new olahdata.Kepala_keluarga();
            q.Show();
            this.Hide();
        }

        private void formAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olahdata.User q = new olahdata.User();
            q.Show();
            this.Hide();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan q = new Laporan();
            q.Show();
            this.Hide();
        }

        private void penyuratanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuutama_Load(object sender, EventArgs e)
        {
            int now = DateTime.Now.Year;
            for (int i = now; i >= 2015; i--)
            {
                cmbLahirMati.Items.Add(i);
            }
            cmbLahirMati.SelectedItem = now;
            kelahiranKematian();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        void grafikjml()
        {
            string jml;
            int a = 0; int b = 0; int c = 0;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand comand = new SqlCommand("select *from penduduk", con);
                read = comand.ExecuteReader();

                while (read.Read())
                {
                    jml = read["rt"].ToString();

                    if (jml == "2")
                        a++;
                    else if (jml == "34")
                        b++;
                    else if (jml == "21")
                        c++;
                }
                this.chart2.ChartAreas[0].AxisX.Title = "RT";
                this.chart2.ChartAreas[0].AxisY.Title = "Jumlah Penduduk";

                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = true;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = false;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = false;
                this.chart2.Series["Pekerjaan"].IsVisibleInLegend = false;
                

                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("2", a);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("34", b);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("21", c);
                con.Close();
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        void kelahiranKematian()
        {
            this.ChartKelahiranKematian.Series["Kelahiran Kematian"].Points.Clear();
            int lahir = 0, mati = 0;
            try
            {

                con.Open();
                SqlDataReader read;
                SqlCommand cmdLahir = new SqlCommand("select * from kelahiran where year(tgl_lahir) = '"+cmbLahirMati.SelectedItem.ToString()+"'", con);
                read = cmdLahir.ExecuteReader();

                while (read.Read())
                {
                    lahir++;
                }
                con.Close();
                con.Open();
                SqlDataReader read2;
                SqlCommand cmdMati = new SqlCommand("select * from kematian where year(tgl_meninggal) = '" + cmbLahirMati.SelectedItem.ToString() + "'", con);
                read2 = cmdMati.ExecuteReader();

                while (read2.Read())
                {
                    mati++;
                }

                con.Close();
                this.ChartKelahiranKematian.Series["Kelahiran Kematian"].Points.AddXY("Kelahiran", lahir);
                this.ChartKelahiranKematian.Series["Kelahiran Kematian"].Points.AddXY("Kematian", mati);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void pekerjaan()
        {
            string jml;
            int a = 0; int b = 0; int c = 0; int d = 0; int e = 0;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand cmdLahir = new SqlCommand("select * from penduduk", con);
                read = cmdLahir.ExecuteReader();

                while (read.Read())
                {
                    jml = read["pekerjaan"].ToString();

                    if (jml == "Pegawai Swasta")
                        a++;
                    else if (jml == "Pegawai Negeri")
                        b++;
                    else if (jml == "Petani")
                        c++;
                    else if (jml == "Ibu Rumah Tangga")
                        d++;
                    else if (jml == "Dll")
                        e++;
                }
                con.Close();
                chart2.ChartAreas[0].Visible = false;
                chart2.ChartAreas[1].Visible = true;
                
                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = false;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = false;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = false;

                this.chart2.Series["Pekerjaan"].IsVisibleInLegend = true;
                
                


                this.chart2.Series["Pekerjaan"].Points.AddXY("Pegawai Swasta",a );
                this.chart2.Series["Pekerjaan"].Points.AddXY("Pegawai Negeri", b);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Pegawai Swasta", c);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Ibu rumah tangga", d);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Dan lain-lain", e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void Umur()
        {
            int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, umur = 0;
            int lahir;
            int now = DateTime.Now.Year;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand cmdUmur = new SqlCommand("select tgl_lahir from penduduk", con);
                read = cmdUmur.ExecuteReader();
                while (read.Read())
                {
                    lahir = Convert.ToDateTime(read["tgl_lahir"]).Year;
                    umur = now - lahir;
                    if (umur >= 0 && umur <= 10)
                        x1++;
                    else if (umur >= 11 && umur <= 20)
                        x2++;
                    else if (umur >= 21 && umur <= 30)
                        x3++;
                    else if (umur >= 31 && umur <= 40)
                        x4++;
                    else if (umur >= 41 && umur <= 50)
                        x5++;
                    else if (umur >= 51)
                        x6++;
                }
                this.chart2.ChartAreas[0].AxisX.Title = "Umur";
                this.chart2.ChartAreas[0].AxisY.Title = "Jumlah";

                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = true;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = false;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = false;
                this.chart2.Series["Pekerjaan"].IsVisibleInLegend = false;
                
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("0-10", x1);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("11-20", x2);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("21-30", x3);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("31-40", x4);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("41-50", x5);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY(">51", x6);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        void grafikjenkel()
        {
            string jml; string jmlr;
            int a = 0; int b = 0; int c = 0; int d = 0;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand comand = new SqlCommand("select *from penduduk", con);
                read = comand.ExecuteReader();
                while (read.Read())
                {
                    jmlr = read["rt"].ToString();
                    jml = read["jk"].ToString();

                    if (jml == "Laki-laki" && jmlr == "21")
                        a++;
                    else if (jml == "Perempuan" && jmlr == "21")
                        b++;
                    if (jml == "Laki-laki" && jmlr == "34")
                        c++;
                    else if (jml == "Perempuan" && jmlr == "34")
                        d++;

                }
                this.chart2.ChartAreas[0].AxisX.Title = "RT";
                this.chart2.ChartAreas[0].AxisY.Title = "Jumlah";
                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = false;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = true;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = true;
                this.chart2.Series["Laki-laki"].Points.AddXY("21", a);
                this.chart2.Series["Perempuan"].Points.AddXY("21", b);
                this.chart2.Series["Laki-laki"].Points.AddXY("34", c);
                this.chart2.Series["Perempuan"].Points.AddXY("34", d);
                con.Close();
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void pilihGrafik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void penduduk_ttp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pilihGrafik_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chart2.ChartAreas[1].Visible = false;
            chart2.ChartAreas[0].Visible = true;

            this.chart2.Series["Perempuan"].Points.Clear();
            this.chart2.Series["Laki-laki"].Points.Clear();
            this.chart2.Series["Jumlah Penduduk"].Points.Clear();
            this.chart2.Series["Pekerjaan"].Points.Clear();
            
            try
            {

                if (pilihGrafik.SelectedItem.ToString() == "RT")
                {
                    grafikjml();
                    con.Close();

                }
                else if (pilihGrafik.SelectedItem.ToString() == "Jenis Kelamin")
                {
                    grafikjenkel();
                    con.Close();
                }
                else if (pilihGrafik.SelectedItem.ToString() == "Umur")
                {
                    Umur();
                    con.Close();
                }
                else if (pilihGrafik.SelectedItem.ToString() == "Pekerjaan")
                {
                    pekerjaan();
                    con.Close();
                }
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmbLahirMati_SelectedIndexChanged(object sender, EventArgs e)
        {
            kelahiranKematian();
        }
    }


}