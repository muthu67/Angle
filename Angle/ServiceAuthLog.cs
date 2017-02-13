namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceAuthLog")]
    public partial class ServiceAuthLog
    {
        [Key]
        [Column(Order = 0)]
        public int ServiceAuthLogID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceAuthID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientID { get; set; }

        [StringLength(100)]
        public string AccountName { get; set; }

        public DateTime? AccessTime { get; set; }

        [StringLength(15)]
        public string IPAddress { get; set; }

        public string RequestHeader { get; set; }

        [StringLength(10)]
        public string WebMethodName { get; set; }

        public DateTime? ResponseTime { get; set; }

        public bool? ResponseStatus { get; set; }

        public string ErrorDescription { get; set; }
    }
}
