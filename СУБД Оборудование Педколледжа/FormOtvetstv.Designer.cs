namespace СУБД_Оборудование_Педколледжа
{
    partial class FormOtvetstv
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
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label namePlaceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtvetstv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAut = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.oborudPedDataSet = new СУБД_Оборудование_Педколледжа.OborudPedDataSet();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.namePlaceLabel1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowZ = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvSpis = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSpis = new System.Windows.Forms.RadioButton();
            this.rbtNonSpis = new System.Windows.Forms.RadioButton();
            this.btnSpis = new System.Windows.Forms.Button();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zayavkaAddDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsAddZayav = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddZayav = new System.Windows.Forms.Button();
            this.usersTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager();
            this.idUserLabel1 = new System.Windows.Forms.Label();
            this.zayavkaAddTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.ZayavkaAddTableAdapter();
            this.btnSpravka = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            namePlaceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpis)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkaAddDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddZayav)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(5, 146);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 168);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(5, 191);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(57, 13);
            otchLabel.TabIndex = 5;
            otchLabel.Text = "Отчество:";
            // 
            // namePlaceLabel
            // 
            namePlaceLabel.AutoSize = true;
            namePlaceLabel.Location = new System.Drawing.Point(5, 124);
            namePlaceLabel.Name = "namePlaceLabel";
            namePlaceLabel.Size = new System.Drawing.Size(52, 13);
            namePlaceLabel.TabIndex = 7;
            namePlaceLabel.Text = "Кабинет:";
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
            this.panel1.Size = new System.Drawing.Size(921, 120);
            this.panel1.TabIndex = 1;
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
            this.lblAut.Location = new System.Drawing.Point(250, 41);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(434, 33);
            this.lblAut.TabIndex = 0;
            this.lblAut.Text = "Рабочее место ответственного";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(65, 146);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 3;
            this.famLabel1.Text = "label1";
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.oborudPedDataSet;
            // 
            // oborudPedDataSet
            // 
            this.oborudPedDataSet.DataSetName = "OborudPedDataSet";
            this.oborudPedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(65, 169);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.Text = "label1";
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(65, 191);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 6;
            this.otchLabel1.Text = "label1";
            // 
            // namePlaceLabel1
            // 
            this.namePlaceLabel1.Location = new System.Drawing.Point(65, 124);
            this.namePlaceLabel1.Name = "namePlaceLabel1";
            this.namePlaceLabel1.Size = new System.Drawing.Size(100, 23);
            this.namePlaceLabel1.TabIndex = 8;
            this.namePlaceLabel1.Text = "label1";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(4, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 38);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Редактировать профиль";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowZ);
            this.tabPage2.Controls.Add(this.btnHide);
            this.tabPage2.Controls.Add(this.btnAccept);
            this.tabPage2.Controls.Add(this.dgvSpis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявки на списание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowZ
            // 
            this.btnShowZ.Location = new System.Drawing.Point(258, 306);
            this.btnShowZ.Name = "btnShowZ";
            this.btnShowZ.Size = new System.Drawing.Size(89, 46);
            this.btnShowZ.TabIndex = 3;
            this.btnShowZ.Text = "Показать все заявки";
            this.btnShowZ.UseVisualStyleBackColor = true;
            this.btnShowZ.Click += new System.EventHandler(this.btnShowZ_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(111, 306);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(141, 46);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Убрать просмотренные заявки";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(6, 306);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 46);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Принять заявку";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dgvSpis
            // 
            this.dgvSpis.AllowUserToAddRows = false;
            this.dgvSpis.AllowUserToDeleteRows = false;
            this.dgvSpis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvSpis.Location = new System.Drawing.Point(6, 6);
            this.dgvSpis.Name = "dgvSpis";
            this.dgvSpis.ReadOnly = true;
            this.dgvSpis.RowHeadersVisible = false;
            this.dgvSpis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpis.Size = new System.Drawing.Size(635, 294);
            this.dgvSpis.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Фамилия";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Оборудование";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Причина";
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
            this.Column11.HeaderText = "Дата заявки";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Серийный номер";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ID";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReturn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnSpis);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxSearch);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvObor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список оборудования";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(394, 300);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(206, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Вернуть выделенное оборудование";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtSpis);
            this.groupBox2.Controls.Add(this.rbtNonSpis);
            this.groupBox2.Location = new System.Drawing.Point(253, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 73);
            this.groupBox2.TabIndex = 3;
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
            // btnSpis
            // 
            this.btnSpis.Location = new System.Drawing.Point(394, 329);
            this.btnSpis.Name = "btnSpis";
            this.btnSpis.Size = new System.Drawing.Size(206, 23);
            this.btnSpis.TabIndex = 6;
            this.btnSpis.Text = "Списать выделенное оборудование";
            this.btnSpis.UseVisualStyleBackColor = true;
            this.btnSpis.Click += new System.EventHandler(this.btnSpis_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить поиск";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(147, 305);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
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
            this.label1.TabIndex = 3;
            this.label1.Text = "Строка поиска:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(147, 279);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDescript);
            this.groupBox1.Controls.Add(this.rbtSerNom);
            this.groupBox1.Controls.Add(this.rbtNazv);
            this.groupBox1.Location = new System.Drawing.Point(6, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 91);
            this.groupBox1.TabIndex = 1;
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
            this.dgvObor.TabIndex = 0;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(171, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 384);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.zayavkaAddDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(731, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Созданные заявки на добавление";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zayavkaAddDataGridView
            // 
            this.zayavkaAddDataGridView.AllowUserToAddRows = false;
            this.zayavkaAddDataGridView.AutoGenerateColumns = false;
            this.zayavkaAddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zayavkaAddDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.zayavkaAddDataGridView.DataSource = this.bsAddZayav;
            this.zayavkaAddDataGridView.Location = new System.Drawing.Point(6, 6);
            this.zayavkaAddDataGridView.Name = "zayavkaAddDataGridView";
            this.zayavkaAddDataGridView.ReadOnly = true;
            this.zayavkaAddDataGridView.RowHeadersVisible = false;
            this.zayavkaAddDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zayavkaAddDataGridView.Size = new System.Drawing.Size(556, 346);
            this.zayavkaAddDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateZayavka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Obor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оборудование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Prinyat";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Просмотрено";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // bsAddZayav
            // 
            this.bsAddZayav.DataMember = "ZayavkaAdd";
            this.bsAddZayav.DataSource = this.oborudPedDataSet;
            // 
            // btnAddZayav
            // 
            this.btnAddZayav.Location = new System.Drawing.Point(4, 251);
            this.btnAddZayav.Name = "btnAddZayav";
            this.btnAddZayav.Size = new System.Drawing.Size(97, 52);
            this.btnAddZayav.TabIndex = 11;
            this.btnAddZayav.Text = "Создать заявку на добавление оборудования";
            this.btnAddZayav.UseVisualStyleBackColor = true;
            this.btnAddZayav.Click += new System.EventHandler(this.btnAddZayav_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.OborudTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = null;
            this.tableAdapterManager.TypesPlaceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.ZayavkaAddTableAdapter = null;
            this.tableAdapterManager.ZayavkaSpisTableAdapter = null;
            // 
            // idUserLabel1
            // 
            this.idUserLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "IdUser", true));
            this.idUserLabel1.Location = new System.Drawing.Point(12, 659);
            this.idUserLabel1.Name = "idUserLabel1";
            this.idUserLabel1.Size = new System.Drawing.Size(100, 23);
            this.idUserLabel1.TabIndex = 13;
            this.idUserLabel1.Text = "label2";
            // 
            // zayavkaAddTableAdapter
            // 
            this.zayavkaAddTableAdapter.ClearBeforeFill = true;
            // 
            // btnSpravka
            // 
            this.btnSpravka.Location = new System.Drawing.Point(4, 482);
            this.btnSpravka.Name = "btnSpravka";
            this.btnSpravka.Size = new System.Drawing.Size(97, 22);
            this.btnSpravka.TabIndex = 20;
            this.btnSpravka.Text = "Справка";
            this.btnSpravka.UseVisualStyleBackColor = true;
            this.btnSpravka.Click += new System.EventHandler(this.btnSpravka_Click);
            // 
            // FormOtvetstv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 522);
            this.Controls.Add(this.btnSpravka);
            this.Controls.Add(this.idUserLabel1);
            this.Controls.Add(this.btnAddZayav);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(namePlaceLabel);
            this.Controls.Add(this.namePlaceLabel1);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.otchLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famLabel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOtvetstv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование НППК";
            this.Load += new System.EventHandler(this.FormOtvetstv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpis)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zayavkaAddDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddZayav)).EndInit();
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
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label namePlaceLabel1;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowZ;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvSpis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtSpis;
        private System.Windows.Forms.RadioButton rbtNonSpis;
        private System.Windows.Forms.Button btnSpis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDescript;
        private System.Windows.Forms.RadioButton rbtSerNom;
        private System.Windows.Forms.RadioButton rbtNazv;
        private System.Windows.Forms.DataGridView dgvObor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddZayav;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label idUserLabel1;
        private System.Windows.Forms.BindingSource bsAddZayav;
        private OborudPedDataSetTableAdapters.ZayavkaAddTableAdapter zayavkaAddTableAdapter;
        private System.Windows.Forms.DataGridView zayavkaAddDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btnSpravka;
    }
}