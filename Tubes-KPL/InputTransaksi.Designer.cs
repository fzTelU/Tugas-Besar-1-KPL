
namespace Tubes_KPL
{
    partial class InputTransaksi
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
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.tbIDTransaksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamaJasa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelInputTransaksi = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInputTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(128, 228);
            this.tbDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(899, 85);
            this.tbDeskripsi.TabIndex = 32;
            this.tbDeskripsi.TextChanged += new System.EventHandler(this.tbDeskripsi_TextChanged);
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(128, 184);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(4);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(899, 22);
            this.tbBerat.TabIndex = 33;
            // 
            // tbIDTransaksi
            // 
            this.tbIDTransaksi.Location = new System.Drawing.Point(128, 95);
            this.tbIDTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDTransaksi.Name = "tbIDTransaksi";
            this.tbIDTransaksi.Size = new System.Drawing.Size(899, 22);
            this.tbIDTransaksi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Deskripsi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Berat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "No Transaksi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(441, 346);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 37);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(585, 346);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 37);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Input Transaksi";
            // 
            // cbNamaJasa
            // 
            this.cbNamaJasa.FormattingEnabled = true;
            this.cbNamaJasa.Location = new System.Drawing.Point(128, 138);
            this.cbNamaJasa.Margin = new System.Windows.Forms.Padding(4);
            this.cbNamaJasa.Name = "cbNamaJasa";
            this.cbNamaJasa.Size = new System.Drawing.Size(899, 24);
            this.cbNamaJasa.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nama Jasa";
            // 
            // tbTanggal
            // 
            this.tbTanggal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.tbTanggal.ForeColor = System.Drawing.Color.White;
            this.tbTanggal.Location = new System.Drawing.Point(910, 37);
            this.tbTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(172, 22);
            this.tbTanggal.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(907, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tanggal :";
            // 
            // panelInputTransaksi
            // 
            this.panelInputTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInputTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.panelInputTransaksi.Controls.Add(this.pictureBox1);
            this.panelInputTransaksi.Controls.Add(this.label9);
            this.panelInputTransaksi.Controls.Add(this.label1);
            this.panelInputTransaksi.Controls.Add(this.tbTanggal);
            this.panelInputTransaksi.Location = new System.Drawing.Point(0, 0);
            this.panelInputTransaksi.Name = "panelInputTransaksi";
            this.panelInputTransaksi.Size = new System.Drawing.Size(1538, 73);
            this.panelInputTransaksi.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tubes_KPL.Properties.Resources.LogoLaundry;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // InputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 404);
            this.Controls.Add(this.panelInputTransaksi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNamaJasa);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.tbIDTransaksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputTransaksi";
            this.Text = "Input Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInputTransaksi.ResumeLayout(false);
            this.panelInputTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.TextBox tbIDTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNamaJasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelInputTransaksi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}