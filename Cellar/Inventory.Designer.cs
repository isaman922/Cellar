namespace Cellar
{
    partial class Inventory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAddBottle = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.dashboard1 = new System.Windows.Forms.Panel();
            this.filterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.dashboard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.btnStats);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnAddBottle);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 549);
            this.panel1.TabIndex = 0;
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnStats.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.Linen;
            this.btnStats.Location = new System.Drawing.Point(3, 411);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(256, 135);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnInventory.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Linen;
            this.btnInventory.Location = new System.Drawing.Point(3, 275);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(256, 135);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnAddBottle
            // 
            this.btnAddBottle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnAddBottle.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBottle.ForeColor = System.Drawing.Color.Linen;
            this.btnAddBottle.Location = new System.Drawing.Point(3, 139);
            this.btnAddBottle.Name = "btnAddBottle";
            this.btnAddBottle.Size = new System.Drawing.Size(256, 135);
            this.btnAddBottle.TabIndex = 1;
            this.btnAddBottle.Text = "Add a Bottle";
            this.btnAddBottle.UseVisualStyleBackColor = false;
            this.btnAddBottle.Click += new System.EventHandler(this.BtnAddBottle_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            this.btnDashboard.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Linen;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(256, 135);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Pristina", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Linen;
            this.title.Location = new System.Drawing.Point(100, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(682, 71);
            this.title.TabIndex = 1;
            this.title.Text = "Brotherhood of Bacchus Cellar App";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.Linen;
            this.subtitle.Location = new System.Drawing.Point(191, 73);
            this.subtitle.MinimumSize = new System.Drawing.Size(500, 29);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(500, 29);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "Daniel Isaman\'s Cellar";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Linen;
            this.dashboard1.Controls.Add(this.filterBy);
            this.dashboard1.Controls.Add(this.label2);
            this.dashboard1.Controls.Add(this.label1);
            this.dashboard1.Controls.Add(this.invList);
            this.dashboard1.Location = new System.Drawing.Point(280, 122);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(590, 549);
            this.dashboard1.TabIndex = 5;
            // 
            // filterBy
            // 
            this.filterBy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBy.FormattingEnabled = true;
            this.filterBy.Items.AddRange(new object[] {
            "Vintage",
            "Name",
            "Country",
            "Category",
            "Importance",
            "Drink-By Window"});
            this.filterBy.Location = new System.Drawing.Point(79, 9);
            this.filterBy.Name = "filterBy";
            this.filterBy.Size = new System.Drawing.Size(503, 26);
            this.filterBy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Double-click to view details)";
            // 
            // invList
            // 
            this.invList.BackColor = System.Drawing.Color.Linen;
            this.invList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invList.FormattingEnabled = true;
            this.invList.ItemHeight = 18;
            this.invList.Items.AddRange(new object[] {
            "Wine 1 listed as .ToString()",
            "Wine 2 listed as .ToString()",
            "Wine 3 listed as .ToString()",
            "2010 Chateau Pape Clement, Bordeaux, France, Drink 2035 - 2055; Ceremonial"});
            this.invList.Location = new System.Drawing.Point(8, 44);
            this.invList.Name = "invList";
            this.invList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invList.Size = new System.Drawing.Size(574, 452);
            this.invList.TabIndex = 0;
            this.invList.DoubleClick += new System.EventHandler(this.InvList_DoubleClick);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 683);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 722);
            this.MinimumSize = new System.Drawing.Size(898, 722);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brotherhood of Bacchus Cellar App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_FormClosed);
            this.panel1.ResumeLayout(false);
            this.dashboard1.ResumeLayout(false);
            this.dashboard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnStats;
        protected System.Windows.Forms.Button btnInventory;
        protected System.Windows.Forms.Button btnAddBottle;
        protected System.Windows.Forms.Button btnDashboard;
        protected System.Windows.Forms.Label title;
        protected System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Panel dashboard1;
        private System.Windows.Forms.ComboBox filterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox invList;
    }
}

