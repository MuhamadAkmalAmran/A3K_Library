
namespace A3K_Library
{
    partial class Form_EditRak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditRak));
            this.txtCategoryEd = new System.Windows.Forms.TextBox();
            this.txtLocEd = new System.Windows.Forms.TextBox();
            this.txtNameEd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRakBtn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryEd
            // 
            this.txtCategoryEd.Location = new System.Drawing.Point(621, 258);
            this.txtCategoryEd.Multiline = true;
            this.txtCategoryEd.Name = "txtCategoryEd";
            this.txtCategoryEd.Size = new System.Drawing.Size(300, 50);
            this.txtCategoryEd.TabIndex = 15;
            this.txtCategoryEd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLocEd
            // 
            this.txtLocEd.Location = new System.Drawing.Point(621, 338);
            this.txtLocEd.Multiline = true;
            this.txtLocEd.Name = "txtLocEd";
            this.txtLocEd.Size = new System.Drawing.Size(300, 50);
            this.txtLocEd.TabIndex = 14;
            this.txtLocEd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNameEd
            // 
            this.txtNameEd.Location = new System.Drawing.Point(621, 185);
            this.txtNameEd.Multiline = true;
            this.txtNameEd.Name = "txtNameEd";
            this.txtNameEd.Size = new System.Drawing.Size(300, 50);
            this.txtNameEd.TabIndex = 13;
            this.txtNameEd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama Rak";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori Rak";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lokasi Rak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edit Rak";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveRakBtn
            // 
            this.saveRakBtn.Location = new System.Drawing.Point(1018, 520);
            this.saveRakBtn.Name = "saveRakBtn";
            this.saveRakBtn.Size = new System.Drawing.Size(124, 48);
            this.saveRakBtn.TabIndex = 8;
            this.saveRakBtn.Text = "Save";
            this.saveRakBtn.UseVisualStyleBackColor = true;
            this.saveRakBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 526);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // Form_EditRak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtCategoryEd);
            this.Controls.Add(this.txtLocEd);
            this.Controls.Add(this.txtNameEd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveRakBtn);
            this.DoubleBuffered = true;
            this.Name = "Form_EditRak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditRak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryEd;
        private System.Windows.Forms.TextBox txtLocEd;
        private System.Windows.Forms.TextBox txtNameEd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveRakBtn;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}