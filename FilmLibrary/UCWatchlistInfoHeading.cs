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
    public partial class UCWatchlistInfoHeading : UserControl
    {
        DataRow watchlist;

        public UCWatchlistInfoHeading()
        {
            InitializeComponent();
        }

        public UCWatchlistInfoHeading(DataRow watchlist) : this()
        {
            this.watchlist = watchlist;
        }

        private async void UCWatchlistInfoHeading_Load(object sender, EventArgs e)
        {
            lblTitle.Text = (string)this.watchlist["title"];

            string owner_name = (string)(await Queries.GetDataTable("Users", String.Format("SELECT username FROM Users WHERE user_id = {0}", (int)this.watchlist["owner_id"]))).Rows[0]["username"];
            lblCreatedBy.Text = lblCreatedBy.Text + " " + owner_name;

            DateTime creation_date = (DateTime)this.watchlist["creation_date"];
            string date_formatted = creation_date.ToString("dd MMMM yyyy");
            lblCreationDate.Text = lblCreationDate.Text + " " + date_formatted;

            lblVisibility.Text = lblVisibility.Text + " " + char.ToUpper(((string)this.watchlist["visibility"])[0]) + ((string)this.watchlist["visibility"]).Substring(1);
            
            int movies_count = (int)(await Queries.GetCountRows("Watchlists_Movies", String.Format("watchlist_id = {0}", this.watchlist["watchlist_id"])));
            lblMoviesCount.Text = lblMoviesCount.Text + " " + movies_count;

            if(this.watchlist["cover"] != DBNull.Value)  
                pbCover.Image = Utils.ByteToImage((Byte[])this.watchlist["cover"]);
        }
    }
}
