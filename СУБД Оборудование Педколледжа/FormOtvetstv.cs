using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace СУБД_Оборудование_Педколледжа
{
    public partial class FormOtvetstv : Form
    {
        public FormOtvetstv()
        {
            InitializeComponent();
        }
        string idplace;
        

        private void FormOtvetstv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.ZayavkaAdd' table. You can move, or remove it, as needed.
            this.zayavkaAddTableAdapter.Fill(this.oborudPedDataSet.ZayavkaAdd);
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillByForm(this.oborudPedDataSet.Users);
            DataRowView drv = (DataRowView)bsUsers.Current;
            namePlaceLabel1.Text = drv["NamePlace"].ToString();
            idplace = drv["IdPlace"].ToString();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and IsSpis = 'false'",con);
            SqlDataReader rez = query.ExecuteReader();
            while(rez.Read())
            {
                dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
            }
            con.Close();
            con.Open();

            SqlCommand query1 = new SqlCommand($@"SELECT        Users.Fam, Oborud.Nazv, ZayavkaSpis.Prichina, ZayavkaSpis.Prinyat, ZayavkaSpis.DateZayavka, Oborud.SerNomer, ZayavkaSpis.IdSpis
FROM            Oborud INNER JOIN
                         Places ON Oborud.IdPlace = Places.IdPlace INNER JOIN
                         Users ON Places.IdPlace = Users.IdPlace INNER JOIN
                         ZayavkaSpis ON Oborud.IdObor = ZayavkaSpis.IDobor AND Places.IdPlace = ZayavkaSpis.IDplace AND Users.IdUser = ZayavkaSpis.IDuser
						 where ZayavkaSpis.IDplace = {idplace}",con);
            SqlDataReader rez1 = query1.ExecuteReader();
            while(rez1.Read())
            {
                dgvSpis.Rows.Add(rez1["Fam"], rez1["Nazv"],rez1["Prichina"],rez1["Prinyat"],rez1["DateZayavka"],rez1["SerNomer"],rez1["IdSpis"]);
            }
            con.Close();

            bsAddZayav.Filter = "IDuser = " + idUserLabel1.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm.bsUsers.Filter = bsUsers.Filter;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.usersTableAdapter.FillByForm(this.oborudPedDataSet.Users);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbxSearch.Text == "")
            {
                MessageBox.Show("В строке поиска ничего нет! Для очистки используйте кнопку \"Очистить поиск\".");
                return;
            }

            rbtSpis.Enabled = false;
            rbtNonSpis.Enabled = false;

            dgvObor.Rows.Clear();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            if (rbtDescript.Checked)
            {
                
                con.Open();
                SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and Descript like '%{tbxSearch.Text}%'", con);
                SqlDataReader rez = query.ExecuteReader();
                while (rez.Read())
                {
                    dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
                }
                con.Close();
            }
            if(rbtNazv.Checked)
            {
                con.Open();
                SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and Nazv like '%{tbxSearch.Text}%'", con);
                SqlDataReader rez = query.ExecuteReader();
                while (rez.Read())
                {
                    dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
                }
                con.Close();
            }
            if(rbtSerNom.Checked)
            {
                con.Open();
                SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and SerNomer like '%{tbxSearch.Text}%'", con);
                SqlDataReader rez = query.ExecuteReader();
                while (rez.Read())
                {
                    dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
                }
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            rbtSpis.Enabled = true;
            rbtNonSpis.Enabled = true;
            dgvObor.Rows.Clear();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and IsSpis = 'false'", con);
            SqlDataReader rez = query.ExecuteReader();
            while (rez.Read())
            {
                dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
            }
            con.Close();
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string idzayav = dgvSpis.CurrentRow.Cells[6].Value.ToString();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Update ZayavkaSpis set prinyat = 'true' where IdSpis = {idzayav}", con);
            query.ExecuteNonQuery();
            dgvSpis.Rows.Clear();
            dgvObor.Rows.Clear();
            FormOtvetstv_Load(null,null);
            con.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            dgvSpis.Rows.Clear();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query1 = new SqlCommand($@"SELECT        Users.Fam, Oborud.Nazv, ZayavkaSpis.Prichina, ZayavkaSpis.Prinyat, ZayavkaSpis.DateZayavka, Oborud.SerNomer, ZayavkaSpis.IdSpis
FROM            Oborud INNER JOIN
                         Places ON Oborud.IdPlace = Places.IdPlace INNER JOIN
                         Users ON Places.IdPlace = Users.IdPlace INNER JOIN
                         ZayavkaSpis ON Oborud.IdObor = ZayavkaSpis.IDobor AND Places.IdPlace = ZayavkaSpis.IDplace AND Users.IdUser = ZayavkaSpis.IDuser
						 where ZayavkaSpis.IDplace = {idplace} and ZayavkaSpis.Prinyat = 'false'", con);
            SqlDataReader rez1 = query1.ExecuteReader();
            while (rez1.Read())
            {
                dgvSpis.Rows.Add(rez1["Fam"], rez1["Nazv"], rez1["Prichina"], rez1["Prinyat"], rez1["DateZayavka"], rez1["SerNomer"], rez1["IdSpis"]);
            }
            con.Close();
        }

        private void btnShowZ_Click(object sender, EventArgs e)
        {
            dgvSpis.Rows.Clear();
            dgvObor.Rows.Clear();
            FormOtvetstv_Load(null, null);
        }

        private void rbtSpis_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtNonSpis.Checked)
            {
                btnSpis.Enabled = true;
                btnReturn.Enabled = false;
                dgvObor.Rows.Clear();
                dgvSpis.Rows.Clear();
                FormOtvetstv_Load(null, null);
            }
            if(rbtSpis.Checked)
            {
                btnReturn.Enabled = true;
                btnSpis.Enabled = false;
                dgvObor.Rows.Clear();
                SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
                con.Open();
                SqlCommand query = new SqlCommand($@"Select Nazv, SerNomer, DatePostup, Descript, IsSpis, DateSpis, IdObor
From Oborud
Where IdPlace = {idplace} and IsSpis = 'true'", con);
                SqlDataReader rez = query.ExecuteReader();
                while (rez.Read())
                {
                    dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
                }
                con.Close();
            }
        }

        private void btnSpis_Click(object sender, EventArgs e)
        {
            string idobor = "";
            try
            {
                 idobor = dgvObor.CurrentRow.Cells[6].Value.ToString();
            }
            catch { MessageBox.Show("Не выделено ни одного элемента!", "Внимание!"); return; }
            string date = DateTime.Now.ToShortDateString();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Update Oborud set IsSpis = 'true', DateSpis = '{date}'  where IdObor = {idobor}", con);
            query.ExecuteNonQuery();
            dgvSpis.Rows.Clear();
            dgvObor.Rows.Clear();
            FormOtvetstv_Load(null, null);
            con.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string idobor = "";
            try
            {
                idobor = dgvObor.CurrentRow.Cells[6].Value.ToString();
            }
            catch { MessageBox.Show("Не выделено ни одного элемента!", "Внимание!"); return; }
           
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Update Oborud set IsSpis = 'false', DateSpis = NULL  where IdObor = {idobor}", con);
            query.ExecuteNonQuery();
            
            dgvObor.Rows.Clear();
            rbtSpis_CheckedChanged(null,null);
            con.Close();
        }

        private void btnAddZayav_Click(object sender, EventArgs e)
        {
            FormZayavAddObor frm = new FormZayavAddObor();
            frm.bsUsers.Filter = this.bsUsers.Filter;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                zayavkaAddTableAdapter.Fill(this.oborudPedDataSet.ZayavkaAdd);
            }
        }

        private void btnSpravka_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\NPPKSpravka.chm");
        }
    }
}
