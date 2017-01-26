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
namespace ASTAPEN
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login()  // Method Login
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(); // membuat komando
                command.Connection = con; // koneksikan dengan database
                command.CommandText = "select * from [user] where username ='" +txtUser.Text+ "' and password ='" +txtPassword.Text+"'";
                // string sql
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("WELCOME TO ASTAPEN");
                    menuutama n = new menuutama();
                    n.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username atau Password anda salah!!!");
                con.Close();
            }
            catch (Exception ex) // exception untuk memberitahu jika ada kesalahan syntax sql
            {
                MessageBox.Show(ex.Message );
                con.Close();
            }
        }
        
        private void SignIn_Click(object sender, EventArgs e)
        {
            login();
            //menuutama n = new menuutama();
         //   n.Show();
           // this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
