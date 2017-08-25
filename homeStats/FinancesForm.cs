using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stats;
using System.Data.OleDb;
using System.Configuration;
namespace homeStats
{
    public partial class FinancesForm : Form
    {
        Statistic dal = null; 
        public FinancesForm()
        {
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
            dal = new Statistic(cnStr);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dal.insert(dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "На данный месяц баланс " + dal.moneyNow().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dal.count(dateTimePicker2.Value, dateTimePicker3.Value,label6,label5,dataGridView1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
