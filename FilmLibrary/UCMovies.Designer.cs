
namespace FilmLibrary
{
    partial class UCMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMovies));
            this.flPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.moviePictureBox4 = new FilmLibrary.MoviePictureBox();
            this.moviePictureBox3 = new FilmLibrary.MoviePictureBox();
            this.moviePictureBox2 = new FilmLibrary.MoviePictureBox();
            this.flPanelMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flPanelMovies
            // 
            this.flPanelMovies.AutoScroll = true;
            this.flPanelMovies.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.flPanelMovies.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.flPanelMovies.BackColor = System.Drawing.Color.Transparent;
            this.flPanelMovies.Controls.Add(this.moviePictureBox2);
            this.flPanelMovies.Controls.Add(this.moviePictureBox3);
            this.flPanelMovies.Controls.Add(this.moviePictureBox4);
            this.flPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelMovies.Location = new System.Drawing.Point(0, 0);
            this.flPanelMovies.Name = "flPanelMovies";
            this.flPanelMovies.Padding = new System.Windows.Forms.Padding(20);
            this.flPanelMovies.Size = new System.Drawing.Size(809, 660);
            this.flPanelMovies.TabIndex = 3;
            this.flPanelMovies.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flPanelMovies_Scroll);
            // 
            // moviePictureBox4
            // 
            this.moviePictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviePictureBox4.Enabled = false;
            this.moviePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("moviePictureBox4.Image")));
            this.moviePictureBox4.Location = new System.Drawing.Point(480, 30);
            this.moviePictureBox4.Margin = new System.Windows.Forms.Padding(10);
            this.moviePictureBox4.Name = "moviePictureBox4";
            this.moviePictureBox4.Size = new System.Drawing.Size(205, 295);
            this.moviePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox4.TabIndex = 3;
            this.moviePictureBox4.TabStop = false;
            this.moviePictureBox4.Visible = false;
            // 
            // moviePictureBox3
            // 
            this.moviePictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviePictureBox3.Enabled = false;
            this.moviePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("moviePictureBox3.Image")));
            this.moviePictureBox3.Location = new System.Drawing.Point(255, 30);
            this.moviePictureBox3.Margin = new System.Windows.Forms.Padding(10);
            this.moviePictureBox3.Name = "moviePictureBox3";
            this.moviePictureBox3.Size = new System.Drawing.Size(205, 295);
            this.moviePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox3.TabIndex = 2;
            this.moviePictureBox3.TabStop = false;
            this.moviePictureBox3.Visible = false;
            // 
            // moviePictureBox2
            // 
            this.moviePictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviePictureBox2.Enabled = false;
            this.moviePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("moviePictureBox2.Image")));
            this.moviePictureBox2.Location = new System.Drawing.Point(30, 30);
            this.moviePictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.moviePictureBox2.Name = "moviePictureBox2";
            this.moviePictureBox2.Size = new System.Drawing.Size(205, 295);
            this.moviePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox2.TabIndex = 1;
            this.moviePictureBox2.TabStop = false;
            this.moviePictureBox2.Visible = false;
            // 
            // UCMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flPanelMovies);
            this.Name = "UCMovies";
            this.Size = new System.Drawing.Size(809, 660);
            this.flPanelMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flPanelMovies;
        private MoviePictureBox moviePictureBox2;
        private MoviePictureBox moviePictureBox3;
        private MoviePictureBox moviePictureBox4;
    }
}
