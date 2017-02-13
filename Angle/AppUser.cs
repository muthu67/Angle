namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppUser")]
    public partial class AppUser
    {
        [Key]
        [Column(Order = 0)]
        public Guid AppUserID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UserID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(128)]
        public string CreatedBy { get; set; }
    }
}
