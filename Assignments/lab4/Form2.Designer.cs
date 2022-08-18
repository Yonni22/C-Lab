namespace lab4
{
    partial class form
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
            this.number = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.objectname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.isavalaible = new System.Windows.Forms.CheckBox();
            this.DisplaysTable = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Chk = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.ErrorProvider(this.components);
            this.N = new System.Windows.Forms.ErrorProvider(this.components);
            this.P = new System.Windows.Forms.ErrorProvider(this.components);
            this.I = new System.Windows.Forms.ErrorProvider(this.components);
            this.C = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaysTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(48, 85);
            this.number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(182, 26);
            this.number.TabIndex = 1;
            this.number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(48, 385);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(201, 35);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(610, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inventory number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(617, 84);
            this.inventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(282, 26);
            this.inventory.TabIndex = 4;
            this.inventory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(290, 85);
            this.date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(271, 26);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // objectname
            // 
            this.objectname.Location = new System.Drawing.Point(48, 205);
            this.objectname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectname.Name = "objectname";
            this.objectname.Size = new System.Drawing.Size(578, 26);
            this.objectname.TabIndex = 8;
            this.objectname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Object name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(390, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(48, 325);
            this.count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(302, 26);
            this.count.TabIndex = 12;
            this.count.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(398, 325);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(226, 26);
            this.price.TabIndex = 13;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(398, 385);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(228, 35);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // isavalaible
            // 
            this.isavalaible.AutoSize = true;
            this.isavalaible.Location = new System.Drawing.Point(684, 408);
            this.isavalaible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isavalaible.Name = "isavalaible";
            this.isavalaible.Size = new System.Drawing.Size(113, 24);
            this.isavalaible.TabIndex = 15;
            this.isavalaible.Text = "Is avaliable";
            this.isavalaible.UseVisualStyleBackColor = true;
            this.isavalaible.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DisplaysTable
            // 
            this.DisplaysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplaysTable.Location = new System.Drawing.Point(1, 440);
            this.DisplaysTable.Name = "DisplaysTable";
            this.DisplaysTable.RowHeadersWidth = 62;
            this.DisplaysTable.RowTemplate.Height = 28;
            this.DisplaysTable.Size = new System.Drawing.Size(1187, 255);
            this.DisplaysTable.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simple";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 24);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Variable product";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Chk
            // 
            this.Chk.FormattingEnabled = true;
            this.Chk.Items.AddRange(new object[] {
            "Is regular",
            "Is working",
            "Is playing"});
            this.Chk.Location = new System.Drawing.Point(684, 162);
            this.Chk.Name = "Chk";
            this.Chk.Size = new System.Drawing.Size(164, 96);
            this.Chk.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "l7";
            // 
            // O
            // 
            this.O.ContainerControl = this;
            // 
            // N
            // 
            this.N.ContainerControl = this;
            // 
            // P
            // 
            this.P.ContainerControl = this;
            // 
            // I
            // 
            this.I.ContainerControl = this;
            // 
            // C
            // 
            this.C.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(684, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Chk);
            this.Controls.Add(this.DisplaysTable);
            this.Controls.Add(this.isavalaible);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.objectname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplaysTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox objectname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox isavalaible;
        private System.Windows.Forms.DataGridView DisplaysTable;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckedListBox Chk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider O;
        private System.Windows.Forms.ErrorProvider N;
        private System.Windows.Forms.ErrorProvider P;
        private System.Windows.Forms.ErrorProvider I;
        private System.Windows.Forms.ErrorProvider C;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}