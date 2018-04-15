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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text;
            if (searchText != "")
            {
                using (var bootleg = new dbTest())
                {
                    var results = ManagerHome.mainDatabaseReference.Foods
                        .Where(p => p.Food_Name == searchText)
                        .Select(p => 
                        new { p.Food_ID, p.Food_Name, p.Food_Type, p.Exp_Date, p.Shelf_Number }).ToList();
                    ResultsGrid.DataSource = null;
                    ResultsGrid.DataSource = results;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input. Try again!");
                SearchBox.Clear();
            }
        }
    }
}
