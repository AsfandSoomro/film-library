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
    public partial class UCProfilePage : UserControl
    {
        private bool isEditMode;
        private bool isUserImageUploaded;

        public UCProfilePage()
        {
            InitializeComponent();
        }

        private void UCProfilePage_Load(object sender, EventArgs e)
        {
            Helpers.ArrangeMainPanelControls(this.FindForm());

            string first_name = Form2.user["first_name"].ToString();
            string last_name = Form2.user["last_name"].ToString();

            lblUsername.Text = Form2.user["username"].ToString();
            if (!String.IsNullOrEmpty(first_name) && !String.IsNullOrEmpty(last_name))
            {

                lblFullName.Text = first_name + " " + last_name;
            }
            else if (!String.IsNullOrEmpty(first_name))
            {
                lblFullName.Text = first_name;
            }
            else if (!String.IsNullOrEmpty(last_name))
            {
                lblFullName.Text = last_name;
            }
            else
            {
                lblFullName.Text = "No Name";
            }

            if(Form2.user["profile_photo"] != DBNull.Value)
                pbProfilePic.Image = Utils.ByteToImage((Byte[])Form2.user["profile_photo"]);

            this.FillUserData();

            this.isEditMode = false;
            this.isUserImageUploaded = false;
        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                try
                {
                    OpenFileDialog choose_image = new OpenFileDialog();
                    choose_image.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                    if (choose_image.ShowDialog() == DialogResult.OK)
                    {
                        Image img = new Bitmap(choose_image.FileName);
                        pbProfilePic.Image = img;
                        choose_image.RestoreDirectory = true;

                        this.isUserImageUploaded = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot upload image.", "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.isEditMode = true;
            panelInfoEdit.Visible = true;
        }

        private void FillUserData()
        {
            txtUsername.Text = Form2.user["username"].ToString();
            txtPassword.Text = Form2.user["password"].ToString();
            if (Form2.user["email"] != DBNull.Value)
                txtEmail.Text = Form2.user["email"].ToString();
            if (Form2.user["first_name"] != DBNull.Value)
                txtFirstName.Text = Form2.user["first_name"].ToString();
            if (Form2.user["last_name"] != DBNull.Value)
                txtLastName.Text = Form2.user["last_name"].ToString();
            dtpDOB.Value = (DateTime)Form2.user["dob"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.isEditMode = false;
            this.isUserImageUploaded = false;
            panelInfoEdit.Visible = false;
            // Resetting with original data
            if (Form2.user["profile_photo"] != DBNull.Value)
                pbProfilePic.Image = Utils.ByteToImage((Byte[])Form2.user["profile_photo"]);
            else
                pbProfilePic.Image = null;
            this.FillUserData();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != Form2.user["username"].ToString())
            {
                int count = await Queries.GetCountRows("Users", String.Format("LOWER(username) = '{0}'", txtUsername.Text.ToLower()));

                if (count != 0)
                {
                    MessageBox.Show("Username already exists.", "Profile Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Users SET username = @username, password = @password, email = @email, first_name = @first_name, last_name = @last_name, dob = @dob, profile_photo = @profile_photo WHERE user_id = @user_id;";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@dob", dtpDOB.Value);
                if (txtEmail.Text != txtEmail.OriginalText && !String.IsNullOrEmpty(txtEmail.Text)) command.Parameters.AddWithValue("@email", txtEmail.Text);
                else command.Parameters.AddWithValue("@email", DBNull.Value);
                if (txtFirstName.Text != txtFirstName.OriginalText && !String.IsNullOrEmpty(txtFirstName.Text)) command.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                else command.Parameters.AddWithValue("@first_name", DBNull.Value);
                if (txtLastName.Text != txtLastName.OriginalText && !String.IsNullOrEmpty(txtLastName.Text)) command.Parameters.AddWithValue("@last_name", txtLastName.Text);
                else command.Parameters.AddWithValue("@last_name", DBNull.Value);
                if (this.isUserImageUploaded) command.Parameters.AddWithValue("@profile_photo", Utils.ImageToByte(pbProfilePic.Image));
                else if(Form2.user["profile_photo"] != DBNull.Value) command.Parameters.AddWithValue("@profile_photo", (Byte[])Form2.user["profile_photo"]);
                else command.Parameters.AddWithValue("@profile_photo", DBNull.Value);

                command.Parameters.AddWithValue("user_id", (int)Form2.user["user_id"]);

                command.ExecuteNonQuery();
                
                conn.Close();

                MessageBox.Show("Successfully updated your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Updating user info in form2
                query = String.Format("SELECT * FROM Users WHERE user_id = {0}", (int)Form2.user["user_id"]);
                Form2.user = (DataRow)(await Queries.GetDataTable("Users", query)).Rows[0];

                // Reloading the page
                Helpers.ShowProfilePage(this.FindForm());
            }
        }
    }
}
