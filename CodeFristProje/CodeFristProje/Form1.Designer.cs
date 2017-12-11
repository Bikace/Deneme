namespace CodeFristProje
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txturunAdi = new System.Windows.Forms.TextBox();
            this.numFiyt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdbFiyataGoreArtan = new System.Windows.Forms.RadioButton();
            this.rdbFiyataGoreAzalan = new System.Windows.Forms.RadioButton();
            this.btnilkOnKayit = new System.Windows.Forms.Button();
            this.btnRaporFormunuAc = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblgelenveri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(479, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 304);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txturunAdi
            // 
            this.txturunAdi.Location = new System.Drawing.Point(12, 50);
            this.txturunAdi.Name = "txturunAdi";
            this.txturunAdi.Size = new System.Drawing.Size(100, 20);
            this.txturunAdi.TabIndex = 2;
            // 
            // numFiyt
            // 
            this.numFiyt.Location = new System.Drawing.Point(118, 50);
            this.numFiyt.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numFiyt.Name = "numFiyt";
            this.numFiyt.Size = new System.Drawing.Size(70, 20);
            this.numFiyt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat";
            // 
            // numStok
            // 
            this.numStok.Location = new System.Drawing.Point(194, 50);
            this.numStok.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(70, 20);
            this.numStok.TabIndex = 6;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(376, 48);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(97, 21);
            this.cmbTedarikci.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tedarikçi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(270, 48);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(97, 21);
            this.cmbKategori.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürün Adına Göre Arayınız:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(15, 400);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(129, 20);
            this.txtAra.TabIndex = 16;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // rdbFiyataGoreArtan
            // 
            this.rdbFiyataGoreArtan.AutoSize = true;
            this.rdbFiyataGoreArtan.Checked = true;
            this.rdbFiyataGoreArtan.Location = new System.Drawing.Point(150, 401);
            this.rdbFiyataGoreArtan.Name = "rdbFiyataGoreArtan";
            this.rdbFiyataGoreArtan.Size = new System.Drawing.Size(107, 17);
            this.rdbFiyataGoreArtan.TabIndex = 17;
            this.rdbFiyataGoreArtan.TabStop = true;
            this.rdbFiyataGoreArtan.Text = "Fiyata Göre Artan";
            this.rdbFiyataGoreArtan.UseVisualStyleBackColor = true;
            this.rdbFiyataGoreArtan.CheckedChanged += new System.EventHandler(this.rdbFiyataGoreArtan_CheckedChanged);
            // 
            // rdbFiyataGoreAzalan
            // 
            this.rdbFiyataGoreAzalan.AutoSize = true;
            this.rdbFiyataGoreAzalan.Location = new System.Drawing.Point(263, 401);
            this.rdbFiyataGoreAzalan.Name = "rdbFiyataGoreAzalan";
            this.rdbFiyataGoreAzalan.Size = new System.Drawing.Size(114, 17);
            this.rdbFiyataGoreAzalan.TabIndex = 18;
            this.rdbFiyataGoreAzalan.Text = "Fiyata Göre Azalan";
            this.rdbFiyataGoreAzalan.UseVisualStyleBackColor = true;
            this.rdbFiyataGoreAzalan.CheckedChanged += new System.EventHandler(this.rdbFiyataGoreAzalan_CheckedChanged);
            // 
            // btnilkOnKayit
            // 
            this.btnilkOnKayit.Location = new System.Drawing.Point(402, 395);
            this.btnilkOnKayit.Name = "btnilkOnKayit";
            this.btnilkOnKayit.Size = new System.Drawing.Size(71, 23);
            this.btnilkOnKayit.TabIndex = 19;
            this.btnilkOnKayit.Text = "İlk On Kayıt";
            this.btnilkOnKayit.UseVisualStyleBackColor = true;
            this.btnilkOnKayit.Click += new System.EventHandler(this.btnilkOnKayit_Click);
            // 
            // btnRaporFormunuAc
            // 
            this.btnRaporFormunuAc.Location = new System.Drawing.Point(513, 395);
            this.btnRaporFormunuAc.Name = "btnRaporFormunuAc";
            this.btnRaporFormunuAc.Size = new System.Drawing.Size(144, 23);
            this.btnRaporFormunuAc.TabIndex = 20;
            this.btnRaporFormunuAc.Text = "Rapor Formunu Aç";
            this.btnRaporFormunuAc.UseVisualStyleBackColor = true;
            this.btnRaporFormunuAc.Click += new System.EventHandler(this.btnRaporFormunuAc_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(569, 46);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 23);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblgelenveri
            // 
            this.lblgelenveri.AutoSize = true;
            this.lblgelenveri.Location = new System.Drawing.Point(12, 13);
            this.lblgelenveri.Name = "lblgelenveri";
            this.lblgelenveri.Size = new System.Drawing.Size(0, 13);
            this.lblgelenveri.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 438);
            this.Controls.Add(this.lblgelenveri);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnRaporFormunuAc);
            this.Controls.Add(this.btnilkOnKayit);
            this.Controls.Add(this.rdbFiyataGoreAzalan);
            this.Controls.Add(this.rdbFiyataGoreArtan);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.numStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFiyt);
            this.Controls.Add(this.txturunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFiyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txturunAdi;
        private System.Windows.Forms.NumericUpDown numFiyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton rdbFiyataGoreArtan;
        private System.Windows.Forms.RadioButton rdbFiyataGoreAzalan;
        private System.Windows.Forms.Button btnilkOnKayit;
        private System.Windows.Forms.Button btnRaporFormunuAc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblgelenveri;
    }
}

