namespace Inventory
{
    partial class Form1
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
            this.Number = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Inventory_Number = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Inventory = new System.Windows.Forms.TextBox();
            this.Object_Name = new System.Windows.Forms.Label();
            this.txt_Object = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.txt_Add = new System.Windows.Forms.Button();
            this.txt_Cancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(41, 23);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(44, 13);
            this.Number.TabIndex = 0;
            this.Number.Text = "Number";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(166, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Inventory_Number
            // 
            this.Inventory_Number.AutoSize = true;
            this.Inventory_Number.Location = new System.Drawing.Point(377, 23);
            this.Inventory_Number.Name = "Inventory_Number";
            this.Inventory_Number.Size = new System.Drawing.Size(91, 13);
            this.Inventory_Number.TabIndex = 2;
            this.Inventory_Number.Text = "Inventory Number";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(44, 50);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(118, 20);
            this.txt_Number.TabIndex = 3;
            // 
            // txt_Inventory
            // 
            this.txt_Inventory.Location = new System.Drawing.Point(375, 50);
            this.txt_Inventory.Name = "txt_Inventory";
            this.txt_Inventory.Size = new System.Drawing.Size(198, 20);
            this.txt_Inventory.TabIndex = 5;
            // 
            // Object_Name
            // 
            this.Object_Name.AutoSize = true;
            this.Object_Name.Location = new System.Drawing.Point(41, 87);
            this.Object_Name.Name = "Object_Name";
            this.Object_Name.Size = new System.Drawing.Size(69, 13);
            this.Object_Name.TabIndex = 6;
            this.Object_Name.Text = "Object Name";
            // 
            // txt_Object
            // 
            this.txt_Object.Location = new System.Drawing.Point(44, 113);
            this.txt_Object.Name = "txt_Object";
            this.txt_Object.Size = new System.Drawing.Size(511, 20);
            this.txt_Object.TabIndex = 7;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(44, 191);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 20);
            this.txt_Count.TabIndex = 8;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(183, 191);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 9;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(41, 167);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 10;
            this.Count.Text = "Count";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(180, 167);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 11;
            this.Price.Text = "Price";
            // 
            // txt_Add
            // 
            this.txt_Add.Location = new System.Drawing.Point(44, 244);
            this.txt_Add.Name = "txt_Add";
            this.txt_Add.Size = new System.Drawing.Size(149, 27);
            this.txt_Add.TabIndex = 12;
            this.txt_Add.Text = "Add";
            this.txt_Add.UseVisualStyleBackColor = true;
            this.txt_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Cancel
            // 
            this.txt_Cancel.Location = new System.Drawing.Point(222, 244);
            this.txt_Cancel.Name = "txt_Cancel";
            this.txt_Cancel.Size = new System.Drawing.Size(147, 27);
            this.txt_Cancel.TabIndex = 13;
            this.txt_Cancel.Text = "Cancel";
            this.txt_Cancel.UseVisualStyleBackColor = true;
            this.txt_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(169, 50);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txt_Cancel);
            this.Controls.Add(this.txt_Add);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_Object);
            this.Controls.Add(this.Object_Name);
            this.Controls.Add(this.txt_Inventory);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.Inventory_Number);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Inventory_Number;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Inventory;
        private System.Windows.Forms.Label Object_Name;
        private System.Windows.Forms.TextBox txt_Object;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button txt_Add;
        private System.Windows.Forms.Button txt_Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

