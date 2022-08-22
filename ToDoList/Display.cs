using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.GetAllProducts();
        }
    }
}
