namespace tuningAtelier.ENT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("menu")]
    public partial class menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public menu()
        {
            batteriesBucket = new HashSet<batteriesBucket>();
        }

        [Key]
        public int idBatteries { get; set; }

        [Required]
        [StringLength(50)]
        public string nameBatteries { get; set; }

        [Required]
        public string descriptionBatteries { get; set; }

        public double priceBatteries { get; set; }

        [Column(TypeName = "image")]
        public byte[] photoBatteries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<batteriesBucket> batteriesBucket { get; set; }
    }
}
