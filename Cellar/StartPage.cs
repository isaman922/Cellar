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
        public StartPage()
        {
            InitializeComponent();
        }

        private void BtnCreateAcct_Click(object sender, EventArgs e)
        {
            //Verify info and create account
        }

        private void ShowSignIn_Click(object sender, EventArgs e)
        {
            //Hide this panel and show the sign-in one
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Verify info and login to account
        }

        private void ShowSignUp_Click(object sender, EventArgs e)
        {
            //Hide this panel and show sign-up panel
        }
    }
}
