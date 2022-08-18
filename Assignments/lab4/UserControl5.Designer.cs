namespace lab4
{
    partial class UserControl5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namel = new System.Windows.Forms.Label();
            this.Inventoryl = new System.Windows.Forms.Label();
            this.Quantityl = new System.Windows.Forms.Label();
            this.Pricel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pricel);
            this.panel1.Controls.Add(this.Quantityl);
            this.panel1.Controls.Add(this.Inventoryl);
            this.panel1.Controls.Add(this.Namel);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 301);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Location = new System.Drawing.Point(24, 46);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(59, 20);
            this.Namel.TabIndex = 0;
            this.Namel.Text = "Name: ";
            // 
            // Inventoryl
            // 
            this.Inventoryl.AutoSize = true;
            this.Inventoryl.Location = new System.Drawing.Point(24, 225);
            this.Inventoryl.Name = "Inventoryl";
            this.Inventoryl.Size = new System.Drawing.Size(82, 20);
            this.Inventoryl.TabIndex = 1;
            this.Inventoryl.Text = "Inventory: ";
            // 
            // Quantityl
            // 
            this.Quantityl.AutoSize = true;
            this.Quantityl.Location = new System.Drawing.Point(24, 143);
            this.Quantityl.Name = "Quantityl";
            this.Quantityl.Size = new System.Drawing.Size(76, 20);
            this.Quantityl.TabIndex = 2;
            this.Quantityl.Text = "Quantity: ";
            // 
            // Pricel
            // 
            this.Pricel.AutoSize = true;
            this.Pricel.Location = new System.Drawing.Point(24, 183);
            this.Pricel.Name = "Pricel";
            this.Pricel.Size = new System.Drawing.Size(52, 20);
            this.Pricel.TabIndex = 3;
            this.Pricel.Text = "Price: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(403, 339);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Pricel;
        private System.Windows.Forms.Label Quantityl;
        private System.Windows.Forms.Label Inventoryl;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label label1;
    }
}
