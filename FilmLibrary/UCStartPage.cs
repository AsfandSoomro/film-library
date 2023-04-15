﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace FilmLibrary
{
    public partial class UCStartPage : UserControl
    {
        public UCStartPage()
        {
            InitializeComponent();
        }

        private void UCStartPage_Load(object sender, EventArgs e)
        {
            lblWelcome.Parent = pbPosters;
            lblWelcome2.Parent = pbPosters;

            /*
            // Opens the top 250 movies inserts code file and inserts the movies along with their cover
            using (StreamReader reader = new StreamReader(@"F:\Uni Class Stuff\Part IV\7th Semester\Visual Programming\Project\FilmLibrary\\other\data\top_250_movies\movies.txt"))
            {
                while(!reader.EndOfStream)
                {
                    string q = reader.ReadLine();
                    string cover_path = reader.ReadLine(); // Cover path line after each insert

                    byte[] arr = Utils.ImageToByte(new Bitmap(@cover_path.Replace('/', '\\')));
                    
                    SqlConnection conn = new SqlConnection(Program.DatabasePath);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@q, conn);

                    cmd.Parameters.AddWithValue("@cover", arr); 
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                lblWelcome.Text = "Successfully read from a file!";
            }
            */
            
        }

    }
}
