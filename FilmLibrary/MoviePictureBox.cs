using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FilmLibrary
{
    class MoviePictureBox : PictureBox
    {
        private static string DefaultMovieImagePath = @"F:\Uni Class Stuff\Part IV\7th Semester\Visual Programming\Project\FilmLibrary\images\Braveheart.jpg";
        private Image OriginalImage;

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
        }

        public MoviePictureBox(Image cover) : this()
        {
            this.Image = cover;
            this.OriginalImage = this.Image;
        }

        // Default Mouse Hover Event
        private void MoviePictureBox_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Image = Utils.ZoomIn((Bitmap)this.Image, 80);
        }

        // Default Mouves Leave Event
        private void MoviePictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Image = OriginalImage;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
