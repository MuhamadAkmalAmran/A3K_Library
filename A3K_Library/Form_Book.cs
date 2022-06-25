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
            this.Close();
        }

        private void Form_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet1.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet1.Buku);

        }
    }
}
