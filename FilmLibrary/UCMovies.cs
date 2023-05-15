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
        private int limit = 18;
        private int lastDisplayedMovieId = 0;
        private bool ScrollDisplayMoviesLock = false;

        public UCMovies(string query) // movies parameter only gets movie_id and cover photo
        {
            InitializeComponent();

            this.theQuery = query;
            this.query = query.Replace("@LIMIT", String.Format("TOP {0}", this.limit));
            this.query = this.query.Replace("@CONDITIONS", String.Format("1 = 1"));

            this.StartDisplayMovies();
        }

        private void UpdateQuery()
        {
            this.query = theQuery.Replace("@LIMIT", String.Format("TOP {0}", this.limit));
            this.query = this.query.Replace("@CONDITIONS", String.Format("movie_id > {0}", this.lastDisplayedMovieId));
        }

        private async void StartDisplayMovies()
        {
            this.DisplayMovies(await Task.Run(() => Queries.GetDataTable("Movies", this.query)));
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
            this.lastDisplayedMovieId = (int)movies.Rows[(int)movies.Rows.Count - 1]["movie_id"];
            this.UpdateQuery();
        }

        private async void flPanelMovies_Scroll(object sender, ScrollEventArgs e)
        {
            // If end of scroll
            if (flPanelMovies.VerticalScroll.Value == flPanelMovies.VerticalScroll.Maximum - flPanelMovies.VerticalScroll.LargeChange + 1)
            {
                if (this.ScrollDisplayMoviesLock == false)
                {
                    // Lock to avoid same movies fetched more than once
                    this.ScrollDisplayMoviesLock = true;
                    // Display 18 more movies
                    this.DisplayMovies(await Task.Run(() => Queries.GetDataTable("Movies", this.query)));
                    // Unlock to let the user display more movies via scroll 
                    this.ScrollDisplayMoviesLock = false;
                }
            }
        }
    }
}
