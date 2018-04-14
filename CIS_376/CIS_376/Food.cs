namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            IngredientsSets = new HashSet<IngredientsSet>();
            IngredientsSets1 = new HashSet<IngredientsSet>();
            IngredientsSets2 = new HashSet<IngredientsSet>();
            IngredientsSets3 = new HashSet<IngredientsSet>();
            IngredientsSets4 = new HashSet<IngredientsSet>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Food_ID { get; set; }

        [Required]
        public string Food_Name { get; set; }

        [Required]
        public string Food_Type { get; set; }

        [Required]
        [StringLength(10)]
        public string Exp_Date { get; set; }

        public int Quantity { get; set; }

        public int? Shelf_Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientsSet> IngredientsSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientsSet> IngredientsSets1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientsSet> IngredientsSets2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientsSet> IngredientsSets3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientsSet> IngredientsSets4 { get; set; }
    }
}
