using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Оборудование_Педколледжа
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsUsers.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oborudPedDataSet);

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);

        }


     

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbxFam.Text == "" || tbxName.Text == "" || tbxOtch.Text == "")
            {
                MessageBox.Show("Не заполнены все обязательные поля!", "Внимание!");
                return;
            }
            if(tbxOldPass.Text != lblPass.Text)
            {
                MessageBox.Show("Неправильный старый пароль!", "Внимание!");
                return;
            }
            if(tbxNewPass.Text != "")
            {
                lblPass.Text = tbxNewPass.Text;
            }

            bsUsers.EndEdit();
            this.usersTableAdapter.Update(this.oborudPedDataSet.Users);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
