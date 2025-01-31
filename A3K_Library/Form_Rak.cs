﻿using System;
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
    public partial class Form_Rak : Form
    {
        private SqlCommand cmd;
        private int rowIndex ;
        private DataSet ds;
        private SqlDataAdapter da;
        
        Koneksi conn = new Koneksi();

        public Form_Rak()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Close();
        }

        //Method untuk menampilkan data digridview
        void TampilRak()
        {
            SqlConnection conect = conn.GetConn();

            try
            {
                conect.Open();
                cmd = new SqlCommand("Select * from Rak", conect);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Rak");
                dataGridRak.DataSource = ds;
                dataGridRak.DataMember = "Rak";
                dataGridRak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //method untuk pencarian data didatagridview
        void CariRak()
        {
            SqlConnection conect = conn.GetConn();

            try
            {
                conect.Open();
                cmd = new SqlCommand("Select * from Rak where Nomor_Rak like '%" + txtCariRak.Text + "%' or Lokasi_Rak like '%" + txtCariRak.Text + "%' or Kategori_Rak like '%" + txtCariRak.Text + "%'", conect);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Rak");
                dataGridRak.DataSource = ds;
                dataGridRak.DataMember = "Rak";
                dataGridRak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void Form_Rak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet.Rak' table. You can move, or remove it, as needed.
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);

            TampilRak();
        }

        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Form_DetailRak Rak1 = new Form_DetailRak();
            Rak1.labelNoRak.Text = this.dataGridRak.CurrentRow.Cells[0].Value.ToString();
            Rak1.labelKategoriRak.Text = this.dataGridRak.CurrentRow.Cells[1].Value.ToString();
            Rak1.labelLokasiRak.Text = this.dataGridRak.CurrentRow.Cells[2].Value.ToString();*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_AddRak ar = new Form_AddRak();
            
            ar.Show();
            ar.txtNoAdd.Clear();
            ar.txtCategoryAdd.Clear();
            ar.txtLocAdd.Clear();
        }
     
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rakTableAdapter.Update(a3K_LibraryDataSet);
                    this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridRak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Form_DetailRak Rak1 = new Form_DetailRak();
            Rak1.labelNoRak.Text = this.dataGridRak.CurrentRow.Cells[0].Value.ToString();
            Rak1.labelKategoriRak.Text = this.dataGridRak.CurrentRow.Cells[1].Value.ToString();
            Rak1.labelLokasiRak.Text = this.dataGridRak.CurrentRow.Cells[2].Value.ToString();*/
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Close();
        }

        private void dataGridRak_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridRak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_EditRak er = new Form_EditRak();
            try
            {
                DataGridViewRow row = this.dataGridRak.Rows[e.RowIndex];
                er.txtNoEd.Text = row.Cells[0].Value.ToString();
                er.txtCategoryEd.Text = row.Cells[1].Value.ToString();
                er.txtLocEd.Text = row.Cells[2].Value.ToString();
                er.Show();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void dataGridRak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCariRak_TextChanged(object sender, EventArgs e)
        {
            CariRak();
        }

        private void dataGridRak_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataGridRak_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridRak.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridRak.CurrentCell = this.dataGridRak.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip4.Show(this.dataGridRak, e.Location);
                contextMenuStrip4.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip4_Click(object sender, EventArgs e)
        {
            if (!this.dataGridRak.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridRak.Rows.RemoveAt(this.rowIndex);

            }
        }

        private void dataGridRak_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
