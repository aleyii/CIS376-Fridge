namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            Recipes = new HashSet<Recipe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ingredients_Id { get; set; }

        public int? Ingredients_1 { get; set; }

        public int? Ingredients_2 { get; set; }

        public int? Ingredients_3 { get; set; }

        public int? Ingredients_4 { get; set; }

        public int? Ingredients_5 { get; set; }

        public int? Ingredients_6 { get; set; }

        public int? Ingredients_7 { get; set; }

        public int? Ingredients_8 { get; set; }

        public int? Ingredients_9 { get; set; }

        public int? Ingredients_10 { get; set; }

        public virtual Food Food { get; set; }

        public virtual Food Food1 { get; set; }

        public virtual Food Food2 { get; set; }

        public virtual Food Food3 { get; set; }

        public virtual Food Food4 { get; set; }

        public virtual Food Food5 { get; set; }

        public virtual Food Food6 { get; set; }

        public virtual Food Food7 { get; set; }

        public virtual Food Food8 { get; set; }

        public virtual Food Food9 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
