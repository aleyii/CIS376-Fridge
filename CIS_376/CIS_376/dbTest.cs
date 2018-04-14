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
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Shelf> Shelves { get; set; }

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
                .HasOptional(e => e.Recipe)
                .WithRequired(e => e.Food);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
