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
    public partial class Recipies : Form
    {
        int minID, maxID, selection;
        string ingredients;

        public Recipies()
        {
            InitializeComponent();
            // how to handle custom recipes
            PullRandomRecipe();
        }

        private void PullRandomRecipe()
        {
            Random rand = new Random();
            maxID = ManagerHome.mainDatabaseReference.Recipes.Max(p => p.Recipe_ID);
            minID = ManagerHome.mainDatabaseReference.Recipes.Min(p => p.Recipe_ID);
            selection = rand.Next(minID, maxID);
            var recipeSelection = ManagerHome.mainDatabaseReference.Recipes.SingleOrDefault(p => p.Recipe_ID == selection);
            publishRecipe(recipeSelection);
        }

        private void publishRecipe(Recipe recipeSelection)
        {
            Recipes.Text = recipeSelection.Name;
            pictureBox1.Load(recipeSelection.PictureURL);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Directions.Text = $"Directions:\n {recipeSelection.Description}";
            ingredients = pullIngredients(recipeSelection);
            Ingedients.Text = $"Ingredients:\n {ingredients}";
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            if (selection == maxID)
            {
                selection = minID;
            }
            else
            {
                selection += 1;
            }
            var recipeSelection = ManagerHome.mainDatabaseReference.Recipes.SingleOrDefault(p => p.Recipe_ID == selection);
            publishRecipe(recipeSelection);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (selection == minID)
            {
                selection = maxID;
            }
            else
            {
                selection -= 1;
            }
            var recipeSelection = ManagerHome.mainDatabaseReference.Recipes.SingleOrDefault(p => p.Recipe_ID == selection);
            publishRecipe(recipeSelection);
        }

        private string pullIngredients(Recipe input)
        {
            return (input.IngredientsSet.Food.Food_Name.ToString()) + ", "+
                (input.IngredientsSet.Food1.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food2.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food3.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food4.Food_Name.ToString());
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
