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

        public virtual Recipe Recipe { get; set; }
    }
}
