namespace Hw4
{
    partial class FormMovieSearch
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
            this.splitContainSearch = new System.Windows.Forms.SplitContainer();
            this.listSearchGenre = new System.Windows.Forms.ListBox();
            this.labelOtherGene = new System.Windows.Forms.Label();
            this.picBoxComedy = new System.Windows.Forms.PictureBox();
            this.picBoxFantasy = new System.Windows.Forms.PictureBox();
            this.picBoxAction = new System.Windows.Forms.PictureBox();
            this.picBoxSciFi = new System.Windows.Forms.PictureBox();
            this.labelPopGenre = new System.Windows.Forms.Label();
            this.picBoxG = new System.Windows.Forms.PictureBox();
            this.picBoxPG = new System.Windows.Forms.PictureBox();
            this.picBoxNR = new System.Windows.Forms.PictureBox();
            this.picBoxUR = new System.Windows.Forms.PictureBox();
            this.picBoxPG13 = new System.Windows.Forms.PictureBox();
            this.picBoxNC = new System.Windows.Forms.PictureBox();
            this.picBoxR = new System.Windows.Forms.PictureBox();
            this.labelSearchRating = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridMovies = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Released = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchInput = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelActor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.labelMovieReview = new System.Windows.Forms.Label();
            this.labelMovieDirector = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelReview = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.tabPopActorDirector = new System.Windows.Forms.TabControl();
            this.tabPagePopActor = new System.Windows.Forms.TabPage();
            this.dataGridPopActor = new System.Windows.Forms.DataGridView();
            this.Actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePopDirector = new System.Windows.Forms.TabPage();
            this.dataGridPopDirector = new System.Windows.Forms.DataGridView();
            this.Directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBoxMoviePoster = new System.Windows.Forms.PictureBox();
            this.dataGridActor = new System.Windows.Forms.DataGridView();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridMovieD = new System.Windows.Forms.DataGridView();
            this.Title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Released2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridGenres = new System.Windows.Forms.DataGridView();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainSearch)).BeginInit();
            this.splitContainSearch.Panel1.SuspendLayout();
            this.splitContainSearch.Panel2.SuspendLayout();
            this.splitContainSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComedy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFantasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSciFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPG13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
            this.tabPopActorDirector.SuspendLayout();
            this.tabPagePopActor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopActor)).BeginInit();
            this.tabPagePopDirector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainSearch
            // 
            this.splitContainSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainSearch.IsSplitterFixed = true;
            this.splitContainSearch.Location = new System.Drawing.Point(12, 12);
            this.splitContainSearch.Name = "splitContainSearch";
            this.splitContainSearch.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainSearch.Panel1
            // 
            this.splitContainSearch.Panel1.Controls.Add(this.listSearchGenre);
            this.splitContainSearch.Panel1.Controls.Add(this.labelOtherGene);
            this.splitContainSearch.Panel1.Controls.Add(this.picBoxComedy);
            this.splitContainSearch.Panel1.Controls.Add(this.picBoxFantasy);
            this.splitContainSearch.Panel1.Controls.Add(this.picBoxAction);
            this.splitContainSearch.Panel1.Controls.Add(this.picBoxSciFi);
            this.splitContainSearch.Panel1.Controls.Add(this.labelPopGenre);
            // 
            // splitContainSearch.Panel2
            // 
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxG);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxPG);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxNR);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxUR);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxPG13);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxNC);
            this.splitContainSearch.Panel2.Controls.Add(this.picBoxR);
            this.splitContainSearch.Panel2.Controls.Add(this.labelSearchRating);
            this.splitContainSearch.Size = new System.Drawing.Size(257, 515);
            this.splitContainSearch.SplitterDistance = 256;
            this.splitContainSearch.TabIndex = 0;
            // 
            // listSearchGenre
            // 
            this.listSearchGenre.FormattingEnabled = true;
            this.listSearchGenre.Items.AddRange(new object[] {
            "Adventure",
            "Animated",
            "Biography",
            "Children",
            "Classic",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Foreign",
            "Historical",
            "Horror",
            "Intrigue",
            "Musical"});
            this.listSearchGenre.Location = new System.Drawing.Point(24, 181);
            this.listSearchGenre.Name = "listSearchGenre";
            this.listSearchGenre.Size = new System.Drawing.Size(164, 56);
            this.listSearchGenre.TabIndex = 6;
            this.listSearchGenre.SelectedIndexChanged += new System.EventHandler(this.listSearchGenre_SelectedIndexChanged);
            // 
            // labelOtherGene
            // 
            this.labelOtherGene.AutoSize = true;
            this.labelOtherGene.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherGene.Location = new System.Drawing.Point(21, 165);
            this.labelOtherGene.Name = "labelOtherGene";
            this.labelOtherGene.Size = new System.Drawing.Size(86, 13);
            this.labelOtherGene.TabIndex = 6;
            this.labelOtherGene.Text = "Other Genres:";
            // 
            // picBoxComedy
            // 
            this.picBoxComedy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxComedy.Image = global::Hw4.Properties.Resources.comedy;
            this.picBoxComedy.Location = new System.Drawing.Point(134, 102);
            this.picBoxComedy.Name = "picBoxComedy";
            this.picBoxComedy.Size = new System.Drawing.Size(100, 50);
            this.picBoxComedy.TabIndex = 7;
            this.picBoxComedy.TabStop = false;
            this.picBoxComedy.Click += new System.EventHandler(this.picBoxComedy_Click);
            // 
            // picBoxFantasy
            // 
            this.picBoxFantasy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxFantasy.Image = global::Hw4.Properties.Resources.fantasy;
            this.picBoxFantasy.Location = new System.Drawing.Point(14, 102);
            this.picBoxFantasy.Name = "picBoxFantasy";
            this.picBoxFantasy.Size = new System.Drawing.Size(100, 50);
            this.picBoxFantasy.TabIndex = 7;
            this.picBoxFantasy.TabStop = false;
            this.picBoxFantasy.Click += new System.EventHandler(this.picBoxFantasy_Click);
            // 
            // picBoxAction
            // 
            this.picBoxAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAction.Image = global::Hw4.Properties.Resources.action;
            this.picBoxAction.Location = new System.Drawing.Point(134, 42);
            this.picBoxAction.Name = "picBoxAction";
            this.picBoxAction.Size = new System.Drawing.Size(100, 50);
            this.picBoxAction.TabIndex = 7;
            this.picBoxAction.TabStop = false;
            this.picBoxAction.Click += new System.EventHandler(this.picBoxAction_Click);
            // 
            // picBoxSciFi
            // 
            this.picBoxSciFi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxSciFi.Image = global::Hw4.Properties.Resources.sci_fi;
            this.picBoxSciFi.Location = new System.Drawing.Point(14, 42);
            this.picBoxSciFi.Name = "picBoxSciFi";
            this.picBoxSciFi.Size = new System.Drawing.Size(100, 50);
            this.picBoxSciFi.TabIndex = 7;
            this.picBoxSciFi.TabStop = false;
            this.picBoxSciFi.Click += new System.EventHandler(this.picBoxSciFi_Click);
            // 
            // labelPopGenre
            // 
            this.labelPopGenre.AutoSize = true;
            this.labelPopGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopGenre.Location = new System.Drawing.Point(21, 13);
            this.labelPopGenre.Name = "labelPopGenre";
            this.labelPopGenre.Size = new System.Drawing.Size(98, 13);
            this.labelPopGenre.TabIndex = 6;
            this.labelPopGenre.Text = "Popular Genres:";
            // 
            // picBoxG
            // 
            this.picBoxG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxG.Image = global::Hw4.Properties.Resources.ratedG;
            this.picBoxG.Location = new System.Drawing.Point(61, 199);
            this.picBoxG.Name = "picBoxG";
            this.picBoxG.Size = new System.Drawing.Size(100, 50);
            this.picBoxG.TabIndex = 7;
            this.picBoxG.TabStop = false;
            this.picBoxG.Click += new System.EventHandler(this.picBoxG_Click);
            // 
            // picBoxPG
            // 
            this.picBoxPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxPG.Image = global::Hw4.Properties.Resources.ratedPG;
            this.picBoxPG.Location = new System.Drawing.Point(134, 143);
            this.picBoxPG.Name = "picBoxPG";
            this.picBoxPG.Size = new System.Drawing.Size(100, 50);
            this.picBoxPG.TabIndex = 7;
            this.picBoxPG.TabStop = false;
            this.picBoxPG.Click += new System.EventHandler(this.picBoxPG_Click);
            // 
            // picBoxNR
            // 
            this.picBoxNR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxNR.Image = global::Hw4.Properties.Resources.ratedNR;
            this.picBoxNR.Location = new System.Drawing.Point(14, 143);
            this.picBoxNR.Name = "picBoxNR";
            this.picBoxNR.Size = new System.Drawing.Size(100, 50);
            this.picBoxNR.TabIndex = 7;
            this.picBoxNR.TabStop = false;
            this.picBoxNR.Click += new System.EventHandler(this.picBoxNR_Click);
            // 
            // picBoxUR
            // 
            this.picBoxUR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxUR.Image = global::Hw4.Properties.Resources.ratedUR;
            this.picBoxUR.Location = new System.Drawing.Point(134, 87);
            this.picBoxUR.Name = "picBoxUR";
            this.picBoxUR.Size = new System.Drawing.Size(100, 50);
            this.picBoxUR.TabIndex = 7;
            this.picBoxUR.TabStop = false;
            this.picBoxUR.Click += new System.EventHandler(this.picBoxUR_Click);
            // 
            // picBoxPG13
            // 
            this.picBoxPG13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxPG13.Image = global::Hw4.Properties.Resources.ratedPG_13;
            this.picBoxPG13.Location = new System.Drawing.Point(14, 87);
            this.picBoxPG13.Name = "picBoxPG13";
            this.picBoxPG13.Size = new System.Drawing.Size(100, 50);
            this.picBoxPG13.TabIndex = 7;
            this.picBoxPG13.TabStop = false;
            this.picBoxPG13.Click += new System.EventHandler(this.picBoxPG13_Click);
            // 
            // picBoxNC
            // 
            this.picBoxNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxNC.Image = global::Hw4.Properties.Resources.ratedNC_17;
            this.picBoxNC.Location = new System.Drawing.Point(134, 31);
            this.picBoxNC.Name = "picBoxNC";
            this.picBoxNC.Size = new System.Drawing.Size(100, 50);
            this.picBoxNC.TabIndex = 7;
            this.picBoxNC.TabStop = false;
            this.picBoxNC.Click += new System.EventHandler(this.picBoxNC_Click);
            // 
            // picBoxR
            // 
            this.picBoxR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxR.Image = global::Hw4.Properties.Resources.ratedR;
            this.picBoxR.Location = new System.Drawing.Point(14, 31);
            this.picBoxR.Name = "picBoxR";
            this.picBoxR.Size = new System.Drawing.Size(100, 50);
            this.picBoxR.TabIndex = 7;
            this.picBoxR.TabStop = false;
            this.picBoxR.Click += new System.EventHandler(this.picBoxR_Click);
            // 
            // labelSearchRating
            // 
            this.labelSearchRating.AutoSize = true;
            this.labelSearchRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchRating.Location = new System.Drawing.Point(21, 15);
            this.labelSearchRating.Name = "labelSearchRating";
            this.labelSearchRating.Size = new System.Drawing.Size(54, 13);
            this.labelSearchRating.TabIndex = 6;
            this.labelSearchRating.Text = "Ratings:";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Search By",
            "Actor",
            "Director",
            "Keyword"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(325, 43);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchBy.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(473, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(680, 44);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridMovies
            // 
            this.dataGridMovies.AllowUserToAddRows = false;
            this.dataGridMovies.AllowUserToDeleteRows = false;
            this.dataGridMovies.AllowUserToResizeColumns = false;
            this.dataGridMovies.AllowUserToResizeRows = false;
            this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Review,
            this.Released,
            this.Rating,
            this.Director});
            this.dataGridMovies.Location = new System.Drawing.Point(288, 115);
            this.dataGridMovies.MultiSelect = false;
            this.dataGridMovies.Name = "dataGridMovies";
            this.dataGridMovies.ReadOnly = true;
            this.dataGridMovies.RowHeadersVisible = false;
            this.dataGridMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMovies.Size = new System.Drawing.Size(603, 106);
            this.dataGridMovies.TabIndex = 4;
            this.dataGridMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMovies_CellContentClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
            // 
            // Review
            // 
            this.Review.DataPropertyName = "Review";
            this.Review.HeaderText = "Review";
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            this.Review.Width = 90;
            // 
            // Released
            // 
            this.Released.DataPropertyName = "Released";
            this.Released.HeaderText = "Released";
            this.Released.Name = "Released";
            this.Released.ReadOnly = true;
            this.Released.Width = 70;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 70;
            // 
            // Director
            // 
            this.Director.DataPropertyName = "Director";
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Width = 150;
            // 
            // labelSearchInput
            // 
            this.labelSearchInput.AutoSize = true;
            this.labelSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchInput.Location = new System.Drawing.Point(525, 92);
            this.labelSearchInput.Name = "labelSearchInput";
            this.labelSearchInput.Size = new System.Drawing.Size(80, 13);
            this.labelSearchInput.TabIndex = 5;
            this.labelSearchInput.Text = "Search Input";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(506, 370);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Movie Title";
            // 
            // labelActor
            // 
            this.labelActor.AutoSize = true;
            this.labelActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActor.Location = new System.Drawing.Point(470, 397);
            this.labelActor.Name = "labelActor";
            this.labelActor.Size = new System.Drawing.Size(78, 13);
            this.labelActor.TabIndex = 7;
            this.labelActor.Text = "Main Actors:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(667, 397);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(51, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genres:";
            // 
            // labelMovieRating
            // 
            this.labelMovieRating.AutoSize = true;
            this.labelMovieRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieRating.Location = new System.Drawing.Point(865, 419);
            this.labelMovieRating.Name = "labelMovieRating";
            this.labelMovieRating.Size = new System.Drawing.Size(48, 13);
            this.labelMovieRating.TabIndex = 9;
            this.labelMovieRating.Text = "Rating:";
            // 
            // labelMovieReview
            // 
            this.labelMovieReview.AutoSize = true;
            this.labelMovieReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieReview.Location = new System.Drawing.Point(865, 453);
            this.labelMovieReview.Name = "labelMovieReview";
            this.labelMovieReview.Size = new System.Drawing.Size(53, 13);
            this.labelMovieReview.TabIndex = 10;
            this.labelMovieReview.Text = "Review:";
            // 
            // labelMovieDirector
            // 
            this.labelMovieDirector.AutoSize = true;
            this.labelMovieDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieDirector.Location = new System.Drawing.Point(865, 486);
            this.labelMovieDirector.Name = "labelMovieDirector";
            this.labelMovieDirector.Size = new System.Drawing.Size(56, 13);
            this.labelMovieDirector.TabIndex = 11;
            this.labelMovieDirector.Text = "Director:";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(938, 419);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 12;
            this.labelRating.Text = "Rating";
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.Location = new System.Drawing.Point(938, 453);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(43, 13);
            this.labelReview.TabIndex = 13;
            this.labelReview.Text = "Review";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(938, 486);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(44, 13);
            this.labelDirector.TabIndex = 14;
            this.labelDirector.Text = "Director";
            // 
            // tabPopActorDirector
            // 
            this.tabPopActorDirector.Controls.Add(this.tabPagePopActor);
            this.tabPopActorDirector.Controls.Add(this.tabPagePopDirector);
            this.tabPopActorDirector.Location = new System.Drawing.Point(909, 119);
            this.tabPopActorDirector.Name = "tabPopActorDirector";
            this.tabPopActorDirector.SelectedIndex = 0;
            this.tabPopActorDirector.Size = new System.Drawing.Size(192, 227);
            this.tabPopActorDirector.TabIndex = 17;
            // 
            // tabPagePopActor
            // 
            this.tabPagePopActor.Controls.Add(this.dataGridPopActor);
            this.tabPagePopActor.Location = new System.Drawing.Point(4, 22);
            this.tabPagePopActor.Name = "tabPagePopActor";
            this.tabPagePopActor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePopActor.Size = new System.Drawing.Size(184, 201);
            this.tabPagePopActor.TabIndex = 0;
            this.tabPagePopActor.Text = "Popular Actors";
            this.tabPagePopActor.UseVisualStyleBackColor = true;
            // 
            // dataGridPopActor
            // 
            this.dataGridPopActor.AllowUserToAddRows = false;
            this.dataGridPopActor.AllowUserToDeleteRows = false;
            this.dataGridPopActor.AllowUserToResizeColumns = false;
            this.dataGridPopActor.AllowUserToResizeRows = false;
            this.dataGridPopActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPopActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actor});
            this.dataGridPopActor.Location = new System.Drawing.Point(15, 17);
            this.dataGridPopActor.Name = "dataGridPopActor";
            this.dataGridPopActor.ReadOnly = true;
            this.dataGridPopActor.RowHeadersVisible = false;
            this.dataGridPopActor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPopActor.Size = new System.Drawing.Size(154, 162);
            this.dataGridPopActor.TabIndex = 0;
            this.dataGridPopActor.Click += new System.EventHandler(this.dataGridPopActor_Click);
            // 
            // Actor
            // 
            this.Actor.DataPropertyName = "ACTOR";
            this.Actor.HeaderText = "Actor";
            this.Actor.Name = "Actor";
            this.Actor.ReadOnly = true;
            this.Actor.Width = 150;
            // 
            // tabPagePopDirector
            // 
            this.tabPagePopDirector.Controls.Add(this.dataGridPopDirector);
            this.tabPagePopDirector.Location = new System.Drawing.Point(4, 22);
            this.tabPagePopDirector.Name = "tabPagePopDirector";
            this.tabPagePopDirector.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePopDirector.Size = new System.Drawing.Size(184, 201);
            this.tabPagePopDirector.TabIndex = 1;
            this.tabPagePopDirector.Text = "Popular Directors";
            this.tabPagePopDirector.UseVisualStyleBackColor = true;
            // 
            // dataGridPopDirector
            // 
            this.dataGridPopDirector.AllowUserToAddRows = false;
            this.dataGridPopDirector.AllowUserToDeleteRows = false;
            this.dataGridPopDirector.AllowUserToResizeColumns = false;
            this.dataGridPopDirector.AllowUserToResizeRows = false;
            this.dataGridPopDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPopDirector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Directors});
            this.dataGridPopDirector.Location = new System.Drawing.Point(15, 20);
            this.dataGridPopDirector.Name = "dataGridPopDirector";
            this.dataGridPopDirector.ReadOnly = true;
            this.dataGridPopDirector.RowHeadersVisible = false;
            this.dataGridPopDirector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPopDirector.Size = new System.Drawing.Size(154, 162);
            this.dataGridPopDirector.TabIndex = 0;
            this.dataGridPopDirector.Click += new System.EventHandler(this.dataGridPopDirector_Click);
            // 
            // Directors
            // 
            this.Directors.DataPropertyName = "DIRECTOR";
            this.Directors.HeaderText = "Director";
            this.Directors.Name = "Directors";
            this.Directors.ReadOnly = true;
            this.Directors.Width = 150;
            // 
            // picBoxMoviePoster
            // 
            this.picBoxMoviePoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMoviePoster.Image = global::Hw4.Properties.Resources.Poster;
            this.picBoxMoviePoster.Location = new System.Drawing.Point(325, 376);
            this.picBoxMoviePoster.Name = "picBoxMoviePoster";
            this.picBoxMoviePoster.Size = new System.Drawing.Size(100, 144);
            this.picBoxMoviePoster.TabIndex = 18;
            this.picBoxMoviePoster.TabStop = false;
            // 
            // dataGridActor
            // 
            this.dataGridActor.AllowUserToAddRows = false;
            this.dataGridActor.AllowUserToDeleteRows = false;
            this.dataGridActor.AllowUserToResizeColumns = false;
            this.dataGridActor.AllowUserToResizeRows = false;
            this.dataGridActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActor.ColumnHeadersVisible = false;
            this.dataGridActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actors});
            this.dataGridActor.Location = new System.Drawing.Point(473, 419);
            this.dataGridActor.Name = "dataGridActor";
            this.dataGridActor.ReadOnly = true;
            this.dataGridActor.RowHeadersVisible = false;
            this.dataGridActor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridActor.Size = new System.Drawing.Size(132, 101);
            this.dataGridActor.TabIndex = 19;
            this.dataGridActor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActor_CellContentClick);
            // 
            // Actors
            // 
            this.Actors.DataPropertyName = "Actor";
            this.Actors.HeaderText = "Actors";
            this.Actors.Name = "Actors";
            this.Actors.ReadOnly = true;
            this.Actors.Width = 132;
            // 
            // dataGridMovieD
            // 
            this.dataGridMovieD.AllowUserToAddRows = false;
            this.dataGridMovieD.AllowUserToDeleteRows = false;
            this.dataGridMovieD.AllowUserToResizeColumns = false;
            this.dataGridMovieD.AllowUserToResizeRows = false;
            this.dataGridMovieD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovieD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title2,
            this.Review2,
            this.Released2,
            this.Rating2});
            this.dataGridMovieD.Location = new System.Drawing.Point(288, 233);
            this.dataGridMovieD.MultiSelect = false;
            this.dataGridMovieD.Name = "dataGridMovieD";
            this.dataGridMovieD.ReadOnly = true;
            this.dataGridMovieD.RowHeadersVisible = false;
            this.dataGridMovieD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMovieD.Size = new System.Drawing.Size(603, 106);
            this.dataGridMovieD.TabIndex = 20;
            this.dataGridMovieD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMovieD_CellContentClick);
            // 
            // Title2
            // 
            this.Title2.DataPropertyName = "Title";
            this.Title2.HeaderText = "Title";
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.Width = 250;
            // 
            // Review2
            // 
            this.Review2.DataPropertyName = "Review";
            this.Review2.HeaderText = "Review";
            this.Review2.Name = "Review2";
            this.Review2.ReadOnly = true;
            this.Review2.Width = 90;
            // 
            // Released2
            // 
            this.Released2.DataPropertyName = "Released";
            this.Released2.HeaderText = "Released";
            this.Released2.Name = "Released2";
            this.Released2.ReadOnly = true;
            this.Released2.Width = 70;
            // 
            // Rating2
            // 
            this.Rating2.DataPropertyName = "Rating";
            this.Rating2.HeaderText = "Rating";
            this.Rating2.Name = "Rating2";
            this.Rating2.ReadOnly = true;
            this.Rating2.Width = 70;
            // 
            // dataGridGenres
            // 
            this.dataGridGenres.AllowUserToAddRows = false;
            this.dataGridGenres.AllowUserToDeleteRows = false;
            this.dataGridGenres.AllowUserToResizeColumns = false;
            this.dataGridGenres.AllowUserToResizeRows = false;
            this.dataGridGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGenres.ColumnHeadersVisible = false;
            this.dataGridGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genre});
            this.dataGridGenres.Location = new System.Drawing.Point(670, 419);
            this.dataGridGenres.Name = "dataGridGenres";
            this.dataGridGenres.ReadOnly = true;
            this.dataGridGenres.RowHeadersVisible = false;
            this.dataGridGenres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridGenres.Size = new System.Drawing.Size(120, 101);
            this.dataGridGenres.TabIndex = 21;
            this.dataGridGenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGenres_CellContentClick);
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 132;
            // 
            // FormMovieSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 542);
            this.Controls.Add(this.dataGridGenres);
            this.Controls.Add(this.dataGridMovieD);
            this.Controls.Add(this.dataGridActor);
            this.Controls.Add(this.picBoxMoviePoster);
            this.Controls.Add(this.tabPopActorDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelMovieDirector);
            this.Controls.Add(this.labelMovieReview);
            this.Controls.Add(this.labelMovieRating);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelActor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSearchInput);
            this.Controls.Add(this.dataGridMovies);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.splitContainSearch);
            this.Name = "FormMovieSearch";
            this.Text = "Hollywood Movies";
            this.splitContainSearch.Panel1.ResumeLayout(false);
            this.splitContainSearch.Panel1.PerformLayout();
            this.splitContainSearch.Panel2.ResumeLayout(false);
            this.splitContainSearch.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainSearch)).EndInit();
            this.splitContainSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComedy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFantasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSciFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPG13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
            this.tabPopActorDirector.ResumeLayout(false);
            this.tabPagePopActor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopActor)).EndInit();
            this.tabPagePopDirector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridMovies;
        private System.Windows.Forms.Label labelSearchInput;
        private System.Windows.Forms.Label labelPopGenre;
        private System.Windows.Forms.Label labelSearchRating;
        private System.Windows.Forms.Label labelOtherGene;
        private System.Windows.Forms.PictureBox picBoxSciFi;
        private System.Windows.Forms.PictureBox picBoxAction;
        private System.Windows.Forms.PictureBox picBoxFantasy;
        private System.Windows.Forms.PictureBox picBoxComedy;
        private System.Windows.Forms.PictureBox picBoxR;
        private System.Windows.Forms.PictureBox picBoxNC;
        private System.Windows.Forms.PictureBox picBoxPG13;
        private System.Windows.Forms.PictureBox picBoxUR;
        private System.Windows.Forms.PictureBox picBoxNR;
        private System.Windows.Forms.PictureBox picBoxPG;
        private System.Windows.Forms.PictureBox picBoxG;
        private System.Windows.Forms.ListBox listSearchGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review;
        private System.Windows.Forms.DataGridViewTextBoxColumn Released;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelActor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Label labelMovieReview;
        private System.Windows.Forms.Label labelMovieDirector;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TabControl tabPopActorDirector;
        private System.Windows.Forms.TabPage tabPagePopActor;
        private System.Windows.Forms.TabPage tabPagePopDirector;
        private System.Windows.Forms.DataGridView dataGridPopActor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actor;
        private System.Windows.Forms.DataGridView dataGridPopDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directors;
        private System.Windows.Forms.PictureBox picBoxMoviePoster;
        private System.Windows.Forms.DataGridView dataGridActor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actors;
        private System.Windows.Forms.DataGridView dataGridMovieD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Released2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating2;
        private System.Windows.Forms.DataGridView dataGridGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}

