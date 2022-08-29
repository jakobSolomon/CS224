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
        private DataGridView _dgv;

        public DataGridView dgv
        {
            get { return _dgv; }
            set { _dgv = value; }   
        }   
        public Display()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dgv = dataGridView1;
            dataGridView1.DataSource = ToD0List.GetAllProducts();
        }
    }
}
