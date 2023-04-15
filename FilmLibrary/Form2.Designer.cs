
namespace FilmLibrary
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(160, 723);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelSearchBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(160, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(809, 723);
            this.panelContainer.TabIndex = 1;
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 0);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(809, 63);
            this.panelSearchBar.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 63);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(809, 660);
            this.panelMain.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(969, 723);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Library";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.Panel panelMain;
    }
}