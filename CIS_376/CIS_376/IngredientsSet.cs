namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IngredientsSet")]
    public partial class IngredientsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IngredientsSet()
        {
            Recipes = new HashSet<Recipe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Set_ID { get; set; }

        public int Ingredient1 { get; set; }

        public int Ingredient2 { get; set; }

        public int Ingredient3 { get; set; }

        public int Ingredient4 { get; set; }

        public int Ingredient5 { get; set; }

        public virtual Food Food { get; set; }

        public virtual Food Food1 { get; set; }

        public virtual Food Food2 { get; set; }

        public virtual Food Food3 { get; set; }

        public virtual Food Food4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
