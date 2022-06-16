using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace СУБД_Оборудование_Педколледжа
{
    public partial class FormSpisObor : Form
    {
        public FormSpisObor()
        {
            InitializeComponent();
        }

      

        private void FormSpisObor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillByForm(this.oborudPedDataSet.Users);
            // TODO: This line of code loads data into the 'oborudPedDataSet.Oborud' table. You can move, or remove it, as needed.
            this.oborudTableAdapter.Fill(this.oborudPedDataSet.Oborud);

        }

        private void btnFormDoc_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsUsers.Current;
            string date = DateTime.Now.ToShortDateString();
            string place = drv["NamePlace"].ToString();
            Word.Application wordapp = new Word.Application();
            wordapp.Visible = true;
            Word.Document doc = wordapp.Documents.Open(Application.StartupPath + "\\Заявка на списание.docx", null, true);

            Word.Bookmarks WBmark = doc.Bookmarks; //закладки
            WBmark["Place"].Range.Text = place.ToLower();
            WBmark["Oborud"].Range.Text = nazvLabel1.Text;
            WBmark["Date"].Range.Text = date;
            WBmark["Prichin"].Range.Text = tbxPrichin.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsUsers.Current;
            DataRowView drvObor = (DataRowView)bsOborud.Current;
            string iduser = drv["IDuser"].ToString();
            string idplace = drv["IdPlace"].ToString();
            string idoborud = drvObor["IdObor"].ToString();
            string date = DateTime.Now.ToString("MM.dd.yyyy");
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Insert into ZayavkaSpis values ({iduser},{idoborud},'{date}','{tbxPrichin.Text}','false',{idplace})", con);
            query.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Заявка успешно создана!", "Внимание!");
            this.Close();
        }
    }
}
