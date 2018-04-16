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
    public partial class Recipes : Form
    {
        int minID, maxID, selection, currentMode; //1 = random mode, 2 = custom mode
        string ingredients; 

        public Recipes()
        {
            InitializeComponent();
            this.CenterToScreen();
            PullRandomRecipe();
            currentMode = 1;
        }

        public Recipes(List<string> customIngredients)
        {
            InitializeComponent();
            this.CenterToScreen();
            PullCustomRecipe(customIngredients);
            currentMode = 2;
        }

        private void PullRandomRecipe()
        {
            Random rand = new Random();
            maxID = ManagerHome.mainDatabaseReference.Recipes.Max(p => p.Recipe_ID);
            minID = ManagerHome.mainDatabaseReference.Recipes.Min(p => p.Recipe_ID);
            selection = rand.Next(minID, maxID);
            var recipeSelection = ManagerHome.mainDatabaseReference.Recipes.SingleOrDefault(p => p.Recipe_ID == selection);
            PublishRecipe(recipeSelection);
        }

        private void PullCustomRecipe(List <string> parameters)
        {
            bool found = false;
            //var recipeSelection = ManagerHome.mainDatabaseReference.IngredientsSets.sing
            
            string test = parameters[0];
            var ingredientQuery = ManagerHome.mainDatabaseReference.Recipes.SingleOrDefault(p => 
            p.IngredientsSet.Food.Food_Name == test ||
            p.IngredientsSet.Food1.Food_Name == test || 
            p.IngredientsSet.Food2.Food_Name == test || 
            p.IngredientsSet.Food3.Food_Name == test || 
            p.IngredientsSet.Food4.Food_Name == test);
            if (ingredientQuery == null)
            {
                MessageBox.Show("No such recipe in the database!");
            }
            else
            {
                found = true;
            }
            
            if (found)
            {
                PublishRecipe(ingredientQuery);
            }
        }

        private void PublishRecipe(Recipe recipeSelection)
        {
            Recipe.Text = recipeSelection.Name;
            pictureBox1.Load(recipeSelection.PictureURL);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Directions.Text = $"Directions:\n {recipeSelection.Description}";
            ingredients = pullIngredients(recipeSelection);
            Ingedients.Text = $"Ingredients:\n {ingredients}";
        }

        
        private void nextButton_Click_1(object sender, EventArgs e)
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
            PublishRecipe(recipeSelection);
        }

        private void previousButton_Click_1(object sender, EventArgs e)
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
            PublishRecipe(recipeSelection);
        }

        private void Return_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private string pullIngredients(Recipe input)
        {
            return (input.IngredientsSet.Food.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food1.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food2.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food3.Food_Name.ToString()) + ", " +
                (input.IngredientsSet.Food4.Food_Name.ToString());
        }

      
    }
}
