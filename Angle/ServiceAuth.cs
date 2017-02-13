namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceAuth")]
    public partial class ServiceAuth
    {
        public int ServiceAuthID { get; set; }

        public int? ClientID { get; set; }

        [StringLength(100)]
        public string AccountName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(5)]
        public string Salt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextPasswordReset { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
    }
}
