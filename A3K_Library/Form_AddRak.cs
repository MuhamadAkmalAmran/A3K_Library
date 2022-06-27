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
    public partial class Form_AddRak : Form
    {
        private SqlCommand cmd;
        Koneksi conn = new Koneksi();
        Form_Rak fr = new Form_Rak();
        public Form_AddRak()
        {
            InitializeComponent();
        }

         
        private void Form_AddRak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet.Rak' table. You can move, or remove it, as needed.
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNoAdd.Text.Trim() == "" || txtCategoryAdd.Text.Trim() == "" || txtLocAdd.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum diisi!");
            }
            else
            {
                SqlConnection conect = conn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into Rak values ('" + txtNoAdd.Text + "', '" + txtCategoryAdd.Text + "', '" + txtLocAdd.Text + "')", conect);
                    conect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasi diSimpan");
                    fr.Show();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }

            /*dt = a3K_LibraryDataSet.Tables["Rak"];
            dr = dt.NewRow();
            dr[0] = txtNoAdd.Text;
            dr[1] = txtCategoryAdd.Text;
            dr[2] = txtLocAdd.Text;
            dt.Rows.Add(dr);
            rakTableAdapter.Update(a3K_LibraryDataSet);
            txtNoAdd.Text = System.Convert.ToString(dr[0]);
            txtCategoryAdd.Enabled = false;
            txtLocAdd.Enabled = false;
            this.rakTableAdapter.Fill(this.a3K_LibraryDataSet.Rak);
            btnAddRak.Enabled = false;
            new Form_Rak().Show();
            this.Close();*/
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fr.Show();
            this.Close();
        }
    }
}
