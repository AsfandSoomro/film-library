﻿
namespace FilmLibrary
{
    partial class UCUpdateWatchlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUpdateWatchlist));
            this.rbPublic = new System.Windows.Forms.RadioButton();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTitle = new FilmLibrary.MyTextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPublic
            // 
            this.rbPublic.AutoSize = true;
            this.rbPublic.BackColor = System.Drawing.Color.Transparent;
            this.rbPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.rbPublic.Location = new System.Drawing.Point(480, 467);
            this.rbPublic.Name = "rbPublic";
            this.rbPublic.Size = new System.Drawing.Size(69, 24);
            this.rbPublic.TabIndex = 17;
            this.rbPublic.Text = "Public";
            this.rbPublic.UseVisualStyleBackColor = false;
            this.rbPublic.CheckedChanged += new System.EventHandler(this.rbPublic_CheckedChanged);
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.BackColor = System.Drawing.Color.Transparent;
            this.rbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.rbPrivate.Location = new System.Drawing.Point(356, 467);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(75, 24);
            this.rbPrivate.TabIndex = 16;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = false;
            this.rbPrivate.CheckedChanged += new System.EventHandler(this.rbPrivate_CheckedChanged);
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.BackColor = System.Drawing.Color.Transparent;
            this.lblVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblVisibility.Location = new System.Drawing.Point(228, 469);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(68, 20);
            this.lblVisibility.TabIndex = 15;
            this.lblVisibility.Text = "Visibility:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SlateGray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnUpdate.Location = new System.Drawing.Point(293, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtTitle.IsPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(232, 427);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.OriginalText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(349, 26);
            this.txtTitle.TabIndex = 13;
            this.txtTitle.Text = "Title";
            this.txtTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyUp);
            // 
            // pbCover
            // 
            this.pbCover.BackColor = System.Drawing.Color.Transparent;
            this.pbCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(262, 83);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(294, 326);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 12;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pbCover_Click);
            // 
            // UCUpdateWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rbPublic);
            this.Controls.Add(this.rbPrivate);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pbCover);
            this.Name = "UCUpdateWatchlist";
            this.Size = new System.Drawing.Size(809, 626);
            this.Load += new System.EventHandler(this.UCUpdateWatchlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPublic;
        private System.Windows.Forms.RadioButton rbPrivate;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Button btnUpdate;
        private MyTextBox txtTitle;
        private System.Windows.Forms.PictureBox pbCover;
    }
}