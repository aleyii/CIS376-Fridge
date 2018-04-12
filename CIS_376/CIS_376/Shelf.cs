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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shelf()
        {
            Layouts = new HashSet<Layout>();
            Layouts1 = new HashSet<Layout>();
            Layouts2 = new HashSet<Layout>();
        }

        [Key]
        public int Shelf_Id { get; set; }

        public int? Food1 { get; set; }

        public int? Food2 { get; set; }

        public int? Food3 { get; set; }

        public int? Food4 { get; set; }

        public int? Food5 { get; set; }

        public virtual Food Food { get; set; }

        public virtual Food Food11 { get; set; }

        public virtual Food Food12 { get; set; }

        public virtual Food Food13 { get; set; }

        public virtual Food Food14 { get; set; }

        public virtual Food Food15 { get; set; }

        public virtual Food Food16 { get; set; }

        public virtual Food Food17 { get; set; }

        public virtual Food Food18 { get; set; }

        public virtual Food Food19 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout> Layouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout> Layouts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout> Layouts2 { get; set; }
    }
}
