
namespace FilmLibrary
{
    partial class UCMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMovie));
            this.panelMovieContainer = new System.Windows.Forms.Panel();
            this.btnAddToWatchlist = new FilmLibrary.AddButton();
            this.pbMovie = new FilmLibrary.MoviePictureBox();
            this.panelMovieContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMovieContainer
            // 
            this.panelMovieContainer.Controls.Add(this.btnAddToWatchlist);
            this.panelMovieContainer.Controls.Add(this.pbMovie);
            this.panelMovieContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovieContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMovieContainer.Name = "panelMovieContainer";
            this.panelMovieContainer.Size = new System.Drawing.Size(205, 295);
            this.panelMovieContainer.TabIndex = 0;
            // 
            // btnAddToWatchlist
            // 
            this.btnAddToWatchlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToWatchlist.BackgroundImage")));
            this.btnAddToWatchlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToWatchlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToWatchlist.FlatAppearance.BorderSize = 0;
            this.btnAddToWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToWatchlist.Location = new System.Drawing.Point(178, 3);
            this.btnAddToWatchlist.Name = "btnAddToWatchlist";
            this.btnAddToWatchlist.Size = new System.Drawing.Size(24, 24);
            this.btnAddToWatchlist.TabIndex = 1;
            this.btnAddToWatchlist.UseVisualStyleBackColor = true;
            this.btnAddToWatchlist.Visible = false;
            this.btnAddToWatchlist.Click += new System.EventHandler(this.btnAddToWatchlist_Click);
            // 
            // pbMovie
            // 
            this.pbMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMovie.Image = ((System.Drawing.Image)(resources.GetObject("pbMovie.Image")));
            this.pbMovie.Location = new System.Drawing.Point(0, 0);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(205, 295);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovie.TabIndex = 0;
            this.pbMovie.TabStop = false;
            // 
            // UCMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.panelMovieContainer);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCMovie";
            this.Size = new System.Drawing.Size(205, 295);
            this.Load += new System.EventHandler(this.UCMovie_Load);
            this.panelMovieContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovieContainer;
        private MoviePictureBox pbMovie;
        private AddButton btnAddToWatchlist;
    }
}
