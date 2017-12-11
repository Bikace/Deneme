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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        KuzeyYeliContext ctx = new KuzeyYeliContext();
        public static string gonderilecekveri;

        private bool kullanicidogrula(string kAdi, string kParola)
        {

            var sorgu = from p in ctx.kullanicilars
                        where p.kullaniciAdi == kAdi
                         && p.sifre == kParola
                        select p;
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (kullanicidogrula(txtkAdi.Text, txtParola.Text))
            {
                Form1 f1 = new Form1();
                gonderilecekveri = txtkAdi.Text;
                this.Visible = false;
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
