namespace CodeFristProje
{
    partial class RaporForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatisRaporu = new System.Windows.Forms.Button();
            this.btnTedarikciKategoriRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSatisRaporu
            // 
            this.btnSatisRaporu.Location = new System.Drawing.Point(13, 13);
            this.btnSatisRaporu.Name = "btnSatisRaporu";
            this.btnSatisRaporu.Size = new System.Drawing.Size(119, 23);
            this.btnSatisRaporu.TabIndex = 1;
            this.btnSatisRaporu.Text = "Ürün Satış Raporu";
            this.btnSatisRaporu.UseVisualStyleBackColor = true;
            this.btnSatisRaporu.Click += new System.EventHandler(this.btnSatisRaporu_Click);
            // 
            // btnTedarikciKategoriRaporu
            // 
            this.btnTedarikciKategoriRaporu.Location = new System.Drawing.Point(138, 14);
            this.btnTedarikciKategoriRaporu.Name = "btnTedarikciKategoriRaporu";
            this.btnTedarikciKategoriRaporu.Size = new System.Drawing.Size(119, 23);
            this.btnTedarikciKategoriRaporu.TabIndex = 2;
            this.btnTedarikciKategoriRaporu.Text = "Tedarikçi Kategori Raporu";
            this.btnTedarikciKategoriRaporu.UseVisualStyleBackColor = true;
            this.btnTedarikciKategoriRaporu.Click += new System.EventHandler(this.btnTedarikciKategoriRaporu_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 329);
            this.Controls.Add(this.btnTedarikciKategoriRaporu);
            this.Controls.Add(this.btnSatisRaporu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatisRaporu;
        private System.Windows.Forms.Button btnTedarikciKategoriRaporu;
    }
}