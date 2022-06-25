
namespace A3K_Library
{
    partial class Form_DetailRak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DetailRak));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLokasiRak = new System.Windows.Forms.Label();
            this.rakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet = new A3K_Library.A3K_LibraryDataSet();
            this.labelKategoriRak = new System.Windows.Forms.Label();
            this.labelNoRak = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rakTableAdapter = new A3K_Library.A3K_LibraryDataSetTableAdapters.RakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Rak";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detail Rak";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelLokasiRak
            // 
            this.labelLokasiRak.AutoSize = true;
            this.labelLokasiRak.BackColor = System.Drawing.Color.Transparent;
            this.labelLokasiRak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Lokasi_Rak", true));
            this.labelLokasiRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLokasiRak.Location = new System.Drawing.Point(522, 333);
            this.labelLokasiRak.Name = "labelLokasiRak";
            this.labelLokasiRak.Size = new System.Drawing.Size(80, 27);
            this.labelLokasiRak.TabIndex = 3;
            this.labelLokasiRak.Text = "label4";
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
            // labelKategoriRak
            // 
            this.labelKategoriRak.AutoSize = true;
            this.labelKategoriRak.BackColor = System.Drawing.Color.Transparent;
            this.labelKategoriRak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Kategori_Rak", true));
            this.labelKategoriRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategoriRak.Location = new System.Drawing.Point(522, 251);
            this.labelKategoriRak.Name = "labelKategoriRak";
            this.labelKategoriRak.Size = new System.Drawing.Size(80, 27);
            this.labelKategoriRak.TabIndex = 4;
            this.labelKategoriRak.Text = "label5";
            // 
            // labelNoRak
            // 
            this.labelNoRak.AutoSize = true;
            this.labelNoRak.BackColor = System.Drawing.Color.Transparent;
            this.labelNoRak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Nomor_Rak", true));
            this.labelNoRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoRak.Location = new System.Drawing.Point(522, 173);
            this.labelNoRak.Name = "labelNoRak";
            this.labelNoRak.Size = new System.Drawing.Size(80, 27);
            this.labelNoRak.TabIndex = 5;
            this.labelNoRak.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lokasi Rak";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 251);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(159, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kategori Rak";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1104, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rakTableAdapter
            // 
            this.rakTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DetailRak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNoRak);
            this.Controls.Add(this.labelKategoriRak);
            this.Controls.Add(this.labelLokasiRak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form_DetailRak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DetailRak";
            this.Load += new System.EventHandler(this.Form_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private A3K_LibraryDataSet a3K_LibraryDataSet;
        private System.Windows.Forms.BindingSource rakBindingSource;
        private A3K_LibraryDataSetTableAdapters.RakTableAdapter rakTableAdapter;
        public System.Windows.Forms.Label labelNoRak;
        public System.Windows.Forms.Label labelKategoriRak;
        public System.Windows.Forms.Label labelLokasiRak;
    }
}