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
    public partial class Graphic : Form
    {
        Statistic dal = null;
        public Graphic()
        {
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
            // Создать объект доступа к данным.
            dal = new Statistic(cnStr);
            
            dal.selectName(nameOfUser);
            dal.selectProduct(nameOfProduct);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            g.DrawLine(Pens.Black, 0, 0, 0, 380);
            g.DrawLine(Pens.Black, 0, 380, 0x438, 380);

            if ((this.nameOfProduct.SelectedItem == null) && (this.nameOfUser.SelectedItem == null))
            {
                this.dal.drawMoney(g, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
                this.drawed.Text = "Потрачено за каждый месяц";
            }
            else if (this.nameOfUser.SelectedItem == null)
            {
                this.dal.drawProduct(g, this.nameOfProduct.SelectedItem.ToString(), this.dateTimePicker1.Value, this.dateTimePicker2.Value);
                this.drawed.Text = "Количество продукта " + this.nameOfProduct.SelectedItem.ToString();
                this.nameOfProduct.SelectedItem = null;
            }
            else
            {
                this.dal.drawBuyer(g, this.nameOfUser.SelectedItem.ToString(), this.dateTimePicker1.Value, this.dateTimePicker2.Value);
                this.drawed.Text = "Потрачено денег на " + this.nameOfUser.SelectedItem.ToString();
                this.nameOfUser.SelectedItem = null;
            }

        }
    }
}
