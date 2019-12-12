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
    public partial class StartPage : Form
    {
        List<Models.Collection> data = new List<Models.Collection>();

        public StartPage()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            //Get's collections and adds them to the data list

            //TO TEST
            data.Add(new Models.Collection("Test", "Person", "test", 1234));
        }
        private void BtnCreateAcct_Click(object sender, EventArgs e)
        {
            //Verify info and create account
        }

        private void ShowSignIn_Click(object sender, EventArgs e)
        {
            //Makes the sign-in panel visible for current users
            signInPanel.Visible = true;
            signUpPanel.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int pinNum = Convert.ToInt32(pin1.Text + pin2 + pin3 + pin4);

                //Verify info and login to account

                //Check username against all usernames in list
                Models.Collection theCollection = null;
                bool uMatch = false;

                foreach (Models.Collection c in data)
                {
                    if (username.Text == c.UserName)
                    {
                        uMatch = true;
                        theCollection = c;
                    }
                }

                if (uMatch)
                {
                    //CheckBox that PIN matches PIN for username
                    if (theCollection.PinNumber == pinNum)
                    {
                        //If so, open the Dashboard using the collection
                        Dashboard d = new Dashboard(theCollection);
                        d.Show();
                        Hide();
                    }
                    else
                    {
                        //Otherwise, show that they do not match
                        MessageBox.Show("The Username or password you entered is invalid. Please try again.", 
                            "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("The Username or password you entered is invalid. Please try again.",
                            "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                //Shoe Messagebox Error about PIN
                MessageBox.Show("PIN must include only numbers", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ShowSignUp_Click(object sender, EventArgs e)
        {
            //Makes the sign-up panel visible for new users
            signUpPanel.Visible = true;
            signInPanel.Visible = false;
        }
    }
}
