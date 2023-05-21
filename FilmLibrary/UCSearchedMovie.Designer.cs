
namespace FilmLibrary
{
    partial class UCSearchedMovie
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSearchedMovie));
            this.panelSearchedMovie = new System.Windows.Forms.Panel();
            this.flpTitleAndYear = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.panelSearchedMovie.SuspendLayout();
            this.flpTitleAndYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchedMovie
            // 
            this.panelSearchedMovie.AutoSize = true;
            this.panelSearchedMovie.BackColor = System.Drawing.Color.Transparent;
            this.panelSearchedMovie.Controls.Add(this.flpTitleAndYear);
            this.panelSearchedMovie.Controls.Add(this.pbCover);
            this.panelSearchedMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSearchedMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchedMovie.Location = new System.Drawing.Point(0, 0);
            this.panelSearchedMovie.Name = "panelSearchedMovie";
            this.panelSearchedMovie.Size = new System.Drawing.Size(547, 82);
            this.panelSearchedMovie.TabIndex = 5;
            this.panelSearchedMovie.Click += new System.EventHandler(this.panelSearchedMovie_Click);
            this.panelSearchedMovie.MouseEnter += new System.EventHandler(this.panelSearchedMovie_MouseEnter);
            this.panelSearchedMovie.MouseLeave += new System.EventHandler(this.panelSearchedMovie_MouseLeave);
            // 
            // flpTitleAndYear
            // 
            this.flpTitleAndYear.Controls.Add(this.lblTitle);
            this.flpTitleAndYear.Controls.Add(this.lblReleaseYear);
            this.flpTitleAndYear.Location = new System.Drawing.Point(69, 13);
            this.flpTitleAndYear.Name = "flpTitleAndYear";
            this.flpTitleAndYear.Size = new System.Drawing.Size(443, 37);
            this.flpTitleAndYear.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.ForeColor = System.Drawing.Color.White;
            this.lblReleaseYear.Location = new System.Drawing.Point(49, 0);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(54, 17);
            this.lblReleaseYear.TabIndex = 5;
            this.lblReleaseYear.Text = "(Year)";
            // 
            // pbCover
            // 
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(5, 6);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(55, 71);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // UCSearchedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelSearchedMovie);
            this.Name = "UCSearchedMovie";
            this.Size = new System.Drawing.Size(547, 82);
            this.panelSearchedMovie.ResumeLayout(false);
            this.flpTitleAndYear.ResumeLayout(false);
            this.flpTitleAndYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchedMovie;
        private System.Windows.Forms.FlowLayoutPanel flpTitleAndYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.PictureBox pbCover;
    }
}
