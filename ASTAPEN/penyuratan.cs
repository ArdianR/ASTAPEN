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
using Microsoft.Office.Interop.Word;

namespace ASTAPEN
{
    public partial class penyuratan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASTAPEN\ASTAPEN\kependudukan.mdf;Integrated Security=True");
        public penyuratan()
        {
            InitializeComponent();
        }

        private void cmbJenisSurat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void showNIK()
        {
            txtNIK.Items.Clear();
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
                    txtNIK.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtNIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select * from penduduk where nik = '" + txtNIK.Text + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                while (reader.Read())
                {
                    txtNama.Text = reader["nama_lengkap"].ToString();
                    txtTglLahir.Text = reader["tempat_lahir"].ToString() + ", " + Convert.ToDateTime(reader["tgl_lahir"]).ToLongDateString();
                  //  txtTglLahir.Text = reader["tempat_lahir"].ToString();
                    txtJenKel.Text = reader["jk"].ToString();
                    txtRT.Text = reader["rt"].ToString();
                    txtPekerjaan.Text = reader["pekerjaan"].ToString();
                    txtAgama.Text = reader["agama"].ToString();
                    txtNoKK.Text = reader["no_kk"].ToString();
                    txtKet.Text = reader["ket"].ToString();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void penyuratan_Load(object sender, EventArgs e)
        {
            showNIK();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbJenisSurat.SelectedIndex == 0) {
                suratpengantar();
            }
            else if (cmbJenisSurat.SelectedIndex == 1)
            {
                suratketerangan();
            }
        }

        void suratpengantar()
        {
                //OBJECT OF MISSING "NULL VALUE"
                Object oMissing = System.Reflection.Missing.Value;
                Object oTemplatePath = "E:/ASTAPEN/templete surat pengantar.dotx";

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = new Document();
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                foreach (Field myMergeField in wordDoc.Fields)
                {
                    Range rngFieldCode = myMergeField.Code;
                    String fieldText = rngFieldCode.Text;
                    // ONLY GETTING THE MAILMERGE FIELDS
                    if (fieldText.StartsWith(" MERGEFIELD"))
                    {
                        // THE TEXT COMES IN THE FORMAT OF
                        // MERGEFIELD  MyFieldName  \\* MERGEFORMAT
                        // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"
                        Int32 endMerge = fieldText.IndexOf("\\");
                        Int32 fieldNameLength = fieldText.Length - endMerge;
                        String fieldName = fieldText.Substring(11, endMerge - 11);
                        // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE
                        fieldName = fieldName.Trim();
                        // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//
                        // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                        if (fieldName == "rt")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtRT.Text);
                        }
                        if (fieldName == "nama")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtNama.Text);
                        }
                        if (fieldName == "tempat")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtTglLahir.Text);
                        }
                        
                        if (fieldName == "jk")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtJenKel.Text);
                        }
                        if (fieldName == "pekerjaan")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtPekerjaan.Text);
                        }
                        if (fieldName == "Agama")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtAgama.Text);
                        }
                        if (fieldName == "nik")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtNIK.Text);
                        }
                        if (fieldName == "nokk")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(txtNoKK.Text);
                        }
                    }
                }
                wordDoc.SaveAs("myfile.docx");
                wordApp.Documents.Open("myFile.docx");
       }

        void suratketerangan()
        {
            //OBJECT OF MISSING "NULL VALUE"
            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = "E:/ASTAPEN/Surat Keterangan Domisili dari RT-RW ASTAPEN.dotx";

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = new Document();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Field myMergeField in wordDoc.Fields)
            {
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;
                // ONLY GETTING THE MAILMERGE FIELDS
                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // THE TEXT COMES IN THE FORMAT OF
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT
                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE
                    fieldName = fieldName.Trim();
                    // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//
                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "RT")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtRT.Text);
                    }
                    if (fieldName == "Nama")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtNama.Text);
                    }
                    if (fieldName == "TTL")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtTglLahir.Text);
                    }

                    if (fieldName == "JK")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtJenKel.Text);
                    }
                    if (fieldName == "Pekerjaan")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtPekerjaan.Text);
                    }
                    if (fieldName == "Agama")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtAgama.Text);
                    }
                    if (fieldName == "Status Perkawinan")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtKet.Text);
                    }
                 /*   if (fieldName == "nokk")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(txtNoKK.Text);
                    } */
                }
            }
            wordDoc.SaveAs("myfile.docx");
            wordApp.Documents.Open("myFile.docx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama m = new menuutama();
            m.Show();
            this.Close();
        }
    }
}
