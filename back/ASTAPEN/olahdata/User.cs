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
    public partial class User : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Button Insert
        {
            InsertData();
            hapus();
            showUsername();
        }

        void InsertData() 
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "insert into [user] (username,password,Nama_admin) values ('" + txtInUser.Text + "','" + txtpass.Text + "','" + txtInNamaAdm.Text +"')";
                command.ExecuteNonQuery();//execute ( jalankan perintah )
                con.Close();//akhiri koneksi ( tutup koneksi )
                MessageBox.Show("Data Telah Berhasil Disimpan!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void UpdateUser()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "select * from [user] where username ='" + txtUpUsername.SelectedItem.ToString() + "' and password ='" + txtUpPassLama.Text + "'";
                // string sql
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 1)
                {
                    update();

                }
                else
                    MessageBox.Show("Username atau Password anda salah!!!");
                
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void update()
        {
            con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "Update [user] set password ='" + txtUpPassBaru.Text + "' ,Nama_admin ='" + txtUpNamaAdmin.Text + "' where username = '"+txtUpUsername.SelectedItem.ToString()+"'";
                command.ExecuteNonQuery();//execute ( jalankan perintah )
                MessageBox.Show("Data Telah Berhasil Diupdate!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
        }
        private void txtUpUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from [user] where username = '" + txtUpUsername.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpNamaAdmin.Text = reader["Nama_admin"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        void showUsername()
        {

            txtUpUsername.Items.Clear();
            txtDeluser.Items.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select username from [user]";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtUpUsername.Items.Add(reader[0].ToString());
                    txtDeluser.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Button Update
        {
            UpdateUser();
            hapus();
            showUsername();
        }

        private void User_Load(object sender, EventArgs e)
        {
            showUsername();
        }
        void hapus()
        {
            txtInUser.Clear();
            txtpass.Clear();
            txtInNamaAdm.Clear();
            txtUpUsername.Text = "";
            txtUpPassLama.Clear();
            txtUpPassBaru.Clear();
            txtUpNamaAdmin.Clear();
            txtDeluser.Text = "";
            txtDelPass.Clear();
            txtDelNamaAd.Clear();
        }
        void delete()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "select * from [user] where username ='" + txtDeluser.SelectedItem.ToString() + "' and password ='" + txtDelPass.Text + "'";
                // string sql
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 1)
                {
                    deleteData();

                }
                else
                    MessageBox.Show("Username atau Password anda salah!!!");

            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void deleteData() {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Delete from [user] where username ='" + txtDeluser.SelectedItem.ToString() + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Telah Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
        }

        private void txtDeluser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from [user] where username = '" + txtDeluser.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtDelNamaAd.Text = reader["Nama_admin"].ToString();
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
            delete();
            hapus();
            showUsername();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }
    }

}
