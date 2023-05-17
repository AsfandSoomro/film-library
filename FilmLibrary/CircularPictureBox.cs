using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace FilmLibrary
{
    public class CircularPictureBox : PictureBox
    {
        /*private static string DefaultProfilePicImagePath = @"F:\Uni Class Stuff\Part IV\7th Semester\Visual Programming\Project\FilmLibrary\images\profile_picture_default.jpg";
        private Image image;

        public event EventHandler ImageChanged;

        //To Overried default Image property
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image Image
        {
            get => image;
            set
            {
                if (image != value)
                {
                    image = value;
                    OnImageChanged(EventArgs.Empty);
                    base.Image = image;
                }
            }
        }
        
        protected virtual void OnImageChanged(EventArgs e)
        {
            ImageChanged?.Invoke(this, e);
        } */

        public CircularPictureBox()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, Width, Height);
                Region = new Region(path);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.SetClip(path);
                base.OnPaint(e);
            }
        }
    }
}