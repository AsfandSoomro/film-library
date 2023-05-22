
namespace FilmLibrary
{
    partial class UCProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProfilePage));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flpAbout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panelInfoEdit = new System.Windows.Forms.Panel();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new FilmLibrary.MyTextBox();
            this.txtFirstName = new FilmLibrary.MyTextBox();
            this.txtEmail = new FilmLibrary.MyTextBox();
            this.txtPassword = new FilmLibrary.MyTextBox();
            this.txtUsername = new FilmLibrary.MyTextBox();
            this.pbProfilePic = new FilmLibrary.CircularPictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.flpAbout.SuspendLayout();
            this.panelInfoEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelInfoEdit);
            this.panelContainer.Controls.Add(this.flpAbout);
            this.panelContainer.Controls.Add(this.btnEdit);
            this.panelContainer.Controls.Add(this.lblUsername);
            this.panelContainer.Controls.Add(this.lblFullName);
            this.panelContainer.Controls.Add(this.pbProfilePic);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 626);
            this.panelContainer.TabIndex = 0;
            // 
            // flpAbout
            // 
            this.flpAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAbout.Controls.Add(this.lblAbout);
            this.flpAbout.Location = new System.Drawing.Point(342, 166);
            this.flpAbout.Name = "flpAbout";
            this.flpAbout.Size = new System.Drawing.Size(375, 77);
            this.flpAbout.TabIndex = 71;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(3, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(78, 20);
            this.lblAbout.TabIndex = 71;
            this.lblAbout.Text = "About me";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnEdit.Location = new System.Drawing.Point(342, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 36);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(338, 119);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 69;
            this.lblUsername.Text = "Username";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(336, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(146, 31);
            this.lblFullName.TabIndex = 68;
            this.lblFullName.Text = "Full Name";
            // 
            // panelInfoEdit
            // 
            this.panelInfoEdit.Controls.Add(this.btnCancel);
            this.panelInfoEdit.Controls.Add(this.btnSave);
            this.panelInfoEdit.Controls.Add(this.lblDOB);
            this.panelInfoEdit.Controls.Add(this.dtpDOB);
            this.panelInfoEdit.Controls.Add(this.txtLastName);
            this.panelInfoEdit.Controls.Add(this.txtFirstName);
            this.panelInfoEdit.Controls.Add(this.txtEmail);
            this.panelInfoEdit.Controls.Add(this.txtPassword);
            this.panelInfoEdit.Controls.Add(this.txtUsername);
            this.panelInfoEdit.Location = new System.Drawing.Point(29, 337);
            this.panelInfoEdit.Name = "panelInfoEdit";
            this.panelInfoEdit.Size = new System.Drawing.Size(701, 274);
            this.panelInfoEdit.TabIndex = 72;
            this.panelInfoEdit.Visible = false;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblDOB.Location = new System.Drawing.Point(25, 231);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(105, 22);
            this.lblDOB.TabIndex = 73;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.dtpDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.dtpDOB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(136, 231);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(117, 23);
            this.dtpDOB.TabIndex = 72;
            this.dtpDOB.Value = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtLastName.IsPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(25, 188);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.OriginalText = "LastName";
            this.txtLastName.Size = new System.Drawing.Size(228, 26);
            this.txtLastName.TabIndex = 71;
            this.txtLastName.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtFirstName.IsPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(25, 146);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.OriginalText = "FirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 26);
            this.txtFirstName.TabIndex = 70;
            this.txtFirstName.Text = "FirstName";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtEmail.IsPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(25, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.OriginalText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 69;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(25, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OriginalText = "Password";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 68;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtUsername.IsPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(25, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.OriginalText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(228, 26);
            this.txtUsername.TabIndex = 67;
            this.txtUsername.Text = "Username";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(43, 28);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(256, 256);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 67;
            this.pbProfilePic.TabStop = false;
            this.pbProfilePic.Click += new System.EventHandler(this.pbProfilePic_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSave.Location = new System.Drawing.Point(314, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(206)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnCancel.Location = new System.Drawing.Point(313, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCProfilePage";
            this.Size = new System.Drawing.Size(771, 626);
            this.Load += new System.EventHandler(this.UCProfilePage_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.flpAbout.ResumeLayout(false);
            this.flpAbout.PerformLayout();
            this.panelInfoEdit.ResumeLayout(false);
            this.panelInfoEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private CircularPictureBox pbProfilePic;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.FlowLayoutPanel flpAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelInfoEdit;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private MyTextBox txtLastName;
        private MyTextBox txtFirstName;
        private MyTextBox txtEmail;
        private MyTextBox txtPassword;
        private MyTextBox txtUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
