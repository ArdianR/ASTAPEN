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
            this.pelaporTableAdapter.Fill(this.kependudukanDataSet.pelapor);
            this.kelahiranTableAdapter.Fill(this.kependudukanDataSet.kelahiran);
            showDataPenduduk();
           // showDataPelapor();
            showDataKematian();
            //showDataKelahiran();
        }

    /*    void showDataKelahiran()
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
                dataKelahiran.DataSource = ds1;
                dataKelahiran.DataMember = "kelahiran";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        } */

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

    /*    void showDataPelapor()
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
                dataPelapor.DataSource = ds1;
                dataPelapor.DataMember = "pelapor";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        */
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

        private void DataKematian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
