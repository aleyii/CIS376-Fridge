namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recipe_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int Ingredients { get; set; }

        public virtual Food Food { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
