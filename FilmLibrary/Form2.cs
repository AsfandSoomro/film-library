﻿using System;
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
        private Timer timerDisposeForm1;

        public static DataRow user;

        private bool isSideBarVisible;
        private int originalSideBarWidth;
        private int sideBarAnimateSpeed = 5;

        public static string currentMainPage;

        public Form2(DataRow user)
        {
            InitializeComponent();

            Form2.user = user;
        }

        private void timerDisposeForm1_Tick(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
                //form1.Dispose();
            this.timerDisposeForm1.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                this.timerDisposeForm1 = new Timer();
                this.timerDisposeForm1.Enabled = true;
                this.timerDisposeForm1.Interval = 4000;
                this.timerDisposeForm1.Tick += new EventHandler(timerDisposeForm1_Tick);
            }

            Helpers.ShowDashboard(this);

            try
            {
                this.pbProfilePic.Image = Utils.ByteToImage((byte[])Form2.user["profile_photo"]);
            }
            catch (Exception)
            {
            }

            this.isSideBarVisible = true;
            this.originalSideBarWidth = panelSideBar.Width;

            string userStatus = user["status"].ToString();
            if (userStatus == "admin" || userStatus == "owner")
            {
                flpManage.Enabled = true;
                flpManage.Visible = true;
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (this.ucProfileMenu.Visible)
                this.UpdateProfileMenuLocation();
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
            Helpers.DisposeAddToWatchlistsUC(this);
        }

        private void panelMain_Resize(object sender, EventArgs e)
        {
            if (Form2.currentMainPage.IndexOf("Movie -") == 0)
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Dashboard")
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Create watchlist")
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage.IndexOf("Update watchlist -") == 0)
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Manage - Add Movie")
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Manage - Update Movie")
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Manage - Delete Movie")
                Helpers.ArrangeMainPanelControls(this);
            else if (Form2.currentMainPage == "Profile")
                Helpers.ArrangeMainPanelControls(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Dashboard")
                Helpers.ShowDashboard(this);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Home")
                Helpers.ShowHome(this);
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            panelGenresContainer.Enabled = !panelGenresContainer.Enabled;
            panelGenresContainer.Visible = !panelGenresContainer.Visible;
            
            if(panelGenresContainer.Controls.Count <= 1)
                Helpers.CreateGenreButtons(panelGenresContainer);
        }

        private void btnMyWatchlists_Click(object sender, EventArgs e)
        {
            panelUserWatchlistsContainer.Enabled = !panelUserWatchlistsContainer.Enabled;
            panelUserWatchlistsContainer.Visible = !panelUserWatchlistsContainer.Visible;

            if (panelUserWatchlistsContainer.Controls.Count <= 2)
                Helpers.CreateUserWatchlistButtons(panelUserWatchlistsContainer, (int)Form2.user["user_id"]);
        }

        private void btnPublicWatchlists_Click(object sender, EventArgs e)
        {
            panelPublicWatchlistsContainer.Enabled = !panelPublicWatchlistsContainer.Enabled;
            panelPublicWatchlistsContainer.Visible = !panelPublicWatchlistsContainer.Visible;

            if (panelPublicWatchlistsContainer.Controls.Count <= 2)
            {
                Helpers.DisposeWatchlistButtons(panelPublicWatchlistsContainer);
                Helpers.CreatePublicWatchlistButtons(panelPublicWatchlistsContainer);
            }
        }

        private void btnCreateWatchlist_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Create Watchlist")
            {
                Helpers.DisposeWatchlistButtons(panelPublicWatchlistsContainer);
                Helpers.ShowCreateWatchlistPage(this, (int)Form2.user["user_id"]);
            }
        }

        private void btnCreateWatchlist2_Click(object sender, EventArgs e)
        {
            btnCreateWatchlist_Click(sender, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Dispose searched movies container first if there already is
            Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);

            Helpers.ShowSearchedMovies(this, txtSearch.Text);

            txtSearch.Text = "Search";
        }

        private void btnManageMovies_Click(object sender, EventArgs e)
        {
            panelManageMoviesContainer.Enabled = !panelManageMoviesContainer.Enabled;
            panelManageMoviesContainer.Visible = !panelManageMoviesContainer.Visible;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Manage - Add Movie")
            {
                Helpers.ShowManageAddMoviePage(this);
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Manage - Update Movie")
            {
                Helpers.ShowManageUpdateMoviePage(this);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Manage - Update Movie")
            {
                Helpers.ShowManageDeleteMoviePage(this);
            }
        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {
            ucProfileMenu.Visible = !ucProfileMenu.Visible;
            if (this.ucProfileMenu.Visible)
                this.UpdateProfileMenuLocation();
        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Dispose searched movies container first if there already is
            Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);

            if(e.KeyCode == Keys.Enter)
            {
                Helpers.ShowSearchedMovies(this, txtSearch.Text);
                txtSearch.Text = "Search";
                return;
            }

            FlowLayoutPanel flp = Helpers.CreateSearchedMoviesContainerFlowLayoutPanel(this);
            flp.Name = "flpSearchedMoviesContainerRuntime";

            DataTable movies = await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT TOP 7 movie_id, cover, title, release_year FROM Movies WHERE LOWER(title) LIKE '{0}%'", this.txtSearch.Text.ToLower())));
            foreach(DataRow movie in movies.Rows)
            {
                UCSearchedMovie uc = new UCSearchedMovie((int)movie["movie_id"], (string)movie["title"], (int)movie["release_year"], (Image)Utils.ByteToImage((byte[])movie["cover"]));
                flp.Controls.Add(uc);
            }

            if (movies.Rows.Count == 0)
            {
                UCSearchedMovieNoResult uc = new UCSearchedMovieNoResult(String.Format("No results for \"{0}\"", txtSearch.Text));
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

        private void flpMenu_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void flpSettings_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void flpManage_MouseDown(object sender, MouseEventArgs e)
        {
            // Trigger the form's mouse down event
            this.Invoke((MethodInvoker)(() =>
            {
                this.OnMouseDown(e);
            }));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSideBarAnimate.Enabled = true;

            // Dispose searched movies container first if there already is
            Helpers.DisposeSearchedMoviesContainerFlowLayoutPanel(this);
        }

        private void timerSideBarAnimate_Tick(object sender, EventArgs e)
        {
            if(this.isSideBarVisible)
            {
                if (panelSideBar.Width > 5)
                {
                    AnimateSideBarDecrease();
                }
                else
                {
                    timerSideBarAnimate.Enabled = false;
                    this.isSideBarVisible = false;
                }
            }
            else
            {
                if (panelSideBar.Width < this.originalSideBarWidth)
                {
                    AnimateSideBarIncrease();
                }
                else
                {
                    timerSideBarAnimate.Enabled = false;
                    this.isSideBarVisible = true;
                }
            }
        }

        private void AnimateSideBarIncrease()
        {
            panelSideBar.Width += this.sideBarAnimateSpeed;
        }

        private void AnimateSideBarDecrease()
        {
            panelSideBar.Width -= this.sideBarAnimateSpeed;
        }

        private void UpdateProfileMenuLocation()
        {
            ucProfileMenu.Location = new Point(pbProfilePic.Location.X - 127, pbProfilePic.Location.Y + 53);
        }
    }
}
