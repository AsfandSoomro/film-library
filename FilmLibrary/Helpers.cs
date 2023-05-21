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
        public static void UpdateMainPageHeading()
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            Label heading = form.Controls.Find("lblMainPageHeading", true).FirstOrDefault() as Label;
            heading.Text = Form2.currentMainPage;
        }
        public static void ShowMovies(string query)
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            query = query.Replace("SELECT", "SELECT @LIMIT");
            UCMovies uc = new UCMovies(query);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void ShowMoviesWithoutClear(string query)
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            query = query.Replace("SELECT", "SELECT @LIMIT");
            UCMovies uc = new UCMovies(query);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        public static void ShowHome()
        {
            Form2.currentMainPage = "Home";
            UpdateMainPageHeading();

            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCMovies uc = new UCMovies("SELECT @LIMIT movie_id, cover FROM Movies WHERE @CONDITIONS");
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public async static void ShowSearchedMovies(string searchQuery)
        {
            Form2.currentMainPage = String.Format("Search result for - \"{0}\"", searchQuery);
            UpdateMainPageHeading();

            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            DataTable movies = await Task.Run(() => Queries.GetDataTable("Movies", String.Format("SELECT movie_id, cover, title, release_year FROM Movies WHERE LOWER(title) LIKE '{0}%'", searchQuery.ToLower())));
            UCSearchedMoviesAll uc = new UCSearchedMoviesAll(movies);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void ShowWatchlistInfoHeading(DataRow watchlist)
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCWatchlistInfoHeading uc = new UCWatchlistInfoHeading(watchlist);
            uc.Dock = DockStyle.Top;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void ShowCreateWatchlistPage(int user_id)
        {
            Form2.currentMainPage = "Create watchlist";
            UpdateMainPageHeading();

            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCCreateWatchlist uc = new UCCreateWatchlist(user_id);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void ShowUpdateWatchlistPage(DataRow watchlist)
        {
            Form2.currentMainPage = "Update watchlist - " + (string)watchlist["title"];
            UpdateMainPageHeading();

            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCUpdateWatchlist uc = new UCUpdateWatchlist(watchlist);
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void OpenMoviePage(Form form, DataRow movie)
        {
            Form2.currentMainPage = "Movie - " + (string)movie["title"];
            Helpers.UpdateMainPageHeading();

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
            UCMoviePage uc = new UCMoviePage(movie);
            uc.Dock = DockStyle.Fill;
            foreach (Control control in mainPanel.Controls) control.Dispose();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public static void ArrangeMoviePageControls()
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            Panel moviePanel = (Panel)mainPanel.Controls.Find("panelContainer", true)[0];

            Size newSize = mainPanel.Size;

            // Calculate the new X position of the control.
            int newLeft = (newSize.Width - moviePanel.Width) / 2;

            moviePanel.Left = newLeft;
            moviePanel.Height = newSize.Height;
            //moviePanel.Width += newLeft/2;
        }

        public static FlowLayoutPanel CreateSearchedMoviesContainerFlowLayoutPanel(Form form)
        {
            TextBox txtSearch = form.Controls.Find("txtSearch", true).FirstOrDefault() as TextBox;

            FlowLayoutPanel flp = new FlowLayoutPanel();

            flp.BackColor = Color.FromArgb(24, 26, 40);
            flp.BorderStyle = BorderStyle.FixedSingle;
            flp.Size = new Size(558, 235);
            flp.Location = new Point(txtSearch.Location.X, 63 - 16);
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

        public static void ShowAddToWatchlistsUC(int movie_id)
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCUserWatchlists uc = new UCUserWatchlists(movie_id);

            mainPanel.Controls.Add(uc);
            Utils.CenterControl(uc, form);
            uc.BringToFront();
        }

        public static void ShowAddToWatchlistsUC(int movie_id, UCMovie parentMovie)
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel containerPanel = form.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            Panel mainPanel = containerPanel.Controls.Find("panelMain", true).FirstOrDefault() as Panel;

            UCUserWatchlists uc = new UCUserWatchlists(movie_id, parentMovie);

            mainPanel.Controls.Add(uc);
            Utils.CenterControl(uc, form);
            uc.BringToFront();
        }

        public static void DisposeAddToWatchlistsUC(Form form)
        {
            // Finds AddToWatchlists UserControl
            UserControl addToWatchlistsUC = form.Controls.Find("UCUserWatchlists", true).FirstOrDefault() as UserControl;
            if (addToWatchlistsUC != null)
            {
                UCUserWatchlists uc = (UCUserWatchlists)addToWatchlistsUC;
                if(uc.parentMovie != null)
                    uc.parentMovie.isAddToWatchlistButtonClicked = false;
                addToWatchlistsUC.Dispose();
            }
        }

        public async static void CreateGenreButtons(Panel panel)
        {
            DataTable genres = (await Queries.GetDataTable("Genres"));

            foreach (DataRow genre in genres.Rows)
            {
                GenreButton btn = new GenreButton(genre);
                panel.Controls.Add(btn);
            } 
        }

        public async static void CreateUserWatchlistButtons(Panel panel, int user_id)
        {
            DataTable watchlists = (await Queries.GetDataTable("Watchlists", String.Format("SELECT * from Watchlists WHERE owner_id = {0}", user_id)));

            foreach (DataRow watchlist in watchlists.Rows)
            {
                WatchlistButton btn = new WatchlistButton(watchlist);
                panel.Controls.Add(btn);
            }
        }

        public async static void CreatePublicWatchlistButtons(Panel panel)
        {
            DataTable watchlists = (await Queries.GetDataTable("Watchlists", "SELECT * from Watchlists WHERE visibility = 'public'"));

            foreach (DataRow watchlist in watchlists.Rows)
            {
                WatchlistButton btn = new WatchlistButton(watchlist);
                panel.Controls.Add(btn);
            }
        }

        public static void DisposeWatchlistButtons(Panel panel)
        {
            foreach (Button btn in panel.Controls)
            {
                if (btn is WatchlistButton)
                {
                    WatchlistButton watchlistButton = (WatchlistButton)btn;
                    watchlistButton.Dispose();
                }
            }
        }

        public static void UpdateWatchlistsSideBar()
        {
            Form form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Panel userWatchlistsPanel = form.Controls.Find("panelUserWatchlistsContainer", true).FirstOrDefault() as Panel;
            Panel publicWatchlistsPanel = form.Controls.Find("panelPublicWatchlistsContainer", true).FirstOrDefault() as Panel;

            Helpers.DisposeWatchlistButtons(userWatchlistsPanel);
            Helpers.CreateUserWatchlistButtons(userWatchlistsPanel, (int)Form2.user["user_id"]);

            Helpers.DisposeWatchlistButtons(publicWatchlistsPanel);
            Helpers.CreatePublicWatchlistButtons(publicWatchlistsPanel);
        }
    }
}
