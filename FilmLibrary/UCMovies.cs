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
        private string theQuery;
        private string query;
        private int currentDisplayedMovies = 0;
        private int[] displayMoviesRange = {0, 17};

        public UCMovies(string query) // movies parameter only gets movie_id and cover photo
        {
            InitializeComponent();

            this.theQuery = query;
            this.query = query.Replace("@range", String.Format("movie_id >= {0} and movie_id <= {1}", this.displayMoviesRange[0], this.displayMoviesRange[1]));

            this.DisplayMovies(Queries.GetDataTable("Movies", this.query));
        }

        private void UpdateRangeAndQuery()
        {
            this.displayMoviesRange[0] += 18;
            this.displayMoviesRange[1] += 18;

            this.query = this.theQuery.Replace("@range", String.Format("movie_id >= {0} and movie_id <= {1}", this.displayMoviesRange[0], this.displayMoviesRange[1]));
        }
        private void DisplayMovies(DataTable movies)
        {
            // Loop over each movie

            foreach(DataRow movie in movies.Rows)
            {
                // Create a new movie picture box the movie
                MoviePictureBox pbMovie = new MoviePictureBox((int)movie["movie_id"], (Byte[])movie["cover"]);
                this.flPanelMovies.Controls.Add(pbMovie);

                this.currentDisplayedMovies += 1;
            }
            this.UpdateRangeAndQuery();
        }

        private void flPanelMovies_Scroll(object sender, ScrollEventArgs e)
        {
            // If end of scroll
            if (flPanelMovies.VerticalScroll.Value == flPanelMovies.VerticalScroll.Maximum - flPanelMovies.VerticalScroll.LargeChange + 1)
            {
                // Display 18 more movies
                this.DisplayMovies(Queries.GetDataTable("Movies", this.query));
            }
        }
    }
}
