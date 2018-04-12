namespace CIS_376
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Layout")]
    public partial class Layout
    {
        public int Id { get; set; }

        public int Shelf1 { get; set; }

        public int Shelf2 { get; set; }

        public int Shelf3 { get; set; }

        public virtual Shelf Shelf { get; set; }

        public virtual Shelf Shelf4 { get; set; }

        public virtual Shelf Shelf5 { get; set; }
    }
}
