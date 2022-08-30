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
            this.Num = new System.Windows.Forms.Label();
            this.Quantityl = new System.Windows.Forms.Label();
            this.Namel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.Num);
            this.panel1.Controls.Add(this.Quantityl);
            this.panel1.Controls.Add(this.Namel);
            this.panel1.Location = new System.Drawing.Point(35, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 280);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.label1_Click);
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Num.Location = new System.Drawing.Point(24, 196);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(92, 25);
            this.Num.TabIndex = 4;
            this.Num.Text = "Number: ";
            this.Num.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Quantityl
            // 
            this.Quantityl.AutoSize = true;
            this.Quantityl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantityl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quantityl.Location = new System.Drawing.Point(24, 121);
            this.Quantityl.Name = "Quantityl";
            this.Quantityl.Size = new System.Drawing.Size(96, 25);
            this.Quantityl.TabIndex = 2;
            this.Quantityl.Text = "Quantity: ";
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Namel.Location = new System.Drawing.Point(24, 46);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(75, 25);
            this.Namel.TabIndex = 0;
            this.Namel.Text = "Name: ";
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(448, 359);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.DoubleClick += new System.EventHandler(this.UserControl5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Quantityl;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label Num;
    }
}
