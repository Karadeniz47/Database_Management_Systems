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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
            goster();
        }

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");


        private void Kullanicilar_Load(object sender, EventArgs e)
        {

        }

        private void goster()
        {
            conn.Open();

            string sorgu = "SELECT * FROM kullanici";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
        }
    }
}
