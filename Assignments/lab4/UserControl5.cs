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
    public partial class UserControl5 : UserControl
    {
        private string product_Name;

        public string Product
        {
            get { return product_Name; }
            set { product_Name = value; Namel.Text += value; }
        }
      

        
        private int number_;

        public int num
        {
            get { return number_; }
            set { number_ = value; Num.Text += value; }
        }

        
        private int Product_Quantity;

        public int ProductQuantity
        {
            get { return Product_Quantity; }
            set { Product_Quantity = value; Quantityl.Text += value; }
        }

        public UserControl5()
        {
            InitializeComponent();
        }
        public Panel Description
        {
            get { return panel1; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
