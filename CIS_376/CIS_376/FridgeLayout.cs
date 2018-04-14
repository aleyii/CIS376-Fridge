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
        public FridgeLayout()
        {
            InitializeComponent();

            FillTable();
        }

        public void FillTable()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
