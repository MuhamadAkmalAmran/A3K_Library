using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3K_Library
{
    public partial class Form_AddBook : Form
    {

        DataTable dt;
        DataRow dr;
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
            dt = a3K_LibraryDataSet5.Tables["Buku"];
            dr = dt.NewRow();
            dr[0] = txtKodeBuku.Text;
            dr[1] = txtPenulisBuku.Text;
            dr[2] = txtJudulBuku.Text;
            dr[3] = txtISBN.Text;
            dr[4] = txtPenerbit.Text;
            dr[5] = txtEksemplarBuku.Text;
            dr[6] = txtSubjek.Text;
            dr[7] = txtTahunTerbit.Text;
            dr[9] = txtKontenDigital.Text;
            dr[10] = txtTargetPembaca.Text;
            dr[11] = txtBahasa.Text;
            dr[12] = txtEdisi.Text;
            dr[13] = txtDeskripsiFisik.Text;
            dt.Rows.Add(dr);
            bukuTableAdapter.Update(a3K_LibraryDataSet5);
            txtKodeBuku.Text = System.Convert.ToString(dr[0]);
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet5.Buku);
            btnAddBook.Enabled = false;
            new Form_Book().Show();
            this.Close();
        }
    }
}
