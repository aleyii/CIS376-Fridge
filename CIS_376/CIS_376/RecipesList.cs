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
    public partial class RecipesList : Form
    {
        public RecipesList()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Jump_Click(object sender, EventArgs e)
        {
            // jump to the recipe page
            var recipes = new Recipies();
            recipes.Owner = this;
            recipes.Show();
            this.Hide();
        }
    }
}
