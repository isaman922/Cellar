namespace Cellar
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.showSignIn = new System.Windows.Forms.Label();
            this.signUpPIN4B = new System.Windows.Forms.TextBox();
            this.signUpPIN3B = new System.Windows.Forms.TextBox();
            this.signUpPIN2B = new System.Windows.Forms.TextBox();
            this.signUpPIN1B = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.signUpUserB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signUpFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signUpLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateAcct = new System.Windows.Forms.Button();
            this.signUpPIN4A = new System.Windows.Forms.TextBox();
            this.signUpPIN3A = new System.Windows.Forms.TextBox();
            this.signUpPIN2A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpPIN1A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpUserA = new System.Windows.Forms.TextBox();
            this.signInPanel = new System.Windows.Forms.Panel();
            this.showSignUp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pin4 = new System.Windows.Forms.TextBox();
            this.pin3 = new System.Windows.Forms.TextBox();
            this.pin2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pin1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.signUpPanel.SuspendLayout();
            this.signInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Pristina", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Linen;
            this.title.Location = new System.Drawing.Point(10, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(862, 91);
            this.title.TabIndex = 1;
            this.title.Text = "Brotherhood of Bacchus Cellar App";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.Linen;
            this.subtitle.Location = new System.Drawing.Point(141, 130);
            this.subtitle.MinimumSize = new System.Drawing.Size(600, 18);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(600, 18);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "Something Witty Here";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.Linen;
            this.signUpPanel.Controls.Add(this.showSignIn);
            this.signUpPanel.Controls.Add(this.signUpPIN4B);
            this.signUpPanel.Controls.Add(this.signUpPIN3B);
            this.signUpPanel.Controls.Add(this.signUpPIN2B);
            this.signUpPanel.Controls.Add(this.signUpPIN1B);
            this.signUpPanel.Controls.Add(this.label10);
            this.signUpPanel.Controls.Add(this.label9);
            this.signUpPanel.Controls.Add(this.signUpUserB);
            this.signUpPanel.Controls.Add(this.label8);
            this.signUpPanel.Controls.Add(this.signUpFName);
            this.signUpPanel.Controls.Add(this.label7);
            this.signUpPanel.Controls.Add(this.signUpLName);
            this.signUpPanel.Controls.Add(this.label6);
            this.signUpPanel.Controls.Add(this.btnCreateAcct);
            this.signUpPanel.Controls.Add(this.signUpPIN4A);
            this.signUpPanel.Controls.Add(this.signUpPIN3A);
            this.signUpPanel.Controls.Add(this.signUpPIN2A);
            this.signUpPanel.Controls.Add(this.label2);
            this.signUpPanel.Controls.Add(this.signUpPIN1A);
            this.signUpPanel.Controls.Add(this.label4);
            this.signUpPanel.Controls.Add(this.signUpUserA);
            this.signUpPanel.Location = new System.Drawing.Point(11, 192);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(860, 479);
            this.signUpPanel.TabIndex = 17;
            this.signUpPanel.Visible = false;
            // 
            // showSignIn
            // 
            this.showSignIn.AutoSize = true;
            this.showSignIn.BackColor = System.Drawing.Color.Linen;
            this.showSignIn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSignIn.Location = new System.Drawing.Point(211, 445);
            this.showSignIn.MinimumSize = new System.Drawing.Size(438, 24);
            this.showSignIn.Name = "showSignIn";
            this.showSignIn.Size = new System.Drawing.Size(438, 24);
            this.showSignIn.TabIndex = 13;
            this.showSignIn.Text = "Already have an account? Click here.";
            this.showSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showSignIn.Click += new System.EventHandler(this.ShowSignIn_Click);
            // 
            // signUpPIN4B
            // 
            this.signUpPIN4B.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN4B.Location = new System.Drawing.Point(591, 277);
            this.signUpPIN4B.MaxLength = 1;
            this.signUpPIN4B.Name = "signUpPIN4B";
            this.signUpPIN4B.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN4B.TabIndex = 11;
            this.signUpPIN4B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpPIN3B
            // 
            this.signUpPIN3B.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN3B.Location = new System.Drawing.Point(554, 277);
            this.signUpPIN3B.MaxLength = 1;
            this.signUpPIN3B.Name = "signUpPIN3B";
            this.signUpPIN3B.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN3B.TabIndex = 10;
            this.signUpPIN3B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpPIN2B
            // 
            this.signUpPIN2B.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN2B.Location = new System.Drawing.Point(517, 277);
            this.signUpPIN2B.MaxLength = 1;
            this.signUpPIN2B.Name = "signUpPIN2B";
            this.signUpPIN2B.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN2B.TabIndex = 9;
            this.signUpPIN2B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpPIN1B
            // 
            this.signUpPIN1B.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN1B.Location = new System.Drawing.Point(480, 277);
            this.signUpPIN1B.MaxLength = 1;
            this.signUpPIN1B.Name = "signUpPIN1B";
            this.signUpPIN1B.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN1B.TabIndex = 8;
            this.signUpPIN1B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Linen;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Confirm PIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Confirm Username";
            // 
            // signUpUserB
            // 
            this.signUpUserB.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpUserB.Location = new System.Drawing.Point(479, 198);
            this.signUpUserB.Name = "signUpUserB";
            this.signUpUserB.Size = new System.Drawing.Size(202, 30);
            this.signUpUserB.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Linen;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "First Name";
            // 
            // signUpFName
            // 
            this.signUpFName.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpFName.Location = new System.Drawing.Point(183, 119);
            this.signUpFName.Name = "signUpFName";
            this.signUpFName.Size = new System.Drawing.Size(202, 30);
            this.signUpFName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Linen;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Last Name";
            // 
            // signUpLName
            // 
            this.signUpLName.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLName.Location = new System.Drawing.Point(479, 119);
            this.signUpLName.Name = "signUpLName";
            this.signUpLName.Size = new System.Drawing.Size(202, 30);
            this.signUpLName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = "New User Sign-Up";
            // 
            // btnCreateAcct
            // 
            this.btnCreateAcct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnCreateAcct.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcct.ForeColor = System.Drawing.Color.Linen;
            this.btnCreateAcct.Location = new System.Drawing.Point(211, 354);
            this.btnCreateAcct.Name = "btnCreateAcct";
            this.btnCreateAcct.Size = new System.Drawing.Size(438, 88);
            this.btnCreateAcct.TabIndex = 12;
            this.btnCreateAcct.Text = "Create Account";
            this.btnCreateAcct.UseVisualStyleBackColor = false;
            this.btnCreateAcct.Click += new System.EventHandler(this.BtnCreateAcct_Click);
            // 
            // signUpPIN4A
            // 
            this.signUpPIN4A.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN4A.Location = new System.Drawing.Point(295, 277);
            this.signUpPIN4A.MaxLength = 1;
            this.signUpPIN4A.Name = "signUpPIN4A";
            this.signUpPIN4A.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN4A.TabIndex = 7;
            this.signUpPIN4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpPIN3A
            // 
            this.signUpPIN3A.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN3A.Location = new System.Drawing.Point(258, 277);
            this.signUpPIN3A.MaxLength = 1;
            this.signUpPIN3A.Name = "signUpPIN3A";
            this.signUpPIN3A.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN3A.TabIndex = 6;
            this.signUpPIN3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpPIN2A
            // 
            this.signUpPIN2A.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN2A.Location = new System.Drawing.Point(221, 277);
            this.signUpPIN2A.MaxLength = 1;
            this.signUpPIN2A.Name = "signUpPIN2A";
            this.signUpPIN2A.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN2A.TabIndex = 5;
            this.signUpPIN2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // signUpPIN1A
            // 
            this.signUpPIN1A.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPIN1A.Location = new System.Drawing.Point(184, 277);
            this.signUpPIN1A.MaxLength = 1;
            this.signUpPIN1A.Name = "signUpPIN1A";
            this.signUpPIN1A.Size = new System.Drawing.Size(31, 30);
            this.signUpPIN1A.TabIndex = 4;
            this.signUpPIN1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "PIN";
            // 
            // signUpUserA
            // 
            this.signUpUserA.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpUserA.Location = new System.Drawing.Point(182, 198);
            this.signUpUserA.Name = "signUpUserA";
            this.signUpUserA.Size = new System.Drawing.Size(202, 30);
            this.signUpUserA.TabIndex = 2;
            // 
            // signInPanel
            // 
            this.signInPanel.BackColor = System.Drawing.Color.Linen;
            this.signInPanel.Controls.Add(this.showSignUp);
            this.signInPanel.Controls.Add(this.label13);
            this.signInPanel.Controls.Add(this.btnLogin);
            this.signInPanel.Controls.Add(this.pin4);
            this.signInPanel.Controls.Add(this.pin3);
            this.signInPanel.Controls.Add(this.pin2);
            this.signInPanel.Controls.Add(this.label14);
            this.signInPanel.Controls.Add(this.pin1);
            this.signInPanel.Controls.Add(this.label15);
            this.signInPanel.Controls.Add(this.username);
            this.signInPanel.Location = new System.Drawing.Point(11, 192);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(860, 479);
            this.signInPanel.TabIndex = 0;
            // 
            // showSignUp
            // 
            this.showSignUp.AutoSize = true;
            this.showSignUp.BackColor = System.Drawing.Color.Linen;
            this.showSignUp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSignUp.Location = new System.Drawing.Point(211, 445);
            this.showSignUp.MinimumSize = new System.Drawing.Size(438, 24);
            this.showSignUp.Name = "showSignUp";
            this.showSignUp.Size = new System.Drawing.Size(438, 24);
            this.showSignUp.TabIndex = 6;
            this.showSignUp.Text = "Don\'t have an account? Click here to sign up.";
            this.showSignUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showSignUp.Click += new System.EventHandler(this.ShowSignUp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Linen;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 34);
            this.label13.TabIndex = 18;
            this.label13.Text = "Current User Sign-In";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Linen;
            this.btnLogin.Location = new System.Drawing.Point(211, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(438, 88);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pin4
            // 
            this.pin4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin4.Location = new System.Drawing.Point(444, 258);
            this.pin4.MaxLength = 1;
            this.pin4.Name = "pin4";
            this.pin4.Size = new System.Drawing.Size(31, 30);
            this.pin4.TabIndex = 4;
            this.pin4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pin3
            // 
            this.pin3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin3.Location = new System.Drawing.Point(407, 258);
            this.pin3.MaxLength = 1;
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(31, 30);
            this.pin3.TabIndex = 3;
            this.pin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pin2
            // 
            this.pin2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin2.Location = new System.Drawing.Point(370, 258);
            this.pin2.MaxLength = 1;
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(31, 30);
            this.pin2.TabIndex = 2;
            this.pin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Linen;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(328, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 24);
            this.label14.TabIndex = 9;
            this.label14.Text = "Username";
            // 
            // pin1
            // 
            this.pin1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin1.Location = new System.Drawing.Point(333, 258);
            this.pin1.MaxLength = 1;
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(31, 30);
            this.pin1.TabIndex = 1;
            this.pin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Linen;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(329, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "PIN";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(331, 179);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(202, 30);
            this.username.TabIndex = 0;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 683);
            this.Controls.Add(this.signInPanel);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 722);
            this.MinimumSize = new System.Drawing.Size(898, 722);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brotherhood of Bacchus Cellar App";
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label title;
        protected System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Panel signUpPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signUpFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signUpLName;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnCreateAcct;
        private System.Windows.Forms.TextBox signUpPIN4A;
        private System.Windows.Forms.TextBox signUpPIN3A;
        private System.Windows.Forms.TextBox signUpPIN2A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signUpPIN1A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signUpUserA;
        private System.Windows.Forms.Label showSignIn;
        private System.Windows.Forms.TextBox signUpPIN4B;
        private System.Windows.Forms.TextBox signUpPIN3B;
        private System.Windows.Forms.TextBox signUpPIN2B;
        private System.Windows.Forms.TextBox signUpPIN1B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox signUpUserB;
        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Label showSignUp;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox pin4;
        private System.Windows.Forms.TextBox pin3;
        private System.Windows.Forms.TextBox pin2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pin1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox username;
    }
}

