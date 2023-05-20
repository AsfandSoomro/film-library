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
    public partial class UCUpdateWatchlist : UserControl
    {
        private DataRow watchlist;
        private bool isUserImageUploaded;

        public UCUpdateWatchlist()
        {
            InitializeComponent();
        }

        public UCUpdateWatchlist(DataRow watchlist) : this()
        {
            this.watchlist = watchlist;
        }

        private void UCUpdateWatchlist_Load(object sender, EventArgs e)
        {
            txtTitle.Text = (string)watchlist["title"];
            txtTitle.OriginalText = (string)watchlist["title"];
            
            if((string)watchlist["visibility"] == "private")
            {
                rbPrivate.Checked = true;
            }
            else
            {
                rbPublic.Checked = true;
            }

            pbCover.Image = Utils.ByteToImage((Byte[])watchlist["cover"]);

            this.isUserImageUploaded = false;
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

                    // Enable the update button
                    btnUpdate.Enabled = true;
                    btnUpdate.BackColor = Color.FromArgb(91, 125, 166);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot upload image.", "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTitle.Text != txtTitle.OriginalText && !String.IsNullOrEmpty(txtTitle.Text))
            {
                // Enable the update button
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.SlateGray;
            }
        }

        private void rbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPrivate.Checked && (string)watchlist["visibility"] == "public")
            {
                // Enable the update button
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.SlateGray;
            }
        }

        private void rbPublic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPublic.Checked && (string)watchlist["visibility"] == "private")
            {
                // Enable the update button
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(91, 125, 166);
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.SlateGray;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query;

            if(this.isUserImageUploaded)
            {
                query = @"UPDATE Watchlists SET title = @title, cover = @cover, visibility = @visibility WHERE watchlist_id = @watchlist_id";
            }
            else
            {
                query = @"UPDATE Watchlists SET title = @title, visibility = @visibility WHERE watchlist_id = @watchlist_id";
            }

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@title", txtTitle.Text);
                if (this.isUserImageUploaded)
                    command.Parameters.AddWithValue("@cover", Utils.ImageToByte(pbCover.Image));
                if (rbPrivate.Checked)
                    command.Parameters.AddWithValue("@visibility", "private");
                else if (rbPublic.Checked)
                    command.Parameters.AddWithValue("@visibility", "public");
                command.Parameters.AddWithValue("@watchlist_id", (int)watchlist["watchlist_id"]);

                command.ExecuteNonQuery();

                conn.Close();

                Helpers.UpdateWatchlistsSideBar();

                MessageBox.Show("Successfully updated the watchlist.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Default values (for no changes)
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.SlateGray;
                this.isUserImageUploaded = false;
                // Updating the datarow
                this.watchlist["title"] = txtTitle.Text;
                if (rbPrivate.Checked)
                    this.watchlist["visibility"] = "private";
                else if (rbPublic.Checked)
                    this.watchlist["visibility"] = "public";
            }
        }
    }
}
