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
    public partial class UCSignUp : UserControl
    {
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void txtUsernameAndPassword_KeyUp(object sender, KeyEventArgs e)
        {
            // Check if both username field and password is filled with user's input
            if (
                (txtUsernameSU.Text != "Username" && txtPasswordSU.Text != "Password") &&
                (!string.IsNullOrEmpty(txtUsernameSU.Text) && !string.IsNullOrEmpty(txtPasswordSU.Text))
                )
            {
                // Enable the sign in button
                btnSignUp2.Enabled = true;
                btnSignUp2.BackColor = Color.FromArgb(255, 182, 157, 116);
            }
            else
            {
                btnSignUp2.Enabled = false;
                btnSignUp2.BackColor = Color.SlateGray;
            }
        }

        private async void btnSignUp2_Click(object sender, EventArgs e)
        {
            int count = await Queries.GetCountRows("Users", String.Format("LOWER(username) = '{0}'", txtUsernameSU.Text.ToLower()));

            if (count != 0)
            {
                MessageBox.Show("Username already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Users(username, password, email, first_name, last_name, dob) VALUES(@username, @password, @email, @first_name, @last_name, @dob);";
                
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", txtUsernameSU.Text);
                command.Parameters.AddWithValue("@password", txtPasswordSU.Text);
                command.Parameters.AddWithValue("@dob", dtpDOB.Value);
                if(txtEmail.Text != txtEmail.OriginalText) command.Parameters.AddWithValue("@email", txtEmail.Text);
                else command.Parameters.AddWithValue("@email", DBNull.Value);
                if (txtFirstName.Text != txtFirstName.OriginalText) command.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                else command.Parameters.AddWithValue("@first_name", DBNull.Value);
                if (txtLastName.Text != txtLastName.OriginalText) command.Parameters.AddWithValue("@last_name", txtLastName.Text);
                else command.Parameters.AddWithValue("@last_name", DBNull.Value);

                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully created your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
