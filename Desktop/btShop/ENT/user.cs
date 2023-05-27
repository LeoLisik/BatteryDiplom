namespace tuningAtelier.ENT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            order = new HashSet<order>();
        }

        [Key]
        public int idUser { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string patronymic { get; set; }

        [Column(TypeName = "image")]
        public byte[] userPhoto { get; set; }

        [Required]
        [StringLength(50)]
        public string role { get; set; }

        [StringLength(50)]
        public string birthday { get; set; }

        [Required]
        [StringLength(50)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> order { get; set; }

        public virtual userGenders userGenders { get; set; }

        public virtual userRoles userRoles { get; set; }

        public virtual userStatus userStatus { get; set; }
    }
}
