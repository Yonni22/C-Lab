using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class ProductClass
    {
        public int number { get; set; }
        public string Objectname { get; set; }
        public int inventorynumber { get; set; }
        public DateTime date { get; set; }
        public double price { get; set; }
        public int Count { get; set; }
        public void Save()
        {
            Console.WriteLine("created");
           
        }
    }
}
