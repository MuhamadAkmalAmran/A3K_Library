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
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet4.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet4.Buku);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_DetailBook Book1 = new Form_DetailBook();
            Book1.labelKode.Text = this.dataGridBook.CurrentRow.Cells[0].Value.ToString();
            Book1.labelPenulis.Text = this.dataGridBook.CurrentRow.Cells[1].Value.ToString();
            Book1.labelJudul.Text = this.dataGridBook.CurrentRow.Cells[2].Value.ToString();
            Book1.labelISBN.Text = this.dataGridBook.CurrentRow.Cells[3].Value.ToString();
            Book1.labelPenerbit.Text = this.dataGridBook.CurrentRow.Cells[4].Value.ToString();
            Book1.labelEksemplar.Text = this.dataGridBook.CurrentRow.Cells[5].Value.ToString();
            Book1.labelSubjek.Text = this.dataGridBook.CurrentRow.Cells[6].Value.ToString();
            Book1.labelTahun.Text = this.dataGridBook.CurrentRow.Cells[7].Value.ToString();
            Book1.labelKonten.Text = this.dataGridBook.CurrentRow.Cells[8].Value.ToString();
            Book1.labelTarget.Text = this.dataGridBook.CurrentRow.Cells[9].Value.ToString();
            Book1.labelBahasa.Text = this.dataGridBook.CurrentRow.Cells[10].Value.ToString();
         
            Book1.labelEdisi.Text = this.dataGridBook.CurrentRow.Cells[11].Value.ToString();
            Book1.labelDeskripsi.Text = this.dataGridBook.CurrentRow.Cells[12].Value.ToString();
            Book1.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_AddBook ab = new Form_AddBook();
            ab.Show();
            ab.txtKodeBuku.Clear();
            ab.txtPenulisBuku.Clear();
            ab.txtJudulBuku.Clear();
            ab.txtISBN.Clear();
            ab.txtPenerbit.Clear();
            ab.txtEksemplarBuku.Clear();
            ab.txtSubjek.Clear();
            ab.txtTahunTerbit.Clear();
            ab.txtKontenDigital.Clear();
            ab.txtTargetPembaca.Clear();
            ab.txtBahasa.Clear();
            ab.txtEdisi.Clear();
            ab.txtDeskripsiFisik.Clear();
            this.Hide();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    bukuBindingSource.EndEdit();
                    bukuTableAdapter.Update(a3K_LibraryDataSet4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridBook.SelectedRows)
            {
                dataGridBook.Rows.RemoveAt(item.Index);
            }
        }
    }
}
