using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items i = new Items();
            i.Number = txt_Number.Text;
            i.Date = dateTimePicker.Text;
            i.Inventory_Number = txt_Inventory.Text;
            i.Object_Name = txt_Object.Text;
            i.Count = txt_Count.Text;
            i.Price = txt_Price.Text;
            MessageBox.Show("Item Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Number.Text = "";
            //dateTimePicker.Text = "";
            txt_Inventory.Text = "";
            txt_Object.Text = "";
            txt_Count.Text = "";
            txt_Price.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
