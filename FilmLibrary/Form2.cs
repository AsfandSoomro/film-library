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

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            // Finds the searched movies flow container
            FlowLayoutPanel searchedMoviesContainerPanel = this.Controls.Find("flpSearchedMoviesContainerRuntime", true).FirstOrDefault() as FlowLayoutPanel;

            // Check if the mouse is not over search movies container when it is clicked
            if (searchedMoviesContainerPanel != null && !Utils.IsClickedWithinBounds(searchedMoviesContainerPanel, e.Location))
            {
                if (txtSearch.Text == "")
                {
                    txtSearch.Text = "Search";
                }
                Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);
            }
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

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Dispose searched movies container first if there already is
            Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);

            FlowLayoutPanel flp = Helpers.CreateSearchedMoviesContainerFlowLayoutPanel(this);
            flp.Name = "flpSearchedMoviesContainerRuntime";

            DataTable movies = await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT TOP 7 movie_id, cover, title, release_year FROM Movies WHERE LOWER(title) LIKE '{0}%'", this.txtSearch.Text.ToLower())));
            foreach(DataRow movie in movies.Rows)
            {
                UCSearchedMovie uc = new UCSearchedMovie((int)movie["movie_id"], (string)movie["title"], (int)movie["release_year"], (Image)Utils.ByteToImage((byte[])movie["cover"]));
                flp.Controls.Add(uc);
            }

            this.Controls.Add(flp);
            flp.BringToFront();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                // Dispose searched movies container first if there already is
                Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);
                return;
            }
        }

        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void panelSearchBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void panelSideBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void panelSideBarLogo_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }
    }
}
