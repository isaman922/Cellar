using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            dashUserLbl.Text = bottles.UserName;
            dashNameLbl.Text = $"{bottles.FirstName} {bottles.LastName}";
            dashCellarCount.Text = bottles.BottleCount().ToString();
            dashCellarValue.Text = $"{bottles.TotalValue().ToString():C}";

            var openQuery = from bottle in bottles.Bottles
                            where bottle.DrinkByStart <= DateTime.Today.Year
                            orderby bottle.DrinkByStart descending , bottle.BottleName ascending
                            select bottle;

            listToOpen.Items.Clear();
            foreach (Models.Bottle b in openQuery)
            {
                listToOpen.Items.Add(b.ToOpenString());
            }

            dashboardPanel.Visible = true;
            addPanel.Visible = false;
            inventoryPanel.Visible = false;
            statsPanel.Visible = false;
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

            dashUserLbl.Text = bottles.UserName;
            dashNameLbl.Text = $"{bottles.FirstName} {bottles.LastName}";
            dashCellarCount.Text = bottles.BottleCount().ToString();
            dashCellarValue.Text = $"{bottles.TotalValue().ToString():C}";

            var openQuery = from bottle in bottles.Bottles
                            where bottle.DrinkByStart <= DateTime.Today.Year
                            orderby bottle.DrinkByStart descending, bottle.BottleName ascending
                            select bottle;
            foreach (Models.Bottle b in openQuery)
            {
                listToOpen.Items.Add(b.ToOpenString());
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
                * invFilterBy- ComboBox allowing for list sorting
                * invList- List of bottles in the collection
            */
            invList.Items.Clear();
            foreach (Models.Bottle b in bottles.Bottles)
            {
                invList.Items.Add(b.ToString());
            }
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
            statAvgAge.Text = $"{bottles.AvgBottleAge():F2} yrs";
            statAvgPeak.Text = $"{bottles.AvgPeakYear()}";

            SetCountryChart();
            SetCategoryChart();
        }

        private void SetCountryChart()
        {
            //List<string[]> data = //bottles.CountryBreakdown();
            List<string[]> data = new List<string[]>();
            data.Add(new string[] { "USA", "3" });
            data.Add(new string[] { "France", "7" });
            data.Add(new string[] { "Germany", "1" });
            data.Add(new string[] { "Spain", "2" });
            data.Add(new string[] { "Italy", "2" });

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
            //int[] data = bottles.CategoryBreakdown();
            int[] data = new int[] { 3, 6, 4, 7, 9, 12, 4, 6 };
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
            {Color.DarkRed, Color.Pink, Color.LightYellow, Color.DodgerBlue, Color.SaddleBrown, Color.Green, Color.Purple, Color.FromArgb(64,64,64)};

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
            //Get and deserialize all collections in the DB into a list of collections
            List<Models.Collection> records = Serializer.GetCollections();

            //Delete the collection where username = bottles.Username
            foreach (Models.Collection record in records.ToList())
            {
                if (record.UserName == bottles.UserName)
                {
                    records.Remove(record);
                }
            }

            //Add the current collection
            records.Add(bottles);

            //Store them in the database
            Serializer.StoreCollections(records);

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

            switch (invFilterBy.SelectedText)
            {
                case "Vintage":
                    bottles.Bottles = bottles.Bottles.OrderByDescending(o => o.Vintage).ToList();
                    break;
                case "Name":
                    bottles.Bottles = bottles.Bottles.OrderBy(o => o.BottleName).ToList();
                    break;
                case "Country":
                    bottles.Bottles = bottles.Bottles.OrderBy(o => o.Country).ToList();
                    break;
                case "Category":
                    bottles.Bottles = bottles.Bottles.OrderBy(o => o.TypeCode).ToList();
                    break;
                case "Importance":
                    bottles.Bottles = bottles.Bottles.OrderBy(o => o.ImportanceCode).ToList();
                    break;
                case "Drink-by Window":
                    bottles.Bottles = bottles.Bottles.OrderBy(o => o.DrinkByStart).ToList();
                    break;
                default:
                    break;
            }
            foreach (Models.Bottle b in bottles.Bottles)
            {
                invList.Items.Add(b.ToString());
            }
        }

        private void InvList_DoubleClick(object sender, EventArgs e)
        {
            // Open Bottle Detail for the selected bottle
            BottleDetails details = new BottleDetails(bottles.Bottles[invList.SelectedIndex]);
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
                    addRatingList.Items.RemoveAt(addRatingList.SelectedIndex);
                }
            }
        }

        private void BtnAddRating_Click(object sender, EventArgs e)
        {
            // Add rating to the ratings list from text in the pts and critic fields

            Regex checkPts = new Regex("[/d|/d/d|/d/d/d|+]");

            if (addRatingPts.Text == "" || addRatingCritic.Text == "" || addRatingPts.Text == "pts" || addRatingCritic.Text == "critic")
            {
                MessageBox.Show("Please input a valid rating value.", "Invalid Input",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else if (checkPts.Match(addRatingPts.Text).ToString() != addRatingPts.Text)
            {
                MessageBox.Show("Please input rating points and critic.", "Invalid Input",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                addRatingList.Items.Add(new string[2] { addRatingPts.Text, addRatingCritic.Text });
            }
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
                    //Upload the picture
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
                addStyle.Text = addSize.Text = addDrinkByStart.Text = addDrinkByEnd.Text =
                addDrinkByPeak.Text = addCost.Text = addLocation.Text = addType.Text =
                addImportance.Text = addRatingPts.Text = addRatingCritic.Text = addNotes.Text =
                addRatingList.Text = addNotes.Text = default;
            addLabelPicture.Image = Properties.Resources.Wine_Bottle;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Convert the contents of the ratings listBox to a list of string arrays
            List<string[]> ratingsList = new List<string[]>();
            for (int i = 0; i < addRatingList.Items.Count; i++)
            {
                ratingsList.Add(addRatingList.Items[i] as string[]);
            }

            //Add the bottle to the collection
            Models.Bottle newBottle = new Models.Bottle(addName.Text, addProducer.Text, Convert.ToInt32(addVintage.Text),
                addCountry.Text, addRegion.Text, addStyle.Text, addSize.Text, Convert.ToInt32(addDrinkByStart.Text),
                Convert.ToInt32(addDrinkByEnd.Text), Convert.ToInt32(addDrinkByPeak.Text), Convert.ToDecimal(addCost.Text),
                addLocation.Text, addType.SelectedIndex, addImportance.SelectedIndex, ratingsList, addNotes.Text,
                Serializer.SerializePhoto(addLabelPicture.Image));
            bottles.Bottles.Add(newBottle);

            MessageBox.Show("The bottle has been added to the collection!", "Bottle Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddBottleReset();
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
            pnlUserMain.Visible = false;
            pnlUserPIN.Visible = true;
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
                    bottles.FirstName = firstName.Text;
                    bottles.LastName = lastName.Text;
                    bottles.UserName = username.Text;
                    bottles.PinNumber = Convert.ToInt32(newPIN1.Text + newPIN2.Text + newPIN3.Text + newPIN4.Text);
                    pnlUserMain.Visible = true;
                    pnlUserEdit.Visible = false;
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
                if (Convert.ToInt32(pin1.Text + pin2.Text + pin3.Text + pin4.Text) == bottles.PinNumber)
                {
                    pnlUserEdit.Visible = true;
                    pnlUserPIN.Visible = false;
                }
                else
                {
                    MessageBox.Show("The PIN number you have entered is inccorect.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlUserMain.Visible = true;
                    pnlUserPIN.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("The PIN number you have entered is inccorect.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
