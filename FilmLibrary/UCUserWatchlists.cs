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
    public partial class UCUserWatchlists : UserControl
    {
        private int movie_id;
        public UCMovie parentMovie;

        public UCUserWatchlists()
        {
            InitializeComponent();
        }

        public UCUserWatchlists(int movie_id) : this()
        {
            this.movie_id = movie_id;
        }

        public UCUserWatchlists(int movie_id, UCMovie parentMovie) : this()
        {
            this.movie_id = movie_id;
            this.parentMovie = parentMovie;
        }

        private async void UCUserWatchlists_Load(object sender, EventArgs e)
        {
            string query = String.Format("SELECT * FROM Watchlists WHERE owner_id = {0}", (int)Form2.user["user_id"]);
            DataTable watchlists = (DataTable)(await Task.Run(() => Queries.GetDataTable("Watchlists", query)));

            foreach (DataRow watchlist in watchlists.Rows)
            {
                UCUserWatchlist uc = new UCUserWatchlist(watchlist, movie_id);
                uc.Dock = DockStyle.Top;
                this.panelWatchlistsContainer.Controls.Add(uc);
            }
        }
    }
}
