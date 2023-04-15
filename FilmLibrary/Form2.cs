using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmLibrary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Movies";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Movies");

                DataTable dataTable = dataSet.Tables["Movies"];

                UCMovies uc = new UCMovies((DataTable)dataTable);
                uc.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(uc);
            }
        }
    }
}
