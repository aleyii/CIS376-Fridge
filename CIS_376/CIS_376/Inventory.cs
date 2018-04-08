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
    }
}
