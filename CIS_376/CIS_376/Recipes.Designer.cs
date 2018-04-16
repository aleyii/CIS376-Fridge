namespace CIS_376
{
    partial class Recipes
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
            this.Recipe = new System.Windows.Forms.Label();
            this.Ingedients = new System.Windows.Forms.Label();
            this.Directions = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recipe
            // 
            this.Recipe.AutoSize = true;
            this.Recipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipe.Location = new System.Drawing.Point(35, 34);
            this.Recipe.Name = "Recipe";
            this.Recipe.Size = new System.Drawing.Size(82, 25);
            this.Recipe.TabIndex = 1;
            this.Recipe.Text = "Recipes";
            // 
            // Ingedients
            // 
            this.Ingedients.Location = new System.Drawing.Point(391, 70);
            this.Ingedients.Name = "Ingedients";
            this.Ingedients.Size = new System.Drawing.Size(291, 157);
            this.Ingedients.TabIndex = 7;
            this.Ingedients.Text = "Ingredients:";
            // 
            // Directions
            // 
            this.Directions.Location = new System.Drawing.Point(391, 271);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(291, 157);
            this.Directions.TabIndex = 8;
            this.Directions.Text = "Directions:";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(617, 34);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click_1);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(40, 372);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(98, 23);
            this.previousButton.TabIndex = 11;
            this.previousButton.Text = "Previous Recipe";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click_1);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(268, 372);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(98, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next Recipe";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 245);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.Ingedients);
            this.Controls.Add(this.Recipe);
            this.Name = "Recipes";
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recipe;
        private System.Windows.Forms.Label Ingedients;
        private System.Windows.Forms.Label Directions;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
    }
}