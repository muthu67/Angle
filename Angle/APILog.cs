namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APILog")]
    public partial class APILog
    {
        [Key]
        [Column(Order = 0)]
        public string APILogID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string APIUserID { get; set; }

        public string Request { get; set; }

        public DateTime? RequestTime { get; set; }

        public string Response { get; set; }

        public DateTime? ResponseTime { get; set; }
    }
}
