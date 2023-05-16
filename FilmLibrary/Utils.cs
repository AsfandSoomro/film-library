using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FilmLibrary
{
    class Utils
    {
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Bitmap ZoomIn(Bitmap img, int percent)
        {
            int width = img.Width;
            int height = img.Height;

            int newWidth = width * percent / 100;
            int newHeight = height * percent / 100;

            int startX = (width - newWidth) / 2;
            int startY = (height - newHeight) / 2;

            Rectangle srcRect = new Rectangle(startX, startY, newWidth, newHeight);

            Bitmap dst = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(dst);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, new Rectangle(0, 0, newWidth, newHeight), srcRect, GraphicsUnit.Pixel);

            return dst;
        }

        public static bool IsClickedWithinBounds(Control control, Point location)
        {
            // Check if the location is within the bounds of the control or any of its child controls
            Rectangle panelBounds = control.RectangleToScreen(control.ClientRectangle);
            if (panelBounds.Contains(location))
                return true;

            // Check child controls recursively
            foreach (Control child in control.Controls)
            {
                if (IsClickedWithinBounds(child, location))
                    return true;
            }

            return false;
        }
    }
}
