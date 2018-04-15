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
        public int Recipe_ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Ingredients { get; set; }

        [Required]
        public string Description { get; set; }

        public string PictureURL { get; set; }

        public virtual IngredientsSet IngredientsSet { get; set; }
    }
}
