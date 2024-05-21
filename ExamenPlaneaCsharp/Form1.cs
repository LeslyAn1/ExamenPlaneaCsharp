using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPlaneaCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { 
          string connectionString = "Data Source=LESLY\\MSSQLSERVER01;Initial Catalog=explanea;Integrated Security=True";

        string query = "SELECT * FROM edbasica";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
    DataTable table = new DataTable();
    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    MessageBox.Show("Datos cargados correctamente.");
                }
                catch (Exception ex)
{
    MessageBox.Show("Error al cargar los datos: " + ex.Message);
}
            }

        }
    }
}
