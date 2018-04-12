namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fridge")]
    public partial class Fridge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_ID { get; set; }

        public int Food_ID { get; set; }

        public int Quantity { get; set; }

        public virtual Food Food { get; set; }
    }
}
