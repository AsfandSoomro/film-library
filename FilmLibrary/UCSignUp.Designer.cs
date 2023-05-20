
namespace FilmLibrary
{
    partial class UCSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSignUp));
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.btnSignUp2 = new System.Windows.Forms.Button();
            this.txtLastName = new FilmLibrary.MyTextBox();
            this.txtFirstName = new FilmLibrary.MyTextBox();
            this.txtEmail = new FilmLibrary.MyTextBox();
            this.txtPasswordSU = new FilmLibrary.MyTextBox();
            this.txtUsernameSU = new FilmLibrary.MyTextBox();
            this.pbProfilePicSU = new FilmLibrary.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicSU)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.dtpDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.dtpDOB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(483, 437);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(117, 23);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.Value = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblDOB.Location = new System.Drawing.Point(372, 437);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(105, 22);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // btnSignUp2
            // 
            this.btnSignUp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp2.BackColor = System.Drawing.Color.SlateGray;
            this.btnSignUp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp2.Enabled = false;
            this.btnSignUp2.FlatAppearance.BorderSize = 0;
            this.btnSignUp2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp2.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSignUp2.Location = new System.Drawing.Point(372, 476);
            this.btnSignUp2.Name = "btnSignUp2";
            this.btnSignUp2.Size = new System.Drawing.Size(228, 36);
            this.btnSignUp2.TabIndex = 7;
            this.btnSignUp2.Text = "Sign Up";
            this.btnSignUp2.UseVisualStyleBackColor = false;
            this.btnSignUp2.Click += new System.EventHandler(this.btnSignUp2_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtLastName.IsPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(372, 394);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.OriginalText = "LastName";
            this.txtLastName.Size = new System.Drawing.Size(228, 26);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtFirstName.IsPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(372, 352);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.OriginalText = "FirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 26);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Text = "FirstName";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtEmail.IsPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(372, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.OriginalText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtPasswordSU
            // 
            this.txtPasswordSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtPasswordSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPasswordSU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtPasswordSU.IsPassword = true;
            this.txtPasswordSU.Location = new System.Drawing.Point(372, 268);
            this.txtPasswordSU.Name = "txtPasswordSU";
            this.txtPasswordSU.OriginalText = "Password";
            this.txtPasswordSU.Size = new System.Drawing.Size(228, 26);
            this.txtPasswordSU.TabIndex = 1;
            this.txtPasswordSU.Text = "Password";
            this.txtPasswordSU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsernameAndPassword_KeyUp);
            // 
            // txtUsernameSU
            // 
            this.txtUsernameSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtUsernameSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsernameSU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtUsernameSU.IsPassword = false;
            this.txtUsernameSU.Location = new System.Drawing.Point(372, 227);
            this.txtUsernameSU.Name = "txtUsernameSU";
            this.txtUsernameSU.OriginalText = "Username";
            this.txtUsernameSU.Size = new System.Drawing.Size(228, 26);
            this.txtUsernameSU.TabIndex = 0;
            this.txtUsernameSU.Text = "Username";
            this.txtUsernameSU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsernameAndPassword_KeyUp);
            // 
            // pbProfilePicSU
            // 
            this.pbProfilePicSU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePicSU.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePicSU.Image")));
            this.pbProfilePicSU.Location = new System.Drawing.Point(405, 62);
            this.pbProfilePicSU.Name = "pbProfilePicSU";
            this.pbProfilePicSU.Size = new System.Drawing.Size(158, 143);
            this.pbProfilePicSU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicSU.TabIndex = 8;
            this.pbProfilePicSU.TabStop = false;
            this.pbProfilePicSU.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // UCSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbProfilePicSU);
            this.Controls.Add(this.btnSignUp2);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPasswordSU);
            this.Controls.Add(this.txtUsernameSU);
            this.Name = "UCSignUp";
            this.Size = new System.Drawing.Size(969, 661);
            this.Load += new System.EventHandler(this.UCSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicSU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox txtUsernameSU;
        private MyTextBox txtPasswordSU;
        private MyTextBox txtEmail;
        private MyTextBox txtFirstName;
        private MyTextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Button btnSignUp2;
        private CircularPictureBox pbProfilePicSU;
    }
}
