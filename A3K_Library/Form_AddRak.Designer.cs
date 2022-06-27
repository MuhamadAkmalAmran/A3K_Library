
namespace A3K_Library
{
    partial class Form_AddRak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddRak));
            this.btnAddRak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoAdd = new System.Windows.Forms.TextBox();
            this.rakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a3K_LibraryDataSet = new A3K_Library.A3K_LibraryDataSet();
            this.txtLocAdd = new System.Windows.Forms.TextBox();
            this.txtCategoryAdd = new System.Windows.Forms.TextBox();
            this.rakTableAdapter = new A3K_Library.A3K_LibraryDataSetTableAdapters.RakTableAdapter();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRak
            // 
            this.btnAddRak.Location = new System.Drawing.Point(1001, 490);
            this.btnAddRak.Name = "btnAddRak";
            this.btnAddRak.Size = new System.Drawing.Size(124, 48);
            this.btnAddRak.TabIndex = 0;
            this.btnAddRak.Text = "Add";
            this.btnAddRak.UseVisualStyleBackColor = true;
            this.btnAddRak.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambahkan Data Rak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lokasi Rak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Rak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nomor Rak";
            // 
            // txtNoAdd
            // 
            this.txtNoAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Nomor_Rak", true));
            this.txtNoAdd.Location = new System.Drawing.Point(604, 155);
            this.txtNoAdd.Multiline = true;
            this.txtNoAdd.Name = "txtNoAdd";
            this.txtNoAdd.Size = new System.Drawing.Size(300, 50);
            this.txtNoAdd.TabIndex = 5;
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
            // txtLocAdd
            // 
            this.txtLocAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Lokasi_Rak", true));
            this.txtLocAdd.Location = new System.Drawing.Point(604, 308);
            this.txtLocAdd.Multiline = true;
            this.txtLocAdd.Name = "txtLocAdd";
            this.txtLocAdd.Size = new System.Drawing.Size(300, 50);
            this.txtLocAdd.TabIndex = 6;
            // 
            // txtCategoryAdd
            // 
            this.txtCategoryAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rakBindingSource, "Kategori_Rak", true));
            this.txtCategoryAdd.Location = new System.Drawing.Point(604, 228);
            this.txtCategoryAdd.Multiline = true;
            this.txtCategoryAdd.Name = "txtCategoryAdd";
            this.txtCategoryAdd.Size = new System.Drawing.Size(300, 50);
            this.txtCategoryAdd.TabIndex = 7;
            // 
            // rakTableAdapter
            // 
            this.rakTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 526);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Form_AddRak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtCategoryAdd);
            this.Controls.Add(this.txtLocAdd);
            this.Controls.Add(this.txtNoAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRak);
            this.DoubleBuffered = true;
            this.Name = "Form_AddRak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddRak";
            this.Load += new System.EventHandler(this.Form_AddRak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3K_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private A3K_LibraryDataSet a3K_LibraryDataSet;
        private System.Windows.Forms.BindingSource rakBindingSource;
        private A3K_LibraryDataSetTableAdapters.RakTableAdapter rakTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.TextBox txtNoAdd;
        public System.Windows.Forms.TextBox txtLocAdd;
        public System.Windows.Forms.TextBox txtCategoryAdd;
    }
}