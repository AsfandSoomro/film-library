using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace FilmLibrary
{
    class MoviePictureBox : PictureBox
    {
        private static string DefaultMovieImagePath = @"F:\Uni Class Stuff\Part IV\7th Semester\Visual Programming\Project\FilmLibrary\images\Braveheart.jpg";
        private Image OriginalImage;
        private int movie_id;
        private DataRow movie;

        public MoviePictureBox()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Margin = new Padding(10);
            this.Size = new Size(205, 295);
            this.Cursor = Cursors.Hand;
            if (this.OriginalImage == null)
            {
                this.Image = new Bitmap(DefaultMovieImagePath);
                this.OriginalImage = this.Image;
            }

            this.MouseHover += new EventHandler(this.MoviePictureBox_MouseHover);
            this.MouseLeave += new EventHandler(this.MoviePictureBox_MouseLeave);
            this.Click += new EventHandler(this.MoviePictureBox_Click);
        }

        public MoviePictureBox(int movie_id, Byte[] cover) : this() // movie parameter might only get id and cover photo
        {
            this.movie_id = (int)movie_id;
            this.Image = (Image)Utils.ByteToImage(cover);
            this.OriginalImage = this.Image;
        }

        // Default Mouse Hover Event
        private void MoviePictureBox_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Image = Utils.ZoomIn((Bitmap)this.Image, 80);
        }

        // Default Mouse Leave Event
        private void MoviePictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Image = OriginalImage;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        // Default Mouse Click Event
        private async void MoviePictureBox_Click(object sender, EventArgs e)
        {
            // Get the movie data and store in move attribute
            string query = String.Format("SELECT * FROM Movies WHERE movie_id = {0}", this.movie_id.ToString());
            this.movie = (DataRow)(await Queries.GetDataTable("Movies", query)).Rows[0];

            Helpers.OpenMoviePage(this.FindForm(), this.movie);
        }
    }
}
