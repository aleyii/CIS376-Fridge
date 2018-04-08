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
    public partial class Inventory : Form
    {
        
        ManagerHome mh = new ManagerHome();
        public Inventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search srh = new Search();
            srh.Show();
            this.Hide();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();
            add.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveItem rmv = new RemoveItem();
            rmv.Show();
            this.Hide();
        }
    }
}
