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
        }

        public void MouseEntered()
        {
            btnAddToWatchlist.Visible = true;
        }

        public void MouseLeft()
        {
            btnAddToWatchlist.Visible = false;
        }
    }
}
