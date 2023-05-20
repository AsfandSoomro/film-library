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
                //Panel panelContainer = new Panel();
                //panelContainer.BackColor = Color.FromArgb(50, 128, 128, 128);
                //panelContainer.Dock = DockStyle.Fill;

                this.isAddToWatchlistButtonClicked = true;

                UCUserWatchlists uc = new UCUserWatchlists(movie_id, this);

                //panelContainer.Controls.Add(uc);

                Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
                Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

                mainPanel.Controls.Add(uc);
                Utils.CenterControl(uc, form);
                uc.BringToFront();
            }
        }
    }
}
