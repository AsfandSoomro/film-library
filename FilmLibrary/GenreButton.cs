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
    class GenreButton : Button
    {
        private DataRow genre;

        public GenreButton()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font(this.Font.FontFamily, 9, FontStyle.Bold);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new Padding(3, 0, 3, 0);
            this.Dock = DockStyle.Top;
        }

        public GenreButton(DataRow genre) : this()
        {
            this.genre = genre;

            this.Text = (string)genre["name"];

            this.Click += new EventHandler(this.GenreButton_Click);
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != (string)this.genre["name"])
            {
                Form2.currentMainPage = (string)this.genre["name"];
                Helpers.UpdateMainPageHeading();

                string query = String.Format("SELECT Movies.movie_id, Movies.cover FROM Movies JOIN Movies_Genres ON Movies.movie_id = Movies_Genres.movie_id WHERE Movies_Genres.genre_id = {0} AND @CONDITIONS", this.genre["genre_id"]);
                Helpers.ShowMovies(query);
            }
        }
    }
}
