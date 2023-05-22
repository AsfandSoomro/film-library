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
        int totalMovies;

        public UCDashboard()
        {
            InitializeComponent();
        }

        private async void UCDashboard_Load(object sender, EventArgs e)
        {
            Helpers.ArrangeMainPanelControls(this.FindForm());

            this.totalMovies = (await Task.Run(() => Queries.GetCountRows("Movies")));
            lblMovies.Text = this.totalMovies.ToString();
            lblUsers.Text = (await Task.Run(() => Queries.GetCountRows("Users", "status = 'user'"))).ToString();
            lblAdmins.Text = (await Task.Run(() => Queries.GetCountRows("Users", "status != 'user'"))).ToString();
            lblWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists"))).ToString();
            lblPubWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists", "visibility = 'public'"))).ToString();
            lblPrivateWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists", "visibility = 'private'"))).ToString();
            lblMoviesAddedToWatchlists.Text = (await Task.Run(() => Queries.GetCountRows("Watchlists_Movies"))).ToString();

            UpdateCovers();
            //timerUpdateCovers.Enabled = true;
        }

        private void timerUpdateCovers_Tick(object sender, EventArgs e)
        {
            UpdateCovers();
        }

        private async void UpdateCovers()
        {
            try
            {
                Random rand = new Random();
                int randomId = rand.Next(0, totalMovies - 12 - 1);
                DataTable movies = (await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT TOP 12 movie_id, cover FROM Movies WHERE movie_id > {0}", randomId))));

                int i = 1;
                foreach (DataRow movie in movies.Rows)
                {
                    MoviePictureBox pb = (MoviePictureBox)this.Controls.Find("pbCoverSmall" + i, true)[0];
                    pb.OriginalImage = Utils.ByteToImage((Byte[])movie["cover"]);
                    pb.Image = pb.OriginalImage;
                    pb.movie_id = (int)movie["movie_id"];

                    i++;
                }
            }
            catch(Exception)
            {
                ;
            }
        }
    }
}
