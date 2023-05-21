using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FilmLibrary
{
    class GenreButton : SideBarSubCategoryButton
    {
        private DataRow genre;

        public GenreButton()
        {

        }

        public GenreButton(DataRow genre) : this()
        {
            this.genre = genre;

            this.Text = (string)genre["name"];

            this.Click += new EventHandler(this.GenreButton_Click);
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != "Genre - " + (string)this.genre["name"])
            {
                Form2.currentMainPage = "Genre - " + (string)this.genre["name"];
                Helpers.UpdateMainPageHeading(this.FindForm());

                string query = String.Format("SELECT Movies.movie_id, Movies.cover FROM Movies JOIN Movies_Genres ON Movies.movie_id = Movies_Genres.movie_id WHERE Movies_Genres.genre_id = {0} AND @CONDITIONS", this.genre["genre_id"]);
                Helpers.ShowMovies(this.FindForm(), query);
            }
        }
    }
}
