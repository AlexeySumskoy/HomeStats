using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeStats
{
    public partial class Check : Form
    {
        private int i;
        string name;
        DateTime date;
        string product;
        public DateForm first;
        public MainForm second;
        public Check()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void insert() {
            Label label = new Label();
            label.Location = new Point(125, 13);
            label.Width = 500;
            label.Height = 13;
            string s = "Вы уверены, что хотите обновит БД ?";
            label.Text = s;
            Button yes = new Button();
            yes.Location = new Point(123, 51);
            yes.Text = "Да";
            Button no = new Button();
            no.Location = new Point(225, 51);
            no.Text = "Нет";
            no.Click += new EventHandler(noButton_Click);
            yes.Click += new EventHandler(insert_Click);
            this.Controls.Add(label);
            this.Controls.Add(yes);
            this.Controls.Add(no);
        }
        public void save()
        {
            Label label = new Label();
            label.Location = new Point(125, 13);
            label.Width = 500;
            label.Height = 13;
            string s = "сохранить бд в google drive ?";
            label.Text = s;
            Button yes = new Button();
            yes.Location = new Point(123, 51);
            yes.Text = "Да";
            Button no = new Button();
            no.Location = new Point(225, 51);
            no.Text = "Нет";
            no.Click += new EventHandler(no_Click);
            yes.Click += new EventHandler(yes_Click);
            this.Controls.Add(label);
            this.Controls.Add(yes);
            this.Controls.Add(no);
        }
        private void yes_Click(object sender, EventArgs e)
        {

            try
            {
                Drive drive = new Drive();
                drive.UploadDb();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void yesButton_Click(object sender, EventArgs e)
        {
            
            first.delete(i, name, date, product);
            this.Close();

        }
        private void insert_Click(object sender, EventArgs e)
        {

            second.insert();
            this.Close();
            Check check = new Check();
            check.Show();
            check.save();

        }
        public void open(int ind, string name, DateTime date, string product) {
            Label label = new Label();
            label.Location = new Point(100, 13);
            label.Width = 500;
            label.Height = 13;
            string s ="Удалить строку" + " " + date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString() + " " + name + " " + product + " ?";
            label.Text = s; 
            Button yes = new Button();
            yes.Location = new Point(123, 51);
            yes.Text = "Да";
            Button no = new Button();
            no.Location = new Point(225, 51);
            no.Text = "Нет";
            no.Click += new EventHandler(noButton_Click);
            yes.Click += new EventHandler(yesButton_Click);            
            i = ind;
            this.name = name;
            this.date = date;
            this.product = product;
            this.Controls.Add(label);
            this.Controls.Add(yes);
            this.Controls.Add(no);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
