using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmLibrary
{
    public partial class UCCreateWatchlist : UserControl
    {
        int user_id;
        private bool isUserImageUploaded;

        public UCCreateWatchlist(int user_id)
        {
            InitializeComponent();

            this.user_id = user_id;
        }

        private void UCCreateWatchlist_Load(object sender, EventArgs e)
        {
            this.isUserImageUploaded = false;
            rbPrivate.Checked = true;
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
                    choose_image.RestoreDirectory = true;

                    this.isUserImageUploaded = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot upload image.", "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtTitle.Text != txtTitle.OriginalText && !String.IsNullOrEmpty(txtTitle.Text))
            {
                // Enable the create button
                btnCreate.Enabled = true;
                btnCreate.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnCreate.Enabled = false;
                btnCreate.BackColor = Color.SlateGray;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Watchlists(title, cover, visibility, owner_id) VALUES (@title, @cover, @visibility, @owner_id);";

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@title", txtTitle.Text);
                if (this.isUserImageUploaded)
                    command.Parameters.AddWithValue("@cover", Utils.ImageToByte(pbCover.Image));
                else
                    command.Parameters.AddWithValue("@cover", DBNull.Value);
                if (rbPrivate.Checked)
                    command.Parameters.AddWithValue("@visibility", "private");
                else if (rbPublic.Checked)
                    command.Parameters.AddWithValue("@visibility", "public");
                command.Parameters.AddWithValue("@owner_id", user_id);

                command.ExecuteNonQuery();

                conn.Close();

                Helpers.UpdateWatchlistsSideBar();

                MessageBox.Show("Successfully created the watchlist.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
