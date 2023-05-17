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
    public partial class UCSignIn : UserControl
    {
        public UCSignIn()
        {
            InitializeComponent();
        }

        private void txtUsernameAndPassword_KeyUp(object sender, KeyEventArgs e)
        {
            // Check if both username field and password is filled with user's input
            if (
                (txtUsername.Text != txtUsername.OriginalText && txtPassword.Text != txtPassword.OriginalText) &&
                (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                )
            {
                // Enable the sign in button
                btnSignIn2.Enabled = true;
                btnSignIn2.BackColor = Color.FromArgb(255, 182, 157, 116);
            }
            else
            {
                btnSignIn2.Enabled = false;
                btnSignIn2.BackColor = Color.SlateGray;
            }
        }
        
        private async void btnSignIn2_Click(object sender, EventArgs e)
        {
            int count = await Queries.GetCountRows("Users", String.Format("LOWER(username) = '{0}' AND password = '{1}'", txtUsername.Text.ToLower(), txtPassword.Text));

            if (count == 0)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = String.Format("SELECT * FROM Users WHERE LOWER(username) = '{0}'", txtUsername.Text.ToLower());
                DataRow userRow = (DataRow)(await Queries.GetDataTable("Users", query)).Rows[0];
                // Currently opened form
                Form form1 = this.FindForm();
                form1.Hide();

                // The new form to be opened
                Form2 form2 = new Form2(userRow);
                form2.Location = form1.Location;
                form2.Show();
            }
        }
    }
}
