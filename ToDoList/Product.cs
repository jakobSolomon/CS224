using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    internal class Product
    {
        static private List <Product> ToDoList = new List<Product> ();
            public string name { get; set; }
            public string description { get; set; }
        public void save()
        {
            MessageBox.Show("saved");
        }
        public static List<Product> GetAllProducts()
        {
            return Product.GetAllProducts();
        }

    }
}
