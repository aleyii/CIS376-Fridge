namespace CIS_376
{
    partial class CustomRecipe
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
            this.FoodBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.listyView = new System.Windows.Forms.ListView();
            this.ReturnButton2 = new System.Windows.Forms.Button();
            this.jumpToRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodBox2
            // 
            this.FoodBox2.FormattingEnabled = true;
            this.FoodBox2.Location = new System.Drawing.Point(43, 175);
            this.FoodBox2.Name = "FoodBox2";
            this.FoodBox2.Size = new System.Drawing.Size(121, 21);
            this.FoodBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Recipe";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the ingredients you want to use in a recipe:\r\n";
            // 
            // AddButton2
            // 
            this.AddButton2.Location = new System.Drawing.Point(180, 175);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(42, 23);
            this.AddButton2.TabIndex = 3;
            this.AddButton2.Text = "Add";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // listyView
            // 
            this.listyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listyView.Location = new System.Drawing.Point(237, 175);
            this.listyView.Name = "listyView";
            this.listyView.Size = new System.Drawing.Size(173, 133);
            this.listyView.TabIndex = 4;
            this.listyView.UseCompatibleStateImageBehavior = false;
            // 
            // ReturnButton2
            // 
            this.ReturnButton2.Location = new System.Drawing.Point(411, 45);
            this.ReturnButton2.Name = "ReturnButton2";
            this.ReturnButton2.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton2.TabIndex = 6;
            this.ReturnButton2.Text = "Return";
            this.ReturnButton2.UseVisualStyleBackColor = true;
            this.ReturnButton2.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // jumpToRecipe
            // 
            this.jumpToRecipe.Location = new System.Drawing.Point(355, 342);
            this.jumpToRecipe.Name = "jumpToRecipe";
            this.jumpToRecipe.Size = new System.Drawing.Size(131, 36);
            this.jumpToRecipe.TabIndex = 7;
            this.jumpToRecipe.Text = "Find recipe with these ingredients";
            this.jumpToRecipe.UseVisualStyleBackColor = true;
            this.jumpToRecipe.Click += new System.EventHandler(this.jumpToRecipe_Click);
            // 
            // CustomRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.jumpToRecipe);
            this.Controls.Add(this.ReturnButton2);
            this.Controls.Add(this.listyView);
            this.Controls.Add(this.AddButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodBox2);
            this.Name = "CustomRecipe";
            this.Text = "CustomRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FoodBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.ListView listyView;
        private System.Windows.Forms.Button ReturnButton2;
        private System.Windows.Forms.Button jumpToRecipe;
    }
}