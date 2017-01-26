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


        private void menuutama_Load(object sender, EventArgs e)
        {
            int now = DateTime.Now.Year;
            for (int i = now; i >= 2016; i--)
            {
                cmbLahirMati.Items.Add(i);
                cmbPelapor.Items.Add(i);
            }
            cmbLahirMati.SelectedItem = now;
            cmbPelapor.SelectedItem = now;
            pilihGrafik.SelectedIndex = 0;
        }

        void grafikjml()
        {
            string jml;
            int a,b,c,d,e,f;
            a = b = c = d = e = f = 0;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand comand = new SqlCommand("select *from penduduk", con);
                read = comand.ExecuteReader();

                while (read.Read())
                {
                    jml = read["rt"].ToString();

                    if (jml == "1")
                        a++;
                    else if (jml == "2")
                        b++;
                    else if (jml == "3")
                        c++;
                    else if (jml == "4")
                        d++;
                    else if (jml == "5")
                        e++;
                    else if (jml == "6")
                        f++;
                }
                this.chart2.ChartAreas[0].AxisX.Title = "RT";
                this.chart2.ChartAreas[0].AxisY.Title = "Jumlah Penduduk";

                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = true;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = false;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = false;
                this.chart2.Series["Pekerjaan"].IsVisibleInLegend = false;


                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("1", a);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("2", b);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("3", c);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("4", d);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("5", e);
                this.chart2.Series["Jumlah Penduduk"].Points.AddXY("6", f);
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
                SqlCommand cmdLahir = new SqlCommand("select * from kelahiran where year(tgl_lahir) = '" + cmbLahirMati.SelectedItem.ToString() + "'", con);
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
            int a = 0; int b = 0; int c = 0; int d = 0; int e = 0; int f = 0;
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
                    else if (jml == "Pelajar/Mahasiswa")
                        f++;
                }
                con.Close();
                chart2.ChartAreas[0].Visible = false;
                chart2.ChartAreas[1].Visible = true;

                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = false;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = false;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = false;

                this.chart2.Series["Pekerjaan"].IsVisibleInLegend = true;




                this.chart2.Series["Pekerjaan"].Points.AddXY("Pegawai Swasta", a);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Pegawai Negeri", b);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Petani", c);
                this.chart2.Series["Pekerjaan"].Points.AddXY("Pelajar/Mahasiswa", f);
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
            int a,b,c,d,e,f,g,h,i,j,k,l;
            a = b = c = d = e = f = g = h = i = j = k = l = 0;
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

                    if (jml == "Laki-laki" && jmlr == "1")
                        a++;
                    else if (jml == "Perempuan" && jmlr == "1")
                        b++;
                   
                    if (jml == "Laki-laki" && jmlr == "2")
                        c++;
                    else if (jml == "Perempuan" && jmlr == "2")
                        d++;

                    if (jml == "Laki-laki" && jmlr == "3")
                        e++;
                    else if (jml == "Perempuan" && jmlr == "3")
                        f++;

                    if (jml == "Laki-laki" && jmlr == "4")
                        g++;
                    else if (jml == "Perempuan" && jmlr == "4")
                        h++;

                    if (jml == "Laki-laki" && jmlr == "5")
                        i++;
                    else if (jml == "Perempuan" && jmlr == "5")
                        j++;

                    if (jml == "Laki-laki" && jmlr == "6")
                        k++;
                    else if (jml == "Perempuan" && jmlr == "6")
                        l++;
                }
                this.chart2.ChartAreas[0].AxisX.Title = "RT";
                this.chart2.ChartAreas[0].AxisY.Title = "Jumlah";
                this.chart2.Series["Jumlah Penduduk"].IsVisibleInLegend = false;
                this.chart2.Series["Laki-laki"].IsVisibleInLegend = true;
                this.chart2.Series["Perempuan"].IsVisibleInLegend = true;
                
                this.chart2.Series["Laki-laki"].Points.AddXY("1", a);
                this.chart2.Series["Perempuan"].Points.AddXY("1", b);
                this.chart2.Series["Laki-laki"].Points.AddXY("2", c);
                this.chart2.Series["Perempuan"].Points.AddXY("2", d);
                this.chart2.Series["Laki-laki"].Points.AddXY("3", e);
                this.chart2.Series["Perempuan"].Points.AddXY("3", f);
                this.chart2.Series["Laki-laki"].Points.AddXY("4", g);
                this.chart2.Series["Perempuan"].Points.AddXY("4", h);
                this.chart2.Series["Laki-laki"].Points.AddXY("5", i);
                this.chart2.Series["Perempuan"].Points.AddXY("5", j);
                this.chart2.Series["Laki-laki"].Points.AddXY("6", k);
                this.chart2.Series["Perempuan"].Points.AddXY("6", l);
                con.Close();
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

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


        private void cmbLahirMati_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            kelahiranKematian();
        }

        void grafikPelapor() {
            this.chartPelapor.Series["Tanggal Datang"].Points.Clear();
            this.chartPelapor.Series["Tanggal Pergi"].Points.Clear();
            int datang,pergi;
            int a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x;
            a = b = c = d = e = f = g = h = i = j = k = l = 0;
            m = n = o = p = q = r = s = t = u = v = w = x = 0;
            try
            {
                con.Open();
                SqlDataReader read;
                SqlCommand comand = new SqlCommand("select * from pelapor where year(tgl_dtng) = '" + cmbPelapor.SelectedItem.ToString() + "' or year(tgl_pergi) = '" + cmbPelapor.SelectedItem.ToString() + "'", con);
                read = comand.ExecuteReader();
                while (read.Read())
                {
                    datang = Convert.ToDateTime( read["tgl_dtng"]).Month;
                    pergi = Convert.ToDateTime(read["tgl_pergi"]).Month;
                    if (datang == 1)
                        a++;
                    else if (datang == 2)
                        b++;
                    else if (datang == 3)
                        c++;
                    else if (datang == 4)
                        d++;
                    else if (datang == 5)
                        e++;
                    else if (datang == 6)
                        f++;
                    else if (datang == 7)
                        g++;
                    else if (datang == 8)
                        h++;
                    else if (datang == 9)
                        i++;
                    else if (datang == 10)
                        j++;
                    else if (datang == 11)
                        k++;
                    else if (datang == 12)
                        l++;

                    if (pergi == 1)
                        m++;
                    else if (pergi == 2)
                        n++;
                    else if (pergi == 3)
                        o++;
                    else if (pergi == 4)
                        p++;
                    else if (pergi == 5)
                        q++;
                    else if (pergi == 6)
                        r++;
                    else if (pergi == 7)
                        s++;
                    else if (pergi == 8)
                        t++;
                    else if (pergi == 9)
                        u++;
                    else if (pergi == 10)
                        v++;
                    else if (pergi == 11)
                        w++;
                    else if (pergi == 12)
                        x++;
                }
                this.chartPelapor.ChartAreas[0].AxisX.Title = "Bulan";
                this.chartPelapor.ChartAreas[0].AxisY.Title = "Jumlah";
                
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Januari", a);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Februari", b);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Maret", c);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("April", d);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Mei", e);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Juni", f);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Juli", g);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Agustus", h);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("September", i);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Oktober", j);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("November", k);
                this.chartPelapor.Series["Tanggal Datang"].Points.AddXY("Desember", l);

                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Januari", m);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Februari", n);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Maret", o);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("April", p);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Mei", q);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Juni", r);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Juli", s);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Agustus", t);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("September", u);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Oktober", v);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("November", w);
                this.chartPelapor.Series["Tanggal Pergi"].Points.AddXY("Desember", x);
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void cmbPelapor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafikPelapor();
        }

        private void penyuratanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            penyuratan m = new penyuratan();
            m.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tentangKamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tentangKami m = new tentangKami();
            m.Show();
            this.Close();
        }
    }


}