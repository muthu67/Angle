namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APIUser")]
    public partial class APIUser
    {
        public Guid APIUserID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public string Password { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(128)]
        public string UpdatedBy { get; set; }
    }
}
