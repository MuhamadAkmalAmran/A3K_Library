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
    public partial class Form_AddBook : Form
    {
        private SqlCommand cmd;
        Koneksi conn = new Koneksi();
        Form_Book fb = new Form_Book();
        public Form_AddBook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet5.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet5.Buku);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtKodeBuku.Text.Trim() == "" || txtJudulBuku.Text.Trim() == "" || txtPenulisBuku.Text.Trim() == "" || txtISBN.Text.Trim() == "" || txtPenerbit.Text.Trim() == "" || txtEksemplarBuku.Text.Trim() == "" || txtSubjek.Text.Trim() == "" || txtTahunTerbit.Text.Trim() == "" || txtKontenDigital.Text.Trim() == "" || txtTargetPembaca.Text.Trim() == "" || txtBahasa.Text.Trim() == "" || txtEdisi.Text.Trim() == "" || txtDeskripsiFisik.Text.Trim() == "" )
            {
                MessageBox.Show("Data Belum diisi!");
            }
            else
            {
                SqlConnection conect = conn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into Buku values ('" + txtKodeBuku.Text + "', '" + txtPenulisBuku.Text + "', '" + txtJudulBuku.Text + "', , '" + txtISBN.Text + "', '" + txtPenerbit.Text + "', '" + txtEksemplarBuku.Text + "', '" + txtSubjek.Text + "', '" + txtTahunTerbit.Text + "', '" + txtKontenDigital.Text + "', '" + txtTargetPembaca.Text + "', '" + txtBahasa.Text + "', '" + txtEdisi.Text + "', '" + txtDeskripsiFisik.Text + "')", conect);
                    conect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasi diSimpan");
                    fb.Show();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form_Book().Show();
            this.Close();
        }
    }
}
