using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FilmLibrary
{
    class MyTextBox : TextBox
    {
        private string originalText;
        private bool isPassword;

        [Browsable(true)] // Make the property visible in the property window
        public string OriginalText
        {
            get { return originalText; }
            set { originalText = value; }
        }

        [Browsable(true)]
        public bool IsPassword
        {
            get { return isPassword; }
            set { isPassword = value; }
        }

        public MyTextBox()
        {
            this.BackColor = Color.FromArgb(24, 26, 40);
            this.ForeColor = Color.FromArgb(245, 245, 239);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Size = new Size(228, 26);
            this.Font = new Font(this.Font.FontFamily, 12);

            this.originalText = "";
            this.IsPassword = false;

            this.Enter += new EventHandler(this.MyTextBox_Enter);
            this.Leave += new EventHandler(this.MyTextBox_Leave);
        }

        private void MyTextBox_Enter(object sender, EventArgs e)
        {
            if (this.Text == this.originalText)
            {
                this.Text = "";
            }
            this.BackColor = Color.FromArgb(255, 245, 245, 239);
            this.ForeColor = Color.Black;

            if (this.isPassword) this.PasswordChar = '*';
        }

        private void MyTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = this.originalText;
                if (this.isPassword) this.PasswordChar = '\0';
            }
            this.BackColor = Color.FromArgb(24, 26, 40);
            this.ForeColor = Color.FromArgb(255, 245, 245, 239);
        }

    }
}
