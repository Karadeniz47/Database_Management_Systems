using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kullanici_Ekle : Form
    {
        public Kullanici_Ekle()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlTransaction transaction = conn.BeginTransaction();

            try
            {
                
                string ad = textBox1_Ad.Text.Trim();
                string soyad = textBox2_Soyad.Text.Trim();
                string sifre = textBox3_Sifre.Text.Trim();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen ad, soyad ve şifre girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                NpgsqlCommand kontrolKomut = new NpgsqlCommand("SELECT kullanici_id FROM kullanici WHERE ad = @p1 AND soyad = @p2", conn);
                kontrolKomut.Parameters.AddWithValue("@p1", ad);
                kontrolKomut.Parameters.AddWithValue("@p2", soyad);

                object kontrolSonuc = kontrolKomut.ExecuteScalar();

                if (kontrolSonuc != null)
                {
                    MessageBox.Show("Kullanıcı zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                   
                    NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO kullanici(ad, soyad, sifre) VALUES (@p1, @p2, @p3)", conn);
                    komut.Parameters.AddWithValue("@p1", ad);
                    komut.Parameters.AddWithValue("@p2", soyad);
                    komut.Parameters.AddWithValue("@p3", sifre);

                    if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(sifre))
                    {
                        MessageBox.Show("Lütfen ad, soyad ve şifre girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    komut.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Kullanıcı Eklendi ");
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

        private void Kullanici_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
