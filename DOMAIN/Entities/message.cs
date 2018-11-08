namespace DOMAIN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("levio_map.message")]
    public partial class message
    {
        public int id { get; set; }

        public DateTime? create_date { get; set; }

        [Column("message")]
        [StringLength(255)]
        public string message1 { get; set; }

        public DateTime? modify_date { get; set; }

        [StringLength(255)]
        public string subject { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? conversation { get; set; }

        public virtual conversation conversation1 { get; set; }
    }
}
