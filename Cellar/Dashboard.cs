﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Cellar.Models;

namespace Cellar
{
    public partial class Dashboard : Form
    {
        //General Variables
        Models.Collection bottles;
        private bool isEditing = false;
        private Models.Bottle bottleBeingEdited;
        private List<string[]> ratingsTemp = new List<string[]>();

        public Collection Bottles { get => bottles; set => bottles = value; }

        public Dashboard(Models.Collection collection)
        {
            InitializeComponent();

            Bottles = collection;
            subtitle.Text = $"{collection.FirstName} {collection.LastName}'s Cellar";

            SetDashboard();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            SetDashboard();
        }

        private void SetDashboard()
        {
            if (isEditing)
            {
                CheckEdit();
            }

            //Display the Dashboard Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = true;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;

            dashUserLbl.Text = Bottles.UserName;
            dashNameLbl.Text = $"{Bottles.FirstName} {Bottles.LastName}";
            dashCellarCount.Text = Bottles.BottleCount().ToString();
            dashCellarValue.Text = $"{Bottles.TotalValue():C}";

            //var openQuery = from bottle in Bottles.Bottles
            //                where bottle.DrinkByStart <= DateTime.Today.Year
            //                orderby bottle.DrinkByStart ascending, bottle.BottleName ascending
            //                select bottle;

            //listToOpen.Items.Clear();
            //foreach (Models.Bottle b in openQuery)
            //{
            //    listToOpen.Items.Add(b.ToOpenString());
            //}

            listToOpen.Items.Clear();
            List<Models.Bottle> updatedList = new List<Models.Bottle>();


            var openQuery = from bottle in Bottles.Bottles
                            where bottle.DrinkByStart <= DateTime.Today.Year
                            orderby bottle.DrinkByStart ascending, bottle.BottleName ascending
                            select bottle;

            foreach (Models.Bottle b in openQuery)
            {
                updatedList.Add(b);
            }

            foreach (Models.Bottle b in updatedList)
            {
                listToOpen.Items.Add(b.ToString());
            }



            /*Dashboard Panel Fields:
                *dashUserLbl- 
                * dashNameLbl- 
                * dashCellarCount- 
                * dashCellarValue- 
                * listToOpen- 
            */
        }

        private void BtnAddBottle_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CheckEdit();
            }

