using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIS_376
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillInventoryGrid();
        }

        public void FillInventoryGrid()
        {
            // table formatting
            InvGridView.RowHeadersVisible = false;

            // fetch food data from database and populate food table with it
            InvGridView.DataSource = null;
            InvGridView.DataSource = ManagerHome.mainDatabaseReference.Foods.ToList().Select(
                p => new { p.Food_ID, p.Food_Name, p.Food_Type, p.Exp_Date }).ToList();
        }

        private void SearchFridgeButton_Click(object sender, EventArgs e)
        {
            var search = new Search();
            search.Owner = this;
            search.Show();
            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var add = new AddItem();
            add.Owner = this;
            add.Show();
            this.Hide();
        }

        private void RemoveFoodButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmBox;
            int selectedFoodID;

            // get food id of selected row
            var selection = InvGridView.SelectedRows;
            Int32.TryParse(selection[0].Cells[0].Value.ToString(), out selectedFoodID);

            // get food based on id
            var itemToRemove = ManagerHome.mainDatabaseReference.Foods.SingleOrDefault(p => 
            p.Food_ID == selectedFoodID);

            try
            {
                // https://stackoverflow.com/questions/3845695/is-there-a-builtin-confirmation-dialog-in-windows-forms
                confirmBox = MessageBox.Show("Are you sure you want to remove this food?", "Confirm Removal", MessageBoxButtons.YesNo);
                if (confirmBox == DialogResult.Yes)
                {
                    ManagerHome.mainDatabaseReference.Foods.Remove(itemToRemove);
                    ManagerHome.mainDatabaseReference.SaveChanges();
                    FillInventoryGrid();
                }
                else
                {
                    MessageBox.Show("Food was not removed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not remove");
            }
        }
        
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            FillInventoryGrid();
        }
    }
}