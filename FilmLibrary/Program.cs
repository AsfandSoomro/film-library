using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FilmLibrary
{
    static class Program
    {
        public const string DatabasePath = "F:\\Uni Class Stuff\\Part IV\\7th Semester\\Visual Programming\\Project\\FilmLibrary\\FilmLibrary\\Database1.mdf";
        public const string MyConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + DatabasePath + "\";Integrated Security=True";
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2((DataRow)(Queries.GetDataTableNonAsync("Users", "SELECT * FROM Users WHERE username = 'asfand'")).Rows[0]));
            Application.Run(new Form1());
        }
    }
}
