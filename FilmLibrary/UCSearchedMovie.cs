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
    public partial class UCSearchedMovie : UserControl
    {
        public UCSearchedMovie(int movie_id, string title, int release_year, Image cover)
        {
            InitializeComponent();

            this.lblTitle.Text = title;
            this.lblReleaseYear.Text = "(" + release_year.ToString() + ")";
            this.pbCover.Image = cover;

            this.MakeChildControlsInheritEvents();
        }

        private void panelSearchedMovie_MouseEnter(object sender, EventArgs e)
        {
            Color color = this.panelSearchedMovie.BackColor;
            this.panelSearchedMovie.BackColor = Color.FromArgb(color.R + 40, color.G + 40, color.B + 40);
        }

        private void panelSearchedMovie_MouseLeave(object sender, EventArgs e)
        {
            Color color = this.panelSearchedMovie.BackColor;
            this.panelSearchedMovie.BackColor = Color.FromArgb(color.R - 40, color.G - 40, color.B - 40);
        }

        private void MakeChildControlsInheritEvents()
        {
            foreach(Control control in this.panelSearchedMovie.Controls)
            {
                control.MouseEnter += this.panelSearchedMovie_MouseEnter;
                control.MouseLeave += this.panelSearchedMovie_MouseLeave;
            }
        }
    }
}
