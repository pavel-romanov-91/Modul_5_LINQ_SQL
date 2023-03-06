namespace CountiesDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.getApiPage = new System.Windows.Forms.TabPage();
            this.btApi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbApi = new System.Windows.Forms.TextBox();
            this.rbGetOneApi = new System.Windows.Forms.RadioButton();
            this.rbGetAllApi = new System.Windows.Forms.RadioButton();
            this.tableGetApi = new System.Windows.Forms.DataGridView();
            this.getDbPage = new System.Windows.Forms.TabPage();
            this.btDb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDb = new System.Windows.Forms.TextBox();
            this.rbGetOneDb = new System.Windows.Forms.RadioButton();
            this.rbGetAllDb = new System.Windows.Forms.RadioButton();
            this.tableGetDb = new System.Windows.Forms.DataGridView();
            this.addDbPage = new System.Windows.Forms.TabPage();
            this.btAddDb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAddDb = new System.Windows.Forms.DataGridView();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.gbTypeSec = new System.Windows.Forms.GroupBox();
            this.tbConfigPassword = new System.Windows.Forms.TextBox();
            this.tbConfigUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSecServer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSecWin = new System.Windows.Forms.RadioButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btConfig = new System.Windows.Forms.Button();
            this.tbConfigServ = new System.Windows.Forms.TextBox();
            this.tbConfigBd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.getApiPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGetApi)).BeginInit();
            this.getDbPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGetDb)).BeginInit();
            this.addDbPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddDb)).BeginInit();
            this.settingsPage.SuspendLayout();
            this.gbTypeSec.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.getApiPage);
            this.tabControl1.Controls.Add(this.getDbPage);
            this.tabControl1.Controls.Add(this.addDbPage);
            this.tabControl1.Controls.Add(this.settingsPage);
            this.tabControl1.Controls.Add(this.helpPage);
            this.tabControl1.Location = new System.Drawing.Point(20, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // getApiPage
            // 
            this.getApiPage.Controls.Add(this.btApi);
            this.getApiPage.Controls.Add(this.groupBox2);
            this.getApiPage.Controls.Add(this.tableGetApi);
            this.getApiPage.Location = new System.Drawing.Point(4, 25);
            this.getApiPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getApiPage.Name = "getApiPage";
            this.getApiPage.Size = new System.Drawing.Size(1004, 460);
            this.getApiPage.TabIndex = 4;
            this.getApiPage.Text = "Получение данных с Api";
            this.getApiPage.UseVisualStyleBackColor = true;
            // 
            // btApi
            // 
            this.btApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btApi.Location = new System.Drawing.Point(488, 399);
            this.btApi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btApi.Name = "btApi";
            this.btApi.Size = new System.Drawing.Size(117, 44);
            this.btApi.TabIndex = 5;
            this.btApi.Text = "Выполнить";
            this.btApi.UseVisualStyleBackColor = true;
            this.btApi.Click += new System.EventHandler(this.btApi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tbApi);
            this.groupBox2.Controls.Add(this.rbGetOneApi);
            this.groupBox2.Controls.Add(this.rbGetAllApi);
            this.groupBox2.Location = new System.Drawing.Point(7, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(472, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите тип вывода:";
            // 
            // tbApi
            // 
            this.tbApi.Location = new System.Drawing.Point(255, 53);
            this.tbApi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApi.Name = "tbApi";
            this.tbApi.Size = new System.Drawing.Size(208, 22);
            this.tbApi.TabIndex = 2;
            // 
            // rbGetOneApi
            // 
            this.rbGetOneApi.AutoSize = true;
            this.rbGetOneApi.Location = new System.Drawing.Point(9, 53);
            this.rbGetOneApi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGetOneApi.Name = "rbGetOneApi";
            this.rbGetOneApi.Size = new System.Drawing.Size(222, 20);
            this.rbGetOneApi.TabIndex = 1;
            this.rbGetOneApi.TabStop = true;
            this.rbGetOneApi.Text = "Вывести страну с названием:";
            this.rbGetOneApi.UseVisualStyleBackColor = true;
            // 
            // rbGetAllApi
            // 
            this.rbGetAllApi.AutoSize = true;
            this.rbGetAllApi.Location = new System.Drawing.Point(9, 25);
            this.rbGetAllApi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGetAllApi.Name = "rbGetAllApi";
            this.rbGetAllApi.Size = new System.Drawing.Size(160, 20);
            this.rbGetAllApi.TabIndex = 0;
            this.rbGetAllApi.TabStop = true;
            this.rbGetAllApi.Text = "Вывести все страны";
            this.rbGetAllApi.UseVisualStyleBackColor = true;
            // 
            // tableGetApi
            // 
            this.tableGetApi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGetApi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGetApi.Location = new System.Drawing.Point(4, 4);
            this.tableGetApi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableGetApi.Name = "tableGetApi";
            this.tableGetApi.RowHeadersWidth = 51;
            this.tableGetApi.Size = new System.Drawing.Size(988, 335);
            this.tableGetApi.TabIndex = 3;
            // 
            // getDbPage
            // 
            this.getDbPage.Controls.Add(this.btDb);
            this.getDbPage.Controls.Add(this.groupBox1);
            this.getDbPage.Controls.Add(this.tableGetDb);
            this.getDbPage.Location = new System.Drawing.Point(4, 25);
            this.getDbPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDbPage.Name = "getDbPage";
            this.getDbPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDbPage.Size = new System.Drawing.Size(1004, 460);
            this.getDbPage.TabIndex = 0;
            this.getDbPage.Text = "Просмотр БД";
            this.getDbPage.UseVisualStyleBackColor = true;
            // 
            // btDb
            // 
            this.btDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDb.Location = new System.Drawing.Point(488, 399);
            this.btDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDb.Name = "btDb";
            this.btDb.Size = new System.Drawing.Size(117, 44);
            this.btDb.TabIndex = 2;
            this.btDb.Text = "Выполнить";
            this.btDb.UseVisualStyleBackColor = true;
            this.btDb.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbDb);
            this.groupBox1.Controls.Add(this.rbGetOneDb);
            this.groupBox1.Controls.Add(this.rbGetAllDb);
            this.groupBox1.Location = new System.Drawing.Point(7, 346);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(472, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тип вывода:";
            // 
            // tbDb
            // 
            this.tbDb.Location = new System.Drawing.Point(255, 53);
            this.tbDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDb.Name = "tbDb";
            this.tbDb.Size = new System.Drawing.Size(208, 22);
            this.tbDb.TabIndex = 2;
            // 
            // rbGetOneDb
            // 
            this.rbGetOneDb.AutoSize = true;
            this.rbGetOneDb.Location = new System.Drawing.Point(9, 53);
            this.rbGetOneDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGetOneDb.Name = "rbGetOneDb";
            this.rbGetOneDb.Size = new System.Drawing.Size(222, 20);
            this.rbGetOneDb.TabIndex = 1;
            this.rbGetOneDb.TabStop = true;
            this.rbGetOneDb.Text = "Вывести страну с названием:";
            this.rbGetOneDb.UseVisualStyleBackColor = true;
            // 
            // rbGetAllDb
            // 
            this.rbGetAllDb.AutoSize = true;
            this.rbGetAllDb.Location = new System.Drawing.Point(9, 25);
            this.rbGetAllDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGetAllDb.Name = "rbGetAllDb";
            this.rbGetAllDb.Size = new System.Drawing.Size(160, 20);
            this.rbGetAllDb.TabIndex = 0;
            this.rbGetAllDb.TabStop = true;
            this.rbGetAllDb.Text = "Вывести все страны";
            this.rbGetAllDb.UseVisualStyleBackColor = true;
            // 
            // tableGetDb
            // 
            this.tableGetDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGetDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGetDb.Location = new System.Drawing.Point(4, 4);
            this.tableGetDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableGetDb.Name = "tableGetDb";
            this.tableGetDb.RowHeadersWidth = 51;
            this.tableGetDb.Size = new System.Drawing.Size(988, 335);
            this.tableGetDb.TabIndex = 0;
            // 
            // addDbPage
            // 
            this.addDbPage.Controls.Add(this.btAddDb);
            this.addDbPage.Controls.Add(this.label7);
            this.addDbPage.Controls.Add(this.tableAddDb);
            this.addDbPage.Location = new System.Drawing.Point(4, 25);
            this.addDbPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDbPage.Name = "addDbPage";
            this.addDbPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDbPage.Size = new System.Drawing.Size(1004, 460);
            this.addDbPage.TabIndex = 1;
            this.addDbPage.Text = "Добавить запись";
            this.addDbPage.UseVisualStyleBackColor = true;
            // 
            // btAddDb
            // 
            this.btAddDb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddDb.Location = new System.Drawing.Point(432, 137);
            this.btAddDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddDb.Name = "btAddDb";
            this.btAddDb.Size = new System.Drawing.Size(123, 46);
            this.btAddDb.TabIndex = 3;
            this.btAddDb.Text = "Добавить";
            this.btAddDb.UseVisualStyleBackColor = true;
            this.btAddDb.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Заполните все поля таблицы и нажмите клавишу \'Добавить\'";
            // 
            // tableAddDb
            // 
            this.tableAddDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableAddDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAddDb.Location = new System.Drawing.Point(4, 4);
            this.tableAddDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableAddDb.Name = "tableAddDb";
            this.tableAddDb.RowHeadersWidth = 51;
            this.tableAddDb.Size = new System.Drawing.Size(988, 126);
            this.tableAddDb.TabIndex = 1;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.gbTypeSec);
            this.settingsPage.Controls.Add(this.lbStatus);
            this.settingsPage.Controls.Add(this.btConfig);
            this.settingsPage.Controls.Add(this.tbConfigServ);
            this.settingsPage.Controls.Add(this.tbConfigBd);
            this.settingsPage.Controls.Add(this.label1);
            this.settingsPage.Controls.Add(this.label2);
            this.settingsPage.Location = new System.Drawing.Point(4, 25);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1004, 460);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "Подключение к БД";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // gbTypeSec
            // 
            this.gbTypeSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTypeSec.Controls.Add(this.tbConfigPassword);
            this.gbTypeSec.Controls.Add(this.tbConfigUserId);
            this.gbTypeSec.Controls.Add(this.label4);
            this.gbTypeSec.Controls.Add(this.rbSecServer);
            this.gbTypeSec.Controls.Add(this.label3);
            this.gbTypeSec.Controls.Add(this.rbSecWin);
            this.gbTypeSec.Location = new System.Drawing.Point(248, 68);
            this.gbTypeSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypeSec.Name = "gbTypeSec";
            this.gbTypeSec.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypeSec.Size = new System.Drawing.Size(387, 144);
            this.gbTypeSec.TabIndex = 12;
            this.gbTypeSec.TabStop = false;
            this.gbTypeSec.Text = "Выберите тип аутентификации";
            // 
            // tbConfigPassword
            // 
            this.tbConfigPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfigPassword.Location = new System.Drawing.Point(160, 108);
            this.tbConfigPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfigPassword.Name = "tbConfigPassword";
            this.tbConfigPassword.Size = new System.Drawing.Size(225, 22);
            this.tbConfigPassword.TabIndex = 15;
            // 
            // tbConfigUserId
            // 
            this.tbConfigUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfigUserId.Location = new System.Drawing.Point(160, 76);
            this.tbConfigUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfigUserId.Name = "tbConfigUserId";
            this.tbConfigUserId.Size = new System.Drawing.Size(225, 22);
            this.tbConfigUserId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Пароль: ";
            // 
            // rbSecServer
            // 
            this.rbSecServer.AutoSize = true;
            this.rbSecServer.Location = new System.Drawing.Point(8, 48);
            this.rbSecServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSecServer.Name = "rbSecServer";
            this.rbSecServer.Size = new System.Drawing.Size(206, 20);
            this.rbSecServer.TabIndex = 14;
            this.rbSecServer.TabStop = true;
            this.rbSecServer.Text = "Аутентификация Sql Server";
            this.rbSecServer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя пользвателя: ";
            // 
            // rbSecWin
            // 
            this.rbSecWin.AutoSize = true;
            this.rbSecWin.Location = new System.Drawing.Point(8, 23);
            this.rbSecWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSecWin.Name = "rbSecWin";
            this.rbSecWin.Size = new System.Drawing.Size(198, 20);
            this.rbSecWin.TabIndex = 13;
            this.rbSecWin.TabStop = true;
            this.rbSecWin.Text = "Аутентификация Windows";
            this.rbSecWin.UseVisualStyleBackColor = true;
            this.rbSecWin.CheckedChanged += new System.EventHandler(this.rbSecWin_CheckedChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(244, 292);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(137, 16);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Статус соединения:";
            // 
            // btConfig
            // 
            this.btConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btConfig.Location = new System.Drawing.Point(408, 219);
            this.btConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(129, 41);
            this.btConfig.TabIndex = 10;
            this.btConfig.Text = "Применить";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbConfigServ
            // 
            this.tbConfigServ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfigServ.Location = new System.Drawing.Point(408, 4);
            this.tbConfigServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfigServ.Name = "tbConfigServ";
            this.tbConfigServ.Size = new System.Drawing.Size(225, 22);
            this.tbConfigServ.TabIndex = 1;
            // 
            // tbConfigBd
            // 
            this.tbConfigBd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfigBd.Location = new System.Drawing.Point(408, 36);
            this.tbConfigBd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfigBd.Name = "tbConfigBd";
            this.tbConfigBd.Size = new System.Drawing.Size(225, 22);
            this.tbConfigBd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название БД:";
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.rtbHelp);
            this.helpPage.Location = new System.Drawing.Point(4, 25);
            this.helpPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(1004, 460);
            this.helpPage.TabIndex = 3;
            this.helpPage.Text = "Справка";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.Location = new System.Drawing.Point(5, 5);
            this.rtbHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(991, 447);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 519);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 555);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с БД информации по странам";
            this.tabControl1.ResumeLayout(false);
            this.getApiPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGetApi)).EndInit();
            this.getDbPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGetDb)).EndInit();
            this.addDbPage.ResumeLayout(false);
            this.addDbPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddDb)).EndInit();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.gbTypeSec.ResumeLayout(false);
            this.gbTypeSec.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage getDbPage;
        private System.Windows.Forms.TabPage addDbPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.TextBox tbConfigServ;
        private System.Windows.Forms.TextBox tbConfigBd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDb;
        private System.Windows.Forms.RadioButton rbGetOneDb;
        private System.Windows.Forms.RadioButton rbGetAllDb;
        private System.Windows.Forms.DataGridView tableGetDb;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataGridView tableAddDb;
        private System.Windows.Forms.Button btAddDb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.TabPage getApiPage;
        private System.Windows.Forms.Button btApi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbApi;
        private System.Windows.Forms.RadioButton rbGetOneApi;
        private System.Windows.Forms.RadioButton rbGetAllApi;
        private System.Windows.Forms.DataGridView tableGetApi;
        private System.Windows.Forms.RadioButton rbSecWin;
        private System.Windows.Forms.GroupBox gbTypeSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSecServer;
        private System.Windows.Forms.TextBox tbConfigPassword;
        private System.Windows.Forms.TextBox tbConfigUserId;
    }
}

