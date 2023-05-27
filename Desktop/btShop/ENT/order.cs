namespace tuningAtelier.ENT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order")]
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            batteriesBucket = new HashSet<batteriesBucket>();
        }

        [Key]
        public int idOrder { get; set; }

        public int idUser { get; set; }

        public int? idShop { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public double? totalPrice { get; set; }

        public DateTime orderDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<batteriesBucket> batteriesBucket { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual statusOrder statusOrder { get; set; }

        public virtual user user { get; set; }
    }
}
