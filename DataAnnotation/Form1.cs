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
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public Form1()
        {
            InitializeComponent();
            HayvanlariYukle();

        }

        private void HayvanlariYukle()
        {
            dgvHayvanlar.DataSource = db.Hayvanlar.ToList();
            db.SaveChanges();
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            Hayvan hayvan2 = new Hayvan();
            hayvan2 = null;
            Bakici bakici2 = new Bakici();
            bakici2 = null;
            HayvanEkle hv = new HayvanEkle(db, hayvan2, bakici2);
            hv.ShowDialog();
            HayvanlariYukle();
        }

        private void dgvHayvanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHayvanlar.SelectedRows.Count == 0)
            {
                dgvBakicilar.DataSource = null;
                return;
            }
            int id = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
            Hayvan hayvan = db.Hayvanlar.Find(id);

            dgvBakicilar.DataSource = null;
            dgvBakicilar.DataSource = hayvan.Bakicilar.Select(x => new
            {
                x.Id,
                x.Ad,
                x.SoyAd,
                Hayvanlar = string.Join(", ", x.Hayvanlar.Select(g => g.Ad))
            }).ToList();

            if (hayvan.Yiyecek == null)
            {
                lblSevdigiYiyecek.Text = "";
                return;
            }

            lblSevdigiYiyecek.Text = hayvan.Yiyecek.Ad;
        }

        private void dgvHayvanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
            Hayvan hayvan = db.Hayvanlar.Find(id);
            Bakici bakici = new Bakici();
            bakici = null;
            HayvanEkle hv = new HayvanEkle(db, hayvan, bakici);
            hv.ShowDialog();
            HayvanlariYukle();

        }

        private void dgvBakicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hayvan hayvan = new Hayvan();
            hayvan = null;
            int id2 = (int)dgvBakicilar.SelectedRows[0].Cells[0].Value;
            Bakici bakici = (Bakici)db.Bakicilar.Find(id2);
            HayvanEkle he2 = new HayvanEkle(db, hayvan, bakici);
            he2.ShowDialog();

        }

        private void dgvHayvanlar_KeyDown(object sender, KeyEventArgs e)
        {
            int id = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
            Hayvan hayvan = db.Hayvanlar.Find(id);
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI!!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    db.Hayvanlar.Remove(hayvan);
                    db.SaveChanges();
                    HayvanlariYukle();
                }
                else if (dr == DialogResult.No)
                {
                    return;

                }
            }
        }

        private void dgvBakicilar_KeyDown(object sender, KeyEventArgs e)
        {
            int id = (int)dgvBakicilar.SelectedRows[0].Cells[0].Value;
            Bakici bakici = (Bakici)db.Bakicilar.Find(id);
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI!!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.Bakicilar.Remove(bakici);
                    db.SaveChanges();
                    HayvanlariYukle();
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }

            }
        }
    }
}