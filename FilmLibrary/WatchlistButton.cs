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
    class WatchlistButton : SideBarSubCategoryButton
    {
        private DataRow watchlist;

        public WatchlistButton()
        {

        }

        public WatchlistButton(DataRow watchlist) : this()
        {
            this.watchlist = watchlist;

            this.Text = (string)watchlist["title"];

            this.Click += new EventHandler(this.WatchlistButton_Click);
        }

        private void WatchlistButton_Click(object sender, EventArgs e)
        {
            if (Form2.currentMainPage != (string)this.watchlist["title"])
            {
                Form2.currentMainPage = (string)this.watchlist["title"];
                Helpers.UpdateMainPageHeading();

                Helpers.ShowWatchlistInfoHeading(this.watchlist);

                string query = String.Format("SELECT Movies.movie_id, Movies.cover FROM Movies JOIN Watchlists_Movies ON Movies.movie_id = Watchlists_Movies.movie_id WHERE Watchlists_Movies.watchlist_id = {0} AND @CONDITIONS", this.watchlist["watchlist_id"]);
                Helpers.ShowMoviesWithoutClear(query);
            }
        }
    }
}
