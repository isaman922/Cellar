using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellar
{
    public partial class Statistics : Form
    {
        Models.Collection bottles;

        public Statistics(Models.Collection collection)
        {
            InitializeComponent();

            bottles = collection;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(bottles);
            dash.Show();
            Hide();
        }

        private void BtnAddBottle_Click(object sender, EventArgs e)
        {
            AddBottle add = new AddBottle(bottles);
            add.Show();
            Hide();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory(bottles);
            inv.Show();
            Hide();
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
