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
    public partial class Form4 : Form
    {
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;
        
        public Form4(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
          
            InitializeComponent();
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;

            DataTable seyahatKayitlari = GetSeyahatKayitlariMetodu(baslangicTarihi, bitisTarihi);

            dataGridView1.DataSource = seyahatKayitlari;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private DataTable GetSeyahatKayitlariMetodu(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("PlanID", typeof(int));
            dataTable.Columns.Add("BaslangicNoktasi", typeof(string));
            dataTable.Columns.Add("VarisNoktasi", typeof(string));
            dataTable.Columns.Add("BaslangicTarihi", typeof(DateTime));
            dataTable.Columns.Add("BitisTarihi", typeof(DateTime));

            
            string connString = "Host=localhost;Username=postgres;Password=iak2494135;Database=Proje";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM get_travel_plans_by_date_range(@baslangic, @bitis)", conn))
                {
                    cmd.Parameters.AddWithValue("@baslangic", baslangicTarihi);
                    cmd.Parameters.AddWithValue("@bitis", bitisTarihi);

                    
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }

                conn.Close();
            }

            return dataTable;
        }


    }
}
