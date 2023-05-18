
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMyWatchlists = new System.Windows.Forms.Button();
            this.btnPublicWatchlists = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.panelGenresContainer = new System.Windows.Forms.Panel();
            this.panelSideBarLogo = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.timerSideBarAnimate = new System.Windows.Forms.Timer(this.components);
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.panelProfileComboBoxcontainer = new System.Windows.Forms.Panel();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelBtnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flpSearchedMoviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearchedMovie = new System.Windows.Forms.Panel();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.flpTitleAndYear = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pbProfilePic = new FilmLibrary.CircularPictureBox();
            this.genreButton1 = new FilmLibrary.GenreButton();
            this.lblMainPageHeading = new System.Windows.Forms.Label();
            this.panelSideBar.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panelGenresContainer.SuspendLayout();
            this.panelSideBarLogo.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            this.panelProfileComboBoxcontainer.SuspendLayout();
            this.panelBtnSearch.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.flpSearchedMoviesContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelSearchedMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.flpTitleAndYear.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.panelSideBar.Controls.Add(this.flpMenu);
            this.panelSideBar.Controls.Add(this.panelSideBarLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(160, 723);
            this.panelSideBar.TabIndex = 0;
            this.panelSideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideBar_MouseDown);
            // 
            // flpMenu
            // 
            this.flpMenu.AutoSize = true;
            this.flpMenu.Controls.Add(this.lblMenu);
            this.flpMenu.Controls.Add(this.btnHome);
            this.flpMenu.Controls.Add(this.btnMyWatchlists);
            this.flpMenu.Controls.Add(this.btnPublicWatchlists);
            this.flpMenu.Controls.Add(this.btnGenres);
            this.flpMenu.Controls.Add(this.panelGenresContainer);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenu.Location = new System.Drawing.Point(0, 63);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(160, 304);
            this.flpMenu.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(3, 10);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 49);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(160, 38);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMyWatchlists
            // 
            this.btnMyWatchlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.btnMyWatchlists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyWatchlists.FlatAppearance.BorderSize = 0;
            this.btnMyWatchlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyWatchlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyWatchlists.Image = ((System.Drawing.Image)(resources.GetObject("btnMyWatchlists.Image")));
            this.btnMyWatchlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWatchlists.Location = new System.Drawing.Point(3, 87);
            this.btnMyWatchlists.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMyWatchlists.Name = "btnMyWatchlists";
            this.btnMyWatchlists.Size = new System.Drawing.Size(160, 38);
            this.btnMyWatchlists.TabIndex = 8;
            this.btnMyWatchlists.Text = "My Watchlists";
            this.btnMyWatchlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWatchlists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyWatchlists.UseVisualStyleBackColor = false;
            // 
            // btnPublicWatchlists
            // 
            this.btnPublicWatchlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.btnPublicWatchlists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublicWatchlists.FlatAppearance.BorderSize = 0;
            this.btnPublicWatchlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicWatchlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicWatchlists.Image = ((System.Drawing.Image)(resources.GetObject("btnPublicWatchlists.Image")));
            this.btnPublicWatchlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicWatchlists.Location = new System.Drawing.Point(3, 125);
            this.btnPublicWatchlists.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPublicWatchlists.Name = "btnPublicWatchlists";
            this.btnPublicWatchlists.Size = new System.Drawing.Size(160, 38);
            this.btnPublicWatchlists.TabIndex = 9;
            this.btnPublicWatchlists.Text = "Pub Watchlists";
            this.btnPublicWatchlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicWatchlists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublicWatchlists.UseVisualStyleBackColor = false;
            // 
            // btnGenres
            // 
            this.btnGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.FlatAppearance.BorderSize = 0;
            this.btnGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenres.Image = ((System.Drawing.Image)(resources.GetObject("btnGenres.Image")));
            this.btnGenres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.Location = new System.Drawing.Point(3, 163);
            this.btnGenres.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(160, 38);
            this.btnGenres.TabIndex = 10;
            this.btnGenres.Text = "Genres";
            this.btnGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenres.UseVisualStyleBackColor = false;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // panelGenresContainer
            // 
            this.panelGenresContainer.AutoScroll = true;
            this.panelGenresContainer.Controls.Add(this.genreButton1);
            this.panelGenresContainer.Enabled = false;
            this.panelGenresContainer.Location = new System.Drawing.Point(3, 201);
            this.panelGenresContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelGenresContainer.Name = "panelGenresContainer";
            this.panelGenresContainer.Size = new System.Drawing.Size(157, 100);
            this.panelGenresContainer.TabIndex = 12;
            this.panelGenresContainer.Visible = false;
            // 
            // panelSideBarLogo
            // 
            this.panelSideBarLogo.Controls.Add(this.lblTitle2);
            this.panelSideBarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideBarLogo.Location = new System.Drawing.Point(0, 0);
            this.panelSideBarLogo.Name = "panelSideBarLogo";
            this.panelSideBarLogo.Size = new System.Drawing.Size(160, 63);
            this.panelSideBarLogo.TabIndex = 0;
            this.panelSideBarLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideBarLogo_MouseDown);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Jokerman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.lblTitle2.Location = new System.Drawing.Point(1, 15);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(158, 33);
            this.lblTitle2.TabIndex = 9;
            this.lblTitle2.Text = "Film Library";
            // 
            // timerSideBarAnimate
            // 
            this.timerSideBarAnimate.Interval = 1;
            this.timerSideBarAnimate.Tick += new System.EventHandler(this.timerSideBarAnimate_Tick);
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.Controls.Add(this.lblMainPageHeading);
            this.panelSearchBar.Controls.Add(this.btnMenu);
            this.panelSearchBar.Controls.Add(this.lblUsername);
            this.panelSearchBar.Controls.Add(this.pbProfilePic);
            this.panelSearchBar.Controls.Add(this.panelBtnSearch);
            this.panelSearchBar.Controls.Add(this.txtSearch);
            this.panelSearchBar.Controls.Add(this.panelProfileComboBoxcontainer);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 0);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(809, 97);
            this.panelSearchBar.TabIndex = 0;
            this.panelSearchBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSearchBar_MouseDown);
            // 
            // panelProfileComboBoxcontainer
            // 
            this.panelProfileComboBoxcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfileComboBoxcontainer.Controls.Add(this.cbProfile);
            this.panelProfileComboBoxcontainer.Location = new System.Drawing.Point(775, 27);
            this.panelProfileComboBoxcontainer.Name = "panelProfileComboBoxcontainer";
            this.panelProfileComboBoxcontainer.Size = new System.Drawing.Size(10, 10);
            this.panelProfileComboBoxcontainer.TabIndex = 11;
            // 
            // cbProfile
            // 
            this.cbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(157)))), ((int)(((byte)(116)))));
            this.cbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfile.ForeColor = System.Drawing.Color.Black;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Items.AddRange(new object[] {
            "Something",
            "Logout"});
            this.cbProfile.Location = new System.Drawing.Point(-100, 10);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(117, 24);
            this.cbProfile.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(49, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(530, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panelBtnSearch
            // 
            this.panelBtnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBtnSearch.Controls.Add(this.btnSearch);
            this.panelBtnSearch.Location = new System.Drawing.Point(576, 21);
            this.panelBtnSearch.Name = "panelBtnSearch";
            this.panelBtnSearch.Size = new System.Drawing.Size(31, 26);
            this.panelBtnSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 18);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(646, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(101, 17);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "UsernameAB";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // flpSearchedMoviesContainer
            // 
            this.flpSearchedMoviesContainer.AutoSize = true;
            this.flpSearchedMoviesContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSearchedMoviesContainer.Controls.Add(this.panelSearchedMovie);
            this.flpSearchedMoviesContainer.Controls.Add(this.panel1);
            this.flpSearchedMoviesContainer.Controls.Add(this.panel2);
            this.flpSearchedMoviesContainer.Enabled = false;
            this.flpSearchedMoviesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearchedMoviesContainer.Location = new System.Drawing.Point(49, 0);
            this.flpSearchedMoviesContainer.Name = "flpSearchedMoviesContainer";
            this.flpSearchedMoviesContainer.Size = new System.Drawing.Size(558, 266);
            this.flpSearchedMoviesContainer.TabIndex = 3;
            this.flpSearchedMoviesContainer.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 82);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(69, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(443, 37);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 82);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(443, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Year)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // panelSearchedMovie
            // 
            this.panelSearchedMovie.Controls.Add(this.flpTitleAndYear);
            this.panelSearchedMovie.Controls.Add(this.pbCover);
            this.panelSearchedMovie.Location = new System.Drawing.Point(3, 3);
            this.panelSearchedMovie.Name = "panelSearchedMovie";
            this.panelSearchedMovie.Size = new System.Drawing.Size(547, 82);
            this.panelSearchedMovie.TabIndex = 6;
            // 
            // pbCover
            // 
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.Location = new System.Drawing.Point(5, 6);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(55, 71);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // flpTitleAndYear
            // 
            this.flpTitleAndYear.Controls.Add(this.lblTitle);
            this.flpTitleAndYear.Controls.Add(this.lblReleaseYear);
            this.flpTitleAndYear.Location = new System.Drawing.Point(69, 13);
            this.flpTitleAndYear.Name = "flpTitleAndYear";
            this.flpTitleAndYear.Size = new System.Drawing.Size(443, 37);
            this.flpTitleAndYear.TabIndex = 1;
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.ForeColor = System.Drawing.Color.White;
            this.lblReleaseYear.Location = new System.Drawing.Point(49, 0);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(54, 17);
            this.lblReleaseYear.TabIndex = 5;
            this.lblReleaseYear.Text = "(Year)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flpSearchedMoviesContainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(809, 626);
            this.panelMain.TabIndex = 1;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(748, 15);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(32, 32);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 9;
            this.pbProfilePic.TabStop = false;
            this.pbProfilePic.Click += new System.EventHandler(this.pbProfilePic_Click);
            // 
            // genreButton1
            // 
            this.genreButton1.BackColor = System.Drawing.Color.Transparent;
            this.genreButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.genreButton1.Enabled = false;
            this.genreButton1.FlatAppearance.BorderSize = 0;
            this.genreButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genreButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.genreButton1.ForeColor = System.Drawing.Color.Black;
            this.genreButton1.Location = new System.Drawing.Point(0, 0);
            this.genreButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.genreButton1.Name = "genreButton1";
            this.genreButton1.Size = new System.Drawing.Size(157, 23);
            this.genreButton1.TabIndex = 12;
            this.genreButton1.Text = "Genre";
            this.genreButton1.UseVisualStyleBackColor = false;
            this.genreButton1.Visible = false;
            // 
            // lblMainPageHeading
            // 
            this.lblMainPageHeading.AutoSize = true;
            this.lblMainPageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPageHeading.ForeColor = System.Drawing.Color.White;
            this.lblMainPageHeading.Location = new System.Drawing.Point(6, 63);
            this.lblMainPageHeading.Name = "lblMainPageHeading";
            this.lblMainPageHeading.Size = new System.Drawing.Size(92, 25);
            this.lblMainPageHeading.TabIndex = 14;
            this.lblMainPageHeading.Text = "Heading";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(969, 723);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Library";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.flpMenu.PerformLayout();
            this.panelGenresContainer.ResumeLayout(false);
            this.panelSideBarLogo.ResumeLayout(false);
            this.panelSideBarLogo.PerformLayout();
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelProfileComboBoxcontainer.ResumeLayout(false);
            this.panelBtnSearch.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.flpSearchedMoviesContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelSearchedMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.flpTitleAndYear.ResumeLayout(false);
            this.flpTitleAndYear.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelSideBarLogo;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMyWatchlists;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Timer timerSideBarAnimate;
        private System.Windows.Forms.Button btnPublicWatchlists;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Panel panelGenresContainer;
        private GenreButton genreButton1;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblUsername;
        private CircularPictureBox pbProfilePic;
        private System.Windows.Forms.Panel panelBtnSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelProfileComboBoxcontainer;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flpSearchedMoviesContainer;
        private System.Windows.Forms.Panel panelSearchedMovie;
        private System.Windows.Forms.FlowLayoutPanel flpTitleAndYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMainPageHeading;
    }
}