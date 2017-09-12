using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stats;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
namespace homeStats
{
   public class Dynamic
    {
        private DateTimePicker date;
        public DateTimePicker givedate {
            get { return date; }
            set{date=value;}
        }
        private ComboBox product;
        public ComboBox giveproduct
        {
            get { return product; }
            set { product = value; }
        }
        private ComboBox productType;
        public ComboBox giveproductType
        {
            get { return productType; }
            set { productType = value; }
        }
        private TextBox price;
        public TextBox givePrice
        {
            get { return price; }
            set { price = value; }
        }
        private TextBox qantity;
        public TextBox giveQantity
        {
            get { return qantity; }
            set { qantity = value; }
        }
    }
   public class dynamicConteiner {
       private List<Dynamic> cart;
       private Statistic dal;
       public dynamicConteiner() { 
       cart =new List<Dynamic>();
       string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString;
       dal = new Statistic(cnStr);
       }
        public List<Dynamic> getCart() { return cart; }
       public void add(Dynamic d) {
       cart.Add(d);}
       public void insert(MainForm main)
       {

            for (int i = cart.Count - 1; i >= 0; i--)
            {
                if (cart[i].givePrice.Text == "" && cart[i].giveQantity.Text == "" && cart[i].giveproductType.SelectedItem == null && cart[i].giveproduct.SelectedItem == null)
                {
                    main.Controls.Remove(cart[i].givedate);
                    main.Controls.Remove(cart[i].givePrice);
                    main.Controls.Remove(cart[i].giveproduct);
                    main.Controls.Remove(cart[i].giveproductType);
                    main.Controls.Remove(cart[i].giveQantity);
                    cart.RemoveAt(i);
                }
                else
                {
                    if (cart[i].givePrice.Text == "" || cart[i].giveQantity.Text == "" || cart[i].giveproductType.SelectedItem == null || cart[i].giveproduct.SelectedItem == null)
                    {
                        MessageBox.Show("Заполните поля");
                        return;
                    }
                    else
                    {
                        cart[i].givePrice.Text = cart[i].givePrice.Text.Replace(".", ",");
                        cart[i].giveQantity.Text = cart[i].giveQantity.Text.Replace(".", ",");
                        try
                        {
                            dal.insert(cart[i].giveproductType.SelectedItem.ToString(), cart[i].givedate.Value, cart[i].giveproduct.SelectedItem.ToString(), Convert.ToDouble(cart[i].givePrice.Text), Convert.ToDouble(cart[i].giveQantity.Text));
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return;
                        }
                        main.Controls.Remove(cart[i].givedate);
                        main.Controls.Remove(cart[i].givePrice);
                        main.Controls.Remove(cart[i].giveproduct);
                        main.Controls.Remove(cart[i].giveproductType);
                        main.Controls.Remove(cart[i].giveQantity);
                        cart.RemoveAt(i);
                    }      
                }
                               
            }
       }
       public void changeType(string s) {
           foreach (Dynamic d in cart) {
               d.giveproductType.Items.Add(s);
           }
       }
       public void changeProduct(string s)
       {
           foreach (Dynamic d in cart)
           {
               d.giveproduct.Items.Add(s);
           }
       }
        public void insertAllTypes()
        {
            dal.selectName(cart[cart.Count - 1].giveproductType);
        }
       
   }
   public class ComboboxConteiner {
       private List<ComboBox> comboList;
       private Statistic dal;
       public ComboboxConteiner() {
           comboList = new List<ComboBox>();
           string cnStr = ConfigurationManager.ConnectionStrings["Statistic"].ConnectionString; 
           dal = new Statistic(cnStr);
       }
       public void add(ComboBox c) {
           comboList.Add(c);
       }
       public DataTable count(DateTime date1, DateTime date2)
       {
           return dal.countProduct(comboList, date1, date2);           
       }
       public void clear(Product p) {
           for (int i = 1; i < comboList.Count; i++)
           {
               p.Controls.Remove(comboList[i]);               
           }
           comboList.Clear();
       }
   }
}
