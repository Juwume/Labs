using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
    public partial class GeneralMenu : Form
    {
        public GeneralMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
            this.Hide();
        }

        private void FormsButton_Click(object sender, EventArgs e)
        {
            FormsForm forms = new FormsForm();
            forms.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
            this.Hide();
        }
    }
}
