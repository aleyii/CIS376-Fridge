namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shelf")]
    public partial class Shelf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shelf_Id { get; set; }

        public int? Shelf_Contents { get; set; }
    }
}
