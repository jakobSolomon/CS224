﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToD0List p = new ToD0List()
            {
                name = textBox1.Text,
                description = textBox2.Text,
            };
            p.save();
            Display d = new Display();
            d.dgv.DataSource = ToD0List.GetAllProducts();
            d.Show(); 
        }
    }
}
