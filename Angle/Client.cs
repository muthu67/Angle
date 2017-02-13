namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int ClientID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public int? MaxSizeLimitPerFile { get; set; }

        public int? MaxSizeBufferLimit { get; set; }

        public int? MaxSizeLimit { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
    }
}
