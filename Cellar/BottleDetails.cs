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
    public partial class BottleDetails : Form
    {
        Models.Bottle theBottle;
        Dashboard theSender;

        public BottleDetails(Dashboard sender, Models.Bottle bottle)
        {
            InitializeComponent();

            if (bottle.Vintage != 0)
            {
                lblVintName.Text = $"{bottle.Vintage} {bottle.BottleName}";
            }
            else
            {
                lblVintName.Text = $"N/V {bottle.BottleName}";
            }
            lblProducer.Text = bottle.Producer;
            lblOrigin.Text = $"{bottle.Subregion}, {bottle.Country}";
            lblStyle.Text = $"{bottle.StyleOrVarietal}";
            lblDrinkRange.Text = $"{bottle.DrinkByStart} - {bottle.DrinkByEnd} (peak {bottle.DrinkByPeak})";
            lblSize.Text = bottle.Size;
            lblCost.Text = $"{bottle.Cost:C}";
            lblLocation.Text = bottle.Location;
            lblType.Text = GetCategoryText(bottle.TypeCode);
            lblImportance.Text = GetImportanceText(bottle.ImportanceCode);
            labelPicture.Image = Serializer.DeserializePhoto(bottle.SerializedLabelImage);
            txtRatings.Text = GetRatingText(bottle.Ratings);
            txtNotes.Text = bottle.Notes;

            theBottle = bottle;
            theSender = sender;
        }

        private string GetCategoryText(int index)
        {
            switch(index)
            {
                case 0:
                    return "Red Wine";
                case 1:
                    return "Rose Wine";
                case 2:
                    return "White Wine";
                case 3:
                    return "Sparkling Wine";
                case 4:
                    return "Dessert/Fortified Wine";
                case 5:
                    return "Beer";
                case 6:
                    return "Spirit";
                case 7:
                    return "Other";
                default:
                    return "";
            }
        }

        private string GetImportanceText(int index)
        {
            switch (index)
            {
                case 0:
                    return "Ceremonial";
                case 1:
                    return "Special";
                case 2:
                    return "Casual";
                case 3:
                    return "Everyday";
                default:
                    return "";
            }
        }

        private string GetRatingText(List<string[]> ratings)
        {
            string returnString = "";
            int i = 0;
            foreach (string[] rating in ratings)
            {
                if (i != 0)
                {
                    returnString += "\r\n";
                }
                returnString += $"{rating[0]} {rating[1]}";
                i++;
            }
            return returnString;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Edit this bottle?",
                "Edit Bottle", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (choice == DialogResult.OK)
            {
                theSender.EditBottle(theBottle);
                Hide();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete this bottle? Once deleted, this action cannot be undone.", 
                "Delete Bottle", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (choice == DialogResult.OK)
            {
                theSender.Bottles.Bottles.Remove(theBottle);
                theSender.SetInventory();
                Hide();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BottleDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
