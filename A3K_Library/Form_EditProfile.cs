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
    public partial class Form_EditProfile : Form
    {
        Koneksi conn = new Koneksi();
        private SqlCommand cmd;
        Form_Profile fp = new Form_Profile();
        public Form_EditProfile()
        {
            InitializeComponent();
        }

        private void Form_EditProfile_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtTelpon.Text.Trim() == "" || txtTgl.Text.Trim() == "" || txtJenis.Text.Trim() == "" || txtAlamat.Text.Trim() == "" )
            {
                MessageBox.Show("Data Belum diisi!");
            }
            else
            {
                SqlConnection conect = conn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into Buku values ('" + txtNama.Text + "', '" + txtTelpon.Text + "', '" + txtTgl.Text + "', , '" + txtJenis.Text + "', '" + txtAlamat.Text + "')", conect);
                    conect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasi diSimpan");
                    fp.Show();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
