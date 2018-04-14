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
        private static int SHELF_NUM = 3;
        public Inventory()
        {
            InitializeComponent();
            FillInventoryGrid();
        }

        public void FillInventoryGrid()
        {
            // table formatting
            //this.InvGridView.DefaultCellStyle.SelectionBackColor = this.InvGridView.DefaultCellStyle.BackColor;
            //this.InvGridView.DefaultCellStyle.SelectionForeColor = this.InvGridView.DefaultCellStyle.ForeColor;
            InvGridView.RowHeadersVisible = false;

            // fetch food data from database and populate food table with it
            InvGridView.DataSource = null;
            InvGridView.DataSource = ManagerHome.mainDatabaseReference.Foods.ToList().Select(p => new { p.Food_ID, p.Food_Name, p.Food_Type, p.Exp_Date }).ToList();
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

        /*private void ShelfHelper(int removedID)
        {
            List<Shelf> entries1, entries2, entries3, entries4, entries5;
            for (int i = 0; i < SHELF_NUM; i++)
            {
                entries1 = ManagerHome.mainDatabaseReference.Shelves.Where(p =>
                p.Shelf_Id == i && p.Food1 == 2).ToList();
                if (entries1.Any())
                {
                    
                }
                entries2 = ManagerHome.mainDatabaseReference.Shelves.Where(p =>
                p.Shelf_Id == i && p.Food2 == 2).ToList();
                if ()
                {

                }
                entries3 = ManagerHome.mainDatabaseReference.Shelves.Where(p =>
                p.Shelf_Id == i && p.Food3 == 2).ToList();
                if ()
                {

                }
                entries4 = ManagerHome.mainDatabaseReference.Shelves.Where(p =>
                p.Shelf_Id == i && p.Food4 == 2).ToList();
                if ()
                {

                }
                entries5 = ManagerHome.mainDatabaseReference.Shelves.Where(p =>
                p.Shelf_Id == i && p.Food5 == 2).ToList();
                if ()
                {

                }
            }
        }*/

        private void AdjustIDs(int removedID)
        {
            int tempID;
            // get all tuples greater than removedID
            var toBeAdjusted = ManagerHome.mainDatabaseReference.Foods.Where(p => p.Food_ID > removedID).ToList();
            for (int i = 0; i < toBeAdjusted.Count; i++)
            {
                toBeAdjusted[i].Food_ID--;
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            FillInventoryGrid();
        }
    }
}