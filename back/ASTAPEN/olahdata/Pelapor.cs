using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ASTAPEN.olahdata
{
    public partial class Pelapor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");

        public Pelapor()
        {
            InitializeComponent();
        }

        void hapus() {
            txtInIdPel.ResetText();
            txtInNama.ResetText();
            tglIndatang.ResetText();
            tglInpergi.ResetText();
            txtInAlamatAsal.ResetText();
            txtInAlamatSekarang.ResetText();
            txtInKeterangan.ResetText();

            txtUpIdPel.ResetText();
            txtUpNama.ResetText();
            txtUpTglDatang.ResetText();
            txtUpTglPergi.ResetText();
            txtUpAlamatAsal.ResetText();
            txtUpAlamatSekarang.ResetText();
            txtUpKeterangan.ResetText();

            txtDelPelapor.ResetText();
            txtDelNama.ResetText();
            txtDelTglDatang.ResetText();
            txtDelTglpergi.ResetText();
            txtDelAlamatAsal.ResetText();
            txtDelAlamatSekarang.ResetText();
            txtDelKeterangan.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertpelapor();
            hapus();
            showNoid();
        }
        private void insertpelapor()
        {
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "insert into pelapor (id_pnduduk,nama,tgl_dtng,tgl_pergi,alamat_asal,alamat_sekarang,ket) values ('" + txtInIdPel.Text + "','" + txtInNama.Text + "','" + tglIndatang.Value.Date.ToString("MM/dd/yyyy") + "','" + tglInpergi.Value.Date.ToString("MM/dd/yyyy") + "','" + txtInAlamatAsal.Text + "','" + txtInAlamatSekarang.Text + "','" + txtInKeterangan.Text + "')";
                //mengisi perintah SQL dengan insert data ke dalam table barang
                command.ExecuteNonQuery();
                //execute ( jalankan perintah )
                con.Close();
                //akhiri koneksi ( tutup koneksi )
                MessageBox.Show("Data Telah Berhasil Disimpan!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }

        private void updatePelapor()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update pelapor set nama ='" + txtUpNama.Text + "',tgl_dtng ='" + txtUpTglDatang.Value.Date.ToString("MM/dd/yyyy") + "',tgl_pergi ='" + txtUpTglPergi.Value.Date.ToString("MM/dd/yyyy") + "', alamat_asal ='" + txtUpAlamatAsal.Text + "',alamat_sekarang ='" + txtUpAlamatSekarang.Text + "',ket ='" + txtUpKeterangan.Text + "'where id_pnduduk ='" + txtUpIdPel.SelectedItem + "'";
                command.ExecuteNonQuery();//execute ( jalankan perintah )
                con.Close();//akhiri koneksi ( tutup koneksi )
                MessageBox.Show("Data Telah Berhasil Diupdate!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        void showNoid()
        {
            txtDelPelapor.Items.Clear();
            txtUpIdPel.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select id_pnduduk from pelapor";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpIdPel.Items.Add(reader[0].ToString());
                    txtDelPelapor.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from pelapor where id_pnduduk = '" + txtUpIdPel.SelectedItem.ToString() + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNama.Text = reader["nama"].ToString();
                    txtUpTglDatang.Text = reader["tgl_dtng"].ToString();
                    txtUpTglPergi.Text = reader["tgl_pergi"].ToString();
                    txtUpAlamatAsal.Text = reader["alamat_asal"].ToString();
                    txtUpAlamatSekarang.Text = reader["alamat_sekarang"].ToString();
                    txtUpKeterangan.Text = reader["ket"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            updatePelapor();
            hapus();
            showNoid();
        }

        private void Pelapor_Load(object sender, EventArgs e)
        {
            showNoid();
        }

        private void delPelapor()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from pelapor where id_pnduduk ='" + Convert.ToString(txtDelPelapor.Text) + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Telah Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void txtDelPelapor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from pelapor where id_pnduduk = '" + txtDelPelapor.SelectedItem.ToString() + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNama.Text = reader["nama"].ToString();
                    txtDelTglDatang.Text = reader["tgl_dtng"].ToString();
                    txtDelTglpergi.Text = reader["tgl_pergi"].ToString();
                    txtDelAlamatAsal.Text = reader["alamat_asal"].ToString();
                    txtDelAlamatSekarang.Text = reader["alamat_sekarang"].ToString();
                    txtDelKeterangan.Text = reader["ket"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delPelapor();
            hapus();
            showNoid();
        }
    }
}