            if (btnAddBottle.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58))))))
            {
                AddBottleReset();
            }

            //Display the Add Bottle Panel
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = true;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;

            addName.Focus();

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
            SetInventory();
        }

        public void SetInventory()
        {
            if (isEditing)
            {
                CheckEdit();
            }

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
                * invFilterBy- ComboBox allowing for list sorting
                * invList- List of bottles in the collection
            */
            invFilterBy.SelectedIndex = 0;
            invFilterBy.SelectedIndex = 1;
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CheckEdit();
            }

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

            statBottleTotal.Text = $"{Bottles.BottleCount()}";
            statValueTotal.Text = $"{Bottles.TotalValue():C}";
            statAvgCost.Text = $"{Bottles.AvgBottleCost():C}";
            statAvgAge.Text = $"{Bottles.AvgBottleAge():F2} yrs";
            statAvgPeak.Text = $"{Bottles.AvgPeakYear()}";

            SetCountryChart();
            SetCategoryChart();
        }
        private void SetCountryChart()
        {
            List<string[]> data = Bottles.CountryBreakdown();
            //List<string[]> data = new List<string[]>();
            //data.Add(new string[] { "USA", "3" });
            //data.Add(new string[] { "France", "7" });
            //data.Add(new string[] { "Germany", "1" });
            //data.Add(new string[] { "Spain", "2" });
            //data.Add(new string[] { "Italy", "2" });

            statCountryChart.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series countries = null;

            foreach (System.Windows.Forms.DataVisualization.Charting.Series series in statCountryChart.Series)
            {
                if (series.Name == "Countries")
                {
                    countries = series;
                }
            }
            if (countries == null)
            {
                countries = new System.Windows.Forms.DataVisualization.Charting.Series("Countries");
                statCountryChart.Series.Add(countries);
            }

            countries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            statCountryChart.Series[0]["PieLabelStyle"] = "Inside";
            countries.IsValueShownAsLabel = true;

            foreach (string[] item in data)
            {
                countries.Points.AddXY(item[0], Convert.ToInt32(item[1]));
            }
        }
        private void SetCategoryChart()
        {
            int[] data = Bottles.CategoryBreakdown();
            //int[] data = new int[] { 3, 6, 4, 7, 9, 12, 4, 6 };
            statCategoryChart.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series categories = null;

            foreach (System.Windows.Forms.DataVisualization.Charting.Series series in statCategoryChart.Series)
            {
                if (series.Name == "Categories")
                {
                    categories = series;
                }
            }
            if (categories == null)
            {
                categories = new System.Windows.Forms.DataVisualization.Charting.Series("Categories");
                statCategoryChart.Series.Add(categories);
            }

            categories.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            statCategoryChart.Series[0]["PieLabelStyle"] = "Inside";
            categories.IsValueShownAsLabel = true;

            categories.Points.AddXY("Red Wine", data[0]);
            categories.Points.AddXY("Rose Wine", data[1]);
            categories.Points.AddXY("White Wine", data[2]);
            categories.Points.AddXY("Sparkling Wine", data[3]);
            categories.Points.AddXY("Dessert/Fortified Wine", data[4]);
            categories.Points.AddXY("Beer", data[5]);
            categories.Points.AddXY("Spirit", data[6]);
            categories.Points.AddXY("Other", data[7]);
            statCategoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            statCategoryChart.PaletteCustomColors = new Color[] 
            {Color.DarkRed, Color.Pink, Color.FromArgb(255,237,138), Color.DodgerBlue, Color.SaddleBrown, Color.FromArgb(130,130,130), Color.Purple, Color.Green};

            //hide label value if zero
            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in categories.Points)
            {
                if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) == 0)
                {
                    point.IsValueShownAsLabel = false;
                    string temp = point.AxisLabel;
                    point.AxisLabel = "";
                    point.LegendText = temp;
                }
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            BeforeClose();

            //Then terminate the application
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
            List<Models.Bottle> sortedList = new List<Models.Bottle>();

            switch (invFilterBy.SelectedIndex)
            {
                case 0:
                    var vintageQuery = from bottle in Bottles.Bottles
                                    orderby bottle.Vintage descending, bottle.BottleName ascending
                                    select bottle;

                    foreach (Models.Bottle b in vintageQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                case 1:
                    var nameQuery = from bottle in Bottles.Bottles
                                       orderby bottle.BottleName ascending
                                       select bottle;

                    foreach (Models.Bottle b in nameQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                case 2:
                    var originQuery = from bottle in Bottles.Bottles
                                       orderby bottle.Country ascending, bottle.Subregion ascending, bottle.BottleName ascending
                                       select bottle;

                    foreach (Models.Bottle b in originQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                case 3:
                    var typeQuery = from bottle in Bottles.Bottles
                                       orderby bottle.TypeCode ascending, bottle.BottleName ascending
                                       select bottle;

                    foreach (Models.Bottle b in typeQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                case 4:
                    var importanceQuery = from bottle in Bottles.Bottles
                                       orderby bottle.ImportanceCode ascending, bottle.BottleName ascending
                                       select bottle;

                    foreach (Models.Bottle b in importanceQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                case 5:
                    var drinkQuery = from bottle in Bottles.Bottles
                                       orderby bottle.DrinkByStart ascending, bottle.BottleName ascending
                                       select bottle;

                    foreach (Models.Bottle b in drinkQuery)
                    {
                        sortedList.Add(b);
                    }
                    break;
                default:
                    break;
            }
            Bottles.Bottles = sortedList;
            foreach (Models.Bottle b in Bottles.Bottles)
            {
                invList.Items.Add(b.ToString());
            }
        }

        private void InvList_DoubleClick(object sender, EventArgs e)
        {
            // Open Bottle Detail for the selected bottle
            BottleDetails details = new BottleDetails(this, Bottles.Bottles[invList.SelectedIndex]);
            details.Show();
        }

        private void AddRatingList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //Delete the selected rating after verification
                DialogResult answer = MessageBox.Show("Are you sure you want to delete the selected rating?", 
                    "Delete Rating?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (answer == DialogResult.OK)
                {
                    ratingsTemp.RemoveAt(addRatingList.SelectedIndex);
                    addRatingList.Items.RemoveAt(addRatingList.SelectedIndex);
                }
            }
        }

        private void BtnAddRating_Click(object sender, EventArgs e)
        {
            // Add rating to the ratings list from text in the pts and critic fields

            bool plus = addRatingPts.Text.Contains("+");

            if (addRatingPts.Text == "" || addRatingCritic.Text == "" || addRatingPts.Text == "pts" || addRatingCritic.Text == "critic")
            {
                MessageBox.Show("Please input rating points and critic.", "Invalid Input",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (!plus && (Convert.ToInt32(addRatingPts.Text) < 0 || Convert.ToInt32(addRatingPts.Text) > 100))
                    {
                        MessageBox.Show("Please input a valid rating value (0-100, may include).", "Invalid Input",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else if  (plus && (Convert.ToInt32(addRatingPts.Text.Remove(addRatingPts.Text.Length - 1, 1)) < 0 || Convert.ToInt32(addRatingPts.Text.Remove(addRatingPts.Text.Length - 1, 1)) > 100))
                    {
                        MessageBox.Show("Please input a valid rating value (0-100, may include).", "Invalid Input",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ratingsTemp.Add(new string[2] { addRatingPts.Text, addRatingCritic.Text });
                        addRatingList.Items.Add($"{addRatingPts.Text} {addRatingCritic.Text}");
                        addRatingPts.Text = "pts";
                        addRatingCritic.Text = "critic";
                        addRatingCritic.ForeColor = addRatingPts.ForeColor = SystemColors.ScrollBar;
                    }
                }
                catch
                {
                    MessageBox.Show("Please input a valid rating value (0-100, may include +).", "Invalid Input",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            addRatingPts.Focus();
        }

        private void BtnUploadLabel_Click(object sender, EventArgs e)
        {
            //Run the openFileDialog and retrieve label picture to input as the pic

            openFileDialog.Filter = "Image Files|*.gif;*.jpg;*.jpeg;*.bmp;*.png";
            openFileDialog.FileName = "";
            DialogResult clicked = openFileDialog.ShowDialog();

            if (clicked == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                try
                {
                    //Upload the label picture
                    addLabelPicture.ImageLocation = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Picture could not be uploaded. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            AddBottleReset();
        }

        private void AddBottleReset()
        {
            //Clear all fields after checking with user
            addName.Text = addProducer.Text = addVintage.Text = addCountry.Text = addRegion.Text =
                addStyle.Text = addSize.Text =  addCost.Text = addLocation.Text = addType.Text =
                addImportance.Text = addRatingList.Text = addNotes.Text = "";
            addLabelPicture.Image = Properties.Resources.Wine_Bottle;

            addDrinkByStart.Text = "year";
            addDrinkByEnd.Text = "year";
            addDrinkByPeak.Text = "year";
            addRatingPts.Text = "pts";
            addRatingCritic.Text = "critic";

            addDrinkByStart.ForeColor = addDrinkByEnd.ForeColor = addDrinkByPeak.ForeColor =
                addRatingPts.ForeColor = addRatingCritic.ForeColor = SystemColors.ScrollBar;

            ratingsTemp.Clear();
            addRatingList.Items.Clear();
            isEditing = false;

            addName.Focus();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addVintage.Text, out int i) && addVintage.Text != "N/V")
            {
                MessageBox.Show("Vintage must be an integer or \"N/V\".", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addSize.Items.Contains(addSize.Text))
            {
                MessageBox.Show("Please select a bottle size from the list.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(addDrinkByStart.Text, out i)|| !Int32.TryParse(addDrinkByEnd.Text, out i)|| !Int32.TryParse(addDrinkByPeak.Text, out i))
            {
                MessageBox.Show("Drink by years must be integers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Decimal.TryParse(addCost.Text, out decimal j))
            {
                MessageBox.Show("Cost must be numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addType.Items.Contains(addType.Text))
            {
                MessageBox.Show("Please select a category code from the list.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addImportance.Items.Contains(addImportance.Text))
            {
                MessageBox.Show("Please select an importance code from the list.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (Convert.ToInt32(addDrinkByPeak.Text) > Convert.ToInt32(addDrinkByEnd.Text))
            //{
            //    MessageBox.Show("Drink-by peak is later than the end of the drink-by window.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else if (addName.Text == "" || addProducer.Text == ""|| addVintage.Text == "" || addCountry.Text == "" || addRegion.Text == "" || addStyle.Text == ""
                || addDrinkByStart.Text == "" || addDrinkByEnd.Text == "" || addDrinkByPeak.Text == "" ||addCost.Text == "" || addLocation.Text == "" || addType.Text == ""
                || addImportance.Text == "")
            {
                MessageBox.Show("Please complete all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isEditing)
                {
                    bottles.Bottles.Remove(bottleBeingEdited);
                }
                AddBottle();
            }
        }

        private void AddVintage_TextChanged(object sender, EventArgs e)
        {
            addVintage.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void AddDrinkByStart_TextChanged(object sender, EventArgs e)
        {
            addDrinkByStart.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void AddDrinkByEnd_TextChanged(object sender, EventArgs e)
        {
            addDrinkByEnd.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void AddDrinkByPeak_TextChanged(object sender, EventArgs e)
        {
            addDrinkByPeak.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void AddRatingPts_TextChanged(object sender, EventArgs e)
        {
            addRatingPts.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void AddRatingCritic_TextChanged(object sender, EventArgs e)
        {
            addRatingCritic.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            //Brings up validation panel
            pin1.Text = pin2.Text = pin3.Text = pin4.Text = "";
            pnlUserMain.Visible = false;
            pnlUserPIN.Visible = true;
            pin1.Focus();
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            //Save Name, Username, and PIN, then show main user panel
            try
            {
                if ((newPIN1.Text + newPIN2.Text + newPIN3.Text + newPIN4.Text) != (confirm1.Text + confirm2.Text + confirm3.Text + confirm4.Text))
                {
                    MessageBox.Show("The PINs you have entered do not match.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (newPIN1.Text == ""|| newPIN2.Text == "" || newPIN3.Text == "" || newPIN4.Text == "" ||
                    firstName.Text == "" || lastName.Text == "" || username.Text == "")
                {
                    MessageBox.Show("Please complete all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Bottles.FirstName = firstName.Text;
                    Bottles.LastName = lastName.Text;
                    Bottles.UserName = username.Text;
                    Bottles.PinNumber = Convert.ToInt32(newPIN1.Text + newPIN2.Text + newPIN3.Text + newPIN4.Text);
                    pnlUserMain.Visible = true;
                    pnlUserEdit.Visible = false;
                    dashNameLbl.Text = $"{Bottles.FirstName} {Bottles.LastName}";
                    dashUserLbl.Text = Bottles.UserName;
                    subtitle.Text = $"{Bottles.FirstName} {Bottles.LastName}'s Cellar";
                }
            }
            catch
            {
                MessageBox.Show("The values you have entered are not allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSubmitUser_Click(object sender, EventArgs e)
        {
            //If PIN is correct, show change panel, and set current values to fields. Otherwise, show user panel
            try
            {
                if (Convert.ToInt32(pin1.Text + pin2.Text + pin3.Text + pin4.Text) == Bottles.PinNumber)
                {
                    pnlUserEdit.Visible = true;
                    pnlUserPIN.Visible = false;

                    firstName.Text = Bottles.FirstName;
                    lastName.Text = Bottles.LastName;
                    username.Text = Bottles.UserName;

                    int i = Bottles.PinNumber.ToString().Length;

                    switch (i)
                    {
                        case 1:
                            newPIN1.Text = newPIN2.Text = newPIN3.Text = "0";
                            newPIN4.Text = Bottles.PinNumber.ToString()[0].ToString();
                            confirm1.Text = confirm2.Text = confirm3.Text = "0";
                            confirm4.Text = Bottles.PinNumber.ToString()[0].ToString();
                            break;
                        case 2:
                            newPIN1.Text = newPIN2.Text = "0";
                            newPIN3.Text = Bottles.PinNumber.ToString()[0].ToString();
                            newPIN4.Text = Bottles.PinNumber.ToString()[1].ToString();
                            confirm1.Text = confirm2.Text = "0";
                            confirm3.Text = Bottles.PinNumber.ToString()[0].ToString();
                            confirm4.Text = Bottles.PinNumber.ToString()[1].ToString();
                            break;
                        case 3:
                            newPIN1.Text = "0";
                            newPIN2.Text = Bottles.PinNumber.ToString()[0].ToString();
                            newPIN3.Text = Bottles.PinNumber.ToString()[1].ToString();
                            newPIN4.Text = Bottles.PinNumber.ToString()[2].ToString();
                            confirm1.Text = "0";
                            confirm2.Text = Bottles.PinNumber.ToString()[0].ToString();
                            confirm3.Text = Bottles.PinNumber.ToString()[1].ToString();
                            confirm4.Text = Bottles.PinNumber.ToString()[2].ToString();
                            break;
                        default:
                            newPIN1.Text = Bottles.PinNumber.ToString()[0].ToString();
                            newPIN2.Text = Bottles.PinNumber.ToString()[1].ToString();
                            newPIN3.Text = Bottles.PinNumber.ToString()[2].ToString();
                            newPIN4.Text = Bottles.PinNumber.ToString()[3].ToString();
                            confirm1.Text = Bottles.PinNumber.ToString()[0].ToString();
                            confirm2.Text = Bottles.PinNumber.ToString()[1].ToString();
                            confirm3.Text = Bottles.PinNumber.ToString()[2].ToString();
                            confirm4.Text = Bottles.PinNumber.ToString()[3].ToString();
                            break;
                    }

                    firstName.Focus();
                }
                else
                {
                    MessageBox.Show("The PIN number you have entered is incorrect.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlUserMain.Visible = true;
                    pnlUserPIN.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("The PIN number you have entered is incorrect.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlUserMain.Visible = true;
                pnlUserPIN.Visible = false;
            }
        }

        private void BtnCancelUser_Click(object sender, EventArgs e)
        {
            //Show the main user panel without making changes
            pnlUserMain.Visible = true;
            pnlUserEdit.Visible = false;
        }

        private void NewPIN1_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(newPIN1);
        }
        private void NewPIN2_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(newPIN2);
        }
        private void NewPIN3_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(newPIN3);
        }
        private void NewPIN4_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(newPIN4);
        }
        private void NewPIN1_Enter(object sender, EventArgs e)
        {
            // Clear all of the items from the textboxes
            newPIN1.Text = newPIN2.Text = newPIN3.Text = newPIN4.Text = "";
        }
        private void Confirm1_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(confirm1);
        }
        private void Confirm2_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(confirm2);
        }
        private void Confirm3_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(confirm3);
        }
        private void Confirm4_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(confirm4);
        }
        private void Confirm1_Enter(object sender, EventArgs e)
        {
            // Clear all of the items from the textboxes
            confirm1.Text = confirm2.Text = confirm3.Text = confirm4.Text = "";
        }
        public void MoveCursor(TextBox txt)
        {
            if (txt.Text != "") { SelectNextControl(txt, true, false, true, false); }
        }
        private void Pin1_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(pin1);
        }
        private void Pin2_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(pin2);
        }
        private void Pin3_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(pin3);
        }
        private void Pin4_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(pin4);
        }

        private void CheckEdit()
        {
            if(isEditing)
            {
                DialogResult choice = MessageBox.Show("You are currently editing a bottle. Would you like to save the changes made to the bottle?", "Continue Editing?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(choice == DialogResult.Yes)
                {
                    int numBottles = bottles.Bottles.Count;
                    AddBottle();
                    if (bottles.Bottles.Count != numBottles)
                    {
                        bottles.Bottles.Remove(bottleBeingEdited);
                        isEditing = false;
                    }
                }
                else
                {
                    AddBottleReset();
                    isEditing = false;
                }
            }
        }

        private void AddBottle()
        {
            //Convert the contents of the ratings listBox to a list of string arrays

            if (addVintage.Text == "N/V")
            {
                addVintage.Text = "0";
            }

            //Add the bottle to the collection
            Models.Bottle newBottle = new Models.Bottle(addName.Text, addProducer.Text, Convert.ToInt32(addVintage.Text),
                addCountry.Text, addRegion.Text, addStyle.Text, addSize.Text, Convert.ToInt32(addDrinkByStart.Text),
                Convert.ToInt32(addDrinkByEnd.Text), Convert.ToInt32(addDrinkByPeak.Text), Convert.ToDecimal(addCost.Text),
                addLocation.Text, addType.SelectedIndex, addImportance.SelectedIndex, ratingsTemp, addNotes.Text,
                Serializer.SerializePhoto(addLabelPicture.Image));
            Bottles.Bottles.Add(newBottle);

            if (isEditing)
            {
                MessageBox.Show("The bottle has been updated!", "Bottle Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The bottle has been added to the collection!", "Bottle Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AddBottleReset();
        }

        public void EditBottle(Models.Bottle theBottle)
        {
            isEditing = true;
            bottleBeingEdited = theBottle;

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));

            dashboardPanel.Visible = false;
            addPanel.Visible = true;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;

            ratingsTemp.Clear();
            foreach (string[] item in theBottle.Ratings)
            {
                ratingsTemp.Add(item);
                addRatingList.Items.Add($"{item[0]} {item[1]}");
            }

            addName.Text = theBottle.BottleName;
            addProducer.Text = theBottle.Producer;
            if (theBottle.Vintage != 0)
            {
                addVintage.Text = theBottle.Vintage.ToString();
            }
            else
            {
                addVintage.Text = "N/V";
            }
            addCountry.Text = theBottle.Country;
            addRegion.Text = theBottle.Subregion;
            addStyle.Text = theBottle.StyleOrVarietal;
            addSize.Text = theBottle.Size;
            addDrinkByStart.Text = theBottle.DrinkByStart.ToString();
            addDrinkByEnd.Text = theBottle.DrinkByEnd.ToString();
            addDrinkByPeak.Text = theBottle.DrinkByPeak.ToString();
            addCost.Text = theBottle.Cost.ToString();
            addLocation.Text = theBottle.Location;
            addType.SelectedIndex = theBottle.TypeCode;
            addType.Text = addType.Items[theBottle.TypeCode].ToString();
            addImportance.SelectedIndex = theBottle.ImportanceCode;
            addImportance.Text = addImportance.Items[theBottle.ImportanceCode].ToString();
            addNotes.Text = theBottle.Notes;
            addLabelPicture.Image = Serializer.DeserializePhoto(theBottle.SerializedLabelImage);
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            //TO DO

            //Save, Log Out, and start at the StartPage again.
            BeforeClose();
            Hide();
            StartPage newStart = new StartPage();
            newStart.Show();
        }

        public void BeforeClose()
        {
            if (isEditing)
            {
                CheckEdit();
            }

            //Get and deserialize all collections in the DB into a list of collections
            List<Models.Collection> records = Serializer.GetCollections();

            //Delete the collection where username = bottles.Username
            foreach (Models.Collection record in records.ToList())
            {
                if (record.UserName == Bottles.UserName)
                {
                    records.Remove(record);
                }
            }

            //Add the current collection
            records.Add(Bottles);

            //Store them in the database
            Serializer.StoreCollections(records);
        }

        private void addPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
