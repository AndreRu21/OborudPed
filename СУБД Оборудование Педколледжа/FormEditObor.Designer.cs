namespace СУБД_Оборудование_Педколледжа
{
    partial class FormEditObor
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
            System.Windows.Forms.Label datePostupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditObor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAut = new System.Windows.Forms.Label();
            this.oborudPedDataSet = new СУБД_Оборудование_Педколледжа.OborudPedDataSet();
            this.oborudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudTableAdapter = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.OborudTableAdapter();
            this.tableAdapterManager = new СУБД_Оборудование_Педколледжа.OborudPedDataSetTableAdapters.TableAdapterManager();
            this.nazvTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serNomerTextBox = new System.Windows.Forms.TextBox();
            this.descriptTextBox = new System.Windows.Forms.TextBox();
            this.datePostupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.isSpisCheckBox = new System.Windows.Forms.CheckBox();
            nazvLabel = new System.Windows.Forms.Label();
            serNomerLabel = new System.Windows.Forms.Label();
            descriptLabel = new System.Windows.Forms.Label();
            datePostupLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(582, 120);
            this.panel1.TabIndex = 3;
            // 
            // lblAut
            // 
            this.lblAut.AutoSize = true;
            this.lblAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAut.Location = new System.Drawing.Point(136, 43);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(438, 33);
            this.lblAut.TabIndex = 0;
            this.lblAut.Text = "Редактирование оборудования";
            // 
            // oborudPedDataSet
            // 
            this.oborudPedDataSet.DataSetName = "OborudPedDataSet";
            this.oborudPedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oborudBindingSource
            // 
            this.oborudBindingSource.DataMember = "Oborud";
            this.oborudBindingSource.DataSource = this.oborudPedDataSet;
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
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.ZayavkaAddTableAdapter = null;
            this.tableAdapterManager.ZayavkaSpisTableAdapter = null;
            // 
            // nazvLabel
            // 
            nazvLabel.AutoSize = true;
            nazvLabel.Location = new System.Drawing.Point(33, 134);
            nazvLabel.Name = "nazvLabel";
            nazvLabel.Size = new System.Drawing.Size(60, 13);
            nazvLabel.TabIndex = 4;
            nazvLabel.Text = "Название:";
            // 
            // nazvTextBox
            // 
            this.nazvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oborudBindingSource, "Nazv", true));
            this.nazvTextBox.Location = new System.Drawing.Point(99, 131);
            this.nazvTextBox.Name = "nazvTextBox";
            this.nazvTextBox.Size = new System.Drawing.Size(154, 20);
            this.nazvTextBox.TabIndex = 5;
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
            // serNomerLabel
            // 
            serNomerLabel.AutoSize = true;
            serNomerLabel.Location = new System.Drawing.Point(274, 134);
            serNomerLabel.Name = "serNomerLabel";
            serNomerLabel.Size = new System.Drawing.Size(96, 13);
            serNomerLabel.TabIndex = 5;
            serNomerLabel.Text = "Серийный номер:";
            // 
            // serNomerTextBox
            // 
            this.serNomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oborudBindingSource, "SerNomer", true));
            this.serNomerTextBox.Location = new System.Drawing.Point(376, 131);
            this.serNomerTextBox.Name = "serNomerTextBox";
            this.serNomerTextBox.Size = new System.Drawing.Size(154, 20);
            this.serNomerTextBox.TabIndex = 6;
            // 
            // descriptLabel
            // 
            descriptLabel.AutoSize = true;
            descriptLabel.Location = new System.Drawing.Point(33, 160);
            descriptLabel.Name = "descriptLabel";
            descriptLabel.Size = new System.Drawing.Size(60, 13);
            descriptLabel.TabIndex = 6;
            descriptLabel.Text = "Описание:";
            // 
            // descriptTextBox
            // 
            this.descriptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oborudBindingSource, "Descript", true));
            this.descriptTextBox.Location = new System.Drawing.Point(99, 157);
            this.descriptTextBox.Name = "descriptTextBox";
            this.descriptTextBox.Size = new System.Drawing.Size(431, 20);
            this.descriptTextBox.TabIndex = 7;
            // 
            // datePostupLabel
            // 
            datePostupLabel.AutoSize = true;
            datePostupLabel.Location = new System.Drawing.Point(34, 187);
            datePostupLabel.Name = "datePostupLabel";
            datePostupLabel.Size = new System.Drawing.Size(103, 13);
            datePostupLabel.TabIndex = 8;
            datePostupLabel.Text = "Дата поступления:";
            // 
            // datePostupDateTimePicker
            // 
            this.datePostupDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oborudBindingSource, "DatePostup", true));
            this.datePostupDateTimePicker.Location = new System.Drawing.Point(143, 183);
            this.datePostupDateTimePicker.Name = "datePostupDateTimePicker";
            this.datePostupDateTimePicker.Size = new System.Drawing.Size(387, 20);
            this.datePostupDateTimePicker.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(195, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // isSpisCheckBox
            // 
            this.isSpisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oborudBindingSource, "IsSpis", true));
            this.isSpisCheckBox.Location = new System.Drawing.Point(37, 212);
            this.isSpisCheckBox.Name = "isSpisCheckBox";
            this.isSpisCheckBox.Size = new System.Drawing.Size(145, 24);
            this.isSpisCheckBox.TabIndex = 12;
            this.isSpisCheckBox.Text = "Списать оборудование";
            this.isSpisCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormEditObor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 275);
            this.Controls.Add(this.isSpisCheckBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(datePostupLabel);
            this.Controls.Add(this.datePostupDateTimePicker);
            this.Controls.Add(descriptLabel);
            this.Controls.Add(this.descriptTextBox);
            this.Controls.Add(serNomerLabel);
            this.Controls.Add(this.serNomerTextBox);
            this.Controls.Add(nazvLabel);
            this.Controls.Add(this.nazvTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditObor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование НППК";
            this.Load += new System.EventHandler(this.FormEditObor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oborudPedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox nazvTextBox;
        private System.Windows.Forms.TextBox serNomerTextBox;
        private System.Windows.Forms.TextBox descriptTextBox;
        private System.Windows.Forms.DateTimePicker datePostupDateTimePicker;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.BindingSource oborudBindingSource;
        private System.Windows.Forms.CheckBox isSpisCheckBox;
    }
}