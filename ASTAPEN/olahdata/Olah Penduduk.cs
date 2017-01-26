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
    public partial class olah_penduduk : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public olah_penduduk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Button Click Insert Data
        {
            insertolahpenduduk();
            hapus();
            showNIK();
        }
        private void insertolahpenduduk()
        {
            try
            {
                
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "insert into penduduk (nik,nama_lengkap,tempat_lahir,tgl_lahir,jk,rt,pekerjaan,pendidikan_terakhir,agama,no_kk,ket) values ('" + txtInNIK.Text + "','" + txtInNama.Text + "','" + txtInTmpLhr.Text + "','" + txtInTglLhr.Value.Date.ToString("MM/dd/yyyy") + "','" + txtInJenKel.SelectedItem.ToString() + "','" + txtInRt.Text + "','" + TxtInPekerjaan.SelectedItem.ToString() + "','" + txtInPendTer.Text + "','" + txtInAgama.SelectedItem.ToString() + "','" + txtInNoKK.SelectedItem.ToString() + "','" + txtInKet.Text + "')";                
                command.ExecuteNonQuery();//execute ( jalankan perintah )
                con.Close();//akhiri koneksi ( tutup koneksi )
                MessageBox.Show("Data Telah Berhasil Disimpan!!", "information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        
        private void button3_Click(object sender, EventArgs e) // Button Update Penduduk
        {
            updatePenduduk();
            hapus();
            showNIK();
        }

        public void showNIK()
        {
            txtUpNIK.Items.Clear();
            txtDelNIK.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select nik from penduduk";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNIK.Items.Add(reader[0].ToString());
                    txtDelNIK.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void showNoKK()
        {
            txtInNoKK.Items.Clear();
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
                    txtInNoKK.Items.Add(reader[0].ToString());
                    txtUpNoKK.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void olah_penduduk_Load(object sender, EventArgs e)
        {
            showNoKK();
            showNIK();
        }

        void hapus()
        {
            txtInNIK.ResetText();
            txtInNama.ResetText();
            txtInTmpLhr.ResetText();
            txtInTglLhr.ResetText();
            txtInJenKel.ResetText();
            txtInRt.ResetText();
            TxtInPekerjaan.ResetText();
            txtInPendTer.ResetText();
            txtInAgama.ResetText();
            txtInNoKK.ResetText();
            txtInKet.ResetText();
            txtUpNIK.ResetText();
            txtUpNamaLengkap.ResetText();
            txtUptmptLahir.ResetText();
            txtUpTglLahir.ResetText();
            txtUPJK.ResetText();
            txtUpRT.ResetText();
            txtUppekerjaan.ResetText();
            txtUpPendidikantrakhir.ResetText();
            txtUpAgama.ResetText();
            txtUpNoKK.ResetText();
            txtUpKet.ResetText();
            txtDelNIK.ResetText();
            txtDelNama.ResetText();
            txtDelTempatLahir.ResetText();
            txtDelTglLahir.ResetText();
            txtDelJK.ResetText();
            txtDelRT.ResetText();
            txtDelPekerjaan.ResetText();
            txtDelPendidikanTerakhir.ResetText();
            txtDelAgama.ResetText();
            txtDelNoKK.ResetText();
            txtDelKet.ResetText();
        }

        private void txtUpNIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from penduduk where nik = '" + txtUpNIK.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNamaLengkap.Text = reader["nama_lengkap"].ToString();
                    txtUptmptLahir.Text = reader["tempat_lahir"].ToString();
                    txtUpTglLahir.Text = reader["tgl_lahir"].ToString();
                    txtUPJK.Text = reader["jk"].ToString();
                    txtUpRT.Text=reader["rt"].ToString();
                    txtUppekerjaan.Text = reader["pekerjaan"].ToString();
                    txtUpPendidikantrakhir.Text = reader["pendidikan_terakhir"].ToString();
                    txtUpAgama.Text = reader["agama"].ToString();
                    txtUpNoKK.Text = reader["no_kk"].ToString();
                    txtUpKet.Text = reader["ket"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Button Delete Penduduk
        {
            delPenduduk();
            hapus();
            showNIK();
        }

        private void txtDelNIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from penduduk where nik = '" + txtDelNIK.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNama.Text = reader["nama_lengkap"].ToString();
                    txtDelTempatLahir.Text = reader["tempat_lahir"].ToString();
                    txtDelTglLahir.Text = reader["tgl_lahir"].ToString();
                    txtDelJK.Text = reader["jk"].ToString();
                    txtDelRT.Text = reader["rt"].ToString();
                    txtDelPekerjaan.Text = reader["pekerjaan"].ToString();
                    txtDelPendidikanTerakhir.Text = reader["pendidikan_terakhir"].ToString();
                    txtDelAgama.Text = reader["agama"].ToString();
                    txtDelNoKK.Text = reader["no_kk"].ToString();
                    txtDelKet.Text = reader["ket"].ToString();
                }
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

        private void updatePenduduk()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update penduduk set nama_lengkap ='" + txtUpNamaLengkap.Text + "' ,tempat_lahir ='" + txtUptmptLahir.Text + "',tgl_lahir ='" + txtUpTglLahir.Value.Date.ToString("MM/dd/yyyy") + "',jk ='" + txtUPJK.Text + "',rt ='" + txtUpRT.Text + "',pekerjaan ='" + txtUppekerjaan.Text + "',pendidikan_terakhir ='" + txtUpPendidikantrakhir.Text + "',agama ='" + txtUpAgama.SelectedItem + "',ket ='" + txtUpKet.Text + "',no_kk ='" + txtUpNoKK.SelectedItem + "' where nik ='" + txtUpNIK.SelectedItem + "'";
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

        private void delPenduduk()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from penduduk where nik ='" + Convert.ToString(txtDelNIK.Text) + "'";
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

        private void txtInNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsWhiteSpace(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtInNIK_TextChanged(object sender, EventArgs e)
        {
            txtInNIK.MaxLength = 16;
        }

    }
}