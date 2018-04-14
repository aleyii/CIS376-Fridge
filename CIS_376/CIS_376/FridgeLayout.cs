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
    public partial class FridgeLayout : Form
    {
        private string templateSearch = "https://www.google.com/search?q=";

        public FridgeLayout()
        {
            InitializeComponent();
        }

        public void FillTable()
        {
            int desiredShelf = Int32.Parse(shelfChoiceBox.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = ManagerHome.mainDatabaseReference.Foods.Where(w => w.Shelf_Number == desiredShelf).Select(p => new { p.Food_Name, p.Food_Type }).ToList();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


        private void selectButton_Click(object sender, EventArgs e)
        {
            FillTable();
            label3.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = templateSearch + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            System.Diagnostics.Process.Start(query + $" {dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()}");
            query = "";
        }
    }
}
