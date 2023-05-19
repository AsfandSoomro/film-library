
namespace FilmLibrary
{
    partial class UCMoviePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMoviePage));
            this.pbMovieCover = new System.Windows.Forms.PictureBox();
            this.flpPlotOutline = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlotOutline = new System.Windows.Forms.Label();
            this.flpMovieTitleAndYear = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieCover)).BeginInit();
            this.flpPlotOutline.SuspendLayout();
            this.flpMovieTitleAndYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMovieCover
            // 
            this.pbMovieCover.Image = ((System.Drawing.Image)(resources.GetObject("pbMovieCover.Image")));
            this.pbMovieCover.Location = new System.Drawing.Point(17, 51);
            this.pbMovieCover.Name = "pbMovieCover";
            this.pbMovieCover.Size = new System.Drawing.Size(246, 383);
            this.pbMovieCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovieCover.TabIndex = 3;
            this.pbMovieCover.TabStop = false;
            // 
            // flpPlotOutline
            // 
            this.flpPlotOutline.Controls.Add(this.lblPlotOutline);
            this.flpPlotOutline.Location = new System.Drawing.Point(280, 140);
            this.flpPlotOutline.Name = "flpPlotOutline";
            this.flpPlotOutline.Size = new System.Drawing.Size(504, 293);
            this.flpPlotOutline.TabIndex = 4;
            // 
            // lblPlotOutline
            // 
            this.lblPlotOutline.AutoSize = true;
            this.lblPlotOutline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotOutline.ForeColor = System.Drawing.Color.White;
            this.lblPlotOutline.Location = new System.Drawing.Point(3, 0);
            this.lblPlotOutline.Name = "lblPlotOutline";
            this.lblPlotOutline.Size = new System.Drawing.Size(90, 20);
            this.lblPlotOutline.TabIndex = 3;
            this.lblPlotOutline.Text = "Plot Outline";
            // 
            // flpMovieTitleAndYear
            // 
            this.flpMovieTitleAndYear.Controls.Add(this.lblMovieTitle);
            this.flpMovieTitleAndYear.Controls.Add(this.lblMovieYear);
            this.flpMovieTitleAndYear.Location = new System.Drawing.Point(280, 61);
            this.flpMovieTitleAndYear.Name = "flpMovieTitleAndYear";
            this.flpMovieTitleAndYear.Size = new System.Drawing.Size(504, 73);
            this.flpMovieTitleAndYear.TabIndex = 5;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.White;
            this.lblMovieTitle.Location = new System.Drawing.Point(3, 0);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(57, 26);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "Title";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYear.ForeColor = System.Drawing.Color.White;
            this.lblMovieYear.Location = new System.Drawing.Point(66, 0);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(79, 26);
            this.lblMovieYear.TabIndex = 3;
            this.lblMovieYear.Text = "(Year)";
            // 
            // UCMovie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.flpMovieTitleAndYear);
            this.Controls.Add(this.flpPlotOutline);
            this.Controls.Add(this.pbMovieCover);
            this.Name = "UCMovie";
            this.Size = new System.Drawing.Size(809, 660);
            this.Load += new System.EventHandler(this.UCMoviePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieCover)).EndInit();
            this.flpPlotOutline.ResumeLayout(false);
            this.flpPlotOutline.PerformLayout();
            this.flpMovieTitleAndYear.ResumeLayout(false);
            this.flpMovieTitleAndYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMovieCover;
        private System.Windows.Forms.FlowLayoutPanel flpPlotOutline;
        private System.Windows.Forms.Label lblPlotOutline;
        private System.Windows.Forms.FlowLayoutPanel flpMovieTitleAndYear;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMovieYear;
    }
}
