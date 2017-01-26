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
    public partial class Kematian : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public Kematian()
        {
            InitializeComponent();
        }

        void hapus()
        {
            txtInIdPenduduk.ResetText();
            txtInNama.Clear();
            txtInTglHariMeninggal.ResetText();
            txtInTmptMeninggal.Clear();
            txtInSebabKematian.Clear();
            txtInKeluarga.Clear();
            txtUpIdPenduduk.ResetText();
            txtUpNama.ResetText();
            txtUpTglHariMeninggal.ResetText();
            txtUpTmptMeninggal.ResetText();
            txtUpSebabKematian.ResetText();
            txtUpKeluarga.ResetText();
            txtDelIdPenduduk.ResetText();
            txtDelNama.ResetText();
            txtDelTglMeninggal.ResetText();
            txtdelTempatMeninggal.ResetText();
            txtDelSebab.ResetText();
            txtDelKeluarga.ResetText();
        }

        void ShowIdFromPenduduk() {
            txtInIdPenduduk.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select nik from penduduk ";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtInIdPenduduk.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Insert data to table kematian
        {
            insertKematian();
            hapus();
            showIdPenduduk();
        }
        private void insertKematian()
        {
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "insert into kematian (id_penduduk,Nama,tgl_meninggal,tmpt_meninggal,sebab_meninggal,keluarga) values ('" + txtInIdPenduduk.SelectedItem.ToString() + "','" + txtInNama.Text + "','" + txtInTglHariMeninggal.Value.Date.ToString("MM/dd/yyyy") + "','" + txtInTmptMeninggal.Text + "','" + txtInSebabKematian.Text + "','" + txtInKeluarga.Text + "')";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) // Update data table kematian
        {
            updateData();
            hapus();
            showIdPenduduk();
        }

        void updateData()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update kematian set Nama ='" + txtUpNama.Text + "' ,tgl_meninggal ='" + txtUpTglHariMeninggal.Value.Date.ToString("MM/dd/yyyy") + "',tmpt_meninggal ='" + txtUpTmptMeninggal.Text + "',sebab_meninggal ='" + txtUpSebabKematian.Text + "',keluarga='" + txtUpKeluarga.Text + "' where id_penduduk ='" + txtUpIdPenduduk.SelectedItem + "'";
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
        private void txtUpNoKematian_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from kematian where id_penduduk = '" + txtUpIdPenduduk.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNama.Text = reader["Nama"].ToString();
                    txtUpTglHariMeninggal.Text = reader["tgl_meninggal"].ToString();
                    txtUpTmptMeninggal.Text = reader["tmpt_meninggal"].ToString();
                    txtUpSebabKematian.Text = reader["sebab_meninggal"].ToString();
                    txtUpKeluarga.Text = reader["keluarga"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        void showIdPenduduk()
        {
            txtUpIdPenduduk.Items.Clear();
            txtDelIdPenduduk.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select id_penduduk from kematian ";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpIdPenduduk.Items.Add(reader[0].ToString());
                    txtDelIdPenduduk.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Kematian_Load(object sender, EventArgs e)
        {
            ShowIdFromPenduduk();
            showIdPenduduk();
        }

        private void button4_Click(object sender, EventArgs e) // Delete data table kematian
        {
            deleteData();
            hapus();
            showIdPenduduk();
        }

        void deleteData()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from kematian where id_penduduk ='" + txtDelIdPenduduk.SelectedItem.ToString() + "'";
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

        private void txtDelIdPenduduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from kematian where id_penduduk = '" + txtDelIdPenduduk.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNama.Text = reader["Nama"].ToString();
                    txtDelTglMeninggal.Text = reader["tgl_meninggal"].ToString();
                    txtdelTempatMeninggal.Text = reader["tmpt_meninggal"].ToString();
                    txtDelSebab.Text = reader["sebab_meninggal"].ToString();
                    txtDelKeluarga.Text = reader["keluarga"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void txtInIdPenduduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from penduduk where nik = '" + txtInIdPenduduk.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtInNama.Text = reader["nama_lengkap"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

    }
}
