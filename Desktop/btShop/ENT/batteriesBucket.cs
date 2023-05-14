namespace tuningAtelier.ENT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("batteriesBucket")]
    public partial class batteriesBucket
    {
        [Key]
        public int idBucket { get; set; }

        public int idOrder { get; set; }

        public int idBatteries { get; set; }

        public virtual menu menu { get; set; }

        public virtual order order { get; set; }
    }
}
