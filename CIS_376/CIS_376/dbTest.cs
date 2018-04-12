namespace CIS_376
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbTest : DbContext
    {
        public dbTest()
            : base("name=FridgeDBEntity")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Fridge> Fridges { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
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
                .HasMany(e => e.Fridges)
                .WithRequired(e => e.Food)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients)
                .WithOptional(e => e.Food)
                .HasForeignKey(e => e.Ingredients_1);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients1)
                .WithOptional(e => e.Food1)
                .HasForeignKey(e => e.Ingredients_10);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients2)
                .WithOptional(e => e.Food2)
                .HasForeignKey(e => e.Ingredients_2);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients3)
                .WithOptional(e => e.Food3)
                .HasForeignKey(e => e.Ingredients_3);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients4)
                .WithOptional(e => e.Food4)
                .HasForeignKey(e => e.Ingredients_4);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients5)
                .WithOptional(e => e.Food5)
                .HasForeignKey(e => e.Ingredients_5);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients6)
                .WithOptional(e => e.Food6)
                .HasForeignKey(e => e.Ingredients_6);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients7)
                .WithOptional(e => e.Food7)
                .HasForeignKey(e => e.Ingredients_7);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients8)
                .WithOptional(e => e.Food8)
                .HasForeignKey(e => e.Ingredients_8);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Ingredients9)
                .WithOptional(e => e.Food9)
                .HasForeignKey(e => e.Ingredients_9);

            modelBuilder.Entity<Food>()
                .HasOptional(e => e.Recipe)
                .WithRequired(e => e.Food);

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.Recipes)
                .WithRequired(e => e.Ingredient)
                .HasForeignKey(e => e.Ingredients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
