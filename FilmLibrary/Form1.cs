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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCStartPage uc = new UCStartPage();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UCLogin uc = new UCLogin();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UCSignUp uc = new UCSignUp();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
        }
    }
}
