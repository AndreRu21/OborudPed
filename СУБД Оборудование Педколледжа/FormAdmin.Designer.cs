namespace СУБД_Оборудование_Педколледжа
{
    partial class FormAdmin
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
            System.Windows.Forms.Label namePlaceLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label famLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAut = new System.Windows.Forms.Label();
            this.oborudPedDataSet = new СУБД_Оборудование_Педколледжа.OborudPedDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager();
            this.placesTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.PlacesTableAdapter();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.bsPlaces = new System.Windows.Forms.BindingSource(this.components);
            this.idPlaceLabel1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditObor = new System.Windows.Forms.Button();
            this.btnAddObor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSpis = new System.Windows.Forms.RadioButton();
            this.rbtNonSpis = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDescript = new System.Windows.Forms.RadioButton();
            this.rbtSerNom = new System.Windows.Forms.RadioButton();
            this.rbtNazv = new System.Windows.Forms.RadioButton();
            this.dgvObor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowZ = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnProsmotr = new System.Windows.Forms.Button();
            this.dgvZayav = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSpravka = new System.Windows.Forms.Button();
            namePlaceLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlaces)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZayav)).BeginInit();
            this.SuspendLayout();
            // 
            // namePlaceLabel
            // 
            namePlaceLabel.AutoSize = true;
            namePlaceLabel.Location = new System.Drawing.Point(12, 132);
            namePlaceLabel.Name = "namePlaceLabel";
            namePlaceLabel.Size = new System.Drawing.Size(52, 13);
            namePlaceLabel.TabIndex = 14;
            namePlaceLabel.Text = "Кабинет:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(12, 232);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(57, 13);
            otchLabel.TabIndex = 12;
            otchLabel.Text = "Отчество:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Имя:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(12, 187);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 8;
            famLabel.Text = "Фамилия:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 120);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::СУБД_Оборудование_Педколледжа.Properties.Resources.NPPK;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAut
            // 
            this.lblAut.AutoSize = true;
            this.lblAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAut.Location = new System.Drawing.Point(286, 42);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(450, 33);
            this.lblAut.TabIndex = 0;
            this.lblAut.Text = "Рабочее место администратора";
            // 
            // oborudPedDataSet
            // 
            this.oborudPedDataSet.DataSetName = "OborudPedDataSet";
            this.oborudPedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.oborudPedDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OborudTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = this.placesTableAdapter;
            this.tableAdapterManager.TypesPlaceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.ZayavkaAddTableAdapter = null;
            this.tableAdapterManager.ZayavkaSpisTableAdapter = null;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(72, 232);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 13;
            this.otchLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(72, 210);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(72, 187);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 10;
            this.famLabel1.Text = "label1";
            // 
            // cmbPlace
            // 
            this.cmbPlace.DataSource = this.bsPlaces;
            this.cmbPlace.DisplayMember = "NamePlace";
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(15, 148);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(121, 21);
            this.cmbPlace.TabIndex = 15;
            this.cmbPlace.ValueMember = "IdPlace";
            this.cmbPlace.SelectedIndexChanged += new System.EventHandler(this.cmbPlace_SelectedIndexChanged);
            // 
            // bsPlaces
            // 
            this.bsPlaces.DataMember = "Places";
            this.bsPlaces.DataSource = this.oborudPedDataSet;
            // 
            // idPlaceLabel1
            // 
            this.idPlaceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlaces, "IdPlace", true));
            this.idPlaceLabel1.Location = new System.Drawing.Point(12, 541);
            this.idPlaceLabel1.Name = "idPlaceLabel1";
            this.idPlaceLabel1.Size = new System.Drawing.Size(100, 23);
            this.idPlaceLabel1.TabIndex = 16;
            this.idPlaceLabel1.Text = "1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(142, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 385);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditObor);
            this.tabPage1.Controls.Add(this.btnAddObor);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxSearch);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvObor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оборудование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditObor
            // 
            this.btnEditObor.Location = new System.Drawing.Point(488, 315);
            this.btnEditObor.Name = "btnEditObor";
            this.btnEditObor.Size = new System.Drawing.Size(153, 36);
            this.btnEditObor.TabIndex = 14;
            this.btnEditObor.Text = "Редактировать выделенное оборудование";
            this.btnEditObor.UseVisualStyleBackColor = true;
            this.btnEditObor.Click += new System.EventHandler(this.btnEditObor_Click);
            // 
            // btnAddObor
            // 
            this.btnAddObor.Location = new System.Drawing.Point(394, 315);
            this.btnAddObor.Name = "btnAddObor";
            this.btnAddObor.Size = new System.Drawing.Size(88, 36);
            this.btnAddObor.TabIndex = 13;
            this.btnAddObor.Text = "Добавить оборудование";
            this.btnAddObor.UseVisualStyleBackColor = true;
            this.btnAddObor.Click += new System.EventHandler(this.btnAddObor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtSpis);
            this.groupBox2.Controls.Add(this.rbtNonSpis);
            this.groupBox2.Location = new System.Drawing.Point(253, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип оборудования:";
            // 
            // rbtSpis
            // 
            this.rbtSpis.AutoSize = true;
            this.rbtSpis.Location = new System.Drawing.Point(6, 41);
            this.rbtSpis.Name = "rbtSpis";
            this.rbtSpis.Size = new System.Drawing.Size(80, 17);
            this.rbtSpis.TabIndex = 1;
            this.rbtSpis.Text = "Списанное";
            this.rbtSpis.UseVisualStyleBackColor = true;
            this.rbtSpis.CheckedChanged += new System.EventHandler(this.rbtSpis_CheckedChanged);
            // 
            // rbtNonSpis
            // 
            this.rbtNonSpis.AutoSize = true;
            this.rbtNonSpis.Checked = true;
            this.rbtNonSpis.Location = new System.Drawing.Point(6, 19);
            this.rbtNonSpis.Name = "rbtNonSpis";
            this.rbtNonSpis.Size = new System.Drawing.Size(96, 17);
            this.rbtNonSpis.TabIndex = 0;
            this.rbtNonSpis.TabStop = true;
            this.rbtNonSpis.Text = "Не списанное";
            this.rbtNonSpis.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить поиск";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(147, 305);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Строка поиска:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(147, 279);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDescript);
            this.groupBox1.Controls.Add(this.rbtSerNom);
            this.groupBox1.Controls.Add(this.rbtNazv);
            this.groupBox1.Location = new System.Drawing.Point(6, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по:";
            // 
            // rbtDescript
            // 
            this.rbtDescript.AutoSize = true;
            this.rbtDescript.Location = new System.Drawing.Point(6, 63);
            this.rbtDescript.Name = "rbtDescript";
            this.rbtDescript.Size = new System.Drawing.Size(77, 17);
            this.rbtDescript.TabIndex = 2;
            this.rbtDescript.Text = "Описанию";
            this.rbtDescript.UseVisualStyleBackColor = true;
            // 
            // rbtSerNom
            // 
            this.rbtSerNom.AutoSize = true;
            this.rbtSerNom.Location = new System.Drawing.Point(6, 41);
            this.rbtSerNom.Name = "rbtSerNom";
            this.rbtSerNom.Size = new System.Drawing.Size(121, 17);
            this.rbtSerNom.TabIndex = 1;
            this.rbtSerNom.Text = "Серийному номеру";
            this.rbtSerNom.UseVisualStyleBackColor = true;
            // 
            // rbtNazv
            // 
            this.rbtNazv.AutoSize = true;
            this.rbtNazv.Checked = true;
            this.rbtNazv.Location = new System.Drawing.Point(6, 19);
            this.rbtNazv.Name = "rbtNazv";
            this.rbtNazv.Size = new System.Drawing.Size(77, 17);
            this.rbtNazv.TabIndex = 0;
            this.rbtNazv.TabStop = true;
            this.rbtNazv.Text = "Названию";
            this.rbtNazv.UseVisualStyleBackColor = true;
            // 
            // dgvObor
            // 
            this.dgvObor.AllowUserToAddRows = false;
            this.dgvObor.AllowUserToDeleteRows = false;
            this.dgvObor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column14});
            this.dgvObor.Location = new System.Drawing.Point(6, 6);
            this.dgvObor.Name = "dgvObor";
            this.dgvObor.ReadOnly = true;
            this.dgvObor.RowHeadersVisible = false;
            this.dgvObor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObor.Size = new System.Drawing.Size(719, 250);
            this.dgvObor.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Серийный номер";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата поступления";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Описание";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Списано/не списано";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дата списания";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ID";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnShowZ);
            this.tabPage2.Controls.Add(this.btnHide);
            this.tabPage2.Controls.Add(this.btnProsmotr);
            this.tabPage2.Controls.Add(this.dgvZayav);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявки на добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowZ
            // 
            this.btnShowZ.Location = new System.Drawing.Point(598, 93);
            this.btnShowZ.Name = "btnShowZ";
            this.btnShowZ.Size = new System.Drawing.Size(106, 46);
            this.btnShowZ.TabIndex = 4;
            this.btnShowZ.Text = "Показать все заявки";
            this.btnShowZ.UseVisualStyleBackColor = true;
            this.btnShowZ.Click += new System.EventHandler(this.btnShowZ_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(598, 35);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(106, 52);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Убрать просмотренные заявки";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnProsmotr
            // 
            this.btnProsmotr.Location = new System.Drawing.Point(598, 6);
            this.btnProsmotr.Name = "btnProsmotr";
            this.btnProsmotr.Size = new System.Drawing.Size(106, 23);
            this.btnProsmotr.TabIndex = 1;
            this.btnProsmotr.Text = "Просмотрено";
            this.btnProsmotr.UseVisualStyleBackColor = true;
            this.btnProsmotr.Click += new System.EventHandler(this.btnProsmotr_Click);
            // 
            // dgvZayav
            // 
            this.dgvZayav.AllowUserToAddRows = false;
            this.dgvZayav.AllowUserToDeleteRows = false;
            this.dgvZayav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZayav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvZayav.Location = new System.Drawing.Point(6, 6);
            this.dgvZayav.Name = "dgvZayav";
            this.dgvZayav.ReadOnly = true;
            this.dgvZayav.RowHeadersVisible = false;
            this.dgvZayav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZayav.Size = new System.Drawing.Size(586, 347);
            this.dgvZayav.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Фамилия";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Оборудование";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Просмотрено";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Место";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "ID";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 258);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 38);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Редактировать профиль";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSpravka
            // 
            this.btnSpravka.Location = new System.Drawing.Point(15, 487);
            this.btnSpravka.Name = "btnSpravka";
            this.btnSpravka.Size = new System.Drawing.Size(97, 22);
            this.btnSpravka.TabIndex = 19;
            this.btnSpravka.Text = "Справка";
            this.btnSpravka.UseVisualStyleBackColor = true;
            this.btnSpravka.Click += new System.EventHandler(this.btnSpravka_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 521);
            this.Controls.Add(this.btnSpravka);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.idPlaceLabel1);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(namePlaceLabel);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.otchLabel1);
            this.Controls.Add(this.famLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.nameLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование НППК";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlaces)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZayav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAut;
        private OborudPedDataSet oborudPedDataSet;
        private OborudPedDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private OborudPedDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OborudPedDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.BindingSource bsPlaces;
        private System.Windows.Forms.Label idPlaceLabel1;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtSpis;
        private System.Windows.Forms.RadioButton rbtNonSpis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDescript;
        private System.Windows.Forms.RadioButton rbtSerNom;
        private System.Windows.Forms.RadioButton rbtNazv;
        private System.Windows.Forms.DataGridView dgvObor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnProsmotr;
        private System.Windows.Forms.DataGridView dgvZayav;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShowZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnAddObor;
        private System.Windows.Forms.Button btnEditObor;
        private System.Windows.Forms.Button btnSpravka;
    }
}