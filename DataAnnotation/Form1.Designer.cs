namespace DataAnnotation
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHayvanEkle = new System.Windows.Forms.Button();
            this.dgvBakicilar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSevdigiYiyecek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.AllowUserToAddRows = false;
            this.dgvHayvanlar.AllowUserToDeleteRows = false;
            this.dgvHayvanlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHayvanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Location = new System.Drawing.Point(18, 65);
            this.dgvHayvanlar.MultiSelect = false;
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.ReadOnly = true;
            this.dgvHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanlar.Size = new System.Drawing.Size(661, 128);
            this.dgvHayvanlar.TabIndex = 2;
            this.dgvHayvanlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHayvanlar_CellDoubleClick);
            this.dgvHayvanlar.SelectionChanged += new System.EventHandler(this.dgvHayvanlar_SelectionChanged);
            this.dgvHayvanlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHayvanlar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hayvanlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hayvan Bakıcıları";
            // 
            // btnHayvanEkle
            // 
            this.btnHayvanEkle.Location = new System.Drawing.Point(413, 396);
            this.btnHayvanEkle.Name = "btnHayvanEkle";
            this.btnHayvanEkle.Size = new System.Drawing.Size(272, 23);
            this.btnHayvanEkle.TabIndex = 8;
            this.btnHayvanEkle.Text = "Hayvan/Bakıcı/Yiyecek Ekle";
            this.btnHayvanEkle.UseVisualStyleBackColor = true;
            this.btnHayvanEkle.Click += new System.EventHandler(this.btnHayvanEkle_Click);
            // 
            // dgvBakicilar
            // 
            this.dgvBakicilar.AllowUserToAddRows = false;
            this.dgvBakicilar.AllowUserToDeleteRows = false;
            this.dgvBakicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBakicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBakicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBakicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBakicilar.Location = new System.Drawing.Point(18, 233);
            this.dgvBakicilar.MultiSelect = false;
            this.dgvBakicilar.Name = "dgvBakicilar";
            this.dgvBakicilar.ReadOnly = true;
            this.dgvBakicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBakicilar.Size = new System.Drawing.Size(667, 143);
            this.dgvBakicilar.TabIndex = 6;
            this.dgvBakicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBakicilar_CellDoubleClick);
            this.dgvBakicilar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBakicilar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "En Sevdiği Yiyecek";
            // 
            // lblSevdigiYiyecek
            // 
            this.lblSevdigiYiyecek.AutoSize = true;
            this.lblSevdigiYiyecek.Location = new System.Drawing.Point(569, 37);
            this.lblSevdigiYiyecek.Name = "lblSevdigiYiyecek";
            this.lblSevdigiYiyecek.Size = new System.Drawing.Size(110, 13);
            this.lblSevdigiYiyecek.TabIndex = 11;
            this.lblSevdigiYiyecek.Text = "En Sevdiği Yiyecekler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.lblSevdigiYiyecek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHayvanEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBakicilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHayvanlar);
            this.Name = "Form1";
            this.Text = "Hayvanlar ve Bakıcıları";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHayvanEkle;
        private System.Windows.Forms.DataGridView dgvBakicilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSevdigiYiyecek;
    }
}

