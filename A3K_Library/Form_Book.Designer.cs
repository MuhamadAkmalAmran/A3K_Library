
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodeBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penulisBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunTerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenDigitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPembacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bahasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiFisikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPustakawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet1 = new A3K_Library.A3K_LibraryDataSet1();
            this.a3K_LibraryDataSet = new A3K_Library.A3K_LibraryDataSet();
            this.a3KLibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuTableAdapter = new A3K_Library.A3K_LibraryDataSet1TableAdapters.BukuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3KLibraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1003, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buku";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(821, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 42);
            this.textBox1.TabIndex = 7;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBukuDataGridViewTextBoxColumn,
            this.penulisBukuDataGridViewTextBoxColumn,
            this.judulBukuDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.penerbitDataGridViewTextBoxColumn,
            this.subjekDataGridViewTextBoxColumn,
            this.tahunTerbitDataGridViewTextBoxColumn,
            this.kontenDigitalDataGridViewTextBoxColumn,
            this.targetPembacaDataGridViewTextBoxColumn,
            this.bahasaDataGridViewTextBoxColumn,
            this.edisiDataGridViewTextBoxColumn,
            this.deskripsiFisikDataGridViewTextBoxColumn,
            this.idPustakawanDataGridViewTextBoxColumn,
            this.nomorRakDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bukuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(216, 307);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(837, 227);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // idPustakawanDataGridViewTextBoxColumn
            // 
            this.idPustakawanDataGridViewTextBoxColumn.DataPropertyName = "Id_Pustakawan";
            this.idPustakawanDataGridViewTextBoxColumn.HeaderText = "Id_Pustakawan";
            this.idPustakawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPustakawanDataGridViewTextBoxColumn.Name = "idPustakawanDataGridViewTextBoxColumn";
            this.idPustakawanDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorRakDataGridViewTextBoxColumn
            // 
            this.nomorRakDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Rak";
            this.nomorRakDataGridViewTextBoxColumn.HeaderText = "Nomor_Rak";
            this.nomorRakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorRakDataGridViewTextBoxColumn.Name = "nomorRakDataGridViewTextBoxColumn";
            this.nomorRakDataGridViewTextBoxColumn.Width = 125;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "Buku";
            this.bukuBindingSource.DataSource = this.a3K_LibraryDataSet1;
            // 
            // a3K_LibraryDataSet1
            // 
            this.a3K_LibraryDataSet1.DataSetName = "A3K_LibraryDataSet1";
            this.a3K_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a3K_LibraryDataSet
            // 
            this.a3K_LibraryDataSet.DataSetName = "A3K_LibraryDataSet";
            this.a3K_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a3KLibraryDataSetBindingSource
            // 
            this.a3KLibraryDataSetBindingSource.DataSource = this.a3K_LibraryDataSet;
            this.a3KLibraryDataSetBindingSource.Position = 0;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Book";
            this.Load += new System.EventHandler(this.Form_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3KLibraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private A3K_LibraryDataSet a3K_LibraryDataSet;
        private System.Windows.Forms.BindingSource a3KLibraryDataSetBindingSource;
        private A3K_LibraryDataSet1 a3K_LibraryDataSet1;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private A3K_LibraryDataSet1TableAdapters.BukuTableAdapter bukuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penulisBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunTerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenDigitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPembacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bahasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiFisikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPustakawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorRakDataGridViewTextBoxColumn;
    }
}