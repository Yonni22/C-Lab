namespace lab4
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispalyProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.catagoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.updateProductsToolStripMenuItem,
            this.searchProductsToolStripMenuItem,
            this.dispalyProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.productsToolStripMenuItem.Text = "Products ";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // catagoriesToolStripMenuItem
            // 
            this.catagoriesToolStripMenuItem.Name = "catagoriesToolStripMenuItem";
            this.catagoriesToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.catagoriesToolStripMenuItem.Text = "Catagories";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addProductsToolStripMenuItem.Text = "Add products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // updateProductsToolStripMenuItem
            // 
            this.updateProductsToolStripMenuItem.Name = "updateProductsToolStripMenuItem";
            this.updateProductsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateProductsToolStripMenuItem.Text = "Update products";
            // 
            // searchProductsToolStripMenuItem
            // 
            this.searchProductsToolStripMenuItem.Name = "searchProductsToolStripMenuItem";
            this.searchProductsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchProductsToolStripMenuItem.Text = "Search products";
            this.searchProductsToolStripMenuItem.Click += new System.EventHandler(this.searchProductsToolStripMenuItem_Click);
            // 
            // dispalyProductsToolStripMenuItem
            // 
            this.dispalyProductsToolStripMenuItem.Name = "dispalyProductsToolStripMenuItem";
            this.dispalyProductsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dispalyProductsToolStripMenuItem.Text = "Dispaly products";
            this.dispalyProductsToolStripMenuItem.Click += new System.EventHandler(this.dispalyProductsToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispalyProductsToolStripMenuItem;
    }
}