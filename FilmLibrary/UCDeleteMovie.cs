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
    public partial class UCDeleteMovie : UserControl
    {
        private DataRow movie;

        public UCDeleteMovie()
        {
            InitializeComponent();
        }

        private void UCUpdateMovie_Load(object sender, EventArgs e)
        {
            Helpers.ArrangeMainPanelControls(this.FindForm());

            // Get the current year
            int currentYear = DateTime.Now.Year;
            int numYears = 200;
            // Fill the ComboBox with years
            for (int i = currentYear; i >= currentYear - numYears; i--)
            {
                cbYear.Items.Add(i.ToString());
                cbYearFetch.Items.Add(i.ToString());
            }
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string condition = "";

            if (txtMovieId.Text != txtMovieId.OriginalText && !String.IsNullOrEmpty(txtMovieId.Text))
            {
                condition = String.Format("movie_id = {0}", txtMovieId.Text);
            }
            else if (txtImdbIdFetch.Text != txtImdbIdFetch.OriginalText && !String.IsNullOrEmpty(txtImdbIdFetch.Text))
            {
                condition = String.Format("imdb_id = {0}", txtImdbIdFetch.Text);
            }
            else if (txtTitleFetch.Text != txtTitleFetch.OriginalText && !String.IsNullOrEmpty(txtTitleFetch.Text) && cbYearFetch.SelectedItem != null)
            {
                condition = String.Format("title = '{0}' AND release_year = {1}", txtTitle.Text.Replace("'", "''"), cbYearFetch.SelectedItem);
            }
            else
            {
                MessageBox.Show("Unknown entry error.", "Field Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                this.movie = (await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT * FROM Movies WHERE {0}", condition)))).Rows[0];
                this.FillMovieData();
                btnDelete.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No match.", "Movie Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageEnableDisableFetchButton()
        {
            if ((txtMovieId.Text != txtMovieId.OriginalText && !String.IsNullOrEmpty(txtMovieId.Text))
                || (txtImdbIdFetch.Text != txtImdbIdFetch.OriginalText && !String.IsNullOrEmpty(txtImdbIdFetch.Text))
                || (txtTitleFetch.Text != txtTitleFetch.OriginalText && !String.IsNullOrEmpty(txtTitleFetch.Text) && cbYearFetch.SelectedItem != null)
                )
            {
                // Enable the create button
                btnFetch.Enabled = true;
                btnFetch.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnFetch.Enabled = false;
                btnFetch.BackColor = Color.SlateGray;
            }
        }

        private void FillMovieData()
        {
            this.txtTitle.Text = this.movie["title"].ToString();
            this.txtIMDBID.Text = this.movie["imdb_id"].ToString();
            this.txtPlot.Text = this.movie["plot_outline"].ToString();
            this.txtVotes.Text = this.movie["votes"].ToString();
            this.txtBudget.Text = this.movie["budget"].ToString();
            this.txtBoxOffice.Text = this.movie["cumulative_worldwide_gross"].ToString();
            this.cbYear.SelectedItem = this.movie["release_year"].ToString();
            this.numRating.Value = (decimal)this.movie["rating"];
            this.pbCover.Image = Utils.ByteToImage((Byte[])this.movie["cover"]);
            this.pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtMovieId_KeyUp(object sender, KeyEventArgs e)
        {
            this.ManageEnableDisableFetchButton();
        }

        private void txtImdbIdFetch_KeyUp(object sender, KeyEventArgs e)
        {
            this.ManageEnableDisableFetchButton();
        }

        private void txtTitleFetch_KeyUp(object sender, KeyEventArgs e)
        {
            this.ManageEnableDisableFetchButton();
        }

        private void cbYearFetch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ManageEnableDisableFetchButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Movies WHERE movie_id = @movie_id";

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@movie_id", (int)this.movie["movie_id"]);
                command.ExecuteNonQuery();

                conn.Close();

                Helpers.ShowDashboard(this.FindForm());
                MessageBox.Show("Successfully deleted the movie.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
