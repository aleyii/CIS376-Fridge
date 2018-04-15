namespace CIS_376
{
    partial class Recipies
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
            this.Recipes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.Button();
            this.Directions = new System.Windows.Forms.Label();
            this.Ingedients = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recipes
            // 
            this.Recipes.AutoSize = true;
            this.Recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipes.Location = new System.Drawing.Point(41, 44);
            this.Recipes.Name = "Recipes";
            this.Recipes.Size = new System.Drawing.Size(82, 25);
            this.Recipes.TabIndex = 0;
            this.Recipes.Text = "Recipes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 204);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(619, 35);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Directions
            // 
            this.Directions.Location = new System.Drawing.Point(404, 252);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(291, 157);
            this.Directions.TabIndex = 5;
            this.Directions.Text = "Directions:";
            // 
            // Ingedients
            // 
            this.Ingedients.Location = new System.Drawing.Point(404, 72);
            this.Ingedients.Name = "Ingedients";
            this.Ingedients.Size = new System.Drawing.Size(291, 157);
            this.Ingedients.TabIndex = 6;
            this.Ingedients.Text = "Ingredients:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(249, 385);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(98, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next Recipe";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(46, 385);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(98, 23);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous Recipe";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // Recipies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.Ingedients);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Recipes);
            this.Name = "Recipies";
            this.Text = "Recipies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recipes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Directions;
        private System.Windows.Forms.Label Ingedients;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}