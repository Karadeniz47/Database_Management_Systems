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
    public partial class Form3 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Proje; user ID=postgres; password=****");

        public Form3(string input)
        {
            InitializeComponent();
            goster(input);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void goster(string inputValue)
        {
           
                conn.Open();

                
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM get_travel_plans_by_city_name(@p)", conn))
                {
                   
                    cmd.Parameters.AddWithValue("@p", inputValue);
                        
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                       
                        if (dataSet.Tables.Count > 0)
                            dataGridView1.DataSource = dataSet.Tables[0];
                       
                    
                  
                }
            conn.Close();

        }

    }
}
