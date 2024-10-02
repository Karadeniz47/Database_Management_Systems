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
    public partial class GuncellemeForm : Form
    {
        private int planID;

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");



        public GuncellemeForm(int planID)
        {
            InitializeComponent();
            this.planID = planID;
            VeritabanindanBilgileriDoldur(planID);
            
        }
        private void GuncellemeForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tren");
            comboBox1.Items.Add("Ucak");

        }

        private void VeritabanindanBilgileriDoldur(int planID)
        {
            conn.Open();

            using (NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM seyahat_plani WHERE plan_id = @p1", conn))
            {
                komut.Parameters.AddWithValue("@p1", planID);

                using (NpgsqlDataReader reader = komut.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       
                        textBox1_baslangic_noktasi.Text = reader["baslangic_noktasi"].ToString();
                        textBox1_varis_noktasi.Text = reader["varis_noktasi"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["baslangic_tarihi"]);
                        dateTimePicker2.Value = Convert.ToDateTime(reader["bitis_tarihi"]);

                        
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen plan ID'ye ait kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            using (NpgsqlCommand komut = new NpgsqlCommand("UPDATE seyahat_plani SET baslangic_tarihi = @p2, bitis_tarihi = @p3, baslangic_noktasi = @p4, varis_noktasi = @p5 WHERE plan_id = @p1", conn))
            {
                komut.Parameters.AddWithValue("@p1", planID);
                komut.Parameters.AddWithValue("@p2", dateTimePicker1.Value.Date);
                komut.Parameters.AddWithValue("@p3", dateTimePicker2.Value.Date);
                komut.Parameters.AddWithValue("@p4", textBox1_baslangic_noktasi.Text);
                komut.Parameters.AddWithValue("@p5", textBox1_varis_noktasi.Text);
                komut.ExecuteNonQuery();

                
            }

            using (NpgsqlCommand u_komut = new NpgsqlCommand("UPDATE ulasim SET ulasim_araci = @p2 WHERE plan_id = @p1 ", conn))
            {
                u_komut.Parameters.AddWithValue("@p1", planID);
                u_komut.Parameters.AddWithValue("@p2", comboBox1.Text);
                u_komut.ExecuteNonQuery();
            }
           
            conn.Close();
            MessageBox.Show("Seyahat Kaydı Güncellendi");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }




}

















