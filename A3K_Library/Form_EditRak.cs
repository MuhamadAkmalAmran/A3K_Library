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
    public partial class Form_EditRak : Form
    {
        int selectedRow;
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
            DataGridViewRow newDataRow = fr.dataGridRak.Rows[selectedRow];
            newDataRow.Cells[0].Value = txtNameEd.Text;
            newDataRow.Cells[1].Value = txtCategoryEd.Text;
            newDataRow.Cells[2].Value = txtLocEd;
            fr.Show();
            this.Close();
        }

        private void Form_EditRak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet.Rak' table. You can move, or remove it, as needed.
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Rak fr = new Form_Rak();
            fr.Show();
            this.Close();
        }
    }
}
