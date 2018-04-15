namespace CIS_376
{
    partial class ManagerHome
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
            this.HomePageLabel = new System.Windows.Forms.Label();
            this.FridgeLayoutButton = new System.Windows.Forms.Button();
            this.ViewInventoryButton = new System.Windows.Forms.Button();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RecipeButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomePageLabel
            // 
            this.HomePageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLabel.Location = new System.Drawing.Point(269, 36);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(244, 75);
            this.HomePageLabel.TabIndex = 0;
            this.HomePageLabel.Text = "Facade Fridge Kitchen Assistant";
            this.HomePageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FridgeLayoutButton
            // 
            this.FridgeLayoutButton.Location = new System.Drawing.Point(72, 293);
            this.FridgeLayoutButton.Name = "FridgeLayoutButton";
            this.FridgeLayoutButton.Size = new System.Drawing.Size(138, 46);
            this.FridgeLayoutButton.TabIndex = 1;
            this.FridgeLayoutButton.Text = "View Fridge Layout";
            this.FridgeLayoutButton.UseVisualStyleBackColor = true;
            this.FridgeLayoutButton.Click += new System.EventHandler(this.FridgeLayoutButton_Click);
            // 
            // ViewInventoryButton
            // 
            this.ViewInventoryButton.Location = new System.Drawing.Point(72, 211);
            this.ViewInventoryButton.Name = "ViewInventoryButton";
            this.ViewInventoryButton.Size = new System.Drawing.Size(138, 46);
            this.ViewInventoryButton.TabIndex = 6;
            this.ViewInventoryButton.Text = "View Fridge Inventory";
            this.ViewInventoryButton.UseVisualStyleBackColor = true;
            this.ViewInventoryButton.Click += new System.EventHandler(this.ViewInventoryButton_Click);
            // 
            // RecipeButton
            // 
            this.RecipeButton.Location = new System.Drawing.Point(324, 211);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(138, 46);
            this.RecipeButton.TabIndex = 7;
            this.RecipeButton.Text = "Find Random Recipes";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.RecipeButton_Click);
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(596, 255);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(138, 46);
            this.EmailButton.TabIndex = 8;
            this.EmailButton.Text = "Send Email Reminder";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(690, 36);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 9;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fridge Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recipe Recommendations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email Reminder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RecipeButton2
            // 
            this.RecipeButton2.Location = new System.Drawing.Point(324, 293);
            this.RecipeButton2.Name = "RecipeButton2";
            this.RecipeButton2.Size = new System.Drawing.Size(138, 46);
            this.RecipeButton2.TabIndex = 13;
            this.RecipeButton2.Text = "Find Custom Recipe";
            this.RecipeButton2.UseVisualStyleBackColor = true;
            this.RecipeButton2.Click += new System.EventHandler(this.RecipeButton2_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.RecipeButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.RecipeButton);
            this.Controls.Add(this.ViewInventoryButton);
            this.Controls.Add(this.FridgeLayoutButton);
            this.Controls.Add(this.HomePageLabel);
            this.Name = "ManagerHome";
            this.Text = "Fridge Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HomePageLabel;
        private System.Windows.Forms.Button FridgeLayoutButton;
        private System.Windows.Forms.Button ViewInventoryButton;
        private System.Windows.Forms.Button RecipeButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button RecipeButton2;
    }
}

