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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            form screen = new form(" ");
            screen.MdiParent = this;
            screen.Show();
        }

        private void dispalyProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Display screen = new Display();
            screen.MdiParent= this;
            screen.Show();

        }

        private void searchProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
           Search s = new Search();
           s.MdiParent = this;
           s.Show();
        }
    }
}
