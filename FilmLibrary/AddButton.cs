using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    class AddButton : Button
    {
        string imagePath = "F:\\Uni Class Stuff\\Part IV\\7th Semester\\Visual Programming\\Project\\FilmLibrary\\images\\add-button.png";

        public AddButton()
        {
            this.Text = "";
            this.BackgroundImage = new Bitmap(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.Size = new Size(24, 24);
        }
    }
}
