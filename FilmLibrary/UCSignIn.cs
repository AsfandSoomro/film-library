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

        private void UCSignIn_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
            txtUsername.BackColor = Color.FromArgb(255, 245, 245, 239);
            txtUsername.ForeColor = Color.Black;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            txtUsername.BackColor = Color.FromArgb(255, 31, 40, 57);
            txtUsername.ForeColor = Color.FromArgb(255, 245, 245, 239);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
            txtPassword.BackColor = Color.FromArgb(255, 245, 245, 239);
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
            txtPassword.BackColor = Color.FromArgb(255, 31, 40, 57);
            txtPassword.ForeColor = Color.FromArgb(255, 245, 245, 239);
        }

        private void txtUsernameAndPassword_KeyUp(object sender, KeyEventArgs e)
        {
            // Check if both username field and password is filled with user's input
            if (
                (txtUsername.Text != "Username" && txtPassword.Text != "Password") &&
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
        
        private void btnSignIn2_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "asfand" && txtPassword.Text == "asfand")
            {
                // Currently opened form
                Form form1 = Application.OpenForms["Form1"];
                form1.Hide();

                // The new form to be opened
                Form2 form2 = new Form2();
                form2.Location = form1.Location;
                form2.Show();
            }
        }
    }
}
