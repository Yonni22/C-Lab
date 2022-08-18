using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
