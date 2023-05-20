using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class UCUserWatchlist : UserControl
    {
        DataRow watchlist;
        int movie_id;

        public UCUserWatchlist()
        {
            InitializeComponent();
        }

        public UCUserWatchlist(DataRow watchlist, int movie_id) : this()
        {
            this.watchlist = watchlist;
            this.movie_id = movie_id;
        }

        private async void UCUserWatchlist_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = (string)watchlist["title"];

            // Check if movie is already in the watchlist by getting the row count
            int countRows = await Queries.GetCountRows("Watchlists_Movies", String.Format("watchlist_id = {0} AND movie_id = {1}", (int)watchlist["watchlist_id"], movie_id));

            if(countRows >= 1)
            {
                btnRemove.Enabled = true;
                btnRemove.Visible = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnAdd.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO Watchlists_Movies(watchlist_id, movie_id) VALUES ({0}, {1});", (int)watchlist["watchlist_id"], movie_id);

            Queries.InsertRow(query);
            //MessageBox.Show(String.Format("Successfully added the move to watchlist {0}.", (string)watchlist["title"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.UpdateButtons();
            Helpers.UpdateWatchlistsSideBar();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM Watchlists_Movies WHERE watchlist_id = {0} AND movie_id = {1};", (int)watchlist["watchlist_id"], movie_id);

            Queries.DeleteRows(query);
            //MessageBox.Show(String.Format("Successfully deleted the move from watchlist {0}.", (string)watchlist["title"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.UpdateButtons();
            Helpers.UpdateWatchlistsSideBar();
        }

        private void UpdateButtons()
        {
            btnRemove.Enabled = !btnRemove.Enabled;
            btnRemove.Visible = !btnRemove.Visible;

            btnAdd.Enabled = !btnAdd.Enabled;
            btnAdd.Visible = !btnAdd.Visible;
        }

    }
}
