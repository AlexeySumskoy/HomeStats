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
    public partial class Form1 : Form
    {
        Statistic dal = null;        
        public Form1()
        {
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
            // Создать объект доступа к данным.
            dal = new Statistic(cnStr);
            DataTable table = new DataTable();
            dal.selectName(nameOfUser);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t=new DataTable();
            t= dal.GetAllByName(nameOfUser.SelectedItem.ToString(), dateOne.Value, dateTwo.Value);
            byName.DataSource=t;
            label1.Text = "На вид продукции " + nameOfUser.SelectedItem.ToString() + " за данный период потрачено " + Convert.ToString(dal.cost(t)) + " Гривен";            
        }
       
    }
}
