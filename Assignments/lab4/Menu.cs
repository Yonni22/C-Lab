using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4;

namespace lab4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);
            ViewPanel.BackColor = Color.CadetBlue;
            foreach (Control item in flowLayoutPanel1.Controls.OfType<UserControl5>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(item);
            }
            foreach (var item in Class1.getall())
            {
                UserControl5 card = new UserControl5();
                card.Product = item.objectname;
                card.ProductQuantity = Convert.ToInt32(item.count);
                card.num = Convert.ToInt32(item.number);
                
                //card.Click += (object sender1, EventArgs eve) =>
                //{
                  //    MessageBox.Show( "Name: " + item.objectname + "\nInventory: " + item.inventory + "\nQuantity: " + item.count + "\nPrice: " + item.price + "\nNumber: " + item.number + "\nDate: " + item.date);
                                   
                //};
                card.Show();
                flowLayoutPanel1.Controls.Add(card);
                card.Description.DoubleClick += (object sender1, EventArgs eve) =>
                {
                    this.flowLayoutPanel1.Controls.Clear();

                    Detail description = new Detail();
                    description.name = item.objectname;
                    description.numb = item.number;
                    description.ProductInvNum = Convert.ToInt32(item.inventory);
                    description.ProductDate = item.date;
                    
                    description.count = Convert.ToInt32(item.count);
                    description.price = Convert.ToInt32(item.price);
                    description.Show();
                    flowLayoutPanel1.Controls.Add(description);

                };
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);

            foreach (var item in Class1.getall())
            {
                if (this.flowLayoutPanel1.Controls.Count > 0)
                    this.flowLayoutPanel1.Controls.RemoveAt(0);
            }

            ViewPanel.BackColor = Color.Coral;
            form product = new form("");
            product.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(product);
            this.flowLayoutPanel1.Tag = product;
            product.Show();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);

            foreach (var item in Class1.getall())
            {
                if (this.flowLayoutPanel1.Controls.Count > 0)
                    this.flowLayoutPanel1.Controls.RemoveAt(0);
            }
            ViewPanel.BackColor = Color.DarkSlateGray;
            UpdateProducts updateProducts = new UpdateProducts();
            updateProducts.TopLevel = false;
            flowLayoutPanel1.Controls.Add(updateProducts);
            flowLayoutPanel1.Tag = updateProducts;
            updateProducts.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);
            foreach (var item in Class1.getall())
            {
                if (this.flowLayoutPanel1.Controls.Count > 0)
                    this.flowLayoutPanel1.Controls.RemoveAt(0);
            }

            ViewPanel.BackColor = Color.DarkCyan;
            Search search = new Search();
            search.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(search);
            this.flowLayoutPanel1.Tag = search;
            search.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
