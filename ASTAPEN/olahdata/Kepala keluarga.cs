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
    public partial class Kepala_keluarga : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public Kepala_keluarga()
        {
            InitializeComponent();
        }

        void showNoKK()
        {
            txtDelNoKK.Items.Clear();
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
                    txtDelNoKK.Items.Add(reader[0].ToString());
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

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            insertData();
            hapus();
            showNoKK();

        }

        void insertData()
        {
            try
            {
                con.Open(); //membuka koneksi
                SqlCommand scom = new SqlCommand(); //membuat sql commmand dengan alias scom
                scom.Connection = con; //include koneksi ke sqlcommand
                scom.CommandType = CommandType.Text;//menentukan jenis komand,defaulnya comandtype.text
                scom.CommandText = "insert into KK(no_kk,nama_kk,alamat_kk) values('" + txtInNoKK.Text + "','" + txtInNamaKK.Text + "','" + txtInAlamat.Text + "')";
                //mengisi perintah sql dengan insert data ke dlm tabel barang
                scom.ExecuteNonQuery();//jalankan perintah
                con.Close();
                txtInNoKK.Clear();
                txtInNamaKK.Clear();
                txtInAlamat.Clear();
                MessageBox.Show("Data Telah Berhasil Disimpan!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateKK();
            hapus();
            showNoKK();
        }

        
        void updateKK()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update KK set nama_kk ='" + txtUpNamaKK.Text + "' ,alamat_kk ='" + txtUpAlmtKK.Text + "' where no_kk ='" + txtUpNoKK.SelectedItem.ToString() + "'";
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

        private void Kepala_keluarga_Load(object sender, EventArgs e)
        {
            showNoKK();
        }

        private void button3_Click(object sender, EventArgs e) // Button Delete
        {
            DeleteKK();
            hapus();
            showNoKK();
        }

        void DeleteKK()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from KK where no_kk ='" + Convert.ToString(txtDelNoKK.SelectedItem.ToString()) + "'";
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

        private void txtUpNoKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from KK where no_kk = '" + txtUpNoKK.SelectedItem.ToString() + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNamaKK.Text = reader["nama_kk"].ToString();
                    txtUpAlmtKK.Text = reader["alamat_kk"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void txtDelNoKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from KK where no_kk = '" + txtDelNoKK.SelectedItem.ToString() + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNamaKK.Text = reader["nama_kk"].ToString();
                    txtDelAlmtKK.Text = reader["alamat_kk"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }
        void hapus()
        {
            txtInNoKK.Clear();
            txtInNamaKK.Clear();
            txtInAlamat.Clear();
            txtUpNoKK.Text = "";
            txtUpNamaKK.Clear();
            txtUpAlmtKK.Clear();
            txtDelNoKK.Text="";
            txtDelNamaKK.Text = "";
            txtDelAlmtKK.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtInNoKK_TextChanged(object sender, EventArgs e)
        {
            txtInNoKK.MaxLength = 16;
        }

        private void txtInNoKK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsWhiteSpace(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}