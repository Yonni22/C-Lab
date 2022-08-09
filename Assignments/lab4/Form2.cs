using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab4
{
    public partial class form : Form
    {
        public string username { get; set; }
        public form(String user)
        {
            InitializeComponent();
            label7.Text = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex("^[a-z]{2,5}$"); // $ - end of string //Regex regex = new Regex(@"^[a-z] {2}$");
            bool result = regex.IsMatch(objectname.Text);                                            // the @ is to check email, its outside b/c its needed // to check .com use . outside then ()
            //string g = result.ToString();
            if (result == false)
            {

                O.SetError(objectname, "can only be char and can't be empty");
            }

            try
            {
                if (string.IsNullOrEmpty(number.Text))
                {
                    N.SetError(number, "Required!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (string.IsNullOrEmpty(price.Text))
            {
                P.SetError(price, "Required");
            }
            if (string.IsNullOrEmpty(price.Text))
            {
                I.SetError(inventory, "Required");
            }
            if (string.IsNullOrEmpty(price.Text))
            {
                C.SetError(count, "Required");
            }
            if (!string.IsNullOrEmpty(number.Text) && !string.IsNullOrEmpty(count.Text) && !string.IsNullOrEmpty(inventory.Text) && result == true)
            {
                string message = " ";
                foreach (var item in Chk.CheckedItems)
                {
                    message = message + item.ToString();
                    MessageBox.Show(message);
                }
                bool b1 = radioButton1.Checked;
                if (b1)
                    MessageBox.Show("Simple");
                bool b2 = radioButton2.Checked;
                if (b2)
                    MessageBox.Show("Variable products");



                Class1 c = new Class1
                {
                    number = number.Text,
                    inventory = inventory.Text,
                    objectname = objectname.Text,
                    count = count.Text,
                    price = price.Text,
                    isavaliable = isavalaible.Checked,

                };
                //MessageBox.Show("saved");
                c.save();
                DisplaysTable.DataSource = null;
                DisplaysTable.DataSource = Class1.getall();

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
