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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kullanici(ad,soyad)values(@p1,@p2)", conn);
            komut1.Parameters.AddWithValue("@p1",textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullanici Eklendi");
        }

        private void k_ad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu ="select * from kullanici";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }
    }
}



