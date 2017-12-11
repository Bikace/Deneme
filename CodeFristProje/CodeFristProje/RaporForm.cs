using CodeFristProje.Models;
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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        KuzeyYeliContext context = new KuzeyYeliContext();
        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Urunlers.Join(
                context.SatisDetays,
                u => u.UrunID,
                sd => sd.UrunID,
                (u, sd) => new
                {
                    u.UrunAdi,
                    sd.Adet,
                    sd.Fiyat,
                    sd.Indirim
                }).GroupBy(x => x.UrunAdi).Select(x => new 
                {
                    x.Key,
                    ToplamSatisTutari = x.Sum(y => y.Adet*y.Fiyat),
                    ToplamAdet=x.Sum(y => y.Adet)
                }).ToList(); 
        }

        private void btnTedarikciKategoriRaporu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Urunlers.Join(
                context.SatisDetays,
                u => u.UrunID,
                sd => sd.UrunID,
                (u,sd) =>  new 
                {
                    u.Kategoriler,
                    u.Tedarikciler,
                    sd.Adet,
                    sd.Fiyat
                }).
                GroupBy(x => new
            {
                x.Kategoriler.KategoriAdi,
                x.Tedarikciler.SirketAdi
            }).Select(x => new 
            {
                x.Key.SirketAdi,
                x.Key.KategoriAdi,
                ToplamTutar = x.Sum(y => y.Adet*y.Fiyat),
                ToplamAdet = x.Sum(y => y.Adet)
            }).ToList();

            dataGridView1.Columns["ToplamTutar"].HeaderText = "Toplam Tutarı";

        }
    }
}