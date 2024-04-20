namespace SeansTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pages = new TabControl();
            moviePage = new TabPage();
            movieNameLbl = new Label();
            movieTimeOneLbl = new Label();
            movieTimeTwoLbl = new Label();
            movieTimeThreeLbl = new Label();
            movieTimeFourLbl = new Label();
            saveMovieBtn = new Button();
            movieNameTxt = new TextBox();
            movieTimeOneDt = new DateTimePicker();
            movieTimeTwoDt = new DateTimePicker();
            movieTimeThreeDt = new DateTimePicker();
            movieTimeFourDt = new DateTimePicker();
            datasMovie = new DataGridView();
            movieTheaterPage = new TabPage();
            movieTheaterNameLbl = new Label();
            movieTheaterCapacityLbl = new Label();
            saveMovieTheaterBtn = new Button();
            movieTheaterNameTxt = new TextBox();
            movieTheaterCapacityTxt = new MaskedTextBox();
            datasMovieTheater = new DataGridView();
            sessionPage = new TabPage();
            sMovieNameLbl = new Label();
            sMovieTheaterNameLbl = new Label();
            sMovieDateLbl = new Label();
            sMovieTimeLbl = new Label();
            saveSessionBtn = new Button();
            sMovieNameCombo = new ComboBox();
            sMovieTheaterNameCombo = new ComboBox();
            sMovieDateDt = new DateTimePicker();
            sMovieTimeCombo = new ComboBox();
            datasSession = new DataGridView();
            customerPage = new TabPage();
            customerNameLbl = new Label();
            customerSurnameLbl = new Label();
            customerIDNumberLbl = new Label();
            cardNumberLbl = new Label();
            validityPeriodLbl = new Label();
            securityCodeLbl = new Label();
            saveCustomerBtn = new Button();
            customerNameTxt = new TextBox();
            customerSurnameTxt = new TextBox();
            customerIDNumberTxt = new MaskedTextBox();
            cardNumberTxt = new MaskedTextBox();
            securityCodeTxt = new MaskedTextBox();
            validityMonthCombo = new ComboBox();
            validityYearCombo = new ComboBox();
            datasSessions = new DataGridView();
            Pages.SuspendLayout();
            moviePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovie).BeginInit();
            movieTheaterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovieTheater).BeginInit();
            sessionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).BeginInit();
            customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Controls.Add(moviePage);
            Pages.Controls.Add(movieTheaterPage);
            Pages.Controls.Add(sessionPage);
            Pages.Controls.Add(customerPage);
            Pages.Location = new Point(12, 12);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(553, 433);
            Pages.TabIndex = 0;
            // 
            // moviePage
            // 
            moviePage.BackColor = Color.DarkSlateGray;
            moviePage.Controls.Add(movieNameLbl);
            moviePage.Controls.Add(movieTimeOneLbl);
            moviePage.Controls.Add(movieTimeTwoLbl);
            moviePage.Controls.Add(movieTimeThreeLbl);
            moviePage.Controls.Add(movieTimeFourLbl);
            moviePage.Controls.Add(saveMovieBtn);
            moviePage.Controls.Add(movieNameTxt);
            moviePage.Controls.Add(movieTimeOneDt);
            moviePage.Controls.Add(movieTimeTwoDt);
            moviePage.Controls.Add(movieTimeThreeDt);
            moviePage.Controls.Add(movieTimeFourDt);
            moviePage.Controls.Add(datasMovie);
            moviePage.ForeColor = Color.Black;
            moviePage.Location = new Point(4, 25);
            moviePage.Name = "moviePage";
            moviePage.Padding = new Padding(3);
            moviePage.Size = new Size(545, 404);
            moviePage.TabIndex = 0;
            moviePage.Text = "Film Seçim Ekranı";
            // 
            // movieNameLbl
            // 
            movieNameLbl.AutoSize = true;
            movieNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieNameLbl.Location = new Point(21, 11);
            movieNameLbl.Name = "movieNameLbl";
            movieNameLbl.Size = new Size(65, 20);
            movieNameLbl.TabIndex = 0;
            movieNameLbl.Text = "Film Adı";
            movieNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            movieNameLbl.Click += movieNameLbl_Click;
            // 
            // movieTimeOneLbl
            // 
            movieTimeOneLbl.AutoSize = true;
            movieTimeOneLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeOneLbl.Location = new Point(16, 41);
            movieTimeOneLbl.Name = "movieTimeOneLbl";
            movieTimeOneLbl.Size = new Size(68, 20);
            movieTimeOneLbl.TabIndex = 2;
            movieTimeOneLbl.Text = "Seans 1";
            movieTimeOneLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeTwoLbl
            // 
            movieTimeTwoLbl.AutoSize = true;
            movieTimeTwoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeTwoLbl.Location = new Point(16, 69);
            movieTimeTwoLbl.Name = "movieTimeTwoLbl";
            movieTimeTwoLbl.Size = new Size(68, 20);
            movieTimeTwoLbl.TabIndex = 4;
            movieTimeTwoLbl.Text = "Seans 2";
            movieTimeTwoLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeThreeLbl
            // 
            movieTimeThreeLbl.AutoSize = true;
            movieTimeThreeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeThreeLbl.Location = new Point(309, 15);
            movieTimeThreeLbl.Name = "movieTimeThreeLbl";
            movieTimeThreeLbl.Size = new Size(68, 20);
            movieTimeThreeLbl.TabIndex = 6;
            movieTimeThreeLbl.Text = "Seans 3";
            movieTimeThreeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeFourLbl
            // 
            movieTimeFourLbl.AutoSize = true;
            movieTimeFourLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeFourLbl.Location = new Point(309, 39);
            movieTimeFourLbl.Name = "movieTimeFourLbl";
            movieTimeFourLbl.Size = new Size(68, 20);
            movieTimeFourLbl.TabIndex = 8;
            movieTimeFourLbl.Text = "Seans 4";
            movieTimeFourLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveMovieBtn
            // 
            saveMovieBtn.BackColor = SystemColors.ActiveCaption;
            saveMovieBtn.FlatStyle = FlatStyle.Popup;
            saveMovieBtn.ForeColor = Color.Black;
            saveMovieBtn.Location = new Point(383, 72);
            saveMovieBtn.Name = "saveMovieBtn";
            saveMovieBtn.Size = new Size(149, 30);
            saveMovieBtn.TabIndex = 10;
            saveMovieBtn.Text = "Kaydet";
            saveMovieBtn.UseVisualStyleBackColor = false;
            saveMovieBtn.Click += saveMovieBtn_Click;
            // 
            // movieNameTxt
            // 
            movieNameTxt.Location = new Point(92, 11);
            movieNameTxt.Name = "movieNameTxt";
            movieNameTxt.Size = new Size(154, 22);
            movieNameTxt.TabIndex = 1;
            movieNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // movieTimeOneDt
            // 
            movieTimeOneDt.Format = DateTimePickerFormat.Time;
            movieTimeOneDt.Location = new Point(90, 41);
            movieTimeOneDt.Name = "movieTimeOneDt";
            movieTimeOneDt.Size = new Size(156, 22);
            movieTimeOneDt.TabIndex = 3;
            movieTimeOneDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeTwoDt
            // 
            movieTimeTwoDt.Format = DateTimePickerFormat.Time;
            movieTimeTwoDt.Location = new Point(90, 72);
            movieTimeTwoDt.Name = "movieTimeTwoDt";
            movieTimeTwoDt.Size = new Size(156, 22);
            movieTimeTwoDt.TabIndex = 5;
            movieTimeTwoDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeThreeDt
            // 
            movieTimeThreeDt.Format = DateTimePickerFormat.Time;
            movieTimeThreeDt.Location = new Point(383, 15);
            movieTimeThreeDt.Name = "movieTimeThreeDt";
            movieTimeThreeDt.Size = new Size(149, 22);
            movieTimeThreeDt.TabIndex = 7;
            movieTimeThreeDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeFourDt
            // 
            movieTimeFourDt.Format = DateTimePickerFormat.Time;
            movieTimeFourDt.Location = new Point(383, 39);
            movieTimeFourDt.Name = "movieTimeFourDt";
            movieTimeFourDt.Size = new Size(149, 22);
            movieTimeFourDt.TabIndex = 9;
            movieTimeFourDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // datasMovie
            // 
            datasMovie.AllowUserToAddRows = false;
            datasMovie.AllowUserToDeleteRows = false;
            datasMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasMovie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasMovie.Location = new Point(6, 131);
            datasMovie.Name = "datasMovie";
            datasMovie.ReadOnly = true;
            datasMovie.Size = new Size(526, 268);
            datasMovie.TabIndex = 11;
            datasMovie.DataBindingComplete += datasMovie_DataBindingComplete;
            // 
            // movieTheaterPage
            // 
            movieTheaterPage.BackColor = Color.DarkSlateGray;
            movieTheaterPage.Controls.Add(movieTheaterNameLbl);
            movieTheaterPage.Controls.Add(movieTheaterCapacityLbl);
            movieTheaterPage.Controls.Add(saveMovieTheaterBtn);
            movieTheaterPage.Controls.Add(movieTheaterNameTxt);
            movieTheaterPage.Controls.Add(movieTheaterCapacityTxt);
            movieTheaterPage.Controls.Add(datasMovieTheater);
            movieTheaterPage.ForeColor = Color.Black;
            movieTheaterPage.Location = new Point(4, 25);
            movieTheaterPage.Name = "movieTheaterPage";
            movieTheaterPage.Padding = new Padding(3);
            movieTheaterPage.Size = new Size(545, 404);
            movieTheaterPage.TabIndex = 1;
            movieTheaterPage.Text = "Salon Seçim Ekranı";
            // 
            // movieTheaterNameLbl
            // 
            movieTheaterNameLbl.AutoSize = true;
            movieTheaterNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTheaterNameLbl.ForeColor = SystemColors.ActiveCaptionText;
            movieTheaterNameLbl.Location = new Point(29, 9);
            movieTheaterNameLbl.Name = "movieTheaterNameLbl";
            movieTheaterNameLbl.Size = new Size(83, 20);
            movieTheaterNameLbl.TabIndex = 0;
            movieTheaterNameLbl.Text = "Salon İsmi";
            movieTheaterNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTheaterCapacityLbl
            // 
            movieTheaterCapacityLbl.AutoSize = true;
            movieTheaterCapacityLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTheaterCapacityLbl.ForeColor = SystemColors.ActiveCaptionText;
            movieTheaterCapacityLbl.Location = new Point(29, 41);
            movieTheaterCapacityLbl.Name = "movieTheaterCapacityLbl";
            movieTheaterCapacityLbl.Size = new Size(127, 20);
            movieTheaterCapacityLbl.TabIndex = 2;
            movieTheaterCapacityLbl.Text = "Salon Kapasitesi";
            movieTheaterCapacityLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveMovieTheaterBtn
            // 
            saveMovieTheaterBtn.BackColor = SystemColors.ActiveCaption;
            saveMovieTheaterBtn.FlatStyle = FlatStyle.Popup;
            saveMovieTheaterBtn.ForeColor = Color.Black;
            saveMovieTheaterBtn.Location = new Point(370, 31);
            saveMovieTheaterBtn.Name = "saveMovieTheaterBtn";
            saveMovieTheaterBtn.Size = new Size(105, 30);
            saveMovieTheaterBtn.TabIndex = 4;
            saveMovieTheaterBtn.Text = "Kaydet";
            saveMovieTheaterBtn.UseVisualStyleBackColor = false;
            saveMovieTheaterBtn.Click += saveMovieTheaterBtn_Click;
            // 
            // movieTheaterNameTxt
            // 
            movieTheaterNameTxt.Location = new Point(152, 9);
            movieTheaterNameTxt.Name = "movieTheaterNameTxt";
            movieTheaterNameTxt.Size = new Size(133, 22);
            movieTheaterNameTxt.TabIndex = 1;
            movieTheaterNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // movieTheaterCapacityTxt
            // 
            movieTheaterCapacityTxt.Location = new Point(152, 39);
            movieTheaterCapacityTxt.Mask = "0000";
            movieTheaterCapacityTxt.Name = "movieTheaterCapacityTxt";
            movieTheaterCapacityTxt.Size = new Size(133, 22);
            movieTheaterCapacityTxt.TabIndex = 3;
            movieTheaterCapacityTxt.TextAlign = HorizontalAlignment.Center;
            movieTheaterCapacityTxt.ValidatingType = typeof(int);
            // 
            // datasMovieTheater
            // 
            datasMovieTheater.AllowUserToAddRows = false;
            datasMovieTheater.AllowUserToDeleteRows = false;
            datasMovieTheater.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasMovieTheater.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasMovieTheater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasMovieTheater.Location = new Point(6, 73);
            datasMovieTheater.Name = "datasMovieTheater";
            datasMovieTheater.ReadOnly = true;
            datasMovieTheater.Size = new Size(533, 326);
            datasMovieTheater.TabIndex = 5;
            datasMovieTheater.DataBindingComplete += datasMovieTheater_DataBindingComplete;
            // 
            // sessionPage
            // 
            sessionPage.BackColor = Color.DarkSlateGray;
            sessionPage.Controls.Add(sMovieNameLbl);
            sessionPage.Controls.Add(sMovieTheaterNameLbl);
            sessionPage.Controls.Add(sMovieDateLbl);
            sessionPage.Controls.Add(sMovieTimeLbl);
            sessionPage.Controls.Add(saveSessionBtn);
            sessionPage.Controls.Add(sMovieNameCombo);
            sessionPage.Controls.Add(sMovieTheaterNameCombo);
            sessionPage.Controls.Add(sMovieDateDt);
            sessionPage.Controls.Add(sMovieTimeCombo);
            sessionPage.Controls.Add(datasSession);
            sessionPage.ForeColor = Color.Black;
            sessionPage.Location = new Point(4, 25);
            sessionPage.Name = "sessionPage";
            sessionPage.Size = new Size(545, 404);
            sessionPage.TabIndex = 2;
            sessionPage.Text = "Seans Seçim Ekranı";
            // 
            // sMovieNameLbl
            // 
            sMovieNameLbl.AutoSize = true;
            sMovieNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieNameLbl.Location = new Point(21, 11);
            sMovieNameLbl.Name = "sMovieNameLbl";
            sMovieNameLbl.Size = new Size(65, 20);
            sMovieNameLbl.TabIndex = 0;
            sMovieNameLbl.Text = "Film Adı";
            sMovieNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieTheaterNameLbl
            // 
            sMovieTheaterNameLbl.AutoSize = true;
            sMovieTheaterNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieTheaterNameLbl.Location = new Point(289, 11);
            sMovieTheaterNameLbl.Name = "sMovieTheaterNameLbl";
            sMovieTheaterNameLbl.Size = new Size(77, 20);
            sMovieTheaterNameLbl.TabIndex = 2;
            sMovieTheaterNameLbl.Text = "Salon Adı";
            sMovieTheaterNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieDateLbl
            // 
            sMovieDateLbl.AutoSize = true;
            sMovieDateLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieDateLbl.Location = new Point(21, 40);
            sMovieDateLbl.Name = "sMovieDateLbl";
            sMovieDateLbl.Size = new Size(77, 20);
            sMovieDateLbl.TabIndex = 4;
            sMovieDateLbl.Text = "Film Tarih";
            sMovieDateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieTimeLbl
            // 
            sMovieTimeLbl.AutoSize = true;
            sMovieTimeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieTimeLbl.Location = new Point(289, 42);
            sMovieTimeLbl.Name = "sMovieTimeLbl";
            sMovieTimeLbl.Size = new Size(44, 20);
            sMovieTimeLbl.TabIndex = 6;
            sMovieTimeLbl.Text = "Tarih";
            sMovieTimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveSessionBtn
            // 
            saveSessionBtn.BackColor = SystemColors.ActiveCaption;
            saveSessionBtn.FlatStyle = FlatStyle.Popup;
            saveSessionBtn.ForeColor = Color.Black;
            saveSessionBtn.Location = new Point(387, 70);
            saveSessionBtn.Name = "saveSessionBtn";
            saveSessionBtn.Size = new Size(140, 30);
            saveSessionBtn.TabIndex = 8;
            saveSessionBtn.Text = "Kaydet";
            saveSessionBtn.UseVisualStyleBackColor = false;
            saveSessionBtn.Click += saveSessionBtn_Click;
            // 
            // sMovieNameCombo
            // 
            sMovieNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieNameCombo.FormattingEnabled = true;
            sMovieNameCombo.IntegralHeight = false;
            sMovieNameCombo.Location = new Point(111, 11);
            sMovieNameCombo.MaxDropDownItems = 3;
            sMovieNameCombo.Name = "sMovieNameCombo";
            sMovieNameCombo.Size = new Size(140, 24);
            sMovieNameCombo.Sorted = true;
            sMovieNameCombo.TabIndex = 1;
            sMovieNameCombo.SelectedIndexChanged += sMovieNameCombo_SelectedIndexChanged;
            // 
            // sMovieTheaterNameCombo
            // 
            sMovieTheaterNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieTheaterNameCombo.FormattingEnabled = true;
            sMovieTheaterNameCombo.IntegralHeight = false;
            sMovieTheaterNameCombo.Location = new Point(387, 7);
            sMovieTheaterNameCombo.MaxDropDownItems = 3;
            sMovieTheaterNameCombo.Name = "sMovieTheaterNameCombo";
            sMovieTheaterNameCombo.Size = new Size(140, 24);
            sMovieTheaterNameCombo.Sorted = true;
            sMovieTheaterNameCombo.TabIndex = 3;
            // 
            // sMovieDateDt
            // 
            sMovieDateDt.Format = DateTimePickerFormat.Short;
            sMovieDateDt.Location = new Point(111, 41);
            sMovieDateDt.Name = "sMovieDateDt";
            sMovieDateDt.Size = new Size(140, 22);
            sMovieDateDt.TabIndex = 5;
            sMovieDateDt.Value = new DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // sMovieTimeCombo
            // 
            sMovieTimeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieTimeCombo.FormattingEnabled = true;
            sMovieTimeCombo.IntegralHeight = false;
            sMovieTimeCombo.Location = new Point(387, 40);
            sMovieTimeCombo.MaxDropDownItems = 3;
            sMovieTimeCombo.Name = "sMovieTimeCombo";
            sMovieTimeCombo.Size = new Size(140, 24);
            sMovieTimeCombo.Sorted = true;
            sMovieTimeCombo.TabIndex = 7;
            // 
            // datasSession
            // 
            datasSession.AllowUserToAddRows = false;
            datasSession.AllowUserToDeleteRows = false;
            datasSession.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSession.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSession.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSession.Location = new Point(6, 106);
            datasSession.Name = "datasSession";
            datasSession.ReadOnly = true;
            datasSession.Size = new Size(521, 293);
            datasSession.TabIndex = 9;
            datasSession.DataBindingComplete += datasSession_DataBindingComplete;
            // 
            // customerPage
            // 
            customerPage.BackColor = Color.DarkSlateGray;
            customerPage.Controls.Add(customerNameLbl);
            customerPage.Controls.Add(customerSurnameLbl);
            customerPage.Controls.Add(customerIDNumberLbl);
            customerPage.Controls.Add(cardNumberLbl);
            customerPage.Controls.Add(validityPeriodLbl);
            customerPage.Controls.Add(securityCodeLbl);
            customerPage.Controls.Add(saveCustomerBtn);
            customerPage.Controls.Add(customerNameTxt);
            customerPage.Controls.Add(customerSurnameTxt);
            customerPage.Controls.Add(customerIDNumberTxt);
            customerPage.Controls.Add(cardNumberTxt);
            customerPage.Controls.Add(securityCodeTxt);
            customerPage.Controls.Add(validityMonthCombo);
            customerPage.Controls.Add(validityYearCombo);
            customerPage.Controls.Add(datasSessions);
            customerPage.ForeColor = Color.Black;
            customerPage.Location = new Point(4, 25);
            customerPage.Name = "customerPage";
            customerPage.Size = new Size(545, 404);
            customerPage.TabIndex = 3;
            customerPage.Text = "Ödeme Ekranı";
            // 
            // customerNameLbl
            // 
            customerNameLbl.AutoSize = true;
            customerNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNameLbl.Location = new Point(22, 21);
            customerNameLbl.Name = "customerNameLbl";
            customerNameLbl.Size = new Size(32, 20);
            customerNameLbl.TabIndex = 1;
            customerNameLbl.Text = "AD";
            customerNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerSurnameLbl
            // 
            customerSurnameLbl.AutoSize = true;
            customerSurnameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerSurnameLbl.Location = new Point(22, 46);
            customerSurnameLbl.Name = "customerSurnameLbl";
            customerSurnameLbl.Size = new Size(66, 20);
            customerSurnameLbl.TabIndex = 3;
            customerSurnameLbl.Text = "SOYAD";
            customerSurnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerIDNumberLbl
            // 
            customerIDNumberLbl.AutoSize = true;
            customerIDNumberLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDNumberLbl.Location = new Point(0, 74);
            customerIDNumberLbl.Name = "customerIDNumberLbl";
            customerIDNumberLbl.Size = new Size(88, 20);
            customerIDNumberLbl.TabIndex = 5;
            customerIDNumberLbl.Text = "KİMLİK NO";
            customerIDNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardNumberLbl
            // 
            cardNumberLbl.AutoSize = true;
            cardNumberLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardNumberLbl.Location = new Point(245, 49);
            cardNumberLbl.Name = "cardNumberLbl";
            cardNumberLbl.Size = new Size(78, 20);
            cardNumberLbl.TabIndex = 7;
            cardNumberLbl.Text = "KART NO";
            cardNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validityPeriodLbl
            // 
            validityPeriodLbl.AutoSize = true;
            validityPeriodLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validityPeriodLbl.Location = new Point(276, 21);
            validityPeriodLbl.Name = "validityPeriodLbl";
            validityPeriodLbl.Size = new Size(47, 20);
            validityPeriodLbl.TabIndex = 9;
            validityPeriodLbl.Text = "S.K.T";
            validityPeriodLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // securityCodeLbl
            // 
            securityCodeLbl.AutoSize = true;
            securityCodeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            securityCodeLbl.Location = new Point(276, 76);
            securityCodeLbl.Name = "securityCodeLbl";
            securityCodeLbl.Size = new Size(42, 20);
            securityCodeLbl.TabIndex = 12;
            securityCodeLbl.Text = "CVC";
            securityCodeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.BackColor = SystemColors.ActiveCaption;
            saveCustomerBtn.FlatStyle = FlatStyle.Popup;
            saveCustomerBtn.ForeColor = Color.Black;
            saveCustomerBtn.Location = new Point(412, 107);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new Size(118, 24);
            saveCustomerBtn.TabIndex = 14;
            saveCustomerBtn.Text = "KAYDET";
            saveCustomerBtn.UseVisualStyleBackColor = false;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // customerNameTxt
            // 
            customerNameTxt.Location = new Point(94, 21);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(110, 22);
            customerNameTxt.TabIndex = 2;
            customerNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // customerSurnameTxt
            // 
            customerSurnameTxt.CharacterCasing = CharacterCasing.Upper;
            customerSurnameTxt.Location = new Point(94, 49);
            customerSurnameTxt.Name = "customerSurnameTxt";
            customerSurnameTxt.Size = new Size(110, 22);
            customerSurnameTxt.TabIndex = 4;
            customerSurnameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // customerIDNumberTxt
            // 
            customerIDNumberTxt.Location = new Point(94, 74);
            customerIDNumberTxt.Mask = "00000000000";
            customerIDNumberTxt.Name = "customerIDNumberTxt";
            customerIDNumberTxt.Size = new Size(110, 22);
            customerIDNumberTxt.TabIndex = 6;
            customerIDNumberTxt.TextAlign = HorizontalAlignment.Center;
            customerIDNumberTxt.ValidatingType = typeof(int);
            // 
            // cardNumberTxt
            // 
            cardNumberTxt.Location = new Point(334, 51);
            cardNumberTxt.Mask = "0000 0000 0000 0000";
            cardNumberTxt.Name = "cardNumberTxt";
            cardNumberTxt.Size = new Size(144, 22);
            cardNumberTxt.TabIndex = 8;
            cardNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // securityCodeTxt
            // 
            securityCodeTxt.Location = new Point(334, 79);
            securityCodeTxt.Mask = "000";
            securityCodeTxt.Name = "securityCodeTxt";
            securityCodeTxt.Size = new Size(144, 22);
            securityCodeTxt.TabIndex = 13;
            securityCodeTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // validityMonthCombo
            // 
            validityMonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityMonthCombo.FormattingEnabled = true;
            validityMonthCombo.IntegralHeight = false;
            validityMonthCombo.Location = new Point(334, 21);
            validityMonthCombo.MaxDropDownItems = 3;
            validityMonthCombo.Name = "validityMonthCombo";
            validityMonthCombo.Size = new Size(72, 24);
            validityMonthCombo.TabIndex = 10;
            // 
            // validityYearCombo
            // 
            validityYearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityYearCombo.FormattingEnabled = true;
            validityYearCombo.IntegralHeight = false;
            validityYearCombo.Location = new Point(412, 21);
            validityYearCombo.MaxDropDownItems = 3;
            validityYearCombo.Name = "validityYearCombo";
            validityYearCombo.Size = new Size(66, 24);
            validityYearCombo.TabIndex = 11;
            // 
            // datasSessions
            // 
            datasSessions.AllowUserToAddRows = false;
            datasSessions.AllowUserToDeleteRows = false;
            datasSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSessions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSessions.Location = new Point(3, 137);
            datasSessions.Name = "datasSessions";
            datasSessions.ReadOnly = true;
            datasSessions.Size = new Size(527, 264);
            datasSessions.TabIndex = 0;
            datasSessions.DataBindingComplete += datasSessions_DataBindingComplete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(589, 457);
            Controls.Add(Pages);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilet Oluşturma Bölümü";
            Load += HomePage_Load;
            KeyDown += HomePage_KeyDown;
            Pages.ResumeLayout(false);
            moviePage.ResumeLayout(false);
            moviePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovie).EndInit();
            movieTheaterPage.ResumeLayout(false);
            movieTheaterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovieTheater).EndInit();
            sessionPage.ResumeLayout(false);
            sessionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).EndInit();
            customerPage.ResumeLayout(false);
            customerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Pages;
        private TabPage moviePage;
        private TabPage movieTheaterPage;
        private TabPage sessionPage;
        private TabPage customerPage;
        private Label movieNameLbl;
        private Label movieTimeOneLbl;
        private Label movieTimeTwoLbl;
        private Label movieTimeThreeLbl;
        private Label movieTimeFourLbl;
        private Label movieTheaterNameLbl;
        private Label movieTheaterCapacityLbl;
        private Label sMovieNameLbl;
        private Label sMovieTheaterNameLbl;
        private Label sMovieDateLbl;
        private Label sMovieTimeLbl;
        private Label customerNameLbl;
        private Label customerSurnameLbl;
        private Label customerIDNumberLbl;
        private Label cardNumberLbl;
        private Label validityPeriodLbl;
        private Label securityCodeLbl;
        private Button saveMovieBtn;
        private Button saveMovieTheaterBtn;
        private Button saveSessionBtn;
        private Button saveCustomerBtn;
        public TextBox movieNameTxt;
        public TextBox movieTheaterNameTxt;
        public TextBox customerNameTxt;
        public TextBox customerSurnameTxt;
        public MaskedTextBox movieTheaterCapacityTxt;
        public MaskedTextBox customerIDNumberTxt;
        public MaskedTextBox cardNumberTxt;
        public MaskedTextBox securityCodeTxt;
        public DateTimePicker movieTimeOneDt;
        public DateTimePicker movieTimeTwoDt;
        public DateTimePicker movieTimeThreeDt;
        public DateTimePicker movieTimeFourDt;
        public DateTimePicker sMovieDateDt;
        public ComboBox sMovieNameCombo;
        public ComboBox sMovieTheaterNameCombo;
        public ComboBox sMovieTimeCombo;
        public ComboBox validityMonthCombo;
        public ComboBox validityYearCombo;
        public DataGridView datasMovie;
        public DataGridView datasMovieTheater;
        public DataGridView datasSession;
        public DataGridView datasSessions;
    }
}
