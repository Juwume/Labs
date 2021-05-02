using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Maket
{
    public partial class DepFizForm : Form
    {
        private string dbPath = "C:\\Users\\makss\\OneDrive\\Документы\\Малый_банк.mdb";
        public DepFizForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            GeneralMenu menu = new GeneralMenu();
            menu.Show();
            this.Close();
        }

        private void DepFizForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.Физические_лица". При необходимости она может быть перемещена или удалена.
            this.физические_лицаTableAdapter.Fill(this.smallBankDataSet.Физические_лица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.Вклады". При необходимости она может быть перемещена или удалена.
            this.вкладыTableAdapter.Fill(this.smallBankDataSet.Вклады);

        }

        private void IdComboBox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + dbPath;
            OleDbConnection dbase = new OleDbConnection(connectionString);
            dbase.Open();

            string query = "SELECT [Фамилия], [Имя], [Отчество] FROM [Физические лица] WHERE [ID клиента] = " + IdComboBox.Text;
            OleDbCommand dbcom = new OleDbCommand(query);
            dbcom.Connection = dbase;
            OleDbDataReader reader = dbcom.ExecuteReader();
            reader.Read();

            
            MessageBox.Show(reader["Фамилия"].ToString());
            
        }
    }
}
