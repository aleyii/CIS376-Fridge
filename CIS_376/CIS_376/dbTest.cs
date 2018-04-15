namespace CIS_376
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbTest : DbContext
    {
        public dbTest()
            : base("name=dbTest")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<IngredientsSet> IngredientsSets { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(e => e.Food_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.Food_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.Exp_Date)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.IngredientsSets)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.Ingredient1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.IngredientsSets1)
                .WithOptional(e => e.Food1)
                .HasForeignKey(e => e.Ingredient2);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.IngredientsSets2)
                .WithOptional(e => e.Food2)
                .HasForeignKey(e => e.Ingredient3);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.IngredientsSets3)
                .WithOptional(e => e.Food3)
                .HasForeignKey(e => e.Ingredient4);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.IngredientsSets4)
                .WithOptional(e => e.Food4)
                .HasForeignKey(e => e.Ingredient5);

            modelBuilder.Entity<IngredientsSet>()
                .HasMany(e => e.Recipes)
                .WithRequired(e => e.IngredientsSet)
                .HasForeignKey(e => e.Ingredients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.PictureURL)
                .IsUnicode(false);
        }
    }
}
