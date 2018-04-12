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

        private void SearchFridgeButton_Click(object sender, EventArgs e)
        {
            Search srh = new Search();
            srh.Show();
            this.Hide();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            mh.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();
            add.Show();
            this.Hide();
        }

        private void RemoveFoodButton_Click(object sender, EventArgs e)
        {
           /* RemoveItem rmv = new RemoveItem();
            rmv.Show();
            this.Hide();*/
        }
    }
}
