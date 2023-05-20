
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
            this.SuspendLayout();
            // 
            // panelWatchlistsContainer
            // 
            this.panelWatchlistsContainer.AutoScroll = true;
            this.panelWatchlistsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWatchlistsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWatchlistsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelWatchlistsContainer.Name = "panelWatchlistsContainer";
            this.panelWatchlistsContainer.Size = new System.Drawing.Size(433, 359);
            this.panelWatchlistsContainer.TabIndex = 0;
            // 
            // UCUserWatchlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelWatchlistsContainer);
            this.Name = "UCUserWatchlists";
            this.Size = new System.Drawing.Size(433, 359);
            this.Load += new System.EventHandler(this.UCUserWatchlists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWatchlistsContainer;
    }
}
