using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LAB3;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {


                ProductClass p = new ProductClass
                {
                    
                    number = String.IsNullOrEmpty(textBox1.Text) ? 0 : int.Parse(textBox1.Text),
                    inventorynumber = String.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text),
                    Objectname = (textBox5.Text),
                    price = String.IsNullOrEmpty(textBox3.Text) ? 0 : int.Parse(textBox3.Text),
                    Count = String.IsNullOrEmpty(textBox4.Text) ? 0 : int.Parse(textBox4.Text),
                    date = dateTimePicker1.Value,
                    isavailable = checkBox1.Checked


                };
                ProductClass s = new ProductClass
                {
                    
                };
                Regex re = new Regex(@"^[0-9]{3}$");
                bool permit = true;

                if (p.number.ToString().Length < 3)
                {
                    errorProvider1.SetError(textBox1, "Error");
                    permit = false;
                }
                if (!re.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Pattern Incorrect");
                    permit = false;
                }
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Name is required");
                }
                if  (p.inventorynumber.ToString().Length < 3)
                {
                    errorProvider1.SetError(textBox2, "Error");
                 }
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Name is required");
                }
                if (p.Objectname.ToString().Length < 3)
                {
                    MessageBox.Show("d");
                }
                if (String.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Name is required");
                }
                if (p.price.ToString().Length < 3)
                {
                    MessageBox.Show("za");
                }
                if (String.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Name is required");
                }
                if (p.number.ToString().Length < 3)
                {
                    MessageBox.Show("a");
                    permit = false;
                }
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Name is required");
                }

                if (p.Count.ToString().Length < 3)
                {
                    MessageBox.Show("a");
                    permit = false;
                }
                if (String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Name is required");
                }
                if (permit) p.Save();
                //ProductClass.GetAllProducts();
                DG.DataSource = null;
                DG.DataSource = ProductClass.GetAllProducts();
                                
                MessageBox.Show($"Product {p.Objectname} \nId: {p.inventorynumber} " +
                    $"\nPrice: {p.price} \nQuantity: {p.Count}\n Date: {p.date}\n{p.number}");

                
                


                //String name =  textBox1.Text;
                //MessageBox.Show($"Hello {name}");
                //MessageBox.Show("Hello " + name);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no item was added");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DG.DataSource = null;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string checkedItems = "";
            foreach(var item in chk.CheckedItems)
            {
                //checkedItems += item.ToString();
                checkedItems = checkedItems + item.ToString() + " ";
            }
            MessageBox.Show(checkedItems);
        }
    }
}
