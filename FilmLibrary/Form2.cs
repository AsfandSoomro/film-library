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
            Helpers.ShowDashboard();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            FlowLayoutPanel flp = this.CreateSearchedMoviesContainerFlowLayoutPanel();

            DataTable movies = Queries.GetDataTable("Movies", String.Format("SELECT TOP 7 movie_id, cover, title, release_year FROM Movies WHERE LOWER(title) LIKE '%{0}%'", this.txtSearch.Text.ToLower()));
            foreach(DataRow movie in movies.Rows)
            {
                UCSearchedMovie uc = new UCSearchedMovie((int)movie["movie_id"], (string)movie["title"], (int)movie["release_year"], (Image)Utils.ByteToImage((byte[])movie["cover"]));
                flp.Controls.Add(uc);
            }

            this.Controls.Add(flp);
            flp.BringToFront();
        }

        private FlowLayoutPanel CreateSearchedMoviesContainerFlowLayoutPanel()
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            
            flp.BackColor = Color.FromArgb(31, 40, 57);
            flp.BorderStyle = BorderStyle.FixedSingle;
            flp.Size = new Size(558, 235);
            flp.Location = new Point(49 + this.panelMenu.Width, 63 - 16);
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;

            return flp;
        }
    }
}
