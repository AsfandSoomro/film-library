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
    public partial class UCMoviePage : UserControl
    {
        private DataRow movie;
        public UCMoviePage(DataRow movie)
        {
            InitializeComponent();

            this.movie = movie;
        }

        private void UCMoviePage_Load(object sender, EventArgs e)
        {
            this.pbMovieCover.Image = (Image)Utils.ByteToImage((Byte[])movie["cover"]);
            this.lblMovieTitle.Text = (string)movie["title"];
            this.lblMovieYear.Text = "(" + (int)movie["release_year"] + ")";
            this.lblPlotOutline.Text = (string)movie["plot_outline"];
        }
    }
}
