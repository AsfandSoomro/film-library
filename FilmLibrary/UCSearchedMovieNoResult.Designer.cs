
namespace FilmLibrary
{
    partial class UCSearchedMovieNoResult
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
            this.panelSearchedMovieNoResult = new System.Windows.Forms.Panel();
            this.lblNoResult = new System.Windows.Forms.Label();
            this.panelSearchedMovieNoResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchedMovieNoResult
            // 
            this.panelSearchedMovieNoResult.AutoSize = true;
            this.panelSearchedMovieNoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchedMovieNoResult.Controls.Add(this.lblNoResult);
            this.panelSearchedMovieNoResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSearchedMovieNoResult.Location = new System.Drawing.Point(19, 15);
            this.panelSearchedMovieNoResult.Name = "panelSearchedMovieNoResult";
            this.panelSearchedMovieNoResult.Size = new System.Drawing.Size(507, 53);
            this.panelSearchedMovieNoResult.TabIndex = 6;
            // 
            // lblNoResult
            // 
            this.lblNoResult.AutoSize = true;
            this.lblNoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResult.ForeColor = System.Drawing.Color.White;
            this.lblNoResult.Location = new System.Drawing.Point(21, 16);
            this.lblNoResult.Name = "lblNoResult";
            this.lblNoResult.Size = new System.Drawing.Size(186, 20);
            this.lblNoResult.TabIndex = 4;
            this.lblNoResult.Text = "No results found for \"xyz\"";
            // 
            // UCSearchedMovieNoResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.panelSearchedMovieNoResult);
            this.Name = "UCSearchedMovieNoResult";
            this.Size = new System.Drawing.Size(547, 82);
            this.panelSearchedMovieNoResult.ResumeLayout(false);
            this.panelSearchedMovieNoResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchedMovieNoResult;
        private System.Windows.Forms.Label lblNoResult;
    }
}
