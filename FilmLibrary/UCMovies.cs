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
    public partial class UCMovies : UserControl
    {
        private DataTable movies;
        private int currentDisplayedMovies = 0;
        private int displayMovies = 18;

        public UCMovies(DataTable movies)
        {
            InitializeComponent();

            this.movies = movies;
            this.DisplayMovies(displayMovies);
        }

        private void DisplayMovies(int howMany)
        {
            // Loop over each movie
            int i = 0;
            while(i < howMany)
            {
                if (this.currentDisplayedMovies >= this.movies.Rows.Count)
                {
                    flPanelMovies.Scroll -= flPanelMovies_Scroll;
                    break;
                }
                DataRow movie = this.movies.Rows[this.currentDisplayedMovies];

                // Create a new movie picture box the movie
                MoviePictureBox pbMovie = new MoviePictureBox(movie);
                this.flPanelMovies.Controls.Add(pbMovie);

                i++;
                this.currentDisplayedMovies += 1;
            }
        }

        private void flPanelMovies_Scroll(object sender, ScrollEventArgs e)
        {
            // If end of scroll
            if (flPanelMovies.VerticalScroll.Value == flPanelMovies.VerticalScroll.Maximum - flPanelMovies.VerticalScroll.LargeChange + 1)
            {
                // Display 18 more movies
                this.DisplayMovies(displayMovies);
            }
        }
    }
}
