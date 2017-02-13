namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App")]
    public partial class App
    {
        public Guid AppID { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Code { get; set; }

        [StringLength(256)]
        public string WebUrl { get; set; }

        [StringLength(256)]
        public string MobileUrl { get; set; }

        [StringLength(256)]
        public string ContactEmail { get; set; }

        [StringLength(150)]
        public string IPAddress { get; set; }

        public bool IsActive { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        public bool? IsTwoFactor { get; set; }

        public string SecretKey { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(128)]
        public string UpdatedBy { get; set; }
    }
}
