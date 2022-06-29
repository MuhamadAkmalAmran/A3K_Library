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
    public partial class FormLogin : Form
    {
        Koneksi conn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataReader dr;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect = conn.GetConn();
            conect.Open();
            cmd = new SqlCommand("select * from masuk where Id_Pustakawan = '"+ tbID.Text + "' and Password = '" + tbPassword.Text + "'", conect);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
                conect.Close();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
