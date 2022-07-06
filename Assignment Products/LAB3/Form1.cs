using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    number = int.Parse(textBox1.Text),
                    inventorynumber = int.Parse(textBox2.Text),
                    Objectname = (textBox5.Text),
                    price = double.Parse(textBox3.Text),
                    Count = int.Parse(textBox4.Text),
                    date = dateTimePicker1.Value
                    };

                
                                
                MessageBox.Show($"Product {p.Objectname} \nId: {p.inventorynumber} \nPrice: {p.price} \nQuantity: {p.Count}\n Date: {p.date}\n{p.number}");



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
    }
}
