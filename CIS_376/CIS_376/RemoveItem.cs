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
    public partial class RemoveItem : Form
    {
        public RemoveItem()
        {
            InitializeComponent();
            tableLayoutPanel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID",typeof(int));
            table.Columns.Add("Item",typeof(String));
        }
    }
}
