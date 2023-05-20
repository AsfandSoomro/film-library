
namespace FilmLibrary
{
    partial class UCSignIn
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
            this.btnSignIn2 = new System.Windows.Forms.Button();
            this.txtUsername = new FilmLibrary.MyTextBox();
            this.txtPassword = new FilmLibrary.MyTextBox();
            this.SuspendLayout();
            // 
            // btnSignIn2
            // 
            this.btnSignIn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn2.BackColor = System.Drawing.Color.SlateGray;
            this.btnSignIn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn2.Enabled = false;
            this.btnSignIn2.FlatAppearance.BorderSize = 0;
            this.btnSignIn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn2.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSignIn2.Location = new System.Drawing.Point(372, 348);
            this.btnSignIn2.Name = "btnSignIn2";
            this.btnSignIn2.Size = new System.Drawing.Size(228, 36);
            this.btnSignIn2.TabIndex = 2;
            this.btnSignIn2.Text = "Sign In";
            this.btnSignIn2.UseVisualStyleBackColor = false;
            this.btnSignIn2.Click += new System.EventHandler(this.btnSignIn2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtUsername.IsPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(372, 257);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.OriginalText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(228, 26);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsernameAndPassword_KeyUp);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(372, 303);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OriginalText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsernameAndPassword_KeyUp);
            // 
            // UCSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSignIn2);
            this.Name = "UCSignIn";
            this.Size = new System.Drawing.Size(969, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignIn2;
        private MyTextBox txtUsername;
        private MyTextBox txtPassword;
    }
}
