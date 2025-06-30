namespace ÇiçekçiApp
{
    partial class AnaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMusteriler = new System.Windows.Forms.TabPage();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.groupBoxMusteriIslemleri = new System.Windows.Forms.GroupBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.tabPageUrunler = new System.Windows.Forms.TabPage();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.groupBoxUrunIslemleri = new System.Windows.Forms.GroupBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.btnUrunTemizle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.tabPageSatis = new System.Windows.Forms.TabPage();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSatisTamamla = new System.Windows.Forms.Button();
            this.btnSatisTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.txtSatisMiktar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSatisUrun = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvSatisSepet = new System.Windows.Forms.DataGridView();
            this.cmbSatisMusteri = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageMusteriler.SuspendLayout();
            this.groupBoxMusteriIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tabPageUrunler.SuspendLayout();
            this.groupBoxUrunIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.tabPageSatis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMusteriler);
            this.tabControl1.Controls.Add(this.tabPageUrunler);
            this.tabControl1.Controls.Add(this.tabPageSatis);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMusteriler
            // 
            this.tabPageMusteriler.Controls.Add(this.btnMusteriAra);
            this.tabPageMusteriler.Controls.Add(this.txtMusteriAra);
            this.tabPageMusteriler.Controls.Add(this.groupBoxMusteriIslemleri);
            this.tabPageMusteriler.Controls.Add(this.dgvMusteriler);
            this.tabPageMusteriler.Location = new System.Drawing.Point(4, 22);
            this.tabPageMusteriler.Name = "tabPageMusteriler";
            this.tabPageMusteriler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMusteriler.Size = new System.Drawing.Size(976, 635);
            this.tabPageMusteriler.TabIndex = 0;
            this.tabPageMusteriler.Text = "Müşteriler";
            this.tabPageMusteriler.UseVisualStyleBackColor = true;
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(893, 8);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriAra.TabIndex = 3;
            this.btnMusteriAra.Text = "Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(314, 10);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(573, 20);
            this.txtMusteriAra.TabIndex = 2;
            // 
            // groupBoxMusteriIslemleri
            // 
            this.groupBoxMusteriIslemleri.Controls.Add(this.lblMusteriID);
            this.groupBoxMusteriIslemleri.Controls.Add(this.btnTemizle);
            this.groupBoxMusteriIslemleri.Controls.Add(this.btnSil);
            this.groupBoxMusteriIslemleri.Controls.Add(this.btnGuncelle);
            this.groupBoxMusteriIslemleri.Controls.Add(this.btnEkle);
            this.groupBoxMusteriIslemleri.Controls.Add(this.txtAdres);
            this.groupBoxMusteriIslemleri.Controls.Add(this.label5);
            this.groupBoxMusteriIslemleri.Controls.Add(this.txtEmail);
            this.groupBoxMusteriIslemleri.Controls.Add(this.label4);
            this.groupBoxMusteriIslemleri.Controls.Add(this.txtTelefon);
            this.groupBoxMusteriIslemleri.Controls.Add(this.label3);
            this.groupBoxMusteriIslemleri.Controls.Add(this.txtSoyad);
            this.groupBoxMusteriIslemleri.Controls.Add(this.label2);
            this.groupBoxMusteriIslemleri.Controls.Add(this.txtAd);
            this.groupBoxMusteriIslemleri.Controls.Add(this.label1);
            this.groupBoxMusteriIslemleri.Location = new System.Drawing.Point(8, 6);
            this.groupBoxMusteriIslemleri.Name = "groupBoxMusteriIslemleri";
            this.groupBoxMusteriIslemleri.Size = new System.Drawing.Size(300, 300);
            this.groupBoxMusteriIslemleri.TabIndex = 1;
            this.groupBoxMusteriIslemleri.TabStop = false;
            this.groupBoxMusteriIslemleri.Text = "Müşteri Bilgileri";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(90, 16);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriID.TabIndex = 14;
            this.lblMusteriID.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(155, 260);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 23);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(25, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(155, 230);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(25, 230);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(90, 155);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(185, 60);
            this.txtAdres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(90, 95);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(185, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(90, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(90, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(314, 38);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(654, 589);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // tabPageUrunler
            // 
            this.tabPageUrunler.Controls.Add(this.btnUrunAra);
            this.tabPageUrunler.Controls.Add(this.txtUrunAra);
            this.tabPageUrunler.Controls.Add(this.groupBoxUrunIslemleri);
            this.tabPageUrunler.Controls.Add(this.dgvUrunler);
            this.tabPageUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunler.Name = "tabPageUrunler";
            this.tabPageUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunler.Size = new System.Drawing.Size(976, 635);
            this.tabPageUrunler.TabIndex = 1;
            this.tabPageUrunler.Text = "Ürünler";
            this.tabPageUrunler.UseVisualStyleBackColor = true;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(893, 8);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(75, 23);
            this.btnUrunAra.TabIndex = 7;
            this.btnUrunAra.Text = "Ara";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(314, 10);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(573, 20);
            this.txtUrunAra.TabIndex = 6;
            // 
            // groupBoxUrunIslemleri
            // 
            this.groupBoxUrunIslemleri.Controls.Add(this.lblUrunID);
            this.groupBoxUrunIslemleri.Controls.Add(this.btnUrunTemizle);
            this.groupBoxUrunIslemleri.Controls.Add(this.btnUrunSil);
            this.groupBoxUrunIslemleri.Controls.Add(this.btnUrunGuncelle);
            this.groupBoxUrunIslemleri.Controls.Add(this.btnUrunEkle);
            this.groupBoxUrunIslemleri.Controls.Add(this.txtUrunAciklama);
            this.groupBoxUrunIslemleri.Controls.Add(this.label6);
            this.groupBoxUrunIslemleri.Controls.Add(this.txtStokMiktari);
            this.groupBoxUrunIslemleri.Controls.Add(this.label7);
            this.groupBoxUrunIslemleri.Controls.Add(this.txtFiyat);
            this.groupBoxUrunIslemleri.Controls.Add(this.label8);
            this.groupBoxUrunIslemleri.Controls.Add(this.txtKategori);
            this.groupBoxUrunIslemleri.Controls.Add(this.label9);
            this.groupBoxUrunIslemleri.Controls.Add(this.txtUrunAdi);
            this.groupBoxUrunIslemleri.Controls.Add(this.label10);
            this.groupBoxUrunIslemleri.Location = new System.Drawing.Point(8, 6);
            this.groupBoxUrunIslemleri.Name = "groupBoxUrunIslemleri";
            this.groupBoxUrunIslemleri.Size = new System.Drawing.Size(300, 300);
            this.groupBoxUrunIslemleri.TabIndex = 5;
            this.groupBoxUrunIslemleri.TabStop = false;
            this.groupBoxUrunIslemleri.Text = "Ürün Bilgileri";
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(90, 16);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(0, 13);
            this.lblUrunID.TabIndex = 14;
            this.lblUrunID.Visible = false;
            // 
            // btnUrunTemizle
            // 
            this.btnUrunTemizle.Location = new System.Drawing.Point(155, 260);
            this.btnUrunTemizle.Name = "btnUrunTemizle";
            this.btnUrunTemizle.Size = new System.Drawing.Size(120, 23);
            this.btnUrunTemizle.TabIndex = 13;
            this.btnUrunTemizle.Text = "Formu Temizle";
            this.btnUrunTemizle.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(25, 260);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(120, 23);
            this.btnUrunSil.TabIndex = 12;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(155, 230);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(120, 23);
            this.btnUrunGuncelle.TabIndex = 11;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(25, 230);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(120, 23);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(90, 155);
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(185, 60);
            this.txtUrunAciklama.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Açıklama";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(90, 125);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(185, 20);
            this.txtStokMiktari.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stok Miktarı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(90, 95);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(185, 20);
            this.txtFiyat.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fiyat";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(90, 65);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(185, 20);
            this.txtKategori.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kategori";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(90, 35);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(185, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Adı";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(314, 38);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(654, 589);
            this.dgvUrunler.TabIndex = 4;
            // 
            // tabPageSatis
            // 
            this.tabPageSatis.Controls.Add(this.txtSatisToplam);
            this.tabPageSatis.Controls.Add(this.label13);
            this.tabPageSatis.Controls.Add(this.btnSatisTamamla);
            this.tabPageSatis.Controls.Add(this.btnSatisTemizle);
            this.tabPageSatis.Controls.Add(this.groupBox1);
            this.tabPageSatis.Controls.Add(this.dgvSatisSepet);
            this.tabPageSatis.Controls.Add(this.cmbSatisMusteri);
            this.tabPageSatis.Controls.Add(this.label14);
            this.tabPageSatis.Location = new System.Drawing.Point(4, 22);
            this.tabPageSatis.Name = "tabPageSatis";
            this.tabPageSatis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSatis.Size = new System.Drawing.Size(976, 635);
            this.tabPageSatis.TabIndex = 2;
            this.tabPageSatis.Text = "Satış Yap";
            this.tabPageSatis.UseVisualStyleBackColor = true;
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisToplam.Location = new System.Drawing.Point(828, 565);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.ReadOnly = true;
            this.txtSatisToplam.Size = new System.Drawing.Size(140, 26);
            this.txtSatisToplam.TabIndex = 7;
            this.txtSatisToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(676, 568);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "TOPLAM TUTAR:";
            // 
            // btnSatisTamamla
            // 
            this.btnSatisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisTamamla.Location = new System.Drawing.Point(828, 597);
            this.btnSatisTamamla.Name = "btnSatisTamamla";
            this.btnSatisTamamla.Size = new System.Drawing.Size(140, 30);
            this.btnSatisTamamla.TabIndex = 5;
            this.btnSatisTamamla.Text = "Satışı Tamamla";
            this.btnSatisTamamla.UseVisualStyleBackColor = true;
            // 
            // btnSatisTemizle
            // 
            this.btnSatisTemizle.Location = new System.Drawing.Point(8, 597);
            this.btnSatisTemizle.Name = "btnSatisTemizle";
            this.btnSatisTemizle.Size = new System.Drawing.Size(140, 30);
            this.btnSatisTemizle.TabIndex = 4;
            this.btnSatisTemizle.Text = "Yeni Satış (Temizle)";
            this.btnSatisTemizle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatisEkle);
            this.groupBox1.Controls.Add(this.txtSatisMiktar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbSatisUrun);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Seçimi";
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.Location = new System.Drawing.Point(834, 23);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(120, 23);
            this.btnSatisEkle.TabIndex = 4;
            this.btnSatisEkle.Text = "Sepete Ekle";
            this.btnSatisEkle.UseVisualStyleBackColor = true;
            // 
            // txtSatisMiktar
            // 
            this.txtSatisMiktar.Location = new System.Drawing.Point(620, 25);
            this.txtSatisMiktar.Name = "txtSatisMiktar";
            this.txtSatisMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtSatisMiktar.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(575, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Miktar:";
            // 
            // cmbSatisUrun
            // 
            this.cmbSatisUrun.FormattingEnabled = true;
            this.cmbSatisUrun.Location = new System.Drawing.Point(75, 25);
            this.cmbSatisUrun.Name = "cmbSatisUrun";
            this.cmbSatisUrun.Size = new System.Drawing.Size(450, 21);
            this.cmbSatisUrun.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Seç:";
            // 
            // dgvSatisSepet
            // 
            this.dgvSatisSepet.AllowUserToAddRows = false;
            this.dgvSatisSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisSepet.Location = new System.Drawing.Point(8, 131);
            this.dgvSatisSepet.Name = "dgvSatisSepet";
            this.dgvSatisSepet.ReadOnly = true;
            this.dgvSatisSepet.Size = new System.Drawing.Size(960, 428);
            this.dgvSatisSepet.TabIndex = 2;
            // 
            // cmbSatisMusteri
            // 
            this.cmbSatisMusteri.FormattingEnabled = true;
            this.cmbSatisMusteri.Location = new System.Drawing.Point(83, 20);
            this.cmbSatisMusteri.Name = "cmbSatisMusteri";
            this.cmbSatisMusteri.Size = new System.Drawing.Size(450, 21);
            this.cmbSatisMusteri.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Müşteri Seç:";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Çiçekçi Yönetim Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMusteriler.ResumeLayout(false);
            this.tabPageMusteriler.PerformLayout();
            this.groupBoxMusteriIslemleri.ResumeLayout(false);
            this.groupBoxMusteriIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tabPageUrunler.ResumeLayout(false);
            this.tabPageUrunler.PerformLayout();
            this.groupBoxUrunIslemleri.ResumeLayout(false);
            this.groupBoxUrunIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.tabPageSatis.ResumeLayout(false);
            this.tabPageSatis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMusteriler;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.TabPage tabPageUrunler;
        private System.Windows.Forms.TabPage tabPageSatis;
        private System.Windows.Forms.GroupBox groupBoxMusteriIslemleri;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.GroupBox groupBoxUrunIslemleri;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Button btnUrunTemizle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridView dgvSatisSepet;
        private System.Windows.Forms.ComboBox cmbSatisMusteri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.TextBox txtSatisMiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSatisUrun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSatisTamamla;
        private System.Windows.Forms.Button btnSatisTemizle;
    }
} 