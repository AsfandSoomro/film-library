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
    public partial class UCAddMovie : UserControl
    {
        private bool isImageUploaded;

        public UCAddMovie()
        {
            InitializeComponent();
        }

        private void UCAddMovie_Load(object sender, EventArgs e)
        {
            Helpers.ArrangeMainPanelControls(this.FindForm());

            // Get the current year
            int currentYear = DateTime.Now.Year;
            int numYears = 200;
            // Fill the ComboBox with years
            for (int i = currentYear; i >= currentYear - numYears; i--)
            {
                cbYear.Items.Add(i.ToString());
            }

            this.isImageUploaded = false;
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

                    this.isImageUploaded = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot upload image.", "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTitle.Text != txtTitle.OriginalText && !String.IsNullOrEmpty(txtTitle.Text) && cbYear.SelectedItem != null)
            {
                // Enable the create button
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.SlateGray;
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != txtTitle.OriginalText && !String.IsNullOrEmpty(txtTitle.Text) && cbYear.SelectedItem != null)
            {
                // Enable the create button
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.SlateGray;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if movie already exists 
            int count = await Queries.GetCountRows("Movies", String.Format("title = '{0}' AND release_year = {1}", txtTitle.Text, cbYear.SelectedItem.ToString()));
            if(count >= 0)
            {
                MessageBox.Show("Movie already exists with same title and release_year.", "Move Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string query = @"INSERT INTO Movies(imdb_id, title, plot_outline, release_year, rating, votes, cover, budget, cumulative_worldwide_gross) VALUES (@imdb_id, @title, @plot_outline, @release_year, @rating, @votes, @cover, @budget, @cumulative_worldwide_gross);";

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                // IMDB ID
                if(txtIMDBID.Text != txtIMDBID.OriginalText && !String.IsNullOrEmpty(txtIMDBID.Text))
                {
                    if(int.TryParse(txtIMDBID.Text, out int num))
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
                if(numRating.Value >= (decimal)0.0)
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
                    if (this.isImageUploaded)
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

                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully added the movie.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
