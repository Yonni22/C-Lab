using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;    

            if(username == "admin" && password == "password")
            {
                form f = new form(username);
                MessageBox.Show("Valid login");
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid");
            
        }
    }
}
