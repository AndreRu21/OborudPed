namespace СУБД_Оборудование_Педколледжа
{
    partial class FormReg
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAut = new System.Windows.Forms.Label();
            this.oborudPedDataSet = new СУБД_Оборудование_Педколледжа.OborudPedDataSet();
            this.usersTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.UsersTableAdapter();
            this.placesTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.PlacesTableAdapter();
            this.tbxFam = new System.Windows.Forms.TextBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxOtch = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.bsPlace = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdPlace = new System.Windows.Forms.Label();
            this.lblMesto = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxShowPass = new System.Windows.Forms.CheckBox();
            this.lblUserPlace = new System.Windows.Forms.Label();
            this.tableAdapterManager = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(44, 129);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(71, 155);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(46, 181);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(57, 13);
            otchLabel.TabIndex = 5;
            otchLabel.Text = "Отчество:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(62, 207);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(41, 13);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Логин:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(55, 233);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(48, 13);
            passLabel.TabIndex = 9;
            passLabel.Text = "Пароль:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(48, 310);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
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
            this.panel1.Size = new System.Drawing.Size(359, 120);
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
            this.lblAut.Location = new System.Drawing.Point(155, 43);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(186, 33);
            this.lblAut.TabIndex = 0;
            this.lblAut.Text = "Регистрация";
            // 
            // oborudPedDataSet
            // 
            this.oborudPedDataSet.DataSetName = "OborudPedDataSet";
            this.oborudPedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // tbxFam
            // 
            this.tbxFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Fam", true));
            this.tbxFam.Location = new System.Drawing.Point(109, 126);
            this.tbxFam.Name = "tbxFam";
            this.tbxFam.Size = new System.Drawing.Size(225, 20);
            this.tbxFam.TabIndex = 3;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.oborudPedDataSet;
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(109, 152);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(225, 20);
            this.tbxName.TabIndex = 4;
            // 
            // tbxOtch
            // 
            this.tbxOtch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Otch", true));
            this.tbxOtch.Location = new System.Drawing.Point(109, 178);
            this.tbxOtch.Name = "tbxOtch";
            this.tbxOtch.Size = new System.Drawing.Size(225, 20);
            this.tbxOtch.TabIndex = 6;
            // 
            // tbxLogin
            // 
            this.tbxLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Login", true));
            this.tbxLogin.Location = new System.Drawing.Point(109, 204);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(225, 20);
            this.tbxLogin.TabIndex = 8;
            // 
            // tbxPass
            // 
            this.tbxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Pass", true));
            this.tbxPass.Location = new System.Drawing.Point(109, 230);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(225, 20);
            this.tbxPass.TabIndex = 10;
            this.tbxPass.UseSystemPasswordChar = true;
            // 
            // mtbPhone
            // 
            this.mtbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Phone", true));
            this.mtbPhone.Location = new System.Drawing.Point(109, 307);
            this.mtbPhone.Mask = "+7(999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(114, 20);
            this.mtbPhone.TabIndex = 14;
            this.mtbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhone_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(157, 377);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbPlace
            // 
            this.cmbPlace.DataSource = this.bsPlace;
            this.cmbPlace.DisplayMember = "NamePlace";
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(109, 333);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(225, 21);
            this.cmbPlace.TabIndex = 21;
            // 
            // bsPlace
            // 
            this.bsPlace.DataMember = "Places";
            this.bsPlace.DataSource = this.oborudPedDataSet;
            // 
            // lblIdPlace
            // 
            this.lblIdPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlace, "IdPlace", true));
            this.lblIdPlace.Location = new System.Drawing.Point(545, 429);
            this.lblIdPlace.Name = "lblIdPlace";
            this.lblIdPlace.Size = new System.Drawing.Size(100, 23);
            this.lblIdPlace.TabIndex = 22;
            this.lblIdPlace.Text = "label1";
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(19, 336);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(84, 13);
            this.lblMesto.TabIndex = 23;
            this.lblMesto.Text = "Закреп. место:";
            // 
            // lblRole
            // 
            this.lblRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Role", true));
            this.lblRole.Location = new System.Drawing.Point(545, 452);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(100, 23);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "label1";
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Location = new System.Drawing.Point(109, 257);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.Size = new System.Drawing.Size(225, 20);
            this.tbxConfirm.TabIndex = 25;
            this.tbxConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Подтверждение:";
            // 
            // cbxShowPass
            // 
            this.cbxShowPass.AutoSize = true;
            this.cbxShowPass.Location = new System.Drawing.Point(109, 284);
            this.cbxShowPass.Name = "cbxShowPass";
            this.cbxShowPass.Size = new System.Drawing.Size(114, 17);
            this.cbxShowPass.TabIndex = 27;
            this.cbxShowPass.Text = "Показать пароль";
            this.cbxShowPass.UseVisualStyleBackColor = true;
            this.cbxShowPass.CheckedChanged += new System.EventHandler(this.cbxShowPass_CheckedChanged);
            // 
            // lblUserPlace
            // 
            this.lblUserPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "IdPlace", true));
            this.lblUserPlace.Location = new System.Drawing.Point(545, 475);
            this.lblUserPlace.Name = "lblUserPlace";
            this.lblUserPlace.Size = new System.Drawing.Size(100, 23);
            this.lblUserPlace.TabIndex = 28;
            this.lblUserPlace.Text = "label2";
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
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 417);
            this.Controls.Add(this.lblUserPlace);
            this.Controls.Add(this.cbxShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblMesto);
            this.Controls.Add(this.lblIdPlace);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.tbxOtch);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.tbxFam);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование НППК";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAut;
        private OborudPedDataSet oborudPedDataSet;
        private System.Windows.Forms.BindingSource bsUsers;
        private OborudPedDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private OborudPedDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbxFam;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxOtch;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private OborudPedDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.BindingSource bsPlace;
        private System.Windows.Forms.Label lblIdPlace;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxShowPass;
        private System.Windows.Forms.Label lblUserPlace;
    }
}