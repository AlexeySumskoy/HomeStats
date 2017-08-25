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

namespace homeStats
{
    public partial class TestForm : Form
    {
        Statistic dal = null;
        Dynamic prod = null;
        Dynamic example = null;
        dynamicConteiner conteiner = null;
        object[] obj;
        object[] obj1;
        public TestForm()
        {
            InitializeComponent();
            string cnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Homeprogram\Statistic.accdb;Persist Security Info=False;";
            dal = new Statistic(cnStr);
            homeStats.DataSource = (DataTable)dal.GetAllInventory();
        }

        

        

        

        private void nameOfProduct_Click(object sender, EventArgs e)
        {
            ComboBox box=(ComboBox)sender;
            box.DroppedDown = true;
            if (box == prod.giveproduct)
            {                
                //получаем ссылку на кнопку, на которую мы нажали
                DateTimePicker d = prod.givedate;
                ComboBox user = prod.giveproductType;
                ComboBox product = prod.giveproduct;
                TextBox p = prod.givePrice;
                TextBox q = prod.giveQantity;
                //Создаем новую кнопку
                DateTimePicker tempDate = new DateTimePicker();
                tempDate.Width = d.Width;
                tempDate.Height = d.Height;
                ComboBox tempuser = new ComboBox();
                tempuser.Height = user.Height;
                tempuser.Width = user.Width;
                tempuser.Items.AddRange(obj1);
                ComboBox tempprod = new ComboBox();
                tempprod.Width = product.Width;
                tempprod.Height = product.Height;
                tempprod.Items.AddRange(obj);
                TextBox tempp = new TextBox();
                tempp.Width = p.Width;
                tempp.Height = p.Height;
                TextBox tempq = new TextBox();
                tempq.Width = q.Width;
                tempq.Height = q.Height;
                //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
                tempDate.Location = new Point(d.Location.X, d.Location.Y + d.Height + 3);
                tempuser.Location = new Point(user.Location.X, user.Location.Y + user.Height + 2);
                tempprod.Location = new Point(product.Location.X, product.Location.Y + product.Height + 2);
                tempp.Location = new Point(p.Location.X, p.Location.Y + p.Height + 3);
                tempq.Location = new Point(q.Location.X, q.Location.Y + q.Height + 3);
                //Добавляем событие нажатия на новую кнопку 
                //(то же что и при нажатии на исходную)
                tempprod.Click += new EventHandler(nameOfProduct_Click);
                tempuser.Click += new EventHandler(nameOfUser_Click);
                //Добавляем элемент на форму
                this.Controls.Add(tempDate);
                this.Controls.Add(tempuser);
                this.Controls.Add(tempprod);
                this.Controls.Add(tempp);
                this.Controls.Add(tempq);
                prod = new Dynamic();
                prod.givedate = tempDate;
                prod.givePrice = tempp;
                prod.giveproduct = tempprod;
                prod.giveproductType = tempuser;
                prod.giveQantity = tempq;
                conteiner.add(prod);
            }
        }

        private void nameOfUser_Click(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            box.DroppedDown = true;

        }

        

        private void homeStats_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int ind = homeStats.SelectedCells[0].RowIndex;
                string name = (string)this.homeStats.CurrentRow.Cells[1].Value;
                DateTime data = (DateTime)this.homeStats.CurrentRow.Cells[0].Value;
                string product = (string)this.homeStats.CurrentRow.Cells[2].Value;
                Check form = new Check();
                form.first = this;
                form.Show();
                form.open(ind, name, data, product);
            }
        }
        public void delete(int ind, string name, DateTime data, string product)
        {
            homeStats.Rows.RemoveAt(ind);
            dal.delete(name, data, product);
        }
    }
}
