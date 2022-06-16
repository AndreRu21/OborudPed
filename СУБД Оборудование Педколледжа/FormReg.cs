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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this.oborudPedDataSet.Places);
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);
            bsUsers.AddNew();
            lblRole.Text = "Закрепленный";
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !cbxShowPass.Checked;
            tbxConfirm.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

     
     

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbxFam.Text == "" || tbxName.Text == "" || tbxOtch.Text == ""|| tbxLogin.Text == "" || tbxPass.Text == "" || tbxConfirm.Text == "")
            {
                MessageBox.Show("Не заполнены все обязательные поля!","Внимание!");
                return;
            }
            if(tbxPass.Text != tbxConfirm.Text)
            {
                MessageBox.Show("Пароль не совпадает с подтверждением!", "Внимание!");
                return;
            }
            int countspace = 0;
            for(int i = 0;i<=mtbPhone.Text.Length -1;i++)
            {
                if (mtbPhone.Text[i] == ' ')
                    countspace++;
            }
            if(countspace>1)
            {
                MessageBox.Show("Телефон имеет неправильный формат!", "Внимание!");
                return;
            }

            lblUserPlace.Text = lblIdPlace.Text;
            bsUsers.EndEdit();
            this.usersTableAdapter.Update(this.oborudPedDataSet.Users);
            MessageBox.Show("Регистрация успешно завершена!", "Внимание");
            this.Close();
                
        }

        private void mtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
                

        }
    }
}
