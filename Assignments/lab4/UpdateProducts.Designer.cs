namespace lab4
{
    partial class UpdateProducts
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.NumberTxtB = new System.Windows.Forms.TextBox();
            this.ObjNameTxtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuaTxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrTxtB = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductTypeGB = new System.Windows.Forms.GroupBox();
            this.VariableRb = new System.Windows.Forms.RadioButton();
            this.SimpleRb = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.InvNumTxtB = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product number";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(389, 35);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(200, 26);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(26, 101);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(65, 20);
            this.Number.TabIndex = 2;
            this.Number.Text = "Number";
            // 
            // NumberTxtB
            // 
            this.NumberTxtB.Location = new System.Drawing.Point(30, 138);
            this.NumberTxtB.Name = "NumberTxtB";
            this.NumberTxtB.Size = new System.Drawing.Size(200, 26);
            this.NumberTxtB.TabIndex = 3;
            // 
            // ObjNameTxtB
            // 
            this.ObjNameTxtB.Location = new System.Drawing.Point(30, 248);
            this.ObjNameTxtB.Name = "ObjNameTxtB";
            this.ObjNameTxtB.Size = new System.Drawing.Size(200, 26);
            this.ObjNameTxtB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Object name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // QuaTxtB
            // 
            this.QuaTxtB.Location = new System.Drawing.Point(34, 365);
            this.QuaTxtB.Name = "QuaTxtB";
            this.QuaTxtB.Size = new System.Drawing.Size(196, 26);
            this.QuaTxtB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // PrTxtB
            // 
            this.PrTxtB.Location = new System.Drawing.Point(311, 248);
            this.PrTxtB.Name = "PrTxtB";
            this.PrTxtB.Size = new System.Drawing.Size(130, 26);
            this.PrTxtB.TabIndex = 11;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(635, 35);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 42);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(327, 344);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 47);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Food",
            "Drinks"});
            this.checkedListBox1.Location = new System.Drawing.Point(494, 248);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 73);
            this.checkedListBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product catagories";
            // 
            // ProductTypeGB
            // 
            this.ProductTypeGB.Controls.Add(this.VariableRb);
            this.ProductTypeGB.Controls.Add(this.SimpleRb);
            this.ProductTypeGB.Location = new System.Drawing.Point(681, 230);
            this.ProductTypeGB.Name = "ProductTypeGB";
            this.ProductTypeGB.Size = new System.Drawing.Size(200, 100);
            this.ProductTypeGB.TabIndex = 16;
            this.ProductTypeGB.TabStop = false;
            this.ProductTypeGB.Text = "Product Type";
            this.ProductTypeGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VariableRb
            // 
            this.VariableRb.AutoSize = true;
            this.VariableRb.Location = new System.Drawing.Point(6, 56);
            this.VariableRb.Name = "VariableRb";
            this.VariableRb.Size = new System.Drawing.Size(92, 24);
            this.VariableRb.TabIndex = 1;
            this.VariableRb.TabStop = true;
            this.VariableRb.Text = "Variable";
            this.VariableRb.UseVisualStyleBackColor = true;
            this.VariableRb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SimpleRb
            // 
            this.SimpleRb.AutoSize = true;
            this.SimpleRb.Location = new System.Drawing.Point(6, 26);
            this.SimpleRb.Name = "SimpleRb";
            this.SimpleRb.Size = new System.Drawing.Size(82, 24);
            this.SimpleRb.TabIndex = 0;
            this.SimpleRb.TabStop = true;
            this.SimpleRb.Text = "Simple";
            this.SimpleRb.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(903, 188);
            this.dataGridView1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Inventory";
            // 
            // InvNumTxtB
            // 
            this.InvNumTxtB.Location = new System.Drawing.Point(681, 137);
            this.InvNumTxtB.Name = "InvNumTxtB";
            this.InvNumTxtB.Size = new System.Drawing.Size(178, 26);
            this.InvNumTxtB.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(945, 644);
            this.Controls.Add(this.InvNumTxtB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductTypeGB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PrTxtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuaTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ObjNameTxtB);
            this.Controls.Add(this.NumberTxtB);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProducts";
            this.Text = "UpdateProducts";
            this.Load += new System.EventHandler(this.SearchTxt_Load);
            this.ProductTypeGB.ResumeLayout(false);
            this.ProductTypeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox NumberTxtB;
        private System.Windows.Forms.TextBox ObjNameTxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuaTxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrTxtB;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ProductTypeGB;
        private System.Windows.Forms.RadioButton VariableRb;
        private System.Windows.Forms.RadioButton SimpleRb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InvNumTxtB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}