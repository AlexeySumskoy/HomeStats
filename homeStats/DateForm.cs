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
            this.byDate.MouseClick += homeStats_MouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table= dal.getByDate(dateOne.Value.Date.ToString("yyyy / MM / dd"), dateTwo.Value.Date.ToString("yyyy / MM / dd"));
            byDate.DataSource = table;
            label5.Text = Convert.ToString(dal.cost(table)) + " Гривен";
            dal.change(byDate);
        }
        private void homeStats_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int ind = byDate.SelectedCells[0].RowIndex;
                string name = (string)this.byDate.CurrentRow.Cells[1].Value;
                DateTime data = (DateTime)this.byDate.CurrentRow.Cells[0].Value;
                string product = (string)this.byDate.CurrentRow.Cells[2].Value;
                Check form = new Check();
                form.first = this;
                form.Show();
                form.open(ind, name, data, product);
            }
        }
        public void delete(int ind, string name, DateTime data, string product)
        {
            try
            {
                dal.delete(name, data, product);
                byDate.Rows.RemoveAt(ind);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


    }
}
