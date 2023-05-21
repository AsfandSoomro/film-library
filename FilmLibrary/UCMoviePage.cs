using System;
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
    public partial class UCMoviePage : UserControl
    {
        private DataRow movie;
        public bool isAddToWatchlistButtonClicked;

        public UCMoviePage(DataRow movie)
        {
            InitializeComponent();

            this.movie = movie;
        }

        private void UCMoviePage_Load(object sender, EventArgs e)
        {
            Helpers.ArrangeMainPanelControls(this.FindForm());

            if (movie["cover"] != DBNull.Value) this.pbCover.Image = (Image)Utils.ByteToImage((Byte[])movie["cover"]);
            this.lblTitle.Text = (string)movie["title"];
            if (movie["release_year"] != DBNull.Value) this.lblYear.Text = "(" + (int)movie["release_year"] + ")";
            if (movie["plot_outline"] != DBNull.Value) this.lblPlot.Text = (string)movie["plot_outline"];
            if(movie["rating"] != DBNull.Value) this.lblRating.Text = (decimal)movie["rating"] + " / 10";
            if(movie["budget"] != DBNull.Value) this.lblBudget.Text = (Convert.ToInt64(movie["budget"])).ToString("C");
            if(movie["cumulative_worldwide_gross"] != DBNull.Value) this.lblBoxOffice.Text = (Convert.ToInt64(movie["cumulative_worldwide_gross"])).ToString("C");

            this.FillGenres();
            this.FillCountries();
            this.FillLanguages();
            this.FillDirectors();
            this.FillProducers();
            this.FillWriters();
            this.FillCast();
        }

        private void btnAddToWatchlist_Click(object sender, EventArgs e)
        {
            Helpers.ShowAddToWatchlistsUC(this.FindForm(), (int)movie["movie_id"]);
        }

        private async void FillGenres()
        {
            DataTable genres = await Task.Run(() => Queries.GetDataTable("Genres", String.Format("SELECT * FROM Genres g INNER JOIN Movies_Genres mg ON g.genre_id = mg.genre_id WHERE mg.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow genre in genres.Rows)
            {
                if (i == 0)
                {
                    lblGenre.Text = (string)genre["name"];
                }
                else
                {
                    lblGenre.Text += ", " + (string)genre["name"];
                }
                i++;
            }
        }

        private async void FillCountries()
        {
            DataTable countries = await Task.Run(() => Queries.GetDataTable("Countries", String.Format("SELECT * FROM Countries c INNER JOIN Movies_Countries mc ON c.country_id = mc.country_id WHERE mc.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow country in countries.Rows)
            {
                if (i == 0)
                {
                    lblCountry.Text = (string)country["name"];
                }
                else
                {
                    lblCountry.Text += ", " + (string)country["name"];
                }
                i++;
            }
        }

        private async void FillLanguages()
        {
            DataTable languages = await Task.Run(() => Queries.GetDataTable("Languages", String.Format("SELECT * FROM Languages l INNER JOIN Movies_Languages ml ON l.language_id = ml.language_id WHERE ml.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow language in languages.Rows)
            {
                if (i == 0)
                {
                    lblLanguage.Text = (string)language["name"];
                }
                else
                {
                    lblLanguage.Text += ", " + (string)language["name"];
                }
                i++;
            }
        }

        private async void FillDirectors()
        {
            DataTable directors = await Task.Run(() => Queries.GetDataTable("Persons", String.Format("SELECT * FROM Persons p INNER JOIN Movies_Directors md ON p.person_id = md.director_id WHERE md.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow director in directors.Rows)
            {
                if (i == 0)
                {
                    lblDirector.Text = (string)director["name"];
                }
                else
                {
                    lblDirector.Text += ", " + (string)director["name"];
                }
                i++;
            }
        }

        private async void FillProducers()
        {
            DataTable producers = await Task.Run(() => Queries.GetDataTable("Persons", String.Format("SELECT * FROM Persons p INNER JOIN Movies_Producers mp ON p.person_id = mp.producer_id WHERE mp.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow producer in producers.Rows)
            {
                if (i == 0)
                {
                    lblProducer.Text = (string)producer["name"];
                }
                else
                {
                    lblProducer.Text += ", " + (string)producer["name"];
                }
                i++;
            }
        }

        private async void FillWriters()
        {
            DataTable writers = await Task.Run(() => Queries.GetDataTable("Persons", String.Format("SELECT * FROM Persons p INNER JOIN Movies_Writers mw ON p.person_id = mw.writer_id WHERE mw.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow writer in writers.Rows)
            {
                if (i == 0)
                {
                    lblWriter.Text = (string)writer["name"];
                }
                else
                {
                    lblWriter.Text += ", " + (string)writer["name"];
                }
                i++;
            }
        }

        private async void FillCast()
        {
            DataTable cast = await Task.Run(() => Queries.GetDataTable("Persons", String.Format("SELECT * FROM Persons p INNER JOIN Movies_Cast mc ON p.person_id = mc.cast_id WHERE mc.movie_id = {0}", this.movie["movie_id"])));
            int i = 0;
            foreach (DataRow c in cast.Rows)
            {
                if (i == 0)
                {
                    lblCast.Text = (string)c["name"];
                }
                else
                {
                    lblCast.Text += ", " + (string)c["name"];
                }
                i++;
            }
        }
    }
}



