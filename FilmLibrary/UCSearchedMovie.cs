﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class UCSearchedMovie : UserControl
    {
        private int movie_id;

        public UCSearchedMovie(int movie_id, string title, int release_year, Image cover)
        {
            InitializeComponent();

            this.movie_id = movie_id;

            this.lblTitle.Text = title;
            this.lblReleaseYear.Text = "(" + release_year.ToString() + ")";
            this.pbCover.Image = cover;

            this.MakeChildControlsInheritEvents();
        }

        private void panelSearchedMovie_MouseEnter(object sender, EventArgs e)
        {
            Color color = this.panelSearchedMovie.BackColor;
            this.panelSearchedMovie.BackColor = Color.FromArgb(color.R + 40, color.G + 40, color.B + 40);
        }

        private void panelSearchedMovie_MouseLeave(object sender, EventArgs e)
        {
            Color color = this.panelSearchedMovie.BackColor;
            this.panelSearchedMovie.BackColor = Color.FromArgb(color.R - 40, color.G - 40, color.B - 40);
        }

        private void MakeChildControlsInheritEvents()
        {
            foreach (Control control in this.panelSearchedMovie.Controls)
            {
                control.MouseEnter += this.panelSearchedMovie_MouseEnter;
                control.MouseLeave += this.panelSearchedMovie_MouseLeave;
            }
        }

        private async void panelSearchedMovie_Click(object sender, EventArgs e)
        {
            // Get the movie data and store in move attribute
            string query = String.Format("SELECT * FROM Movies WHERE movie_id = {0}", this.movie_id.ToString());
            DataRow movie = (DataRow)(await Queries.GetDataTable("Movies", query)).Rows[0];

            Helpers.OpenMoviePage(this.FindForm(), movie);
        }
    }
}
