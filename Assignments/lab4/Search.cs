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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = Class1.findone(textSearch.Text);

            if (product == null)
            {
                MessageBox.Show("nothing is entered");
            }
            else
            {
                MessageBox.Show($"product foiound ! \n nme: {product.objectname}");
            }

            


            

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
