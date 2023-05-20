
namespace FilmLibrary
{
    partial class UCUserWatchlists
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
            this.panelWatchlistsContainer = new System.Windows.Forms.Panel();
            this.ucUserWatchlist3 = new FilmLibrary.UCUserWatchlist();
            this.ucUserWatchlist2 = new FilmLibrary.UCUserWatchlist();
            this.ucUserWatchlist1 = new FilmLibrary.UCUserWatchlist();
            this.panelWatchlistsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWatchlistsContainer
            // 
            this.panelWatchlistsContainer.AutoScroll = true;
            this.panelWatchlistsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panelWatchlistsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWatchlistsContainer.Controls.Add(this.ucUserWatchlist3);
            this.panelWatchlistsContainer.Controls.Add(this.ucUserWatchlist2);
            this.panelWatchlistsContainer.Controls.Add(this.ucUserWatchlist1);
            this.panelWatchlistsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWatchlistsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelWatchlistsContainer.Name = "panelWatchlistsContainer";
            this.panelWatchlistsContainer.Size = new System.Drawing.Size(433, 359);
            this.panelWatchlistsContainer.TabIndex = 2;
            // 
            // ucUserWatchlist3
            // 
            this.ucUserWatchlist3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ucUserWatchlist3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserWatchlist3.Enabled = false;
            this.ucUserWatchlist3.Location = new System.Drawing.Point(0, 118);
            this.ucUserWatchlist3.Margin = new System.Windows.Forms.Padding(10);
            this.ucUserWatchlist3.Name = "ucUserWatchlist3";
            this.ucUserWatchlist3.Size = new System.Drawing.Size(431, 59);
            this.ucUserWatchlist3.TabIndex = 2;
            this.ucUserWatchlist3.Visible = false;
            // 
            // ucUserWatchlist2
            // 
            this.ucUserWatchlist2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ucUserWatchlist2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserWatchlist2.Enabled = false;
            this.ucUserWatchlist2.Location = new System.Drawing.Point(0, 59);
            this.ucUserWatchlist2.Margin = new System.Windows.Forms.Padding(10);
            this.ucUserWatchlist2.Name = "ucUserWatchlist2";
            this.ucUserWatchlist2.Size = new System.Drawing.Size(431, 59);
            this.ucUserWatchlist2.TabIndex = 1;
            this.ucUserWatchlist2.Visible = false;
            // 
            // ucUserWatchlist1
            // 
            this.ucUserWatchlist1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ucUserWatchlist1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserWatchlist1.Enabled = false;
            this.ucUserWatchlist1.Location = new System.Drawing.Point(0, 0);
            this.ucUserWatchlist1.Margin = new System.Windows.Forms.Padding(10);
            this.ucUserWatchlist1.Name = "ucUserWatchlist1";
            this.ucUserWatchlist1.Size = new System.Drawing.Size(431, 59);
            this.ucUserWatchlist1.TabIndex = 0;
            this.ucUserWatchlist1.Visible = false;
            // 
            // UCUserWatchlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelWatchlistsContainer);
            this.Name = "UCUserWatchlists";
            this.Size = new System.Drawing.Size(433, 359);
            this.Load += new System.EventHandler(this.UCUserWatchlists_Load);
            this.panelWatchlistsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWatchlistsContainer;
        private UCUserWatchlist ucUserWatchlist3;
        private UCUserWatchlist ucUserWatchlist2;
        private UCUserWatchlist ucUserWatchlist1;
    }
}
