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
    public partial class UCMovie : UserControl
    {
        private DataRow movie;
        public UCMovie(DataRow movie)
        {
            InitializeComponent();

            this.movie = movie;
        }

        private void UCMovie_Load(object sender, EventArgs e)
        {
            this.pbMovieCover.Image = (Image)Utils.ByteToImage((Byte[])movie["cover"]);
            this.lblMovieTitle.Text = (string)movie["title"];
            this.lblMovieYear.Text = "(" + (int)movie["release_year"] + ")";
            this.lblPlotOutline.Text = (string)movie["plot_outline"];
        }

        private void btnBack_Click(object sender, EventArgs e)
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

                Form form = this.FindForm();
                Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
                Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

                UCMovies uc = new UCMovies((DataTable)dataTable);
                uc.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(uc);
            }
        }
    }
}
