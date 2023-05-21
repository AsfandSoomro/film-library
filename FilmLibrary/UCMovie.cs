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
    public partial class UCMovie : UserControl
    {
        int movie_id;
        Byte[] cover;

        public bool isAddToWatchlistButtonClicked;

        public UCMovie()
        {
            InitializeComponent();
        }

        public UCMovie(int movie_id, Byte[] cover) : this()
        {
            this.movie_id = movie_id;
            this.cover = cover;
        }

        private void UCMovie_Load(object sender, EventArgs e)
        {
            this.pbMovie.Update(this.movie_id, this.cover);
            this.btnAddToWatchlist.Parent = this.pbMovie;
            this.isAddToWatchlistButtonClicked = false;
        }

        public void MouseEntered()
        {
            btnAddToWatchlist.Visible = true;
        }

        public void MouseLeft()
        {
            btnAddToWatchlist.Visible = false;
        }

        private void btnAddToWatchlist_Click(object sender, EventArgs e)
        {
            if (this.isAddToWatchlistButtonClicked == false)
            {
                this.isAddToWatchlistButtonClicked = true;

                Helpers.ShowAddToWatchlistsUC(movie_id, this);
            }
        }
    }
}
