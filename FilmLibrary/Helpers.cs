using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilmLibrary
{
    class Helpers
    {
        public static void ShowDashboard()
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCMovies uc = new UCMovies("SELECT @LIMIT movie_id, cover FROM Movies WHERE @CONDITIONS");
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void OpenMoviePage(Form form, DataRow movie)
        {
            // Finds the panels in the given opened instance of Form2
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            // Dispose the searched movies container
            DisposeSearchedMoviesContainerFlowLayoutPanel(form);

            // Clear search textbox
            TextBox txtSearch = form.Controls.Find("txtSearch", true).FirstOrDefault() as TextBox;
            if(txtSearch.Text != "Search")
                txtSearch.Text = "Search";

            // Initialize the Movie UserControl and pass it the movie data clearing the current content
            UCMovie uc = new UCMovie(movie);
            uc.Dock = DockStyle.Fill;
            foreach (Control control in mainPanel.Controls) control.Dispose();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static FlowLayoutPanel CreateSearchedMoviesContainerFlowLayoutPanel(Form form)
        {
            Panel panelSideBar = form.Controls.Find("panelSideBar", true).FirstOrDefault() as Panel;

            FlowLayoutPanel flp = new FlowLayoutPanel();

            flp.BackColor = Color.FromArgb(31, 40, 57);
            flp.BorderStyle = BorderStyle.FixedSingle;
            flp.Size = new Size(558, 235);
            flp.Location = new Point(49 + panelSideBar.Width, 63 - 16);
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;

            return flp;
        }

        public static void DisposeSearchedMoviesContainerFlowLayoutPanel(Form form)
        {
            // Finds the searched movies flow container and disposes it
            FlowLayoutPanel searchedMoviesContainerPanel = form.Controls.Find("flpSearchedMoviesContainerRuntime", true).FirstOrDefault() as FlowLayoutPanel;
            if (searchedMoviesContainerPanel != null)
                searchedMoviesContainerPanel.Dispose();
        }
    }
}
