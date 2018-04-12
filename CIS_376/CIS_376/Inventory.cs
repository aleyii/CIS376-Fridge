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
            FillInventoryGrid();
        }

        private void FillInventoryGrid()
        {
            // table formatting
            this.InvGridView.DefaultCellStyle.SelectionBackColor = this.InvGridView.DefaultCellStyle.BackColor;
            this.InvGridView.DefaultCellStyle.SelectionForeColor = this.InvGridView.DefaultCellStyle.ForeColor;
            InvGridView.RowHeadersVisible = false;

            // fetch food data from database and populate food table with it
            InvGridView.DataSource = null;
            InvGridView.DataSource = ManagerHome.mainDatabaseReference.Foods.ToList().Select(p => new { p.Food_ID, p.Food_Name, p.Food_Type, p.Exp_Date }).ToList();
        }

        private void SearchFridgeButton_Click(object sender, EventArgs e)
        {
            var srh = new Search();
            srh.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var add = new AddItem();
            add.Show();
        }

        private void RemoveFoodButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement remove function
        }
    }
}
