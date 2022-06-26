
namespace A3K_Library
{
    partial class Form_AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddBook));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet1 = new A3K_Library.A3K_LibraryDataSet1();
            this.txtKontenDigital = new System.Windows.Forms.TextBox();
            this.bukuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet2 = new A3K_Library.A3K_LibraryDataSet2();
            this.txtTargetPembaca = new System.Windows.Forms.TextBox();
            this.txtBahasa = new System.Windows.Forms.TextBox();
            this.txtSubjek = new System.Windows.Forms.TextBox();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtEksemplarBuku = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.txtPenulisBuku = new System.Windows.Forms.TextBox();
            this.txtDeskripsiFisik = new System.Windows.Forms.TextBox();
            this.txtEdisi = new System.Windows.Forms.TextBox();
            this.bukuTableAdapter = new A3K_Library.A3K_LibraryDataSet1TableAdapters.BukuTableAdapter();
            this.bukuTableAdapter1 = new A3K_Library.A3K_LibraryDataSet2TableAdapters.BukuTableAdapter();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kode Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Penulis Buku";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Judul Buku";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(1112, 505);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(124, 48);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Eksemplar Buku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Subjek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tahun Terbit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Konten Digital";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Target Pembaca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bahasa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Edisi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "Deskripsi Fisik";
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "Kode_Buku", true));
            this.txtKodeBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBuku.Location = new System.Drawing.Point(317, 19);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.Size = new System.Drawing.Size(764, 30);
            this.txtKodeBuku.TabIndex = 26;
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
            // txtKontenDigital
            // 
            this.txtKontenDigital.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Konten_Digital", true));
            this.txtKontenDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontenDigital.Location = new System.Drawing.Point(317, 355);
            this.txtKontenDigital.Name = "txtKontenDigital";
            this.txtKontenDigital.Size = new System.Drawing.Size(764, 30);
            this.txtKontenDigital.TabIndex = 27;
            // 
            // bukuBindingSource1
            // 
            this.bukuBindingSource1.DataMember = "Buku";
            this.bukuBindingSource1.DataSource = this.a3K_LibraryDataSet2;
            // 
            // a3K_LibraryDataSet2
            // 
            this.a3K_LibraryDataSet2.DataSetName = "A3K_LibraryDataSet2";
            this.a3K_LibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTargetPembaca
            // 
            this.txtTargetPembaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Target_Pembaca", true));
            this.txtTargetPembaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetPembaca.Location = new System.Drawing.Point(317, 397);
            this.txtTargetPembaca.Name = "txtTargetPembaca";
            this.txtTargetPembaca.Size = new System.Drawing.Size(764, 30);
            this.txtTargetPembaca.TabIndex = 28;
            // 
            // txtBahasa
            // 
            this.txtBahasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Bahasa", true));
            this.txtBahasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBahasa.Location = new System.Drawing.Point(317, 439);
            this.txtBahasa.Name = "txtBahasa";
            this.txtBahasa.Size = new System.Drawing.Size(764, 30);
            this.txtBahasa.TabIndex = 29;
            // 
            // txtSubjek
            // 
            this.txtSubjek.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Subjek", true));
            this.txtSubjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjek.Location = new System.Drawing.Point(317, 271);
            this.txtSubjek.Name = "txtSubjek";
            this.txtSubjek.Size = new System.Drawing.Size(764, 30);
            this.txtSubjek.TabIndex = 30;
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Tahun_Terbit", true));
            this.txtTahunTerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahunTerbit.Location = new System.Drawing.Point(317, 313);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(764, 30);
            this.txtTahunTerbit.TabIndex = 31;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "Penerbit", true));
            this.txtPenerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenerbit.Location = new System.Drawing.Point(317, 187);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(764, 30);
            this.txtPenerbit.TabIndex = 32;
            // 
            // txtEksemplarBuku
            // 
            this.txtEksemplarBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Eksemplar_Buku", true));
            this.txtEksemplarBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEksemplarBuku.Location = new System.Drawing.Point(317, 229);
            this.txtEksemplarBuku.Name = "txtEksemplarBuku";
            this.txtEksemplarBuku.Size = new System.Drawing.Size(764, 30);
            this.txtEksemplarBuku.TabIndex = 33;
            // 
            // txtISBN
            // 
            this.txtISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "ISBN", true));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(317, 145);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(764, 30);
            this.txtISBN.TabIndex = 34;
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "Judul_Buku", true));
            this.txtJudulBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulBuku.Location = new System.Drawing.Point(317, 103);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.Size = new System.Drawing.Size(764, 30);
            this.txtJudulBuku.TabIndex = 35;
            // 
            // txtPenulisBuku
            // 
            this.txtPenulisBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "Penulis_Buku", true));
            this.txtPenulisBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenulisBuku.Location = new System.Drawing.Point(317, 61);
            this.txtPenulisBuku.Name = "txtPenulisBuku";
            this.txtPenulisBuku.Size = new System.Drawing.Size(764, 30);
            this.txtPenulisBuku.TabIndex = 36;
            // 
            // txtDeskripsiFisik
            // 
            this.txtDeskripsiFisik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Deskripsi_Fisik", true));
            this.txtDeskripsiFisik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskripsiFisik.Location = new System.Drawing.Point(317, 523);
            this.txtDeskripsiFisik.Name = "txtDeskripsiFisik";
            this.txtDeskripsiFisik.Size = new System.Drawing.Size(764, 30);
            this.txtDeskripsiFisik.TabIndex = 37;
            this.txtDeskripsiFisik.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtEdisi
            // 
            this.txtEdisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource1, "Edisi", true));
            this.txtEdisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdisi.Location = new System.Drawing.Point(317, 481);
            this.txtEdisi.Name = "txtEdisi";
            this.txtEdisi.Size = new System.Drawing.Size(764, 30);
            this.txtEdisi.TabIndex = 38;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // bukuTableAdapter1
            // 
            this.bukuTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 526);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // Form_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtEdisi);
            this.Controls.Add(this.txtDeskripsiFisik);
            this.Controls.Add(this.txtPenulisBuku);
            this.Controls.Add(this.txtJudulBuku);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtEksemplarBuku);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.txtSubjek);
            this.Controls.Add(this.txtBahasa);
            this.Controls.Add(this.txtTargetPembaca);
            this.Controls.Add(this.txtKontenDigital);
            this.Controls.Add(this.txtKodeBuku);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddBook);
            this.DoubleBuffered = true;
            this.Name = "Form_AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddBook";
            this.Load += new System.EventHandler(this.Form_AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKodeBuku;
        private System.Windows.Forms.TextBox txtKontenDigital;
        private System.Windows.Forms.TextBox txtTargetPembaca;
        private System.Windows.Forms.TextBox txtBahasa;
        private System.Windows.Forms.TextBox txtSubjek;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtEksemplarBuku;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.TextBox txtPenulisBuku;
        private System.Windows.Forms.TextBox txtDeskripsiFisik;
        private System.Windows.Forms.TextBox txtEdisi;
        private A3K_LibraryDataSet1 a3K_LibraryDataSet1;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private A3K_LibraryDataSet1TableAdapters.BukuTableAdapter bukuTableAdapter;
        private A3K_LibraryDataSet2 a3K_LibraryDataSet2;
        private System.Windows.Forms.BindingSource bukuBindingSource1;
        private A3K_LibraryDataSet2TableAdapters.BukuTableAdapter bukuTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}