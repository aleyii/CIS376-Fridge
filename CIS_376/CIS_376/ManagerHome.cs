using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CIS_376
{
    
    public partial class ManagerHome : Form
    {
        public static dbTest mainDatabaseReference;

        public ManagerHome()
        {
            InitializeComponent();
            mainDatabaseReference = new dbTest();
        }

        private void FridgeLayoutButton_Click(object sender, EventArgs e)
        {
            FridgeLayout fl = new FridgeLayout();
            fl.Show();
        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            var inv = new Inventory();
            inv.Show();
        }

        private void RecipeButton_Click(object sender, EventArgs e)
        {
            // TODO: Add view recipe form
        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory();
            inventory.Show();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            var email = new ReminderEmail();
            email.Show();
        }
    }
}
