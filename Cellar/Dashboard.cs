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
        //General Variables
        Models.Collection bottles;

        public Dashboard(Models.Collection collection)
        {
            InitializeComponent();

            bottles = collection;
            subtitle.Text = $"{collection.FirstName} {collection.LastName}'s Cellar";
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Display the Dashboard Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = true;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;

            /*Dashboard Panel Fields:
                *
            */
        }

        private void BtnAddBottle_Click(object sender, EventArgs e)
        {
            //Display the Add Bottle Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = true;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;

            /*Add Bottle Panel Fields:
                * addName- 
                * addProducer- 
                * addVintage- 
                * addCountry- 
                * addRegion- 
                * addStyle- 
                * addSize- 
                * addDrinkByStart- 
                * addDrinkByEnd- 
                * addDrinkByPeak- 
                * addCost- 
                * addLocation- 
                * addType- 
                * addImportance- 
                * addRatingPts- 
                * addRatingCritic- 
                * addRatingList- 
                * addNotes- 
                * addLabelPicture- 
                * btnAddRating- 
                * btnUploadLabel- 
                * btnClear- 
                * btnSubmit- 
                * openFileDialog- 
            */
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            //Display the Inventory Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = false;
            inventoryPanel.Visible = true;
            statsPanel.Visible = false;

            /*Inventory Panel Fields:
                * invFilterBy- 
                * invList- 
            */
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            //Display the Statistics Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = true;

            /*Statistics Panel Fields:
                * statBottleTotal- 
                * statValueTotal- 
                * statAvgCost- 
                * statAvgAge- 
                * statAvgPeak- 
                * statCountryChart- 
                * statCategoryChart- 
            */

            statBottleTotal.Text = $"{bottles.BottleCount()}";
            statValueTotal.Text = $"{bottles.TotalValue():C}";
            statAvgCost.Text = $"{bottles.AvgBottleCost():C}";
            statAvgAge.Text = $"{bottles.AvgBottleAge():D2} yrs";
            statAvgPeak.Text = $"{bottles.AvgPeakYear()}";

            //Update Charts TO DO
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Update the collection with the bottles, serialize collection


            Application.Exit();
        }

        private void InvFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Filter the list accordingly:
            /*
             * Vintage
             * Name
             * Country
             * Category
             * Importance
             * Drink-by Window
             * */

            invList.Items.Clear();

            switch (invFilterBy.SelectedText)
            {
                case "Vintage":
                    var vintQuery = from bottle in bottles.Bottles
                                    orderby bottle.Vintage descending
                                    select bottle;
                    foreach (Models.Bottle b in vintQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                case "Name":
                    var nameQuery = from bottle in bottles.Bottles
                                    orderby bottle.BottleName ascending
                                    select bottle;
                    foreach (Models.Bottle b in nameQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                case "Country":
                    var originQuery = from bottle in bottles.Bottles
                                      orderby bottle.Country ascending
                                      select bottle;
                    foreach (Models.Bottle b in originQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                case "Category":
                    var typeQuery = from bottle in bottles.Bottles
                                    orderby bottle.TypeCode ascending
                                    select bottle;
                    foreach (Models.Bottle b in typeQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                case "Importance":
                    var importanceQuery = from bottle in bottles.Bottles
                                          orderby bottle.ImportanceCode ascending
                                          select bottle;
                    foreach (Models.Bottle b in importanceQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                case "Drink-by Window":
                    var drinkQuery = from bottle in bottles.Bottles
                                     orderby bottle.DrinkByStart ascending
                                     select bottle;
                    foreach (Models.Bottle b in drinkQuery)
                    {
                        invList.Items.Add(b.ToString());
                    }
                    break;
                default:
                    break;
            }
        }

        private void InvList_DoubleClick(object sender, EventArgs e)
        {
            // Open Bottle Detail for the selected bottle
        }

        private void AddRatingList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //Delete the selected rating after verification

            }
        }

        private void BtnAddRating_Click(object sender, EventArgs e)
        {
            // Add rating to the ratings list from text in the pts and critic fields
        }

        private void BtnUploadLabel_Click(object sender, EventArgs e)
        {
            //Run the openFileDialog and retrieve label picture to input as the pic
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clear all fields after checking with user
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Add the bottle to the collection
        }


    }
}
