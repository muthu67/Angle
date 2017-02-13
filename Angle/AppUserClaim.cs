namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppUserClaim")]
    public partial class AppUserClaim
    {
        [Key]
        [Column(Order = 0)]
        public Guid AppUserClaimID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AppID { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(128)]
        public string CreatedBy { get; set; }
    }
}
