namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TravelClassMaster")]
    public partial class TravelClassMaster
    {
        [Key]
        [StringLength(5)]
        public string AirlineCode { get; set; }

        [StringLength(50)]
        public string Class { get; set; }
    }
}
