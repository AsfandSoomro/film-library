﻿
namespace FilmLibrary
{
    partial class UCProfileMenu
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
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMyLibrary = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flpContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.flpContainer.Controls.Add(this.panelTop);
            this.flpContainer.Controls.Add(this.panel2);
            this.flpContainer.Controls.Add(this.btnProfile);
            this.flpContainer.Controls.Add(this.btnMyLibrary);
            this.flpContainer.Controls.Add(this.btnSettings);
            this.flpContainer.Controls.Add(this.panel1);
            this.flpContainer.Controls.Add(this.btnLogout);
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(176, 243);
            this.flpContainer.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblFullName);
            this.panelTop.Controls.Add(this.lblUsername);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(173, 64);
            this.panelTop.TabIndex = 19;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(48, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 18);
            this.lblFullName.TabIndex = 16;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(40, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 3);
            this.panel2.TabIndex = 18;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(3, 76);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(173, 38);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMyLibrary
            // 
            this.btnMyLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnMyLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyLibrary.FlatAppearance.BorderSize = 0;
            this.btnMyLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnMyLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnMyLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyLibrary.Location = new System.Drawing.Point(3, 114);
            this.btnMyLibrary.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMyLibrary.Name = "btnMyLibrary";
            this.btnMyLibrary.Size = new System.Drawing.Size(173, 38);
            this.btnMyLibrary.TabIndex = 12;
            this.btnMyLibrary.Text = "My Library";
            this.btnMyLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyLibrary.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 152);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(173, 38);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 3);
            this.panel1.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 199);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 38);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UCProfileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpContainer);
            this.Name = "UCProfileMenu";
            this.Size = new System.Drawing.Size(176, 243);
            this.Load += new System.EventHandler(this.UCProfileMenu_Load);
            this.flpContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMyLibrary;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
    }
}
