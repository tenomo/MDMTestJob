namespace MDMTestJob
{
    partial class OrderEditForm
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
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lable4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DueTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProcessedTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(87, 11);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(270, 21);
            this.customersComboBox.TabIndex = 0;
            this.customersComboBox.Text = "Select";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumberTextBox.Location = new System.Drawing.Point(87, 34);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(270, 20);
            this.NumberTextBox.TabIndex = 7;
            this.NumberTextBox.Text = "Input number";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmountTextBox.Location = new System.Drawing.Point(87, 60);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(270, 20);
            this.AmountTextBox.TabIndex = 8;
            this.AmountTextBox.Text = "input amount";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProcessedTimeDatePicker);
            this.panel1.Controls.Add(this.DueTimeDatePicker);
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NumberTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customersComboBox);
            this.panel1.Controls.Add(this.Lable4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 284);
            this.panel1.TabIndex = 13;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(87, 138);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(270, 115);
            this.DescriptionTextBox.TabIndex = 16;
            this.DescriptionTextBox.Text = "input description";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Processed time";
            // 
            // Lable4
            // 
            this.Lable4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lable4.AutoSize = true;
            this.Lable4.Location = new System.Drawing.Point(3, 89);
            this.Lable4.Name = "Lable4";
            this.Lable4.Size = new System.Drawing.Size(52, 13);
            this.Lable4.TabIndex = 15;
            this.Lable4.Text = "Due time ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(312, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(12, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.DueTimeDatePicker.Location = new System.Drawing.Point(87, 89);
            this.DueTimeDatePicker.Name = "dateTimePicker1";
            this.DueTimeDatePicker.Size = new System.Drawing.Size(270, 20);
            this.DueTimeDatePicker.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.ProcessedTimeDatePicker.Location = new System.Drawing.Point(87, 115);
            this.ProcessedTimeDatePicker.Name = "dateTimePicker2";
            this.ProcessedTimeDatePicker.Size = new System.Drawing.Size(270, 20);
            this.ProcessedTimeDatePicker.TabIndex = 18;
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrderEditForm";
            this.Text = "Order editor";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lable4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.DateTimePicker ProcessedTimeDatePicker;
        private System.Windows.Forms.DateTimePicker DueTimeDatePicker;
    }
}