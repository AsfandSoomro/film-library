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
        private Timer timerDisposeForm2;

        // Flags
        private bool flgCenterControls = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timerDisposeForm2_Tick(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
                //form2.Dispose();
            this.timerDisposeForm2.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                this.timerDisposeForm2 = new Timer();
                this.timerDisposeForm2.Enabled = true;
                this.timerDisposeForm2.Interval = 4000;
                this.timerDisposeForm2.Tick += new EventHandler(timerDisposeForm2_Tick);
            }

            UCStartPage uc = new UCStartPage();
           // uc.Dock = DockStyle.Fill;
            //uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.flgCenterControls == true)
                Utils.CenterControls(this.panelMain, this);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UCSignIn uc = new UCSignIn();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc);
            this.flgCenterControls = true;
            Utils.CenterControls(this.panelMain, this);

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
            Utils.CenterControls(this.panelMain, this);

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
    }
}
