namespace DOMAIN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("levio_map.ressource")]
    public partial class ressource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ressource()
        {
            applications = new HashSet<application>();
            leaves = new HashSet<leave>();
            mandates = new HashSet<mandate>();
            ressource1 = new HashSet<ressource>();
            skills = new HashSet<skill>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool archived { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string token { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string contract_type { get; set; }

        [StringLength(255)]
        public string profile { get; set; }

        [StringLength(255)]
        public string sector { get; set; }

        [StringLength(255)]
        public string seniority { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        public int? assigned_id { get; set; }

        public int? project_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<application> applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leave> leaves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mandate> mandates { get; set; }

        public virtual project project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ressource> ressource1 { get; set; }

        public virtual ressource ressource2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skill> skills { get; set; }
    }
}
