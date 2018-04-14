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
    public partial class AddItem : Form
    {
        static int SHELF_LIMIT = 4;

        public AddItem()
        {
            InitializeComponent();
            FillShelfComboBox();
        }

        private bool HasDupe(String name)
        {
            // get all food names from food table that match name
            var nameResult = ManagerHome.mainDatabaseReference.Foods.Where(p =>
            p.Food_Name == name).ToList();

            // check for matches
            if (nameResult.Any())
            {
                return true;
            }

            return false;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement regular expressions to handle input
            // TODO: Ensure that the user enters text
            string name, type, expDate;
            int quantity, maxID;
            Food food;

            // get all values from textboxes
            name = NameBox.Text;
            type = TypeBox.Text;
            expDate = ExpDateBox.Value.ToShortDateString();
            Int32.TryParse(QuantBox.Text, out quantity);

            // grab max food id
            maxID = ManagerHome.mainDatabaseReference.Foods.Max(p => p.Food_ID);

            // check for duplicate names
            if (!HasDupe(name))
            {
                food = new Food();
                try
                {
                    // add food to database
                    //food.Food_ID = maxID;
                    food.Food_Name = name;
                    food.Food_Type = type;
                    food.Quantity = quantity;
                    food.Shelf_Number = Int32.Parse(ShelfComboBox.Text);
                    food.Exp_Date = expDate;
                    ManagerHome.mainDatabaseReference.Foods.Add(food);
                }
                catch (Exception exc)
                {
                    ManagerHome.mainDatabaseReference.Foods.Remove(food);
                    MessageBox.Show("Failed to add new food");
                }

                try
                {
                    ManagerHome.mainDatabaseReference.SaveChanges();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Unable to save changes");
                }
            }

            // clear all fields
            NameBox.Clear();
            TypeBox.Clear();
            QuantBox.Clear();
            ExpDateBox.ResetText();
            ShelfComboBox.Text = "";
            maxID++;
        }
        private void FillShelfComboBox()
        {
            for (int i = 0; i < SHELF_LIMIT; i++)
            {
                ShelfComboBox.Items.Add(i + 1);                     // ascii mona lisa.jpg
            }
        }
    }
}