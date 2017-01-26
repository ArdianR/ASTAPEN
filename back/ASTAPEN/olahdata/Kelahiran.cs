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
    public partial class Kelahiran : Form
            {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        
        public Kelahiran()
        {
            InitializeComponent();
        }

        void hapus()
        {
            txtInNo.Clear();
            txtInNama.Clear();
            txtInTempat.Clear();
            txtInTgl.ResetText();
            txtInNOKK.Text = "";
            txtInJK.Text = "";
            txtNamaOrtu.Clear();
            txtInNOKK.Text = "";
            txtUpNoAkte.Text = "";
            txtUpNamaAnak.Clear();
            txtUpTmptLahir.Clear();
            txtUpTglLahir.ResetText();
            txtUpNoKK.Text = "";
            txtUpJenKel.Text = "";
            txtUpNamaOrtu.Clear();
            txtUpNoKK.Text = "";
            txtDelNoAkte.ResetText();
            txtDelNamaAnak.ResetText();
            txtDelTmptLahir.ResetText();
            txtDelTglLahir.ResetText();
            txtDelNoKK.ResetText();
            txtDelJenKel.ResetText();
            txtDelNamaOrtu.ResetText();
            txtDelNoKK.ResetText();



        }

       private void button1_Click(object sender, EventArgs e)  // Button insert klik
        {
            insertKelahiran();
            hapus();
            showNoAkte();
        }
        private void insertKelahiran()
        {
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "insert into kelahiran (no_akte,nama_anak,tmpt_lhr,tgl_lahir,jk,nama_ortu,no_kk) values ('" + txtInNo.Text + "','" + txtInNama.Text + "','" + txtInTempat.Text + "','" + txtInTgl.Value.Date.ToString("MM/dd/yyyy") + "','" + txtInJK.SelectedItem.ToString() + "','" + txtNamaOrtu.Text + "','" + txtInNOKK.SelectedItem.ToString() + "')";

                //mengisi perintah SQL dengan insert data ke dalam table
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

        private void Kelahiran_Load(object sender, EventArgs e)
        {
            showNoKK();
            showNoAkte();
        }
        void showNoKK()
        {
            txtInNOKK.Items.Clear();
            txtUpNoKK.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select no_kk from KK";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtInNOKK.Items.Add(reader[0].ToString());
                    txtUpNoKK.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void showNoAkte()
        {
            txtUpNoAkte.Items.Clear();
            txtDelNoAkte.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select no_akte from kelahiran";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNoAkte.Items.Add(reader[0].ToString());
                    txtDelNoAkte.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delkelahiran();
            hapus();
            showNoAkte();
        }

        private void delkelahiran()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from kelahiran where no_akte ='" + Convert.ToString(txtDelNoAkte.Text) + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }

        private void txtUpNoAkte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from kelahiran where no_akte = '" + txtUpNoAkte.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNamaAnak.Text = reader["nama_anak"].ToString();
                    txtUpTmptLahir.Text = reader["tmpt_lhr"].ToString();
                    txtUpTglLahir.Text = reader["tgl_lahir"].ToString();
                    txtUpJenKel.Text = reader["jk"].ToString();
                    txtUpNamaOrtu.Text = reader["nama_ortu"].ToString();
                    txtUpNoKK.Text = reader["no_kk"].ToString();
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
            updateData();
            hapus();
            showNoAkte();
        }

        private void txtDelNoAkte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from kelahiran where no_akte = '" + txtDelNoAkte.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNamaAnak.Text = reader["nama_anak"].ToString();
                    txtDelTmptLahir.Text = reader["tmpt_lhr"].ToString();
                    txtDelTglLahir.Text = reader["tgl_lahir"].ToString();
                    txtDelJenKel.Text = reader["jk"].ToString();
                    txtDelNamaOrtu.Text = reader["nama_ortu"].ToString();
                    txtDelNoKK.Text = reader["no_kk"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        void updateData()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update kelahiran set nama_anak ='" + txtUpNamaAnak.Text + "' ,tmpt_lhr ='" + txtUpTmptLahir.Text + "',tgl_lahir ='" + txtUpTglLahir.Value.Date.ToString("MM/dd/yyyy") + "',jk ='" + txtUpJenKel.Text + "',nama_ortu='" + txtUpNamaOrtu.Text + "',no_kk ='" + txtUpNoKK.Text + "' where no_akte ='" + txtUpNoAkte.SelectedItem + "'";
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
    }
}
