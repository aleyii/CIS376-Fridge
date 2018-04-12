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
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }

        private void RecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            ReminderEmail email = new ReminderEmail();
            email.Show();
            this.Hide();
        }
    }
}
