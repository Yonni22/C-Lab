﻿using System;
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

        private int Product_InvNum;

        public int ProductInvNum
        {
            get { return Product_InvNum; }
            set { Product_InvNum = value; Inventoryl.Text += value; }
        }

        private int Product_Quantity;

        public int ProductQuantity
        {
            get { return Product_Quantity; }
            set { Product_Quantity = value; Quantityl.Text += value; }
        }

        private double product_Price;

        public double ProductPrice
        {
            get { return product_Price; }
            set { product_Price = value; Pricel.Text += value; }
        }

        public UserControl5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}