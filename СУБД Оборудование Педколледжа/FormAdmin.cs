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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        string idplace;

        private void FormAdmin_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'oborudPedDataSet.Places' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this.oborudPedDataSet.Places);
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.oborudPedDataSet.Users);
            idplace = idPlaceLabel1.Text;
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


            con.Open();
            SqlCommand query2 = new SqlCommand($@"SELECT        Users.Fam, ZayavkaAdd.DateZayavka, ZayavkaAdd.Obor, ZayavkaAdd.Prinyat, Places.NamePlace, ZayavkaAdd.IdAdd
FROM            Users INNER JOIN
                         ZayavkaAdd ON Users.IdUser = ZayavkaAdd.IDuser INNER JOIN
                         Places ON Users.IdPlace = Places.IdPlace AND ZayavkaAdd.IDPlace = Places.IdPlace
						 where ZayavkaAdd.IDPlace = {idplace}", con);
            SqlDataReader zayav = query2.ExecuteReader();
            while (zayav.Read())
            {
                dgvZayav.Rows.Add(zayav["Fam"], zayav["DateZayavka"], zayav["Obor"], zayav["Prinyat"], zayav["NamePlace"], zayav["IdAdd"]);
            }
            con.Close();
        }

        private void rbtSpis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNonSpis.Checked)
            {

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
            if (rbtSpis.Checked)
            {
               
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
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
Where IdPlace = {idplace} and Descript like '%{tbxSearch.Text}%' ", con);
                SqlDataReader rez = query.ExecuteReader();
                while (rez.Read())
                {
                    dgvObor.Rows.Add(rez["Nazv"], rez["SerNomer"], rez["DatePostup"], rez["Descript"], rez["IsSpis"], rez["DateSpis"], rez["IdObor"]);
                }
                con.Close();
            }
            if (rbtNazv.Checked)
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
            if (rbtSerNom.Checked)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm.bsUsers.Filter = this.bsUsers.Filter;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.usersTableAdapter.FillByForm(this.oborudPedDataSet.Users);
            }
        }

        async private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Delay(50);
            idplace = idPlaceLabel1.Text;
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

            dgvZayav.Rows.Clear();
            con.Open();
            SqlCommand query2 = new SqlCommand($@"SELECT        Users.Fam, ZayavkaAdd.DateZayavka, ZayavkaAdd.Obor, ZayavkaAdd.Prinyat, Places.NamePlace, ZayavkaAdd.IdAdd
FROM            Users INNER JOIN
                         ZayavkaAdd ON Users.IdUser = ZayavkaAdd.IDuser INNER JOIN
                         Places ON Users.IdPlace = Places.IdPlace AND ZayavkaAdd.IDPlace = Places.IdPlace
						 where ZayavkaAdd.IDPlace = {idplace}", con);
            SqlDataReader zayav = query2.ExecuteReader();
            while (zayav.Read())
            {
                dgvZayav.Rows.Add(zayav["Fam"], zayav["DateZayavka"], zayav["Obor"], zayav["Prinyat"], zayav["NamePlace"], zayav["IdAdd"]);
            }
            con.Close();
        }

        private void btnProsmotr_Click(object sender, EventArgs e)
        {
            string idzayav = dgvZayav.CurrentRow.Cells[5].Value.ToString();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Update ZayavkaAdd set prinyat = 'true' where IdAdd = {idzayav}", con);
            query.ExecuteNonQuery();
            cmbPlace_SelectedIndexChanged(null,null);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            dgvZayav.Rows.Clear();
            con.Open();
            SqlCommand query2 = new SqlCommand($@"SELECT        Users.Fam, ZayavkaAdd.DateZayavka, ZayavkaAdd.Obor, ZayavkaAdd.Prinyat, Places.NamePlace, ZayavkaAdd.IdAdd
FROM            Users INNER JOIN
                         ZayavkaAdd ON Users.IdUser = ZayavkaAdd.IDuser INNER JOIN
                         Places ON Users.IdPlace = Places.IdPlace AND ZayavkaAdd.IDPlace = Places.IdPlace
						 where ZayavkaAdd.IDPlace = {idplace} and ZayavkaAdd.Prinyat = 'false'", con);
            SqlDataReader zayav = query2.ExecuteReader();
            while (zayav.Read())
            {
                dgvZayav.Rows.Add(zayav["Fam"], zayav["DateZayavka"], zayav["Obor"], zayav["Prinyat"], zayav["NamePlace"], zayav["IdAdd"]);
            }
            con.Close();
        }

        private void btnShowZ_Click(object sender, EventArgs e)
        {
            cmbPlace_SelectedIndexChanged(null, null);
        }

        private void btnAddObor_Click(object sender, EventArgs e)
        {
            FormAddObor frm = new FormAddObor();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
                con.Open();
                SqlCommand query = new SqlCommand($@"Insert into Oborud values('{frm.tbxName.Text}','{frm.tbxSerNom.Text}',
{idPlaceLabel1.Text},'{DateTime.Now.ToString("MM.dd.yyyy")}','{frm.tbxOpis.Text}','false', null)",con);
                query.ExecuteNonQuery();
                con.Close();
                dgvObor.Rows.Clear();
                dgvZayav.Rows.Clear();
                FormAdmin_Load(null,null);
            }
        }

        private void btnEditObor_Click(object sender, EventArgs e)
        {
            string idobor = "-1";
            try
            {
                idobor = dgvObor.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Для редактирования выделите элемент в таблице!", "Внимание!");
                return;
            }
            FormEditObor frm = new FormEditObor();
            frm.oborudBindingSource.Filter = $"IdObor = {idobor}";
            if(frm.ShowDialog()== DialogResult.OK)
            {
                dgvObor.Rows.Clear();
                dgvZayav.Rows.Clear();
                FormAdmin_Load(null, null);
            }
        }

        private void btnSpravka_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\NPPKSpravka.chm");
        }
    }
}
