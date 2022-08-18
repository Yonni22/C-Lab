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
    public partial class UpdateProducts : Form
    {
        public UpdateProducts()
        {
            InitializeComponent();
        }
        Class1 updatedProduct = new Class1();
        Class1 productInList = new Class1();


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTxt_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            productInList = Class1.findone(SearchTxt.Text);
            if (updatedProduct == null)
            {
                MessageBox.Show("Product is not found.");
            }
            else if (productInList == null)
            {
                MessageBox.Show("No Product was added. Add Products first!");
            }
            else
            {
                QuaTxtB.Text = productInList.count.ToString();
                InvNumTxtB.Text = productInList.inventory.ToString();
                NumberTxtB.Text = productInList.number.ToString();
                ObjNameTxtB.Text = productInList.objectname;
                PrTxtB.Text = productInList.price.ToString();
                if (productInList.productType == "Variable")
                {
                    VariableRb.Checked = true;
                }
                else
                {
                    SimpleRb.Checked = true;
                }
            }

            List<Class1> productList = new List<Class1>();
            productList.Add(productInList);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productList;
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Regex rxNumber = new Regex(@"^[0-9]{5,10}$");
            Regex rxInventoryNumber = new Regex(@"^[0-9]{5,10}$");
            bool FlagChecker = true;
            errorProvider1.Clear();

            Class1 product = new Class1();
            if (rxNumber.IsMatch(NumberTxtB.Text))
            {
                updatedProduct.number = (NumberTxtB.Text);
            }
            else
            {
                FlagChecker = false;
                errorProvider1.SetError(NumberTxtB, "Please enter 5 or more digits.");
            }


            updatedProduct.date = dateTimePicker1.Value;


            if (rxInventoryNumber.IsMatch(InvNumTxtB.Text))
            {
                updatedProduct.inventory = (InvNumTxtB.Text);
            }
            else
            {
                FlagChecker = false;
                errorProvider1.SetError(InvNumTxtB, "Please enter 5 or more digits.");
            }


            for (int i = 0; i < (ObjNameTxtB.Text.Length); i++)
            {
                if (((ObjNameTxtB.Text[i] >= 'A' && ObjNameTxtB.Text[i] <= 'Z') || (ObjNameTxtB.Text[i] >= 'a' && ObjNameTxtB.Text[i] <= 'z') || (ObjNameTxtB.Text[i] >= '0' && ObjNameTxtB.Text[i] <= '9') || (ObjNameTxtB.Text[i] == ' ' || ObjNameTxtB.Text[i] == '_')) == false)
                {
                    FlagChecker = false;
                    errorProvider1.SetError(ObjNameTxtB, "Pleae enter only alphabets, numbers, space or/and an underscore.");
                    break;
                }
            }
            updatedProduct.objectname = ObjNameTxtB.Text;

            try
            {
                updatedProduct.count = (QuaTxtB.Text);

            }
            catch (Exception)
            {
                FlagChecker = false;
                errorProvider1.SetError(QuaTxtB, "Please enter numbers only.");
            }

            try
            {
                updatedProduct.price = (PrTxtB.Text);

            }
            catch (Exception)
            {
                FlagChecker = false;
                errorProvider1.SetError(PrTxtB, "Please enter numbers only.");
            }

            updatedProduct.productType = (SimpleRb.Checked == true) ? "Simple" : "Variable";

            if (SimpleRb.Checked == false && VariableRb.Checked == false)
            {
                FlagChecker = false;
                errorProvider1.SetError(ProductTypeGB, "Please select only one of the following");
            }

            if (FlagChecker == true)
            {
                if (updatedProduct != null)
                {
                    Class1.updateProduct(updatedProduct, productInList);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Class1.getall();
                    MessageBox.Show("Product has been updated sucessfully.");
                }
                else
                {
                    MessageBox.Show("Please be sure that the product was added");
                }
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
