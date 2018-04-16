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
        List<String> FoodCollection = new List<string>();
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
            this.Close();
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(FoodBox2.Text);
            if (FoodCollection.Contains(item.ToString()))
            {
                MessageBox.Show("Already included!");
            }
            else
            {
                listyView.Items.Add(item);
                FoodCollection.Add(item.ToString());
                FoodBox2.Text = "";
                listyView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}
