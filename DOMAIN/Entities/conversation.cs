namespace DOMAIN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("levio_map.conversation")]
    public partial class conversation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public conversation()
        {
            messages = new HashSet<message>();
        }

        public int id { get; set; }

        public DateTime? create_date { get; set; }

        public DateTime? modify_date { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        public int? from_user { get; set; }

        public int? to_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<message> messages { get; set; }
    }
}
