
namespace FilmLibrary
{
    partial class UCCreateWatchlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCreateWatchlist));
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.txtTitle = new FilmLibrary.MyTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.rbPublic = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.BackColor = System.Drawing.Color.Transparent;
            this.pbCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(253, 32);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(294, 326);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pbCover_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtTitle.IsPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(223, 376);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.OriginalText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(349, 26);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Title";
            this.txtTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyUp);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnCreate.Location = new System.Drawing.Point(284, 457);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(228, 36);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.BackColor = System.Drawing.Color.Transparent;
            this.lblVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblVisibility.Location = new System.Drawing.Point(219, 418);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(68, 20);
            this.lblVisibility.TabIndex = 9;
            this.lblVisibility.Text = "Visibility:";
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.BackColor = System.Drawing.Color.Transparent;
            this.rbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.rbPrivate.Location = new System.Drawing.Point(347, 416);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(75, 24);
            this.rbPrivate.TabIndex = 10;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = false;
            // 
            // rbPublic
            // 
            this.rbPublic.AutoSize = true;
            this.rbPublic.BackColor = System.Drawing.Color.Transparent;
            this.rbPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.rbPublic.Location = new System.Drawing.Point(471, 416);
            this.rbPublic.Name = "rbPublic";
            this.rbPublic.Size = new System.Drawing.Size(69, 24);
            this.rbPublic.TabIndex = 11;
            this.rbPublic.Text = "Public";
            this.rbPublic.UseVisualStyleBackColor = false;
            // 
            // UCCreateWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rbPublic);
            this.Controls.Add(this.rbPrivate);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pbCover);
            this.Name = "UCCreateWatchlist";
            this.Size = new System.Drawing.Size(809, 626);
            this.Load += new System.EventHandler(this.UCCreateWatchlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private MyTextBox txtTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.RadioButton rbPublic;
    }
}
