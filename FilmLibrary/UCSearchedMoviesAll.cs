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
    public partial class UCSearchedMoviesAll : UserControl
    {
        private DataTable movies;
        public UCSearchedMoviesAll(DataTable movies)
        {
            InitializeComponent();

            this.movies = movies;
        }

        private void UCSearchedMoviesAll_Load(object sender, EventArgs e)
        {
            foreach(DataRow movie in movies.Rows)
            {
                UCSearchedMovie uc = new UCSearchedMovie((int)movie["movie_id"], (string)movie["title"], (int)movie["release_year"], Utils.ByteToImage((Byte[])movie["cover"]));
                uc.BorderStyle = BorderStyle.FixedSingle;
                uc.Margin = new Padding(20, 13, 20, 13);
                uc.Size = new Size(flpSearchedMoviesAllContainer.Width - uc.Margin.Left - uc.Margin.Right, uc.Size.Height);

                flpSearchedMoviesAllContainer.Controls.Add(uc);
            }
        }

        private void flpSearchedMoviesAllContainer_Resize(object sender, EventArgs e)
        {
            // Increase all searched movies container's width to fit screen
            foreach(UCSearchedMovie uc in flpSearchedMoviesAllContainer.Controls)
            {
                uc.Size = new Size(flpSearchedMoviesAllContainer.Width - uc.Margin.Left - uc.Margin.Right, uc.Size.Height);
            }
        }
    }
}
