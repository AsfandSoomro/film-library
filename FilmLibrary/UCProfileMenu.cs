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
    public partial class UCProfileMenu : UserControl
    {
        public UCProfileMenu()
        {
            InitializeComponent();
        }

        private void UCProfileMenu_Load(object sender, EventArgs e)
        {
            try
            {
                string first_name = Form2.user["first_name"].ToString();
                string last_name = Form2.user["last_name"].ToString();

                lblUsername.Text = Form2.user["username"].ToString();
                if (!String.IsNullOrEmpty(first_name) && !String.IsNullOrEmpty(last_name))
                    lblFullName.Text = first_name + " " + last_name;

                Utils.CenterControlX(lblUsername, panelTop);
                Utils.CenterControlX(lblFullName, panelTop);
            }
            catch(Exception)
            {
                ;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Helpers.ShowProfilePage(this.FindForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Helpers.LogoutUser(this.FindForm());
        }
    }
}
