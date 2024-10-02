using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sorgu = "SELECT \r\n    kullanici.kullanici_id,\r\n   seyahat_plani.plan_id,\r\n    kullanici.ad,\r\n    kullanici.soyad,\r\n        seyahat_plani.baslangic_tarihi,\r\n    seyahat_plani.bitis_tarihi,\r\n    seyahat_plani.baslangic_noktasi,\r\n    seyahat_plani.varis_noktasi,\r\n        ulasim.ulasim_araci,\r\n    ulasim.kalkis_tarihi,\r\n    CASE \r\n        WHEN ulasim.ulasim_araci = 'Tren' THEN tren.tren_istasyonu\r\n        WHEN ulasim.ulasim_araci = 'Ucak' THEN ucak.havalimani\r\n        ELSE NULL\r\n    END AS kalkis_yeri\r\nFROM \r\n    kullanici\r\nJOIN \r\n    seyahat_plani ON kullanici.kullanici_id = seyahat_plani.kullanici_id\r\n JOIN \r\n    ulasim ON seyahat_plani.plan_id = ulasim.plan_id\r\nLEFT JOIN \r\n    tren ON ulasim.ulasim_id = tren.tren_ulasim_id\r\nLEFT JOIN \r\n    ucak ON ulasim.ulasim_id = ucak.ucak_ulasim_id;\r\n";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void EkleVeyaGuncelle()
        {
            conn.Open();

            NpgsqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // Kullanıcı adı ve soyadı kontrolü
                string ad = textBox_ad.Text.Trim();
                string soyad = textBox_soyad.Text.Trim();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve soyadı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int kullaniciID = 0;

                // Varolan bir kullanıcı mı kontrolü
                NpgsqlCommand kontrolKomut = new NpgsqlCommand("SELECT kullanici_id FROM kullanici WHERE ad = @p1 AND soyad = @p2", conn);
                kontrolKomut.Parameters.AddWithValue("@p1", ad);
                kontrolKomut.Parameters.AddWithValue("@p2", soyad);

                object kontrolSonuc = kontrolKomut.ExecuteScalar();

                if (kontrolSonuc != null)
                {
                    kullaniciID = Convert.ToInt32(kontrolSonuc);
                }
                else
                {
                    // Yeni kullanıcı eklemek
                    NpgsqlCommand yeniKullaniciKomut = new NpgsqlCommand("INSERT INTO kullanici(ad, soyad) VALUES (@p1, @p2) RETURNING kullanici_id", conn);
                    yeniKullaniciKomut.Parameters.AddWithValue("@p1", ad);
                    yeniKullaniciKomut.Parameters.AddWithValue("@p2", soyad);

                    kullaniciID = Convert.ToInt32(yeniKullaniciKomut.ExecuteScalar());
                }

                // Seyahat planı eklemek
                NpgsqlCommand seyahatKomut = new NpgsqlCommand("INSERT INTO seyahat_plani(baslangic_tarihi, bitis_tarihi, baslangic_noktasi, varis_noktasi, kullanici_id) VALUES (@p3, @p4, @p5, @p6, @p7) RETURNING plan_id", conn);
                seyahatKomut.Parameters.AddWithValue("@p3", dateTimePicker1.Value.Date);
                seyahatKomut.Parameters.AddWithValue("@p4", dateTimePicker2.Value.Date);
                seyahatKomut.Parameters.AddWithValue("@p5", textBox_baslangic_noktasi.Text);
                seyahatKomut.Parameters.AddWithValue("@p6", textBox_varis_noktasi.Text);
                seyahatKomut.Parameters.AddWithValue("@p7", kullaniciID);

                int planID = Convert.ToInt32(seyahatKomut.ExecuteScalar());

                if ( dateTimePicker1.Value == null || dateTimePicker2.Value == null)
                {
                    MessageBox.Show("Lütfen baslangic_tarihi ve bitis_tarihi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    transaction.Rollback();
                    return;
                }

                if (string.IsNullOrEmpty(textBox_baslangic_noktasi.Text) || string.IsNullOrEmpty(textBox_varis_noktasi.Text))
                {
                    MessageBox.Show("Lütfen baslangic noktasi ve varis noktasi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    transaction.Rollback();
                    return;
                }

               
                // Ulaşım eklemek
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || dateTimePicker3.Value == null)
                {
                    MessageBox.Show("Lütfen ulaşım aracı ve kalkış tarihini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    transaction.Rollback();
                    return;
                }

                NpgsqlCommand ulasimKomut = new NpgsqlCommand("INSERT INTO ulasim(ulasim_araci, plan_id, kalkis_tarihi) VALUES (@p10, @p11, @p12) RETURNING ulasim_id", conn);
                ulasimKomut.Parameters.AddWithValue("@p10", comboBox1.Text);
                ulasimKomut.Parameters.AddWithValue("@p11", planID);
                ulasimKomut.Parameters.AddWithValue("@p12", dateTimePicker3.Value.Date);

                int ulasimID = Convert.ToInt32(ulasimKomut.ExecuteScalar());

                // Tren veya Uçak eklemek
                NpgsqlCommand trenUcakKomut;

                if (comboBox1.Text == "Tren")
                {
                    if (string.IsNullOrWhiteSpace(textBox_kalkis_yeri.Text))
                    {
                        MessageBox.Show("Lütfen tren istasyonunu girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    trenUcakKomut = new NpgsqlCommand("INSERT INTO tren(tren_ulasim_id, tren_istasyonu) VALUES (@p13, @p14)", conn);
                    trenUcakKomut.Parameters.AddWithValue("@p13", ulasimID);
                    trenUcakKomut.Parameters.AddWithValue("@p14", textBox_kalkis_yeri.Text);
                    trenUcakKomut.ExecuteNonQuery();
                }
                else if (comboBox1.Text == "Ucak")
                {
                    if (string.IsNullOrWhiteSpace(textBox_kalkis_yeri.Text))
                    {
                        MessageBox.Show("Lütfen havalimanını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    trenUcakKomut = new NpgsqlCommand("INSERT INTO ucak(ucak_ulasim_id, havalimani) VALUES (@p15, @p16)", conn);
                    trenUcakKomut.Parameters.AddWithValue("@p15", ulasimID);
                    trenUcakKomut.Parameters.AddWithValue("@p16", textBox_kalkis_yeri.Text);
                    trenUcakKomut.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Seyahat Kaydı Eklendi");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }







        private void button_ekle_Click(object sender, EventArgs e)
        {

            EkleVeyaGuncelle();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tren");
            comboBox1.Items.Add("Ucak");
            sil_textbox.Text = "planID giriniz";
            textBox_ara.Text = "planID giriniz";
            textBox_guncelle.Text = "planID giriniz";
            textBox1_kullanici_sil.Text = "kullaniciID giriniz";
            textBox1.Text = "planID giriniz";
            textBox2.Text = "kullaniciID giriniz";
            textBox3.Text = "sehir giriniz";
            sil_textbox.ForeColor = Color.LightGray;
            textBox_ara.ForeColor = Color.LightGray;
            textBox_guncelle.ForeColor = Color.LightGray;
            textBox1_kullanici_sil.ForeColor = Color.LightGray;
            textBox1.ForeColor = Color.LightGray;
            textBox2.ForeColor = Color.LightGray;
            textBox3.ForeColor = Color.LightGray;
    
        }



        private void button_guncelle_Click(object sender, EventArgs e)
        {
            
            int planID;
            if (!int.TryParse(textBox_guncelle.Text, out planID))
            {
                MessageBox.Show("Geçerli bir plan ID girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.Open();

           
            using (NpgsqlCommand kontrolKomutu = new NpgsqlCommand("SELECT COUNT(*) FROM seyahat_plani WHERE plan_id = @p1", conn))
            {
                kontrolKomutu.Parameters.AddWithValue("@p1", planID);
                int kayitSayisi = Convert.ToInt32(kontrolKomutu.ExecuteScalar());

                if (kayitSayisi == 0)
                {
                    MessageBox.Show("Belirtilen plan ID'ye ait kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
            }

           
            using (GuncellemeForm guncellemeForm = new GuncellemeForm(planID))
            {
                if (guncellemeForm.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }

            conn.Close();

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            string planIDText = sil_textbox.Text;

            if (string.IsNullOrEmpty(planIDText))
            {
                MessageBox.Show("Geçersiz plan ID");
                return;
            }

            if (!int.TryParse(planIDText, out int planID))
            {
                MessageBox.Show("Geçersiz plan ID formatı");
                return;
            }

            try
            {
                conn.Open();

                using (NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM seyahat_plani WHERE plan_id = @p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", planID);
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                        MessageBox.Show("Kayıt başarıyla silindi.");
                    else
                        MessageBox.Show("Belirtilen plan ID bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            string planID = textBox_ara.Text.Trim();

            if (string.IsNullOrEmpty(planID))
            {
                MessageBox.Show("Geçerli bir plan ID girin.");
                return;
            }

            try
            {
                conn.Open();

                using (NpgsqlCommand komut = new NpgsqlCommand("SELECT \r\n    kullanici.kullanici_id,\r\n    kullanici.ad,\r\n    kullanici.soyad,\r\n    seyahat_plani.plan_id,\r\n    seyahat_plani.baslangic_tarihi,\r\n    seyahat_plani.bitis_tarihi,\r\n    seyahat_plani.baslangic_noktasi,\r\n    seyahat_plani.varis_noktasi,\r\n    ulasim.ulasim_araci,\r\n    ulasim.kalkis_tarihi,\r\n    CASE \r\n        WHEN ulasim.ulasim_araci = 'Tren' THEN tren.tren_istasyonu\r\n        WHEN ulasim.ulasim_araci = 'Ucak' THEN ucak.havalimani\r\n        ELSE NULL\r\n    END AS kalkis_yeri\r\nFROM \r\n    kullanici \r\n    JOIN seyahat_plani ON kullanici.kullanici_id = seyahat_plani.kullanici_id\r\n    JOIN ulasim ON seyahat_plani.plan_id = ulasim.plan_id\r\n    LEFT JOIN tren ON ulasim.ulasim_id = tren.tren_ulasim_id\r\n    LEFT JOIN ucak ON ulasim.ulasim_id = ucak.ucak_ulasim_id\r\nWHERE seyahat_plani.plan_id = @p;\r\n", conn))
                {
                    komut.Parameters.AddWithValue("@p", Convert.ToInt32(planID));

                    using (NpgsqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen plan ID'ye sahip kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void sil_textbox_Enter(object sender, EventArgs e)
        {
            if(sil_textbox.Text == "planID giriniz")
            {
                sil_textbox.Text = "";
                sil_textbox.ForeColor = Color.Black;
            }

        }

        private void sil_textbox_Leave(object sender, EventArgs e)
        {
            if(sil_textbox.Text == "")
            {
                sil_textbox.Text = "planID giriniz";
                sil_textbox.ForeColor = Color.LightGray;
            }

        }

        private void textBox_ara_Enter(object sender, EventArgs e)
        {
           
            if (textBox_ara.Text == "planID giriniz")
            {
                textBox_ara.Text = "";
                textBox_ara.ForeColor = Color.Black;
            }
                
            

        }

        private void textBox_ara_Leave(object sender, EventArgs e)
        {
            if(textBox_ara.Text == "")
            {
                textBox_ara.Text = "planID giriniz";
                textBox_ara.ForeColor = Color.LightGray;
            }

        }

        private void textBox_guncelle_Enter(object sender, EventArgs e)
        {
            if(textBox_guncelle.Text == "planID giriniz")
            {
                textBox_guncelle.Text = "";
                textBox_guncelle.ForeColor = Color.Black;
            }

        }

        private void textBox_guncelle_Leave(object sender, EventArgs e)
        {
            if(textBox_guncelle.Text == "")
            {
                textBox_guncelle.Text = "planID giriniz";
                textBox_guncelle.ForeColor= Color.LightGray;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silinen_kayitlar_Click(object sender, EventArgs e)
        {
            using (deleted_travel_plan deleted_Travel_Plan = new deleted_travel_plan())
            {
                if (deleted_Travel_Plan.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           using(Updated_Travel_Plan updated_travel_plan = new Updated_Travel_Plan())
            {
                if (updated_travel_plan.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Kullanicilar kullanicilar = new Kullanicilar())
            {
                if(kullanicilar.ShowDialog() == DialogResult.OK)
                {

                }
            }
               
        }

        private void button1_kullanici_Click(object sender, EventArgs e)
        {

            using (Kullanici_Ekle k = new Kullanici_Ekle())
            {
                if (k.ShowDialog() == DialogResult.OK)
                {

                }
            }



        }

        private void textBox1_kullanici_sil_Enter(object sender, EventArgs e)
        {
            if (textBox1_kullanici_sil.Text == "kullaniciID giriniz")
            {
                textBox1_kullanici_sil.Text = "";
                textBox1_kullanici_sil.ForeColor = Color.Black;
            }

        }

        private void textBox1_kullanici_sil_Leave(object sender, EventArgs e)
        {
            if (textBox1_kullanici_sil.Text == "")
            {
                textBox1_kullanici_sil.Text = "kullaniciID giriniz";
                textBox1_kullanici_sil.ForeColor = Color.LightGray;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullaniciIDText = textBox1_kullanici_sil.Text;

            if (string.IsNullOrEmpty(kullaniciIDText))
            {
                MessageBox.Show("Geçersiz kullanici ID");
                return;
            }

            if (!int.TryParse(kullaniciIDText, out int kullaniciID))
            {
                MessageBox.Show("Geçersiz plan ID formatı");
                return;
            }

            try
            {
                conn.Open();

                using (NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM kullanici WHERE kullanici_id = @p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", kullaniciID);
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                        MessageBox.Show("Kullanici başarıyla silindi.");
                    else
                        MessageBox.Show("Belirtilen kullanici ID bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int inputValue = Convert.ToInt32(textBox1.Text);

           
           
                conn.Open();

               
                using (var cmd = new NpgsqlCommand("SELECT calculate_travel_days(@p)", conn))
                {
                    // Parametre eklenmesi
                    cmd.Parameters.AddWithValue("@p", inputValue);

                    try
                    {
                        
                        var result = cmd.ExecuteScalar();

                        
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Sonuç", typeof(string));
                        dataTable.Rows.Add(result);

                        dataGridView2.DataSource = dataTable;
                    conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }

                
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int inputValue = Convert.ToInt32(textBox2.Text);

            
            conn.Open();

           
            using (var cmd = new NpgsqlCommand("SELECT calculate_visited_cities_count(@p)", conn))
            {
                
                cmd.Parameters.AddWithValue("@p", inputValue);

                try
                {
                   
                    var result = cmd.ExecuteScalar();

                   
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Sonuç", typeof(string));
                    dataTable.Rows.Add(result);

                    dataGridView3.DataSource = dataTable;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            conn.Open();

            
            using (var cmd = new NpgsqlCommand("SELECT calculate_user_count()", conn))
            {

                try
                {
                    
                    var result = cmd.ExecuteScalar();

                    
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Sonuç", typeof(string));
                    dataTable.Rows.Add(result);

                    dataGridView4.DataSource = dataTable;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }





        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            string cityName = textBox3.Text;

            conn.Open();

           
            using (NpgsqlCommand kontrolKomutu = new NpgsqlCommand("SELECT COUNT(*) FROM seyahat_plani WHERE baslangic_noktasi = @p1 OR varis_noktasi = @p1", conn))
            {
                kontrolKomutu.Parameters.AddWithValue("@p1", cityName);
                int kayitSayisi = Convert.ToInt32(kontrolKomutu.ExecuteScalar());

                if (kayitSayisi == 0)
                {
                    MessageBox.Show("Belirtilen şehir adına ait kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
            }

            
            using (Form3 form = new Form3(cityName))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }

            conn.Close();

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "planID giriniz")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "planID giriniz";
                textBox1.ForeColor = Color.LightGray;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "kullaniciID giriniz")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "kullaniciID giriniz";
                textBox2.ForeColor = Color.LightGray;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "sehir giriniz")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "sehir giriniz";
                textBox3.ForeColor = Color.LightGray;
            }

        }
    }

}
