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

        public int? Food1 { get; set; }

        public int? Food2 { get; set; }

        public int? Food3 { get; set; }

        public int? Food4 { get; set; }

        public int? Food5 { get; set; }

        public virtual Food Food { get; set; }

        public virtual Food Food6 { get; set; }

        public virtual Food Food7 { get; set; }

        public virtual Food Food8 { get; set; }

        public virtual Food Food9 { get; set; }
    }
}
