using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionstring = @"Data Source=DESKTOP-I9UD49J ; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show("Connected");
                string query = "Insert into Products values ('Sample', 4, 4, 2)";
                SqlCommand com = new SqlCommand(query, con);
                var result = com.ExecuteNonQuery();
                if(result != 0)
                {
                    MessageBox.Show("Products Added!");

                }
                //MessageBox.Show(result.ToString());
                con.Close();
              
            }
            catch
            {
                MessageBox.Show("error");
            };
                                                            
        }
    }
}
