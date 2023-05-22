
namespace FilmLibrary
{
    partial class UCAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddMovie));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtVotes = new FilmLibrary.MyTextBox();
            this.txtBoxOffice = new FilmLibrary.MyTextBox();
            this.txtBudget = new FilmLibrary.MyTextBox();
            this.txtIMDBID = new FilmLibrary.MyTextBox();
            this.txtPlot = new FilmLibrary.MyTextBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTitle = new FilmLibrary.MyTextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.btnAdd);
            this.panelContainer.Controls.Add(this.lblRating);
            this.panelContainer.Controls.Add(this.numRating);
            this.panelContainer.Controls.Add(this.txtVotes);
            this.panelContainer.Controls.Add(this.txtBoxOffice);
            this.panelContainer.Controls.Add(this.txtBudget);
            this.panelContainer.Controls.Add(this.txtIMDBID);
            this.panelContainer.Controls.Add(this.txtPlot);
            this.panelContainer.Controls.Add(this.cbYear);
            this.panelContainer.Controls.Add(this.lblYear);
            this.panelContainer.Controls.Add(this.txtTitle);
            this.panelContainer.Controls.Add(this.pbCover);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 626);
            this.panelContainer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnAdd.Location = new System.Drawing.Point(258, 576);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 36);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblRating.Location = new System.Drawing.Point(302, 354);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 20);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating:";
            // 
            // numRating
            // 
            this.numRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.numRating.DecimalPlaces = 1;
            this.numRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.ForeColor = System.Drawing.Color.White;
            this.numRating.Location = new System.Drawing.Point(377, 348);
            this.numRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(326, 26);
            this.numRating.TabIndex = 17;
            // 
            // txtVotes
            // 
            this.txtVotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtVotes.IsPassword = false;
            this.txtVotes.Location = new System.Drawing.Point(304, 239);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.OriginalText = "Votes";
            this.txtVotes.Size = new System.Drawing.Size(399, 26);
            this.txtVotes.TabIndex = 16;
            this.txtVotes.Text = "Votes";
            // 
            // txtBoxOffice
            // 
            this.txtBoxOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtBoxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxOffice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtBoxOffice.IsPassword = false;
            this.txtBoxOffice.Location = new System.Drawing.Point(304, 189);
            this.txtBoxOffice.Name = "txtBoxOffice";
            this.txtBoxOffice.OriginalText = "Box Office";
            this.txtBoxOffice.Size = new System.Drawing.Size(399, 26);
            this.txtBoxOffice.TabIndex = 15;
            this.txtBoxOffice.Text = "Box Office";
            // 
            // txtBudget
            // 
            this.txtBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtBudget.IsPassword = false;
            this.txtBudget.Location = new System.Drawing.Point(304, 136);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.OriginalText = "Budget";
            this.txtBudget.Size = new System.Drawing.Size(399, 26);
            this.txtBudget.TabIndex = 14;
            this.txtBudget.Text = "Budget";
            // 
            // txtIMDBID
            // 
            this.txtIMDBID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtIMDBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIMDBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtIMDBID.IsPassword = false;
            this.txtIMDBID.Location = new System.Drawing.Point(304, 82);
            this.txtIMDBID.Name = "txtIMDBID";
            this.txtIMDBID.OriginalText = "IMdb ID";
            this.txtIMDBID.Size = new System.Drawing.Size(399, 26);
            this.txtIMDBID.TabIndex = 13;
            this.txtIMDBID.Text = "IMdb ID";
            // 
            // txtPlot
            // 
            this.txtPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtPlot.IsPassword = false;
            this.txtPlot.Location = new System.Drawing.Point(25, 393);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.OriginalText = "Plot Outline";
            this.txtPlot.Size = new System.Drawing.Size(678, 168);
            this.txtPlot.TabIndex = 12;
            this.txtPlot.Text = "Plot Outline";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.Color.White;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(424, 295);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(279, 28);
            this.cbYear.TabIndex = 11;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblYear.Location = new System.Drawing.Point(302, 298);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(106, 20);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Release year:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtTitle.IsPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(304, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.OriginalText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(399, 26);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.Text = "Title";
            this.txtTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyUp);
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(25, 33);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(252, 341);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCover.TabIndex = 5;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pbCover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(706, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(706, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            // 
            // UCAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCAddMovie";
            this.Size = new System.Drawing.Size(771, 626);
            this.Load += new System.EventHandler(this.UCAddMovie_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pbCover;
        private MyTextBox txtTitle;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblYear;
        private MyTextBox txtPlot;
        private MyTextBox txtBoxOffice;
        private MyTextBox txtBudget;
        private MyTextBox txtIMDBID;
        private System.Windows.Forms.NumericUpDown numRating;
        private MyTextBox txtVotes;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
