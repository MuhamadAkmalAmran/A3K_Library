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
            Rak1.labelNoRak.Text = this.dataGridRak.CurrentRow.Cells[0].Value.ToString();
            Rak1.labelKategoriRak.Text = this.dataGridRak.CurrentRow.Cells[1].Value.ToString();
            Rak1.labelLokasiRak.Text = this.dataGridRak.CurrentRow.Cells[2].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form_EditRak().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_AddRak FAR = new Form_AddRak();
            FAR.Show();
            FAR.txtNoAdd.Clear();
            FAR.txtLocAdd.Clear();
            FAR.txtCategoryAdd.Clear();
        }
        

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridRak.SelectedRows)
            {
                dataGridRak.Rows.RemoveAt(item.Index);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    rakBindingSource.EndEdit();
                    rakTableAdapter.Update(a3K_LibraryDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
