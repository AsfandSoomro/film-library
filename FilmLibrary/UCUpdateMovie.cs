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
    public partial class UCUpdateMovie : UserControl
    {
        private DataRow movie;

        public UCUpdateMovie()
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

            if(txtMovieId.Text != txtMovieId.OriginalText && !String.IsNullOrEmpty(txtMovieId.Text))
            {
                condition = String.Format("movie_id = {0}", txtMovieId.Text);
            }
            else if (txtImdbIdFetch.Text != txtImdbIdFetch.OriginalText && !String.IsNullOrEmpty(txtImdbIdFetch.Text))
            {
                condition = String.Format("imdb_id = {0}", txtImdbIdFetch.Text);
            }
            else if (txtTitleFetch.Text != txtTitleFetch.OriginalText && !String.IsNullOrEmpty(txtTitleFetch.Text) &&cbYearFetch.SelectedItem != null)
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
            }
            catch(Exception)
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
            this.txtPlot.Text  = this.movie["plot_outline"].ToString();
            this.txtVotes.Text = this.movie["votes"].ToString();
            this.txtBudget.Text = this.movie["budget"].ToString();
            this.txtBoxOffice.Text = this.movie["cumulative_worldwide_gross"].ToString();
            this.cbYear.SelectedItem = this.movie["release_year"].ToString();
            this.numRating.Value = (decimal)this.movie["rating"];
            this.pbCover.Image = Utils.ByteToImage((Byte[])this.movie["cover"]);
            this.pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnRemoveCover.Enabled = true;
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

        private void pbCover_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choose_image = new OpenFileDialog();
                choose_image.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                if (choose_image.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(choose_image.FileName);
                    pbCover.Image = img;
                    pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
                    choose_image.RestoreDirectory = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot upload image.", "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveCover_Click(object sender, EventArgs e)
        {
            pbCover.Image = null;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if movie already exists (only if title and release_year are changed)
            if (txtTitle.Text != this.movie["title"].ToString() || cbYear.SelectedItem.ToString() != this.movie["release_year"].ToString())
            {
                int count = await Queries.GetCountRows("Movies", String.Format("title = '{0}' AND release_year = {1}", txtTitle.Text, cbYear.SelectedItem.ToString()));
                if (count >= 0)
                {
                    MessageBox.Show("Movie already exists with same title and release_year.", "Move Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string query = @"UPDATE Movies SET imdb_id = @imdb_id, title = @title, plot_outline = @plot_outline, release_year = @release_year, rating = @rating, votes = @votes, cover = @cover, budget = @budget, cumulative_worldwide_gross = @cumulative_worldwide_gross WHERE movie_id = @movie_id;";

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                // IMDB ID
                if (txtIMDBID.Text != txtIMDBID.OriginalText && !String.IsNullOrEmpty(txtIMDBID.Text))
                {
                    if (int.TryParse(txtIMDBID.Text, out int num))
                        command.Parameters.AddWithValue("@imdb_id", num);
                    else
                        MessageBox.Show("IMdb id is incorrect.", "Field Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.Parameters.AddWithValue("@imdb_id", DBNull.Value);
                }

                // Title
                command.Parameters.AddWithValue("@title", txtTitle.Text);

                // Plot Outline
                if (txtPlot.Text != txtPlot.OriginalText && !String.IsNullOrEmpty(txtPlot.Text))
                    command.Parameters.AddWithValue("@plot_outline", txtPlot.Text);
                else
                    command.Parameters.AddWithValue("@plot_outline", DBNull.Value);

                // Release year
                command.Parameters.AddWithValue("@release_year", Convert.ToInt32(cbYear.SelectedItem.ToString()));

                // Rating
                if (numRating.Value >= (decimal)0.0)
                    command.Parameters.AddWithValue("@rating", numRating.Value);
                else
                    command.Parameters.AddWithValue("@rating", DBNull.Value);

                //Votes
                if (txtVotes.Text != txtVotes.OriginalText && !String.IsNullOrEmpty(txtVotes.Text))
                {
                    if (Int64.TryParse(txtVotes.Text, out Int64 num))
                        command.Parameters.AddWithValue("@votes", num);
                    else
                        MessageBox.Show("Votes are incorrect.", "Field Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.Parameters.AddWithValue("@votes", DBNull.Value);
                }

                // Cover
                try
                {
                    if(pbCover.Image != null)
                        command.Parameters.AddWithValue("@cover", Utils.ImageToByte(pbCover.Image));
                    else
                        command.Parameters.AddWithValue("@cover", DBNull.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something unexpected happen with cover.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Budget
                if (txtBudget.Text != txtBudget.OriginalText && !String.IsNullOrEmpty(txtBudget.Text))
                {
                    if (Int64.TryParse(txtBudget.Text, out Int64 num))
                        command.Parameters.AddWithValue("@budget", num);
                    else
                        MessageBox.Show("Budget is incorrect.", "Field Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.Parameters.AddWithValue("@budget", DBNull.Value);
                }

                // Box office
                if (txtBoxOffice.Text != txtBoxOffice.OriginalText && !String.IsNullOrEmpty(txtBoxOffice.Text))
                {
                    if (Int64.TryParse(txtBoxOffice.Text, out Int64 num))
                        command.Parameters.AddWithValue("@cumulative_worldwide_gross", num);
                    else
                        MessageBox.Show("Box office is incorrect.", "Field Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command.Parameters.AddWithValue("@cumulative_worldwide_gross", DBNull.Value);
                }

                command.Parameters.AddWithValue("@movie_id", (int)this.movie["movie_id"]);

                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully updated the movie.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
