namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceTypeSearch")]
    public partial class ServiceTypeSearch
    {
        public Guid ServiceTypeSearchID { get; set; }

        [StringLength(5)]
        public string SourceCountryCode { get; set; }

        [StringLength(100)]
        public string SourceCountryName { get; set; }

        [StringLength(5)]
        public string DestinationCountryCode { get; set; }

        [StringLength(100)]
        public string DestinationCountryName { get; set; }

        [StringLength(15)]
        public string ServiceCode { get; set; }

        [StringLength(100)]
        public string ServiceCodeDescription { get; set; }

        [StringLength(15)]
        public string TypeCode { get; set; }

        [StringLength(100)]
        public string TypeCodeDescription { get; set; }

        [Key]
        [StringLength(1024)]
        public string SearchCriteria { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(128)]
        public string UpdatedBy { get; set; }
    }
}
