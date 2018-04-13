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
        static int SHELF_LIMIT = 3;

        public AddItem()
        {
            InitializeComponent();
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
            this.Close();
        }

        private int[] ShelveNewFood(string name)
        {
            /*
             *these code smells make me wanna vom, 
             * but I can't think of another way to do it with how our database is set up*/
            int[] shelfID_and_slotNum = new int[2];
            for (int i = 0; i < SHELF_LIMIT; i++)
            {
                shelfID_and_slotNum[0] = i + 1;

                // find first open space on shelf # shelfNum
                var empties = ManagerHome.mainDatabaseReference.Shelves.Select(p =>
                p.Shelf_Id == i && p.Food1 == null).ToList();

                if (empties.Any())
                {
                    shelfID_and_slotNum[1] = 1;
                    return shelfID_and_slotNum;
                }

                // spot 2
                empties = ManagerHome.mainDatabaseReference.Shelves.Select(p =>
                p.Shelf_Id == i && p.Food2 == null).ToList();

                if (empties.Any())
                {
                    shelfID_and_slotNum[1] = 2;
                    return shelfID_and_slotNum;
                }

                // spot 3
                empties = ManagerHome.mainDatabaseReference.Shelves.Select(p =>
                p.Shelf_Id == i && p.Food3 == null).ToList();

                if (empties.Any())
                {
                    shelfID_and_slotNum[1] = 3;
                    return shelfID_and_slotNum;
                }

                // spot 4
                empties = ManagerHome.mainDatabaseReference.Shelves.Select(p =>
                p.Shelf_Id == i && p.Food4  == null).ToList();

                if (empties.Any())
                {
                    shelfID_and_slotNum[1] = 4;
                    return shelfID_and_slotNum;
                }

                // spot 5
                empties = ManagerHome.mainDatabaseReference.Shelves.Select(p =>
                p.Shelf_Id == i && p.Food5 == null).ToList();

                if (empties.Any())
                {
                    shelfID_and_slotNum[1] = 5;
                    return shelfID_and_slotNum;
                }
            }
            shelfID_and_slotNum[0] = -1;
            shelfID_and_slotNum[1] = -1;
            return shelfID_and_slotNum;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement regular expressions to handle input
            // TODO: Ensure that the user enters text
            string name, type, expDate;
            int quantity, maxID;
            int[] firstOpenSpot = new int[2];
            Food food;

            // get all values from textboxes
            name = NameBox.Text;
            type = TypeBox.Text;
            expDate = ExpDateBox.Text;
            Int32.TryParse(QuantBox.Text, out quantity);
            //Int32.TryParse(ShelfBox.Text, out shelf);

            // grab max food id
            maxID = ManagerHome.mainDatabaseReference.Foods.Max(p => p.Food_ID);

            // check for duplicate names
            if (!HasDupe(name))
            {
                food = new Food();
                try
                {
                    // add food to database
                    food.Food_Name = name;
                    food.Food_Type = type;
                    food.Quantity = quantity;
                    food.Exp_Date = expDate;
                    ManagerHome.mainDatabaseReference.Foods.Add(food);
                    maxID++;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Failed to add new food");
                }
                /*try
                {
                    // find first open spot
                    firstOpenSpot = ShelveNewFood(name);
                    var openSpace = ManagerHome.mainDatabaseReference.Shelves.SingleOrDefault(p => p.Shelf_Id == firstOpenSpot[0]);
                    
                    // determine which shelf to put food item on
                    switch (firstOpenSpot[1])
                    {
                        case 1:
                            openSpace.Food1 = maxID;
                            break;
                        case 2:
                            openSpace.Food2 = maxID;
                            break;
                        case 3:
                            openSpace.Food3 = maxID;
                            break;
                        case 4:
                            openSpace.Food4 = maxID;
                            break;
                        case 5:
                            openSpace.Food5 = maxID;
                            break;
                        default:
                            // no empty space available
                            MessageBox.Show("No open space for this item");
                            break;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Unable to add item to shelf");
                }*/
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
            ExpDateBox.Clear();
        }
    }
}
