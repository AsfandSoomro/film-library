
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
            this.timerSideBarAnimate = new System.Windows.Forms.Timer(this.components);
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new FilmLibrary.MyTextBox();
            this.lblMainPageHeading = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pbProfilePic = new FilmLibrary.CircularPictureBox();
            this.panelBtnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lineDesign1 = new System.Windows.Forms.Panel();
            this.lineDesign2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flpSearchedMoviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchedMovie = new System.Windows.Forms.Panel();
            this.flpTitleAndYear = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.flpManage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblManage = new System.Windows.Forms.Label();
            this.btnManageMovies = new System.Windows.Forms.Button();
            this.panelManageMoviesContainer = new System.Windows.Forms.Panel();
            this.btnDeleteMovie = new FilmLibrary.SideBarSubCategoryButton();
            this.btnUpdateMovie = new FilmLibrary.SideBarSubCategoryButton();
            this.btnAddMovie = new FilmLibrary.SideBarSubCategoryButton();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTerms = new System.Windows.Forms.Button();
            this.btnPrivacy = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMyWatchlists = new System.Windows.Forms.Button();
            this.panelUserWatchlistsContainer = new System.Windows.Forms.Panel();
            this.watchlistButton1 = new FilmLibrary.WatchlistButton();
            this.btnCreateWatchlist = new FilmLibrary.SideBarSubCategoryButton();
            this.btnPublicWatchlists = new System.Windows.Forms.Button();
            this.panelPublicWatchlistsContainer = new System.Windows.Forms.Panel();
            this.watchlistButton2 = new FilmLibrary.WatchlistButton();
            this.btnCreateWatchlist2 = new FilmLibrary.SideBarSubCategoryButton();
            this.btnGenres = new System.Windows.Forms.Button();
            this.panelGenresContainer = new System.Windows.Forms.Panel();
            this.btnGenre = new FilmLibrary.GenreButton();
            this.ucProfileMenu = new FilmLibrary.UCProfileMenu();
            this.panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.panelBtnSearch.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flpSearchedMoviesContainer.SuspendLayout();
            this.panelSearchedMovie.SuspendLayout();
            this.flpTitleAndYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.flpManage.SuspendLayout();
            this.panelManageMoviesContainer.SuspendLayout();
            this.flpSettings.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panelUserWatchlistsContainer.SuspendLayout();
            this.panelPublicWatchlistsContainer.SuspendLayout();
            this.panelGenresContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSideBarAnimate
            // 
            this.timerSideBarAnimate.Interval = 1;
            this.timerSideBarAnimate.Tick += new System.EventHandler(this.timerSideBarAnimate_Tick);
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.panelSearchBar.Controls.Add(this.pictureBox3);
            this.panelSearchBar.Controls.Add(this.txtSearch);
            this.panelSearchBar.Controls.Add(this.lblMainPageHeading);
            this.panelSearchBar.Controls.Add(this.btnMenu);
            this.panelSearchBar.Controls.Add(this.pbProfilePic);
            this.panelSearchBar.Controls.Add(this.panelBtnSearch);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 0);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(969, 97);
            this.panelSearchBar.TabIndex = 2;
            this.panelSearchBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSearchBar_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.txtSearch.IsPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(245, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.OriginalText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(530, 26);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Search";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lblMainPageHeading
            // 
            this.lblMainPageHeading.AutoSize = true;
            this.lblMainPageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPageHeading.ForeColor = System.Drawing.Color.White;
            this.lblMainPageHeading.Location = new System.Drawing.Point(202, 63);
            this.lblMainPageHeading.Name = "lblMainPageHeading";
            this.lblMainPageHeading.Size = new System.Drawing.Size(92, 25);
            this.lblMainPageHeading.TabIndex = 14;
            this.lblMainPageHeading.Text = "Heading";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(193, 15);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(887, 15);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(42, 42);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 9;
            this.pbProfilePic.TabStop = false;
            this.pbProfilePic.Click += new System.EventHandler(this.pbProfilePic_Click);
            // 
            // panelBtnSearch
            // 
            this.panelBtnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBtnSearch.Controls.Add(this.btnSearch);
            this.panelBtnSearch.Location = new System.Drawing.Point(772, 21);
            this.panelBtnSearch.Name = "panelBtnSearch";
            this.panelBtnSearch.Size = new System.Drawing.Size(31, 26);
            this.panelBtnSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(4, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 18);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.lineDesign1);
            this.panelContainer.Controls.Add(this.lineDesign2);
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelSideBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 97);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(969, 626);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // lineDesign1
            // 
            this.lineDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.lineDesign1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineDesign1.Location = new System.Drawing.Point(200, 0);
            this.lineDesign1.Name = "lineDesign1";
            this.lineDesign1.Size = new System.Drawing.Size(769, 2);
            this.lineDesign1.TabIndex = 20;
            // 
            // lineDesign2
            // 
            this.lineDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(166)))));
            this.lineDesign2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineDesign2.Location = new System.Drawing.Point(198, 0);
            this.lineDesign2.Name = "lineDesign2";
            this.lineDesign2.Size = new System.Drawing.Size(2, 626);
            this.lineDesign2.TabIndex = 19;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.panelMain.Controls.Add(this.flpSearchedMoviesContainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(198, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(771, 626);
            this.panelMain.TabIndex = 3;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.Resize += new System.EventHandler(this.panelMain_Resize);
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
            this.flpSearchedMoviesContainer.Location = new System.Drawing.Point(45, 0);
            this.flpSearchedMoviesContainer.Name = "flpSearchedMoviesContainer";
            this.flpSearchedMoviesContainer.Size = new System.Drawing.Size(558, 266);
            this.flpSearchedMoviesContainer.TabIndex = 3;
            this.flpSearchedMoviesContainer.Visible = false;
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
            // flpTitleAndYear
            // 
            this.flpTitleAndYear.Controls.Add(this.lblTitle);
            this.flpTitleAndYear.Controls.Add(this.lblReleaseYear);
            this.flpTitleAndYear.Location = new System.Drawing.Point(69, 13);
            this.flpTitleAndYear.Name = "flpTitleAndYear";
            this.flpTitleAndYear.Size = new System.Drawing.Size(443, 37);
            this.flpTitleAndYear.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 82);
            this.panel1.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 82);
            this.panel2.TabIndex = 8;
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
            // panelSideBar
            // 
            this.panelSideBar.AutoScroll = true;
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.panelSideBar.Controls.Add(this.flpManage);
            this.panelSideBar.Controls.Add(this.flpSettings);
            this.panelSideBar.Controls.Add(this.flpMenu);
            this.panelSideBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(198, 626);
            this.panelSideBar.TabIndex = 2;
            this.panelSideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideBar_MouseDown);
            // 
            // flpManage
            // 
            this.flpManage.AutoSize = true;
            this.flpManage.BackColor = System.Drawing.Color.Transparent;
            this.flpManage.Controls.Add(this.lblManage);
            this.flpManage.Controls.Add(this.btnManageMovies);
            this.flpManage.Controls.Add(this.panelManageMoviesContainer);
            this.flpManage.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpManage.Enabled = false;
            this.flpManage.Location = new System.Drawing.Point(0, 749);
            this.flpManage.Name = "flpManage";
            this.flpManage.Size = new System.Drawing.Size(181, 190);
            this.flpManage.TabIndex = 3;
            this.flpManage.Visible = false;
            this.flpManage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpManage_MouseDown);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.BackColor = System.Drawing.Color.Transparent;
            this.lblManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblManage.Location = new System.Drawing.Point(3, 10);
            this.lblManage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(85, 24);
            this.lblManage.TabIndex = 12;
            this.lblManage.Text = "Manage";
            // 
            // btnManageMovies
            // 
            this.btnManageMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnManageMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMovies.FlatAppearance.BorderSize = 0;
            this.btnManageMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnManageMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnManageMovies.Image = ((System.Drawing.Image)(resources.GetObject("btnManageMovies.Image")));
            this.btnManageMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMovies.Location = new System.Drawing.Point(3, 49);
            this.btnManageMovies.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnManageMovies.Name = "btnManageMovies";
            this.btnManageMovies.Size = new System.Drawing.Size(198, 38);
            this.btnManageMovies.TabIndex = 13;
            this.btnManageMovies.Text = "Movies";
            this.btnManageMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageMovies.UseVisualStyleBackColor = false;
            this.btnManageMovies.Click += new System.EventHandler(this.btnManageMovies_Click);
            // 
            // panelManageMoviesContainer
            // 
            this.panelManageMoviesContainer.AutoScroll = true;
            this.panelManageMoviesContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelManageMoviesContainer.Controls.Add(this.btnDeleteMovie);
            this.panelManageMoviesContainer.Controls.Add(this.btnUpdateMovie);
            this.panelManageMoviesContainer.Controls.Add(this.btnAddMovie);
            this.panelManageMoviesContainer.Enabled = false;
            this.panelManageMoviesContainer.Location = new System.Drawing.Point(3, 87);
            this.panelManageMoviesContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelManageMoviesContainer.Name = "panelManageMoviesContainer";
            this.panelManageMoviesContainer.Size = new System.Drawing.Size(180, 100);
            this.panelManageMoviesContainer.TabIndex = 20;
            this.panelManageMoviesContainer.Visible = false;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteMovie.FlatAppearance.BorderSize = 0;
            this.btnDeleteMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteMovie.Location = new System.Drawing.Point(0, 46);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteMovie.TabIndex = 2;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMovie.FlatAppearance.BorderSize = 0;
            this.btnUpdateMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnUpdateMovie.Location = new System.Drawing.Point(0, 23);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(180, 23);
            this.btnUpdateMovie.TabIndex = 1;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMovie.FlatAppearance.BorderSize = 0;
            this.btnAddMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddMovie.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddMovie.Location = new System.Drawing.Point(0, 0);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(180, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // flpSettings
            // 
            this.flpSettings.AutoSize = true;
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Controls.Add(this.lblSettings);
            this.flpSettings.Controls.Add(this.btnFAQ);
            this.flpSettings.Controls.Add(this.btnHelp);
            this.flpSettings.Controls.Add(this.btnTerms);
            this.flpSettings.Controls.Add(this.btnPrivacy);
            this.flpSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSettings.Location = new System.Drawing.Point(0, 548);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(181, 201);
            this.flpSettings.TabIndex = 2;
            this.flpSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpSettings_MouseDown);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblSettings.Location = new System.Drawing.Point(3, 10);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(84, 24);
            this.lblSettings.TabIndex = 11;
            this.lblSettings.Text = "Settings";
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnFAQ.Image = ((System.Drawing.Image)(resources.GetObject("btnFAQ.Image")));
            this.btnFAQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.Location = new System.Drawing.Point(3, 49);
            this.btnFAQ.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(198, 38);
            this.btnFAQ.TabIndex = 13;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFAQ.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(3, 87);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(198, 38);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help Center";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnTerms
            // 
            this.btnTerms.BackColor = System.Drawing.Color.Transparent;
            this.btnTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerms.FlatAppearance.BorderSize = 0;
            this.btnTerms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnTerms.Image = ((System.Drawing.Image)(resources.GetObject("btnTerms.Image")));
            this.btnTerms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerms.Location = new System.Drawing.Point(3, 125);
            this.btnTerms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTerms.Name = "btnTerms";
            this.btnTerms.Size = new System.Drawing.Size(198, 38);
            this.btnTerms.TabIndex = 15;
            this.btnTerms.Text = "Terms of Use";
            this.btnTerms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTerms.UseVisualStyleBackColor = false;
            // 
            // btnPrivacy
            // 
            this.btnPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.btnPrivacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrivacy.FlatAppearance.BorderSize = 0;
            this.btnPrivacy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPrivacy.Image = ((System.Drawing.Image)(resources.GetObject("btnPrivacy.Image")));
            this.btnPrivacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivacy.Location = new System.Drawing.Point(3, 163);
            this.btnPrivacy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPrivacy.Name = "btnPrivacy";
            this.btnPrivacy.Size = new System.Drawing.Size(198, 38);
            this.btnPrivacy.TabIndex = 16;
            this.btnPrivacy.Text = "Privacy";
            this.btnPrivacy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrivacy.UseVisualStyleBackColor = false;
            // 
            // flpMenu
            // 
            this.flpMenu.AutoSize = true;
            this.flpMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpMenu.Controls.Add(this.lblMenu);
            this.flpMenu.Controls.Add(this.btnDashboard);
            this.flpMenu.Controls.Add(this.btnHome);
            this.flpMenu.Controls.Add(this.btnMyWatchlists);
            this.flpMenu.Controls.Add(this.panelUserWatchlistsContainer);
            this.flpMenu.Controls.Add(this.btnPublicWatchlists);
            this.flpMenu.Controls.Add(this.panelPublicWatchlistsContainer);
            this.flpMenu.Controls.Add(this.btnGenres);
            this.flpMenu.Controls.Add(this.panelGenresContainer);
            this.flpMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(181, 548);
            this.flpMenu.TabIndex = 1;
            this.flpMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpMenu_MouseDown);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblMenu.Location = new System.Drawing.Point(3, 10);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 49);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(198, 38);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 87);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(198, 38);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMyWatchlists
            // 
            this.btnMyWatchlists.BackColor = System.Drawing.Color.Transparent;
            this.btnMyWatchlists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyWatchlists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyWatchlists.FlatAppearance.BorderSize = 0;
            this.btnMyWatchlists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnMyWatchlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyWatchlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyWatchlists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnMyWatchlists.Image = ((System.Drawing.Image)(resources.GetObject("btnMyWatchlists.Image")));
            this.btnMyWatchlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWatchlists.Location = new System.Drawing.Point(3, 125);
            this.btnMyWatchlists.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMyWatchlists.Name = "btnMyWatchlists";
            this.btnMyWatchlists.Size = new System.Drawing.Size(198, 38);
            this.btnMyWatchlists.TabIndex = 8;
            this.btnMyWatchlists.Text = "My Watchlists";
            this.btnMyWatchlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWatchlists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyWatchlists.UseVisualStyleBackColor = false;
            this.btnMyWatchlists.Click += new System.EventHandler(this.btnMyWatchlists_Click);
            // 
            // panelUserWatchlistsContainer
            // 
            this.panelUserWatchlistsContainer.AutoScroll = true;
            this.panelUserWatchlistsContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelUserWatchlistsContainer.Controls.Add(this.watchlistButton1);
            this.panelUserWatchlistsContainer.Controls.Add(this.btnCreateWatchlist);
            this.panelUserWatchlistsContainer.Enabled = false;
            this.panelUserWatchlistsContainer.Location = new System.Drawing.Point(3, 163);
            this.panelUserWatchlistsContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelUserWatchlistsContainer.Name = "panelUserWatchlistsContainer";
            this.panelUserWatchlistsContainer.Size = new System.Drawing.Size(180, 100);
            this.panelUserWatchlistsContainer.TabIndex = 13;
            this.panelUserWatchlistsContainer.Visible = false;
            // 
            // watchlistButton1
            // 
            this.watchlistButton1.BackColor = System.Drawing.Color.Transparent;
            this.watchlistButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.watchlistButton1.Enabled = false;
            this.watchlistButton1.FlatAppearance.BorderSize = 0;
            this.watchlistButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.watchlistButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.watchlistButton1.Location = new System.Drawing.Point(0, 23);
            this.watchlistButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.watchlistButton1.Name = "watchlistButton1";
            this.watchlistButton1.Size = new System.Drawing.Size(180, 23);
            this.watchlistButton1.TabIndex = 2;
            this.watchlistButton1.Text = "Watchlist";
            this.watchlistButton1.UseVisualStyleBackColor = false;
            this.watchlistButton1.Visible = false;
            // 
            // btnCreateWatchlist
            // 
            this.btnCreateWatchlist.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateWatchlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateWatchlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateWatchlist.FlatAppearance.BorderSize = 0;
            this.btnCreateWatchlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnCreateWatchlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreateWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWatchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreateWatchlist.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCreateWatchlist.Location = new System.Drawing.Point(0, 0);
            this.btnCreateWatchlist.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCreateWatchlist.Name = "btnCreateWatchlist";
            this.btnCreateWatchlist.Size = new System.Drawing.Size(180, 23);
            this.btnCreateWatchlist.TabIndex = 1;
            this.btnCreateWatchlist.Text = "Create";
            this.btnCreateWatchlist.UseVisualStyleBackColor = false;
            this.btnCreateWatchlist.Click += new System.EventHandler(this.btnCreateWatchlist_Click);
            // 
            // btnPublicWatchlists
            // 
            this.btnPublicWatchlists.BackColor = System.Drawing.Color.Transparent;
            this.btnPublicWatchlists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicWatchlists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublicWatchlists.FlatAppearance.BorderSize = 0;
            this.btnPublicWatchlists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnPublicWatchlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicWatchlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicWatchlists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPublicWatchlists.Image = ((System.Drawing.Image)(resources.GetObject("btnPublicWatchlists.Image")));
            this.btnPublicWatchlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicWatchlists.Location = new System.Drawing.Point(3, 266);
            this.btnPublicWatchlists.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPublicWatchlists.Name = "btnPublicWatchlists";
            this.btnPublicWatchlists.Size = new System.Drawing.Size(198, 38);
            this.btnPublicWatchlists.TabIndex = 14;
            this.btnPublicWatchlists.Text = "Public Watchlists";
            this.btnPublicWatchlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicWatchlists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublicWatchlists.UseVisualStyleBackColor = false;
            this.btnPublicWatchlists.Click += new System.EventHandler(this.btnPublicWatchlists_Click);
            // 
            // panelPublicWatchlistsContainer
            // 
            this.panelPublicWatchlistsContainer.AutoScroll = true;
            this.panelPublicWatchlistsContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelPublicWatchlistsContainer.Controls.Add(this.watchlistButton2);
            this.panelPublicWatchlistsContainer.Controls.Add(this.btnCreateWatchlist2);
            this.panelPublicWatchlistsContainer.Enabled = false;
            this.panelPublicWatchlistsContainer.Location = new System.Drawing.Point(3, 304);
            this.panelPublicWatchlistsContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelPublicWatchlistsContainer.Name = "panelPublicWatchlistsContainer";
            this.panelPublicWatchlistsContainer.Size = new System.Drawing.Size(180, 100);
            this.panelPublicWatchlistsContainer.TabIndex = 17;
            this.panelPublicWatchlistsContainer.Visible = false;
            // 
            // watchlistButton2
            // 
            this.watchlistButton2.BackColor = System.Drawing.Color.Transparent;
            this.watchlistButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.watchlistButton2.Enabled = false;
            this.watchlistButton2.FlatAppearance.BorderSize = 0;
            this.watchlistButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.watchlistButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.watchlistButton2.Location = new System.Drawing.Point(0, 23);
            this.watchlistButton2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.watchlistButton2.Name = "watchlistButton2";
            this.watchlistButton2.Size = new System.Drawing.Size(180, 23);
            this.watchlistButton2.TabIndex = 3;
            this.watchlistButton2.Text = "Watchlist";
            this.watchlistButton2.UseVisualStyleBackColor = false;
            this.watchlistButton2.Visible = false;
            // 
            // btnCreateWatchlist2
            // 
            this.btnCreateWatchlist2.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateWatchlist2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateWatchlist2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateWatchlist2.FlatAppearance.BorderSize = 0;
            this.btnCreateWatchlist2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnCreateWatchlist2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreateWatchlist2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWatchlist2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreateWatchlist2.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCreateWatchlist2.Location = new System.Drawing.Point(0, 0);
            this.btnCreateWatchlist2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCreateWatchlist2.Name = "btnCreateWatchlist2";
            this.btnCreateWatchlist2.Size = new System.Drawing.Size(180, 23);
            this.btnCreateWatchlist2.TabIndex = 2;
            this.btnCreateWatchlist2.Text = "Create";
            this.btnCreateWatchlist2.UseVisualStyleBackColor = false;
            this.btnCreateWatchlist2.Click += new System.EventHandler(this.btnCreateWatchlist2_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.BackColor = System.Drawing.Color.Transparent;
            this.btnGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.FlatAppearance.BorderSize = 0;
            this.btnGenres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnGenres.Image = ((System.Drawing.Image)(resources.GetObject("btnGenres.Image")));
            this.btnGenres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.Location = new System.Drawing.Point(3, 407);
            this.btnGenres.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(198, 38);
            this.btnGenres.TabIndex = 18;
            this.btnGenres.Text = "Genres";
            this.btnGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenres.UseVisualStyleBackColor = false;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // panelGenresContainer
            // 
            this.panelGenresContainer.AutoScroll = true;
            this.panelGenresContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelGenresContainer.Controls.Add(this.btnGenre);
            this.panelGenresContainer.Enabled = false;
            this.panelGenresContainer.Location = new System.Drawing.Point(3, 445);
            this.panelGenresContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelGenresContainer.Name = "panelGenresContainer";
            this.panelGenresContainer.Size = new System.Drawing.Size(180, 100);
            this.panelGenresContainer.TabIndex = 19;
            this.panelGenresContainer.Visible = false;
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.Transparent;
            this.btnGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.Enabled = false;
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnGenre.Location = new System.Drawing.Point(0, 0);
            this.btnGenre.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(180, 23);
            this.btnGenre.TabIndex = 12;
            this.btnGenre.Text = "Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Visible = false;
            // 
            // ucProfileMenu
            // 
            this.ucProfileMenu.AutoSize = true;
            this.ucProfileMenu.BackColor = System.Drawing.Color.Transparent;
            this.ucProfileMenu.Location = new System.Drawing.Point(760, 68);
            this.ucProfileMenu.Name = "ucProfileMenu";
            this.ucProfileMenu.Size = new System.Drawing.Size(176, 243);
            this.ucProfileMenu.TabIndex = 18;
            this.ucProfileMenu.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 723);
            this.Controls.Add(this.ucProfileMenu);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSearchBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(770, 250);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Library";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.panelBtnSearch.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flpSearchedMoviesContainer.ResumeLayout(false);
            this.panelSearchedMovie.ResumeLayout(false);
            this.flpTitleAndYear.ResumeLayout(false);
            this.flpTitleAndYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.flpManage.ResumeLayout(false);
            this.flpManage.PerformLayout();
            this.panelManageMoviesContainer.ResumeLayout(false);
            this.flpSettings.ResumeLayout(false);
            this.flpSettings.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.flpMenu.PerformLayout();
            this.panelUserWatchlistsContainer.ResumeLayout(false);
            this.panelPublicWatchlistsContainer.ResumeLayout(false);
            this.panelGenresContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerSideBarAnimate;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MyTextBox txtSearch;
        private System.Windows.Forms.Label lblMainPageHeading;
        private System.Windows.Forms.Button btnMenu;
        private CircularPictureBox pbProfilePic;
        private System.Windows.Forms.Panel panelBtnSearch;
        private System.Windows.Forms.Button btnSearch;
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
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.FlowLayoutPanel flpManage;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTerms;
        private System.Windows.Forms.Button btnPrivacy;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMyWatchlists;
        private System.Windows.Forms.Panel panelUserWatchlistsContainer;
        private WatchlistButton watchlistButton1;
        private SideBarSubCategoryButton btnCreateWatchlist;
        private System.Windows.Forms.Button btnPublicWatchlists;
        private System.Windows.Forms.Panel panelPublicWatchlistsContainer;
        private WatchlistButton watchlistButton2;
        private SideBarSubCategoryButton btnCreateWatchlist2;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Panel panelGenresContainer;
        private GenreButton btnGenre;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageMovies;
        private System.Windows.Forms.Panel panelManageMoviesContainer;
        private SideBarSubCategoryButton btnDeleteMovie;
        private SideBarSubCategoryButton btnUpdateMovie;
        private SideBarSubCategoryButton btnAddMovie;
        private System.Windows.Forms.Panel lineDesign1;
        private System.Windows.Forms.Panel lineDesign2;
        private UCProfileMenu ucProfileMenu;
    }
}