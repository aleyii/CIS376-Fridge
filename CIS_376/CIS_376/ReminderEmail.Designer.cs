namespace CIS_376
{
    partial class ReminderEmail
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
            this.TestButton = new System.Windows.Forms.Button();
            this.EmailAddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerifyEmail = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Food_Label = new System.Windows.Forms.Label();
            this.FoodBox = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(435, 311);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Send Email";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Visible = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // EmailAddressBox
            // 
            this.EmailAddressBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressBox.Location = new System.Drawing.Point(167, 129);
            this.EmailAddressBox.Name = "EmailAddressBox";
            this.EmailAddressBox.Size = new System.Drawing.Size(249, 29);
            this.EmailAddressBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Reminder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter email address:\r\n";
            // 
            // VerifyEmail
            // 
            this.VerifyEmail.Location = new System.Drawing.Point(435, 132);
            this.VerifyEmail.Name = "VerifyEmail";
            this.VerifyEmail.Size = new System.Drawing.Size(75, 23);
            this.VerifyEmail.TabIndex = 4;
            this.VerifyEmail.Text = "Verify Email";
            this.VerifyEmail.UseVisualStyleBackColor = true;
            this.VerifyEmail.Click += new System.EventHandler(this.VerifyEmail_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(584, 60);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Food_Label
            // 
            this.Food_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Label.Location = new System.Drawing.Point(12, 250);
            this.Food_Label.Name = "Food_Label";
            this.Food_Label.Size = new System.Drawing.Size(133, 44);
            this.Food_Label.TabIndex = 6;
            this.Food_Label.Text = "Choose foods to add to the list:";
            this.Food_Label.Visible = false;
            // 
            // FoodBox
            // 
            this.FoodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBox.FormattingEnabled = true;
            this.FoodBox.Location = new System.Drawing.Point(16, 308);
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(121, 28);
            this.FoodBox.TabIndex = 7;
            this.FoodBox.Visible = false;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(143, 312);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(40, 21);
            this.Add_button.TabIndex = 8;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Visible = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(221, 308);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(195, 123);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // ReminderEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 454);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.FoodBox);
            this.Controls.Add(this.Food_Label);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.VerifyEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailAddressBox);
            this.Controls.Add(this.TestButton);
            this.Name = "ReminderEmail";
            this.Text = "ReminderEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox EmailAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VerifyEmail;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label Food_Label;
        private System.Windows.Forms.ComboBox FoodBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ListView listView1;
    }
}