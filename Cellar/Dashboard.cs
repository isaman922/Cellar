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
        string[,] ratingsList;

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
            statAvgAge.Text = $"{bottles.AvgBottleAge():D2} yrs";
            statAvgPeak.Text = $"{bottles.AvgPeakYear()}";

            //TO DO
            //Update Charts

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Get and deserialize all collections in the DB into a list of collections
            List<Models.Collection> records = Serializer.GetCollections();

            //Delete the collection where username = bottles.Username
            foreach (Models.Collection record in records)
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
            //TO DO
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
            addLabelPicture.Image = default;
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
