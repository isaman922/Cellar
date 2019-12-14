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
            data = Serializer.GetCollections();
        }

        private void BtnCreateAcct_Click(object sender, EventArgs e)
        {
            //Verify info and create account

            Regex nameFormat = new Regex("[a-z|A-Z]+");
            Regex userFormat = new Regex("[a-z|A-Z|0-9]+");

            try
            {
                if (signUpUserA.Text != signUpUserB.Text)
                {
                    //Messagebox about username not matching
                    MessageBox.Show("The usernames you have entered do not match. Please try again.",
                                  "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetInput();
                }
                else if ((signUpPIN1A.Text != signUpPIN1B.Text) || (signUpPIN2A.Text != signUpPIN2B.Text) || (signUpPIN3A.Text != signUpPIN3B.Text) || (signUpPIN4A.Text != signUpPIN4B.Text))
                {
                    //Messagebox about PINs not matching
                    MessageBox.Show("The PINs you have entered do not match. Please try again.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetInput();
                }
                else if ((nameFormat.Match(signUpFName.Text).ToString() != signUpFName.Text ) || (nameFormat.Match(signUpLName.Text).ToString() != signUpLName.Text))
                {
                    //MessageBox about wrong format in names
                    MessageBox.Show("First and last names must contain only alphabetic characters. Please try again.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetInput();
                }
                else if (userFormat.Match(signUpUserA.Text).ToString() != signUpUserA.Text)
                {
                    //MessageBox about wrong format in username
                    MessageBox.Show("Username must contain only alphabetic or numeric characters. Please try again.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetInput();
                }
                else
                {
                    int pinNum = Convert.ToInt32(signUpPIN1A.Text + signUpPIN2A.Text + signUpPIN3A.Text + signUpPIN4A.Text);

                    //Verify info and login to account

                    //Check username against all usernames in list
                    bool uMatch = false;

                    foreach (Models.Collection c in data)
                    {
                        if (signUpUserA.Text == c.UserName)
                        {
                            uMatch = true;
                        }
                    }

                    if (!uMatch)
                    {
                        Dashboard d = new Dashboard(new Models.Collection(signUpFName.Text, signUpLName.Text, signUpUserA.Text, pinNum));
                        d.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("The username you selected is already in use. Please select a new username. Please try again.",
                                "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                //Shoe Messagebox Error about PIN
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("PIN must include only numbers", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ResetInput()
        {
            username.Text = pin1.Text = pin2.Text = pin3.Text = pin4.Text = signUpPIN1A.Text = signUpPIN2A.Text =
                signUpPIN3A.Text = signUpPIN4A.Text = signUpPIN1B.Text = signUpPIN2B.Text = signUpPIN3B.Text =
                signUpPIN4B.Text = signUpFName.Text = signUpLName.Text = signUpUserA.Text = signUpUserB.Text = "";
        }

        private void ShowSignIn_Click(object sender, EventArgs e)
        {
            //Makes the sign-in panel visible for current users
            signInPanel.Visible = true;
            ResetInput();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int pinNum = Convert.ToInt32(pin1.Text + pin2.Text + pin3.Text + pin4.Text);

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
                    //Check that PIN matches PIN for username
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
                        ResetInput();
                    }
                }
                else
                {
                    MessageBox.Show("The Username or password you entered is invalid. Please try again.",
                            "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetInput();
                }
            }
            catch
            {
                //Shoe Messagebox Error about PIN
                MessageBox.Show("PIN must include only numbers", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ResetInput();
            }
        }

        private void ShowSignUp_Click(object sender, EventArgs e)
        {
            //Makes the sign-up panel visible for new users
            signInPanel.Visible = false;
            ResetInput();
        }

        private void StartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void SignUpPIN1A_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN1A);
        }

        private void SignUpPIN2A_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN2A);
        }

        private void SignUpPIN3A_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN3A);
        }

        private void SignUpPIN4A_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN4A);
        }

        private void SignUpPIN1B_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN1B);
        }

        private void SignUpPIN2B_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN2B);
        }

        private void SignUpPIN3B_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN3B);
        }

        private void SignUpPIN4B_TextChanged(object sender, EventArgs e)
        {
            MoveCursor(signUpPIN4B);
        }
    }
}
