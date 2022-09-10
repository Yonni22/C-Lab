using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lab4
{
    internal class Class1
    {
        private static List<Class1> product = new List<Class1>();  
        public string number { get; set; }
        public string inventory { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public bool isavaliable { get; set; }
        public string productType { get; set; }
        public DateTime date { get; set; }

        public void save()
        {
            //Console.WriteLine("saved");
            product.Add(this);
            try
            {

                String connectionstring = @"Data Source=DESKTOP-I9UD49J\SQLEXPRESS; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                string query = "insert into student(id,fname,lname,_address,_date,gender) values(@id,@fn,@ln,@address,@date,@gender);";//"insert into student values ('ss' ,'ddd');";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@number", number);
                com.Parameters.AddWithValue("@inventory", inventory);
                com.Parameters.AddWithValue("@objectname", objectname);
                com.Parameters.AddWithValue("@quantity", count);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@price", price);
                //var result = com.ExecuteReader();
                com.ExecuteNonQuery();
              
            }
            catch
            {
                Console.WriteLine("error");
            };
        }
        public static List<Class1> getall()
        {
            return product;
        }
        public static Class1 findone(string name)
        {

            return product.Find(p => p.number == name);

        }
        public static void updateProduct(Class1 editedProduct, Class1 productTobeEdited)
        {
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i] == productTobeEdited)
                {
                    product[i] = editedProduct;
                }
            }

        }




    }
}
