using System;
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
    public partial class ManagerHome : Form
    {

      
        public ManagerHome()
        {
            InitializeComponent();
            HomePageLabel.Text = "Store Manager Homepage";// set text of label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FridgeLayout fl = new FridgeLayout();
            fl.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }
    }
}
