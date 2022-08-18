namespace lab4
{
    partial class Menu
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Indicator = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Searchbtn);
            this.panel1.Controls.Add(this.Indicator);
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Displaybtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 665);
            this.panel1.TabIndex = 0;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.Salmon;
            this.ViewPanel.Controls.Add(this.flowLayoutPanel1);
            this.ViewPanel.Location = new System.Drawing.Point(243, 12);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1030, 665);
            this.ViewPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 618);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Displaybtn
            // 
            this.Displaybtn.Location = new System.Drawing.Point(31, 71);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(140, 39);
            this.Displaybtn.TabIndex = 0;
            this.Displaybtn.Text = "Display";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(31, 139);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(140, 39);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(31, 274);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(140, 39);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(31, 207);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(140, 39);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(47, 350);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(106, 39);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Indicator
            // 
            this.Indicator.Location = new System.Drawing.Point(4, 81);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(21, 29);
            this.Indicator.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 1050);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Indicator;
    }
}