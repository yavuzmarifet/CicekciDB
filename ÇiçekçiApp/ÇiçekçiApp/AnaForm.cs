using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ÇiçekçiApp
{
    public partial class AnaForm : Form
    {
        private DataTable satisSepetTable = new DataTable();

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            // Müşteri Sekmesi
            MusterileriYukle();
            btnEkle.Click += new EventHandler(btnEkle_Click);
            btnGuncelle.Click += new EventHandler(btnGuncelle_Click);
            btnSil.Click += new EventHandler(btnSil_Click);
            btnTemizle.Click += new EventHandler(btnTemizle_Click);
            btnMusteriAra.Click += new EventHandler(btnMusteriAra_Click);
            dgvMusteriler.CellClick += new DataGridViewCellEventHandler(dgvMusteriler_CellClick);
            
            // Ürünler Sekmesi
            UrunleriYukle();
            btnUrunEkle.Click += new EventHandler(btnUrunEkle_Click);
            btnUrunGuncelle.Click += new EventHandler(btnUrunGuncelle_Click);
            btnUrunSil.Click += new EventHandler(btnUrunSil_Click);
            btnUrunTemizle.Click += new EventHandler(btnUrunTemizle_Click);
            btnUrunAra.Click += new EventHandler(btnUrunAra_Click);
            dgvUrunler.CellClick += new DataGridViewCellEventHandler(dgvUrunler_CellClick);

            // Satış Sekmesi
            SatisSekmesiniHazirla();
        }

        #region Müşteri Metotları
        private void MusterileriYukle(string aramaMetni = null)
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    string sorgu = aramaMetni == null ? "MusteriListele" : "MusteriAra";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        if (aramaMetni != null)
                        {
                            komut.Parameters.AddWithValue("@p_AramaMetni", aramaMetni);
                        }
                        
                        using (var adapter = new MySqlDataAdapter(komut))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvMusteriler.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    baglanti.Open();
                    using (var komut = new MySqlCommand("MusteriEkle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@p_Ad", txtAd.Text);
                        komut.Parameters.AddWithValue("@p_Soyad", txtSoyad.Text);
                        komut.Parameters.AddWithValue("@p_Telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@p_Email", txtEmail.Text);
                        komut.Parameters.AddWithValue("@p_Adres", txtAdres.Text);
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Müşteri başarıyla eklendi.");
                MusterileriYukle();
                FormuTemizle();
                SatisMusteriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMusteriID.Text)) { MessageBox.Show("Lütfen bir müşteri seçin."); return; }
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    using (var komut = new MySqlCommand("MusteriGuncelle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@p_MusteriID", Convert.ToInt32(lblMusteriID.Text));
                        komut.Parameters.AddWithValue("@p_Ad", txtAd.Text);
                        komut.Parameters.AddWithValue("@p_Soyad", txtSoyad.Text);
                        komut.Parameters.AddWithValue("@p_Telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@p_Email", txtEmail.Text);
                        komut.Parameters.AddWithValue("@p_Adres", txtAdres.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Müşteri başarıyla güncellendi.");
                MusterileriYukle();
                FormuTemizle();
                SatisMusteriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMusteriID.Text)) { MessageBox.Show("Lütfen bir müşteri seçin."); return; }
            if (MessageBox.Show("Bu müşteriyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.GetConnection())
                    {
                        using (var komut = new MySqlCommand("MusteriSil", baglanti))
                        {
                            komut.CommandType = CommandType.StoredProcedure;
                            komut.Parameters.AddWithValue("@p_MusteriID", Convert.ToInt32(lblMusteriID.Text));
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    MusterileriYukle();
                    FormuTemizle();
                    SatisMusteriYukle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];
                lblMusteriID.Text = row.Cells["MusteriID"].Value.ToString();
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }
        
        private void btnTemizle_Click(object sender, EventArgs e) { FormuTemizle(); }
        private void btnMusteriAra_Click(object sender, EventArgs e) { MusterileriYukle(txtMusteriAra.Text); }
        private void FormuTemizle()
        {
            lblMusteriID.Text = "";
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Text = "";
            txtMusteriAra.Clear();
            dgvMusteriler.ClearSelection();
        }
        #endregion

        #region Ürün Metotları
        private void UrunleriYukle(string aramaMetni = null)
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    string sorgu = aramaMetni == null ? "UrunListele" : "UrunAra"; 
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        if (aramaMetni != null)
                        {
                             komut.Parameters.AddWithValue("@p_AramaMetni", aramaMetni);
                        }
                        using (var adapter = new MySqlDataAdapter(komut))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvUrunler.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
             try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    using (var komut = new MySqlCommand("UrunEkle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@p_UrunAdi", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@p_Kategori", txtKategori.Text);
                        komut.Parameters.AddWithValue("@p_Fiyat", Convert.ToDecimal(txtFiyat.Text));
                        komut.Parameters.AddWithValue("@p_StokMiktari", Convert.ToInt32(txtStokMiktari.Text));
                        komut.Parameters.AddWithValue("@p_Aciklama", txtUrunAciklama.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla eklendi.");
                UrunleriYukle();
                UrunFormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblUrunID.Text)) { MessageBox.Show("Lütfen bir ürün seçin."); return; }
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    using (var komut = new MySqlCommand("UrunGuncelle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@p_UrunID", Convert.ToInt32(lblUrunID.Text));
                        komut.Parameters.AddWithValue("@p_UrunAdi", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@p_Kategori", txtKategori.Text);
                        komut.Parameters.AddWithValue("@p_Fiyat", Convert.ToDecimal(txtFiyat.Text));
                        komut.Parameters.AddWithValue("@p_StokMiktari", Convert.ToInt32(txtStokMiktari.Text));
                        komut.Parameters.AddWithValue("@p_Aciklama", txtUrunAciklama.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla güncellendi.");
                UrunleriYukle();
                UrunFormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblUrunID.Text)) { MessageBox.Show("Lütfen bir ürün seçin."); return; }
            if (MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.GetConnection())
                    {
                        using (var komut = new MySqlCommand("UrunSil", baglanti))
                        {
                            komut.CommandType = CommandType.StoredProcedure;
                            komut.Parameters.AddWithValue("@p_UrunID", Convert.ToInt32(lblUrunID.Text));
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Ürün başarıyla silindi.");
                    UrunleriYukle();
                    UrunFormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        
        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];
                lblUrunID.Text = row.Cells["UrunID"].Value.ToString();
                txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
                txtKategori.Text = row.Cells["Kategori"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                txtStokMiktari.Text = row.Cells["StokMiktari"].Value.ToString();
                txtUrunAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            }
        }

        private void btnUrunTemizle_Click(object sender, EventArgs e) { UrunFormuTemizle(); }
        private void btnUrunAra_Click(object sender, EventArgs e) { UrunleriYukle(txtUrunAra.Text); }
        private void UrunFormuTemizle()
        {
            lblUrunID.Text = "";
            txtUrunAdi.Clear();
            txtKategori.Clear();
            txtFiyat.Clear();
            txtStokMiktari.Clear();
            txtUrunAciklama.Clear();
            txtUrunAra.Clear();
            dgvUrunler.ClearSelection();
        }

        #endregion

        #region Satış Metotları
        private void SatisSekmesiniHazirla()
        {
            satisSepetTable.Columns.Add("UrunID", typeof(int));
            satisSepetTable.Columns.Add("UrunAdi", typeof(string));
            satisSepetTable.Columns.Add("Miktar", typeof(int));
            satisSepetTable.Columns.Add("BirimFiyat", typeof(decimal));
            satisSepetTable.Columns.Add("Tutar", typeof(decimal), "Miktar * BirimFiyat");
            dgvSatisSepet.DataSource = satisSepetTable;

            SatisMusteriYukle();
            SatisUrunYukle();
            
            btnSatisEkle.Click += btnSatisEkle_Click;
            btnSatisTamamla.Click += btnSatisTamamla_Click;
            btnSatisTemizle.Click += btnSatisTemizle_Click;
        }

        private void SatisMusteriYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    using (var komut = new MySqlCommand("MusteriListele", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        using (var adapter = new MySqlDataAdapter(komut))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            cmbSatisMusteri.DataSource = dt;
                            cmbSatisMusteri.DisplayMember = "Ad";
                            cmbSatisMusteri.ValueMember = "MusteriID";
                            cmbSatisMusteri.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("Müşteriler yüklenemedi: " + ex.Message); }
        }

        private void SatisUrunYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    using (var komut = new MySqlCommand("UrunListele", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        using (var adapter = new MySqlDataAdapter(komut))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            cmbSatisUrun.DataSource = dt;
                            cmbSatisUrun.DisplayMember = "UrunAdi";
                            cmbSatisUrun.ValueMember = "UrunID";
                            cmbSatisUrun.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("Ürünler yüklenemedi: " + ex.Message); }
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            if (cmbSatisUrun.SelectedItem == null || string.IsNullOrWhiteSpace(txtSatisMiktar.Text)) return;
            
            DataRowView seciliUrun = cmbSatisUrun.SelectedItem as DataRowView;
            int urunID = Convert.ToInt32(seciliUrun["UrunID"]);
            string urunAdi = seciliUrun["UrunAdi"].ToString();
            decimal birimFiyat = Convert.ToDecimal(seciliUrun["Fiyat"]);
            int miktar;

            if (!int.TryParse(txtSatisMiktar.Text, out miktar) || miktar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
                return;
            }

            satisSepetTable.Rows.Add(urunID, urunAdi, miktar, birimFiyat);
            SatisToplamHesapla();
        }
        
        private void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (cmbSatisMusteri.SelectedItem == null || satisSepetTable.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen müşteri seçin ve sepete ürün ekleyin.");
                return;
            }

            int musteriID = Convert.ToInt32(cmbSatisMusteri.SelectedValue);
            decimal toplamTutar = Convert.ToDecimal(txtSatisToplam.Text);
            int yeniSatisID;

            try
            {
                using (var baglanti = VeritabaniBaglantisi.GetConnection())
                {
                    baglanti.Open();
                    using (var komut = new MySqlCommand("SatisEkle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@p_MusteriID", musteriID);
                        komut.Parameters.AddWithValue("@p_SatisTarihi", DateTime.Now);
                        komut.Parameters.AddWithValue("@p_ToplamTutar", toplamTutar);
                        komut.Parameters.Add("@p_YeniSatisID", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                        komut.ExecuteNonQuery();
                        yeniSatisID = Convert.ToInt32(komut.Parameters["@p_YeniSatisID"].Value);
                    }

                    foreach (DataRow row in satisSepetTable.Rows)
                    {
                        using (var komut = new MySqlCommand("SatisDetayEkle", baglanti))
                        {
                            komut.CommandType = CommandType.StoredProcedure;
                            komut.Parameters.AddWithValue("@p_SatisID", yeniSatisID);
                            komut.Parameters.AddWithValue("@p_UrunID", Convert.ToInt32(row["UrunID"]));
                            komut.Parameters.AddWithValue("@p_Miktar", Convert.ToInt32(row["Miktar"]));
                            komut.Parameters.AddWithValue("@p_BirimFiyat", Convert.ToDecimal(row["BirimFiyat"]));
                            komut.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Satış başarıyla tamamlandı.");
                UrunleriYukle(); // Stokların güncel halini görmek için
                SatisFormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış tamamlanırken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSatisTemizle_Click(object sender, EventArgs e) { SatisFormuTemizle(); }
        
        private void SatisToplamHesapla()
        {
            decimal toplam = 0;
            foreach(DataRow row in satisSepetTable.Rows)
            {
                toplam += Convert.ToDecimal(row["Tutar"]);
            }
            txtSatisToplam.Text = toplam.ToString("C2");
        }
        
        private void SatisFormuTemizle()
        {
            satisSepetTable.Clear();
            cmbSatisMusteri.SelectedIndex = -1;
            cmbSatisUrun.SelectedIndex = -1;
            txtSatisMiktar.Clear();
            txtSatisToplam.Clear();
        }
        #endregion
    }
} 