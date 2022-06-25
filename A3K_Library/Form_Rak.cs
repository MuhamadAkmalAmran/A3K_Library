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
    public partial class Form_Rak : Form
    {
        public Form_Rak()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Close();
        }

        private void Form_Rak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet.Rak' table. You can move, or remove it, as needed.
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_DetailRak Rak1 = new Form_DetailRak();
            Rak1.labelNoRak.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Rak1.labelKategoriRak.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Rak1.labelLokasiRak.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
