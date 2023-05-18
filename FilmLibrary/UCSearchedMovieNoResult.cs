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
    public partial class UCSearchedMovieNoResult : UserControl
    {
        public UCSearchedMovieNoResult()
        {
            InitializeComponent();
        }

        public UCSearchedMovieNoResult(string text) : this()
        {
            this.lblNoResult.Text = text;
        }
    }
}
