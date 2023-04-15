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
            this.Click += new EventHandler(this.MoviePictureBox_MouseClick);
        }

        public MoviePictureBox(DataRow movie) : this()
        {
            this.movie = movie;
            this.Image = (Image)Utils.ByteToImage((Byte[])movie["cover"]);
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
        private void MoviePictureBox_MouseClick(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;
           
            UCMovie uc = new UCMovie(this.movie);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }
    }
}
