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
    public partial class Dashboard : Form
    {
        Models.Collection bottles;
        public Dashboard(Models.Collection collection)
        {
            InitializeComponent();

            bottles = collection;
            subtitle.Text = $"{collection.FirstName} {collection.LastName}'s Cellar";
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = true;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;
        }

        private void BtnAddBottle_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = true;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = false;
            inventoryPanel.Visible = true;
            statsPanel.Visible = false;
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = true;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
