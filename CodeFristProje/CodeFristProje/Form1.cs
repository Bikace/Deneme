using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFristProje
{
    using Models;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KuzeyYeliContext ctx = new KuzeyYeliContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
            lblgelenveri.Text = GirisFormu.gonderilecekveri;
            
            dataGridView1.DataSource = ctx.Urunlers.ToList();

            cmbKategori.DataSource = ctx.Kategorilers.ToList();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";

            cmbTedarikci.DataSource = ctx.Tedarikcilers.ToList();
            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";

        }
        void UrunListele()
        {
            var urunler =  ctx.Urunlers.Join(
                ctx.Kategorilers,
                u => u.KategoriID,
                k => k.KategoriID,
                (urun, ktg) => new 
                {
                    urun,
                    ktg.KategoriAdi
                }).Join(
                ctx.Tedarikcilers,
                uk => uk.urun.TedarikciID,
                t => t.TedarikciID,
                (urun,ted) => new 
                {
                    urun.urun.UrunID,
                    urun.urun.UrunAdi,
                    urun.urun.Fiyat,
                    urun.urun.Stok,
                    urun.KategoriAdi,
                    ted.SirketAdi,
                    urun.urun.TedarikciID,
                    urun.urun.KategoriID
                }).OrderBy(x => x.Fiyat).ToList();

            dataGridView1.DataSource = urunler;
            dataGridView1.Columns["TedarikciID"].Visible = dataGridView1.Columns["KategoriID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Urunler u = new Urunler();
            u.UrunAdi = txturunAdi.Text;
            u.Fiyat = numFiyt.Value;
            u.Stok = Convert.ToInt16(numStok.Value);
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID = (int)cmbTedarikci.SelectedValue;

            ctx.Urunlers.Add(u);
            ctx.SaveChanges();
            dataGridView1.DataSource = ctx.Urunlers.ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            dataGridView1.DataSource = ctx.Urunlers.Where(x => x.UrunAdi.Contains(ara)).ToList();
        }

        private void rdbFiyataGoreArtan_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFiyataGoreArtan.Checked)
            {
                dataGridView1.DataSource = ctx.Urunlers.OrderBy(x => x.Fiyat).ToList();
            }
        }

        private void rdbFiyataGoreAzalan_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFiyataGoreAzalan.Checked)
            {
                dataGridView1.DataSource = ctx.Urunlers.OrderByDescending(x => x.Fiyat).ToList();
            }
        }

        private void btnilkOnKayit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Urunlers.Take(10).ToList();
        }

        private void btnRaporFormunuAc_Click(object sender, EventArgs e)
        {
            RaporForm rf = new RaporForm();
            rf.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçili Kayıt Silinsin Mi?", "Kayıt Silme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;

                Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID==id);
                ctx.Urunlers.Remove(u);
                ctx.SaveChanges();
                UrunListele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txturunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
            numFiyt.Value = (decimal)row.Cells["Fiyat"].Value;
            numStok.Value = Convert.ToDecimal( row.Cells["Stok"].Value);
            cmbKategori.SelectedValue = row.Cells["KategoriID"].Value;
            cmbTedarikci.SelectedValue = row.Cells["TedarikciID"].Value;
            txturunAdi.Tag = row.Cells["UrunID"].Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)txturunAdi.Tag;
            Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            u.UrunAdi = txturunAdi.Text;
            u.Fiyat = numFiyt.Value;
            u.Stok = Convert.ToInt16(numStok.Value);
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID = (int)cmbTedarikci.SelectedValue;

            ctx.SaveChanges();
            UrunListele();
        }
    }
}
