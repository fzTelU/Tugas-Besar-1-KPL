namespace Tubes_KPL
{
    partial class DataJasa
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
            this.panelDataJasa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJasa = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbMataUang = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDataJasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataJasa
            // 
            this.panelDataJasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataJasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.panelDataJasa.Controls.Add(this.lbMataUang);
            this.panelDataJasa.Controls.Add(this.label1);
            this.panelDataJasa.Controls.Add(this.pictureBox1);
            this.panelDataJasa.Location = new System.Drawing.Point(0, 0);
            this.panelDataJasa.Name = "panelDataJasa";
            this.panelDataJasa.Size = new System.Drawing.Size(997, 73);
            this.panelDataJasa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Jasa";
            // 
            // dgvJasa
            // 
            this.dgvJasa.BackgroundColor = System.Drawing.Color.White;
            this.dgvJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJasa.Location = new System.Drawing.Point(24, 91);
            this.dgvJasa.Name = "dgvJasa";
            this.dgvJasa.RowHeadersWidth = 51;
            this.dgvJasa.RowTemplate.Height = 24;
            this.dgvJasa.Size = new System.Drawing.Size(945, 426);
            this.dgvJasa.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(349, 549);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 37);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(502, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbMataUang
            // 
            this.lbMataUang.AutoSize = true;
            this.lbMataUang.ForeColor = System.Drawing.Color.Transparent;
            this.lbMataUang.Location = new System.Drawing.Point(820, 48);
            this.lbMataUang.Name = "lbMataUang";
            this.lbMataUang.Size = new System.Drawing.Size(76, 16);
            this.lbMataUang.TabIndex = 2;
            this.lbMataUang.Text = "Mata Uang:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tubes_KPL.Properties.Resources.LogoLaundry;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DataJasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 603);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvJasa);
            this.Controls.Add(this.panelDataJasa);
            this.Name = "DataJasa";
            this.Text = "DataJasa";
            this.panelDataJasa.ResumeLayout(false);
            this.panelDataJasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataJasa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJasa;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbMataUang;
    }
}