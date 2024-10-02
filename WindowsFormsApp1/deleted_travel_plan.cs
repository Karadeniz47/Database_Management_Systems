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
    public partial class deleted_travel_plan : Form
    {
        public deleted_travel_plan()
        {
            InitializeComponent();
            goster();
        }

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goster()
        {
            conn.Open();

            string sorgu = "SELECT * FROM deleted_travel_plan_log";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
        }

        private void deleted_travel_plan_Load(object sender, EventArgs e)
        {

        }
    }
}
