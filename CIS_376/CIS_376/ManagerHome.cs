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

            //https://msdn.microsoft.com/en-us/library/system.windows.forms.tooltip(v=vs.110).aspx
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.RecipeButton, "Finds a random recipe with the ingredients in your kitchen");
            toolTip1.SetToolTip(this.RecipeButton2, "Finds a recipe based on specifed parameters");
            toolTip1.SetToolTip(this.ViewInventoryButton, "Add and remove Food in the kitchen");
            toolTip1.SetToolTip(this.FridgeLayoutButton, "See where food is in the kitchen, included google search");
            toolTip1.SetToolTip(this.EmailButton, "Emails a custom grocery list reminder");
        }

        private void FridgeLayoutButton_Click(object sender, EventArgs e)
        {
            FridgeLayout fl = new FridgeLayout();
            fl.Owner = this;
            fl.Show();
            this.Hide();
        }

        private void RecipeButton_Click(object sender, EventArgs e)
        {
            var recipes = new Recipies();
            recipes.Owner = this;
            recipes.Show();
            this.Hide();
        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory(); // type var?-Aley
            inventory.Owner = this;
            inventory.Show();
            this.Hide();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            var email = new ReminderEmail();
            email.Owner = this;
            email.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //system.exit();?
        }

        private void RecipeButton2_Click(object sender, EventArgs e)
        {
            var recipes2 = new RecipesList();
            recipes2.Owner = this;
            recipes2.Show();
            this.Hide();
        }
    }
}
