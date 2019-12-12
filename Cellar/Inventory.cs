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
    public partial class Inventory : Form
    {
        Models.Collection bottles;
        List<Models.Bottle> bottleList = new List<Models.Bottle>();

        public Inventory(Models.Collection collection)
        {
            InitializeComponent();

            bottles = collection;

            foreach (Models.Bottle b in bottles.Bottles)
            {
                invList.Items.Add(b.ToString());
                bottleList.Add(b);
            }

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            BeforeClosing();
            Dashboard dash = new Dashboard(bottles);
            dash.Show();
            Hide();
        }

        private void BtnAddBottle_Click(object sender, EventArgs e)
        {
            BeforeClosing();
            AddBottle add = new AddBottle(bottles);
            add.Show();
            Hide();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            BeforeClosing();
            Statistics stat = new Statistics(bottles);
            stat.Show();
            Hide();
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            BeforeClosing();
            
            //TO DO
            //Serialize and send to DB here

            Application.Exit();
        }

        private void InvList_DoubleClick(object sender, EventArgs e)
        {
            BottleDetails details = new BottleDetails(bottles.Bottles[invList.SelectedIndex]);
        }

        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                invList.Items.Clear();
                bottleList.Clear();

                switch (filterBy.SelectedText)
                {
                    case "Vintage":
                        var vintageSort = from bottle in bottles.Bottles
                                          orderby bottle.Vintage ascending
                                          select bottle;
                        foreach (var bottle in vintageSort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    case "Name":
                        var nameSort = from bottle in bottles.Bottles
                                       orderby bottle.BottleName ascending
                                       select bottle;
                        foreach (var bottle in nameSort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    case "Country":
                        var originSort = from bottle in bottles.Bottles
                                         orderby bottle.Country ascending
                                         select bottle;
                        foreach (var bottle in originSort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    case "Category":
                        var categorySort = from bottle in bottles.Bottles
                                           orderby bottle.TypeCode ascending
                                           select bottle;
                        foreach (var bottle in categorySort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    case "Importance":
                        var importanceSort = from bottle in bottles.Bottles
                                             orderby bottle.ImportanceCode ascending
                                             select bottle;
                        foreach (var bottle in importanceSort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    case "Drink-by Window":
                        var drinkSort = from bottle in bottles.Bottles
                                        orderby bottle.DrinkByStart ascending
                                        select bottle;
                        foreach (var bottle in drinkSort)
                        {
                            invList.Items.Add(bottle.ToString());
                            bottleList.Add(bottle);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                return;
            }
        }

        private void BeforeClosing()
        {
            //Sequence to complete before moving to another form and/or closing
            bottles.Bottles = bottleList;
        }
    }
}
