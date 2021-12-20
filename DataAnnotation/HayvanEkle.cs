using DataAnnotation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnnotation
{
    public partial class HayvanEkle : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Hayvan hayvan1 = new Hayvan();
        Bakici bakici1 = new Bakici();
        public HayvanEkle(ApplicationDbContext db, Hayvan hayvan1, Bakici bakici1)
        {
            this.db = db;
            this.hayvan1 = hayvan1;
            this.bakici1 = bakici1;
            InitializeComponent();
            BakicilariYukle();
            YiyecekleriYukle();
            CinsiyetYukle();
            HayvanlariYukle();
        }

        private void HayvanlariYukle()
        {
            clbHayvanlar.DataSource = db.Hayvanlar.OrderByDescending(x => x.Ad).ToList();
            clbHayvanlar.DisplayMember = "Ad";
            clbHayvanlar.ValueMember = "Id";

            if (hayvan1 == null && bakici1 == null)
            {
                HayvanEkleFormuTemizle();
            }
            else if (hayvan1 != null)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                btnEkle.Text = "Kaydet";
                txtHayvanAdi.Text = hayvan1.Ad;
                txtHayvanTuru.Text = hayvan1.Tur;
                nudHayvanKutle.Value = hayvan1.Kutle;
                cboHayvanCinsiyet.SelectedItem = hayvan1.Cinsiyet;
                cboHayvanFavoriYiyecek.SelectedItem = hayvan1.FavoriYiyecekId;
                cbxHayvanSahibiVarMi.Checked = hayvan1.SahibiVarMi;

                for (int i = 0; i < clbBakicilar.Items.Count; i++)
                {
                    Bakici bakici = (Bakici)clbBakicilar.Items[i];
                    if (hayvan1.Bakicilar.Any(x => x.Id == bakici.Id))
                    {
                        clbBakicilar.SetItemChecked(i, true);
                    }
                }
            }
            else if (bakici1 != null)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                btnBakiciEkle.Text = "Düzenle";
                txtBakiciAd.Text = bakici1.Ad;
                txtBakiciSoyAd.Text = bakici1.SoyAd;
                for (int i = 0; i < clbHayvanlar.Items.Count; i++)
                {
                    Hayvan hayvan = (Hayvan)clbHayvanlar.Items[i];
                    if (bakici1.Hayvanlar.Any(x => x.Id == hayvan.Id))
                    {
                        clbHayvanlar.SetItemChecked(i, true);
                    }
                }

            }
            
        }

        private void CinsiyetYukle()
        {
            cboHayvanCinsiyet.DataSource = Enum.GetValues(typeof(DataAnnotation.Enums.Cinsiyet));
        }

        private void YiyecekleriYukle()
        {
            cboHayvanFavoriYiyecek.DataSource = db.Yiyecekler.ToList();
            cboHayvanFavoriYiyecek.DisplayMember = "Ad";
            cboHayvanFavoriYiyecek.ValueMember = "Id";
        }

        private void BakicilariYukle()
        {
            clbBakicilar.DataSource = db.Bakicilar.OrderByDescending(x => x.Ad).ToList();
            clbBakicilar.DisplayMember = "Ad";
            clbBakicilar.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Ekle")
            {
                Hayvan hayvan = new Hayvan() { Bakicilar = new List<Bakici>() };
                if (txtHayvanAdi.Text == "" || txtHayvanTuru.Text == "" || cboHayvanCinsiyet.SelectedIndex < 0)
                {
                    MessageBox.Show("Zorunlu(*) alanlar boş bırakılamaz.");
                    return;
                }
                //|| clbBakicilar.CheckedItems.Count == 0 : Bakıcıyı zorunlu yapmak istersek

                hayvan.Ad = txtHayvanAdi.Text;
                hayvan.Tur = txtHayvanTuru.Text;
                hayvan.Cinsiyet = (DataAnnotation.Enums.Cinsiyet)cboHayvanCinsiyet.SelectedItem;
                hayvan.Kutle = nudHayvanKutle.Value;
                hayvan.SahibiVarMi = cbxHayvanSahibiVarMi.Checked;
                hayvan.DogumTarihi = dtpHayvanDogumTarihi.Value;
                hayvan.FavoriYiyecekId = ((Yiyecek)cboHayvanFavoriYiyecek.SelectedItem).Id;
                foreach (Bakici bakici in clbBakicilar.CheckedItems)
                {
                    hayvan.Bakicilar.Add(bakici);
                }
                db.Hayvanlar.Add(hayvan);
                db.SaveChanges();
                MessageBox.Show("Hayvan kaydedildi");
                HayvanEkleFormuTemizle();
            }

            if (btnEkle.Text == "Kaydet")
            {
                hayvan1.Ad = txtHayvanAdi.Text.Trim();
                hayvan1.Tur = txtHayvanTuru.Text.Trim();
                hayvan1.Kutle = (int)nudHayvanKutle.Value;
                hayvan1.FavoriYiyecekId = ((Yiyecek)cboHayvanFavoriYiyecek.SelectedItem).Id;
                hayvan1.Cinsiyet = (DataAnnotation.Enums.Cinsiyet)cboHayvanCinsiyet.SelectedItem;
                hayvan1.SahibiVarMi = cbxHayvanSahibiVarMi.Checked;
                hayvan1.DogumTarihi = dtpHayvanDogumTarihi.Value;
                
                foreach (Bakici bakici in clbBakicilar.CheckedItems)
                {
                    hayvan1.Bakicilar.Clear();
                    hayvan1.Bakicilar.Add(bakici);
                }
                
                db.SaveChanges();
                MessageBox.Show("Düzenleme kaydedildi");
                HayvanEkleFormuTemizle();
                Close();
            }
            
        }

        private void HayvanEkleFormuTemizle()
        {
            txtHayvanAdi.Clear();
            txtHayvanTuru.Clear();
            cboHayvanCinsiyet.SelectedIndex = -1;
            nudHayvanKutle.Value = 0;
            cboHayvanCinsiyet.SelectedIndex = -1;
            cboHayvanFavoriYiyecek.SelectedIndex = -1;
            dtpHayvanDogumTarihi.Value = DateTime.Now;
            clbBakicilar.ClearSelected();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBakiciEkle_Click(object sender, EventArgs e)
        {
            if (btnBakiciEkle.Text == "Ekle")
            {
                Bakici bakici = new Bakici() { Hayvanlar = new List<Hayvan>() };

                bakici.Ad = txtBakiciAd.Text;
                bakici.SoyAd = txtBakiciSoyAd.Text;
                foreach (Hayvan hayvan in clbHayvanlar.CheckedItems)
                {
                    bakici.Hayvanlar.Add(hayvan);
                }
                db.Bakicilar.Add(bakici);
                db.SaveChanges();
                MessageBox.Show("Bakici kaydedildi");
                BakiciFormuTemizle();
            }
            if (btnBakiciEkle.Text == "Düzenle")
            {
                bakici1.Ad = txtBakiciAd.Text;
                bakici1.SoyAd = txtBakiciSoyAd.Text;
                foreach (Hayvan hayvan in clbHayvanlar.CheckedItems)
                {
                    bakici1.Hayvanlar.Clear();
                    bakici1.Hayvanlar.Add(hayvan);
                }
                db.SaveChanges();
                MessageBox.Show("Düzenleme kaydedildi");
                BakiciFormuTemizle();
                Close();
            }
            
        }

        private void BakiciFormuTemizle()
        {
            txtBakiciAd.Clear();
            txtBakiciSoyAd.Clear();
            clbHayvanlar.ClearSelected();
        }

        private void btnBakiciIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYiyecekEkle_Click(object sender, EventArgs e)
        {
            if (txtYiyecekAd.Text == "" || dtpUretimTarihi.Value == null)
            {
                MessageBox.Show("Zorunlu(*) alanlar boş bırakılamaz");
            }
            Yiyecek yiyecek = new Yiyecek();
            yiyecek.Ad = txtYiyecekAd.Text.Trim();
            yiyecek.UretimTarihi = dtpUretimTarihi.Value;
            yiyecek.SonKullanmaTarihi = dtpSonKullanmaTarihi.Value;
            yiyecek.Kalori = nudYiyecekKalori.Value;

            db.Yiyecekler.Add(yiyecek);
            db.SaveChanges();
            MessageBox.Show("Yiyecek kaydedildi");
            YiyecekFormuTemizle();
            FormuGuncelle();
        }

        private void FormuGuncelle()
        {
            cboHayvanFavoriYiyecek.DataSource = null;
            cboHayvanFavoriYiyecek.DataSource = db.Yiyecekler.OrderByDescending(x => x.Ad).ToList();
            cboHayvanFavoriYiyecek.DisplayMember = "Ad";

            clbHayvanlar.DataSource = null;
            clbHayvanlar.DataSource = db.Hayvanlar.OrderByDescending(x => x.Ad).ToList();
            clbHayvanlar.DisplayMember = "Ad";

            clbBakicilar.DataSource = null;
            clbBakicilar.DataSource = db.Bakicilar.OrderByDescending(x => x.Ad).ToList();
            clbBakicilar.DisplayMember = "Ad";
        }

        private void YiyecekFormuTemizle()
        {
            txtYiyecekAd.Clear();
            dtpUretimTarihi.Value = DateTime.Now;
            dtpSonKullanmaTarihi.Value = DateTime.Now;
            nudYiyecekKalori.Value = 0;
        }

        private void btnYiyecekIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
