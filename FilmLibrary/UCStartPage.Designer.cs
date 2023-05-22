
namespace FilmLibrary
{
    partial class UCStartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStartPage));
            this.pbPosters = new System.Windows.Forms.PictureBox();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosters)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPosters
            // 
            this.pbPosters.Image = ((System.Drawing.Image)(resources.GetObject("pbPosters.Image")));
            this.pbPosters.Location = new System.Drawing.Point(0, 3);
            this.pbPosters.Name = "pbPosters";
            this.pbPosters.Size = new System.Drawing.Size(970, 413);
            this.pbPosters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosters.TabIndex = 3;
            this.pbPosters.TabStop = false;
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblWelcome2.Location = new System.Drawing.Point(22, 169);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(910, 104);
            this.lblWelcome2.TabIndex = 2;
            this.lblWelcome2.Text = resources.GetString("lblWelcome2.Text");
            this.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblWelcome.Location = new System.Drawing.Point(223, 121);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(489, 36);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to Asfand\'s Film Library";
            // 
            // UCStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.pbPosters);
            this.Name = "UCStartPage";
            this.Size = new System.Drawing.Size(973, 661);
            this.Load += new System.EventHandler(this.UCStartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPosters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPosters;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblWelcome;
    }
}
