using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace СУБД_Оборудование_Педколледжа
{
    public partial class FormAut : Form
    {
        public FormAut()
        {
            InitializeComponent();
        }

        

        private void FormAut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsUsers.Filter = "Login = '" + tbxLogin.Text + "' and Pass = '" + tbxPass.Text + "'";
            if(bsUsers.Count > 0)
            {
                if(lblRole.Text == "Ответственный")
                {
                    FormOtvetstv frm = new FormOtvetstv();
                    frm.bsUsers.Filter = bsUsers.Filter;
                    frm.ShowDialog();
                }
                if(lblRole.Text == "Закрепленный")
                {
                    FormZakrep frm = new FormZakrep();
                    frm.bsUsers.Filter = this.bsUsers.Filter;
                    frm.ShowDialog();
                }
                if(lblRole.Text == "Администратор")
                {
                    FormAdmin frm = new FormAdmin();
                    frm.bsUsers.Filter = this.bsUsers.Filter;
                    frm.ShowDialog();
                }

                this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);
            }
            else
            {
                MessageBox.Show("Неверный логин/пароль! Повторите попытку.", "Внимание!");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            FormReg frm = new FormReg();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);
            }
        }

        private void btnSpravka_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\NPPKSpravka.chm");
        }
    }
}
