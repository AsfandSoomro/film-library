using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FilmLibrary
{
    class SideBarSubCategoryButton : Button
    {
        public SideBarSubCategoryButton()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.FromArgb(245, 245, 239);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font(this.Font.FontFamily, 9);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.Margin = new Padding(3, 0, 3, 0);
            this.Dock = DockStyle.Top;
        }
    }
}