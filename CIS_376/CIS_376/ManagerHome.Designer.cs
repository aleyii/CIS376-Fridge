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
            this.HomePageLabel = new System.Windows.Forms.Label();
            this.FridgeLayoutButton = new System.Windows.Forms.Button();
            this.ViewInventoryButton = new System.Windows.Forms.Button();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomePageLabel
            // 
            this.HomePageLabel.AutoSize = true;
            this.HomePageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLabel.Location = new System.Drawing.Point(313, 55);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(165, 31);
            this.HomePageLabel.TabIndex = 0;
            this.HomePageLabel.Text = "Fridge Menu";
            // 
            // FridgeLayoutButton
            // 
            this.FridgeLayoutButton.Location = new System.Drawing.Point(172, 286);
            this.FridgeLayoutButton.Name = "FridgeLayoutButton";
            this.FridgeLayoutButton.Size = new System.Drawing.Size(138, 46);
            this.FridgeLayoutButton.TabIndex = 1;
            this.FridgeLayoutButton.Text = "View Fridge Layout";
            this.FridgeLayoutButton.UseVisualStyleBackColor = true;
            this.FridgeLayoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewInventoryButton
            // 
            this.ViewInventoryButton.Location = new System.Drawing.Point(319, 180);
            this.ViewInventoryButton.Name = "ViewInventoryButton";
            this.ViewInventoryButton.Size = new System.Drawing.Size(138, 46);
            this.ViewInventoryButton.TabIndex = 6;
            this.ViewInventoryButton.Text = "View Fridge Inventory";
            this.ViewInventoryButton.UseVisualStyleBackColor = true;
            this.ViewInventoryButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // RecipeButton
            // 
            this.RecipeButton.Location = new System.Drawing.Point(469, 286);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(138, 46);
            this.RecipeButton.TabIndex = 7;
            this.RecipeButton.Text = "View Recipes";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.RecipeButton_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecipeButton);
            this.Controls.Add(this.ViewInventoryButton);
            this.Controls.Add(this.FridgeLayoutButton);
            this.Controls.Add(this.HomePageLabel);
            this.Name = "ManagerHome";
            this.Text = "Fridge Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomePageLabel;
        private System.Windows.Forms.Button FridgeLayoutButton;
        private System.Windows.Forms.Button ViewInventoryButton;
        private System.Windows.Forms.Button RecipeButton;
    }
}

