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
    public partial class Form_AddBook : Form
    {
        public Form_AddBook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet2.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter1.Fill(this.a3K_LibraryDataSet2.Buku);
            // TODO: This line of code loads data into the 'a3K_LibraryDataSet1.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.a3K_LibraryDataSet1.Buku);

        }
    }
}
