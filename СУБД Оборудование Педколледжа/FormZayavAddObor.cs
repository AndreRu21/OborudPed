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
using Word = Microsoft.Office.Interop.Word;

namespace СУБД_Оборудование_Педколледжа
{
    public partial class FormZayavAddObor : Form
    {
        public FormZayavAddObor()
        {
            InitializeComponent();
        }

       

        private void FormAddObor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oborudPedDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillByForm(this.oborudPedDataSet.Users);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbxObor.Text == "")
            {
                MessageBox.Show("Поле с названием не может быть пустым!","Внимание!");
                return;
            }
            DataRowView drv = (DataRowView)bsUsers.Current;
            string iduser = drv["IDuser"].ToString();
            string idplace = drv["IdPlace"].ToString();
            string date = DateTime.Now.ToString("MM.dd.yyyy");
            SqlConnection con = new SqlConnection(Properties.Settings.Default.OborudPedConnectionString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Insert into ZayavkaAdd values ({iduser},'{date}','{tbxObor.Text}','false',{idplace})",con);
            query.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Заявка успешно создана!", "Внимание!");
            this.Close();
        }

        private void btnFormDoc_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsUsers.Current;
            string date = DateTime.Now.ToShortDateString();
            string place = drv["NamePlace"].ToString();
            Word.Application wordapp = new Word.Application();
            wordapp.Visible = true;
            Word.Document doc = wordapp.Documents.Open(Application.StartupPath + "\\Заявка на добавление.docx", null, true);

            Word.Bookmarks WBmark = doc.Bookmarks; //закладки
            WBmark["Place"].Range.Text = place.ToLower();
            WBmark["Oborud"].Range.Text = tbxObor.Text;
            WBmark["Date"].Range.Text = date;
        }
    }
}
