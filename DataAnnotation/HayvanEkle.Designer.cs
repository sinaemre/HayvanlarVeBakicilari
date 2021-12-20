namespace DataAnnotation
{
    partial class HayvanEkle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clbBakicilar = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHayvanFavoriYiyecek = new System.Windows.Forms.ComboBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHayvanTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHayvanKutle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHayvanDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxHayvanSahibiVarMi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHayvanCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtHayvanAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBakiciIptal = new System.Windows.Forms.Button();
            this.btnBakiciEkle = new System.Windows.Forms.Button();
            this.clbHayvanlar = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBakiciAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBakiciSoyAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnYiyecekIptal = new System.Windows.Forms.Button();
            this.btnYiyecekEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.nudYiyecekKalori = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpSonKullanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYiyecekAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHayvanKutle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYiyecekKalori)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 452);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clbBakicilar);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cboHayvanFavoriYiyecek);
            this.tabPage1.Controls.Add(this.btnIptal);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtHayvanTuru);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudHayvanKutle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpHayvanDogumTarihi);
            this.tabPage1.Controls.Add(this.cbxHayvanSahibiVarMi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboHayvanCinsiyet);
            this.tabPage1.Controls.Add(this.txtHayvanAdi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hayvan Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clbBakicilar
            // 
            this.clbBakicilar.FormattingEnabled = true;
            this.clbBakicilar.Location = new System.Drawing.Point(273, 40);
            this.clbBakicilar.Name = "clbBakicilar";
            this.clbBakicilar.Size = new System.Drawing.Size(387, 349);
            this.clbBakicilar.Sorted = true;
            this.clbBakicilar.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Bakıcı*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Favori Yiyecek";
            // 
            // cboHayvanFavoriYiyecek
            // 
            this.cboHayvanFavoriYiyecek.FormattingEnabled = true;
            this.cboHayvanFavoriYiyecek.Location = new System.Drawing.Point(18, 318);
            this.cboHayvanFavoriYiyecek.Name = "cboHayvanFavoriYiyecek";
            this.cboHayvanFavoriYiyecek.Size = new System.Drawing.Size(200, 21);
            this.cboHayvanFavoriYiyecek.TabIndex = 18;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(62, 385);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(143, 385);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tür*";
            // 
            // txtHayvanTuru
            // 
            this.txtHayvanTuru.Location = new System.Drawing.Point(18, 97);
            this.txtHayvanTuru.Name = "txtHayvanTuru";
            this.txtHayvanTuru.Size = new System.Drawing.Size(200, 20);
            this.txtHayvanTuru.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kütle*";
            // 
            // nudHayvanKutle
            // 
            this.nudHayvanKutle.Location = new System.Drawing.Point(18, 263);
            this.nudHayvanKutle.Name = "nudHayvanKutle";
            this.nudHayvanKutle.Size = new System.Drawing.Size(200, 20);
            this.nudHayvanKutle.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doğum Tarihi*";
            // 
            // dtpHayvanDogumTarihi
            // 
            this.dtpHayvanDogumTarihi.Location = new System.Drawing.Point(18, 208);
            this.dtpHayvanDogumTarihi.Name = "dtpHayvanDogumTarihi";
            this.dtpHayvanDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpHayvanDogumTarihi.TabIndex = 7;
            // 
            // cbxHayvanSahibiVarMi
            // 
            this.cbxHayvanSahibiVarMi.AutoSize = true;
            this.cbxHayvanSahibiVarMi.Location = new System.Drawing.Point(125, 362);
            this.cbxHayvanSahibiVarMi.Name = "cbxHayvanSahibiVarMi";
            this.cbxHayvanSahibiVarMi.Size = new System.Drawing.Size(97, 17);
            this.cbxHayvanSahibiVarMi.TabIndex = 6;
            this.cbxHayvanSahibiVarMi.Text = "Sahibi Var mi?*";
            this.cbxHayvanSahibiVarMi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cinsiyet*";
            // 
            // cboHayvanCinsiyet
            // 
            this.cboHayvanCinsiyet.FormattingEnabled = true;
            this.cboHayvanCinsiyet.Location = new System.Drawing.Point(18, 152);
            this.cboHayvanCinsiyet.Name = "cboHayvanCinsiyet";
            this.cboHayvanCinsiyet.Size = new System.Drawing.Size(200, 21);
            this.cboHayvanCinsiyet.TabIndex = 4;
            // 
            // txtHayvanAdi
            // 
            this.txtHayvanAdi.Location = new System.Drawing.Point(18, 42);
            this.txtHayvanAdi.Name = "txtHayvanAdi";
            this.txtHayvanAdi.Size = new System.Drawing.Size(200, 20);
            this.txtHayvanAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hayvan Adı*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBakiciIptal);
            this.tabPage2.Controls.Add(this.btnBakiciEkle);
            this.tabPage2.Controls.Add(this.clbHayvanlar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtBakiciAd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtBakiciSoyAd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bakıcı Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBakiciIptal
            // 
            this.btnBakiciIptal.Location = new System.Drawing.Point(79, 142);
            this.btnBakiciIptal.Name = "btnBakiciIptal";
            this.btnBakiciIptal.Size = new System.Drawing.Size(75, 23);
            this.btnBakiciIptal.TabIndex = 11;
            this.btnBakiciIptal.Text = "İptal";
            this.btnBakiciIptal.UseVisualStyleBackColor = true;
            this.btnBakiciIptal.Click += new System.EventHandler(this.btnBakiciIptal_Click);
            // 
            // btnBakiciEkle
            // 
            this.btnBakiciEkle.Location = new System.Drawing.Point(175, 142);
            this.btnBakiciEkle.Name = "btnBakiciEkle";
            this.btnBakiciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBakiciEkle.TabIndex = 10;
            this.btnBakiciEkle.Text = "Ekle";
            this.btnBakiciEkle.UseVisualStyleBackColor = true;
            this.btnBakiciEkle.Click += new System.EventHandler(this.btnBakiciEkle_Click);
            // 
            // clbHayvanlar
            // 
            this.clbHayvanlar.FormattingEnabled = true;
            this.clbHayvanlar.Location = new System.Drawing.Point(307, 45);
            this.clbHayvanlar.Name = "clbHayvanlar";
            this.clbHayvanlar.Size = new System.Drawing.Size(338, 289);
            this.clbHayvanlar.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Baktığı Hayvanlar";
            // 
            // txtBakiciAd
            // 
            this.txtBakiciAd.Location = new System.Drawing.Point(20, 45);
            this.txtBakiciAd.Name = "txtBakiciAd";
            this.txtBakiciAd.Size = new System.Drawing.Size(230, 20);
            this.txtBakiciAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Soyad";
            // 
            // txtBakiciSoyAd
            // 
            this.txtBakiciSoyAd.Location = new System.Drawing.Point(20, 95);
            this.txtBakiciSoyAd.Name = "txtBakiciSoyAd";
            this.txtBakiciSoyAd.Size = new System.Drawing.Size(230, 20);
            this.txtBakiciSoyAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ad";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnYiyecekIptal);
            this.tabPage3.Controls.Add(this.btnYiyecekEkle);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.nudYiyecekKalori);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dtpSonKullanmaTarihi);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dtpUretimTarihi);
            this.tabPage3.Controls.Add(this.txtYiyecekAd);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(704, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yiyecek Ekle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnYiyecekIptal
            // 
            this.btnYiyecekIptal.Location = new System.Drawing.Point(43, 269);
            this.btnYiyecekIptal.Name = "btnYiyecekIptal";
            this.btnYiyecekIptal.Size = new System.Drawing.Size(75, 23);
            this.btnYiyecekIptal.TabIndex = 9;
            this.btnYiyecekIptal.Text = "İptal";
            this.btnYiyecekIptal.UseVisualStyleBackColor = true;
            this.btnYiyecekIptal.Click += new System.EventHandler(this.btnYiyecekIptal_Click);
            // 
            // btnYiyecekEkle
            // 
            this.btnYiyecekEkle.Location = new System.Drawing.Point(145, 269);
            this.btnYiyecekEkle.Name = "btnYiyecekEkle";
            this.btnYiyecekEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYiyecekEkle.TabIndex = 8;
            this.btnYiyecekEkle.Text = "Ekle";
            this.btnYiyecekEkle.UseVisualStyleBackColor = true;
            this.btnYiyecekEkle.Click += new System.EventHandler(this.btnYiyecekEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Kalori";
            // 
            // nudYiyecekKalori
            // 
            this.nudYiyecekKalori.Location = new System.Drawing.Point(20, 223);
            this.nudYiyecekKalori.Name = "nudYiyecekKalori";
            this.nudYiyecekKalori.Size = new System.Drawing.Size(200, 20);
            this.nudYiyecekKalori.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Son Kullanma Tarihi";
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(20, 168);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpSonKullanmaTarihi.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Üretim Tarihi";
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Location = new System.Drawing.Point(20, 109);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpUretimTarihi.TabIndex = 2;
            // 
            // txtYiyecekAd
            // 
            this.txtYiyecekAd.Location = new System.Drawing.Point(20, 45);
            this.txtYiyecekAd.Name = "txtYiyecekAd";
            this.txtYiyecekAd.Size = new System.Drawing.Size(200, 20);
            this.txtYiyecekAd.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ad";
            // 
            // HayvanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "HayvanEkle";
            this.Text = "HayvanEkle";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHayvanKutle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYiyecekKalori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtHayvanAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHayvanCinsiyet;
        private System.Windows.Forms.CheckBox cbxHayvanSahibiVarMi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHayvanDogumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHayvanKutle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHayvanTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHayvanFavoriYiyecek;
        private System.Windows.Forms.TextBox txtBakiciAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBakiciSoyAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbHayvanlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYiyecekAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpSonKullanmaTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudYiyecekKalori;
        private System.Windows.Forms.Button btnYiyecekEkle;
        private System.Windows.Forms.Button btnBakiciIptal;
        private System.Windows.Forms.Button btnBakiciEkle;
        private System.Windows.Forms.Button btnYiyecekIptal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox clbBakicilar;
    }
}