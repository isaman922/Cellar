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
            this.panel2 = new System.Windows.Forms.Panel();
            this.subtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Location = new System.Drawing.Point(12, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 549);
            this.panel2.TabIndex = 1;
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.Linen;
            this.subtitle.Location = new System.Drawing.Point(141, 73);
            this.subtitle.MinimumSize = new System.Drawing.Size(600, 18);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(600, 18);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "Something Witty Here";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 722);
            this.MinimumSize = new System.Drawing.Size(898, 722);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brotherhood of Bacchus Cellar App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label subtitle;
    }
}

