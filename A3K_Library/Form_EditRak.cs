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

namespace A3K_Library
{
    public partial class Form_EditRak : Form
    {
        private SqlCommand cmd;
        Koneksi conn = new Koneksi();
        public Form_EditRak()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Rak fr = new Form_Rak();
            if (txtNoEd.Text.Trim() == "" || txtCategoryEd.Text.Trim() == "" || txtLocEd.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum diisi!");
            }
            else
            {
                SqlConnection conect = conn.GetConn();
                try
                {
                    cmd = new SqlCommand("update Rak set Kategori_Rak = '" + txtCategoryEd.Text + "', Lokasi_Rak = '" + txtLocEd.Text + "' where Nomor_Rak = '" + txtNoEd.Text + "'", conect);
                    conect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasi diUbah");
                    fr.Show();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void Form_EditRak_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Rak fr = new Form_Rak();
            fr.Show();
            this.Close();
        }
    }
}
