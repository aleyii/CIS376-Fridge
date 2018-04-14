namespace CIS_376
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.QuantBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpDateLabel = new System.Windows.Forms.Label();
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.ShelfLabel = new System.Windows.Forms.Label();
            this.ExpDateBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Food";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(660, 49);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(137, 101);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(162, 275);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(59, 108);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Food Name:";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(137, 134);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 2;
            // 
            // QuantBox
            // 
            this.QuantBox.Location = new System.Drawing.Point(137, 163);
            this.QuantBox.Name = "QuantBox";
            this.QuantBox.Size = new System.Drawing.Size(100, 20);
            this.QuantBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Food Type:";
            // 
            // ExpDateLabel
            // 
            this.ExpDateLabel.AutoSize = true;
            this.ExpDateLabel.Location = new System.Drawing.Point(42, 232);
            this.ExpDateLabel.Name = "ExpDateLabel";
            this.ExpDateLabel.Size = new System.Drawing.Size(82, 13);
            this.ExpDateLabel.TabIndex = 24;
            this.ExpDateLabel.Text = "Expiration Date:";
            // 
            // ShelfComboBox
            // 
            this.ShelfComboBox.FormattingEnabled = true;
            this.ShelfComboBox.Location = new System.Drawing.Point(137, 198);
            this.ShelfComboBox.Name = "ShelfComboBox";
            this.ShelfComboBox.Size = new System.Drawing.Size(100, 21);
            this.ShelfComboBox.TabIndex = 4;
            // 
            // ShelfLabel
            // 
            this.ShelfLabel.AutoSize = true;
            this.ShelfLabel.Location = new System.Drawing.Point(89, 201);
            this.ShelfLabel.Name = "ShelfLabel";
            this.ShelfLabel.Size = new System.Drawing.Size(34, 13);
            this.ShelfLabel.TabIndex = 26;
            this.ShelfLabel.Text = "Shelf:";
            // 
            // ExpDateBox
            // 
            this.ExpDateBox.Location = new System.Drawing.Point(137, 232);
            this.ExpDateBox.Name = "ExpDateBox";
            this.ExpDateBox.Size = new System.Drawing.Size(200, 20);
            this.ExpDateBox.TabIndex = 27;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExpDateBox);
            this.Controls.Add(this.ShelfLabel);
            this.Controls.Add(this.ShelfComboBox);
            this.Controls.Add(this.ExpDateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "Add Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox QuantBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ExpDateLabel;
        private System.Windows.Forms.ComboBox ShelfComboBox;
        private System.Windows.Forms.Label ShelfLabel;
        private System.Windows.Forms.DateTimePicker ExpDateBox;
    }
}