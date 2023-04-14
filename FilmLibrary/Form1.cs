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
        // Flags
        private bool flgCenterControls = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCStartPage uc = new UCStartPage();
           // uc.Dock = DockStyle.Fill;
            //uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.flgCenterControls == true)
                CenterControls(this.panelMain);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UCSignIn uc = new UCSignIn();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
            this.flgCenterControls = true;
            CenterControls(this.panelMain);

            this.btnStartPage.Visible = true;
            this.btnSignIn.Enabled = false;
            this.btnSignUp.Enabled = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UCSignUp uc = new UCSignUp();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
            this.flgCenterControls = true;
            CenterControls(this.panelMain);

            this.btnStartPage.Visible = true;
            this.btnSignIn.Enabled = true;
            this.btnSignUp.Enabled = false;
        }

        private void btnStartPage_Click(object sender, EventArgs e)
        {
            UCStartPage uc = new UCStartPage();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
            this.flgCenterControls = false;

            this.btnStartPage.Visible = false;
            this.btnSignIn.Enabled = true;
            this.btnSignUp.Enabled = true;
        }

        // Center the controls in the panel
        public void CenterControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Location = new Point((this.ClientSize.Width - control.Size.Width) / 2, (this.ClientSize.Height - control.Size.Height) / 2);
            }
        }
    }
}
