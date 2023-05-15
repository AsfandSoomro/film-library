using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }

}
