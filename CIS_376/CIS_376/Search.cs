﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_376
{
    public partial class Search : Form
    {

        Inventory inv = new Inventory();
        public Search()
        {
            InitializeComponent();
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter text here...";
                textBox1.ForeColor = Color.Gray;

            }
               

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            inv.Show();
            this.Hide();
        }
    }
}
