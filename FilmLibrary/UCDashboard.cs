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
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }

        private async void UCDashboard_Load(object sender, EventArgs e)
        {
            int totalMovies = (await Task.Run(() => Queries.GetCountRows("Movies")));
            lblMovies.Text = totalMovies.ToString();
            lblUsers.Text = (await Task.Run(() => Queries.GetCountRows("Users", "status = 'user'"))).ToString();
            lblAdmins.Text = (await Task.Run(() => Queries.GetCountRows("Users", "status = 'admin'"))).ToString();
            lblWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists"))).ToString();
            lblPubWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists", "visibility = 'public'"))).ToString();
            lblPrivateWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists", "visibility = 'private'"))).ToString();
            lblMoviesAddedToWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists_Movies"))).ToString();

            Random rand = new Random();
            int randomId = rand.Next(0, totalMovies - 12 - 1);
            DataTable covers = (await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT TOP 12 cover FROM Movies WHERE movie_id > {0}", randomId))));
            
            int i = 1;
            foreach(DataRow cover in covers.Rows)
            {
                PictureBox pb = (PictureBox)this.Controls.Find("pbCoverSmall" + i, true)[0];
                pb.Image = Utils.ByteToImage((Byte[])cover["cover"]);

                i++;
            }
        }
    }
}
