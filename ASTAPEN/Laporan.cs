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
    public partial class Laporan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public Laporan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kependudukanDataSet.pelapor' table. You can move, or remove it, as needed.
          //  this.pelaporTableAdapter.Fill(this.kependudukanDataSet.pelapor);
          //  this.kelahiranTableAdapter.Fill(this.kependudukanDataSet.kelahiran);
            showDataPenduduk();
            showDataPelapor();
            showDataKematian();
            showDataKelahiran();
            showNoKK();
        }

        void showPenduduk()  // Menampilkan tabel Mahasiswa dalam DataGrid
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from penduduk where no_kk = '"+cmbNoKK.SelectedItem.ToString()+"' " ;
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "penduduk");
                datagridkk.DataSource = ds1;
                datagridkk.DataMember = "penduduk";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void showDataKelahiran()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from kelahiran";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "kelahiran");
                kelahiranDataGridView.DataSource = ds1;
                kelahiranDataGridView.DataMember = "kelahiran";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        } 

        void showDataKematian()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from kematian";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "kematian");
                DataKematian.DataSource = ds1;
                DataKematian.DataMember = "kematian";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void showDataPelapor()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from pelapor";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "pelapor");
                pelaporDataGridView.DataSource = ds1;
                pelaporDataGridView.DataMember = "pelapor";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        
        void showDataPenduduk()  // Menampilkan tabel Mahasiswa dalam DataGrid
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from penduduk";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "penduduk");
                dataPenduduk.DataSource = ds1;
                dataPenduduk.DataMember = "penduduk";
                con.Close();
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

        void showNoKK()
        {
            cmbNoKK.Items.Clear();
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
                    cmbNoKK.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dataPenduduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbNoKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPenduduk();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }
    }
}
