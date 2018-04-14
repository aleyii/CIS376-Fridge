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
        Shelf shelf;

        public FridgeLayout()
        {
            InitializeComponent();

            FillTable();
        }

        public void FillTable()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
           // var foodId1 = Int32.Parse(ManagerHome.mainDatabaseReference.Shelves.Select(p => new { p.Food1}).ToString());
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
