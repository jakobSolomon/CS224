using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoList
{
    internal class ToD0List
    {
        static private List <ToD0List> ToDoList = new List<ToD0List> ();
            public string name { get; set; }
            public string description { get; set; }
        public void save()
        {
            MessageBox.Show("saved");
            //ToD0List.add();
        }
        public static List<ToD0List> GetAllProducts()
        {
            return ToD0List.ToDoList;
        }

    }
}
