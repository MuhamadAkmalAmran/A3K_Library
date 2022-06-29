
using System;
using System.Windows.Forms;

namespace A3K_Library
{
    partial class Form_Rak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rak));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtCariRak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridRak = new System.Windows.Forms.DataGridView();
            this.nomorRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet = new A3K_Library.A3K_LibraryDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rakTableAdapter = new A3K_Library.A3K_LibraryDataSetTableAdapters.RakTableAdapter();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtCariRak
            // 
            this.txtCariRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariRak.Location = new System.Drawing.Point(354, 98);
            this.txtCariRak.Name = "txtCariRak";
            this.txtCariRak.Size = new System.Drawing.Size(442, 54);
            this.txtCariRak.TabIndex = 1;
            this.txtCariRak.TextChanged += new System.EventHandler(this.txtCariRak_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rak";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1008, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridRak
            // 
            this.dataGridRak.AutoGenerateColumns = false;
            this.dataGridRak.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorRakDataGridViewTextBoxColumn,
            this.kategoriRakDataGridViewTextBoxColumn,
            this.lokasiRakDataGridViewTextBoxColumn});
            this.dataGridRak.DataSource = this.rakBindingSource;
            this.dataGridRak.Location = new System.Drawing.Point(213, 266);
            this.dataGridRak.Name = "dataGridRak";
            this.dataGridRak.RowHeadersWidth = 51;
            this.dataGridRak.RowTemplate.Height = 24;
            this.dataGridRak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRak.Size = new System.Drawing.Size(837, 227);
            this.dataGridRak.TabIndex = 6;
            this.dataGridRak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRak_CellClick);
            this.dataGridRak.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRak_CellDoubleClick);
            this.dataGridRak.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridRak_CellMouseUp);
            this.dataGridRak.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRak_RowEnter);
            this.dataGridRak.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridRak_MouseUp);
            // 
            // nomorRakDataGridViewTextBoxColumn
            // 
            this.nomorRakDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Rak";
            this.nomorRakDataGridViewTextBoxColumn.HeaderText = "Nomor_Rak";
            this.nomorRakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorRakDataGridViewTextBoxColumn.Name = "nomorRakDataGridViewTextBoxColumn";
            this.nomorRakDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriRakDataGridViewTextBoxColumn
            // 
            this.kategoriRakDataGridViewTextBoxColumn.DataPropertyName = "Kategori_Rak";
            this.kategoriRakDataGridViewTextBoxColumn.HeaderText = "Kategori_Rak";
            this.kategoriRakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriRakDataGridViewTextBoxColumn.Name = "kategoriRakDataGridViewTextBoxColumn";
            this.kategoriRakDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiRakDataGridViewTextBoxColumn
            // 
            this.lokasiRakDataGridViewTextBoxColumn.DataPropertyName = "Lokasi_Rak";
            this.lokasiRakDataGridViewTextBoxColumn.HeaderText = "Lokasi_Rak";
            this.lokasiRakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiRakDataGridViewTextBoxColumn.Name = "lokasiRakDataGridViewTextBoxColumn";
            this.lokasiRakDataGridViewTextBoxColumn.Width = 125;
            // 
            // rakBindingSource
            // 
            this.rakBindingSource.DataMember = "Rak";
            this.rakBindingSource.DataSource = this.a3K_LibraryDataSet;
            // 
            // a3K_LibraryDataSet
            // 
            this.a3K_LibraryDataSet.DataSetName = "A3K_LibraryDataSet";
            this.a3K_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(212, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(270, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(817, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(213, 509);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(330, 218);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // rakTableAdapter
            // 
            this.rakTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(156, 28);
            this.contextMenuStrip4.Click += new System.EventHandler(this.contextMenuStrip4_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // Form_Rak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridRak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariRak);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form_Rak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Rak";
            this.Load += new System.EventHandler(this.Form_Rak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtCariRak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private A3K_LibraryDataSet a3K_LibraryDataSet;
        private System.Windows.Forms.BindingSource rakBindingSource;
        private A3K_LibraryDataSetTableAdapters.RakTableAdapter rakTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.DataGridView dataGridRak;
        private DataGridViewCellEventHandler dataGridRak_CellContentDoubleClick;
        private EventHandler dataGridRak_Click;
        private EventHandler pictureBox5_Click;
        private DataGridViewTextBoxColumn nomorRakDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriRakDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lokasiRakDataGridViewTextBoxColumn;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
    }
}