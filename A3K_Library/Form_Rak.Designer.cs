
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nomorRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiRakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet = new A3K_Library.A3K_LibraryDataSet();
            this.rakTableAdapter = new A3K_Library.A3K_LibraryDataSetTableAdapters.RakTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 42);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(818, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
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
            this.pictureBox1.Location = new System.Drawing.Point(1000, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorRakDataGridViewTextBoxColumn,
            this.kategoriRakDataGridViewTextBoxColumn,
            this.lokasiRakDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rakBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(213, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(837, 227);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // rakTableAdapter
            // 
            this.rakTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1080, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1080, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1080, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form_Rak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form_Rak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Rak";
            this.Load += new System.EventHandler(this.Form_Rak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private A3K_LibraryDataSet a3K_LibraryDataSet;
        private System.Windows.Forms.BindingSource rakBindingSource;
        private A3K_LibraryDataSetTableAdapters.RakTableAdapter rakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorRakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriRakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiRakDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}