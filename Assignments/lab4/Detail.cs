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
    public partial class Detail : UserControl
    {
        private string product_num;

        public string numb
        {
            get { return product_num; }
            set { product_num = value; label3.Text = value; }
        }
        private string Pname;

        public string name
        {
            get { return Pname; }
            set { Pname = value; label8.Text = value; }
        }

        private int Product_InvNum;

        public int ProductInvNum
        {
            get { return Product_InvNum; }
            set { Product_InvNum = value; label6.Text = Convert.ToString(value); }
        }

        private int Pcount;

        public int count
        {
            get { return Pcount; }
            set { Pcount = value; label11.Text = Convert.ToString(value); }
        }

        private double Pprice;

        public double price
        {
            get { return Pprice; }
            set { Pprice = value; label10.Text = Convert.ToString(value); }
        }

        private DateTime product_Date;
        public DateTime ProductDate
        {
            get { return product_Date; }
            set { product_Date = value; label4.Text = Convert.ToString(value); }
        }


       

        public Detail()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
