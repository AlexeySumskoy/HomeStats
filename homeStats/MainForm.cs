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
    public partial class MainForm : Form
    {
        Statistic dal = null;        
        string[] s = new string[2];
        StringBuilder result = null;
        Function f=null;
        bool b = false;
        double d;
        Dynamic prod = null;
        Dynamic example = null;
        dynamicConteiner conteiner = null;
        object[] obj;
        object[] obj1;
        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += main_KeyDown;
            this.KeyPreview = true;
            this.StartPosition =System.Windows.Forms.FormStartPosition.CenterScreen;            
            string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
dal = new Statistic(cnStr);
example = new Dynamic();
conteiner = new dynamicConteiner();
result = new StringBuilder();
            nameOfUser.KeyDown += type_KeyDown;
this.nameOfProduct.SelectedValueChanged += ComboBox_SelectedValueChanged;
dal.selectProduct(nameOfProduct);
example.givedate = date;
example.givePrice = price;
example.giveproduct = nameOfProduct;
example.giveproductType = nameOfUser;
example.giveQantity = qantity;
conteiner.add(example);
prod = new Dynamic();
prod.givedate = date;
prod.givePrice = price;
prod.giveproduct = nameOfProduct;
prod.giveproductType = nameOfUser;
prod.giveQantity = qantity;
obj = new object[nameOfProduct.Items.Count];
obj1 = new object[nameOfUser.Items.Count];
nameOfProduct.Items.CopyTo(obj, 0);
nameOfUser.Items.CopyTo(obj1, 0);
 trial.Select();
}


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            result.Append("0");
            calculate.Text = result.ToString();             
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            result.Append("1");
            calculate.Text = result.ToString();     
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            result.Append("2");
            calculate.Text = result.ToString();      
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            result.Append("3");
            calculate.Text = result.ToString();      
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            result.Append("4");
            calculate.Text = result.ToString();      
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            result.Append("5");
            calculate.Text = result.ToString();      
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            result.Append("6");
            calculate.Text = result.ToString();   
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            result.Append("7");
            calculate.Text = result.ToString();   
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            result.Append("8");
            calculate.Text = result.ToString();   
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            result.Append("9");
            calculate.Text = result.ToString();   
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                f.setB(Convert.ToDouble(calculate.Text));
                d = f.calculate();
                f = new Mult();
                f.setA(d);
                result.Clear();
                calculate.Text = result.ToString();
            }
            else
            {
                f = new Mult();
                f.setA(Convert.ToDouble(calculate.Text));
                result.Clear();
                calculate.Text = result.ToString();
                b = true;
            }
        }

        private void buttonRazr_Click(object sender, EventArgs e)
        {
            result.Append(",");
            calculate.Text = result.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Clear();
            calculate.Text = result.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                f.setB(Convert.ToDouble(calculate.Text));
                d = f.calculate();
                f = new Div();
                f.setA(d);
                result.Clear();
                calculate.Text = result.ToString();
            }
            else
            {
                f = new Div();
                f.setA(Convert.ToDouble(calculate.Text));
                result.Clear();
                calculate.Text = result.ToString(); ;
                b = true;
            }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                f.setB(Convert.ToDouble(calculate.Text));
                d = f.calculate();
                f = new Minus();
                f.setA(d);
                result.Clear();
                calculate.Text = result.ToString();
            }
            else
            {
                f = new Minus();
                f.setA(Convert.ToDouble(calculate.Text));
                result.Clear();
                calculate.Text = result.ToString();
                b = true;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                f.setB(Convert.ToDouble(calculate.Text));
                d = f.calculate();
                f = new Sum();
                f.setA(d);
                result.Clear();
                calculate.Text = result.ToString();
            }
            else
            {
                f = new Sum();
                f.setA(Convert.ToDouble(calculate.Text));
                result.Clear();
                calculate.Text = result.ToString();
                b = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            f.setB(Convert.ToDouble(calculate.Text));
            result.Clear();
          calculate.Text=Convert.ToString(f.calculate());
          b =false;
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (result.Length == 0)
                return;
           result.Remove(result.Length-1,1);
           calculate.Text = result.ToString();
        }

       

        private void button1_Click_2(object sender, EventArgs e)
        {
            Check form = new Check();
            form.second = this;
            form.Show();
            form.insert();            


        }
        public void insert() {
            conteiner.insert(this);
            if (conteiner.getCart().Count != 0) { return; }
            prod = example;
            conteiner.add(example);
            this.Controls.Add(example.givedate);
            this.Controls.Add(example.givePrice);
            this.Controls.Add(example.giveproduct);
            this.Controls.Add(example.giveproductType);
            this.Controls.Add(example.giveQantity);
            this.nameOfProduct.SelectedItem = null;
            this.nameOfUser.SelectedItem = null;
            price.Text = "";
            qantity.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (nameOfUser.FindString(trial.Text) != -1)
                return;
            conteiner.changeType(trial.Text);           
            obj1 = new object[nameOfUser.Items.Count];            
            nameOfUser.Items.CopyTo(obj1, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nameOfProduct.FindString(trial.Text) != -1)
                return;
            conteiner.changeProduct(trial.Text);
            obj = new object[nameOfProduct.Items.Count];            
            nameOfProduct.Items.CopyTo(obj, 0);
            conteiner.insertAllTypes();
        }
        private void type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Home)
            {
                ComboBox cb = (ComboBox)sender;
                dal.selectName(cb);
            }
        }
        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (conteiner.getCart()[conteiner.getCart().Count - 1].giveproductType.SelectedItem == null || conteiner.getCart()[conteiner.getCart().Count - 1].giveproduct.SelectedItem == null || conteiner.getCart()[conteiner.getCart().Count - 1].givePrice.Text == "" || conteiner.getCart()[conteiner.getCart().Count - 1].giveQantity.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                    //получаем ссылку на кнопку, на которую мы нажали
                    DateTimePicker d = conteiner.getCart()[conteiner.getCart().Count - 1].givedate;
                    ComboBox user = conteiner.getCart()[conteiner.getCart().Count - 1].giveproductType;
                    ComboBox product = conteiner.getCart()[conteiner.getCart().Count - 1].giveproduct;
                    TextBox p = conteiner.getCart()[conteiner.getCart().Count - 1].givePrice;
                    TextBox q = conteiner.getCart()[conteiner.getCart().Count - 1].giveQantity;
                    //Создаем новую кнопку
                    DateTimePicker tempDate = new DateTimePicker();
                    tempDate.Value = d.Value;
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
                    tempuser.Location = new Point(user.Location.X, tempDate.Location.Y);
                    tempprod.Location = new Point(product.Location.X, tempDate.Location.Y);
                    tempp.Location = new Point(p.Location.X, tempDate.Location.Y);
                    tempq.Location = new Point(q.Location.X, tempDate.Location.Y);
                    //Добавляем событие нажатия на новую кнопку 
                    //(то же что и при нажатии на исходную)                    
                    tempuser.Click += new EventHandler(nameOfUser_Click);
                tempuser.KeyDown += type_KeyDown;
                    tempprod.SelectedValueChanged += ComboBox_SelectedValueChanged;
                tempprod.Click += nameOfProduct_Click;
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
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                button3.Select();
            }
            if (e.KeyData == Keys.Left)
            {
                trial.Select();
            }
            if (e.KeyData == Keys.Enter)
            {
                nameOfUser.Items.Add(trial.Text);
            }
            
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                button2.Select();
            }
            if (e.KeyData == Keys.Enter)
            {
                nameOfProduct.Items.Add(trial.Text);
            }
            
            
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                qantity.Select();
            }
            if (e.KeyData == Keys.Left)
            {
                nameOfProduct.Select();
                nameOfProduct.DroppedDown = true;
            }
        }

        private void cuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                price.Select();
            }
            if (e.KeyData == Keys.Right)
            {
                addButton.Select();
            }
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                qantity.Select();
            }
        }

        private void nameOfUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                nameOfProduct.Select();
                nameOfProduct.DroppedDown = true;
            }
        }

        private void nameOfProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                price.Select(); ;
            }
            if (e.KeyData == Keys.Left)
            {
                nameOfUser.Select();
                nameOfUser.DroppedDown = true;
            }
        }       

        private void nameOfUser_Click(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            box.DroppedDown = true;
        }

        private void nameOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                if (f is Sum)
                {
                    double a = f.getA();
                    f = new PlusPercent();
                    f.setA(a);
                    f.setB(Convert.ToDouble(calculate.Text));
                    calculate.Text = Convert.ToString(f.calculate());
                    b = false;
                }
                else
                    if (f is Minus)
                    {
                        double a = f.getA();
                        f = new MinusPercent();
                        f.setA(a);
                        f.setB(Convert.ToDouble(calculate.Text));
                        calculate.Text = Convert.ToString(f.calculate());
                        b = false;
                    }
                    else { MessageBox.Show("Выберите + или -"); }
            }
            else
            {
                MessageBox.Show("ВВедите первый операнд");
            }
        }
        private void ComboBox_SelectedValueChanged(object sender, System.EventArgs e)
        {            
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem == null) { return; }
            string name = cb.SelectedItem.ToString();
            List<string> list = dal.changeProdType(name);
            int i = conteiner.getCart().FindIndex(x => x.giveproduct == cb);
            if (list.Count != 0)
            {
                conteiner.getCart()[i].giveproductType.Items.Clear();
                foreach (string s in list)
                {
                    conteiner.getCart()[i].giveproductType.Items.Add(s);
                }
            }
            else {
                dal.selectName (conteiner.getCart()[i].giveproductType);
                 }
        }

        private void поПользователюToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateForm form = new DateForm();
            form.Show();
        }

        private void ByprodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.Show();
        }

        private void financesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FinancesForm form = new FinancesForm();
            form.Show();
        }

        private void GrapgToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphic form = new Graphic();
            form.Show();
        }

        private void nameOfProduct_Click(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.DroppedDown = true;
        }
        
    }
    
        }
    

