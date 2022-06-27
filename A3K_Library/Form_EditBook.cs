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
    public partial class Form_EditBook : Form
    {
        Koneksi conn = new Koneksi();
        private SqlCommand cmd;
        public Form_EditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Book fb = new Form_Book();
            if (txtKodeED.Text.Trim() == "" || txtPenulisEd.Text.Trim() == "" || txtJudulEd.Text.Trim() == "" || txtISBNEd.Text.Trim() == "" || txtPenerbitEd.Text.Trim() == "" || txtEksemplarEd.Text.Trim() == "" || txtSubjekEd.Text.Trim() == "" || txtTahunEd.Text.Trim() == "" || txtKontenEd.Text.Trim() == "" || txtTargetEd.Text.Trim() == "" || txtBahasaEd.Text.Trim() == "" || txtEdisiEd.Text.Trim() == "" || txtDeskripsiEd.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum diisi!");
            }
            else
            {
                SqlConnection conect = conn.GetConn();
                try
                {
                    cmd = new SqlCommand("update Buku set Penulis_Buku = '" + txtPenulisEd.Text + "', Judul_Buku = '" + txtJudulEd.Text + "', Eksemplar_Buku = '" + txtEksemplarEd.Text + "', Subjek = '" + txtSubjekEd.Text + "', Tahun_Terbit = '" + txtTahunEd.Text + "', Konten_Digital = '" + txtKontenEd.Text + "', Target_Pembaca = '" + txtTargetEd.Text + "', Bahasa = '" + txtBahasaEd.Text + "', Edisi = '" + txtEdisiEd.Text + "', Deskripsi_Fisik = '" + txtDeskripsiEd.Text + "' where Kode_Buku = '" + txtKodeED.Text + "'", conect);
                    conect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasi diUbah");
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

        private void Form_EditBook_Load(object sender, EventArgs e)
        {

        }
    }
}
