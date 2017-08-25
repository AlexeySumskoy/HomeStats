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
using System.Configuration;
namespace homeStats
{
    public partial class DateForm : Form
    {
        Statistic dal = null;
        public DateForm()
        {
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString; 
            // Создать объект доступа к данным.
            dal = new Statistic(cnStr);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table= dal.getByDate(dateOne.Value.Date.ToString("yyyy / MM / dd"), dateTwo.Value.Date.ToString("yyyy / MM / dd"));
            byDate.DataSource = table;
            label5.Text = Convert.ToString(dal.cost(table)) + " Гривен";
            dal.change(byDate);
        }

        
    }
}
