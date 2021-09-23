
namespace CarSeller_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Cars = new System.Windows.Forms.ListBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Make = new System.Windows.Forms.TextBox();
            this.Make_label = new System.Windows.Forms.Label();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.Model_label = new System.Windows.Forms.Label();
            this.textBox_Color = new System.Windows.Forms.TextBox();
            this.Color_label = new System.Windows.Forms.Label();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.Km_label = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.Year_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Cars
            // 
            this.listBox_Cars.FormattingEnabled = true;
            this.listBox_Cars.ItemHeight = 20;
            this.listBox_Cars.Location = new System.Drawing.Point(12, 44);
            this.listBox_Cars.Name = "listBox_Cars";
            this.listBox_Cars.Size = new System.Drawing.Size(193, 244);
            this.listBox_Cars.TabIndex = 0;
            this.listBox_Cars.SelectedIndexChanged += new System.EventHandler(this.listBox_Cars_SelectedIndexChanged);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(211, 47);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(24, 20);
            this.ID_label.TabIndex = 1;
            this.ID_label.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(267, 44);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(125, 27);
            this.textBox_ID.TabIndex = 6;
            // 
            // textBox_Make
            // 
            this.textBox_Make.Location = new System.Drawing.Point(267, 77);
            this.textBox_Make.Name = "textBox_Make";
            this.textBox_Make.Size = new System.Drawing.Size(125, 27);
            this.textBox_Make.TabIndex = 8;
            // 
            // Make_label
            // 
            this.Make_label.AutoSize = true;
            this.Make_label.Location = new System.Drawing.Point(211, 80);
            this.Make_label.Name = "Make_label";
            this.Make_label.Size = new System.Drawing.Size(45, 20);
            this.Make_label.TabIndex = 7;
            this.Make_label.Text = "Make";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(267, 110);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(125, 27);
            this.textBox_Model.TabIndex = 10;
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Location = new System.Drawing.Point(211, 113);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(52, 20);
            this.Model_label.TabIndex = 9;
            this.Model_label.Text = "Model";
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(267, 143);
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.Size = new System.Drawing.Size(125, 27);
            this.textBox_Color.TabIndex = 12;
            // 
            // Color_label
            // 
            this.Color_label.AutoSize = true;
            this.Color_label.Location = new System.Drawing.Point(211, 146);
            this.Color_label.Name = "Color_label";
            this.Color_label.Size = new System.Drawing.Size(45, 20);
            this.Color_label.TabIndex = 11;
            this.Color_label.Text = "Color";
            // 
            // textBox_Km
            // 
            this.textBox_Km.Location = new System.Drawing.Point(267, 176);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.Size = new System.Drawing.Size(125, 27);
            this.textBox_Km.TabIndex = 14;
            // 
            // Km_label
            // 
            this.Km_label.AutoSize = true;
            this.Km_label.Location = new System.Drawing.Point(211, 179);
            this.Km_label.Name = "Km_label";
            this.Km_label.Size = new System.Drawing.Size(31, 20);
            this.Km_label.TabIndex = 13;
            this.Km_label.Text = "Km";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(267, 209);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(125, 27);
            this.textBox_Price.TabIndex = 16;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(211, 212);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(41, 20);
            this.Price_label.TabIndex = 15;
            this.Price_label.Text = "Price";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(267, 242);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(125, 27);
            this.textBox_Year.TabIndex = 18;
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.Location = new System.Drawing.Point(211, 245);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(37, 20);
            this.Year_label.TabIndex = 17;
            this.Year_label.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(212, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Car Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of Cars";
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Location = new System.Drawing.Point(413, 36);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(151, 28);
            this.comboBoxColors.TabIndex = 21;
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxColors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select color";
            // 
            // listBoxColors
            // 
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 20;
            this.listBoxColors.Location = new System.Drawing.Point(413, 77);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(150, 204);
            this.listBoxColors.TabIndex = 23;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(267, 275);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(267, 310);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(94, 29);
            this.buttonRemove.TabIndex = 31;
            this.buttonRemove.Text = "RemoveCar";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.Year_label);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.textBox_Km);
            this.Controls.Add(this.Km_label);
            this.Controls.Add(this.textBox_Color);
            this.Controls.Add(this.Color_label);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.Model_label);
            this.Controls.Add(this.textBox_Make);
            this.Controls.Add(this.Make_label);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.listBox_Cars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Cars;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Make;
        private System.Windows.Forms.Label Make_label;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.TextBox textBox_Color;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.TextBox textBox_Km;
        private System.Windows.Forms.Label Km_label;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
    }
}

