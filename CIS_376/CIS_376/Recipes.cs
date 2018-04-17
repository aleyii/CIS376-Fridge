using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIS_376
{
    public partial class Recipes : Form
    {
        int minID, maxID, selection, timesSkipped, currentMode; //1 = random mode, 2 = custom mode
        string ingredients, test;
        string currentRecipePublished = "";
        List<string> mainParameters = new List<string>();

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
            previousButton.Visible = false;
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
            mainParameters = parameters;
            test = parameters[0];
            timesSkipped = 0;

            var ingredientQuery = ManagerHome.mainDatabaseReference.Recipes.FirstOrDefault(p =>
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
                currentRecipePublished = ingredientQuery.Name.ToString();
            }
            else
            {
                this.Return.PerformClick();
            }
        }

        private void PullCustomRecipe(int timesSkipped)
        {
            bool found = false;
            var ingredientQuery = ManagerHome.mainDatabaseReference.Recipes.OrderBy(o => o.Recipe_ID).Skip(timesSkipped).FirstOrDefault(p =>
            p.IngredientsSet.Food.Food_Name == test ||
            p.IngredientsSet.Food1.Food_Name == test ||
            p.IngredientsSet.Food2.Food_Name == test ||
            p.IngredientsSet.Food3.Food_Name == test ||
            p.IngredientsSet.Food4.Food_Name == test);
            if (ingredientQuery == null)
            {
                MessageBox.Show("No such recipe in the database!");
            }
            else if (ingredientQuery.Name == currentRecipePublished)
            {
                MessageBox.Show("Last of recipes!");
                Return.PerformClick();
            }
            else
            {
                found = true;
            }

            if (found)
            {
                PublishRecipe(ingredientQuery);
                currentRecipePublished = ingredientQuery.Name.ToString();
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
            if (currentMode == 1)
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
            else
            {
                timesSkipped += 1;
                PullCustomRecipe(timesSkipped);
            }
        }

        private void previousButton_Click_1(object sender, EventArgs e)
        {
            if (currentMode == 1)
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
            else
            {
                timesSkipped += 1;
                PullCustomRecipe(timesSkipped);
            }
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
