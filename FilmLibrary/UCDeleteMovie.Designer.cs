
namespace FilmLibrary
{
    partial class UCDeleteMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDeleteMovie));
            this.btnFetch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYearFetch = new System.Windows.Forms.ComboBox();
            this.txtTitleFetch = new FilmLibrary.MyTextBox();
            this.txtImdbIdFetch = new FilmLibrary.MyTextBox();
            this.txtMovieId = new FilmLibrary.MyTextBox();
            this.lblFetchHeading = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFetchContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.txtTitle = new FilmLibrary.MyTextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.txtVotes = new FilmLibrary.MyTextBox();
            this.txtPlot = new FilmLibrary.MyTextBox();
            this.txtBoxOffice = new FilmLibrary.MyTextBox();
            this.txtIMDBID = new FilmLibrary.MyTextBox();
            this.txtBudget = new FilmLibrary.MyTextBox();
            this.panelContainer.SuspendLayout();
            this.panelFetchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.Color.SlateGray;
            this.btnFetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetch.Enabled = false;
            this.btnFetch.FlatAppearance.BorderSize = 0;
            this.btnFetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFetch.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnFetch.Location = new System.Drawing.Point(273, 94);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(228, 36);
            this.btnFetch.TabIndex = 40;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(723, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = ")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(544, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "AND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(320, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "OR (";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(161, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "OR";
            // 
            // cbYearFetch
            // 
            this.cbYearFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.cbYearFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearFetch.ForeColor = System.Drawing.Color.White;
            this.cbYearFetch.FormattingEnabled = true;
            this.cbYearFetch.Location = new System.Drawing.Point(593, 49);
            this.cbYearFetch.Name = "cbYearFetch";
            this.cbYearFetch.Size = new System.Drawing.Size(127, 28);
            this.cbYearFetch.TabIndex = 35;
            this.cbYearFetch.SelectedIndexChanged += new System.EventHandler(this.cbYearFetch_SelectedIndexChanged);
            // 
            // txtTitleFetch
            // 
            this.txtTitleFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtTitleFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitleFetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtTitleFetch.IsPassword = false;
            this.txtTitleFetch.Location = new System.Drawing.Point(363, 51);
            this.txtTitleFetch.Name = "txtTitleFetch";
            this.txtTitleFetch.OriginalText = "Title";
            this.txtTitleFetch.Size = new System.Drawing.Size(175, 26);
            this.txtTitleFetch.TabIndex = 34;
            this.txtTitleFetch.Text = "Title";
            this.txtTitleFetch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitleFetch_KeyUp);
            // 
            // txtImdbIdFetch
            // 
            this.txtImdbIdFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtImdbIdFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImdbIdFetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtImdbIdFetch.IsPassword = false;
            this.txtImdbIdFetch.Location = new System.Drawing.Point(199, 51);
            this.txtImdbIdFetch.Name = "txtImdbIdFetch";
            this.txtImdbIdFetch.OriginalText = "IMdb_id";
            this.txtImdbIdFetch.Size = new System.Drawing.Size(115, 26);
            this.txtImdbIdFetch.TabIndex = 33;
            this.txtImdbIdFetch.Text = "IMdb_id";
            this.txtImdbIdFetch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtImdbIdFetch_KeyUp);
            // 
            // txtMovieId
            // 
            this.txtMovieId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMovieId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtMovieId.IsPassword = false;
            this.txtMovieId.Location = new System.Drawing.Point(42, 51);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.OriginalText = "Movie_id";
            this.txtMovieId.Size = new System.Drawing.Size(115, 26);
            this.txtMovieId.TabIndex = 32;
            this.txtMovieId.Text = "Movie_id";
            this.txtMovieId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMovieId_KeyUp);
            // 
            // lblFetchHeading
            // 
            this.lblFetchHeading.AutoSize = true;
            this.lblFetchHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblFetchHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblFetchHeading.Location = new System.Drawing.Point(38, 19);
            this.lblFetchHeading.Name = "lblFetchHeading";
            this.lblFetchHeading.Size = new System.Drawing.Size(119, 20);
            this.lblFetchHeading.TabIndex = 31;
            this.lblFetchHeading.Text = "Fetch movie by:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnDelete.Location = new System.Drawing.Point(275, 714);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 36);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.panelFetchContainer);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pbCover);
            this.panelContainer.Controls.Add(this.btnDelete);
            this.panelContainer.Controls.Add(this.txtTitle);
            this.panelContainer.Controls.Add(this.lblRating);
            this.panelContainer.Controls.Add(this.lblYear);
            this.panelContainer.Controls.Add(this.numRating);
            this.panelContainer.Controls.Add(this.cbYear);
            this.panelContainer.Controls.Add(this.txtVotes);
            this.panelContainer.Controls.Add(this.txtPlot);
            this.panelContainer.Controls.Add(this.txtBoxOffice);
            this.panelContainer.Controls.Add(this.txtIMDBID);
            this.panelContainer.Controls.Add(this.txtBudget);
            this.panelContainer.Location = new System.Drawing.Point(2, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 626);
            this.panelContainer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(723, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "*";
            // 
            // panelFetchContainer
            // 
            this.panelFetchContainer.Controls.Add(this.btnFetch);
            this.panelFetchContainer.Controls.Add(this.label6);
            this.panelFetchContainer.Controls.Add(this.label5);
            this.panelFetchContainer.Controls.Add(this.label4);
            this.panelFetchContainer.Controls.Add(this.label3);
            this.panelFetchContainer.Controls.Add(this.cbYearFetch);
            this.panelFetchContainer.Controls.Add(this.txtTitleFetch);
            this.panelFetchContainer.Controls.Add(this.txtImdbIdFetch);
            this.panelFetchContainer.Controls.Add(this.txtMovieId);
            this.panelFetchContainer.Controls.Add(this.lblFetchHeading);
            this.panelFetchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFetchContainer.Location = new System.Drawing.Point(0, 0);
            this.panelFetchContainer.Name = "panelFetchContainer";
            this.panelFetchContainer.Size = new System.Drawing.Size(754, 146);
            this.panelFetchContainer.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(723, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "*";
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(42, 171);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(252, 341);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCover.TabIndex = 41;
            this.pbCover.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtTitle.IsPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(321, 171);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.OriginalText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(399, 26);
            this.txtTitle.TabIndex = 42;
            this.txtTitle.Text = "Title";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblRating.Location = new System.Drawing.Point(319, 492);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 20);
            this.lblRating.TabIndex = 51;
            this.lblRating.Text = "Rating:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblYear.Location = new System.Drawing.Point(319, 436);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(106, 20);
            this.lblYear.TabIndex = 43;
            this.lblYear.Text = "Release year:";
            // 
            // numRating
            // 
            this.numRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.numRating.DecimalPlaces = 1;
            this.numRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.ForeColor = System.Drawing.Color.White;
            this.numRating.Location = new System.Drawing.Point(394, 486);
            this.numRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(326, 26);
            this.numRating.TabIndex = 50;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.Color.White;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(441, 433);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(279, 28);
            this.cbYear.TabIndex = 44;
            // 
            // txtVotes
            // 
            this.txtVotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtVotes.IsPassword = false;
            this.txtVotes.Location = new System.Drawing.Point(321, 377);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.OriginalText = "Votes";
            this.txtVotes.Size = new System.Drawing.Size(399, 26);
            this.txtVotes.TabIndex = 49;
            this.txtVotes.Text = "Votes";
            // 
            // txtPlot
            // 
            this.txtPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtPlot.IsPassword = false;
            this.txtPlot.Location = new System.Drawing.Point(42, 531);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.OriginalText = "Plot Outline";
            this.txtPlot.Size = new System.Drawing.Size(678, 168);
            this.txtPlot.TabIndex = 45;
            this.txtPlot.Text = "Plot Outline";
            // 
            // txtBoxOffice
            // 
            this.txtBoxOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtBoxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxOffice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtBoxOffice.IsPassword = false;
            this.txtBoxOffice.Location = new System.Drawing.Point(321, 327);
            this.txtBoxOffice.Name = "txtBoxOffice";
            this.txtBoxOffice.OriginalText = "Box Office";
            this.txtBoxOffice.Size = new System.Drawing.Size(399, 26);
            this.txtBoxOffice.TabIndex = 48;
            this.txtBoxOffice.Text = "Box Office";
            // 
            // txtIMDBID
            // 
            this.txtIMDBID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtIMDBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIMDBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtIMDBID.IsPassword = false;
            this.txtIMDBID.Location = new System.Drawing.Point(321, 220);
            this.txtIMDBID.Name = "txtIMDBID";
            this.txtIMDBID.OriginalText = "IMdb ID";
            this.txtIMDBID.Size = new System.Drawing.Size(399, 26);
            this.txtIMDBID.TabIndex = 46;
            this.txtIMDBID.Text = "IMdb ID";
            // 
            // txtBudget
            // 
            this.txtBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtBudget.IsPassword = false;
            this.txtBudget.Location = new System.Drawing.Point(321, 274);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.OriginalText = "Budget";
            this.txtBudget.Size = new System.Drawing.Size(399, 26);
            this.txtBudget.TabIndex = 47;
            this.txtBudget.Text = "Budget";
            // 
            // UCDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCDeleteMovie";
            this.Size = new System.Drawing.Size(776, 630);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelFetchContainer.ResumeLayout(false);
            this.panelFetchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYearFetch;
        private MyTextBox txtTitleFetch;
        private MyTextBox txtImdbIdFetch;
        private MyTextBox txtMovieId;
        private System.Windows.Forms.Label lblFetchHeading;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelFetchContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCover;
        private MyTextBox txtTitle;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.ComboBox cbYear;
        private MyTextBox txtVotes;
        private MyTextBox txtPlot;
        private MyTextBox txtBoxOffice;
        private MyTextBox txtIMDBID;
        private MyTextBox txtBudget;
    }
}
