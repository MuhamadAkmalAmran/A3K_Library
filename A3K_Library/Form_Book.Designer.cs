
namespace A3K_Library
{
    partial class Form_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Book));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariBuku = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.kodeBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penulisBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eksemplarBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunTerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenDigitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPembacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bahasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiFisikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet7 = new A3K_Library.A3K_LibraryDataSet7();
            this.bukuTableAdapter = new A3K_Library.A3K_LibraryDataSet7TableAdapters.BukuTableAdapter();
            this.a3K_LibraryDataSet8 = new A3K_Library.A3K_LibraryDataSet8();
            this.rakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rakTableAdapter = new A3K_Library.A3K_LibraryDataSet8TableAdapters.RakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buku";
            // 
            // txtCariBuku
            // 
            this.txtCariBuku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariBuku.Location = new System.Drawing.Point(357, 139);
            this.txtCariBuku.Name = "txtCariBuku";
            this.txtCariBuku.Size = new System.Drawing.Size(442, 46);
            this.txtCariBuku.TabIndex = 7;
            this.txtCariBuku.TextChanged += new System.EventHandler(this.txtCariBuku_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(277, 259);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1011, 553);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(822, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(216, 545);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(342, 259);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // dataGridBook
            // 
            this.dataGridBook.AutoGenerateColumns = false;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBukuDataGridViewTextBoxColumn,
            this.penulisBukuDataGridViewTextBoxColumn,
            this.judulBukuDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.penerbitDataGridViewTextBoxColumn,
            this.eksemplarBukuDataGridViewTextBoxColumn,
            this.subjekDataGridViewTextBoxColumn,
            this.tahunTerbitDataGridViewTextBoxColumn,
            this.kontenDigitalDataGridViewTextBoxColumn,
            this.targetPembacaDataGridViewTextBoxColumn,
            this.bahasaDataGridViewTextBoxColumn,
            this.edisiDataGridViewTextBoxColumn,
            this.deskripsiFisikDataGridViewTextBoxColumn});
            this.dataGridBook.DataSource = this.bukuBindingSource;
            this.dataGridBook.Location = new System.Drawing.Point(216, 307);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.RowHeadersWidth = 51;
            this.dataGridBook.RowTemplate.Height = 24;
            this.dataGridBook.Size = new System.Drawing.Size(837, 227);
            this.dataGridBook.TabIndex = 21;
            this.dataGridBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellClick);
            this.dataGridBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellDoubleClick);
            this.dataGridBook.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellMouseLeave);
            this.dataGridBook.DoubleClick += new System.EventHandler(this.dataGridBook_DoubleClick);
            // 
            // kodeBukuDataGridViewTextBoxColumn
            // 
            this.kodeBukuDataGridViewTextBoxColumn.DataPropertyName = "Kode_Buku";
            this.kodeBukuDataGridViewTextBoxColumn.HeaderText = "Kode_Buku";
            this.kodeBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBukuDataGridViewTextBoxColumn.Name = "kodeBukuDataGridViewTextBoxColumn";
            this.kodeBukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // penulisBukuDataGridViewTextBoxColumn
            // 
            this.penulisBukuDataGridViewTextBoxColumn.DataPropertyName = "Penulis_Buku";
            this.penulisBukuDataGridViewTextBoxColumn.HeaderText = "Penulis_Buku";
            this.penulisBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penulisBukuDataGridViewTextBoxColumn.Name = "penulisBukuDataGridViewTextBoxColumn";
            this.penulisBukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // judulBukuDataGridViewTextBoxColumn
            // 
            this.judulBukuDataGridViewTextBoxColumn.DataPropertyName = "Judul_Buku";
            this.judulBukuDataGridViewTextBoxColumn.HeaderText = "Judul_Buku";
            this.judulBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.judulBukuDataGridViewTextBoxColumn.Name = "judulBukuDataGridViewTextBoxColumn";
            this.judulBukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // penerbitDataGridViewTextBoxColumn
            // 
            this.penerbitDataGridViewTextBoxColumn.DataPropertyName = "Penerbit";
            this.penerbitDataGridViewTextBoxColumn.HeaderText = "Penerbit";
            this.penerbitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penerbitDataGridViewTextBoxColumn.Name = "penerbitDataGridViewTextBoxColumn";
            this.penerbitDataGridViewTextBoxColumn.Width = 125;
            // 
            // eksemplarBukuDataGridViewTextBoxColumn
            // 
            this.eksemplarBukuDataGridViewTextBoxColumn.DataPropertyName = "Eksemplar_Buku";
            this.eksemplarBukuDataGridViewTextBoxColumn.HeaderText = "Eksemplar_Buku";
            this.eksemplarBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eksemplarBukuDataGridViewTextBoxColumn.Name = "eksemplarBukuDataGridViewTextBoxColumn";
            this.eksemplarBukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjekDataGridViewTextBoxColumn
            // 
            this.subjekDataGridViewTextBoxColumn.DataPropertyName = "Subjek";
            this.subjekDataGridViewTextBoxColumn.HeaderText = "Subjek";
            this.subjekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjekDataGridViewTextBoxColumn.Name = "subjekDataGridViewTextBoxColumn";
            this.subjekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tahunTerbitDataGridViewTextBoxColumn
            // 
            this.tahunTerbitDataGridViewTextBoxColumn.DataPropertyName = "Tahun_Terbit";
            this.tahunTerbitDataGridViewTextBoxColumn.HeaderText = "Tahun_Terbit";
            this.tahunTerbitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahunTerbitDataGridViewTextBoxColumn.Name = "tahunTerbitDataGridViewTextBoxColumn";
            this.tahunTerbitDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontenDigitalDataGridViewTextBoxColumn
            // 
            this.kontenDigitalDataGridViewTextBoxColumn.DataPropertyName = "Konten_Digital";
            this.kontenDigitalDataGridViewTextBoxColumn.HeaderText = "Konten_Digital";
            this.kontenDigitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontenDigitalDataGridViewTextBoxColumn.Name = "kontenDigitalDataGridViewTextBoxColumn";
            this.kontenDigitalDataGridViewTextBoxColumn.Width = 125;
            // 
            // targetPembacaDataGridViewTextBoxColumn
            // 
            this.targetPembacaDataGridViewTextBoxColumn.DataPropertyName = "Target_Pembaca";
            this.targetPembacaDataGridViewTextBoxColumn.HeaderText = "Target_Pembaca";
            this.targetPembacaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.targetPembacaDataGridViewTextBoxColumn.Name = "targetPembacaDataGridViewTextBoxColumn";
            this.targetPembacaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bahasaDataGridViewTextBoxColumn
            // 
            this.bahasaDataGridViewTextBoxColumn.DataPropertyName = "Bahasa";
            this.bahasaDataGridViewTextBoxColumn.HeaderText = "Bahasa";
            this.bahasaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bahasaDataGridViewTextBoxColumn.Name = "bahasaDataGridViewTextBoxColumn";
            this.bahasaDataGridViewTextBoxColumn.Width = 125;
            // 
            // edisiDataGridViewTextBoxColumn
            // 
            this.edisiDataGridViewTextBoxColumn.DataPropertyName = "Edisi";
            this.edisiDataGridViewTextBoxColumn.HeaderText = "Edisi";
            this.edisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edisiDataGridViewTextBoxColumn.Name = "edisiDataGridViewTextBoxColumn";
            this.edisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskripsiFisikDataGridViewTextBoxColumn
            // 
            this.deskripsiFisikDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi_Fisik";
            this.deskripsiFisikDataGridViewTextBoxColumn.HeaderText = "Deskripsi_Fisik";
            this.deskripsiFisikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiFisikDataGridViewTextBoxColumn.Name = "deskripsiFisikDataGridViewTextBoxColumn";
            this.deskripsiFisikDataGridViewTextBoxColumn.Width = 125;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "Buku";
            this.bukuBindingSource.DataSource = this.a3K_LibraryDataSet7;
            // 
            // a3K_LibraryDataSet7
            // 
            this.a3K_LibraryDataSet7.DataSetName = "A3K_LibraryDataSet7";
            this.a3K_LibraryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // a3K_LibraryDataSet8
            // 
            this.a3K_LibraryDataSet8.DataSetName = "A3K_LibraryDataSet8";
            this.a3K_LibraryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rakBindingSource
            // 
            this.rakBindingSource.DataMember = "Rak";
            this.rakBindingSource.DataSource = this.a3K_LibraryDataSet8;
            // 
            // rakTableAdapter
            // 
            this.rakTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariBuku);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Book";
            this.Load += new System.EventHandler(this.Form_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariBuku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dataGridBook;
        private A3K_LibraryDataSet7 a3K_LibraryDataSet7;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private A3K_LibraryDataSet7TableAdapters.BukuTableAdapter bukuTableAdapter;
        private A3K_LibraryDataSet8 a3K_LibraryDataSet8;
        private System.Windows.Forms.BindingSource rakBindingSource;
        private A3K_LibraryDataSet8TableAdapters.RakTableAdapter rakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penulisBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksemplarBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunTerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenDigitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPembacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bahasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiFisikDataGridViewTextBoxColumn;
    }
}