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
    public partial class FormEditObor : Form
    {
        public FormEditObor()
        {
            InitializeComponent();
        }

        

        private void FormEditObor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Oborud' table. You can move, or remove it, as needed.
            this.oborudTableAdapter.Fill(this.oborudPedDataSet.Oborud);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(nazvTextBox.Text == "" || serNomerTextBox.Text == "" || descriptTextBox.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля!", "Внимание!");
                return;
            }
            if(isSpisCheckBox.Checked)
            {
                DataRowView drv = (DataRowView)oborudBindingSource.Current;
                drv["DateSpis"] = DateTime.Now.ToShortDateString();
            }
            else
            {
                DataRowView drv = (DataRowView)oborudBindingSource.Current;
                drv["DateSpis"] = DBNull.Value;
            }
            oborudBindingSource.EndEdit();
            this.oborudTableAdapter.Update(this.oborudPedDataSet.Oborud);
        }
    }
}
