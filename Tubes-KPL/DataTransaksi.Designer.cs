namespace Tubes_KPL
{
    partial class DataTransaksi
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
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.panelDataTransaksi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMataUang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.panelDataTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(27, 92);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 51;
            this.dgvTransaksi.RowTemplate.Height = 24;
            this.dgvTransaksi.Size = new System.Drawing.Size(945, 426);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // btAddNew
            // 
            this.btAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btAddNew.ForeColor = System.Drawing.Color.White;
            this.btAddNew.Location = new System.Drawing.Point(354, 545);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(100, 37);
            this.btAddNew.TabIndex = 1;
            this.btAddNew.Text = "Add New";
            this.btAddNew.UseVisualStyleBackColor = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(524, 545);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 37);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panelDataTransaksi
            // 
            this.panelDataTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.panelDataTransaksi.Controls.Add(this.lbMataUang);
            this.panelDataTransaksi.Controls.Add(this.pictureBox1);
            this.panelDataTransaksi.Controls.Add(this.label1);
            this.panelDataTransaksi.Location = new System.Drawing.Point(-1, 0);
            this.panelDataTransaksi.Name = "panelDataTransaksi";
            this.panelDataTransaksi.Size = new System.Drawing.Size(997, 73);
            this.panelDataTransaksi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Transaksi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tubes_KPL.Properties.Resources.LogoLaundry;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbMataUang
            // 
            this.lbMataUang.AutoSize = true;
            this.lbMataUang.ForeColor = System.Drawing.Color.White;
            this.lbMataUang.Location = new System.Drawing.Point(817, 48);
            this.lbMataUang.Name = "lbMataUang";
            this.lbMataUang.Size = new System.Drawing.Size(79, 16);
            this.lbMataUang.TabIndex = 6;
            this.lbMataUang.Text = "Mata Uang: ";
            // 
            // DataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 603);
            this.Controls.Add(this.panelDataTransaksi);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.dgvTransaksi);
            this.Name = "DataTransaksi";
            this.Text = "DataTransaksi";
            this.Load += new System.EventHandler(this.DataTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.panelDataTransaksi.ResumeLayout(false);
            this.panelDataTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panelDataTransaksi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMataUang;
    }
}