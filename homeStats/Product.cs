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
    public partial class Product : Form
    {
        Statistic dal = null;
        ComboboxConteiner conteiner;
        ComboBox box;
        object[] obj;
        public Product()
        {
            
            InitializeComponent();
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
            // Создать объект доступа к данным.
            dal = new Statistic(cnStr);
           
            dal.selectProduct(nameOfProduct);
            box = nameOfProduct;
            conteiner = new ComboboxConteiner();
            obj = new object[nameOfProduct.Items.Count];
            nameOfProduct.Items.CopyTo(obj, 0);
            conteiner.add(box);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           mainView.DataSource= conteiner.count(dateTimePicker1.Value, dateTimePicker2.Value);
            conteiner.clear(this);
            box = nameOfProduct;
            conteiner.add(box);
            this.nameOfProduct.SelectedItem = null;            
        }

        private void nameOfProduct_Click(object sender, EventArgs e)
        {
            ComboBox box1 = (ComboBox)sender;
            box1.DroppedDown = true;
            if (box1 == box) {
                ComboBox tempprod = new ComboBox();
                tempprod.Width = box1.Width;
                tempprod.Height = box1.Height;
                tempprod.Items.AddRange(obj);
                tempprod.Location = new Point(box1.Location.X, box1.Location.Y + box1.Height + 2);
                tempprod.Click += new EventHandler(nameOfProduct_Click);
                this.Controls.Add(tempprod);
                box  = tempprod;
                conteiner.add(tempprod);
            }
        }
    }
}
