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

        private void FillInventoryGrid()
        {
            // table formatting
            this.InvGridView.DefaultCellStyle.SelectionBackColor = this.InvGridView.DefaultCellStyle.BackColor;
            this.InvGridView.DefaultCellStyle.SelectionForeColor = this.InvGridView.DefaultCellStyle.ForeColor;
            InvGridView.RowHeadersVisible = false;

            // fetch food data from database and populate food table with it
            InvGridView.DataSource = null;
            InvGridView.DataSource = ManagerHome.mainDatabaseReference.Foods.ToList().Select(p => new { p.Food_ID, p.Food_Name, p.Food_Type, p.Exp_Date }).ToList();
            
            /*// table formatting
            InvGridView.Columns[1].Width = 170;
            InvGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InvGridView.Columns[0].Visible = false;*/
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
            // TODO: Implement remove function
        }
    }
}
