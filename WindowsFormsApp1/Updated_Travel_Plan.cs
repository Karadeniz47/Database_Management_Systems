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
    public partial class Updated_Travel_Plan : Form
    {
        public Updated_Travel_Plan()
        {
            InitializeComponent();
            goster();
        }

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");


        private void Updated_Travel_Plan_Load(object sender, EventArgs e)
        {

        }

        private void goster()
        {
            conn.Open();

            string sorgu = "SELECT * FROM updated_travel_plan_log";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
        }


    }
}
