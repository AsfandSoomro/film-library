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
        private DataRow user;

        private bool isSideBarVisible;
        private int originalSideBarWidth;

        public static string currentMainPage;

        public Form2(DataRow user)
        {
            InitializeComponent();

            this.user = user;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            Helpers.ShowHome();

            this.lblUsername.Text = (string)this.user["username"];
            try
            {
                this.pbProfilePic.Image = Utils.ByteToImage((byte[])this.user["profile_photo"]);
            }
            catch (Exception)
            {
            }

            this.isSideBarVisible = true;
            this.originalSideBarWidth = panelSideBar.Width;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Home")
                Helpers.ShowHome();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            panelGenresContainer.Enabled = !panelGenresContainer.Enabled;
            panelGenresContainer.Visible = !panelGenresContainer.Visible;
            
            if(panelGenresContainer.Controls.Count < 2)
                Helpers.CreateGenreButtons(panelGenresContainer);
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

        private void pbProfilePic_Click(object sender, EventArgs e)
        {
            cbProfile.DroppedDown = true;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            cbProfile.DroppedDown = true;
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
            panelSideBar.Width += 5;
        }

        private void AnimateSideBarDecrease()
        {
            panelSideBar.Width -= 5;
        }
    }
}
