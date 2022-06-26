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
    public partial class Form_Book : Form
    {
        public Form_Book()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Hide();
        }

        private void Form_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet1.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet1.Buku);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_DetailBook Book1 = new Form_DetailBook();
            Book1.labelKode.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Book1.labelPenulis.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Book1.labelJudul.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Book1.labelISBN.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Book1.labelPenerbit.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Book1.labelEksemplar.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Book1.labelSubjek.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            Book1.labelTahun.Text = this.dataGridView2.CurrentRow.Cells[7].Value.ToString();
            Book1.labelKonten.Text = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();
            Book1.labelTarget.Text = this.dataGridView2.CurrentRow.Cells[9].Value.ToString();
            Book1.labelBahasa.Text = this.dataGridView2.CurrentRow.Cells[10].Value.ToString();
         
            Book1.labelEdisi.Text = this.dataGridView2.CurrentRow.Cells[11].Value.ToString();
            Book1.labelDeskripsi.Text = this.dataGridView2.CurrentRow.Cells[12].Value.ToString();
            Book1.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form_AddBook().Show();
            this.Hide();
        }
    }
}
