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
    public partial class CustomRecipe : Form
    {
        List<string> FoodCollection = new List<string>();
        static int QUERY_LIMIT = 2;
        int amountQueries = 0;
        public CustomRecipe()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillComboBox();
        }

        private void FillComboBox()
        {
            FoodBox2.DataSource = null;
            FoodBox2.Items.Clear();

            var foods = ManagerHome.mainDatabaseReference.Foods.ToList().Select(p => new { p.Food_ID, p.Food_Name }).ToList();
            FoodBox2.DataSource = foods.ToList();
            FoodBox2.ValueMember = "Food_ID";
            FoodBox2.DisplayMember = "Food_Name";
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(FoodBox2.Text);

            if (FoodCollection.Contains(FoodBox2.Text))
            {
                MessageBox.Show("Already included!");
            }
            else if(amountQueries > QUERY_LIMIT)
            {
                MessageBox.Show("No more than two ingredients, please");
            }
            else
            {
                listyView.Items.Add(item);
                FoodCollection.Add(FoodBox2.Text);
                FoodBox2.Text = "";
                resize(); // doesn't work right
            }
        }

        private void resize()
        {
            listyView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listyView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void jumpToRecipe_Click(object sender, EventArgs e)
        {
            var recipes = new Recipes(FoodCollection);
            recipes.Owner = this;
            recipes.Show();
            this.Hide();
            FoodCollection.Clear();
            listyView.Clear();
        }
    }
}
