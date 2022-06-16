namespace СУБД_Оборудование_Педколледжа
{
    partial class FormSpisObor
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
            System.Windows.Forms.Label nazvLabel;
            System.Windows.Forms.Label serNomerLabel;
            System.Windows.Forms.Label descriptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpisObor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAut = new System.Windows.Forms.Label();
            this.oborudPedDataSet = new СУБД_Оборудование_Педколледжа.OborudPedDataSet();
            this.bsOborud = new System.Windows.Forms.BindingSource(this.components);
            this.oborudTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.OborudTableAdapter();
            this.tableAdapterManager = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.UsersTableAdapter();
            this.nazvLabel1 = new System.Windows.Forms.Label();
            this.serNomerLabel1 = new System.Windows.Forms.Label();
            this.descriptLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrichin = new System.Windows.Forms.TextBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFormDoc = new System.Windows.Forms.Button();
            nazvLabel = new System.Windows.Forms.Label();
            serNomerLabel = new System.Windows.Forms.Label();
            descriptLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOborud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // nazvLabel
            // 
            nazvLabel.AutoSize = true;
            nazvLabel.Location = new System.Drawing.Point(6, 133);
            nazvLabel.Name = "nazvLabel";
            nazvLabel.Size = new System.Drawing.Size(60, 13);
            nazvLabel.TabIndex = 3;
            nazvLabel.Text = "Название:";
            // 
            // serNomerLabel
            // 
            serNomerLabel.AutoSize = true;
            serNomerLabel.Location = new System.Drawing.Point(6, 161);
            serNomerLabel.Name = "serNomerLabel";
            serNomerLabel.Size = new System.Drawing.Size(96, 13);
            serNomerLabel.TabIndex = 4;
            serNomerLabel.Text = "Серийный номер:";
            // 
            // descriptLabel
            // 
            descriptLabel.AutoSize = true;
            descriptLabel.Location = new System.Drawing.Point(232, 133);
            descriptLabel.Name = "descriptLabel";
            descriptLabel.Size = new System.Drawing.Size(60, 13);
            descriptLabel.TabIndex = 5;
            descriptLabel.Text = "Описание:";
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
            this.panel1.Size = new System.Drawing.Size(626, 120);
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
            this.lblAut.Location = new System.Drawing.Point(136, 45);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(485, 33);
            this.lblAut.TabIndex = 0;
            this.lblAut.Text = "Заявка на списание оборудования";
            // 
            // oborudPedDataSet
            // 
            this.oborudPedDataSet.DataSetName = "OborudPedDataSet";
            this.oborudPedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsOborud
            // 
            this.bsOborud.DataMember = "Oborud";
            this.bsOborud.DataSource = this.oborudPedDataSet;
            // 
            // oborudTableAdapter
            // 
            this.oborudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OborudTableAdapter = this.oborudTableAdapter;
            this.tableAdapterManager.PlacesTableAdapter = null;
            this.tableAdapterManager.TypesPlaceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.ZayavkaAddTableAdapter = null;
            this.tableAdapterManager.ZayavkaSpisTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // nazvLabel1
            // 
            this.nazvLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOborud, "Nazv", true));
            this.nazvLabel1.Location = new System.Drawing.Point(72, 133);
            this.nazvLabel1.Name = "nazvLabel1";
            this.nazvLabel1.Size = new System.Drawing.Size(154, 23);
            this.nazvLabel1.TabIndex = 4;
            this.nazvLabel1.Text = "label1";
            // 
            // serNomerLabel1
            // 
            this.serNomerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOborud, "SerNomer", true));
            this.serNomerLabel1.Location = new System.Drawing.Point(108, 161);
            this.serNomerLabel1.Name = "serNomerLabel1";
            this.serNomerLabel1.Size = new System.Drawing.Size(100, 23);
            this.serNomerLabel1.TabIndex = 5;
            this.serNomerLabel1.Text = "label1";
            // 
            // descriptLabel1
            // 
            this.descriptLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOborud, "Descript", true));
            this.descriptLabel1.Location = new System.Drawing.Point(298, 133);
            this.descriptLabel1.Name = "descriptLabel1";
            this.descriptLabel1.Size = new System.Drawing.Size(302, 22);
            this.descriptLabel1.TabIndex = 6;
            this.descriptLabel1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Укажите причину списания:";
            // 
            // tbxPrichin
            // 
            this.tbxPrichin.Location = new System.Drawing.Point(387, 158);
            this.tbxPrichin.Name = "tbxPrichin";
            this.tbxPrichin.Size = new System.Drawing.Size(213, 20);
            this.tbxPrichin.TabIndex = 8;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.oborudPedDataSet;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(162, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(243, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFormDoc
            // 
            this.btnFormDoc.Location = new System.Drawing.Point(324, 213);
            this.btnFormDoc.Name = "btnFormDoc";
            this.btnFormDoc.Size = new System.Drawing.Size(151, 23);
            this.btnFormDoc.TabIndex = 11;
            this.btnFormDoc.Text = "Сформировать документ";
            this.btnFormDoc.UseVisualStyleBackColor = true;
            this.btnFormDoc.Click += new System.EventHandler(this.btnFormDoc_Click);
            // 
            // FormSpisObor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 248);
            this.Controls.Add(this.btnFormDoc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxPrichin);
            this.Controls.Add(this.label1);
            this.Controls.Add(descriptLabel);
            this.Controls.Add(this.descriptLabel1);
            this.Controls.Add(serNomerLabel);
            this.Controls.Add(this.serNomerLabel1);
            this.Controls.Add(nazvLabel);
            this.Controls.Add(this.nazvLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpisObor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование НППК";
            this.Load += new System.EventHandler(this.FormSpisObor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOborud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAut;
        private OborudPedDataSet oborudPedDataSet;
        private OborudPedDataSetTableAdapters.OborudTableAdapter oborudTableAdapter;
        private OborudPedDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nazvLabel1;
        private System.Windows.Forms.Label serNomerLabel1;
        private System.Windows.Forms.Label descriptLabel1;
        private OborudPedDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrichin;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFormDoc;
        public System.Windows.Forms.BindingSource bsOborud;
    }
}