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
    public partial class Form_Book : Form
    {
        Koneksi conn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        
        public Form_Book()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Close();
        }

        void TampilBook()
        {
            SqlConnection conect = conn.GetConn();

            try
            {
                conect.Open();
                cmd = new SqlCommand("Select * from Buku", conect);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Buku");
                dataGridBook.DataSource = ds;
                dataGridBook.DataMember = "Buku";
                dataGridBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                conect.Close();
            }
        }
        private void Form_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet8.Rak' table. You can move, or remove it, as needed.
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet8.Rak);
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet7.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet7.Buku);

            TampilBook();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    bukuBindingSource.EndEdit();
                    bukuTableAdapter.Update(a3K_LibraryDataSet7);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_EditBook eb = new Form_EditBook();
            eb.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Close();
        }

        private void dataGridBook_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Close();
        }

        private void dataGridBook_DoubleClick(object sender, EventArgs e)
        {

            
        }

        private void dataGridBook_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_EditBook edit = new Form_EditBook();
            try
            {
                DataGridViewRow row = this.dataGridBook.Rows[e.RowIndex];
                edit.txtKodeED.Text = row.Cells[0].Value.ToString();
                edit.txtPenulisEd.Text = row.Cells[1].Value.ToString();
                edit.txtJudulEd.Text = row.Cells[2].Value.ToString();
                edit.txtISBNEd.Text = row.Cells[3].Value.ToString();
                edit.txtPenerbitEd.Text = row.Cells[4].Value.ToString();
                edit.txtEksemplarEd.Text = row.Cells[5].Value.ToString();
                edit.txtSubjekEd.Text = row.Cells[6].Value.ToString();
                edit.txtTahunEd.Text = row.Cells[7].Value.ToString();
                edit.txtKontenEd.Text = row.Cells[8].Value.ToString();
                edit.txtTargetEd.Text = row.Cells[9].Value.ToString();
                edit.txtBahasaEd.Text = row.Cells[10].Value.ToString();
                edit.txtEdisiEd.Text = row.Cells[11].Value.ToString();
                edit.txtDeskripsiEd.Text = row.Cells[12].Value.ToString();
                edit.Show();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
